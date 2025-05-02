using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000035 RID: 53
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Full Body Biped")]
	public class GrounderFBBIK : Grounder
	{
		// Token: 0x060001AA RID: 426 RVA: 0x0000A073 File Offset: 0x00008273
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6");
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000A07F File Offset: 0x0000827F
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page9.html");
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000A08B File Offset: 0x0000828B
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_grounder_f_b_b_i_k.html");
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000A097 File Offset: 0x00008297
		public override void ResetPosition()
		{
			this.solver.Reset();
			this.spineOffset = Vector3.zero;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000A0AF File Offset: 0x000082AF
		private bool IsReadyToInitiate()
		{
			return !(this.ik == null) && this.ik.solver.initiated;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000A0D8 File Offset: 0x000082D8
		private void Update()
		{
			this.firstSolve = true;
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

		// Token: 0x060001B0 RID: 432 RVA: 0x0000A12D File Offset: 0x0000832D
		private void FixedUpdate()
		{
			this.firstSolve = true;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000A136 File Offset: 0x00008336
		private void LateUpdate()
		{
			this.firstSolve = true;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000A140 File Offset: 0x00008340
		private void Initiate()
		{
			this.ik.solver.leftLegMapping.maintainRotationWeight = 1f;
			this.ik.solver.rightLegMapping.maintainRotationWeight = 1f;
			this.feet = new Transform[2];
			this.feet[0] = this.ik.solver.leftFootEffector.bone;
			this.feet[1] = this.ik.solver.rightFootEffector.bone;
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(solver.OnPreUpdate, new IKSolver.UpdateDelegate(this.OnSolverUpdate));
			IKSolverFullBodyBiped solver2 = this.ik.solver;
			solver2.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(solver2.OnPostUpdate, new IKSolver.UpdateDelegate(this.OnPostSolverUpdate));
			this.solver.Initiate(this.ik.references.root, this.feet);
			base.initiated = true;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000A248 File Offset: 0x00008448
		private void OnSolverUpdate()
		{
			if (!this.firstSolve)
			{
				return;
			}
			this.firstSolve = false;
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 0f)
			{
				return;
			}
			if (this.OnPreGrounder != null)
			{
				this.OnPreGrounder();
			}
			this.solver.Update();
			this.ik.references.pelvis.position += this.solver.pelvis.IKOffset * this.weight;
			this.SetLegIK(this.ik.solver.leftFootEffector, this.solver.legs[0]);
			this.SetLegIK(this.ik.solver.rightFootEffector, this.solver.legs[1]);
			if (this.spineBend != 0f)
			{
				this.spineSpeed = Mathf.Clamp(this.spineSpeed, 0f, this.spineSpeed);
				Vector3 a = base.GetSpineOffsetTarget() * this.weight;
				this.spineOffset = Vector3.Lerp(this.spineOffset, a * this.spineBend, Time.deltaTime * this.spineSpeed);
				Vector3 a2 = this.ik.references.root.up * this.spineOffset.magnitude;
				for (int i = 0; i < this.spine.Length; i++)
				{
					this.ik.solver.GetEffector(this.spine[i].effectorType).positionOffset += this.spineOffset * this.spine[i].horizontalWeight + a2 * this.spine[i].verticalWeight;
				}
			}
			if (this.OnPostGrounder != null)
			{
				this.OnPostGrounder();
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000A42C File Offset: 0x0000862C
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
			effector.positionOffset += (leg.IKPosition - effector.bone.position) * this.weight;
			effector.bone.rotation = Quaternion.Slerp(Quaternion.identity, leg.rotationOffset, this.weight) * effector.bone.rotation;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000A49C File Offset: 0x0000869C
		private void OnDrawGizmosSelected()
		{
			if (this.ik == null)
			{
				this.ik = base.GetComponent<FullBodyBipedIK>();
			}
			if (this.ik == null)
			{
				this.ik = base.GetComponentInParent<FullBodyBipedIK>();
			}
			if (this.ik == null)
			{
				this.ik = base.GetComponentInChildren<FullBodyBipedIK>();
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000A4F7 File Offset: 0x000086F7
		private void OnPostSolverUpdate()
		{
			if (this.OnPostIK != null)
			{
				this.OnPostIK();
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000A50C File Offset: 0x0000870C
		private void OnDestroy()
		{
			if (base.initiated && this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPreUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(solver.OnPreUpdate, new IKSolver.UpdateDelegate(this.OnSolverUpdate));
				IKSolverFullBodyBiped solver2 = this.ik.solver;
				solver2.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(solver2.OnPostUpdate, new IKSolver.UpdateDelegate(this.OnPostSolverUpdate));
			}
		}

		// Token: 0x0400012B RID: 299
		[Tooltip("Reference to the FBBIK componet.")]
		public FullBodyBipedIK ik;

		// Token: 0x0400012C RID: 300
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend = 2f;

		// Token: 0x0400012D RID: 301
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed = 3f;

		// Token: 0x0400012E RID: 302
		public GrounderFBBIK.SpineEffector[] spine = new GrounderFBBIK.SpineEffector[0];

		// Token: 0x0400012F RID: 303
		private Transform[] feet = new Transform[2];

		// Token: 0x04000130 RID: 304
		private Vector3 spineOffset;

		// Token: 0x04000131 RID: 305
		private bool firstSolve;

		// Token: 0x020000D6 RID: 214
		[Serializable]
		public class SpineEffector
		{
			// Token: 0x0600066C RID: 1644 RVA: 0x0002B23F File Offset: 0x0002943F
			public SpineEffector()
			{
			}

			// Token: 0x0600066D RID: 1645 RVA: 0x0002B252 File Offset: 0x00029452
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
				this.effectorType = effectorType;
				this.horizontalWeight = horizontalWeight;
				this.verticalWeight = verticalWeight;
			}

			// Token: 0x0400060D RID: 1549
			[Tooltip("The type of the effector.")]
			public FullBodyBipedEffector effectorType;

			// Token: 0x0400060E RID: 1550
			[Tooltip("The weight of horizontal bend offset towards the slope.")]
			public float horizontalWeight = 1f;

			// Token: 0x0400060F RID: 1551
			[Tooltip("The vertical bend offset weight.")]
			public float verticalWeight;
		}
	}
}
