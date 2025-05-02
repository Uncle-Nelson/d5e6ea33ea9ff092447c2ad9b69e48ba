using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000047 RID: 71
	public class FBBIKArmBending : MonoBehaviour
	{
		// Token: 0x06000250 RID: 592 RVA: 0x0000CCA4 File Offset: 0x0000AEA4
		private void LateUpdate()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.initiated)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(solver.OnPostUpdate, new IKSolver.UpdateDelegate(this.OnPostFBBIK));
				this.initiated = true;
			}
			if (this.ik.solver.leftHandEffector.target != null)
			{
				Vector3 left = Vector3.left;
				this.ik.solver.leftArmChain.bendConstraint.direction = this.ik.solver.leftHandEffector.target.rotation * left + this.ik.solver.leftHandEffector.target.rotation * this.bendDirectionOffsetLeft + this.ik.transform.rotation * this.characterSpaceBendOffsetLeft;
				this.ik.solver.leftArmChain.bendConstraint.weight = 1f;
			}
			if (this.ik.solver.rightHandEffector.target != null)
			{
				Vector3 right = Vector3.right;
				this.ik.solver.rightArmChain.bendConstraint.direction = this.ik.solver.rightHandEffector.target.rotation * right + this.ik.solver.rightHandEffector.target.rotation * this.bendDirectionOffsetRight + this.ik.transform.rotation * this.characterSpaceBendOffsetRight;
				this.ik.solver.rightArmChain.bendConstraint.weight = 1f;
			}
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0000CE90 File Offset: 0x0000B090
		private void OnPostFBBIK()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.leftHandEffector.target != null)
			{
				this.ik.references.leftHand.rotation = this.ik.solver.leftHandEffector.target.rotation;
			}
			if (this.ik.solver.rightHandEffector.target != null)
			{
				this.ik.references.rightHand.rotation = this.ik.solver.rightHandEffector.target.rotation;
			}
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0000CF44 File Offset: 0x0000B144
		private void OnDestroy()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(solver.OnPostUpdate, new IKSolver.UpdateDelegate(this.OnPostFBBIK));
			}
		}

		// Token: 0x0400018C RID: 396
		public FullBodyBipedIK ik;

		// Token: 0x0400018D RID: 397
		public Vector3 bendDirectionOffsetLeft;

		// Token: 0x0400018E RID: 398
		public Vector3 bendDirectionOffsetRight;

		// Token: 0x0400018F RID: 399
		public Vector3 characterSpaceBendOffsetLeft;

		// Token: 0x04000190 RID: 400
		public Vector3 characterSpaceBendOffsetRight;

		// Token: 0x04000191 RID: 401
		private Quaternion leftHandTargetRotation;

		// Token: 0x04000192 RID: 402
		private Quaternion rightHandTargetRotation;

		// Token: 0x04000193 RID: 403
		private bool initiated;
	}
}
