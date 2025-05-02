using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200002F RID: 47
	[Serializable]
	public class ConstraintRotationOffset : Constraint
	{
		// Token: 0x06000171 RID: 369 RVA: 0x00008D10 File Offset: 0x00006F10
		public override void UpdateConstraint()
		{
			if (this.weight <= 0f)
			{
				return;
			}
			if (!base.isValid)
			{
				return;
			}
			if (!this.initiated)
			{
				this.defaultLocalRotation = this.transform.localRotation;
				this.lastLocalRotation = this.transform.localRotation;
				this.initiated = true;
			}
			if (this.rotationChanged)
			{
				this.defaultLocalRotation = this.transform.localRotation;
			}
			this.transform.localRotation = this.defaultLocalRotation;
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, this.offset, this.weight);
			this.lastLocalRotation = this.transform.localRotation;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00008DC7 File Offset: 0x00006FC7
		public ConstraintRotationOffset()
		{
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00008DCF File Offset: 0x00006FCF
		public ConstraintRotationOffset(Transform transform)
		{
			this.transform = transform;
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00008DDE File Offset: 0x00006FDE
		private bool rotationChanged
		{
			get
			{
				return this.transform.localRotation != this.lastLocalRotation;
			}
		}

		// Token: 0x040000F7 RID: 247
		public Quaternion offset;

		// Token: 0x040000F8 RID: 248
		private Quaternion defaultRotation;

		// Token: 0x040000F9 RID: 249
		private Quaternion defaultLocalRotation;

		// Token: 0x040000FA RID: 250
		private Quaternion lastLocalRotation;

		// Token: 0x040000FB RID: 251
		private Quaternion defaultTargetLocalRotation;

		// Token: 0x040000FC RID: 252
		private bool initiated;
	}
}
