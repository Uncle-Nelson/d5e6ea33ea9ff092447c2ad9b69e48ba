using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000060 RID: 96
	public class TwistRelaxer : MonoBehaviour
	{
		// Token: 0x060003C5 RID: 965 RVA: 0x00019D2C File Offset: 0x00017F2C
		public void Start()
		{
			if (this.twistSolvers.Length == 0)
			{
				Debug.LogError("TwistRelaxer has no TwistSolvers. TwistRelaxer.cs was restructured for FIK v2.0 to support multiple relaxers on the same body part and TwistRelaxer components need to be set up again, sorry for the inconvenience!", base.transform);
				return;
			}
			TwistSolver[] array = this.twistSolvers;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Initiate();
			}
			if (this.ik != null)
			{
				IKSolver iksolver = this.ik.GetIKSolver();
				iksolver.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(iksolver.OnPostUpdate, new IKSolver.UpdateDelegate(this.OnPostUpdate));
			}
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00019DAC File Offset: 0x00017FAC
		private void Update()
		{
			if (this.ik != null && this.ik.fixTransforms)
			{
				TwistSolver[] array = this.twistSolvers;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].FixTransforms();
				}
			}
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00019DF4 File Offset: 0x00017FF4
		private void OnPostUpdate()
		{
			if (this.ik != null)
			{
				TwistSolver[] array = this.twistSolvers;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].Relax();
				}
			}
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00019E2C File Offset: 0x0001802C
		private void LateUpdate()
		{
			if (this.ik == null)
			{
				TwistSolver[] array = this.twistSolvers;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].Relax();
				}
			}
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00019E64 File Offset: 0x00018064
		private void OnDestroy()
		{
			if (this.ik != null)
			{
				IKSolver iksolver = this.ik.GetIKSolver();
				iksolver.OnPostUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(iksolver.OnPostUpdate, new IKSolver.UpdateDelegate(this.OnPostUpdate));
			}
		}

		// Token: 0x040002DC RID: 732
		public IK ik;

		// Token: 0x040002DD RID: 733
		[Tooltip("If using multiple solvers, add them in inverse hierarchical order - first forearm roll bone, then forearm bone and upper arm bone.")]
		public TwistSolver[] twistSolvers = new TwistSolver[0];
	}
}
