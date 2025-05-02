using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000078 RID: 120
	public class FABRIKBendGoal : MonoBehaviour
	{
		// Token: 0x060004DA RID: 1242 RVA: 0x0001FF0D File Offset: 0x0001E10D
		private void Start()
		{
			IKSolverFABRIK solver = this.ik.solver;
			solver.OnPreIteration = (IKSolver.IterationDelegate)Delegate.Combine(solver.OnPreIteration, new IKSolver.IterationDelegate(this.OnPreIteration));
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x0001FF3C File Offset: 0x0001E13C
		private void OnPreIteration(int it)
		{
			if (it != 0)
			{
				return;
			}
			if (this.weight <= 0f)
			{
				return;
			}
			Vector3 vector = base.transform.position - this.ik.solver.bones[0].transform.position;
			vector *= this.weight;
			IKSolver.Bone[] bones = this.ik.solver.bones;
			for (int i = 0; i < bones.Length; i++)
			{
				bones[i].solverPosition += vector;
			}
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x0001FFC8 File Offset: 0x0001E1C8
		private void OnDestroy()
		{
			if (this.ik != null)
			{
				IKSolverFABRIK solver = this.ik.solver;
				solver.OnPreIteration = (IKSolver.IterationDelegate)Delegate.Remove(solver.OnPreIteration, new IKSolver.IterationDelegate(this.OnPreIteration));
			}
		}

		// Token: 0x040003A9 RID: 937
		public FABRIK ik;

		// Token: 0x040003AA RID: 938
		[Range(0f, 1f)]
		public float weight = 1f;
	}
}
