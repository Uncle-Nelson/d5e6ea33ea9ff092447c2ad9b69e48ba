using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x0200009B RID: 155
	public class FBIKHandsOnProp : MonoBehaviour
	{
		// Token: 0x06000588 RID: 1416 RVA: 0x000258D7 File Offset: 0x00023AD7
		private void Awake()
		{
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreRead = (IKSolver.UpdateDelegate)Delegate.Combine(solver.OnPreRead, new IKSolver.UpdateDelegate(this.OnPreRead));
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00025908 File Offset: 0x00023B08
		private void OnPreRead()
		{
			if (this.leftHanded)
			{
				this.HandsOnProp(this.ik.solver.leftHandEffector, this.ik.solver.rightHandEffector);
				return;
			}
			this.HandsOnProp(this.ik.solver.rightHandEffector, this.ik.solver.leftHandEffector);
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0002596C File Offset: 0x00023B6C
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
			Vector3 vector = otherHand.bone.position - mainHand.bone.position;
			Vector3 point = Quaternion.Inverse(mainHand.bone.rotation) * vector;
			Vector3 b = mainHand.bone.position + vector * 0.5f;
			Quaternion rhs = Quaternion.Inverse(mainHand.bone.rotation) * otherHand.bone.rotation;
			Vector3 toDirection = otherHand.bone.position + otherHand.positionOffset - (mainHand.bone.position + mainHand.positionOffset);
			Vector3 a = mainHand.bone.position + mainHand.positionOffset + vector * 0.5f;
			mainHand.position = mainHand.bone.position + mainHand.positionOffset + (a - b);
			mainHand.positionWeight = 1f;
			Quaternion lhs = Quaternion.FromToRotation(vector, toDirection);
			mainHand.bone.rotation = lhs * mainHand.bone.rotation;
			otherHand.position = mainHand.position + mainHand.bone.rotation * point;
			otherHand.positionWeight = 1f;
			otherHand.bone.rotation = mainHand.bone.rotation * rhs;
			this.ik.solver.leftArmMapping.maintainRotationWeight = 1f;
			this.ik.solver.rightArmMapping.maintainRotationWeight = 1f;
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00025B1C File Offset: 0x00023D1C
		private void OnDestroy()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPreRead = (IKSolver.UpdateDelegate)Delegate.Remove(solver.OnPreRead, new IKSolver.UpdateDelegate(this.OnPreRead));
			}
		}

		// Token: 0x04000496 RID: 1174
		public FullBodyBipedIK ik;

		// Token: 0x04000497 RID: 1175
		public bool leftHanded;
	}
}
