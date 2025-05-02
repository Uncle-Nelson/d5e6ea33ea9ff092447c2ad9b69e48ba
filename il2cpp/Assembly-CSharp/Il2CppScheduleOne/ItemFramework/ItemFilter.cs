using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005D6 RID: 1494
	public class ItemFilter : Object
	{
		// Token: 0x0600834A RID: 33610 RVA: 0x0022E74C File Offset: 0x0022C94C
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFilter()
		{
			Il2CppClassPointerStore<ItemFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFilter>.NativeClassPtr);
			ItemFilter.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_New_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter>.NativeClassPtr, 100679718);
			ItemFilter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter>.NativeClassPtr, 100679719);
		}

		// Token: 0x0600834B RID: 33611 RVA: 0x0022E7A4 File Offset: 0x0022C9A4
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 30138, RefRangeEnd = 30158, XrefRangeStart = 30138, XrefRangeEnd = 30158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemFilter.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_New_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600834C RID: 33612 RVA: 0x0022E7FC File Offset: 0x0022C9FC
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFilter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFilter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600834D RID: 33613 RVA: 0x0003E64B File Offset: 0x0003C84B
		public ItemFilter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005960 RID: 22880
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_New_Boolean_ItemInstance_0;

		// Token: 0x04005961 RID: 22881
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
