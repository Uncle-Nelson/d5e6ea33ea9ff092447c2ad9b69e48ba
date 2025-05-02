using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.PlayerTasks.Tasks
{
	// Token: 0x02000214 RID: 532
	public class UseMixingStationTask : Task
	{
		// Token: 0x06002C4E RID: 11342 RVA: 0x000FCE6C File Offset: 0x000FB06C
		// Note: this type is marked as 'beforefieldinit'.
		static UseMixingStationTask()
		{
			Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks.Tasks", "UseMixingStationTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr);
			UseMixingStationTask.NativeFieldInfoPtr__Station_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, "<Station>k__BackingField");
			UseMixingStationTask.NativeFieldInfoPtr__CurrentStep_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, "<CurrentStep>k__BackingField");
			UseMixingStationTask.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, "items");
			UseMixingStationTask.NativeFieldInfoPtr_mixerItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, "mixerItems");
			UseMixingStationTask.NativeFieldInfoPtr_ingredientPieces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, "ingredientPieces");
			UseMixingStationTask.NativeFieldInfoPtr_removedIngredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, "removedIngredients");
			UseMixingStationTask.NativeFieldInfoPtr_Jug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, "Jug");
			UseMixingStationTask.NativeMethodInfoPtr_get_Station_Public_get_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668280);
			UseMixingStationTask.NativeMethodInfoPtr_set_Station_Private_set_Void_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668281);
			UseMixingStationTask.NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668282);
			UseMixingStationTask.NativeMethodInfoPtr_set_CurrentStep_Private_set_Void_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668283);
			UseMixingStationTask.NativeMethodInfoPtr_GetStepDescription_Public_Static_String_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668284);
			UseMixingStationTask.NativeMethodInfoPtr__ctor_Public_Void_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668285);
			UseMixingStationTask.NativeMethodInfoPtr_CreateJug_Private_Beaker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668286);
			UseMixingStationTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668287);
			UseMixingStationTask.NativeMethodInfoPtr_UpdateInstruction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668288);
			UseMixingStationTask.NativeMethodInfoPtr_CheckProgress_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668289);
			UseMixingStationTask.NativeMethodInfoPtr_CheckStep_CombineIngredients_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668290);
			UseMixingStationTask.NativeMethodInfoPtr_GetCombinedIngredients_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668291);
			UseMixingStationTask.NativeMethodInfoPtr_ProgressStep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668292);
			UseMixingStationTask.NativeMethodInfoPtr_StartButtonPressed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668293);
			UseMixingStationTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668294);
			UseMixingStationTask.NativeMethodInfoPtr_CreateTrash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668295);
			UseMixingStationTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668296);
			UseMixingStationTask.NativeMethodInfoPtr_Method_Private_Void_StorableItemDefinition_Int32_Boolean_byref___c__DisplayClass15_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668297);
		}

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x06002C4F RID: 11343 RVA: 0x000FD090 File Offset: 0x000FB290
		// (set) Token: 0x06002C50 RID: 11344 RVA: 0x000FD0D0 File Offset: 0x000FB2D0
		public unsafe MixingStation Station
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_get_Station_Public_get_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MixingStation>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_set_Station_Private_set_Void_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x06002C51 RID: 11345 RVA: 0x000FD114 File Offset: 0x000FB314
		// (set) Token: 0x06002C52 RID: 11346 RVA: 0x000FD150 File Offset: 0x000FB350
		public unsafe UseMixingStationTask.EStep CurrentStep
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 79669, RefRangeEnd = 79670, XrefRangeStart = 79669, XrefRangeEnd = 79670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 121135, RefRangeEnd = 121144, XrefRangeStart = 121135, XrefRangeEnd = 121144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_set_CurrentStep_Private_set_Void_EStep_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C53 RID: 11347 RVA: 0x000FD190 File Offset: 0x000FB390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123710, XrefRangeEnd = 123714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStepDescription(UseMixingStationTask.EStep step)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref step;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_GetStepDescription_Public_Static_String_EStep_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002C54 RID: 11348 RVA: 0x000FD1C8 File Offset: 0x000FB3C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123797, RefRangeEnd = 123798, XrefRangeStart = 123714, XrefRangeEnd = 123797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UseMixingStationTask(MixingStation station) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr__ctor_Public_Void_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C55 RID: 11349 RVA: 0x000FD214 File Offset: 0x000FB414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123798, XrefRangeEnd = 123820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Beaker CreateJug()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_CreateJug_Private_Beaker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Beaker>(intPtr3) : null;
		}

		// Token: 0x06002C56 RID: 11350 RVA: 0x000FD254 File Offset: 0x000FB454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123820, XrefRangeEnd = 123830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseMixingStationTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C57 RID: 11351 RVA: 0x000FD290 File Offset: 0x000FB490
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123863, RefRangeEnd = 123864, XrefRangeStart = 123830, XrefRangeEnd = 123863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInstruction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_UpdateInstruction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C58 RID: 11352 RVA: 0x000FD2C4 File Offset: 0x000FB4C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123864, XrefRangeEnd = 123871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_CheckProgress_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C59 RID: 11353 RVA: 0x000FD2F8 File Offset: 0x000FB4F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123871, XrefRangeEnd = 123878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_CombineIngredients()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_CheckStep_CombineIngredients_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C5A RID: 11354 RVA: 0x000FD32C File Offset: 0x000FB52C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 123911, RefRangeEnd = 123915, XrefRangeStart = 123878, XrefRangeEnd = 123911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCombinedIngredients()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_GetCombinedIngredients_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C5B RID: 11355 RVA: 0x000FD368 File Offset: 0x000FB568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123915, XrefRangeEnd = 123916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProgressStep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_ProgressStep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C5C RID: 11356 RVA: 0x000FD39C File Offset: 0x000FB59C
		[CallerCount(0)]
		public unsafe void StartButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_StartButtonPressed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C5D RID: 11357 RVA: 0x000FD3D0 File Offset: 0x000FB5D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123916, XrefRangeEnd = 123934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Success()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseMixingStationTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C5E RID: 11358 RVA: 0x000FD40C File Offset: 0x000FB60C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123970, RefRangeEnd = 123971, XrefRangeStart = 123934, XrefRangeEnd = 123970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateTrash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_CreateTrash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C5F RID: 11359 RVA: 0x000FD440 File Offset: 0x000FB640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123971, XrefRangeEnd = 124016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseMixingStationTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C60 RID: 11360 RVA: 0x000FD47C File Offset: 0x000FB67C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 124082, RefRangeEnd = 124084, XrefRangeStart = 124016, XrefRangeEnd = 124082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_StorableItemDefinition_Int32_Boolean_byref___c__DisplayClass15_0_0(StorableItemDefinition def, int index, bool mixer, ref UseMixingStationTask.__c__DisplayClass15_0 A_4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mixer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_4);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_Method_Private_Void_StorableItemDefinition_Int32_Boolean_byref___c__DisplayClass15_0_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C61 RID: 11361 RVA: 0x00017EDB File Offset: 0x000160DB
		public UseMixingStationTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x06002C62 RID: 11362 RVA: 0x000FD4F0 File Offset: 0x000FB6F0
		// (set) Token: 0x06002C63 RID: 11363 RVA: 0x00017EE4 File Offset: 0x000160E4
		public unsafe MixingStation _Station_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr__Station_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixingStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr__Station_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x06002C64 RID: 11364 RVA: 0x000FD520 File Offset: 0x000FB720
		// (set) Token: 0x06002C65 RID: 11365 RVA: 0x00017F03 File Offset: 0x00016103
		public unsafe UseMixingStationTask.EStep _CurrentStep_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr__CurrentStep_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr__CurrentStep_k__BackingField)) = value;
			}
		}

		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x06002C66 RID: 11366 RVA: 0x000FD548 File Offset: 0x000FB748
		// (set) Token: 0x06002C67 RID: 11367 RVA: 0x00017F1E File Offset: 0x0001611E
		public unsafe List<StationItem> items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x06002C68 RID: 11368 RVA: 0x000FD578 File Offset: 0x000FB778
		// (set) Token: 0x06002C69 RID: 11369 RVA: 0x00017F3D File Offset: 0x0001613D
		public unsafe List<StationItem> mixerItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_mixerItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_mixerItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x06002C6A RID: 11370 RVA: 0x000FD5A8 File Offset: 0x000FB7A8
		// (set) Token: 0x06002C6B RID: 11371 RVA: 0x00017F5C File Offset: 0x0001615C
		public unsafe List<IngredientPiece> ingredientPieces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_ingredientPieces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IngredientPiece>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_ingredientPieces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x06002C6C RID: 11372 RVA: 0x000FD5D8 File Offset: 0x000FB7D8
		// (set) Token: 0x06002C6D RID: 11373 RVA: 0x00017F7B File Offset: 0x0001617B
		public unsafe Il2CppReferenceArray<ItemInstance> removedIngredients
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_removedIngredients);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_removedIngredients), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x06002C6E RID: 11374 RVA: 0x000FD608 File Offset: 0x000FB808
		// (set) Token: 0x06002C6F RID: 11375 RVA: 0x00017F9A File Offset: 0x0001619A
		public unsafe Beaker Jug
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_Jug);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Beaker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_Jug), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D63 RID: 7523
		private static readonly IntPtr NativeFieldInfoPtr__Station_k__BackingField;

		// Token: 0x04001D64 RID: 7524
		private static readonly IntPtr NativeFieldInfoPtr__CurrentStep_k__BackingField;

		// Token: 0x04001D65 RID: 7525
		private static readonly IntPtr NativeFieldInfoPtr_items;

		// Token: 0x04001D66 RID: 7526
		private static readonly IntPtr NativeFieldInfoPtr_mixerItems;

		// Token: 0x04001D67 RID: 7527
		private static readonly IntPtr NativeFieldInfoPtr_ingredientPieces;

		// Token: 0x04001D68 RID: 7528
		private static readonly IntPtr NativeFieldInfoPtr_removedIngredients;

		// Token: 0x04001D69 RID: 7529
		private static readonly IntPtr NativeFieldInfoPtr_Jug;

		// Token: 0x04001D6A RID: 7530
		private static readonly IntPtr NativeMethodInfoPtr_get_Station_Public_get_MixingStation_0;

		// Token: 0x04001D6B RID: 7531
		private static readonly IntPtr NativeMethodInfoPtr_set_Station_Private_set_Void_MixingStation_0;

		// Token: 0x04001D6C RID: 7532
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0;

		// Token: 0x04001D6D RID: 7533
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentStep_Private_set_Void_EStep_0;

		// Token: 0x04001D6E RID: 7534
		private static readonly IntPtr NativeMethodInfoPtr_GetStepDescription_Public_Static_String_EStep_0;

		// Token: 0x04001D6F RID: 7535
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MixingStation_0;

		// Token: 0x04001D70 RID: 7536
		private static readonly IntPtr NativeMethodInfoPtr_CreateJug_Private_Beaker_0;

		// Token: 0x04001D71 RID: 7537
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001D72 RID: 7538
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInstruction_Private_Void_0;

		// Token: 0x04001D73 RID: 7539
		private static readonly IntPtr NativeMethodInfoPtr_CheckProgress_Private_Void_0;

		// Token: 0x04001D74 RID: 7540
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_CombineIngredients_Private_Void_0;

		// Token: 0x04001D75 RID: 7541
		private static readonly IntPtr NativeMethodInfoPtr_GetCombinedIngredients_Private_Int32_0;

		// Token: 0x04001D76 RID: 7542
		private static readonly IntPtr NativeMethodInfoPtr_ProgressStep_Private_Void_0;

		// Token: 0x04001D77 RID: 7543
		private static readonly IntPtr NativeMethodInfoPtr_StartButtonPressed_Private_Void_0;

		// Token: 0x04001D78 RID: 7544
		private static readonly IntPtr NativeMethodInfoPtr_Success_Public_Virtual_Void_0;

		// Token: 0x04001D79 RID: 7545
		private static readonly IntPtr NativeMethodInfoPtr_CreateTrash_Private_Void_0;

		// Token: 0x04001D7A RID: 7546
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001D7B RID: 7547
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_StorableItemDefinition_Int32_Boolean_byref___c__DisplayClass15_0_0;

		// Token: 0x020008E9 RID: 2281
		[OriginalName("Assembly-CSharp.dll", "", "EStep")]
		public enum EStep
		{
			// Token: 0x0400856E RID: 34158
			CombineIngredients,
			// Token: 0x0400856F RID: 34159
			StartMixing
		}

		// Token: 0x020008EA RID: 2282
		[ObfuscatedName("ScheduleOne.PlayerTasks.Tasks.UseMixingStationTask+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : ValueType
		{
			// Token: 0x0600C4C8 RID: 50376 RVA: 0x002FEB7C File Offset: 0x002FCD7C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<UseMixingStationTask.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UseMixingStationTask.__c__DisplayClass15_0>.NativeClassPtr);
				UseMixingStationTask.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask.__c__DisplayClass15_0>.NativeClassPtr, "<>4__this");
				UseMixingStationTask.__c__DisplayClass15_0.NativeFieldInfoPtr_station = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask.__c__DisplayClass15_0>.NativeClassPtr, "station");
			}

			// Token: 0x0600C4C9 RID: 50377 RVA: 0x0005FC2B File Offset: 0x0005DE2B
			public __c__DisplayClass15_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600C4CA RID: 50378 RVA: 0x0005FC34 File Offset: 0x0005DE34
			public __c__DisplayClass15_0() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UseMixingStationTask.__c__DisplayClass15_0>.NativeClassPtr))
			{
			}

			// Token: 0x17003D6D RID: 15725
			// (get) Token: 0x0600C4CB RID: 50379 RVA: 0x002FEBD0 File Offset: 0x002FCDD0
			// (set) Token: 0x0600C4CC RID: 50380 RVA: 0x0005FC46 File Offset: 0x0005DE46
			public unsafe UseMixingStationTask __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UseMixingStationTask>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D6E RID: 15726
			// (get) Token: 0x0600C4CD RID: 50381 RVA: 0x002FEC00 File Offset: 0x002FCE00
			// (set) Token: 0x0600C4CE RID: 50382 RVA: 0x0005FC65 File Offset: 0x0005DE65
			public unsafe MixingStation station
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.__c__DisplayClass15_0.NativeFieldInfoPtr_station);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixingStation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.__c__DisplayClass15_0.NativeFieldInfoPtr_station), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008570 RID: 34160
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008571 RID: 34161
			private static readonly IntPtr NativeFieldInfoPtr_station;
		}
	}
}
