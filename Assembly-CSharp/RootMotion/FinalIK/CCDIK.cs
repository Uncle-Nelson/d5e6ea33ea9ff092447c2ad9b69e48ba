using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200003B RID: 59
	[HelpURL("http://www.root-motion.com/finalikdox/html/page5.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/CCD IK")]
	public class CCDIK : IK
	{
		// Token: 0x060001FC RID: 508 RVA: 0x0000C307 File Offset: 0x0000A507
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page5.html");
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000C313 File Offset: 0x0000A513
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_c_c_d_i_k.html");
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000C31F File Offset: 0x0000A51F
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000C32B File Offset: 0x0000A52B
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000C337 File Offset: 0x0000A537
		public override IKSolver GetIKSolver()
		{
			return this.solver;
		}

		// Token: 0x0400017A RID: 378
		public IKSolverCCD solver = new IKSolverCCD();
	}
}
