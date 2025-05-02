using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000029 RID: 41
	[HelpURL("http://www.root-motion.com/finalikdox/html/page4.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Biped IK")]
	public class BipedIK : SolverManager
	{
		// Token: 0x06000147 RID: 327 RVA: 0x00008433 File Offset: 0x00006633
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page4.html");
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0000843F File Offset: 0x0000663F
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_biped_i_k.html");
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000844B File Offset: 0x0000664B
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00008457 File Offset: 0x00006657
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00008463 File Offset: 0x00006663
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return this.GetGoalIK(goal).GetIKPositionWeight();
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00008471 File Offset: 0x00006671
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return this.GetGoalIK(goal).GetIKRotationWeight();
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000847F File Offset: 0x0000667F
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
			this.GetGoalIK(goal).SetIKPositionWeight(weight);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000848E File Offset: 0x0000668E
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
			this.GetGoalIK(goal).SetIKRotationWeight(weight);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000849D File Offset: 0x0000669D
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
			this.GetGoalIK(goal).SetIKPosition(IKPosition);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000084AC File Offset: 0x000066AC
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
			this.GetGoalIK(goal).SetIKRotation(IKRotation);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000084BB File Offset: 0x000066BB
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return this.GetGoalIK(goal).GetIKPosition();
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000084C9 File Offset: 0x000066C9
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return this.GetGoalIK(goal).GetIKRotation();
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000084D7 File Offset: 0x000066D7
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
			this.solvers.lookAt.SetLookAtWeight(weight, bodyWeight, headWeight, eyesWeight, clampWeight, clampWeightHead, clampWeightEyes);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x000084F4 File Offset: 0x000066F4
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
			this.solvers.lookAt.SetIKPosition(lookAtPosition);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00008507 File Offset: 0x00006707
		public void SetSpinePosition(Vector3 spinePosition)
		{
			this.solvers.spine.SetIKPosition(spinePosition);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000851A File Offset: 0x0000671A
		public void SetSpineWeight(float weight)
		{
			this.solvers.spine.SetIKPositionWeight(weight);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00008530 File Offset: 0x00006730
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			switch (goal)
			{
			case AvatarIKGoal.LeftFoot:
				return this.solvers.leftFoot;
			case AvatarIKGoal.RightFoot:
				return this.solvers.rightFoot;
			case AvatarIKGoal.LeftHand:
				return this.solvers.leftHand;
			case AvatarIKGoal.RightHand:
				return this.solvers.rightHand;
			default:
				return null;
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00008586 File Offset: 0x00006786
		public void InitiateBipedIK()
		{
			this.InitiateSolver();
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000858E File Offset: 0x0000678E
		public void UpdateBipedIK()
		{
			this.UpdateSolver();
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00008598 File Offset: 0x00006798
		public void SetToDefaults()
		{
			foreach (IKSolverLimb iksolverLimb in this.solvers.limbs)
			{
				iksolverLimb.SetIKPositionWeight(0f);
				iksolverLimb.SetIKRotationWeight(0f);
				iksolverLimb.bendModifier = IKSolverLimb.BendModifier.Animation;
				iksolverLimb.bendModifierWeight = 1f;
			}
			this.solvers.leftHand.maintainRotationWeight = 0f;
			this.solvers.rightHand.maintainRotationWeight = 0f;
			this.solvers.spine.SetIKPositionWeight(0f);
			this.solvers.spine.tolerance = 0f;
			this.solvers.spine.maxIterations = 2;
			this.solvers.spine.useRotationLimits = false;
			this.solvers.aim.SetIKPositionWeight(0f);
			this.solvers.aim.tolerance = 0f;
			this.solvers.aim.maxIterations = 2;
			this.SetLookAtWeight(0f, 0.5f, 1f, 1f, 0.5f, 0.7f, 0.5f);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000086C4 File Offset: 0x000068C4
		protected override void FixTransforms()
		{
			this.solvers.pelvis.FixTransforms();
			this.solvers.lookAt.FixTransforms();
			for (int i = 0; i < this.solvers.limbs.Length; i++)
			{
				this.solvers.limbs[i].FixTransforms();
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000871C File Offset: 0x0000691C
		protected override void InitiateSolver()
		{
			string message = "";
			if (BipedReferences.SetupError(this.references, ref message))
			{
				Warning.Log(message, this.references.root, false);
				return;
			}
			this.solvers.AssignReferences(this.references);
			if (this.solvers.spine.bones.Length > 1)
			{
				this.solvers.spine.Initiate(base.transform);
			}
			this.solvers.lookAt.Initiate(base.transform);
			this.solvers.aim.Initiate(base.transform);
			IKSolverLimb[] limbs = this.solvers.limbs;
			for (int i = 0; i < limbs.Length; i++)
			{
				limbs[i].Initiate(base.transform);
			}
			this.solvers.pelvis.Initiate(this.references.pelvis);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x000087FC File Offset: 0x000069FC
		protected override void UpdateSolver()
		{
			for (int i = 0; i < this.solvers.limbs.Length; i++)
			{
				this.solvers.limbs[i].MaintainBend();
				this.solvers.limbs[i].MaintainRotation();
			}
			this.solvers.pelvis.Update();
			if (this.solvers.spine.bones.Length > 1)
			{
				this.solvers.spine.Update();
			}
			this.solvers.aim.Update();
			this.solvers.lookAt.Update();
			for (int j = 0; j < this.solvers.limbs.Length; j++)
			{
				this.solvers.limbs[j].Update();
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000088C4 File Offset: 0x00006AC4
		public void LogWarning(string message)
		{
			Warning.Log(message, base.transform, false);
		}

		// Token: 0x040000E3 RID: 227
		public BipedReferences references = new BipedReferences();

		// Token: 0x040000E4 RID: 228
		public BipedIKSolvers solvers = new BipedIKSolvers();
	}
}
