using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Management.UI;
using Il2CppScheduleOne.Tools;
using Il2CppScheduleOne.UI.Management;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003A4 RID: 932
	public class ManagementInterface : Singleton<ManagementInterface>
	{
		// Token: 0x060048F5 RID: 18677 RVA: 0x00164550 File Offset: 0x00162750
		// Note: this type is marked as 'beforefieldinit'.
		static ManagementInterface()
		{
			Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ManagementInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr);
			ManagementInterface.NativeFieldInfoPtr_PANEL_SLIDE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "PANEL_SLIDE_TIME");
			ManagementInterface.NativeFieldInfoPtr__EquippedClipboard_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "<EquippedClipboard>k__BackingField");
			ManagementInterface.NativeFieldInfoPtr_NothingSelectedLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "NothingSelectedLabel");
			ManagementInterface.NativeFieldInfoPtr_DifferentTypesSelectedLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "DifferentTypesSelectedLabel");
			ManagementInterface.NativeFieldInfoPtr_PanelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "PanelContainer");
			ManagementInterface.NativeFieldInfoPtr_MainScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "MainScreen");
			ManagementInterface.NativeFieldInfoPtr_ItemSelectorScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "ItemSelectorScreen");
			ManagementInterface.NativeFieldInfoPtr_NPCSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "NPCSelector");
			ManagementInterface.NativeFieldInfoPtr_ObjectSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "ObjectSelector");
			ManagementInterface.NativeFieldInfoPtr_RecipeSelectorScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "RecipeSelectorScreen");
			ManagementInterface.NativeFieldInfoPtr_TransitEntitySelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "TransitEntitySelector");
			ManagementInterface.NativeFieldInfoPtr_ConfigPanelPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "ConfigPanelPrefabs");
			ManagementInterface.NativeFieldInfoPtr_Configurables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "Configurables");
			ManagementInterface.NativeFieldInfoPtr_areConfigurablesUniform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "areConfigurablesUniform");
			ManagementInterface.NativeFieldInfoPtr_loadedPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "loadedPanel");
			ManagementInterface.NativeMethodInfoPtr_get_EquippedClipboard_Public_get_ManagementClipboard_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100672342);
			ManagementInterface.NativeMethodInfoPtr_set_EquippedClipboard_Protected_set_Void_ManagementClipboard_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100672343);
			ManagementInterface.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100672344);
			ManagementInterface.NativeMethodInfoPtr_Open_Public_Void_List_1_IConfigurable_ManagementClipboard_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100672345);
			ManagementInterface.NativeMethodInfoPtr_Close_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100672346);
			ManagementInterface.NativeMethodInfoPtr_UpdateMainLabels_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100672347);
			ManagementInterface.NativeMethodInfoPtr_InitializeConfigPanel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100672348);
			ManagementInterface.NativeMethodInfoPtr_DestroyConfigPanel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100672349);
			ManagementInterface.NativeMethodInfoPtr_GetConfigPanelPrefab_Public_ConfigPanel_EConfigurableType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100672350);
			ManagementInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100672351);
		}

		// Token: 0x170015F2 RID: 5618
		// (get) Token: 0x060048F6 RID: 18678 RVA: 0x00164774 File Offset: 0x00162974
		// (set) Token: 0x060048F7 RID: 18679 RVA: 0x001647B4 File Offset: 0x001629B4
		public unsafe ManagementClipboard_Equippable EquippedClipboard
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19637, RefRangeEnd = 19640, XrefRangeStart = 19637, XrefRangeEnd = 19640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr_get_EquippedClipboard_Public_get_ManagementClipboard_Equippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ManagementClipboard_Equippable>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19641, RefRangeEnd = 19644, XrefRangeStart = 19641, XrefRangeEnd = 19644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr_set_EquippedClipboard_Protected_set_Void_ManagementClipboard_Equippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060048F8 RID: 18680 RVA: 0x001647F8 File Offset: 0x001629F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162912, XrefRangeEnd = 162915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagementInterface.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048F9 RID: 18681 RVA: 0x00164834 File Offset: 0x00162A34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 162952, RefRangeEnd = 162953, XrefRangeStart = 162915, XrefRangeEnd = 162952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(List<IConfigurable> configurables, ManagementClipboard_Equippable _equippedClipboard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configurables);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_equippedClipboard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr_Open_Public_Void_List_1_IConfigurable_ManagementClipboard_Equippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048FA RID: 18682 RVA: 0x00164888 File Offset: 0x00162A88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 162966, RefRangeEnd = 162967, XrefRangeStart = 162953, XrefRangeEnd = 162966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool preserveState = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref preserveState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr_Close_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048FB RID: 18683 RVA: 0x001648C8 File Offset: 0x00162AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162967, XrefRangeEnd = 162973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMainLabels()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr_UpdateMainLabels_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048FC RID: 18684 RVA: 0x001648FC File Offset: 0x00162AFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 163034, RefRangeEnd = 163035, XrefRangeStart = 162973, XrefRangeEnd = 163034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeConfigPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr_InitializeConfigPanel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048FD RID: 18685 RVA: 0x00164930 File Offset: 0x00162B30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 163044, RefRangeEnd = 163046, XrefRangeStart = 163035, XrefRangeEnd = 163044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyConfigPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr_DestroyConfigPanel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048FE RID: 18686 RVA: 0x00164964 File Offset: 0x00162B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163046, XrefRangeEnd = 163059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigPanel GetConfigPanelPrefab(EConfigurableType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr_GetConfigPanelPrefab_Public_ConfigPanel_EConfigurableType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigPanel>(intPtr3) : null;
		}

		// Token: 0x060048FF RID: 18687 RVA: 0x001649B0 File Offset: 0x00162BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163059, XrefRangeEnd = 163069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManagementInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004900 RID: 18688 RVA: 0x000232B0 File Offset: 0x000214B0
		public ManagementInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015E3 RID: 5603
		// (get) Token: 0x06004901 RID: 18689 RVA: 0x001649EC File Offset: 0x00162BEC
		// (set) Token: 0x06004902 RID: 18690 RVA: 0x000232B9 File Offset: 0x000214B9
		public unsafe static float PANEL_SLIDE_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ManagementInterface.NativeFieldInfoPtr_PANEL_SLIDE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManagementInterface.NativeFieldInfoPtr_PANEL_SLIDE_TIME, (void*)(&value));
			}
		}

		// Token: 0x170015E4 RID: 5604
		// (get) Token: 0x06004903 RID: 18691 RVA: 0x00164A08 File Offset: 0x00162C08
		// (set) Token: 0x06004904 RID: 18692 RVA: 0x000232C7 File Offset: 0x000214C7
		public unsafe ManagementClipboard_Equippable _EquippedClipboard_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr__EquippedClipboard_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagementClipboard_Equippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr__EquippedClipboard_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015E5 RID: 5605
		// (get) Token: 0x06004905 RID: 18693 RVA: 0x00164A38 File Offset: 0x00162C38
		// (set) Token: 0x06004906 RID: 18694 RVA: 0x000232E6 File Offset: 0x000214E6
		public unsafe TextMeshProUGUI NothingSelectedLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_NothingSelectedLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_NothingSelectedLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015E6 RID: 5606
		// (get) Token: 0x06004907 RID: 18695 RVA: 0x00164A68 File Offset: 0x00162C68
		// (set) Token: 0x06004908 RID: 18696 RVA: 0x00023305 File Offset: 0x00021505
		public unsafe TextMeshProUGUI DifferentTypesSelectedLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_DifferentTypesSelectedLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_DifferentTypesSelectedLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015E7 RID: 5607
		// (get) Token: 0x06004909 RID: 18697 RVA: 0x00164A98 File Offset: 0x00162C98
		// (set) Token: 0x0600490A RID: 18698 RVA: 0x00023324 File Offset: 0x00021524
		public unsafe RectTransform PanelContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_PanelContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_PanelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015E8 RID: 5608
		// (get) Token: 0x0600490B RID: 18699 RVA: 0x00164AC8 File Offset: 0x00162CC8
		// (set) Token: 0x0600490C RID: 18700 RVA: 0x00023343 File Offset: 0x00021543
		public unsafe ClipboardScreen MainScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_MainScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClipboardScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_MainScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015E9 RID: 5609
		// (get) Token: 0x0600490D RID: 18701 RVA: 0x00164AF8 File Offset: 0x00162CF8
		// (set) Token: 0x0600490E RID: 18702 RVA: 0x00023362 File Offset: 0x00021562
		public unsafe ItemSelector ItemSelectorScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_ItemSelectorScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_ItemSelectorScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015EA RID: 5610
		// (get) Token: 0x0600490F RID: 18703 RVA: 0x00164B28 File Offset: 0x00162D28
		// (set) Token: 0x06004910 RID: 18704 RVA: 0x00023381 File Offset: 0x00021581
		public unsafe NPCSelector NPCSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_NPCSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_NPCSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015EB RID: 5611
		// (get) Token: 0x06004911 RID: 18705 RVA: 0x00164B58 File Offset: 0x00162D58
		// (set) Token: 0x06004912 RID: 18706 RVA: 0x000233A0 File Offset: 0x000215A0
		public unsafe Il2CppScheduleOne.UI.Management.ObjectSelector ObjectSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_ObjectSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.UI.Management.ObjectSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_ObjectSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015EC RID: 5612
		// (get) Token: 0x06004913 RID: 18707 RVA: 0x00164B88 File Offset: 0x00162D88
		// (set) Token: 0x06004914 RID: 18708 RVA: 0x000233BF File Offset: 0x000215BF
		public unsafe RecipeSelector RecipeSelectorScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_RecipeSelectorScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RecipeSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_RecipeSelectorScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015ED RID: 5613
		// (get) Token: 0x06004915 RID: 18709 RVA: 0x00164BB8 File Offset: 0x00162DB8
		// (set) Token: 0x06004916 RID: 18710 RVA: 0x000233DE File Offset: 0x000215DE
		public unsafe TransitEntitySelector TransitEntitySelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_TransitEntitySelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransitEntitySelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_TransitEntitySelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015EE RID: 5614
		// (get) Token: 0x06004917 RID: 18711 RVA: 0x00164BE8 File Offset: 0x00162DE8
		// (set) Token: 0x06004918 RID: 18712 RVA: 0x000233FD File Offset: 0x000215FD
		public unsafe Il2CppReferenceArray<ManagementInterface.ConfigurableTypePanel> ConfigPanelPrefabs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_ConfigPanelPrefabs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ManagementInterface.ConfigurableTypePanel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_ConfigPanelPrefabs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015EF RID: 5615
		// (get) Token: 0x06004919 RID: 18713 RVA: 0x00164C18 File Offset: 0x00162E18
		// (set) Token: 0x0600491A RID: 18714 RVA: 0x0002341C File Offset: 0x0002161C
		public unsafe List<IConfigurable> Configurables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_Configurables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IConfigurable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_Configurables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015F0 RID: 5616
		// (get) Token: 0x0600491B RID: 18715 RVA: 0x00164C48 File Offset: 0x00162E48
		// (set) Token: 0x0600491C RID: 18716 RVA: 0x0002343B File Offset: 0x0002163B
		public unsafe bool areConfigurablesUniform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_areConfigurablesUniform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_areConfigurablesUniform)) = value;
			}
		}

		// Token: 0x170015F1 RID: 5617
		// (get) Token: 0x0600491D RID: 18717 RVA: 0x00164C70 File Offset: 0x00162E70
		// (set) Token: 0x0600491E RID: 18718 RVA: 0x00023456 File Offset: 0x00021656
		public unsafe ConfigPanel loadedPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_loadedPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_loadedPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003138 RID: 12600
		private static readonly IntPtr NativeFieldInfoPtr_PANEL_SLIDE_TIME;

		// Token: 0x04003139 RID: 12601
		private static readonly IntPtr NativeFieldInfoPtr__EquippedClipboard_k__BackingField;

		// Token: 0x0400313A RID: 12602
		private static readonly IntPtr NativeFieldInfoPtr_NothingSelectedLabel;

		// Token: 0x0400313B RID: 12603
		private static readonly IntPtr NativeFieldInfoPtr_DifferentTypesSelectedLabel;

		// Token: 0x0400313C RID: 12604
		private static readonly IntPtr NativeFieldInfoPtr_PanelContainer;

		// Token: 0x0400313D RID: 12605
		private static readonly IntPtr NativeFieldInfoPtr_MainScreen;

		// Token: 0x0400313E RID: 12606
		private static readonly IntPtr NativeFieldInfoPtr_ItemSelectorScreen;

		// Token: 0x0400313F RID: 12607
		private static readonly IntPtr NativeFieldInfoPtr_NPCSelector;

		// Token: 0x04003140 RID: 12608
		private static readonly IntPtr NativeFieldInfoPtr_ObjectSelector;

		// Token: 0x04003141 RID: 12609
		private static readonly IntPtr NativeFieldInfoPtr_RecipeSelectorScreen;

		// Token: 0x04003142 RID: 12610
		private static readonly IntPtr NativeFieldInfoPtr_TransitEntitySelector;

		// Token: 0x04003143 RID: 12611
		private static readonly IntPtr NativeFieldInfoPtr_ConfigPanelPrefabs;

		// Token: 0x04003144 RID: 12612
		private static readonly IntPtr NativeFieldInfoPtr_Configurables;

		// Token: 0x04003145 RID: 12613
		private static readonly IntPtr NativeFieldInfoPtr_areConfigurablesUniform;

		// Token: 0x04003146 RID: 12614
		private static readonly IntPtr NativeFieldInfoPtr_loadedPanel;

		// Token: 0x04003147 RID: 12615
		private static readonly IntPtr NativeMethodInfoPtr_get_EquippedClipboard_Public_get_ManagementClipboard_Equippable_0;

		// Token: 0x04003148 RID: 12616
		private static readonly IntPtr NativeMethodInfoPtr_set_EquippedClipboard_Protected_set_Void_ManagementClipboard_Equippable_0;

		// Token: 0x04003149 RID: 12617
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400314A RID: 12618
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_List_1_IConfigurable_ManagementClipboard_Equippable_0;

		// Token: 0x0400314B RID: 12619
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_Boolean_0;

		// Token: 0x0400314C RID: 12620
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMainLabels_Private_Void_0;

		// Token: 0x0400314D RID: 12621
		private static readonly IntPtr NativeMethodInfoPtr_InitializeConfigPanel_Private_Void_0;

		// Token: 0x0400314E RID: 12622
		private static readonly IntPtr NativeMethodInfoPtr_DestroyConfigPanel_Private_Void_0;

		// Token: 0x0400314F RID: 12623
		private static readonly IntPtr NativeMethodInfoPtr_GetConfigPanelPrefab_Public_ConfigPanel_EConfigurableType_0;

		// Token: 0x04003150 RID: 12624
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200097C RID: 2428
		[Serializable]
		public class ConfigurableTypePanel : Il2CppSystem.Object
		{
			// Token: 0x0600C9EE RID: 51694 RVA: 0x0030DCF4 File Offset: 0x0030BEF4
			// Note: this type is marked as 'beforefieldinit'.
			static ConfigurableTypePanel()
			{
				Il2CppClassPointerStore<ManagementInterface.ConfigurableTypePanel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "ConfigurableTypePanel");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementInterface.ConfigurableTypePanel>.NativeClassPtr);
				ManagementInterface.ConfigurableTypePanel.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface.ConfigurableTypePanel>.NativeClassPtr, "Type");
				ManagementInterface.ConfigurableTypePanel.NativeFieldInfoPtr_Panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface.ConfigurableTypePanel>.NativeClassPtr, "Panel");
				ManagementInterface.ConfigurableTypePanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface.ConfigurableTypePanel>.NativeClassPtr, 100672352);
			}

			// Token: 0x0600C9EF RID: 51695 RVA: 0x0030DD5C File Offset: 0x0030BF5C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConfigurableTypePanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementInterface.ConfigurableTypePanel>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.ConfigurableTypePanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C9F0 RID: 51696 RVA: 0x00062312 File Offset: 0x00060512
			public ConfigurableTypePanel(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EF3 RID: 16115
			// (get) Token: 0x0600C9F1 RID: 51697 RVA: 0x0030DD98 File Offset: 0x0030BF98
			// (set) Token: 0x0600C9F2 RID: 51698 RVA: 0x0006231B File Offset: 0x0006051B
			public unsafe EConfigurableType Type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.ConfigurableTypePanel.NativeFieldInfoPtr_Type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.ConfigurableTypePanel.NativeFieldInfoPtr_Type)) = value;
				}
			}

			// Token: 0x17003EF4 RID: 16116
			// (get) Token: 0x0600C9F3 RID: 51699 RVA: 0x0030DDC0 File Offset: 0x0030BFC0
			// (set) Token: 0x0600C9F4 RID: 51700 RVA: 0x00062336 File Offset: 0x00060536
			public unsafe ConfigPanel Panel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.ConfigurableTypePanel.NativeFieldInfoPtr_Panel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.ConfigurableTypePanel.NativeFieldInfoPtr_Panel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040088A3 RID: 34979
			private static readonly IntPtr NativeFieldInfoPtr_Type;

			// Token: 0x040088A4 RID: 34980
			private static readonly IntPtr NativeFieldInfoPtr_Panel;

			// Token: 0x040088A5 RID: 34981
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200097D RID: 2429
		[ObfuscatedName("ScheduleOne.Management.ManagementInterface+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C9F5 RID: 51701 RVA: 0x0030DDF0 File Offset: 0x0030BFF0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ManagementInterface.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementInterface.__c>.NativeClassPtr);
				ManagementInterface.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface.__c>.NativeClassPtr, "<>9");
				ManagementInterface.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface.__c>.NativeClassPtr, "<>9__23_0");
				ManagementInterface.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface.__c>.NativeClassPtr, 100672354);
				ManagementInterface.__c.NativeMethodInfoPtr__InitializeConfigPanel_b__23_0_Internal_EntityConfiguration_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface.__c>.NativeClassPtr, 100672355);
			}

			// Token: 0x0600C9F6 RID: 51702 RVA: 0x0030DE6C File Offset: 0x0030C06C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementInterface.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C9F7 RID: 51703 RVA: 0x0030DEA8 File Offset: 0x0030C0A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162908, XrefRangeEnd = 162912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EntityConfiguration _InitializeConfigPanel_b__23_0(IConfigurable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.__c.NativeMethodInfoPtr__InitializeConfigPanel_b__23_0_Internal_EntityConfiguration_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityConfiguration>(intPtr3) : null;
			}

			// Token: 0x0600C9F8 RID: 51704 RVA: 0x00062355 File Offset: 0x00060555
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EF5 RID: 16117
			// (get) Token: 0x0600C9F9 RID: 51705 RVA: 0x0030DEF8 File Offset: 0x0030C0F8
			// (set) Token: 0x0600C9FA RID: 51706 RVA: 0x0006235E File Offset: 0x0006055E
			public unsafe static ManagementInterface.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ManagementInterface.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagementInterface.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ManagementInterface.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EF6 RID: 16118
			// (get) Token: 0x0600C9FB RID: 51707 RVA: 0x0030DF20 File Offset: 0x0030C120
			// (set) Token: 0x0600C9FC RID: 51708 RVA: 0x00062370 File Offset: 0x00060570
			public unsafe static Func<IConfigurable, EntityConfiguration> __9__23_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ManagementInterface.__c.NativeFieldInfoPtr___9__23_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IConfigurable, EntityConfiguration>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ManagementInterface.__c.NativeFieldInfoPtr___9__23_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040088A6 RID: 34982
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040088A7 RID: 34983
			private static readonly IntPtr NativeFieldInfoPtr___9__23_0;

			// Token: 0x040088A8 RID: 34984
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040088A9 RID: 34985
			private static readonly IntPtr NativeMethodInfoPtr__InitializeConfigPanel_b__23_0_Internal_EntityConfiguration_IConfigurable_0;
		}

		// Token: 0x0200097E RID: 2430
		[ObfuscatedName("ScheduleOne.Management.ManagementInterface+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C9FD RID: 51709 RVA: 0x0030DF48 File Offset: 0x0030C148
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<ManagementInterface.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementInterface.__c__DisplayClass25_0>.NativeClassPtr);
				ManagementInterface.__c__DisplayClass25_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface.__c__DisplayClass25_0>.NativeClassPtr, "type");
				ManagementInterface.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface.__c__DisplayClass25_0>.NativeClassPtr, 100672356);
				ManagementInterface.__c__DisplayClass25_0.NativeMethodInfoPtr__GetConfigPanelPrefab_b__0_Internal_Boolean_ConfigurableTypePanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface.__c__DisplayClass25_0>.NativeClassPtr, 100672357);
			}

			// Token: 0x0600C9FE RID: 51710 RVA: 0x0030DFB0 File Offset: 0x0030C1B0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementInterface.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C9FF RID: 51711 RVA: 0x0030DFEC File Offset: 0x0030C1EC
			[CallerCount(0)]
			public unsafe bool _GetConfigPanelPrefab_b__0(ManagementInterface.ConfigurableTypePanel x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.__c__DisplayClass25_0.NativeMethodInfoPtr__GetConfigPanelPrefab_b__0_Internal_Boolean_ConfigurableTypePanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CA00 RID: 51712 RVA: 0x00062382 File Offset: 0x00060582
			public __c__DisplayClass25_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EF7 RID: 16119
			// (get) Token: 0x0600CA01 RID: 51713 RVA: 0x0030E03C File Offset: 0x0030C23C
			// (set) Token: 0x0600CA02 RID: 51714 RVA: 0x0006238B File Offset: 0x0006058B
			public unsafe EConfigurableType type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.__c__DisplayClass25_0.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.__c__DisplayClass25_0.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x040088AA RID: 34986
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x040088AB RID: 34987
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040088AC RID: 34988
			private static readonly IntPtr NativeMethodInfoPtr__GetConfigPanelPrefab_b__0_Internal_Boolean_ConfigurableTypePanel_0;
		}
	}
}
