using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Emotions
{
	// Token: 0x02000607 RID: 1543
	public class AvatarEmotionManager : MonoBehaviour
	{
		// Token: 0x060087F9 RID: 34809 RVA: 0x0023D510 File Offset: 0x0023B710
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarEmotionManager()
		{
			Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Emotions", "AvatarEmotionManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr);
			AvatarEmotionManager.NativeFieldInfoPtr_MAX_UPDATE_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "MAX_UPDATE_DISTANCE");
			AvatarEmotionManager.NativeFieldInfoPtr__CurrentEmotion_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "<CurrentEmotion>k__BackingField");
			AvatarEmotionManager.NativeFieldInfoPtr__CurrentEmotionPreset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "<CurrentEmotionPreset>k__BackingField");
			AvatarEmotionManager.NativeFieldInfoPtr_EmotionPresetList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "EmotionPresetList");
			AvatarEmotionManager.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "Avatar");
			AvatarEmotionManager.NativeFieldInfoPtr_EyeController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "EyeController");
			AvatarEmotionManager.NativeFieldInfoPtr_EyebrowController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "EyebrowController");
			AvatarEmotionManager.NativeFieldInfoPtr_activeEmotionOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "activeEmotionOverride");
			AvatarEmotionManager.NativeFieldInfoPtr_overrideStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "overrideStack");
			AvatarEmotionManager.NativeFieldInfoPtr_neutralPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "neutralPreset");
			AvatarEmotionManager.NativeFieldInfoPtr_emotionLerpRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "emotionLerpRoutine");
			AvatarEmotionManager.NativeFieldInfoPtr_emotionRemovalRoutines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "emotionRemovalRoutines");
			AvatarEmotionManager.NativeFieldInfoPtr_tempIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "tempIndex");
			AvatarEmotionManager.NativeMethodInfoPtr_get_CurrentEmotion_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680241);
			AvatarEmotionManager.NativeMethodInfoPtr_set_CurrentEmotion_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680242);
			AvatarEmotionManager.NativeMethodInfoPtr_get_CurrentEmotionPreset_Public_get_AvatarEmotionPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680243);
			AvatarEmotionManager.NativeMethodInfoPtr_set_CurrentEmotionPreset_Protected_set_Void_AvatarEmotionPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680244);
			AvatarEmotionManager.NativeMethodInfoPtr_get_IsSwitchingEmotion_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680245);
			AvatarEmotionManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680246);
			AvatarEmotionManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680247);
			AvatarEmotionManager.NativeMethodInfoPtr_UpdateEmotion_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680248);
			AvatarEmotionManager.NativeMethodInfoPtr_ConfigureNeutralFace_Public_Void_Texture2D_Single_Single_EyeLidConfiguration_EyeLidConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680249);
			AvatarEmotionManager.NativeMethodInfoPtr_AddEmotionOverride_Public_Virtual_New_Void_String_String_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680250);
			AvatarEmotionManager.NativeMethodInfoPtr_RemoveEmotionOverride_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680251);
			AvatarEmotionManager.NativeMethodInfoPtr_ClearOverrides_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680252);
			AvatarEmotionManager.NativeMethodInfoPtr_ClearRemovalRoutine_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680253);
			AvatarEmotionManager.NativeMethodInfoPtr_GetHighestPriorityOverride_Public_EmotionOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680254);
			AvatarEmotionManager.NativeMethodInfoPtr_LerpEmotion_Private_Void_AvatarEmotionPreset_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680255);
			AvatarEmotionManager.NativeMethodInfoPtr_SetEmotion_Private_Void_AvatarEmotionPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680256);
			AvatarEmotionManager.NativeMethodInfoPtr_HasEmotion_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680257);
			AvatarEmotionManager.NativeMethodInfoPtr_GetEmotion_Public_AvatarEmotionPreset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680258);
			AvatarEmotionManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680259);
		}

		// Token: 0x1700296C RID: 10604
		// (get) Token: 0x060087FA RID: 34810 RVA: 0x0023D7C0 File Offset: 0x0023B9C0
		// (set) Token: 0x060087FB RID: 34811 RVA: 0x0023D7F8 File Offset: 0x0023B9F8
		public unsafe string CurrentEmotion
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_get_CurrentEmotion_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_set_CurrentEmotion_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700296D RID: 10605
		// (get) Token: 0x060087FC RID: 34812 RVA: 0x0023D83C File Offset: 0x0023BA3C
		// (set) Token: 0x060087FD RID: 34813 RVA: 0x0023D87C File Offset: 0x0023BA7C
		public unsafe AvatarEmotionPreset CurrentEmotionPreset
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19637, RefRangeEnd = 19640, XrefRangeStart = 19637, XrefRangeEnd = 19640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_get_CurrentEmotionPreset_Public_get_AvatarEmotionPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarEmotionPreset>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19641, RefRangeEnd = 19644, XrefRangeStart = 19641, XrefRangeEnd = 19644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_set_CurrentEmotionPreset_Protected_set_Void_AvatarEmotionPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700296E RID: 10606
		// (get) Token: 0x060087FE RID: 34814 RVA: 0x0023D8C0 File Offset: 0x0023BAC0
		public unsafe bool IsSwitchingEmotion
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 252122, RefRangeEnd = 252125, XrefRangeStart = 252122, XrefRangeEnd = 252122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_get_IsSwitchingEmotion_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060087FF RID: 34815 RVA: 0x0023D8FC File Offset: 0x0023BAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252125, XrefRangeEnd = 252151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008800 RID: 34816 RVA: 0x0023D930 File Offset: 0x0023BB30
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008801 RID: 34817 RVA: 0x0023D964 File Offset: 0x0023BB64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252151, XrefRangeEnd = 252211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEmotion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_UpdateEmotion_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008802 RID: 34818 RVA: 0x0023D998 File Offset: 0x0023BB98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 252234, RefRangeEnd = 252236, XrefRangeStart = 252211, XrefRangeEnd = 252234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureNeutralFace(Texture2D faceTex, float restingBrowHeight, float restingBrowAngle, Eye.EyeLidConfiguration leftEyelidConfig, Eye.EyeLidConfiguration rightEyelidConfig)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(faceTex);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref restingBrowHeight;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref restingBrowAngle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leftEyelidConfig;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightEyelidConfig;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_ConfigureNeutralFace_Public_Void_Texture2D_Single_Single_EyeLidConfiguration_EyeLidConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008803 RID: 34819 RVA: 0x0023DA14 File Offset: 0x0023BC14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252236, XrefRangeEnd = 252279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddEmotionOverride(string emotionName, string overrideLabel, float duration = 0f, int priority = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(emotionName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(overrideLabel);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarEmotionManager.NativeMethodInfoPtr_AddEmotionOverride_Public_Virtual_New_Void_String_String_Single_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008804 RID: 34820 RVA: 0x0023DA90 File Offset: 0x0023BC90
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 252297, RefRangeEnd = 252320, XrefRangeStart = 252279, XrefRangeEnd = 252297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveEmotionOverride(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_RemoveEmotionOverride_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008805 RID: 34821 RVA: 0x0023DAD4 File Offset: 0x0023BCD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 252328, RefRangeEnd = 252330, XrefRangeStart = 252320, XrefRangeEnd = 252328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearOverrides()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_ClearOverrides_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008806 RID: 34822 RVA: 0x0023DB08 File Offset: 0x0023BD08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 252343, RefRangeEnd = 252345, XrefRangeStart = 252330, XrefRangeEnd = 252343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearRemovalRoutine(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_ClearRemovalRoutine_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008807 RID: 34823 RVA: 0x0023DB4C File Offset: 0x0023BD4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252345, XrefRangeEnd = 252369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmotionOverride GetHighestPriorityOverride()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_GetHighestPriorityOverride_Public_EmotionOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EmotionOverride>(intPtr3) : null;
		}

		// Token: 0x06008808 RID: 34824 RVA: 0x0023DB8C File Offset: 0x0023BD8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252369, XrefRangeEnd = 252387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LerpEmotion(AvatarEmotionPreset preset, float animationTime = 0.2f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(preset);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref animationTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_LerpEmotion_Private_Void_AvatarEmotionPreset_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008809 RID: 34825 RVA: 0x0023DBDC File Offset: 0x0023BDDC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 252411, RefRangeEnd = 252414, XrefRangeStart = 252387, XrefRangeEnd = 252411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEmotion(AvatarEmotionPreset preset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(preset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_SetEmotion_Private_Void_AvatarEmotionPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600880A RID: 34826 RVA: 0x0023DC20 File Offset: 0x0023BE20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 252415, RefRangeEnd = 252416, XrefRangeStart = 252414, XrefRangeEnd = 252415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasEmotion(string emotion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(emotion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_HasEmotion_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600880B RID: 34827 RVA: 0x0023DC70 File Offset: 0x0023BE70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 252431, RefRangeEnd = 252433, XrefRangeStart = 252416, XrefRangeEnd = 252431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarEmotionPreset GetEmotion(string emotion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(emotion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_GetEmotion_Public_AvatarEmotionPreset_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarEmotionPreset>(intPtr3) : null;
		}

		// Token: 0x0600880C RID: 34828 RVA: 0x0023DCC0 File Offset: 0x0023BEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252433, XrefRangeEnd = 252459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarEmotionManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600880D RID: 34829 RVA: 0x00040CD7 File Offset: 0x0003EED7
		public AvatarEmotionManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700295F RID: 10591
		// (get) Token: 0x0600880E RID: 34830 RVA: 0x0023DCFC File Offset: 0x0023BEFC
		// (set) Token: 0x0600880F RID: 34831 RVA: 0x00040CE0 File Offset: 0x0003EEE0
		public unsafe static float MAX_UPDATE_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarEmotionManager.NativeFieldInfoPtr_MAX_UPDATE_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarEmotionManager.NativeFieldInfoPtr_MAX_UPDATE_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17002960 RID: 10592
		// (get) Token: 0x06008810 RID: 34832 RVA: 0x0023DD18 File Offset: 0x0023BF18
		// (set) Token: 0x06008811 RID: 34833 RVA: 0x00040CEE File Offset: 0x0003EEEE
		public unsafe string _CurrentEmotion_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr__CurrentEmotion_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr__CurrentEmotion_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002961 RID: 10593
		// (get) Token: 0x06008812 RID: 34834 RVA: 0x0023DD40 File Offset: 0x0023BF40
		// (set) Token: 0x06008813 RID: 34835 RVA: 0x00040D0D File Offset: 0x0003EF0D
		public unsafe AvatarEmotionPreset _CurrentEmotionPreset_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr__CurrentEmotionPreset_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionPreset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr__CurrentEmotionPreset_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002962 RID: 10594
		// (get) Token: 0x06008814 RID: 34836 RVA: 0x0023DD70 File Offset: 0x0023BF70
		// (set) Token: 0x06008815 RID: 34837 RVA: 0x00040D2C File Offset: 0x0003EF2C
		public unsafe List<AvatarEmotionPreset> EmotionPresetList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_EmotionPresetList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AvatarEmotionPreset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_EmotionPresetList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002963 RID: 10595
		// (get) Token: 0x06008816 RID: 34838 RVA: 0x0023DDA0 File Offset: 0x0023BFA0
		// (set) Token: 0x06008817 RID: 34839 RVA: 0x00040D4B File Offset: 0x0003EF4B
		public unsafe Avatar Avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_Avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002964 RID: 10596
		// (get) Token: 0x06008818 RID: 34840 RVA: 0x0023DDD0 File Offset: 0x0023BFD0
		// (set) Token: 0x06008819 RID: 34841 RVA: 0x00040D6A File Offset: 0x0003EF6A
		public unsafe EyeController EyeController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_EyeController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EyeController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_EyeController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002965 RID: 10597
		// (get) Token: 0x0600881A RID: 34842 RVA: 0x0023DE00 File Offset: 0x0023C000
		// (set) Token: 0x0600881B RID: 34843 RVA: 0x00040D89 File Offset: 0x0003EF89
		public unsafe EyebrowController EyebrowController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_EyebrowController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EyebrowController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_EyebrowController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002966 RID: 10598
		// (get) Token: 0x0600881C RID: 34844 RVA: 0x0023DE30 File Offset: 0x0023C030
		// (set) Token: 0x0600881D RID: 34845 RVA: 0x00040DA8 File Offset: 0x0003EFA8
		public unsafe EmotionOverride activeEmotionOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_activeEmotionOverride);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EmotionOverride>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_activeEmotionOverride), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002967 RID: 10599
		// (get) Token: 0x0600881E RID: 34846 RVA: 0x0023DE60 File Offset: 0x0023C060
		// (set) Token: 0x0600881F RID: 34847 RVA: 0x00040DC7 File Offset: 0x0003EFC7
		public unsafe List<EmotionOverride> overrideStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_overrideStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EmotionOverride>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_overrideStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002968 RID: 10600
		// (get) Token: 0x06008820 RID: 34848 RVA: 0x0023DE90 File Offset: 0x0023C090
		// (set) Token: 0x06008821 RID: 34849 RVA: 0x00040DE6 File Offset: 0x0003EFE6
		public unsafe AvatarEmotionPreset neutralPreset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_neutralPreset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionPreset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_neutralPreset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002969 RID: 10601
		// (get) Token: 0x06008822 RID: 34850 RVA: 0x0023DEC0 File Offset: 0x0023C0C0
		// (set) Token: 0x06008823 RID: 34851 RVA: 0x00040E05 File Offset: 0x0003F005
		public unsafe Coroutine emotionLerpRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_emotionLerpRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_emotionLerpRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700296A RID: 10602
		// (get) Token: 0x06008824 RID: 34852 RVA: 0x0023DEF0 File Offset: 0x0023C0F0
		// (set) Token: 0x06008825 RID: 34853 RVA: 0x00040E24 File Offset: 0x0003F024
		public unsafe Dictionary<string, Coroutine> emotionRemovalRoutines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_emotionRemovalRoutines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Coroutine>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_emotionRemovalRoutines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700296B RID: 10603
		// (get) Token: 0x06008826 RID: 34854 RVA: 0x0023DF20 File Offset: 0x0023C120
		// (set) Token: 0x06008827 RID: 34855 RVA: 0x00040E43 File Offset: 0x0003F043
		public unsafe int tempIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_tempIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_tempIndex)) = value;
			}
		}

		// Token: 0x04005C6B RID: 23659
		private static readonly IntPtr NativeFieldInfoPtr_MAX_UPDATE_DISTANCE;

		// Token: 0x04005C6C RID: 23660
		private static readonly IntPtr NativeFieldInfoPtr__CurrentEmotion_k__BackingField;

		// Token: 0x04005C6D RID: 23661
		private static readonly IntPtr NativeFieldInfoPtr__CurrentEmotionPreset_k__BackingField;

		// Token: 0x04005C6E RID: 23662
		private static readonly IntPtr NativeFieldInfoPtr_EmotionPresetList;

		// Token: 0x04005C6F RID: 23663
		private static readonly IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x04005C70 RID: 23664
		private static readonly IntPtr NativeFieldInfoPtr_EyeController;

		// Token: 0x04005C71 RID: 23665
		private static readonly IntPtr NativeFieldInfoPtr_EyebrowController;

		// Token: 0x04005C72 RID: 23666
		private static readonly IntPtr NativeFieldInfoPtr_activeEmotionOverride;

		// Token: 0x04005C73 RID: 23667
		private static readonly IntPtr NativeFieldInfoPtr_overrideStack;

		// Token: 0x04005C74 RID: 23668
		private static readonly IntPtr NativeFieldInfoPtr_neutralPreset;

		// Token: 0x04005C75 RID: 23669
		private static readonly IntPtr NativeFieldInfoPtr_emotionLerpRoutine;

		// Token: 0x04005C76 RID: 23670
		private static readonly IntPtr NativeFieldInfoPtr_emotionRemovalRoutines;

		// Token: 0x04005C77 RID: 23671
		private static readonly IntPtr NativeFieldInfoPtr_tempIndex;

		// Token: 0x04005C78 RID: 23672
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentEmotion_Public_get_String_0;

		// Token: 0x04005C79 RID: 23673
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentEmotion_Protected_set_Void_String_0;

		// Token: 0x04005C7A RID: 23674
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentEmotionPreset_Public_get_AvatarEmotionPreset_0;

		// Token: 0x04005C7B RID: 23675
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentEmotionPreset_Protected_set_Void_AvatarEmotionPreset_0;

		// Token: 0x04005C7C RID: 23676
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSwitchingEmotion_Public_get_Boolean_0;

		// Token: 0x04005C7D RID: 23677
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005C7E RID: 23678
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005C7F RID: 23679
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEmotion_Public_Void_0;

		// Token: 0x04005C80 RID: 23680
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureNeutralFace_Public_Void_Texture2D_Single_Single_EyeLidConfiguration_EyeLidConfiguration_0;

		// Token: 0x04005C81 RID: 23681
		private static readonly IntPtr NativeMethodInfoPtr_AddEmotionOverride_Public_Virtual_New_Void_String_String_Single_Int32_0;

		// Token: 0x04005C82 RID: 23682
		private static readonly IntPtr NativeMethodInfoPtr_RemoveEmotionOverride_Public_Void_String_0;

		// Token: 0x04005C83 RID: 23683
		private static readonly IntPtr NativeMethodInfoPtr_ClearOverrides_Public_Void_0;

		// Token: 0x04005C84 RID: 23684
		private static readonly IntPtr NativeMethodInfoPtr_ClearRemovalRoutine_Private_Void_String_0;

		// Token: 0x04005C85 RID: 23685
		private static readonly IntPtr NativeMethodInfoPtr_GetHighestPriorityOverride_Public_EmotionOverride_0;

		// Token: 0x04005C86 RID: 23686
		private static readonly IntPtr NativeMethodInfoPtr_LerpEmotion_Private_Void_AvatarEmotionPreset_Single_0;

		// Token: 0x04005C87 RID: 23687
		private static readonly IntPtr NativeMethodInfoPtr_SetEmotion_Private_Void_AvatarEmotionPreset_0;

		// Token: 0x04005C88 RID: 23688
		private static readonly IntPtr NativeMethodInfoPtr_HasEmotion_Public_Boolean_String_0;

		// Token: 0x04005C89 RID: 23689
		private static readonly IntPtr NativeMethodInfoPtr_GetEmotion_Public_AvatarEmotionPreset_String_0;

		// Token: 0x04005C8A RID: 23690
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AFC RID: 2812
		[ObfuscatedName("ScheduleOne.AvatarFramework.Emotions.AvatarEmotionManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D623 RID: 54819 RVA: 0x0032FFBC File Offset: 0x0032E1BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr);
				AvatarEmotionManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr, "<>9");
				AvatarEmotionManager.__c.NativeFieldInfoPtr___9__21_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr, "<>9__21_0");
				AvatarEmotionManager.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr, "<>9__24_0");
				AvatarEmotionManager.__c.NativeFieldInfoPtr___9__29_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr, "<>9__29_0");
				AvatarEmotionManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr, 100680261);
				AvatarEmotionManager.__c.NativeMethodInfoPtr__Start_b__21_0_Internal_Boolean_AvatarEmotionPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr, 100680262);
				AvatarEmotionManager.__c.NativeMethodInfoPtr__ConfigureNeutralFace_b__24_0_Internal_Boolean_AvatarEmotionPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr, 100680263);
				AvatarEmotionManager.__c.NativeMethodInfoPtr__GetHighestPriorityOverride_b__29_0_Internal_Int32_EmotionOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr, 100680264);
			}

			// Token: 0x0600D624 RID: 54820 RVA: 0x00330088 File Offset: 0x0032E288
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D625 RID: 54821 RVA: 0x003300C4 File Offset: 0x0032E2C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252076, XrefRangeEnd = 252080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Start_b__21_0(AvatarEmotionPreset x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c.NativeMethodInfoPtr__Start_b__21_0_Internal_Boolean_AvatarEmotionPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D626 RID: 54822 RVA: 0x00330114 File Offset: 0x0032E314
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252080, XrefRangeEnd = 252084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ConfigureNeutralFace_b__24_0(AvatarEmotionPreset x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c.NativeMethodInfoPtr__ConfigureNeutralFace_b__24_0_Internal_Boolean_AvatarEmotionPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D627 RID: 54823 RVA: 0x00330164 File Offset: 0x0032E364
			[CallerCount(0)]
			public unsafe int _GetHighestPriorityOverride_b__29_0(EmotionOverride x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c.NativeMethodInfoPtr__GetHighestPriorityOverride_b__29_0_Internal_Int32_EmotionOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D628 RID: 54824 RVA: 0x0006837A File Offset: 0x0006657A
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700425F RID: 16991
			// (get) Token: 0x0600D629 RID: 54825 RVA: 0x003301B4 File Offset: 0x0032E3B4
			// (set) Token: 0x0600D62A RID: 54826 RVA: 0x00068383 File Offset: 0x00066583
			public unsafe static AvatarEmotionManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AvatarEmotionManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AvatarEmotionManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004260 RID: 16992
			// (get) Token: 0x0600D62B RID: 54827 RVA: 0x003301DC File Offset: 0x0032E3DC
			// (set) Token: 0x0600D62C RID: 54828 RVA: 0x00068395 File Offset: 0x00066595
			public unsafe static Predicate<AvatarEmotionPreset> __9__21_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AvatarEmotionManager.__c.NativeFieldInfoPtr___9__21_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<AvatarEmotionPreset>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AvatarEmotionManager.__c.NativeFieldInfoPtr___9__21_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004261 RID: 16993
			// (get) Token: 0x0600D62D RID: 54829 RVA: 0x00330204 File Offset: 0x0032E404
			// (set) Token: 0x0600D62E RID: 54830 RVA: 0x000683A7 File Offset: 0x000665A7
			public unsafe static Predicate<AvatarEmotionPreset> __9__24_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AvatarEmotionManager.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<AvatarEmotionPreset>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AvatarEmotionManager.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004262 RID: 16994
			// (get) Token: 0x0600D62F RID: 54831 RVA: 0x0033022C File Offset: 0x0032E42C
			// (set) Token: 0x0600D630 RID: 54832 RVA: 0x000683B9 File Offset: 0x000665B9
			public unsafe static Func<EmotionOverride, int> __9__29_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AvatarEmotionManager.__c.NativeFieldInfoPtr___9__29_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EmotionOverride, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AvatarEmotionManager.__c.NativeFieldInfoPtr___9__29_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009007 RID: 36871
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009008 RID: 36872
			private static readonly IntPtr NativeFieldInfoPtr___9__21_0;

			// Token: 0x04009009 RID: 36873
			private static readonly IntPtr NativeFieldInfoPtr___9__24_0;

			// Token: 0x0400900A RID: 36874
			private static readonly IntPtr NativeFieldInfoPtr___9__29_0;

			// Token: 0x0400900B RID: 36875
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400900C RID: 36876
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__21_0_Internal_Boolean_AvatarEmotionPreset_0;

			// Token: 0x0400900D RID: 36877
			private static readonly IntPtr NativeMethodInfoPtr__ConfigureNeutralFace_b__24_0_Internal_Boolean_AvatarEmotionPreset_0;

			// Token: 0x0400900E RID: 36878
			private static readonly IntPtr NativeMethodInfoPtr__GetHighestPriorityOverride_b__29_0_Internal_Int32_EmotionOverride_0;
		}

		// Token: 0x02000AFD RID: 2813
		[ObfuscatedName("ScheduleOne.AvatarFramework.Emotions.AvatarEmotionManager+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D631 RID: 54833 RVA: 0x00330254 File Offset: 0x0032E454
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr);
				AvatarEmotionManager.__c__DisplayClass25_0.NativeFieldInfoPtr_overrideLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr, "overrideLabel");
				AvatarEmotionManager.__c__DisplayClass25_0.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr, "duration");
				AvatarEmotionManager.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr, "<>4__this");
				AvatarEmotionManager.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr, 100680265);
				AvatarEmotionManager.__c__DisplayClass25_0.NativeMethodInfoPtr__AddEmotionOverride_b__0_Internal_Boolean_EmotionOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr, 100680266);
				AvatarEmotionManager.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr, 100680267);
			}

			// Token: 0x0600D632 RID: 54834 RVA: 0x003302F8 File Offset: 0x0032E4F8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D633 RID: 54835 RVA: 0x00330334 File Offset: 0x0032E534
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddEmotionOverride_b__0(EmotionOverride x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass25_0.NativeMethodInfoPtr__AddEmotionOverride_b__0_Internal_Boolean_EmotionOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D634 RID: 54836 RVA: 0x00330384 File Offset: 0x0032E584
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252094, XrefRangeEnd = 252099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D635 RID: 54837 RVA: 0x000683CB File Offset: 0x000665CB
			public __c__DisplayClass25_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004263 RID: 16995
			// (get) Token: 0x0600D636 RID: 54838 RVA: 0x003303C4 File Offset: 0x0032E5C4
			// (set) Token: 0x0600D637 RID: 54839 RVA: 0x000683D4 File Offset: 0x000665D4
			public unsafe string overrideLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.NativeFieldInfoPtr_overrideLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.NativeFieldInfoPtr_overrideLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004264 RID: 16996
			// (get) Token: 0x0600D638 RID: 54840 RVA: 0x003303EC File Offset: 0x0032E5EC
			// (set) Token: 0x0600D639 RID: 54841 RVA: 0x000683F3 File Offset: 0x000665F3
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x17004265 RID: 16997
			// (get) Token: 0x0600D63A RID: 54842 RVA: 0x00330414 File Offset: 0x0032E614
			// (set) Token: 0x0600D63B RID: 54843 RVA: 0x0006840E File Offset: 0x0006660E
			public unsafe AvatarEmotionManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400900F RID: 36879
			private static readonly IntPtr NativeFieldInfoPtr_overrideLabel;

			// Token: 0x04009010 RID: 36880
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x04009011 RID: 36881
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009012 RID: 36882
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009013 RID: 36883
			private static readonly IntPtr NativeMethodInfoPtr__AddEmotionOverride_b__0_Internal_Boolean_EmotionOverride_0;

			// Token: 0x04009014 RID: 36884
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C6A RID: 3178
			[ObfuscatedName("ScheduleOne.AvatarFramework.Emotions.AvatarEmotionManager+<>c__DisplayClass25_0+<<AddEmotionOverride>g__RemoveEmotionAfterDuration|1>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E4B7 RID: 58551 RVA: 0x00359F74 File Offset: 0x00358174
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr, "<<AddEmotionOverride>g__RemoveEmotionAfterDuration|1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680268);
					AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680269);
					AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680270);
					AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680271);
					AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680272);
					AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680273);
				}

				// Token: 0x0600E4B8 RID: 58552 RVA: 0x0035A054 File Offset: 0x00358254
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E4B9 RID: 58553 RVA: 0x0035A09C File Offset: 0x0035829C
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E4BA RID: 58554 RVA: 0x0035A0D0 File Offset: 0x003582D0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252084, XrefRangeEnd = 252089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700470F RID: 18191
				// (get) Token: 0x0600E4BB RID: 58555 RVA: 0x0035A10C File Offset: 0x0035830C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E4BC RID: 58556 RVA: 0x0035A14C File Offset: 0x0035834C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252089, XrefRangeEnd = 252094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004710 RID: 18192
				// (get) Token: 0x0600E4BD RID: 58557 RVA: 0x0035A180 File Offset: 0x00358380
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E4BE RID: 58558 RVA: 0x0006F83C File Offset: 0x0006DA3C
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700470C RID: 18188
				// (get) Token: 0x0600E4BF RID: 58559 RVA: 0x0035A1C0 File Offset: 0x003583C0
				// (set) Token: 0x0600E4C0 RID: 58560 RVA: 0x0006F845 File Offset: 0x0006DA45
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700470D RID: 18189
				// (get) Token: 0x0600E4C1 RID: 58561 RVA: 0x0035A1E8 File Offset: 0x003583E8
				// (set) Token: 0x0600E4C2 RID: 58562 RVA: 0x0006F860 File Offset: 0x0006DA60
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700470E RID: 18190
				// (get) Token: 0x0600E4C3 RID: 58563 RVA: 0x0035A218 File Offset: 0x00358418
				// (set) Token: 0x0600E4C4 RID: 58564 RVA: 0x0006F87F File Offset: 0x0006DA7F
				public unsafe AvatarEmotionManager.__c__DisplayClass25_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionManager.__c__DisplayClass25_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040098FB RID: 39163
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040098FC RID: 39164
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040098FD RID: 39165
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040098FE RID: 39166
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040098FF RID: 39167
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009900 RID: 39168
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009901 RID: 39169
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009902 RID: 39170
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009903 RID: 39171
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000AFE RID: 2814
		[ObfuscatedName("ScheduleOne.AvatarFramework.Emotions.AvatarEmotionManager+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D63C RID: 54844 RVA: 0x00330444 File Offset: 0x0032E644
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass26_0>.NativeClassPtr);
				AvatarEmotionManager.__c__DisplayClass26_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass26_0>.NativeClassPtr, "label");
				AvatarEmotionManager.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass26_0>.NativeClassPtr, 100680274);
				AvatarEmotionManager.__c__DisplayClass26_0.NativeMethodInfoPtr__RemoveEmotionOverride_b__0_Internal_Boolean_EmotionOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass26_0>.NativeClassPtr, 100680275);
			}

			// Token: 0x0600D63D RID: 54845 RVA: 0x003304AC File Offset: 0x0032E6AC
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass26_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D63E RID: 54846 RVA: 0x003304E8 File Offset: 0x0032E6E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveEmotionOverride_b__0(EmotionOverride x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass26_0.NativeMethodInfoPtr__RemoveEmotionOverride_b__0_Internal_Boolean_EmotionOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D63F RID: 54847 RVA: 0x0006842D File Offset: 0x0006662D
			public __c__DisplayClass26_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004266 RID: 16998
			// (get) Token: 0x0600D640 RID: 54848 RVA: 0x00330538 File Offset: 0x0032E738
			// (set) Token: 0x0600D641 RID: 54849 RVA: 0x00068436 File Offset: 0x00066636
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass26_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass26_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009015 RID: 36885
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04009016 RID: 36886
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009017 RID: 36887
			private static readonly IntPtr NativeMethodInfoPtr__RemoveEmotionOverride_b__0_Internal_Boolean_EmotionOverride_0;
		}

		// Token: 0x02000AFF RID: 2815
		[ObfuscatedName("ScheduleOne.AvatarFramework.Emotions.AvatarEmotionManager+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D642 RID: 54850 RVA: 0x00330560 File Offset: 0x0032E760
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0>.NativeClassPtr);
				AvatarEmotionManager.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0>.NativeClassPtr, "<>4__this");
				AvatarEmotionManager.__c__DisplayClass30_0.NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0>.NativeClassPtr, "preset");
				AvatarEmotionManager.__c__DisplayClass30_0.NativeFieldInfoPtr_animationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0>.NativeClassPtr, "animationTime");
				AvatarEmotionManager.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0>.NativeClassPtr, 100680276);
				AvatarEmotionManager.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0>.NativeClassPtr, 100680277);
			}

			// Token: 0x0600D643 RID: 54851 RVA: 0x003305F0 File Offset: 0x0032E7F0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D644 RID: 54852 RVA: 0x0033062C File Offset: 0x0032E82C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252117, XrefRangeEnd = 252122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D645 RID: 54853 RVA: 0x00068455 File Offset: 0x00066655
			public __c__DisplayClass30_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004267 RID: 16999
			// (get) Token: 0x0600D646 RID: 54854 RVA: 0x0033066C File Offset: 0x0032E86C
			// (set) Token: 0x0600D647 RID: 54855 RVA: 0x0006845E File Offset: 0x0006665E
			public unsafe AvatarEmotionManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004268 RID: 17000
			// (get) Token: 0x0600D648 RID: 54856 RVA: 0x0033069C File Offset: 0x0032E89C
			// (set) Token: 0x0600D649 RID: 54857 RVA: 0x0006847D File Offset: 0x0006667D
			public unsafe AvatarEmotionPreset preset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.NativeFieldInfoPtr_preset);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionPreset>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.NativeFieldInfoPtr_preset), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004269 RID: 17001
			// (get) Token: 0x0600D64A RID: 54858 RVA: 0x003306CC File Offset: 0x0032E8CC
			// (set) Token: 0x0600D64B RID: 54859 RVA: 0x0006849C File Offset: 0x0006669C
			public unsafe float animationTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.NativeFieldInfoPtr_animationTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.NativeFieldInfoPtr_animationTime)) = value;
				}
			}

			// Token: 0x04009018 RID: 36888
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009019 RID: 36889
			private static readonly IntPtr NativeFieldInfoPtr_preset;

			// Token: 0x0400901A RID: 36890
			private static readonly IntPtr NativeFieldInfoPtr_animationTime;

			// Token: 0x0400901B RID: 36891
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400901C RID: 36892
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C6B RID: 3179
			[ObfuscatedName("ScheduleOne.AvatarFramework.Emotions.AvatarEmotionManager+<>c__DisplayClass30_0+<<LerpEmotion>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E4C5 RID: 58565 RVA: 0x0035A248 File Offset: 0x00358448
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique()
				{
					Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0>.NativeClassPtr, "<<LerpEmotion>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr);
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, "<>1__state");
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, "<>2__current");
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, "<>4__this");
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__startPreset_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, "<startPreset>5__2");
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__timeStep_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, "<timeStep>5__3");
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, "<i>5__4");
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, 100680278);
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, 100680279);
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, 100680280);
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, 100680281);
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, 100680282);
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, 100680283);
				}

				// Token: 0x0600E4C6 RID: 58566 RVA: 0x0035A364 File Offset: 0x00358564
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E4C7 RID: 58567 RVA: 0x0035A3AC File Offset: 0x003585AC
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E4C8 RID: 58568 RVA: 0x0035A3E0 File Offset: 0x003585E0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252099, XrefRangeEnd = 252112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004717 RID: 18199
				// (get) Token: 0x0600E4C9 RID: 58569 RVA: 0x0035A41C File Offset: 0x0035861C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E4CA RID: 58570 RVA: 0x0035A45C File Offset: 0x0035865C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252112, XrefRangeEnd = 252117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004718 RID: 18200
				// (get) Token: 0x0600E4CB RID: 58571 RVA: 0x0035A490 File Offset: 0x00358690
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E4CC RID: 58572 RVA: 0x0006F89E File Offset: 0x0006DA9E
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004711 RID: 18193
				// (get) Token: 0x0600E4CD RID: 58573 RVA: 0x0035A4D0 File Offset: 0x003586D0
				// (set) Token: 0x0600E4CE RID: 58574 RVA: 0x0006F8A7 File Offset: 0x0006DAA7
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004712 RID: 18194
				// (get) Token: 0x0600E4CF RID: 58575 RVA: 0x0035A4F8 File Offset: 0x003586F8
				// (set) Token: 0x0600E4D0 RID: 58576 RVA: 0x0006F8C2 File Offset: 0x0006DAC2
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004713 RID: 18195
				// (get) Token: 0x0600E4D1 RID: 58577 RVA: 0x0035A528 File Offset: 0x00358728
				// (set) Token: 0x0600E4D2 RID: 58578 RVA: 0x0006F8E1 File Offset: 0x0006DAE1
				public unsafe AvatarEmotionManager.__c__DisplayClass30_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionManager.__c__DisplayClass30_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004714 RID: 18196
				// (get) Token: 0x0600E4D3 RID: 58579 RVA: 0x0035A558 File Offset: 0x00358758
				// (set) Token: 0x0600E4D4 RID: 58580 RVA: 0x0006F900 File Offset: 0x0006DB00
				public unsafe AvatarEmotionPreset _startPreset_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__startPreset_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionPreset>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__startPreset_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004715 RID: 18197
				// (get) Token: 0x0600E4D5 RID: 58581 RVA: 0x0035A588 File Offset: 0x00358788
				// (set) Token: 0x0600E4D6 RID: 58582 RVA: 0x0006F91F File Offset: 0x0006DB1F
				public unsafe float _timeStep_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__timeStep_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__timeStep_5__3)) = value;
					}
				}

				// Token: 0x17004716 RID: 18198
				// (get) Token: 0x0600E4D7 RID: 58583 RVA: 0x0035A5B0 File Offset: 0x003587B0
				// (set) Token: 0x0600E4D8 RID: 58584 RVA: 0x0006F93A File Offset: 0x0006DB3A
				public unsafe float _i_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__i_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__i_5__4)) = value;
					}
				}

				// Token: 0x04009904 RID: 39172
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009905 RID: 39173
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009906 RID: 39174
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009907 RID: 39175
				private static readonly IntPtr NativeFieldInfoPtr__startPreset_5__2;

				// Token: 0x04009908 RID: 39176
				private static readonly IntPtr NativeFieldInfoPtr__timeStep_5__3;

				// Token: 0x04009909 RID: 39177
				private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

				// Token: 0x0400990A RID: 39178
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400990B RID: 39179
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400990C RID: 39180
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400990D RID: 39181
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400990E RID: 39182
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400990F RID: 39183
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B00 RID: 2816
		[ObfuscatedName("ScheduleOne.AvatarFramework.Emotions.AvatarEmotionManager+<>c__DisplayClass33_0")]
		public sealed class __c__DisplayClass33_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D64C RID: 54860 RVA: 0x003306F4 File Offset: 0x0032E8F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_0()
			{
				Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "<>c__DisplayClass33_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass33_0>.NativeClassPtr);
				AvatarEmotionManager.__c__DisplayClass33_0.NativeFieldInfoPtr_emotion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass33_0>.NativeClassPtr, "emotion");
				AvatarEmotionManager.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass33_0>.NativeClassPtr, 100680284);
				AvatarEmotionManager.__c__DisplayClass33_0.NativeMethodInfoPtr__GetEmotion_b__0_Internal_Boolean_AvatarEmotionPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass33_0>.NativeClassPtr, 100680285);
			}

			// Token: 0x0600D64D RID: 54861 RVA: 0x0033075C File Offset: 0x0032E95C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass33_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D64E RID: 54862 RVA: 0x00330798 File Offset: 0x0032E998
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetEmotion_b__0(AvatarEmotionPreset x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass33_0.NativeMethodInfoPtr__GetEmotion_b__0_Internal_Boolean_AvatarEmotionPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D64F RID: 54863 RVA: 0x000684B7 File Offset: 0x000666B7
			public __c__DisplayClass33_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700426A RID: 17002
			// (get) Token: 0x0600D650 RID: 54864 RVA: 0x003307E8 File Offset: 0x0032E9E8
			// (set) Token: 0x0600D651 RID: 54865 RVA: 0x000684C0 File Offset: 0x000666C0
			public unsafe string emotion
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass33_0.NativeFieldInfoPtr_emotion);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass33_0.NativeFieldInfoPtr_emotion), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400901D RID: 36893
			private static readonly IntPtr NativeFieldInfoPtr_emotion;

			// Token: 0x0400901E RID: 36894
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400901F RID: 36895
			private static readonly IntPtr NativeMethodInfoPtr__GetEmotion_b__0_Internal_Boolean_AvatarEmotionPreset_0;
		}
	}
}
