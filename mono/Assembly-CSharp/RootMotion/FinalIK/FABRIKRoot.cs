using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200003D RID: 61
	[HelpURL("http://www.root-motion.com/finalikdox/html/page7.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK Root")]
	public class FABRIKRoot : IK
	{
		// Token: 0x06000208 RID: 520 RVA: 0x0000C39D File Offset: 0x0000A59D
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page7.html");
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000C3A9 File Offset: 0x0000A5A9
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_f_a_b_r_i_k_root.html");
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000C3B5 File Offset: 0x0000A5B5
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0000C3C1 File Offset: 0x0000A5C1
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000C3CD File Offset: 0x0000A5CD
		public override IKSolver GetIKSolver()
		{
			return this.solver;
		}

		// Token: 0x0400017C RID: 380
		public IKSolverFABRIKRoot solver = new IKSolverFABRIKRoot();
	}
}
