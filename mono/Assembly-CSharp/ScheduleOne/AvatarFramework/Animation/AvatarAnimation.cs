using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.GameTime;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Skating;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.AvatarFramework.Animation
{
	// Token: 0x02000991 RID: 2449
	public class AvatarAnimation : MonoBehaviour
	{
		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x0600425B RID: 16987 RVA: 0x00115E78 File Offset: 0x00114078
		// (set) Token: 0x0600425C RID: 16988 RVA: 0x00115E80 File Offset: 0x00114080
		public bool IsCrouched { get; protected set; }

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x0600425D RID: 16989 RVA: 0x00115E89 File Offset: 0x00114089
		public bool IsSeated
		{
			get
			{
				return this.CurrentSeat != null;
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x0600425E RID: 16990 RVA: 0x00115E97 File Offset: 0x00114097
		// (set) Token: 0x0600425F RID: 16991 RVA: 0x00115E9F File Offset: 0x0011409F
		public float TimeSinceSitEnd { get; protected set; } = 1000f;

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06004260 RID: 16992 RVA: 0x00115EA8 File Offset: 0x001140A8
		// (set) Token: 0x06004261 RID: 16993 RVA: 0x00115EB0 File Offset: 0x001140B0
		public AvatarSeat CurrentSeat { get; protected set; }

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06004262 RID: 16994 RVA: 0x00115EB9 File Offset: 0x001140B9
		// (set) Token: 0x06004263 RID: 16995 RVA: 0x00115EC1 File Offset: 0x001140C1
		public bool StandUpAnimationPlaying { get; protected set; }

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x06004264 RID: 16996 RVA: 0x00115ECA File Offset: 0x001140CA
		// (set) Token: 0x06004265 RID: 16997 RVA: 0x00115ED2 File Offset: 0x001140D2
		public bool IsAvatarCulled { get; private set; }

		// Token: 0x06004266 RID: 16998 RVA: 0x00115EDC File Offset: 0x001140DC
		protected virtual void Awake()
		{
			this.initialCullingMode = this.animator.cullingMode;
			this.animator.cullingMode = 0;
			this.avatar = base.GetComponent<Avatar>();
			this.avatar.onRagdollChange.AddListener(new UnityAction<bool, bool, bool>(this.RagdollChange));
			this.standUpFromBackBoneTransforms = new BoneTransform[this.Bones.Length];
			this.standUpFromFrontBoneTransforms = new BoneTransform[this.Bones.Length];
			this.ragdollBoneTransforms = new BoneTransform[this.Bones.Length];
			this.standingBoneTransforms = new BoneTransform[this.Bones.Length];
			for (int i = 0; i < this.Bones.Length; i++)
			{
				this.standUpFromBackBoneTransforms[i] = new BoneTransform();
				this.standUpFromFrontBoneTransforms[i] = new BoneTransform();
				this.ragdollBoneTransforms[i] = new BoneTransform();
				this.standingBoneTransforms[i] = new BoneTransform();
			}
			this.PopulateBoneTransforms(this.standingBoneTransforms);
			base.InvokeRepeating("InfrequentUpdate", Random.Range(0f, 0.5f), 0.1f);
		}

		// Token: 0x06004267 RID: 16999 RVA: 0x00115FEC File Offset: 0x001141EC
		protected virtual void Start()
		{
			this.PopulateAnimationStartBoneTransforms(this.StandUpFromFrontClipName, this.standUpFromFrontBoneTransforms);
			this.PopulateAnimationStartBoneTransforms(this.StandUpFromBackClipName, this.standUpFromBackBoneTransforms);
			if (NetworkSingleton<TimeManager>.InstanceExists)
			{
				TimeManager instance = NetworkSingleton<TimeManager>.Instance;
				instance.onMinutePass = (Action)Delegate.Remove(instance.onMinutePass, new Action(this.MinPass));
				TimeManager instance2 = NetworkSingleton<TimeManager>.Instance;
				instance2.onMinutePass = (Action)Delegate.Combine(instance2.onMinutePass, new Action(this.MinPass));
			}
			Player componentInParent = base.GetComponentInParent<Player>();
			if (componentInParent != null)
			{
				Player player = componentInParent;
				player.onSkateboardMounted = (Action<Skateboard>)Delegate.Combine(player.onSkateboardMounted, new Action<Skateboard>(this.SkateboardMounted));
				Player player2 = componentInParent;
				player2.onSkateboardDismounted = (Action)Delegate.Combine(player2.onSkateboardDismounted, new Action(this.SkateboardDismounted));
			}
			this.framesActive = 0;
		}

		// Token: 0x06004268 RID: 17000 RVA: 0x001160CB File Offset: 0x001142CB
		private void OnDestroy()
		{
			if (NetworkSingleton<TimeManager>.InstanceExists)
			{
				TimeManager instance = NetworkSingleton<TimeManager>.Instance;
				instance.onMinutePass = (Action)Delegate.Remove(instance.onMinutePass, new Action(this.MinPass));
			}
		}

		// Token: 0x06004269 RID: 17001 RVA: 0x001160FA File Offset: 0x001142FA
		private void OnEnable()
		{
			this.framesActive = 0;
		}

		// Token: 0x0600426A RID: 17002 RVA: 0x00116104 File Offset: 0x00114304
		private void Update()
		{
			if (this.IsSeated)
			{
				this.TimeSinceSitEnd = 0f;
			}
			else
			{
				this.TimeSinceSitEnd += Time.deltaTime;
			}
			if (this.seatRoutine == null && this.CurrentSeat != null)
			{
				base.transform.position = this.CurrentSeat.SittingPoint.position + AvatarAnimation.SITTING_OFFSET * base.transform.localScale.y;
				base.transform.rotation = this.CurrentSeat.SittingPoint.rotation;
			}
			if (base.gameObject.activeInHierarchy)
			{
				this.framesActive++;
			}
		}

		// Token: 0x0600426B RID: 17003 RVA: 0x001161BE File Offset: 0x001143BE
		private void InfrequentUpdate()
		{
			this.UpdateAnimationActive(false);
		}

		// Token: 0x0600426C RID: 17004 RVA: 0x001161C8 File Offset: 0x001143C8
		private void MinPass()
		{
			if (this == null || this.animator == null)
			{
				return;
			}
			if (Time.timeSinceLevelLoad > 3f && this.animator.cullingMode != this.initialCullingMode)
			{
				this.animator.cullingMode = this.initialCullingMode;
			}
		}

		// Token: 0x0600426D RID: 17005 RVA: 0x00116220 File Offset: 0x00114420
		private void UpdateAnimationActive(bool forceWriteIdle = false)
		{
			if (!PlayerSingleton<PlayerCamera>.InstanceExists)
			{
				return;
			}
			float num = Vector3.SqrMagnitude(PlayerSingleton<PlayerCamera>.Instance.transform.position - base.transform.position);
			bool flag = num < 1600f * QualitySettings.lodBias;
			if (flag && num > 225f)
			{
				flag = (Vector3.Dot(PlayerSingleton<PlayerCamera>.Instance.transform.forward, base.transform.position - PlayerSingleton<PlayerCamera>.Instance.transform.position) > 0f);
			}
			if (Time.timeSinceLevelLoad < 3f)
			{
				flag = true;
			}
			if (!this.AllowCulling)
			{
				flag = true;
			}
			bool isAvatarCulled = this.IsAvatarCulled;
			this.IsAvatarCulled = false;
			if (this.avatar.UseImpostor && this.UseImpostor)
			{
				if (!flag)
				{
					this.IsAvatarCulled = true;
				}
				if (!flag && !this.avatar.Impostor.gameObject.activeSelf)
				{
					this.avatar.BodyContainer.gameObject.SetActive(false);
					this.avatar.Impostor.EnableImpostor();
					return;
				}
				if (flag && this.avatar.Impostor.gameObject.activeSelf)
				{
					this.avatar.BodyContainer.gameObject.SetActive(true);
					this.avatar.Impostor.DisableImpostor();
				}
			}
			this.animator.enabled = (this.animationEnabled && flag);
			if (!this.IsAvatarCulled)
			{
				this.animator.SetBool("Sitting", this.IsSeated);
				if (isAvatarCulled && this.avatar.CurrentEquippable != null)
				{
					this.avatar.CurrentEquippable.InitializeAnimation();
				}
			}
		}

		// Token: 0x0600426E RID: 17006 RVA: 0x001163D2 File Offset: 0x001145D2
		public void SetDirection(float dir)
		{
			this.animator.SetFloat("Direction", dir);
		}

		// Token: 0x0600426F RID: 17007 RVA: 0x001163E5 File Offset: 0x001145E5
		public void SetStrafe(float strafe)
		{
			this.animator.SetFloat("Strafe", strafe);
		}

		// Token: 0x06004270 RID: 17008 RVA: 0x001163F8 File Offset: 0x001145F8
		public void SetTimeAirborne(float airbone)
		{
			this.animator.SetFloat("TimeAirborne", airbone);
		}

		// Token: 0x06004271 RID: 17009 RVA: 0x0011640B File Offset: 0x0011460B
		public void SetCrouched(bool crouched)
		{
			this.IsCrouched = crouched;
			this.animator.SetBool("isCrouched", crouched);
		}

		// Token: 0x06004272 RID: 17010 RVA: 0x00116425 File Offset: 0x00114625
		public void SetGrounded(bool grounded)
		{
			this.animator.SetBool("isGrounded", grounded);
		}

		// Token: 0x06004273 RID: 17011 RVA: 0x00116438 File Offset: 0x00114638
		public void Jump()
		{
			this.animator.SetTrigger("Jump");
		}

		// Token: 0x06004274 RID: 17012 RVA: 0x0011644A File Offset: 0x0011464A
		public void SetAnimationEnabled(bool enabled)
		{
			this.animationEnabled = enabled;
			this.UpdateAnimationActive(false);
		}

		// Token: 0x06004275 RID: 17013 RVA: 0x0011645C File Offset: 0x0011465C
		public void Flinch(Vector3 forceDirection, AvatarAnimation.EFlinchType flinchType)
		{
			Vector3 vector = base.transform.InverseTransformDirection(forceDirection);
			AvatarAnimation.EFlinchDirection eflinchDirection;
			if (Mathf.Abs(vector.z) > Mathf.Abs(vector.x))
			{
				if (vector.z > 0f)
				{
					eflinchDirection = AvatarAnimation.EFlinchDirection.Forward;
				}
				else
				{
					eflinchDirection = AvatarAnimation.EFlinchDirection.Backward;
				}
			}
			else if (vector.x > 0f)
			{
				eflinchDirection = AvatarAnimation.EFlinchDirection.Right;
			}
			else
			{
				eflinchDirection = AvatarAnimation.EFlinchDirection.Left;
			}
			if (flinchType != AvatarAnimation.EFlinchType.Light)
			{
				switch (eflinchDirection)
				{
				case AvatarAnimation.EFlinchDirection.Forward:
					this.animator.SetTrigger("Flinch_Heavy_Forward");
					break;
				case AvatarAnimation.EFlinchDirection.Backward:
					this.animator.SetTrigger("Flinch_Heavy_Backward");
					break;
				case AvatarAnimation.EFlinchDirection.Left:
					this.animator.SetTrigger("Flinch_Heavy_Left");
					break;
				case AvatarAnimation.EFlinchDirection.Right:
					this.animator.SetTrigger("Flinch_Heavy_Right");
					break;
				}
				if (this.onHeavyFlinch != null)
				{
					this.onHeavyFlinch.Invoke();
				}
				return;
			}
			switch (eflinchDirection)
			{
			case AvatarAnimation.EFlinchDirection.Forward:
				this.animator.SetTrigger("Flinch_Forward");
				return;
			case AvatarAnimation.EFlinchDirection.Backward:
				this.animator.SetTrigger("Flinch_Backward");
				return;
			case AvatarAnimation.EFlinchDirection.Left:
				this.animator.SetTrigger("Flinch_Left");
				return;
			case AvatarAnimation.EFlinchDirection.Right:
				this.animator.SetTrigger("Flinch_Right");
				return;
			default:
				return;
			}
		}

		// Token: 0x06004276 RID: 17014 RVA: 0x00116588 File Offset: 0x00114788
		public void PlayStandUpAnimation()
		{
			AvatarAnimation.<>c__DisplayClass75_0 CS$<>8__locals1 = new AvatarAnimation.<>c__DisplayClass75_0();
			CS$<>8__locals1.<>4__this = this;
			this.StandUpAnimationPlaying = true;
			if (this.onStandupStart != null)
			{
				this.onStandupStart.Invoke();
			}
			this.PopulateBoneTransforms(this.ragdollBoneTransforms);
			CS$<>8__locals1.standUpFromBack = this.ShouldGetUpFromBack();
			this.PopulateAnimationStartBoneTransforms(this.StandUpFromFrontClipName, this.standUpFromFrontBoneTransforms);
			this.PopulateAnimationStartBoneTransforms(this.StandUpFromBackClipName, this.standUpFromBackBoneTransforms);
			CS$<>8__locals1.finalBoneTransforms = (CS$<>8__locals1.standUpFromBack ? this.standUpFromBackBoneTransforms : this.standUpFromFrontBoneTransforms);
			if (this.standUpRoutine != null)
			{
				base.StopCoroutine(this.standUpRoutine);
			}
			this.standUpRoutine = Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<PlayStandUpAnimation>g__StandUpRoutine|0());
		}

		// Token: 0x06004277 RID: 17015 RVA: 0x00116640 File Offset: 0x00114840
		protected void RagdollChange(bool oldValue, bool ragdoll, bool playStandUpAnim)
		{
			bool flag = oldValue && !ragdoll && playStandUpAnim;
			if (ragdoll && this.IsSeated)
			{
				if (this.CurrentSeat != null)
				{
					this.CurrentSeat.SetOccupant(null);
					this.CurrentSeat = null;
				}
				this.animator.SetBool("Sitting", false);
				base.GetComponentInParent<NPCMovement>().SpeedController.RemoveSpeedControl("seated");
			}
			if (ragdoll && this.standUpRoutine != null)
			{
				base.StopCoroutine(this.standUpRoutine);
			}
			if (oldValue && !ragdoll)
			{
				this.AlignPositionToHips();
			}
			if (!flag)
			{
				this.SetAnimationEnabled(!ragdoll);
				return;
			}
			this.PlayStandUpAnimation();
		}

		// Token: 0x06004278 RID: 17016 RVA: 0x001166E4 File Offset: 0x001148E4
		private void AlignPositionToHips()
		{
			Vector3 position = this.HipBone.position;
			Quaternion rotation = this.HipBone.rotation;
			base.transform.position = this.HipBone.position;
			RaycastHit raycastHit;
			if (Physics.Raycast(base.transform.position, Vector3.down, ref raycastHit, 10f, this.GroundingMask))
			{
				base.transform.position = new Vector3(base.transform.position.x, raycastHit.point.y, base.transform.position.z);
			}
			base.transform.rotation = Quaternion.LookRotation(Vector3.ProjectOnPlane(this.ShouldGetUpFromBack() ? (-this.HipBone.up) : this.HipBone.up, Vector3.up), Vector3.up);
			this.HipBone.position = position;
			this.HipBone.rotation = rotation;
		}

		// Token: 0x06004279 RID: 17017 RVA: 0x001167E0 File Offset: 0x001149E0
		private bool ShouldGetUpFromBack()
		{
			return Vector3.Angle(this.HipBone.forward, Vector3.up) < 90f;
		}

		// Token: 0x0600427A RID: 17018 RVA: 0x00116800 File Offset: 0x00114A00
		private void PopulateBoneTransforms(BoneTransform[] boneTransforms)
		{
			for (int i = 0; i < this.Bones.Length; i++)
			{
				boneTransforms[i].Position = this.Bones[i].localPosition;
				boneTransforms[i].Rotation = this.Bones[i].localRotation;
			}
		}

		// Token: 0x0600427B RID: 17019 RVA: 0x0011684C File Offset: 0x00114A4C
		private List<Pose> GetBoneTransforms()
		{
			List<Pose> list = new List<Pose>();
			for (int i = 0; i < this.Bones.Length; i++)
			{
				list.Add(new Pose(this.Bones[i].localPosition, this.Bones[i].localRotation));
			}
			return list;
		}

		// Token: 0x0600427C RID: 17020 RVA: 0x00116898 File Offset: 0x00114A98
		private void PopulateAnimationStartBoneTransforms(string clipName, BoneTransform[] boneTransforms)
		{
			Vector3 position = this.animator.transform.position;
			Quaternion rotation = this.animator.transform.rotation;
			if (this.animator.runtimeAnimatorController == null)
			{
				return;
			}
			foreach (AnimationClip animationClip in this.animator.runtimeAnimatorController.animationClips)
			{
				if (animationClip.name == clipName)
				{
					animationClip.SampleAnimation(this.animator.gameObject, 0f);
					this.PopulateBoneTransforms(boneTransforms);
					break;
				}
			}
			this.animator.transform.position = position;
			this.animator.transform.rotation = rotation;
		}

		// Token: 0x0600427D RID: 17021 RVA: 0x00116950 File Offset: 0x00114B50
		public void SetTrigger(string trigger)
		{
			if (string.IsNullOrEmpty(trigger))
			{
				return;
			}
			this.animator.SetTrigger(trigger);
			this.UpdateAnimationActive(true);
		}

		// Token: 0x0600427E RID: 17022 RVA: 0x0011696E File Offset: 0x00114B6E
		public void ResetTrigger(string trigger)
		{
			this.animator.ResetTrigger(trigger);
		}

		// Token: 0x0600427F RID: 17023 RVA: 0x0011697C File Offset: 0x00114B7C
		public void SetBool(string id, bool value)
		{
			this.animator.SetBool(id, value);
			this.UpdateAnimationActive(true);
		}

		// Token: 0x06004280 RID: 17024 RVA: 0x00116994 File Offset: 0x00114B94
		public void SetSeat(AvatarSeat seat)
		{
			AvatarAnimation.<>c__DisplayClass85_0 CS$<>8__locals1 = new AvatarAnimation.<>c__DisplayClass85_0();
			CS$<>8__locals1.<>4__this = this;
			if (seat == this.CurrentSeat)
			{
				return;
			}
			if (this.CurrentSeat != null)
			{
				this.CurrentSeat.SetOccupant(null);
			}
			this.CurrentSeat = seat;
			if (this.CurrentSeat != null)
			{
				this.CurrentSeat.SetOccupant(base.GetComponentInParent<NPC>());
			}
			this.animator.SetBool("Sitting", this.IsSeated);
			CS$<>8__locals1.startPos = base.transform.position;
			CS$<>8__locals1.startRot = base.transform.rotation;
			if (this.seatRoutine != null)
			{
				Singleton<CoroutineService>.Instance.StopCoroutine(this.seatRoutine);
			}
			if (this.CurrentSeat != null)
			{
				CS$<>8__locals1.endPos = this.CurrentSeat.SittingPoint.position + AvatarAnimation.SITTING_OFFSET * base.transform.localScale.y;
				CS$<>8__locals1.endRot = this.CurrentSeat.SittingPoint.rotation;
				this.seatRoutine = Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<SetSeat>g__Lerp|0(false));
				base.GetComponentInParent<NPCMovement>().SpeedController.AddSpeedControl(new NPCSpeedController.SpeedControl("seated", 100, -1f));
				return;
			}
			CS$<>8__locals1.endPos = base.transform.parent.position;
			CS$<>8__locals1.endRot = base.transform.parent.rotation;
			this.seatRoutine = Singleton<CoroutineService>.Instance.StartCoroutine(CS$<>8__locals1.<SetSeat>g__Lerp|0(true));
		}

		// Token: 0x06004281 RID: 17025 RVA: 0x00116B28 File Offset: 0x00114D28
		public void SkateboardMounted(Skateboard board)
		{
			this.IKController.BodyIK.solvers.pelvis.target = board.Animation.PelvisAlignment.Transform;
			this.IKController.BodyIK.solvers.spine.target = board.Animation.SpineAlignment.Transform;
			this.IKController.BodyIK.solvers.leftFoot.target = board.Animation.LeftFootAlignment.Transform;
			this.IKController.BodyIK.solvers.rightFoot.target = board.Animation.RightFootAlignment.Transform;
			this.IKController.BodyIK.solvers.leftHand.target = board.Animation.LeftHandAlignment.Transform;
			this.IKController.BodyIK.solvers.rightHand.target = board.Animation.RightHandAlignment.Transform;
			this.IKController.BodyIK.solvers.rightFoot.SetBendPlaneToCurrent();
			this.IKController.BodyIK.solvers.leftFoot.SetBendPlaneToCurrent();
			this.IKController.OverrideLegBendTargets(board.Animation.LeftLegBendTarget.Transform, board.Animation.RightLegBendTarget.Transform);
			this.IKController.SetIKActive(true);
			this.avatar.SetEquippable(string.Empty);
			this.avatar.LookController.ForceLookTarget = board.Animation.AvatarFaceTarget;
			this.avatar.LookController.ForceLookRotateBody = true;
			this.SetBool("SkateIdle", true);
			this.activeSkateboard = board;
			this.activeSkateboard.OnPushStart.AddListener(new UnityAction(this.SkateboardPush));
		}

		// Token: 0x06004282 RID: 17026 RVA: 0x00116D08 File Offset: 0x00114F08
		public void SkateboardDismounted()
		{
			this.IKController.ResetLegBendTargets();
			this.IKController.SetIKActive(false);
			this.avatar.LookController.ForceLookTarget = null;
			this.avatar.LookController.ForceLookRotateBody = false;
			this.SetBool("SkateIdle", false);
			this.activeSkateboard.OnPushStart.RemoveListener(new UnityAction(this.SkateboardPush));
			this.activeSkateboard = null;
		}

		// Token: 0x06004283 RID: 17027 RVA: 0x00116D7D File Offset: 0x00114F7D
		private void SkateboardPush()
		{
			this.SetTrigger("SkatePush");
		}

		// Token: 0x04002FF4 RID: 12276
		public const float AnimationRangeSqr = 1600f;

		// Token: 0x04002FF5 RID: 12277
		public const float FrustrumCullMinDist = 225f;

		// Token: 0x04002FF6 RID: 12278
		public const float RunningAnimationSpeed = 8f;

		// Token: 0x04002FF7 RID: 12279
		public const float MaxBoneOffset = 0.01f;

		// Token: 0x04002FF8 RID: 12280
		public const float MaxBoneOffsetSqr = 0.0001f;

		// Token: 0x04002FF9 RID: 12281
		public static Vector3 SITTING_OFFSET = new Vector3(0f, -0.825f, 0f);

		// Token: 0x04002FFA RID: 12282
		public const float SEAT_TIME = 0.5f;

		// Token: 0x04003000 RID: 12288
		public bool DEBUG_MODE;

		// Token: 0x04003001 RID: 12289
		private int framesActive;

		// Token: 0x04003002 RID: 12290
		[Header("References")]
		public Animator animator;

		// Token: 0x04003003 RID: 12291
		public Transform HipBone;

		// Token: 0x04003004 RID: 12292
		public Transform[] Bones;

		// Token: 0x04003005 RID: 12293
		protected Avatar avatar;

		// Token: 0x04003006 RID: 12294
		public Transform LeftHandContainer;

		// Token: 0x04003007 RID: 12295
		public Transform RightHandContainer;

		// Token: 0x04003008 RID: 12296
		public Transform RightHandAlignmentPoint;

		// Token: 0x04003009 RID: 12297
		public Transform LeftHandAlignmentPoint;

		// Token: 0x0400300A RID: 12298
		public AvatarIKController IKController;

		// Token: 0x0400300B RID: 12299
		[Header("Settings")]
		public LayerMask GroundingMask;

		// Token: 0x0400300C RID: 12300
		public string StandUpFromBackClipName;

		// Token: 0x0400300D RID: 12301
		public string StandUpFromFrontClipName;

		// Token: 0x0400300E RID: 12302
		public bool UseImpostor = true;

		// Token: 0x0400300F RID: 12303
		public bool AllowCulling = true;

		// Token: 0x04003010 RID: 12304
		public UnityEvent onStandupStart;

		// Token: 0x04003011 RID: 12305
		public UnityEvent onStandupDone;

		// Token: 0x04003012 RID: 12306
		public UnityEvent onHeavyFlinch;

		// Token: 0x04003013 RID: 12307
		private BoneTransform[] standingBoneTransforms;

		// Token: 0x04003014 RID: 12308
		private BoneTransform[] standUpFromBackBoneTransforms;

		// Token: 0x04003015 RID: 12309
		private BoneTransform[] standUpFromFrontBoneTransforms;

		// Token: 0x04003016 RID: 12310
		private BoneTransform[] ragdollBoneTransforms;

		// Token: 0x04003017 RID: 12311
		private Coroutine standUpRoutine;

		// Token: 0x04003018 RID: 12312
		private Coroutine seatRoutine;

		// Token: 0x04003019 RID: 12313
		private Skateboard activeSkateboard;

		// Token: 0x0400301A RID: 12314
		private bool animationEnabled = true;

		// Token: 0x0400301B RID: 12315
		private AnimatorCullingMode initialCullingMode;

		// Token: 0x02000992 RID: 2450
		public enum EFlinchType
		{
			// Token: 0x0400301D RID: 12317
			Light,
			// Token: 0x0400301E RID: 12318
			Heavy
		}

		// Token: 0x02000993 RID: 2451
		public enum EFlinchDirection
		{
			// Token: 0x04003020 RID: 12320
			Forward,
			// Token: 0x04003021 RID: 12321
			Backward,
			// Token: 0x04003022 RID: 12322
			Left,
			// Token: 0x04003023 RID: 12323
			Right
		}
	}
}
