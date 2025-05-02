using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x0200008C RID: 140
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		// Token: 0x06000543 RID: 1347 RVA: 0x00023660 File Offset: 0x00021860
		private void OnAnimatorIK(int layer)
		{
			this.animator.transform.rotation = this.bipedIK.transform.rotation;
			Vector3 b = this.animator.transform.position - this.bipedIK.transform.position;
			this.lookAtTargetAnimator.position = this.lookAtTargetBiped.position + b;
			this.bipedIK.SetLookAtPosition(this.lookAtTargetBiped.position);
			this.bipedIK.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight, this.lookAtClampWeightHead, this.lookAtClampWeightEyes);
			this.animator.SetLookAtPosition(this.lookAtTargetAnimator.position);
			this.animator.SetLookAtWeight(this.lookAtWeight, this.lookAtBodyWeight, this.lookAtHeadWeight, this.lookAtEyesWeight, this.lookAtClampWeight);
			this.footTargetAnimator.position = this.footTargetBiped.position + b;
			this.footTargetAnimator.rotation = this.footTargetBiped.rotation;
			this.bipedIK.SetIKPosition(AvatarIKGoal.LeftFoot, this.footTargetBiped.position);
			this.bipedIK.SetIKRotation(AvatarIKGoal.LeftFoot, this.footTargetBiped.rotation);
			this.bipedIK.SetIKPositionWeight(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.bipedIK.SetIKRotationWeight(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.LeftFoot, this.footTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.LeftFoot, this.footTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, this.footPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, this.footRotationWeight);
			this.handTargetAnimator.position = this.handTargetBiped.position + b;
			this.handTargetAnimator.rotation = this.handTargetBiped.rotation;
			this.bipedIK.SetIKPosition(AvatarIKGoal.LeftHand, this.handTargetBiped.position);
			this.bipedIK.SetIKRotation(AvatarIKGoal.LeftHand, this.handTargetBiped.rotation);
			this.bipedIK.SetIKPositionWeight(AvatarIKGoal.LeftHand, this.handPositionWeight);
			this.bipedIK.SetIKRotationWeight(AvatarIKGoal.LeftHand, this.handRotationWeight);
			this.animator.SetIKPosition(AvatarIKGoal.LeftHand, this.handTargetAnimator.position);
			this.animator.SetIKRotation(AvatarIKGoal.LeftHand, this.handTargetAnimator.rotation);
			this.animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, this.handPositionWeight);
			this.animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, this.handRotationWeight);
		}

		// Token: 0x04000412 RID: 1042
		[LargeHeader("References")]
		public Animator animator;

		// Token: 0x04000413 RID: 1043
		public BipedIK bipedIK;

		// Token: 0x04000414 RID: 1044
		[LargeHeader("Look At")]
		public Transform lookAtTargetBiped;

		// Token: 0x04000415 RID: 1045
		public Transform lookAtTargetAnimator;

		// Token: 0x04000416 RID: 1046
		[Range(0f, 1f)]
		public float lookAtWeight = 1f;

		// Token: 0x04000417 RID: 1047
		[Range(0f, 1f)]
		public float lookAtBodyWeight = 1f;

		// Token: 0x04000418 RID: 1048
		[Range(0f, 1f)]
		public float lookAtHeadWeight = 1f;

		// Token: 0x04000419 RID: 1049
		[Range(0f, 1f)]
		public float lookAtEyesWeight = 1f;

		// Token: 0x0400041A RID: 1050
		[Range(0f, 1f)]
		public float lookAtClampWeight = 0.5f;

		// Token: 0x0400041B RID: 1051
		[Range(0f, 1f)]
		public float lookAtClampWeightHead = 0.5f;

		// Token: 0x0400041C RID: 1052
		[Range(0f, 1f)]
		public float lookAtClampWeightEyes = 0.5f;

		// Token: 0x0400041D RID: 1053
		[LargeHeader("Foot")]
		public Transform footTargetBiped;

		// Token: 0x0400041E RID: 1054
		public Transform footTargetAnimator;

		// Token: 0x0400041F RID: 1055
		[Range(0f, 1f)]
		public float footPositionWeight;

		// Token: 0x04000420 RID: 1056
		[Range(0f, 1f)]
		public float footRotationWeight;

		// Token: 0x04000421 RID: 1057
		[LargeHeader("Hand")]
		public Transform handTargetBiped;

		// Token: 0x04000422 RID: 1058
		public Transform handTargetAnimator;

		// Token: 0x04000423 RID: 1059
		[Range(0f, 1f)]
		public float handPositionWeight;

		// Token: 0x04000424 RID: 1060
		[Range(0f, 1f)]
		public float handRotationWeight;
	}
}
