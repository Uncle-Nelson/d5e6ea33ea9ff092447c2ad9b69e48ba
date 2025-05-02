using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000046 RID: 70
	[Serializable]
	public class FABRIKChain
	{
		// Token: 0x0600024A RID: 586 RVA: 0x0000CA58 File Offset: 0x0000AC58
		public bool IsValid(ref string message)
		{
			if (this.ik == null)
			{
				message = "IK unassigned in FABRIKChain.";
				return false;
			}
			return this.ik.solver.IsValid(ref message);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000CA87 File Offset: 0x0000AC87
		public void Initiate()
		{
			this.ik.enabled = false;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0000CA98 File Offset: 0x0000AC98
		public void Stage1(FABRIKChain[] chain)
		{
			for (int i = 0; i < this.children.Length; i++)
			{
				chain[this.children[i]].Stage1(chain);
			}
			if (this.children.Length == 0)
			{
				this.ik.solver.SolveForward(this.ik.solver.GetIKPosition());
				return;
			}
			this.ik.solver.SolveForward(this.GetCentroid(chain));
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0000CB0C File Offset: 0x0000AD0C
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
			this.ik.solver.SolveBackward(rootPosition);
			for (int i = 0; i < this.children.Length; i++)
			{
				chain[this.children[i]].Stage2(this.ik.solver.bones[this.ik.solver.bones.Length - 1].transform.position, chain);
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000CB7C File Offset: 0x0000AD7C
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			Vector3 ikposition = this.ik.solver.GetIKPosition();
			if (this.pin >= 1f)
			{
				return ikposition;
			}
			float num = 0f;
			for (int i = 0; i < this.children.Length; i++)
			{
				num += chain[this.children[i]].pull;
			}
			if (num <= 0f)
			{
				return ikposition;
			}
			if (num < 1f)
			{
				num = 1f;
			}
			Vector3 vector = ikposition;
			for (int j = 0; j < this.children.Length; j++)
			{
				Vector3 a = chain[this.children[j]].ik.solver.bones[0].solverPosition - ikposition;
				float d = chain[this.children[j]].pull / num;
				vector += a * d;
			}
			if (this.pin <= 0f)
			{
				return vector;
			}
			return vector + (ikposition - vector) * this.pin;
		}

		// Token: 0x04000188 RID: 392
		public FABRIK ik;

		// Token: 0x04000189 RID: 393
		[Range(0f, 1f)]
		public float pull = 1f;

		// Token: 0x0400018A RID: 394
		[Range(0f, 1f)]
		public float pin = 1f;

		// Token: 0x0400018B RID: 395
		public int[] children = new int[0];
	}
}
