using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000B1 RID: 177
	public class TwoHandedProp : MonoBehaviour
	{
		// Token: 0x060005DF RID: 1503 RVA: 0x00027BF8 File Offset: 0x00025DF8
		private void Start()
		{
			this.ik = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(solver.OnPostUpdate, new IKSolver.UpdateDelegate(this.AfterFBBIK));
			if (this.ik.solver.rightHandEffector.target == null)
			{
				Debug.LogError("Right Hand Effector needs a Target in this demo.");
			}
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00027C64 File Offset: 0x00025E64
		private void LateUpdate()
		{
			this.targetPosRelativeToRight = this.ik.references.rightHand.InverseTransformPoint(this.leftHandTarget.position);
			this.targetRotRelativeToRight = Quaternion.Inverse(this.ik.references.rightHand.rotation) * this.leftHandTarget.rotation;
			this.ik.solver.leftHandEffector.position = this.ik.solver.rightHandEffector.target.position + this.ik.solver.rightHandEffector.target.rotation * this.targetPosRelativeToRight;
			this.ik.solver.leftHandEffector.rotation = this.ik.solver.rightHandEffector.target.rotation * this.targetRotRelativeToRight;
			this.ik.solver.rightHandEffector.positionWeight = this.weight;
			float positionWeight = this.leftHandWeight * this.weight;
			this.ik.solver.leftHandEffector.positionWeight = positionWeight;
			this.leftHandPoser.weight = positionWeight;
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00027DA8 File Offset: 0x00025FA8
		private void AfterFBBIK()
		{
			this.ik.solver.leftHandEffector.bone.rotation = Quaternion.Slerp(this.ik.solver.leftHandEffector.bone.rotation, this.ik.solver.leftHandEffector.rotation, this.leftHandWeight * this.weight);
			this.ik.solver.rightHandEffector.bone.rotation = Quaternion.Slerp(this.ik.solver.rightHandEffector.bone.rotation, this.ik.solver.rightHandEffector.rotation, this.weight);
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00027E64 File Offset: 0x00026064
		private void OnDestroy()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(solver.OnPostUpdate, new IKSolver.UpdateDelegate(this.AfterFBBIK));
			}
		}

		// Token: 0x0400050C RID: 1292
		[Range(0f, 1f)]
		public float weight = 1f;

		// Token: 0x0400050D RID: 1293
		[Tooltip("The left hand target parented to the right hand.")]
		public Transform leftHandTarget;

		// Token: 0x0400050E RID: 1294
		[Tooltip("Left hand poser (poses fingers to match the left hand target).")]
		public Poser leftHandPoser;

		// Token: 0x0400050F RID: 1295
		[Tooltip("The weight of pinning the left hand to the prop.")]
		[Range(0f, 1f)]
		public float leftHandWeight = 1f;

		// Token: 0x04000510 RID: 1296
		private FullBodyBipedIK ik;

		// Token: 0x04000511 RID: 1297
		private Vector3 targetPosRelativeToRight;

		// Token: 0x04000512 RID: 1298
		private Quaternion targetRotRelativeToRight;
	}
}
