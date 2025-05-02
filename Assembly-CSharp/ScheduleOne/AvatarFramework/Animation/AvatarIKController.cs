using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Animation
{
	// Token: 0x02000999 RID: 2457
	public class AvatarIKController : MonoBehaviour
	{
		// Token: 0x0600429A RID: 17050 RVA: 0x00117420 File Offset: 0x00115620
		private void Awake()
		{
			this.BodyIK.InitiateBipedIK();
			this.defaultLeftLegBendTarget = this.BodyIK.solvers.leftFoot.bendGoal;
			this.defaultRightLegBendTarget = this.BodyIK.solvers.rightFoot.bendGoal;
		}

		// Token: 0x0600429B RID: 17051 RVA: 0x0011746E File Offset: 0x0011566E
		private void Start()
		{
			this.SetIKActive(false);
		}

		// Token: 0x0600429C RID: 17052 RVA: 0x00117477 File Offset: 0x00115677
		public void SetIKActive(bool active)
		{
			this.BodyIK.enabled = active;
		}

		// Token: 0x0600429D RID: 17053 RVA: 0x00117485 File Offset: 0x00115685
		public void OverrideLegBendTargets(Transform leftLegTarget, Transform rightLegTarget)
		{
			this.BodyIK.solvers.leftFoot.bendGoal = leftLegTarget;
			this.BodyIK.solvers.rightFoot.bendGoal = rightLegTarget;
		}

		// Token: 0x0600429E RID: 17054 RVA: 0x001174B3 File Offset: 0x001156B3
		public void ResetLegBendTargets()
		{
			this.BodyIK.solvers.leftFoot.bendGoal = this.defaultLeftLegBendTarget;
			this.BodyIK.solvers.rightFoot.bendGoal = this.defaultRightLegBendTarget;
		}

		// Token: 0x04003041 RID: 12353
		[Header("References")]
		public BipedIK BodyIK;

		// Token: 0x04003042 RID: 12354
		private Transform defaultLeftLegBendTarget;

		// Token: 0x04003043 RID: 12355
		private Transform defaultRightLegBendTarget;
	}
}
