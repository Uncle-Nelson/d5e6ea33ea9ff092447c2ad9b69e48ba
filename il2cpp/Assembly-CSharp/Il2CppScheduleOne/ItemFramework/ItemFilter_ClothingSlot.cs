using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Clothing;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005D8 RID: 1496
	public class ItemFilter_ClothingSlot : ItemFilter
	{
		// Token: 0x06008354 RID: 33620 RVA: 0x0022E978 File Offset: 0x0022CB78
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFilter_ClothingSlot()
		{
			Il2CppClassPointerStore<ItemFilter_ClothingSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemFilter_ClothingSlot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFilter_ClothingSlot>.NativeClassPtr);
			ItemFilter_ClothingSlot.NativeFieldInfoPtr__SlotType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFilter_ClothingSlot>.NativeClassPtr, "<SlotType>k__BackingField");
			ItemFilter_ClothingSlot.NativeMethodInfoPtr_get_SlotType_Public_get_EClothingSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_ClothingSlot>.NativeClassPtr, 100679722);
			ItemFilter_ClothingSlot.NativeMethodInfoPtr_set_SlotType_Private_set_Void_EClothingSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_ClothingSlot>.NativeClassPtr, 100679723);
			ItemFilter_ClothingSlot.NativeMethodInfoPtr__ctor_Public_Void_EClothingSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_ClothingSlot>.NativeClassPtr, 100679724);
			ItemFilter_ClothingSlot.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_ClothingSlot>.NativeClassPtr, 100679725);
		}

		// Token: 0x170027BE RID: 10174
		// (get) Token: 0x06008355 RID: 33621 RVA: 0x0022EA0C File Offset: 0x0022CC0C
		// (set) Token: 0x06008356 RID: 33622 RVA: 0x0022EA48 File Offset: 0x0022CC48
		public unsafe EClothingSlot SlotType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_ClothingSlot.NativeMethodInfoPtr_get_SlotType_Public_get_EClothingSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_ClothingSlot.NativeMethodInfoPtr_set_SlotType_Private_set_Void_EClothingSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008357 RID: 33623 RVA: 0x0022EA88 File Offset: 0x0022CC88
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFilter_ClothingSlot(EClothingSlot slot) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFilter_ClothingSlot>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref slot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_ClothingSlot.NativeMethodInfoPtr__ctor_Public_Void_EClothingSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008358 RID: 33624 RVA: 0x0022EAD0 File Offset: 0x0022CCD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247419, XrefRangeEnd = 247430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemFilter_ClothingSlot.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008359 RID: 33625 RVA: 0x0003E67C File Offset: 0x0003C87C
		public ItemFilter_ClothingSlot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027BD RID: 10173
		// (get) Token: 0x0600835A RID: 33626 RVA: 0x0022EB28 File Offset: 0x0022CD28
		// (set) Token: 0x0600835B RID: 33627 RVA: 0x0003E685 File Offset: 0x0003C885
		public unsafe EClothingSlot _SlotType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_ClothingSlot.NativeFieldInfoPtr__SlotType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_ClothingSlot.NativeFieldInfoPtr__SlotType_k__BackingField)) = value;
			}
		}

		// Token: 0x04005965 RID: 22885
		private static readonly IntPtr NativeFieldInfoPtr__SlotType_k__BackingField;

		// Token: 0x04005966 RID: 22886
		private static readonly IntPtr NativeMethodInfoPtr_get_SlotType_Public_get_EClothingSlot_0;

		// Token: 0x04005967 RID: 22887
		private static readonly IntPtr NativeMethodInfoPtr_set_SlotType_Private_set_Void_EClothingSlot_0;

		// Token: 0x04005968 RID: 22888
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EClothingSlot_0;

		// Token: 0x04005969 RID: 22889
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0;
	}
}
