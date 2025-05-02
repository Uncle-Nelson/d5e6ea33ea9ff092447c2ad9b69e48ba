using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000063 RID: 99
	[Serializable]
	public class InteractionLookAt
	{
		// Token: 0x060003E5 RID: 997 RVA: 0x0001B34C File Offset: 0x0001954C
		public void Look(Transform target, float time)
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.IKPositionWeight <= 0f)
			{
				this.ik.solver.IKPosition = this.ik.solver.GetRoot().position + this.ik.solver.GetRoot().forward * 3f;
			}
			this.lookAtTarget = target;
			this.stopLookTime = time;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0001B3D6 File Offset: 0x000195D6
		public void OnFixTransforms()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.fixTransforms)
			{
				this.ik.solver.FixTransforms();
			}
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0001B404 File Offset: 0x00019604
		public void Update()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.enabled)
			{
				this.ik.enabled = false;
			}
			if (this.lookAtTarget == null)
			{
				return;
			}
			if (this.isPaused)
			{
				this.stopLookTime += Time.deltaTime;
			}
			float num = (Time.time < this.stopLookTime) ? this.weightSpeed : (-this.weightSpeed);
			this.weight = Mathf.Clamp(this.weight + num * Time.deltaTime, 0f, 1f);
			this.ik.solver.IKPositionWeight = Interp.Float(this.weight, InterpolationMode.InOutQuintic);
			this.ik.solver.IKPosition = Vector3.Lerp(this.ik.solver.IKPosition, this.lookAtTarget.position, this.lerpSpeed * Time.deltaTime);
			if (this.weight <= 0f)
			{
				this.lookAtTarget = null;
			}
			this.firstFBBIKSolve = true;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0001B518 File Offset: 0x00019718
		public void SolveSpine()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float headWeight = this.ik.solver.headWeight;
			float eyesWeight = this.ik.solver.eyesWeight;
			this.ik.solver.headWeight = 0f;
			this.ik.solver.eyesWeight = 0f;
			this.ik.solver.Update();
			this.ik.solver.headWeight = headWeight;
			this.ik.solver.eyesWeight = eyesWeight;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0001B5BC File Offset: 0x000197BC
		public void SolveHead()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.firstFBBIKSolve)
			{
				return;
			}
			float bodyWeight = this.ik.solver.bodyWeight;
			this.ik.solver.bodyWeight = 0f;
			this.ik.solver.Update();
			this.ik.solver.bodyWeight = bodyWeight;
			this.firstFBBIKSolve = false;
		}

		// Token: 0x04000312 RID: 786
		[Tooltip("(Optional) reference to the LookAtIK component that will be used to make the character look at the objects that it is interacting with.")]
		public LookAtIK ik;

		// Token: 0x04000313 RID: 787
		[Tooltip("Interpolation speed of the LookAtIK target.")]
		public float lerpSpeed = 5f;

		// Token: 0x04000314 RID: 788
		[Tooltip("Interpolation speed of the LookAtIK weight.")]
		public float weightSpeed = 1f;

		// Token: 0x04000315 RID: 789
		[HideInInspector]
		public bool isPaused;

		// Token: 0x04000316 RID: 790
		private Transform lookAtTarget;

		// Token: 0x04000317 RID: 791
		private float stopLookTime;

		// Token: 0x04000318 RID: 792
		private float weight;

		// Token: 0x04000319 RID: 793
		private bool firstFBBIKSolve;
	}
}
