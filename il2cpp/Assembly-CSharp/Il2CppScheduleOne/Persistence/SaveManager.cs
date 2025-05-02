using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x0200021F RID: 543
	public class SaveManager : PersistentSingleton<SaveManager>
	{
		// Token: 0x06002D39 RID: 11577 RVA: 0x001003F0 File Offset: 0x000FE5F0
		// Note: this type is marked as 'beforefieldinit'.
		static SaveManager()
		{
			Il2CppClassPointerStore<SaveManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "SaveManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveManager>.NativeClassPtr);
			SaveManager.NativeFieldInfoPtr_MAIN_SCENE_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "MAIN_SCENE_NAME");
			SaveManager.NativeFieldInfoPtr_MENU_SCENE_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "MENU_SCENE_NAME");
			SaveManager.NativeFieldInfoPtr_TUTORIAL_SCENE_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "TUTORIAL_SCENE_NAME");
			SaveManager.NativeFieldInfoPtr_SAVES_PER_FRAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "SAVES_PER_FRAME");
			SaveManager.NativeFieldInfoPtr_SAVE_FILE_EXTENSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "SAVE_FILE_EXTENSION");
			SaveManager.NativeFieldInfoPtr_SAVE_SLOT_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "SAVE_SLOT_COUNT");
			SaveManager.NativeFieldInfoPtr_SAVE_GAME_PREFIX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "SAVE_GAME_PREFIX");
			SaveManager.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "DEBUG");
			SaveManager.NativeFieldInfoPtr_PRETTY_PRINT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "PRETTY_PRINT");
			SaveManager.NativeFieldInfoPtr_SaveError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "SaveError");
			SaveManager.NativeFieldInfoPtr__AccessPermissionIssueDetected_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "<AccessPermissionIssueDetected>k__BackingField");
			SaveManager.NativeFieldInfoPtr__IsSaving_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "<IsSaving>k__BackingField");
			SaveManager.NativeFieldInfoPtr__SecondsSinceLastSave_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "<SecondsSinceLastSave>k__BackingField");
			SaveManager.NativeFieldInfoPtr__PlayersSavePath_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "<PlayersSavePath>k__BackingField");
			SaveManager.NativeFieldInfoPtr__IndividualSavesContainerPath_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "<IndividualSavesContainerPath>k__BackingField");
			SaveManager.NativeFieldInfoPtr__SaveName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "<SaveName>k__BackingField");
			SaveManager.NativeFieldInfoPtr_Saveables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "Saveables");
			SaveManager.NativeFieldInfoPtr_BaseSaveables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "BaseSaveables");
			SaveManager.NativeFieldInfoPtr_ApprovedBaseLevelPaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "ApprovedBaseLevelPaths");
			SaveManager.NativeFieldInfoPtr_CompletedSaveables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "CompletedSaveables");
			SaveManager.NativeFieldInfoPtr_QueuedSaveRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "QueuedSaveRequests");
			SaveManager.NativeFieldInfoPtr_WriteIssueDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "WriteIssueDisplay");
			SaveManager.NativeFieldInfoPtr_onSaveStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "onSaveStart");
			SaveManager.NativeFieldInfoPtr_onSaveComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "onSaveComplete");
			SaveManager.NativeFieldInfoPtr_saveFolderInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "saveFolderInitialized");
			SaveManager.NativeMethodInfoPtr_ReportSaveError_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668473);
			SaveManager.NativeMethodInfoPtr_get_AccessPermissionIssueDetected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668474);
			SaveManager.NativeMethodInfoPtr_set_AccessPermissionIssueDetected_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668475);
			SaveManager.NativeMethodInfoPtr_get_IsSaving_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668476);
			SaveManager.NativeMethodInfoPtr_set_IsSaving_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668477);
			SaveManager.NativeMethodInfoPtr_get_SecondsSinceLastSave_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668478);
			SaveManager.NativeMethodInfoPtr_set_SecondsSinceLastSave_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668479);
			SaveManager.NativeMethodInfoPtr_get_PlayersSavePath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668480);
			SaveManager.NativeMethodInfoPtr_set_PlayersSavePath_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668481);
			SaveManager.NativeMethodInfoPtr_get_IndividualSavesContainerPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668482);
			SaveManager.NativeMethodInfoPtr_set_IndividualSavesContainerPath_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668483);
			SaveManager.NativeMethodInfoPtr_get_SaveName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668484);
			SaveManager.NativeMethodInfoPtr_set_SaveName_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668485);
			SaveManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668486);
			SaveManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668487);
			SaveManager.NativeMethodInfoPtr_CheckSaveFolderInitialized_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668488);
			SaveManager.NativeMethodInfoPtr_HasWritePermissionOnDir_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668489);
			SaveManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668490);
			SaveManager.NativeMethodInfoPtr_DelayedSave_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668491);
			SaveManager.NativeMethodInfoPtr_Save_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668492);
			SaveManager.NativeMethodInfoPtr_Save_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668493);
			SaveManager.NativeMethodInfoPtr_ClearBaseLevelOutdatedSaves_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668494);
			SaveManager.NativeMethodInfoPtr_CompleteSaveable_Public_Void_ISaveable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668495);
			SaveManager.NativeMethodInfoPtr_ClearCompletedSaveable_Public_Void_ISaveable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668496);
			SaveManager.NativeMethodInfoPtr_RegisterSaveable_Public_Void_ISaveable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668497);
			SaveManager.NativeMethodInfoPtr_QueueSaveRequest_Public_Void_SaveRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668498);
			SaveManager.NativeMethodInfoPtr_DequeueSaveRequest_Public_Void_SaveRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668499);
			SaveManager.NativeMethodInfoPtr_StripExtensions_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668500);
			SaveManager.NativeMethodInfoPtr_MakeFileSafe_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668501);
			SaveManager.NativeMethodInfoPtr_GetVersionNumber_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668502);
			SaveManager.NativeMethodInfoPtr_Clean_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668503);
			SaveManager.NativeMethodInfoPtr_DisablePlayTutorial_Public_Void_SaveInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668504);
			SaveManager.NativeMethodInfoPtr_SanitizeFileName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668505);
			SaveManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668506);
		}

		// Token: 0x06002D3A RID: 11578 RVA: 0x001008BC File Offset: 0x000FEABC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 126635, RefRangeEnd = 126639, XrefRangeStart = 126633, XrefRangeEnd = 126635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReportSaveError()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_ReportSaveError_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F22 RID: 3874
		// (get) Token: 0x06002D3B RID: 11579 RVA: 0x001008E4 File Offset: 0x000FEAE4
		// (set) Token: 0x06002D3C RID: 11580 RVA: 0x00100920 File Offset: 0x000FEB20
		public unsafe bool AccessPermissionIssueDetected
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_get_AccessPermissionIssueDetected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37992, RefRangeEnd = 38015, XrefRangeStart = 37992, XrefRangeEnd = 38015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_set_AccessPermissionIssueDetected_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000F23 RID: 3875
		// (get) Token: 0x06002D3D RID: 11581 RVA: 0x00100960 File Offset: 0x000FEB60
		// (set) Token: 0x06002D3E RID: 11582 RVA: 0x0010099C File Offset: 0x000FEB9C
		public unsafe bool IsSaving
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_get_IsSaving_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_set_IsSaving_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x06002D3F RID: 11583 RVA: 0x001009DC File Offset: 0x000FEBDC
		// (set) Token: 0x06002D40 RID: 11584 RVA: 0x00100A18 File Offset: 0x000FEC18
		public unsafe float SecondsSinceLastSave
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_get_SecondsSinceLastSave_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 106279, RefRangeEnd = 106281, XrefRangeStart = 106279, XrefRangeEnd = 106281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_set_SecondsSinceLastSave_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x06002D41 RID: 11585 RVA: 0x00100A58 File Offset: 0x000FEC58
		// (set) Token: 0x06002D42 RID: 11586 RVA: 0x00100A90 File Offset: 0x000FEC90
		public unsafe string PlayersSavePath
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19644, RefRangeEnd = 19658, XrefRangeStart = 19644, XrefRangeEnd = 19658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_get_PlayersSavePath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19659, RefRangeEnd = 19660, XrefRangeStart = 19659, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_set_PlayersSavePath_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x06002D43 RID: 11587 RVA: 0x00100AD4 File Offset: 0x000FECD4
		// (set) Token: 0x06002D44 RID: 11588 RVA: 0x00100B0C File Offset: 0x000FED0C
		public unsafe string IndividualSavesContainerPath
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 19660, RefRangeEnd = 19667, XrefRangeStart = 19660, XrefRangeEnd = 19667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_get_IndividualSavesContainerPath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_set_IndividualSavesContainerPath_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x06002D45 RID: 11589 RVA: 0x00100B50 File Offset: 0x000FED50
		// (set) Token: 0x06002D46 RID: 11590 RVA: 0x00100B88 File Offset: 0x000FED88
		public unsafe string SaveName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35358, RefRangeEnd = 35359, XrefRangeStart = 35358, XrefRangeEnd = 35359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_get_SaveName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_set_SaveName_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D47 RID: 11591 RVA: 0x00100BCC File Offset: 0x000FEDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126639, XrefRangeEnd = 126679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SaveManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D48 RID: 11592 RVA: 0x00100C08 File Offset: 0x000FEE08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126679, XrefRangeEnd = 126695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SaveManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D49 RID: 11593 RVA: 0x00100C44 File Offset: 0x000FEE44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 126736, RefRangeEnd = 126738, XrefRangeStart = 126695, XrefRangeEnd = 126736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckSaveFolderInitialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_CheckSaveFolderInitialized_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D4A RID: 11594 RVA: 0x00100C78 File Offset: 0x000FEE78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126750, RefRangeEnd = 126751, XrefRangeStart = 126738, XrefRangeEnd = 126750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasWritePermissionOnDir(string path)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_HasWritePermissionOnDir_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D4B RID: 11595 RVA: 0x00100CBC File Offset: 0x000FEEBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126751, XrefRangeEnd = 126774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D4C RID: 11596 RVA: 0x00100CF0 File Offset: 0x000FEEF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126777, RefRangeEnd = 126778, XrefRangeStart = 126774, XrefRangeEnd = 126777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DelayedSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_DelayedSave_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D4D RID: 11597 RVA: 0x00100D24 File Offset: 0x000FEF24
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 126784, RefRangeEnd = 126789, XrefRangeStart = 126778, XrefRangeEnd = 126784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Save()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_Save_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D4E RID: 11598 RVA: 0x00100D58 File Offset: 0x000FEF58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126828, RefRangeEnd = 126829, XrefRangeStart = 126789, XrefRangeEnd = 126828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Save(string saveFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(saveFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_Save_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D4F RID: 11599 RVA: 0x00100D9C File Offset: 0x000FEF9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126829, XrefRangeEnd = 126900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearBaseLevelOutdatedSaves(string saveFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(saveFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_ClearBaseLevelOutdatedSaves_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D50 RID: 11600 RVA: 0x00100DE0 File Offset: 0x000FEFE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126913, RefRangeEnd = 126914, XrefRangeStart = 126900, XrefRangeEnd = 126913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteSaveable(ISaveable saveable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_CompleteSaveable_Public_Void_ISaveable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D51 RID: 11601 RVA: 0x00100E24 File Offset: 0x000FF024
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126918, RefRangeEnd = 126919, XrefRangeStart = 126914, XrefRangeEnd = 126918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearCompletedSaveable(ISaveable saveable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_ClearCompletedSaveable_Public_Void_ISaveable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D52 RID: 11602 RVA: 0x00100E68 File Offset: 0x000FF068
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 126933, RefRangeEnd = 126965, XrefRangeStart = 126919, XrefRangeEnd = 126933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterSaveable(ISaveable saveable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_RegisterSaveable_Public_Void_ISaveable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D53 RID: 11603 RVA: 0x00100EAC File Offset: 0x000FF0AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126965, XrefRangeEnd = 126971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueSaveRequest(SaveRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_QueueSaveRequest_Public_Void_SaveRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D54 RID: 11604 RVA: 0x00100EF0 File Offset: 0x000FF0F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126971, XrefRangeEnd = 126975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DequeueSaveRequest(SaveRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_DequeueSaveRequest_Public_Void_SaveRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D55 RID: 11605 RVA: 0x00100F34 File Offset: 0x000FF134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126975, XrefRangeEnd = 126981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string StripExtensions(string filePath)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_StripExtensions_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002D56 RID: 11606 RVA: 0x00100F70 File Offset: 0x000FF170
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 126987, RefRangeEnd = 126992, XrefRangeStart = 126981, XrefRangeEnd = 126987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string MakeFileSafe(string fileName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_MakeFileSafe_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002D57 RID: 11607 RVA: 0x00100FAC File Offset: 0x000FF1AC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 127016, RefRangeEnd = 127021, XrefRangeStart = 126992, XrefRangeEnd = 127016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetVersionNumber(string version)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(version);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_GetVersionNumber_Public_Static_Single_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D58 RID: 11608 RVA: 0x00100FF0 File Offset: 0x000FF1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127021, XrefRangeEnd = 127025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clean()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_Clean_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D59 RID: 11609 RVA: 0x00101024 File Offset: 0x000FF224
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127054, RefRangeEnd = 127055, XrefRangeStart = 127025, XrefRangeEnd = 127054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisablePlayTutorial(SaveInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_DisablePlayTutorial_Public_Void_SaveInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D5A RID: 11610 RVA: 0x00101068 File Offset: 0x000FF268
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 127061, RefRangeEnd = 127063, XrefRangeStart = 127055, XrefRangeEnd = 127061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SanitizeFileName(string fileName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_SanitizeFileName_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002D5B RID: 11611 RVA: 0x001010A4 File Offset: 0x000FF2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127063, XrefRangeEnd = 127108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D5C RID: 11612 RVA: 0x000184E6 File Offset: 0x000166E6
		public SaveManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F09 RID: 3849
		// (get) Token: 0x06002D5D RID: 11613 RVA: 0x001010E0 File Offset: 0x000FF2E0
		// (set) Token: 0x06002D5E RID: 11614 RVA: 0x000184EF File Offset: 0x000166EF
		public unsafe static string MAIN_SCENE_NAME
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SaveManager.NativeFieldInfoPtr_MAIN_SCENE_NAME, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveManager.NativeFieldInfoPtr_MAIN_SCENE_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F0A RID: 3850
		// (get) Token: 0x06002D5F RID: 11615 RVA: 0x00101100 File Offset: 0x000FF300
		// (set) Token: 0x06002D60 RID: 11616 RVA: 0x00018501 File Offset: 0x00016701
		public unsafe static string MENU_SCENE_NAME
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SaveManager.NativeFieldInfoPtr_MENU_SCENE_NAME, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveManager.NativeFieldInfoPtr_MENU_SCENE_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F0B RID: 3851
		// (get) Token: 0x06002D61 RID: 11617 RVA: 0x00101120 File Offset: 0x000FF320
		// (set) Token: 0x06002D62 RID: 11618 RVA: 0x00018513 File Offset: 0x00016713
		public unsafe static string TUTORIAL_SCENE_NAME
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SaveManager.NativeFieldInfoPtr_TUTORIAL_SCENE_NAME, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveManager.NativeFieldInfoPtr_TUTORIAL_SCENE_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F0C RID: 3852
		// (get) Token: 0x06002D63 RID: 11619 RVA: 0x00101140 File Offset: 0x000FF340
		// (set) Token: 0x06002D64 RID: 11620 RVA: 0x00018525 File Offset: 0x00016725
		public unsafe static int SAVES_PER_FRAME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SaveManager.NativeFieldInfoPtr_SAVES_PER_FRAME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveManager.NativeFieldInfoPtr_SAVES_PER_FRAME, (void*)(&value));
			}
		}

		// Token: 0x17000F0D RID: 3853
		// (get) Token: 0x06002D65 RID: 11621 RVA: 0x0010115C File Offset: 0x000FF35C
		// (set) Token: 0x06002D66 RID: 11622 RVA: 0x00018533 File Offset: 0x00016733
		public unsafe static string SAVE_FILE_EXTENSION
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SaveManager.NativeFieldInfoPtr_SAVE_FILE_EXTENSION, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveManager.NativeFieldInfoPtr_SAVE_FILE_EXTENSION, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F0E RID: 3854
		// (get) Token: 0x06002D67 RID: 11623 RVA: 0x0010117C File Offset: 0x000FF37C
		// (set) Token: 0x06002D68 RID: 11624 RVA: 0x00018545 File Offset: 0x00016745
		public unsafe static int SAVE_SLOT_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SaveManager.NativeFieldInfoPtr_SAVE_SLOT_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveManager.NativeFieldInfoPtr_SAVE_SLOT_COUNT, (void*)(&value));
			}
		}

		// Token: 0x17000F0F RID: 3855
		// (get) Token: 0x06002D69 RID: 11625 RVA: 0x00101198 File Offset: 0x000FF398
		// (set) Token: 0x06002D6A RID: 11626 RVA: 0x00018553 File Offset: 0x00016753
		public unsafe static string SAVE_GAME_PREFIX
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SaveManager.NativeFieldInfoPtr_SAVE_GAME_PREFIX, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveManager.NativeFieldInfoPtr_SAVE_GAME_PREFIX, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F10 RID: 3856
		// (get) Token: 0x06002D6B RID: 11627 RVA: 0x001011B8 File Offset: 0x000FF3B8
		// (set) Token: 0x06002D6C RID: 11628 RVA: 0x00018565 File Offset: 0x00016765
		public unsafe static bool DEBUG
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(SaveManager.NativeFieldInfoPtr_DEBUG, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveManager.NativeFieldInfoPtr_DEBUG, (void*)(&value));
			}
		}

		// Token: 0x17000F11 RID: 3857
		// (get) Token: 0x06002D6D RID: 11629 RVA: 0x001011D4 File Offset: 0x000FF3D4
		// (set) Token: 0x06002D6E RID: 11630 RVA: 0x00018573 File Offset: 0x00016773
		public unsafe static bool PRETTY_PRINT
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(SaveManager.NativeFieldInfoPtr_PRETTY_PRINT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveManager.NativeFieldInfoPtr_PRETTY_PRINT, (void*)(&value));
			}
		}

		// Token: 0x17000F12 RID: 3858
		// (get) Token: 0x06002D6F RID: 11631 RVA: 0x001011F0 File Offset: 0x000FF3F0
		// (set) Token: 0x06002D70 RID: 11632 RVA: 0x00018581 File Offset: 0x00016781
		public unsafe static bool SaveError
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(SaveManager.NativeFieldInfoPtr_SaveError, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveManager.NativeFieldInfoPtr_SaveError, (void*)(&value));
			}
		}

		// Token: 0x17000F13 RID: 3859
		// (get) Token: 0x06002D71 RID: 11633 RVA: 0x0010120C File Offset: 0x000FF40C
		// (set) Token: 0x06002D72 RID: 11634 RVA: 0x0001858F File Offset: 0x0001678F
		public unsafe bool _AccessPermissionIssueDetected_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__AccessPermissionIssueDetected_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__AccessPermissionIssueDetected_k__BackingField)) = value;
			}
		}

		// Token: 0x17000F14 RID: 3860
		// (get) Token: 0x06002D73 RID: 11635 RVA: 0x00101234 File Offset: 0x000FF434
		// (set) Token: 0x06002D74 RID: 11636 RVA: 0x000185AA File Offset: 0x000167AA
		public unsafe bool _IsSaving_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__IsSaving_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__IsSaving_k__BackingField)) = value;
			}
		}

		// Token: 0x17000F15 RID: 3861
		// (get) Token: 0x06002D75 RID: 11637 RVA: 0x0010125C File Offset: 0x000FF45C
		// (set) Token: 0x06002D76 RID: 11638 RVA: 0x000185C5 File Offset: 0x000167C5
		public unsafe float _SecondsSinceLastSave_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__SecondsSinceLastSave_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__SecondsSinceLastSave_k__BackingField)) = value;
			}
		}

		// Token: 0x17000F16 RID: 3862
		// (get) Token: 0x06002D77 RID: 11639 RVA: 0x00101284 File Offset: 0x000FF484
		// (set) Token: 0x06002D78 RID: 11640 RVA: 0x000185E0 File Offset: 0x000167E0
		public unsafe string _PlayersSavePath_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__PlayersSavePath_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__PlayersSavePath_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F17 RID: 3863
		// (get) Token: 0x06002D79 RID: 11641 RVA: 0x001012AC File Offset: 0x000FF4AC
		// (set) Token: 0x06002D7A RID: 11642 RVA: 0x000185FF File Offset: 0x000167FF
		public unsafe string _IndividualSavesContainerPath_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__IndividualSavesContainerPath_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__IndividualSavesContainerPath_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F18 RID: 3864
		// (get) Token: 0x06002D7B RID: 11643 RVA: 0x001012D4 File Offset: 0x000FF4D4
		// (set) Token: 0x06002D7C RID: 11644 RVA: 0x0001861E File Offset: 0x0001681E
		public unsafe string _SaveName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__SaveName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__SaveName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F19 RID: 3865
		// (get) Token: 0x06002D7D RID: 11645 RVA: 0x001012FC File Offset: 0x000FF4FC
		// (set) Token: 0x06002D7E RID: 11646 RVA: 0x0001863D File Offset: 0x0001683D
		public unsafe List<ISaveable> Saveables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_Saveables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ISaveable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_Saveables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F1A RID: 3866
		// (get) Token: 0x06002D7F RID: 11647 RVA: 0x0010132C File Offset: 0x000FF52C
		// (set) Token: 0x06002D80 RID: 11648 RVA: 0x0001865C File Offset: 0x0001685C
		public unsafe List<IBaseSaveable> BaseSaveables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_BaseSaveables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IBaseSaveable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_BaseSaveables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F1B RID: 3867
		// (get) Token: 0x06002D81 RID: 11649 RVA: 0x0010135C File Offset: 0x000FF55C
		// (set) Token: 0x06002D82 RID: 11650 RVA: 0x0001867B File Offset: 0x0001687B
		public unsafe List<string> ApprovedBaseLevelPaths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_ApprovedBaseLevelPaths);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_ApprovedBaseLevelPaths), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F1C RID: 3868
		// (get) Token: 0x06002D83 RID: 11651 RVA: 0x0010138C File Offset: 0x000FF58C
		// (set) Token: 0x06002D84 RID: 11652 RVA: 0x0001869A File Offset: 0x0001689A
		public unsafe List<ISaveable> CompletedSaveables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_CompletedSaveables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ISaveable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_CompletedSaveables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F1D RID: 3869
		// (get) Token: 0x06002D85 RID: 11653 RVA: 0x001013BC File Offset: 0x000FF5BC
		// (set) Token: 0x06002D86 RID: 11654 RVA: 0x000186B9 File Offset: 0x000168B9
		public unsafe List<SaveRequest> QueuedSaveRequests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_QueuedSaveRequests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SaveRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_QueuedSaveRequests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F1E RID: 3870
		// (get) Token: 0x06002D87 RID: 11655 RVA: 0x001013EC File Offset: 0x000FF5EC
		// (set) Token: 0x06002D88 RID: 11656 RVA: 0x000186D8 File Offset: 0x000168D8
		public unsafe RectTransform WriteIssueDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_WriteIssueDisplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_WriteIssueDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F1F RID: 3871
		// (get) Token: 0x06002D89 RID: 11657 RVA: 0x0010141C File Offset: 0x000FF61C
		// (set) Token: 0x06002D8A RID: 11658 RVA: 0x000186F7 File Offset: 0x000168F7
		public unsafe UnityEvent onSaveStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_onSaveStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_onSaveStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F20 RID: 3872
		// (get) Token: 0x06002D8B RID: 11659 RVA: 0x0010144C File Offset: 0x000FF64C
		// (set) Token: 0x06002D8C RID: 11660 RVA: 0x00018716 File Offset: 0x00016916
		public unsafe UnityEvent onSaveComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_onSaveComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_onSaveComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F21 RID: 3873
		// (get) Token: 0x06002D8D RID: 11661 RVA: 0x0010147C File Offset: 0x000FF67C
		// (set) Token: 0x06002D8E RID: 11662 RVA: 0x00018735 File Offset: 0x00016935
		public unsafe bool saveFolderInitialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_saveFolderInitialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_saveFolderInitialized)) = value;
			}
		}

		// Token: 0x04001E07 RID: 7687
		private static readonly IntPtr NativeFieldInfoPtr_MAIN_SCENE_NAME;

		// Token: 0x04001E08 RID: 7688
		private static readonly IntPtr NativeFieldInfoPtr_MENU_SCENE_NAME;

		// Token: 0x04001E09 RID: 7689
		private static readonly IntPtr NativeFieldInfoPtr_TUTORIAL_SCENE_NAME;

		// Token: 0x04001E0A RID: 7690
		private static readonly IntPtr NativeFieldInfoPtr_SAVES_PER_FRAME;

		// Token: 0x04001E0B RID: 7691
		private static readonly IntPtr NativeFieldInfoPtr_SAVE_FILE_EXTENSION;

		// Token: 0x04001E0C RID: 7692
		private static readonly IntPtr NativeFieldInfoPtr_SAVE_SLOT_COUNT;

		// Token: 0x04001E0D RID: 7693
		private static readonly IntPtr NativeFieldInfoPtr_SAVE_GAME_PREFIX;

		// Token: 0x04001E0E RID: 7694
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04001E0F RID: 7695
		private static readonly IntPtr NativeFieldInfoPtr_PRETTY_PRINT;

		// Token: 0x04001E10 RID: 7696
		private static readonly IntPtr NativeFieldInfoPtr_SaveError;

		// Token: 0x04001E11 RID: 7697
		private static readonly IntPtr NativeFieldInfoPtr__AccessPermissionIssueDetected_k__BackingField;

		// Token: 0x04001E12 RID: 7698
		private static readonly IntPtr NativeFieldInfoPtr__IsSaving_k__BackingField;

		// Token: 0x04001E13 RID: 7699
		private static readonly IntPtr NativeFieldInfoPtr__SecondsSinceLastSave_k__BackingField;

		// Token: 0x04001E14 RID: 7700
		private static readonly IntPtr NativeFieldInfoPtr__PlayersSavePath_k__BackingField;

		// Token: 0x04001E15 RID: 7701
		private static readonly IntPtr NativeFieldInfoPtr__IndividualSavesContainerPath_k__BackingField;

		// Token: 0x04001E16 RID: 7702
		private static readonly IntPtr NativeFieldInfoPtr__SaveName_k__BackingField;

		// Token: 0x04001E17 RID: 7703
		private static readonly IntPtr NativeFieldInfoPtr_Saveables;

		// Token: 0x04001E18 RID: 7704
		private static readonly IntPtr NativeFieldInfoPtr_BaseSaveables;

		// Token: 0x04001E19 RID: 7705
		private static readonly IntPtr NativeFieldInfoPtr_ApprovedBaseLevelPaths;

		// Token: 0x04001E1A RID: 7706
		private static readonly IntPtr NativeFieldInfoPtr_CompletedSaveables;

		// Token: 0x04001E1B RID: 7707
		private static readonly IntPtr NativeFieldInfoPtr_QueuedSaveRequests;

		// Token: 0x04001E1C RID: 7708
		private static readonly IntPtr NativeFieldInfoPtr_WriteIssueDisplay;

		// Token: 0x04001E1D RID: 7709
		private static readonly IntPtr NativeFieldInfoPtr_onSaveStart;

		// Token: 0x04001E1E RID: 7710
		private static readonly IntPtr NativeFieldInfoPtr_onSaveComplete;

		// Token: 0x04001E1F RID: 7711
		private static readonly IntPtr NativeFieldInfoPtr_saveFolderInitialized;

		// Token: 0x04001E20 RID: 7712
		private static readonly IntPtr NativeMethodInfoPtr_ReportSaveError_Public_Static_Void_0;

		// Token: 0x04001E21 RID: 7713
		private static readonly IntPtr NativeMethodInfoPtr_get_AccessPermissionIssueDetected_Public_get_Boolean_0;

		// Token: 0x04001E22 RID: 7714
		private static readonly IntPtr NativeMethodInfoPtr_set_AccessPermissionIssueDetected_Protected_set_Void_Boolean_0;

		// Token: 0x04001E23 RID: 7715
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSaving_Public_get_Boolean_0;

		// Token: 0x04001E24 RID: 7716
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSaving_Protected_set_Void_Boolean_0;

		// Token: 0x04001E25 RID: 7717
		private static readonly IntPtr NativeMethodInfoPtr_get_SecondsSinceLastSave_Public_get_Single_0;

		// Token: 0x04001E26 RID: 7718
		private static readonly IntPtr NativeMethodInfoPtr_set_SecondsSinceLastSave_Protected_set_Void_Single_0;

		// Token: 0x04001E27 RID: 7719
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayersSavePath_Public_get_String_0;

		// Token: 0x04001E28 RID: 7720
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayersSavePath_Protected_set_Void_String_0;

		// Token: 0x04001E29 RID: 7721
		private static readonly IntPtr NativeMethodInfoPtr_get_IndividualSavesContainerPath_Public_get_String_0;

		// Token: 0x04001E2A RID: 7722
		private static readonly IntPtr NativeMethodInfoPtr_set_IndividualSavesContainerPath_Protected_set_Void_String_0;

		// Token: 0x04001E2B RID: 7723
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveName_Public_get_String_0;

		// Token: 0x04001E2C RID: 7724
		private static readonly IntPtr NativeMethodInfoPtr_set_SaveName_Protected_set_Void_String_0;

		// Token: 0x04001E2D RID: 7725
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04001E2E RID: 7726
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04001E2F RID: 7727
		private static readonly IntPtr NativeMethodInfoPtr_CheckSaveFolderInitialized_Public_Void_0;

		// Token: 0x04001E30 RID: 7728
		private static readonly IntPtr NativeMethodInfoPtr_HasWritePermissionOnDir_Public_Static_Boolean_String_0;

		// Token: 0x04001E31 RID: 7729
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001E32 RID: 7730
		private static readonly IntPtr NativeMethodInfoPtr_DelayedSave_Public_Void_0;

		// Token: 0x04001E33 RID: 7731
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Void_0;

		// Token: 0x04001E34 RID: 7732
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Void_String_0;

		// Token: 0x04001E35 RID: 7733
		private static readonly IntPtr NativeMethodInfoPtr_ClearBaseLevelOutdatedSaves_Private_Void_String_0;

		// Token: 0x04001E36 RID: 7734
		private static readonly IntPtr NativeMethodInfoPtr_CompleteSaveable_Public_Void_ISaveable_0;

		// Token: 0x04001E37 RID: 7735
		private static readonly IntPtr NativeMethodInfoPtr_ClearCompletedSaveable_Public_Void_ISaveable_0;

		// Token: 0x04001E38 RID: 7736
		private static readonly IntPtr NativeMethodInfoPtr_RegisterSaveable_Public_Void_ISaveable_0;

		// Token: 0x04001E39 RID: 7737
		private static readonly IntPtr NativeMethodInfoPtr_QueueSaveRequest_Public_Void_SaveRequest_0;

		// Token: 0x04001E3A RID: 7738
		private static readonly IntPtr NativeMethodInfoPtr_DequeueSaveRequest_Public_Void_SaveRequest_0;

		// Token: 0x04001E3B RID: 7739
		private static readonly IntPtr NativeMethodInfoPtr_StripExtensions_Public_Static_String_String_0;

		// Token: 0x04001E3C RID: 7740
		private static readonly IntPtr NativeMethodInfoPtr_MakeFileSafe_Public_Static_String_String_0;

		// Token: 0x04001E3D RID: 7741
		private static readonly IntPtr NativeMethodInfoPtr_GetVersionNumber_Public_Static_Single_String_0;

		// Token: 0x04001E3E RID: 7742
		private static readonly IntPtr NativeMethodInfoPtr_Clean_Private_Void_0;

		// Token: 0x04001E3F RID: 7743
		private static readonly IntPtr NativeMethodInfoPtr_DisablePlayTutorial_Public_Void_SaveInfo_0;

		// Token: 0x04001E40 RID: 7744
		private static readonly IntPtr NativeMethodInfoPtr_SanitizeFileName_Public_Static_String_String_0;

		// Token: 0x04001E41 RID: 7745
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008F8 RID: 2296
		[ObfuscatedName("ScheduleOne.Persistence.SaveManager+<>c__DisplayClass51_0")]
		public sealed class __c__DisplayClass51_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C54F RID: 50511 RVA: 0x00300300 File Offset: 0x002FE500
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass51_0()
			{
				Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "<>c__DisplayClass51_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0>.NativeClassPtr);
				SaveManager.__c__DisplayClass51_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0>.NativeClassPtr, "<>4__this");
				SaveManager.__c__DisplayClass51_0.NativeFieldInfoPtr_saveFolderPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0>.NativeClassPtr, "saveFolderPath");
				SaveManager.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0>.NativeClassPtr, 100668507);
				SaveManager.__c__DisplayClass51_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0>.NativeClassPtr, 100668508);
			}

			// Token: 0x0600C550 RID: 50512 RVA: 0x0030037C File Offset: 0x002FE57C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass51_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C551 RID: 50513 RVA: 0x003003B8 File Offset: 0x002FE5B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126628, XrefRangeEnd = 126633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.__c__DisplayClass51_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C552 RID: 50514 RVA: 0x0006002E File Offset: 0x0005E22E
			public __c__DisplayClass51_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D91 RID: 15761
			// (get) Token: 0x0600C553 RID: 50515 RVA: 0x003003F8 File Offset: 0x002FE5F8
			// (set) Token: 0x0600C554 RID: 50516 RVA: 0x00060037 File Offset: 0x0005E237
			public unsafe SaveManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.__c__DisplayClass51_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.__c__DisplayClass51_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D92 RID: 15762
			// (get) Token: 0x0600C555 RID: 50517 RVA: 0x00300428 File Offset: 0x002FE628
			// (set) Token: 0x0600C556 RID: 50518 RVA: 0x00060056 File Offset: 0x0005E256
			public unsafe string saveFolderPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.__c__DisplayClass51_0.NativeFieldInfoPtr_saveFolderPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.__c__DisplayClass51_0.NativeFieldInfoPtr_saveFolderPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040085C1 RID: 34241
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040085C2 RID: 34242
			private static readonly IntPtr NativeFieldInfoPtr_saveFolderPath;

			// Token: 0x040085C3 RID: 34243
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040085C4 RID: 34244
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C3C RID: 3132
			[ObfuscatedName("ScheduleOne.Persistence.SaveManager+<>c__DisplayClass51_0+<<Save>g__SaveRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E1ED RID: 57837 RVA: 0x0035161C File Offset: 0x0034F81C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0>.NativeClassPtr, "<<Save>g__SaveRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668509);
					SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668510);
					SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668511);
					SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668512);
					SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668513);
					SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668514);
				}

				// Token: 0x0600E1EE RID: 57838 RVA: 0x003516FC File Offset: 0x0034F8FC
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E1EF RID: 57839 RVA: 0x00351744 File Offset: 0x0034F944
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E1F0 RID: 57840 RVA: 0x00351778 File Offset: 0x0034F978
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126532, XrefRangeEnd = 126623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004609 RID: 17929
				// (get) Token: 0x0600E1F1 RID: 57841 RVA: 0x003517B4 File Offset: 0x0034F9B4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E1F2 RID: 57842 RVA: 0x003517F4 File Offset: 0x0034F9F4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126623, XrefRangeEnd = 126628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700460A RID: 17930
				// (get) Token: 0x0600E1F3 RID: 57843 RVA: 0x00351828 File Offset: 0x0034FA28
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E1F4 RID: 57844 RVA: 0x0006E267 File Offset: 0x0006C467
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004606 RID: 17926
				// (get) Token: 0x0600E1F5 RID: 57845 RVA: 0x00351868 File Offset: 0x0034FA68
				// (set) Token: 0x0600E1F6 RID: 57846 RVA: 0x0006E270 File Offset: 0x0006C470
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004607 RID: 17927
				// (get) Token: 0x0600E1F7 RID: 57847 RVA: 0x00351890 File Offset: 0x0034FA90
				// (set) Token: 0x0600E1F8 RID: 57848 RVA: 0x0006E28B File Offset: 0x0006C48B
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004608 RID: 17928
				// (get) Token: 0x0600E1F9 RID: 57849 RVA: 0x003518C0 File Offset: 0x0034FAC0
				// (set) Token: 0x0600E1FA RID: 57850 RVA: 0x0006E2AA File Offset: 0x0006C4AA
				public unsafe SaveManager.__c__DisplayClass51_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveManager.__c__DisplayClass51_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009740 RID: 38720
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009741 RID: 38721
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009742 RID: 38722
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009743 RID: 38723
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009744 RID: 38724
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009745 RID: 38725
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009746 RID: 38726
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009747 RID: 38727
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009748 RID: 38728
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
