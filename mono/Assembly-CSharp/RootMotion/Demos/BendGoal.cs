using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020000B5 RID: 181
	public class BendGoal : MonoBehaviour
	{
		// Token: 0x060005F0 RID: 1520 RVA: 0x00028280 File Offset: 0x00026480
		private void Start()
		{
			Debug.Log("BendGoal is deprecated, you can now a bend goal from the custom inspector of the LimbIK component.");
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x0002828C File Offset: 0x0002648C
		private void LateUpdate()
		{
			if (this.limbIK == null)
			{
				return;
			}
			this.limbIK.solver.SetBendGoalPosition(base.transform.position, this.weight);
		}

		// Token: 0x04000524 RID: 1316
		public LimbIK limbIK;

		// Token: 0x04000525 RID: 1317
		[Range(0f, 1f)]
		public float weight = 1f;
	}
}
