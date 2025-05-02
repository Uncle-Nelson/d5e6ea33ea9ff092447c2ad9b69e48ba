using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005D9 RID: 1497
	public class ItemFilter_Dryable : ItemFilter
	{
		// Token: 0x0600835C RID: 33628 RVA: 0x0022EB50 File Offset: 0x0022CD50
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFilter_Dryable()
		{
			Il2CppClassPointerStore<ItemFilter_Dryable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemFilter_Dryable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFilter_Dryable>.NativeClassPtr);
			ItemFilter_Dryable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_Dryable>.NativeClassPtr, 100679726);
			ItemFilter_Dryable.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_Dryable>.NativeClassPtr, 100679727);
			ItemFilter_Dryable.NativeMethodInfoPtr_IsItemDryable_Public_Static_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_Dryable>.NativeClassPtr, 100679728);
		}

		// Token: 0x0600835D RID: 33629 RVA: 0x0022EBBC File Offset: 0x0022CDBC
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFilter_Dryable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFilter_Dryable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_Dryable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600835E RID: 33630 RVA: 0x0022EBF8 File Offset: 0x0022CDF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247430, XrefRangeEnd = 247431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemFilter_Dryable.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600835F RID: 33631 RVA: 0x0022EC50 File Offset: 0x0022CE50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 247448, RefRangeEnd = 247450, XrefRangeStart = 247431, XrefRangeEnd = 247448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsItemDryable(ItemInstance instance)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_Dryable.NativeMethodInfoPtr_IsItemDryable_Public_Static_Boolean_ItemInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008360 RID: 33632 RVA: 0x0003E6A0 File Offset: 0x0003C8A0
		public ItemFilter_Dryable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400596A RID: 22890
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400596B RID: 22891
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0;

		// Token: 0x0400596C RID: 22892
		private static readonly IntPtr NativeMethodInfoPtr_IsItemDryable_Public_Static_Boolean_ItemInstance_0;
	}
}
