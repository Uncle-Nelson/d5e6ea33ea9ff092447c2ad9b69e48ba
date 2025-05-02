using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003A5 RID: 933
	public class ManagementItemFilter : Object
	{
		// Token: 0x0600491F RID: 18719 RVA: 0x00164CA0 File Offset: 0x00162EA0
		// Note: this type is marked as 'beforefieldinit'.
		static ManagementItemFilter()
		{
			Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ManagementItemFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr);
			ManagementItemFilter.NativeFieldInfoPtr__Mode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, "<Mode>k__BackingField");
			ManagementItemFilter.NativeFieldInfoPtr__Items_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, "<Items>k__BackingField");
			ManagementItemFilter.NativeMethodInfoPtr_get_Mode_Public_get_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100672358);
			ManagementItemFilter.NativeMethodInfoPtr_set_Mode_Private_set_Void_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100672359);
			ManagementItemFilter.NativeMethodInfoPtr_get_Items_Public_get_List_1_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100672360);
			ManagementItemFilter.NativeMethodInfoPtr_set_Items_Private_set_Void_List_1_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100672361);
			ManagementItemFilter.NativeMethodInfoPtr__ctor_Public_Void_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100672362);
			ManagementItemFilter.NativeMethodInfoPtr_SetMode_Public_Void_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100672363);
			ManagementItemFilter.NativeMethodInfoPtr_AddItem_Public_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100672364);
			ManagementItemFilter.NativeMethodInfoPtr_RemoveItem_Public_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100672365);
			ManagementItemFilter.NativeMethodInfoPtr_Contains_Public_Boolean_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100672366);
			ManagementItemFilter.NativeMethodInfoPtr_DoesItemMeetFilter_Public_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100672367);
			ManagementItemFilter.NativeMethodInfoPtr_GetDescription_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100672368);
		}

		// Token: 0x170015F5 RID: 5621
		// (get) Token: 0x06004920 RID: 18720 RVA: 0x00164DD4 File Offset: 0x00162FD4
		// (set) Token: 0x06004921 RID: 18721 RVA: 0x00164E10 File Offset: 0x00163010
		public unsafe ManagementItemFilter.EMode Mode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_get_Mode_Public_get_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 29970, RefRangeEnd = 29976, XrefRangeStart = 29970, XrefRangeEnd = 29976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_set_Mode_Private_set_Void_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015F6 RID: 5622
		// (get) Token: 0x06004922 RID: 18722 RVA: 0x00164E50 File Offset: 0x00163050
		// (set) Token: 0x06004923 RID: 18723 RVA: 0x00164E90 File Offset: 0x00163090
		public unsafe List<ItemDefinition> Items
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_get_Items_Public_get_List_1_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemDefinition>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_set_Items_Private_set_Void_List_1_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004924 RID: 18724 RVA: 0x00164ED4 File Offset: 0x001630D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 163082, RefRangeEnd = 163084, XrefRangeStart = 163069, XrefRangeEnd = 163082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManagementItemFilter(ManagementItemFilter.EMode mode) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr__ctor_Public_Void_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004925 RID: 18725 RVA: 0x00164F1C File Offset: 0x0016311C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 29970, RefRangeEnd = 29976, XrefRangeStart = 29970, XrefRangeEnd = 29976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMode(ManagementItemFilter.EMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_SetMode_Public_Void_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004926 RID: 18726 RVA: 0x00164F5C File Offset: 0x0016315C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 163090, RefRangeEnd = 163092, XrefRangeStart = 163084, XrefRangeEnd = 163090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddItem(ItemDefinition item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_AddItem_Public_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004927 RID: 18727 RVA: 0x00164FA0 File Offset: 0x001631A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163092, XrefRangeEnd = 163096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveItem(ItemDefinition item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_RemoveItem_Public_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004928 RID: 18728 RVA: 0x00164FE4 File Offset: 0x001631E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163096, XrefRangeEnd = 163100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(ItemDefinition item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_Contains_Public_Boolean_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004929 RID: 18729 RVA: 0x00165034 File Offset: 0x00163234
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 163107, RefRangeEnd = 163108, XrefRangeStart = 163100, XrefRangeEnd = 163107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesItemMeetFilter(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_DoesItemMeetFilter_Public_Boolean_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600492A RID: 18730 RVA: 0x00165084 File Offset: 0x00163284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163108, XrefRangeEnd = 163116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetDescription()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_GetDescription_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600492B RID: 18731 RVA: 0x00023475 File Offset: 0x00021675
		public ManagementItemFilter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015F3 RID: 5619
		// (get) Token: 0x0600492C RID: 18732 RVA: 0x001650BC File Offset: 0x001632BC
		// (set) Token: 0x0600492D RID: 18733 RVA: 0x0002347E File Offset: 0x0002167E
		public unsafe ManagementItemFilter.EMode _Mode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementItemFilter.NativeFieldInfoPtr__Mode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementItemFilter.NativeFieldInfoPtr__Mode_k__BackingField)) = value;
			}
		}

		// Token: 0x170015F4 RID: 5620
		// (get) Token: 0x0600492E RID: 18734 RVA: 0x001650E4 File Offset: 0x001632E4
		// (set) Token: 0x0600492F RID: 18735 RVA: 0x00023499 File Offset: 0x00021699
		public unsafe List<ItemDefinition> _Items_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementItemFilter.NativeFieldInfoPtr__Items_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementItemFilter.NativeFieldInfoPtr__Items_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003151 RID: 12625
		private static readonly IntPtr NativeFieldInfoPtr__Mode_k__BackingField;

		// Token: 0x04003152 RID: 12626
		private static readonly IntPtr NativeFieldInfoPtr__Items_k__BackingField;

		// Token: 0x04003153 RID: 12627
		private static readonly IntPtr NativeMethodInfoPtr_get_Mode_Public_get_EMode_0;

		// Token: 0x04003154 RID: 12628
		private static readonly IntPtr NativeMethodInfoPtr_set_Mode_Private_set_Void_EMode_0;

		// Token: 0x04003155 RID: 12629
		private static readonly IntPtr NativeMethodInfoPtr_get_Items_Public_get_List_1_ItemDefinition_0;

		// Token: 0x04003156 RID: 12630
		private static readonly IntPtr NativeMethodInfoPtr_set_Items_Private_set_Void_List_1_ItemDefinition_0;

		// Token: 0x04003157 RID: 12631
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EMode_0;

		// Token: 0x04003158 RID: 12632
		private static readonly IntPtr NativeMethodInfoPtr_SetMode_Public_Void_EMode_0;

		// Token: 0x04003159 RID: 12633
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Public_Void_ItemDefinition_0;

		// Token: 0x0400315A RID: 12634
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItem_Public_Void_ItemDefinition_0;

		// Token: 0x0400315B RID: 12635
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_ItemDefinition_0;

		// Token: 0x0400315C RID: 12636
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMeetFilter_Public_Boolean_ItemInstance_0;

		// Token: 0x0400315D RID: 12637
		private static readonly IntPtr NativeMethodInfoPtr_GetDescription_Public_String_0;

		// Token: 0x0200097F RID: 2431
		[OriginalName("Assembly-CSharp.dll", "", "EMode")]
		public enum EMode
		{
			// Token: 0x040088AE RID: 34990
			Whitelist,
			// Token: 0x040088AF RID: 34991
			Blacklist
		}
	}
}
