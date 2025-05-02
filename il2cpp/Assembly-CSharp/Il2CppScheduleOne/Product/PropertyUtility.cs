using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Properties;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005AF RID: 1455
	public class PropertyUtility : Singleton<PropertyUtility>
	{
		// Token: 0x06007FED RID: 32749 RVA: 0x00223D54 File Offset: 0x00221F54
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyUtility()
		{
			Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "PropertyUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr);
			PropertyUtility.NativeFieldInfoPtr_PropertyDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "PropertyDatas");
			PropertyUtility.NativeFieldInfoPtr_DrugTypeDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "DrugTypeDatas");
			PropertyUtility.NativeFieldInfoPtr_AllProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "AllProperties");
			PropertyUtility.NativeFieldInfoPtr_Products = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "Products");
			PropertyUtility.NativeFieldInfoPtr_Properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "Properties");
			PropertyUtility.NativeFieldInfoPtr_PropertiesDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "PropertiesDict");
			PropertyUtility.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, 100679356);
			PropertyUtility.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, 100679357);
			PropertyUtility.NativeMethodInfoPtr_GetProperties_Public_List_1_Property_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, 100679358);
			PropertyUtility.NativeMethodInfoPtr_GetProperties_Public_List_1_Property_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, 100679359);
			PropertyUtility.NativeMethodInfoPtr_GetPropertyData_Public_Static_PropertyData_EProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, 100679360);
			PropertyUtility.NativeMethodInfoPtr_GetDrugTypeData_Public_Static_DrugTypeData_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, 100679361);
			PropertyUtility.NativeMethodInfoPtr_GetOrderedPropertyColors_Public_Static_List_1_Color32_List_1_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, 100679362);
			PropertyUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, 100679363);
		}

		// Token: 0x06007FEE RID: 32750 RVA: 0x00223E9C File Offset: 0x0022209C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243661, XrefRangeEnd = 243681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyUtility.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FEF RID: 32751 RVA: 0x00223ED8 File Offset: 0x002220D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243681, XrefRangeEnd = 243684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyUtility.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FF0 RID: 32752 RVA: 0x00223F14 File Offset: 0x00222114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243684, XrefRangeEnd = 243703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Property> GetProperties(int tier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref tier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.NativeMethodInfoPtr_GetProperties_Public_List_1_Property_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr3) : null;
		}

		// Token: 0x06007FF1 RID: 32753 RVA: 0x00223F60 File Offset: 0x00222160
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 243771, RefRangeEnd = 243774, XrefRangeStart = 243703, XrefRangeEnd = 243771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Property> GetProperties(List<string> ids)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ids);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.NativeMethodInfoPtr_GetProperties_Public_List_1_Property_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr3) : null;
		}

		// Token: 0x06007FF2 RID: 32754 RVA: 0x00223FB0 File Offset: 0x002221B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 243792, RefRangeEnd = 243795, XrefRangeStart = 243774, XrefRangeEnd = 243792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyUtility.PropertyData GetPropertyData(EProperty property)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref property;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.NativeMethodInfoPtr_GetPropertyData_Public_Static_PropertyData_EProperty_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyUtility.PropertyData>(intPtr3) : null;
		}

		// Token: 0x06007FF3 RID: 32755 RVA: 0x00223FF0 File Offset: 0x002221F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 243813, RefRangeEnd = 243816, XrefRangeStart = 243795, XrefRangeEnd = 243813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyUtility.DrugTypeData GetDrugTypeData(EDrugType drugType)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref drugType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.NativeMethodInfoPtr_GetDrugTypeData_Public_Static_DrugTypeData_EDrugType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyUtility.DrugTypeData>(intPtr3) : null;
		}

		// Token: 0x06007FF4 RID: 32756 RVA: 0x00224030 File Offset: 0x00222230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243816, XrefRangeEnd = 243866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Color32> GetOrderedPropertyColors(List<Property> properties)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.NativeMethodInfoPtr_GetOrderedPropertyColors_Public_Static_List_1_Color32_List_1_Property_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Color32>>(intPtr3) : null;
		}

		// Token: 0x06007FF5 RID: 32757 RVA: 0x00224074 File Offset: 0x00222274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243866, XrefRangeEnd = 243911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FF6 RID: 32758 RVA: 0x0003CA29 File Offset: 0x0003AC29
		public PropertyUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026A5 RID: 9893
		// (get) Token: 0x06007FF7 RID: 32759 RVA: 0x002240B0 File Offset: 0x002222B0
		// (set) Token: 0x06007FF8 RID: 32760 RVA: 0x0003CA32 File Offset: 0x0003AC32
		public unsafe List<PropertyUtility.PropertyData> PropertyDatas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_PropertyDatas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PropertyUtility.PropertyData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_PropertyDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026A6 RID: 9894
		// (get) Token: 0x06007FF9 RID: 32761 RVA: 0x002240E0 File Offset: 0x002222E0
		// (set) Token: 0x06007FFA RID: 32762 RVA: 0x0003CA51 File Offset: 0x0003AC51
		public unsafe List<PropertyUtility.DrugTypeData> DrugTypeDatas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_DrugTypeDatas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PropertyUtility.DrugTypeData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_DrugTypeDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026A7 RID: 9895
		// (get) Token: 0x06007FFB RID: 32763 RVA: 0x00224110 File Offset: 0x00222310
		// (set) Token: 0x06007FFC RID: 32764 RVA: 0x0003CA70 File Offset: 0x0003AC70
		public unsafe List<Property> AllProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_AllProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_AllProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026A8 RID: 9896
		// (get) Token: 0x06007FFD RID: 32765 RVA: 0x00224140 File Offset: 0x00222340
		// (set) Token: 0x06007FFE RID: 32766 RVA: 0x0003CA8F File Offset: 0x0003AC8F
		public unsafe List<ProductDefinition> Products
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_Products);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_Products), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026A9 RID: 9897
		// (get) Token: 0x06007FFF RID: 32767 RVA: 0x00224170 File Offset: 0x00222370
		// (set) Token: 0x06008000 RID: 32768 RVA: 0x0003CAAE File Offset: 0x0003ACAE
		public unsafe List<PropertyItemDefinition> Properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_Properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PropertyItemDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_Properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026AA RID: 9898
		// (get) Token: 0x06008001 RID: 32769 RVA: 0x002241A0 File Offset: 0x002223A0
		// (set) Token: 0x06008002 RID: 32770 RVA: 0x0003CACD File Offset: 0x0003ACCD
		public unsafe Dictionary<string, Property> PropertiesDict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_PropertiesDict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Property>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.NativeFieldInfoPtr_PropertiesDict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400572B RID: 22315
		private static readonly IntPtr NativeFieldInfoPtr_PropertyDatas;

		// Token: 0x0400572C RID: 22316
		private static readonly IntPtr NativeFieldInfoPtr_DrugTypeDatas;

		// Token: 0x0400572D RID: 22317
		private static readonly IntPtr NativeFieldInfoPtr_AllProperties;

		// Token: 0x0400572E RID: 22318
		private static readonly IntPtr NativeFieldInfoPtr_Products;

		// Token: 0x0400572F RID: 22319
		private static readonly IntPtr NativeFieldInfoPtr_Properties;

		// Token: 0x04005730 RID: 22320
		private static readonly IntPtr NativeFieldInfoPtr_PropertiesDict;

		// Token: 0x04005731 RID: 22321
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04005732 RID: 22322
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04005733 RID: 22323
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_List_1_Property_Int32_0;

		// Token: 0x04005734 RID: 22324
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_List_1_Property_List_1_String_0;

		// Token: 0x04005735 RID: 22325
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyData_Public_Static_PropertyData_EProperty_0;

		// Token: 0x04005736 RID: 22326
		private static readonly IntPtr NativeMethodInfoPtr_GetDrugTypeData_Public_Static_DrugTypeData_EDrugType_0;

		// Token: 0x04005737 RID: 22327
		private static readonly IntPtr NativeMethodInfoPtr_GetOrderedPropertyColors_Public_Static_List_1_Color32_List_1_Property_0;

		// Token: 0x04005738 RID: 22328
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AD6 RID: 2774
		[Serializable]
		public class PropertyData : Il2CppSystem.Object
		{
			// Token: 0x0600D4C2 RID: 54466 RVA: 0x0032C124 File Offset: 0x0032A324
			// Note: this type is marked as 'beforefieldinit'.
			static PropertyData()
			{
				Il2CppClassPointerStore<PropertyUtility.PropertyData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "PropertyData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility.PropertyData>.NativeClassPtr);
				PropertyUtility.PropertyData.NativeFieldInfoPtr_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.PropertyData>.NativeClassPtr, "Property");
				PropertyUtility.PropertyData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.PropertyData>.NativeClassPtr, "Name");
				PropertyUtility.PropertyData.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.PropertyData>.NativeClassPtr, "Description");
				PropertyUtility.PropertyData.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.PropertyData>.NativeClassPtr, "Color");
				PropertyUtility.PropertyData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.PropertyData>.NativeClassPtr, 100679364);
			}

			// Token: 0x0600D4C3 RID: 54467 RVA: 0x0032C1B4 File Offset: 0x0032A3B4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PropertyData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility.PropertyData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.PropertyData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4C4 RID: 54468 RVA: 0x00067885 File Offset: 0x00065A85
			public PropertyData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041EF RID: 16879
			// (get) Token: 0x0600D4C5 RID: 54469 RVA: 0x0032C1F0 File Offset: 0x0032A3F0
			// (set) Token: 0x0600D4C6 RID: 54470 RVA: 0x0006788E File Offset: 0x00065A8E
			public unsafe EProperty Property
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.PropertyData.NativeFieldInfoPtr_Property);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.PropertyData.NativeFieldInfoPtr_Property)) = value;
				}
			}

			// Token: 0x170041F0 RID: 16880
			// (get) Token: 0x0600D4C7 RID: 54471 RVA: 0x0032C218 File Offset: 0x0032A418
			// (set) Token: 0x0600D4C8 RID: 54472 RVA: 0x000678A9 File Offset: 0x00065AA9
			public unsafe string Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.PropertyData.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.PropertyData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170041F1 RID: 16881
			// (get) Token: 0x0600D4C9 RID: 54473 RVA: 0x0032C240 File Offset: 0x0032A440
			// (set) Token: 0x0600D4CA RID: 54474 RVA: 0x000678C8 File Offset: 0x00065AC8
			public unsafe string Description
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.PropertyData.NativeFieldInfoPtr_Description);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.PropertyData.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170041F2 RID: 16882
			// (get) Token: 0x0600D4CB RID: 54475 RVA: 0x0032C268 File Offset: 0x0032A468
			// (set) Token: 0x0600D4CC RID: 54476 RVA: 0x000678E7 File Offset: 0x00065AE7
			public unsafe Color Color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.PropertyData.NativeFieldInfoPtr_Color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.PropertyData.NativeFieldInfoPtr_Color)) = value;
				}
			}

			// Token: 0x04008F2F RID: 36655
			private static readonly IntPtr NativeFieldInfoPtr_Property;

			// Token: 0x04008F30 RID: 36656
			private static readonly IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x04008F31 RID: 36657
			private static readonly IntPtr NativeFieldInfoPtr_Description;

			// Token: 0x04008F32 RID: 36658
			private static readonly IntPtr NativeFieldInfoPtr_Color;

			// Token: 0x04008F33 RID: 36659
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AD7 RID: 2775
		[Serializable]
		public class DrugTypeData : Il2CppSystem.Object
		{
			// Token: 0x0600D4CD RID: 54477 RVA: 0x0032C290 File Offset: 0x0032A490
			// Note: this type is marked as 'beforefieldinit'.
			static DrugTypeData()
			{
				Il2CppClassPointerStore<PropertyUtility.DrugTypeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "DrugTypeData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility.DrugTypeData>.NativeClassPtr);
				PropertyUtility.DrugTypeData.NativeFieldInfoPtr_DrugType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.DrugTypeData>.NativeClassPtr, "DrugType");
				PropertyUtility.DrugTypeData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.DrugTypeData>.NativeClassPtr, "Name");
				PropertyUtility.DrugTypeData.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.DrugTypeData>.NativeClassPtr, "Color");
				PropertyUtility.DrugTypeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.DrugTypeData>.NativeClassPtr, 100679365);
			}

			// Token: 0x0600D4CE RID: 54478 RVA: 0x0032C30C File Offset: 0x0032A50C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DrugTypeData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility.DrugTypeData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.DrugTypeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4CF RID: 54479 RVA: 0x00067902 File Offset: 0x00065B02
			public DrugTypeData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041F3 RID: 16883
			// (get) Token: 0x0600D4D0 RID: 54480 RVA: 0x0032C348 File Offset: 0x0032A548
			// (set) Token: 0x0600D4D1 RID: 54481 RVA: 0x0006790B File Offset: 0x00065B0B
			public unsafe EDrugType DrugType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.DrugTypeData.NativeFieldInfoPtr_DrugType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.DrugTypeData.NativeFieldInfoPtr_DrugType)) = value;
				}
			}

			// Token: 0x170041F4 RID: 16884
			// (get) Token: 0x0600D4D2 RID: 54482 RVA: 0x0032C370 File Offset: 0x0032A570
			// (set) Token: 0x0600D4D3 RID: 54483 RVA: 0x00067926 File Offset: 0x00065B26
			public unsafe string Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.DrugTypeData.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.DrugTypeData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170041F5 RID: 16885
			// (get) Token: 0x0600D4D4 RID: 54484 RVA: 0x0032C398 File Offset: 0x0032A598
			// (set) Token: 0x0600D4D5 RID: 54485 RVA: 0x00067945 File Offset: 0x00065B45
			public unsafe Color Color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.DrugTypeData.NativeFieldInfoPtr_Color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.DrugTypeData.NativeFieldInfoPtr_Color)) = value;
				}
			}

			// Token: 0x04008F34 RID: 36660
			private static readonly IntPtr NativeFieldInfoPtr_DrugType;

			// Token: 0x04008F35 RID: 36661
			private static readonly IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x04008F36 RID: 36662
			private static readonly IntPtr NativeFieldInfoPtr_Color;

			// Token: 0x04008F37 RID: 36663
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AD8 RID: 2776
		[ObfuscatedName("ScheduleOne.Product.PropertyUtility+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D4D6 RID: 54486 RVA: 0x0032C3C0 File Offset: 0x0032A5C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PropertyUtility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility.__c>.NativeClassPtr);
				PropertyUtility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.__c>.NativeClassPtr, "<>9");
				PropertyUtility.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.__c>.NativeClassPtr, "<>9__14_0");
				PropertyUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c>.NativeClassPtr, 100679367);
				PropertyUtility.__c.NativeMethodInfoPtr__GetOrderedPropertyColors_b__14_0_Internal_Int32_Property_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c>.NativeClassPtr, 100679368);
			}

			// Token: 0x0600D4D7 RID: 54487 RVA: 0x0032C43C File Offset: 0x0032A63C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4D8 RID: 54488 RVA: 0x0032C478 File Offset: 0x0032A678
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetOrderedPropertyColors_b__14_0(Property x, Property y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c.NativeMethodInfoPtr__GetOrderedPropertyColors_b__14_0_Internal_Int32_Property_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D4D9 RID: 54489 RVA: 0x00067960 File Offset: 0x00065B60
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041F6 RID: 16886
			// (get) Token: 0x0600D4DA RID: 54490 RVA: 0x0032C4D8 File Offset: 0x0032A6D8
			// (set) Token: 0x0600D4DB RID: 54491 RVA: 0x00067969 File Offset: 0x00065B69
			public unsafe static PropertyUtility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PropertyUtility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyUtility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PropertyUtility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041F7 RID: 16887
			// (get) Token: 0x0600D4DC RID: 54492 RVA: 0x0032C500 File Offset: 0x0032A700
			// (set) Token: 0x0600D4DD RID: 54493 RVA: 0x0006797B File Offset: 0x00065B7B
			public unsafe static Comparison<Property> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PropertyUtility.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<Property>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PropertyUtility.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F38 RID: 36664
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008F39 RID: 36665
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04008F3A RID: 36666
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F3B RID: 36667
			private static readonly IntPtr NativeMethodInfoPtr__GetOrderedPropertyColors_b__14_0_Internal_Int32_Property_Property_0;
		}

		// Token: 0x02000AD9 RID: 2777
		[ObfuscatedName("ScheduleOne.Product.PropertyUtility+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D4DE RID: 54494 RVA: 0x0032C528 File Offset: 0x0032A728
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass10_0>.NativeClassPtr);
				PropertyUtility.__c__DisplayClass10_0.NativeFieldInfoPtr_tier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass10_0>.NativeClassPtr, "tier");
				PropertyUtility.__c__DisplayClass10_0.NativeFieldInfoPtr_excludePostMixingRework = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass10_0>.NativeClassPtr, "excludePostMixingRework");
				PropertyUtility.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass10_0>.NativeClassPtr, 100679369);
				PropertyUtility.__c__DisplayClass10_0.NativeMethodInfoPtr__GetProperties_b__0_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass10_0>.NativeClassPtr, 100679370);
			}

			// Token: 0x0600D4DF RID: 54495 RVA: 0x0032C5A4 File Offset: 0x0032A7A4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4E0 RID: 54496 RVA: 0x0032C5E0 File Offset: 0x0032A7E0
			[CallerCount(0)]
			public unsafe bool _GetProperties_b__0(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass10_0.NativeMethodInfoPtr__GetProperties_b__0_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D4E1 RID: 54497 RVA: 0x0006798D File Offset: 0x00065B8D
			public __c__DisplayClass10_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041F8 RID: 16888
			// (get) Token: 0x0600D4E2 RID: 54498 RVA: 0x0032C630 File Offset: 0x0032A830
			// (set) Token: 0x0600D4E3 RID: 54499 RVA: 0x00067996 File Offset: 0x00065B96
			public unsafe int tier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass10_0.NativeFieldInfoPtr_tier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass10_0.NativeFieldInfoPtr_tier)) = value;
				}
			}

			// Token: 0x170041F9 RID: 16889
			// (get) Token: 0x0600D4E4 RID: 54500 RVA: 0x0032C658 File Offset: 0x0032A858
			// (set) Token: 0x0600D4E5 RID: 54501 RVA: 0x000679B1 File Offset: 0x00065BB1
			public unsafe bool excludePostMixingRework
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass10_0.NativeFieldInfoPtr_excludePostMixingRework);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass10_0.NativeFieldInfoPtr_excludePostMixingRework)) = value;
				}
			}

			// Token: 0x04008F3C RID: 36668
			private static readonly IntPtr NativeFieldInfoPtr_tier;

			// Token: 0x04008F3D RID: 36669
			private static readonly IntPtr NativeFieldInfoPtr_excludePostMixingRework;

			// Token: 0x04008F3E RID: 36670
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F3F RID: 36671
			private static readonly IntPtr NativeMethodInfoPtr__GetProperties_b__0_Internal_Boolean_Property_0;
		}

		// Token: 0x02000ADA RID: 2778
		[ObfuscatedName("ScheduleOne.Product.PropertyUtility+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D4E6 RID: 54502 RVA: 0x0032C680 File Offset: 0x0032A880
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_0>.NativeClassPtr);
				PropertyUtility.__c__DisplayClass11_0.NativeFieldInfoPtr_ids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_0>.NativeClassPtr, "ids");
				PropertyUtility.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_0>.NativeClassPtr, 100679371);
				PropertyUtility.__c__DisplayClass11_0.NativeMethodInfoPtr__GetProperties_b__0_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_0>.NativeClassPtr, 100679372);
			}

			// Token: 0x0600D4E7 RID: 54503 RVA: 0x0032C6E8 File Offset: 0x0032A8E8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4E8 RID: 54504 RVA: 0x0032C724 File Offset: 0x0032A924
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243657, XrefRangeEnd = 243661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetProperties_b__0(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass11_0.NativeMethodInfoPtr__GetProperties_b__0_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D4E9 RID: 54505 RVA: 0x000679CC File Offset: 0x00065BCC
			public __c__DisplayClass11_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041FA RID: 16890
			// (get) Token: 0x0600D4EA RID: 54506 RVA: 0x0032C774 File Offset: 0x0032A974
			// (set) Token: 0x0600D4EB RID: 54507 RVA: 0x000679D5 File Offset: 0x00065BD5
			public unsafe List<string> ids
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass11_0.NativeFieldInfoPtr_ids);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass11_0.NativeFieldInfoPtr_ids), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F40 RID: 36672
			private static readonly IntPtr NativeFieldInfoPtr_ids;

			// Token: 0x04008F41 RID: 36673
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F42 RID: 36674
			private static readonly IntPtr NativeMethodInfoPtr__GetProperties_b__0_Internal_Boolean_Property_0;
		}

		// Token: 0x02000ADB RID: 2779
		[ObfuscatedName("ScheduleOne.Product.PropertyUtility+<>c__DisplayClass11_1")]
		public sealed class __c__DisplayClass11_1 : Il2CppSystem.Object
		{
			// Token: 0x0600D4EC RID: 54508 RVA: 0x0032C7A4 File Offset: 0x0032A9A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_1()
			{
				Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "<>c__DisplayClass11_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_1>.NativeClassPtr);
				PropertyUtility.__c__DisplayClass11_1.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_1>.NativeClassPtr, "id");
				PropertyUtility.__c__DisplayClass11_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_1>.NativeClassPtr, 100679373);
				PropertyUtility.__c__DisplayClass11_1.NativeMethodInfoPtr__GetProperties_b__1_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_1>.NativeClassPtr, 100679374);
			}

			// Token: 0x0600D4ED RID: 54509 RVA: 0x0032C80C File Offset: 0x0032AA0C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass11_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass11_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4EE RID: 54510 RVA: 0x0032C848 File Offset: 0x0032AA48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetProperties_b__1(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass11_1.NativeMethodInfoPtr__GetProperties_b__1_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D4EF RID: 54511 RVA: 0x000679F4 File Offset: 0x00065BF4
			public __c__DisplayClass11_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041FB RID: 16891
			// (get) Token: 0x0600D4F0 RID: 54512 RVA: 0x0032C898 File Offset: 0x0032AA98
			// (set) Token: 0x0600D4F1 RID: 54513 RVA: 0x000679FD File Offset: 0x00065BFD
			public unsafe string id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass11_1.NativeFieldInfoPtr_id);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass11_1.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008F43 RID: 36675
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04008F44 RID: 36676
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F45 RID: 36677
			private static readonly IntPtr NativeMethodInfoPtr__GetProperties_b__1_Internal_Boolean_Property_0;
		}

		// Token: 0x02000ADC RID: 2780
		[ObfuscatedName("ScheduleOne.Product.PropertyUtility+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D4F2 RID: 54514 RVA: 0x0032C8C0 File Offset: 0x0032AAC0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass12_0>.NativeClassPtr);
				PropertyUtility.__c__DisplayClass12_0.NativeFieldInfoPtr_property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass12_0>.NativeClassPtr, "property");
				PropertyUtility.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass12_0>.NativeClassPtr, 100679375);
				PropertyUtility.__c__DisplayClass12_0.NativeMethodInfoPtr__GetPropertyData_b__0_Internal_Boolean_PropertyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass12_0>.NativeClassPtr, 100679376);
			}

			// Token: 0x0600D4F3 RID: 54515 RVA: 0x0032C928 File Offset: 0x0032AB28
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4F4 RID: 54516 RVA: 0x0032C964 File Offset: 0x0032AB64
			[CallerCount(0)]
			public unsafe bool _GetPropertyData_b__0(PropertyUtility.PropertyData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass12_0.NativeMethodInfoPtr__GetPropertyData_b__0_Internal_Boolean_PropertyData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D4F5 RID: 54517 RVA: 0x00067A1C File Offset: 0x00065C1C
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041FC RID: 16892
			// (get) Token: 0x0600D4F6 RID: 54518 RVA: 0x0032C9B4 File Offset: 0x0032ABB4
			// (set) Token: 0x0600D4F7 RID: 54519 RVA: 0x00067A25 File Offset: 0x00065C25
			public unsafe EProperty property
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass12_0.NativeFieldInfoPtr_property);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass12_0.NativeFieldInfoPtr_property)) = value;
				}
			}

			// Token: 0x04008F46 RID: 36678
			private static readonly IntPtr NativeFieldInfoPtr_property;

			// Token: 0x04008F47 RID: 36679
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F48 RID: 36680
			private static readonly IntPtr NativeMethodInfoPtr__GetPropertyData_b__0_Internal_Boolean_PropertyData_0;
		}

		// Token: 0x02000ADD RID: 2781
		[ObfuscatedName("ScheduleOne.Product.PropertyUtility+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D4F8 RID: 54520 RVA: 0x0032C9DC File Offset: 0x0032ABDC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyUtility>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass13_0>.NativeClassPtr);
				PropertyUtility.__c__DisplayClass13_0.NativeFieldInfoPtr_drugType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass13_0>.NativeClassPtr, "drugType");
				PropertyUtility.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass13_0>.NativeClassPtr, 100679377);
				PropertyUtility.__c__DisplayClass13_0.NativeMethodInfoPtr__GetDrugTypeData_b__0_Internal_Boolean_DrugTypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass13_0>.NativeClassPtr, 100679378);
			}

			// Token: 0x0600D4F9 RID: 54521 RVA: 0x0032CA44 File Offset: 0x0032AC44
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyUtility.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4FA RID: 54522 RVA: 0x0032CA80 File Offset: 0x0032AC80
			[CallerCount(0)]
			public unsafe bool _GetDrugTypeData_b__0(PropertyUtility.DrugTypeData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyUtility.__c__DisplayClass13_0.NativeMethodInfoPtr__GetDrugTypeData_b__0_Internal_Boolean_DrugTypeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D4FB RID: 54523 RVA: 0x00067A40 File Offset: 0x00065C40
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041FD RID: 16893
			// (get) Token: 0x0600D4FC RID: 54524 RVA: 0x0032CAD0 File Offset: 0x0032ACD0
			// (set) Token: 0x0600D4FD RID: 54525 RVA: 0x00067A49 File Offset: 0x00065C49
			public unsafe EDrugType drugType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass13_0.NativeFieldInfoPtr_drugType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyUtility.__c__DisplayClass13_0.NativeFieldInfoPtr_drugType)) = value;
				}
			}

			// Token: 0x04008F49 RID: 36681
			private static readonly IntPtr NativeFieldInfoPtr_drugType;

			// Token: 0x04008F4A RID: 36682
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F4B RID: 36683
			private static readonly IntPtr NativeMethodInfoPtr__GetDrugTypeData_b__0_Internal_Boolean_DrugTypeData_0;
		}
	}
}
