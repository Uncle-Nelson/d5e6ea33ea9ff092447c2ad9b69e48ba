using System;
using Il2CppFishNet.Transporting;
using Il2CppFishNet.Transporting.Yak;
using Il2CppFishySteamworks;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Persistence.ItemLoaders;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.UI.MainMenu;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x0200021B RID: 539
	public class LoadManager : PersistentSingleton<LoadManager>
	{
		// Token: 0x06002CB7 RID: 11447 RVA: 0x000FE9BC File Offset: 0x000FCBBC
		// Note: this type is marked as 'beforefieldinit'.
		static LoadManager()
		{
			Il2CppClassPointerStore<LoadManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "LoadManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager>.NativeClassPtr);
			LoadManager.NativeFieldInfoPtr_LOADS_PER_FRAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "LOADS_PER_FRAME");
			LoadManager.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "DEBUG");
			LoadManager.NativeFieldInfoPtr_LOAD_ERROR_TIMEOUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "LOAD_ERROR_TIMEOUT");
			LoadManager.NativeFieldInfoPtr_NETWORK_TIMEOUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "NETWORK_TIMEOUT");
			LoadManager.NativeFieldInfoPtr_LoadHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "LoadHistory");
			LoadManager.NativeFieldInfoPtr_SaveGames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "SaveGames");
			LoadManager.NativeFieldInfoPtr_LastPlayedGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "LastPlayedGame");
			LoadManager.NativeFieldInfoPtr__IsGameLoaded_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<IsGameLoaded>k__BackingField");
			LoadManager.NativeFieldInfoPtr__IsLoading_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<IsLoading>k__BackingField");
			LoadManager.NativeFieldInfoPtr__TimeSinceGameLoaded_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<TimeSinceGameLoaded>k__BackingField");
			LoadManager.NativeFieldInfoPtr__DebugMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<DebugMode>k__BackingField");
			LoadManager.NativeFieldInfoPtr__LoadStatus_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<LoadStatus>k__BackingField");
			LoadManager.NativeFieldInfoPtr__LoadedGameFolderPath_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<LoadedGameFolderPath>k__BackingField");
			LoadManager.NativeFieldInfoPtr__ActiveSaveInfo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<ActiveSaveInfo>k__BackingField");
			LoadManager.NativeFieldInfoPtr__StoredSaveInfo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<StoredSaveInfo>k__BackingField");
			LoadManager.NativeFieldInfoPtr_loadRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "loadRequests");
			LoadManager.NativeFieldInfoPtr_ItemLoaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "ItemLoaders");
			LoadManager.NativeFieldInfoPtr_ObjectLoaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "ObjectLoaders");
			LoadManager.NativeFieldInfoPtr_NPCLoaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "NPCLoaders");
			LoadManager.NativeFieldInfoPtr_onPreSceneChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "onPreSceneChange");
			LoadManager.NativeFieldInfoPtr_onPreLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "onPreLoad");
			LoadManager.NativeFieldInfoPtr_onLoadComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "onLoadComplete");
			LoadManager.NativeFieldInfoPtr_onSaveInfoLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "onSaveInfoLoaded");
			LoadManager.NativeMethodInfoPtr_get_DefaultTutorialSaveFolder_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668347);
			LoadManager.NativeMethodInfoPtr_get_IsGameLoaded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668348);
			LoadManager.NativeMethodInfoPtr_set_IsGameLoaded_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668349);
			LoadManager.NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668350);
			LoadManager.NativeMethodInfoPtr_set_IsLoading_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668351);
			LoadManager.NativeMethodInfoPtr_get_TimeSinceGameLoaded_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668352);
			LoadManager.NativeMethodInfoPtr_set_TimeSinceGameLoaded_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668353);
			LoadManager.NativeMethodInfoPtr_get_DebugMode_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668354);
			LoadManager.NativeMethodInfoPtr_set_DebugMode_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668355);
			LoadManager.NativeMethodInfoPtr_get_LoadStatus_Public_get_ELoadStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668356);
			LoadManager.NativeMethodInfoPtr_set_LoadStatus_Protected_set_Void_ELoadStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668357);
			LoadManager.NativeMethodInfoPtr_get_LoadedGameFolderPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668358);
			LoadManager.NativeMethodInfoPtr_set_LoadedGameFolderPath_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668359);
			LoadManager.NativeMethodInfoPtr_get_ActiveSaveInfo_Public_get_SaveInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668360);
			LoadManager.NativeMethodInfoPtr_set_ActiveSaveInfo_Private_set_Void_SaveInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668361);
			LoadManager.NativeMethodInfoPtr_get_StoredSaveInfo_Public_get_SaveInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668362);
			LoadManager.NativeMethodInfoPtr_set_StoredSaveInfo_Private_set_Void_SaveInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668363);
			LoadManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668364);
			LoadManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668365);
			LoadManager.NativeMethodInfoPtr_Bananas_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668366);
			LoadManager.NativeMethodInfoPtr_InitializeItemLoaders_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668367);
			LoadManager.NativeMethodInfoPtr_InitializeObjectLoaders_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668368);
			LoadManager.NativeMethodInfoPtr_InitializeNPCLoaders_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668369);
			LoadManager.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668370);
			LoadManager.NativeMethodInfoPtr_QueueLoadRequest_Public_Void_LoadRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668371);
			LoadManager.NativeMethodInfoPtr_DequeueLoadRequest_Public_Void_LoadRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668372);
			LoadManager.NativeMethodInfoPtr_GetItemLoader_Public_ItemLoader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668373);
			LoadManager.NativeMethodInfoPtr_GetObjectLoader_Public_BuildableItemLoader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668374);
			LoadManager.NativeMethodInfoPtr_GetNPCLoader_Public_NPCLoader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668375);
			LoadManager.NativeMethodInfoPtr_GetLoadStatusText_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668376);
			LoadManager.NativeMethodInfoPtr_StartGame_Public_Void_SaveInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668377);
			LoadManager.NativeMethodInfoPtr_LoadTutorialAsClient_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668378);
			LoadManager.NativeMethodInfoPtr_LoadAsClient_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668379);
			LoadManager.NativeMethodInfoPtr_StartLoadErrorAutosubmit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668380);
			LoadManager.NativeMethodInfoPtr_SetWaitingForHostLoad_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668381);
			LoadManager.NativeMethodInfoPtr_LoadLastSave_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668382);
			LoadManager.NativeMethodInfoPtr_CleanUp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668383);
			LoadManager.NativeMethodInfoPtr_ExitToMenu_Public_Void_SaveInfo_Data_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668384);
			LoadManager.NativeMethodInfoPtr_RefreshSaveInfo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668385);
			LoadManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668386);
			LoadManager.NativeMethodInfoPtr_Method_Internal_Static_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668388);
			LoadManager.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668389);
		}

		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x06002CB8 RID: 11448 RVA: 0x000FEF00 File Offset: 0x000FD100
		public unsafe string DefaultTutorialSaveFolder
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 125487, RefRangeEnd = 125489, XrefRangeStart = 125477, XrefRangeEnd = 125487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_DefaultTutorialSaveFolder_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x06002CB9 RID: 11449 RVA: 0x000FEF38 File Offset: 0x000FD138
		// (set) Token: 0x06002CBA RID: 11450 RVA: 0x000FEF74 File Offset: 0x000FD174
		public unsafe bool IsGameLoaded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_IsGameLoaded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_set_IsGameLoaded_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x06002CBB RID: 11451 RVA: 0x000FEFB4 File Offset: 0x000FD1B4
		// (set) Token: 0x06002CBC RID: 11452 RVA: 0x000FEFF0 File Offset: 0x000FD1F0
		public unsafe bool IsLoading
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_set_IsLoading_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x06002CBD RID: 11453 RVA: 0x000FF030 File Offset: 0x000FD230
		// (set) Token: 0x06002CBE RID: 11454 RVA: 0x000FF06C File Offset: 0x000FD26C
		public unsafe float TimeSinceGameLoaded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_TimeSinceGameLoaded_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_set_TimeSinceGameLoaded_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x06002CBF RID: 11455 RVA: 0x000FF0AC File Offset: 0x000FD2AC
		// (set) Token: 0x06002CC0 RID: 11456 RVA: 0x000FF0E8 File Offset: 0x000FD2E8
		public unsafe bool DebugMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_DebugMode_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_set_DebugMode_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x06002CC1 RID: 11457 RVA: 0x000FF128 File Offset: 0x000FD328
		// (set) Token: 0x06002CC2 RID: 11458 RVA: 0x000FF164 File Offset: 0x000FD364
		public unsafe LoadManager.ELoadStatus LoadStatus
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 45639, RefRangeEnd = 45640, XrefRangeStart = 45639, XrefRangeEnd = 45640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_LoadStatus_Public_get_ELoadStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_set_LoadStatus_Protected_set_Void_ELoadStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x06002CC3 RID: 11459 RVA: 0x000FF1A4 File Offset: 0x000FD3A4
		// (set) Token: 0x06002CC4 RID: 11460 RVA: 0x000FF1DC File Offset: 0x000FD3DC
		public unsafe string LoadedGameFolderPath
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 19660, RefRangeEnd = 19667, XrefRangeStart = 19660, XrefRangeEnd = 19667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_LoadedGameFolderPath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_set_LoadedGameFolderPath_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000EF9 RID: 3833
		// (get) Token: 0x06002CC5 RID: 11461 RVA: 0x000FF220 File Offset: 0x000FD420
		// (set) Token: 0x06002CC6 RID: 11462 RVA: 0x000FF260 File Offset: 0x000FD460
		public unsafe SaveInfo ActiveSaveInfo
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35358, RefRangeEnd = 35359, XrefRangeStart = 35358, XrefRangeEnd = 35359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_ActiveSaveInfo_Public_get_SaveInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SaveInfo>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_set_ActiveSaveInfo_Private_set_Void_SaveInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000EFA RID: 3834
		// (get) Token: 0x06002CC7 RID: 11463 RVA: 0x000FF2A4 File Offset: 0x000FD4A4
		// (set) Token: 0x06002CC8 RID: 11464 RVA: 0x000FF2E4 File Offset: 0x000FD4E4
		public unsafe SaveInfo StoredSaveInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_StoredSaveInfo_Public_get_SaveInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SaveInfo>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_set_StoredSaveInfo_Private_set_Void_SaveInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CC9 RID: 11465 RVA: 0x000FF328 File Offset: 0x000FD528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125489, XrefRangeEnd = 125492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CCA RID: 11466 RVA: 0x000FF364 File Offset: 0x000FD564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125492, XrefRangeEnd = 125610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CCB RID: 11467 RVA: 0x000FF3A0 File Offset: 0x000FD5A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125660, RefRangeEnd = 125661, XrefRangeStart = 125610, XrefRangeEnd = 125660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bananas()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_Bananas_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CCC RID: 11468 RVA: 0x000FF3D4 File Offset: 0x000FD5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125661, XrefRangeEnd = 125705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeItemLoaders()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_InitializeItemLoaders_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CCD RID: 11469 RVA: 0x000FF408 File Offset: 0x000FD608
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125781, RefRangeEnd = 125782, XrefRangeStart = 125705, XrefRangeEnd = 125781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeObjectLoaders()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_InitializeObjectLoaders_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CCE RID: 11470 RVA: 0x000FF43C File Offset: 0x000FD63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125782, XrefRangeEnd = 125806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeNPCLoaders()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_InitializeNPCLoaders_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CCF RID: 11471 RVA: 0x000FF470 File Offset: 0x000FD670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125806, XrefRangeEnd = 125847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CD0 RID: 11472 RVA: 0x000FF4A4 File Offset: 0x000FD6A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125847, XrefRangeEnd = 125853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueLoadRequest(LoadRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_QueueLoadRequest_Public_Void_LoadRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CD1 RID: 11473 RVA: 0x000FF4E8 File Offset: 0x000FD6E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125853, XrefRangeEnd = 125857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DequeueLoadRequest(LoadRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_DequeueLoadRequest_Public_Void_LoadRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CD2 RID: 11474 RVA: 0x000FF52C File Offset: 0x000FD72C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125878, RefRangeEnd = 125879, XrefRangeStart = 125857, XrefRangeEnd = 125878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemLoader GetItemLoader(string itemType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_GetItemLoader_Public_ItemLoader_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemLoader>(intPtr3) : null;
		}

		// Token: 0x06002CD3 RID: 11475 RVA: 0x000FF57C File Offset: 0x000FD77C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125879, XrefRangeEnd = 125900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildableItemLoader GetObjectLoader(string objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(objectType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_GetObjectLoader_Public_BuildableItemLoader_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BuildableItemLoader>(intPtr3) : null;
		}

		// Token: 0x06002CD4 RID: 11476 RVA: 0x000FF5CC File Offset: 0x000FD7CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125921, RefRangeEnd = 125922, XrefRangeStart = 125900, XrefRangeEnd = 125921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCLoader GetNPCLoader(string npcType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_GetNPCLoader_Public_NPCLoader_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCLoader>(intPtr3) : null;
		}

		// Token: 0x06002CD5 RID: 11477 RVA: 0x000FF61C File Offset: 0x000FD81C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125929, RefRangeEnd = 125930, XrefRangeStart = 125922, XrefRangeEnd = 125929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLoadStatusText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_GetLoadStatusText_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002CD6 RID: 11478 RVA: 0x000FF654 File Offset: 0x000FD854
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 125949, RefRangeEnd = 125953, XrefRangeStart = 125930, XrefRangeEnd = 125949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartGame(SaveInfo info, bool allowLoadStacking = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowLoadStacking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_StartGame_Public_Void_SaveInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CD7 RID: 11479 RVA: 0x000FF6A4 File Offset: 0x000FD8A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125972, RefRangeEnd = 125973, XrefRangeStart = 125953, XrefRangeEnd = 125972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadTutorialAsClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_LoadTutorialAsClient_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CD8 RID: 11480 RVA: 0x000FF6D8 File Offset: 0x000FD8D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125993, RefRangeEnd = 125994, XrefRangeStart = 125973, XrefRangeEnd = 125993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadAsClient(string steamId64)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(steamId64);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_LoadAsClient_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CD9 RID: 11481 RVA: 0x000FF71C File Offset: 0x000FD91C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125994, XrefRangeEnd = 126000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartLoadErrorAutosubmit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_StartLoadErrorAutosubmit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CDA RID: 11482 RVA: 0x000FF750 File Offset: 0x000FD950
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 126000, RefRangeEnd = 126002, XrefRangeStart = 126000, XrefRangeEnd = 126000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWaitingForHostLoad()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_SetWaitingForHostLoad_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CDB RID: 11483 RVA: 0x000FF784 File Offset: 0x000FD984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126002, XrefRangeEnd = 126009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadLastSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_LoadLastSave_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CDC RID: 11484 RVA: 0x000FF7B8 File Offset: 0x000FD9B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 126084, RefRangeEnd = 126087, XrefRangeStart = 126009, XrefRangeEnd = 126084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_CleanUp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CDD RID: 11485 RVA: 0x000FF7EC File Offset: 0x000FD9EC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 126147, RefRangeEnd = 126154, XrefRangeStart = 126087, XrefRangeEnd = 126147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitToMenu(SaveInfo autoLoadSave = null, MainMenuPopup.Data mainMenuPopup = null, bool preventLeaveLobby = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(autoLoadSave);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mainMenuPopup);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preventLeaveLobby;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_ExitToMenu_Public_Void_SaveInfo_Data_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CDE RID: 11486 RVA: 0x000FF850 File Offset: 0x000FDA50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 126346, RefRangeEnd = 126348, XrefRangeStart = 126154, XrefRangeEnd = 126346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshSaveInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_RefreshSaveInfo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CDF RID: 11487 RVA: 0x000FF884 File Offset: 0x000FDA84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126348, XrefRangeEnd = 126382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CE0 RID: 11488 RVA: 0x000FF8C0 File Offset: 0x000FDAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126382, XrefRangeEnd = 126408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_PDM_0()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_Method_Internal_Static_Void_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CE1 RID: 11489 RVA: 0x000FF8E8 File Offset: 0x000FDAE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126408, XrefRangeEnd = 126413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002CE2 RID: 11490 RVA: 0x000180F9 File Offset: 0x000162F9
		public LoadManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x06002CE3 RID: 11491 RVA: 0x000FF928 File Offset: 0x000FDB28
		// (set) Token: 0x06002CE4 RID: 11492 RVA: 0x00018102 File Offset: 0x00016302
		public unsafe static int LOADS_PER_FRAME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LoadManager.NativeFieldInfoPtr_LOADS_PER_FRAME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadManager.NativeFieldInfoPtr_LOADS_PER_FRAME, (void*)(&value));
			}
		}

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x06002CE5 RID: 11493 RVA: 0x000FF944 File Offset: 0x000FDB44
		// (set) Token: 0x06002CE6 RID: 11494 RVA: 0x00018110 File Offset: 0x00016310
		public unsafe static bool DEBUG
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(LoadManager.NativeFieldInfoPtr_DEBUG, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadManager.NativeFieldInfoPtr_DEBUG, (void*)(&value));
			}
		}

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x06002CE7 RID: 11495 RVA: 0x000FF960 File Offset: 0x000FDB60
		// (set) Token: 0x06002CE8 RID: 11496 RVA: 0x0001811E File Offset: 0x0001631E
		public unsafe static float LOAD_ERROR_TIMEOUT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LoadManager.NativeFieldInfoPtr_LOAD_ERROR_TIMEOUT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadManager.NativeFieldInfoPtr_LOAD_ERROR_TIMEOUT, (void*)(&value));
			}
		}

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x06002CE9 RID: 11497 RVA: 0x000FF97C File Offset: 0x000FDB7C
		// (set) Token: 0x06002CEA RID: 11498 RVA: 0x0001812C File Offset: 0x0001632C
		public unsafe static float NETWORK_TIMEOUT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LoadManager.NativeFieldInfoPtr_NETWORK_TIMEOUT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadManager.NativeFieldInfoPtr_NETWORK_TIMEOUT, (void*)(&value));
			}
		}

		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x06002CEB RID: 11499 RVA: 0x000FF998 File Offset: 0x000FDB98
		// (set) Token: 0x06002CEC RID: 11500 RVA: 0x0001813A File Offset: 0x0001633A
		public unsafe static List<string> LoadHistory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoadManager.NativeFieldInfoPtr_LoadHistory, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadManager.NativeFieldInfoPtr_LoadHistory, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x06002CED RID: 11501 RVA: 0x000FF9C0 File Offset: 0x000FDBC0
		// (set) Token: 0x06002CEE RID: 11502 RVA: 0x0001814C File Offset: 0x0001634C
		public unsafe static Il2CppReferenceArray<SaveInfo> SaveGames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoadManager.NativeFieldInfoPtr_SaveGames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SaveInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadManager.NativeFieldInfoPtr_SaveGames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE1 RID: 3809
		// (get) Token: 0x06002CEF RID: 11503 RVA: 0x000FF9E8 File Offset: 0x000FDBE8
		// (set) Token: 0x06002CF0 RID: 11504 RVA: 0x0001815E File Offset: 0x0001635E
		public unsafe static SaveInfo LastPlayedGame
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoadManager.NativeFieldInfoPtr_LastPlayedGame, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadManager.NativeFieldInfoPtr_LastPlayedGame, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE2 RID: 3810
		// (get) Token: 0x06002CF1 RID: 11505 RVA: 0x000FFA10 File Offset: 0x000FDC10
		// (set) Token: 0x06002CF2 RID: 11506 RVA: 0x00018170 File Offset: 0x00016370
		public unsafe bool _IsGameLoaded_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__IsGameLoaded_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__IsGameLoaded_k__BackingField)) = value;
			}
		}

		// Token: 0x17000EE3 RID: 3811
		// (get) Token: 0x06002CF3 RID: 11507 RVA: 0x000FFA38 File Offset: 0x000FDC38
		// (set) Token: 0x06002CF4 RID: 11508 RVA: 0x0001818B File Offset: 0x0001638B
		public unsafe bool _IsLoading_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__IsLoading_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__IsLoading_k__BackingField)) = value;
			}
		}

		// Token: 0x17000EE4 RID: 3812
		// (get) Token: 0x06002CF5 RID: 11509 RVA: 0x000FFA60 File Offset: 0x000FDC60
		// (set) Token: 0x06002CF6 RID: 11510 RVA: 0x000181A6 File Offset: 0x000163A6
		public unsafe float _TimeSinceGameLoaded_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__TimeSinceGameLoaded_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__TimeSinceGameLoaded_k__BackingField)) = value;
			}
		}

		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x06002CF7 RID: 11511 RVA: 0x000FFA88 File Offset: 0x000FDC88
		// (set) Token: 0x06002CF8 RID: 11512 RVA: 0x000181C1 File Offset: 0x000163C1
		public unsafe bool _DebugMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__DebugMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__DebugMode_k__BackingField)) = value;
			}
		}

		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x06002CF9 RID: 11513 RVA: 0x000FFAB0 File Offset: 0x000FDCB0
		// (set) Token: 0x06002CFA RID: 11514 RVA: 0x000181DC File Offset: 0x000163DC
		public unsafe LoadManager.ELoadStatus _LoadStatus_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__LoadStatus_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__LoadStatus_k__BackingField)) = value;
			}
		}

		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x06002CFB RID: 11515 RVA: 0x000FFAD8 File Offset: 0x000FDCD8
		// (set) Token: 0x06002CFC RID: 11516 RVA: 0x000181F7 File Offset: 0x000163F7
		public unsafe string _LoadedGameFolderPath_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__LoadedGameFolderPath_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__LoadedGameFolderPath_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x06002CFD RID: 11517 RVA: 0x000FFB00 File Offset: 0x000FDD00
		// (set) Token: 0x06002CFE RID: 11518 RVA: 0x00018216 File Offset: 0x00016416
		public unsafe SaveInfo _ActiveSaveInfo_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__ActiveSaveInfo_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__ActiveSaveInfo_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x06002CFF RID: 11519 RVA: 0x000FFB30 File Offset: 0x000FDD30
		// (set) Token: 0x06002D00 RID: 11520 RVA: 0x00018235 File Offset: 0x00016435
		public unsafe SaveInfo _StoredSaveInfo_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__StoredSaveInfo_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__StoredSaveInfo_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x06002D01 RID: 11521 RVA: 0x000FFB60 File Offset: 0x000FDD60
		// (set) Token: 0x06002D02 RID: 11522 RVA: 0x00018254 File Offset: 0x00016454
		public unsafe List<LoadRequest> loadRequests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_loadRequests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LoadRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_loadRequests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x06002D03 RID: 11523 RVA: 0x000FFB90 File Offset: 0x000FDD90
		// (set) Token: 0x06002D04 RID: 11524 RVA: 0x00018273 File Offset: 0x00016473
		public unsafe List<ItemLoader> ItemLoaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_ItemLoaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemLoader>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_ItemLoaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x06002D05 RID: 11525 RVA: 0x000FFBC0 File Offset: 0x000FDDC0
		// (set) Token: 0x06002D06 RID: 11526 RVA: 0x00018292 File Offset: 0x00016492
		public unsafe List<BuildableItemLoader> ObjectLoaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_ObjectLoaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BuildableItemLoader>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_ObjectLoaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EED RID: 3821
		// (get) Token: 0x06002D07 RID: 11527 RVA: 0x000FFBF0 File Offset: 0x000FDDF0
		// (set) Token: 0x06002D08 RID: 11528 RVA: 0x000182B1 File Offset: 0x000164B1
		public unsafe List<NPCLoader> NPCLoaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_NPCLoaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCLoader>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_NPCLoaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x06002D09 RID: 11529 RVA: 0x000FFC20 File Offset: 0x000FDE20
		// (set) Token: 0x06002D0A RID: 11530 RVA: 0x000182D0 File Offset: 0x000164D0
		public unsafe UnityEvent onPreSceneChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_onPreSceneChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_onPreSceneChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x06002D0B RID: 11531 RVA: 0x000FFC50 File Offset: 0x000FDE50
		// (set) Token: 0x06002D0C RID: 11532 RVA: 0x000182EF File Offset: 0x000164EF
		public unsafe UnityEvent onPreLoad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_onPreLoad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_onPreLoad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x06002D0D RID: 11533 RVA: 0x000FFC80 File Offset: 0x000FDE80
		// (set) Token: 0x06002D0E RID: 11534 RVA: 0x0001830E File Offset: 0x0001650E
		public unsafe UnityEvent onLoadComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_onLoadComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_onLoadComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x06002D0F RID: 11535 RVA: 0x000FFCB0 File Offset: 0x000FDEB0
		// (set) Token: 0x06002D10 RID: 11536 RVA: 0x0001832D File Offset: 0x0001652D
		public unsafe UnityEvent onSaveInfoLoaded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_onSaveInfoLoaded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_onSaveInfoLoaded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001DB1 RID: 7601
		private static readonly IntPtr NativeFieldInfoPtr_LOADS_PER_FRAME;

		// Token: 0x04001DB2 RID: 7602
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04001DB3 RID: 7603
		private static readonly IntPtr NativeFieldInfoPtr_LOAD_ERROR_TIMEOUT;

		// Token: 0x04001DB4 RID: 7604
		private static readonly IntPtr NativeFieldInfoPtr_NETWORK_TIMEOUT;

		// Token: 0x04001DB5 RID: 7605
		private static readonly IntPtr NativeFieldInfoPtr_LoadHistory;

		// Token: 0x04001DB6 RID: 7606
		private static readonly IntPtr NativeFieldInfoPtr_SaveGames;

		// Token: 0x04001DB7 RID: 7607
		private static readonly IntPtr NativeFieldInfoPtr_LastPlayedGame;

		// Token: 0x04001DB8 RID: 7608
		private static readonly IntPtr NativeFieldInfoPtr__IsGameLoaded_k__BackingField;

		// Token: 0x04001DB9 RID: 7609
		private static readonly IntPtr NativeFieldInfoPtr__IsLoading_k__BackingField;

		// Token: 0x04001DBA RID: 7610
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceGameLoaded_k__BackingField;

		// Token: 0x04001DBB RID: 7611
		private static readonly IntPtr NativeFieldInfoPtr__DebugMode_k__BackingField;

		// Token: 0x04001DBC RID: 7612
		private static readonly IntPtr NativeFieldInfoPtr__LoadStatus_k__BackingField;

		// Token: 0x04001DBD RID: 7613
		private static readonly IntPtr NativeFieldInfoPtr__LoadedGameFolderPath_k__BackingField;

		// Token: 0x04001DBE RID: 7614
		private static readonly IntPtr NativeFieldInfoPtr__ActiveSaveInfo_k__BackingField;

		// Token: 0x04001DBF RID: 7615
		private static readonly IntPtr NativeFieldInfoPtr__StoredSaveInfo_k__BackingField;

		// Token: 0x04001DC0 RID: 7616
		private static readonly IntPtr NativeFieldInfoPtr_loadRequests;

		// Token: 0x04001DC1 RID: 7617
		private static readonly IntPtr NativeFieldInfoPtr_ItemLoaders;

		// Token: 0x04001DC2 RID: 7618
		private static readonly IntPtr NativeFieldInfoPtr_ObjectLoaders;

		// Token: 0x04001DC3 RID: 7619
		private static readonly IntPtr NativeFieldInfoPtr_NPCLoaders;

		// Token: 0x04001DC4 RID: 7620
		private static readonly IntPtr NativeFieldInfoPtr_onPreSceneChange;

		// Token: 0x04001DC5 RID: 7621
		private static readonly IntPtr NativeFieldInfoPtr_onPreLoad;

		// Token: 0x04001DC6 RID: 7622
		private static readonly IntPtr NativeFieldInfoPtr_onLoadComplete;

		// Token: 0x04001DC7 RID: 7623
		private static readonly IntPtr NativeFieldInfoPtr_onSaveInfoLoaded;

		// Token: 0x04001DC8 RID: 7624
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultTutorialSaveFolder_Public_get_String_0;

		// Token: 0x04001DC9 RID: 7625
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGameLoaded_Public_get_Boolean_0;

		// Token: 0x04001DCA RID: 7626
		private static readonly IntPtr NativeMethodInfoPtr_set_IsGameLoaded_Protected_set_Void_Boolean_0;

		// Token: 0x04001DCB RID: 7627
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0;

		// Token: 0x04001DCC RID: 7628
		private static readonly IntPtr NativeMethodInfoPtr_set_IsLoading_Protected_set_Void_Boolean_0;

		// Token: 0x04001DCD RID: 7629
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceGameLoaded_Public_get_Single_0;

		// Token: 0x04001DCE RID: 7630
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceGameLoaded_Protected_set_Void_Single_0;

		// Token: 0x04001DCF RID: 7631
		private static readonly IntPtr NativeMethodInfoPtr_get_DebugMode_Public_get_Boolean_0;

		// Token: 0x04001DD0 RID: 7632
		private static readonly IntPtr NativeMethodInfoPtr_set_DebugMode_Protected_set_Void_Boolean_0;

		// Token: 0x04001DD1 RID: 7633
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadStatus_Public_get_ELoadStatus_0;

		// Token: 0x04001DD2 RID: 7634
		private static readonly IntPtr NativeMethodInfoPtr_set_LoadStatus_Protected_set_Void_ELoadStatus_0;

		// Token: 0x04001DD3 RID: 7635
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadedGameFolderPath_Public_get_String_0;

		// Token: 0x04001DD4 RID: 7636
		private static readonly IntPtr NativeMethodInfoPtr_set_LoadedGameFolderPath_Protected_set_Void_String_0;

		// Token: 0x04001DD5 RID: 7637
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveSaveInfo_Public_get_SaveInfo_0;

		// Token: 0x04001DD6 RID: 7638
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveSaveInfo_Private_set_Void_SaveInfo_0;

		// Token: 0x04001DD7 RID: 7639
		private static readonly IntPtr NativeMethodInfoPtr_get_StoredSaveInfo_Public_get_SaveInfo_0;

		// Token: 0x04001DD8 RID: 7640
		private static readonly IntPtr NativeMethodInfoPtr_set_StoredSaveInfo_Private_set_Void_SaveInfo_0;

		// Token: 0x04001DD9 RID: 7641
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04001DDA RID: 7642
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04001DDB RID: 7643
		private static readonly IntPtr NativeMethodInfoPtr_Bananas_Private_Void_0;

		// Token: 0x04001DDC RID: 7644
		private static readonly IntPtr NativeMethodInfoPtr_InitializeItemLoaders_Private_Void_0;

		// Token: 0x04001DDD RID: 7645
		private static readonly IntPtr NativeMethodInfoPtr_InitializeObjectLoaders_Private_Void_0;

		// Token: 0x04001DDE RID: 7646
		private static readonly IntPtr NativeMethodInfoPtr_InitializeNPCLoaders_Private_Void_0;

		// Token: 0x04001DDF RID: 7647
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04001DE0 RID: 7648
		private static readonly IntPtr NativeMethodInfoPtr_QueueLoadRequest_Public_Void_LoadRequest_0;

		// Token: 0x04001DE1 RID: 7649
		private static readonly IntPtr NativeMethodInfoPtr_DequeueLoadRequest_Public_Void_LoadRequest_0;

		// Token: 0x04001DE2 RID: 7650
		private static readonly IntPtr NativeMethodInfoPtr_GetItemLoader_Public_ItemLoader_String_0;

		// Token: 0x04001DE3 RID: 7651
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectLoader_Public_BuildableItemLoader_String_0;

		// Token: 0x04001DE4 RID: 7652
		private static readonly IntPtr NativeMethodInfoPtr_GetNPCLoader_Public_NPCLoader_String_0;

		// Token: 0x04001DE5 RID: 7653
		private static readonly IntPtr NativeMethodInfoPtr_GetLoadStatusText_Public_String_0;

		// Token: 0x04001DE6 RID: 7654
		private static readonly IntPtr NativeMethodInfoPtr_StartGame_Public_Void_SaveInfo_Boolean_0;

		// Token: 0x04001DE7 RID: 7655
		private static readonly IntPtr NativeMethodInfoPtr_LoadTutorialAsClient_Public_Void_0;

		// Token: 0x04001DE8 RID: 7656
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsClient_Public_Void_String_0;

		// Token: 0x04001DE9 RID: 7657
		private static readonly IntPtr NativeMethodInfoPtr_StartLoadErrorAutosubmit_Private_Void_0;

		// Token: 0x04001DEA RID: 7658
		private static readonly IntPtr NativeMethodInfoPtr_SetWaitingForHostLoad_Public_Void_0;

		// Token: 0x04001DEB RID: 7659
		private static readonly IntPtr NativeMethodInfoPtr_LoadLastSave_Public_Void_0;

		// Token: 0x04001DEC RID: 7660
		private static readonly IntPtr NativeMethodInfoPtr_CleanUp_Private_Void_0;

		// Token: 0x04001DED RID: 7661
		private static readonly IntPtr NativeMethodInfoPtr_ExitToMenu_Public_Void_SaveInfo_Data_Boolean_0;

		// Token: 0x04001DEE RID: 7662
		private static readonly IntPtr NativeMethodInfoPtr_RefreshSaveInfo_Public_Void_0;

		// Token: 0x04001DEF RID: 7663
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001DF0 RID: 7664
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_PDM_0;

		// Token: 0x04001DF1 RID: 7665
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x020008EC RID: 2284
		[OriginalName("Assembly-CSharp.dll", "", "ELoadStatus")]
		public enum ELoadStatus
		{
			// Token: 0x04008576 RID: 34166
			None,
			// Token: 0x04008577 RID: 34167
			LoadingScene,
			// Token: 0x04008578 RID: 34168
			Initializing,
			// Token: 0x04008579 RID: 34169
			LoadingData,
			// Token: 0x0400857A RID: 34170
			SpawningPlayer,
			// Token: 0x0400857B RID: 34171
			WaitingForHost
		}

		// Token: 0x020008ED RID: 2285
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<<StartLoadErrorAutosubmit>g__Wait|66_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C4D5 RID: 50389 RVA: 0x002FED4C File Offset: 0x002FCF4C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique()
			{
				Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<<StartLoadErrorAutosubmit>g__Wait|66_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr);
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, "<>1__state");
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, "<>2__current");
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, "<>4__this");
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr__t_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, "<t>5__2");
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, 100668390);
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, 100668391);
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, 100668392);
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, 100668393);
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, 100668394);
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, 100668395);
			}

			// Token: 0x0600C4D6 RID: 50390 RVA: 0x002FEE40 File Offset: 0x002FD040
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C4D7 RID: 50391 RVA: 0x002FEE88 File Offset: 0x002FD088
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C4D8 RID: 50392 RVA: 0x002FEEBC File Offset: 0x002FD0BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124609, XrefRangeEnd = 124622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003D74 RID: 15732
			// (get) Token: 0x0600C4D9 RID: 50393 RVA: 0x002FEEF8 File Offset: 0x002FD0F8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C4DA RID: 50394 RVA: 0x002FEF38 File Offset: 0x002FD138
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124622, XrefRangeEnd = 124627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003D75 RID: 15733
			// (get) Token: 0x0600C4DB RID: 50395 RVA: 0x002FEF6C File Offset: 0x002FD16C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C4DC RID: 50396 RVA: 0x0005FCA8 File Offset: 0x0005DEA8
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D70 RID: 15728
			// (get) Token: 0x0600C4DD RID: 50397 RVA: 0x002FEFAC File Offset: 0x002FD1AC
			// (set) Token: 0x0600C4DE RID: 50398 RVA: 0x0005FCB1 File Offset: 0x0005DEB1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003D71 RID: 15729
			// (get) Token: 0x0600C4DF RID: 50399 RVA: 0x002FEFD4 File Offset: 0x002FD1D4
			// (set) Token: 0x0600C4E0 RID: 50400 RVA: 0x0005FCCC File Offset: 0x0005DECC
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D72 RID: 15730
			// (get) Token: 0x0600C4E1 RID: 50401 RVA: 0x002FF004 File Offset: 0x002FD204
			// (set) Token: 0x0600C4E2 RID: 50402 RVA: 0x0005FCEB File Offset: 0x0005DEEB
			public unsafe LoadManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D73 RID: 15731
			// (get) Token: 0x0600C4E3 RID: 50403 RVA: 0x002FF034 File Offset: 0x002FD234
			// (set) Token: 0x0600C4E4 RID: 50404 RVA: 0x0005FD0A File Offset: 0x0005DF0A
			public unsafe float _t_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr__t_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr__t_5__2)) = value;
				}
			}

			// Token: 0x0400857C RID: 34172
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400857D RID: 34173
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400857E RID: 34174
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400857F RID: 34175
			private static readonly IntPtr NativeFieldInfoPtr__t_5__2;

			// Token: 0x04008580 RID: 34176
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008581 RID: 34177
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008582 RID: 34178
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008583 RID: 34179
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008584 RID: 34180
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008585 RID: 34181
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020008EE RID: 2286
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C4E5 RID: 50405 RVA: 0x002FF05C File Offset: 0x002FD25C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr);
				LoadManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9");
				LoadManager.__c.NativeFieldInfoPtr___9__63_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__63_5");
				LoadManager.__c.NativeFieldInfoPtr___9__63_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__63_1");
				LoadManager.__c.NativeFieldInfoPtr___9__63_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__63_2");
				LoadManager.__c.NativeFieldInfoPtr___9__64_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__64_2");
				LoadManager.__c.NativeFieldInfoPtr___9__64_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__64_3");
				LoadManager.__c.NativeFieldInfoPtr___9__64_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__64_4");
				LoadManager.__c.NativeFieldInfoPtr___9__65_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__65_2");
				LoadManager.__c.NativeFieldInfoPtr___9__65_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__65_3");
				LoadManager.__c.NativeFieldInfoPtr___9__65_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__65_4");
				LoadManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668397);
				LoadManager.__c.NativeMethodInfoPtr__StartGame_b__63_5_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668398);
				LoadManager.__c.NativeMethodInfoPtr__StartGame_b__63_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668399);
				LoadManager.__c.NativeMethodInfoPtr__StartGame_b__63_2_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668400);
				LoadManager.__c.NativeMethodInfoPtr__LoadTutorialAsClient_b__64_2_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668401);
				LoadManager.__c.NativeMethodInfoPtr__LoadTutorialAsClient_b__64_3_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668402);
				LoadManager.__c.NativeMethodInfoPtr__LoadTutorialAsClient_b__64_4_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668403);
				LoadManager.__c.NativeMethodInfoPtr__LoadAsClient_b__65_2_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668404);
				LoadManager.__c.NativeMethodInfoPtr__LoadAsClient_b__65_3_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668405);
				LoadManager.__c.NativeMethodInfoPtr__LoadAsClient_b__65_4_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668406);
			}

			// Token: 0x0600C4E6 RID: 50406 RVA: 0x002FF218 File Offset: 0x002FD418
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C4E7 RID: 50407 RVA: 0x002FF254 File Offset: 0x002FD454
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124627, XrefRangeEnd = 124628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StartGame_b__63_5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__StartGame_b__63_5_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C4E8 RID: 50408 RVA: 0x002FF290 File Offset: 0x002FD490
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124628, XrefRangeEnd = 124631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StartGame_b__63_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__StartGame_b__63_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C4E9 RID: 50409 RVA: 0x002FF2CC File Offset: 0x002FD4CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124631, XrefRangeEnd = 124639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StartGame_b__63_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__StartGame_b__63_2_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C4EA RID: 50410 RVA: 0x002FF308 File Offset: 0x002FD508
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadTutorialAsClient_b__64_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__LoadTutorialAsClient_b__64_2_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C4EB RID: 50411 RVA: 0x002FF344 File Offset: 0x002FD544
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadTutorialAsClient_b__64_3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__LoadTutorialAsClient_b__64_3_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C4EC RID: 50412 RVA: 0x002FF380 File Offset: 0x002FD580
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124639, XrefRangeEnd = 124647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadTutorialAsClient_b__64_4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__LoadTutorialAsClient_b__64_4_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C4ED RID: 50413 RVA: 0x002FF3BC File Offset: 0x002FD5BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124647, XrefRangeEnd = 124655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadAsClient_b__65_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__LoadAsClient_b__65_2_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C4EE RID: 50414 RVA: 0x002FF3F8 File Offset: 0x002FD5F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124655, XrefRangeEnd = 124663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadAsClient_b__65_3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__LoadAsClient_b__65_3_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C4EF RID: 50415 RVA: 0x002FF434 File Offset: 0x002FD634
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124663, XrefRangeEnd = 124667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadAsClient_b__65_4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__LoadAsClient_b__65_4_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C4F0 RID: 50416 RVA: 0x0005FD25 File Offset: 0x0005DF25
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D76 RID: 15734
			// (get) Token: 0x0600C4F1 RID: 50417 RVA: 0x002FF470 File Offset: 0x002FD670
			// (set) Token: 0x0600C4F2 RID: 50418 RVA: 0x0005FD2E File Offset: 0x0005DF2E
			public unsafe static LoadManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D77 RID: 15735
			// (get) Token: 0x0600C4F3 RID: 50419 RVA: 0x002FF498 File Offset: 0x002FD698
			// (set) Token: 0x0600C4F4 RID: 50420 RVA: 0x0005FD40 File Offset: 0x0005DF40
			public unsafe static Func<bool> __9__63_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__63_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__63_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D78 RID: 15736
			// (get) Token: 0x0600C4F5 RID: 50421 RVA: 0x002FF4C0 File Offset: 0x002FD6C0
			// (set) Token: 0x0600C4F6 RID: 50422 RVA: 0x0005FD52 File Offset: 0x0005DF52
			public unsafe static Func<bool> __9__63_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__63_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__63_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D79 RID: 15737
			// (get) Token: 0x0600C4F7 RID: 50423 RVA: 0x002FF4E8 File Offset: 0x002FD6E8
			// (set) Token: 0x0600C4F8 RID: 50424 RVA: 0x0005FD64 File Offset: 0x0005DF64
			public unsafe static Func<bool> __9__63_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__63_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__63_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D7A RID: 15738
			// (get) Token: 0x0600C4F9 RID: 50425 RVA: 0x002FF510 File Offset: 0x002FD710
			// (set) Token: 0x0600C4FA RID: 50426 RVA: 0x0005FD76 File Offset: 0x0005DF76
			public unsafe static Func<bool> __9__64_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__64_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__64_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D7B RID: 15739
			// (get) Token: 0x0600C4FB RID: 50427 RVA: 0x002FF538 File Offset: 0x002FD738
			// (set) Token: 0x0600C4FC RID: 50428 RVA: 0x0005FD88 File Offset: 0x0005DF88
			public unsafe static Func<bool> __9__64_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__64_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__64_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D7C RID: 15740
			// (get) Token: 0x0600C4FD RID: 50429 RVA: 0x002FF560 File Offset: 0x002FD760
			// (set) Token: 0x0600C4FE RID: 50430 RVA: 0x0005FD9A File Offset: 0x0005DF9A
			public unsafe static Func<bool> __9__64_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__64_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__64_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D7D RID: 15741
			// (get) Token: 0x0600C4FF RID: 50431 RVA: 0x002FF588 File Offset: 0x002FD788
			// (set) Token: 0x0600C500 RID: 50432 RVA: 0x0005FDAC File Offset: 0x0005DFAC
			public unsafe static Func<bool> __9__65_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__65_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__65_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D7E RID: 15742
			// (get) Token: 0x0600C501 RID: 50433 RVA: 0x002FF5B0 File Offset: 0x002FD7B0
			// (set) Token: 0x0600C502 RID: 50434 RVA: 0x0005FDBE File Offset: 0x0005DFBE
			public unsafe static Func<bool> __9__65_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__65_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__65_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D7F RID: 15743
			// (get) Token: 0x0600C503 RID: 50435 RVA: 0x002FF5D8 File Offset: 0x002FD7D8
			// (set) Token: 0x0600C504 RID: 50436 RVA: 0x0005FDD0 File Offset: 0x0005DFD0
			public unsafe static Func<bool> __9__65_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__65_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__65_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008586 RID: 34182
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008587 RID: 34183
			private static readonly IntPtr NativeFieldInfoPtr___9__63_5;

			// Token: 0x04008588 RID: 34184
			private static readonly IntPtr NativeFieldInfoPtr___9__63_1;

			// Token: 0x04008589 RID: 34185
			private static readonly IntPtr NativeFieldInfoPtr___9__63_2;

			// Token: 0x0400858A RID: 34186
			private static readonly IntPtr NativeFieldInfoPtr___9__64_2;

			// Token: 0x0400858B RID: 34187
			private static readonly IntPtr NativeFieldInfoPtr___9__64_3;

			// Token: 0x0400858C RID: 34188
			private static readonly IntPtr NativeFieldInfoPtr___9__64_4;

			// Token: 0x0400858D RID: 34189
			private static readonly IntPtr NativeFieldInfoPtr___9__65_2;

			// Token: 0x0400858E RID: 34190
			private static readonly IntPtr NativeFieldInfoPtr___9__65_3;

			// Token: 0x0400858F RID: 34191
			private static readonly IntPtr NativeFieldInfoPtr___9__65_4;

			// Token: 0x04008590 RID: 34192
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008591 RID: 34193
			private static readonly IntPtr NativeMethodInfoPtr__StartGame_b__63_5_Internal_Boolean_0;

			// Token: 0x04008592 RID: 34194
			private static readonly IntPtr NativeMethodInfoPtr__StartGame_b__63_1_Internal_Boolean_0;

			// Token: 0x04008593 RID: 34195
			private static readonly IntPtr NativeMethodInfoPtr__StartGame_b__63_2_Internal_Boolean_0;

			// Token: 0x04008594 RID: 34196
			private static readonly IntPtr NativeMethodInfoPtr__LoadTutorialAsClient_b__64_2_Internal_Boolean_0;

			// Token: 0x04008595 RID: 34197
			private static readonly IntPtr NativeMethodInfoPtr__LoadTutorialAsClient_b__64_3_Internal_Boolean_0;

			// Token: 0x04008596 RID: 34198
			private static readonly IntPtr NativeMethodInfoPtr__LoadTutorialAsClient_b__64_4_Internal_Boolean_0;

			// Token: 0x04008597 RID: 34199
			private static readonly IntPtr NativeMethodInfoPtr__LoadAsClient_b__65_2_Internal_Boolean_0;

			// Token: 0x04008598 RID: 34200
			private static readonly IntPtr NativeMethodInfoPtr__LoadAsClient_b__65_3_Internal_Boolean_0;

			// Token: 0x04008599 RID: 34201
			private static readonly IntPtr NativeMethodInfoPtr__LoadAsClient_b__65_4_Internal_Boolean_0;
		}

		// Token: 0x020008EF RID: 2287
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass59_0")]
		public sealed class __c__DisplayClass59_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C505 RID: 50437 RVA: 0x002FF600 File Offset: 0x002FD800
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass59_0()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass59_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass59_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass59_0>.NativeClassPtr);
				LoadManager.__c__DisplayClass59_0.NativeFieldInfoPtr_itemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass59_0>.NativeClassPtr, "itemType");
				LoadManager.__c__DisplayClass59_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass59_0>.NativeClassPtr, 100668407);
				LoadManager.__c__DisplayClass59_0.NativeMethodInfoPtr__GetItemLoader_b__0_Internal_Boolean_ItemLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass59_0>.NativeClassPtr, 100668408);
			}

			// Token: 0x0600C506 RID: 50438 RVA: 0x002FF668 File Offset: 0x002FD868
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass59_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass59_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass59_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C507 RID: 50439 RVA: 0x002FF6A4 File Offset: 0x002FD8A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124667, XrefRangeEnd = 124669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetItemLoader_b__0(ItemLoader loader)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(loader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass59_0.NativeMethodInfoPtr__GetItemLoader_b__0_Internal_Boolean_ItemLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C508 RID: 50440 RVA: 0x0005FDE2 File Offset: 0x0005DFE2
			public __c__DisplayClass59_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D80 RID: 15744
			// (get) Token: 0x0600C509 RID: 50441 RVA: 0x002FF6F4 File Offset: 0x002FD8F4
			// (set) Token: 0x0600C50A RID: 50442 RVA: 0x0005FDEB File Offset: 0x0005DFEB
			public unsafe string itemType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass59_0.NativeFieldInfoPtr_itemType);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass59_0.NativeFieldInfoPtr_itemType), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400859A RID: 34202
			private static readonly IntPtr NativeFieldInfoPtr_itemType;

			// Token: 0x0400859B RID: 34203
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400859C RID: 34204
			private static readonly IntPtr NativeMethodInfoPtr__GetItemLoader_b__0_Internal_Boolean_ItemLoader_0;
		}

		// Token: 0x020008F0 RID: 2288
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass60_0")]
		public sealed class __c__DisplayClass60_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C50B RID: 50443 RVA: 0x002FF71C File Offset: 0x002FD91C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass60_0()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass60_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass60_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass60_0>.NativeClassPtr);
				LoadManager.__c__DisplayClass60_0.NativeFieldInfoPtr_objectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass60_0>.NativeClassPtr, "objectType");
				LoadManager.__c__DisplayClass60_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass60_0>.NativeClassPtr, 100668409);
				LoadManager.__c__DisplayClass60_0.NativeMethodInfoPtr__GetObjectLoader_b__0_Internal_Boolean_BuildableItemLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass60_0>.NativeClassPtr, 100668410);
			}

			// Token: 0x0600C50C RID: 50444 RVA: 0x002FF784 File Offset: 0x002FD984
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass60_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass60_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass60_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C50D RID: 50445 RVA: 0x002FF7C0 File Offset: 0x002FD9C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124669, XrefRangeEnd = 124671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetObjectLoader_b__0(BuildableItemLoader loader)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(loader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass60_0.NativeMethodInfoPtr__GetObjectLoader_b__0_Internal_Boolean_BuildableItemLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C50E RID: 50446 RVA: 0x0005FE0A File Offset: 0x0005E00A
			public __c__DisplayClass60_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D81 RID: 15745
			// (get) Token: 0x0600C50F RID: 50447 RVA: 0x002FF810 File Offset: 0x002FDA10
			// (set) Token: 0x0600C510 RID: 50448 RVA: 0x0005FE13 File Offset: 0x0005E013
			public unsafe string objectType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass60_0.NativeFieldInfoPtr_objectType);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass60_0.NativeFieldInfoPtr_objectType), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400859D RID: 34205
			private static readonly IntPtr NativeFieldInfoPtr_objectType;

			// Token: 0x0400859E RID: 34206
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400859F RID: 34207
			private static readonly IntPtr NativeMethodInfoPtr__GetObjectLoader_b__0_Internal_Boolean_BuildableItemLoader_0;
		}

		// Token: 0x020008F1 RID: 2289
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass61_0")]
		public sealed class __c__DisplayClass61_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C511 RID: 50449 RVA: 0x002FF838 File Offset: 0x002FDA38
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass61_0()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass61_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass61_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass61_0>.NativeClassPtr);
				LoadManager.__c__DisplayClass61_0.NativeFieldInfoPtr_npcType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass61_0>.NativeClassPtr, "npcType");
				LoadManager.__c__DisplayClass61_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass61_0>.NativeClassPtr, 100668411);
				LoadManager.__c__DisplayClass61_0.NativeMethodInfoPtr__GetNPCLoader_b__0_Internal_Boolean_NPCLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass61_0>.NativeClassPtr, 100668412);
			}

			// Token: 0x0600C512 RID: 50450 RVA: 0x002FF8A0 File Offset: 0x002FDAA0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass61_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass61_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass61_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C513 RID: 50451 RVA: 0x002FF8DC File Offset: 0x002FDADC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetNPCLoader_b__0(NPCLoader loader)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(loader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass61_0.NativeMethodInfoPtr__GetNPCLoader_b__0_Internal_Boolean_NPCLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C514 RID: 50452 RVA: 0x0005FE32 File Offset: 0x0005E032
			public __c__DisplayClass61_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D82 RID: 15746
			// (get) Token: 0x0600C515 RID: 50453 RVA: 0x002FF92C File Offset: 0x002FDB2C
			// (set) Token: 0x0600C516 RID: 50454 RVA: 0x0005FE3B File Offset: 0x0005E03B
			public unsafe string npcType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass61_0.NativeFieldInfoPtr_npcType);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass61_0.NativeFieldInfoPtr_npcType), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040085A0 RID: 34208
			private static readonly IntPtr NativeFieldInfoPtr_npcType;

			// Token: 0x040085A1 RID: 34209
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040085A2 RID: 34210
			private static readonly IntPtr NativeMethodInfoPtr__GetNPCLoader_b__0_Internal_Boolean_NPCLoader_0;
		}

		// Token: 0x020008F2 RID: 2290
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass63_0")]
		public sealed class __c__DisplayClass63_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C517 RID: 50455 RVA: 0x002FF954 File Offset: 0x002FDB54
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass63_0()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass63_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0>.NativeClassPtr);
				LoadManager.__c__DisplayClass63_0.NativeFieldInfoPtr_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0>.NativeClassPtr, "info");
				LoadManager.__c__DisplayClass63_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0>.NativeClassPtr, "<>4__this");
				LoadManager.__c__DisplayClass63_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0>.NativeClassPtr, 100668413);
				LoadManager.__c__DisplayClass63_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0>.NativeClassPtr, 100668414);
				LoadManager.__c__DisplayClass63_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0>.NativeClassPtr, 100668415);
			}

			// Token: 0x0600C518 RID: 50456 RVA: 0x002FF9E4 File Offset: 0x002FDBE4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass63_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C519 RID: 50457 RVA: 0x002FFA20 File Offset: 0x002FDC20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124971, XrefRangeEnd = 124976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C51A RID: 50458 RVA: 0x002FFA60 File Offset: 0x002FDC60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124976, XrefRangeEnd = 124981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C51B RID: 50459 RVA: 0x0005FE5A File Offset: 0x0005E05A
			public __c__DisplayClass63_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D83 RID: 15747
			// (get) Token: 0x0600C51C RID: 50460 RVA: 0x002FFAA0 File Offset: 0x002FDCA0
			// (set) Token: 0x0600C51D RID: 50461 RVA: 0x0005FE63 File Offset: 0x0005E063
			public unsafe SaveInfo info
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.NativeFieldInfoPtr_info);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.NativeFieldInfoPtr_info), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D84 RID: 15748
			// (get) Token: 0x0600C51E RID: 50462 RVA: 0x002FFAD0 File Offset: 0x002FDCD0
			// (set) Token: 0x0600C51F RID: 50463 RVA: 0x0005FE82 File Offset: 0x0005E082
			public unsafe LoadManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040085A3 RID: 34211
			private static readonly IntPtr NativeFieldInfoPtr_info;

			// Token: 0x040085A4 RID: 34212
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040085A5 RID: 34213
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040085A6 RID: 34214
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x040085A7 RID: 34215
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1;

			// Token: 0x02000C36 RID: 3126
			[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass63_0+<<StartGame>g__LoadRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E18D RID: 57741 RVA: 0x00350394 File Offset: 0x0034E594
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique()
				{
					Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0>.NativeClassPtr, "<<StartGame>g__LoadRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr);
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, "<>1__state");
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, "<>2__current");
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, "<>4__this");
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr__playingTutorial_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, "<playingTutorial>5__2");
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr__asyncLoad_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, "<asyncLoad>5__3");
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr__yak_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, "<yak>5__4");
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, 100668416);
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, 100668417);
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, 100668418);
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, 100668419);
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, 100668420);
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, 100668421);
				}

				// Token: 0x0600E18E RID: 57742 RVA: 0x003504B0 File Offset: 0x0034E6B0
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E18F RID: 57743 RVA: 0x003504F8 File Offset: 0x0034E6F8
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E190 RID: 57744 RVA: 0x0035052C File Offset: 0x0034E72C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124671, XrefRangeEnd = 124942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170045E8 RID: 17896
				// (get) Token: 0x0600E191 RID: 57745 RVA: 0x00350568 File Offset: 0x0034E768
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E192 RID: 57746 RVA: 0x003505A8 File Offset: 0x0034E7A8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124942, XrefRangeEnd = 124947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170045E9 RID: 17897
				// (get) Token: 0x0600E193 RID: 57747 RVA: 0x003505DC File Offset: 0x0034E7DC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E194 RID: 57748 RVA: 0x0006DF65 File Offset: 0x0006C165
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170045E2 RID: 17890
				// (get) Token: 0x0600E195 RID: 57749 RVA: 0x0035061C File Offset: 0x0034E81C
				// (set) Token: 0x0600E196 RID: 57750 RVA: 0x0006DF6E File Offset: 0x0006C16E
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170045E3 RID: 17891
				// (get) Token: 0x0600E197 RID: 57751 RVA: 0x00350644 File Offset: 0x0034E844
				// (set) Token: 0x0600E198 RID: 57752 RVA: 0x0006DF89 File Offset: 0x0006C189
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045E4 RID: 17892
				// (get) Token: 0x0600E199 RID: 57753 RVA: 0x00350674 File Offset: 0x0034E874
				// (set) Token: 0x0600E19A RID: 57754 RVA: 0x0006DFA8 File Offset: 0x0006C1A8
				public unsafe LoadManager.__c__DisplayClass63_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager.__c__DisplayClass63_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045E5 RID: 17893
				// (get) Token: 0x0600E19B RID: 57755 RVA: 0x003506A4 File Offset: 0x0034E8A4
				// (set) Token: 0x0600E19C RID: 57756 RVA: 0x0006DFC7 File Offset: 0x0006C1C7
				public unsafe bool _playingTutorial_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr__playingTutorial_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr__playingTutorial_5__2)) = value;
					}
				}

				// Token: 0x170045E6 RID: 17894
				// (get) Token: 0x0600E19D RID: 57757 RVA: 0x003506CC File Offset: 0x0034E8CC
				// (set) Token: 0x0600E19E RID: 57758 RVA: 0x0006DFE2 File Offset: 0x0006C1E2
				public unsafe AsyncOperation _asyncLoad_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr__asyncLoad_5__3);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr__asyncLoad_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045E7 RID: 17895
				// (get) Token: 0x0600E19F RID: 57759 RVA: 0x003506FC File Offset: 0x0034E8FC
				// (set) Token: 0x0600E1A0 RID: 57760 RVA: 0x0006E001 File Offset: 0x0006C201
				public unsafe Yak _yak_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr__yak_5__4);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Yak>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr__yak_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009704 RID: 38660
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009705 RID: 38661
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009706 RID: 38662
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009707 RID: 38663
				private static readonly IntPtr NativeFieldInfoPtr__playingTutorial_5__2;

				// Token: 0x04009708 RID: 38664
				private static readonly IntPtr NativeFieldInfoPtr__asyncLoad_5__3;

				// Token: 0x04009709 RID: 38665
				private static readonly IntPtr NativeFieldInfoPtr__yak_5__4;

				// Token: 0x0400970A RID: 38666
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400970B RID: 38667
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400970C RID: 38668
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400970D RID: 38669
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400970E RID: 38670
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400970F RID: 38671
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02000C37 RID: 3127
			[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass63_0+<<StartGame>g__Load|3>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E1A1 RID: 57761 RVA: 0x0035072C File Offset: 0x0034E92C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0>.NativeClassPtr, "<<StartGame>g__Load|3>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668422);
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668423);
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668424);
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668425);
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668426);
					LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668427);
				}

				// Token: 0x0600E1A2 RID: 57762 RVA: 0x0035080C File Offset: 0x0034EA0C
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E1A3 RID: 57763 RVA: 0x00350854 File Offset: 0x0034EA54
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E1A4 RID: 57764 RVA: 0x00350888 File Offset: 0x0034EA88
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124947, XrefRangeEnd = 124966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170045ED RID: 17901
				// (get) Token: 0x0600E1A5 RID: 57765 RVA: 0x003508C4 File Offset: 0x0034EAC4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E1A6 RID: 57766 RVA: 0x00350904 File Offset: 0x0034EB04
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124966, XrefRangeEnd = 124971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170045EE RID: 17902
				// (get) Token: 0x0600E1A7 RID: 57767 RVA: 0x00350938 File Offset: 0x0034EB38
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E1A8 RID: 57768 RVA: 0x0006E020 File Offset: 0x0006C220
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170045EA RID: 17898
				// (get) Token: 0x0600E1A9 RID: 57769 RVA: 0x00350978 File Offset: 0x0034EB78
				// (set) Token: 0x0600E1AA RID: 57770 RVA: 0x0006E029 File Offset: 0x0006C229
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170045EB RID: 17899
				// (get) Token: 0x0600E1AB RID: 57771 RVA: 0x003509A0 File Offset: 0x0034EBA0
				// (set) Token: 0x0600E1AC RID: 57772 RVA: 0x0006E044 File Offset: 0x0006C244
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045EC RID: 17900
				// (get) Token: 0x0600E1AD RID: 57773 RVA: 0x003509D0 File Offset: 0x0034EBD0
				// (set) Token: 0x0600E1AE RID: 57774 RVA: 0x0006E063 File Offset: 0x0006C263
				public unsafe LoadManager.__c__DisplayClass63_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager.__c__DisplayClass63_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009710 RID: 38672
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009711 RID: 38673
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009712 RID: 38674
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009713 RID: 38675
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009714 RID: 38676
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009715 RID: 38677
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009716 RID: 38678
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009717 RID: 38679
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009718 RID: 38680
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020008F3 RID: 2291
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass63_1")]
		public sealed class __c__DisplayClass63_1 : Il2CppSystem.Object
		{
			// Token: 0x0600C520 RID: 50464 RVA: 0x002FFB00 File Offset: 0x002FDD00
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass63_1()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass63_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_1>.NativeClassPtr);
				LoadManager.__c__DisplayClass63_1.NativeFieldInfoPtr_fishy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_1>.NativeClassPtr, "fishy");
				LoadManager.__c__DisplayClass63_1.NativeFieldInfoPtr_port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_1>.NativeClassPtr, "port");
				LoadManager.__c__DisplayClass63_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_1>.NativeClassPtr, 100668428);
				LoadManager.__c__DisplayClass63_1.NativeMethodInfoPtr_Method_Internal_Void_ServerConnectionStateArgs_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_1>.NativeClassPtr, 100668429);
			}

			// Token: 0x0600C521 RID: 50465 RVA: 0x002FFB7C File Offset: 0x002FDD7C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass63_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C522 RID: 50466 RVA: 0x002FFBB8 File Offset: 0x002FDDB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124981, XrefRangeEnd = 125021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_ServerConnectionStateArgs_PDM_0(ServerConnectionStateArgs args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref args;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_1.NativeMethodInfoPtr_Method_Internal_Void_ServerConnectionStateArgs_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C523 RID: 50467 RVA: 0x0005FEA1 File Offset: 0x0005E0A1
			public __c__DisplayClass63_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D85 RID: 15749
			// (get) Token: 0x0600C524 RID: 50468 RVA: 0x002FFBF8 File Offset: 0x002FDDF8
			// (set) Token: 0x0600C525 RID: 50469 RVA: 0x0005FEAA File Offset: 0x0005E0AA
			public unsafe FishySteamworks fishy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_1.NativeFieldInfoPtr_fishy);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FishySteamworks>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_1.NativeFieldInfoPtr_fishy), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D86 RID: 15750
			// (get) Token: 0x0600C526 RID: 50470 RVA: 0x002FFC28 File Offset: 0x002FDE28
			// (set) Token: 0x0600C527 RID: 50471 RVA: 0x0005FEC9 File Offset: 0x0005E0C9
			public unsafe ushort port
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_1.NativeFieldInfoPtr_port);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_1.NativeFieldInfoPtr_port)) = value;
				}
			}

			// Token: 0x040085A8 RID: 34216
			private static readonly IntPtr NativeFieldInfoPtr_fishy;

			// Token: 0x040085A9 RID: 34217
			private static readonly IntPtr NativeFieldInfoPtr_port;

			// Token: 0x040085AA RID: 34218
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040085AB RID: 34219
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_ServerConnectionStateArgs_PDM_0;
		}

		// Token: 0x020008F4 RID: 2292
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass64_0")]
		public sealed class __c__DisplayClass64_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C528 RID: 50472 RVA: 0x002FFC50 File Offset: 0x002FDE50
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass64_0()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass64_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0>.NativeClassPtr);
				LoadManager.__c__DisplayClass64_0.NativeFieldInfoPtr_waitForExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0>.NativeClassPtr, "waitForExit");
				LoadManager.__c__DisplayClass64_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0>.NativeClassPtr, "<>4__this");
				LoadManager.__c__DisplayClass64_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0>.NativeClassPtr, 100668430);
				LoadManager.__c__DisplayClass64_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0>.NativeClassPtr, 100668431);
				LoadManager.__c__DisplayClass64_0.NativeMethodInfoPtr__LoadTutorialAsClient_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0>.NativeClassPtr, 100668432);
				LoadManager.__c__DisplayClass64_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0>.NativeClassPtr, 100668433);
			}

			// Token: 0x0600C529 RID: 50473 RVA: 0x002FFCF4 File Offset: 0x002FDEF4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass64_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass64_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C52A RID: 50474 RVA: 0x002FFD30 File Offset: 0x002FDF30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125238, XrefRangeEnd = 125243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass64_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C52B RID: 50475 RVA: 0x002FFD70 File Offset: 0x002FDF70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125243, XrefRangeEnd = 125245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadTutorialAsClient_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass64_0.NativeMethodInfoPtr__LoadTutorialAsClient_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C52C RID: 50476 RVA: 0x002FFDAC File Offset: 0x002FDFAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125245, XrefRangeEnd = 125250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass64_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C52D RID: 50477 RVA: 0x0005FEE4 File Offset: 0x0005E0E4
			public __c__DisplayClass64_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D87 RID: 15751
			// (get) Token: 0x0600C52E RID: 50478 RVA: 0x002FFDEC File Offset: 0x002FDFEC
			// (set) Token: 0x0600C52F RID: 50479 RVA: 0x0005FEED File Offset: 0x0005E0ED
			public unsafe bool waitForExit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.NativeFieldInfoPtr_waitForExit);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.NativeFieldInfoPtr_waitForExit)) = value;
				}
			}

			// Token: 0x17003D88 RID: 15752
			// (get) Token: 0x0600C530 RID: 50480 RVA: 0x002FFE14 File Offset: 0x002FE014
			// (set) Token: 0x0600C531 RID: 50481 RVA: 0x0005FF08 File Offset: 0x0005E108
			public unsafe LoadManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040085AC RID: 34220
			private static readonly IntPtr NativeFieldInfoPtr_waitForExit;

			// Token: 0x040085AD RID: 34221
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040085AE RID: 34222
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040085AF RID: 34223
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x040085B0 RID: 34224
			private static readonly IntPtr NativeMethodInfoPtr__LoadTutorialAsClient_b__1_Internal_Boolean_0;

			// Token: 0x040085B1 RID: 34225
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1;

			// Token: 0x02000C38 RID: 3128
			[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass64_0+<<LoadTutorialAsClient>g__LoadRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E1AF RID: 57775 RVA: 0x00350A00 File Offset: 0x0034EC00
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique()
				{
					Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0>.NativeClassPtr, "<<LoadTutorialAsClient>g__LoadRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr);
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, "<>1__state");
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, "<>2__current");
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, "<>4__this");
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr__asyncLoad_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, "<asyncLoad>5__2");
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr__yak_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, "<yak>5__3");
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, 100668434);
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, 100668435);
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, 100668436);
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, 100668437);
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, 100668438);
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, 100668439);
				}

				// Token: 0x0600E1B0 RID: 57776 RVA: 0x00350B08 File Offset: 0x0034ED08
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E1B1 RID: 57777 RVA: 0x00350B50 File Offset: 0x0034ED50
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E1B2 RID: 57778 RVA: 0x00350B84 File Offset: 0x0034ED84
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125021, XrefRangeEnd = 125209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170045F4 RID: 17908
				// (get) Token: 0x0600E1B3 RID: 57779 RVA: 0x00350BC0 File Offset: 0x0034EDC0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E1B4 RID: 57780 RVA: 0x00350C00 File Offset: 0x0034EE00
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125209, XrefRangeEnd = 125214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170045F5 RID: 17909
				// (get) Token: 0x0600E1B5 RID: 57781 RVA: 0x00350C34 File Offset: 0x0034EE34
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E1B6 RID: 57782 RVA: 0x0006E082 File Offset: 0x0006C282
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170045EF RID: 17903
				// (get) Token: 0x0600E1B7 RID: 57783 RVA: 0x00350C74 File Offset: 0x0034EE74
				// (set) Token: 0x0600E1B8 RID: 57784 RVA: 0x0006E08B File Offset: 0x0006C28B
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170045F0 RID: 17904
				// (get) Token: 0x0600E1B9 RID: 57785 RVA: 0x00350C9C File Offset: 0x0034EE9C
				// (set) Token: 0x0600E1BA RID: 57786 RVA: 0x0006E0A6 File Offset: 0x0006C2A6
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045F1 RID: 17905
				// (get) Token: 0x0600E1BB RID: 57787 RVA: 0x00350CCC File Offset: 0x0034EECC
				// (set) Token: 0x0600E1BC RID: 57788 RVA: 0x0006E0C5 File Offset: 0x0006C2C5
				public unsafe LoadManager.__c__DisplayClass64_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager.__c__DisplayClass64_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045F2 RID: 17906
				// (get) Token: 0x0600E1BD RID: 57789 RVA: 0x00350CFC File Offset: 0x0034EEFC
				// (set) Token: 0x0600E1BE RID: 57790 RVA: 0x0006E0E4 File Offset: 0x0006C2E4
				public unsafe AsyncOperation _asyncLoad_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr__asyncLoad_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr__asyncLoad_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045F3 RID: 17907
				// (get) Token: 0x0600E1BF RID: 57791 RVA: 0x00350D2C File Offset: 0x0034EF2C
				// (set) Token: 0x0600E1C0 RID: 57792 RVA: 0x0006E103 File Offset: 0x0006C303
				public unsafe Yak _yak_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr__yak_5__3);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Yak>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr__yak_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009719 RID: 38681
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400971A RID: 38682
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400971B RID: 38683
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400971C RID: 38684
				private static readonly IntPtr NativeFieldInfoPtr__asyncLoad_5__2;

				// Token: 0x0400971D RID: 38685
				private static readonly IntPtr NativeFieldInfoPtr__yak_5__3;

				// Token: 0x0400971E RID: 38686
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400971F RID: 38687
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009720 RID: 38688
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009721 RID: 38689
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009722 RID: 38690
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009723 RID: 38691
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02000C39 RID: 3129
			[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass64_0+<<LoadTutorialAsClient>g__Load|5>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E1C1 RID: 57793 RVA: 0x00350D5C File Offset: 0x0034EF5C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0>.NativeClassPtr, "<<LoadTutorialAsClient>g__Load|5>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668440);
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668441);
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668442);
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668443);
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668444);
					LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668445);
				}

				// Token: 0x0600E1C2 RID: 57794 RVA: 0x00350E3C File Offset: 0x0034F03C
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E1C3 RID: 57795 RVA: 0x00350E84 File Offset: 0x0034F084
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E1C4 RID: 57796 RVA: 0x00350EB8 File Offset: 0x0034F0B8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125214, XrefRangeEnd = 125233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170045F9 RID: 17913
				// (get) Token: 0x0600E1C5 RID: 57797 RVA: 0x00350EF4 File Offset: 0x0034F0F4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E1C6 RID: 57798 RVA: 0x00350F34 File Offset: 0x0034F134
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125233, XrefRangeEnd = 125238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170045FA RID: 17914
				// (get) Token: 0x0600E1C7 RID: 57799 RVA: 0x00350F68 File Offset: 0x0034F168
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E1C8 RID: 57800 RVA: 0x0006E122 File Offset: 0x0006C322
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170045F6 RID: 17910
				// (get) Token: 0x0600E1C9 RID: 57801 RVA: 0x00350FA8 File Offset: 0x0034F1A8
				// (set) Token: 0x0600E1CA RID: 57802 RVA: 0x0006E12B File Offset: 0x0006C32B
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170045F7 RID: 17911
				// (get) Token: 0x0600E1CB RID: 57803 RVA: 0x00350FD0 File Offset: 0x0034F1D0
				// (set) Token: 0x0600E1CC RID: 57804 RVA: 0x0006E146 File Offset: 0x0006C346
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045F8 RID: 17912
				// (get) Token: 0x0600E1CD RID: 57805 RVA: 0x00351000 File Offset: 0x0034F200
				// (set) Token: 0x0600E1CE RID: 57806 RVA: 0x0006E165 File Offset: 0x0006C365
				public unsafe LoadManager.__c__DisplayClass64_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager.__c__DisplayClass64_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass64_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009724 RID: 38692
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009725 RID: 38693
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009726 RID: 38694
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009727 RID: 38695
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009728 RID: 38696
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009729 RID: 38697
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400972A RID: 38698
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400972B RID: 38699
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400972C RID: 38700
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020008F5 RID: 2293
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass65_0")]
		public sealed class __c__DisplayClass65_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C532 RID: 50482 RVA: 0x002FFE44 File Offset: 0x002FE044
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass65_0()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass65_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0>.NativeClassPtr);
				LoadManager.__c__DisplayClass65_0.NativeFieldInfoPtr_waitForExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0>.NativeClassPtr, "waitForExit");
				LoadManager.__c__DisplayClass65_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0>.NativeClassPtr, "<>4__this");
				LoadManager.__c__DisplayClass65_0.NativeFieldInfoPtr_steamId64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0>.NativeClassPtr, "steamId64");
				LoadManager.__c__DisplayClass65_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0>.NativeClassPtr, 100668446);
				LoadManager.__c__DisplayClass65_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0>.NativeClassPtr, 100668447);
				LoadManager.__c__DisplayClass65_0.NativeMethodInfoPtr__LoadAsClient_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0>.NativeClassPtr, 100668448);
			}

			// Token: 0x0600C533 RID: 50483 RVA: 0x002FFEE8 File Offset: 0x002FE0E8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass65_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass65_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C534 RID: 50484 RVA: 0x002FFF24 File Offset: 0x002FE124
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125420, XrefRangeEnd = 125425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass65_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C535 RID: 50485 RVA: 0x002FFF64 File Offset: 0x002FE164
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125425, XrefRangeEnd = 125427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadAsClient_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass65_0.NativeMethodInfoPtr__LoadAsClient_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C536 RID: 50486 RVA: 0x0005FF27 File Offset: 0x0005E127
			public __c__DisplayClass65_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D89 RID: 15753
			// (get) Token: 0x0600C537 RID: 50487 RVA: 0x002FFFA0 File Offset: 0x002FE1A0
			// (set) Token: 0x0600C538 RID: 50488 RVA: 0x0005FF30 File Offset: 0x0005E130
			public unsafe bool waitForExit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.NativeFieldInfoPtr_waitForExit);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.NativeFieldInfoPtr_waitForExit)) = value;
				}
			}

			// Token: 0x17003D8A RID: 15754
			// (get) Token: 0x0600C539 RID: 50489 RVA: 0x002FFFC8 File Offset: 0x002FE1C8
			// (set) Token: 0x0600C53A RID: 50490 RVA: 0x0005FF4B File Offset: 0x0005E14B
			public unsafe LoadManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D8B RID: 15755
			// (get) Token: 0x0600C53B RID: 50491 RVA: 0x002FFFF8 File Offset: 0x002FE1F8
			// (set) Token: 0x0600C53C RID: 50492 RVA: 0x0005FF6A File Offset: 0x0005E16A
			public unsafe string steamId64
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.NativeFieldInfoPtr_steamId64);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.NativeFieldInfoPtr_steamId64), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040085B2 RID: 34226
			private static readonly IntPtr NativeFieldInfoPtr_waitForExit;

			// Token: 0x040085B3 RID: 34227
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040085B4 RID: 34228
			private static readonly IntPtr NativeFieldInfoPtr_steamId64;

			// Token: 0x040085B5 RID: 34229
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040085B6 RID: 34230
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x040085B7 RID: 34231
			private static readonly IntPtr NativeMethodInfoPtr__LoadAsClient_b__1_Internal_Boolean_0;

			// Token: 0x02000C3A RID: 3130
			[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass65_0+<<LoadAsClient>g__LoadRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E1CF RID: 57807 RVA: 0x00351030 File Offset: 0x0034F230
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0>.NativeClassPtr, "<<LoadAsClient>g__LoadRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668449);
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668450);
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668451);
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668452);
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668453);
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668454);
				}

				// Token: 0x0600E1D0 RID: 57808 RVA: 0x00351110 File Offset: 0x0034F310
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E1D1 RID: 57809 RVA: 0x00351158 File Offset: 0x0034F358
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E1D2 RID: 57810 RVA: 0x0035118C File Offset: 0x0034F38C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125250, XrefRangeEnd = 125415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170045FE RID: 17918
				// (get) Token: 0x0600E1D3 RID: 57811 RVA: 0x003511C8 File Offset: 0x0034F3C8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E1D4 RID: 57812 RVA: 0x00351208 File Offset: 0x0034F408
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125415, XrefRangeEnd = 125420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170045FF RID: 17919
				// (get) Token: 0x0600E1D5 RID: 57813 RVA: 0x0035123C File Offset: 0x0034F43C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E1D6 RID: 57814 RVA: 0x0006E184 File Offset: 0x0006C384
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170045FB RID: 17915
				// (get) Token: 0x0600E1D7 RID: 57815 RVA: 0x0035127C File Offset: 0x0034F47C
				// (set) Token: 0x0600E1D8 RID: 57816 RVA: 0x0006E18D File Offset: 0x0006C38D
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170045FC RID: 17916
				// (get) Token: 0x0600E1D9 RID: 57817 RVA: 0x003512A4 File Offset: 0x0034F4A4
				// (set) Token: 0x0600E1DA RID: 57818 RVA: 0x0006E1A8 File Offset: 0x0006C3A8
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045FD RID: 17917
				// (get) Token: 0x0600E1DB RID: 57819 RVA: 0x003512D4 File Offset: 0x0034F4D4
				// (set) Token: 0x0600E1DC RID: 57820 RVA: 0x0006E1C7 File Offset: 0x0006C3C7
				public unsafe LoadManager.__c__DisplayClass65_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager.__c__DisplayClass65_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400972D RID: 38701
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400972E RID: 38702
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400972F RID: 38703
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009730 RID: 38704
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009731 RID: 38705
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009732 RID: 38706
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009733 RID: 38707
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009734 RID: 38708
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009735 RID: 38709
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020008F6 RID: 2294
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass70_0")]
		public sealed class __c__DisplayClass70_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C53D RID: 50493 RVA: 0x00300020 File Offset: 0x002FE220
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass70_0()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass70_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0>.NativeClassPtr);
				LoadManager.__c__DisplayClass70_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0>.NativeClassPtr, "<>4__this");
				LoadManager.__c__DisplayClass70_0.NativeFieldInfoPtr_autoLoadSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0>.NativeClassPtr, "autoLoadSave");
				LoadManager.__c__DisplayClass70_0.NativeFieldInfoPtr_mainMenuPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0>.NativeClassPtr, "mainMenuPopup");
				LoadManager.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0>.NativeClassPtr, 100668455);
				LoadManager.__c__DisplayClass70_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0>.NativeClassPtr, 100668456);
			}

			// Token: 0x0600C53E RID: 50494 RVA: 0x003000B0 File Offset: 0x002FE2B0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass70_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C53F RID: 50495 RVA: 0x003000EC File Offset: 0x002FE2EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125468, XrefRangeEnd = 125473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass70_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C540 RID: 50496 RVA: 0x0005FF89 File Offset: 0x0005E189
			public __c__DisplayClass70_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D8C RID: 15756
			// (get) Token: 0x0600C541 RID: 50497 RVA: 0x0030012C File Offset: 0x002FE32C
			// (set) Token: 0x0600C542 RID: 50498 RVA: 0x0005FF92 File Offset: 0x0005E192
			public unsafe LoadManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D8D RID: 15757
			// (get) Token: 0x0600C543 RID: 50499 RVA: 0x0030015C File Offset: 0x002FE35C
			// (set) Token: 0x0600C544 RID: 50500 RVA: 0x0005FFB1 File Offset: 0x0005E1B1
			public unsafe SaveInfo autoLoadSave
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_0.NativeFieldInfoPtr_autoLoadSave);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_0.NativeFieldInfoPtr_autoLoadSave), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D8E RID: 15758
			// (get) Token: 0x0600C545 RID: 50501 RVA: 0x0030018C File Offset: 0x002FE38C
			// (set) Token: 0x0600C546 RID: 50502 RVA: 0x0005FFD0 File Offset: 0x0005E1D0
			public unsafe MainMenuPopup.Data mainMenuPopup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_0.NativeFieldInfoPtr_mainMenuPopup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainMenuPopup.Data>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_0.NativeFieldInfoPtr_mainMenuPopup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040085B8 RID: 34232
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040085B9 RID: 34233
			private static readonly IntPtr NativeFieldInfoPtr_autoLoadSave;

			// Token: 0x040085BA RID: 34234
			private static readonly IntPtr NativeFieldInfoPtr_mainMenuPopup;

			// Token: 0x040085BB RID: 34235
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040085BC RID: 34236
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C3B RID: 3131
			[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass70_0+<<ExitToMenu>g__Load|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E1DD RID: 57821 RVA: 0x00351304 File Offset: 0x0034F504
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique()
				{
					Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0>.NativeClassPtr, "<<ExitToMenu>g__Load|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr);
					LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, "<>1__state");
					LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, "<>2__current");
					LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, "<>4__this");
					LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr__asyncLoad_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, "<asyncLoad>5__2");
					LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, 100668457);
					LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, 100668458);
					LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, 100668459);
					LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, 100668460);
					LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, 100668461);
					LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, 100668462);
				}

				// Token: 0x0600E1DE RID: 57822 RVA: 0x003513F8 File Offset: 0x0034F5F8
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E1DF RID: 57823 RVA: 0x00351440 File Offset: 0x0034F640
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E1E0 RID: 57824 RVA: 0x00351474 File Offset: 0x0034F674
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125427, XrefRangeEnd = 125463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004604 RID: 17924
				// (get) Token: 0x0600E1E1 RID: 57825 RVA: 0x003514B0 File Offset: 0x0034F6B0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E1E2 RID: 57826 RVA: 0x003514F0 File Offset: 0x0034F6F0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125463, XrefRangeEnd = 125468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004605 RID: 17925
				// (get) Token: 0x0600E1E3 RID: 57827 RVA: 0x00351524 File Offset: 0x0034F724
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E1E4 RID: 57828 RVA: 0x0006E1E6 File Offset: 0x0006C3E6
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004600 RID: 17920
				// (get) Token: 0x0600E1E5 RID: 57829 RVA: 0x00351564 File Offset: 0x0034F764
				// (set) Token: 0x0600E1E6 RID: 57830 RVA: 0x0006E1EF File Offset: 0x0006C3EF
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004601 RID: 17921
				// (get) Token: 0x0600E1E7 RID: 57831 RVA: 0x0035158C File Offset: 0x0034F78C
				// (set) Token: 0x0600E1E8 RID: 57832 RVA: 0x0006E20A File Offset: 0x0006C40A
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004602 RID: 17922
				// (get) Token: 0x0600E1E9 RID: 57833 RVA: 0x003515BC File Offset: 0x0034F7BC
				// (set) Token: 0x0600E1EA RID: 57834 RVA: 0x0006E229 File Offset: 0x0006C429
				public unsafe LoadManager.__c__DisplayClass70_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager.__c__DisplayClass70_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004603 RID: 17923
				// (get) Token: 0x0600E1EB RID: 57835 RVA: 0x003515EC File Offset: 0x0034F7EC
				// (set) Token: 0x0600E1EC RID: 57836 RVA: 0x0006E248 File Offset: 0x0006C448
				public unsafe AsyncOperation _asyncLoad_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr__asyncLoad_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr__asyncLoad_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009736 RID: 38710
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009737 RID: 38711
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009738 RID: 38712
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009739 RID: 38713
				private static readonly IntPtr NativeFieldInfoPtr__asyncLoad_5__2;

				// Token: 0x0400973A RID: 38714
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400973B RID: 38715
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400973C RID: 38716
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400973D RID: 38717
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400973E RID: 38718
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400973F RID: 38719
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020008F7 RID: 2295
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass70_1")]
		public sealed class __c__DisplayClass70_1 : Il2CppSystem.Object
		{
			// Token: 0x0600C547 RID: 50503 RVA: 0x003001BC File Offset: 0x002FE3BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass70_1()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass70_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_1>.NativeClassPtr);
				LoadManager.__c__DisplayClass70_1.NativeFieldInfoPtr_timeOnWaitStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_1>.NativeClassPtr, "timeOnWaitStart");
				LoadManager.__c__DisplayClass70_1.NativeFieldInfoPtr_maxWait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_1>.NativeClassPtr, "maxWait");
				LoadManager.__c__DisplayClass70_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_1>.NativeClassPtr, 100668463);
				LoadManager.__c__DisplayClass70_1.NativeMethodInfoPtr__ExitToMenu_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_1>.NativeClassPtr, 100668464);
			}

			// Token: 0x0600C548 RID: 50504 RVA: 0x00300238 File Offset: 0x002FE438
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass70_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass70_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass70_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C549 RID: 50505 RVA: 0x00300274 File Offset: 0x002FE474
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125473, XrefRangeEnd = 125477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ExitToMenu_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass70_1.NativeMethodInfoPtr__ExitToMenu_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C54A RID: 50506 RVA: 0x0005FFEF File Offset: 0x0005E1EF
			public __c__DisplayClass70_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D8F RID: 15759
			// (get) Token: 0x0600C54B RID: 50507 RVA: 0x003002B0 File Offset: 0x002FE4B0
			// (set) Token: 0x0600C54C RID: 50508 RVA: 0x0005FFF8 File Offset: 0x0005E1F8
			public unsafe float timeOnWaitStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_1.NativeFieldInfoPtr_timeOnWaitStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_1.NativeFieldInfoPtr_timeOnWaitStart)) = value;
				}
			}

			// Token: 0x17003D90 RID: 15760
			// (get) Token: 0x0600C54D RID: 50509 RVA: 0x003002D8 File Offset: 0x002FE4D8
			// (set) Token: 0x0600C54E RID: 50510 RVA: 0x00060013 File Offset: 0x0005E213
			public unsafe float maxWait
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_1.NativeFieldInfoPtr_maxWait);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass70_1.NativeFieldInfoPtr_maxWait)) = value;
				}
			}

			// Token: 0x040085BD RID: 34237
			private static readonly IntPtr NativeFieldInfoPtr_timeOnWaitStart;

			// Token: 0x040085BE RID: 34238
			private static readonly IntPtr NativeFieldInfoPtr_maxWait;

			// Token: 0x040085BF RID: 34239
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040085C0 RID: 34240
			private static readonly IntPtr NativeMethodInfoPtr__ExitToMenu_b__1_Internal_Boolean_0;
		}
	}
}
