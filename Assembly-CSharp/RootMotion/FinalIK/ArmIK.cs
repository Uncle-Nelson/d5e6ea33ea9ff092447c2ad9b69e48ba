using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200003A RID: 58
	[HelpURL("http://www.root-motion.com/finalikdox/html/page2.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Arm IK")]
	public class ArmIK : IK
	{
		// Token: 0x060001F6 RID: 502 RVA: 0x0000C2BC File Offset: 0x0000A4BC
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page2.html");
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000C2C8 File Offset: 0x0000A4C8
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_arm_i_k.html");
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000C2D4 File Offset: 0x0000A4D4
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000C2E0 File Offset: 0x0000A4E0
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000C2EC File Offset: 0x0000A4EC
		public override IKSolver GetIKSolver()
		{
			return this.solver;
		}

		// Token: 0x04000179 RID: 377
		public IKSolverArm solver = new IKSolverArm();
	}
}
