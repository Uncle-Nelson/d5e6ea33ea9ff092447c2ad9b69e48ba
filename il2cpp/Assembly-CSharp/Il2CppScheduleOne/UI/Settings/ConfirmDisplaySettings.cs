using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x02000687 RID: 1671
	public class ConfirmDisplaySettings : MonoBehaviour
	{
		// Token: 0x060095AF RID: 38319 RVA: 0x00265FB0 File Offset: 0x002641B0
		// Note: this type is marked as 'beforefieldinit'.
		static ConfirmDisplaySettings()
		{
			Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "ConfirmDisplaySettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr);
			ConfirmDisplaySettings.NativeFieldInfoPtr_RevertTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, "RevertTime");
			ConfirmDisplaySettings.NativeFieldInfoPtr_SubtitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, "SubtitleLabel");
			ConfirmDisplaySettings.NativeFieldInfoPtr_timeUntilRevert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, "timeUntilRevert");
			ConfirmDisplaySettings.NativeFieldInfoPtr_oldSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, "oldSettings");
			ConfirmDisplaySettings.NativeFieldInfoPtr_newSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, "newSettings");
			ConfirmDisplaySettings.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, 100681795);
			ConfirmDisplaySettings.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, 100681796);
			ConfirmDisplaySettings.NativeMethodInfoPtr_Open_Public_Void_DisplaySettings_DisplaySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, 100681797);
			ConfirmDisplaySettings.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, 100681798);
			ConfirmDisplaySettings.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, 100681799);
			ConfirmDisplaySettings.NativeMethodInfoPtr_Close_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, 100681800);
			ConfirmDisplaySettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, 100681801);
		}

		// Token: 0x17002DFF RID: 11775
		// (get) Token: 0x060095B0 RID: 38320 RVA: 0x002660D0 File Offset: 0x002642D0
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269061, XrefRangeEnd = 269071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmDisplaySettings.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060095B1 RID: 38321 RVA: 0x0026610C File Offset: 0x0026430C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269071, XrefRangeEnd = 269084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmDisplaySettings.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095B2 RID: 38322 RVA: 0x00266140 File Offset: 0x00264340
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 269094, RefRangeEnd = 269095, XrefRangeStart = 269084, XrefRangeEnd = 269094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(DisplaySettings _oldSettings, DisplaySettings _newSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _oldSettings;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _newSettings;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmDisplaySettings.NativeMethodInfoPtr_Open_Public_Void_DisplaySettings_DisplaySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095B3 RID: 38323 RVA: 0x0026618C File Offset: 0x0026438C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269095, XrefRangeEnd = 269107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmDisplaySettings.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095B4 RID: 38324 RVA: 0x002661D0 File Offset: 0x002643D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269107, XrefRangeEnd = 269115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmDisplaySettings.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095B5 RID: 38325 RVA: 0x00266204 File Offset: 0x00264404
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 269141, RefRangeEnd = 269144, XrefRangeStart = 269115, XrefRangeEnd = 269141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool revert)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref revert;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmDisplaySettings.NativeMethodInfoPtr_Close_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095B6 RID: 38326 RVA: 0x00266244 File Offset: 0x00264444
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfirmDisplaySettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmDisplaySettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095B7 RID: 38327 RVA: 0x00048C5E File Offset: 0x00046E5E
		public ConfirmDisplaySettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DFA RID: 11770
		// (get) Token: 0x060095B8 RID: 38328 RVA: 0x00266280 File Offset: 0x00264480
		// (set) Token: 0x060095B9 RID: 38329 RVA: 0x00048C67 File Offset: 0x00046E67
		public unsafe static float RevertTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ConfirmDisplaySettings.NativeFieldInfoPtr_RevertTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConfirmDisplaySettings.NativeFieldInfoPtr_RevertTime, (void*)(&value));
			}
		}

		// Token: 0x17002DFB RID: 11771
		// (get) Token: 0x060095BA RID: 38330 RVA: 0x0026629C File Offset: 0x0026449C
		// (set) Token: 0x060095BB RID: 38331 RVA: 0x00048C75 File Offset: 0x00046E75
		public unsafe TextMeshProUGUI SubtitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDisplaySettings.NativeFieldInfoPtr_SubtitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDisplaySettings.NativeFieldInfoPtr_SubtitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DFC RID: 11772
		// (get) Token: 0x060095BC RID: 38332 RVA: 0x002662CC File Offset: 0x002644CC
		// (set) Token: 0x060095BD RID: 38333 RVA: 0x00048C94 File Offset: 0x00046E94
		public unsafe float timeUntilRevert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDisplaySettings.NativeFieldInfoPtr_timeUntilRevert);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDisplaySettings.NativeFieldInfoPtr_timeUntilRevert)) = value;
			}
		}

		// Token: 0x17002DFD RID: 11773
		// (get) Token: 0x060095BE RID: 38334 RVA: 0x002662F4 File Offset: 0x002644F4
		// (set) Token: 0x060095BF RID: 38335 RVA: 0x00048CAF File Offset: 0x00046EAF
		public unsafe DisplaySettings oldSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDisplaySettings.NativeFieldInfoPtr_oldSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDisplaySettings.NativeFieldInfoPtr_oldSettings)) = value;
			}
		}

		// Token: 0x17002DFE RID: 11774
		// (get) Token: 0x060095C0 RID: 38336 RVA: 0x0026631C File Offset: 0x0026451C
		// (set) Token: 0x060095C1 RID: 38337 RVA: 0x00048CCA File Offset: 0x00046ECA
		public unsafe DisplaySettings newSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDisplaySettings.NativeFieldInfoPtr_newSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDisplaySettings.NativeFieldInfoPtr_newSettings)) = value;
			}
		}

		// Token: 0x040064EF RID: 25839
		private static readonly IntPtr NativeFieldInfoPtr_RevertTime;

		// Token: 0x040064F0 RID: 25840
		private static readonly IntPtr NativeFieldInfoPtr_SubtitleLabel;

		// Token: 0x040064F1 RID: 25841
		private static readonly IntPtr NativeFieldInfoPtr_timeUntilRevert;

		// Token: 0x040064F2 RID: 25842
		private static readonly IntPtr NativeFieldInfoPtr_oldSettings;

		// Token: 0x040064F3 RID: 25843
		private static readonly IntPtr NativeFieldInfoPtr_newSettings;

		// Token: 0x040064F4 RID: 25844
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040064F5 RID: 25845
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x040064F6 RID: 25846
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_DisplaySettings_DisplaySettings_0;

		// Token: 0x040064F7 RID: 25847
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0;

		// Token: 0x040064F8 RID: 25848
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040064F9 RID: 25849
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_Boolean_0;

		// Token: 0x040064FA RID: 25850
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
