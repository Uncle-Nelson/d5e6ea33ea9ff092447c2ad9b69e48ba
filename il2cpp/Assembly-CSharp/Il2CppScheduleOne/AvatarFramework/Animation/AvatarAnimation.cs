using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Skating;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.AvatarFramework.Animation
{
	// Token: 0x0200060A RID: 1546
	public class AvatarAnimation : MonoBehaviour
	{
		// Token: 0x06008847 RID: 34887 RVA: 0x0023E47C File Offset: 0x0023C67C
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarAnimation()
		{
			Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Animation", "AvatarAnimation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr);
			AvatarAnimation.NativeFieldInfoPtr_AnimationRangeSqr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "AnimationRangeSqr");
			AvatarAnimation.NativeFieldInfoPtr_FrustrumCullMinDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "FrustrumCullMinDist");
			AvatarAnimation.NativeFieldInfoPtr_RunningAnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "RunningAnimationSpeed");
			AvatarAnimation.NativeFieldInfoPtr_MaxBoneOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "MaxBoneOffset");
			AvatarAnimation.NativeFieldInfoPtr_MaxBoneOffsetSqr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "MaxBoneOffsetSqr");
			AvatarAnimation.NativeFieldInfoPtr_SITTING_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "SITTING_OFFSET");
			AvatarAnimation.NativeFieldInfoPtr_SEAT_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "SEAT_TIME");
			AvatarAnimation.NativeFieldInfoPtr__IsCrouched_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "<IsCrouched>k__BackingField");
			AvatarAnimation.NativeFieldInfoPtr__TimeSinceSitEnd_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "<TimeSinceSitEnd>k__BackingField");
			AvatarAnimation.NativeFieldInfoPtr__CurrentSeat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "<CurrentSeat>k__BackingField");
			AvatarAnimation.NativeFieldInfoPtr__StandUpAnimationPlaying_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "<StandUpAnimationPlaying>k__BackingField");
			AvatarAnimation.NativeFieldInfoPtr__IsAvatarCulled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "<IsAvatarCulled>k__BackingField");
			AvatarAnimation.NativeFieldInfoPtr_DEBUG_MODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "DEBUG_MODE");
			AvatarAnimation.NativeFieldInfoPtr_framesActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "framesActive");
			AvatarAnimation.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "animator");
			AvatarAnimation.NativeFieldInfoPtr_HipBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "HipBone");
			AvatarAnimation.NativeFieldInfoPtr_Bones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "Bones");
			AvatarAnimation.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "avatar");
			AvatarAnimation.NativeFieldInfoPtr_LeftHandContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "LeftHandContainer");
			AvatarAnimation.NativeFieldInfoPtr_RightHandContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "RightHandContainer");
			AvatarAnimation.NativeFieldInfoPtr_RightHandAlignmentPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "RightHandAlignmentPoint");
			AvatarAnimation.NativeFieldInfoPtr_LeftHandAlignmentPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "LeftHandAlignmentPoint");
			AvatarAnimation.NativeFieldInfoPtr_IKController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "IKController");
			AvatarAnimation.NativeFieldInfoPtr_GroundingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "GroundingMask");
			AvatarAnimation.NativeFieldInfoPtr_StandUpFromBackClipName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "StandUpFromBackClipName");
			AvatarAnimation.NativeFieldInfoPtr_StandUpFromFrontClipName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "StandUpFromFrontClipName");
			AvatarAnimation.NativeFieldInfoPtr_UseImpostor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "UseImpostor");
			AvatarAnimation.NativeFieldInfoPtr_AllowCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "AllowCulling");
			AvatarAnimation.NativeFieldInfoPtr_onStandupStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "onStandupStart");
			AvatarAnimation.NativeFieldInfoPtr_onStandupDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "onStandupDone");
			AvatarAnimation.NativeFieldInfoPtr_onHeavyFlinch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "onHeavyFlinch");
			AvatarAnimation.NativeFieldInfoPtr_standingBoneTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "standingBoneTransforms");
			AvatarAnimation.NativeFieldInfoPtr_standUpFromBackBoneTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "standUpFromBackBoneTransforms");
			AvatarAnimation.NativeFieldInfoPtr_standUpFromFrontBoneTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "standUpFromFrontBoneTransforms");
			AvatarAnimation.NativeFieldInfoPtr_ragdollBoneTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "ragdollBoneTransforms");
			AvatarAnimation.NativeFieldInfoPtr_standUpRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "standUpRoutine");
			AvatarAnimation.NativeFieldInfoPtr_seatRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "seatRoutine");
			AvatarAnimation.NativeFieldInfoPtr_activeSkateboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "activeSkateboard");
			AvatarAnimation.NativeFieldInfoPtr_animationEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "animationEnabled");
			AvatarAnimation.NativeFieldInfoPtr_initialCullingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "initialCullingMode");
			AvatarAnimation.NativeMethodInfoPtr_get_IsCrouched_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680293);
			AvatarAnimation.NativeMethodInfoPtr_set_IsCrouched_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680294);
			AvatarAnimation.NativeMethodInfoPtr_get_IsSeated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680295);
			AvatarAnimation.NativeMethodInfoPtr_get_TimeSinceSitEnd_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680296);
			AvatarAnimation.NativeMethodInfoPtr_set_TimeSinceSitEnd_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680297);
			AvatarAnimation.NativeMethodInfoPtr_get_CurrentSeat_Public_get_AvatarSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680298);
			AvatarAnimation.NativeMethodInfoPtr_set_CurrentSeat_Protected_set_Void_AvatarSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680299);
			AvatarAnimation.NativeMethodInfoPtr_get_StandUpAnimationPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680300);
			AvatarAnimation.NativeMethodInfoPtr_set_StandUpAnimationPlaying_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680301);
			AvatarAnimation.NativeMethodInfoPtr_get_IsAvatarCulled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680302);
			AvatarAnimation.NativeMethodInfoPtr_set_IsAvatarCulled_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680303);
			AvatarAnimation.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680304);
			AvatarAnimation.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680305);
			AvatarAnimation.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680306);
			AvatarAnimation.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680307);
			AvatarAnimation.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680308);
			AvatarAnimation.NativeMethodInfoPtr_InfrequentUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680309);
			AvatarAnimation.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680310);
			AvatarAnimation.NativeMethodInfoPtr_UpdateAnimationActive_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680311);
			AvatarAnimation.NativeMethodInfoPtr_SetDirection_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680312);
			AvatarAnimation.NativeMethodInfoPtr_SetStrafe_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680313);
			AvatarAnimation.NativeMethodInfoPtr_SetTimeAirborne_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680314);
			AvatarAnimation.NativeMethodInfoPtr_SetCrouched_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680315);
			AvatarAnimation.NativeMethodInfoPtr_SetGrounded_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680316);
			AvatarAnimation.NativeMethodInfoPtr_Jump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680317);
			AvatarAnimation.NativeMethodInfoPtr_SetAnimationEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680318);
			AvatarAnimation.NativeMethodInfoPtr_Flinch_Public_Void_Vector3_EFlinchType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680319);
			AvatarAnimation.NativeMethodInfoPtr_PlayStandUpAnimation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680320);
			AvatarAnimation.NativeMethodInfoPtr_RagdollChange_Protected_Void_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680321);
			AvatarAnimation.NativeMethodInfoPtr_AlignPositionToHips_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680322);
			AvatarAnimation.NativeMethodInfoPtr_ShouldGetUpFromBack_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680323);
			AvatarAnimation.NativeMethodInfoPtr_PopulateBoneTransforms_Private_Void_Il2CppReferenceArray_1_BoneTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680324);
			AvatarAnimation.NativeMethodInfoPtr_GetBoneTransforms_Private_List_1_Pose_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680325);
			AvatarAnimation.NativeMethodInfoPtr_PopulateAnimationStartBoneTransforms_Private_Void_String_Il2CppReferenceArray_1_BoneTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680326);
			AvatarAnimation.NativeMethodInfoPtr_SetTrigger_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680327);
			AvatarAnimation.NativeMethodInfoPtr_ResetTrigger_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680328);
			AvatarAnimation.NativeMethodInfoPtr_SetBool_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680329);
			AvatarAnimation.NativeMethodInfoPtr_SetSeat_Public_Void_AvatarSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680330);
			AvatarAnimation.NativeMethodInfoPtr_SkateboardMounted_Public_Void_Skateboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680331);
			AvatarAnimation.NativeMethodInfoPtr_SkateboardDismounted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680332);
			AvatarAnimation.NativeMethodInfoPtr_SkateboardPush_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680333);
			AvatarAnimation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, 100680334);
		}

		// Token: 0x170029A3 RID: 10659
		// (get) Token: 0x06008848 RID: 34888 RVA: 0x0023EB14 File Offset: 0x0023CD14
		// (set) Token: 0x06008849 RID: 34889 RVA: 0x0023EB50 File Offset: 0x0023CD50
		public unsafe bool IsCrouched
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35365, RefRangeEnd = 35366, XrefRangeStart = 35365, XrefRangeEnd = 35366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_get_IsCrouched_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35366, RefRangeEnd = 35368, XrefRangeStart = 35366, XrefRangeEnd = 35368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_set_IsCrouched_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170029A4 RID: 10660
		// (get) Token: 0x0600884A RID: 34890 RVA: 0x0023EB90 File Offset: 0x0023CD90
		public unsafe bool IsSeated
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 252555, RefRangeEnd = 252556, XrefRangeStart = 252551, XrefRangeEnd = 252555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_get_IsSeated_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170029A5 RID: 10661
		// (get) Token: 0x0600884B RID: 34891 RVA: 0x0023EBCC File Offset: 0x0023CDCC
		// (set) Token: 0x0600884C RID: 34892 RVA: 0x0023EC08 File Offset: 0x0023CE08
		public unsafe float TimeSinceSitEnd
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_get_TimeSinceSitEnd_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 29977, RefRangeEnd = 29988, XrefRangeStart = 29977, XrefRangeEnd = 29988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_set_TimeSinceSitEnd_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170029A6 RID: 10662
		// (get) Token: 0x0600884D RID: 34893 RVA: 0x0023EC48 File Offset: 0x0023CE48
		// (set) Token: 0x0600884E RID: 34894 RVA: 0x0023EC88 File Offset: 0x0023CE88
		public unsafe AvatarSeat CurrentSeat
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19637, RefRangeEnd = 19640, XrefRangeStart = 19637, XrefRangeEnd = 19640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_get_CurrentSeat_Public_get_AvatarSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarSeat>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19641, RefRangeEnd = 19644, XrefRangeStart = 19641, XrefRangeEnd = 19644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_set_CurrentSeat_Protected_set_Void_AvatarSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170029A7 RID: 10663
		// (get) Token: 0x0600884F RID: 34895 RVA: 0x0023ECCC File Offset: 0x0023CECC
		// (set) Token: 0x06008850 RID: 34896 RVA: 0x0023ED08 File Offset: 0x0023CF08
		public unsafe bool StandUpAnimationPlaying
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_get_StandUpAnimationPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_set_StandUpAnimationPlaying_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170029A8 RID: 10664
		// (get) Token: 0x06008851 RID: 34897 RVA: 0x0023ED48 File Offset: 0x0023CF48
		// (set) Token: 0x06008852 RID: 34898 RVA: 0x0023ED84 File Offset: 0x0023CF84
		public unsafe bool IsAvatarCulled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_get_IsAvatarCulled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 57506, RefRangeEnd = 57507, XrefRangeStart = 57506, XrefRangeEnd = 57507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_set_IsAvatarCulled_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008853 RID: 34899 RVA: 0x0023EDC4 File Offset: 0x0023CFC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252556, XrefRangeEnd = 252613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarAnimation.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008854 RID: 34900 RVA: 0x0023EE00 File Offset: 0x0023D000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252613, XrefRangeEnd = 252675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarAnimation.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008855 RID: 34901 RVA: 0x0023EE3C File Offset: 0x0023D03C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252675, XrefRangeEnd = 252693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008856 RID: 34902 RVA: 0x0023EE70 File Offset: 0x0023D070
		[CallerCount(0)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008857 RID: 34903 RVA: 0x0023EEA4 File Offset: 0x0023D0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252693, XrefRangeEnd = 252717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008858 RID: 34904 RVA: 0x0023EED8 File Offset: 0x0023D0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252717, XrefRangeEnd = 252718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InfrequentUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_InfrequentUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008859 RID: 34905 RVA: 0x0023EF0C File Offset: 0x0023D10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252718, XrefRangeEnd = 252728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600885A RID: 34906 RVA: 0x0023EF40 File Offset: 0x0023D140
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 252760, RefRangeEnd = 252769, XrefRangeStart = 252728, XrefRangeEnd = 252760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAnimationActive(bool forceWriteIdle = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forceWriteIdle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_UpdateAnimationActive_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600885B RID: 34907 RVA: 0x0023EF80 File Offset: 0x0023D180
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 252773, RefRangeEnd = 252777, XrefRangeStart = 252769, XrefRangeEnd = 252773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDirection(float dir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetDirection_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600885C RID: 34908 RVA: 0x0023EFC0 File Offset: 0x0023D1C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 252781, RefRangeEnd = 252783, XrefRangeStart = 252777, XrefRangeEnd = 252781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStrafe(float strafe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref strafe;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetStrafe_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600885D RID: 34909 RVA: 0x0023F000 File Offset: 0x0023D200
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 252787, RefRangeEnd = 252789, XrefRangeStart = 252783, XrefRangeEnd = 252787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTimeAirborne(float airbone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref airbone;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetTimeAirborne_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600885E RID: 34910 RVA: 0x0023F040 File Offset: 0x0023D240
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 252793, RefRangeEnd = 252798, XrefRangeStart = 252789, XrefRangeEnd = 252793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCrouched(bool crouched)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref crouched;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetCrouched_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600885F RID: 34911 RVA: 0x0023F080 File Offset: 0x0023D280
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 252802, RefRangeEnd = 252804, XrefRangeStart = 252798, XrefRangeEnd = 252802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGrounded(bool grounded)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref grounded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetGrounded_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008860 RID: 34912 RVA: 0x0023F0C0 File Offset: 0x0023D2C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 252808, RefRangeEnd = 252810, XrefRangeStart = 252804, XrefRangeEnd = 252808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Jump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_Jump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008861 RID: 34913 RVA: 0x0023F0F4 File Offset: 0x0023D2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252810, XrefRangeEnd = 252811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAnimationEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetAnimationEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008862 RID: 34914 RVA: 0x0023F134 File Offset: 0x0023D334
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 252833, RefRangeEnd = 252835, XrefRangeStart = 252811, XrefRangeEnd = 252833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Flinch(Vector3 forceDirection, AvatarAnimation.EFlinchType flinchType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forceDirection;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flinchType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_Flinch_Public_Void_Vector3_EFlinchType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008863 RID: 34915 RVA: 0x0023F180 File Offset: 0x0023D380
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 252856, RefRangeEnd = 252857, XrefRangeStart = 252835, XrefRangeEnd = 252856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayStandUpAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_PlayStandUpAnimation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008864 RID: 34916 RVA: 0x0023F1B4 File Offset: 0x0023D3B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252857, XrefRangeEnd = 252882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RagdollChange(bool oldValue, bool ragdoll, bool playStandUpAnim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldValue;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ragdoll;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playStandUpAnim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_RagdollChange_Protected_Void_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008865 RID: 34917 RVA: 0x0023F210 File Offset: 0x0023D410
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 252919, RefRangeEnd = 252920, XrefRangeStart = 252882, XrefRangeEnd = 252919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignPositionToHips()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_AlignPositionToHips_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008866 RID: 34918 RVA: 0x0023F244 File Offset: 0x0023D444
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 252924, RefRangeEnd = 252926, XrefRangeStart = 252920, XrefRangeEnd = 252924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldGetUpFromBack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_ShouldGetUpFromBack_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008867 RID: 34919 RVA: 0x0023F280 File Offset: 0x0023D480
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 252929, RefRangeEnd = 252931, XrefRangeStart = 252926, XrefRangeEnd = 252929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateBoneTransforms(Il2CppReferenceArray<BoneTransform> boneTransforms)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(boneTransforms);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_PopulateBoneTransforms_Private_Void_Il2CppReferenceArray_1_BoneTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008868 RID: 34920 RVA: 0x0023F2C4 File Offset: 0x0023D4C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252931, XrefRangeEnd = 252945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Pose> GetBoneTransforms()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_GetBoneTransforms_Private_List_1_Pose_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Pose>>(intPtr3) : null;
		}

		// Token: 0x06008869 RID: 34921 RVA: 0x0023F304 File Offset: 0x0023D504
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 252966, RefRangeEnd = 252970, XrefRangeStart = 252945, XrefRangeEnd = 252966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateAnimationStartBoneTransforms(string clipName, Il2CppReferenceArray<BoneTransform> boneTransforms)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(clipName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(boneTransforms);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_PopulateAnimationStartBoneTransforms_Private_Void_String_Il2CppReferenceArray_1_BoneTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600886A RID: 34922 RVA: 0x0023F358 File Offset: 0x0023D558
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 252973, RefRangeEnd = 252987, XrefRangeStart = 252970, XrefRangeEnd = 252973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTrigger(string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trigger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetTrigger_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600886B RID: 34923 RVA: 0x0023F39C File Offset: 0x0023D59C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 252989, RefRangeEnd = 252997, XrefRangeStart = 252987, XrefRangeEnd = 252989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetTrigger(string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trigger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_ResetTrigger_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600886C RID: 34924 RVA: 0x0023F3E0 File Offset: 0x0023D5E0
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 253000, RefRangeEnd = 253023, XrefRangeStart = 252997, XrefRangeEnd = 253000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBool(string id, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetBool_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600886D RID: 34925 RVA: 0x0023F430 File Offset: 0x0023D630
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253077, RefRangeEnd = 253078, XrefRangeStart = 253023, XrefRangeEnd = 253077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSeat(AvatarSeat seat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(seat);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SetSeat_Public_Void_AvatarSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600886E RID: 34926 RVA: 0x0023F474 File Offset: 0x0023D674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253078, XrefRangeEnd = 253104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkateboardMounted(Skateboard board)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(board);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SkateboardMounted_Public_Void_Skateboard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600886F RID: 34927 RVA: 0x0023F4B8 File Offset: 0x0023D6B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253104, XrefRangeEnd = 253120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkateboardDismounted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SkateboardDismounted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008870 RID: 34928 RVA: 0x0023F4EC File Offset: 0x0023D6EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253120, XrefRangeEnd = 253125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkateboardPush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr_SkateboardPush_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008871 RID: 34929 RVA: 0x0023F520 File Offset: 0x0023D720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253125, XrefRangeEnd = 253126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarAnimation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008872 RID: 34930 RVA: 0x00040F86 File Offset: 0x0003F186
		public AvatarAnimation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700297B RID: 10619
		// (get) Token: 0x06008873 RID: 34931 RVA: 0x0023F55C File Offset: 0x0023D75C
		// (set) Token: 0x06008874 RID: 34932 RVA: 0x00040F8F File Offset: 0x0003F18F
		public unsafe static float AnimationRangeSqr
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_AnimationRangeSqr, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_AnimationRangeSqr, (void*)(&value));
			}
		}

		// Token: 0x1700297C RID: 10620
		// (get) Token: 0x06008875 RID: 34933 RVA: 0x0023F578 File Offset: 0x0023D778
		// (set) Token: 0x06008876 RID: 34934 RVA: 0x00040F9D File Offset: 0x0003F19D
		public unsafe static float FrustrumCullMinDist
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_FrustrumCullMinDist, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_FrustrumCullMinDist, (void*)(&value));
			}
		}

		// Token: 0x1700297D RID: 10621
		// (get) Token: 0x06008877 RID: 34935 RVA: 0x0023F594 File Offset: 0x0023D794
		// (set) Token: 0x06008878 RID: 34936 RVA: 0x00040FAB File Offset: 0x0003F1AB
		public unsafe static float RunningAnimationSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_RunningAnimationSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_RunningAnimationSpeed, (void*)(&value));
			}
		}

		// Token: 0x1700297E RID: 10622
		// (get) Token: 0x06008879 RID: 34937 RVA: 0x0023F5B0 File Offset: 0x0023D7B0
		// (set) Token: 0x0600887A RID: 34938 RVA: 0x00040FB9 File Offset: 0x0003F1B9
		public unsafe static float MaxBoneOffset
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_MaxBoneOffset, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_MaxBoneOffset, (void*)(&value));
			}
		}

		// Token: 0x1700297F RID: 10623
		// (get) Token: 0x0600887B RID: 34939 RVA: 0x0023F5CC File Offset: 0x0023D7CC
		// (set) Token: 0x0600887C RID: 34940 RVA: 0x00040FC7 File Offset: 0x0003F1C7
		public unsafe static float MaxBoneOffsetSqr
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_MaxBoneOffsetSqr, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_MaxBoneOffsetSqr, (void*)(&value));
			}
		}

		// Token: 0x17002980 RID: 10624
		// (get) Token: 0x0600887D RID: 34941 RVA: 0x0023F5E8 File Offset: 0x0023D7E8
		// (set) Token: 0x0600887E RID: 34942 RVA: 0x00040FD5 File Offset: 0x0003F1D5
		public unsafe static Vector3 SITTING_OFFSET
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_SITTING_OFFSET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_SITTING_OFFSET, (void*)(&value));
			}
		}

		// Token: 0x17002981 RID: 10625
		// (get) Token: 0x0600887F RID: 34943 RVA: 0x0023F604 File Offset: 0x0023D804
		// (set) Token: 0x06008880 RID: 34944 RVA: 0x00040FE3 File Offset: 0x0003F1E3
		public unsafe static float SEAT_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarAnimation.NativeFieldInfoPtr_SEAT_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarAnimation.NativeFieldInfoPtr_SEAT_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002982 RID: 10626
		// (get) Token: 0x06008881 RID: 34945 RVA: 0x0023F620 File Offset: 0x0023D820
		// (set) Token: 0x06008882 RID: 34946 RVA: 0x00040FF1 File Offset: 0x0003F1F1
		public unsafe bool _IsCrouched_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__IsCrouched_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__IsCrouched_k__BackingField)) = value;
			}
		}

		// Token: 0x17002983 RID: 10627
		// (get) Token: 0x06008883 RID: 34947 RVA: 0x0023F648 File Offset: 0x0023D848
		// (set) Token: 0x06008884 RID: 34948 RVA: 0x0004100C File Offset: 0x0003F20C
		public unsafe float _TimeSinceSitEnd_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__TimeSinceSitEnd_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__TimeSinceSitEnd_k__BackingField)) = value;
			}
		}

		// Token: 0x17002984 RID: 10628
		// (get) Token: 0x06008885 RID: 34949 RVA: 0x0023F670 File Offset: 0x0023D870
		// (set) Token: 0x06008886 RID: 34950 RVA: 0x00041027 File Offset: 0x0003F227
		public unsafe AvatarSeat _CurrentSeat_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__CurrentSeat_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSeat>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__CurrentSeat_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002985 RID: 10629
		// (get) Token: 0x06008887 RID: 34951 RVA: 0x0023F6A0 File Offset: 0x0023D8A0
		// (set) Token: 0x06008888 RID: 34952 RVA: 0x00041046 File Offset: 0x0003F246
		public unsafe bool _StandUpAnimationPlaying_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__StandUpAnimationPlaying_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__StandUpAnimationPlaying_k__BackingField)) = value;
			}
		}

		// Token: 0x17002986 RID: 10630
		// (get) Token: 0x06008889 RID: 34953 RVA: 0x0023F6C8 File Offset: 0x0023D8C8
		// (set) Token: 0x0600888A RID: 34954 RVA: 0x00041061 File Offset: 0x0003F261
		public unsafe bool _IsAvatarCulled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__IsAvatarCulled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr__IsAvatarCulled_k__BackingField)) = value;
			}
		}

		// Token: 0x17002987 RID: 10631
		// (get) Token: 0x0600888B RID: 34955 RVA: 0x0023F6F0 File Offset: 0x0023D8F0
		// (set) Token: 0x0600888C RID: 34956 RVA: 0x0004107C File Offset: 0x0003F27C
		public unsafe bool DEBUG_MODE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_DEBUG_MODE);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_DEBUG_MODE)) = value;
			}
		}

		// Token: 0x17002988 RID: 10632
		// (get) Token: 0x0600888D RID: 34957 RVA: 0x0023F718 File Offset: 0x0023D918
		// (set) Token: 0x0600888E RID: 34958 RVA: 0x00041097 File Offset: 0x0003F297
		public unsafe int framesActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_framesActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_framesActive)) = value;
			}
		}

		// Token: 0x17002989 RID: 10633
		// (get) Token: 0x0600888F RID: 34959 RVA: 0x0023F740 File Offset: 0x0023D940
		// (set) Token: 0x06008890 RID: 34960 RVA: 0x000410B2 File Offset: 0x0003F2B2
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700298A RID: 10634
		// (get) Token: 0x06008891 RID: 34961 RVA: 0x0023F770 File Offset: 0x0023D970
		// (set) Token: 0x06008892 RID: 34962 RVA: 0x000410D1 File Offset: 0x0003F2D1
		public unsafe Transform HipBone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_HipBone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_HipBone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700298B RID: 10635
		// (get) Token: 0x06008893 RID: 34963 RVA: 0x0023F7A0 File Offset: 0x0023D9A0
		// (set) Token: 0x06008894 RID: 34964 RVA: 0x000410F0 File Offset: 0x0003F2F0
		public unsafe Il2CppReferenceArray<Transform> Bones
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_Bones);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_Bones), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700298C RID: 10636
		// (get) Token: 0x06008895 RID: 34965 RVA: 0x0023F7D0 File Offset: 0x0023D9D0
		// (set) Token: 0x06008896 RID: 34966 RVA: 0x0004110F File Offset: 0x0003F30F
		public unsafe Avatar avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700298D RID: 10637
		// (get) Token: 0x06008897 RID: 34967 RVA: 0x0023F800 File Offset: 0x0023DA00
		// (set) Token: 0x06008898 RID: 34968 RVA: 0x0004112E File Offset: 0x0003F32E
		public unsafe Transform LeftHandContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_LeftHandContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_LeftHandContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700298E RID: 10638
		// (get) Token: 0x06008899 RID: 34969 RVA: 0x0023F830 File Offset: 0x0023DA30
		// (set) Token: 0x0600889A RID: 34970 RVA: 0x0004114D File Offset: 0x0003F34D
		public unsafe Transform RightHandContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_RightHandContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_RightHandContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700298F RID: 10639
		// (get) Token: 0x0600889B RID: 34971 RVA: 0x0023F860 File Offset: 0x0023DA60
		// (set) Token: 0x0600889C RID: 34972 RVA: 0x0004116C File Offset: 0x0003F36C
		public unsafe Transform RightHandAlignmentPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_RightHandAlignmentPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_RightHandAlignmentPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002990 RID: 10640
		// (get) Token: 0x0600889D RID: 34973 RVA: 0x0023F890 File Offset: 0x0023DA90
		// (set) Token: 0x0600889E RID: 34974 RVA: 0x0004118B File Offset: 0x0003F38B
		public unsafe Transform LeftHandAlignmentPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_LeftHandAlignmentPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_LeftHandAlignmentPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002991 RID: 10641
		// (get) Token: 0x0600889F RID: 34975 RVA: 0x0023F8C0 File Offset: 0x0023DAC0
		// (set) Token: 0x060088A0 RID: 34976 RVA: 0x000411AA File Offset: 0x0003F3AA
		public unsafe AvatarIKController IKController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_IKController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarIKController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_IKController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002992 RID: 10642
		// (get) Token: 0x060088A1 RID: 34977 RVA: 0x0023F8F0 File Offset: 0x0023DAF0
		// (set) Token: 0x060088A2 RID: 34978 RVA: 0x000411C9 File Offset: 0x0003F3C9
		public unsafe LayerMask GroundingMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_GroundingMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_GroundingMask)) = value;
			}
		}

		// Token: 0x17002993 RID: 10643
		// (get) Token: 0x060088A3 RID: 34979 RVA: 0x0023F918 File Offset: 0x0023DB18
		// (set) Token: 0x060088A4 RID: 34980 RVA: 0x000411E4 File Offset: 0x0003F3E4
		public unsafe string StandUpFromBackClipName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_StandUpFromBackClipName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_StandUpFromBackClipName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002994 RID: 10644
		// (get) Token: 0x060088A5 RID: 34981 RVA: 0x0023F940 File Offset: 0x0023DB40
		// (set) Token: 0x060088A6 RID: 34982 RVA: 0x00041203 File Offset: 0x0003F403
		public unsafe string StandUpFromFrontClipName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_StandUpFromFrontClipName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_StandUpFromFrontClipName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002995 RID: 10645
		// (get) Token: 0x060088A7 RID: 34983 RVA: 0x0023F968 File Offset: 0x0023DB68
		// (set) Token: 0x060088A8 RID: 34984 RVA: 0x00041222 File Offset: 0x0003F422
		public unsafe bool UseImpostor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_UseImpostor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_UseImpostor)) = value;
			}
		}

		// Token: 0x17002996 RID: 10646
		// (get) Token: 0x060088A9 RID: 34985 RVA: 0x0023F990 File Offset: 0x0023DB90
		// (set) Token: 0x060088AA RID: 34986 RVA: 0x0004123D File Offset: 0x0003F43D
		public unsafe bool AllowCulling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_AllowCulling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_AllowCulling)) = value;
			}
		}

		// Token: 0x17002997 RID: 10647
		// (get) Token: 0x060088AB RID: 34987 RVA: 0x0023F9B8 File Offset: 0x0023DBB8
		// (set) Token: 0x060088AC RID: 34988 RVA: 0x00041258 File Offset: 0x0003F458
		public unsafe UnityEvent onStandupStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_onStandupStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_onStandupStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002998 RID: 10648
		// (get) Token: 0x060088AD RID: 34989 RVA: 0x0023F9E8 File Offset: 0x0023DBE8
		// (set) Token: 0x060088AE RID: 34990 RVA: 0x00041277 File Offset: 0x0003F477
		public unsafe UnityEvent onStandupDone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_onStandupDone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_onStandupDone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002999 RID: 10649
		// (get) Token: 0x060088AF RID: 34991 RVA: 0x0023FA18 File Offset: 0x0023DC18
		// (set) Token: 0x060088B0 RID: 34992 RVA: 0x00041296 File Offset: 0x0003F496
		public unsafe UnityEvent onHeavyFlinch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_onHeavyFlinch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_onHeavyFlinch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700299A RID: 10650
		// (get) Token: 0x060088B1 RID: 34993 RVA: 0x0023FA48 File Offset: 0x0023DC48
		// (set) Token: 0x060088B2 RID: 34994 RVA: 0x000412B5 File Offset: 0x0003F4B5
		public unsafe Il2CppReferenceArray<BoneTransform> standingBoneTransforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_standingBoneTransforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BoneTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_standingBoneTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700299B RID: 10651
		// (get) Token: 0x060088B3 RID: 34995 RVA: 0x0023FA78 File Offset: 0x0023DC78
		// (set) Token: 0x060088B4 RID: 34996 RVA: 0x000412D4 File Offset: 0x0003F4D4
		public unsafe Il2CppReferenceArray<BoneTransform> standUpFromBackBoneTransforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_standUpFromBackBoneTransforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BoneTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_standUpFromBackBoneTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700299C RID: 10652
		// (get) Token: 0x060088B5 RID: 34997 RVA: 0x0023FAA8 File Offset: 0x0023DCA8
		// (set) Token: 0x060088B6 RID: 34998 RVA: 0x000412F3 File Offset: 0x0003F4F3
		public unsafe Il2CppReferenceArray<BoneTransform> standUpFromFrontBoneTransforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_standUpFromFrontBoneTransforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BoneTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_standUpFromFrontBoneTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700299D RID: 10653
		// (get) Token: 0x060088B7 RID: 34999 RVA: 0x0023FAD8 File Offset: 0x0023DCD8
		// (set) Token: 0x060088B8 RID: 35000 RVA: 0x00041312 File Offset: 0x0003F512
		public unsafe Il2CppReferenceArray<BoneTransform> ragdollBoneTransforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_ragdollBoneTransforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BoneTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_ragdollBoneTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700299E RID: 10654
		// (get) Token: 0x060088B9 RID: 35001 RVA: 0x0023FB08 File Offset: 0x0023DD08
		// (set) Token: 0x060088BA RID: 35002 RVA: 0x00041331 File Offset: 0x0003F531
		public unsafe Coroutine standUpRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_standUpRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_standUpRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700299F RID: 10655
		// (get) Token: 0x060088BB RID: 35003 RVA: 0x0023FB38 File Offset: 0x0023DD38
		// (set) Token: 0x060088BC RID: 35004 RVA: 0x00041350 File Offset: 0x0003F550
		public unsafe Coroutine seatRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_seatRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_seatRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029A0 RID: 10656
		// (get) Token: 0x060088BD RID: 35005 RVA: 0x0023FB68 File Offset: 0x0023DD68
		// (set) Token: 0x060088BE RID: 35006 RVA: 0x0004136F File Offset: 0x0003F56F
		public unsafe Skateboard activeSkateboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_activeSkateboard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_activeSkateboard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029A1 RID: 10657
		// (get) Token: 0x060088BF RID: 35007 RVA: 0x0023FB98 File Offset: 0x0023DD98
		// (set) Token: 0x060088C0 RID: 35008 RVA: 0x0004138E File Offset: 0x0003F58E
		public unsafe bool animationEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_animationEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_animationEnabled)) = value;
			}
		}

		// Token: 0x170029A2 RID: 10658
		// (get) Token: 0x060088C1 RID: 35009 RVA: 0x0023FBC0 File Offset: 0x0023DDC0
		// (set) Token: 0x060088C2 RID: 35010 RVA: 0x000413A9 File Offset: 0x0003F5A9
		public unsafe AnimatorCullingMode initialCullingMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_initialCullingMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.NativeFieldInfoPtr_initialCullingMode)) = value;
			}
		}

		// Token: 0x04005C9C RID: 23708
		private static readonly IntPtr NativeFieldInfoPtr_AnimationRangeSqr;

		// Token: 0x04005C9D RID: 23709
		private static readonly IntPtr NativeFieldInfoPtr_FrustrumCullMinDist;

		// Token: 0x04005C9E RID: 23710
		private static readonly IntPtr NativeFieldInfoPtr_RunningAnimationSpeed;

		// Token: 0x04005C9F RID: 23711
		private static readonly IntPtr NativeFieldInfoPtr_MaxBoneOffset;

		// Token: 0x04005CA0 RID: 23712
		private static readonly IntPtr NativeFieldInfoPtr_MaxBoneOffsetSqr;

		// Token: 0x04005CA1 RID: 23713
		private static readonly IntPtr NativeFieldInfoPtr_SITTING_OFFSET;

		// Token: 0x04005CA2 RID: 23714
		private static readonly IntPtr NativeFieldInfoPtr_SEAT_TIME;

		// Token: 0x04005CA3 RID: 23715
		private static readonly IntPtr NativeFieldInfoPtr__IsCrouched_k__BackingField;

		// Token: 0x04005CA4 RID: 23716
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceSitEnd_k__BackingField;

		// Token: 0x04005CA5 RID: 23717
		private static readonly IntPtr NativeFieldInfoPtr__CurrentSeat_k__BackingField;

		// Token: 0x04005CA6 RID: 23718
		private static readonly IntPtr NativeFieldInfoPtr__StandUpAnimationPlaying_k__BackingField;

		// Token: 0x04005CA7 RID: 23719
		private static readonly IntPtr NativeFieldInfoPtr__IsAvatarCulled_k__BackingField;

		// Token: 0x04005CA8 RID: 23720
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG_MODE;

		// Token: 0x04005CA9 RID: 23721
		private static readonly IntPtr NativeFieldInfoPtr_framesActive;

		// Token: 0x04005CAA RID: 23722
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x04005CAB RID: 23723
		private static readonly IntPtr NativeFieldInfoPtr_HipBone;

		// Token: 0x04005CAC RID: 23724
		private static readonly IntPtr NativeFieldInfoPtr_Bones;

		// Token: 0x04005CAD RID: 23725
		private static readonly IntPtr NativeFieldInfoPtr_avatar;

		// Token: 0x04005CAE RID: 23726
		private static readonly IntPtr NativeFieldInfoPtr_LeftHandContainer;

		// Token: 0x04005CAF RID: 23727
		private static readonly IntPtr NativeFieldInfoPtr_RightHandContainer;

		// Token: 0x04005CB0 RID: 23728
		private static readonly IntPtr NativeFieldInfoPtr_RightHandAlignmentPoint;

		// Token: 0x04005CB1 RID: 23729
		private static readonly IntPtr NativeFieldInfoPtr_LeftHandAlignmentPoint;

		// Token: 0x04005CB2 RID: 23730
		private static readonly IntPtr NativeFieldInfoPtr_IKController;

		// Token: 0x04005CB3 RID: 23731
		private static readonly IntPtr NativeFieldInfoPtr_GroundingMask;

		// Token: 0x04005CB4 RID: 23732
		private static readonly IntPtr NativeFieldInfoPtr_StandUpFromBackClipName;

		// Token: 0x04005CB5 RID: 23733
		private static readonly IntPtr NativeFieldInfoPtr_StandUpFromFrontClipName;

		// Token: 0x04005CB6 RID: 23734
		private static readonly IntPtr NativeFieldInfoPtr_UseImpostor;

		// Token: 0x04005CB7 RID: 23735
		private static readonly IntPtr NativeFieldInfoPtr_AllowCulling;

		// Token: 0x04005CB8 RID: 23736
		private static readonly IntPtr NativeFieldInfoPtr_onStandupStart;

		// Token: 0x04005CB9 RID: 23737
		private static readonly IntPtr NativeFieldInfoPtr_onStandupDone;

		// Token: 0x04005CBA RID: 23738
		private static readonly IntPtr NativeFieldInfoPtr_onHeavyFlinch;

		// Token: 0x04005CBB RID: 23739
		private static readonly IntPtr NativeFieldInfoPtr_standingBoneTransforms;

		// Token: 0x04005CBC RID: 23740
		private static readonly IntPtr NativeFieldInfoPtr_standUpFromBackBoneTransforms;

		// Token: 0x04005CBD RID: 23741
		private static readonly IntPtr NativeFieldInfoPtr_standUpFromFrontBoneTransforms;

		// Token: 0x04005CBE RID: 23742
		private static readonly IntPtr NativeFieldInfoPtr_ragdollBoneTransforms;

		// Token: 0x04005CBF RID: 23743
		private static readonly IntPtr NativeFieldInfoPtr_standUpRoutine;

		// Token: 0x04005CC0 RID: 23744
		private static readonly IntPtr NativeFieldInfoPtr_seatRoutine;

		// Token: 0x04005CC1 RID: 23745
		private static readonly IntPtr NativeFieldInfoPtr_activeSkateboard;

		// Token: 0x04005CC2 RID: 23746
		private static readonly IntPtr NativeFieldInfoPtr_animationEnabled;

		// Token: 0x04005CC3 RID: 23747
		private static readonly IntPtr NativeFieldInfoPtr_initialCullingMode;

		// Token: 0x04005CC4 RID: 23748
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCrouched_Public_get_Boolean_0;

		// Token: 0x04005CC5 RID: 23749
		private static readonly IntPtr NativeMethodInfoPtr_set_IsCrouched_Protected_set_Void_Boolean_0;

		// Token: 0x04005CC6 RID: 23750
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSeated_Public_get_Boolean_0;

		// Token: 0x04005CC7 RID: 23751
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceSitEnd_Public_get_Single_0;

		// Token: 0x04005CC8 RID: 23752
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceSitEnd_Protected_set_Void_Single_0;

		// Token: 0x04005CC9 RID: 23753
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSeat_Public_get_AvatarSeat_0;

		// Token: 0x04005CCA RID: 23754
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentSeat_Protected_set_Void_AvatarSeat_0;

		// Token: 0x04005CCB RID: 23755
		private static readonly IntPtr NativeMethodInfoPtr_get_StandUpAnimationPlaying_Public_get_Boolean_0;

		// Token: 0x04005CCC RID: 23756
		private static readonly IntPtr NativeMethodInfoPtr_set_StandUpAnimationPlaying_Protected_set_Void_Boolean_0;

		// Token: 0x04005CCD RID: 23757
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAvatarCulled_Public_get_Boolean_0;

		// Token: 0x04005CCE RID: 23758
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAvatarCulled_Private_set_Void_Boolean_0;

		// Token: 0x04005CCF RID: 23759
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04005CD0 RID: 23760
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04005CD1 RID: 23761
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04005CD2 RID: 23762
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04005CD3 RID: 23763
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005CD4 RID: 23764
		private static readonly IntPtr NativeMethodInfoPtr_InfrequentUpdate_Private_Void_0;

		// Token: 0x04005CD5 RID: 23765
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04005CD6 RID: 23766
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAnimationActive_Private_Void_Boolean_0;

		// Token: 0x04005CD7 RID: 23767
		private static readonly IntPtr NativeMethodInfoPtr_SetDirection_Public_Void_Single_0;

		// Token: 0x04005CD8 RID: 23768
		private static readonly IntPtr NativeMethodInfoPtr_SetStrafe_Public_Void_Single_0;

		// Token: 0x04005CD9 RID: 23769
		private static readonly IntPtr NativeMethodInfoPtr_SetTimeAirborne_Public_Void_Single_0;

		// Token: 0x04005CDA RID: 23770
		private static readonly IntPtr NativeMethodInfoPtr_SetCrouched_Public_Void_Boolean_0;

		// Token: 0x04005CDB RID: 23771
		private static readonly IntPtr NativeMethodInfoPtr_SetGrounded_Public_Void_Boolean_0;

		// Token: 0x04005CDC RID: 23772
		private static readonly IntPtr NativeMethodInfoPtr_Jump_Public_Void_0;

		// Token: 0x04005CDD RID: 23773
		private static readonly IntPtr NativeMethodInfoPtr_SetAnimationEnabled_Public_Void_Boolean_0;

		// Token: 0x04005CDE RID: 23774
		private static readonly IntPtr NativeMethodInfoPtr_Flinch_Public_Void_Vector3_EFlinchType_0;

		// Token: 0x04005CDF RID: 23775
		private static readonly IntPtr NativeMethodInfoPtr_PlayStandUpAnimation_Public_Void_0;

		// Token: 0x04005CE0 RID: 23776
		private static readonly IntPtr NativeMethodInfoPtr_RagdollChange_Protected_Void_Boolean_Boolean_Boolean_0;

		// Token: 0x04005CE1 RID: 23777
		private static readonly IntPtr NativeMethodInfoPtr_AlignPositionToHips_Private_Void_0;

		// Token: 0x04005CE2 RID: 23778
		private static readonly IntPtr NativeMethodInfoPtr_ShouldGetUpFromBack_Private_Boolean_0;

		// Token: 0x04005CE3 RID: 23779
		private static readonly IntPtr NativeMethodInfoPtr_PopulateBoneTransforms_Private_Void_Il2CppReferenceArray_1_BoneTransform_0;

		// Token: 0x04005CE4 RID: 23780
		private static readonly IntPtr NativeMethodInfoPtr_GetBoneTransforms_Private_List_1_Pose_0;

		// Token: 0x04005CE5 RID: 23781
		private static readonly IntPtr NativeMethodInfoPtr_PopulateAnimationStartBoneTransforms_Private_Void_String_Il2CppReferenceArray_1_BoneTransform_0;

		// Token: 0x04005CE6 RID: 23782
		private static readonly IntPtr NativeMethodInfoPtr_SetTrigger_Public_Void_String_0;

		// Token: 0x04005CE7 RID: 23783
		private static readonly IntPtr NativeMethodInfoPtr_ResetTrigger_Public_Void_String_0;

		// Token: 0x04005CE8 RID: 23784
		private static readonly IntPtr NativeMethodInfoPtr_SetBool_Public_Void_String_Boolean_0;

		// Token: 0x04005CE9 RID: 23785
		private static readonly IntPtr NativeMethodInfoPtr_SetSeat_Public_Void_AvatarSeat_0;

		// Token: 0x04005CEA RID: 23786
		private static readonly IntPtr NativeMethodInfoPtr_SkateboardMounted_Public_Void_Skateboard_0;

		// Token: 0x04005CEB RID: 23787
		private static readonly IntPtr NativeMethodInfoPtr_SkateboardDismounted_Public_Void_0;

		// Token: 0x04005CEC RID: 23788
		private static readonly IntPtr NativeMethodInfoPtr_SkateboardPush_Private_Void_0;

		// Token: 0x04005CED RID: 23789
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B01 RID: 2817
		[OriginalName("Assembly-CSharp.dll", "", "EFlinchType")]
		public enum EFlinchType
		{
			// Token: 0x04009021 RID: 36897
			Light,
			// Token: 0x04009022 RID: 36898
			Heavy
		}

		// Token: 0x02000B02 RID: 2818
		[OriginalName("Assembly-CSharp.dll", "", "EFlinchDirection")]
		public enum EFlinchDirection
		{
			// Token: 0x04009024 RID: 36900
			Forward,
			// Token: 0x04009025 RID: 36901
			Backward,
			// Token: 0x04009026 RID: 36902
			Left,
			// Token: 0x04009027 RID: 36903
			Right
		}

		// Token: 0x02000B03 RID: 2819
		[ObfuscatedName("ScheduleOne.AvatarFramework.Animation.AvatarAnimation+<>c__DisplayClass75_0")]
		public sealed class __c__DisplayClass75_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D652 RID: 54866 RVA: 0x00330810 File Offset: 0x0032EA10
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass75_0()
			{
				Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "<>c__DisplayClass75_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0>.NativeClassPtr);
				AvatarAnimation.__c__DisplayClass75_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0>.NativeClassPtr, "<>4__this");
				AvatarAnimation.__c__DisplayClass75_0.NativeFieldInfoPtr_finalBoneTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0>.NativeClassPtr, "finalBoneTransforms");
				AvatarAnimation.__c__DisplayClass75_0.NativeFieldInfoPtr_standUpFromBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0>.NativeClassPtr, "standUpFromBack");
				AvatarAnimation.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0>.NativeClassPtr, 100680336);
				AvatarAnimation.__c__DisplayClass75_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0>.NativeClassPtr, 100680337);
			}

			// Token: 0x0600D653 RID: 54867 RVA: 0x003308A0 File Offset: 0x0032EAA0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass75_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D654 RID: 54868 RVA: 0x003308DC File Offset: 0x0032EADC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 252523, RefRangeEnd = 252524, XrefRangeStart = 252518, XrefRangeEnd = 252523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass75_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D655 RID: 54869 RVA: 0x000684DF File Offset: 0x000666DF
			public __c__DisplayClass75_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700426B RID: 17003
			// (get) Token: 0x0600D656 RID: 54870 RVA: 0x0033091C File Offset: 0x0032EB1C
			// (set) Token: 0x0600D657 RID: 54871 RVA: 0x000684E8 File Offset: 0x000666E8
			public unsafe AvatarAnimation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarAnimation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700426C RID: 17004
			// (get) Token: 0x0600D658 RID: 54872 RVA: 0x0033094C File Offset: 0x0032EB4C
			// (set) Token: 0x0600D659 RID: 54873 RVA: 0x00068507 File Offset: 0x00066707
			public unsafe Il2CppReferenceArray<BoneTransform> finalBoneTransforms
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.NativeFieldInfoPtr_finalBoneTransforms);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BoneTransform>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.NativeFieldInfoPtr_finalBoneTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700426D RID: 17005
			// (get) Token: 0x0600D65A RID: 54874 RVA: 0x0033097C File Offset: 0x0032EB7C
			// (set) Token: 0x0600D65B RID: 54875 RVA: 0x00068526 File Offset: 0x00066726
			public unsafe bool standUpFromBack
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.NativeFieldInfoPtr_standUpFromBack);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.NativeFieldInfoPtr_standUpFromBack)) = value;
				}
			}

			// Token: 0x04009028 RID: 36904
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009029 RID: 36905
			private static readonly IntPtr NativeFieldInfoPtr_finalBoneTransforms;

			// Token: 0x0400902A RID: 36906
			private static readonly IntPtr NativeFieldInfoPtr_standUpFromBack;

			// Token: 0x0400902B RID: 36907
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400902C RID: 36908
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000C6C RID: 3180
			[ObfuscatedName("ScheduleOne.AvatarFramework.Animation.AvatarAnimation+<>c__DisplayClass75_0+<<PlayStandUpAnimation>g__StandUpRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E4D9 RID: 58585 RVA: 0x0035A5D8 File Offset: 0x003587D8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique()
				{
					Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0>.NativeClassPtr, "<<PlayStandUpAnimation>g__StandUpRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr);
					AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>1__state");
					AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>2__current");
					AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>4__this");
					AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__time_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<time>5__2");
					AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<i>5__3");
					AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680338);
					AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680339);
					AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680340);
					AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680341);
					AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680342);
					AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680343);
				}

				// Token: 0x0600E4DA RID: 58586 RVA: 0x0035A6E0 File Offset: 0x003588E0
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E4DB RID: 58587 RVA: 0x0035A728 File Offset: 0x00358928
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E4DC RID: 58588 RVA: 0x0035A75C File Offset: 0x0035895C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252490, XrefRangeEnd = 252513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700471E RID: 18206
				// (get) Token: 0x0600E4DD RID: 58589 RVA: 0x0035A798 File Offset: 0x00358998
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E4DE RID: 58590 RVA: 0x0035A7D8 File Offset: 0x003589D8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252513, XrefRangeEnd = 252518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700471F RID: 18207
				// (get) Token: 0x0600E4DF RID: 58591 RVA: 0x0035A80C File Offset: 0x00358A0C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E4E0 RID: 58592 RVA: 0x0006F955 File Offset: 0x0006DB55
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004719 RID: 18201
				// (get) Token: 0x0600E4E1 RID: 58593 RVA: 0x0035A84C File Offset: 0x00358A4C
				// (set) Token: 0x0600E4E2 RID: 58594 RVA: 0x0006F95E File Offset: 0x0006DB5E
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700471A RID: 18202
				// (get) Token: 0x0600E4E3 RID: 58595 RVA: 0x0035A874 File Offset: 0x00358A74
				// (set) Token: 0x0600E4E4 RID: 58596 RVA: 0x0006F979 File Offset: 0x0006DB79
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700471B RID: 18203
				// (get) Token: 0x0600E4E5 RID: 58597 RVA: 0x0035A8A4 File Offset: 0x00358AA4
				// (set) Token: 0x0600E4E6 RID: 58598 RVA: 0x0006F998 File Offset: 0x0006DB98
				public unsafe AvatarAnimation.__c__DisplayClass75_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarAnimation.__c__DisplayClass75_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700471C RID: 18204
				// (get) Token: 0x0600E4E7 RID: 58599 RVA: 0x0035A8D4 File Offset: 0x00358AD4
				// (set) Token: 0x0600E4E8 RID: 58600 RVA: 0x0006F9B7 File Offset: 0x0006DBB7
				public unsafe float _time_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__time_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__time_5__2)) = value;
					}
				}

				// Token: 0x1700471D RID: 18205
				// (get) Token: 0x0600E4E9 RID: 58601 RVA: 0x0035A8FC File Offset: 0x00358AFC
				// (set) Token: 0x0600E4EA RID: 58602 RVA: 0x0006F9D2 File Offset: 0x0006DBD2
				public unsafe float _i_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass75_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
					}
				}

				// Token: 0x04009910 RID: 39184
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009911 RID: 39185
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009912 RID: 39186
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009913 RID: 39187
				private static readonly IntPtr NativeFieldInfoPtr__time_5__2;

				// Token: 0x04009914 RID: 39188
				private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

				// Token: 0x04009915 RID: 39189
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009916 RID: 39190
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009917 RID: 39191
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009918 RID: 39192
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009919 RID: 39193
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400991A RID: 39194
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B04 RID: 2820
		[ObfuscatedName("ScheduleOne.AvatarFramework.Animation.AvatarAnimation+<>c__DisplayClass85_0")]
		public sealed class __c__DisplayClass85_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D65C RID: 54876 RVA: 0x003309A4 File Offset: 0x0032EBA4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass85_0()
			{
				Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarAnimation>.NativeClassPtr, "<>c__DisplayClass85_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0>.NativeClassPtr);
				AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0>.NativeClassPtr, "<>4__this");
				AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_startPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0>.NativeClassPtr, "startPos");
				AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_endPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0>.NativeClassPtr, "endPos");
				AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_startRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0>.NativeClassPtr, "startRot");
				AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_endRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0>.NativeClassPtr, "endRot");
				AvatarAnimation.__c__DisplayClass85_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0>.NativeClassPtr, 100680344);
				AvatarAnimation.__c__DisplayClass85_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0>.NativeClassPtr, 100680345);
			}

			// Token: 0x0600D65D RID: 54877 RVA: 0x00330A5C File Offset: 0x0032EC5C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass85_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass85_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D65E RID: 54878 RVA: 0x00330A98 File Offset: 0x0032EC98
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 252550, RefRangeEnd = 252551, XrefRangeStart = 252545, XrefRangeEnd = 252550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_Boolean_0(bool resetLocalCoordinates)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref resetLocalCoordinates;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass85_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D65F RID: 54879 RVA: 0x00068541 File Offset: 0x00066741
			public __c__DisplayClass85_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700426E RID: 17006
			// (get) Token: 0x0600D660 RID: 54880 RVA: 0x00330AE4 File Offset: 0x0032ECE4
			// (set) Token: 0x0600D661 RID: 54881 RVA: 0x0006854A File Offset: 0x0006674A
			public unsafe AvatarAnimation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarAnimation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700426F RID: 17007
			// (get) Token: 0x0600D662 RID: 54882 RVA: 0x00330B14 File Offset: 0x0032ED14
			// (set) Token: 0x0600D663 RID: 54883 RVA: 0x00068569 File Offset: 0x00066769
			public unsafe Vector3 startPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_startPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_startPos)) = value;
				}
			}

			// Token: 0x17004270 RID: 17008
			// (get) Token: 0x0600D664 RID: 54884 RVA: 0x00330B3C File Offset: 0x0032ED3C
			// (set) Token: 0x0600D665 RID: 54885 RVA: 0x00068584 File Offset: 0x00066784
			public unsafe Vector3 endPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_endPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_endPos)) = value;
				}
			}

			// Token: 0x17004271 RID: 17009
			// (get) Token: 0x0600D666 RID: 54886 RVA: 0x00330B64 File Offset: 0x0032ED64
			// (set) Token: 0x0600D667 RID: 54887 RVA: 0x0006859F File Offset: 0x0006679F
			public unsafe Quaternion startRot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_startRot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_startRot)) = value;
				}
			}

			// Token: 0x17004272 RID: 17010
			// (get) Token: 0x0600D668 RID: 54888 RVA: 0x00330B8C File Offset: 0x0032ED8C
			// (set) Token: 0x0600D669 RID: 54889 RVA: 0x000685BA File Offset: 0x000667BA
			public unsafe Quaternion endRot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_endRot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.NativeFieldInfoPtr_endRot)) = value;
				}
			}

			// Token: 0x0400902D RID: 36909
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400902E RID: 36910
			private static readonly IntPtr NativeFieldInfoPtr_startPos;

			// Token: 0x0400902F RID: 36911
			private static readonly IntPtr NativeFieldInfoPtr_endPos;

			// Token: 0x04009030 RID: 36912
			private static readonly IntPtr NativeFieldInfoPtr_startRot;

			// Token: 0x04009031 RID: 36913
			private static readonly IntPtr NativeFieldInfoPtr_endRot;

			// Token: 0x04009032 RID: 36914
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009033 RID: 36915
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_Boolean_0;

			// Token: 0x02000C6D RID: 3181
			[ObfuscatedName("ScheduleOne.AvatarFramework.Animation.AvatarAnimation+<>c__DisplayClass85_0+<<SetSeat>g__Lerp|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E4EB RID: 58603 RVA: 0x0035A924 File Offset: 0x00358B24
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique()
				{
					Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0>.NativeClassPtr, "<<SetSeat>g__Lerp|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr);
					AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, "<>1__state");
					AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, "<>2__current");
					AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, "<>4__this");
					AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr_resetLocalCoordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, "resetLocalCoordinates");
					AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, "<i>5__2");
					AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, 100680346);
					AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, 100680347);
					AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, 100680348);
					AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, 100680349);
					AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, 100680350);
					AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr, 100680351);
				}

				// Token: 0x0600E4EC RID: 58604 RVA: 0x0035AA2C File Offset: 0x00358C2C
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E4ED RID: 58605 RVA: 0x0035AA74 File Offset: 0x00358C74
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E4EE RID: 58606 RVA: 0x0035AAA8 File Offset: 0x00358CA8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252524, XrefRangeEnd = 252540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004725 RID: 18213
				// (get) Token: 0x0600E4EF RID: 58607 RVA: 0x0035AAE4 File Offset: 0x00358CE4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E4F0 RID: 58608 RVA: 0x0035AB24 File Offset: 0x00358D24
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252540, XrefRangeEnd = 252545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004726 RID: 18214
				// (get) Token: 0x0600E4F1 RID: 58609 RVA: 0x0035AB58 File Offset: 0x00358D58
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E4F2 RID: 58610 RVA: 0x0006F9ED File Offset: 0x0006DBED
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004720 RID: 18208
				// (get) Token: 0x0600E4F3 RID: 58611 RVA: 0x0035AB98 File Offset: 0x00358D98
				// (set) Token: 0x0600E4F4 RID: 58612 RVA: 0x0006F9F6 File Offset: 0x0006DBF6
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004721 RID: 18209
				// (get) Token: 0x0600E4F5 RID: 58613 RVA: 0x0035ABC0 File Offset: 0x00358DC0
				// (set) Token: 0x0600E4F6 RID: 58614 RVA: 0x0006FA11 File Offset: 0x0006DC11
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004722 RID: 18210
				// (get) Token: 0x0600E4F7 RID: 58615 RVA: 0x0035ABF0 File Offset: 0x00358DF0
				// (set) Token: 0x0600E4F8 RID: 58616 RVA: 0x0006FA30 File Offset: 0x0006DC30
				public unsafe AvatarAnimation.__c__DisplayClass85_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarAnimation.__c__DisplayClass85_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004723 RID: 18211
				// (get) Token: 0x0600E4F9 RID: 58617 RVA: 0x0035AC20 File Offset: 0x00358E20
				// (set) Token: 0x0600E4FA RID: 58618 RVA: 0x0006FA4F File Offset: 0x0006DC4F
				public unsafe bool resetLocalCoordinates
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr_resetLocalCoordinates);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr_resetLocalCoordinates)) = value;
					}
				}

				// Token: 0x17004724 RID: 18212
				// (get) Token: 0x0600E4FB RID: 58619 RVA: 0x0035AC48 File Offset: 0x00358E48
				// (set) Token: 0x0600E4FC RID: 58620 RVA: 0x0006FA6A File Offset: 0x0006DC6A
				public unsafe float _i_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAnimation.__c__DisplayClass85_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoreSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x0400991B RID: 39195
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400991C RID: 39196
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400991D RID: 39197
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400991E RID: 39198
				private static readonly IntPtr NativeFieldInfoPtr_resetLocalCoordinates;

				// Token: 0x0400991F RID: 39199
				private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x04009920 RID: 39200
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009921 RID: 39201
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009922 RID: 39202
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009923 RID: 39203
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009924 RID: 39204
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009925 RID: 39205
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
