using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000B9 RID: 185
	public class VRIKArmMocap : MonoBehaviour
	{
		// Token: 0x060005FB RID: 1531 RVA: 0x000285B3 File Offset: 0x000267B3
		private void Start()
		{
			IKSolverVR solver = this.ik.solver;
			solver.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(solver.OnPostUpdate, new IKSolver.UpdateDelegate(this.AfterVRIK));
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x000285E4 File Offset: 0x000267E4
		private void AfterVRIK()
		{
			VRIKArmMocap.UpdateArm(this.ik.references.leftUpperArm, this.ik.references.leftForearm, this.ik.references.leftHand, this.leftElbowTarget, this.ik.solver.leftArm.target);
			VRIKArmMocap.UpdateArm(this.ik.references.rightUpperArm, this.ik.references.rightForearm, this.ik.references.rightHand, this.rightElbowTarget, this.ik.solver.rightArm.target);
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00028694 File Offset: 0x00026894
		private static void UpdateArm(Transform upperArm, Transform forearm, Transform hand, Transform elbowTarget, Transform handTarget)
		{
			if (elbowTarget == null)
			{
				return;
			}
			if (handTarget == null)
			{
				return;
			}
			upperArm.rotation = Quaternion.FromToRotation(forearm.position - upperArm.position, elbowTarget.position - upperArm.position) * upperArm.rotation;
			forearm.rotation = Quaternion.FromToRotation(hand.position - forearm.position, handTarget.position - forearm.position) * forearm.rotation;
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00028727 File Offset: 0x00026927
		private void OnDestroy()
		{
			if (this.ik != null)
			{
				IKSolverVR solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(solver.OnPostUpdate, new IKSolver.UpdateDelegate(this.AfterVRIK));
			}
		}

		// Token: 0x04000534 RID: 1332
		public VRIK ik;

		// Token: 0x04000535 RID: 1333
		public Transform leftElbowTarget;

		// Token: 0x04000536 RID: 1334
		public Transform rightElbowTarget;
	}
}
