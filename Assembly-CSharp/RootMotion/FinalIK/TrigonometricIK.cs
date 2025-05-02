using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000044 RID: 68
	[HelpURL("http://www.root-motion.com/finalikdox/html/page15.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Trigonometric IK")]
	public class TrigonometricIK : IK
	{
		// Token: 0x0600023B RID: 571 RVA: 0x0000C906 File Offset: 0x0000AB06
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page15.html");
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000C912 File Offset: 0x0000AB12
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_trigonometric_i_k.html");
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000C91E File Offset: 0x0000AB1E
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000C92A File Offset: 0x0000AB2A
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000C936 File Offset: 0x0000AB36
		public override IKSolver GetIKSolver()
		{
			return this.solver;
		}

		// Token: 0x04000185 RID: 389
		public IKSolverTrigonometric solver = new IKSolverTrigonometric();
	}
}
