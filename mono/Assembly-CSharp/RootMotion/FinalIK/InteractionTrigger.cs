using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000067 RID: 103
	[HelpURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Trigger")]
	public class InteractionTrigger : MonoBehaviour
	{
		// Token: 0x06000454 RID: 1108 RVA: 0x0001D76D File Offset: 0x0001B96D
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page10.html");
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0001D779 File Offset: 0x0001B979
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_interaction_trigger.html");
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x0001D785 File Offset: 0x0001B985
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial4()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6");
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0001D791 File Offset: 0x0001B991
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0001D79D File Offset: 0x0001B99D
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0001D7AC File Offset: 0x0001B9AC
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			if (base.GetComponent<Collider>() == null)
			{
				Warning.Log("Using the InteractionTrigger requires a Collider component.", base.transform, false);
				return -1;
			}
			int result = -1;
			float num = 180f;
			float num2 = 0f;
			for (int i = 0; i < this.ranges.Length; i++)
			{
				if (this.ranges[i].IsInRange(character, raycastFrom, raycastHit, base.transform, out num2) && num2 <= num)
				{
					num = num2;
					result = i;
				}
			}
			return result;
		}

		// Token: 0x04000349 RID: 841
		[Tooltip("The valid ranges of the character's and/or its camera's position for triggering interaction when the character is in contact with the collider of this trigger.")]
		public InteractionTrigger.Range[] ranges = new InteractionTrigger.Range[0];

		// Token: 0x020000FF RID: 255
		[Serializable]
		public class CharacterPosition
		{
			// Token: 0x170000BC RID: 188
			// (get) Token: 0x06000799 RID: 1945 RVA: 0x00032D1B File Offset: 0x00030F1B
			public Vector3 offset3D
			{
				get
				{
					return new Vector3(this.offset.x, 0f, this.offset.y);
				}
			}

			// Token: 0x170000BD RID: 189
			// (get) Token: 0x0600079A RID: 1946 RVA: 0x00032D3D File Offset: 0x00030F3D
			public Vector3 direction3D
			{
				get
				{
					return Quaternion.AngleAxis(this.angleOffset, Vector3.up) * Vector3.forward;
				}
			}

			// Token: 0x0600079B RID: 1947 RVA: 0x00032D5C File Offset: 0x00030F5C
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				error = 0f;
				if (!this.use)
				{
					return true;
				}
				error = 180f;
				if (this.radius <= 0f)
				{
					return false;
				}
				if (this.maxAngle <= 0f)
				{
					return false;
				}
				Vector3 forward = trigger.forward;
				if (this.fixYAxis)
				{
					forward.y = 0f;
				}
				if (forward == Vector3.zero)
				{
					return false;
				}
				Vector3 vector = this.fixYAxis ? Vector3.up : trigger.up;
				Quaternion rotation = Quaternion.LookRotation(forward, vector);
				Vector3 vector2 = trigger.position + rotation * this.offset3D;
				Vector3 b = this.orbit ? trigger.position : vector2;
				Vector3 vector3 = character.position - b;
				Vector3.OrthoNormalize(ref vector, ref vector3);
				vector3 *= Vector3.Project(character.position - b, vector3).magnitude;
				if (this.orbit)
				{
					float magnitude = this.offset.magnitude;
					float magnitude2 = vector3.magnitude;
					if (magnitude2 < magnitude - this.radius || magnitude2 > magnitude + this.radius)
					{
						return false;
					}
				}
				else if (vector3.magnitude > this.radius)
				{
					return false;
				}
				Vector3 vector4 = rotation * this.direction3D;
				Vector3.OrthoNormalize(ref vector, ref vector4);
				if (this.orbit)
				{
					Vector3 vector5 = vector2 - trigger.position;
					if (vector5 == Vector3.zero)
					{
						vector5 = Vector3.forward;
					}
					vector3 = Quaternion.Inverse(Quaternion.LookRotation(vector5, vector)) * vector3;
					vector4 = Quaternion.AngleAxis(Mathf.Atan2(vector3.x, vector3.z) * 57.29578f, vector) * vector4;
				}
				float num = Vector3.Angle(vector4, character.forward);
				if (num > this.maxAngle)
				{
					return false;
				}
				error = num / this.maxAngle * 180f;
				return true;
			}

			// Token: 0x0400078D RID: 1933
			[Tooltip("If false, will not care where the character stands, as long as it is in contact with the trigger collider.")]
			public bool use;

			// Token: 0x0400078E RID: 1934
			[Tooltip("The offset of the character's position relative to the trigger in XZ plane. Y position of the character is unlimited as long as it is contact with the collider.")]
			public Vector2 offset;

			// Token: 0x0400078F RID: 1935
			[Tooltip("Angle offset from the default forward direction.")]
			[Range(-180f, 180f)]
			public float angleOffset;

			// Token: 0x04000790 RID: 1936
			[Tooltip("Max angular offset of the character's forward from the direction of this trigger.")]
			[Range(0f, 180f)]
			public float maxAngle = 45f;

			// Token: 0x04000791 RID: 1937
			[Tooltip("Max offset of the character's position from this range's center.")]
			public float radius = 0.5f;

			// Token: 0x04000792 RID: 1938
			[Tooltip("If true, will rotate the trigger around its Y axis relative to the position of the character, so the object can be interacted with from all sides.")]
			public bool orbit;

			// Token: 0x04000793 RID: 1939
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object. For example a gun will be able to be picked up from the same direction relative to the barrel no matter which side the gun is resting on.")]
			public bool fixYAxis;
		}

		// Token: 0x02000100 RID: 256
		[Serializable]
		public class CameraPosition
		{
			// Token: 0x0600079D RID: 1949 RVA: 0x00032F68 File Offset: 0x00031168
			public Quaternion GetRotation()
			{
				Vector3 forward = this.lookAtTarget.transform.forward;
				if (this.fixYAxis)
				{
					forward.y = 0f;
				}
				if (forward == Vector3.zero)
				{
					return Quaternion.identity;
				}
				Vector3 upwards = this.fixYAxis ? Vector3.up : this.lookAtTarget.transform.up;
				return Quaternion.LookRotation(forward, upwards);
			}

			// Token: 0x0600079E RID: 1950 RVA: 0x00032FD4 File Offset: 0x000311D4
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				error = 0f;
				if (this.lookAtTarget == null)
				{
					return true;
				}
				error = 180f;
				if (raycastFrom == null)
				{
					return false;
				}
				if (hit.collider != this.lookAtTarget)
				{
					return false;
				}
				if (hit.distance > this.maxDistance)
				{
					return false;
				}
				if (this.direction == Vector3.zero)
				{
					return false;
				}
				if (this.maxDistance <= 0f)
				{
					return false;
				}
				if (this.maxAngle <= 0f)
				{
					return false;
				}
				Vector3 to = this.GetRotation() * this.direction;
				float num = Vector3.Angle(raycastFrom.position - hit.point, to);
				if (num > this.maxAngle)
				{
					return false;
				}
				error = num / this.maxAngle * 180f;
				return true;
			}

			// Token: 0x04000794 RID: 1940
			[Tooltip("What the camera should be looking at to trigger the interaction? If null, this camera position will not be used.")]
			public Collider lookAtTarget;

			// Token: 0x04000795 RID: 1941
			[Tooltip("The direction from the lookAtTarget towards the camera (in lookAtTarget's space).")]
			public Vector3 direction = -Vector3.forward;

			// Token: 0x04000796 RID: 1942
			[Tooltip("Max distance from the lookAtTarget to the camera.")]
			public float maxDistance = 0.5f;

			// Token: 0x04000797 RID: 1943
			[Tooltip("Max angle between the direction and the direction towards the camera.")]
			[Range(0f, 180f)]
			public float maxAngle = 45f;

			// Token: 0x04000798 RID: 1944
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object.")]
			public bool fixYAxis;
		}

		// Token: 0x02000101 RID: 257
		[Serializable]
		public class Range
		{
			// Token: 0x060007A0 RID: 1952 RVA: 0x000330DC File Offset: 0x000312DC
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				maxError = 0f;
				float a = 0f;
				float b = 0f;
				if (!this.characterPosition.IsInRange(character, trigger, out a))
				{
					return false;
				}
				if (!this.cameraPosition.IsInRange(raycastFrom, raycastHit, trigger, out b))
				{
					return false;
				}
				maxError = Mathf.Max(a, b);
				return true;
			}

			// Token: 0x04000799 RID: 1945
			[HideInInspector]
			public string name;

			// Token: 0x0400079A RID: 1946
			[HideInInspector]
			public bool show = true;

			// Token: 0x0400079B RID: 1947
			[Tooltip("The range for the character's position and rotation.")]
			public InteractionTrigger.CharacterPosition characterPosition;

			// Token: 0x0400079C RID: 1948
			[Tooltip("The range for the character camera's position and rotation.")]
			public InteractionTrigger.CameraPosition cameraPosition;

			// Token: 0x0400079D RID: 1949
			[Tooltip("Definitions of the interactions associated with this range.")]
			public InteractionTrigger.Range.Interaction[] interactions;

			// Token: 0x02000139 RID: 313
			[Serializable]
			public class Interaction
			{
				// Token: 0x040008C0 RID: 2240
				[Tooltip("The InteractionObject to interact with.")]
				public InteractionObject interactionObject;

				// Token: 0x040008C1 RID: 2241
				[Tooltip("The effectors to interact with.")]
				public FullBodyBipedEffector[] effectors;
			}
		}
	}
}
