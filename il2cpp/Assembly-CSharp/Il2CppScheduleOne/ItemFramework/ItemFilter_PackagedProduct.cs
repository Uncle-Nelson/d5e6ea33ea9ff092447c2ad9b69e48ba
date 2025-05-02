using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005DD RID: 1501
	public class ItemFilter_PackagedProduct : ItemFilter_Category
	{
		// Token: 0x06008373 RID: 33651 RVA: 0x0022F030 File Offset: 0x0022D230
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFilter_PackagedProduct()
		{
			Il2CppClassPointerStore<ItemFilter_PackagedProduct>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemFilter_PackagedProduct");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFilter_PackagedProduct>.NativeClassPtr);
			ItemFilter_PackagedProduct.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_PackagedProduct>.NativeClassPtr, 100679735);
			ItemFilter_PackagedProduct.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_PackagedProduct>.NativeClassPtr, 100679736);
		}

		// Token: 0x06008374 RID: 33652 RVA: 0x0022F088 File Offset: 0x0022D288
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 247491, RefRangeEnd = 247493, XrefRangeStart = 247478, XrefRangeEnd = 247491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFilter_PackagedProduct() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFilter_PackagedProduct>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_PackagedProduct.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008375 RID: 33653 RVA: 0x0022F0C4 File Offset: 0x0022D2C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247493, XrefRangeEnd = 247503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemFilter_PackagedProduct.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008376 RID: 33654 RVA: 0x0003E719 File Offset: 0x0003C919
		public ItemFilter_PackagedProduct(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005976 RID: 22902
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005977 RID: 22903
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0;
	}
}
