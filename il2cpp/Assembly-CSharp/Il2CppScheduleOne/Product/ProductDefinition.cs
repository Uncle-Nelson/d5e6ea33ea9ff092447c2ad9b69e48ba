using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Packaging;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.Product.Packaging;
using Il2CppScheduleOne.Properties;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005A6 RID: 1446
	[Serializable]
	public class ProductDefinition : PropertyItemDefinition
	{
		// Token: 0x06007E56 RID: 32342 RVA: 0x0021CBA8 File Offset: 0x0021ADA8
		// Note: this type is marked as 'beforefieldinit'.
		static ProductDefinition()
		{
			Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "ProductDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr);
			ProductDefinition.NativeFieldInfoPtr_DrugTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "DrugTypes");
			ProductDefinition.NativeFieldInfoPtr_LawIntensityChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "LawIntensityChange");
			ProductDefinition.NativeFieldInfoPtr_BasePrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "BasePrice");
			ProductDefinition.NativeFieldInfoPtr_MarketValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "MarketValue");
			ProductDefinition.NativeFieldInfoPtr_FunctionalProduct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "FunctionalProduct");
			ProductDefinition.NativeFieldInfoPtr_EffectsDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "EffectsDuration");
			ProductDefinition.NativeFieldInfoPtr_BaseAddictiveness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "BaseAddictiveness");
			ProductDefinition.NativeFieldInfoPtr_ValidPackaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "ValidPackaging");
			ProductDefinition.NativeFieldInfoPtr__Recipes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "<Recipes>k__BackingField");
			ProductDefinition.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			ProductDefinition.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			ProductDefinition.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "<HasChanged>k__BackingField");
			ProductDefinition.NativeMethodInfoPtr_get_DrugType_Public_get_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679094);
			ProductDefinition.NativeMethodInfoPtr_get_Price_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679095);
			ProductDefinition.NativeMethodInfoPtr_get_Recipes_Public_get_List_1_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679096);
			ProductDefinition.NativeMethodInfoPtr_set_Recipes_Private_set_Void_List_1_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679097);
			ProductDefinition.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679098);
			ProductDefinition.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679099);
			ProductDefinition.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679100);
			ProductDefinition.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679101);
			ProductDefinition.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679102);
			ProductDefinition.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679103);
			ProductDefinition.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679104);
			ProductDefinition.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679105);
			ProductDefinition.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679106);
			ProductDefinition.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679107);
			ProductDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679108);
			ProductDefinition.NativeMethodInfoPtr_OnValidate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679109);
			ProductDefinition.NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679110);
			ProductDefinition.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679111);
			ProductDefinition.NativeMethodInfoPtr_GetAddictiveness_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679112);
			ProductDefinition.NativeMethodInfoPtr_CleanRecipes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679113);
			ProductDefinition.NativeMethodInfoPtr_AddRecipe_Public_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679114);
			ProductDefinition.NativeMethodInfoPtr_GetSaveData_Public_Virtual_New_ProductData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679115);
			ProductDefinition.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679116);
			ProductDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100679117);
		}

		// Token: 0x17002641 RID: 9793
		// (get) Token: 0x06007E57 RID: 32343 RVA: 0x0021CEA8 File Offset: 0x0021B0A8
		public unsafe EDrugType DrugType
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 239219, RefRangeEnd = 239239, XrefRangeStart = 239216, XrefRangeEnd = 239219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_get_DrugType_Public_get_EDrugType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002642 RID: 9794
		// (get) Token: 0x06007E58 RID: 32344 RVA: 0x0021CEE4 File Offset: 0x0021B0E4
		public unsafe float Price
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 239245, RefRangeEnd = 239248, XrefRangeStart = 239239, XrefRangeEnd = 239245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_get_Price_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002643 RID: 9795
		// (get) Token: 0x06007E59 RID: 32345 RVA: 0x0021CF20 File Offset: 0x0021B120
		// (set) Token: 0x06007E5A RID: 32346 RVA: 0x0021CF60 File Offset: 0x0021B160
		public unsafe List<StationRecipe> Recipes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_get_Recipes_Public_get_List_1_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<StationRecipe>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_set_Recipes_Private_set_Void_List_1_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002644 RID: 9796
		// (get) Token: 0x06007E5B RID: 32347 RVA: 0x0021CFA4 File Offset: 0x0021B1A4
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239248, XrefRangeEnd = 239249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002645 RID: 9797
		// (get) Token: 0x06007E5C RID: 32348 RVA: 0x0021CFDC File Offset: 0x0021B1DC
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002646 RID: 9798
		// (get) Token: 0x06007E5D RID: 32349 RVA: 0x0021D014 File Offset: 0x0021B214
		public unsafe virtual Loader Loader
		{
			[CallerCount(65)]
			[CachedScanResults(RefRangeStart = 31227, RefRangeEnd = 31292, XrefRangeStart = 31227, XrefRangeEnd = 31292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17002647 RID: 9799
		// (get) Token: 0x06007E5E RID: 32350 RVA: 0x0021D054 File Offset: 0x0021B254
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(183)]
			[CachedScanResults(RefRangeStart = 35953, RefRangeEnd = 36136, XrefRangeStart = 35953, XrefRangeEnd = 36136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002648 RID: 9800
		// (get) Token: 0x06007E5F RID: 32351 RVA: 0x0021D090 File Offset: 0x0021B290
		// (set) Token: 0x06007E60 RID: 32352 RVA: 0x0021D0D0 File Offset: 0x0021B2D0
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002649 RID: 9801
		// (get) Token: 0x06007E61 RID: 32353 RVA: 0x0021D114 File Offset: 0x0021B314
		// (set) Token: 0x06007E62 RID: 32354 RVA: 0x0021D154 File Offset: 0x0021B354
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700264A RID: 9802
		// (get) Token: 0x06007E63 RID: 32355 RVA: 0x0021D198 File Offset: 0x0021B398
		// (set) Token: 0x06007E64 RID: 32356 RVA: 0x0021D1D4 File Offset: 0x0021B3D4
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007E65 RID: 32357 RVA: 0x0021D214 File Offset: 0x0021B414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239249, XrefRangeEnd = 239253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06007E66 RID: 32358 RVA: 0x0021D26C File Offset: 0x0021B46C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239253, XrefRangeEnd = 239258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_OnValidate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E67 RID: 32359 RVA: 0x0021D2A0 File Offset: 0x0021B4A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 239287, RefRangeEnd = 239290, XrefRangeStart = 239258, XrefRangeEnd = 239287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(List<Property> properties, List<EDrugType> drugTypes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(drugTypes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E68 RID: 32360 RVA: 0x0021D2F4 File Offset: 0x0021B4F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239290, XrefRangeEnd = 239296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductDefinition.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E69 RID: 32361 RVA: 0x0021D330 File Offset: 0x0021B530
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 239301, RefRangeEnd = 239305, XrefRangeStart = 239296, XrefRangeEnd = 239301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAddictiveness()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_GetAddictiveness_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007E6A RID: 32362 RVA: 0x0021D36C File Offset: 0x0021B56C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 239316, RefRangeEnd = 239319, XrefRangeStart = 239305, XrefRangeEnd = 239316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanRecipes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_CleanRecipes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E6B RID: 32363 RVA: 0x0021D3A0 File Offset: 0x0021B5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239319, XrefRangeEnd = 239331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRecipe(StationRecipe recipe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_AddRecipe_Public_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E6C RID: 32364 RVA: 0x0021D3E4 File Offset: 0x0021B5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239331, XrefRangeEnd = 239347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ProductData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductDefinition.NativeMethodInfoPtr_GetSaveData_Public_Virtual_New_ProductData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductData>(intPtr3) : null;
		}

		// Token: 0x06007E6D RID: 32365 RVA: 0x0021D430 File Offset: 0x0021B630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239347, XrefRangeEnd = 239348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductDefinition.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007E6E RID: 32366 RVA: 0x0021D474 File Offset: 0x0021B674
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 239368, RefRangeEnd = 239371, XrefRangeStart = 239348, XrefRangeEnd = 239368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E6F RID: 32367 RVA: 0x0003C0BF File Offset: 0x0003A2BF
		public ProductDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002635 RID: 9781
		// (get) Token: 0x06007E70 RID: 32368 RVA: 0x0021D4B0 File Offset: 0x0021B6B0
		// (set) Token: 0x06007E71 RID: 32369 RVA: 0x0003C0C8 File Offset: 0x0003A2C8
		public unsafe List<DrugTypeContainer> DrugTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_DrugTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DrugTypeContainer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_DrugTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002636 RID: 9782
		// (get) Token: 0x06007E72 RID: 32370 RVA: 0x0021D4E0 File Offset: 0x0021B6E0
		// (set) Token: 0x06007E73 RID: 32371 RVA: 0x0003C0E7 File Offset: 0x0003A2E7
		public unsafe float LawIntensityChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_LawIntensityChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_LawIntensityChange)) = value;
			}
		}

		// Token: 0x17002637 RID: 9783
		// (get) Token: 0x06007E74 RID: 32372 RVA: 0x0021D508 File Offset: 0x0021B708
		// (set) Token: 0x06007E75 RID: 32373 RVA: 0x0003C102 File Offset: 0x0003A302
		public unsafe float BasePrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_BasePrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_BasePrice)) = value;
			}
		}

		// Token: 0x17002638 RID: 9784
		// (get) Token: 0x06007E76 RID: 32374 RVA: 0x0021D530 File Offset: 0x0021B730
		// (set) Token: 0x06007E77 RID: 32375 RVA: 0x0003C11D File Offset: 0x0003A31D
		public unsafe float MarketValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_MarketValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_MarketValue)) = value;
			}
		}

		// Token: 0x17002639 RID: 9785
		// (get) Token: 0x06007E78 RID: 32376 RVA: 0x0021D558 File Offset: 0x0021B758
		// (set) Token: 0x06007E79 RID: 32377 RVA: 0x0003C138 File Offset: 0x0003A338
		public unsafe FunctionalProduct FunctionalProduct
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_FunctionalProduct);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionalProduct>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_FunctionalProduct), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700263A RID: 9786
		// (get) Token: 0x06007E7A RID: 32378 RVA: 0x0021D588 File Offset: 0x0021B788
		// (set) Token: 0x06007E7B RID: 32379 RVA: 0x0003C157 File Offset: 0x0003A357
		public unsafe int EffectsDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_EffectsDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_EffectsDuration)) = value;
			}
		}

		// Token: 0x1700263B RID: 9787
		// (get) Token: 0x06007E7C RID: 32380 RVA: 0x0021D5B0 File Offset: 0x0021B7B0
		// (set) Token: 0x06007E7D RID: 32381 RVA: 0x0003C172 File Offset: 0x0003A372
		public unsafe float BaseAddictiveness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_BaseAddictiveness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_BaseAddictiveness)) = value;
			}
		}

		// Token: 0x1700263C RID: 9788
		// (get) Token: 0x06007E7E RID: 32382 RVA: 0x0021D5D8 File Offset: 0x0021B7D8
		// (set) Token: 0x06007E7F RID: 32383 RVA: 0x0003C18D File Offset: 0x0003A38D
		public unsafe Il2CppReferenceArray<PackagingDefinition> ValidPackaging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_ValidPackaging);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PackagingDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_ValidPackaging), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700263D RID: 9789
		// (get) Token: 0x06007E80 RID: 32384 RVA: 0x0021D608 File Offset: 0x0021B808
		// (set) Token: 0x06007E81 RID: 32385 RVA: 0x0003C1AC File Offset: 0x0003A3AC
		public unsafe List<StationRecipe> _Recipes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr__Recipes_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationRecipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr__Recipes_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700263E RID: 9790
		// (get) Token: 0x06007E82 RID: 32386 RVA: 0x0021D638 File Offset: 0x0021B838
		// (set) Token: 0x06007E83 RID: 32387 RVA: 0x0003C1CB File Offset: 0x0003A3CB
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700263F RID: 9791
		// (get) Token: 0x06007E84 RID: 32388 RVA: 0x0021D668 File Offset: 0x0021B868
		// (set) Token: 0x06007E85 RID: 32389 RVA: 0x0003C1EA File Offset: 0x0003A3EA
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002640 RID: 9792
		// (get) Token: 0x06007E86 RID: 32390 RVA: 0x0021D698 File Offset: 0x0021B898
		// (set) Token: 0x06007E87 RID: 32391 RVA: 0x0003C209 File Offset: 0x0003A409
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x040055F8 RID: 22008
		private static readonly IntPtr NativeFieldInfoPtr_DrugTypes;

		// Token: 0x040055F9 RID: 22009
		private static readonly IntPtr NativeFieldInfoPtr_LawIntensityChange;

		// Token: 0x040055FA RID: 22010
		private static readonly IntPtr NativeFieldInfoPtr_BasePrice;

		// Token: 0x040055FB RID: 22011
		private static readonly IntPtr NativeFieldInfoPtr_MarketValue;

		// Token: 0x040055FC RID: 22012
		private static readonly IntPtr NativeFieldInfoPtr_FunctionalProduct;

		// Token: 0x040055FD RID: 22013
		private static readonly IntPtr NativeFieldInfoPtr_EffectsDuration;

		// Token: 0x040055FE RID: 22014
		private static readonly IntPtr NativeFieldInfoPtr_BaseAddictiveness;

		// Token: 0x040055FF RID: 22015
		private static readonly IntPtr NativeFieldInfoPtr_ValidPackaging;

		// Token: 0x04005600 RID: 22016
		private static readonly IntPtr NativeFieldInfoPtr__Recipes_k__BackingField;

		// Token: 0x04005601 RID: 22017
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04005602 RID: 22018
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04005603 RID: 22019
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04005604 RID: 22020
		private static readonly IntPtr NativeMethodInfoPtr_get_DrugType_Public_get_EDrugType_0;

		// Token: 0x04005605 RID: 22021
		private static readonly IntPtr NativeMethodInfoPtr_get_Price_Public_get_Single_0;

		// Token: 0x04005606 RID: 22022
		private static readonly IntPtr NativeMethodInfoPtr_get_Recipes_Public_get_List_1_StationRecipe_0;

		// Token: 0x04005607 RID: 22023
		private static readonly IntPtr NativeMethodInfoPtr_set_Recipes_Private_set_Void_List_1_StationRecipe_0;

		// Token: 0x04005608 RID: 22024
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04005609 RID: 22025
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400560A RID: 22026
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x0400560B RID: 22027
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400560C RID: 22028
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x0400560D RID: 22029
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x0400560E RID: 22030
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x0400560F RID: 22031
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04005610 RID: 22032
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04005611 RID: 22033
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04005612 RID: 22034
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005613 RID: 22035
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Public_Void_0;

		// Token: 0x04005614 RID: 22036
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_0;

		// Token: 0x04005615 RID: 22037
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04005616 RID: 22038
		private static readonly IntPtr NativeMethodInfoPtr_GetAddictiveness_Public_Single_0;

		// Token: 0x04005617 RID: 22039
		private static readonly IntPtr NativeMethodInfoPtr_CleanRecipes_Public_Void_0;

		// Token: 0x04005618 RID: 22040
		private static readonly IntPtr NativeMethodInfoPtr_AddRecipe_Public_Void_StationRecipe_0;

		// Token: 0x04005619 RID: 22041
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_Virtual_New_ProductData_0;

		// Token: 0x0400561A RID: 22042
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x0400561B RID: 22043
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
