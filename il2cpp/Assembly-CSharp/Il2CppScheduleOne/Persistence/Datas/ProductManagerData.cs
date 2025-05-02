using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Product;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002AD RID: 685
	[Serializable]
	public class ProductManagerData : SaveData
	{
		// Token: 0x06003159 RID: 12633 RVA: 0x0010D328 File Offset: 0x0010B528
		// Note: this type is marked as 'beforefieldinit'.
		static ProductManagerData()
		{
			Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ProductManagerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr);
			ProductManagerData.NativeFieldInfoPtr_DiscoveredProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "DiscoveredProducts");
			ProductManagerData.NativeFieldInfoPtr_ListedProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "ListedProducts");
			ProductManagerData.NativeFieldInfoPtr_ActiveMixOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "ActiveMixOperation");
			ProductManagerData.NativeFieldInfoPtr_IsMixComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "IsMixComplete");
			ProductManagerData.NativeFieldInfoPtr_MixRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "MixRecipes");
			ProductManagerData.NativeFieldInfoPtr_ProductPrices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "ProductPrices");
			ProductManagerData.NativeFieldInfoPtr_FavouritedProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "FavouritedProducts");
			ProductManagerData.NativeFieldInfoPtr_CreatedWeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "CreatedWeed");
			ProductManagerData.NativeFieldInfoPtr_CreatedMeth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "CreatedMeth");
			ProductManagerData.NativeFieldInfoPtr_CreatedCocaine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "CreatedCocaine");
			ProductManagerData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Il2CppStringArray_NewMixOperation_Boolean_Il2CppReferenceArray_1_MixRecipeData_Il2CppReferenceArray_1_StringIntPair_Il2CppStringArray_Il2CppReferenceArray_1_WeedProductData_Il2CppReferenceArray_1_MethProductData_Il2CppReferenceArray_1_CocaineProductData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, 100668838);
		}

		// Token: 0x0600315A RID: 12634 RVA: 0x0010D434 File Offset: 0x0010B634
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131128, RefRangeEnd = 131129, XrefRangeStart = 131118, XrefRangeEnd = 131128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductManagerData(Il2CppStringArray discoveredProducts, Il2CppStringArray listedProducts, NewMixOperation activeOperation, bool isMixComplete, Il2CppReferenceArray<MixRecipeData> mixRecipes, Il2CppReferenceArray<StringIntPair> productPrices, Il2CppStringArray favouritedProducts, Il2CppReferenceArray<WeedProductData> createdWeed, Il2CppReferenceArray<MethProductData> createdMeth, Il2CppReferenceArray<CocaineProductData> createdCocaine) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(discoveredProducts);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listedProducts);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activeOperation);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isMixComplete;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mixRecipes);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(productPrices);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(favouritedProducts);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(createdWeed);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(createdMeth);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(createdCocaine);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Il2CppStringArray_NewMixOperation_Boolean_Il2CppReferenceArray_1_MixRecipeData_Il2CppReferenceArray_1_StringIntPair_Il2CppStringArray_Il2CppReferenceArray_1_WeedProductData_Il2CppReferenceArray_1_MethProductData_Il2CppReferenceArray_1_CocaineProductData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600315B RID: 12635 RVA: 0x0001A59E File Offset: 0x0001879E
		public ProductManagerData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001018 RID: 4120
		// (get) Token: 0x0600315C RID: 12636 RVA: 0x0010D528 File Offset: 0x0010B728
		// (set) Token: 0x0600315D RID: 12637 RVA: 0x0001A5A7 File Offset: 0x000187A7
		public unsafe Il2CppStringArray DiscoveredProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_DiscoveredProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_DiscoveredProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001019 RID: 4121
		// (get) Token: 0x0600315E RID: 12638 RVA: 0x0010D558 File Offset: 0x0010B758
		// (set) Token: 0x0600315F RID: 12639 RVA: 0x0001A5C6 File Offset: 0x000187C6
		public unsafe Il2CppStringArray ListedProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_ListedProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_ListedProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700101A RID: 4122
		// (get) Token: 0x06003160 RID: 12640 RVA: 0x0010D588 File Offset: 0x0010B788
		// (set) Token: 0x06003161 RID: 12641 RVA: 0x0001A5E5 File Offset: 0x000187E5
		public unsafe NewMixOperation ActiveMixOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_ActiveMixOperation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NewMixOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_ActiveMixOperation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700101B RID: 4123
		// (get) Token: 0x06003162 RID: 12642 RVA: 0x0010D5B8 File Offset: 0x0010B7B8
		// (set) Token: 0x06003163 RID: 12643 RVA: 0x0001A604 File Offset: 0x00018804
		public unsafe bool IsMixComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_IsMixComplete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_IsMixComplete)) = value;
			}
		}

		// Token: 0x1700101C RID: 4124
		// (get) Token: 0x06003164 RID: 12644 RVA: 0x0010D5E0 File Offset: 0x0010B7E0
		// (set) Token: 0x06003165 RID: 12645 RVA: 0x0001A61F File Offset: 0x0001881F
		public unsafe Il2CppReferenceArray<MixRecipeData> MixRecipes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_MixRecipes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MixRecipeData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_MixRecipes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700101D RID: 4125
		// (get) Token: 0x06003166 RID: 12646 RVA: 0x0010D610 File Offset: 0x0010B810
		// (set) Token: 0x06003167 RID: 12647 RVA: 0x0001A63E File Offset: 0x0001883E
		public unsafe Il2CppReferenceArray<StringIntPair> ProductPrices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_ProductPrices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StringIntPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_ProductPrices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700101E RID: 4126
		// (get) Token: 0x06003168 RID: 12648 RVA: 0x0010D640 File Offset: 0x0010B840
		// (set) Token: 0x06003169 RID: 12649 RVA: 0x0001A65D File Offset: 0x0001885D
		public unsafe Il2CppStringArray FavouritedProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_FavouritedProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_FavouritedProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700101F RID: 4127
		// (get) Token: 0x0600316A RID: 12650 RVA: 0x0010D670 File Offset: 0x0010B870
		// (set) Token: 0x0600316B RID: 12651 RVA: 0x0001A67C File Offset: 0x0001887C
		public unsafe Il2CppReferenceArray<WeedProductData> CreatedWeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_CreatedWeed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WeedProductData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_CreatedWeed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001020 RID: 4128
		// (get) Token: 0x0600316C RID: 12652 RVA: 0x0010D6A0 File Offset: 0x0010B8A0
		// (set) Token: 0x0600316D RID: 12653 RVA: 0x0001A69B File Offset: 0x0001889B
		public unsafe Il2CppReferenceArray<MethProductData> CreatedMeth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_CreatedMeth);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MethProductData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_CreatedMeth), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001021 RID: 4129
		// (get) Token: 0x0600316E RID: 12654 RVA: 0x0010D6D0 File Offset: 0x0010B8D0
		// (set) Token: 0x0600316F RID: 12655 RVA: 0x0001A6BA File Offset: 0x000188BA
		public unsafe Il2CppReferenceArray<CocaineProductData> CreatedCocaine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_CreatedCocaine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CocaineProductData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_CreatedCocaine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400201C RID: 8220
		private static readonly IntPtr NativeFieldInfoPtr_DiscoveredProducts;

		// Token: 0x0400201D RID: 8221
		private static readonly IntPtr NativeFieldInfoPtr_ListedProducts;

		// Token: 0x0400201E RID: 8222
		private static readonly IntPtr NativeFieldInfoPtr_ActiveMixOperation;

		// Token: 0x0400201F RID: 8223
		private static readonly IntPtr NativeFieldInfoPtr_IsMixComplete;

		// Token: 0x04002020 RID: 8224
		private static readonly IntPtr NativeFieldInfoPtr_MixRecipes;

		// Token: 0x04002021 RID: 8225
		private static readonly IntPtr NativeFieldInfoPtr_ProductPrices;

		// Token: 0x04002022 RID: 8226
		private static readonly IntPtr NativeFieldInfoPtr_FavouritedProducts;

		// Token: 0x04002023 RID: 8227
		private static readonly IntPtr NativeFieldInfoPtr_CreatedWeed;

		// Token: 0x04002024 RID: 8228
		private static readonly IntPtr NativeFieldInfoPtr_CreatedMeth;

		// Token: 0x04002025 RID: 8229
		private static readonly IntPtr NativeFieldInfoPtr_CreatedCocaine;

		// Token: 0x04002026 RID: 8230
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Il2CppStringArray_NewMixOperation_Boolean_Il2CppReferenceArray_1_MixRecipeData_Il2CppReferenceArray_1_StringIntPair_Il2CppStringArray_Il2CppReferenceArray_1_WeedProductData_Il2CppReferenceArray_1_MethProductData_Il2CppReferenceArray_1_CocaineProductData_0;
	}
}
