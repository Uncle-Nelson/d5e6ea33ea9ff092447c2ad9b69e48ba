using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x02000711 RID: 1809
	[Serializable]
	public class ShopListing : Il2CppSystem.Object
	{
		// Token: 0x0600A2DA RID: 41690 RVA: 0x0028E690 File Offset: 0x0028C890
		// Note: this type is marked as 'beforefieldinit'.
		static ShopListing()
		{
			Il2CppClassPointerStore<ShopListing>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "ShopListing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopListing>.NativeClassPtr);
			ShopListing.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "name");
			ShopListing.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "Item");
			ShopListing.NativeFieldInfoPtr_OverridePrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "OverridePrice");
			ShopListing.NativeFieldInfoPtr_OverriddenPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "OverriddenPrice");
			ShopListing.NativeFieldInfoPtr_LimitedStock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "LimitedStock");
			ShopListing.NativeFieldInfoPtr_DefaultStock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "DefaultStock");
			ShopListing.NativeFieldInfoPtr_RestockRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "RestockRate");
			ShopListing.NativeFieldInfoPtr_EnforceMinimumGameCreationVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "EnforceMinimumGameCreationVersion");
			ShopListing.NativeFieldInfoPtr_MinimumGameCreationVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "MinimumGameCreationVersion");
			ShopListing.NativeFieldInfoPtr_CanBeDelivered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "CanBeDelivered");
			ShopListing.NativeFieldInfoPtr_UseIconTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "UseIconTint");
			ShopListing.NativeFieldInfoPtr_IconTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "IconTint");
			ShopListing.NativeFieldInfoPtr__Shop_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "<Shop>k__BackingField");
			ShopListing.NativeFieldInfoPtr__CurrentStock_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "<CurrentStock>k__BackingField");
			ShopListing.NativeFieldInfoPtr__QuantityInCart_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "<QuantityInCart>k__BackingField");
			ShopListing.NativeFieldInfoPtr_onStockChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "onStockChanged");
			ShopListing.NativeMethodInfoPtr_get_IsInStock_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683233);
			ShopListing.NativeMethodInfoPtr_get_Price_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683234);
			ShopListing.NativeMethodInfoPtr_get_IsUnlimitedStock_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683235);
			ShopListing.NativeMethodInfoPtr_get_Shop_Public_get_ShopInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683236);
			ShopListing.NativeMethodInfoPtr_set_Shop_Private_set_Void_ShopInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683237);
			ShopListing.NativeMethodInfoPtr_get_CurrentStock_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683238);
			ShopListing.NativeMethodInfoPtr_set_CurrentStock_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683239);
			ShopListing.NativeMethodInfoPtr_get_QuantityInCart_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683240);
			ShopListing.NativeMethodInfoPtr_set_QuantityInCart_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683241);
			ShopListing.NativeMethodInfoPtr_get_CurrentStockMinusCart_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683242);
			ShopListing.NativeMethodInfoPtr_Initialize_Public_Void_ShopInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683243);
			ShopListing.NativeMethodInfoPtr_Restock_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683244);
			ShopListing.NativeMethodInfoPtr_RemoveStock_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683245);
			ShopListing.NativeMethodInfoPtr_SetStock_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683246);
			ShopListing.NativeMethodInfoPtr_ShouldShow_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683247);
			ShopListing.NativeMethodInfoPtr_DoesListingMatchCategoryFilter_Public_Virtual_New_Boolean_EShopCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683248);
			ShopListing.NativeMethodInfoPtr_DoesListingMatchSearchTerm_Public_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683249);
			ShopListing.NativeMethodInfoPtr_SetQuantityInCart_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683250);
			ShopListing.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100683251);
		}

		// Token: 0x17003244 RID: 12868
		// (get) Token: 0x0600A2DB RID: 41691 RVA: 0x0028E97C File Offset: 0x0028CB7C
		public unsafe bool IsInStock
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30138, RefRangeEnd = 30158, XrefRangeStart = 30138, XrefRangeEnd = 30158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_get_IsInStock_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003245 RID: 12869
		// (get) Token: 0x0600A2DC RID: 41692 RVA: 0x0028E9B8 File Offset: 0x0028CBB8
		public unsafe float Price
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 285837, RefRangeEnd = 285845, XrefRangeStart = 285837, XrefRangeEnd = 285837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_get_Price_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003246 RID: 12870
		// (get) Token: 0x0600A2DD RID: 41693 RVA: 0x0028E9F4 File Offset: 0x0028CBF4
		public unsafe bool IsUnlimitedStock
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 285845, RefRangeEnd = 285857, XrefRangeStart = 285845, XrefRangeEnd = 285845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_get_IsUnlimitedStock_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003247 RID: 12871
		// (get) Token: 0x0600A2DE RID: 41694 RVA: 0x0028EA30 File Offset: 0x0028CC30
		// (set) Token: 0x0600A2DF RID: 41695 RVA: 0x0028EA70 File Offset: 0x0028CC70
		public unsafe ShopInterface Shop
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16593, RefRangeEnd = 16594, XrefRangeStart = 16593, XrefRangeEnd = 16594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_get_Shop_Public_get_ShopInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 38376, RefRangeEnd = 38379, XrefRangeStart = 38376, XrefRangeEnd = 38379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_set_Shop_Private_set_Void_ShopInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003248 RID: 12872
		// (get) Token: 0x0600A2E0 RID: 41696 RVA: 0x0028EAB4 File Offset: 0x0028CCB4
		// (set) Token: 0x0600A2E1 RID: 41697 RVA: 0x0028EAF0 File Offset: 0x0028CCF0
		public unsafe int CurrentStock
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 47051, RefRangeEnd = 47054, XrefRangeStart = 47051, XrefRangeEnd = 47054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_get_CurrentStock_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 48697, RefRangeEnd = 48700, XrefRangeStart = 48697, XrefRangeEnd = 48700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_set_CurrentStock_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003249 RID: 12873
		// (get) Token: 0x0600A2E2 RID: 41698 RVA: 0x0028EB30 File Offset: 0x0028CD30
		// (set) Token: 0x0600A2E3 RID: 41699 RVA: 0x0028EB6C File Offset: 0x0028CD6C
		public unsafe int QuantityInCart
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 69401, RefRangeEnd = 69402, XrefRangeStart = 69401, XrefRangeEnd = 69402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_get_QuantityInCart_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 258006, RefRangeEnd = 258015, XrefRangeStart = 258006, XrefRangeEnd = 258015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_set_QuantityInCart_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700324A RID: 12874
		// (get) Token: 0x0600A2E4 RID: 41700 RVA: 0x0028EBAC File Offset: 0x0028CDAC
		public unsafe int CurrentStockMinusCart
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 285857, RefRangeEnd = 285863, XrefRangeStart = 285857, XrefRangeEnd = 285857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_get_CurrentStockMinusCart_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600A2E5 RID: 41701 RVA: 0x0028EBE8 File Offset: 0x0028CDE8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 38376, RefRangeEnd = 38379, XrefRangeStart = 38376, XrefRangeEnd = 38379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(ShopInterface shop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(shop);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_Initialize_Public_Void_ShopInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2E6 RID: 41702 RVA: 0x0028EC2C File Offset: 0x0028CE2C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 285864, RefRangeEnd = 285867, XrefRangeStart = 285863, XrefRangeEnd = 285864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Restock(bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_Restock_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2E7 RID: 41703 RVA: 0x0028EC6C File Offset: 0x0028CE6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285868, RefRangeEnd = 285869, XrefRangeStart = 285867, XrefRangeEnd = 285868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveStock(int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_RemoveStock_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2E8 RID: 41704 RVA: 0x0028ECAC File Offset: 0x0028CEAC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 285891, RefRangeEnd = 285895, XrefRangeStart = 285869, XrefRangeEnd = 285891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStock(int quantity, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_SetStock_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2E9 RID: 41705 RVA: 0x0028ECF8 File Offset: 0x0028CEF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285895, XrefRangeEnd = 285900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldShow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopListing.NativeMethodInfoPtr_ShouldShow_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A2EA RID: 41706 RVA: 0x0028ED40 File Offset: 0x0028CF40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285900, XrefRangeEnd = 285907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool DoesListingMatchCategoryFilter(EShopCategory category)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref category;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopListing.NativeMethodInfoPtr_DoesListingMatchCategoryFilter_Public_Virtual_New_Boolean_EShopCategory_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A2EB RID: 41707 RVA: 0x0028ED94 File Offset: 0x0028CF94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285907, XrefRangeEnd = 285911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool DoesListingMatchSearchTerm(string searchTerm)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(searchTerm);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopListing.NativeMethodInfoPtr_DoesListingMatchSearchTerm_Public_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A2EC RID: 41708 RVA: 0x0028EDEC File Offset: 0x0028CFEC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 285911, RefRangeEnd = 285915, XrefRangeStart = 285911, XrefRangeEnd = 285911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQuantityInCart(int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_SetQuantityInCart_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2ED RID: 41709 RVA: 0x0028EE2C File Offset: 0x0028D02C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 285916, RefRangeEnd = 285918, XrefRangeStart = 285915, XrefRangeEnd = 285916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopListing() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopListing>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2EE RID: 41710 RVA: 0x00050278 File Offset: 0x0004E478
		public ShopListing(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003234 RID: 12852
		// (get) Token: 0x0600A2EF RID: 41711 RVA: 0x0028EE68 File Offset: 0x0028D068
		// (set) Token: 0x0600A2F0 RID: 41712 RVA: 0x00050281 File Offset: 0x0004E481
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003235 RID: 12853
		// (get) Token: 0x0600A2F1 RID: 41713 RVA: 0x0028EE90 File Offset: 0x0028D090
		// (set) Token: 0x0600A2F2 RID: 41714 RVA: 0x000502A0 File Offset: 0x0004E4A0
		public unsafe StorableItemDefinition Item
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_Item);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003236 RID: 12854
		// (get) Token: 0x0600A2F3 RID: 41715 RVA: 0x0028EEC0 File Offset: 0x0028D0C0
		// (set) Token: 0x0600A2F4 RID: 41716 RVA: 0x000502BF File Offset: 0x0004E4BF
		public unsafe bool OverridePrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_OverridePrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_OverridePrice)) = value;
			}
		}

		// Token: 0x17003237 RID: 12855
		// (get) Token: 0x0600A2F5 RID: 41717 RVA: 0x0028EEE8 File Offset: 0x0028D0E8
		// (set) Token: 0x0600A2F6 RID: 41718 RVA: 0x000502DA File Offset: 0x0004E4DA
		public unsafe float OverriddenPrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_OverriddenPrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_OverriddenPrice)) = value;
			}
		}

		// Token: 0x17003238 RID: 12856
		// (get) Token: 0x0600A2F7 RID: 41719 RVA: 0x0028EF10 File Offset: 0x0028D110
		// (set) Token: 0x0600A2F8 RID: 41720 RVA: 0x000502F5 File Offset: 0x0004E4F5
		public unsafe bool LimitedStock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_LimitedStock);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_LimitedStock)) = value;
			}
		}

		// Token: 0x17003239 RID: 12857
		// (get) Token: 0x0600A2F9 RID: 41721 RVA: 0x0028EF38 File Offset: 0x0028D138
		// (set) Token: 0x0600A2FA RID: 41722 RVA: 0x00050310 File Offset: 0x0004E510
		public unsafe int DefaultStock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_DefaultStock);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_DefaultStock)) = value;
			}
		}

		// Token: 0x1700323A RID: 12858
		// (get) Token: 0x0600A2FB RID: 41723 RVA: 0x0028EF60 File Offset: 0x0028D160
		// (set) Token: 0x0600A2FC RID: 41724 RVA: 0x0005032B File Offset: 0x0004E52B
		public unsafe ShopListing.ERestockRate RestockRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_RestockRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_RestockRate)) = value;
			}
		}

		// Token: 0x1700323B RID: 12859
		// (get) Token: 0x0600A2FD RID: 41725 RVA: 0x0028EF88 File Offset: 0x0028D188
		// (set) Token: 0x0600A2FE RID: 41726 RVA: 0x00050346 File Offset: 0x0004E546
		public unsafe bool EnforceMinimumGameCreationVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_EnforceMinimumGameCreationVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_EnforceMinimumGameCreationVersion)) = value;
			}
		}

		// Token: 0x1700323C RID: 12860
		// (get) Token: 0x0600A2FF RID: 41727 RVA: 0x0028EFB0 File Offset: 0x0028D1B0
		// (set) Token: 0x0600A300 RID: 41728 RVA: 0x00050361 File Offset: 0x0004E561
		public unsafe float MinimumGameCreationVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_MinimumGameCreationVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_MinimumGameCreationVersion)) = value;
			}
		}

		// Token: 0x1700323D RID: 12861
		// (get) Token: 0x0600A301 RID: 41729 RVA: 0x0028EFD8 File Offset: 0x0028D1D8
		// (set) Token: 0x0600A302 RID: 41730 RVA: 0x0005037C File Offset: 0x0004E57C
		public unsafe bool CanBeDelivered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_CanBeDelivered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_CanBeDelivered)) = value;
			}
		}

		// Token: 0x1700323E RID: 12862
		// (get) Token: 0x0600A303 RID: 41731 RVA: 0x0028F000 File Offset: 0x0028D200
		// (set) Token: 0x0600A304 RID: 41732 RVA: 0x00050397 File Offset: 0x0004E597
		public unsafe bool UseIconTint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_UseIconTint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_UseIconTint)) = value;
			}
		}

		// Token: 0x1700323F RID: 12863
		// (get) Token: 0x0600A305 RID: 41733 RVA: 0x0028F028 File Offset: 0x0028D228
		// (set) Token: 0x0600A306 RID: 41734 RVA: 0x000503B2 File Offset: 0x0004E5B2
		public unsafe Color IconTint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_IconTint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_IconTint)) = value;
			}
		}

		// Token: 0x17003240 RID: 12864
		// (get) Token: 0x0600A307 RID: 41735 RVA: 0x0028F050 File Offset: 0x0028D250
		// (set) Token: 0x0600A308 RID: 41736 RVA: 0x000503CD File Offset: 0x0004E5CD
		public unsafe ShopInterface _Shop_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr__Shop_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr__Shop_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003241 RID: 12865
		// (get) Token: 0x0600A309 RID: 41737 RVA: 0x0028F080 File Offset: 0x0028D280
		// (set) Token: 0x0600A30A RID: 41738 RVA: 0x000503EC File Offset: 0x0004E5EC
		public unsafe int _CurrentStock_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr__CurrentStock_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr__CurrentStock_k__BackingField)) = value;
			}
		}

		// Token: 0x17003242 RID: 12866
		// (get) Token: 0x0600A30B RID: 41739 RVA: 0x0028F0A8 File Offset: 0x0028D2A8
		// (set) Token: 0x0600A30C RID: 41740 RVA: 0x00050407 File Offset: 0x0004E607
		public unsafe int _QuantityInCart_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr__QuantityInCart_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr__QuantityInCart_k__BackingField)) = value;
			}
		}

		// Token: 0x17003243 RID: 12867
		// (get) Token: 0x0600A30D RID: 41741 RVA: 0x0028F0D0 File Offset: 0x0028D2D0
		// (set) Token: 0x0600A30E RID: 41742 RVA: 0x00050422 File Offset: 0x0004E622
		public unsafe Action onStockChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_onStockChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_onStockChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006D40 RID: 27968
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04006D41 RID: 27969
		private static readonly IntPtr NativeFieldInfoPtr_Item;

		// Token: 0x04006D42 RID: 27970
		private static readonly IntPtr NativeFieldInfoPtr_OverridePrice;

		// Token: 0x04006D43 RID: 27971
		private static readonly IntPtr NativeFieldInfoPtr_OverriddenPrice;

		// Token: 0x04006D44 RID: 27972
		private static readonly IntPtr NativeFieldInfoPtr_LimitedStock;

		// Token: 0x04006D45 RID: 27973
		private static readonly IntPtr NativeFieldInfoPtr_DefaultStock;

		// Token: 0x04006D46 RID: 27974
		private static readonly IntPtr NativeFieldInfoPtr_RestockRate;

		// Token: 0x04006D47 RID: 27975
		private static readonly IntPtr NativeFieldInfoPtr_EnforceMinimumGameCreationVersion;

		// Token: 0x04006D48 RID: 27976
		private static readonly IntPtr NativeFieldInfoPtr_MinimumGameCreationVersion;

		// Token: 0x04006D49 RID: 27977
		private static readonly IntPtr NativeFieldInfoPtr_CanBeDelivered;

		// Token: 0x04006D4A RID: 27978
		private static readonly IntPtr NativeFieldInfoPtr_UseIconTint;

		// Token: 0x04006D4B RID: 27979
		private static readonly IntPtr NativeFieldInfoPtr_IconTint;

		// Token: 0x04006D4C RID: 27980
		private static readonly IntPtr NativeFieldInfoPtr__Shop_k__BackingField;

		// Token: 0x04006D4D RID: 27981
		private static readonly IntPtr NativeFieldInfoPtr__CurrentStock_k__BackingField;

		// Token: 0x04006D4E RID: 27982
		private static readonly IntPtr NativeFieldInfoPtr__QuantityInCart_k__BackingField;

		// Token: 0x04006D4F RID: 27983
		private static readonly IntPtr NativeFieldInfoPtr_onStockChanged;

		// Token: 0x04006D50 RID: 27984
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInStock_Public_get_Boolean_0;

		// Token: 0x04006D51 RID: 27985
		private static readonly IntPtr NativeMethodInfoPtr_get_Price_Public_get_Single_0;

		// Token: 0x04006D52 RID: 27986
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUnlimitedStock_Public_get_Boolean_0;

		// Token: 0x04006D53 RID: 27987
		private static readonly IntPtr NativeMethodInfoPtr_get_Shop_Public_get_ShopInterface_0;

		// Token: 0x04006D54 RID: 27988
		private static readonly IntPtr NativeMethodInfoPtr_set_Shop_Private_set_Void_ShopInterface_0;

		// Token: 0x04006D55 RID: 27989
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStock_Public_get_Int32_0;

		// Token: 0x04006D56 RID: 27990
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentStock_Protected_set_Void_Int32_0;

		// Token: 0x04006D57 RID: 27991
		private static readonly IntPtr NativeMethodInfoPtr_get_QuantityInCart_Public_get_Int32_0;

		// Token: 0x04006D58 RID: 27992
		private static readonly IntPtr NativeMethodInfoPtr_set_QuantityInCart_Private_set_Void_Int32_0;

		// Token: 0x04006D59 RID: 27993
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStockMinusCart_Public_get_Int32_0;

		// Token: 0x04006D5A RID: 27994
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_ShopInterface_0;

		// Token: 0x04006D5B RID: 27995
		private static readonly IntPtr NativeMethodInfoPtr_Restock_Public_Void_Boolean_0;

		// Token: 0x04006D5C RID: 27996
		private static readonly IntPtr NativeMethodInfoPtr_RemoveStock_Public_Void_Int32_0;

		// Token: 0x04006D5D RID: 27997
		private static readonly IntPtr NativeMethodInfoPtr_SetStock_Public_Void_Int32_Boolean_0;

		// Token: 0x04006D5E RID: 27998
		private static readonly IntPtr NativeMethodInfoPtr_ShouldShow_Public_Virtual_New_Boolean_0;

		// Token: 0x04006D5F RID: 27999
		private static readonly IntPtr NativeMethodInfoPtr_DoesListingMatchCategoryFilter_Public_Virtual_New_Boolean_EShopCategory_0;

		// Token: 0x04006D60 RID: 28000
		private static readonly IntPtr NativeMethodInfoPtr_DoesListingMatchSearchTerm_Public_Virtual_New_Boolean_String_0;

		// Token: 0x04006D61 RID: 28001
		private static readonly IntPtr NativeMethodInfoPtr_SetQuantityInCart_Public_Void_Int32_0;

		// Token: 0x04006D62 RID: 28002
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BBE RID: 3006
		[Serializable]
		public class CategoryInstance : Il2CppSystem.Object
		{
			// Token: 0x0600DD99 RID: 56729 RVA: 0x00345498 File Offset: 0x00343698
			// Note: this type is marked as 'beforefieldinit'.
			static CategoryInstance()
			{
				Il2CppClassPointerStore<ShopListing.CategoryInstance>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "CategoryInstance");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopListing.CategoryInstance>.NativeClassPtr);
				ShopListing.CategoryInstance.NativeFieldInfoPtr_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing.CategoryInstance>.NativeClassPtr, "Category");
				ShopListing.CategoryInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing.CategoryInstance>.NativeClassPtr, 100683252);
			}

			// Token: 0x0600DD9A RID: 56730 RVA: 0x003454EC File Offset: 0x003436EC
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CategoryInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopListing.CategoryInstance>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.CategoryInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD9B RID: 56731 RVA: 0x0006BFD1 File Offset: 0x0006A1D1
			public CategoryInstance(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044AA RID: 17578
			// (get) Token: 0x0600DD9C RID: 56732 RVA: 0x00345528 File Offset: 0x00343728
			// (set) Token: 0x0600DD9D RID: 56733 RVA: 0x0006BFDA File Offset: 0x0006A1DA
			public unsafe EShopCategory Category
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.CategoryInstance.NativeFieldInfoPtr_Category);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.CategoryInstance.NativeFieldInfoPtr_Category)) = value;
				}
			}

			// Token: 0x04009470 RID: 38000
			private static readonly IntPtr NativeFieldInfoPtr_Category;

			// Token: 0x04009471 RID: 38001
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000BBF RID: 3007
		[OriginalName("Assembly-CSharp.dll", "", "ERestockRate")]
		public enum ERestockRate
		{
			// Token: 0x04009473 RID: 38003
			Daily,
			// Token: 0x04009474 RID: 38004
			Weekly,
			// Token: 0x04009475 RID: 38005
			Never
		}

		// Token: 0x02000BC0 RID: 3008
		[ObfuscatedName("ScheduleOne.UI.Shop.ShopListing+<>c__DisplayClass40_0")]
		public sealed class __c__DisplayClass40_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DD9E RID: 56734 RVA: 0x00345550 File Offset: 0x00343750
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass40_0()
			{
				Il2CppClassPointerStore<ShopListing.__c__DisplayClass40_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "<>c__DisplayClass40_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopListing.__c__DisplayClass40_0>.NativeClassPtr);
				ShopListing.__c__DisplayClass40_0.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing.__c__DisplayClass40_0>.NativeClassPtr, "category");
				ShopListing.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing.__c__DisplayClass40_0>.NativeClassPtr, 100683253);
				ShopListing.__c__DisplayClass40_0.NativeMethodInfoPtr__DoesListingMatchCategoryFilter_b__0_Internal_Boolean_CategoryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing.__c__DisplayClass40_0>.NativeClassPtr, 100683254);
			}

			// Token: 0x0600DD9F RID: 56735 RVA: 0x003455B8 File Offset: 0x003437B8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass40_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopListing.__c__DisplayClass40_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDA0 RID: 56736 RVA: 0x003455F4 File Offset: 0x003437F4
			[CallerCount(0)]
			public unsafe bool _DoesListingMatchCategoryFilter_b__0(ShopListing.CategoryInstance x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.__c__DisplayClass40_0.NativeMethodInfoPtr__DoesListingMatchCategoryFilter_b__0_Internal_Boolean_CategoryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DDA1 RID: 56737 RVA: 0x0006BFF5 File Offset: 0x0006A1F5
			public __c__DisplayClass40_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044AB RID: 17579
			// (get) Token: 0x0600DDA2 RID: 56738 RVA: 0x00345644 File Offset: 0x00343844
			// (set) Token: 0x0600DDA3 RID: 56739 RVA: 0x0006BFFE File Offset: 0x0006A1FE
			public unsafe EShopCategory category
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.__c__DisplayClass40_0.NativeFieldInfoPtr_category);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.__c__DisplayClass40_0.NativeFieldInfoPtr_category)) = value;
				}
			}

			// Token: 0x04009476 RID: 38006
			private static readonly IntPtr NativeFieldInfoPtr_category;

			// Token: 0x04009477 RID: 38007
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009478 RID: 38008
			private static readonly IntPtr NativeMethodInfoPtr__DoesListingMatchCategoryFilter_b__0_Internal_Boolean_CategoryInstance_0;
		}
	}
}
