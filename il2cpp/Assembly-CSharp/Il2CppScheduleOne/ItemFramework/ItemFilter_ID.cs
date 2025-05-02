using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005DA RID: 1498
	public class ItemFilter_ID : ItemFilter
	{
		// Token: 0x06008361 RID: 33633 RVA: 0x0022EC94 File Offset: 0x0022CE94
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFilter_ID()
		{
			Il2CppClassPointerStore<ItemFilter_ID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemFilter_ID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFilter_ID>.NativeClassPtr);
			ItemFilter_ID.NativeFieldInfoPtr_IsWhitelist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFilter_ID>.NativeClassPtr, "IsWhitelist");
			ItemFilter_ID.NativeFieldInfoPtr_IDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFilter_ID>.NativeClassPtr, "IDs");
			ItemFilter_ID.NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_ID>.NativeClassPtr, 100679729);
			ItemFilter_ID.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_ID>.NativeClassPtr, 100679730);
		}

		// Token: 0x06008362 RID: 33634 RVA: 0x0022ED14 File Offset: 0x0022CF14
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 247459, RefRangeEnd = 247464, XrefRangeStart = 247450, XrefRangeEnd = 247459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFilter_ID(List<string> ids) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFilter_ID>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ids);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_ID.NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008363 RID: 33635 RVA: 0x0022ED60 File Offset: 0x0022CF60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247464, XrefRangeEnd = 247467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemFilter_ID.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008364 RID: 33636 RVA: 0x0003E6A9 File Offset: 0x0003C8A9
		public ItemFilter_ID(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027BF RID: 10175
		// (get) Token: 0x06008365 RID: 33637 RVA: 0x0022EDB8 File Offset: 0x0022CFB8
		// (set) Token: 0x06008366 RID: 33638 RVA: 0x0003E6B2 File Offset: 0x0003C8B2
		public unsafe bool IsWhitelist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_ID.NativeFieldInfoPtr_IsWhitelist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_ID.NativeFieldInfoPtr_IsWhitelist)) = value;
			}
		}

		// Token: 0x170027C0 RID: 10176
		// (get) Token: 0x06008367 RID: 33639 RVA: 0x0022EDE0 File Offset: 0x0022CFE0
		// (set) Token: 0x06008368 RID: 33640 RVA: 0x0003E6CD File Offset: 0x0003C8CD
		public unsafe List<string> IDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_ID.NativeFieldInfoPtr_IDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_ID.NativeFieldInfoPtr_IDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400596D RID: 22893
		private static readonly IntPtr NativeFieldInfoPtr_IsWhitelist;

		// Token: 0x0400596E RID: 22894
		private static readonly IntPtr NativeFieldInfoPtr_IDs;

		// Token: 0x0400596F RID: 22895
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0;

		// Token: 0x04005970 RID: 22896
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0;
	}
}
