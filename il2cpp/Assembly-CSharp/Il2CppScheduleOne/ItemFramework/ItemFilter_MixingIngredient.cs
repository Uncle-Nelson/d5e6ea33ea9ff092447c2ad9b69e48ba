using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005DC RID: 1500
	public class ItemFilter_MixingIngredient : ItemFilter
	{
		// Token: 0x0600836F RID: 33647 RVA: 0x0022EF44 File Offset: 0x0022D144
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFilter_MixingIngredient()
		{
			Il2CppClassPointerStore<ItemFilter_MixingIngredient>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemFilter_MixingIngredient");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFilter_MixingIngredient>.NativeClassPtr);
			ItemFilter_MixingIngredient.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_MixingIngredient>.NativeClassPtr, 100679733);
			ItemFilter_MixingIngredient.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_MixingIngredient>.NativeClassPtr, 100679734);
		}

		// Token: 0x06008370 RID: 33648 RVA: 0x0022EF9C File Offset: 0x0022D19C
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFilter_MixingIngredient() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFilter_MixingIngredient>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_MixingIngredient.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008371 RID: 33649 RVA: 0x0022EFD8 File Offset: 0x0022D1D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247468, XrefRangeEnd = 247478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemFilter_MixingIngredient.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008372 RID: 33650 RVA: 0x0003E710 File Offset: 0x0003C910
		public ItemFilter_MixingIngredient(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005974 RID: 22900
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005975 RID: 22901
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0;
	}
}
