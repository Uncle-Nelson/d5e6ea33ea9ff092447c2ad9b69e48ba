using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200002A RID: 42
	[Serializable]
	public class BipedIKSolvers
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000160 RID: 352 RVA: 0x000088F4 File Offset: 0x00006AF4
		public IKSolverLimb[] limbs
		{
			get
			{
				if (this._limbs == null || (this._limbs != null && this._limbs.Length != 4))
				{
					this._limbs = new IKSolverLimb[]
					{
						this.leftFoot,
						this.rightFoot,
						this.leftHand,
						this.rightHand
					};
				}
				return this._limbs;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00008954 File Offset: 0x00006B54
		public IKSolver[] ikSolvers
		{
			get
			{
				if (this._ikSolvers == null || (this._ikSolvers != null && this._ikSolvers.Length != 7))
				{
					this._ikSolvers = new IKSolver[]
					{
						this.leftFoot,
						this.rightFoot,
						this.leftHand,
						this.rightHand,
						this.spine,
						this.lookAt,
						this.aim
					};
				}
				return this._ikSolvers;
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000089D0 File Offset: 0x00006BD0
		public void AssignReferences(BipedReferences references)
		{
			this.leftHand.SetChain(references.leftUpperArm, references.leftForearm, references.leftHand, references.root);
			this.rightHand.SetChain(references.rightUpperArm, references.rightForearm, references.rightHand, references.root);
			this.leftFoot.SetChain(references.leftThigh, references.leftCalf, references.leftFoot, references.root);
			this.rightFoot.SetChain(references.rightThigh, references.rightCalf, references.rightFoot, references.root);
			this.spine.SetChain(references.spine, references.root);
			this.lookAt.SetChain(references.spine, references.head, references.eyes, references.root);
			this.aim.SetChain(references.spine, references.root);
			this.leftFoot.goal = AvatarIKGoal.LeftFoot;
			this.rightFoot.goal = AvatarIKGoal.RightFoot;
			this.leftHand.goal = AvatarIKGoal.LeftHand;
			this.rightHand.goal = AvatarIKGoal.RightHand;
		}

		// Token: 0x040000E5 RID: 229
		public IKSolverLimb leftFoot = new IKSolverLimb(AvatarIKGoal.LeftFoot);

		// Token: 0x040000E6 RID: 230
		public IKSolverLimb rightFoot = new IKSolverLimb(AvatarIKGoal.RightFoot);

		// Token: 0x040000E7 RID: 231
		public IKSolverLimb leftHand = new IKSolverLimb(AvatarIKGoal.LeftHand);

		// Token: 0x040000E8 RID: 232
		public IKSolverLimb rightHand = new IKSolverLimb(AvatarIKGoal.RightHand);

		// Token: 0x040000E9 RID: 233
		public IKSolverFABRIK spine = new IKSolverFABRIK();

		// Token: 0x040000EA RID: 234
		public IKSolverLookAt lookAt = new IKSolverLookAt();

		// Token: 0x040000EB RID: 235
		public IKSolverAim aim = new IKSolverAim();

		// Token: 0x040000EC RID: 236
		public Constraints pelvis = new Constraints();

		// Token: 0x040000ED RID: 237
		private IKSolverLimb[] _limbs;

		// Token: 0x040000EE RID: 238
		private IKSolver[] _ikSolvers;
	}
}
