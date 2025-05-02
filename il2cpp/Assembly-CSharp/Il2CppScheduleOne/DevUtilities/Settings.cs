using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000478 RID: 1144
	public class Settings : PersistentSingleton<Settings>
	{
		// Token: 0x060062C5 RID: 25285 RVA: 0x001C0AF4 File Offset: 0x001BECF4
		// Note: this type is marked as 'beforefieldinit'.
		static Settings()
		{
			Il2CppClassPointerStore<Settings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "Settings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Settings>.NativeClassPtr);
			Settings.NativeFieldInfoPtr_MinYPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "MinYPos");
			Settings.NativeFieldInfoPtr__unitType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "<unitType>k__BackingField");
			Settings.NativeFieldInfoPtr_DisplaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "DisplaySettings");
			Settings.NativeFieldInfoPtr_UnappliedDisplaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "UnappliedDisplaySettings");
			Settings.NativeFieldInfoPtr_GraphicsSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "GraphicsSettings");
			Settings.NativeFieldInfoPtr_AudioSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "AudioSettings");
			Settings.NativeFieldInfoPtr_InputSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "InputSettings");
			Settings.NativeFieldInfoPtr_InputActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "InputActions");
			Settings.NativeFieldInfoPtr_GameInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "GameInput");
			Settings.NativeFieldInfoPtr_SSAO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "SSAO");
			Settings.NativeFieldInfoPtr_GodRays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "GodRays");
			Settings.NativeFieldInfoPtr_LookSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "LookSensitivity");
			Settings.NativeFieldInfoPtr_InvertMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "InvertMouse");
			Settings.NativeFieldInfoPtr_CameraFOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "CameraFOV");
			Settings.NativeFieldInfoPtr_SprintMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "SprintMode");
			Settings.NativeFieldInfoPtr_CameraBobIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "CameraBobIntensity");
			Settings.NativeFieldInfoPtr_playerControls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "playerControls");
			Settings.NativeFieldInfoPtr_onDisplayChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "onDisplayChanged");
			Settings.NativeFieldInfoPtr_onInputsApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "onInputsApplied");
			Settings.NativeMethodInfoPtr_get_unitType_Public_get_UnitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675819);
			Settings.NativeMethodInfoPtr_set_unitType_Protected_set_Void_UnitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675820);
			Settings.NativeMethodInfoPtr_get_PausingFreezesTime_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675821);
			Settings.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675822);
			Settings.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675823);
			Settings.NativeMethodInfoPtr_ApplyDisplaySettings_Public_Void_DisplaySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675824);
			Settings.NativeMethodInfoPtr_MoveMainWindowTo_Private_Void_DisplayInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675825);
			Settings.NativeMethodInfoPtr_ReloadGraphicsSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675826);
			Settings.NativeMethodInfoPtr_ApplyGraphicsSettings_Public_Void_GraphicsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675827);
			Settings.NativeMethodInfoPtr_ReloadAudioSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675828);
			Settings.NativeMethodInfoPtr_ApplyAudioSettings_Public_Void_AudioSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675829);
			Settings.NativeMethodInfoPtr_ReloadInputSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675830);
			Settings.NativeMethodInfoPtr_ApplyInputSettings_Public_Void_InputSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675831);
			Settings.NativeMethodInfoPtr_WriteDisplaySettings_Public_Void_DisplaySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675832);
			Settings.NativeMethodInfoPtr_ReadDisplaySettings_Public_DisplaySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675833);
			Settings.NativeMethodInfoPtr_WriteGraphicsSettings_Public_Void_GraphicsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675834);
			Settings.NativeMethodInfoPtr_ReadGraphicsSettings_Public_GraphicsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675835);
			Settings.NativeMethodInfoPtr_WriteAudioSettings_Public_Void_AudioSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675836);
			Settings.NativeMethodInfoPtr_ReadAudioSettings_Public_AudioSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675837);
			Settings.NativeMethodInfoPtr_WriteInputSettings_Public_Void_InputSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675838);
			Settings.NativeMethodInfoPtr_ReadInputSettings_Public_InputSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675839);
			Settings.NativeMethodInfoPtr_GetActionControlPath_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675840);
			Settings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100675841);
		}

		// Token: 0x17001DCF RID: 7631
		// (get) Token: 0x060062C6 RID: 25286 RVA: 0x001C0E6C File Offset: 0x001BF06C
		// (set) Token: 0x060062C7 RID: 25287 RVA: 0x001C0EA8 File Offset: 0x001BF0A8
		public unsafe Settings.UnitType unitType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29988, RefRangeEnd = 29989, XrefRangeStart = 29988, XrefRangeEnd = 29989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_unitType_Public_get_UnitType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29989, RefRangeEnd = 29990, XrefRangeStart = 29989, XrefRangeEnd = 29990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_set_unitType_Protected_set_Void_UnitType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001DD0 RID: 7632
		// (get) Token: 0x060062C8 RID: 25288 RVA: 0x001C0EE8 File Offset: 0x001BF0E8
		public unsafe bool PausingFreezesTime
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 202570, RefRangeEnd = 202574, XrefRangeStart = 202564, XrefRangeEnd = 202570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_PausingFreezesTime_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060062C9 RID: 25289 RVA: 0x001C0F24 File Offset: 0x001BF124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202574, XrefRangeEnd = 202670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Settings.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062CA RID: 25290 RVA: 0x001C0F60 File Offset: 0x001BF160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202670, XrefRangeEnd = 202679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Settings.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062CB RID: 25291 RVA: 0x001C0F9C File Offset: 0x001BF19C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 202722, RefRangeEnd = 202725, XrefRangeStart = 202679, XrefRangeEnd = 202722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyDisplaySettings(DisplaySettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref settings;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ApplyDisplaySettings_Public_Void_DisplaySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062CC RID: 25292 RVA: 0x001C0FDC File Offset: 0x001BF1DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202725, XrefRangeEnd = 202733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveMainWindowTo(DisplayInfo displayInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(displayInfo));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_MoveMainWindowTo_Private_Void_DisplayInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062CD RID: 25293 RVA: 0x001C1024 File Offset: 0x001BF224
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 202735, RefRangeEnd = 202740, XrefRangeStart = 202733, XrefRangeEnd = 202735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReloadGraphicsSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ReloadGraphicsSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062CE RID: 25294 RVA: 0x001C1058 File Offset: 0x001BF258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202740, XrefRangeEnd = 202742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyGraphicsSettings(GraphicsSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ApplyGraphicsSettings_Public_Void_GraphicsSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062CF RID: 25295 RVA: 0x001C109C File Offset: 0x001BF29C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 202743, RefRangeEnd = 202744, XrefRangeStart = 202742, XrefRangeEnd = 202743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReloadAudioSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ReloadAudioSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062D0 RID: 25296 RVA: 0x001C10D0 File Offset: 0x001BF2D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 202773, RefRangeEnd = 202775, XrefRangeStart = 202744, XrefRangeEnd = 202773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyAudioSettings(AudioSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ApplyAudioSettings_Public_Void_AudioSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062D1 RID: 25297 RVA: 0x001C1114 File Offset: 0x001BF314
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 202776, RefRangeEnd = 202779, XrefRangeStart = 202775, XrefRangeEnd = 202776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReloadInputSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ReloadInputSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062D2 RID: 25298 RVA: 0x001C1148 File Offset: 0x001BF348
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 202784, RefRangeEnd = 202786, XrefRangeStart = 202779, XrefRangeEnd = 202784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyInputSettings(InputSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ApplyInputSettings_Public_Void_InputSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062D3 RID: 25299 RVA: 0x001C118C File Offset: 0x001BF38C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 202808, RefRangeEnd = 202809, XrefRangeStart = 202786, XrefRangeEnd = 202808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteDisplaySettings(DisplaySettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref settings;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_WriteDisplaySettings_Public_Void_DisplaySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062D4 RID: 25300 RVA: 0x001C11CC File Offset: 0x001BF3CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 202831, RefRangeEnd = 202833, XrefRangeStart = 202809, XrefRangeEnd = 202831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DisplaySettings ReadDisplaySettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ReadDisplaySettings_Public_DisplaySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060062D5 RID: 25301 RVA: 0x001C1208 File Offset: 0x001BF408
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 202850, RefRangeEnd = 202855, XrefRangeStart = 202833, XrefRangeEnd = 202850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteGraphicsSettings(GraphicsSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_WriteGraphicsSettings_Public_Void_GraphicsSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062D6 RID: 25302 RVA: 0x001C124C File Offset: 0x001BF44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202855, XrefRangeEnd = 202874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphicsSettings ReadGraphicsSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ReadGraphicsSettings_Public_GraphicsSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GraphicsSettings>(intPtr3) : null;
		}

		// Token: 0x060062D7 RID: 25303 RVA: 0x001C128C File Offset: 0x001BF48C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 202897, RefRangeEnd = 202898, XrefRangeStart = 202874, XrefRangeEnd = 202897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteAudioSettings(AudioSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_WriteAudioSettings_Public_Void_AudioSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062D8 RID: 25304 RVA: 0x001C12D0 File Offset: 0x001BF4D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202898, XrefRangeEnd = 202923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioSettings ReadAudioSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ReadAudioSettings_Public_AudioSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioSettings>(intPtr3) : null;
		}

		// Token: 0x060062D9 RID: 25305 RVA: 0x001C1310 File Offset: 0x001BF510
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 202939, RefRangeEnd = 202942, XrefRangeStart = 202923, XrefRangeEnd = 202939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteInputSettings(InputSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_WriteInputSettings_Public_Void_InputSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062DA RID: 25306 RVA: 0x001C1354 File Offset: 0x001BF554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202942, XrefRangeEnd = 202961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputSettings ReadInputSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ReadInputSettings_Public_InputSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputSettings>(intPtr3) : null;
		}

		// Token: 0x060062DB RID: 25307 RVA: 0x001C1394 File Offset: 0x001BF594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202961, XrefRangeEnd = 202971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetActionControlPath(string actionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_GetActionControlPath_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060062DC RID: 25308 RVA: 0x001C13DC File Offset: 0x001BF5DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202971, XrefRangeEnd = 202989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Settings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Settings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062DD RID: 25309 RVA: 0x0002EB3A File Offset: 0x0002CD3A
		public Settings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DBC RID: 7612
		// (get) Token: 0x060062DE RID: 25310 RVA: 0x001C1418 File Offset: 0x001BF618
		// (set) Token: 0x060062DF RID: 25311 RVA: 0x0002EB43 File Offset: 0x0002CD43
		public unsafe static float MinYPos
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Settings.NativeFieldInfoPtr_MinYPos, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Settings.NativeFieldInfoPtr_MinYPos, (void*)(&value));
			}
		}

		// Token: 0x17001DBD RID: 7613
		// (get) Token: 0x060062E0 RID: 25312 RVA: 0x001C1434 File Offset: 0x001BF634
		// (set) Token: 0x060062E1 RID: 25313 RVA: 0x0002EB51 File Offset: 0x0002CD51
		public unsafe Settings.UnitType _unitType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr__unitType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr__unitType_k__BackingField)) = value;
			}
		}

		// Token: 0x17001DBE RID: 7614
		// (get) Token: 0x060062E2 RID: 25314 RVA: 0x001C145C File Offset: 0x001BF65C
		// (set) Token: 0x060062E3 RID: 25315 RVA: 0x0002EB6C File Offset: 0x0002CD6C
		public unsafe DisplaySettings DisplaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_DisplaySettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_DisplaySettings)) = value;
			}
		}

		// Token: 0x17001DBF RID: 7615
		// (get) Token: 0x060062E4 RID: 25316 RVA: 0x001C1484 File Offset: 0x001BF684
		// (set) Token: 0x060062E5 RID: 25317 RVA: 0x0002EB87 File Offset: 0x0002CD87
		public unsafe DisplaySettings UnappliedDisplaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_UnappliedDisplaySettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_UnappliedDisplaySettings)) = value;
			}
		}

		// Token: 0x17001DC0 RID: 7616
		// (get) Token: 0x060062E6 RID: 25318 RVA: 0x001C14AC File Offset: 0x001BF6AC
		// (set) Token: 0x060062E7 RID: 25319 RVA: 0x0002EBA2 File Offset: 0x0002CDA2
		public unsafe GraphicsSettings GraphicsSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_GraphicsSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraphicsSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_GraphicsSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DC1 RID: 7617
		// (get) Token: 0x060062E8 RID: 25320 RVA: 0x001C14DC File Offset: 0x001BF6DC
		// (set) Token: 0x060062E9 RID: 25321 RVA: 0x0002EBC1 File Offset: 0x0002CDC1
		public unsafe AudioSettings AudioSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_AudioSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_AudioSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DC2 RID: 7618
		// (get) Token: 0x060062EA RID: 25322 RVA: 0x001C150C File Offset: 0x001BF70C
		// (set) Token: 0x060062EB RID: 25323 RVA: 0x0002EBE0 File Offset: 0x0002CDE0
		public unsafe InputSettings InputSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_InputSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_InputSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DC3 RID: 7619
		// (get) Token: 0x060062EC RID: 25324 RVA: 0x001C153C File Offset: 0x001BF73C
		// (set) Token: 0x060062ED RID: 25325 RVA: 0x0002EBFF File Offset: 0x0002CDFF
		public unsafe InputActionAsset InputActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_InputActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_InputActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DC4 RID: 7620
		// (get) Token: 0x060062EE RID: 25326 RVA: 0x001C156C File Offset: 0x001BF76C
		// (set) Token: 0x060062EF RID: 25327 RVA: 0x0002EC1E File Offset: 0x0002CE1E
		public unsafe GameInput GameInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_GameInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameInput>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_GameInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DC5 RID: 7621
		// (get) Token: 0x060062F0 RID: 25328 RVA: 0x001C159C File Offset: 0x001BF79C
		// (set) Token: 0x060062F1 RID: 25329 RVA: 0x0002EC3D File Offset: 0x0002CE3D
		public unsafe ScriptableRendererFeature SSAO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_SSAO);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableRendererFeature>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_SSAO), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DC6 RID: 7622
		// (get) Token: 0x060062F2 RID: 25330 RVA: 0x001C15CC File Offset: 0x001BF7CC
		// (set) Token: 0x060062F3 RID: 25331 RVA: 0x0002EC5C File Offset: 0x0002CE5C
		public unsafe ScriptableRendererFeature GodRays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_GodRays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableRendererFeature>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_GodRays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DC7 RID: 7623
		// (get) Token: 0x060062F4 RID: 25332 RVA: 0x001C15FC File Offset: 0x001BF7FC
		// (set) Token: 0x060062F5 RID: 25333 RVA: 0x0002EC7B File Offset: 0x0002CE7B
		public unsafe float LookSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_LookSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_LookSensitivity)) = value;
			}
		}

		// Token: 0x17001DC8 RID: 7624
		// (get) Token: 0x060062F6 RID: 25334 RVA: 0x001C1624 File Offset: 0x001BF824
		// (set) Token: 0x060062F7 RID: 25335 RVA: 0x0002EC96 File Offset: 0x0002CE96
		public unsafe bool InvertMouse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_InvertMouse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_InvertMouse)) = value;
			}
		}

		// Token: 0x17001DC9 RID: 7625
		// (get) Token: 0x060062F8 RID: 25336 RVA: 0x001C164C File Offset: 0x001BF84C
		// (set) Token: 0x060062F9 RID: 25337 RVA: 0x0002ECB1 File Offset: 0x0002CEB1
		public unsafe float CameraFOV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_CameraFOV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_CameraFOV)) = value;
			}
		}

		// Token: 0x17001DCA RID: 7626
		// (get) Token: 0x060062FA RID: 25338 RVA: 0x001C1674 File Offset: 0x001BF874
		// (set) Token: 0x060062FB RID: 25339 RVA: 0x0002ECCC File Offset: 0x0002CECC
		public unsafe InputSettings.EActionMode SprintMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_SprintMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_SprintMode)) = value;
			}
		}

		// Token: 0x17001DCB RID: 7627
		// (get) Token: 0x060062FC RID: 25340 RVA: 0x001C169C File Offset: 0x001BF89C
		// (set) Token: 0x060062FD RID: 25341 RVA: 0x0002ECE7 File Offset: 0x0002CEE7
		public unsafe float CameraBobIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_CameraBobIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_CameraBobIntensity)) = value;
			}
		}

		// Token: 0x17001DCC RID: 7628
		// (get) Token: 0x060062FE RID: 25342 RVA: 0x001C16C4 File Offset: 0x001BF8C4
		// (set) Token: 0x060062FF RID: 25343 RVA: 0x0002ED02 File Offset: 0x0002CF02
		public unsafe InputActionMap playerControls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_playerControls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionMap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_playerControls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DCD RID: 7629
		// (get) Token: 0x06006300 RID: 25344 RVA: 0x001C16F4 File Offset: 0x001BF8F4
		// (set) Token: 0x06006301 RID: 25345 RVA: 0x0002ED21 File Offset: 0x0002CF21
		public unsafe Action onDisplayChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_onDisplayChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_onDisplayChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DCE RID: 7630
		// (get) Token: 0x06006302 RID: 25346 RVA: 0x001C1724 File Offset: 0x001BF924
		// (set) Token: 0x06006303 RID: 25347 RVA: 0x0002ED40 File Offset: 0x0002CF40
		public unsafe Action onInputsApplied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_onInputsApplied);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_onInputsApplied), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400435E RID: 17246
		private static readonly IntPtr NativeFieldInfoPtr_MinYPos;

		// Token: 0x0400435F RID: 17247
		private static readonly IntPtr NativeFieldInfoPtr__unitType_k__BackingField;

		// Token: 0x04004360 RID: 17248
		private static readonly IntPtr NativeFieldInfoPtr_DisplaySettings;

		// Token: 0x04004361 RID: 17249
		private static readonly IntPtr NativeFieldInfoPtr_UnappliedDisplaySettings;

		// Token: 0x04004362 RID: 17250
		private static readonly IntPtr NativeFieldInfoPtr_GraphicsSettings;

		// Token: 0x04004363 RID: 17251
		private static readonly IntPtr NativeFieldInfoPtr_AudioSettings;

		// Token: 0x04004364 RID: 17252
		private static readonly IntPtr NativeFieldInfoPtr_InputSettings;

		// Token: 0x04004365 RID: 17253
		private static readonly IntPtr NativeFieldInfoPtr_InputActions;

		// Token: 0x04004366 RID: 17254
		private static readonly IntPtr NativeFieldInfoPtr_GameInput;

		// Token: 0x04004367 RID: 17255
		private static readonly IntPtr NativeFieldInfoPtr_SSAO;

		// Token: 0x04004368 RID: 17256
		private static readonly IntPtr NativeFieldInfoPtr_GodRays;

		// Token: 0x04004369 RID: 17257
		private static readonly IntPtr NativeFieldInfoPtr_LookSensitivity;

		// Token: 0x0400436A RID: 17258
		private static readonly IntPtr NativeFieldInfoPtr_InvertMouse;

		// Token: 0x0400436B RID: 17259
		private static readonly IntPtr NativeFieldInfoPtr_CameraFOV;

		// Token: 0x0400436C RID: 17260
		private static readonly IntPtr NativeFieldInfoPtr_SprintMode;

		// Token: 0x0400436D RID: 17261
		private static readonly IntPtr NativeFieldInfoPtr_CameraBobIntensity;

		// Token: 0x0400436E RID: 17262
		private static readonly IntPtr NativeFieldInfoPtr_playerControls;

		// Token: 0x0400436F RID: 17263
		private static readonly IntPtr NativeFieldInfoPtr_onDisplayChanged;

		// Token: 0x04004370 RID: 17264
		private static readonly IntPtr NativeFieldInfoPtr_onInputsApplied;

		// Token: 0x04004371 RID: 17265
		private static readonly IntPtr NativeMethodInfoPtr_get_unitType_Public_get_UnitType_0;

		// Token: 0x04004372 RID: 17266
		private static readonly IntPtr NativeMethodInfoPtr_set_unitType_Protected_set_Void_UnitType_0;

		// Token: 0x04004373 RID: 17267
		private static readonly IntPtr NativeMethodInfoPtr_get_PausingFreezesTime_Public_get_Boolean_0;

		// Token: 0x04004374 RID: 17268
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04004375 RID: 17269
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04004376 RID: 17270
		private static readonly IntPtr NativeMethodInfoPtr_ApplyDisplaySettings_Public_Void_DisplaySettings_0;

		// Token: 0x04004377 RID: 17271
		private static readonly IntPtr NativeMethodInfoPtr_MoveMainWindowTo_Private_Void_DisplayInfo_0;

		// Token: 0x04004378 RID: 17272
		private static readonly IntPtr NativeMethodInfoPtr_ReloadGraphicsSettings_Public_Void_0;

		// Token: 0x04004379 RID: 17273
		private static readonly IntPtr NativeMethodInfoPtr_ApplyGraphicsSettings_Public_Void_GraphicsSettings_0;

		// Token: 0x0400437A RID: 17274
		private static readonly IntPtr NativeMethodInfoPtr_ReloadAudioSettings_Public_Void_0;

		// Token: 0x0400437B RID: 17275
		private static readonly IntPtr NativeMethodInfoPtr_ApplyAudioSettings_Public_Void_AudioSettings_0;

		// Token: 0x0400437C RID: 17276
		private static readonly IntPtr NativeMethodInfoPtr_ReloadInputSettings_Public_Void_0;

		// Token: 0x0400437D RID: 17277
		private static readonly IntPtr NativeMethodInfoPtr_ApplyInputSettings_Public_Void_InputSettings_0;

		// Token: 0x0400437E RID: 17278
		private static readonly IntPtr NativeMethodInfoPtr_WriteDisplaySettings_Public_Void_DisplaySettings_0;

		// Token: 0x0400437F RID: 17279
		private static readonly IntPtr NativeMethodInfoPtr_ReadDisplaySettings_Public_DisplaySettings_0;

		// Token: 0x04004380 RID: 17280
		private static readonly IntPtr NativeMethodInfoPtr_WriteGraphicsSettings_Public_Void_GraphicsSettings_0;

		// Token: 0x04004381 RID: 17281
		private static readonly IntPtr NativeMethodInfoPtr_ReadGraphicsSettings_Public_GraphicsSettings_0;

		// Token: 0x04004382 RID: 17282
		private static readonly IntPtr NativeMethodInfoPtr_WriteAudioSettings_Public_Void_AudioSettings_0;

		// Token: 0x04004383 RID: 17283
		private static readonly IntPtr NativeMethodInfoPtr_ReadAudioSettings_Public_AudioSettings_0;

		// Token: 0x04004384 RID: 17284
		private static readonly IntPtr NativeMethodInfoPtr_WriteInputSettings_Public_Void_InputSettings_0;

		// Token: 0x04004385 RID: 17285
		private static readonly IntPtr NativeMethodInfoPtr_ReadInputSettings_Public_InputSettings_0;

		// Token: 0x04004386 RID: 17286
		private static readonly IntPtr NativeMethodInfoPtr_GetActionControlPath_Public_String_String_0;

		// Token: 0x04004387 RID: 17287
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A25 RID: 2597
		[OriginalName("Assembly-CSharp.dll", "", "UnitType")]
		public enum UnitType
		{
			// Token: 0x04008BD0 RID: 35792
			Metric,
			// Token: 0x04008BD1 RID: 35793
			Imperial
		}
	}
}
