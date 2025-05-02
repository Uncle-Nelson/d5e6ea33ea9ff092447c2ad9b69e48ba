using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000099 RID: 153
	public class FBIKBendGoal : MonoBehaviour
	{
		// Token: 0x06000582 RID: 1410 RVA: 0x0002577C File Offset: 0x0002397C
		private void Start()
		{
			Debug.Log("FBIKBendGoal is deprecated, you can now a bend goal from the custom inspector of the FullBodyBipedIK component.");
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00025788 File Offset: 0x00023988
		private void Update()
		{
			if (this.ik == null)
			{
				return;
			}
			this.ik.solver.GetBendConstraint(this.chain).bendGoal = base.transform;
			this.ik.solver.GetBendConstraint(this.chain).weight = this.weight;
		}

		// Token: 0x0400048B RID: 1163
		public FullBodyBipedIK ik;

		// Token: 0x0400048C RID: 1164
		public FullBodyBipedChain chain;

		// Token: 0x0400048D RID: 1165
		public float weight;
	}
}
