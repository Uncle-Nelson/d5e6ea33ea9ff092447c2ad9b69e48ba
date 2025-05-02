using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.GameTime
{
	// Token: 0x02000193 RID: 403
	public class TimeManager : NetworkSingleton<TimeManager>
	{
		// Token: 0x060020C4 RID: 8388 RVA: 0x000D66DC File Offset: 0x000D48DC
		// Note: this type is marked as 'beforefieldinit'.
		static TimeManager()
		{
			Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.GameTime", "TimeManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr);
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_CYCLE_DURATION_MINS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "CYCLE_DURATION_MINS");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_MINUTE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "MINUTE_TIME");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_DEFAULT_WAKE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "DEFAULT_WAKE_TIME");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_END_OF_DAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "END_OF_DAY");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__SleepInProgress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<SleepInProgress>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__ElapsedDays_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<ElapsedDays>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__CurrentTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<CurrentTime>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__TimeOnCurrentMinute_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<TimeOnCurrentMinute>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_DefaultTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "DefaultTime");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_DefaultDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "DefaultDay");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_TimeProgressionMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "TimeProgressionMultiplier");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__DailyMinTotal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<DailyMinTotal>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__Playtime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<Playtime>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_savedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "savedTime");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__TimeOverridden_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<TimeOverridden>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onMinutePass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onMinutePass");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onHourPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onHourPass");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onDayPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onDayPass");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onWeekPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onWeekPass");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onUpdate");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onFixedUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onFixedUpdate");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTimeSkip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onTimeSkip");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onTick");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onSleepStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onSleepStart");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__onSleepStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "_onSleepStart");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onSleepEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onSleepEnd");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__onSleepEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "_onSleepEnd");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onFirstNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onFirstNight");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTimeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onTimeChanged");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_SelectedWakeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "SelectedWakeTime");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_sleepStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "sleepStartTime");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_sleepEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "sleepEndTime");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__HostDailySummaryDone_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<HostDailySummaryDone>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_defaultFixedTimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "defaultFixedTimeScale");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "loader");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<HasChanged>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.GameTime.TimeManagerAssembly-CSharp.dll_Excuted");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.GameTime.TimeManagerAssembly-CSharp.dll_Excuted");
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_IsEndOfDay_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666952);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_SleepInProgress_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666953);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_SleepInProgress_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666954);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_ElapsedDays_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666955);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_ElapsedDays_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666956);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_CurrentTime_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666957);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_CurrentTime_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666958);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_TimeOnCurrentMinute_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666959);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_TimeOnCurrentMinute_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666960);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_DailyMinTotal_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666961);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_DailyMinTotal_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666962);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_IsNight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666963);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_DayIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666964);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_NormalizedTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666965);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_Playtime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666966);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_Playtime_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666967);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_CurrentDay_Public_get_EDay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666968);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_TimeOverridden_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666969);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_TimeOverridden_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666970);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_HostDailySummaryDone_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666971);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_HostDailySummaryDone_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666972);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666973);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666974);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666975);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666976);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666977);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666978);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666979);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666980);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666981);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666982);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666983);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666984);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666985);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666986);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Clean_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666987);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SendTimeData_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666988);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetData_Private_Void_NetworkConnection_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666989);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666990);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666991);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_ResetHostSleepDone_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666992);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_MarkHostSleepDone_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666993);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetHostSleepDone_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666994);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_TickLoop_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666995);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_TimeLoop_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666996);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_StaggeredMinPass_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666997);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Tick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666998);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetTime_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666999);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetElapsedDays_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667000);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Get12HourTime_Public_Static_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667001);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Get24HourTimeFromMinSum_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667002);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetMinSumFrom24HourTime_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667003);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_IsCurrentTimeWithinRange_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667004);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_IsGivenTimeWithinRange_Public_Static_Boolean_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667005);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_IsValid24HourTime_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667006);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_IsCurrentDateWithinRange_Public_Boolean_GameDateTime_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667007);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_InvokeDayPassClientSide_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667008);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_InvokeWeekPassClientSide_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667009);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_FastForwardToWakeTime_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667010);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetDateTime_Public_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667011);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetTotalMinSum_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667012);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_AddMinutesTo24HourTime_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667013);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetAllTimeInRange_Public_Static_List_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667014);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetWakeTime_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667015);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_StartSleep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667016);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_EndSleep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667017);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667018);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetPlaytime_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667019);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetTimeOverridden_Public_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667020);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetRandomTime_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667021);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667022);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr__TimeLoop_b__102_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667023);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667024);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667025);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667026);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_SetData_2661156041_Private_Void_NetworkConnection_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667027);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___SetData_2661156041_Private_Void_NetworkConnection_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667028);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_SetData_2661156041_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667029);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Target_SetData_2661156041_Private_Void_NetworkConnection_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667030);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Target_SetData_2661156041_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667031);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Server_ResetHostSleepDone_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667032);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___ResetHostSleepDone_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667033);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Server_ResetHostSleepDone_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667034);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Server_MarkHostSleepDone_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667035);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___MarkHostSleepDone_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667036);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Server_MarkHostSleepDone_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667037);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_SetHostSleepDone_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667038);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___SetHostSleepDone_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667039);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_SetHostSleepDone_1140765316_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667040);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_InvokeDayPassClientSide_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667041);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___InvokeDayPassClientSide_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667042);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_InvokeDayPassClientSide_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667043);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_InvokeWeekPassClientSide_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667044);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___InvokeWeekPassClientSide_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667045);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_InvokeWeekPassClientSide_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667046);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Server_SetWakeTime_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667047);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___SetWakeTime_3316948804_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667048);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Server_SetWakeTime_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667049);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_StartSleep_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667050);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___StartSleep_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667051);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_StartSleep_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667052);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_EndSleep_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667053);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___EndSleep_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667054);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_EndSleep_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667055);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667056);
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x060020C5 RID: 8389 RVA: 0x000D7260 File Offset: 0x000D5460
		public unsafe bool IsEndOfDay
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 109381, RefRangeEnd = 109384, XrefRangeStart = 109381, XrefRangeEnd = 109381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_IsEndOfDay_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x060020C6 RID: 8390 RVA: 0x000D729C File Offset: 0x000D549C
		// (set) Token: 0x060020C7 RID: 8391 RVA: 0x000D72D8 File Offset: 0x000D54D8
		public unsafe bool SleepInProgress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_SleepInProgress_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_SleepInProgress_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x060020C8 RID: 8392 RVA: 0x000D7318 File Offset: 0x000D5518
		// (set) Token: 0x060020C9 RID: 8393 RVA: 0x000D7354 File Offset: 0x000D5554
		public unsafe int ElapsedDays
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_ElapsedDays_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_ElapsedDays_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x060020CA RID: 8394 RVA: 0x000D7394 File Offset: 0x000D5594
		// (set) Token: 0x060020CB RID: 8395 RVA: 0x000D73D0 File Offset: 0x000D55D0
		public unsafe int CurrentTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_CurrentTime_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_CurrentTime_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x060020CC RID: 8396 RVA: 0x000D7410 File Offset: 0x000D5610
		// (set) Token: 0x060020CD RID: 8397 RVA: 0x000D744C File Offset: 0x000D564C
		public unsafe float TimeOnCurrentMinute
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 59144, RefRangeEnd = 59145, XrefRangeStart = 59144, XrefRangeEnd = 59145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_TimeOnCurrentMinute_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_TimeOnCurrentMinute_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x060020CE RID: 8398 RVA: 0x000D748C File Offset: 0x000D568C
		// (set) Token: 0x060020CF RID: 8399 RVA: 0x000D74C8 File Offset: 0x000D56C8
		public unsafe int DailyMinTotal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_DailyMinTotal_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_DailyMinTotal_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x060020D0 RID: 8400 RVA: 0x000D7508 File Offset: 0x000D5708
		public unsafe bool IsNight
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 109384, RefRangeEnd = 109386, XrefRangeStart = 109384, XrefRangeEnd = 109384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_IsNight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x060020D1 RID: 8401 RVA: 0x000D7544 File Offset: 0x000D5744
		public unsafe int DayIndex
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 109386, RefRangeEnd = 109392, XrefRangeStart = 109386, XrefRangeEnd = 109386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_DayIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x060020D2 RID: 8402 RVA: 0x000D7580 File Offset: 0x000D5780
		public unsafe float NormalizedTime
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 109392, RefRangeEnd = 109393, XrefRangeStart = 109392, XrefRangeEnd = 109392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_NormalizedTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x060020D3 RID: 8403 RVA: 0x000D75BC File Offset: 0x000D57BC
		// (set) Token: 0x060020D4 RID: 8404 RVA: 0x000D75F8 File Offset: 0x000D57F8
		public unsafe float Playtime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_Playtime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 109393, RefRangeEnd = 109394, XrefRangeStart = 109393, XrefRangeEnd = 109393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_Playtime_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x060020D5 RID: 8405 RVA: 0x000D7638 File Offset: 0x000D5838
		public unsafe EDay CurrentDay
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 109386, RefRangeEnd = 109392, XrefRangeStart = 109386, XrefRangeEnd = 109392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_CurrentDay_Public_get_EDay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x060020D6 RID: 8406 RVA: 0x000D7674 File Offset: 0x000D5874
		// (set) Token: 0x060020D7 RID: 8407 RVA: 0x000D76B0 File Offset: 0x000D58B0
		public unsafe bool TimeOverridden
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_TimeOverridden_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_TimeOverridden_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x060020D8 RID: 8408 RVA: 0x000D76F0 File Offset: 0x000D58F0
		// (set) Token: 0x060020D9 RID: 8409 RVA: 0x000D772C File Offset: 0x000D592C
		public unsafe bool HostDailySummaryDone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_HostDailySummaryDone_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_HostDailySummaryDone_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x060020DA RID: 8410 RVA: 0x000D776C File Offset: 0x000D596C
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109394, XrefRangeEnd = 109396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x060020DB RID: 8411 RVA: 0x000D77A4 File Offset: 0x000D59A4
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109396, XrefRangeEnd = 109398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x060020DC RID: 8412 RVA: 0x000D77DC File Offset: 0x000D59DC
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x060020DD RID: 8413 RVA: 0x000D781C File Offset: 0x000D5A1C
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(183)]
			[CachedScanResults(RefRangeStart = 35953, RefRangeEnd = 36136, XrefRangeStart = 35953, XrefRangeEnd = 36136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x060020DE RID: 8414 RVA: 0x000D7858 File Offset: 0x000D5A58
		// (set) Token: 0x060020DF RID: 8415 RVA: 0x000D7898 File Offset: 0x000D5A98
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109398, XrefRangeEnd = 109399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x060020E0 RID: 8416 RVA: 0x000D78DC File Offset: 0x000D5ADC
		// (set) Token: 0x060020E1 RID: 8417 RVA: 0x000D791C File Offset: 0x000D5B1C
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109399, XrefRangeEnd = 109400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x060020E2 RID: 8418 RVA: 0x000D7960 File Offset: 0x000D5B60
		// (set) Token: 0x060020E3 RID: 8419 RVA: 0x000D799C File Offset: 0x000D5B9C
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020E4 RID: 8420 RVA: 0x000D79DC File Offset: 0x000D5BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109400, XrefRangeEnd = 109401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E5 RID: 8421 RVA: 0x000D7A18 File Offset: 0x000D5C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109401, XrefRangeEnd = 109407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E6 RID: 8422 RVA: 0x000D7A54 File Offset: 0x000D5C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109407, XrefRangeEnd = 109410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E7 RID: 8423 RVA: 0x000D7AA4 File Offset: 0x000D5CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109410, XrefRangeEnd = 109423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E8 RID: 8424 RVA: 0x000D7AE0 File Offset: 0x000D5CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109423, XrefRangeEnd = 109440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clean()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Clean_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E9 RID: 8425 RVA: 0x000D7B14 File Offset: 0x000D5D14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 109453, RefRangeEnd = 109455, XrefRangeStart = 109440, XrefRangeEnd = 109453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendTimeData(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SendTimeData_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020EA RID: 8426 RVA: 0x000D7B58 File Offset: 0x000D5D58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109505, RefRangeEnd = 109506, XrefRangeStart = 109455, XrefRangeEnd = 109505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData(NetworkConnection conn, int _elapsedDays, int _time, float sendTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _elapsedDays;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _time;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetData_Private_Void_NetworkConnection_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x000D7BC4 File Offset: 0x000D5DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109506, XrefRangeEnd = 109578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020EC RID: 8428 RVA: 0x000D7C00 File Offset: 0x000D5E00
		[CallerCount(0)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020ED RID: 8429 RVA: 0x000D7C3C File Offset: 0x000D5E3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109599, RefRangeEnd = 109600, XrefRangeStart = 109578, XrefRangeEnd = 109599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetHostSleepDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_ResetHostSleepDone_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x000D7C70 File Offset: 0x000D5E70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109621, RefRangeEnd = 109622, XrefRangeStart = 109600, XrefRangeEnd = 109621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkHostSleepDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_MarkHostSleepDone_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020EF RID: 8431 RVA: 0x000D7CA4 File Offset: 0x000D5EA4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 109644, RefRangeEnd = 109650, XrefRangeStart = 109622, XrefRangeEnd = 109644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHostSleepDone(bool done)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref done;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetHostSleepDone_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F0 RID: 8432 RVA: 0x000D7CE4 File Offset: 0x000D5EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109650, XrefRangeEnd = 109655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator TickLoop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_TickLoop_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x000D7D24 File Offset: 0x000D5F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109655, XrefRangeEnd = 109660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator TimeLoop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_TimeLoop_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x000D7D64 File Offset: 0x000D5F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109660, XrefRangeEnd = 109665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator StaggeredMinPass(float staggerTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref staggerTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_StaggeredMinPass_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x000D7DB0 File Offset: 0x000D5FB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 109712, RefRangeEnd = 109714, XrefRangeStart = 109665, XrefRangeEnd = 109712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Tick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Tick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F4 RID: 8436 RVA: 0x000D7DE4 File Offset: 0x000D5FE4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 109728, RefRangeEnd = 109734, XrefRangeStart = 109714, XrefRangeEnd = 109728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTime(int _time, bool local = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _time;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref local;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetTime_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F5 RID: 8437 RVA: 0x000D7E30 File Offset: 0x000D6030
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109747, RefRangeEnd = 109748, XrefRangeStart = 109734, XrefRangeEnd = 109747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetElapsedDays(int days)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref days;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetElapsedDays_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x000D7E70 File Offset: 0x000D6070
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 109776, RefRangeEnd = 109796, XrefRangeStart = 109748, XrefRangeEnd = 109776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Get12HourTime(float _time, bool appendDesignator = true)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _time;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appendDesignator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Get12HourTime_Public_Static_String_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x000D7EB8 File Offset: 0x000D60B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 109796, RefRangeEnd = 109798, XrefRangeStart = 109796, XrefRangeEnd = 109796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Get24HourTimeFromMinSum(int minSum)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minSum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Get24HourTimeFromMinSum_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020F8 RID: 8440 RVA: 0x000D7EF8 File Offset: 0x000D60F8
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 109798, RefRangeEnd = 109819, XrefRangeStart = 109798, XrefRangeEnd = 109798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetMinSumFrom24HourTime(int _time)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetMinSumFrom24HourTime_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x000D7F38 File Offset: 0x000D6138
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 109819, RefRangeEnd = 109861, XrefRangeStart = 109819, XrefRangeEnd = 109819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCurrentTimeWithinRange(int min, int max)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref min;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_IsCurrentTimeWithinRange_Public_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020FA RID: 8442 RVA: 0x000D7F90 File Offset: 0x000D6190
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 109861, RefRangeEnd = 109872, XrefRangeStart = 109861, XrefRangeEnd = 109861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsGivenTimeWithinRange(int givenTime, int min, int max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref givenTime;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_IsGivenTimeWithinRange_Public_Static_Boolean_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020FB RID: 8443 RVA: 0x000D7FEC File Offset: 0x000D61EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109878, RefRangeEnd = 109879, XrefRangeStart = 109872, XrefRangeEnd = 109878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValid24HourTime(string input)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_IsValid24HourTime_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020FC RID: 8444 RVA: 0x000D8030 File Offset: 0x000D6230
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109879, RefRangeEnd = 109880, XrefRangeStart = 109879, XrefRangeEnd = 109879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCurrentDateWithinRange(GameDateTime start, GameDateTime end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_IsCurrentDateWithinRange_Public_Boolean_GameDateTime_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020FD RID: 8445 RVA: 0x000D8088 File Offset: 0x000D6288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109880, XrefRangeEnd = 109898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeDayPassClientSide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_InvokeDayPassClientSide_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020FE RID: 8446 RVA: 0x000D80BC File Offset: 0x000D62BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109898, XrefRangeEnd = 109916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeWeekPassClientSide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_InvokeWeekPassClientSide_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x000D80F0 File Offset: 0x000D62F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109992, RefRangeEnd = 109993, XrefRangeStart = 109916, XrefRangeEnd = 109992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FastForwardToWakeTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_FastForwardToWakeTime_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002100 RID: 8448 RVA: 0x000D8124 File Offset: 0x000D6324
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 109993, RefRangeEnd = 109999, XrefRangeStart = 109993, XrefRangeEnd = 109993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameDateTime GetDateTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetDateTime_Public_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002101 RID: 8449 RVA: 0x000D8160 File Offset: 0x000D6360
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 109999, RefRangeEnd = 110003, XrefRangeStart = 109999, XrefRangeEnd = 109999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTotalMinSum()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetTotalMinSum_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x000D819C File Offset: 0x000D639C
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 110003, RefRangeEnd = 110036, XrefRangeStart = 110003, XrefRangeEnd = 110003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int AddMinutesTo24HourTime(int time, int minsToAdd)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minsToAdd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_AddMinutesTo24HourTime_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x000D81E8 File Offset: 0x000D63E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110036, XrefRangeEnd = 110050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<int> GetAllTimeInRange(int min, int max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref min;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetAllTimeInRange_Public_Static_List_1_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
		}

		// Token: 0x06002104 RID: 8452 RVA: 0x000D8238 File Offset: 0x000D6438
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 110070, RefRangeEnd = 110072, XrefRangeStart = 110050, XrefRangeEnd = 110070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWakeTime(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetWakeTime_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002105 RID: 8453 RVA: 0x000D8278 File Offset: 0x000D6478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110072, XrefRangeEnd = 110093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartSleep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_StartSleep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002106 RID: 8454 RVA: 0x000D82AC File Offset: 0x000D64AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110093, XrefRangeEnd = 110114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndSleep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_EndSleep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002107 RID: 8455 RVA: 0x000D82E0 File Offset: 0x000D64E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110114, XrefRangeEnd = 110120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002108 RID: 8456 RVA: 0x000D8324 File Offset: 0x000D6524
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109393, RefRangeEnd = 109394, XrefRangeStart = 109393, XrefRangeEnd = 109394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlaytime(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetPlaytime_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x000D8364 File Offset: 0x000D6564
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110128, RefRangeEnd = 110129, XrefRangeStart = 110120, XrefRangeEnd = 110128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTimeOverridden(bool overridden, int time = 1200)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overridden;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetTimeOverridden_Public_Void_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600210A RID: 8458 RVA: 0x000D83B0 File Offset: 0x000D65B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110129, XrefRangeEnd = 110131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRandomTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetRandomTime_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600210B RID: 8459 RVA: 0x000D83E4 File Offset: 0x000D65E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110131, XrefRangeEnd = 110151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600210C RID: 8460 RVA: 0x000D8420 File Offset: 0x000D6620
		[CallerCount(0)]
		public unsafe bool _TimeLoop_b__102_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr__TimeLoop_b__102_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600210D RID: 8461 RVA: 0x000D845C File Offset: 0x000D665C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110151, XrefRangeEnd = 110216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x000D8498 File Offset: 0x000D6698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110216, XrefRangeEnd = 110219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600210F RID: 8463 RVA: 0x000D84D4 File Offset: 0x000D66D4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002110 RID: 8464 RVA: 0x000D8510 File Offset: 0x000D6710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110219, XrefRangeEnd = 110242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetData_2661156041(NetworkConnection conn, int _elapsedDays, int _time, float sendTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _elapsedDays;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _time;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_SetData_2661156041_Private_Void_NetworkConnection_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002111 RID: 8465 RVA: 0x000D857C File Offset: 0x000D677C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 110249, RefRangeEnd = 110252, XrefRangeStart = 110242, XrefRangeEnd = 110249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetData_2661156041(NetworkConnection conn, int _elapsedDays, int _time, float sendTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _elapsedDays;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _time;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___SetData_2661156041_Private_Void_NetworkConnection_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002112 RID: 8466 RVA: 0x000D85E8 File Offset: 0x000D67E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110252, XrefRangeEnd = 110260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetData_2661156041(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_SetData_2661156041_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002113 RID: 8467 RVA: 0x000D8638 File Offset: 0x000D6838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110260, XrefRangeEnd = 110274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetData_2661156041(NetworkConnection conn, int _elapsedDays, int _time, float sendTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _elapsedDays;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _time;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Target_SetData_2661156041_Private_Void_NetworkConnection_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002114 RID: 8468 RVA: 0x000D86A4 File Offset: 0x000D68A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110274, XrefRangeEnd = 110282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetData_2661156041(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Target_SetData_2661156041_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002115 RID: 8469 RVA: 0x000D86F4 File Offset: 0x000D68F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110282, XrefRangeEnd = 110300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ResetHostSleepDone_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Server_ResetHostSleepDone_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002116 RID: 8470 RVA: 0x000D8728 File Offset: 0x000D6928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110300, XrefRangeEnd = 110301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ResetHostSleepDone_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___ResetHostSleepDone_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x000D875C File Offset: 0x000D695C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110301, XrefRangeEnd = 110304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ResetHostSleepDone_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Server_ResetHostSleepDone_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002118 RID: 8472 RVA: 0x000D87C0 File Offset: 0x000D69C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110304, XrefRangeEnd = 110322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_MarkHostSleepDone_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Server_MarkHostSleepDone_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002119 RID: 8473 RVA: 0x000D87F4 File Offset: 0x000D69F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110322, XrefRangeEnd = 110323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___MarkHostSleepDone_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___MarkHostSleepDone_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x000D8828 File Offset: 0x000D6A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110323, XrefRangeEnd = 110326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_MarkHostSleepDone_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Server_MarkHostSleepDone_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x000D888C File Offset: 0x000D6A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110326, XrefRangeEnd = 110345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetHostSleepDone_1140765316(bool done)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref done;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_SetHostSleepDone_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x000D88CC File Offset: 0x000D6ACC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 110356, RefRangeEnd = 110358, XrefRangeStart = 110345, XrefRangeEnd = 110356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetHostSleepDone_1140765316(bool done)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref done;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___SetHostSleepDone_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x000D890C File Offset: 0x000D6B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110358, XrefRangeEnd = 110361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetHostSleepDone_1140765316(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_SetHostSleepDone_1140765316_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600211E RID: 8478 RVA: 0x000D895C File Offset: 0x000D6B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_InvokeDayPassClientSide_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_InvokeDayPassClientSide_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600211F RID: 8479 RVA: 0x000D8990 File Offset: 0x000D6B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110361, XrefRangeEnd = 110362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___InvokeDayPassClientSide_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___InvokeDayPassClientSide_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002120 RID: 8480 RVA: 0x000D89C4 File Offset: 0x000D6BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110362, XrefRangeEnd = 110364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_InvokeDayPassClientSide_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_InvokeDayPassClientSide_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002121 RID: 8481 RVA: 0x000D8A14 File Offset: 0x000D6C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_InvokeWeekPassClientSide_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_InvokeWeekPassClientSide_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002122 RID: 8482 RVA: 0x000D8A48 File Offset: 0x000D6C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110364, XrefRangeEnd = 110365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___InvokeWeekPassClientSide_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___InvokeWeekPassClientSide_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002123 RID: 8483 RVA: 0x000D8A7C File Offset: 0x000D6C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110365, XrefRangeEnd = 110367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_InvokeWeekPassClientSide_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_InvokeWeekPassClientSide_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002124 RID: 8484 RVA: 0x000D8ACC File Offset: 0x000D6CCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 110070, RefRangeEnd = 110072, XrefRangeStart = 110070, XrefRangeEnd = 110072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetWakeTime_3316948804(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Server_SetWakeTime_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002125 RID: 8485 RVA: 0x000D8B0C File Offset: 0x000D6D0C
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetWakeTime_3316948804(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___SetWakeTime_3316948804_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002126 RID: 8486 RVA: 0x000D8B4C File Offset: 0x000D6D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110367, XrefRangeEnd = 110371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetWakeTime_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Server_SetWakeTime_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002127 RID: 8487 RVA: 0x000D8BB0 File Offset: 0x000D6DB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110371, XrefRangeEnd = 110389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_StartSleep_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_StartSleep_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002128 RID: 8488 RVA: 0x000D8BE4 File Offset: 0x000D6DE4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 110404, RefRangeEnd = 110409, XrefRangeStart = 110389, XrefRangeEnd = 110404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StartSleep_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___StartSleep_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x000D8C18 File Offset: 0x000D6E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110409, XrefRangeEnd = 110412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_StartSleep_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_StartSleep_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600212A RID: 8490 RVA: 0x000D8C68 File Offset: 0x000D6E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110412, XrefRangeEnd = 110430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_EndSleep_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_EndSleep_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600212B RID: 8491 RVA: 0x000D8C9C File Offset: 0x000D6E9C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 110461, RefRangeEnd = 110464, XrefRangeStart = 110430, XrefRangeEnd = 110461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___EndSleep_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___EndSleep_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600212C RID: 8492 RVA: 0x000D8CD0 File Offset: 0x000D6ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110464, XrefRangeEnd = 110467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_EndSleep_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_EndSleep_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x000D8D20 File Offset: 0x000D6F20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110515, RefRangeEnd = 110516, XrefRangeStart = 110467, XrefRangeEnd = 110515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600212E RID: 8494 RVA: 0x00012716 File Offset: 0x00010916
		public TimeManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x0600212F RID: 8495 RVA: 0x000D8D5C File Offset: 0x000D6F5C
		// (set) Token: 0x06002130 RID: 8496 RVA: 0x0001271F File Offset: 0x0001091F
		public unsafe static float CYCLE_DURATION_MINS
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_CYCLE_DURATION_MINS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_CYCLE_DURATION_MINS, (void*)(&value));
			}
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x06002131 RID: 8497 RVA: 0x000D8D78 File Offset: 0x000D6F78
		// (set) Token: 0x06002132 RID: 8498 RVA: 0x0001272D File Offset: 0x0001092D
		public unsafe static float MINUTE_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_MINUTE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_MINUTE_TIME, (void*)(&value));
			}
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x06002133 RID: 8499 RVA: 0x000D8D94 File Offset: 0x000D6F94
		// (set) Token: 0x06002134 RID: 8500 RVA: 0x0001273B File Offset: 0x0001093B
		public unsafe static int DEFAULT_WAKE_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_DEFAULT_WAKE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_DEFAULT_WAKE_TIME, (void*)(&value));
			}
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06002135 RID: 8501 RVA: 0x000D8DB0 File Offset: 0x000D6FB0
		// (set) Token: 0x06002136 RID: 8502 RVA: 0x00012749 File Offset: 0x00010949
		public unsafe static int END_OF_DAY
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_END_OF_DAY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_END_OF_DAY, (void*)(&value));
			}
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x06002137 RID: 8503 RVA: 0x000D8DCC File Offset: 0x000D6FCC
		// (set) Token: 0x06002138 RID: 8504 RVA: 0x00012757 File Offset: 0x00010957
		public unsafe bool _SleepInProgress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__SleepInProgress_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__SleepInProgress_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x06002139 RID: 8505 RVA: 0x000D8DF4 File Offset: 0x000D6FF4
		// (set) Token: 0x0600213A RID: 8506 RVA: 0x00012772 File Offset: 0x00010972
		public unsafe int _ElapsedDays_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__ElapsedDays_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__ElapsedDays_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x0600213B RID: 8507 RVA: 0x000D8E1C File Offset: 0x000D701C
		// (set) Token: 0x0600213C RID: 8508 RVA: 0x0001278D File Offset: 0x0001098D
		public unsafe int _CurrentTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__CurrentTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__CurrentTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x0600213D RID: 8509 RVA: 0x000D8E44 File Offset: 0x000D7044
		// (set) Token: 0x0600213E RID: 8510 RVA: 0x000127A8 File Offset: 0x000109A8
		public unsafe float _TimeOnCurrentMinute_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__TimeOnCurrentMinute_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__TimeOnCurrentMinute_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x0600213F RID: 8511 RVA: 0x000D8E6C File Offset: 0x000D706C
		// (set) Token: 0x06002140 RID: 8512 RVA: 0x000127C3 File Offset: 0x000109C3
		public unsafe int DefaultTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_DefaultTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_DefaultTime)) = value;
			}
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x06002141 RID: 8513 RVA: 0x000D8E94 File Offset: 0x000D7094
		// (set) Token: 0x06002142 RID: 8514 RVA: 0x000127DE File Offset: 0x000109DE
		public unsafe EDay DefaultDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_DefaultDay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_DefaultDay)) = value;
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x06002143 RID: 8515 RVA: 0x000D8EBC File Offset: 0x000D70BC
		// (set) Token: 0x06002144 RID: 8516 RVA: 0x000127F9 File Offset: 0x000109F9
		public unsafe float TimeProgressionMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_TimeProgressionMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_TimeProgressionMultiplier)) = value;
			}
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x06002145 RID: 8517 RVA: 0x000D8EE4 File Offset: 0x000D70E4
		// (set) Token: 0x06002146 RID: 8518 RVA: 0x00012814 File Offset: 0x00010A14
		public unsafe int _DailyMinTotal_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__DailyMinTotal_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__DailyMinTotal_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x06002147 RID: 8519 RVA: 0x000D8F0C File Offset: 0x000D710C
		// (set) Token: 0x06002148 RID: 8520 RVA: 0x0001282F File Offset: 0x00010A2F
		public unsafe float _Playtime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__Playtime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__Playtime_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x06002149 RID: 8521 RVA: 0x000D8F34 File Offset: 0x000D7134
		// (set) Token: 0x0600214A RID: 8522 RVA: 0x0001284A File Offset: 0x00010A4A
		public unsafe int savedTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_savedTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_savedTime)) = value;
			}
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x0600214B RID: 8523 RVA: 0x000D8F5C File Offset: 0x000D715C
		// (set) Token: 0x0600214C RID: 8524 RVA: 0x00012865 File Offset: 0x00010A65
		public unsafe bool _TimeOverridden_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__TimeOverridden_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__TimeOverridden_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x0600214D RID: 8525 RVA: 0x000D8F84 File Offset: 0x000D7184
		// (set) Token: 0x0600214E RID: 8526 RVA: 0x00012880 File Offset: 0x00010A80
		public unsafe Action onMinutePass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onMinutePass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onMinutePass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x0600214F RID: 8527 RVA: 0x000D8FB4 File Offset: 0x000D71B4
		// (set) Token: 0x06002150 RID: 8528 RVA: 0x0001289F File Offset: 0x00010A9F
		public unsafe Action onHourPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onHourPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onHourPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x06002151 RID: 8529 RVA: 0x000D8FE4 File Offset: 0x000D71E4
		// (set) Token: 0x06002152 RID: 8530 RVA: 0x000128BE File Offset: 0x00010ABE
		public unsafe Action onDayPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onDayPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onDayPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x06002153 RID: 8531 RVA: 0x000D9014 File Offset: 0x000D7214
		// (set) Token: 0x06002154 RID: 8532 RVA: 0x000128DD File Offset: 0x00010ADD
		public unsafe Action onWeekPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onWeekPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onWeekPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x06002155 RID: 8533 RVA: 0x000D9044 File Offset: 0x000D7244
		// (set) Token: 0x06002156 RID: 8534 RVA: 0x000128FC File Offset: 0x00010AFC
		public unsafe Action onUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x06002157 RID: 8535 RVA: 0x000D9074 File Offset: 0x000D7274
		// (set) Token: 0x06002158 RID: 8536 RVA: 0x0001291B File Offset: 0x00010B1B
		public unsafe Action onFixedUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onFixedUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onFixedUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x06002159 RID: 8537 RVA: 0x000D90A4 File Offset: 0x000D72A4
		// (set) Token: 0x0600215A RID: 8538 RVA: 0x0001293A File Offset: 0x00010B3A
		public unsafe Action<int> onTimeSkip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTimeSkip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTimeSkip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x0600215B RID: 8539 RVA: 0x000D90D4 File Offset: 0x000D72D4
		// (set) Token: 0x0600215C RID: 8540 RVA: 0x00012959 File Offset: 0x00010B59
		public unsafe Action onTick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTick);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTick), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x0600215D RID: 8541 RVA: 0x000D9104 File Offset: 0x000D7304
		// (set) Token: 0x0600215E RID: 8542 RVA: 0x00012978 File Offset: 0x00010B78
		public unsafe static Action onSleepStart
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onSleepStart, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onSleepStart, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x0600215F RID: 8543 RVA: 0x000D912C File Offset: 0x000D732C
		// (set) Token: 0x06002160 RID: 8544 RVA: 0x0001298A File Offset: 0x00010B8A
		public unsafe UnityEvent _onSleepStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__onSleepStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__onSleepStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x06002161 RID: 8545 RVA: 0x000D915C File Offset: 0x000D735C
		// (set) Token: 0x06002162 RID: 8546 RVA: 0x000129A9 File Offset: 0x00010BA9
		public unsafe static Action<int> onSleepEnd
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onSleepEnd, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onSleepEnd, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x06002163 RID: 8547 RVA: 0x000D9184 File Offset: 0x000D7384
		// (set) Token: 0x06002164 RID: 8548 RVA: 0x000129BB File Offset: 0x00010BBB
		public unsafe UnityEvent _onSleepEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__onSleepEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__onSleepEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x06002165 RID: 8549 RVA: 0x000D91B4 File Offset: 0x000D73B4
		// (set) Token: 0x06002166 RID: 8550 RVA: 0x000129DA File Offset: 0x00010BDA
		public unsafe UnityEvent onFirstNight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onFirstNight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onFirstNight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x06002167 RID: 8551 RVA: 0x000D91E4 File Offset: 0x000D73E4
		// (set) Token: 0x06002168 RID: 8552 RVA: 0x000129F9 File Offset: 0x00010BF9
		public unsafe Action onTimeChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTimeChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTimeChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x06002169 RID: 8553 RVA: 0x000D9214 File Offset: 0x000D7414
		// (set) Token: 0x0600216A RID: 8554 RVA: 0x00012A18 File Offset: 0x00010C18
		public unsafe static int SelectedWakeTime
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_SelectedWakeTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_SelectedWakeTime, (void*)(&value));
			}
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x0600216B RID: 8555 RVA: 0x000D9230 File Offset: 0x000D7430
		// (set) Token: 0x0600216C RID: 8556 RVA: 0x00012A26 File Offset: 0x00010C26
		public unsafe GameDateTime sleepStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_sleepStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_sleepStartTime)) = value;
			}
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x0600216D RID: 8557 RVA: 0x000D9258 File Offset: 0x000D7458
		// (set) Token: 0x0600216E RID: 8558 RVA: 0x00012A41 File Offset: 0x00010C41
		public unsafe int sleepEndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_sleepEndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_sleepEndTime)) = value;
			}
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x0600216F RID: 8559 RVA: 0x000D9280 File Offset: 0x000D7480
		// (set) Token: 0x06002170 RID: 8560 RVA: 0x00012A5C File Offset: 0x00010C5C
		public unsafe bool _HostDailySummaryDone_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__HostDailySummaryDone_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__HostDailySummaryDone_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06002171 RID: 8561 RVA: 0x000D92A8 File Offset: 0x000D74A8
		// (set) Token: 0x06002172 RID: 8562 RVA: 0x00012A77 File Offset: 0x00010C77
		public unsafe float defaultFixedTimeScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_defaultFixedTimeScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_defaultFixedTimeScale)) = value;
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x06002173 RID: 8563 RVA: 0x000D92D0 File Offset: 0x000D74D0
		// (set) Token: 0x06002174 RID: 8564 RVA: 0x00012A92 File Offset: 0x00010C92
		public unsafe TimeLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x06002175 RID: 8565 RVA: 0x000D9300 File Offset: 0x000D7500
		// (set) Token: 0x06002176 RID: 8566 RVA: 0x00012AB1 File Offset: 0x00010CB1
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x06002177 RID: 8567 RVA: 0x000D9330 File Offset: 0x000D7530
		// (set) Token: 0x06002178 RID: 8568 RVA: 0x00012AD0 File Offset: 0x00010CD0
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06002179 RID: 8569 RVA: 0x000D9360 File Offset: 0x000D7560
		// (set) Token: 0x0600217A RID: 8570 RVA: 0x00012AEF File Offset: 0x00010CEF
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x0600217B RID: 8571 RVA: 0x000D9388 File Offset: 0x000D7588
		// (set) Token: 0x0600217C RID: 8572 RVA: 0x00012B0A File Offset: 0x00010D0A
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x0600217D RID: 8573 RVA: 0x000D93B0 File Offset: 0x000D75B0
		// (set) Token: 0x0600217E RID: 8574 RVA: 0x00012B25 File Offset: 0x00010D25
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040015C1 RID: 5569
		private static readonly IntPtr NativeFieldInfoPtr_CYCLE_DURATION_MINS;

		// Token: 0x040015C2 RID: 5570
		private static readonly IntPtr NativeFieldInfoPtr_MINUTE_TIME;

		// Token: 0x040015C3 RID: 5571
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_WAKE_TIME;

		// Token: 0x040015C4 RID: 5572
		private static readonly IntPtr NativeFieldInfoPtr_END_OF_DAY;

		// Token: 0x040015C5 RID: 5573
		private static readonly IntPtr NativeFieldInfoPtr__SleepInProgress_k__BackingField;

		// Token: 0x040015C6 RID: 5574
		private static readonly IntPtr NativeFieldInfoPtr__ElapsedDays_k__BackingField;

		// Token: 0x040015C7 RID: 5575
		private static readonly IntPtr NativeFieldInfoPtr__CurrentTime_k__BackingField;

		// Token: 0x040015C8 RID: 5576
		private static readonly IntPtr NativeFieldInfoPtr__TimeOnCurrentMinute_k__BackingField;

		// Token: 0x040015C9 RID: 5577
		private static readonly IntPtr NativeFieldInfoPtr_DefaultTime;

		// Token: 0x040015CA RID: 5578
		private static readonly IntPtr NativeFieldInfoPtr_DefaultDay;

		// Token: 0x040015CB RID: 5579
		private static readonly IntPtr NativeFieldInfoPtr_TimeProgressionMultiplier;

		// Token: 0x040015CC RID: 5580
		private static readonly IntPtr NativeFieldInfoPtr__DailyMinTotal_k__BackingField;

		// Token: 0x040015CD RID: 5581
		private static readonly IntPtr NativeFieldInfoPtr__Playtime_k__BackingField;

		// Token: 0x040015CE RID: 5582
		private static readonly IntPtr NativeFieldInfoPtr_savedTime;

		// Token: 0x040015CF RID: 5583
		private static readonly IntPtr NativeFieldInfoPtr__TimeOverridden_k__BackingField;

		// Token: 0x040015D0 RID: 5584
		private static readonly IntPtr NativeFieldInfoPtr_onMinutePass;

		// Token: 0x040015D1 RID: 5585
		private static readonly IntPtr NativeFieldInfoPtr_onHourPass;

		// Token: 0x040015D2 RID: 5586
		private static readonly IntPtr NativeFieldInfoPtr_onDayPass;

		// Token: 0x040015D3 RID: 5587
		private static readonly IntPtr NativeFieldInfoPtr_onWeekPass;

		// Token: 0x040015D4 RID: 5588
		private static readonly IntPtr NativeFieldInfoPtr_onUpdate;

		// Token: 0x040015D5 RID: 5589
		private static readonly IntPtr NativeFieldInfoPtr_onFixedUpdate;

		// Token: 0x040015D6 RID: 5590
		private static readonly IntPtr NativeFieldInfoPtr_onTimeSkip;

		// Token: 0x040015D7 RID: 5591
		private static readonly IntPtr NativeFieldInfoPtr_onTick;

		// Token: 0x040015D8 RID: 5592
		private static readonly IntPtr NativeFieldInfoPtr_onSleepStart;

		// Token: 0x040015D9 RID: 5593
		private static readonly IntPtr NativeFieldInfoPtr__onSleepStart;

		// Token: 0x040015DA RID: 5594
		private static readonly IntPtr NativeFieldInfoPtr_onSleepEnd;

		// Token: 0x040015DB RID: 5595
		private static readonly IntPtr NativeFieldInfoPtr__onSleepEnd;

		// Token: 0x040015DC RID: 5596
		private static readonly IntPtr NativeFieldInfoPtr_onFirstNight;

		// Token: 0x040015DD RID: 5597
		private static readonly IntPtr NativeFieldInfoPtr_onTimeChanged;

		// Token: 0x040015DE RID: 5598
		private static readonly IntPtr NativeFieldInfoPtr_SelectedWakeTime;

		// Token: 0x040015DF RID: 5599
		private static readonly IntPtr NativeFieldInfoPtr_sleepStartTime;

		// Token: 0x040015E0 RID: 5600
		private static readonly IntPtr NativeFieldInfoPtr_sleepEndTime;

		// Token: 0x040015E1 RID: 5601
		private static readonly IntPtr NativeFieldInfoPtr__HostDailySummaryDone_k__BackingField;

		// Token: 0x040015E2 RID: 5602
		private static readonly IntPtr NativeFieldInfoPtr_defaultFixedTimeScale;

		// Token: 0x040015E3 RID: 5603
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x040015E4 RID: 5604
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x040015E5 RID: 5605
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x040015E6 RID: 5606
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x040015E7 RID: 5607
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040015E8 RID: 5608
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040015E9 RID: 5609
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEndOfDay_Public_get_Boolean_0;

		// Token: 0x040015EA RID: 5610
		private static readonly IntPtr NativeMethodInfoPtr_get_SleepInProgress_Public_get_Boolean_0;

		// Token: 0x040015EB RID: 5611
		private static readonly IntPtr NativeMethodInfoPtr_set_SleepInProgress_Protected_set_Void_Boolean_0;

		// Token: 0x040015EC RID: 5612
		private static readonly IntPtr NativeMethodInfoPtr_get_ElapsedDays_Public_get_Int32_0;

		// Token: 0x040015ED RID: 5613
		private static readonly IntPtr NativeMethodInfoPtr_set_ElapsedDays_Protected_set_Void_Int32_0;

		// Token: 0x040015EE RID: 5614
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentTime_Public_get_Int32_0;

		// Token: 0x040015EF RID: 5615
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentTime_Protected_set_Void_Int32_0;

		// Token: 0x040015F0 RID: 5616
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeOnCurrentMinute_Public_get_Single_0;

		// Token: 0x040015F1 RID: 5617
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeOnCurrentMinute_Protected_set_Void_Single_0;

		// Token: 0x040015F2 RID: 5618
		private static readonly IntPtr NativeMethodInfoPtr_get_DailyMinTotal_Public_get_Int32_0;

		// Token: 0x040015F3 RID: 5619
		private static readonly IntPtr NativeMethodInfoPtr_set_DailyMinTotal_Protected_set_Void_Int32_0;

		// Token: 0x040015F4 RID: 5620
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNight_Public_get_Boolean_0;

		// Token: 0x040015F5 RID: 5621
		private static readonly IntPtr NativeMethodInfoPtr_get_DayIndex_Public_get_Int32_0;

		// Token: 0x040015F6 RID: 5622
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedTime_Public_get_Single_0;

		// Token: 0x040015F7 RID: 5623
		private static readonly IntPtr NativeMethodInfoPtr_get_Playtime_Public_get_Single_0;

		// Token: 0x040015F8 RID: 5624
		private static readonly IntPtr NativeMethodInfoPtr_set_Playtime_Protected_set_Void_Single_0;

		// Token: 0x040015F9 RID: 5625
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentDay_Public_get_EDay_0;

		// Token: 0x040015FA RID: 5626
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeOverridden_Public_get_Boolean_0;

		// Token: 0x040015FB RID: 5627
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeOverridden_Protected_set_Void_Boolean_0;

		// Token: 0x040015FC RID: 5628
		private static readonly IntPtr NativeMethodInfoPtr_get_HostDailySummaryDone_Public_get_Boolean_0;

		// Token: 0x040015FD RID: 5629
		private static readonly IntPtr NativeMethodInfoPtr_set_HostDailySummaryDone_Private_set_Void_Boolean_0;

		// Token: 0x040015FE RID: 5630
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040015FF RID: 5631
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04001600 RID: 5632
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04001601 RID: 5633
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001602 RID: 5634
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04001603 RID: 5635
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04001604 RID: 5636
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04001605 RID: 5637
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04001606 RID: 5638
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001607 RID: 5639
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04001608 RID: 5640
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04001609 RID: 5641
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x0400160A RID: 5642
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x0400160B RID: 5643
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x0400160C RID: 5644
		private static readonly IntPtr NativeMethodInfoPtr_Clean_Private_Void_0;

		// Token: 0x0400160D RID: 5645
		private static readonly IntPtr NativeMethodInfoPtr_SendTimeData_Public_Void_NetworkConnection_0;

		// Token: 0x0400160E RID: 5646
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Private_Void_NetworkConnection_Int32_Int32_Single_0;

		// Token: 0x0400160F RID: 5647
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04001610 RID: 5648
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04001611 RID: 5649
		private static readonly IntPtr NativeMethodInfoPtr_ResetHostSleepDone_Public_Void_0;

		// Token: 0x04001612 RID: 5650
		private static readonly IntPtr NativeMethodInfoPtr_MarkHostSleepDone_Public_Void_0;

		// Token: 0x04001613 RID: 5651
		private static readonly IntPtr NativeMethodInfoPtr_SetHostSleepDone_Private_Void_Boolean_0;

		// Token: 0x04001614 RID: 5652
		private static readonly IntPtr NativeMethodInfoPtr_TickLoop_Private_IEnumerator_0;

		// Token: 0x04001615 RID: 5653
		private static readonly IntPtr NativeMethodInfoPtr_TimeLoop_Private_IEnumerator_0;

		// Token: 0x04001616 RID: 5654
		private static readonly IntPtr NativeMethodInfoPtr_StaggeredMinPass_Private_IEnumerator_Single_0;

		// Token: 0x04001617 RID: 5655
		private static readonly IntPtr NativeMethodInfoPtr_Tick_Private_Void_0;

		// Token: 0x04001618 RID: 5656
		private static readonly IntPtr NativeMethodInfoPtr_SetTime_Public_Void_Int32_Boolean_0;

		// Token: 0x04001619 RID: 5657
		private static readonly IntPtr NativeMethodInfoPtr_SetElapsedDays_Public_Void_Int32_0;

		// Token: 0x0400161A RID: 5658
		private static readonly IntPtr NativeMethodInfoPtr_Get12HourTime_Public_Static_String_Single_Boolean_0;

		// Token: 0x0400161B RID: 5659
		private static readonly IntPtr NativeMethodInfoPtr_Get24HourTimeFromMinSum_Public_Static_Int32_Int32_0;

		// Token: 0x0400161C RID: 5660
		private static readonly IntPtr NativeMethodInfoPtr_GetMinSumFrom24HourTime_Public_Static_Int32_Int32_0;

		// Token: 0x0400161D RID: 5661
		private static readonly IntPtr NativeMethodInfoPtr_IsCurrentTimeWithinRange_Public_Boolean_Int32_Int32_0;

		// Token: 0x0400161E RID: 5662
		private static readonly IntPtr NativeMethodInfoPtr_IsGivenTimeWithinRange_Public_Static_Boolean_Int32_Int32_Int32_0;

		// Token: 0x0400161F RID: 5663
		private static readonly IntPtr NativeMethodInfoPtr_IsValid24HourTime_Public_Static_Boolean_String_0;

		// Token: 0x04001620 RID: 5664
		private static readonly IntPtr NativeMethodInfoPtr_IsCurrentDateWithinRange_Public_Boolean_GameDateTime_GameDateTime_0;

		// Token: 0x04001621 RID: 5665
		private static readonly IntPtr NativeMethodInfoPtr_InvokeDayPassClientSide_Private_Void_0;

		// Token: 0x04001622 RID: 5666
		private static readonly IntPtr NativeMethodInfoPtr_InvokeWeekPassClientSide_Private_Void_0;

		// Token: 0x04001623 RID: 5667
		private static readonly IntPtr NativeMethodInfoPtr_FastForwardToWakeTime_Public_Void_0;

		// Token: 0x04001624 RID: 5668
		private static readonly IntPtr NativeMethodInfoPtr_GetDateTime_Public_GameDateTime_0;

		// Token: 0x04001625 RID: 5669
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalMinSum_Public_Int32_0;

		// Token: 0x04001626 RID: 5670
		private static readonly IntPtr NativeMethodInfoPtr_AddMinutesTo24HourTime_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x04001627 RID: 5671
		private static readonly IntPtr NativeMethodInfoPtr_GetAllTimeInRange_Public_Static_List_1_Int32_Int32_Int32_0;

		// Token: 0x04001628 RID: 5672
		private static readonly IntPtr NativeMethodInfoPtr_SetWakeTime_Public_Void_Int32_0;

		// Token: 0x04001629 RID: 5673
		private static readonly IntPtr NativeMethodInfoPtr_StartSleep_Private_Void_0;

		// Token: 0x0400162A RID: 5674
		private static readonly IntPtr NativeMethodInfoPtr_EndSleep_Private_Void_0;

		// Token: 0x0400162B RID: 5675
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x0400162C RID: 5676
		private static readonly IntPtr NativeMethodInfoPtr_SetPlaytime_Public_Void_Single_0;

		// Token: 0x0400162D RID: 5677
		private static readonly IntPtr NativeMethodInfoPtr_SetTimeOverridden_Public_Void_Boolean_Int32_0;

		// Token: 0x0400162E RID: 5678
		private static readonly IntPtr NativeMethodInfoPtr_SetRandomTime_Private_Void_0;

		// Token: 0x0400162F RID: 5679
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001630 RID: 5680
		private static readonly IntPtr NativeMethodInfoPtr__TimeLoop_b__102_0_Private_Boolean_0;

		// Token: 0x04001631 RID: 5681
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04001632 RID: 5682
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04001633 RID: 5683
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04001634 RID: 5684
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetData_2661156041_Private_Void_NetworkConnection_Int32_Int32_Single_0;

		// Token: 0x04001635 RID: 5685
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetData_2661156041_Private_Void_NetworkConnection_Int32_Int32_Single_0;

		// Token: 0x04001636 RID: 5686
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetData_2661156041_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001637 RID: 5687
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetData_2661156041_Private_Void_NetworkConnection_Int32_Int32_Single_0;

		// Token: 0x04001638 RID: 5688
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetData_2661156041_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001639 RID: 5689
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ResetHostSleepDone_2166136261_Private_Void_0;

		// Token: 0x0400163A RID: 5690
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ResetHostSleepDone_2166136261_Public_Void_0;

		// Token: 0x0400163B RID: 5691
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ResetHostSleepDone_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400163C RID: 5692
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_MarkHostSleepDone_2166136261_Private_Void_0;

		// Token: 0x0400163D RID: 5693
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___MarkHostSleepDone_2166136261_Public_Void_0;

		// Token: 0x0400163E RID: 5694
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_MarkHostSleepDone_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400163F RID: 5695
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetHostSleepDone_1140765316_Private_Void_Boolean_0;

		// Token: 0x04001640 RID: 5696
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetHostSleepDone_1140765316_Private_Void_Boolean_0;

		// Token: 0x04001641 RID: 5697
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetHostSleepDone_1140765316_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001642 RID: 5698
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_InvokeDayPassClientSide_2166136261_Private_Void_0;

		// Token: 0x04001643 RID: 5699
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___InvokeDayPassClientSide_2166136261_Private_Void_0;

		// Token: 0x04001644 RID: 5700
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_InvokeDayPassClientSide_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001645 RID: 5701
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_InvokeWeekPassClientSide_2166136261_Private_Void_0;

		// Token: 0x04001646 RID: 5702
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___InvokeWeekPassClientSide_2166136261_Private_Void_0;

		// Token: 0x04001647 RID: 5703
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_InvokeWeekPassClientSide_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001648 RID: 5704
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetWakeTime_3316948804_Private_Void_Int32_0;

		// Token: 0x04001649 RID: 5705
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetWakeTime_3316948804_Public_Void_Int32_0;

		// Token: 0x0400164A RID: 5706
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetWakeTime_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400164B RID: 5707
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_StartSleep_2166136261_Private_Void_0;

		// Token: 0x0400164C RID: 5708
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StartSleep_2166136261_Private_Void_0;

		// Token: 0x0400164D RID: 5709
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_StartSleep_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400164E RID: 5710
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_EndSleep_2166136261_Private_Void_0;

		// Token: 0x0400164F RID: 5711
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___EndSleep_2166136261_Private_Void_0;

		// Token: 0x04001650 RID: 5712
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_EndSleep_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001651 RID: 5713
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x020008BA RID: 2234
		[ObfuscatedName("ScheduleOne.GameTime.TimeManager+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600C344 RID: 49988 RVA: 0x002FA514 File Offset: 0x002F8714
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr);
				Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr, "<>9");
				Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9__101_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr, "<>9__101_0");
				Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9__102_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr, "<>9__102_1");
				Il2CppScheduleOne.GameTime.TimeManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr, 100667058);
				Il2CppScheduleOne.GameTime.TimeManager.__c.NativeMethodInfoPtr__TickLoop_b__101_0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr, 100667059);
				Il2CppScheduleOne.GameTime.TimeManager.__c.NativeMethodInfoPtr__TimeLoop_b__102_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr, 100667060);
			}

			// Token: 0x0600C345 RID: 49989 RVA: 0x002FA5B8 File Offset: 0x002F87B8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C346 RID: 49990 RVA: 0x002FA5F4 File Offset: 0x002F87F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109259, XrefRangeEnd = 109260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TickLoop_b__101_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeMethodInfoPtr__TickLoop_b__101_0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C347 RID: 49991 RVA: 0x002FA630 File Offset: 0x002F8830
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TimeLoop_b__102_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeMethodInfoPtr__TimeLoop_b__102_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C348 RID: 49992 RVA: 0x0005F081 File Offset: 0x0005D281
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CF6 RID: 15606
			// (get) Token: 0x0600C349 RID: 49993 RVA: 0x002FA66C File Offset: 0x002F886C
			// (set) Token: 0x0600C34A RID: 49994 RVA: 0x0005F08A File Offset: 0x0005D28A
			public unsafe static TimeManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CF7 RID: 15607
			// (get) Token: 0x0600C34B RID: 49995 RVA: 0x002FA694 File Offset: 0x002F8894
			// (set) Token: 0x0600C34C RID: 49996 RVA: 0x0005F09C File Offset: 0x0005D29C
			public unsafe static Func<bool> __9__101_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9__101_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9__101_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CF8 RID: 15608
			// (get) Token: 0x0600C34D RID: 49997 RVA: 0x002FA6BC File Offset: 0x002F88BC
			// (set) Token: 0x0600C34E RID: 49998 RVA: 0x0005F0AE File Offset: 0x0005D2AE
			public unsafe static Func<bool> __9__102_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9__102_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9__102_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400846F RID: 33903
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008470 RID: 33904
			private static readonly IntPtr NativeFieldInfoPtr___9__101_0;

			// Token: 0x04008471 RID: 33905
			private static readonly IntPtr NativeFieldInfoPtr___9__102_1;

			// Token: 0x04008472 RID: 33906
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008473 RID: 33907
			private static readonly IntPtr NativeMethodInfoPtr__TickLoop_b__101_0_Internal_Boolean_0;

			// Token: 0x04008474 RID: 33908
			private static readonly IntPtr NativeMethodInfoPtr__TimeLoop_b__102_1_Internal_Boolean_0;
		}

		// Token: 0x020008BB RID: 2235
		[ObfuscatedName("ScheduleOne.GameTime.TimeManager+<>c__DisplayClass94_0")]
		public sealed class __c__DisplayClass94_0 : Object
		{
			// Token: 0x0600C34F RID: 49999 RVA: 0x002FA6E4 File Offset: 0x002F88E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass94_0()
			{
				Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<>c__DisplayClass94_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0>.NativeClassPtr);
				Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeFieldInfoPtr_connection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0>.NativeClassPtr, "connection");
				Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0>.NativeClassPtr, "<>4__this");
				Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0>.NativeClassPtr, 100667061);
				Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0>.NativeClassPtr, 100667062);
				Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeMethodInfoPtr__SendTimeData_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0>.NativeClassPtr, 100667063);
			}

			// Token: 0x0600C350 RID: 50000 RVA: 0x002FA774 File Offset: 0x002F8974
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass94_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C351 RID: 50001 RVA: 0x002FA7B0 File Offset: 0x002F89B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109277, XrefRangeEnd = 109282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C352 RID: 50002 RVA: 0x002FA7F0 File Offset: 0x002F89F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109282, XrefRangeEnd = 109290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SendTimeData_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeMethodInfoPtr__SendTimeData_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C353 RID: 50003 RVA: 0x0005F0C0 File Offset: 0x0005D2C0
			public __c__DisplayClass94_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CF9 RID: 15609
			// (get) Token: 0x0600C354 RID: 50004 RVA: 0x002FA82C File Offset: 0x002F8A2C
			// (set) Token: 0x0600C355 RID: 50005 RVA: 0x0005F0C9 File Offset: 0x0005D2C9
			public unsafe NetworkConnection connection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeFieldInfoPtr_connection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkConnection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeFieldInfoPtr_connection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CFA RID: 15610
			// (get) Token: 0x0600C356 RID: 50006 RVA: 0x002FA85C File Offset: 0x002F8A5C
			// (set) Token: 0x0600C357 RID: 50007 RVA: 0x0005F0E8 File Offset: 0x0005D2E8
			public unsafe TimeManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008475 RID: 33909
			private static readonly IntPtr NativeFieldInfoPtr_connection;

			// Token: 0x04008476 RID: 33910
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008477 RID: 33911
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008478 RID: 33912
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008479 RID: 33913
			private static readonly IntPtr NativeMethodInfoPtr__SendTimeData_b__1_Internal_Boolean_0;

			// Token: 0x02000C31 RID: 3121
			[ObfuscatedName("ScheduleOne.GameTime.TimeManager+<>c__DisplayClass94_0+<<SendTimeData>g__WaitForPlayerReady|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Object
			{
				// Token: 0x0600E145 RID: 57669 RVA: 0x0034F534 File Offset: 0x0034D734
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0>.NativeClassPtr, "<<SendTimeData>g__WaitForPlayerReady|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667064);
					Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667065);
					Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667066);
					Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667067);
					Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667068);
					Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667069);
				}

				// Token: 0x0600E146 RID: 57670 RVA: 0x0034F614 File Offset: 0x0034D814
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E147 RID: 57671 RVA: 0x0034F65C File Offset: 0x0034D85C
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E148 RID: 57672 RVA: 0x0034F690 File Offset: 0x0034D890
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109260, XrefRangeEnd = 109272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170045CB RID: 17867
				// (get) Token: 0x0600E149 RID: 57673 RVA: 0x0034F6CC File Offset: 0x0034D8CC
				public unsafe Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E14A RID: 57674 RVA: 0x0034F70C File Offset: 0x0034D90C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109272, XrefRangeEnd = 109277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170045CC RID: 17868
				// (get) Token: 0x0600E14B RID: 57675 RVA: 0x0034F740 File Offset: 0x0034D940
				public unsafe Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E14C RID: 57676 RVA: 0x0006DD60 File Offset: 0x0006BF60
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170045C8 RID: 17864
				// (get) Token: 0x0600E14D RID: 57677 RVA: 0x0034F780 File Offset: 0x0034D980
				// (set) Token: 0x0600E14E RID: 57678 RVA: 0x0006DD69 File Offset: 0x0006BF69
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170045C9 RID: 17865
				// (get) Token: 0x0600E14F RID: 57679 RVA: 0x0034F7A8 File Offset: 0x0034D9A8
				// (set) Token: 0x0600E150 RID: 57680 RVA: 0x0006DD84 File Offset: 0x0006BF84
				public unsafe Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045CA RID: 17866
				// (get) Token: 0x0600E151 RID: 57681 RVA: 0x0034F7D8 File Offset: 0x0034D9D8
				// (set) Token: 0x0600E152 RID: 57682 RVA: 0x0006DDA3 File Offset: 0x0006BFA3
				public unsafe TimeManager.__c__DisplayClass94_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeManager.__c__DisplayClass94_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040096D6 RID: 38614
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040096D7 RID: 38615
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040096D8 RID: 38616
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040096D9 RID: 38617
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040096DA RID: 38618
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040096DB RID: 38619
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040096DC RID: 38620
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040096DD RID: 38621
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040096DE RID: 38622
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020008BC RID: 2236
		[ObfuscatedName("ScheduleOne.GameTime.TimeManager+<StaggeredMinPass>d__103")]
		public sealed class _StaggeredMinPass_d__103 : Object
		{
			// Token: 0x0600C358 RID: 50008 RVA: 0x002FA88C File Offset: 0x002F8A8C
			// Note: this type is marked as 'beforefieldinit'.
			static _StaggeredMinPass_d__103()
			{
				Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<StaggeredMinPass>d__103");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr);
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, "<>1__state");
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, "<>2__current");
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, "<>4__this");
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr_staggerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, "staggerTime");
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__listeners_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, "<listeners>5__2");
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__perDelay_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, "<perDelay>5__3");
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__startTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, "<startTime>5__4");
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__waitOverflow_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, "<waitOverflow>5__5");
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__timeOnWaitStart_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, "<timeOnWaitStart>5__6");
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__loopsSinceLastWait_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, "<loopsSinceLastWait>5__7");
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__i_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, "<i>5__8");
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, 100667070);
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, 100667071);
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, 100667072);
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, 100667073);
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, 100667074);
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, 100667075);
			}

			// Token: 0x0600C359 RID: 50009 RVA: 0x002FAA0C File Offset: 0x002F8C0C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _StaggeredMinPass_d__103(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C35A RID: 50010 RVA: 0x002FAA54 File Offset: 0x002F8C54
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C35B RID: 50011 RVA: 0x002FAA88 File Offset: 0x002F8C88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109290, XrefRangeEnd = 109317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003D06 RID: 15622
			// (get) Token: 0x0600C35C RID: 50012 RVA: 0x002FAAC4 File Offset: 0x002F8CC4
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C35D RID: 50013 RVA: 0x002FAB04 File Offset: 0x002F8D04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109317, XrefRangeEnd = 109322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003D07 RID: 15623
			// (get) Token: 0x0600C35E RID: 50014 RVA: 0x002FAB38 File Offset: 0x002F8D38
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C35F RID: 50015 RVA: 0x0005F107 File Offset: 0x0005D307
			public _StaggeredMinPass_d__103(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CFB RID: 15611
			// (get) Token: 0x0600C360 RID: 50016 RVA: 0x002FAB78 File Offset: 0x002F8D78
			// (set) Token: 0x0600C361 RID: 50017 RVA: 0x0005F110 File Offset: 0x0005D310
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003CFC RID: 15612
			// (get) Token: 0x0600C362 RID: 50018 RVA: 0x002FABA0 File Offset: 0x002F8DA0
			// (set) Token: 0x0600C363 RID: 50019 RVA: 0x0005F12B File Offset: 0x0005D32B
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CFD RID: 15613
			// (get) Token: 0x0600C364 RID: 50020 RVA: 0x002FABD0 File Offset: 0x002F8DD0
			// (set) Token: 0x0600C365 RID: 50021 RVA: 0x0005F14A File Offset: 0x0005D34A
			public unsafe TimeManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CFE RID: 15614
			// (get) Token: 0x0600C366 RID: 50022 RVA: 0x002FAC00 File Offset: 0x002F8E00
			// (set) Token: 0x0600C367 RID: 50023 RVA: 0x0005F169 File Offset: 0x0005D369
			public unsafe float staggerTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr_staggerTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr_staggerTime)) = value;
				}
			}

			// Token: 0x17003CFF RID: 15615
			// (get) Token: 0x0600C368 RID: 50024 RVA: 0x002FAC28 File Offset: 0x002F8E28
			// (set) Token: 0x0600C369 RID: 50025 RVA: 0x0005F184 File Offset: 0x0005D384
			public unsafe Il2CppReferenceArray<Delegate> _listeners_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__listeners_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Delegate>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__listeners_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D00 RID: 15616
			// (get) Token: 0x0600C36A RID: 50026 RVA: 0x002FAC58 File Offset: 0x002F8E58
			// (set) Token: 0x0600C36B RID: 50027 RVA: 0x0005F1A3 File Offset: 0x0005D3A3
			public unsafe float _perDelay_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__perDelay_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__perDelay_5__3)) = value;
				}
			}

			// Token: 0x17003D01 RID: 15617
			// (get) Token: 0x0600C36C RID: 50028 RVA: 0x002FAC80 File Offset: 0x002F8E80
			// (set) Token: 0x0600C36D RID: 50029 RVA: 0x0005F1BE File Offset: 0x0005D3BE
			public unsafe float _startTime_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__startTime_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__startTime_5__4)) = value;
				}
			}

			// Token: 0x17003D02 RID: 15618
			// (get) Token: 0x0600C36E RID: 50030 RVA: 0x002FACA8 File Offset: 0x002F8EA8
			// (set) Token: 0x0600C36F RID: 50031 RVA: 0x0005F1D9 File Offset: 0x0005D3D9
			public unsafe float _waitOverflow_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__waitOverflow_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__waitOverflow_5__5)) = value;
				}
			}

			// Token: 0x17003D03 RID: 15619
			// (get) Token: 0x0600C370 RID: 50032 RVA: 0x002FACD0 File Offset: 0x002F8ED0
			// (set) Token: 0x0600C371 RID: 50033 RVA: 0x0005F1F4 File Offset: 0x0005D3F4
			public unsafe float _timeOnWaitStart_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__timeOnWaitStart_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__timeOnWaitStart_5__6)) = value;
				}
			}

			// Token: 0x17003D04 RID: 15620
			// (get) Token: 0x0600C372 RID: 50034 RVA: 0x002FACF8 File Offset: 0x002F8EF8
			// (set) Token: 0x0600C373 RID: 50035 RVA: 0x0005F20F File Offset: 0x0005D40F
			public unsafe int _loopsSinceLastWait_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__loopsSinceLastWait_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__loopsSinceLastWait_5__7)) = value;
				}
			}

			// Token: 0x17003D05 RID: 15621
			// (get) Token: 0x0600C374 RID: 50036 RVA: 0x002FAD20 File Offset: 0x002F8F20
			// (set) Token: 0x0600C375 RID: 50037 RVA: 0x0005F22A File Offset: 0x0005D42A
			public unsafe int _i_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__i_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__i_5__8)) = value;
				}
			}

			// Token: 0x0400847A RID: 33914
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400847B RID: 33915
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400847C RID: 33916
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400847D RID: 33917
			private static readonly IntPtr NativeFieldInfoPtr_staggerTime;

			// Token: 0x0400847E RID: 33918
			private static readonly IntPtr NativeFieldInfoPtr__listeners_5__2;

			// Token: 0x0400847F RID: 33919
			private static readonly IntPtr NativeFieldInfoPtr__perDelay_5__3;

			// Token: 0x04008480 RID: 33920
			private static readonly IntPtr NativeFieldInfoPtr__startTime_5__4;

			// Token: 0x04008481 RID: 33921
			private static readonly IntPtr NativeFieldInfoPtr__waitOverflow_5__5;

			// Token: 0x04008482 RID: 33922
			private static readonly IntPtr NativeFieldInfoPtr__timeOnWaitStart_5__6;

			// Token: 0x04008483 RID: 33923
			private static readonly IntPtr NativeFieldInfoPtr__loopsSinceLastWait_5__7;

			// Token: 0x04008484 RID: 33924
			private static readonly IntPtr NativeFieldInfoPtr__i_5__8;

			// Token: 0x04008485 RID: 33925
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008486 RID: 33926
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008487 RID: 33927
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008488 RID: 33928
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008489 RID: 33929
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400848A RID: 33930
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020008BD RID: 2237
		[ObfuscatedName("ScheduleOne.GameTime.TimeManager+<TickLoop>d__101")]
		public sealed class _TickLoop_d__101 : Object
		{
			// Token: 0x0600C376 RID: 50038 RVA: 0x002FAD48 File Offset: 0x002F8F48
			// Note: this type is marked as 'beforefieldinit'.
			static _TickLoop_d__101()
			{
				Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<TickLoop>d__101");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr);
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, "<>1__state");
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, "<>2__current");
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, "<>4__this");
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr__lastWaitExcess_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, "<lastWaitExcess>5__2");
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr__timeToWait_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, "<timeToWait>5__3");
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr__timeOnWaitStart_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, "<timeOnWaitStart>5__4");
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, 100667076);
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, 100667077);
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, 100667078);
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, 100667079);
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, 100667080);
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, 100667081);
			}

			// Token: 0x0600C377 RID: 50039 RVA: 0x002FAE64 File Offset: 0x002F9064
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TickLoop_d__101(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C378 RID: 50040 RVA: 0x002FAEAC File Offset: 0x002F90AC
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C379 RID: 50041 RVA: 0x002FAEE0 File Offset: 0x002F90E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109322, XrefRangeEnd = 109354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003D0E RID: 15630
			// (get) Token: 0x0600C37A RID: 50042 RVA: 0x002FAF1C File Offset: 0x002F911C
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C37B RID: 50043 RVA: 0x002FAF5C File Offset: 0x002F915C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109354, XrefRangeEnd = 109359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003D0F RID: 15631
			// (get) Token: 0x0600C37C RID: 50044 RVA: 0x002FAF90 File Offset: 0x002F9190
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C37D RID: 50045 RVA: 0x0005F245 File Offset: 0x0005D445
			public _TickLoop_d__101(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D08 RID: 15624
			// (get) Token: 0x0600C37E RID: 50046 RVA: 0x002FAFD0 File Offset: 0x002F91D0
			// (set) Token: 0x0600C37F RID: 50047 RVA: 0x0005F24E File Offset: 0x0005D44E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003D09 RID: 15625
			// (get) Token: 0x0600C380 RID: 50048 RVA: 0x002FAFF8 File Offset: 0x002F91F8
			// (set) Token: 0x0600C381 RID: 50049 RVA: 0x0005F269 File Offset: 0x0005D469
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D0A RID: 15626
			// (get) Token: 0x0600C382 RID: 50050 RVA: 0x002FB028 File Offset: 0x002F9228
			// (set) Token: 0x0600C383 RID: 50051 RVA: 0x0005F288 File Offset: 0x0005D488
			public unsafe TimeManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D0B RID: 15627
			// (get) Token: 0x0600C384 RID: 50052 RVA: 0x002FB058 File Offset: 0x002F9258
			// (set) Token: 0x0600C385 RID: 50053 RVA: 0x0005F2A7 File Offset: 0x0005D4A7
			public unsafe float _lastWaitExcess_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr__lastWaitExcess_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr__lastWaitExcess_5__2)) = value;
				}
			}

			// Token: 0x17003D0C RID: 15628
			// (get) Token: 0x0600C386 RID: 50054 RVA: 0x002FB080 File Offset: 0x002F9280
			// (set) Token: 0x0600C387 RID: 50055 RVA: 0x0005F2C2 File Offset: 0x0005D4C2
			public unsafe float _timeToWait_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr__timeToWait_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr__timeToWait_5__3)) = value;
				}
			}

			// Token: 0x17003D0D RID: 15629
			// (get) Token: 0x0600C388 RID: 50056 RVA: 0x002FB0A8 File Offset: 0x002F92A8
			// (set) Token: 0x0600C389 RID: 50057 RVA: 0x0005F2DD File Offset: 0x0005D4DD
			public unsafe float _timeOnWaitStart_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr__timeOnWaitStart_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr__timeOnWaitStart_5__4)) = value;
				}
			}

			// Token: 0x0400848B RID: 33931
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400848C RID: 33932
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400848D RID: 33933
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400848E RID: 33934
			private static readonly IntPtr NativeFieldInfoPtr__lastWaitExcess_5__2;

			// Token: 0x0400848F RID: 33935
			private static readonly IntPtr NativeFieldInfoPtr__timeToWait_5__3;

			// Token: 0x04008490 RID: 33936
			private static readonly IntPtr NativeFieldInfoPtr__timeOnWaitStart_5__4;

			// Token: 0x04008491 RID: 33937
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008492 RID: 33938
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008493 RID: 33939
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008494 RID: 33940
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008495 RID: 33941
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008496 RID: 33942
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020008BE RID: 2238
		[ObfuscatedName("ScheduleOne.GameTime.TimeManager+<TimeLoop>d__102")]
		public sealed class _TimeLoop_d__102 : Object
		{
			// Token: 0x0600C38A RID: 50058 RVA: 0x002FB0D0 File Offset: 0x002F92D0
			// Note: this type is marked as 'beforefieldinit'.
			static _TimeLoop_d__102()
			{
				Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<TimeLoop>d__102");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr);
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, "<>1__state");
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, "<>2__current");
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, "<>4__this");
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr__lastWaitExcess_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, "<lastWaitExcess>5__2");
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr__timeToWait_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, "<timeToWait>5__3");
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr__timeOnWaitStart_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, "<timeOnWaitStart>5__4");
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, 100667082);
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, 100667083);
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, 100667084);
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, 100667085);
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, 100667086);
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, 100667087);
			}

			// Token: 0x0600C38B RID: 50059 RVA: 0x002FB1EC File Offset: 0x002F93EC
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TimeLoop_d__102(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C38C RID: 50060 RVA: 0x002FB234 File Offset: 0x002F9434
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C38D RID: 50061 RVA: 0x002FB268 File Offset: 0x002F9468
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109359, XrefRangeEnd = 109376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003D16 RID: 15638
			// (get) Token: 0x0600C38E RID: 50062 RVA: 0x002FB2A4 File Offset: 0x002F94A4
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C38F RID: 50063 RVA: 0x002FB2E4 File Offset: 0x002F94E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109376, XrefRangeEnd = 109381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003D17 RID: 15639
			// (get) Token: 0x0600C390 RID: 50064 RVA: 0x002FB318 File Offset: 0x002F9518
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C391 RID: 50065 RVA: 0x0005F2F8 File Offset: 0x0005D4F8
			public _TimeLoop_d__102(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D10 RID: 15632
			// (get) Token: 0x0600C392 RID: 50066 RVA: 0x002FB358 File Offset: 0x002F9558
			// (set) Token: 0x0600C393 RID: 50067 RVA: 0x0005F301 File Offset: 0x0005D501
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003D11 RID: 15633
			// (get) Token: 0x0600C394 RID: 50068 RVA: 0x002FB380 File Offset: 0x002F9580
			// (set) Token: 0x0600C395 RID: 50069 RVA: 0x0005F31C File Offset: 0x0005D51C
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D12 RID: 15634
			// (get) Token: 0x0600C396 RID: 50070 RVA: 0x002FB3B0 File Offset: 0x002F95B0
			// (set) Token: 0x0600C397 RID: 50071 RVA: 0x0005F33B File Offset: 0x0005D53B
			public unsafe TimeManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D13 RID: 15635
			// (get) Token: 0x0600C398 RID: 50072 RVA: 0x002FB3E0 File Offset: 0x002F95E0
			// (set) Token: 0x0600C399 RID: 50073 RVA: 0x0005F35A File Offset: 0x0005D55A
			public unsafe float _lastWaitExcess_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr__lastWaitExcess_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr__lastWaitExcess_5__2)) = value;
				}
			}

			// Token: 0x17003D14 RID: 15636
			// (get) Token: 0x0600C39A RID: 50074 RVA: 0x002FB408 File Offset: 0x002F9608
			// (set) Token: 0x0600C39B RID: 50075 RVA: 0x0005F375 File Offset: 0x0005D575
			public unsafe float _timeToWait_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr__timeToWait_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr__timeToWait_5__3)) = value;
				}
			}

			// Token: 0x17003D15 RID: 15637
			// (get) Token: 0x0600C39C RID: 50076 RVA: 0x002FB430 File Offset: 0x002F9630
			// (set) Token: 0x0600C39D RID: 50077 RVA: 0x0005F390 File Offset: 0x0005D590
			public unsafe float _timeOnWaitStart_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr__timeOnWaitStart_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr__timeOnWaitStart_5__4)) = value;
				}
			}

			// Token: 0x04008497 RID: 33943
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008498 RID: 33944
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008499 RID: 33945
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400849A RID: 33946
			private static readonly IntPtr NativeFieldInfoPtr__lastWaitExcess_5__2;

			// Token: 0x0400849B RID: 33947
			private static readonly IntPtr NativeFieldInfoPtr__timeToWait_5__3;

			// Token: 0x0400849C RID: 33948
			private static readonly IntPtr NativeFieldInfoPtr__timeOnWaitStart_5__4;

			// Token: 0x0400849D RID: 33949
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400849E RID: 33950
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400849F RID: 33951
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040084A0 RID: 33952
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040084A1 RID: 33953
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040084A2 RID: 33954
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
