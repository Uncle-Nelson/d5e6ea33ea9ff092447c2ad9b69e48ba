using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000042 RID: 66
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Limb IK")]
	public class LimbIK : IK
	{
		// Token: 0x0600022F RID: 559 RVA: 0x0000C870 File Offset: 0x0000AA70
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page12.html");
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0000C87C File Offset: 0x0000AA7C
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_limb_i_k.html");
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000C888 File Offset: 0x0000AA88
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000C894 File Offset: 0x0000AA94
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000C8A0 File Offset: 0x0000AAA0
		public override IKSolver GetIKSolver()
		{
			return this.solver;
		}

		// Token: 0x04000183 RID: 387
		public IKSolverLimb solver = new IKSolverLimb();
	}
}
