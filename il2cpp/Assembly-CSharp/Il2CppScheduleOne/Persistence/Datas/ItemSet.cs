using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000257 RID: 599
	[Serializable]
	public class ItemSet : Object
	{
		// Token: 0x06002EA5 RID: 11941 RVA: 0x001056EC File Offset: 0x001038EC
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSet()
		{
			Il2CppClassPointerStore<ItemSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ItemSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSet>.NativeClassPtr);
			ItemSet.NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, "Items");
			ItemSet.NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, 100668720);
			ItemSet.NativeMethodInfoPtr_GetJSON_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, 100668721);
			ItemSet.NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, 100668722);
			ItemSet.NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, 100668723);
			ItemSet.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, 100668724);
			ItemSet.NativeMethodInfoPtr_Deserialize_Public_Static_Il2CppReferenceArray_1_ItemInstance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, 100668725);
		}

		// Token: 0x06002EA6 RID: 11942 RVA: 0x001057A8 File Offset: 0x001039A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130394, XrefRangeEnd = 130405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSet(List<ItemData> items) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSet>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSet.NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EA7 RID: 11943 RVA: 0x001057F4 File Offset: 0x001039F4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 130406, RefRangeEnd = 130410, XrefRangeStart = 130405, XrefRangeEnd = 130406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetJSON()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSet.NativeMethodInfoPtr_GetJSON_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002EA8 RID: 11944 RVA: 0x0010582C File Offset: 0x00103A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130410, XrefRangeEnd = 130421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSet(List<ItemInstance> items) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSet>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSet.NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EA9 RID: 11945 RVA: 0x00105878 File Offset: 0x00103A78
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 130442, RefRangeEnd = 130466, XrefRangeStart = 130421, XrefRangeEnd = 130442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSet(List<ItemSlot> itemSlots) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSet>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemSlots);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSet.NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EAA RID: 11946 RVA: 0x001058C4 File Offset: 0x00103AC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130481, RefRangeEnd = 130483, XrefRangeStart = 130466, XrefRangeEnd = 130481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSet(Il2CppReferenceArray<ItemSlot> itemSlots) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSet>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemSlots);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSet.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EAB RID: 11947 RVA: 0x00105910 File Offset: 0x00103B10
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 130493, RefRangeEnd = 130497, XrefRangeStart = 130483, XrefRangeEnd = 130493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<ItemInstance> Deserialize(string json)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSet.NativeMethodInfoPtr_Deserialize_Public_Static_Il2CppReferenceArray_1_ItemInstance_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemInstance>>(intPtr3) : null;
		}

		// Token: 0x06002EAC RID: 11948 RVA: 0x00018A07 File Offset: 0x00016C07
		public ItemSet(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x06002EAD RID: 11949 RVA: 0x00105954 File Offset: 0x00103B54
		// (set) Token: 0x06002EAE RID: 11950 RVA: 0x00018A10 File Offset: 0x00016C10
		public unsafe Il2CppStringArray Items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSet.NativeFieldInfoPtr_Items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSet.NativeFieldInfoPtr_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001EE3 RID: 7907
		private static readonly IntPtr NativeFieldInfoPtr_Items;

		// Token: 0x04001EE4 RID: 7908
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemData_0;

		// Token: 0x04001EE5 RID: 7909
		private static readonly IntPtr NativeMethodInfoPtr_GetJSON_Public_String_0;

		// Token: 0x04001EE6 RID: 7910
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemInstance_0;

		// Token: 0x04001EE7 RID: 7911
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemSlot_0;

		// Token: 0x04001EE8 RID: 7912
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_ItemSlot_0;

		// Token: 0x04001EE9 RID: 7913
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_Il2CppReferenceArray_1_ItemInstance_String_0;
	}
}
