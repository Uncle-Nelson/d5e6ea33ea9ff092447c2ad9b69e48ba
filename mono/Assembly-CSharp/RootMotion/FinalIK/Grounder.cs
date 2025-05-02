using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000033 RID: 51
	public abstract class Grounder : MonoBehaviour
	{
		// Token: 0x06000194 RID: 404
		public abstract void ResetPosition();

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000195 RID: 405 RVA: 0x000098B3 File Offset: 0x00007AB3
		// (set) Token: 0x06000196 RID: 406 RVA: 0x000098BB File Offset: 0x00007ABB
		public bool initiated { get; protected set; }

		// Token: 0x06000197 RID: 407 RVA: 0x000098C4 File Offset: 0x00007AC4
		protected Vector3 GetSpineOffsetTarget()
		{
			Vector3 vector = Vector3.zero;
			for (int i = 0; i < this.solver.legs.Length; i++)
			{
				vector += this.GetLegSpineBendVector(this.solver.legs[i]);
			}
			return vector;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000990A File Offset: 0x00007B0A
		protected void LogWarning(string message)
		{
			Warning.Log(message, base.transform, false);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000991C File Offset: 0x00007B1C
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			Vector3 legSpineTangent = this.GetLegSpineTangent(leg);
			float d = (Vector3.Dot(this.solver.root.forward, legSpineTangent.normalized) + 1f) * 0.5f;
			float magnitude = (leg.IKPosition - leg.transform.position).magnitude;
			return legSpineTangent * magnitude * d;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00009988 File Offset: 0x00007B88
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			Vector3 vector = leg.transform.position - this.solver.root.position;
			if (!this.solver.rotateSolver || this.solver.root.up == Vector3.up)
			{
				return new Vector3(vector.x, 0f, vector.z);
			}
			Vector3 up = this.solver.root.up;
			Vector3.OrthoNormalize(ref up, ref vector);
			return vector;
		}

		// Token: 0x0600019B RID: 411
		protected abstract void OpenUserManual();

		// Token: 0x0600019C RID: 412
		protected abstract void OpenScriptReference();

		// Token: 0x0400011C RID: 284
		[Tooltip("The master weight. Use this to fade in/out the grounding effect.")]
		[Range(0f, 1f)]
		public float weight = 1f;

		// Token: 0x0400011D RID: 285
		[Tooltip("The Grounding solver. Not to confuse with IK solvers.")]
		public Grounding solver = new Grounding();

		// Token: 0x0400011E RID: 286
		public Grounder.GrounderDelegate OnPreGrounder;

		// Token: 0x0400011F RID: 287
		public Grounder.GrounderDelegate OnPostGrounder;

		// Token: 0x04000120 RID: 288
		public Grounder.GrounderDelegate OnPostIK;

		// Token: 0x020000D5 RID: 213
		// (Invoke) Token: 0x06000669 RID: 1641
		public delegate void GrounderDelegate();
	}
}
