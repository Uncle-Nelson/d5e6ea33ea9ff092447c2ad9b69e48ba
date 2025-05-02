using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.ProductManagerApp
{
	// Token: 0x020006A7 RID: 1703
	public class ProductAppDetailPanel : MonoBehaviour
	{
		// Token: 0x06009857 RID: 38999 RVA: 0x0026E3FC File Offset: 0x0026C5FC
		// Note: this type is marked as 'beforefieldinit'.
		static ProductAppDetailPanel()
		{
			Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.ProductManagerApp", "ProductAppDetailPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr);
			ProductAppDetailPanel.NativeFieldInfoPtr__ActiveProduct_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "<ActiveProduct>k__BackingField");
			ProductAppDetailPanel.NativeFieldInfoPtr_AddictionColor_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "AddictionColor_Min");
			ProductAppDetailPanel.NativeFieldInfoPtr_AddictionColor_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "AddictionColor_Max");
			ProductAppDetailPanel.NativeFieldInfoPtr_NothingSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "NothingSelected");
			ProductAppDetailPanel.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "Container");
			ProductAppDetailPanel.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "NameLabel");
			ProductAppDetailPanel.NativeFieldInfoPtr_ValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "ValueLabel");
			ProductAppDetailPanel.NativeFieldInfoPtr_SuggestedPriceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "SuggestedPriceLabel");
			ProductAppDetailPanel.NativeFieldInfoPtr_ListedForSale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "ListedForSale");
			ProductAppDetailPanel.NativeFieldInfoPtr_DescLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "DescLabel");
			ProductAppDetailPanel.NativeFieldInfoPtr_PropertyLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "PropertyLabels");
			ProductAppDetailPanel.NativeFieldInfoPtr_Listed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "Listed");
			ProductAppDetailPanel.NativeFieldInfoPtr_Delisted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "Delisted");
			ProductAppDetailPanel.NativeFieldInfoPtr_NotDiscovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "NotDiscovered");
			ProductAppDetailPanel.NativeFieldInfoPtr_RecipesLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "RecipesLabel");
			ProductAppDetailPanel.NativeFieldInfoPtr_RecipeEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "RecipeEntries");
			ProductAppDetailPanel.NativeFieldInfoPtr_LayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "LayoutGroup");
			ProductAppDetailPanel.NativeFieldInfoPtr_AddictionSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "AddictionSlider");
			ProductAppDetailPanel.NativeFieldInfoPtr_AddictionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "AddictionLabel");
			ProductAppDetailPanel.NativeFieldInfoPtr_ScrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "ScrollRect");
			ProductAppDetailPanel.NativeMethodInfoPtr_get_ActiveProduct_Public_get_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682101);
			ProductAppDetailPanel.NativeMethodInfoPtr_set_ActiveProduct_Protected_set_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682102);
			ProductAppDetailPanel.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682103);
			ProductAppDetailPanel.NativeMethodInfoPtr_SetActiveProduct_Public_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682104);
			ProductAppDetailPanel.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682105);
			ProductAppDetailPanel.NativeMethodInfoPtr_UpdateListed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682106);
			ProductAppDetailPanel.NativeMethodInfoPtr_UpdatePrice_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682107);
			ProductAppDetailPanel.NativeMethodInfoPtr_ListingToggled_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682108);
			ProductAppDetailPanel.NativeMethodInfoPtr_PriceSubmitted_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682109);
			ProductAppDetailPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682110);
			ProductAppDetailPanel.NativeMethodInfoPtr__Awake_b__23_0_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682111);
			ProductAppDetailPanel.NativeMethodInfoPtr__Awake_b__23_1_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100682112);
		}

		// Token: 0x17002ED7 RID: 11991
		// (get) Token: 0x06009858 RID: 39000 RVA: 0x0026E6AC File Offset: 0x0026C8AC
		// (set) Token: 0x06009859 RID: 39001 RVA: 0x0026E6EC File Offset: 0x0026C8EC
		public unsafe ProductDefinition ActiveProduct
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_get_ActiveProduct_Public_get_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_set_ActiveProduct_Protected_set_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600985A RID: 39002 RVA: 0x0026E730 File Offset: 0x0026C930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272238, XrefRangeEnd = 272257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600985B RID: 39003 RVA: 0x0026E764 File Offset: 0x0026C964
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 272452, RefRangeEnd = 272456, XrefRangeStart = 272257, XrefRangeEnd = 272452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActiveProduct(ProductDefinition productDefinition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(productDefinition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_SetActiveProduct_Public_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600985C RID: 39004 RVA: 0x0026E7A8 File Offset: 0x0026C9A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272456, XrefRangeEnd = 272462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600985D RID: 39005 RVA: 0x0026E7DC File Offset: 0x0026C9DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 272471, RefRangeEnd = 272474, XrefRangeStart = 272462, XrefRangeEnd = 272471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateListed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_UpdateListed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600985E RID: 39006 RVA: 0x0026E810 File Offset: 0x0026CA10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 272481, RefRangeEnd = 272483, XrefRangeStart = 272474, XrefRangeEnd = 272481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePrice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_UpdatePrice_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600985F RID: 39007 RVA: 0x0026E844 File Offset: 0x0026CA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272483, XrefRangeEnd = 272508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ListingToggled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_ListingToggled_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009860 RID: 39008 RVA: 0x0026E878 File Offset: 0x0026CA78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 272533, RefRangeEnd = 272534, XrefRangeStart = 272508, XrefRangeEnd = 272533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PriceSubmitted(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_PriceSubmitted_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009861 RID: 39009 RVA: 0x0026E8BC File Offset: 0x0026CABC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductAppDetailPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009862 RID: 39010 RVA: 0x0026E8F8 File Offset: 0x0026CAF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__23_0(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr__Awake_b__23_0_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009863 RID: 39011 RVA: 0x0026E938 File Offset: 0x0026CB38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272534, XrefRangeEnd = 272535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__23_1(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr__Awake_b__23_1_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009864 RID: 39012 RVA: 0x0004A24E File Offset: 0x0004844E
		public ProductAppDetailPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002EC3 RID: 11971
		// (get) Token: 0x06009865 RID: 39013 RVA: 0x0026E97C File Offset: 0x0026CB7C
		// (set) Token: 0x06009866 RID: 39014 RVA: 0x0004A257 File Offset: 0x00048457
		public unsafe ProductDefinition _ActiveProduct_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr__ActiveProduct_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr__ActiveProduct_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EC4 RID: 11972
		// (get) Token: 0x06009867 RID: 39015 RVA: 0x0026E9AC File Offset: 0x0026CBAC
		// (set) Token: 0x06009868 RID: 39016 RVA: 0x0004A276 File Offset: 0x00048476
		public unsafe Color AddictionColor_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_AddictionColor_Min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_AddictionColor_Min)) = value;
			}
		}

		// Token: 0x17002EC5 RID: 11973
		// (get) Token: 0x06009869 RID: 39017 RVA: 0x0026E9D4 File Offset: 0x0026CBD4
		// (set) Token: 0x0600986A RID: 39018 RVA: 0x0004A291 File Offset: 0x00048491
		public unsafe Color AddictionColor_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_AddictionColor_Max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_AddictionColor_Max)) = value;
			}
		}

		// Token: 0x17002EC6 RID: 11974
		// (get) Token: 0x0600986B RID: 39019 RVA: 0x0026E9FC File Offset: 0x0026CBFC
		// (set) Token: 0x0600986C RID: 39020 RVA: 0x0004A2AC File Offset: 0x000484AC
		public unsafe GameObject NothingSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_NothingSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_NothingSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EC7 RID: 11975
		// (get) Token: 0x0600986D RID: 39021 RVA: 0x0026EA2C File Offset: 0x0026CC2C
		// (set) Token: 0x0600986E RID: 39022 RVA: 0x0004A2CB File Offset: 0x000484CB
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EC8 RID: 11976
		// (get) Token: 0x0600986F RID: 39023 RVA: 0x0026EA5C File Offset: 0x0026CC5C
		// (set) Token: 0x06009870 RID: 39024 RVA: 0x0004A2EA File Offset: 0x000484EA
		public unsafe Text NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EC9 RID: 11977
		// (get) Token: 0x06009871 RID: 39025 RVA: 0x0026EA8C File Offset: 0x0026CC8C
		// (set) Token: 0x06009872 RID: 39026 RVA: 0x0004A309 File Offset: 0x00048509
		public unsafe InputField ValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_ValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_ValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ECA RID: 11978
		// (get) Token: 0x06009873 RID: 39027 RVA: 0x0026EABC File Offset: 0x0026CCBC
		// (set) Token: 0x06009874 RID: 39028 RVA: 0x0004A328 File Offset: 0x00048528
		public unsafe Text SuggestedPriceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_SuggestedPriceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_SuggestedPriceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ECB RID: 11979
		// (get) Token: 0x06009875 RID: 39029 RVA: 0x0026EAEC File Offset: 0x0026CCEC
		// (set) Token: 0x06009876 RID: 39030 RVA: 0x0004A347 File Offset: 0x00048547
		public unsafe Toggle ListedForSale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_ListedForSale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_ListedForSale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ECC RID: 11980
		// (get) Token: 0x06009877 RID: 39031 RVA: 0x0026EB1C File Offset: 0x0026CD1C
		// (set) Token: 0x06009878 RID: 39032 RVA: 0x0004A366 File Offset: 0x00048566
		public unsafe Text DescLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_DescLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_DescLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ECD RID: 11981
		// (get) Token: 0x06009879 RID: 39033 RVA: 0x0026EB4C File Offset: 0x0026CD4C
		// (set) Token: 0x0600987A RID: 39034 RVA: 0x0004A385 File Offset: 0x00048585
		public unsafe Il2CppReferenceArray<Text> PropertyLabels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_PropertyLabels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_PropertyLabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ECE RID: 11982
		// (get) Token: 0x0600987B RID: 39035 RVA: 0x0026EB7C File Offset: 0x0026CD7C
		// (set) Token: 0x0600987C RID: 39036 RVA: 0x0004A3A4 File Offset: 0x000485A4
		public unsafe RectTransform Listed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_Listed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_Listed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ECF RID: 11983
		// (get) Token: 0x0600987D RID: 39037 RVA: 0x0026EBAC File Offset: 0x0026CDAC
		// (set) Token: 0x0600987E RID: 39038 RVA: 0x0004A3C3 File Offset: 0x000485C3
		public unsafe RectTransform Delisted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_Delisted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_Delisted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ED0 RID: 11984
		// (get) Token: 0x0600987F RID: 39039 RVA: 0x0026EBDC File Offset: 0x0026CDDC
		// (set) Token: 0x06009880 RID: 39040 RVA: 0x0004A3E2 File Offset: 0x000485E2
		public unsafe RectTransform NotDiscovered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_NotDiscovered);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_NotDiscovered), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ED1 RID: 11985
		// (get) Token: 0x06009881 RID: 39041 RVA: 0x0026EC0C File Offset: 0x0026CE0C
		// (set) Token: 0x06009882 RID: 39042 RVA: 0x0004A401 File Offset: 0x00048601
		public unsafe RectTransform RecipesLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_RecipesLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_RecipesLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ED2 RID: 11986
		// (get) Token: 0x06009883 RID: 39043 RVA: 0x0026EC3C File Offset: 0x0026CE3C
		// (set) Token: 0x06009884 RID: 39044 RVA: 0x0004A420 File Offset: 0x00048620
		public unsafe Il2CppReferenceArray<RectTransform> RecipeEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_RecipeEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_RecipeEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ED3 RID: 11987
		// (get) Token: 0x06009885 RID: 39045 RVA: 0x0026EC6C File Offset: 0x0026CE6C
		// (set) Token: 0x06009886 RID: 39046 RVA: 0x0004A43F File Offset: 0x0004863F
		public unsafe VerticalLayoutGroup LayoutGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_LayoutGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VerticalLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_LayoutGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ED4 RID: 11988
		// (get) Token: 0x06009887 RID: 39047 RVA: 0x0026EC9C File Offset: 0x0026CE9C
		// (set) Token: 0x06009888 RID: 39048 RVA: 0x0004A45E File Offset: 0x0004865E
		public unsafe Scrollbar AddictionSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_AddictionSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_AddictionSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ED5 RID: 11989
		// (get) Token: 0x06009889 RID: 39049 RVA: 0x0026ECCC File Offset: 0x0026CECC
		// (set) Token: 0x0600988A RID: 39050 RVA: 0x0004A47D File Offset: 0x0004867D
		public unsafe Text AddictionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_AddictionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_AddictionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ED6 RID: 11990
		// (get) Token: 0x0600988B RID: 39051 RVA: 0x0026ECFC File Offset: 0x0026CEFC
		// (set) Token: 0x0600988C RID: 39052 RVA: 0x0004A49C File Offset: 0x0004869C
		public unsafe ScrollRect ScrollRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_ScrollRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_ScrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400669D RID: 26269
		private static readonly IntPtr NativeFieldInfoPtr__ActiveProduct_k__BackingField;

		// Token: 0x0400669E RID: 26270
		private static readonly IntPtr NativeFieldInfoPtr_AddictionColor_Min;

		// Token: 0x0400669F RID: 26271
		private static readonly IntPtr NativeFieldInfoPtr_AddictionColor_Max;

		// Token: 0x040066A0 RID: 26272
		private static readonly IntPtr NativeFieldInfoPtr_NothingSelected;

		// Token: 0x040066A1 RID: 26273
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040066A2 RID: 26274
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x040066A3 RID: 26275
		private static readonly IntPtr NativeFieldInfoPtr_ValueLabel;

		// Token: 0x040066A4 RID: 26276
		private static readonly IntPtr NativeFieldInfoPtr_SuggestedPriceLabel;

		// Token: 0x040066A5 RID: 26277
		private static readonly IntPtr NativeFieldInfoPtr_ListedForSale;

		// Token: 0x040066A6 RID: 26278
		private static readonly IntPtr NativeFieldInfoPtr_DescLabel;

		// Token: 0x040066A7 RID: 26279
		private static readonly IntPtr NativeFieldInfoPtr_PropertyLabels;

		// Token: 0x040066A8 RID: 26280
		private static readonly IntPtr NativeFieldInfoPtr_Listed;

		// Token: 0x040066A9 RID: 26281
		private static readonly IntPtr NativeFieldInfoPtr_Delisted;

		// Token: 0x040066AA RID: 26282
		private static readonly IntPtr NativeFieldInfoPtr_NotDiscovered;

		// Token: 0x040066AB RID: 26283
		private static readonly IntPtr NativeFieldInfoPtr_RecipesLabel;

		// Token: 0x040066AC RID: 26284
		private static readonly IntPtr NativeFieldInfoPtr_RecipeEntries;

		// Token: 0x040066AD RID: 26285
		private static readonly IntPtr NativeFieldInfoPtr_LayoutGroup;

		// Token: 0x040066AE RID: 26286
		private static readonly IntPtr NativeFieldInfoPtr_AddictionSlider;

		// Token: 0x040066AF RID: 26287
		private static readonly IntPtr NativeFieldInfoPtr_AddictionLabel;

		// Token: 0x040066B0 RID: 26288
		private static readonly IntPtr NativeFieldInfoPtr_ScrollRect;

		// Token: 0x040066B1 RID: 26289
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveProduct_Public_get_ProductDefinition_0;

		// Token: 0x040066B2 RID: 26290
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveProduct_Protected_set_Void_ProductDefinition_0;

		// Token: 0x040066B3 RID: 26291
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x040066B4 RID: 26292
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveProduct_Public_Void_ProductDefinition_0;

		// Token: 0x040066B5 RID: 26293
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040066B6 RID: 26294
		private static readonly IntPtr NativeMethodInfoPtr_UpdateListed_Private_Void_0;

		// Token: 0x040066B7 RID: 26295
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePrice_Private_Void_0;

		// Token: 0x040066B8 RID: 26296
		private static readonly IntPtr NativeMethodInfoPtr_ListingToggled_Private_Void_0;

		// Token: 0x040066B9 RID: 26297
		private static readonly IntPtr NativeMethodInfoPtr_PriceSubmitted_Private_Void_String_0;

		// Token: 0x040066BA RID: 26298
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040066BB RID: 26299
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__23_0_Private_Void_Boolean_0;

		// Token: 0x040066BC RID: 26300
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__23_1_Private_Void_String_0;
	}
}
