using System;
using UnityEngine;
using UnityEngine.Playables;

namespace RootMotion
{
	// Token: 0x0200000D RID: 13
	public class HumanoidBaker : Baker
	{
		// Token: 0x06000053 RID: 83 RVA: 0x00003C6C File Offset: 0x00001E6C
		private void Awake()
		{
			this.animator = base.GetComponent<Animator>();
			this.director = base.GetComponent<PlayableDirector>();
			if (this.mode == Baker.Mode.AnimationStates || this.mode == Baker.Mode.AnimationClips)
			{
				if (this.animator == null || !this.animator.isHuman)
				{
					Debug.LogError("HumanoidBaker GameObject does not have a Humanoid Animator component, can not bake.");
					base.enabled = false;
					return;
				}
				this.animator.cullingMode = AnimatorCullingMode.AlwaysAnimate;
			}
			else if (this.mode == Baker.Mode.PlayableDirector && this.director == null)
			{
				Debug.LogError("HumanoidBaker GameObject does not have a PlayableDirector component, can not bake.");
			}
			this.muscles = new float[HumanTrait.MuscleCount];
			this.bakerMuscles = new BakerMuscle[HumanTrait.MuscleCount];
			for (int i = 0; i < this.bakerMuscles.Length; i++)
			{
				this.bakerMuscles[i] = new BakerMuscle(i);
			}
			this.rootQT = new BakerHumanoidQT("Root");
			this.leftFootQT = new BakerHumanoidQT(this.animator.GetBoneTransform(HumanBodyBones.LeftFoot), AvatarIKGoal.LeftFoot, "LeftFoot");
			this.rightFootQT = new BakerHumanoidQT(this.animator.GetBoneTransform(HumanBodyBones.RightFoot), AvatarIKGoal.RightFoot, "RightFoot");
			this.leftHandQT = new BakerHumanoidQT(this.animator.GetBoneTransform(HumanBodyBones.LeftHand), AvatarIKGoal.LeftHand, "LeftHand");
			this.rightHandQT = new BakerHumanoidQT(this.animator.GetBoneTransform(HumanBodyBones.RightHand), AvatarIKGoal.RightHand, "RightHand");
			this.handler = new HumanPoseHandler(this.animator.avatar, this.animator.transform);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003DE6 File Offset: 0x00001FE6
		protected override Transform GetCharacterRoot()
		{
			return this.animator.transform;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00003DF4 File Offset: 0x00001FF4
		protected override void OnStartBaking()
		{
			this.rootQT.Reset();
			this.leftFootQT.Reset();
			this.rightFootQT.Reset();
			this.leftHandQT.Reset();
			this.rightHandQT.Reset();
			for (int i = 0; i < this.bakerMuscles.Length; i++)
			{
				this.bakerMuscles[i].Reset();
			}
			this.mN = this.muscleFrameRateDiv;
			this.lastBodyRotation = Quaternion.identity;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003E70 File Offset: 0x00002070
		protected override void OnSetLoopFrame(float time)
		{
			for (int i = 0; i < this.bakerMuscles.Length; i++)
			{
				this.bakerMuscles[i].SetLoopFrame(time);
			}
			this.rootQT.MoveLastKeyframes(time);
			this.leftFootQT.SetLoopFrame(time);
			this.rightFootQT.SetLoopFrame(time);
			this.leftHandQT.SetLoopFrame(time);
			this.rightHandQT.SetLoopFrame(time);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003EDC File Offset: 0x000020DC
		protected override void OnSetCurves(ref AnimationClip clip)
		{
			float time = this.bakerMuscles[0].curve.keys[this.bakerMuscles[0].curve.keys.Length - 1].time;
			float lengthMlp = (this.mode != Baker.Mode.Realtime) ? (base.clipLength / time) : 1f;
			for (int i = 0; i < this.bakerMuscles.Length; i++)
			{
				this.bakerMuscles[i].SetCurves(ref clip, this.keyReductionError, lengthMlp);
			}
			this.rootQT.SetCurves(ref clip, this.IKKeyReductionError, lengthMlp);
			this.leftFootQT.SetCurves(ref clip, this.IKKeyReductionError, lengthMlp);
			this.rightFootQT.SetCurves(ref clip, this.IKKeyReductionError, lengthMlp);
			if (this.bakeHandIK)
			{
				this.leftHandQT.SetCurves(ref clip, this.IKKeyReductionError, lengthMlp);
				this.rightHandQT.SetCurves(ref clip, this.IKKeyReductionError, lengthMlp);
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003FC4 File Offset: 0x000021C4
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
			this.mN++;
			bool flag = true;
			if (this.mN < this.muscleFrameRateDiv && !lastFrame)
			{
				flag = false;
			}
			if (this.mN >= this.muscleFrameRateDiv)
			{
				this.mN = 0;
			}
			this.UpdateHumanPose();
			if (flag)
			{
				for (int i = 0; i < this.bakerMuscles.Length; i++)
				{
					this.bakerMuscles[i].SetKeyframe(time, this.muscles);
				}
			}
			this.rootQT.SetKeyframes(time, this.bodyPosition, this.bodyRotation);
			Vector3 vector = this.bodyPosition * this.animator.humanScale;
			this.leftFootQT.SetIKKeyframes(time, this.animator.avatar, this.animator.transform, this.animator.humanScale, vector, this.bodyRotation);
			this.rightFootQT.SetIKKeyframes(time, this.animator.avatar, this.animator.transform, this.animator.humanScale, vector, this.bodyRotation);
			this.leftHandQT.SetIKKeyframes(time, this.animator.avatar, this.animator.transform, this.animator.humanScale, vector, this.bodyRotation);
			this.rightHandQT.SetIKKeyframes(time, this.animator.avatar, this.animator.transform, this.animator.humanScale, vector, this.bodyRotation);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00004138 File Offset: 0x00002338
		private void UpdateHumanPose()
		{
			this.handler.GetHumanPose(ref this.pose);
			this.bodyPosition = this.pose.bodyPosition;
			this.bodyRotation = this.pose.bodyRotation;
			this.bodyRotation = BakerUtilities.EnsureQuaternionContinuity(this.lastBodyRotation, this.bodyRotation);
			this.lastBodyRotation = this.bodyRotation;
			for (int i = 0; i < this.pose.muscles.Length; i++)
			{
				this.muscles[i] = this.pose.muscles[i];
			}
		}

		// Token: 0x04000044 RID: 68
		[Tooltip("Should the hand IK curves be added to the animation? Disable this if the original hand positions are not important when using the clip on another character via Humanoid retargeting.")]
		public bool bakeHandIK = true;

		// Token: 0x04000045 RID: 69
		[Tooltip("Max keyframe reduction error for the Root.Q/T, LeftFoot IK and RightFoot IK channels. Having a larger error value for 'Key Reduction Error' and a smaller one for this enables you to optimize clip data size without the floating feet effect by enabling 'Foot IK' in the Animator.")]
		[Range(0f, 0.1f)]
		public float IKKeyReductionError;

		// Token: 0x04000046 RID: 70
		[Tooltip("Frame rate divider for the muscle curves. If you have 'Frame Rate' set to 30, and this value set to 3, the muscle curves will be baked at 10 fps. Only the Root Q/T and Hand and Foot IK curves will be baked at 30. This enables you to optimize clip data size without the floating feet effect by enabling 'Foot IK' in the Animator.")]
		[Range(1f, 9f)]
		public int muscleFrameRateDiv = 1;

		// Token: 0x04000047 RID: 71
		private BakerMuscle[] bakerMuscles;

		// Token: 0x04000048 RID: 72
		private BakerHumanoidQT rootQT;

		// Token: 0x04000049 RID: 73
		private BakerHumanoidQT leftFootQT;

		// Token: 0x0400004A RID: 74
		private BakerHumanoidQT rightFootQT;

		// Token: 0x0400004B RID: 75
		private BakerHumanoidQT leftHandQT;

		// Token: 0x0400004C RID: 76
		private BakerHumanoidQT rightHandQT;

		// Token: 0x0400004D RID: 77
		private float[] muscles = new float[0];

		// Token: 0x0400004E RID: 78
		private HumanPose pose;

		// Token: 0x0400004F RID: 79
		private HumanPoseHandler handler;

		// Token: 0x04000050 RID: 80
		private Vector3 bodyPosition;

		// Token: 0x04000051 RID: 81
		private Quaternion bodyRotation = Quaternion.identity;

		// Token: 0x04000052 RID: 82
		private int mN;

		// Token: 0x04000053 RID: 83
		private Quaternion lastBodyRotation = Quaternion.identity;
	}
}
