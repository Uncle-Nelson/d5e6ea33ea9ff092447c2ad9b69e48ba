using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Skating
{
	// Token: 0x020002CD RID: 717
	public class SkateboardAnimation : MonoBehaviour
	{
		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000F78 RID: 3960 RVA: 0x000448C5 File Offset: 0x00042AC5
		public float CurrentCrouchShift
		{
			get
			{
				return this.currentCrouchShift;
			}
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x000448D0 File Offset: 0x00042AD0
		private void Awake()
		{
			this.board = base.GetComponent<Skateboard>();
			this.board.OnPushStart.AddListener(new UnityAction(this.OnPushStart));
			this.pelvisDefaultPosition = this.PelvisAlignment.Transform.localPosition;
			this.pelvisDefaultRotation = this.PelvisAlignment.Transform.localRotation;
			this.spineDefaultPosition = this.SpineAlignment.Transform.localPosition;
			this.alignmentSets.Add(this.PelvisContainerAlignment);
			this.alignmentSets.Add(this.PelvisAlignment);
			this.alignmentSets.Add(this.SpineContainerAlignment);
			this.alignmentSets.Add(this.SpineAlignment);
			this.alignmentSets.Add(this.LeftFootAlignment);
			this.alignmentSets.Add(this.RightFootAlignment);
			this.alignmentSets.Add(this.LeftLegBendTarget);
			this.alignmentSets.Add(this.RightLegBendTarget);
			this.alignmentSets.Add(this.LeftHandAlignment);
			this.alignmentSets.Add(this.RightHandAlignment);
			this.alignmentSets.Add(this.LeftHandLoweredAlignment);
			this.alignmentSets.Add(this.LeftHandRaisedAlignment);
			this.alignmentSets.Add(this.RightHandLoweredAlignment);
			this.alignmentSets.Add(this.RightHandRaisedAlignment);
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x00044A35 File Offset: 0x00042C35
		private void Update()
		{
			this.UpdateIKBlend();
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x00044A3D File Offset: 0x00042C3D
		private void LateUpdate()
		{
			this.UpdateBodyAlignment();
			this.UpdateArmLift();
			this.UpdatePelvisRotation();
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x000045B1 File Offset: 0x000027B1
		private void FixedUpdate()
		{
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x00044A54 File Offset: 0x00042C54
		private void UpdateIKBlend()
		{
			if (this.board.IsPushing || (this.board.TimeSincePushStart < this.PushAnimationDuration && this.board.JumpBuildAmount < 0.1f))
			{
				this.ikBlend = Mathf.Lerp(this.ikBlend, 1f, Time.deltaTime * this.IKBlendChangeRate);
			}
			else
			{
				this.ikBlend = Mathf.Lerp(this.ikBlend, 0f, Time.deltaTime * this.IKBlendChangeRate);
			}
			foreach (SkateboardAnimation.AlignmentSet alignmentSet in this.alignmentSets)
			{
				alignmentSet.Transform.localPosition = Vector3.Lerp(alignmentSet.Default.localPosition, alignmentSet.Animated.localPosition, this.ikBlend);
				alignmentSet.Transform.localRotation = Quaternion.Lerp(alignmentSet.Default.localRotation, alignmentSet.Animated.localRotation, this.ikBlend);
			}
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x00044B70 File Offset: 0x00042D70
		private void UpdateBodyAlignment()
		{
			Vector3 vector = this.PelvisAlignment.Transform.parent.TransformPoint(new Vector3(this.pelvisDefaultPosition.x, 0f, this.pelvisDefaultPosition.z));
			Vector3 a = new Vector3(0f, this.pelvisDefaultPosition.y, 0f);
			Vector3 b = base.transform.up * this.pelvisDefaultPosition.y;
			vector += Vector3.Lerp(a, b, this.PelvisOffsetBlend);
			float jumpBuildAmount = this.board.JumpBuildAmount;
			float b2 = Mathf.Clamp01(this.board.CurrentSpeed_Kmh / this.board.TopSpeed_Kmh) * 0.1f;
			float b3 = Mathf.Max(jumpBuildAmount, b2);
			this.currentCrouchShift = Mathf.Lerp(this.currentCrouchShift, b3, Time.deltaTime * this.CrouchSpeed);
			vector.y -= this.currentCrouchShift * this.JumpCrouchAmount;
			float b4 = Mathf.Clamp(-this.board.Accelerometer.Acceleration.y * this.VerticalMomentumMultiplier, -this.VerticalMomentumOffsetClamp, 0f);
			this.currentMomentumOffset = Mathf.Lerp(this.currentMomentumOffset, b4, Time.deltaTime * this.MomentumMoveSpeed);
			vector.y += this.currentMomentumOffset;
			this.PelvisAlignment.Transform.position = vector;
			this.SpineAlignment.Transform.localPosition = Vector3.Lerp(this.spineDefaultPosition, this.SpineAlignment_Hunched.localPosition, this.currentCrouchShift);
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x00044D0C File Offset: 0x00042F0C
		private void UpdateArmLift()
		{
			float jumpBuildAmount = this.board.JumpBuildAmount;
			float num = Mathf.Clamp01(this.board.CurrentSpeed_Kmh / this.board.TopSpeed_Kmh) * 0f;
			float num2 = Mathf.Abs(this.board.CurrentSteerInput) * 0f;
			this.SetArmLift(Mathf.Max(new float[]
			{
				jumpBuildAmount,
				num,
				num2
			}));
			this.currentArmLift = Mathf.Lerp(this.currentArmLift, this.targetArmLift, Time.deltaTime * this.ArmLiftRate);
			this.RightHandAlignment.Transform.localPosition = Vector3.Lerp(this.RightHandLoweredAlignment.Transform.localPosition, this.RightHandRaisedAlignment.Transform.localPosition, this.currentArmLift);
			this.RightHandAlignment.Transform.localRotation = Quaternion.Lerp(this.RightHandLoweredAlignment.Transform.localRotation, this.RightHandRaisedAlignment.Transform.localRotation, this.currentArmLift);
			this.LeftHandAlignment.Transform.localPosition = Vector3.Lerp(this.LeftHandLoweredAlignment.Transform.localPosition, this.LeftHandRaisedAlignment.Transform.localPosition, this.currentArmLift);
			this.LeftHandAlignment.Transform.localRotation = Quaternion.Lerp(this.LeftHandLoweredAlignment.Transform.localRotation, this.LeftHandRaisedAlignment.Transform.localRotation, this.currentArmLift);
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x00044E8C File Offset: 0x0004308C
		private void UpdatePelvisRotation()
		{
			float num = this.board.CurrentSteerInput * this.PelvisMaxRotation;
			Quaternion b = this.pelvisDefaultRotation * Quaternion.AngleAxis(num, Vector3.up);
			this.PelvisAlignment.Transform.localRotation = Quaternion.Lerp(this.PelvisAlignment.Transform.localRotation, b, Time.deltaTime * 5f);
			this.HandContainer.localRotation = Quaternion.Lerp(this.HandContainer.localRotation, Quaternion.Euler(num, 0f, 0f), Time.deltaTime * 5f);
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x00044F2A File Offset: 0x0004312A
		public void SetArmLift(float lift)
		{
			this.targetArmLift = lift;
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x00044F33 File Offset: 0x00043133
		private void OnPushStart()
		{
			this.IKAnimation.Stop();
			this.IKAnimation["Skateboard push"].speed = this.PushAnimationSpeed;
			this.IKAnimation.Play("Skateboard push");
		}

		// Token: 0x04000FFC RID: 4092
		[Header("Settings")]
		public float JumpCrouchAmount = 0.4f;

		// Token: 0x04000FFD RID: 4093
		public float CrouchSpeed = 4f;

		// Token: 0x04000FFE RID: 4094
		public float ArmLiftRate = 5f;

		// Token: 0x04000FFF RID: 4095
		public float PelvisMaxRotation = 10f;

		// Token: 0x04001000 RID: 4096
		public float HandsMaxRotation = 10f;

		// Token: 0x04001001 RID: 4097
		public float PelvisOffsetBlend;

		// Token: 0x04001002 RID: 4098
		public float VerticalMomentumMultiplier = 0.5f;

		// Token: 0x04001003 RID: 4099
		public float VerticalMomentumOffsetClamp = 0.3f;

		// Token: 0x04001004 RID: 4100
		public float MomentumMoveSpeed = 5f;

		// Token: 0x04001005 RID: 4101
		public float IKBlendChangeRate = 3f;

		// Token: 0x04001006 RID: 4102
		public float PushAnimationDuration = 1.1f;

		// Token: 0x04001007 RID: 4103
		public float PushAnimationSpeed = 1.3f;

		// Token: 0x04001008 RID: 4104
		[Header("References")]
		public SkateboardAnimation.AlignmentSet PelvisContainerAlignment;

		// Token: 0x04001009 RID: 4105
		public SkateboardAnimation.AlignmentSet PelvisAlignment;

		// Token: 0x0400100A RID: 4106
		public SkateboardAnimation.AlignmentSet SpineContainerAlignment;

		// Token: 0x0400100B RID: 4107
		public SkateboardAnimation.AlignmentSet SpineAlignment;

		// Token: 0x0400100C RID: 4108
		public Transform SpineAlignment_Hunched;

		// Token: 0x0400100D RID: 4109
		public SkateboardAnimation.AlignmentSet LeftFootAlignment;

		// Token: 0x0400100E RID: 4110
		public SkateboardAnimation.AlignmentSet RightFootAlignment;

		// Token: 0x0400100F RID: 4111
		public SkateboardAnimation.AlignmentSet LeftLegBendTarget;

		// Token: 0x04001010 RID: 4112
		public SkateboardAnimation.AlignmentSet RightLegBendTarget;

		// Token: 0x04001011 RID: 4113
		public SkateboardAnimation.AlignmentSet LeftHandAlignment;

		// Token: 0x04001012 RID: 4114
		public SkateboardAnimation.AlignmentSet RightHandAlignment;

		// Token: 0x04001013 RID: 4115
		public Transform AvatarFaceTarget;

		// Token: 0x04001014 RID: 4116
		public Transform HandContainer;

		// Token: 0x04001015 RID: 4117
		public Animation IKAnimation;

		// Token: 0x04001016 RID: 4118
		[Header("Arm Lift")]
		public SkateboardAnimation.AlignmentSet LeftHandLoweredAlignment;

		// Token: 0x04001017 RID: 4119
		public SkateboardAnimation.AlignmentSet LeftHandRaisedAlignment;

		// Token: 0x04001018 RID: 4120
		public SkateboardAnimation.AlignmentSet RightHandLoweredAlignment;

		// Token: 0x04001019 RID: 4121
		public SkateboardAnimation.AlignmentSet RightHandRaisedAlignment;

		// Token: 0x0400101A RID: 4122
		private Skateboard board;

		// Token: 0x0400101B RID: 4123
		private float currentCrouchShift;

		// Token: 0x0400101C RID: 4124
		private float targetArmLift;

		// Token: 0x0400101D RID: 4125
		private float currentArmLift;

		// Token: 0x0400101E RID: 4126
		private Quaternion pelvisDefaultRotation;

		// Token: 0x0400101F RID: 4127
		private Vector3 pelvisDefaultPosition;

		// Token: 0x04001020 RID: 4128
		private Vector3 spineDefaultPosition;

		// Token: 0x04001021 RID: 4129
		private float currentMomentumOffset;

		// Token: 0x04001022 RID: 4130
		private float ikBlend;

		// Token: 0x04001023 RID: 4131
		private List<SkateboardAnimation.AlignmentSet> alignmentSets = new List<SkateboardAnimation.AlignmentSet>();

		// Token: 0x020002CE RID: 718
		[Serializable]
		public class AlignmentSet
		{
			// Token: 0x04001024 RID: 4132
			public Transform Transform;

			// Token: 0x04001025 RID: 4133
			public Transform Default;

			// Token: 0x04001026 RID: 4134
			public Transform Animated;
		}
	}
}
