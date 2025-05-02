using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005D7 RID: 1495
	public class ItemFilter_Category : ItemFilter
	{
		// Token: 0x0600834E RID: 33614 RVA: 0x0022E838 File Offset: 0x0022CA38
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFilter_Category()
		{
			Il2CppClassPointerStore<ItemFilter_Category>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemFilter_Category");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFilter_Category>.NativeClassPtr);
			ItemFilter_Category.NativeFieldInfoPtr_AcceptedCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFilter_Category>.NativeClassPtr, "AcceptedCategories");
			ItemFilter_Category.NativeMethodInfoPtr__ctor_Public_Void_List_1_EItemCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_Category>.NativeClassPtr, 100679720);
			ItemFilter_Category.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_Category>.NativeClassPtr, 100679721);
		}

		// Token: 0x0600834F RID: 33615 RVA: 0x0022E8A4 File Offset: 0x0022CAA4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 247410, RefRangeEnd = 247416, XrefRangeStart = 247401, XrefRangeEnd = 247410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFilter_Category(List<EItemCategory> acceptedCategories) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFilter_Category>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(acceptedCategories);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_Category.NativeMethodInfoPtr__ctor_Public_Void_List_1_EItemCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008350 RID: 33616 RVA: 0x0022E8F0 File Offset: 0x0022CAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247416, XrefRangeEnd = 247419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemFilter_Category.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008351 RID: 33617 RVA: 0x0003E654 File Offset: 0x0003C854
		public ItemFilter_Category(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027BC RID: 10172
		// (get) Token: 0x06008352 RID: 33618 RVA: 0x0022E948 File Offset: 0x0022CB48
		// (set) Token: 0x06008353 RID: 33619 RVA: 0x0003E65D File Offset: 0x0003C85D
		public unsafe List<EItemCategory> AcceptedCategories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_Category.NativeFieldInfoPtr_AcceptedCategories);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EItemCategory>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_Category.NativeFieldInfoPtr_AcceptedCategories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005962 RID: 22882
		private static readonly IntPtr NativeFieldInfoPtr_AcceptedCategories;

		// Token: 0x04005963 RID: 22883
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_EItemCategory_0;

		// Token: 0x04005964 RID: 22884
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0;
	}
}
