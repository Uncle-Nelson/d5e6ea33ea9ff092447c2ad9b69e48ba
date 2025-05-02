using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002A7 RID: 679
	[Serializable]
	public class PlantData : SaveData
	{
		// Token: 0x06003126 RID: 12582 RVA: 0x0010CA1C File Offset: 0x0010AC1C
		// Note: this type is marked as 'beforefieldinit'.
		static PlantData()
		{
			Il2CppClassPointerStore<PlantData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "PlantData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlantData>.NativeClassPtr);
			PlantData.NativeFieldInfoPtr_SeedID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantData>.NativeClassPtr, "SeedID");
			PlantData.NativeFieldInfoPtr_GrowthProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantData>.NativeClassPtr, "GrowthProgress");
			PlantData.NativeFieldInfoPtr_YieldLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantData>.NativeClassPtr, "YieldLevel");
			PlantData.NativeFieldInfoPtr_QualityLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantData>.NativeClassPtr, "QualityLevel");
			PlantData.NativeFieldInfoPtr_ActiveBuds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantData>.NativeClassPtr, "ActiveBuds");
			PlantData.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_Single_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlantData>.NativeClassPtr, 100668831);
		}

		// Token: 0x06003127 RID: 12583 RVA: 0x0010CAC4 File Offset: 0x0010ACC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131093, RefRangeEnd = 131094, XrefRangeStart = 131090, XrefRangeEnd = 131093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlantData(string seedID, float growthProgress, float yieldLevel, float qualityLevel, Il2CppStructArray<int> activeBuds) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlantData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(seedID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref growthProgress;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yieldLevel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref qualityLevel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activeBuds);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlantData.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_Single_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003128 RID: 12584 RVA: 0x0001A394 File Offset: 0x00018594
		public PlantData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001008 RID: 4104
		// (get) Token: 0x06003129 RID: 12585 RVA: 0x0010CB4C File Offset: 0x0010AD4C
		// (set) Token: 0x0600312A RID: 12586 RVA: 0x0001A39D File Offset: 0x0001859D
		public unsafe string SeedID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_SeedID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_SeedID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001009 RID: 4105
		// (get) Token: 0x0600312B RID: 12587 RVA: 0x0010CB74 File Offset: 0x0010AD74
		// (set) Token: 0x0600312C RID: 12588 RVA: 0x0001A3BC File Offset: 0x000185BC
		public unsafe float GrowthProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_GrowthProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_GrowthProgress)) = value;
			}
		}

		// Token: 0x1700100A RID: 4106
		// (get) Token: 0x0600312D RID: 12589 RVA: 0x0010CB9C File Offset: 0x0010AD9C
		// (set) Token: 0x0600312E RID: 12590 RVA: 0x0001A3D7 File Offset: 0x000185D7
		public unsafe float YieldLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_YieldLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_YieldLevel)) = value;
			}
		}

		// Token: 0x1700100B RID: 4107
		// (get) Token: 0x0600312F RID: 12591 RVA: 0x0010CBC4 File Offset: 0x0010ADC4
		// (set) Token: 0x06003130 RID: 12592 RVA: 0x0001A3F2 File Offset: 0x000185F2
		public unsafe float QualityLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_QualityLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_QualityLevel)) = value;
			}
		}

		// Token: 0x1700100C RID: 4108
		// (get) Token: 0x06003131 RID: 12593 RVA: 0x0010CBEC File Offset: 0x0010ADEC
		// (set) Token: 0x06003132 RID: 12594 RVA: 0x0001A40D File Offset: 0x0001860D
		public unsafe Il2CppStructArray<int> ActiveBuds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_ActiveBuds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_ActiveBuds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002005 RID: 8197
		private static readonly IntPtr NativeFieldInfoPtr_SeedID;

		// Token: 0x04002006 RID: 8198
		private static readonly IntPtr NativeFieldInfoPtr_GrowthProgress;

		// Token: 0x04002007 RID: 8199
		private static readonly IntPtr NativeFieldInfoPtr_YieldLevel;

		// Token: 0x04002008 RID: 8200
		private static readonly IntPtr NativeFieldInfoPtr_QualityLevel;

		// Token: 0x04002009 RID: 8201
		private static readonly IntPtr NativeFieldInfoPtr_ActiveBuds;

		// Token: 0x0400200A RID: 8202
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_Single_Il2CppStructArray_1_Int32_0;
	}
}
