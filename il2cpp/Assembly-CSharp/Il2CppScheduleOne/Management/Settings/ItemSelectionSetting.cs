using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Management.Settings
{
	// Token: 0x020003AA RID: 938
	[Serializable]
	public class ItemSelectionSetting : Object
	{
		// Token: 0x06004957 RID: 18775 RVA: 0x001659C0 File Offset: 0x00163BC0
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSelectionSetting()
		{
			Il2CppClassPointerStore<ItemSelectionSetting>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management.Settings", "ItemSelectionSetting");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSelectionSetting>.NativeClassPtr);
			ItemSelectionSetting.NativeFieldInfoPtr__SelectedItems_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelectionSetting>.NativeClassPtr, "<SelectedItems>k__BackingField");
			ItemSelectionSetting.NativeMethodInfoPtr_get_SelectedItems_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelectionSetting>.NativeClassPtr, 100672388);
			ItemSelectionSetting.NativeMethodInfoPtr_set_SelectedItems_Protected_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelectionSetting>.NativeClassPtr, 100672389);
			ItemSelectionSetting.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelectionSetting>.NativeClassPtr, 100672390);
		}

		// Token: 0x17001600 RID: 5632
		// (get) Token: 0x06004958 RID: 18776 RVA: 0x00165A40 File Offset: 0x00163C40
		// (set) Token: 0x06004959 RID: 18777 RVA: 0x00165A80 File Offset: 0x00163C80
		public unsafe List<string> SelectedItems
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 17380, RefRangeEnd = 17390, XrefRangeStart = 17380, XrefRangeEnd = 17390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelectionSetting.NativeMethodInfoPtr_get_SelectedItems_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29995, RefRangeEnd = 29997, XrefRangeStart = 29995, XrefRangeEnd = 29997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelectionSetting.NativeMethodInfoPtr_set_SelectedItems_Protected_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600495A RID: 18778 RVA: 0x00165AC4 File Offset: 0x00163CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163276, XrefRangeEnd = 163284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSelectionSetting() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSelectionSetting>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelectionSetting.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600495B RID: 18779 RVA: 0x00023596 File Offset: 0x00021796
		public ItemSelectionSetting(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015FF RID: 5631
		// (get) Token: 0x0600495C RID: 18780 RVA: 0x00165B00 File Offset: 0x00163D00
		// (set) Token: 0x0600495D RID: 18781 RVA: 0x0002359F File Offset: 0x0002179F
		public unsafe List<string> _SelectedItems_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelectionSetting.NativeFieldInfoPtr__SelectedItems_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelectionSetting.NativeFieldInfoPtr__SelectedItems_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003177 RID: 12663
		private static readonly IntPtr NativeFieldInfoPtr__SelectedItems_k__BackingField;

		// Token: 0x04003178 RID: 12664
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedItems_Public_get_List_1_String_0;

		// Token: 0x04003179 RID: 12665
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedItems_Protected_set_Void_List_1_String_0;

		// Token: 0x0400317A RID: 12666
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
