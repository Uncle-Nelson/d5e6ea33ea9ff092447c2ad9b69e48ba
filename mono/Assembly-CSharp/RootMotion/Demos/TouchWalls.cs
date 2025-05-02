using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000AF RID: 175
	public class TouchWalls : MonoBehaviour
	{
		// Token: 0x060005D8 RID: 1496 RVA: 0x00027ACC File Offset: 0x00025CCC
		private void Start()
		{
			TouchWalls.EffectorLink[] array = this.effectorLinks;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Initiate(this.interactionSystem);
			}
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00027AFC File Offset: 0x00025CFC
		private void FixedUpdate()
		{
			for (int i = 0; i < this.effectorLinks.Length; i++)
			{
				this.effectorLinks[i].Update(this.interactionSystem);
			}
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00027B30 File Offset: 0x00025D30
		private void OnDestroy()
		{
			if (this.interactionSystem != null)
			{
				for (int i = 0; i < this.effectorLinks.Length; i++)
				{
					this.effectorLinks[i].Destroy(this.interactionSystem);
				}
			}
		}

		// Token: 0x04000507 RID: 1287
		public InteractionSystem interactionSystem;

		// Token: 0x04000508 RID: 1288
		public TouchWalls.EffectorLink[] effectorLinks;

		// Token: 0x02000126 RID: 294
		[Serializable]
		public class EffectorLink
		{
			// Token: 0x06000830 RID: 2096 RVA: 0x000355E0 File Offset: 0x000337E0
			public void Initiate(InteractionSystem interactionSystem)
			{
				this.raycastDirectionLocal = this.spherecastFrom.InverseTransformDirection(this.interactionObject.transform.position - this.spherecastFrom.position);
				this.raycastDistance = Vector3.Distance(this.spherecastFrom.position, this.interactionObject.transform.position);
				interactionSystem.OnInteractionStart = (InteractionSystem.InteractionDelegate)Delegate.Combine(interactionSystem.OnInteractionStart, new InteractionSystem.InteractionDelegate(this.OnInteractionStart));
				interactionSystem.OnInteractionResume = (InteractionSystem.InteractionDelegate)Delegate.Combine(interactionSystem.OnInteractionResume, new InteractionSystem.InteractionDelegate(this.OnInteractionResume));
				interactionSystem.OnInteractionStop = (InteractionSystem.InteractionDelegate)Delegate.Combine(interactionSystem.OnInteractionStop, new InteractionSystem.InteractionDelegate(this.OnInteractionStop));
				this.hit.normal = Vector3.forward;
				this.targetPosition = this.interactionObject.transform.position;
				this.targetRotation = this.interactionObject.transform.rotation;
				this.initiated = true;
			}

			// Token: 0x06000831 RID: 2097 RVA: 0x000356F0 File Offset: 0x000338F0
			private bool FindWalls(Vector3 direction)
			{
				if (!this.enabled)
				{
					return false;
				}
				bool result = Physics.SphereCast(this.spherecastFrom.position, this.spherecastRadius, direction, out this.hit, this.raycastDistance * this.distanceMlp, this.touchLayers);
				if (this.hit.distance < this.minDistance)
				{
					result = false;
				}
				return result;
			}

			// Token: 0x06000832 RID: 2098 RVA: 0x00035754 File Offset: 0x00033954
			public void Update(InteractionSystem interactionSystem)
			{
				if (!this.initiated)
				{
					return;
				}
				Vector3 vector = this.spherecastFrom.TransformDirection(this.raycastDirectionLocal);
				this.hit.point = this.spherecastFrom.position + vector;
				bool flag = this.FindWalls(vector);
				if (!this.inTouch)
				{
					if (flag && Time.time > this.nextSwitchTime)
					{
						this.interactionObject.transform.parent = null;
						interactionSystem.StartInteraction(this.effectorType, this.interactionObject, true);
						this.nextSwitchTime = Time.time + this.minSwitchTime / interactionSystem.speed;
						this.targetPosition = this.hit.point;
						this.targetRotation = Quaternion.LookRotation(-this.hit.normal);
						this.interactionObject.transform.position = this.targetPosition;
						this.interactionObject.transform.rotation = this.targetRotation;
					}
				}
				else
				{
					if (!flag)
					{
						this.StopTouch(interactionSystem);
					}
					else if (!interactionSystem.IsPaused(this.effectorType) || this.sliding)
					{
						this.targetPosition = this.hit.point;
						this.targetRotation = Quaternion.LookRotation(-this.hit.normal);
					}
					if (Vector3.Distance(this.interactionObject.transform.position, this.hit.point) > this.releaseDistance)
					{
						if (flag)
						{
							this.targetPosition = this.hit.point;
							this.targetRotation = Quaternion.LookRotation(-this.hit.normal);
						}
						else
						{
							this.StopTouch(interactionSystem);
						}
					}
				}
				float b = (!this.inTouch || (interactionSystem.IsPaused(this.effectorType) && this.interactionObject.transform.position == this.targetPosition)) ? 0f : 1f;
				this.speedF = Mathf.Lerp(this.speedF, b, Time.deltaTime * 3f * interactionSystem.speed);
				float t = Time.deltaTime * this.lerpSpeed * this.speedF * interactionSystem.speed;
				this.interactionObject.transform.position = Vector3.Lerp(this.interactionObject.transform.position, this.targetPosition, t);
				this.interactionObject.transform.rotation = Quaternion.Slerp(this.interactionObject.transform.rotation, this.targetRotation, t);
			}

			// Token: 0x06000833 RID: 2099 RVA: 0x000359E4 File Offset: 0x00033BE4
			private void StopTouch(InteractionSystem interactionSystem)
			{
				this.interactionObject.transform.parent = interactionSystem.transform;
				this.nextSwitchTime = Time.time + this.minSwitchTime / interactionSystem.speed;
				if (interactionSystem.IsPaused(this.effectorType))
				{
					interactionSystem.ResumeInteraction(this.effectorType);
					return;
				}
				this.speedF = 0f;
				this.targetPosition = this.hit.point;
				if (this.hit.normal != Vector3.zero)
				{
					this.targetRotation = Quaternion.LookRotation(-this.hit.normal);
				}
			}

			// Token: 0x06000834 RID: 2100 RVA: 0x00035A8A File Offset: 0x00033C8A
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
				if (effectorType != this.effectorType || interactionObject != this.interactionObject)
				{
					return;
				}
				this.inTouch = true;
			}

			// Token: 0x06000835 RID: 2101 RVA: 0x00035AAB File Offset: 0x00033CAB
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
				if (effectorType != this.effectorType || interactionObject != this.interactionObject)
				{
					return;
				}
				this.inTouch = false;
			}

			// Token: 0x06000836 RID: 2102 RVA: 0x00035ACC File Offset: 0x00033CCC
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
				if (effectorType != this.effectorType || interactionObject != this.interactionObject)
				{
					return;
				}
				this.inTouch = false;
			}

			// Token: 0x06000837 RID: 2103 RVA: 0x00035AF0 File Offset: 0x00033CF0
			public void Destroy(InteractionSystem interactionSystem)
			{
				if (!this.initiated)
				{
					return;
				}
				interactionSystem.OnInteractionStart = (InteractionSystem.InteractionDelegate)Delegate.Remove(interactionSystem.OnInteractionStart, new InteractionSystem.InteractionDelegate(this.OnInteractionStart));
				interactionSystem.OnInteractionResume = (InteractionSystem.InteractionDelegate)Delegate.Remove(interactionSystem.OnInteractionResume, new InteractionSystem.InteractionDelegate(this.OnInteractionResume));
				interactionSystem.OnInteractionStop = (InteractionSystem.InteractionDelegate)Delegate.Remove(interactionSystem.OnInteractionStop, new InteractionSystem.InteractionDelegate(this.OnInteractionStop));
			}

			// Token: 0x0400086A RID: 2154
			public bool enabled = true;

			// Token: 0x0400086B RID: 2155
			public FullBodyBipedEffector effectorType;

			// Token: 0x0400086C RID: 2156
			public InteractionObject interactionObject;

			// Token: 0x0400086D RID: 2157
			public Transform spherecastFrom;

			// Token: 0x0400086E RID: 2158
			public float spherecastRadius = 0.1f;

			// Token: 0x0400086F RID: 2159
			public float minDistance = 0.3f;

			// Token: 0x04000870 RID: 2160
			public float distanceMlp = 1f;

			// Token: 0x04000871 RID: 2161
			public LayerMask touchLayers;

			// Token: 0x04000872 RID: 2162
			public float lerpSpeed = 10f;

			// Token: 0x04000873 RID: 2163
			public float minSwitchTime = 0.2f;

			// Token: 0x04000874 RID: 2164
			public float releaseDistance = 0.4f;

			// Token: 0x04000875 RID: 2165
			public bool sliding;

			// Token: 0x04000876 RID: 2166
			private Vector3 raycastDirectionLocal;

			// Token: 0x04000877 RID: 2167
			private float raycastDistance;

			// Token: 0x04000878 RID: 2168
			private bool inTouch;

			// Token: 0x04000879 RID: 2169
			private RaycastHit hit;

			// Token: 0x0400087A RID: 2170
			private Vector3 targetPosition;

			// Token: 0x0400087B RID: 2171
			private Quaternion targetRotation;

			// Token: 0x0400087C RID: 2172
			private bool initiated;

			// Token: 0x0400087D RID: 2173
			private float nextSwitchTime;

			// Token: 0x0400087E RID: 2174
			private float speedF;
		}
	}
}
