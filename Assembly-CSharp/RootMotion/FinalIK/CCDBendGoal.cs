using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000075 RID: 117
	public class CCDBendGoal : MonoBehaviour
	{
		// Token: 0x060004C9 RID: 1225 RVA: 0x0001F919 File Offset: 0x0001DB19
		private void Start()
		{
			IKSolverCCD solver = this.ik.solver;
			solver.OnPreUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(solver.OnPreUpdate, new IKSolver.UpdateDelegate(this.BeforeIK));
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x0001F948 File Offset: 0x0001DB48
		private void BeforeIK()
		{
			if (!base.enabled)
			{
				return;
			}
			float num = this.ik.solver.IKPositionWeight * this.weight;
			if (num <= 0f)
			{
				return;
			}
			Vector3 position = this.ik.solver.bones[0].transform.position;
			Quaternion quaternion = Quaternion.FromToRotation(this.ik.solver.bones[this.ik.solver.bones.Length - 1].transform.position - position, base.transform.position - position);
			if (num < 1f)
			{
				quaternion = Quaternion.Slerp(Quaternion.identity, quaternion, num);
			}
			this.ik.solver.bones[0].transform.rotation = quaternion * this.ik.solver.bones[0].transform.rotation;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x0001FA3B File Offset: 0x0001DC3B
		private void OnDestroy()
		{
			if (this.ik != null)
			{
				IKSolverCCD solver = this.ik.solver;
				solver.OnPreUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(solver.OnPreUpdate, new IKSolver.UpdateDelegate(this.BeforeIK));
			}
		}

		// Token: 0x040003A1 RID: 929
		public CCDIK ik;

		// Token: 0x040003A2 RID: 930
		[Range(0f, 1f)]
		public float weight = 1f;
	}
}
