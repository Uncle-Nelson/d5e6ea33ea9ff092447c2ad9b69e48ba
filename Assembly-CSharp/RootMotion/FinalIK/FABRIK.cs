using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200003C RID: 60
	[HelpURL("http://www.root-motion.com/finalikdox/html/page6.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK")]
	public class FABRIK : IK
	{
		// Token: 0x06000202 RID: 514 RVA: 0x0000C352 File Offset: 0x0000A552
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page6.html");
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000C35E File Offset: 0x0000A55E
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_f_a_b_r_i_k.html");
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000C36A File Offset: 0x0000A56A
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000C376 File Offset: 0x0000A576
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000C382 File Offset: 0x0000A582
		public override IKSolver GetIKSolver()
		{
			return this.solver;
		}

		// Token: 0x0400017B RID: 379
		public IKSolverFABRIK solver = new IKSolverFABRIK();
	}
}
