using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x0200020F RID: 527
	public class UseChemistryStationTask : Task
	{
		// Token: 0x06002BDD RID: 11229 RVA: 0x000FB6F0 File Offset: 0x000F98F0
		// Note: this type is marked as 'beforefieldinit'.
		static UseChemistryStationTask()
		{
			Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "UseChemistryStationTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr);
			UseChemistryStationTask.NativeFieldInfoPtr_STIR_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "STIR_TIME");
			UseChemistryStationTask.NativeFieldInfoPtr_TEMPERATURE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "TEMPERATURE_TIME");
			UseChemistryStationTask.NativeFieldInfoPtr__CurrentStep_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "<CurrentStep>k__BackingField");
			UseChemistryStationTask.NativeFieldInfoPtr__Station_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "<Station>k__BackingField");
			UseChemistryStationTask.NativeFieldInfoPtr__Recipe_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "<Recipe>k__BackingField");
			UseChemistryStationTask.NativeFieldInfoPtr_beaker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "beaker");
			UseChemistryStationTask.NativeFieldInfoPtr_stirringRod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "stirringRod");
			UseChemistryStationTask.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "items");
			UseChemistryStationTask.NativeFieldInfoPtr_ingredientPieces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "ingredientPieces");
			UseChemistryStationTask.NativeFieldInfoPtr_stirProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "stirProgress");
			UseChemistryStationTask.NativeFieldInfoPtr_timeInTemperatureRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "timeInTemperatureRange");
			UseChemistryStationTask.NativeFieldInfoPtr_RemovedIngredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "RemovedIngredients");
			UseChemistryStationTask.NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668233);
			UseChemistryStationTask.NativeMethodInfoPtr_set_CurrentStep_Private_set_Void_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668234);
			UseChemistryStationTask.NativeMethodInfoPtr_get_Station_Public_get_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668235);
			UseChemistryStationTask.NativeMethodInfoPtr_set_Station_Private_set_Void_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668236);
			UseChemistryStationTask.NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668237);
			UseChemistryStationTask.NativeMethodInfoPtr_set_Recipe_Private_set_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668238);
			UseChemistryStationTask.NativeMethodInfoPtr_GetStepDescription_Public_Static_String_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668239);
			UseChemistryStationTask.NativeMethodInfoPtr__ctor_Public_Void_ChemistryStation_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668240);
			UseChemistryStationTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668241);
			UseChemistryStationTask.NativeMethodInfoPtr_UpdateInstruction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668242);
			UseChemistryStationTask.NativeMethodInfoPtr_CheckProgress_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668243);
			UseChemistryStationTask.NativeMethodInfoPtr_ProgressStep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668244);
			UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_CombineIngredients_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668245);
			UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_StirMixture_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668246);
			UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_LowerBoilingFlask_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668247);
			UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_PourIntoBoilingFlask_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668248);
			UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_RaiseBoilingFlask_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668249);
			UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_StartHeat_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668250);
			UseChemistryStationTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668251);
			UseChemistryStationTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668252);
		}

		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x06002BDE RID: 11230 RVA: 0x000FB9A0 File Offset: 0x000F9BA0
		// (set) Token: 0x06002BDF RID: 11231 RVA: 0x000FB9DC File Offset: 0x000F9BDC
		public unsafe ChemistryStation.EStep CurrentStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_set_CurrentStep_Private_set_Void_EStep_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x06002BE0 RID: 11232 RVA: 0x000FBA1C File Offset: 0x000F9C1C
		// (set) Token: 0x06002BE1 RID: 11233 RVA: 0x000FBA5C File Offset: 0x000F9C5C
		public unsafe ChemistryStation Station
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 43173, RefRangeEnd = 43174, XrefRangeStart = 43173, XrefRangeEnd = 43174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_get_Station_Public_get_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChemistryStation>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_set_Station_Private_set_Void_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x06002BE2 RID: 11234 RVA: 0x000FBAA0 File Offset: 0x000F9CA0
		// (set) Token: 0x06002BE3 RID: 11235 RVA: 0x000FBAE0 File Offset: 0x000F9CE0
		public unsafe StationRecipe Recipe
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_set_Recipe_Private_set_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BE4 RID: 11236 RVA: 0x000FBB24 File Offset: 0x000F9D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122934, XrefRangeEnd = 122944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStepDescription(ChemistryStation.EStep step)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref step;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_GetStepDescription_Public_Static_String_EStep_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002BE5 RID: 11237 RVA: 0x000FBB5C File Offset: 0x000F9D5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 123088, RefRangeEnd = 123090, XrefRangeStart = 122944, XrefRangeEnd = 123088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UseChemistryStationTask(ChemistryStation station, StationRecipe recipe) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr__ctor_Public_Void_ChemistryStation_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x000FBBBC File Offset: 0x000F9DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123090, XrefRangeEnd = 123093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseChemistryStationTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x000FBBF8 File Offset: 0x000F9DF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123134, RefRangeEnd = 123135, XrefRangeStart = 123093, XrefRangeEnd = 123134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInstruction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_UpdateInstruction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x000FBC2C File Offset: 0x000F9E2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123145, RefRangeEnd = 123146, XrefRangeStart = 123135, XrefRangeEnd = 123145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_CheckProgress_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x000FBC60 File Offset: 0x000F9E60
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 123181, RefRangeEnd = 123189, XrefRangeStart = 123146, XrefRangeEnd = 123181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProgressStep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_ProgressStep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BEA RID: 11242 RVA: 0x000FBC94 File Offset: 0x000F9E94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123220, RefRangeEnd = 123221, XrefRangeStart = 123189, XrefRangeEnd = 123220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_CombineIngredients()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_CombineIngredients_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BEB RID: 11243 RVA: 0x000FBCC8 File Offset: 0x000F9EC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123239, RefRangeEnd = 123240, XrefRangeStart = 123221, XrefRangeEnd = 123239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_StirMixture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_StirMixture_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BEC RID: 11244 RVA: 0x000FBCFC File Offset: 0x000F9EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123240, XrefRangeEnd = 123243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_LowerBoilingFlask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_LowerBoilingFlask_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BED RID: 11245 RVA: 0x000FBD30 File Offset: 0x000F9F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123243, XrefRangeEnd = 123246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_PourIntoBoilingFlask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_PourIntoBoilingFlask_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BEE RID: 11246 RVA: 0x000FBD64 File Offset: 0x000F9F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123246, XrefRangeEnd = 123249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_RaiseBoilingFlask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_RaiseBoilingFlask_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BEF RID: 11247 RVA: 0x000FBD98 File Offset: 0x000F9F98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123273, RefRangeEnd = 123274, XrefRangeStart = 123249, XrefRangeEnd = 123273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_StartHeat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_StartHeat_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BF0 RID: 11248 RVA: 0x000FBDCC File Offset: 0x000F9FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123274, XrefRangeEnd = 123300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Success()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseChemistryStationTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BF1 RID: 11249 RVA: 0x000FBE08 File Offset: 0x000FA008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123300, XrefRangeEnd = 123347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseChemistryStationTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BF2 RID: 11250 RVA: 0x00017BB6 File Offset: 0x00015DB6
		public UseChemistryStationTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x06002BF3 RID: 11251 RVA: 0x000FBE44 File Offset: 0x000FA044
		// (set) Token: 0x06002BF4 RID: 11252 RVA: 0x00017BBF File Offset: 0x00015DBF
		public unsafe static float STIR_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UseChemistryStationTask.NativeFieldInfoPtr_STIR_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UseChemistryStationTask.NativeFieldInfoPtr_STIR_TIME, (void*)(&value));
			}
		}

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x06002BF5 RID: 11253 RVA: 0x000FBE60 File Offset: 0x000FA060
		// (set) Token: 0x06002BF6 RID: 11254 RVA: 0x00017BCD File Offset: 0x00015DCD
		public unsafe static float TEMPERATURE_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UseChemistryStationTask.NativeFieldInfoPtr_TEMPERATURE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UseChemistryStationTask.NativeFieldInfoPtr_TEMPERATURE_TIME, (void*)(&value));
			}
		}

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x06002BF7 RID: 11255 RVA: 0x000FBE7C File Offset: 0x000FA07C
		// (set) Token: 0x06002BF8 RID: 11256 RVA: 0x00017BDB File Offset: 0x00015DDB
		public unsafe ChemistryStation.EStep _CurrentStep_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr__CurrentStep_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr__CurrentStep_k__BackingField)) = value;
			}
		}

		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x06002BF9 RID: 11257 RVA: 0x000FBEA4 File Offset: 0x000FA0A4
		// (set) Token: 0x06002BFA RID: 11258 RVA: 0x00017BF6 File Offset: 0x00015DF6
		public unsafe ChemistryStation _Station_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr__Station_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChemistryStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr__Station_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x06002BFB RID: 11259 RVA: 0x000FBED4 File Offset: 0x000FA0D4
		// (set) Token: 0x06002BFC RID: 11260 RVA: 0x00017C15 File Offset: 0x00015E15
		public unsafe StationRecipe _Recipe_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr__Recipe_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr__Recipe_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x06002BFD RID: 11261 RVA: 0x000FBF04 File Offset: 0x000FA104
		// (set) Token: 0x06002BFE RID: 11262 RVA: 0x00017C34 File Offset: 0x00015E34
		public unsafe Beaker beaker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_beaker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Beaker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_beaker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x06002BFF RID: 11263 RVA: 0x000FBF34 File Offset: 0x000FA134
		// (set) Token: 0x06002C00 RID: 11264 RVA: 0x00017C53 File Offset: 0x00015E53
		public unsafe StirringRod stirringRod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_stirringRod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StirringRod>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_stirringRod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x06002C01 RID: 11265 RVA: 0x000FBF64 File Offset: 0x000FA164
		// (set) Token: 0x06002C02 RID: 11266 RVA: 0x00017C72 File Offset: 0x00015E72
		public unsafe List<StationItem> items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x06002C03 RID: 11267 RVA: 0x000FBF94 File Offset: 0x000FA194
		// (set) Token: 0x06002C04 RID: 11268 RVA: 0x00017C91 File Offset: 0x00015E91
		public unsafe List<IngredientPiece> ingredientPieces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_ingredientPieces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IngredientPiece>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_ingredientPieces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x06002C05 RID: 11269 RVA: 0x000FBFC4 File Offset: 0x000FA1C4
		// (set) Token: 0x06002C06 RID: 11270 RVA: 0x00017CB0 File Offset: 0x00015EB0
		public unsafe float stirProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_stirProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_stirProgress)) = value;
			}
		}

		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x06002C07 RID: 11271 RVA: 0x000FBFEC File Offset: 0x000FA1EC
		// (set) Token: 0x06002C08 RID: 11272 RVA: 0x00017CCB File Offset: 0x00015ECB
		public unsafe float timeInTemperatureRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_timeInTemperatureRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_timeInTemperatureRange)) = value;
			}
		}

		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x06002C09 RID: 11273 RVA: 0x000FC014 File Offset: 0x000FA214
		// (set) Token: 0x06002C0A RID: 11274 RVA: 0x00017CE6 File Offset: 0x00015EE6
		public unsafe Il2CppReferenceArray<ItemInstance> RemovedIngredients
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_RemovedIngredients);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_RemovedIngredients), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D18 RID: 7448
		private static readonly IntPtr NativeFieldInfoPtr_STIR_TIME;

		// Token: 0x04001D19 RID: 7449
		private static readonly IntPtr NativeFieldInfoPtr_TEMPERATURE_TIME;

		// Token: 0x04001D1A RID: 7450
		private static readonly IntPtr NativeFieldInfoPtr__CurrentStep_k__BackingField;

		// Token: 0x04001D1B RID: 7451
		private static readonly IntPtr NativeFieldInfoPtr__Station_k__BackingField;

		// Token: 0x04001D1C RID: 7452
		private static readonly IntPtr NativeFieldInfoPtr__Recipe_k__BackingField;

		// Token: 0x04001D1D RID: 7453
		private static readonly IntPtr NativeFieldInfoPtr_beaker;

		// Token: 0x04001D1E RID: 7454
		private static readonly IntPtr NativeFieldInfoPtr_stirringRod;

		// Token: 0x04001D1F RID: 7455
		private static readonly IntPtr NativeFieldInfoPtr_items;

		// Token: 0x04001D20 RID: 7456
		private static readonly IntPtr NativeFieldInfoPtr_ingredientPieces;

		// Token: 0x04001D21 RID: 7457
		private static readonly IntPtr NativeFieldInfoPtr_stirProgress;

		// Token: 0x04001D22 RID: 7458
		private static readonly IntPtr NativeFieldInfoPtr_timeInTemperatureRange;

		// Token: 0x04001D23 RID: 7459
		private static readonly IntPtr NativeFieldInfoPtr_RemovedIngredients;

		// Token: 0x04001D24 RID: 7460
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0;

		// Token: 0x04001D25 RID: 7461
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentStep_Private_set_Void_EStep_0;

		// Token: 0x04001D26 RID: 7462
		private static readonly IntPtr NativeMethodInfoPtr_get_Station_Public_get_ChemistryStation_0;

		// Token: 0x04001D27 RID: 7463
		private static readonly IntPtr NativeMethodInfoPtr_set_Station_Private_set_Void_ChemistryStation_0;

		// Token: 0x04001D28 RID: 7464
		private static readonly IntPtr NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0;

		// Token: 0x04001D29 RID: 7465
		private static readonly IntPtr NativeMethodInfoPtr_set_Recipe_Private_set_Void_StationRecipe_0;

		// Token: 0x04001D2A RID: 7466
		private static readonly IntPtr NativeMethodInfoPtr_GetStepDescription_Public_Static_String_EStep_0;

		// Token: 0x04001D2B RID: 7467
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ChemistryStation_StationRecipe_0;

		// Token: 0x04001D2C RID: 7468
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001D2D RID: 7469
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInstruction_Private_Void_0;

		// Token: 0x04001D2E RID: 7470
		private static readonly IntPtr NativeMethodInfoPtr_CheckProgress_Private_Void_0;

		// Token: 0x04001D2F RID: 7471
		private static readonly IntPtr NativeMethodInfoPtr_ProgressStep_Private_Void_0;

		// Token: 0x04001D30 RID: 7472
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_CombineIngredients_Private_Void_0;

		// Token: 0x04001D31 RID: 7473
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_StirMixture_Private_Void_0;

		// Token: 0x04001D32 RID: 7474
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_LowerBoilingFlask_Private_Void_0;

		// Token: 0x04001D33 RID: 7475
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_PourIntoBoilingFlask_Private_Void_0;

		// Token: 0x04001D34 RID: 7476
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_RaiseBoilingFlask_Private_Void_0;

		// Token: 0x04001D35 RID: 7477
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_StartHeat_Private_Void_0;

		// Token: 0x04001D36 RID: 7478
		private static readonly IntPtr NativeMethodInfoPtr_Success_Public_Virtual_Void_0;

		// Token: 0x04001D37 RID: 7479
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;
	}
}
