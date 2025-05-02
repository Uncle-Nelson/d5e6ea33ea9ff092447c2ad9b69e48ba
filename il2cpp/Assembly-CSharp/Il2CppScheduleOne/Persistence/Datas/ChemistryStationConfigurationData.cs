using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000276 RID: 630
	[Serializable]
	public class ChemistryStationConfigurationData : SaveData
	{
		// Token: 0x06002F92 RID: 12178 RVA: 0x001080C4 File Offset: 0x001062C4
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistryStationConfigurationData()
		{
			Il2CppClassPointerStore<ChemistryStationConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ChemistryStationConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistryStationConfigurationData>.NativeClassPtr);
			ChemistryStationConfigurationData.NativeFieldInfoPtr_Recipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationConfigurationData>.NativeClassPtr, "Recipe");
			ChemistryStationConfigurationData.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationConfigurationData>.NativeClassPtr, "Destination");
			ChemistryStationConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_StationRecipeFieldData_ObjectFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationConfigurationData>.NativeClassPtr, 100668781);
		}

		// Token: 0x06002F93 RID: 12179 RVA: 0x00108130 File Offset: 0x00106330
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 130739, RefRangeEnd = 130748, XrefRangeStart = 130739, XrefRangeEnd = 130748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistryStationConfigurationData(StationRecipeFieldData recipe, ObjectFieldData destination) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryStationConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_StationRecipeFieldData_ObjectFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F94 RID: 12180 RVA: 0x0001931F File Offset: 0x0001751F
		public ChemistryStationConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F88 RID: 3976
		// (get) Token: 0x06002F95 RID: 12181 RVA: 0x00108190 File Offset: 0x00106390
		// (set) Token: 0x06002F96 RID: 12182 RVA: 0x00019328 File Offset: 0x00017528
		public unsafe StationRecipeFieldData Recipe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfigurationData.NativeFieldInfoPtr_Recipe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfigurationData.NativeFieldInfoPtr_Recipe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x06002F97 RID: 12183 RVA: 0x001081C0 File Offset: 0x001063C0
		// (set) Token: 0x06002F98 RID: 12184 RVA: 0x00019347 File Offset: 0x00017547
		public unsafe ObjectFieldData Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfigurationData.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfigurationData.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F53 RID: 8019
		private static readonly IntPtr NativeFieldInfoPtr_Recipe;

		// Token: 0x04001F54 RID: 8020
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04001F55 RID: 8021
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StationRecipeFieldData_ObjectFieldData_0;
	}
}
