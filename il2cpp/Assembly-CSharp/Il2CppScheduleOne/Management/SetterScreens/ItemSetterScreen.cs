using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Management.Presets.Options;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Management.SetterScreens
{
	// Token: 0x020003AB RID: 939
	public class ItemSetterScreen : Singleton<ItemSetterScreen>
	{
		// Token: 0x0600495E RID: 18782 RVA: 0x00165B30 File Offset: 0x00163D30
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSetterScreen()
		{
			Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management.SetterScreens", "ItemSetterScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr);
			ItemSetterScreen.NativeFieldInfoPtr__Option_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, "<Option>k__BackingField");
			ItemSetterScreen.NativeFieldInfoPtr_ListEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, "ListEntryPrefab");
			ItemSetterScreen.NativeFieldInfoPtr_EntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, "EntryContainer");
			ItemSetterScreen.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, "TitleLabel");
			ItemSetterScreen.NativeFieldInfoPtr_allEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, "allEntry");
			ItemSetterScreen.NativeFieldInfoPtr_noneEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, "noneEntry");
			ItemSetterScreen.NativeFieldInfoPtr_pairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, "pairs");
			ItemSetterScreen.NativeMethodInfoPtr_get_Option_Public_get_ItemList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672391);
			ItemSetterScreen.NativeMethodInfoPtr_set_Option_Private_set_Void_ItemList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672392);
			ItemSetterScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672393);
			ItemSetterScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672394);
			ItemSetterScreen.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_ItemList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672395);
			ItemSetterScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672396);
			ItemSetterScreen.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672397);
			ItemSetterScreen.NativeMethodInfoPtr_CreateEntry_Private_RectTransform_Sprite_String_Action_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672398);
			ItemSetterScreen.NativeMethodInfoPtr_AllClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672399);
			ItemSetterScreen.NativeMethodInfoPtr_NoneClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672400);
			ItemSetterScreen.NativeMethodInfoPtr_EntryClicked_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672401);
			ItemSetterScreen.NativeMethodInfoPtr_RefreshTicks_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672402);
			ItemSetterScreen.NativeMethodInfoPtr_SetEntryTicked_Private_Void_RectTransform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672403);
			ItemSetterScreen.NativeMethodInfoPtr_CreateEntries_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672404);
			ItemSetterScreen.NativeMethodInfoPtr_DestroyEntries_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672405);
			ItemSetterScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672406);
		}

		// Token: 0x17001608 RID: 5640
		// (get) Token: 0x0600495F RID: 18783 RVA: 0x00165D2C File Offset: 0x00163F2C
		// (set) Token: 0x06004960 RID: 18784 RVA: 0x00165D6C File Offset: 0x00163F6C
		public unsafe ItemList Option
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19637, RefRangeEnd = 19640, XrefRangeStart = 19637, XrefRangeEnd = 19640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_get_Option_Public_get_ItemList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemList>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19641, RefRangeEnd = 19644, XrefRangeStart = 19641, XrefRangeEnd = 19644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_set_Option_Private_set_Void_ItemList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001609 RID: 5641
		// (get) Token: 0x06004961 RID: 18785 RVA: 0x00165DB0 File Offset: 0x00163FB0
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 163289, RefRangeEnd = 163290, XrefRangeStart = 163289, XrefRangeEnd = 163289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004962 RID: 18786 RVA: 0x00165DEC File Offset: 0x00163FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163290, XrefRangeEnd = 163325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSetterScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004963 RID: 18787 RVA: 0x00165E28 File Offset: 0x00164028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163325, XrefRangeEnd = 163343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open(ItemList option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSetterScreen.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_ItemList_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004964 RID: 18788 RVA: 0x00165E78 File Offset: 0x00164078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163343, XrefRangeEnd = 163344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004965 RID: 18789 RVA: 0x00165EBC File Offset: 0x001640BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163344, XrefRangeEnd = 163349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSetterScreen.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004966 RID: 18790 RVA: 0x00165EF8 File Offset: 0x001640F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 163408, RefRangeEnd = 163410, XrefRangeStart = 163349, XrefRangeEnd = 163408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectTransform CreateEntry(Sprite icon, string label, Action onClick, string prefabID = "", bool createPair = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(icon);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onClick);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefabID);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createPair;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_CreateEntry_Private_RectTransform_Sprite_String_Action_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
		}

		// Token: 0x06004967 RID: 18791 RVA: 0x00165F90 File Offset: 0x00164190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163410, XrefRangeEnd = 163412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AllClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_AllClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004968 RID: 18792 RVA: 0x00165FC4 File Offset: 0x001641C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163412, XrefRangeEnd = 163416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NoneClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_NoneClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004969 RID: 18793 RVA: 0x00165FF8 File Offset: 0x001641F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163416, XrefRangeEnd = 163433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EntryClicked(string prefabID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(prefabID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_EntryClicked_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600496A RID: 18794 RVA: 0x0016603C File Offset: 0x0016423C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 163476, RefRangeEnd = 163480, XrefRangeStart = 163433, XrefRangeEnd = 163476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshTicks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_RefreshTicks_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600496B RID: 18795 RVA: 0x00166070 File Offset: 0x00164270
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 163486, RefRangeEnd = 163487, XrefRangeStart = 163480, XrefRangeEnd = 163486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEntryTicked(RectTransform entry, bool ticked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ticked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_SetEntryTicked_Private_Void_RectTransform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600496C RID: 18796 RVA: 0x001660C0 File Offset: 0x001642C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163487, XrefRangeEnd = 163496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateEntries()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_CreateEntries_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600496D RID: 18797 RVA: 0x001660F4 File Offset: 0x001642F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 163517, RefRangeEnd = 163518, XrefRangeStart = 163496, XrefRangeEnd = 163517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyEntries()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_DestroyEntries_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600496E RID: 18798 RVA: 0x00166128 File Offset: 0x00164328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163518, XrefRangeEnd = 163528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSetterScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600496F RID: 18799 RVA: 0x000235BE File Offset: 0x000217BE
		public ItemSetterScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001601 RID: 5633
		// (get) Token: 0x06004970 RID: 18800 RVA: 0x00166164 File Offset: 0x00164364
		// (set) Token: 0x06004971 RID: 18801 RVA: 0x000235C7 File Offset: 0x000217C7
		public unsafe ItemList _Option_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr__Option_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr__Option_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001602 RID: 5634
		// (get) Token: 0x06004972 RID: 18802 RVA: 0x00166194 File Offset: 0x00164394
		// (set) Token: 0x06004973 RID: 18803 RVA: 0x000235E6 File Offset: 0x000217E6
		public unsafe GameObject ListEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_ListEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_ListEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001603 RID: 5635
		// (get) Token: 0x06004974 RID: 18804 RVA: 0x001661C4 File Offset: 0x001643C4
		// (set) Token: 0x06004975 RID: 18805 RVA: 0x00023605 File Offset: 0x00021805
		public unsafe RectTransform EntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_EntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_EntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001604 RID: 5636
		// (get) Token: 0x06004976 RID: 18806 RVA: 0x001661F4 File Offset: 0x001643F4
		// (set) Token: 0x06004977 RID: 18807 RVA: 0x00023624 File Offset: 0x00021824
		public unsafe TextMeshProUGUI TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001605 RID: 5637
		// (get) Token: 0x06004978 RID: 18808 RVA: 0x00166224 File Offset: 0x00164424
		// (set) Token: 0x06004979 RID: 18809 RVA: 0x00023643 File Offset: 0x00021843
		public unsafe RectTransform allEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_allEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_allEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001606 RID: 5638
		// (get) Token: 0x0600497A RID: 18810 RVA: 0x00166254 File Offset: 0x00164454
		// (set) Token: 0x0600497B RID: 18811 RVA: 0x00023662 File Offset: 0x00021862
		public unsafe RectTransform noneEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_noneEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_noneEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001607 RID: 5639
		// (get) Token: 0x0600497C RID: 18812 RVA: 0x00166284 File Offset: 0x00164484
		// (set) Token: 0x0600497D RID: 18813 RVA: 0x00023681 File Offset: 0x00021881
		public unsafe List<ItemSetterScreen.Pair> pairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_pairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSetterScreen.Pair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_pairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400317B RID: 12667
		private static readonly IntPtr NativeFieldInfoPtr__Option_k__BackingField;

		// Token: 0x0400317C RID: 12668
		private static readonly IntPtr NativeFieldInfoPtr_ListEntryPrefab;

		// Token: 0x0400317D RID: 12669
		private static readonly IntPtr NativeFieldInfoPtr_EntryContainer;

		// Token: 0x0400317E RID: 12670
		private static readonly IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x0400317F RID: 12671
		private static readonly IntPtr NativeFieldInfoPtr_allEntry;

		// Token: 0x04003180 RID: 12672
		private static readonly IntPtr NativeFieldInfoPtr_noneEntry;

		// Token: 0x04003181 RID: 12673
		private static readonly IntPtr NativeFieldInfoPtr_pairs;

		// Token: 0x04003182 RID: 12674
		private static readonly IntPtr NativeMethodInfoPtr_get_Option_Public_get_ItemList_0;

		// Token: 0x04003183 RID: 12675
		private static readonly IntPtr NativeMethodInfoPtr_set_Option_Private_set_Void_ItemList_0;

		// Token: 0x04003184 RID: 12676
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04003185 RID: 12677
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04003186 RID: 12678
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_ItemList_0;

		// Token: 0x04003187 RID: 12679
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04003188 RID: 12680
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

		// Token: 0x04003189 RID: 12681
		private static readonly IntPtr NativeMethodInfoPtr_CreateEntry_Private_RectTransform_Sprite_String_Action_String_Boolean_0;

		// Token: 0x0400318A RID: 12682
		private static readonly IntPtr NativeMethodInfoPtr_AllClicked_Private_Void_0;

		// Token: 0x0400318B RID: 12683
		private static readonly IntPtr NativeMethodInfoPtr_NoneClicked_Private_Void_0;

		// Token: 0x0400318C RID: 12684
		private static readonly IntPtr NativeMethodInfoPtr_EntryClicked_Private_Void_String_0;

		// Token: 0x0400318D RID: 12685
		private static readonly IntPtr NativeMethodInfoPtr_RefreshTicks_Private_Void_0;

		// Token: 0x0400318E RID: 12686
		private static readonly IntPtr NativeMethodInfoPtr_SetEntryTicked_Private_Void_RectTransform_Boolean_0;

		// Token: 0x0400318F RID: 12687
		private static readonly IntPtr NativeMethodInfoPtr_CreateEntries_Private_Void_0;

		// Token: 0x04003190 RID: 12688
		private static readonly IntPtr NativeMethodInfoPtr_DestroyEntries_Private_Void_0;

		// Token: 0x04003191 RID: 12689
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000980 RID: 2432
		public class Pair : Il2CppSystem.Object
		{
			// Token: 0x0600CA03 RID: 51715 RVA: 0x0030E064 File Offset: 0x0030C264
			// Note: this type is marked as 'beforefieldinit'.
			static Pair()
			{
				Il2CppClassPointerStore<ItemSetterScreen.Pair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, "Pair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSetterScreen.Pair>.NativeClassPtr);
				ItemSetterScreen.Pair.NativeFieldInfoPtr_prefabID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen.Pair>.NativeClassPtr, "prefabID");
				ItemSetterScreen.Pair.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen.Pair>.NativeClassPtr, "entry");
				ItemSetterScreen.Pair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen.Pair>.NativeClassPtr, 100672407);
			}

			// Token: 0x0600CA04 RID: 51716 RVA: 0x0030E0CC File Offset: 0x0030C2CC
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Pair() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSetterScreen.Pair>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.Pair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA05 RID: 51717 RVA: 0x000623A6 File Offset: 0x000605A6
			public Pair(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EF8 RID: 16120
			// (get) Token: 0x0600CA06 RID: 51718 RVA: 0x0030E108 File Offset: 0x0030C308
			// (set) Token: 0x0600CA07 RID: 51719 RVA: 0x000623AF File Offset: 0x000605AF
			public unsafe string prefabID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.Pair.NativeFieldInfoPtr_prefabID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.Pair.NativeFieldInfoPtr_prefabID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003EF9 RID: 16121
			// (get) Token: 0x0600CA08 RID: 51720 RVA: 0x0030E130 File Offset: 0x0030C330
			// (set) Token: 0x0600CA09 RID: 51721 RVA: 0x000623CE File Offset: 0x000605CE
			public unsafe RectTransform entry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.Pair.NativeFieldInfoPtr_entry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.Pair.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040088B0 RID: 34992
			private static readonly IntPtr NativeFieldInfoPtr_prefabID;

			// Token: 0x040088B1 RID: 34993
			private static readonly IntPtr NativeFieldInfoPtr_entry;

			// Token: 0x040088B2 RID: 34994
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000981 RID: 2433
		[ObfuscatedName("ScheduleOne.Management.SetterScreens.ItemSetterScreen+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CA0A RID: 51722 RVA: 0x0030E160 File Offset: 0x0030C360
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass17_0>.NativeClassPtr);
				ItemSetterScreen.__c__DisplayClass17_0.NativeFieldInfoPtr_onClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass17_0>.NativeClassPtr, "onClick");
				ItemSetterScreen.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass17_0>.NativeClassPtr, 100672408);
				ItemSetterScreen.__c__DisplayClass17_0.NativeMethodInfoPtr__CreateEntry_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass17_0>.NativeClassPtr, 100672409);
			}

			// Token: 0x0600CA0B RID: 51723 RVA: 0x0030E1C8 File Offset: 0x0030C3C8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA0C RID: 51724 RVA: 0x0030E204 File Offset: 0x0030C404
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateEntry_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.__c__DisplayClass17_0.NativeMethodInfoPtr__CreateEntry_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA0D RID: 51725 RVA: 0x000623ED File Offset: 0x000605ED
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EFA RID: 16122
			// (get) Token: 0x0600CA0E RID: 51726 RVA: 0x0030E238 File Offset: 0x0030C438
			// (set) Token: 0x0600CA0F RID: 51727 RVA: 0x000623F6 File Offset: 0x000605F6
			public unsafe Action onClick
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.__c__DisplayClass17_0.NativeFieldInfoPtr_onClick);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.__c__DisplayClass17_0.NativeFieldInfoPtr_onClick), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040088B3 RID: 34995
			private static readonly IntPtr NativeFieldInfoPtr_onClick;

			// Token: 0x040088B4 RID: 34996
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040088B5 RID: 34997
			private static readonly IntPtr NativeMethodInfoPtr__CreateEntry_b__0_Internal_Void_0;
		}

		// Token: 0x02000982 RID: 2434
		[ObfuscatedName("ScheduleOne.Management.SetterScreens.ItemSetterScreen+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CA10 RID: 51728 RVA: 0x0030E268 File Offset: 0x0030C468
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass21_0>.NativeClassPtr);
				ItemSetterScreen.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass21_0>.NativeClassPtr, "<>4__this");
				ItemSetterScreen.__c__DisplayClass21_0.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass21_0>.NativeClassPtr, "i");
				ItemSetterScreen.__c__DisplayClass21_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass21_0>.NativeClassPtr, "<>9__0");
				ItemSetterScreen.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass21_0>.NativeClassPtr, 100672410);
				ItemSetterScreen.__c__DisplayClass21_0.NativeMethodInfoPtr__RefreshTicks_b__0_Internal_Boolean_Pair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass21_0>.NativeClassPtr, 100672411);
			}

			// Token: 0x0600CA11 RID: 51729 RVA: 0x0030E2F8 File Offset: 0x0030C4F8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA12 RID: 51730 RVA: 0x0030E334 File Offset: 0x0030C534
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163284, XrefRangeEnd = 163289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RefreshTicks_b__0(ItemSetterScreen.Pair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.__c__DisplayClass21_0.NativeMethodInfoPtr__RefreshTicks_b__0_Internal_Boolean_Pair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CA13 RID: 51731 RVA: 0x00062415 File Offset: 0x00060615
			public __c__DisplayClass21_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EFB RID: 16123
			// (get) Token: 0x0600CA14 RID: 51732 RVA: 0x0030E384 File Offset: 0x0030C584
			// (set) Token: 0x0600CA15 RID: 51733 RVA: 0x0006241E File Offset: 0x0006061E
			public unsafe ItemSetterScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSetterScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EFC RID: 16124
			// (get) Token: 0x0600CA16 RID: 51734 RVA: 0x0030E3B4 File Offset: 0x0030C5B4
			// (set) Token: 0x0600CA17 RID: 51735 RVA: 0x0006243D File Offset: 0x0006063D
			public unsafe int i
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.__c__DisplayClass21_0.NativeFieldInfoPtr_i);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.__c__DisplayClass21_0.NativeFieldInfoPtr_i)) = value;
				}
			}

			// Token: 0x17003EFD RID: 16125
			// (get) Token: 0x0600CA18 RID: 51736 RVA: 0x0030E3DC File Offset: 0x0030C5DC
			// (set) Token: 0x0600CA19 RID: 51737 RVA: 0x00062458 File Offset: 0x00060658
			public unsafe Predicate<ItemSetterScreen.Pair> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.__c__DisplayClass21_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<ItemSetterScreen.Pair>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.__c__DisplayClass21_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040088B6 RID: 34998
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040088B7 RID: 34999
			private static readonly IntPtr NativeFieldInfoPtr_i;

			// Token: 0x040088B8 RID: 35000
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x040088B9 RID: 35001
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040088BA RID: 35002
			private static readonly IntPtr NativeMethodInfoPtr__RefreshTicks_b__0_Internal_Boolean_Pair_0;
		}
	}
}
