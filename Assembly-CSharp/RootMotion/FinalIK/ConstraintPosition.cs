using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200002C RID: 44
	[Serializable]
	public class ConstraintPosition : Constraint
	{
		// Token: 0x06000167 RID: 359 RVA: 0x00008B79 File Offset: 0x00006D79
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
			this.transform.position = Vector3.Lerp(this.transform.position, this.position, this.weight);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00008BB9 File Offset: 0x00006DB9
		public ConstraintPosition()
		{
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00008BC1 File Offset: 0x00006DC1
		public ConstraintPosition(Transform transform)
		{
			this.transform = transform;
		}

		// Token: 0x040000F1 RID: 241
		public Vector3 position;
	}
}
