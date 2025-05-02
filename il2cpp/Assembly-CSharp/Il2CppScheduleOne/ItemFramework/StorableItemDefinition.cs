using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Levelling;
using Il2CppScheduleOne.StationFramework;
using Il2CppScheduleOne.Storage;
using Il2CppScheduleOne.UI.Shop;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005EF RID: 1519
	[Serializable]
	public class StorableItemDefinition : ItemDefinition
	{
		// Token: 0x060084A1 RID: 33953 RVA: 0x0023370C File Offset: 0x0023190C
		// Note: this type is marked as 'beforefieldinit'.
		static StorableItemDefinition()
		{
			Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "StorableItemDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr);
			StorableItemDefinition.NativeFieldInfoPtr_BasePurchasePrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, "BasePurchasePrice");
			StorableItemDefinition.NativeFieldInfoPtr_ShopCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, "ShopCategories");
			StorableItemDefinition.NativeFieldInfoPtr_RequiresLevelToPurchase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, "RequiresLevelToPurchase");
			StorableItemDefinition.NativeFieldInfoPtr_RequiredRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, "RequiredRank");
			StorableItemDefinition.NativeFieldInfoPtr_ResellMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, "ResellMultiplier");
			StorableItemDefinition.NativeFieldInfoPtr_StoredItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, "StoredItem");
			StorableItemDefinition.NativeFieldInfoPtr_StationItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, "StationItem");
			StorableItemDefinition.NativeMethodInfoPtr_get_IsPurchasable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, 100679900);
			StorableItemDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, 100679901);
			StorableItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, 100679902);
		}

		// Token: 0x1700281A RID: 10266
		// (get) Token: 0x060084A2 RID: 33954 RVA: 0x00233804 File Offset: 0x00231A04
		public unsafe bool IsPurchasable
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 249239, RefRangeEnd = 249261, XrefRangeStart = 249238, XrefRangeEnd = 249239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorableItemDefinition.NativeMethodInfoPtr_get_IsPurchasable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060084A3 RID: 33955 RVA: 0x00233840 File Offset: 0x00231A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249261, XrefRangeEnd = 249265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorableItemDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x060084A4 RID: 33956 RVA: 0x00233898 File Offset: 0x00231A98
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 249273, RefRangeEnd = 249284, XrefRangeStart = 249265, XrefRangeEnd = 249273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorableItemDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorableItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060084A5 RID: 33957 RVA: 0x0003EDC7 File Offset: 0x0003CFC7
		public StorableItemDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002813 RID: 10259
		// (get) Token: 0x060084A6 RID: 33958 RVA: 0x002338D4 File Offset: 0x00231AD4
		// (set) Token: 0x060084A7 RID: 33959 RVA: 0x0003EDD0 File Offset: 0x0003CFD0
		public unsafe float BasePurchasePrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_BasePurchasePrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_BasePurchasePrice)) = value;
			}
		}

		// Token: 0x17002814 RID: 10260
		// (get) Token: 0x060084A8 RID: 33960 RVA: 0x002338FC File Offset: 0x00231AFC
		// (set) Token: 0x060084A9 RID: 33961 RVA: 0x0003EDEB File Offset: 0x0003CFEB
		public unsafe List<ShopListing.CategoryInstance> ShopCategories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_ShopCategories);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ShopListing.CategoryInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_ShopCategories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002815 RID: 10261
		// (get) Token: 0x060084AA RID: 33962 RVA: 0x0023392C File Offset: 0x00231B2C
		// (set) Token: 0x060084AB RID: 33963 RVA: 0x0003EE0A File Offset: 0x0003D00A
		public unsafe bool RequiresLevelToPurchase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_RequiresLevelToPurchase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_RequiresLevelToPurchase)) = value;
			}
		}

		// Token: 0x17002816 RID: 10262
		// (get) Token: 0x060084AC RID: 33964 RVA: 0x00233954 File Offset: 0x00231B54
		// (set) Token: 0x060084AD RID: 33965 RVA: 0x0003EE25 File Offset: 0x0003D025
		public unsafe FullRank RequiredRank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_RequiredRank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_RequiredRank)) = value;
			}
		}

		// Token: 0x17002817 RID: 10263
		// (get) Token: 0x060084AE RID: 33966 RVA: 0x0023397C File Offset: 0x00231B7C
		// (set) Token: 0x060084AF RID: 33967 RVA: 0x0003EE40 File Offset: 0x0003D040
		public unsafe float ResellMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_ResellMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_ResellMultiplier)) = value;
			}
		}

		// Token: 0x17002818 RID: 10264
		// (get) Token: 0x060084B0 RID: 33968 RVA: 0x002339A4 File Offset: 0x00231BA4
		// (set) Token: 0x060084B1 RID: 33969 RVA: 0x0003EE5B File Offset: 0x0003D05B
		public unsafe StoredItem StoredItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_StoredItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoredItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_StoredItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002819 RID: 10265
		// (get) Token: 0x060084B2 RID: 33970 RVA: 0x002339D4 File Offset: 0x00231BD4
		// (set) Token: 0x060084B3 RID: 33971 RVA: 0x0003EE7A File Offset: 0x0003D07A
		public unsafe StationItem StationItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_StationItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_StationItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005A55 RID: 23125
		private static readonly IntPtr NativeFieldInfoPtr_BasePurchasePrice;

		// Token: 0x04005A56 RID: 23126
		private static readonly IntPtr NativeFieldInfoPtr_ShopCategories;

		// Token: 0x04005A57 RID: 23127
		private static readonly IntPtr NativeFieldInfoPtr_RequiresLevelToPurchase;

		// Token: 0x04005A58 RID: 23128
		private static readonly IntPtr NativeFieldInfoPtr_RequiredRank;

		// Token: 0x04005A59 RID: 23129
		private static readonly IntPtr NativeFieldInfoPtr_ResellMultiplier;

		// Token: 0x04005A5A RID: 23130
		private static readonly IntPtr NativeFieldInfoPtr_StoredItem;

		// Token: 0x04005A5B RID: 23131
		private static readonly IntPtr NativeFieldInfoPtr_StationItem;

		// Token: 0x04005A5C RID: 23132
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPurchasable_Public_get_Boolean_0;

		// Token: 0x04005A5D RID: 23133
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005A5E RID: 23134
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
