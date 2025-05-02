using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000A8 RID: 168
	public abstract class PickUp2Handed : MonoBehaviour
	{
		// Token: 0x060005BA RID: 1466 RVA: 0x00027330 File Offset: 0x00025530
		private void OnGUI()
		{
			GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
			GUILayout.Space((float)this.GUIspace);
			if (!this.holding)
			{
				if (GUILayout.Button("Pick Up " + this.obj.name, Array.Empty<GUILayoutOption>()))
				{
					this.interactionSystem.StartInteraction(FullBodyBipedEffector.LeftHand, this.obj, false);
					this.interactionSystem.StartInteraction(FullBodyBipedEffector.RightHand, this.obj, false);
				}
			}
			else
			{
				GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
				if (this.holdingRight && GUILayout.Button("Release Right", Array.Empty<GUILayoutOption>()))
				{
					this.interactionSystem.ResumeInteraction(FullBodyBipedEffector.RightHand);
				}
				if (this.holdingLeft && GUILayout.Button("Release Left", Array.Empty<GUILayoutOption>()))
				{
					this.interactionSystem.ResumeInteraction(FullBodyBipedEffector.LeftHand);
				}
				if (GUILayout.Button("Drop " + this.obj.name, Array.Empty<GUILayoutOption>()))
				{
					this.interactionSystem.ResumeAll();
				}
				GUILayout.EndVertical();
			}
			GUILayout.EndHorizontal();
		}

		// Token: 0x060005BB RID: 1467
		protected abstract void RotatePivot();

		// Token: 0x060005BC RID: 1468 RVA: 0x00027438 File Offset: 0x00025638
		private void Start()
		{
			InteractionSystem interactionSystem = this.interactionSystem;
			interactionSystem.OnInteractionStart = (InteractionSystem.InteractionDelegate)Delegate.Combine(interactionSystem.OnInteractionStart, new InteractionSystem.InteractionDelegate(this.OnStart));
			InteractionSystem interactionSystem2 = this.interactionSystem;
			interactionSystem2.OnInteractionPause = (InteractionSystem.InteractionDelegate)Delegate.Combine(interactionSystem2.OnInteractionPause, new InteractionSystem.InteractionDelegate(this.OnPause));
			InteractionSystem interactionSystem3 = this.interactionSystem;
			interactionSystem3.OnInteractionResume = (InteractionSystem.InteractionDelegate)Delegate.Combine(interactionSystem3.OnInteractionResume, new InteractionSystem.InteractionDelegate(this.OnDrop));
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x000274BC File Offset: 0x000256BC
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
			if (effectorType != FullBodyBipedEffector.LeftHand)
			{
				return;
			}
			if (interactionObject != this.obj)
			{
				return;
			}
			this.obj.transform.parent = this.interactionSystem.transform;
			Rigidbody component = this.obj.GetComponent<Rigidbody>();
			if (component != null)
			{
				component.isKinematic = true;
			}
			this.pickUpPosition = this.obj.transform.position;
			this.pickUpRotation = this.obj.transform.rotation;
			this.holdWeight = 0f;
			this.holdWeightVel = 0f;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00027556 File Offset: 0x00025756
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
			if (effectorType != FullBodyBipedEffector.LeftHand)
			{
				return;
			}
			if (interactionObject != this.obj)
			{
				return;
			}
			this.holdPoint.rotation = this.obj.transform.rotation;
			this.RotatePivot();
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00027590 File Offset: 0x00025790
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
			if (this.holding)
			{
				return;
			}
			if (interactionObject != this.obj)
			{
				return;
			}
			this.obj.transform.parent = null;
			if (this.obj.GetComponent<Rigidbody>() != null)
			{
				this.obj.GetComponent<Rigidbody>().isKinematic = false;
			}
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x000275EC File Offset: 0x000257EC
		private void LateUpdate()
		{
			if (this.holding)
			{
				this.holdWeight = Mathf.SmoothDamp(this.holdWeight, 1f, ref this.holdWeightVel, this.pickUpTime);
				this.obj.transform.position = Vector3.Lerp(this.pickUpPosition, this.holdPoint.position, this.holdWeight);
				this.obj.transform.rotation = Quaternion.Lerp(this.pickUpRotation, this.holdPoint.rotation, this.holdWeight);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x0002767B File Offset: 0x0002587B
		private bool holding
		{
			get
			{
				return this.holdingLeft || this.holdingRight;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x0002768D File Offset: 0x0002588D
		private bool holdingLeft
		{
			get
			{
				return this.interactionSystem.IsPaused(FullBodyBipedEffector.LeftHand) && this.interactionSystem.GetInteractionObject(FullBodyBipedEffector.LeftHand) == this.obj;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x000276B6 File Offset: 0x000258B6
		private bool holdingRight
		{
			get
			{
				return this.interactionSystem.IsPaused(FullBodyBipedEffector.RightHand) && this.interactionSystem.GetInteractionObject(FullBodyBipedEffector.RightHand) == this.obj;
			}
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x000276E0 File Offset: 0x000258E0
		private void OnDestroy()
		{
			if (this.interactionSystem == null)
			{
				return;
			}
			InteractionSystem interactionSystem = this.interactionSystem;
			interactionSystem.OnInteractionStart = (InteractionSystem.InteractionDelegate)Delegate.Remove(interactionSystem.OnInteractionStart, new InteractionSystem.InteractionDelegate(this.OnStart));
			InteractionSystem interactionSystem2 = this.interactionSystem;
			interactionSystem2.OnInteractionPause = (InteractionSystem.InteractionDelegate)Delegate.Remove(interactionSystem2.OnInteractionPause, new InteractionSystem.InteractionDelegate(this.OnPause));
			InteractionSystem interactionSystem3 = this.interactionSystem;
			interactionSystem3.OnInteractionResume = (InteractionSystem.InteractionDelegate)Delegate.Remove(interactionSystem3.OnInteractionResume, new InteractionSystem.InteractionDelegate(this.OnDrop));
		}

		// Token: 0x040004F0 RID: 1264
		public int GUIspace;

		// Token: 0x040004F1 RID: 1265
		public InteractionSystem interactionSystem;

		// Token: 0x040004F2 RID: 1266
		public InteractionObject obj;

		// Token: 0x040004F3 RID: 1267
		public Transform pivot;

		// Token: 0x040004F4 RID: 1268
		public Transform holdPoint;

		// Token: 0x040004F5 RID: 1269
		public float pickUpTime = 0.3f;

		// Token: 0x040004F6 RID: 1270
		private float holdWeight;

		// Token: 0x040004F7 RID: 1271
		private float holdWeightVel;

		// Token: 0x040004F8 RID: 1272
		private Vector3 pickUpPosition;

		// Token: 0x040004F9 RID: 1273
		private Quaternion pickUpRotation;
	}
}
