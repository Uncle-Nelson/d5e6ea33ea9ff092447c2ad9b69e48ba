using System;
using UnityEngine;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x0200033C RID: 828
	public class DraggableConstraint : MonoBehaviour
	{
		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06001287 RID: 4743 RVA: 0x00050E5E File Offset: 0x0004F05E
		private Vector3 RelativePos
		{
			get
			{
				if (!(this.Container != null))
				{
					return base.transform.localPosition;
				}
				return this.Container.InverseTransformPoint(base.transform.position);
			}
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x00050E90 File Offset: 0x0004F090
		private void Start()
		{
			this.draggable = base.GetComponent<Draggable>();
			if (this.ClampUpDirection)
			{
				this.joint = this.draggable.Rb.gameObject.AddComponent<ConfigurableJoint>();
				if (this.Anchor == null && this.Container != null)
				{
					this.Container.gameObject.AddComponent<Rigidbody>();
					this.Anchor = this.Container.gameObject.GetComponent<Rigidbody>();
					this.Anchor.isKinematic = true;
					this.Anchor.useGravity = false;
				}
				this.joint.connectedBody = this.Anchor;
				this.joint.zMotion = 0;
				this.joint.angularXMotion = 0;
				this.joint.angularYMotion = 0;
				this.joint.angularZMotion = 1;
			}
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x00050F6C File Offset: 0x0004F16C
		public void SetContainer(Transform container)
		{
			this.Container = container;
			this.startLocalPos = this.RelativePos;
			if (this.joint != null && this.Anchor == null && this.Container != null)
			{
				this.Anchor = this.Container.gameObject.AddComponent<Rigidbody>();
				this.Anchor.isKinematic = true;
				this.Anchor.useGravity = false;
				this.joint.connectedBody = this.Anchor;
			}
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x00050FF5 File Offset: 0x0004F1F5
		protected virtual void FixedUpdate()
		{
			if (this.AlignUpToContainerPlane)
			{
				this.AlignToContainerPlane();
			}
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x00051005 File Offset: 0x0004F205
		protected virtual void LateUpdate()
		{
			if (this.ProportionalZClamp)
			{
				this.ProportionalClamp();
			}
			if (this.ClampUpDirection)
			{
				this.ClampUpRot();
			}
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x00051024 File Offset: 0x0004F224
		private void ProportionalClamp()
		{
			if (this.Container == null)
			{
				return;
			}
			if (this.draggable == null)
			{
				return;
			}
			float num = Mathf.Clamp(Mathf.Abs(this.RelativePos.x) / this.startLocalPos.x, 0f, 1f);
			float num2 = Mathf.Abs(this.startLocalPos.z) * num;
			Vector3 vector = this.Container.InverseTransformPoint(this.draggable.originalHitPoint);
			vector.z = Mathf.Clamp(vector.z, -num2, num2);
			Vector3 originalHitPoint = this.Container.TransformPoint(vector);
			this.draggable.SetOriginalHitPoint(originalHitPoint);
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x000510D4 File Offset: 0x0004F2D4
		private void LockRotationX()
		{
			Vector3 eulerAngles = (base.transform.rotation * Quaternion.Inverse(this.Container.rotation)).eulerAngles;
			eulerAngles.x = 0f;
			base.transform.rotation = this.Container.rotation * Quaternion.Euler(eulerAngles);
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x00051138 File Offset: 0x0004F338
		private void LockRotationY()
		{
			Vector3 eulerAngles = (base.transform.rotation * Quaternion.Inverse(this.Container.rotation)).eulerAngles;
			eulerAngles.y = 0f;
			base.transform.rotation = this.Container.rotation * Quaternion.Euler(eulerAngles);
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x0005119C File Offset: 0x0004F39C
		private void AlignToContainerPlane()
		{
			Vector3 forward = this.Container.forward;
			Quaternion quaternion = Quaternion.LookRotation(forward, base.transform.up);
			Vector3 normalized = Vector3.ProjectOnPlane(base.transform.forward, forward).normalized;
			Quaternion.FromToRotation(base.transform.forward, normalized) * quaternion;
			base.transform.rotation = quaternion;
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x00051208 File Offset: 0x0004F408
		private void ClampUpRot()
		{
			if (this.joint == null)
			{
				Console.LogWarning("No joint found on DraggableConstraint, cannot clamp up rotation", null);
				return;
			}
			Vector3.Angle(this.draggable.transform.up, Vector3.up);
			SoftJointLimit angularZLimit = this.joint.angularZLimit;
			angularZLimit.limit = this.UpDirectionMaxDifference;
			this.joint.angularZLimit = angularZLimit;
		}

		// Token: 0x040011E3 RID: 4579
		public Transform Container;

		// Token: 0x040011E4 RID: 4580
		public Rigidbody Anchor;

		// Token: 0x040011E5 RID: 4581
		public bool ProportionalZClamp;

		// Token: 0x040011E6 RID: 4582
		public bool AlignUpToContainerPlane;

		// Token: 0x040011E7 RID: 4583
		[Header("Up Direction Clamping")]
		public bool ClampUpDirection;

		// Token: 0x040011E8 RID: 4584
		public float UpDirectionMaxDifference = 45f;

		// Token: 0x040011E9 RID: 4585
		private Vector3 startLocalPos;

		// Token: 0x040011EA RID: 4586
		private Draggable draggable;

		// Token: 0x040011EB RID: 4587
		private ConfigurableJoint joint;
	}
}
