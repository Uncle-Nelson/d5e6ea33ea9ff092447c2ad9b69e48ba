using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000098 RID: 152
	public class FBBIKSettings : MonoBehaviour
	{
		// Token: 0x0600057E RID: 1406 RVA: 0x00025694 File Offset: 0x00023894
		public void UpdateSettings()
		{
			if (this.ik == null)
			{
				return;
			}
			this.leftArm.Apply(FullBodyBipedChain.LeftArm, this.ik.solver);
			this.rightArm.Apply(FullBodyBipedChain.RightArm, this.ik.solver);
			this.leftLeg.Apply(FullBodyBipedChain.LeftLeg, this.ik.solver);
			this.rightLeg.Apply(FullBodyBipedChain.RightLeg, this.ik.solver);
			this.ik.solver.chain[0].pin = this.rootPin;
			this.ik.solver.bodyEffector.effectChildNodes = this.bodyEffectChildNodes;
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00025744 File Offset: 0x00023944
		private void Start()
		{
			Debug.Log("FBBIKSettings is deprecated, you can now edit all the settings from the custom inspector of the FullBodyBipedIK component.");
			this.UpdateSettings();
			if (this.disableAfterStart)
			{
				base.enabled = false;
			}
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00025765 File Offset: 0x00023965
		private void Update()
		{
			this.UpdateSettings();
		}

		// Token: 0x04000483 RID: 1155
		public FullBodyBipedIK ik;

		// Token: 0x04000484 RID: 1156
		public bool disableAfterStart;

		// Token: 0x04000485 RID: 1157
		public FBBIKSettings.Limb leftArm;

		// Token: 0x04000486 RID: 1158
		public FBBIKSettings.Limb rightArm;

		// Token: 0x04000487 RID: 1159
		public FBBIKSettings.Limb leftLeg;

		// Token: 0x04000488 RID: 1160
		public FBBIKSettings.Limb rightLeg;

		// Token: 0x04000489 RID: 1161
		public float rootPin;

		// Token: 0x0400048A RID: 1162
		public bool bodyEffectChildNodes = true;

		// Token: 0x0200011F RID: 287
		[Serializable]
		public class Limb
		{
			// Token: 0x06000817 RID: 2071 RVA: 0x00034E56 File Offset: 0x00033056
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
				solver.GetChain(chain).reachSmoothing = this.reachSmoothing;
				solver.GetEndEffector(chain).maintainRelativePositionWeight = this.maintainRelativePositionWeight;
				solver.GetLimbMapping(chain).weight = this.mappingWeight;
			}

			// Token: 0x0400084A RID: 2122
			public FBIKChain.Smoothing reachSmoothing;

			// Token: 0x0400084B RID: 2123
			public float maintainRelativePositionWeight;

			// Token: 0x0400084C RID: 2124
			public float mappingWeight = 1f;
		}
	}
}
