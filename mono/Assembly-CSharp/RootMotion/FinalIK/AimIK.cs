using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000039 RID: 57
	[HelpURL("https://www.youtube.com/watch?v=wT8fViZpLmQ&index=3&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Aim IK")]
	public class AimIK : IK
	{
		// Token: 0x060001EF RID: 495 RVA: 0x0000C265 File Offset: 0x0000A465
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page1.html");
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000C271 File Offset: 0x0000A471
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_aim_i_k.html");
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000C27D File Offset: 0x0000A47D
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenSetupTutorial()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=wT8fViZpLmQ");
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0000C289 File Offset: 0x0000A489
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000C295 File Offset: 0x0000A495
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000C2A1 File Offset: 0x0000A4A1
		public override IKSolver GetIKSolver()
		{
			return this.solver;
		}

		// Token: 0x04000178 RID: 376
		public IKSolverAim solver = new IKSolverAim();
	}
}
