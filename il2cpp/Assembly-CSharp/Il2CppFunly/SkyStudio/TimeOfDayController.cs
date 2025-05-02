using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000118 RID: 280
	public class TimeOfDayController : MonoBehaviour
	{
		// Token: 0x06001819 RID: 6169 RVA: 0x000BB900 File Offset: 0x000B9B00
		// Note: this type is marked as 'beforefieldinit'.
		static TimeOfDayController()
		{
			Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "TimeOfDayController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr);
			TimeOfDayController.NativeFieldInfoPtr__instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, "<instance>k__BackingField");
			TimeOfDayController.NativeFieldInfoPtr_m_SkyProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, "m_SkyProfile");
			TimeOfDayController.NativeFieldInfoPtr_m_SkyTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, "m_SkyTime");
			TimeOfDayController.NativeFieldInfoPtr_automaticTimeIncrement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, "automaticTimeIncrement");
			TimeOfDayController.NativeFieldInfoPtr_copySkyProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, "copySkyProfile");
			TimeOfDayController.NativeFieldInfoPtr_m_SkyMaterialController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, "m_SkyMaterialController");
			TimeOfDayController.NativeFieldInfoPtr_automaticIncrementSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, "automaticIncrementSpeed");
			TimeOfDayController.NativeFieldInfoPtr_sunOrbit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, "sunOrbit");
			TimeOfDayController.NativeFieldInfoPtr_moonOrbit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, "moonOrbit");
			TimeOfDayController.NativeFieldInfoPtr_weatherController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, "weatherController");
			TimeOfDayController.NativeFieldInfoPtr_updateGlobalIllumination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, "updateGlobalIllumination");
			TimeOfDayController.NativeFieldInfoPtr_skyProfileTransitionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, "skyProfileTransitionPrefab");
			TimeOfDayController.NativeFieldInfoPtr_timeChangedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, "timeChangedCallback");
			TimeOfDayController.NativeFieldInfoPtr_m_DidInitialUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, "m_DidInitialUpdate");
			TimeOfDayController.NativeMethodInfoPtr_get_instance_Public_Static_get_TimeOfDayController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665856);
			TimeOfDayController.NativeMethodInfoPtr_set_instance_Private_Static_set_Void_TimeOfDayController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665857);
			TimeOfDayController.NativeMethodInfoPtr_get_skyProfile_Public_get_SkyProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665858);
			TimeOfDayController.NativeMethodInfoPtr_set_skyProfile_Public_set_Void_SkyProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665859);
			TimeOfDayController.NativeMethodInfoPtr_get_skyTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665860);
			TimeOfDayController.NativeMethodInfoPtr_set_skyTime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665861);
			TimeOfDayController.NativeMethodInfoPtr_get_SkyMaterial_Public_get_SkyMaterialController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665862);
			TimeOfDayController.NativeMethodInfoPtr_add_timeChangedCallback_Public_add_Void_TimeOfDayDidChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665863);
			TimeOfDayController.NativeMethodInfoPtr_remove_timeChangedCallback_Public_rem_Void_TimeOfDayDidChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665864);
			TimeOfDayController.NativeMethodInfoPtr_get_timeOfDay_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665865);
			TimeOfDayController.NativeMethodInfoPtr_get_daysElapsed_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665866);
			TimeOfDayController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665867);
			TimeOfDayController.NativeMethodInfoPtr_OnEnabled_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665868);
			TimeOfDayController.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665869);
			TimeOfDayController.NativeMethodInfoPtr_WarnInvalidSkySetup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665870);
			TimeOfDayController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665871);
			TimeOfDayController.NativeMethodInfoPtr_UpdateGlobalIllumination_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665872);
			TimeOfDayController.NativeMethodInfoPtr_SynchronizeAllShaderKeywords_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665873);
			TimeOfDayController.NativeMethodInfoPtr_SynchronizedShaderKeyword_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665874);
			TimeOfDayController.NativeMethodInfoPtr_GetPrimaryLightDirection_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665875);
			TimeOfDayController.NativeMethodInfoPtr_StartSkyProfileTransition_Public_Boolean_SkyProfile_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665876);
			TimeOfDayController.NativeMethodInfoPtr_CancelSkyProfileTransition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665877);
			TimeOfDayController.NativeMethodInfoPtr_OnBlendComplete_Public_Void_BlendSkyProfiles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665878);
			TimeOfDayController.NativeMethodInfoPtr_IsBlendingInProgress_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665879);
			TimeOfDayController.NativeMethodInfoPtr_UpdateSkyForCurrentTime_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665880);
			TimeOfDayController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, 100665881);
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x0600181A RID: 6170 RVA: 0x000BBC50 File Offset: 0x000B9E50
		// (set) Token: 0x0600181B RID: 6171 RVA: 0x000BBC84 File Offset: 0x000B9E84
		public unsafe static TimeOfDayController instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94132, XrefRangeEnd = 94134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_get_instance_Public_Static_get_TimeOfDayController_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeOfDayController>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94134, XrefRangeEnd = 94138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_set_instance_Private_Static_set_Void_TimeOfDayController_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x0600181C RID: 6172 RVA: 0x000BBCBC File Offset: 0x000B9EBC
		// (set) Token: 0x0600181D RID: 6173 RVA: 0x000BBCFC File Offset: 0x000B9EFC
		public unsafe SkyProfile skyProfile
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_get_skyProfile_Public_get_SkyProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr3) : null;
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 94152, RefRangeEnd = 94159, XrefRangeStart = 94138, XrefRangeEnd = 94152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_set_skyProfile_Public_set_Void_SkyProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x0600181E RID: 6174 RVA: 0x000BBD40 File Offset: 0x000B9F40
		// (set) Token: 0x0600181F RID: 6175 RVA: 0x000BBD7C File Offset: 0x000B9F7C
		public unsafe float skyTime
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 59852, RefRangeEnd = 59853, XrefRangeStart = 59852, XrefRangeEnd = 59853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_get_skyTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 94160, RefRangeEnd = 94161, XrefRangeStart = 94159, XrefRangeEnd = 94160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_set_skyTime_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06001820 RID: 6176 RVA: 0x000BBDBC File Offset: 0x000B9FBC
		public unsafe SkyMaterialController SkyMaterial
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19644, RefRangeEnd = 19658, XrefRangeStart = 19644, XrefRangeEnd = 19658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_get_SkyMaterial_Public_get_SkyMaterialController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SkyMaterialController>(intPtr3) : null;
			}
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x000BBDFC File Offset: 0x000B9FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94161, XrefRangeEnd = 94165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_timeChangedCallback(TimeOfDayController.TimeOfDayDidChange value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_add_timeChangedCallback_Public_add_Void_TimeOfDayDidChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x000BBE40 File Offset: 0x000BA040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94165, XrefRangeEnd = 94169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_timeChangedCallback(TimeOfDayController.TimeOfDayDidChange value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_remove_timeChangedCallback_Public_rem_Void_TimeOfDayDidChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06001823 RID: 6179 RVA: 0x000BBE84 File Offset: 0x000BA084
		public unsafe float timeOfDay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_get_timeOfDay_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06001824 RID: 6180 RVA: 0x000BBEC0 File Offset: 0x000BA0C0
		public unsafe int daysElapsed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_get_daysElapsed_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x000BBEFC File Offset: 0x000BA0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94169, XrefRangeEnd = 94173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x000BBF30 File Offset: 0x000BA130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94173, XrefRangeEnd = 94174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_OnEnabled_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x000BBF64 File Offset: 0x000BA164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94174, XrefRangeEnd = 94178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x000BBF98 File Offset: 0x000BA198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94178, XrefRangeEnd = 94184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WarnInvalidSkySetup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_WarnInvalidSkySetup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x000BBFCC File Offset: 0x000BA1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94184, XrefRangeEnd = 94277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x000BC000 File Offset: 0x000BA200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94277, XrefRangeEnd = 94278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateGlobalIllumination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_UpdateGlobalIllumination_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x000BC034 File Offset: 0x000BA234
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 94290, RefRangeEnd = 94292, XrefRangeStart = 94278, XrefRangeEnd = 94290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SynchronizeAllShaderKeywords()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_SynchronizeAllShaderKeywords_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x000BC068 File Offset: 0x000BA268
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 94302, RefRangeEnd = 94304, XrefRangeStart = 94292, XrefRangeEnd = 94302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SynchronizedShaderKeyword(string featureKey, string shaderKeyword)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(featureKey);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(shaderKeyword);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_SynchronizedShaderKeyword_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x000BC0BC File Offset: 0x000BA2BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94304, XrefRangeEnd = 94318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPrimaryLightDirection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_GetPrimaryLightDirection_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x000BC0F8 File Offset: 0x000BA2F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 94362, RefRangeEnd = 94363, XrefRangeStart = 94318, XrefRangeEnd = 94362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartSkyProfileTransition(SkyProfile toProfile, float duration = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toProfile);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_StartSkyProfileTransition_Public_Boolean_SkyProfile_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x000BC154 File Offset: 0x000BA354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94363, XrefRangeEnd = 94371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelSkyProfileTransition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_CancelSkyProfileTransition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x000BC188 File Offset: 0x000BA388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94371, XrefRangeEnd = 94374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBlendComplete(BlendSkyProfiles blender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(blender);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_OnBlendComplete_Public_Void_BlendSkyProfiles_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x000BC1CC File Offset: 0x000BA3CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94374, XrefRangeEnd = 94381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsBlendingInProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_IsBlendingInProgress_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x000BC208 File Offset: 0x000BA408
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 95261, RefRangeEnd = 95269, XrefRangeStart = 94381, XrefRangeEnd = 95261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSkyForCurrentTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr_UpdateSkyForCurrentTime_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x000BC23C File Offset: 0x000BA43C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95269, XrefRangeEnd = 95270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeOfDayController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x0000DE27 File Offset: 0x0000C027
		public TimeOfDayController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06001835 RID: 6197 RVA: 0x000BC278 File Offset: 0x000BA478
		// (set) Token: 0x06001836 RID: 6198 RVA: 0x0000DE30 File Offset: 0x0000C030
		public unsafe static TimeOfDayController _instance_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimeOfDayController.NativeFieldInfoPtr__instance_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeOfDayController>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeOfDayController.NativeFieldInfoPtr__instance_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06001837 RID: 6199 RVA: 0x000BC2A0 File Offset: 0x000BA4A0
		// (set) Token: 0x06001838 RID: 6200 RVA: 0x0000DE42 File Offset: 0x0000C042
		public unsafe SkyProfile m_SkyProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_m_SkyProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_m_SkyProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06001839 RID: 6201 RVA: 0x000BC2D0 File Offset: 0x000BA4D0
		// (set) Token: 0x0600183A RID: 6202 RVA: 0x0000DE61 File Offset: 0x0000C061
		public unsafe float m_SkyTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_m_SkyTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_m_SkyTime)) = value;
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x0600183B RID: 6203 RVA: 0x000BC2F8 File Offset: 0x000BA4F8
		// (set) Token: 0x0600183C RID: 6204 RVA: 0x0000DE7C File Offset: 0x0000C07C
		public unsafe bool automaticTimeIncrement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_automaticTimeIncrement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_automaticTimeIncrement)) = value;
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x0600183D RID: 6205 RVA: 0x000BC320 File Offset: 0x000BA520
		// (set) Token: 0x0600183E RID: 6206 RVA: 0x0000DE97 File Offset: 0x0000C097
		public unsafe bool copySkyProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_copySkyProfile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_copySkyProfile)) = value;
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x0600183F RID: 6207 RVA: 0x000BC348 File Offset: 0x000BA548
		// (set) Token: 0x06001840 RID: 6208 RVA: 0x0000DEB2 File Offset: 0x0000C0B2
		public unsafe SkyMaterialController m_SkyMaterialController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_m_SkyMaterialController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkyMaterialController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_m_SkyMaterialController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06001841 RID: 6209 RVA: 0x000BC378 File Offset: 0x000BA578
		// (set) Token: 0x06001842 RID: 6210 RVA: 0x0000DED1 File Offset: 0x0000C0D1
		public unsafe float automaticIncrementSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_automaticIncrementSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_automaticIncrementSpeed)) = value;
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06001843 RID: 6211 RVA: 0x000BC3A0 File Offset: 0x000BA5A0
		// (set) Token: 0x06001844 RID: 6212 RVA: 0x0000DEEC File Offset: 0x0000C0EC
		public unsafe OrbitingBody sunOrbit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_sunOrbit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OrbitingBody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_sunOrbit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06001845 RID: 6213 RVA: 0x000BC3D0 File Offset: 0x000BA5D0
		// (set) Token: 0x06001846 RID: 6214 RVA: 0x0000DF0B File Offset: 0x0000C10B
		public unsafe OrbitingBody moonOrbit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_moonOrbit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OrbitingBody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_moonOrbit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06001847 RID: 6215 RVA: 0x000BC400 File Offset: 0x000BA600
		// (set) Token: 0x06001848 RID: 6216 RVA: 0x0000DF2A File Offset: 0x0000C12A
		public unsafe WeatherController weatherController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_weatherController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeatherController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_weatherController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06001849 RID: 6217 RVA: 0x000BC430 File Offset: 0x000BA630
		// (set) Token: 0x0600184A RID: 6218 RVA: 0x0000DF49 File Offset: 0x0000C149
		public unsafe bool updateGlobalIllumination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_updateGlobalIllumination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_updateGlobalIllumination)) = value;
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x0600184B RID: 6219 RVA: 0x000BC458 File Offset: 0x000BA658
		// (set) Token: 0x0600184C RID: 6220 RVA: 0x0000DF64 File Offset: 0x0000C164
		public unsafe BlendSkyProfiles skyProfileTransitionPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_skyProfileTransitionPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlendSkyProfiles>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_skyProfileTransitionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x0600184D RID: 6221 RVA: 0x000BC488 File Offset: 0x000BA688
		// (set) Token: 0x0600184E RID: 6222 RVA: 0x0000DF83 File Offset: 0x0000C183
		public unsafe TimeOfDayController.TimeOfDayDidChange timeChangedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_timeChangedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeOfDayController.TimeOfDayDidChange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_timeChangedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x0600184F RID: 6223 RVA: 0x000BC4B8 File Offset: 0x000BA6B8
		// (set) Token: 0x06001850 RID: 6224 RVA: 0x0000DFA2 File Offset: 0x0000C1A2
		public unsafe bool m_DidInitialUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_m_DidInitialUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeOfDayController.NativeFieldInfoPtr_m_DidInitialUpdate)) = value;
			}
		}

		// Token: 0x04000FD5 RID: 4053
		private static readonly IntPtr NativeFieldInfoPtr__instance_k__BackingField;

		// Token: 0x04000FD6 RID: 4054
		private static readonly IntPtr NativeFieldInfoPtr_m_SkyProfile;

		// Token: 0x04000FD7 RID: 4055
		private static readonly IntPtr NativeFieldInfoPtr_m_SkyTime;

		// Token: 0x04000FD8 RID: 4056
		private static readonly IntPtr NativeFieldInfoPtr_automaticTimeIncrement;

		// Token: 0x04000FD9 RID: 4057
		private static readonly IntPtr NativeFieldInfoPtr_copySkyProfile;

		// Token: 0x04000FDA RID: 4058
		private static readonly IntPtr NativeFieldInfoPtr_m_SkyMaterialController;

		// Token: 0x04000FDB RID: 4059
		private static readonly IntPtr NativeFieldInfoPtr_automaticIncrementSpeed;

		// Token: 0x04000FDC RID: 4060
		private static readonly IntPtr NativeFieldInfoPtr_sunOrbit;

		// Token: 0x04000FDD RID: 4061
		private static readonly IntPtr NativeFieldInfoPtr_moonOrbit;

		// Token: 0x04000FDE RID: 4062
		private static readonly IntPtr NativeFieldInfoPtr_weatherController;

		// Token: 0x04000FDF RID: 4063
		private static readonly IntPtr NativeFieldInfoPtr_updateGlobalIllumination;

		// Token: 0x04000FE0 RID: 4064
		private static readonly IntPtr NativeFieldInfoPtr_skyProfileTransitionPrefab;

		// Token: 0x04000FE1 RID: 4065
		private static readonly IntPtr NativeFieldInfoPtr_timeChangedCallback;

		// Token: 0x04000FE2 RID: 4066
		private static readonly IntPtr NativeFieldInfoPtr_m_DidInitialUpdate;

		// Token: 0x04000FE3 RID: 4067
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_TimeOfDayController_0;

		// Token: 0x04000FE4 RID: 4068
		private static readonly IntPtr NativeMethodInfoPtr_set_instance_Private_Static_set_Void_TimeOfDayController_0;

		// Token: 0x04000FE5 RID: 4069
		private static readonly IntPtr NativeMethodInfoPtr_get_skyProfile_Public_get_SkyProfile_0;

		// Token: 0x04000FE6 RID: 4070
		private static readonly IntPtr NativeMethodInfoPtr_set_skyProfile_Public_set_Void_SkyProfile_0;

		// Token: 0x04000FE7 RID: 4071
		private static readonly IntPtr NativeMethodInfoPtr_get_skyTime_Public_get_Single_0;

		// Token: 0x04000FE8 RID: 4072
		private static readonly IntPtr NativeMethodInfoPtr_set_skyTime_Public_set_Void_Single_0;

		// Token: 0x04000FE9 RID: 4073
		private static readonly IntPtr NativeMethodInfoPtr_get_SkyMaterial_Public_get_SkyMaterialController_0;

		// Token: 0x04000FEA RID: 4074
		private static readonly IntPtr NativeMethodInfoPtr_add_timeChangedCallback_Public_add_Void_TimeOfDayDidChange_0;

		// Token: 0x04000FEB RID: 4075
		private static readonly IntPtr NativeMethodInfoPtr_remove_timeChangedCallback_Public_rem_Void_TimeOfDayDidChange_0;

		// Token: 0x04000FEC RID: 4076
		private static readonly IntPtr NativeMethodInfoPtr_get_timeOfDay_Public_get_Single_0;

		// Token: 0x04000FED RID: 4077
		private static readonly IntPtr NativeMethodInfoPtr_get_daysElapsed_Public_get_Int32_0;

		// Token: 0x04000FEE RID: 4078
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000FEF RID: 4079
		private static readonly IntPtr NativeMethodInfoPtr_OnEnabled_Private_Void_0;

		// Token: 0x04000FF0 RID: 4080
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04000FF1 RID: 4081
		private static readonly IntPtr NativeMethodInfoPtr_WarnInvalidSkySetup_Private_Void_0;

		// Token: 0x04000FF2 RID: 4082
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000FF3 RID: 4083
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGlobalIllumination_Public_Void_0;

		// Token: 0x04000FF4 RID: 4084
		private static readonly IntPtr NativeMethodInfoPtr_SynchronizeAllShaderKeywords_Private_Void_0;

		// Token: 0x04000FF5 RID: 4085
		private static readonly IntPtr NativeMethodInfoPtr_SynchronizedShaderKeyword_Private_Void_String_String_0;

		// Token: 0x04000FF6 RID: 4086
		private static readonly IntPtr NativeMethodInfoPtr_GetPrimaryLightDirection_Private_Vector3_0;

		// Token: 0x04000FF7 RID: 4087
		private static readonly IntPtr NativeMethodInfoPtr_StartSkyProfileTransition_Public_Boolean_SkyProfile_Single_0;

		// Token: 0x04000FF8 RID: 4088
		private static readonly IntPtr NativeMethodInfoPtr_CancelSkyProfileTransition_Public_Void_0;

		// Token: 0x04000FF9 RID: 4089
		private static readonly IntPtr NativeMethodInfoPtr_OnBlendComplete_Public_Void_BlendSkyProfiles_0;

		// Token: 0x04000FFA RID: 4090
		private static readonly IntPtr NativeMethodInfoPtr_IsBlendingInProgress_Public_Boolean_0;

		// Token: 0x04000FFB RID: 4091
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSkyForCurrentTime_Public_Void_0;

		// Token: 0x04000FFC RID: 4092
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000855 RID: 2133
		public sealed class TimeOfDayDidChange : MulticastDelegate
		{
			// Token: 0x0600C06B RID: 49259 RVA: 0x002F0D18 File Offset: 0x002EEF18
			// Note: this type is marked as 'beforefieldinit'.
			static TimeOfDayDidChange()
			{
				Il2CppClassPointerStore<TimeOfDayController.TimeOfDayDidChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeOfDayController>.NativeClassPtr, "TimeOfDayDidChange");
				TimeOfDayController.TimeOfDayDidChange.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController.TimeOfDayDidChange>.NativeClassPtr, 100665882);
				TimeOfDayController.TimeOfDayDidChange.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_TimeOfDayController_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController.TimeOfDayDidChange>.NativeClassPtr, 100665883);
				TimeOfDayController.TimeOfDayDidChange.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TimeOfDayController_Single_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController.TimeOfDayDidChange>.NativeClassPtr, 100665884);
				TimeOfDayController.TimeOfDayDidChange.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeOfDayController.TimeOfDayDidChange>.NativeClassPtr, 100665885);
			}

			// Token: 0x0600C06C RID: 49260 RVA: 0x002F0D8C File Offset: 0x002EEF8C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 72693, RefRangeEnd = 72695, XrefRangeStart = 72693, XrefRangeEnd = 72695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TimeOfDayDidChange(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeOfDayController.TimeOfDayDidChange>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.TimeOfDayDidChange.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C06D RID: 49261 RVA: 0x002F0DE8 File Offset: 0x002EEFE8
			[CallerCount(0)]
			public unsafe void Invoke(TimeOfDayController tc, float timeOfDay)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tc);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeOfDay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.TimeOfDayDidChange.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_TimeOfDayController_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C06E RID: 49262 RVA: 0x002F0E38 File Offset: 0x002EF038
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94128, XrefRangeEnd = 94132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(TimeOfDayController tc, float timeOfDay, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tc);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeOfDay;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.TimeOfDayDidChange.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TimeOfDayController_Single_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600C06F RID: 49263 RVA: 0x002F0EBC File Offset: 0x002EF0BC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22499, RefRangeEnd = 22500, XrefRangeStart = 22499, XrefRangeEnd = 22500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeOfDayController.TimeOfDayDidChange.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C070 RID: 49264 RVA: 0x0005E01A File Offset: 0x0005C21A
			public TimeOfDayDidChange(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600C071 RID: 49265 RVA: 0x0005E023 File Offset: 0x0005C223
			public static implicit operator TimeOfDayController.TimeOfDayDidChange(Action<TimeOfDayController, float> A_0)
			{
				return DelegateSupport.ConvertDelegate<TimeOfDayController.TimeOfDayDidChange>(A_0);
			}

			// Token: 0x0600C072 RID: 49266 RVA: 0x0005E02B File Offset: 0x0005C22B
			public static TimeOfDayController.TimeOfDayDidChange operator +(TimeOfDayController.TimeOfDayDidChange A_0, TimeOfDayController.TimeOfDayDidChange A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<TimeOfDayController.TimeOfDayDidChange>();
			}

			// Token: 0x0600C073 RID: 49267 RVA: 0x0005E039 File Offset: 0x0005C239
			public static TimeOfDayController.TimeOfDayDidChange operator -(TimeOfDayController.TimeOfDayDidChange A_0, TimeOfDayController.TimeOfDayDidChange A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<TimeOfDayController.TimeOfDayDidChange>();
				}
				return result;
			}

			// Token: 0x0400825C RID: 33372
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400825D RID: 33373
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_TimeOfDayController_Single_0;

			// Token: 0x0400825E RID: 33374
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TimeOfDayController_Single_AsyncCallback_Object_0;

			// Token: 0x0400825F RID: 33375
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
