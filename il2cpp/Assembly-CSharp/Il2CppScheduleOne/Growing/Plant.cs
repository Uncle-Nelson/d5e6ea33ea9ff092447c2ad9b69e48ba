using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Trash;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x0200055A RID: 1370
	public class Plant : MonoBehaviour
	{
		// Token: 0x06007875 RID: 30837 RVA: 0x00208F0C File Offset: 0x0020710C
		// Note: this type is marked as 'beforefieldinit'.
		static Plant()
		{
			Il2CppClassPointerStore<Plant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "Plant");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Plant>.NativeClassPtr);
			Plant.NativeFieldInfoPtr__Pot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "<Pot>k__BackingField");
			Plant.NativeFieldInfoPtr__NormalizedGrowthProgress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "<NormalizedGrowthProgress>k__BackingField");
			Plant.NativeFieldInfoPtr_VisualsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "VisualsContainer");
			Plant.NativeFieldInfoPtr_GrowthStages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "GrowthStages");
			Plant.NativeFieldInfoPtr_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "Collider");
			Plant.NativeFieldInfoPtr_SnipSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "SnipSound");
			Plant.NativeFieldInfoPtr_DestroySound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "DestroySound");
			Plant.NativeFieldInfoPtr_FullyGrownParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "FullyGrownParticles");
			Plant.NativeFieldInfoPtr_SeedDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "SeedDefinition");
			Plant.NativeFieldInfoPtr_GrowthTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "GrowthTime");
			Plant.NativeFieldInfoPtr_BaseYieldLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "BaseYieldLevel");
			Plant.NativeFieldInfoPtr_BaseQualityLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "BaseQualityLevel");
			Plant.NativeFieldInfoPtr_HarvestTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "HarvestTarget");
			Plant.NativeFieldInfoPtr_PlantScrapPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "PlantScrapPrefab");
			Plant.NativeFieldInfoPtr_onGrowthDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "onGrowthDone");
			Plant.NativeFieldInfoPtr_YieldLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "YieldLevel");
			Plant.NativeFieldInfoPtr_QualityLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "QualityLevel");
			Plant.NativeFieldInfoPtr_ActiveHarvestables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "ActiveHarvestables");
			Plant.NativeMethodInfoPtr_get_Pot_Public_get_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678417);
			Plant.NativeMethodInfoPtr_set_Pot_Protected_set_Void_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678418);
			Plant.NativeMethodInfoPtr_get_NormalizedGrowthProgress_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678419);
			Plant.NativeMethodInfoPtr_set_NormalizedGrowthProgress_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678420);
			Plant.NativeMethodInfoPtr_get_IsFullyGrown_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678421);
			Plant.NativeMethodInfoPtr_get_FinalGrowthStage_Public_get_PlantGrowthStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678422);
			Plant.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_NetworkObject_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678423);
			Plant.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678424);
			Plant.NativeMethodInfoPtr_MinPass_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678425);
			Plant.NativeMethodInfoPtr_SetNormalizedGrowthProgress_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678426);
			Plant.NativeMethodInfoPtr_UpdateVisuals_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678427);
			Plant.NativeMethodInfoPtr_SetHarvestableActive_Public_Virtual_New_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678428);
			Plant.NativeMethodInfoPtr_IsHarvestableActive_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678429);
			Plant.NativeMethodInfoPtr_GrowthDone_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678430);
			Plant.NativeMethodInfoPtr_GenerateUniqueIntegers_Private_List_1_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678431);
			Plant.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678432);
			Plant.NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_New_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678433);
			Plant.NativeMethodInfoPtr_GetPlantData_Public_PlantData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678434);
			Plant.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678435);
		}

		// Token: 0x1700247B RID: 9339
		// (get) Token: 0x06007876 RID: 30838 RVA: 0x00209220 File Offset: 0x00207420
		// (set) Token: 0x06007877 RID: 30839 RVA: 0x00209260 File Offset: 0x00207460
		public unsafe Pot Pot
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_get_Pot_Public_get_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_set_Pot_Protected_set_Void_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700247C RID: 9340
		// (get) Token: 0x06007878 RID: 30840 RVA: 0x002092A4 File Offset: 0x002074A4
		// (set) Token: 0x06007879 RID: 30841 RVA: 0x002092E0 File Offset: 0x002074E0
		public unsafe float NormalizedGrowthProgress
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 59852, RefRangeEnd = 59853, XrefRangeStart = 59852, XrefRangeEnd = 59853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_get_NormalizedGrowthProgress_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_set_NormalizedGrowthProgress_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700247D RID: 9341
		// (get) Token: 0x0600787A RID: 30842 RVA: 0x00209320 File Offset: 0x00207520
		public unsafe bool IsFullyGrown
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 232581, RefRangeEnd = 232586, XrefRangeStart = 232581, XrefRangeEnd = 232581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_get_IsFullyGrown_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700247E RID: 9342
		// (get) Token: 0x0600787B RID: 30843 RVA: 0x0020935C File Offset: 0x0020755C
		public unsafe PlantGrowthStage FinalGrowthStage
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 232586, RefRangeEnd = 232587, XrefRangeStart = 232586, XrefRangeEnd = 232586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_get_FinalGrowthStage_Public_get_PlantGrowthStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlantGrowthStage>(intPtr3) : null;
			}
		}

		// Token: 0x0600787C RID: 30844 RVA: 0x0020939C File Offset: 0x0020759C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232587, XrefRangeEnd = 232598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(NetworkObject pot, float growthProgress = 0f, float yieldLevel = 0f, float qualityLevel = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref growthProgress;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yieldLevel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref qualityLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Plant.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_NetworkObject_Single_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600787D RID: 30845 RVA: 0x00209414 File Offset: 0x00207614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232598, XrefRangeEnd = 232629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Destroy(bool dropScraps = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dropScraps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Plant.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600787E RID: 30846 RVA: 0x00209460 File Offset: 0x00207660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232629, XrefRangeEnd = 232639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Plant.NativeMethodInfoPtr_MinPass_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600787F RID: 30847 RVA: 0x0020949C File Offset: 0x0020769C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232639, XrefRangeEnd = 232641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetNormalizedGrowthProgress(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Plant.NativeMethodInfoPtr_SetNormalizedGrowthProgress_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007880 RID: 30848 RVA: 0x002094E8 File Offset: 0x002076E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232641, XrefRangeEnd = 232648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Plant.NativeMethodInfoPtr_UpdateVisuals_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007881 RID: 30849 RVA: 0x00209524 File Offset: 0x00207724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232648, XrefRangeEnd = 232656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetHarvestableActive(int index, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Plant.NativeMethodInfoPtr_SetHarvestableActive_Public_Virtual_New_Void_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007882 RID: 30850 RVA: 0x0020957C File Offset: 0x0020777C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 232660, RefRangeEnd = 232661, XrefRangeStart = 232656, XrefRangeEnd = 232660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsHarvestableActive(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_IsHarvestableActive_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007883 RID: 30851 RVA: 0x002095C8 File Offset: 0x002077C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 232689, RefRangeEnd = 232690, XrefRangeStart = 232661, XrefRangeEnd = 232689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GrowthDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_GrowthDone_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007884 RID: 30852 RVA: 0x002095FC File Offset: 0x002077FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 232717, RefRangeEnd = 232718, XrefRangeStart = 232690, XrefRangeEnd = 232717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<int> GenerateUniqueIntegers(int min, int max, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref min;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_GenerateUniqueIntegers_Private_List_1_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
		}

		// Token: 0x06007885 RID: 30853 RVA: 0x00209664 File Offset: 0x00207864
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 232721, RefRangeEnd = 232723, XrefRangeStart = 232718, XrefRangeEnd = 232721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007886 RID: 30854 RVA: 0x002096A4 File Offset: 0x002078A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232723, XrefRangeEnd = 232729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ItemInstance GetHarvestedProduct(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Plant.NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_New_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06007887 RID: 30855 RVA: 0x002096FC File Offset: 0x002078FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 232736, RefRangeEnd = 232737, XrefRangeStart = 232729, XrefRangeEnd = 232736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlantData GetPlantData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_GetPlantData_Public_PlantData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlantData>(intPtr3) : null;
		}

		// Token: 0x06007888 RID: 30856 RVA: 0x0020973C File Offset: 0x0020793C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 232749, RefRangeEnd = 232751, XrefRangeStart = 232737, XrefRangeEnd = 232749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Plant() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Plant>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007889 RID: 30857 RVA: 0x00039236 File Offset: 0x00037436
		public Plant(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002469 RID: 9321
		// (get) Token: 0x0600788A RID: 30858 RVA: 0x00209778 File Offset: 0x00207978
		// (set) Token: 0x0600788B RID: 30859 RVA: 0x0003923F File Offset: 0x0003743F
		public unsafe Pot _Pot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr__Pot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr__Pot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700246A RID: 9322
		// (get) Token: 0x0600788C RID: 30860 RVA: 0x002097A8 File Offset: 0x002079A8
		// (set) Token: 0x0600788D RID: 30861 RVA: 0x0003925E File Offset: 0x0003745E
		public unsafe float _NormalizedGrowthProgress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr__NormalizedGrowthProgress_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr__NormalizedGrowthProgress_k__BackingField)) = value;
			}
		}

		// Token: 0x1700246B RID: 9323
		// (get) Token: 0x0600788E RID: 30862 RVA: 0x002097D0 File Offset: 0x002079D0
		// (set) Token: 0x0600788F RID: 30863 RVA: 0x00039279 File Offset: 0x00037479
		public unsafe Transform VisualsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_VisualsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_VisualsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700246C RID: 9324
		// (get) Token: 0x06007890 RID: 30864 RVA: 0x00209800 File Offset: 0x00207A00
		// (set) Token: 0x06007891 RID: 30865 RVA: 0x00039298 File Offset: 0x00037498
		public unsafe Il2CppReferenceArray<PlantGrowthStage> GrowthStages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_GrowthStages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlantGrowthStage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_GrowthStages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700246D RID: 9325
		// (get) Token: 0x06007892 RID: 30866 RVA: 0x00209830 File Offset: 0x00207A30
		// (set) Token: 0x06007893 RID: 30867 RVA: 0x000392B7 File Offset: 0x000374B7
		public unsafe Collider Collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_Collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_Collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700246E RID: 9326
		// (get) Token: 0x06007894 RID: 30868 RVA: 0x00209860 File Offset: 0x00207A60
		// (set) Token: 0x06007895 RID: 30869 RVA: 0x000392D6 File Offset: 0x000374D6
		public unsafe AudioSourceController SnipSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_SnipSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_SnipSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700246F RID: 9327
		// (get) Token: 0x06007896 RID: 30870 RVA: 0x00209890 File Offset: 0x00207A90
		// (set) Token: 0x06007897 RID: 30871 RVA: 0x000392F5 File Offset: 0x000374F5
		public unsafe AudioSourceController DestroySound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_DestroySound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_DestroySound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002470 RID: 9328
		// (get) Token: 0x06007898 RID: 30872 RVA: 0x002098C0 File Offset: 0x00207AC0
		// (set) Token: 0x06007899 RID: 30873 RVA: 0x00039314 File Offset: 0x00037514
		public unsafe ParticleSystem FullyGrownParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_FullyGrownParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_FullyGrownParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002471 RID: 9329
		// (get) Token: 0x0600789A RID: 30874 RVA: 0x002098F0 File Offset: 0x00207AF0
		// (set) Token: 0x0600789B RID: 30875 RVA: 0x00039333 File Offset: 0x00037533
		public unsafe SeedDefinition SeedDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_SeedDefinition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SeedDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_SeedDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002472 RID: 9330
		// (get) Token: 0x0600789C RID: 30876 RVA: 0x00209920 File Offset: 0x00207B20
		// (set) Token: 0x0600789D RID: 30877 RVA: 0x00039352 File Offset: 0x00037552
		public unsafe int GrowthTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_GrowthTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_GrowthTime)) = value;
			}
		}

		// Token: 0x17002473 RID: 9331
		// (get) Token: 0x0600789E RID: 30878 RVA: 0x00209948 File Offset: 0x00207B48
		// (set) Token: 0x0600789F RID: 30879 RVA: 0x0003936D File Offset: 0x0003756D
		public unsafe float BaseYieldLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_BaseYieldLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_BaseYieldLevel)) = value;
			}
		}

		// Token: 0x17002474 RID: 9332
		// (get) Token: 0x060078A0 RID: 30880 RVA: 0x00209970 File Offset: 0x00207B70
		// (set) Token: 0x060078A1 RID: 30881 RVA: 0x00039388 File Offset: 0x00037588
		public unsafe float BaseQualityLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_BaseQualityLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_BaseQualityLevel)) = value;
			}
		}

		// Token: 0x17002475 RID: 9333
		// (get) Token: 0x060078A2 RID: 30882 RVA: 0x00209998 File Offset: 0x00207B98
		// (set) Token: 0x060078A3 RID: 30883 RVA: 0x000393A3 File Offset: 0x000375A3
		public unsafe string HarvestTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_HarvestTarget);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_HarvestTarget), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002476 RID: 9334
		// (get) Token: 0x060078A4 RID: 30884 RVA: 0x002099C0 File Offset: 0x00207BC0
		// (set) Token: 0x060078A5 RID: 30885 RVA: 0x000393C2 File Offset: 0x000375C2
		public unsafe TrashItem PlantScrapPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_PlantScrapPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_PlantScrapPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002477 RID: 9335
		// (get) Token: 0x060078A6 RID: 30886 RVA: 0x002099F0 File Offset: 0x00207BF0
		// (set) Token: 0x060078A7 RID: 30887 RVA: 0x000393E1 File Offset: 0x000375E1
		public unsafe UnityEvent onGrowthDone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_onGrowthDone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_onGrowthDone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002478 RID: 9336
		// (get) Token: 0x060078A8 RID: 30888 RVA: 0x00209A20 File Offset: 0x00207C20
		// (set) Token: 0x060078A9 RID: 30889 RVA: 0x00039400 File Offset: 0x00037600
		public unsafe float YieldLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_YieldLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_YieldLevel)) = value;
			}
		}

		// Token: 0x17002479 RID: 9337
		// (get) Token: 0x060078AA RID: 30890 RVA: 0x00209A48 File Offset: 0x00207C48
		// (set) Token: 0x060078AB RID: 30891 RVA: 0x0003941B File Offset: 0x0003761B
		public unsafe float QualityLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_QualityLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_QualityLevel)) = value;
			}
		}

		// Token: 0x1700247A RID: 9338
		// (get) Token: 0x060078AC RID: 30892 RVA: 0x00209A70 File Offset: 0x00207C70
		// (set) Token: 0x060078AD RID: 30893 RVA: 0x00039436 File Offset: 0x00037636
		public unsafe List<int> ActiveHarvestables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_ActiveHarvestables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_ActiveHarvestables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005213 RID: 21011
		private static readonly IntPtr NativeFieldInfoPtr__Pot_k__BackingField;

		// Token: 0x04005214 RID: 21012
		private static readonly IntPtr NativeFieldInfoPtr__NormalizedGrowthProgress_k__BackingField;

		// Token: 0x04005215 RID: 21013
		private static readonly IntPtr NativeFieldInfoPtr_VisualsContainer;

		// Token: 0x04005216 RID: 21014
		private static readonly IntPtr NativeFieldInfoPtr_GrowthStages;

		// Token: 0x04005217 RID: 21015
		private static readonly IntPtr NativeFieldInfoPtr_Collider;

		// Token: 0x04005218 RID: 21016
		private static readonly IntPtr NativeFieldInfoPtr_SnipSound;

		// Token: 0x04005219 RID: 21017
		private static readonly IntPtr NativeFieldInfoPtr_DestroySound;

		// Token: 0x0400521A RID: 21018
		private static readonly IntPtr NativeFieldInfoPtr_FullyGrownParticles;

		// Token: 0x0400521B RID: 21019
		private static readonly IntPtr NativeFieldInfoPtr_SeedDefinition;

		// Token: 0x0400521C RID: 21020
		private static readonly IntPtr NativeFieldInfoPtr_GrowthTime;

		// Token: 0x0400521D RID: 21021
		private static readonly IntPtr NativeFieldInfoPtr_BaseYieldLevel;

		// Token: 0x0400521E RID: 21022
		private static readonly IntPtr NativeFieldInfoPtr_BaseQualityLevel;

		// Token: 0x0400521F RID: 21023
		private static readonly IntPtr NativeFieldInfoPtr_HarvestTarget;

		// Token: 0x04005220 RID: 21024
		private static readonly IntPtr NativeFieldInfoPtr_PlantScrapPrefab;

		// Token: 0x04005221 RID: 21025
		private static readonly IntPtr NativeFieldInfoPtr_onGrowthDone;

		// Token: 0x04005222 RID: 21026
		private static readonly IntPtr NativeFieldInfoPtr_YieldLevel;

		// Token: 0x04005223 RID: 21027
		private static readonly IntPtr NativeFieldInfoPtr_QualityLevel;

		// Token: 0x04005224 RID: 21028
		private static readonly IntPtr NativeFieldInfoPtr_ActiveHarvestables;

		// Token: 0x04005225 RID: 21029
		private static readonly IntPtr NativeMethodInfoPtr_get_Pot_Public_get_Pot_0;

		// Token: 0x04005226 RID: 21030
		private static readonly IntPtr NativeMethodInfoPtr_set_Pot_Protected_set_Void_Pot_0;

		// Token: 0x04005227 RID: 21031
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedGrowthProgress_Public_get_Single_0;

		// Token: 0x04005228 RID: 21032
		private static readonly IntPtr NativeMethodInfoPtr_set_NormalizedGrowthProgress_Protected_set_Void_Single_0;

		// Token: 0x04005229 RID: 21033
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFullyGrown_Public_get_Boolean_0;

		// Token: 0x0400522A RID: 21034
		private static readonly IntPtr NativeMethodInfoPtr_get_FinalGrowthStage_Public_get_PlantGrowthStage_0;

		// Token: 0x0400522B RID: 21035
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_NetworkObject_Single_Single_Single_0;

		// Token: 0x0400522C RID: 21036
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x0400522D RID: 21037
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Public_Virtual_New_Void_0;

		// Token: 0x0400522E RID: 21038
		private static readonly IntPtr NativeMethodInfoPtr_SetNormalizedGrowthProgress_Public_Virtual_New_Void_Single_0;

		// Token: 0x0400522F RID: 21039
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisuals_Protected_Virtual_New_Void_0;

		// Token: 0x04005230 RID: 21040
		private static readonly IntPtr NativeMethodInfoPtr_SetHarvestableActive_Public_Virtual_New_Void_Int32_Boolean_0;

		// Token: 0x04005231 RID: 21041
		private static readonly IntPtr NativeMethodInfoPtr_IsHarvestableActive_Public_Boolean_Int32_0;

		// Token: 0x04005232 RID: 21042
		private static readonly IntPtr NativeMethodInfoPtr_GrowthDone_Private_Void_0;

		// Token: 0x04005233 RID: 21043
		private static readonly IntPtr NativeMethodInfoPtr_GenerateUniqueIntegers_Private_List_1_Int32_Int32_Int32_Int32_0;

		// Token: 0x04005234 RID: 21044
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x04005235 RID: 21045
		private static readonly IntPtr NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_New_ItemInstance_Int32_0;

		// Token: 0x04005236 RID: 21046
		private static readonly IntPtr NativeMethodInfoPtr_GetPlantData_Public_PlantData_0;

		// Token: 0x04005237 RID: 21047
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
