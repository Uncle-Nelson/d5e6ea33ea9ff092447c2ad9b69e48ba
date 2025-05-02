using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200003E RID: 62
	[HelpURL("https://www.youtube.com/watch?v=7__IafZGwvI&index=1&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Full Body Biped IK")]
	public class FullBodyBipedIK : IK
	{
		// Token: 0x0600020E RID: 526 RVA: 0x0000C3E8 File Offset: 0x0000A5E8
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page8.html");
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000C3F4 File Offset: 0x0000A5F4
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_full_body_biped_i_k.html");
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000C400 File Offset: 0x0000A600
		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=7__IafZGwvI");
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000C40C File Offset: 0x0000A60C
		[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
		private void OpenInspectorTutorial()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=tgRMsTphjJo");
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000C418 File Offset: 0x0000A618
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000C424 File Offset: 0x0000A624
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000C430 File Offset: 0x0000A630
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
			this.references = references;
			this.solver.SetToReferences(this.references, rootNode);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000C44B File Offset: 0x0000A64B
		public override IKSolver GetIKSolver()
		{
			return this.solver;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000C454 File Offset: 0x0000A654
		public bool ReferencesError(ref string errorMessage)
		{
			if (BipedReferences.SetupError(this.references, ref errorMessage))
			{
				return true;
			}
			if (this.references.spine.Length == 0)
			{
				errorMessage = "References has no spine bones assigned, can not initiate the solver.";
				return true;
			}
			if (this.solver.rootNode == null)
			{
				errorMessage = "Root Node bone is null, can not initiate the solver.";
				return true;
			}
			if (this.solver.rootNode != this.references.pelvis)
			{
				bool flag = false;
				for (int i = 0; i < this.references.spine.Length; i++)
				{
					if (this.solver.rootNode == this.references.spine[i])
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					errorMessage = "The Root Node has to be one of the bones in the Spine or the Pelvis, can not initiate the solver.";
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000C50C File Offset: 0x0000A70C
		public bool ReferencesWarning(ref string warningMessage)
		{
			if (BipedReferences.SetupWarning(this.references, ref warningMessage))
			{
				return true;
			}
			Vector3 vector = this.references.rightUpperArm.position - this.references.leftUpperArm.position;
			Vector3 vector2 = this.solver.rootNode.position - this.references.leftUpperArm.position;
			if (Vector3.Dot(vector.normalized, vector2.normalized) > 0.95f)
			{
				warningMessage = "The root node, the left upper arm and the right upper arm bones should ideally form a triangle that is as close to equilateral as possible. Currently the root node bone seems to be very close to the line between the left upper arm and the right upper arm bones. This might cause unwanted behaviour like the spine turning upside down when pulled by a hand effector.Please set the root node bone to be one of the lower bones in the spine.";
				return true;
			}
			Vector3 vector3 = this.references.rightThigh.position - this.references.leftThigh.position;
			Vector3 vector4 = this.solver.rootNode.position - this.references.leftThigh.position;
			if (Vector3.Dot(vector3.normalized, vector4.normalized) > 0.95f)
			{
				warningMessage = "The root node, the left thigh and the right thigh bones should ideally form a triangle that is as close to equilateral as possible. Currently the root node bone seems to be very close to the line between the left thigh and the right thigh bones. This might cause unwanted behaviour like the hip turning upside down when pulled by an effector.Please set the root node bone to be one of the higher bones in the spine.";
				return true;
			}
			return false;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000C608 File Offset: 0x0000A808
		[ContextMenu("Reinitiate")]
		private void Reinitiate()
		{
			this.SetReferences(this.references, this.solver.rootNode);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000C624 File Offset: 0x0000A824
		[ContextMenu("Auto-detect References")]
		private void AutoDetectReferences()
		{
			this.references = new BipedReferences();
			BipedReferences.AutoDetectReferences(ref this.references, base.transform, new BipedReferences.AutoDetectParams(true, false));
			this.solver.rootNode = IKSolverFullBodyBiped.DetectRootNodeBone(this.references);
			this.solver.SetToReferences(this.references, this.solver.rootNode);
		}

		// Token: 0x0400017D RID: 381
		public BipedReferences references = new BipedReferences();

		// Token: 0x0400017E RID: 382
		public IKSolverFullBodyBiped solver = new IKSolverFullBodyBiped();
	}
}
