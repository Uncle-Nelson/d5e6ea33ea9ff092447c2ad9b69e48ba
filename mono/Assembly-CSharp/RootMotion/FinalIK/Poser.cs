using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200006A RID: 106
	public abstract class Poser : SolverManager
	{
		// Token: 0x06000468 RID: 1128
		public abstract void AutoMapping();

		// Token: 0x06000469 RID: 1129 RVA: 0x0001DC44 File Offset: 0x0001BE44
		public void UpdateManual()
		{
			this.UpdatePoser();
		}

		// Token: 0x0600046A RID: 1130
		protected abstract void InitiatePoser();

		// Token: 0x0600046B RID: 1131
		protected abstract void UpdatePoser();

		// Token: 0x0600046C RID: 1132
		protected abstract void FixPoserTransforms();

		// Token: 0x0600046D RID: 1133 RVA: 0x0001DC4C File Offset: 0x0001BE4C
		protected override void UpdateSolver()
		{
			if (!this.initiated)
			{
				this.InitiateSolver();
			}
			if (!this.initiated)
			{
				return;
			}
			this.UpdatePoser();
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x0001DC6B File Offset: 0x0001BE6B
		protected override void InitiateSolver()
		{
			if (this.initiated)
			{
				return;
			}
			this.InitiatePoser();
			this.initiated = true;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x0001DC83 File Offset: 0x0001BE83
		protected override void FixTransforms()
		{
			if (!this.initiated)
			{
				return;
			}
			this.FixPoserTransforms();
		}

		// Token: 0x04000350 RID: 848
		public Transform poseRoot;

		// Token: 0x04000351 RID: 849
		[Range(0f, 1f)]
		public float weight = 1f;

		// Token: 0x04000352 RID: 850
		[Range(0f, 1f)]
		public float localRotationWeight = 1f;

		// Token: 0x04000353 RID: 851
		[Range(0f, 1f)]
		public float localPositionWeight;

		// Token: 0x04000354 RID: 852
		private bool initiated;
	}
}
