using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000619 RID: 1561
	public class CustomizationManager : Singleton<CustomizationManager>
	{
		// Token: 0x06008A16 RID: 35350 RVA: 0x0024372C File Offset: 0x0024192C
		// Note: this type is marked as 'beforefieldinit'.
		static CustomizationManager()
		{
			Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "CustomizationManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr);
			CustomizationManager.NativeFieldInfoPtr_ActiveSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, "ActiveSettings");
			CustomizationManager.NativeFieldInfoPtr_TemplateAvatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, "TemplateAvatar");
			CustomizationManager.NativeFieldInfoPtr_SaveInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, "SaveInputField");
			CustomizationManager.NativeFieldInfoPtr_LoadInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, "LoadInputField");
			CustomizationManager.NativeFieldInfoPtr_OnAvatarSettingsChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, "OnAvatarSettingsChanged");
			CustomizationManager.NativeFieldInfoPtr_DefaultSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, "DefaultSettings");
			CustomizationManager.NativeFieldInfoPtr_isEditingOriginal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, "isEditingOriginal");
			CustomizationManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680456);
			CustomizationManager.NativeMethodInfoPtr_CreateSettings_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680457);
			CustomizationManager.NativeMethodInfoPtr_CreateSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680458);
			CustomizationManager.NativeMethodInfoPtr_LoadSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680459);
			CustomizationManager.NativeMethodInfoPtr_LoadSettings_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680460);
			CustomizationManager.NativeMethodInfoPtr_ApplyDefaultSettings_Private_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680461);
			CustomizationManager.NativeMethodInfoPtr_LoadSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680462);
			CustomizationManager.NativeMethodInfoPtr_GenderChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680463);
			CustomizationManager.NativeMethodInfoPtr_WeightChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680464);
			CustomizationManager.NativeMethodInfoPtr_HeightChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680465);
			CustomizationManager.NativeMethodInfoPtr_SkinColorChanged_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680466);
			CustomizationManager.NativeMethodInfoPtr_HairChanged_Public_Void_Accessory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680467);
			CustomizationManager.NativeMethodInfoPtr_HairColorChanged_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680468);
			CustomizationManager.NativeMethodInfoPtr_EyeBallTintChanged_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680469);
			CustomizationManager.NativeMethodInfoPtr_UpperEyeLidRestingPositionChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680470);
			CustomizationManager.NativeMethodInfoPtr_LowerEyeLidRestingPositionChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680471);
			CustomizationManager.NativeMethodInfoPtr_EyebrowScaleChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680472);
			CustomizationManager.NativeMethodInfoPtr_EyebrowThicknessChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680473);
			CustomizationManager.NativeMethodInfoPtr_EyebrowRestingHeightChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680474);
			CustomizationManager.NativeMethodInfoPtr_EyebrowRestingAngleChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680475);
			CustomizationManager.NativeMethodInfoPtr_PupilDilationChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680476);
			CustomizationManager.NativeMethodInfoPtr_FaceLayerChanged_Public_Void_FaceLayer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680477);
			CustomizationManager.NativeMethodInfoPtr_FaceLayerColorChanged_Public_Void_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680478);
			CustomizationManager.NativeMethodInfoPtr_BodyLayerChanged_Public_Void_AvatarLayer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680479);
			CustomizationManager.NativeMethodInfoPtr_BodyLayerColorChanged_Public_Void_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680480);
			CustomizationManager.NativeMethodInfoPtr_AccessoryChanged_Public_Void_Accessory_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680481);
			CustomizationManager.NativeMethodInfoPtr_AccessoryColorChanged_Public_Void_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680482);
			CustomizationManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680483);
		}

		// Token: 0x06008A17 RID: 35351 RVA: 0x00243A18 File Offset: 0x00241C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254185, XrefRangeEnd = 254195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomizationManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A18 RID: 35352 RVA: 0x00243A54 File Offset: 0x00241C54
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateSettings(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_CreateSettings_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A19 RID: 35353 RVA: 0x00243A98 File Offset: 0x00241C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254195, XrefRangeEnd = 254200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_CreateSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A1A RID: 35354 RVA: 0x00243ACC File Offset: 0x00241CCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 254220, RefRangeEnd = 254223, XrefRangeStart = 254200, XrefRangeEnd = 254220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadSettings(AvatarSettings loadedSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(loadedSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_LoadSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A1B RID: 35355 RVA: 0x00243B10 File Offset: 0x00241D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254223, XrefRangeEnd = 254239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadSettings(string settingsName, bool editOriginal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(settingsName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref editOriginal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_LoadSettings_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A1C RID: 35356 RVA: 0x00243B60 File Offset: 0x00241D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254239, XrefRangeEnd = 254246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyDefaultSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_ApplyDefaultSettings_Private_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A1D RID: 35357 RVA: 0x00243BA4 File Offset: 0x00241DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254246, XrefRangeEnd = 254272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_LoadSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A1E RID: 35358 RVA: 0x00243BD8 File Offset: 0x00241DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254272, XrefRangeEnd = 254274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenderChanged(float genderScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref genderScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_GenderChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A1F RID: 35359 RVA: 0x00243C18 File Offset: 0x00241E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254274, XrefRangeEnd = 254276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WeightChanged(float weightScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref weightScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_WeightChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A20 RID: 35360 RVA: 0x00243C58 File Offset: 0x00241E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254276, XrefRangeEnd = 254278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HeightChanged(float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_HeightChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A21 RID: 35361 RVA: 0x00243C98 File Offset: 0x00241E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254278, XrefRangeEnd = 254282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkinColorChanged(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_SkinColorChanged_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A22 RID: 35362 RVA: 0x00243CD8 File Offset: 0x00241ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254282, XrefRangeEnd = 254292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HairChanged(Accessory newHair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newHair);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_HairChanged_Public_Void_Accessory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A23 RID: 35363 RVA: 0x00243D1C File Offset: 0x00241F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254292, XrefRangeEnd = 254294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HairColorChanged(Color newCol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newCol;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_HairColorChanged_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A24 RID: 35364 RVA: 0x00243D5C File Offset: 0x00241F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254294, XrefRangeEnd = 254296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EyeBallTintChanged(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_EyeBallTintChanged_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A25 RID: 35365 RVA: 0x00243D9C File Offset: 0x00241F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254296, XrefRangeEnd = 254298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpperEyeLidRestingPositionChanged(float newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_UpperEyeLidRestingPositionChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A26 RID: 35366 RVA: 0x00243DDC File Offset: 0x00241FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254298, XrefRangeEnd = 254300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LowerEyeLidRestingPositionChanged(float newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_LowerEyeLidRestingPositionChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A27 RID: 35367 RVA: 0x00243E1C File Offset: 0x0024201C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254300, XrefRangeEnd = 254302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EyebrowScaleChanged(float newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_EyebrowScaleChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A28 RID: 35368 RVA: 0x00243E5C File Offset: 0x0024205C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254302, XrefRangeEnd = 254304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EyebrowThicknessChanged(float newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_EyebrowThicknessChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A29 RID: 35369 RVA: 0x00243E9C File Offset: 0x0024209C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254304, XrefRangeEnd = 254306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EyebrowRestingHeightChanged(float newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_EyebrowRestingHeightChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A2A RID: 35370 RVA: 0x00243EDC File Offset: 0x002420DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254306, XrefRangeEnd = 254308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EyebrowRestingAngleChanged(float newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_EyebrowRestingAngleChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A2B RID: 35371 RVA: 0x00243F1C File Offset: 0x0024211C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254308, XrefRangeEnd = 254310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PupilDilationChanged(float dilation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dilation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_PupilDilationChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A2C RID: 35372 RVA: 0x00243F5C File Offset: 0x0024215C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254310, XrefRangeEnd = 254325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FaceLayerChanged(FaceLayer layer, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(layer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_FaceLayerChanged_Public_Void_FaceLayer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A2D RID: 35373 RVA: 0x00243FAC File Offset: 0x002421AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254325, XrefRangeEnd = 254333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FaceLayerColorChanged(Color col, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_FaceLayerColorChanged_Public_Void_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A2E RID: 35374 RVA: 0x00243FF8 File Offset: 0x002421F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254333, XrefRangeEnd = 254348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BodyLayerChanged(AvatarLayer layer, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(layer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_BodyLayerChanged_Public_Void_AvatarLayer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A2F RID: 35375 RVA: 0x00244048 File Offset: 0x00242248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254348, XrefRangeEnd = 254356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BodyLayerColorChanged(Color col, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_BodyLayerColorChanged_Public_Void_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A30 RID: 35376 RVA: 0x00244094 File Offset: 0x00242294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254356, XrefRangeEnd = 254395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AccessoryChanged(Accessory acc, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(acc);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_AccessoryChanged_Public_Void_Accessory_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A31 RID: 35377 RVA: 0x002440E4 File Offset: 0x002422E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254395, XrefRangeEnd = 254408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AccessoryColorChanged(Color col, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_AccessoryColorChanged_Public_Void_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A32 RID: 35378 RVA: 0x00244130 File Offset: 0x00242330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254408, XrefRangeEnd = 254411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomizationManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A33 RID: 35379 RVA: 0x000420B1 File Offset: 0x000402B1
		public CustomizationManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A1E RID: 10782
		// (get) Token: 0x06008A34 RID: 35380 RVA: 0x0024416C File Offset: 0x0024236C
		// (set) Token: 0x06008A35 RID: 35381 RVA: 0x000420BA File Offset: 0x000402BA
		public unsafe AvatarSettings ActiveSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_ActiveSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_ActiveSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A1F RID: 10783
		// (get) Token: 0x06008A36 RID: 35382 RVA: 0x0024419C File Offset: 0x0024239C
		// (set) Token: 0x06008A37 RID: 35383 RVA: 0x000420D9 File Offset: 0x000402D9
		public unsafe Avatar TemplateAvatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_TemplateAvatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_TemplateAvatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A20 RID: 10784
		// (get) Token: 0x06008A38 RID: 35384 RVA: 0x002441CC File Offset: 0x002423CC
		// (set) Token: 0x06008A39 RID: 35385 RVA: 0x000420F8 File Offset: 0x000402F8
		public unsafe TMP_InputField SaveInputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_SaveInputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_SaveInputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A21 RID: 10785
		// (get) Token: 0x06008A3A RID: 35386 RVA: 0x002441FC File Offset: 0x002423FC
		// (set) Token: 0x06008A3B RID: 35387 RVA: 0x00042117 File Offset: 0x00040317
		public unsafe TMP_InputField LoadInputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_LoadInputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_LoadInputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A22 RID: 10786
		// (get) Token: 0x06008A3C RID: 35388 RVA: 0x0024422C File Offset: 0x0024242C
		// (set) Token: 0x06008A3D RID: 35389 RVA: 0x00042136 File Offset: 0x00040336
		public unsafe CustomizationManager.AvatarSettingsChanged OnAvatarSettingsChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_OnAvatarSettingsChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomizationManager.AvatarSettingsChanged>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_OnAvatarSettingsChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A23 RID: 10787
		// (get) Token: 0x06008A3E RID: 35390 RVA: 0x0024425C File Offset: 0x0024245C
		// (set) Token: 0x06008A3F RID: 35391 RVA: 0x00042155 File Offset: 0x00040355
		public unsafe AvatarSettings DefaultSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_DefaultSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_DefaultSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A24 RID: 10788
		// (get) Token: 0x06008A40 RID: 35392 RVA: 0x0024428C File Offset: 0x0024248C
		// (set) Token: 0x06008A41 RID: 35393 RVA: 0x00042174 File Offset: 0x00040374
		public unsafe bool isEditingOriginal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_isEditingOriginal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_isEditingOriginal)) = value;
			}
		}

		// Token: 0x04005DB4 RID: 23988
		private static readonly IntPtr NativeFieldInfoPtr_ActiveSettings;

		// Token: 0x04005DB5 RID: 23989
		private static readonly IntPtr NativeFieldInfoPtr_TemplateAvatar;

		// Token: 0x04005DB6 RID: 23990
		private static readonly IntPtr NativeFieldInfoPtr_SaveInputField;

		// Token: 0x04005DB7 RID: 23991
		private static readonly IntPtr NativeFieldInfoPtr_LoadInputField;

		// Token: 0x04005DB8 RID: 23992
		private static readonly IntPtr NativeFieldInfoPtr_OnAvatarSettingsChanged;

		// Token: 0x04005DB9 RID: 23993
		private static readonly IntPtr NativeFieldInfoPtr_DefaultSettings;

		// Token: 0x04005DBA RID: 23994
		private static readonly IntPtr NativeFieldInfoPtr_isEditingOriginal;

		// Token: 0x04005DBB RID: 23995
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04005DBC RID: 23996
		private static readonly IntPtr NativeMethodInfoPtr_CreateSettings_Public_Void_String_0;

		// Token: 0x04005DBD RID: 23997
		private static readonly IntPtr NativeMethodInfoPtr_CreateSettings_Public_Void_0;

		// Token: 0x04005DBE RID: 23998
		private static readonly IntPtr NativeMethodInfoPtr_LoadSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005DBF RID: 23999
		private static readonly IntPtr NativeMethodInfoPtr_LoadSettings_Public_Void_String_Boolean_0;

		// Token: 0x04005DC0 RID: 24000
		private static readonly IntPtr NativeMethodInfoPtr_ApplyDefaultSettings_Private_Void_AvatarSettings_0;

		// Token: 0x04005DC1 RID: 24001
		private static readonly IntPtr NativeMethodInfoPtr_LoadSettings_Public_Void_0;

		// Token: 0x04005DC2 RID: 24002
		private static readonly IntPtr NativeMethodInfoPtr_GenderChanged_Public_Void_Single_0;

		// Token: 0x04005DC3 RID: 24003
		private static readonly IntPtr NativeMethodInfoPtr_WeightChanged_Public_Void_Single_0;

		// Token: 0x04005DC4 RID: 24004
		private static readonly IntPtr NativeMethodInfoPtr_HeightChanged_Public_Void_Single_0;

		// Token: 0x04005DC5 RID: 24005
		private static readonly IntPtr NativeMethodInfoPtr_SkinColorChanged_Public_Void_Color_0;

		// Token: 0x04005DC6 RID: 24006
		private static readonly IntPtr NativeMethodInfoPtr_HairChanged_Public_Void_Accessory_0;

		// Token: 0x04005DC7 RID: 24007
		private static readonly IntPtr NativeMethodInfoPtr_HairColorChanged_Public_Void_Color_0;

		// Token: 0x04005DC8 RID: 24008
		private static readonly IntPtr NativeMethodInfoPtr_EyeBallTintChanged_Public_Void_Color_0;

		// Token: 0x04005DC9 RID: 24009
		private static readonly IntPtr NativeMethodInfoPtr_UpperEyeLidRestingPositionChanged_Public_Void_Single_0;

		// Token: 0x04005DCA RID: 24010
		private static readonly IntPtr NativeMethodInfoPtr_LowerEyeLidRestingPositionChanged_Public_Void_Single_0;

		// Token: 0x04005DCB RID: 24011
		private static readonly IntPtr NativeMethodInfoPtr_EyebrowScaleChanged_Public_Void_Single_0;

		// Token: 0x04005DCC RID: 24012
		private static readonly IntPtr NativeMethodInfoPtr_EyebrowThicknessChanged_Public_Void_Single_0;

		// Token: 0x04005DCD RID: 24013
		private static readonly IntPtr NativeMethodInfoPtr_EyebrowRestingHeightChanged_Public_Void_Single_0;

		// Token: 0x04005DCE RID: 24014
		private static readonly IntPtr NativeMethodInfoPtr_EyebrowRestingAngleChanged_Public_Void_Single_0;

		// Token: 0x04005DCF RID: 24015
		private static readonly IntPtr NativeMethodInfoPtr_PupilDilationChanged_Public_Void_Single_0;

		// Token: 0x04005DD0 RID: 24016
		private static readonly IntPtr NativeMethodInfoPtr_FaceLayerChanged_Public_Void_FaceLayer_Int32_0;

		// Token: 0x04005DD1 RID: 24017
		private static readonly IntPtr NativeMethodInfoPtr_FaceLayerColorChanged_Public_Void_Color_Int32_0;

		// Token: 0x04005DD2 RID: 24018
		private static readonly IntPtr NativeMethodInfoPtr_BodyLayerChanged_Public_Void_AvatarLayer_Int32_0;

		// Token: 0x04005DD3 RID: 24019
		private static readonly IntPtr NativeMethodInfoPtr_BodyLayerColorChanged_Public_Void_Color_Int32_0;

		// Token: 0x04005DD4 RID: 24020
		private static readonly IntPtr NativeMethodInfoPtr_AccessoryChanged_Public_Void_Accessory_Int32_0;

		// Token: 0x04005DD5 RID: 24021
		private static readonly IntPtr NativeMethodInfoPtr_AccessoryColorChanged_Public_Void_Color_Int32_0;

		// Token: 0x04005DD6 RID: 24022
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B10 RID: 2832
		public sealed class AvatarSettingsChanged : MulticastDelegate
		{
			// Token: 0x0600D6A3 RID: 54947 RVA: 0x003316CC File Offset: 0x0032F8CC
			// Note: this type is marked as 'beforefieldinit'.
			static AvatarSettingsChanged()
			{
				Il2CppClassPointerStore<CustomizationManager.AvatarSettingsChanged>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, "AvatarSettingsChanged");
				CustomizationManager.AvatarSettingsChanged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager.AvatarSettingsChanged>.NativeClassPtr, 100680484);
				CustomizationManager.AvatarSettingsChanged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager.AvatarSettingsChanged>.NativeClassPtr, 100680485);
				CustomizationManager.AvatarSettingsChanged.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AvatarSettings_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager.AvatarSettingsChanged>.NativeClassPtr, 100680486);
				CustomizationManager.AvatarSettingsChanged.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager.AvatarSettingsChanged>.NativeClassPtr, 100680487);
			}

			// Token: 0x0600D6A4 RID: 54948 RVA: 0x00331740 File Offset: 0x0032F940
			[CallerCount(632)]
			[CachedScanResults(RefRangeStart = 81889, RefRangeEnd = 82521, XrefRangeStart = 81889, XrefRangeEnd = 82521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AvatarSettingsChanged(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomizationManager.AvatarSettingsChanged>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.AvatarSettingsChanged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6A5 RID: 54949 RVA: 0x0033179C File Offset: 0x0032F99C
			[CallerCount(0)]
			public unsafe void Invoke(AvatarSettings settings)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.AvatarSettingsChanged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6A6 RID: 54950 RVA: 0x003317E0 File Offset: 0x0032F9E0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74827, RefRangeEnd = 74828, XrefRangeStart = 74827, XrefRangeEnd = 74828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(AvatarSettings settings, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.AvatarSettingsChanged.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AvatarSettings_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600D6A7 RID: 54951 RVA: 0x00331854 File Offset: 0x0032FA54
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22499, RefRangeEnd = 22500, XrefRangeStart = 22499, XrefRangeEnd = 22500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.AvatarSettingsChanged.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6A8 RID: 54952 RVA: 0x00068747 File Offset: 0x00066947
			public AvatarSettingsChanged(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D6A9 RID: 54953 RVA: 0x00068750 File Offset: 0x00066950
			public static implicit operator CustomizationManager.AvatarSettingsChanged(Action<AvatarSettings> A_0)
			{
				return DelegateSupport.ConvertDelegate<CustomizationManager.AvatarSettingsChanged>(A_0);
			}

			// Token: 0x0600D6AA RID: 54954 RVA: 0x00068758 File Offset: 0x00066958
			public static CustomizationManager.AvatarSettingsChanged operator +(CustomizationManager.AvatarSettingsChanged A_0, CustomizationManager.AvatarSettingsChanged A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<CustomizationManager.AvatarSettingsChanged>();
			}

			// Token: 0x0600D6AB RID: 54955 RVA: 0x00068766 File Offset: 0x00066966
			public static CustomizationManager.AvatarSettingsChanged operator -(CustomizationManager.AvatarSettingsChanged A_0, CustomizationManager.AvatarSettingsChanged A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<CustomizationManager.AvatarSettingsChanged>();
				}
				return result;
			}

			// Token: 0x0400905C RID: 36956
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400905D RID: 36957
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AvatarSettings_0;

			// Token: 0x0400905E RID: 36958
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AvatarSettings_AsyncCallback_Object_0;

			// Token: 0x0400905F RID: 36959
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
