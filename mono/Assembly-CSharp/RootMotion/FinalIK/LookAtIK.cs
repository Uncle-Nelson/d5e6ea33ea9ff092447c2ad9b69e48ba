using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000043 RID: 67
	[HelpURL("http://www.root-motion.com/finalikdox/html/page13.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Look At IK")]
	public class LookAtIK : IK
	{
		// Token: 0x06000235 RID: 565 RVA: 0x0000C8BB File Offset: 0x0000AABB
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page13.html");
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000C8C7 File Offset: 0x0000AAC7
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_look_at_i_k.html");
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000C8D3 File Offset: 0x0000AAD3
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0000C8DF File Offset: 0x0000AADF
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000C8EB File Offset: 0x0000AAEB
		public override IKSolver GetIKSolver()
		{
			return this.solver;
		}

		// Token: 0x04000184 RID: 388
		public IKSolverLookAt solver = new IKSolverLookAt();
	}
}
