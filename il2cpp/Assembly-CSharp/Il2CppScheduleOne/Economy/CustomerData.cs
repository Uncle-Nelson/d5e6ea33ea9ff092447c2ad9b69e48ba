using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Properties;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x02000410 RID: 1040
	[Serializable]
	public class CustomerData : ScriptableObject
	{
		// Token: 0x06005A2E RID: 23086 RVA: 0x001A3A78 File Offset: 0x001A1C78
		// Note: this type is marked as 'beforefieldinit'.
		static CustomerData()
		{
			Il2CppClassPointerStore<CustomerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "CustomerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomerData>.NativeClassPtr);
			CustomerData.NativeFieldInfoPtr_DefaultAffinityData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "DefaultAffinityData");
			CustomerData.NativeFieldInfoPtr_PreferredProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "PreferredProperties");
			CustomerData.NativeFieldInfoPtr_MinWeeklySpend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "MinWeeklySpend");
			CustomerData.NativeFieldInfoPtr_MaxWeeklySpend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "MaxWeeklySpend");
			CustomerData.NativeFieldInfoPtr_MinOrdersPerWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "MinOrdersPerWeek");
			CustomerData.NativeFieldInfoPtr_MaxOrdersPerWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "MaxOrdersPerWeek");
			CustomerData.NativeFieldInfoPtr_OrderTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "OrderTime");
			CustomerData.NativeFieldInfoPtr_PreferredOrderDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "PreferredOrderDay");
			CustomerData.NativeFieldInfoPtr_Standards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "Standards");
			CustomerData.NativeFieldInfoPtr_CanBeDirectlyApproached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "CanBeDirectlyApproached");
			CustomerData.NativeFieldInfoPtr_GuaranteeFirstSampleSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "GuaranteeFirstSampleSuccess");
			CustomerData.NativeFieldInfoPtr_MinMutualRelationRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "MinMutualRelationRequirement");
			CustomerData.NativeFieldInfoPtr_MaxMutualRelationRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "MaxMutualRelationRequirement");
			CustomerData.NativeFieldInfoPtr_CallPoliceChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "CallPoliceChance");
			CustomerData.NativeFieldInfoPtr_DependenceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "DependenceMultiplier");
			CustomerData.NativeFieldInfoPtr_BaseAddiction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "BaseAddiction");
			CustomerData.NativeFieldInfoPtr_onChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "onChanged");
			CustomerData.NativeMethodInfoPtr_GetQualityScalar_Public_Static_Single_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100674788);
			CustomerData.NativeMethodInfoPtr_GetOrderDays_Public_List_1_EDay_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100674789);
			CustomerData.NativeMethodInfoPtr_GetAdjustedWeeklySpend_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100674790);
			CustomerData.NativeMethodInfoPtr_RandomizeAffinities_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100674791);
			CustomerData.NativeMethodInfoPtr_RandomizeProperties_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100674792);
			CustomerData.NativeMethodInfoPtr_RandomizeTiming_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100674793);
			CustomerData.NativeMethodInfoPtr_ClearInvalid_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100674794);
			CustomerData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100674795);
		}

		// Token: 0x06005A2F RID: 23087 RVA: 0x001A3C9C File Offset: 0x001A1E9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 190605, RefRangeEnd = 190607, XrefRangeStart = 190605, XrefRangeEnd = 190605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetQualityScalar(EQuality quality)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr_GetQualityScalar_Public_Static_Single_EQuality_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005A30 RID: 23088 RVA: 0x001A3CDC File Offset: 0x001A1EDC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 190620, RefRangeEnd = 190623, XrefRangeStart = 190607, XrefRangeEnd = 190620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<EDay> GetOrderDays(float dependence, float normalizedRelationship)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dependence;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalizedRelationship;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr_GetOrderDays_Public_List_1_EDay_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<EDay>>(intPtr3) : null;
		}

		// Token: 0x06005A31 RID: 23089 RVA: 0x001A3D38 File Offset: 0x001A1F38
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 190630, RefRangeEnd = 190633, XrefRangeStart = 190623, XrefRangeEnd = 190630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAdjustedWeeklySpend(float normalizedRelationship)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref normalizedRelationship;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr_GetAdjustedWeeklySpend_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005A32 RID: 23090 RVA: 0x001A3D84 File Offset: 0x001A1F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190633, XrefRangeEnd = 190681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeAffinities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr_RandomizeAffinities_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A33 RID: 23091 RVA: 0x001A3DB8 File Offset: 0x001A1FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190681, XrefRangeEnd = 190727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr_RandomizeProperties_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A34 RID: 23092 RVA: 0x001A3DEC File Offset: 0x001A1FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190727, XrefRangeEnd = 190731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeTiming()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr_RandomizeTiming_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A35 RID: 23093 RVA: 0x001A3E20 File Offset: 0x001A2020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190731, XrefRangeEnd = 190736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearInvalid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr_ClearInvalid_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A36 RID: 23094 RVA: 0x001A3E54 File Offset: 0x001A2054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190736, XrefRangeEnd = 190744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomerData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A37 RID: 23095 RVA: 0x0002A967 File Offset: 0x00028B67
		public CustomerData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B2B RID: 6955
		// (get) Token: 0x06005A38 RID: 23096 RVA: 0x001A3E90 File Offset: 0x001A2090
		// (set) Token: 0x06005A39 RID: 23097 RVA: 0x0002A970 File Offset: 0x00028B70
		public unsafe CustomerAffinityData DefaultAffinityData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_DefaultAffinityData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomerAffinityData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_DefaultAffinityData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B2C RID: 6956
		// (get) Token: 0x06005A3A RID: 23098 RVA: 0x001A3EC0 File Offset: 0x001A20C0
		// (set) Token: 0x06005A3B RID: 23099 RVA: 0x0002A98F File Offset: 0x00028B8F
		public unsafe List<Property> PreferredProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_PreferredProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_PreferredProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B2D RID: 6957
		// (get) Token: 0x06005A3C RID: 23100 RVA: 0x001A3EF0 File Offset: 0x001A20F0
		// (set) Token: 0x06005A3D RID: 23101 RVA: 0x0002A9AE File Offset: 0x00028BAE
		public unsafe float MinWeeklySpend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MinWeeklySpend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MinWeeklySpend)) = value;
			}
		}

		// Token: 0x17001B2E RID: 6958
		// (get) Token: 0x06005A3E RID: 23102 RVA: 0x001A3F18 File Offset: 0x001A2118
		// (set) Token: 0x06005A3F RID: 23103 RVA: 0x0002A9C9 File Offset: 0x00028BC9
		public unsafe float MaxWeeklySpend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MaxWeeklySpend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MaxWeeklySpend)) = value;
			}
		}

		// Token: 0x17001B2F RID: 6959
		// (get) Token: 0x06005A40 RID: 23104 RVA: 0x001A3F40 File Offset: 0x001A2140
		// (set) Token: 0x06005A41 RID: 23105 RVA: 0x0002A9E4 File Offset: 0x00028BE4
		public unsafe int MinOrdersPerWeek
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MinOrdersPerWeek);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MinOrdersPerWeek)) = value;
			}
		}

		// Token: 0x17001B30 RID: 6960
		// (get) Token: 0x06005A42 RID: 23106 RVA: 0x001A3F68 File Offset: 0x001A2168
		// (set) Token: 0x06005A43 RID: 23107 RVA: 0x0002A9FF File Offset: 0x00028BFF
		public unsafe int MaxOrdersPerWeek
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MaxOrdersPerWeek);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MaxOrdersPerWeek)) = value;
			}
		}

		// Token: 0x17001B31 RID: 6961
		// (get) Token: 0x06005A44 RID: 23108 RVA: 0x001A3F90 File Offset: 0x001A2190
		// (set) Token: 0x06005A45 RID: 23109 RVA: 0x0002AA1A File Offset: 0x00028C1A
		public unsafe int OrderTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_OrderTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_OrderTime)) = value;
			}
		}

		// Token: 0x17001B32 RID: 6962
		// (get) Token: 0x06005A46 RID: 23110 RVA: 0x001A3FB8 File Offset: 0x001A21B8
		// (set) Token: 0x06005A47 RID: 23111 RVA: 0x0002AA35 File Offset: 0x00028C35
		public unsafe EDay PreferredOrderDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_PreferredOrderDay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_PreferredOrderDay)) = value;
			}
		}

		// Token: 0x17001B33 RID: 6963
		// (get) Token: 0x06005A48 RID: 23112 RVA: 0x001A3FE0 File Offset: 0x001A21E0
		// (set) Token: 0x06005A49 RID: 23113 RVA: 0x0002AA50 File Offset: 0x00028C50
		public unsafe ECustomerStandard Standards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_Standards);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_Standards)) = value;
			}
		}

		// Token: 0x17001B34 RID: 6964
		// (get) Token: 0x06005A4A RID: 23114 RVA: 0x001A4008 File Offset: 0x001A2208
		// (set) Token: 0x06005A4B RID: 23115 RVA: 0x0002AA6B File Offset: 0x00028C6B
		public unsafe bool CanBeDirectlyApproached
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_CanBeDirectlyApproached);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_CanBeDirectlyApproached)) = value;
			}
		}

		// Token: 0x17001B35 RID: 6965
		// (get) Token: 0x06005A4C RID: 23116 RVA: 0x001A4030 File Offset: 0x001A2230
		// (set) Token: 0x06005A4D RID: 23117 RVA: 0x0002AA86 File Offset: 0x00028C86
		public unsafe bool GuaranteeFirstSampleSuccess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_GuaranteeFirstSampleSuccess);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_GuaranteeFirstSampleSuccess)) = value;
			}
		}

		// Token: 0x17001B36 RID: 6966
		// (get) Token: 0x06005A4E RID: 23118 RVA: 0x001A4058 File Offset: 0x001A2258
		// (set) Token: 0x06005A4F RID: 23119 RVA: 0x0002AAA1 File Offset: 0x00028CA1
		public unsafe float MinMutualRelationRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MinMutualRelationRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MinMutualRelationRequirement)) = value;
			}
		}

		// Token: 0x17001B37 RID: 6967
		// (get) Token: 0x06005A50 RID: 23120 RVA: 0x001A4080 File Offset: 0x001A2280
		// (set) Token: 0x06005A51 RID: 23121 RVA: 0x0002AABC File Offset: 0x00028CBC
		public unsafe float MaxMutualRelationRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MaxMutualRelationRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MaxMutualRelationRequirement)) = value;
			}
		}

		// Token: 0x17001B38 RID: 6968
		// (get) Token: 0x06005A52 RID: 23122 RVA: 0x001A40A8 File Offset: 0x001A22A8
		// (set) Token: 0x06005A53 RID: 23123 RVA: 0x0002AAD7 File Offset: 0x00028CD7
		public unsafe float CallPoliceChance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_CallPoliceChance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_CallPoliceChance)) = value;
			}
		}

		// Token: 0x17001B39 RID: 6969
		// (get) Token: 0x06005A54 RID: 23124 RVA: 0x001A40D0 File Offset: 0x001A22D0
		// (set) Token: 0x06005A55 RID: 23125 RVA: 0x0002AAF2 File Offset: 0x00028CF2
		public unsafe float DependenceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_DependenceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_DependenceMultiplier)) = value;
			}
		}

		// Token: 0x17001B3A RID: 6970
		// (get) Token: 0x06005A56 RID: 23126 RVA: 0x001A40F8 File Offset: 0x001A22F8
		// (set) Token: 0x06005A57 RID: 23127 RVA: 0x0002AB0D File Offset: 0x00028D0D
		public unsafe float BaseAddiction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_BaseAddiction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_BaseAddiction)) = value;
			}
		}

		// Token: 0x17001B3B RID: 6971
		// (get) Token: 0x06005A58 RID: 23128 RVA: 0x001A4120 File Offset: 0x001A2320
		// (set) Token: 0x06005A59 RID: 23129 RVA: 0x0002AB28 File Offset: 0x00028D28
		public unsafe Action onChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_onChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_onChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003D94 RID: 15764
		private static readonly IntPtr NativeFieldInfoPtr_DefaultAffinityData;

		// Token: 0x04003D95 RID: 15765
		private static readonly IntPtr NativeFieldInfoPtr_PreferredProperties;

		// Token: 0x04003D96 RID: 15766
		private static readonly IntPtr NativeFieldInfoPtr_MinWeeklySpend;

		// Token: 0x04003D97 RID: 15767
		private static readonly IntPtr NativeFieldInfoPtr_MaxWeeklySpend;

		// Token: 0x04003D98 RID: 15768
		private static readonly IntPtr NativeFieldInfoPtr_MinOrdersPerWeek;

		// Token: 0x04003D99 RID: 15769
		private static readonly IntPtr NativeFieldInfoPtr_MaxOrdersPerWeek;

		// Token: 0x04003D9A RID: 15770
		private static readonly IntPtr NativeFieldInfoPtr_OrderTime;

		// Token: 0x04003D9B RID: 15771
		private static readonly IntPtr NativeFieldInfoPtr_PreferredOrderDay;

		// Token: 0x04003D9C RID: 15772
		private static readonly IntPtr NativeFieldInfoPtr_Standards;

		// Token: 0x04003D9D RID: 15773
		private static readonly IntPtr NativeFieldInfoPtr_CanBeDirectlyApproached;

		// Token: 0x04003D9E RID: 15774
		private static readonly IntPtr NativeFieldInfoPtr_GuaranteeFirstSampleSuccess;

		// Token: 0x04003D9F RID: 15775
		private static readonly IntPtr NativeFieldInfoPtr_MinMutualRelationRequirement;

		// Token: 0x04003DA0 RID: 15776
		private static readonly IntPtr NativeFieldInfoPtr_MaxMutualRelationRequirement;

		// Token: 0x04003DA1 RID: 15777
		private static readonly IntPtr NativeFieldInfoPtr_CallPoliceChance;

		// Token: 0x04003DA2 RID: 15778
		private static readonly IntPtr NativeFieldInfoPtr_DependenceMultiplier;

		// Token: 0x04003DA3 RID: 15779
		private static readonly IntPtr NativeFieldInfoPtr_BaseAddiction;

		// Token: 0x04003DA4 RID: 15780
		private static readonly IntPtr NativeFieldInfoPtr_onChanged;

		// Token: 0x04003DA5 RID: 15781
		private static readonly IntPtr NativeMethodInfoPtr_GetQualityScalar_Public_Static_Single_EQuality_0;

		// Token: 0x04003DA6 RID: 15782
		private static readonly IntPtr NativeMethodInfoPtr_GetOrderDays_Public_List_1_EDay_Single_Single_0;

		// Token: 0x04003DA7 RID: 15783
		private static readonly IntPtr NativeMethodInfoPtr_GetAdjustedWeeklySpend_Public_Single_Single_0;

		// Token: 0x04003DA8 RID: 15784
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeAffinities_Public_Void_0;

		// Token: 0x04003DA9 RID: 15785
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeProperties_Public_Void_0;

		// Token: 0x04003DAA RID: 15786
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeTiming_Public_Void_0;

		// Token: 0x04003DAB RID: 15787
		private static readonly IntPtr NativeMethodInfoPtr_ClearInvalid_Public_Void_0;

		// Token: 0x04003DAC RID: 15788
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
