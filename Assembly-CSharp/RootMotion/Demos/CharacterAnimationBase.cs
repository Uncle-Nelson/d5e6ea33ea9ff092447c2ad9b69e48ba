using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000BE RID: 190
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		// Token: 0x06000609 RID: 1545 RVA: 0x00028C20 File Offset: 0x00026E20
		public virtual Vector3 GetPivotPoint()
		{
			return base.transform.position;
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x00028C2D File Offset: 0x00026E2D
		public virtual bool animationGrounded
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00028C30 File Offset: 0x00026E30
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			Vector3 vector = base.transform.InverseTransformDirection(worldDirection);
			return Mathf.Atan2(vector.x, vector.z) * 57.29578f;
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00028C64 File Offset: 0x00026E64
		protected virtual void Start()
		{
			if (base.transform.parent.GetComponent<CharacterBase>() == null)
			{
				Debug.LogWarning("Animation controllers should be parented to character controllers!", base.transform);
			}
			this.lastPosition = base.transform.position;
			this.localPosition = base.transform.localPosition;
			this.lastRotation = base.transform.rotation;
			this.localRotation = base.transform.localRotation;
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00028CDD File Offset: 0x00026EDD
		protected virtual void LateUpdate()
		{
			if (this.animatePhysics)
			{
				return;
			}
			this.SmoothFollow();
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00028CEE File Offset: 0x00026EEE
		protected virtual void FixedUpdate()
		{
			if (!this.animatePhysics)
			{
				return;
			}
			this.SmoothFollow();
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00028D00 File Offset: 0x00026F00
		private void SmoothFollow()
		{
			if (this.smoothFollow)
			{
				base.transform.position = Vector3.Lerp(this.lastPosition, base.transform.parent.TransformPoint(this.localPosition), Time.deltaTime * this.smoothFollowSpeed);
				base.transform.rotation = Quaternion.Lerp(this.lastRotation, base.transform.parent.rotation * this.localRotation, Time.deltaTime * this.smoothFollowSpeed);
			}
			else
			{
				base.transform.localPosition = this.localPosition;
				base.transform.localRotation = this.localRotation;
			}
			this.lastPosition = base.transform.position;
			this.lastRotation = base.transform.rotation;
		}

		// Token: 0x04000554 RID: 1364
		public bool smoothFollow = true;

		// Token: 0x04000555 RID: 1365
		public float smoothFollowSpeed = 20f;

		// Token: 0x04000556 RID: 1366
		protected bool animatePhysics;

		// Token: 0x04000557 RID: 1367
		private Vector3 lastPosition;

		// Token: 0x04000558 RID: 1368
		private Vector3 localPosition;

		// Token: 0x04000559 RID: 1369
		private Quaternion localRotation;

		// Token: 0x0400055A RID: 1370
		private Quaternion lastRotation;
	}
}
