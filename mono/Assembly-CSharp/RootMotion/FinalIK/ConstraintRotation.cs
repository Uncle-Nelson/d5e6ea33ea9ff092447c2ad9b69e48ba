using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200002E RID: 46
	[Serializable]
	public class ConstraintRotation : Constraint
	{
		// Token: 0x0600016E RID: 366 RVA: 0x00008CB6 File Offset: 0x00006EB6
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
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, this.rotation, this.weight);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00008CF6 File Offset: 0x00006EF6
		public ConstraintRotation()
		{
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00008CFE File Offset: 0x00006EFE
		public ConstraintRotation(Transform transform)
		{
			this.transform = transform;
		}

		// Token: 0x040000F6 RID: 246
		public Quaternion rotation;
	}
}
