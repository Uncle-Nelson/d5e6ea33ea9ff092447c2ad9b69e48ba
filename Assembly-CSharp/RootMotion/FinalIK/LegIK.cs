using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000041 RID: 65
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Leg IK")]
	public class LegIK : IK
	{
		// Token: 0x06000229 RID: 553 RVA: 0x0000C825 File Offset: 0x0000AA25
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page11.html");
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000C831 File Offset: 0x0000AA31
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_leg_i_k.html");
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000C83D File Offset: 0x0000AA3D
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000C849 File Offset: 0x0000AA49
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000C855 File Offset: 0x0000AA55
		public override IKSolver GetIKSolver()
		{
			return this.solver;
		}

		// Token: 0x04000182 RID: 386
		public IKSolverLeg solver = new IKSolverLeg();
	}
}
