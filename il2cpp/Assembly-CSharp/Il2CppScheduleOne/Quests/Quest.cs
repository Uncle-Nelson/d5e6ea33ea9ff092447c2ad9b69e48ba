using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.UI;
using Il2CppScheduleOne.UI.Compass;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001AF RID: 431
	[Serializable]
	public class Quest : MonoBehaviour
	{
		// Token: 0x060024A2 RID: 9378 RVA: 0x000E2468 File Offset: 0x000E0668
		// Note: this type is marked as 'beforefieldinit'.
		static Quest()
		{
			Il2CppClassPointerStore<Quest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest>.NativeClassPtr);
			Quest.NativeFieldInfoPtr_MAX_HUD_ENTRY_LABELS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "MAX_HUD_ENTRY_LABELS");
			Quest.NativeFieldInfoPtr_CriticalExpiryThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "CriticalExpiryThreshold");
			Quest.NativeFieldInfoPtr_Quests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "Quests");
			Quest.NativeFieldInfoPtr_HoveredQuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "HoveredQuest");
			Quest.NativeFieldInfoPtr_ActiveQuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "ActiveQuests");
			Quest.NativeFieldInfoPtr__QuestState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<QuestState>k__BackingField");
			Quest.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<GUID>k__BackingField");
			Quest.NativeFieldInfoPtr__IsTracked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<IsTracked>k__BackingField");
			Quest.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "title");
			Quest.NativeFieldInfoPtr_Subtitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "Subtitle");
			Quest.NativeFieldInfoPtr_onSubtitleChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "onSubtitleChanged");
			Quest.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "Description");
			Quest.NativeFieldInfoPtr_StaticGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "StaticGUID");
			Quest.NativeFieldInfoPtr_TrackOnBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "TrackOnBegin");
			Quest.NativeFieldInfoPtr_ExpiryVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "ExpiryVisibility");
			Quest.NativeFieldInfoPtr_AutoCompleteOnAllEntriesComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "AutoCompleteOnAllEntriesComplete");
			Quest.NativeFieldInfoPtr_PlayQuestCompleteSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "PlayQuestCompleteSound");
			Quest.NativeFieldInfoPtr_CompletionXP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "CompletionXP");
			Quest.NativeFieldInfoPtr__Expires_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<Expires>k__BackingField");
			Quest.NativeFieldInfoPtr__Expiry_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<Expiry>k__BackingField");
			Quest.NativeFieldInfoPtr_AutoStartFirstEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "AutoStartFirstEntry");
			Quest.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "Entries");
			Quest.NativeFieldInfoPtr_IconPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "IconPrefab");
			Quest.NativeFieldInfoPtr_PoIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "PoIPrefab");
			Quest.NativeFieldInfoPtr_onQuestBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "onQuestBegin");
			Quest.NativeFieldInfoPtr_onQuestEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "onQuestEnd");
			Quest.NativeFieldInfoPtr_onActiveState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "onActiveState");
			Quest.NativeFieldInfoPtr_onTrackChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "onTrackChange");
			Quest.NativeFieldInfoPtr_onComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "onComplete");
			Quest.NativeFieldInfoPtr_onInitialComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "onInitialComplete");
			Quest.NativeFieldInfoPtr_ShouldSendExpiryReminder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "ShouldSendExpiryReminder");
			Quest.NativeFieldInfoPtr_ShouldSendExpiredNotification = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "ShouldSendExpiredNotification");
			Quest.NativeFieldInfoPtr_journalEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "journalEntry");
			Quest.NativeFieldInfoPtr_entryTitleRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "entryTitleRect");
			Quest.NativeFieldInfoPtr_trackedRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "trackedRect");
			Quest.NativeFieldInfoPtr_entryTimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "entryTimeLabel");
			Quest.NativeFieldInfoPtr_criticalTimeBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "criticalTimeBackground");
			Quest.NativeFieldInfoPtr_detailPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "detailPanel");
			Quest.NativeFieldInfoPtr__hudUI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<hudUI>k__BackingField");
			Quest.NativeFieldInfoPtr_onHudUICreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "onHudUICreated");
			Quest.NativeFieldInfoPtr_expiryReminderSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "expiryReminderSent");
			Quest.NativeFieldInfoPtr_compassElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "compassElement");
			Quest.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			Quest.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			Quest.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<HasChanged>k__BackingField");
			Quest.NativeFieldInfoPtr_autoInitialize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "autoInitialize");
			Quest.NativeMethodInfoPtr_get_QuestState_Public_get_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667350);
			Quest.NativeMethodInfoPtr_set_QuestState_Protected_set_Void_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667351);
			Quest.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667352);
			Quest.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667353);
			Quest.NativeMethodInfoPtr_get_IsTracked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667354);
			Quest.NativeMethodInfoPtr_set_IsTracked_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667355);
			Quest.NativeMethodInfoPtr_get_ActiveEntryCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667356);
			Quest.NativeMethodInfoPtr_get_Title_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667357);
			Quest.NativeMethodInfoPtr_get_Expires_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667358);
			Quest.NativeMethodInfoPtr_set_Expires_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667359);
			Quest.NativeMethodInfoPtr_get_Expiry_Public_get_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667360);
			Quest.NativeMethodInfoPtr_set_Expiry_Protected_set_Void_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667361);
			Quest.NativeMethodInfoPtr_get_hudUIExists_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667362);
			Quest.NativeMethodInfoPtr_get_hudUI_Public_get_QuestHUDUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667363);
			Quest.NativeMethodInfoPtr_set_hudUI_Private_set_Void_QuestHUDUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667364);
			Quest.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667365);
			Quest.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667366);
			Quest.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667367);
			Quest.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667368);
			Quest.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667369);
			Quest.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667370);
			Quest.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667371);
			Quest.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667372);
			Quest.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667373);
			Quest.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667374);
			Quest.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667375);
			Quest.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667376);
			Quest.NativeMethodInfoPtr_InitializeQuest_Public_Virtual_New_Void_String_String_Il2CppReferenceArray_1_QuestEntryData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667377);
			Quest.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667378);
			Quest.NativeMethodInfoPtr_ConfigureExpiry_Public_Void_Boolean_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667379);
			Quest.NativeMethodInfoPtr_Begin_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667380);
			Quest.NativeMethodInfoPtr_Complete_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667381);
			Quest.NativeMethodInfoPtr_Fail_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667382);
			Quest.NativeMethodInfoPtr_Expire_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667383);
			Quest.NativeMethodInfoPtr_Cancel_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667384);
			Quest.NativeMethodInfoPtr_End_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667385);
			Quest.NativeMethodInfoPtr_SetQuestState_Public_Virtual_New_Void_EQuestState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667386);
			Quest.NativeMethodInfoPtr_ShouldShowJournalEntry_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667387);
			Quest.NativeMethodInfoPtr_SetQuestEntryState_Public_Virtual_New_Void_Int32_EQuestState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667388);
			Quest.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667389);
			Quest.NativeMethodInfoPtr_CheckExpiry_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667390);
			Quest.NativeMethodInfoPtr_CheckAutoComplete_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667391);
			Quest.NativeMethodInfoPtr_CanExpire_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667392);
			Quest.NativeMethodInfoPtr_SendExpiryReminder_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667393);
			Quest.NativeMethodInfoPtr_SendExpiredNotification_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667394);
			Quest.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667395);
			Quest.NativeMethodInfoPtr_SetSubtitle_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667396);
			Quest.NativeMethodInfoPtr_SetIsTracked_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667397);
			Quest.NativeMethodInfoPtr_SetupJournalEntry_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667398);
			Quest.NativeMethodInfoPtr_DestroyJournalEntry_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667399);
			Quest.NativeMethodInfoPtr_JournalEntryClicked_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667400);
			Quest.NativeMethodInfoPtr_JournalEntryHoverStart_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667401);
			Quest.NativeMethodInfoPtr_GetMinsUntilExpiry_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667402);
			Quest.NativeMethodInfoPtr_GetExpiryText_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667403);
			Quest.NativeMethodInfoPtr_SetupHudUI_Public_Virtual_New_QuestHUDUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667404);
			Quest.NativeMethodInfoPtr_UpdateHUDUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667405);
			Quest.NativeMethodInfoPtr_BopHUDUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667406);
			Quest.NativeMethodInfoPtr_GetQuestTitle_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667407);
			Quest.NativeMethodInfoPtr_GetFirstActiveEntry_Public_QuestEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667408);
			Quest.NativeMethodInfoPtr_DestroyHudUI_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667409);
			Quest.NativeMethodInfoPtr_CreateDetailDisplay_Public_Virtual_New_RectTransform_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667410);
			Quest.NativeMethodInfoPtr_DestroyDetailDisplay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667411);
			Quest.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667412);
			Quest.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667413);
			Quest.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_QuestData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667414);
			Quest.NativeMethodInfoPtr_GetQuest_Public_Static_Quest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667415);
			Quest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667416);
			Quest.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667418);
			Quest.NativeMethodInfoPtr__SetupJournalEntry_b__110_0_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667419);
			Quest.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667420);
		}

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x060024A3 RID: 9379 RVA: 0x000E2DA8 File Offset: 0x000E0FA8
		// (set) Token: 0x060024A4 RID: 9380 RVA: 0x000E2DE4 File Offset: 0x000E0FE4
		public unsafe EQuestState QuestState
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20564, RefRangeEnd = 20565, XrefRangeStart = 20564, XrefRangeEnd = 20565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_QuestState_Public_get_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29976, RefRangeEnd = 29977, XrefRangeStart = 29976, XrefRangeEnd = 29977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_QuestState_Protected_set_Void_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x060024A5 RID: 9381 RVA: 0x000E2E24 File Offset: 0x000E1024
		// (set) Token: 0x060024A6 RID: 9382 RVA: 0x000E2E60 File Offset: 0x000E1060
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x060024A7 RID: 9383 RVA: 0x000E2EA0 File Offset: 0x000E10A0
		// (set) Token: 0x060024A8 RID: 9384 RVA: 0x000E2EDC File Offset: 0x000E10DC
		public unsafe bool IsTracked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_IsTracked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_IsTracked_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x060024A9 RID: 9385 RVA: 0x000E2F1C File Offset: 0x000E111C
		public unsafe int ActiveEntryCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 113771, RefRangeEnd = 113772, XrefRangeStart = 113753, XrefRangeEnd = 113771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_ActiveEntryCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x060024AA RID: 9386 RVA: 0x000E2F58 File Offset: 0x000E1158
		public unsafe string Title
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 113772, RefRangeEnd = 113773, XrefRangeStart = 113772, XrefRangeEnd = 113772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_Title_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x060024AB RID: 9387 RVA: 0x000E2F90 File Offset: 0x000E1190
		// (set) Token: 0x060024AC RID: 9388 RVA: 0x000E2FCC File Offset: 0x000E11CC
		public unsafe bool Expires
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_Expires_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_Expires_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x060024AD RID: 9389 RVA: 0x000E300C File Offset: 0x000E120C
		// (set) Token: 0x060024AE RID: 9390 RVA: 0x000E3048 File Offset: 0x000E1248
		public unsafe GameDateTime Expiry
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_Expiry_Public_get_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_Expiry_Protected_set_Void_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x060024AF RID: 9391 RVA: 0x000E3088 File Offset: 0x000E1288
		public unsafe bool hudUIExists
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113773, XrefRangeEnd = 113777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_hudUIExists_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x060024B0 RID: 9392 RVA: 0x000E30C4 File Offset: 0x000E12C4
		// (set) Token: 0x060024B1 RID: 9393 RVA: 0x000E3104 File Offset: 0x000E1304
		public unsafe QuestHUDUI hudUI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_hudUI_Public_get_QuestHUDUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<QuestHUDUI>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_hudUI_Private_set_Void_QuestHUDUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x060024B2 RID: 9394 RVA: 0x000E3148 File Offset: 0x000E1348
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113777, XrefRangeEnd = 113782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x060024B3 RID: 9395 RVA: 0x000E3180 File Offset: 0x000E1380
		public unsafe virtual string SaveFileName
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 113787, RefRangeEnd = 113789, XrefRangeStart = 113782, XrefRangeEnd = 113787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x060024B4 RID: 9396 RVA: 0x000E31B8 File Offset: 0x000E13B8
		public unsafe virtual Loader Loader
		{
			[CallerCount(65)]
			[CachedScanResults(RefRangeStart = 31227, RefRangeEnd = 31292, XrefRangeStart = 31227, XrefRangeEnd = 31292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x060024B5 RID: 9397 RVA: 0x000E31F8 File Offset: 0x000E13F8
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(183)]
			[CachedScanResults(RefRangeStart = 35953, RefRangeEnd = 36136, XrefRangeStart = 35953, XrefRangeEnd = 36136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x060024B6 RID: 9398 RVA: 0x000E3234 File Offset: 0x000E1434
		// (set) Token: 0x060024B7 RID: 9399 RVA: 0x000E3274 File Offset: 0x000E1474
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113789, XrefRangeEnd = 113790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x060024B8 RID: 9400 RVA: 0x000E32B8 File Offset: 0x000E14B8
		// (set) Token: 0x060024B9 RID: 9401 RVA: 0x000E32F8 File Offset: 0x000E14F8
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x060024BA RID: 9402 RVA: 0x000E333C File Offset: 0x000E153C
		// (set) Token: 0x060024BB RID: 9403 RVA: 0x000E3378 File Offset: 0x000E1578
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024BC RID: 9404 RVA: 0x000E33B8 File Offset: 0x000E15B8
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024BD RID: 9405 RVA: 0x000E33F4 File Offset: 0x000E15F4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 113829, RefRangeEnd = 113835, XrefRangeStart = 113790, XrefRangeEnd = 113829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024BE RID: 9406 RVA: 0x000E3430 File Offset: 0x000E1630
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113896, RefRangeEnd = 113897, XrefRangeStart = 113835, XrefRangeEnd = 113896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeQuest(string title, string description, Il2CppReferenceArray<QuestEntryData> entries, string guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entries);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_InitializeQuest_Public_Virtual_New_Void_String_String_Il2CppReferenceArray_1_QuestEntryData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024BF RID: 9407 RVA: 0x000E34B4 File Offset: 0x000E16B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113897, XrefRangeEnd = 113903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024C0 RID: 9408 RVA: 0x000E34F0 File Offset: 0x000E16F0
		[CallerCount(0)]
		public unsafe void ConfigureExpiry(bool expires, GameDateTime expiry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref expires;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expiry;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_ConfigureExpiry_Public_Void_Boolean_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024C1 RID: 9409 RVA: 0x000E353C File Offset: 0x000E173C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 113914, RefRangeEnd = 113918, XrefRangeStart = 113903, XrefRangeEnd = 113914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Begin(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_Begin_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024C2 RID: 9410 RVA: 0x000E3588 File Offset: 0x000E1788
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113944, RefRangeEnd = 113945, XrefRangeStart = 113918, XrefRangeEnd = 113944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Complete(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_Complete_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024C3 RID: 9411 RVA: 0x000E35D4 File Offset: 0x000E17D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113945, XrefRangeEnd = 113951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Fail(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_Fail_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024C4 RID: 9412 RVA: 0x000E3620 File Offset: 0x000E1820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113951, XrefRangeEnd = 113956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Expire(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_Expire_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024C5 RID: 9413 RVA: 0x000E366C File Offset: 0x000E186C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113956, XrefRangeEnd = 113962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cancel(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_Cancel_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024C6 RID: 9414 RVA: 0x000E36B8 File Offset: 0x000E18B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114003, RefRangeEnd = 114005, XrefRangeStart = 113962, XrefRangeEnd = 114003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_End_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024C7 RID: 9415 RVA: 0x000E36F4 File Offset: 0x000E18F4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 114053, RefRangeEnd = 114057, XrefRangeStart = 114005, XrefRangeEnd = 114053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetQuestState(EQuestState state, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_SetQuestState_Public_Virtual_New_Void_EQuestState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024C8 RID: 9416 RVA: 0x000E374C File Offset: 0x000E194C
		[CallerCount(0)]
		public unsafe virtual bool ShouldShowJournalEntry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_ShouldShowJournalEntry_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024C9 RID: 9417 RVA: 0x000E3794 File Offset: 0x000E1994
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114068, RefRangeEnd = 114069, XrefRangeStart = 114057, XrefRangeEnd = 114068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetQuestEntryState(int entryIndex, EQuestState state, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref entryIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_SetQuestEntryState_Public_Virtual_New_Void_Int32_EQuestState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024CA RID: 9418 RVA: 0x000E37FC File Offset: 0x000E19FC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 114080, RefRangeEnd = 114094, XrefRangeStart = 114069, XrefRangeEnd = 114080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024CB RID: 9419 RVA: 0x000E3838 File Offset: 0x000E1A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114094, XrefRangeEnd = 114096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckExpiry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_CheckExpiry_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024CC RID: 9420 RVA: 0x000E3874 File Offset: 0x000E1A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114096, XrefRangeEnd = 114101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckAutoComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_CheckAutoComplete_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x000E38A8 File Offset: 0x000E1AA8
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 30138, RefRangeEnd = 30158, XrefRangeStart = 30138, XrefRangeEnd = 30158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanExpire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_CanExpire_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024CE RID: 9422 RVA: 0x000E38F0 File Offset: 0x000E1AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114101, XrefRangeEnd = 114112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendExpiryReminder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_SendExpiryReminder_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x000E392C File Offset: 0x000E1B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114112, XrefRangeEnd = 114123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendExpiredNotification()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_SendExpiredNotification_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x000E3968 File Offset: 0x000E1B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114123, XrefRangeEnd = 114127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x000E39A8 File Offset: 0x000E1BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSubtitle(string subtitle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(subtitle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_SetSubtitle_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D2 RID: 9426 RVA: 0x000E39EC File Offset: 0x000E1BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114127, XrefRangeEnd = 114151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsTracked(bool tracked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref tracked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_SetIsTracked_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D3 RID: 9427 RVA: 0x000E3A38 File Offset: 0x000E1C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114151, XrefRangeEnd = 114248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetupJournalEntry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_SetupJournalEntry_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D4 RID: 9428 RVA: 0x000E3A74 File Offset: 0x000E1C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114248, XrefRangeEnd = 114257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyJournalEntry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_DestroyJournalEntry_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D5 RID: 9429 RVA: 0x000E3AA8 File Offset: 0x000E1CA8
		[CallerCount(0)]
		public unsafe void JournalEntryClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_JournalEntryClicked_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D6 RID: 9430 RVA: 0x000E3ADC File Offset: 0x000E1CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114257, XrefRangeEnd = 114263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void JournalEntryHoverStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_JournalEntryHoverStart_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024D7 RID: 9431 RVA: 0x000E3B10 File Offset: 0x000E1D10
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 114269, RefRangeEnd = 114276, XrefRangeStart = 114263, XrefRangeEnd = 114269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMinsUntilExpiry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_GetMinsUntilExpiry_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024D8 RID: 9432 RVA: 0x000E3B4C File Offset: 0x000E1D4C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 114282, RefRangeEnd = 114285, XrefRangeStart = 114276, XrefRangeEnd = 114282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetExpiryText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_GetExpiryText_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060024D9 RID: 9433 RVA: 0x000E3B84 File Offset: 0x000E1D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114285, XrefRangeEnd = 114310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual QuestHUDUI SetupHudUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_SetupHudUI_Public_Virtual_New_QuestHUDUI_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<QuestHUDUI>(intPtr3) : null;
		}

		// Token: 0x060024DA RID: 9434 RVA: 0x000E3BD0 File Offset: 0x000E1DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114310, XrefRangeEnd = 114311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateHUDUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_UpdateHUDUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024DB RID: 9435 RVA: 0x000E3C04 File Offset: 0x000E1E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114311, XrefRangeEnd = 114316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BopHUDUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_BopHUDUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024DC RID: 9436 RVA: 0x000E3C38 File Offset: 0x000E1E38
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 19660, RefRangeEnd = 19667, XrefRangeStart = 19660, XrefRangeEnd = 19667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetQuestTitle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_GetQuestTitle_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060024DD RID: 9437 RVA: 0x000E3C7C File Offset: 0x000E1E7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114323, RefRangeEnd = 114325, XrefRangeStart = 114316, XrefRangeEnd = 114323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestEntry GetFirstActiveEntry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_GetFirstActiveEntry_Public_QuestEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr3) : null;
		}

		// Token: 0x060024DE RID: 9438 RVA: 0x000E3CBC File Offset: 0x000E1EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114325, XrefRangeEnd = 114333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyHudUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_DestroyHudUI_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024DF RID: 9439 RVA: 0x000E3CF0 File Offset: 0x000E1EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114333, XrefRangeEnd = 114454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual RectTransform CreateDetailDisplay(RectTransform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_CreateDetailDisplay_Public_Virtual_New_RectTransform_RectTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
		}

		// Token: 0x060024E0 RID: 9440 RVA: 0x000E3D4C File Offset: 0x000E1F4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114464, RefRangeEnd = 114466, XrefRangeStart = 114454, XrefRangeEnd = 114464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyDetailDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_DestroyDetailDisplay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024E1 RID: 9441 RVA: 0x000E3D80 File Offset: 0x000E1F80
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 30138, RefRangeEnd = 30158, XrefRangeStart = 30138, XrefRangeEnd = 30158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024E2 RID: 9442 RVA: 0x000E3DC8 File Offset: 0x000E1FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114466, XrefRangeEnd = 114498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060024E3 RID: 9443 RVA: 0x000E3E0C File Offset: 0x000E200C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114498, XrefRangeEnd = 114520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(QuestData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_QuestData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024E4 RID: 9444 RVA: 0x000E3E5C File Offset: 0x000E205C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 114539, RefRangeEnd = 114544, XrefRangeStart = 114520, XrefRangeEnd = 114539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quest GetQuest(string questName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(questName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_GetQuest_Public_Static_Quest_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quest>(intPtr3) : null;
		}

		// Token: 0x060024E5 RID: 9445 RVA: 0x000E3EA0 File Offset: 0x000E20A0
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 114573, RefRangeEnd = 114595, XrefRangeStart = 114544, XrefRangeEnd = 114573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024E6 RID: 9446 RVA: 0x000E3EDC File Offset: 0x000E20DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114634, RefRangeEnd = 114635, XrefRangeStart = 114595, XrefRangeEnd = 114634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024E7 RID: 9447 RVA: 0x000E3F10 File Offset: 0x000E2110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114635, XrefRangeEnd = 114641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SetupJournalEntry_b__110_0(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr__SetupJournalEntry_b__110_0_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024E8 RID: 9448 RVA: 0x000E3F54 File Offset: 0x000E2154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114641, XrefRangeEnd = 114670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024E9 RID: 9449 RVA: 0x000148F8 File Offset: 0x00012AF8
		public Quest(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x060024EA RID: 9450 RVA: 0x000E3F88 File Offset: 0x000E2188
		// (set) Token: 0x060024EB RID: 9451 RVA: 0x00014901 File Offset: 0x00012B01
		public unsafe static int MAX_HUD_ENTRY_LABELS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Quest.NativeFieldInfoPtr_MAX_HUD_ENTRY_LABELS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest.NativeFieldInfoPtr_MAX_HUD_ENTRY_LABELS, (void*)(&value));
			}
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x060024EC RID: 9452 RVA: 0x000E3FA4 File Offset: 0x000E21A4
		// (set) Token: 0x060024ED RID: 9453 RVA: 0x0001490F File Offset: 0x00012B0F
		public unsafe static int CriticalExpiryThreshold
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Quest.NativeFieldInfoPtr_CriticalExpiryThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest.NativeFieldInfoPtr_CriticalExpiryThreshold, (void*)(&value));
			}
		}

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x060024EE RID: 9454 RVA: 0x000E3FC0 File Offset: 0x000E21C0
		// (set) Token: 0x060024EF RID: 9455 RVA: 0x0001491D File Offset: 0x00012B1D
		public unsafe static List<Quest> Quests
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Quest.NativeFieldInfoPtr_Quests, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Quest>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest.NativeFieldInfoPtr_Quests, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x060024F0 RID: 9456 RVA: 0x000E3FE8 File Offset: 0x000E21E8
		// (set) Token: 0x060024F1 RID: 9457 RVA: 0x0001492F File Offset: 0x00012B2F
		public unsafe static Quest HoveredQuest
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Quest.NativeFieldInfoPtr_HoveredQuest, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quest>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest.NativeFieldInfoPtr_HoveredQuest, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x060024F2 RID: 9458 RVA: 0x000E4010 File Offset: 0x000E2210
		// (set) Token: 0x060024F3 RID: 9459 RVA: 0x00014941 File Offset: 0x00012B41
		public unsafe static List<Quest> ActiveQuests
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Quest.NativeFieldInfoPtr_ActiveQuests, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Quest>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest.NativeFieldInfoPtr_ActiveQuests, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x060024F4 RID: 9460 RVA: 0x000E4038 File Offset: 0x000E2238
		// (set) Token: 0x060024F5 RID: 9461 RVA: 0x00014953 File Offset: 0x00012B53
		public unsafe EQuestState _QuestState_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__QuestState_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__QuestState_k__BackingField)) = value;
			}
		}

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x060024F6 RID: 9462 RVA: 0x000E4060 File Offset: 0x000E2260
		// (set) Token: 0x060024F7 RID: 9463 RVA: 0x0001496E File Offset: 0x00012B6E
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x060024F8 RID: 9464 RVA: 0x000E4088 File Offset: 0x000E2288
		// (set) Token: 0x060024F9 RID: 9465 RVA: 0x00014989 File Offset: 0x00012B89
		public unsafe bool _IsTracked_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__IsTracked_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__IsTracked_k__BackingField)) = value;
			}
		}

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x060024FA RID: 9466 RVA: 0x000E40B0 File Offset: 0x000E22B0
		// (set) Token: 0x060024FB RID: 9467 RVA: 0x000149A4 File Offset: 0x00012BA4
		public unsafe string title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_title);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_title), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x060024FC RID: 9468 RVA: 0x000E40D8 File Offset: 0x000E22D8
		// (set) Token: 0x060024FD RID: 9469 RVA: 0x000149C3 File Offset: 0x00012BC3
		public unsafe string Subtitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_Subtitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_Subtitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x060024FE RID: 9470 RVA: 0x000E4100 File Offset: 0x000E2300
		// (set) Token: 0x060024FF RID: 9471 RVA: 0x000149E2 File Offset: 0x00012BE2
		public unsafe Action onSubtitleChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onSubtitleChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onSubtitleChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x06002500 RID: 9472 RVA: 0x000E4130 File Offset: 0x000E2330
		// (set) Token: 0x06002501 RID: 9473 RVA: 0x00014A01 File Offset: 0x00012C01
		public unsafe string Description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_Description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x06002502 RID: 9474 RVA: 0x000E4158 File Offset: 0x000E2358
		// (set) Token: 0x06002503 RID: 9475 RVA: 0x00014A20 File Offset: 0x00012C20
		public unsafe string StaticGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_StaticGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_StaticGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x06002504 RID: 9476 RVA: 0x000E4180 File Offset: 0x000E2380
		// (set) Token: 0x06002505 RID: 9477 RVA: 0x00014A3F File Offset: 0x00012C3F
		public unsafe bool TrackOnBegin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_TrackOnBegin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_TrackOnBegin)) = value;
			}
		}

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x06002506 RID: 9478 RVA: 0x000E41A8 File Offset: 0x000E23A8
		// (set) Token: 0x06002507 RID: 9479 RVA: 0x00014A5A File Offset: 0x00012C5A
		public unsafe EExpiryVisibility ExpiryVisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_ExpiryVisibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_ExpiryVisibility)) = value;
			}
		}

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x06002508 RID: 9480 RVA: 0x000E41D0 File Offset: 0x000E23D0
		// (set) Token: 0x06002509 RID: 9481 RVA: 0x00014A75 File Offset: 0x00012C75
		public unsafe bool AutoCompleteOnAllEntriesComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_AutoCompleteOnAllEntriesComplete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_AutoCompleteOnAllEntriesComplete)) = value;
			}
		}

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x0600250A RID: 9482 RVA: 0x000E41F8 File Offset: 0x000E23F8
		// (set) Token: 0x0600250B RID: 9483 RVA: 0x00014A90 File Offset: 0x00012C90
		public unsafe bool PlayQuestCompleteSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_PlayQuestCompleteSound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_PlayQuestCompleteSound)) = value;
			}
		}

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x0600250C RID: 9484 RVA: 0x000E4220 File Offset: 0x000E2420
		// (set) Token: 0x0600250D RID: 9485 RVA: 0x00014AAB File Offset: 0x00012CAB
		public unsafe int CompletionXP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_CompletionXP);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_CompletionXP)) = value;
			}
		}

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x0600250E RID: 9486 RVA: 0x000E4248 File Offset: 0x000E2448
		// (set) Token: 0x0600250F RID: 9487 RVA: 0x00014AC6 File Offset: 0x00012CC6
		public unsafe bool _Expires_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__Expires_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__Expires_k__BackingField)) = value;
			}
		}

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x06002510 RID: 9488 RVA: 0x000E4270 File Offset: 0x000E2470
		// (set) Token: 0x06002511 RID: 9489 RVA: 0x00014AE1 File Offset: 0x00012CE1
		public unsafe GameDateTime _Expiry_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__Expiry_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__Expiry_k__BackingField)) = value;
			}
		}

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x06002512 RID: 9490 RVA: 0x000E4298 File Offset: 0x000E2498
		// (set) Token: 0x06002513 RID: 9491 RVA: 0x00014AFC File Offset: 0x00012CFC
		public unsafe bool AutoStartFirstEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_AutoStartFirstEntry);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_AutoStartFirstEntry)) = value;
			}
		}

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x06002514 RID: 9492 RVA: 0x000E42C0 File Offset: 0x000E24C0
		// (set) Token: 0x06002515 RID: 9493 RVA: 0x00014B17 File Offset: 0x00012D17
		public unsafe List<QuestEntry> Entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_Entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<QuestEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x06002516 RID: 9494 RVA: 0x000E42F0 File Offset: 0x000E24F0
		// (set) Token: 0x06002517 RID: 9495 RVA: 0x00014B36 File Offset: 0x00012D36
		public unsafe RectTransform IconPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_IconPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_IconPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x06002518 RID: 9496 RVA: 0x000E4320 File Offset: 0x000E2520
		// (set) Token: 0x06002519 RID: 9497 RVA: 0x00014B55 File Offset: 0x00012D55
		public unsafe GameObject PoIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_PoIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_PoIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x0600251A RID: 9498 RVA: 0x000E4350 File Offset: 0x000E2550
		// (set) Token: 0x0600251B RID: 9499 RVA: 0x00014B74 File Offset: 0x00012D74
		public unsafe UnityEvent onQuestBegin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onQuestBegin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onQuestBegin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x0600251C RID: 9500 RVA: 0x000E4380 File Offset: 0x000E2580
		// (set) Token: 0x0600251D RID: 9501 RVA: 0x00014B93 File Offset: 0x00012D93
		public unsafe UnityEvent<EQuestState> onQuestEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onQuestEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<EQuestState>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onQuestEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x0600251E RID: 9502 RVA: 0x000E43B0 File Offset: 0x000E25B0
		// (set) Token: 0x0600251F RID: 9503 RVA: 0x00014BB2 File Offset: 0x00012DB2
		public unsafe UnityEvent onActiveState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onActiveState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onActiveState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x06002520 RID: 9504 RVA: 0x000E43E0 File Offset: 0x000E25E0
		// (set) Token: 0x06002521 RID: 9505 RVA: 0x00014BD1 File Offset: 0x00012DD1
		public unsafe UnityEvent<bool> onTrackChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onTrackChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onTrackChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x06002522 RID: 9506 RVA: 0x000E4410 File Offset: 0x000E2610
		// (set) Token: 0x06002523 RID: 9507 RVA: 0x00014BF0 File Offset: 0x00012DF0
		public unsafe UnityEvent onComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x06002524 RID: 9508 RVA: 0x000E4440 File Offset: 0x000E2640
		// (set) Token: 0x06002525 RID: 9509 RVA: 0x00014C0F File Offset: 0x00012E0F
		public unsafe UnityEvent onInitialComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onInitialComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onInitialComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x06002526 RID: 9510 RVA: 0x000E4470 File Offset: 0x000E2670
		// (set) Token: 0x06002527 RID: 9511 RVA: 0x00014C2E File Offset: 0x00012E2E
		public unsafe bool ShouldSendExpiryReminder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_ShouldSendExpiryReminder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_ShouldSendExpiryReminder)) = value;
			}
		}

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x06002528 RID: 9512 RVA: 0x000E4498 File Offset: 0x000E2698
		// (set) Token: 0x06002529 RID: 9513 RVA: 0x00014C49 File Offset: 0x00012E49
		public unsafe bool ShouldSendExpiredNotification
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_ShouldSendExpiredNotification);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_ShouldSendExpiredNotification)) = value;
			}
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x0600252A RID: 9514 RVA: 0x000E44C0 File Offset: 0x000E26C0
		// (set) Token: 0x0600252B RID: 9515 RVA: 0x00014C64 File Offset: 0x00012E64
		public unsafe RectTransform journalEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_journalEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_journalEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x0600252C RID: 9516 RVA: 0x000E44F0 File Offset: 0x000E26F0
		// (set) Token: 0x0600252D RID: 9517 RVA: 0x00014C83 File Offset: 0x00012E83
		public unsafe RectTransform entryTitleRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_entryTitleRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_entryTitleRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x0600252E RID: 9518 RVA: 0x000E4520 File Offset: 0x000E2720
		// (set) Token: 0x0600252F RID: 9519 RVA: 0x00014CA2 File Offset: 0x00012EA2
		public unsafe RectTransform trackedRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_trackedRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_trackedRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x06002530 RID: 9520 RVA: 0x000E4550 File Offset: 0x000E2750
		// (set) Token: 0x06002531 RID: 9521 RVA: 0x00014CC1 File Offset: 0x00012EC1
		public unsafe Text entryTimeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_entryTimeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_entryTimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x06002532 RID: 9522 RVA: 0x000E4580 File Offset: 0x000E2780
		// (set) Token: 0x06002533 RID: 9523 RVA: 0x00014CE0 File Offset: 0x00012EE0
		public unsafe Image criticalTimeBackground
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_criticalTimeBackground);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_criticalTimeBackground), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x06002534 RID: 9524 RVA: 0x000E45B0 File Offset: 0x000E27B0
		// (set) Token: 0x06002535 RID: 9525 RVA: 0x00014CFF File Offset: 0x00012EFF
		public unsafe RectTransform detailPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_detailPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_detailPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x06002536 RID: 9526 RVA: 0x000E45E0 File Offset: 0x000E27E0
		// (set) Token: 0x06002537 RID: 9527 RVA: 0x00014D1E File Offset: 0x00012F1E
		public unsafe QuestHUDUI _hudUI_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__hudUI_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestHUDUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__hudUI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x06002538 RID: 9528 RVA: 0x000E4610 File Offset: 0x000E2810
		// (set) Token: 0x06002539 RID: 9529 RVA: 0x00014D3D File Offset: 0x00012F3D
		public unsafe Action onHudUICreated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onHudUICreated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onHudUICreated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x0600253A RID: 9530 RVA: 0x000E4640 File Offset: 0x000E2840
		// (set) Token: 0x0600253B RID: 9531 RVA: 0x00014D5C File Offset: 0x00012F5C
		public unsafe bool expiryReminderSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_expiryReminderSent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_expiryReminderSent)) = value;
			}
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x0600253C RID: 9532 RVA: 0x000E4668 File Offset: 0x000E2868
		// (set) Token: 0x0600253D RID: 9533 RVA: 0x00014D77 File Offset: 0x00012F77
		public unsafe CompassManager.Element compassElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_compassElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompassManager.Element>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_compassElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x0600253E RID: 9534 RVA: 0x000E4698 File Offset: 0x000E2898
		// (set) Token: 0x0600253F RID: 9535 RVA: 0x00014D96 File Offset: 0x00012F96
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x06002540 RID: 9536 RVA: 0x000E46C8 File Offset: 0x000E28C8
		// (set) Token: 0x06002541 RID: 9537 RVA: 0x00014DB5 File Offset: 0x00012FB5
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x06002542 RID: 9538 RVA: 0x000E46F8 File Offset: 0x000E28F8
		// (set) Token: 0x06002543 RID: 9539 RVA: 0x00014DD4 File Offset: 0x00012FD4
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x06002544 RID: 9540 RVA: 0x000E4720 File Offset: 0x000E2920
		// (set) Token: 0x06002545 RID: 9541 RVA: 0x00014DEF File Offset: 0x00012FEF
		public unsafe bool autoInitialize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_autoInitialize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_autoInitialize)) = value;
			}
		}

		// Token: 0x0400184F RID: 6223
		private static readonly IntPtr NativeFieldInfoPtr_MAX_HUD_ENTRY_LABELS;

		// Token: 0x04001850 RID: 6224
		private static readonly IntPtr NativeFieldInfoPtr_CriticalExpiryThreshold;

		// Token: 0x04001851 RID: 6225
		private static readonly IntPtr NativeFieldInfoPtr_Quests;

		// Token: 0x04001852 RID: 6226
		private static readonly IntPtr NativeFieldInfoPtr_HoveredQuest;

		// Token: 0x04001853 RID: 6227
		private static readonly IntPtr NativeFieldInfoPtr_ActiveQuests;

		// Token: 0x04001854 RID: 6228
		private static readonly IntPtr NativeFieldInfoPtr__QuestState_k__BackingField;

		// Token: 0x04001855 RID: 6229
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04001856 RID: 6230
		private static readonly IntPtr NativeFieldInfoPtr__IsTracked_k__BackingField;

		// Token: 0x04001857 RID: 6231
		private static readonly IntPtr NativeFieldInfoPtr_title;

		// Token: 0x04001858 RID: 6232
		private static readonly IntPtr NativeFieldInfoPtr_Subtitle;

		// Token: 0x04001859 RID: 6233
		private static readonly IntPtr NativeFieldInfoPtr_onSubtitleChanged;

		// Token: 0x0400185A RID: 6234
		private static readonly IntPtr NativeFieldInfoPtr_Description;

		// Token: 0x0400185B RID: 6235
		private static readonly IntPtr NativeFieldInfoPtr_StaticGUID;

		// Token: 0x0400185C RID: 6236
		private static readonly IntPtr NativeFieldInfoPtr_TrackOnBegin;

		// Token: 0x0400185D RID: 6237
		private static readonly IntPtr NativeFieldInfoPtr_ExpiryVisibility;

		// Token: 0x0400185E RID: 6238
		private static readonly IntPtr NativeFieldInfoPtr_AutoCompleteOnAllEntriesComplete;

		// Token: 0x0400185F RID: 6239
		private static readonly IntPtr NativeFieldInfoPtr_PlayQuestCompleteSound;

		// Token: 0x04001860 RID: 6240
		private static readonly IntPtr NativeFieldInfoPtr_CompletionXP;

		// Token: 0x04001861 RID: 6241
		private static readonly IntPtr NativeFieldInfoPtr__Expires_k__BackingField;

		// Token: 0x04001862 RID: 6242
		private static readonly IntPtr NativeFieldInfoPtr__Expiry_k__BackingField;

		// Token: 0x04001863 RID: 6243
		private static readonly IntPtr NativeFieldInfoPtr_AutoStartFirstEntry;

		// Token: 0x04001864 RID: 6244
		private static readonly IntPtr NativeFieldInfoPtr_Entries;

		// Token: 0x04001865 RID: 6245
		private static readonly IntPtr NativeFieldInfoPtr_IconPrefab;

		// Token: 0x04001866 RID: 6246
		private static readonly IntPtr NativeFieldInfoPtr_PoIPrefab;

		// Token: 0x04001867 RID: 6247
		private static readonly IntPtr NativeFieldInfoPtr_onQuestBegin;

		// Token: 0x04001868 RID: 6248
		private static readonly IntPtr NativeFieldInfoPtr_onQuestEnd;

		// Token: 0x04001869 RID: 6249
		private static readonly IntPtr NativeFieldInfoPtr_onActiveState;

		// Token: 0x0400186A RID: 6250
		private static readonly IntPtr NativeFieldInfoPtr_onTrackChange;

		// Token: 0x0400186B RID: 6251
		private static readonly IntPtr NativeFieldInfoPtr_onComplete;

		// Token: 0x0400186C RID: 6252
		private static readonly IntPtr NativeFieldInfoPtr_onInitialComplete;

		// Token: 0x0400186D RID: 6253
		private static readonly IntPtr NativeFieldInfoPtr_ShouldSendExpiryReminder;

		// Token: 0x0400186E RID: 6254
		private static readonly IntPtr NativeFieldInfoPtr_ShouldSendExpiredNotification;

		// Token: 0x0400186F RID: 6255
		private static readonly IntPtr NativeFieldInfoPtr_journalEntry;

		// Token: 0x04001870 RID: 6256
		private static readonly IntPtr NativeFieldInfoPtr_entryTitleRect;

		// Token: 0x04001871 RID: 6257
		private static readonly IntPtr NativeFieldInfoPtr_trackedRect;

		// Token: 0x04001872 RID: 6258
		private static readonly IntPtr NativeFieldInfoPtr_entryTimeLabel;

		// Token: 0x04001873 RID: 6259
		private static readonly IntPtr NativeFieldInfoPtr_criticalTimeBackground;

		// Token: 0x04001874 RID: 6260
		private static readonly IntPtr NativeFieldInfoPtr_detailPanel;

		// Token: 0x04001875 RID: 6261
		private static readonly IntPtr NativeFieldInfoPtr__hudUI_k__BackingField;

		// Token: 0x04001876 RID: 6262
		private static readonly IntPtr NativeFieldInfoPtr_onHudUICreated;

		// Token: 0x04001877 RID: 6263
		private static readonly IntPtr NativeFieldInfoPtr_expiryReminderSent;

		// Token: 0x04001878 RID: 6264
		private static readonly IntPtr NativeFieldInfoPtr_compassElement;

		// Token: 0x04001879 RID: 6265
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x0400187A RID: 6266
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x0400187B RID: 6267
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x0400187C RID: 6268
		private static readonly IntPtr NativeFieldInfoPtr_autoInitialize;

		// Token: 0x0400187D RID: 6269
		private static readonly IntPtr NativeMethodInfoPtr_get_QuestState_Public_get_EQuestState_0;

		// Token: 0x0400187E RID: 6270
		private static readonly IntPtr NativeMethodInfoPtr_set_QuestState_Protected_set_Void_EQuestState_0;

		// Token: 0x0400187F RID: 6271
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04001880 RID: 6272
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04001881 RID: 6273
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTracked_Public_get_Boolean_0;

		// Token: 0x04001882 RID: 6274
		private static readonly IntPtr NativeMethodInfoPtr_set_IsTracked_Protected_set_Void_Boolean_0;

		// Token: 0x04001883 RID: 6275
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveEntryCount_Public_get_Int32_0;

		// Token: 0x04001884 RID: 6276
		private static readonly IntPtr NativeMethodInfoPtr_get_Title_Public_get_String_0;

		// Token: 0x04001885 RID: 6277
		private static readonly IntPtr NativeMethodInfoPtr_get_Expires_Public_get_Boolean_0;

		// Token: 0x04001886 RID: 6278
		private static readonly IntPtr NativeMethodInfoPtr_set_Expires_Protected_set_Void_Boolean_0;

		// Token: 0x04001887 RID: 6279
		private static readonly IntPtr NativeMethodInfoPtr_get_Expiry_Public_get_GameDateTime_0;

		// Token: 0x04001888 RID: 6280
		private static readonly IntPtr NativeMethodInfoPtr_set_Expiry_Protected_set_Void_GameDateTime_0;

		// Token: 0x04001889 RID: 6281
		private static readonly IntPtr NativeMethodInfoPtr_get_hudUIExists_Public_get_Boolean_0;

		// Token: 0x0400188A RID: 6282
		private static readonly IntPtr NativeMethodInfoPtr_get_hudUI_Public_get_QuestHUDUI_0;

		// Token: 0x0400188B RID: 6283
		private static readonly IntPtr NativeMethodInfoPtr_set_hudUI_Private_set_Void_QuestHUDUI_0;

		// Token: 0x0400188C RID: 6284
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400188D RID: 6285
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400188E RID: 6286
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x0400188F RID: 6287
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001890 RID: 6288
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04001891 RID: 6289
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04001892 RID: 6290
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04001893 RID: 6291
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04001894 RID: 6292
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001895 RID: 6293
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04001896 RID: 6294
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04001897 RID: 6295
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04001898 RID: 6296
		private static readonly IntPtr NativeMethodInfoPtr_InitializeQuest_Public_Virtual_New_Void_String_String_Il2CppReferenceArray_1_QuestEntryData_String_0;

		// Token: 0x04001899 RID: 6297
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x0400189A RID: 6298
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureExpiry_Public_Void_Boolean_GameDateTime_0;

		// Token: 0x0400189B RID: 6299
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x0400189C RID: 6300
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x0400189D RID: 6301
		private static readonly IntPtr NativeMethodInfoPtr_Fail_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x0400189E RID: 6302
		private static readonly IntPtr NativeMethodInfoPtr_Expire_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x0400189F RID: 6303
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040018A0 RID: 6304
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Virtual_New_Void_0;

		// Token: 0x040018A1 RID: 6305
		private static readonly IntPtr NativeMethodInfoPtr_SetQuestState_Public_Virtual_New_Void_EQuestState_Boolean_0;

		// Token: 0x040018A2 RID: 6306
		private static readonly IntPtr NativeMethodInfoPtr_ShouldShowJournalEntry_Protected_Virtual_New_Boolean_0;

		// Token: 0x040018A3 RID: 6307
		private static readonly IntPtr NativeMethodInfoPtr_SetQuestEntryState_Public_Virtual_New_Void_Int32_EQuestState_Boolean_0;

		// Token: 0x040018A4 RID: 6308
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0;

		// Token: 0x040018A5 RID: 6309
		private static readonly IntPtr NativeMethodInfoPtr_CheckExpiry_Protected_Virtual_New_Void_0;

		// Token: 0x040018A6 RID: 6310
		private static readonly IntPtr NativeMethodInfoPtr_CheckAutoComplete_Private_Void_1;

		// Token: 0x040018A7 RID: 6311
		private static readonly IntPtr NativeMethodInfoPtr_CanExpire_Protected_Virtual_New_Boolean_0;

		// Token: 0x040018A8 RID: 6312
		private static readonly IntPtr NativeMethodInfoPtr_SendExpiryReminder_Protected_Virtual_New_Void_0;

		// Token: 0x040018A9 RID: 6313
		private static readonly IntPtr NativeMethodInfoPtr_SendExpiredNotification_Protected_Virtual_New_Void_0;

		// Token: 0x040018AA RID: 6314
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x040018AB RID: 6315
		private static readonly IntPtr NativeMethodInfoPtr_SetSubtitle_Public_Void_String_0;

		// Token: 0x040018AC RID: 6316
		private static readonly IntPtr NativeMethodInfoPtr_SetIsTracked_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040018AD RID: 6317
		private static readonly IntPtr NativeMethodInfoPtr_SetupJournalEntry_Public_Virtual_New_Void_0;

		// Token: 0x040018AE RID: 6318
		private static readonly IntPtr NativeMethodInfoPtr_DestroyJournalEntry_Private_Void_1;

		// Token: 0x040018AF RID: 6319
		private static readonly IntPtr NativeMethodInfoPtr_JournalEntryClicked_Private_Void_1;

		// Token: 0x040018B0 RID: 6320
		private static readonly IntPtr NativeMethodInfoPtr_JournalEntryHoverStart_Private_Void_1;

		// Token: 0x040018B1 RID: 6321
		private static readonly IntPtr NativeMethodInfoPtr_GetMinsUntilExpiry_Public_Int32_0;

		// Token: 0x040018B2 RID: 6322
		private static readonly IntPtr NativeMethodInfoPtr_GetExpiryText_Public_String_0;

		// Token: 0x040018B3 RID: 6323
		private static readonly IntPtr NativeMethodInfoPtr_SetupHudUI_Public_Virtual_New_QuestHUDUI_0;

		// Token: 0x040018B4 RID: 6324
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHUDUI_Public_Void_0;

		// Token: 0x040018B5 RID: 6325
		private static readonly IntPtr NativeMethodInfoPtr_BopHUDUI_Public_Void_0;

		// Token: 0x040018B6 RID: 6326
		private static readonly IntPtr NativeMethodInfoPtr_GetQuestTitle_Public_Virtual_New_String_0;

		// Token: 0x040018B7 RID: 6327
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstActiveEntry_Public_QuestEntry_0;

		// Token: 0x040018B8 RID: 6328
		private static readonly IntPtr NativeMethodInfoPtr_DestroyHudUI_Private_Void_1;

		// Token: 0x040018B9 RID: 6329
		private static readonly IntPtr NativeMethodInfoPtr_CreateDetailDisplay_Public_Virtual_New_RectTransform_RectTransform_0;

		// Token: 0x040018BA RID: 6330
		private static readonly IntPtr NativeMethodInfoPtr_DestroyDetailDisplay_Public_Void_0;

		// Token: 0x040018BB RID: 6331
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0;

		// Token: 0x040018BC RID: 6332
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x040018BD RID: 6333
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_QuestData_0;

		// Token: 0x040018BE RID: 6334
		private static readonly IntPtr NativeMethodInfoPtr_GetQuest_Public_Static_Quest_String_0;

		// Token: 0x040018BF RID: 6335
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040018C0 RID: 6336
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;

		// Token: 0x040018C1 RID: 6337
		private static readonly IntPtr NativeMethodInfoPtr__SetupJournalEntry_b__110_0_Private_Void_BaseEventData_0;

		// Token: 0x040018C2 RID: 6338
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;

		// Token: 0x020008CE RID: 2254
		[ObfuscatedName("ScheduleOne.Quests.Quest+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C40C RID: 50188 RVA: 0x002FC7F0 File Offset: 0x002FA9F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Quest.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest.__c>.NativeClassPtr);
				Quest.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest.__c>.NativeClassPtr, "<>9");
				Quest.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest.__c>.NativeClassPtr, "<>9__18_0");
				Quest.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest.__c>.NativeClassPtr, 100667422);
				Quest.__c.NativeMethodInfoPtr__get_ActiveEntryCount_b__18_0_Internal_Boolean_QuestEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest.__c>.NativeClassPtr, 100667423);
			}

			// Token: 0x0600C40D RID: 50189 RVA: 0x002FC86C File Offset: 0x002FAA6C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C40E RID: 50190 RVA: 0x002FC8A8 File Offset: 0x002FAAA8
			[CallerCount(0)]
			public unsafe bool _get_ActiveEntryCount_b__18_0(QuestEntry x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.__c.NativeMethodInfoPtr__get_ActiveEntryCount_b__18_0_Internal_Boolean_QuestEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C40F RID: 50191 RVA: 0x0005F6F1 File Offset: 0x0005D8F1
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D33 RID: 15667
			// (get) Token: 0x0600C410 RID: 50192 RVA: 0x002FC8F8 File Offset: 0x002FAAF8
			// (set) Token: 0x0600C411 RID: 50193 RVA: 0x0005F6FA File Offset: 0x0005D8FA
			public unsafe static Quest.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Quest.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quest.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Quest.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D34 RID: 15668
			// (get) Token: 0x0600C412 RID: 50194 RVA: 0x002FC920 File Offset: 0x002FAB20
			// (set) Token: 0x0600C413 RID: 50195 RVA: 0x0005F70C File Offset: 0x0005D90C
			public unsafe static Func<QuestEntry, bool> __9__18_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Quest.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<QuestEntry, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Quest.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040084DE RID: 34014
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040084DF RID: 34015
			private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x040084E0 RID: 34016
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040084E1 RID: 34017
			private static readonly IntPtr NativeMethodInfoPtr__get_ActiveEntryCount_b__18_0_Internal_Boolean_QuestEntry_0;
		}

		// Token: 0x020008CF RID: 2255
		[ObfuscatedName("ScheduleOne.Quests.Quest+<>c__DisplayClass127_0")]
		public sealed class __c__DisplayClass127_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C414 RID: 50196 RVA: 0x002FC948 File Offset: 0x002FAB48
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass127_0()
			{
				Il2CppClassPointerStore<Quest.__c__DisplayClass127_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<>c__DisplayClass127_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest.__c__DisplayClass127_0>.NativeClassPtr);
				Quest.__c__DisplayClass127_0.NativeFieldInfoPtr_questName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest.__c__DisplayClass127_0>.NativeClassPtr, "questName");
				Quest.__c__DisplayClass127_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest.__c__DisplayClass127_0>.NativeClassPtr, 100667424);
				Quest.__c__DisplayClass127_0.NativeMethodInfoPtr__GetQuest_b__0_Internal_Boolean_Quest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest.__c__DisplayClass127_0>.NativeClassPtr, 100667425);
			}

			// Token: 0x0600C415 RID: 50197 RVA: 0x002FC9B0 File Offset: 0x002FABB0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass127_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest.__c__DisplayClass127_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.__c__DisplayClass127_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C416 RID: 50198 RVA: 0x002FC9EC File Offset: 0x002FABEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113749, XrefRangeEnd = 113753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetQuest_b__0(Quest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.__c__DisplayClass127_0.NativeMethodInfoPtr__GetQuest_b__0_Internal_Boolean_Quest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C417 RID: 50199 RVA: 0x0005F71E File Offset: 0x0005D91E
			public __c__DisplayClass127_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D35 RID: 15669
			// (get) Token: 0x0600C418 RID: 50200 RVA: 0x002FCA3C File Offset: 0x002FAC3C
			// (set) Token: 0x0600C419 RID: 50201 RVA: 0x0005F727 File Offset: 0x0005D927
			public unsafe string questName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.__c__DisplayClass127_0.NativeFieldInfoPtr_questName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.__c__DisplayClass127_0.NativeFieldInfoPtr_questName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040084E2 RID: 34018
			private static readonly IntPtr NativeFieldInfoPtr_questName;

			// Token: 0x040084E3 RID: 34019
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040084E4 RID: 34020
			private static readonly IntPtr NativeMethodInfoPtr__GetQuest_b__0_Internal_Boolean_Quest_0;
		}
	}
}
