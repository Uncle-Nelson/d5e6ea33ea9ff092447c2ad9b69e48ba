using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000034 RID: 52
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Biped")]
	public class GrounderBipedIK : Grounder
	{
		// Token: 0x0600019E RID: 414 RVA: 0x00009A2F File Offset: 0x00007C2F
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page9.html");
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00009A3B File Offset: 0x00007C3B
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_grounder_biped_i_k.html");
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00009A47 File Offset: 0x00007C47
		public override void ResetPosition()
		{
			this.solver.Reset();
			this.spineOffset = Vector3.zero;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00009A60 File Offset: 0x00007C60
		private bool IsReadyToInitiate()
		{
			return !(this.ik == null) && this.ik.solvers.leftFoot.initiated && this.ik.solvers.rightFoot.initiated;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00009AB0 File Offset: 0x00007CB0
		private void Update()
		{
			this.weight = Mathf.Clamp(this.weight, 0f, 1f);
			if (this.weight <= 0f)
			{
				return;
			}
			if (base.initiated)
			{
				return;
			}
			if (!this.IsReadyToInitiate())
			{
				return;
			}
			this.Initiate();
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00009B00 File Offset: 0x00007D00
		private void Initiate()
		{
			this.feet = new Transform[2];
			this.footRotations = new Quaternion[2];
			this.feet[0] = this.ik.references.leftFoot;
			this.feet[1] = this.ik.references.rightFoot;
			this.footRotations[0] = Quaternion.identity;
			this.footRotations[1] = Quaternion.identity;
			IKSolverFABRIK spine = this.ik.solvers.spine;
			spine.OnPreUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(spine.OnPreUpdate, new IKSolver.UpdateDelegate(this.OnSolverUpdate));
			IKSolverLimb rightFoot = this.ik.solvers.rightFoot;
			rightFoot.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(rightFoot.OnPostUpdate, new IKSolver.UpdateDelegate(this.OnPostSolverUpdate));
			this.animatedPelvisLocalPosition = this.ik.references.pelvis.localPosition;
			this.solver.Initiate(this.ik.references.root, this.feet);
			base.initiated = true;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00009C1C File Offset: 0x00007E1C
		private void OnDisable()
		{
			if (!base.initiated)
			{
				return;
			}
			this.ik.solvers.leftFoot.IKPositionWeight = 0f;
			this.ik.solvers.rightFoot.IKPositionWeight = 0f;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00009C5C File Offset: 0x00007E5C
		private void OnSolverUpdate()
		{
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 0f)
			{
				if (this.lastWeight <= 0f)
				{
					return;
				}
				this.OnDisable();
			}
			this.lastWeight = this.weight;
			if (this.OnPreGrounder != null)
			{
				this.OnPreGrounder();
			}
			if (this.ik.references.pelvis.localPosition != this.solvedPelvisLocalPosition)
			{
				this.animatedPelvisLocalPosition = this.ik.references.pelvis.localPosition;
			}
			else
			{
				this.ik.references.pelvis.localPosition = this.animatedPelvisLocalPosition;
			}
			this.solver.Update();
			this.ik.references.pelvis.position += this.solver.pelvis.IKOffset * this.weight;
			this.SetLegIK(this.ik.solvers.leftFoot, 0);
			this.SetLegIK(this.ik.solvers.rightFoot, 1);
			if (this.spineBend != 0f && this.ik.references.spine.Length != 0)
			{
				this.spineSpeed = Mathf.Clamp(this.spineSpeed, 0f, this.spineSpeed);
				Vector3 a = base.GetSpineOffsetTarget() * this.weight;
				this.spineOffset = Vector3.Lerp(this.spineOffset, a * this.spineBend, Time.deltaTime * this.spineSpeed);
				Quaternion rotation = this.ik.references.leftUpperArm.rotation;
				Quaternion rotation2 = this.ik.references.rightUpperArm.rotation;
				Vector3 up = this.solver.up;
				Quaternion lhs = Quaternion.FromToRotation(up, up + this.spineOffset);
				this.ik.references.spine[0].rotation = lhs * this.ik.references.spine[0].rotation;
				this.ik.references.leftUpperArm.rotation = rotation;
				this.ik.references.rightUpperArm.rotation = rotation2;
				this.ik.solvers.lookAt.SetDirty();
			}
			if (this.OnPostGrounder != null)
			{
				this.OnPostGrounder();
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00009ECE File Offset: 0x000080CE
		private void SetLegIK(IKSolverLimb limb, int index)
		{
			this.footRotations[index] = this.feet[index].rotation;
			limb.IKPosition = this.solver.legs[index].IKPosition;
			limb.IKPositionWeight = this.weight;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00009F10 File Offset: 0x00008110
		private void OnPostSolverUpdate()
		{
			if (this.weight <= 0f)
			{
				return;
			}
			if (!base.enabled)
			{
				return;
			}
			for (int i = 0; i < this.feet.Length; i++)
			{
				this.feet[i].rotation = Quaternion.Slerp(Quaternion.identity, this.solver.legs[i].rotationOffset, this.weight) * this.footRotations[i];
			}
			this.solvedPelvisLocalPosition = this.ik.references.pelvis.localPosition;
			if (this.OnPostIK != null)
			{
				this.OnPostIK();
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00009FB8 File Offset: 0x000081B8
		private void OnDestroy()
		{
			if (base.initiated && this.ik != null)
			{
				IKSolverFABRIK spine = this.ik.solvers.spine;
				spine.OnPreUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(spine.OnPreUpdate, new IKSolver.UpdateDelegate(this.OnSolverUpdate));
				IKSolverLimb rightFoot = this.ik.solvers.rightFoot;
				rightFoot.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(rightFoot.OnPostUpdate, new IKSolver.UpdateDelegate(this.OnPostSolverUpdate));
			}
		}

		// Token: 0x04000122 RID: 290
		[Tooltip("The BipedIK componet.")]
		public BipedIK ik;

		// Token: 0x04000123 RID: 291
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend = 7f;

		// Token: 0x04000124 RID: 292
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed = 3f;

		// Token: 0x04000125 RID: 293
		private Transform[] feet = new Transform[2];

		// Token: 0x04000126 RID: 294
		private Quaternion[] footRotations = new Quaternion[2];

		// Token: 0x04000127 RID: 295
		private Vector3 animatedPelvisLocalPosition;

		// Token: 0x04000128 RID: 296
		private Vector3 solvedPelvisLocalPosition;

		// Token: 0x04000129 RID: 297
		private Vector3 spineOffset;

		// Token: 0x0400012A RID: 298
		private float lastWeight;
	}
}
