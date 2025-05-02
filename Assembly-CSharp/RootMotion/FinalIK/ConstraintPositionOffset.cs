using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200002D RID: 45
	[Serializable]
	public class ConstraintPositionOffset : Constraint
	{
		// Token: 0x0600016A RID: 362 RVA: 0x00008BD0 File Offset: 0x00006DD0
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
				this.defaultLocalPosition = this.transform.localPosition;
				this.lastLocalPosition = this.transform.localPosition;
				this.initiated = true;
			}
			if (this.positionChanged)
			{
				this.defaultLocalPosition = this.transform.localPosition;
			}
			this.transform.localPosition = this.defaultLocalPosition;
			this.transform.position += this.offset * this.weight;
			this.lastLocalPosition = this.transform.localPosition;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00008C87 File Offset: 0x00006E87
		public ConstraintPositionOffset()
		{
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00008C8F File Offset: 0x00006E8F
		public ConstraintPositionOffset(Transform transform)
		{
			this.transform = transform;
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00008C9E File Offset: 0x00006E9E
		private bool positionChanged
		{
			get
			{
				return this.transform.localPosition != this.lastLocalPosition;
			}
		}

		// Token: 0x040000F2 RID: 242
		public Vector3 offset;

		// Token: 0x040000F3 RID: 243
		private Vector3 defaultLocalPosition;

		// Token: 0x040000F4 RID: 244
		private Vector3 lastLocalPosition;

		// Token: 0x040000F5 RID: 245
		private bool initiated;
	}
}
