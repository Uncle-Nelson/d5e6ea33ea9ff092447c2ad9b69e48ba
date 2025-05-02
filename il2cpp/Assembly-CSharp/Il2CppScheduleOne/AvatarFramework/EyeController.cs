using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x020005F8 RID: 1528
	public class EyeController : MonoBehaviour
	{
		// Token: 0x06008698 RID: 34456 RVA: 0x002398BC File Offset: 0x00237ABC
		// Note: this type is marked as 'beforefieldinit'.
		static EyeController()
		{
			Il2CppClassPointerStore<EyeController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "EyeController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyeController>.NativeClassPtr);
			EyeController.NativeFieldInfoPtr_eyeHeightMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "eyeHeightMultiplier");
			EyeController.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "DEBUG");
			EyeController.NativeFieldInfoPtr__EyesOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "<EyesOpen>k__BackingField");
			EyeController.NativeFieldInfoPtr_leftEye = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "leftEye");
			EyeController.NativeFieldInfoPtr_rightEye = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "rightEye");
			EyeController.NativeFieldInfoPtr_eyeSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "eyeSpacing");
			EyeController.NativeFieldInfoPtr_eyeHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "eyeHeight");
			EyeController.NativeFieldInfoPtr_eyeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "eyeSize");
			EyeController.NativeFieldInfoPtr_leftEyeLidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "leftEyeLidColor");
			EyeController.NativeFieldInfoPtr_rightEyeLidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "rightEyeLidColor");
			EyeController.NativeFieldInfoPtr_LeftRestingEyeState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "LeftRestingEyeState");
			EyeController.NativeFieldInfoPtr_RightRestingEyeState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "RightRestingEyeState");
			EyeController.NativeFieldInfoPtr_eyeBallMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "eyeBallMaterial");
			EyeController.NativeFieldInfoPtr_eyeBallColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "eyeBallColor");
			EyeController.NativeFieldInfoPtr_PupilDilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "PupilDilation");
			EyeController.NativeFieldInfoPtr_BlinkingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "BlinkingEnabled");
			EyeController.NativeFieldInfoPtr_blinkInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "blinkInterval");
			EyeController.NativeFieldInfoPtr_blinkIntervalSpread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "blinkIntervalSpread");
			EyeController.NativeFieldInfoPtr_blinkDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "blinkDuration");
			EyeController.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "avatar");
			EyeController.NativeFieldInfoPtr_blinkRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "blinkRoutine");
			EyeController.NativeFieldInfoPtr_timeUntilNextBlink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "timeUntilNextBlink");
			EyeController.NativeFieldInfoPtr_eyeBallTintOverridden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "eyeBallTintOverridden");
			EyeController.NativeFieldInfoPtr_eyeLidOverridden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "eyeLidOverridden");
			EyeController.NativeFieldInfoPtr_defaultLeftEyeRestingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "defaultLeftEyeRestingState");
			EyeController.NativeFieldInfoPtr_defaultRightEyeRestingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "defaultRightEyeRestingState");
			EyeController.NativeFieldInfoPtr_defaultDilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "defaultDilation");
			EyeController.NativeMethodInfoPtr_get_EyesOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680106);
			EyeController.NativeMethodInfoPtr_set_EyesOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680107);
			EyeController.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680108);
			EyeController.NativeMethodInfoPtr_Update_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680109);
			EyeController.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680110);
			EyeController.NativeMethodInfoPtr_ApplySettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680111);
			EyeController.NativeMethodInfoPtr_SetEyeballTint_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680112);
			EyeController.NativeMethodInfoPtr_OverrideEyeballTint_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680113);
			EyeController.NativeMethodInfoPtr_ResetEyeballTint_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680114);
			EyeController.NativeMethodInfoPtr_OverrideEyeLids_Public_Void_EyeLidConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680115);
			EyeController.NativeMethodInfoPtr_ResetEyeLids_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680116);
			EyeController.NativeMethodInfoPtr_RagdollChange_Private_Void_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680117);
			EyeController.NativeMethodInfoPtr_SetEyesOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680118);
			EyeController.NativeMethodInfoPtr_ApplyDilation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680119);
			EyeController.NativeMethodInfoPtr_SetPupilDilation_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680120);
			EyeController.NativeMethodInfoPtr_ResetPupilDilation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680121);
			EyeController.NativeMethodInfoPtr_ApplyRestingEyeLidState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680122);
			EyeController.NativeMethodInfoPtr_ForceBlink_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680123);
			EyeController.NativeMethodInfoPtr_SetLeftEyeRestingLidState_Public_Void_EyeLidConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680124);
			EyeController.NativeMethodInfoPtr_SetRightEyeRestingLidState_Public_Void_EyeLidConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680125);
			EyeController.NativeMethodInfoPtr_BlinkRoutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680126);
			EyeController.NativeMethodInfoPtr_ResetBlinkCounter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680127);
			EyeController.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680128);
			EyeController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680129);
			EyeController.NativeMethodInfoPtr__BlinkRoutine_b__48_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680131);
		}

		// Token: 0x17002900 RID: 10496
		// (get) Token: 0x06008699 RID: 34457 RVA: 0x00239CFC File Offset: 0x00237EFC
		// (set) Token: 0x0600869A RID: 34458 RVA: 0x00239D38 File Offset: 0x00237F38
		public unsafe bool EyesOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_get_EyesOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_set_EyesOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600869B RID: 34459 RVA: 0x00239D78 File Offset: 0x00237F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251207, XrefRangeEnd = 251224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EyeController.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600869C RID: 34460 RVA: 0x00239DB4 File Offset: 0x00237FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251224, XrefRangeEnd = 251239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_Update_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600869D RID: 34461 RVA: 0x00239DE8 File Offset: 0x00237FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251239, XrefRangeEnd = 251240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600869E RID: 34462 RVA: 0x00239E1C File Offset: 0x0023801C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251240, XrefRangeEnd = 251269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplySettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_ApplySettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600869F RID: 34463 RVA: 0x00239E50 File Offset: 0x00238050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251269, XrefRangeEnd = 251271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEyeballTint(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_SetEyeballTint_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086A0 RID: 34464 RVA: 0x00239E90 File Offset: 0x00238090
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 251273, RefRangeEnd = 251279, XrefRangeStart = 251271, XrefRangeEnd = 251273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideEyeballTint(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_OverrideEyeballTint_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086A1 RID: 34465 RVA: 0x00239ED0 File Offset: 0x002380D0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 251281, RefRangeEnd = 251287, XrefRangeStart = 251279, XrefRangeEnd = 251281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetEyeballTint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_ResetEyeballTint_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086A2 RID: 34466 RVA: 0x00239F04 File Offset: 0x00238104
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 251287, RefRangeEnd = 251296, XrefRangeStart = 251287, XrefRangeEnd = 251287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideEyeLids(Eye.EyeLidConfiguration eyeLidConfiguration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref eyeLidConfiguration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_OverrideEyeLids_Public_Void_EyeLidConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086A3 RID: 34467 RVA: 0x00239F44 File Offset: 0x00238144
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 251296, RefRangeEnd = 251308, XrefRangeStart = 251296, XrefRangeEnd = 251296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetEyeLids()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_ResetEyeLids_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086A4 RID: 34468 RVA: 0x00239F78 File Offset: 0x00238178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251308, XrefRangeEnd = 251311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RagdollChange(bool oldValue, bool newValue, bool playStandUpAnim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldValue;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playStandUpAnim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_RagdollChange_Private_Void_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086A5 RID: 34469 RVA: 0x00239FD4 File Offset: 0x002381D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 251326, RefRangeEnd = 251328, XrefRangeStart = 251311, XrefRangeEnd = 251326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEyesOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_SetEyesOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086A6 RID: 34470 RVA: 0x0023A014 File Offset: 0x00238214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251328, XrefRangeEnd = 251331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyDilation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_ApplyDilation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086A7 RID: 34471 RVA: 0x0023A048 File Offset: 0x00238248
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 251333, RefRangeEnd = 251339, XrefRangeStart = 251331, XrefRangeEnd = 251333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPupilDilation(float dilation, bool writeDefault = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dilation;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeDefault;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_SetPupilDilation_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086A8 RID: 34472 RVA: 0x0023A094 File Offset: 0x00238294
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 251341, RefRangeEnd = 251347, XrefRangeStart = 251339, XrefRangeEnd = 251341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetPupilDilation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_ResetPupilDilation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086A9 RID: 34473 RVA: 0x0023A0C8 File Offset: 0x002382C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 251350, RefRangeEnd = 251352, XrefRangeStart = 251347, XrefRangeEnd = 251350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyRestingEyeLidState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_ApplyRestingEyeLidState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086AA RID: 34474 RVA: 0x0023A0FC File Offset: 0x002382FC
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 251355, RefRangeEnd = 251378, XrefRangeStart = 251352, XrefRangeEnd = 251355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceBlink()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_ForceBlink_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086AB RID: 34475 RVA: 0x0023A130 File Offset: 0x00238330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251378, XrefRangeEnd = 251379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLeftEyeRestingLidState(Eye.EyeLidConfiguration config)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref config;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_SetLeftEyeRestingLidState_Public_Void_EyeLidConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086AC RID: 34476 RVA: 0x0023A170 File Offset: 0x00238370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251379, XrefRangeEnd = 251380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRightEyeRestingLidState(Eye.EyeLidConfiguration config)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref config;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_SetRightEyeRestingLidState_Public_Void_EyeLidConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086AD RID: 34477 RVA: 0x0023A1B0 File Offset: 0x002383B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251380, XrefRangeEnd = 251385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator BlinkRoutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_BlinkRoutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060086AE RID: 34478 RVA: 0x0023A1F0 File Offset: 0x002383F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251385, XrefRangeEnd = 251386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetBlinkCounter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_ResetBlinkCounter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086AF RID: 34479 RVA: 0x0023A224 File Offset: 0x00238424
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 251388, RefRangeEnd = 251389, XrefRangeStart = 251386, XrefRangeEnd = 251388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAt(Vector3 position, bool instant = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instant;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086B0 RID: 34480 RVA: 0x0023A270 File Offset: 0x00238470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251389, XrefRangeEnd = 251390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EyeController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EyeController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086B1 RID: 34481 RVA: 0x0023A2AC File Offset: 0x002384AC
		[CallerCount(0)]
		public unsafe bool _BlinkRoutine_b__48_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr__BlinkRoutine_b__48_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060086B2 RID: 34482 RVA: 0x0003FFC4 File Offset: 0x0003E1C4
		public EyeController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028E5 RID: 10469
		// (get) Token: 0x060086B3 RID: 34483 RVA: 0x0023A2E8 File Offset: 0x002384E8
		// (set) Token: 0x060086B4 RID: 34484 RVA: 0x0003FFCD File Offset: 0x0003E1CD
		public unsafe static float eyeHeightMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(EyeController.NativeFieldInfoPtr_eyeHeightMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EyeController.NativeFieldInfoPtr_eyeHeightMultiplier, (void*)(&value));
			}
		}

		// Token: 0x170028E6 RID: 10470
		// (get) Token: 0x060086B5 RID: 34485 RVA: 0x0023A304 File Offset: 0x00238504
		// (set) Token: 0x060086B6 RID: 34486 RVA: 0x0003FFDB File Offset: 0x0003E1DB
		public unsafe bool DEBUG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x170028E7 RID: 10471
		// (get) Token: 0x060086B7 RID: 34487 RVA: 0x0023A32C File Offset: 0x0023852C
		// (set) Token: 0x060086B8 RID: 34488 RVA: 0x0003FFF6 File Offset: 0x0003E1F6
		public unsafe bool _EyesOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr__EyesOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr__EyesOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x170028E8 RID: 10472
		// (get) Token: 0x060086B9 RID: 34489 RVA: 0x0023A354 File Offset: 0x00238554
		// (set) Token: 0x060086BA RID: 34490 RVA: 0x00040011 File Offset: 0x0003E211
		public unsafe Eye leftEye
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_leftEye);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Eye>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_leftEye), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028E9 RID: 10473
		// (get) Token: 0x060086BB RID: 34491 RVA: 0x0023A384 File Offset: 0x00238584
		// (set) Token: 0x060086BC RID: 34492 RVA: 0x00040030 File Offset: 0x0003E230
		public unsafe Eye rightEye
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_rightEye);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Eye>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_rightEye), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028EA RID: 10474
		// (get) Token: 0x060086BD RID: 34493 RVA: 0x0023A3B4 File Offset: 0x002385B4
		// (set) Token: 0x060086BE RID: 34494 RVA: 0x0004004F File Offset: 0x0003E24F
		public unsafe float eyeSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeSpacing)) = value;
			}
		}

		// Token: 0x170028EB RID: 10475
		// (get) Token: 0x060086BF RID: 34495 RVA: 0x0023A3DC File Offset: 0x002385DC
		// (set) Token: 0x060086C0 RID: 34496 RVA: 0x0004006A File Offset: 0x0003E26A
		public unsafe float eyeHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeHeight)) = value;
			}
		}

		// Token: 0x170028EC RID: 10476
		// (get) Token: 0x060086C1 RID: 34497 RVA: 0x0023A404 File Offset: 0x00238604
		// (set) Token: 0x060086C2 RID: 34498 RVA: 0x00040085 File Offset: 0x0003E285
		public unsafe float eyeSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeSize)) = value;
			}
		}

		// Token: 0x170028ED RID: 10477
		// (get) Token: 0x060086C3 RID: 34499 RVA: 0x0023A42C File Offset: 0x0023862C
		// (set) Token: 0x060086C4 RID: 34500 RVA: 0x000400A0 File Offset: 0x0003E2A0
		public unsafe Color leftEyeLidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_leftEyeLidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_leftEyeLidColor)) = value;
			}
		}

		// Token: 0x170028EE RID: 10478
		// (get) Token: 0x060086C5 RID: 34501 RVA: 0x0023A454 File Offset: 0x00238654
		// (set) Token: 0x060086C6 RID: 34502 RVA: 0x000400BB File Offset: 0x0003E2BB
		public unsafe Color rightEyeLidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_rightEyeLidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_rightEyeLidColor)) = value;
			}
		}

		// Token: 0x170028EF RID: 10479
		// (get) Token: 0x060086C7 RID: 34503 RVA: 0x0023A47C File Offset: 0x0023867C
		// (set) Token: 0x060086C8 RID: 34504 RVA: 0x000400D6 File Offset: 0x0003E2D6
		public unsafe Eye.EyeLidConfiguration LeftRestingEyeState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_LeftRestingEyeState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_LeftRestingEyeState)) = value;
			}
		}

		// Token: 0x170028F0 RID: 10480
		// (get) Token: 0x060086C9 RID: 34505 RVA: 0x0023A4A4 File Offset: 0x002386A4
		// (set) Token: 0x060086CA RID: 34506 RVA: 0x000400F1 File Offset: 0x0003E2F1
		public unsafe Eye.EyeLidConfiguration RightRestingEyeState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_RightRestingEyeState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_RightRestingEyeState)) = value;
			}
		}

		// Token: 0x170028F1 RID: 10481
		// (get) Token: 0x060086CB RID: 34507 RVA: 0x0023A4CC File Offset: 0x002386CC
		// (set) Token: 0x060086CC RID: 34508 RVA: 0x0004010C File Offset: 0x0003E30C
		public unsafe Material eyeBallMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeBallMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeBallMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028F2 RID: 10482
		// (get) Token: 0x060086CD RID: 34509 RVA: 0x0023A4FC File Offset: 0x002386FC
		// (set) Token: 0x060086CE RID: 34510 RVA: 0x0004012B File Offset: 0x0003E32B
		public unsafe Color eyeBallColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeBallColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeBallColor)) = value;
			}
		}

		// Token: 0x170028F3 RID: 10483
		// (get) Token: 0x060086CF RID: 34511 RVA: 0x0023A524 File Offset: 0x00238724
		// (set) Token: 0x060086D0 RID: 34512 RVA: 0x00040146 File Offset: 0x0003E346
		public unsafe float PupilDilation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_PupilDilation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_PupilDilation)) = value;
			}
		}

		// Token: 0x170028F4 RID: 10484
		// (get) Token: 0x060086D1 RID: 34513 RVA: 0x0023A54C File Offset: 0x0023874C
		// (set) Token: 0x060086D2 RID: 34514 RVA: 0x00040161 File Offset: 0x0003E361
		public unsafe bool BlinkingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_BlinkingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_BlinkingEnabled)) = value;
			}
		}

		// Token: 0x170028F5 RID: 10485
		// (get) Token: 0x060086D3 RID: 34515 RVA: 0x0023A574 File Offset: 0x00238774
		// (set) Token: 0x060086D4 RID: 34516 RVA: 0x0004017C File Offset: 0x0003E37C
		public unsafe float blinkInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_blinkInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_blinkInterval)) = value;
			}
		}

		// Token: 0x170028F6 RID: 10486
		// (get) Token: 0x060086D5 RID: 34517 RVA: 0x0023A59C File Offset: 0x0023879C
		// (set) Token: 0x060086D6 RID: 34518 RVA: 0x00040197 File Offset: 0x0003E397
		public unsafe float blinkIntervalSpread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_blinkIntervalSpread);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_blinkIntervalSpread)) = value;
			}
		}

		// Token: 0x170028F7 RID: 10487
		// (get) Token: 0x060086D7 RID: 34519 RVA: 0x0023A5C4 File Offset: 0x002387C4
		// (set) Token: 0x060086D8 RID: 34520 RVA: 0x000401B2 File Offset: 0x0003E3B2
		public unsafe float blinkDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_blinkDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_blinkDuration)) = value;
			}
		}

		// Token: 0x170028F8 RID: 10488
		// (get) Token: 0x060086D9 RID: 34521 RVA: 0x0023A5EC File Offset: 0x002387EC
		// (set) Token: 0x060086DA RID: 34522 RVA: 0x000401CD File Offset: 0x0003E3CD
		public unsafe Avatar avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028F9 RID: 10489
		// (get) Token: 0x060086DB RID: 34523 RVA: 0x0023A61C File Offset: 0x0023881C
		// (set) Token: 0x060086DC RID: 34524 RVA: 0x000401EC File Offset: 0x0003E3EC
		public unsafe Coroutine blinkRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_blinkRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_blinkRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028FA RID: 10490
		// (get) Token: 0x060086DD RID: 34525 RVA: 0x0023A64C File Offset: 0x0023884C
		// (set) Token: 0x060086DE RID: 34526 RVA: 0x0004020B File Offset: 0x0003E40B
		public unsafe float timeUntilNextBlink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_timeUntilNextBlink);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_timeUntilNextBlink)) = value;
			}
		}

		// Token: 0x170028FB RID: 10491
		// (get) Token: 0x060086DF RID: 34527 RVA: 0x0023A674 File Offset: 0x00238874
		// (set) Token: 0x060086E0 RID: 34528 RVA: 0x00040226 File Offset: 0x0003E426
		public unsafe bool eyeBallTintOverridden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeBallTintOverridden);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeBallTintOverridden)) = value;
			}
		}

		// Token: 0x170028FC RID: 10492
		// (get) Token: 0x060086E1 RID: 34529 RVA: 0x0023A69C File Offset: 0x0023889C
		// (set) Token: 0x060086E2 RID: 34530 RVA: 0x00040241 File Offset: 0x0003E441
		public unsafe bool eyeLidOverridden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeLidOverridden);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeLidOverridden)) = value;
			}
		}

		// Token: 0x170028FD RID: 10493
		// (get) Token: 0x060086E3 RID: 34531 RVA: 0x0023A6C4 File Offset: 0x002388C4
		// (set) Token: 0x060086E4 RID: 34532 RVA: 0x0004025C File Offset: 0x0003E45C
		public unsafe Eye.EyeLidConfiguration defaultLeftEyeRestingState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_defaultLeftEyeRestingState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_defaultLeftEyeRestingState)) = value;
			}
		}

		// Token: 0x170028FE RID: 10494
		// (get) Token: 0x060086E5 RID: 34533 RVA: 0x0023A6EC File Offset: 0x002388EC
		// (set) Token: 0x060086E6 RID: 34534 RVA: 0x00040277 File Offset: 0x0003E477
		public unsafe Eye.EyeLidConfiguration defaultRightEyeRestingState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_defaultRightEyeRestingState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_defaultRightEyeRestingState)) = value;
			}
		}

		// Token: 0x170028FF RID: 10495
		// (get) Token: 0x060086E7 RID: 34535 RVA: 0x0023A714 File Offset: 0x00238914
		// (set) Token: 0x060086E8 RID: 34536 RVA: 0x00040292 File Offset: 0x0003E492
		public unsafe float defaultDilation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_defaultDilation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_defaultDilation)) = value;
			}
		}

		// Token: 0x04005B9C RID: 23452
		private static readonly IntPtr NativeFieldInfoPtr_eyeHeightMultiplier;

		// Token: 0x04005B9D RID: 23453
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04005B9E RID: 23454
		private static readonly IntPtr NativeFieldInfoPtr__EyesOpen_k__BackingField;

		// Token: 0x04005B9F RID: 23455
		private static readonly IntPtr NativeFieldInfoPtr_leftEye;

		// Token: 0x04005BA0 RID: 23456
		private static readonly IntPtr NativeFieldInfoPtr_rightEye;

		// Token: 0x04005BA1 RID: 23457
		private static readonly IntPtr NativeFieldInfoPtr_eyeSpacing;

		// Token: 0x04005BA2 RID: 23458
		private static readonly IntPtr NativeFieldInfoPtr_eyeHeight;

		// Token: 0x04005BA3 RID: 23459
		private static readonly IntPtr NativeFieldInfoPtr_eyeSize;

		// Token: 0x04005BA4 RID: 23460
		private static readonly IntPtr NativeFieldInfoPtr_leftEyeLidColor;

		// Token: 0x04005BA5 RID: 23461
		private static readonly IntPtr NativeFieldInfoPtr_rightEyeLidColor;

		// Token: 0x04005BA6 RID: 23462
		private static readonly IntPtr NativeFieldInfoPtr_LeftRestingEyeState;

		// Token: 0x04005BA7 RID: 23463
		private static readonly IntPtr NativeFieldInfoPtr_RightRestingEyeState;

		// Token: 0x04005BA8 RID: 23464
		private static readonly IntPtr NativeFieldInfoPtr_eyeBallMaterial;

		// Token: 0x04005BA9 RID: 23465
		private static readonly IntPtr NativeFieldInfoPtr_eyeBallColor;

		// Token: 0x04005BAA RID: 23466
		private static readonly IntPtr NativeFieldInfoPtr_PupilDilation;

		// Token: 0x04005BAB RID: 23467
		private static readonly IntPtr NativeFieldInfoPtr_BlinkingEnabled;

		// Token: 0x04005BAC RID: 23468
		private static readonly IntPtr NativeFieldInfoPtr_blinkInterval;

		// Token: 0x04005BAD RID: 23469
		private static readonly IntPtr NativeFieldInfoPtr_blinkIntervalSpread;

		// Token: 0x04005BAE RID: 23470
		private static readonly IntPtr NativeFieldInfoPtr_blinkDuration;

		// Token: 0x04005BAF RID: 23471
		private static readonly IntPtr NativeFieldInfoPtr_avatar;

		// Token: 0x04005BB0 RID: 23472
		private static readonly IntPtr NativeFieldInfoPtr_blinkRoutine;

		// Token: 0x04005BB1 RID: 23473
		private static readonly IntPtr NativeFieldInfoPtr_timeUntilNextBlink;

		// Token: 0x04005BB2 RID: 23474
		private static readonly IntPtr NativeFieldInfoPtr_eyeBallTintOverridden;

		// Token: 0x04005BB3 RID: 23475
		private static readonly IntPtr NativeFieldInfoPtr_eyeLidOverridden;

		// Token: 0x04005BB4 RID: 23476
		private static readonly IntPtr NativeFieldInfoPtr_defaultLeftEyeRestingState;

		// Token: 0x04005BB5 RID: 23477
		private static readonly IntPtr NativeFieldInfoPtr_defaultRightEyeRestingState;

		// Token: 0x04005BB6 RID: 23478
		private static readonly IntPtr NativeFieldInfoPtr_defaultDilation;

		// Token: 0x04005BB7 RID: 23479
		private static readonly IntPtr NativeMethodInfoPtr_get_EyesOpen_Public_get_Boolean_0;

		// Token: 0x04005BB8 RID: 23480
		private static readonly IntPtr NativeMethodInfoPtr_set_EyesOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04005BB9 RID: 23481
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04005BBA RID: 23482
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Void_0;

		// Token: 0x04005BBB RID: 23483
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04005BBC RID: 23484
		private static readonly IntPtr NativeMethodInfoPtr_ApplySettings_Public_Void_0;

		// Token: 0x04005BBD RID: 23485
		private static readonly IntPtr NativeMethodInfoPtr_SetEyeballTint_Public_Void_Color_0;

		// Token: 0x04005BBE RID: 23486
		private static readonly IntPtr NativeMethodInfoPtr_OverrideEyeballTint_Public_Void_Color_0;

		// Token: 0x04005BBF RID: 23487
		private static readonly IntPtr NativeMethodInfoPtr_ResetEyeballTint_Public_Void_0;

		// Token: 0x04005BC0 RID: 23488
		private static readonly IntPtr NativeMethodInfoPtr_OverrideEyeLids_Public_Void_EyeLidConfiguration_0;

		// Token: 0x04005BC1 RID: 23489
		private static readonly IntPtr NativeMethodInfoPtr_ResetEyeLids_Public_Void_0;

		// Token: 0x04005BC2 RID: 23490
		private static readonly IntPtr NativeMethodInfoPtr_RagdollChange_Private_Void_Boolean_Boolean_Boolean_0;

		// Token: 0x04005BC3 RID: 23491
		private static readonly IntPtr NativeMethodInfoPtr_SetEyesOpen_Public_Void_Boolean_0;

		// Token: 0x04005BC4 RID: 23492
		private static readonly IntPtr NativeMethodInfoPtr_ApplyDilation_Private_Void_0;

		// Token: 0x04005BC5 RID: 23493
		private static readonly IntPtr NativeMethodInfoPtr_SetPupilDilation_Public_Void_Single_Boolean_0;

		// Token: 0x04005BC6 RID: 23494
		private static readonly IntPtr NativeMethodInfoPtr_ResetPupilDilation_Public_Void_0;

		// Token: 0x04005BC7 RID: 23495
		private static readonly IntPtr NativeMethodInfoPtr_ApplyRestingEyeLidState_Private_Void_0;

		// Token: 0x04005BC8 RID: 23496
		private static readonly IntPtr NativeMethodInfoPtr_ForceBlink_Public_Void_0;

		// Token: 0x04005BC9 RID: 23497
		private static readonly IntPtr NativeMethodInfoPtr_SetLeftEyeRestingLidState_Public_Void_EyeLidConfiguration_0;

		// Token: 0x04005BCA RID: 23498
		private static readonly IntPtr NativeMethodInfoPtr_SetRightEyeRestingLidState_Public_Void_EyeLidConfiguration_0;

		// Token: 0x04005BCB RID: 23499
		private static readonly IntPtr NativeMethodInfoPtr_BlinkRoutine_Private_IEnumerator_0;

		// Token: 0x04005BCC RID: 23500
		private static readonly IntPtr NativeMethodInfoPtr_ResetBlinkCounter_Private_Void_0;

		// Token: 0x04005BCD RID: 23501
		private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Boolean_0;

		// Token: 0x04005BCE RID: 23502
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005BCF RID: 23503
		private static readonly IntPtr NativeMethodInfoPtr__BlinkRoutine_b__48_0_Private_Boolean_0;

		// Token: 0x02000AF3 RID: 2803
		[ObfuscatedName("ScheduleOne.AvatarFramework.EyeController+<BlinkRoutine>d__48")]
		public sealed class _BlinkRoutine_d__48 : Il2CppSystem.Object
		{
			// Token: 0x0600D5BF RID: 54719 RVA: 0x0032EE00 File Offset: 0x0032D000
			// Note: this type is marked as 'beforefieldinit'.
			static _BlinkRoutine_d__48()
			{
				Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "<BlinkRoutine>d__48");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr);
				EyeController._BlinkRoutine_d__48.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr, "<>1__state");
				EyeController._BlinkRoutine_d__48.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr, "<>2__current");
				EyeController._BlinkRoutine_d__48.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr, "<>4__this");
				EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr, 100680132);
				EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr, 100680133);
				EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr, 100680134);
				EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr, 100680135);
				EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr, 100680136);
				EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr, 100680137);
			}

			// Token: 0x0600D5C0 RID: 54720 RVA: 0x0032EEE0 File Offset: 0x0032D0E0
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BlinkRoutine_d__48(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5C1 RID: 54721 RVA: 0x0032EF28 File Offset: 0x0032D128
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5C2 RID: 54722 RVA: 0x0032EF5C File Offset: 0x0032D15C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251182, XrefRangeEnd = 251202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700423E RID: 16958
			// (get) Token: 0x0600D5C3 RID: 54723 RVA: 0x0032EF98 File Offset: 0x0032D198
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D5C4 RID: 54724 RVA: 0x0032EFD8 File Offset: 0x0032D1D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251202, XrefRangeEnd = 251207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700423F RID: 16959
			// (get) Token: 0x0600D5C5 RID: 54725 RVA: 0x0032F00C File Offset: 0x0032D20C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D5C6 RID: 54726 RVA: 0x00068003 File Offset: 0x00066203
			public _BlinkRoutine_d__48(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700423B RID: 16955
			// (get) Token: 0x0600D5C7 RID: 54727 RVA: 0x0032F04C File Offset: 0x0032D24C
			// (set) Token: 0x0600D5C8 RID: 54728 RVA: 0x0006800C File Offset: 0x0006620C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController._BlinkRoutine_d__48.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController._BlinkRoutine_d__48.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700423C RID: 16956
			// (get) Token: 0x0600D5C9 RID: 54729 RVA: 0x0032F074 File Offset: 0x0032D274
			// (set) Token: 0x0600D5CA RID: 54730 RVA: 0x00068027 File Offset: 0x00066227
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController._BlinkRoutine_d__48.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController._BlinkRoutine_d__48.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700423D RID: 16957
			// (get) Token: 0x0600D5CB RID: 54731 RVA: 0x0032F0A4 File Offset: 0x0032D2A4
			// (set) Token: 0x0600D5CC RID: 54732 RVA: 0x00068046 File Offset: 0x00066246
			public unsafe EyeController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController._BlinkRoutine_d__48.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EyeController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController._BlinkRoutine_d__48.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008FC7 RID: 36807
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008FC8 RID: 36808
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008FC9 RID: 36809
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008FCA RID: 36810
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008FCB RID: 36811
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008FCC RID: 36812
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008FCD RID: 36813
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008FCE RID: 36814
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008FCF RID: 36815
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
