using System;
using System.Collections;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200007E RID: 126
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060004F6 RID: 1270 RVA: 0x00020983 File Offset: 0x0001EB83
		protected float deltaTime
		{
			get
			{
				return Time.time - this.lastTime;
			}
		}

		// Token: 0x060004F7 RID: 1271
		protected abstract void OnModifyOffset();

		// Token: 0x060004F8 RID: 1272 RVA: 0x00020991 File Offset: 0x0001EB91
		protected virtual void Start()
		{
			base.StartCoroutine(this.Initiate());
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x000209A0 File Offset: 0x0001EBA0
		private IEnumerator Initiate()
		{
			while (this.ik == null)
			{
				yield return null;
			}
			IKSolverVR solver = this.ik.solver;
			solver.OnPreUpdate = (IKSolver.UpdateDelegate)Delegate.Combine(solver.OnPreUpdate, new IKSolver.UpdateDelegate(this.ModifyOffset));
			this.lastTime = Time.time;
			yield break;
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x000209B0 File Offset: 0x0001EBB0
		private void ModifyOffset()
		{
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 0f)
			{
				return;
			}
			if (this.deltaTime <= 0f)
			{
				return;
			}
			if (this.ik == null)
			{
				return;
			}
			this.weight = Mathf.Clamp(this.weight, 0f, 1f);
			this.OnModifyOffset();
			this.lastTime = Time.time;
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00020A1D File Offset: 0x0001EC1D
		protected virtual void OnDestroy()
		{
			if (this.ik != null)
			{
				IKSolverVR solver = this.ik.solver;
				solver.OnPreUpdate = (IKSolver.UpdateDelegate)Delegate.Remove(solver.OnPreUpdate, new IKSolver.UpdateDelegate(this.ModifyOffset));
			}
		}

		// Token: 0x040003C9 RID: 969
		[Tooltip("The master weight")]
		public float weight = 1f;

		// Token: 0x040003CA RID: 970
		[Tooltip("Reference to the VRIK component")]
		public VRIK ik;

		// Token: 0x040003CB RID: 971
		private float lastTime;
	}
}
