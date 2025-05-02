using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200002B RID: 43
	[Serializable]
	public abstract class Constraint
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00008B63 File Offset: 0x00006D63
		public bool isValid
		{
			get
			{
				return this.transform != null;
			}
		}

		// Token: 0x06000165 RID: 357
		public abstract void UpdateConstraint();

		// Token: 0x040000EF RID: 239
		public Transform transform;

		// Token: 0x040000F0 RID: 240
		public float weight;
	}
}
