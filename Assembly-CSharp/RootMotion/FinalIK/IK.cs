using System;

namespace RootMotion.FinalIK
{
	// Token: 0x0200003F RID: 63
	public abstract class IK : SolverManager
	{
		// Token: 0x0600021B RID: 539
		public abstract IKSolver GetIKSolver();

		// Token: 0x0600021C RID: 540 RVA: 0x0000C6A5 File Offset: 0x0000A8A5
		protected override void UpdateSolver()
		{
			if (!this.GetIKSolver().initiated)
			{
				this.InitiateSolver();
			}
			if (!this.GetIKSolver().initiated)
			{
				return;
			}
			this.GetIKSolver().Update();
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000C6D3 File Offset: 0x0000A8D3
		protected override void InitiateSolver()
		{
			if (this.GetIKSolver().initiated)
			{
				return;
			}
			this.GetIKSolver().Initiate(base.transform);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000C6F4 File Offset: 0x0000A8F4
		protected override void FixTransforms()
		{
			if (!this.GetIKSolver().initiated)
			{
				return;
			}
			this.GetIKSolver().FixTransforms();
		}

		// Token: 0x0600021F RID: 543
		protected abstract void OpenUserManual();

		// Token: 0x06000220 RID: 544
		protected abstract void OpenScriptReference();
	}
}
