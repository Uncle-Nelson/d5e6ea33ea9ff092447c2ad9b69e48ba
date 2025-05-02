using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRootMotion.FinalIK;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Animation
{
	// Token: 0x0200060D RID: 1549
	public class AvatarLookController : MonoBehaviour
	{
		// Token: 0x060088ED RID: 35053 RVA: 0x002402DC File Offset: 0x0023E4DC
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarLookController()
		{
			Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Animation", "AvatarLookController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr);
			AvatarLookController.NativeFieldInfoPtr_LookAtPlayerRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "LookAtPlayerRange");
			AvatarLookController.NativeFieldInfoPtr_EyeContractRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "EyeContractRange");
			AvatarLookController.NativeFieldInfoPtr_AimIKRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "AimIKRange");
			AvatarLookController.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "DEBUG");
			AvatarLookController.NativeFieldInfoPtr_Aim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "Aim");
			AvatarLookController.NativeFieldInfoPtr_HeadBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "HeadBone");
			AvatarLookController.NativeFieldInfoPtr_LookForwardTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "LookForwardTarget");
			AvatarLookController.NativeFieldInfoPtr_LookOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "LookOrigin");
			AvatarLookController.NativeFieldInfoPtr_Eyes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "Eyes");
			AvatarLookController.NativeFieldInfoPtr_NPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "NPC");
			AvatarLookController.NativeFieldInfoPtr_AutoLookAtPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "AutoLookAtPlayer");
			AvatarLookController.NativeFieldInfoPtr_LookLerpSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "LookLerpSpeed");
			AvatarLookController.NativeFieldInfoPtr_AimIKWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "AimIKWeight");
			AvatarLookController.NativeFieldInfoPtr_BodyRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "BodyRotationSpeed");
			AvatarLookController.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "avatar");
			AvatarLookController.NativeFieldInfoPtr_lookAtPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "lookAtPos");
			AvatarLookController.NativeFieldInfoPtr_lookAtTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "lookAtTarget");
			AvatarLookController.NativeFieldInfoPtr_lastFrameOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "lastFrameOffset");
			AvatarLookController.NativeFieldInfoPtr_overrideLookAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "overrideLookAt");
			AvatarLookController.NativeFieldInfoPtr_overriddenLookTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "overriddenLookTarget");
			AvatarLookController.NativeFieldInfoPtr_overrideLookPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "overrideLookPriority");
			AvatarLookController.NativeFieldInfoPtr_overrideRotateBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "overrideRotateBody");
			AvatarLookController.NativeFieldInfoPtr_lastFrameLookOriginPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "lastFrameLookOriginPos");
			AvatarLookController.NativeFieldInfoPtr_lastFrameLookOriginForward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "lastFrameLookOriginForward");
			AvatarLookController.NativeFieldInfoPtr_ForceLookTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "ForceLookTarget");
			AvatarLookController.NativeFieldInfoPtr_ForceLookRotateBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "ForceLookRotateBody");
			AvatarLookController.NativeFieldInfoPtr_defaultIKWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "defaultIKWeight");
			AvatarLookController.NativeFieldInfoPtr_nearestPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "nearestPlayer");
			AvatarLookController.NativeFieldInfoPtr_nearestPlayerDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "nearestPlayerDist");
			AvatarLookController.NativeFieldInfoPtr_localPlayerDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "localPlayerDist");
			AvatarLookController.NativeFieldInfoPtr_cullRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, "cullRange");
			AvatarLookController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680362);
			AvatarLookController.NativeMethodInfoPtr_UpdateShit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680363);
			AvatarLookController.NativeMethodInfoPtr_UpdateNearestPlayer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680364);
			AvatarLookController.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680365);
			AvatarLookController.NativeMethodInfoPtr_OverrideLookTarget_Public_Void_Vector3_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680366);
			AvatarLookController.NativeMethodInfoPtr_LookForward_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680367);
			AvatarLookController.NativeMethodInfoPtr_LerpTargetTransform_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680368);
			AvatarLookController.NativeMethodInfoPtr_GetNearestPlayer_Private_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680369);
			AvatarLookController.NativeMethodInfoPtr_CanLookAt_Private_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680370);
			AvatarLookController.NativeMethodInfoPtr_RagdollChange_Protected_Void_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680371);
			AvatarLookController.NativeMethodInfoPtr_OverrideIKWeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680372);
			AvatarLookController.NativeMethodInfoPtr_ResetIKWeight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680373);
			AvatarLookController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680374);
			AvatarLookController.NativeMethodInfoPtr__GetNearestPlayer_b__38_0_Private_Single_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr, 100680375);
		}

		// Token: 0x060088EE RID: 35054 RVA: 0x00240690 File Offset: 0x0023E890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253193, XrefRangeEnd = 253236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088EF RID: 35055 RVA: 0x002406C4 File Offset: 0x0023E8C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253254, RefRangeEnd = 253255, XrefRangeStart = 253236, XrefRangeEnd = 253254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateShit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_UpdateShit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088F0 RID: 35056 RVA: 0x002406F8 File Offset: 0x0023E8F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253255, XrefRangeEnd = 253310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateNearestPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_UpdateNearestPlayer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088F1 RID: 35057 RVA: 0x0024072C File Offset: 0x0023E92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253310, XrefRangeEnd = 253361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088F2 RID: 35058 RVA: 0x00240760 File Offset: 0x0023E960
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 253378, RefRangeEnd = 253394, XrefRangeStart = 253361, XrefRangeEnd = 253378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideLookTarget(Vector3 targetPosition, int priority, bool rotateBody = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotateBody;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_OverrideLookTarget_Public_Void_Vector3_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088F3 RID: 35059 RVA: 0x002407BC File Offset: 0x0023E9BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253405, RefRangeEnd = 253406, XrefRangeStart = 253394, XrefRangeEnd = 253405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookForward()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_LookForward_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088F4 RID: 35060 RVA: 0x002407F0 File Offset: 0x0023E9F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253424, RefRangeEnd = 253425, XrefRangeStart = 253406, XrefRangeEnd = 253424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LerpTargetTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_LerpTargetTransform_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088F5 RID: 35061 RVA: 0x00240824 File Offset: 0x0023EA24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253425, XrefRangeEnd = 253442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Player GetNearestPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_GetNearestPlayer_Private_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
		}

		// Token: 0x060088F6 RID: 35062 RVA: 0x00240864 File Offset: 0x0023EA64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253451, RefRangeEnd = 253452, XrefRangeStart = 253442, XrefRangeEnd = 253451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanLookAt(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_CanLookAt_Private_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060088F7 RID: 35063 RVA: 0x002408B0 File Offset: 0x0023EAB0
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RagdollChange(bool oldValue, bool ragdoll, bool playStandUpAnim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldValue;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ragdoll;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playStandUpAnim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_RagdollChange_Protected_Void_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088F8 RID: 35064 RVA: 0x0024090C File Offset: 0x0023EB0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 253454, RefRangeEnd = 253457, XrefRangeStart = 253452, XrefRangeEnd = 253454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideIKWeight(float weight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref weight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_OverrideIKWeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088F9 RID: 35065 RVA: 0x0024094C File Offset: 0x0023EB4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253459, RefRangeEnd = 253460, XrefRangeStart = 253457, XrefRangeEnd = 253459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetIKWeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr_ResetIKWeight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088FA RID: 35066 RVA: 0x00240980 File Offset: 0x0023EB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253460, XrefRangeEnd = 253467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarLookController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarLookController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088FB RID: 35067 RVA: 0x002409BC File Offset: 0x0023EBBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253467, XrefRangeEnd = 253474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _GetNearestPlayer_b__38_0(Player p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLookController.NativeMethodInfoPtr__GetNearestPlayer_b__38_0_Private_Single_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060088FC RID: 35068 RVA: 0x00041556 File Offset: 0x0003F756
		public AvatarLookController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170029B7 RID: 10679
		// (get) Token: 0x060088FD RID: 35069 RVA: 0x00240A0C File Offset: 0x0023EC0C
		// (set) Token: 0x060088FE RID: 35070 RVA: 0x0004155F File Offset: 0x0003F75F
		public unsafe static float LookAtPlayerRange
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarLookController.NativeFieldInfoPtr_LookAtPlayerRange, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarLookController.NativeFieldInfoPtr_LookAtPlayerRange, (void*)(&value));
			}
		}

		// Token: 0x170029B8 RID: 10680
		// (get) Token: 0x060088FF RID: 35071 RVA: 0x00240A28 File Offset: 0x0023EC28
		// (set) Token: 0x06008900 RID: 35072 RVA: 0x0004156D File Offset: 0x0003F76D
		public unsafe static float EyeContractRange
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarLookController.NativeFieldInfoPtr_EyeContractRange, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarLookController.NativeFieldInfoPtr_EyeContractRange, (void*)(&value));
			}
		}

		// Token: 0x170029B9 RID: 10681
		// (get) Token: 0x06008901 RID: 35073 RVA: 0x00240A44 File Offset: 0x0023EC44
		// (set) Token: 0x06008902 RID: 35074 RVA: 0x0004157B File Offset: 0x0003F77B
		public unsafe static float AimIKRange
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarLookController.NativeFieldInfoPtr_AimIKRange, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarLookController.NativeFieldInfoPtr_AimIKRange, (void*)(&value));
			}
		}

		// Token: 0x170029BA RID: 10682
		// (get) Token: 0x06008903 RID: 35075 RVA: 0x00240A60 File Offset: 0x0023EC60
		// (set) Token: 0x06008904 RID: 35076 RVA: 0x00041589 File Offset: 0x0003F789
		public unsafe bool DEBUG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x170029BB RID: 10683
		// (get) Token: 0x06008905 RID: 35077 RVA: 0x00240A88 File Offset: 0x0023EC88
		// (set) Token: 0x06008906 RID: 35078 RVA: 0x000415A4 File Offset: 0x0003F7A4
		public unsafe AimIK Aim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_Aim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AimIK>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_Aim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029BC RID: 10684
		// (get) Token: 0x06008907 RID: 35079 RVA: 0x00240AB8 File Offset: 0x0023ECB8
		// (set) Token: 0x06008908 RID: 35080 RVA: 0x000415C3 File Offset: 0x0003F7C3
		public unsafe Transform HeadBone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_HeadBone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_HeadBone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029BD RID: 10685
		// (get) Token: 0x06008909 RID: 35081 RVA: 0x00240AE8 File Offset: 0x0023ECE8
		// (set) Token: 0x0600890A RID: 35082 RVA: 0x000415E2 File Offset: 0x0003F7E2
		public unsafe Transform LookForwardTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_LookForwardTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_LookForwardTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029BE RID: 10686
		// (get) Token: 0x0600890B RID: 35083 RVA: 0x00240B18 File Offset: 0x0023ED18
		// (set) Token: 0x0600890C RID: 35084 RVA: 0x00041601 File Offset: 0x0003F801
		public unsafe Transform LookOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_LookOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_LookOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029BF RID: 10687
		// (get) Token: 0x0600890D RID: 35085 RVA: 0x00240B48 File Offset: 0x0023ED48
		// (set) Token: 0x0600890E RID: 35086 RVA: 0x00041620 File Offset: 0x0003F820
		public unsafe EyeController Eyes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_Eyes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EyeController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_Eyes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029C0 RID: 10688
		// (get) Token: 0x0600890F RID: 35087 RVA: 0x00240B78 File Offset: 0x0023ED78
		// (set) Token: 0x06008910 RID: 35088 RVA: 0x0004163F File Offset: 0x0003F83F
		public unsafe NPC NPC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_NPC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_NPC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029C1 RID: 10689
		// (get) Token: 0x06008911 RID: 35089 RVA: 0x00240BA8 File Offset: 0x0023EDA8
		// (set) Token: 0x06008912 RID: 35090 RVA: 0x0004165E File Offset: 0x0003F85E
		public unsafe bool AutoLookAtPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_AutoLookAtPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_AutoLookAtPlayer)) = value;
			}
		}

		// Token: 0x170029C2 RID: 10690
		// (get) Token: 0x06008913 RID: 35091 RVA: 0x00240BD0 File Offset: 0x0023EDD0
		// (set) Token: 0x06008914 RID: 35092 RVA: 0x00041679 File Offset: 0x0003F879
		public unsafe float LookLerpSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_LookLerpSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_LookLerpSpeed)) = value;
			}
		}

		// Token: 0x170029C3 RID: 10691
		// (get) Token: 0x06008915 RID: 35093 RVA: 0x00240BF8 File Offset: 0x0023EDF8
		// (set) Token: 0x06008916 RID: 35094 RVA: 0x00041694 File Offset: 0x0003F894
		public unsafe float AimIKWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_AimIKWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_AimIKWeight)) = value;
			}
		}

		// Token: 0x170029C4 RID: 10692
		// (get) Token: 0x06008917 RID: 35095 RVA: 0x00240C20 File Offset: 0x0023EE20
		// (set) Token: 0x06008918 RID: 35096 RVA: 0x000416AF File Offset: 0x0003F8AF
		public unsafe float BodyRotationSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_BodyRotationSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_BodyRotationSpeed)) = value;
			}
		}

		// Token: 0x170029C5 RID: 10693
		// (get) Token: 0x06008919 RID: 35097 RVA: 0x00240C48 File Offset: 0x0023EE48
		// (set) Token: 0x0600891A RID: 35098 RVA: 0x000416CA File Offset: 0x0003F8CA
		public unsafe Avatar avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029C6 RID: 10694
		// (get) Token: 0x0600891B RID: 35099 RVA: 0x00240C78 File Offset: 0x0023EE78
		// (set) Token: 0x0600891C RID: 35100 RVA: 0x000416E9 File Offset: 0x0003F8E9
		public unsafe Vector3 lookAtPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lookAtPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lookAtPos)) = value;
			}
		}

		// Token: 0x170029C7 RID: 10695
		// (get) Token: 0x0600891D RID: 35101 RVA: 0x00240CA0 File Offset: 0x0023EEA0
		// (set) Token: 0x0600891E RID: 35102 RVA: 0x00041704 File Offset: 0x0003F904
		public unsafe Transform lookAtTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lookAtTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lookAtTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029C8 RID: 10696
		// (get) Token: 0x0600891F RID: 35103 RVA: 0x00240CD0 File Offset: 0x0023EED0
		// (set) Token: 0x06008920 RID: 35104 RVA: 0x00041723 File Offset: 0x0003F923
		public unsafe Vector3 lastFrameOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lastFrameOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lastFrameOffset)) = value;
			}
		}

		// Token: 0x170029C9 RID: 10697
		// (get) Token: 0x06008921 RID: 35105 RVA: 0x00240CF8 File Offset: 0x0023EEF8
		// (set) Token: 0x06008922 RID: 35106 RVA: 0x0004173E File Offset: 0x0003F93E
		public unsafe bool overrideLookAt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_overrideLookAt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_overrideLookAt)) = value;
			}
		}

		// Token: 0x170029CA RID: 10698
		// (get) Token: 0x06008923 RID: 35107 RVA: 0x00240D20 File Offset: 0x0023EF20
		// (set) Token: 0x06008924 RID: 35108 RVA: 0x00041759 File Offset: 0x0003F959
		public unsafe Vector3 overriddenLookTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_overriddenLookTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_overriddenLookTarget)) = value;
			}
		}

		// Token: 0x170029CB RID: 10699
		// (get) Token: 0x06008925 RID: 35109 RVA: 0x00240D48 File Offset: 0x0023EF48
		// (set) Token: 0x06008926 RID: 35110 RVA: 0x00041774 File Offset: 0x0003F974
		public unsafe int overrideLookPriority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_overrideLookPriority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_overrideLookPriority)) = value;
			}
		}

		// Token: 0x170029CC RID: 10700
		// (get) Token: 0x06008927 RID: 35111 RVA: 0x00240D70 File Offset: 0x0023EF70
		// (set) Token: 0x06008928 RID: 35112 RVA: 0x0004178F File Offset: 0x0003F98F
		public unsafe bool overrideRotateBody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_overrideRotateBody);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_overrideRotateBody)) = value;
			}
		}

		// Token: 0x170029CD RID: 10701
		// (get) Token: 0x06008929 RID: 35113 RVA: 0x00240D98 File Offset: 0x0023EF98
		// (set) Token: 0x0600892A RID: 35114 RVA: 0x000417AA File Offset: 0x0003F9AA
		public unsafe Vector3 lastFrameLookOriginPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lastFrameLookOriginPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lastFrameLookOriginPos)) = value;
			}
		}

		// Token: 0x170029CE RID: 10702
		// (get) Token: 0x0600892B RID: 35115 RVA: 0x00240DC0 File Offset: 0x0023EFC0
		// (set) Token: 0x0600892C RID: 35116 RVA: 0x000417C5 File Offset: 0x0003F9C5
		public unsafe Vector3 lastFrameLookOriginForward
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lastFrameLookOriginForward);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_lastFrameLookOriginForward)) = value;
			}
		}

		// Token: 0x170029CF RID: 10703
		// (get) Token: 0x0600892D RID: 35117 RVA: 0x00240DE8 File Offset: 0x0023EFE8
		// (set) Token: 0x0600892E RID: 35118 RVA: 0x000417E0 File Offset: 0x0003F9E0
		public unsafe Transform ForceLookTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_ForceLookTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_ForceLookTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029D0 RID: 10704
		// (get) Token: 0x0600892F RID: 35119 RVA: 0x00240E18 File Offset: 0x0023F018
		// (set) Token: 0x06008930 RID: 35120 RVA: 0x000417FF File Offset: 0x0003F9FF
		public unsafe bool ForceLookRotateBody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_ForceLookRotateBody);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_ForceLookRotateBody)) = value;
			}
		}

		// Token: 0x170029D1 RID: 10705
		// (get) Token: 0x06008931 RID: 35121 RVA: 0x00240E40 File Offset: 0x0023F040
		// (set) Token: 0x06008932 RID: 35122 RVA: 0x0004181A File Offset: 0x0003FA1A
		public unsafe float defaultIKWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_defaultIKWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_defaultIKWeight)) = value;
			}
		}

		// Token: 0x170029D2 RID: 10706
		// (get) Token: 0x06008933 RID: 35123 RVA: 0x00240E68 File Offset: 0x0023F068
		// (set) Token: 0x06008934 RID: 35124 RVA: 0x00041835 File Offset: 0x0003FA35
		public unsafe Player nearestPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_nearestPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_nearestPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029D3 RID: 10707
		// (get) Token: 0x06008935 RID: 35125 RVA: 0x00240E98 File Offset: 0x0023F098
		// (set) Token: 0x06008936 RID: 35126 RVA: 0x00041854 File Offset: 0x0003FA54
		public unsafe float nearestPlayerDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_nearestPlayerDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_nearestPlayerDist)) = value;
			}
		}

		// Token: 0x170029D4 RID: 10708
		// (get) Token: 0x06008937 RID: 35127 RVA: 0x00240EC0 File Offset: 0x0023F0C0
		// (set) Token: 0x06008938 RID: 35128 RVA: 0x0004186F File Offset: 0x0003FA6F
		public unsafe float localPlayerDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_localPlayerDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_localPlayerDist)) = value;
			}
		}

		// Token: 0x170029D5 RID: 10709
		// (get) Token: 0x06008939 RID: 35129 RVA: 0x00240EE8 File Offset: 0x0023F0E8
		// (set) Token: 0x0600893A RID: 35130 RVA: 0x0004188A File Offset: 0x0003FA8A
		public unsafe float cullRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_cullRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLookController.NativeFieldInfoPtr_cullRange)) = value;
			}
		}

		// Token: 0x04005D06 RID: 23814
		private static readonly IntPtr NativeFieldInfoPtr_LookAtPlayerRange;

		// Token: 0x04005D07 RID: 23815
		private static readonly IntPtr NativeFieldInfoPtr_EyeContractRange;

		// Token: 0x04005D08 RID: 23816
		private static readonly IntPtr NativeFieldInfoPtr_AimIKRange;

		// Token: 0x04005D09 RID: 23817
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04005D0A RID: 23818
		private static readonly IntPtr NativeFieldInfoPtr_Aim;

		// Token: 0x04005D0B RID: 23819
		private static readonly IntPtr NativeFieldInfoPtr_HeadBone;

		// Token: 0x04005D0C RID: 23820
		private static readonly IntPtr NativeFieldInfoPtr_LookForwardTarget;

		// Token: 0x04005D0D RID: 23821
		private static readonly IntPtr NativeFieldInfoPtr_LookOrigin;

		// Token: 0x04005D0E RID: 23822
		private static readonly IntPtr NativeFieldInfoPtr_Eyes;

		// Token: 0x04005D0F RID: 23823
		private static readonly IntPtr NativeFieldInfoPtr_NPC;

		// Token: 0x04005D10 RID: 23824
		private static readonly IntPtr NativeFieldInfoPtr_AutoLookAtPlayer;

		// Token: 0x04005D11 RID: 23825
		private static readonly IntPtr NativeFieldInfoPtr_LookLerpSpeed;

		// Token: 0x04005D12 RID: 23826
		private static readonly IntPtr NativeFieldInfoPtr_AimIKWeight;

		// Token: 0x04005D13 RID: 23827
		private static readonly IntPtr NativeFieldInfoPtr_BodyRotationSpeed;

		// Token: 0x04005D14 RID: 23828
		private static readonly IntPtr NativeFieldInfoPtr_avatar;

		// Token: 0x04005D15 RID: 23829
		private static readonly IntPtr NativeFieldInfoPtr_lookAtPos;

		// Token: 0x04005D16 RID: 23830
		private static readonly IntPtr NativeFieldInfoPtr_lookAtTarget;

		// Token: 0x04005D17 RID: 23831
		private static readonly IntPtr NativeFieldInfoPtr_lastFrameOffset;

		// Token: 0x04005D18 RID: 23832
		private static readonly IntPtr NativeFieldInfoPtr_overrideLookAt;

		// Token: 0x04005D19 RID: 23833
		private static readonly IntPtr NativeFieldInfoPtr_overriddenLookTarget;

		// Token: 0x04005D1A RID: 23834
		private static readonly IntPtr NativeFieldInfoPtr_overrideLookPriority;

		// Token: 0x04005D1B RID: 23835
		private static readonly IntPtr NativeFieldInfoPtr_overrideRotateBody;

		// Token: 0x04005D1C RID: 23836
		private static readonly IntPtr NativeFieldInfoPtr_lastFrameLookOriginPos;

		// Token: 0x04005D1D RID: 23837
		private static readonly IntPtr NativeFieldInfoPtr_lastFrameLookOriginForward;

		// Token: 0x04005D1E RID: 23838
		private static readonly IntPtr NativeFieldInfoPtr_ForceLookTarget;

		// Token: 0x04005D1F RID: 23839
		private static readonly IntPtr NativeFieldInfoPtr_ForceLookRotateBody;

		// Token: 0x04005D20 RID: 23840
		private static readonly IntPtr NativeFieldInfoPtr_defaultIKWeight;

		// Token: 0x04005D21 RID: 23841
		private static readonly IntPtr NativeFieldInfoPtr_nearestPlayer;

		// Token: 0x04005D22 RID: 23842
		private static readonly IntPtr NativeFieldInfoPtr_nearestPlayerDist;

		// Token: 0x04005D23 RID: 23843
		private static readonly IntPtr NativeFieldInfoPtr_localPlayerDist;

		// Token: 0x04005D24 RID: 23844
		private static readonly IntPtr NativeFieldInfoPtr_cullRange;

		// Token: 0x04005D25 RID: 23845
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005D26 RID: 23846
		private static readonly IntPtr NativeMethodInfoPtr_UpdateShit_Private_Void_0;

		// Token: 0x04005D27 RID: 23847
		private static readonly IntPtr NativeMethodInfoPtr_UpdateNearestPlayer_Private_Void_0;

		// Token: 0x04005D28 RID: 23848
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04005D29 RID: 23849
		private static readonly IntPtr NativeMethodInfoPtr_OverrideLookTarget_Public_Void_Vector3_Int32_Boolean_0;

		// Token: 0x04005D2A RID: 23850
		private static readonly IntPtr NativeMethodInfoPtr_LookForward_Private_Void_0;

		// Token: 0x04005D2B RID: 23851
		private static readonly IntPtr NativeMethodInfoPtr_LerpTargetTransform_Private_Void_0;

		// Token: 0x04005D2C RID: 23852
		private static readonly IntPtr NativeMethodInfoPtr_GetNearestPlayer_Private_Player_0;

		// Token: 0x04005D2D RID: 23853
		private static readonly IntPtr NativeMethodInfoPtr_CanLookAt_Private_Boolean_Vector3_0;

		// Token: 0x04005D2E RID: 23854
		private static readonly IntPtr NativeMethodInfoPtr_RagdollChange_Protected_Void_Boolean_Boolean_Boolean_0;

		// Token: 0x04005D2F RID: 23855
		private static readonly IntPtr NativeMethodInfoPtr_OverrideIKWeight_Public_Void_Single_0;

		// Token: 0x04005D30 RID: 23856
		private static readonly IntPtr NativeMethodInfoPtr_ResetIKWeight_Public_Void_0;

		// Token: 0x04005D31 RID: 23857
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005D32 RID: 23858
		private static readonly IntPtr NativeMethodInfoPtr__GetNearestPlayer_b__38_0_Private_Single_Player_0;
	}
}
