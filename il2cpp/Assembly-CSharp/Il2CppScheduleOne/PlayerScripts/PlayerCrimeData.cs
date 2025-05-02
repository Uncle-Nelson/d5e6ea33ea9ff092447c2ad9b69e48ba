using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Law;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.Police;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x020003E5 RID: 997
	public class PlayerCrimeData : NetworkBehaviour
	{
		// Token: 0x06005037 RID: 20535 RVA: 0x0017F2D0 File Offset: 0x0017D4D0
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerCrimeData()
		{
			Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "PlayerCrimeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr);
			PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_INVESTIGATING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "SEARCH_TIME_INVESTIGATING");
			PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_ARRESTING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "SEARCH_TIME_ARRESTING");
			PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_NONLETHAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "SEARCH_TIME_NONLETHAL");
			PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_LETHAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "SEARCH_TIME_LETHAL");
			PlayerCrimeData.NativeFieldInfoPtr_ESCALATION_TIME_ARRESTING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "ESCALATION_TIME_ARRESTING");
			PlayerCrimeData.NativeFieldInfoPtr_ESCALATION_TIME_NONLETHAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "ESCALATION_TIME_NONLETHAL");
			PlayerCrimeData.NativeFieldInfoPtr_SHOT_COOLDOWN_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "SHOT_COOLDOWN_MIN");
			PlayerCrimeData.NativeFieldInfoPtr_SHOT_COOLDOWN_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "SHOT_COOLDOWN_MAX");
			PlayerCrimeData.NativeFieldInfoPtr_VEHICLE_COLLISION_LIFETIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "VEHICLE_COLLISION_LIFETIME");
			PlayerCrimeData.NativeFieldInfoPtr_VEHICLE_COLLISION_LIMIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "VEHICLE_COLLISION_LIMIT");
			PlayerCrimeData.NativeFieldInfoPtr_NearestOfficer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "NearestOfficer");
			PlayerCrimeData.NativeFieldInfoPtr_Player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "Player");
			PlayerCrimeData.NativeFieldInfoPtr_onPursuitEscapedSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "onPursuitEscapedSound");
			PlayerCrimeData.NativeFieldInfoPtr__CurrentPursuitLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "<CurrentPursuitLevel>k__BackingField");
			PlayerCrimeData.NativeFieldInfoPtr__LastKnownPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "<LastKnownPosition>k__BackingField");
			PlayerCrimeData.NativeFieldInfoPtr_Pursuers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "Pursuers");
			PlayerCrimeData.NativeFieldInfoPtr__CurrentArrestProgress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "<CurrentArrestProgress>k__BackingField");
			PlayerCrimeData.NativeFieldInfoPtr__CurrentBodySearchProgress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "<CurrentBodySearchProgress>k__BackingField");
			PlayerCrimeData.NativeFieldInfoPtr_TimeSincePursuitStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "TimeSincePursuitStart");
			PlayerCrimeData.NativeFieldInfoPtr_CurrentPursuitLevelDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "CurrentPursuitLevelDuration");
			PlayerCrimeData.NativeFieldInfoPtr_TimeSinceSighted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "TimeSinceSighted");
			PlayerCrimeData.NativeFieldInfoPtr_Crimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "Crimes");
			PlayerCrimeData.NativeFieldInfoPtr_BodySearchPending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "BodySearchPending");
			PlayerCrimeData.NativeFieldInfoPtr__TimeSinceLastBodySearch_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "<TimeSinceLastBodySearch>k__BackingField");
			PlayerCrimeData.NativeFieldInfoPtr__EvadedArrest_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "<EvadedArrest>k__BackingField");
			PlayerCrimeData.NativeFieldInfoPtr_timeSinceLastShot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "timeSinceLastShot");
			PlayerCrimeData.NativeFieldInfoPtr_Collisions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "Collisions");
			PlayerCrimeData.NativeFieldInfoPtr__lightCombatTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "_lightCombatTrack");
			PlayerCrimeData.NativeFieldInfoPtr__heavyCombatTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "_heavyCombatTrack");
			PlayerCrimeData.NativeFieldInfoPtr_outOfSightTimeToDipMusic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "outOfSightTimeToDipMusic");
			PlayerCrimeData.NativeFieldInfoPtr_minMusicVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "minMusicVolume");
			PlayerCrimeData.NativeFieldInfoPtr_musicChangeRate_Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "musicChangeRate_Down");
			PlayerCrimeData.NativeFieldInfoPtr_musicChangeRate_Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "musicChangeRate_Up");
			PlayerCrimeData.NativeFieldInfoPtr_syncVar____CurrentPursuitLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "syncVar___<CurrentPursuitLevel>k__BackingField");
			PlayerCrimeData.NativeFieldInfoPtr_syncVar____LastKnownPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "syncVar___<LastKnownPosition>k__BackingField");
			PlayerCrimeData.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.PlayerScripts.PlayerCrimeDataAssembly-CSharp.dll_Excuted");
			PlayerCrimeData.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.PlayerScripts.PlayerCrimeDataAssembly-CSharp.dll_Excuted");
			PlayerCrimeData.NativeMethodInfoPtr_get_CurrentPursuitLevel_Public_get_EPursuitLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673366);
			PlayerCrimeData.NativeMethodInfoPtr_set_CurrentPursuitLevel_Protected_set_Void_EPursuitLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673367);
			PlayerCrimeData.NativeMethodInfoPtr_get_LastKnownPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673368);
			PlayerCrimeData.NativeMethodInfoPtr_set_LastKnownPosition_Protected_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673369);
			PlayerCrimeData.NativeMethodInfoPtr_get_CurrentArrestProgress_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673370);
			PlayerCrimeData.NativeMethodInfoPtr_set_CurrentArrestProgress_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673371);
			PlayerCrimeData.NativeMethodInfoPtr_get_CurrentBodySearchProgress_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673372);
			PlayerCrimeData.NativeMethodInfoPtr_set_CurrentBodySearchProgress_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673373);
			PlayerCrimeData.NativeMethodInfoPtr_get_TimeSinceLastBodySearch_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673374);
			PlayerCrimeData.NativeMethodInfoPtr_set_TimeSinceLastBodySearch_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673375);
			PlayerCrimeData.NativeMethodInfoPtr_get_EvadedArrest_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673376);
			PlayerCrimeData.NativeMethodInfoPtr_set_EvadedArrest_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673377);
			PlayerCrimeData.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673378);
			PlayerCrimeData.NativeMethodInfoPtr_Start_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673379);
			PlayerCrimeData.NativeMethodInfoPtr_OnDestroy_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673380);
			PlayerCrimeData.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673381);
			PlayerCrimeData.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673382);
			PlayerCrimeData.NativeMethodInfoPtr_SetPursuitLevel_Public_Void_EPursuitLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673383);
			PlayerCrimeData.NativeMethodInfoPtr_Escalate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673384);
			PlayerCrimeData.NativeMethodInfoPtr_Deescalate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673385);
			PlayerCrimeData.NativeMethodInfoPtr_RecordLastKnownPosition_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673386);
			PlayerCrimeData.NativeMethodInfoPtr_SetArrestProgress_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673387);
			PlayerCrimeData.NativeMethodInfoPtr_ResetBodysearchCooldown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673388);
			PlayerCrimeData.NativeMethodInfoPtr_SetBodySearchProgress_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673389);
			PlayerCrimeData.NativeMethodInfoPtr_OnDie_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673390);
			PlayerCrimeData.NativeMethodInfoPtr_AddCrime_Public_Void_Crime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673391);
			PlayerCrimeData.NativeMethodInfoPtr_ClearCrimes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673392);
			PlayerCrimeData.NativeMethodInfoPtr_IsCrimeOnRecord_Public_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673393);
			PlayerCrimeData.NativeMethodInfoPtr_SetEvaded_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673394);
			PlayerCrimeData.NativeMethodInfoPtr_OnSleepStart_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673395);
			PlayerCrimeData.NativeMethodInfoPtr_UpdateEscalation_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673396);
			PlayerCrimeData.NativeMethodInfoPtr_UpdateTimeout_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673397);
			PlayerCrimeData.NativeMethodInfoPtr_UpdateMusic_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673398);
			PlayerCrimeData.NativeMethodInfoPtr_TimeoutPursuit_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673399);
			PlayerCrimeData.NativeMethodInfoPtr_GetSearchTime_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673400);
			PlayerCrimeData.NativeMethodInfoPtr_ResetShotAccuracy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673401);
			PlayerCrimeData.NativeMethodInfoPtr_GetShotAccuracyMultiplier_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673402);
			PlayerCrimeData.NativeMethodInfoPtr_RecordVehicleCollision_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673403);
			PlayerCrimeData.NativeMethodInfoPtr_CheckNearestOfficer_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673404);
			PlayerCrimeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673405);
			PlayerCrimeData.NativeMethodInfoPtr__Awake_b__53_0_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673406);
			PlayerCrimeData.NativeMethodInfoPtr__CheckNearestOfficer_b__79_0_Private_Single_PoliceOfficer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673407);
			PlayerCrimeData.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673408);
			PlayerCrimeData.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673409);
			PlayerCrimeData.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673410);
			PlayerCrimeData.NativeMethodInfoPtr_RpcWriter___Server_set_CurrentPursuitLevel_2979171596_Private_Void_EPursuitLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673411);
			PlayerCrimeData.NativeMethodInfoPtr_RpcLogic___set_CurrentPursuitLevel_2979171596_Protected_Void_EPursuitLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673412);
			PlayerCrimeData.NativeMethodInfoPtr_RpcReader___Server_set_CurrentPursuitLevel_2979171596_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673413);
			PlayerCrimeData.NativeMethodInfoPtr_RpcWriter___Server_set_LastKnownPosition_4276783012_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673414);
			PlayerCrimeData.NativeMethodInfoPtr_RpcLogic___set_LastKnownPosition_4276783012_Protected_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673415);
			PlayerCrimeData.NativeMethodInfoPtr_RpcReader___Server_set_LastKnownPosition_4276783012_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673416);
			PlayerCrimeData.NativeMethodInfoPtr_RpcWriter___Observers_RecordLastKnownPosition_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673417);
			PlayerCrimeData.NativeMethodInfoPtr_RpcLogic___RecordLastKnownPosition_1140765316_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673418);
			PlayerCrimeData.NativeMethodInfoPtr_RpcReader___Observers_RecordLastKnownPosition_1140765316_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673419);
			PlayerCrimeData.NativeMethodInfoPtr_sync___get_value__CurrentPursuitLevel_k__BackingField_Public_get_EPursuitLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673420);
			PlayerCrimeData.NativeMethodInfoPtr_sync___set_value__CurrentPursuitLevel_k__BackingField_Public_set_Void_EPursuitLevel_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673421);
			PlayerCrimeData.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_PlayerScripts_PlayerCrimeData_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673422);
			PlayerCrimeData.NativeMethodInfoPtr_sync___get_value__LastKnownPosition_k__BackingField_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673423);
			PlayerCrimeData.NativeMethodInfoPtr_sync___set_value__LastKnownPosition_k__BackingField_Public_set_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673424);
			PlayerCrimeData.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673425);
		}

		// Token: 0x17001824 RID: 6180
		// (get) Token: 0x06005038 RID: 20536 RVA: 0x0017FA94 File Offset: 0x0017DC94
		// (set) Token: 0x06005039 RID: 20537 RVA: 0x0017FAD0 File Offset: 0x0017DCD0
		public unsafe PlayerCrimeData.EPursuitLevel CurrentPursuitLevel
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 60914, RefRangeEnd = 60954, XrefRangeStart = 60914, XrefRangeEnd = 60954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_get_CurrentPursuitLevel_Public_get_EPursuitLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 174636, RefRangeEnd = 174637, XrefRangeStart = 174603, XrefRangeEnd = 174636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_set_CurrentPursuitLevel_Protected_set_Void_EPursuitLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001825 RID: 6181
		// (get) Token: 0x0600503A RID: 20538 RVA: 0x0017FB10 File Offset: 0x0017DD10
		// (set) Token: 0x0600503B RID: 20539 RVA: 0x0017FB4C File Offset: 0x0017DD4C
		public unsafe Vector3 LastKnownPosition
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 174637, RefRangeEnd = 174648, XrefRangeStart = 174637, XrefRangeEnd = 174637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_get_LastKnownPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174648, XrefRangeEnd = 174656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_set_LastKnownPosition_Protected_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001826 RID: 6182
		// (get) Token: 0x0600503C RID: 20540 RVA: 0x0017FB8C File Offset: 0x0017DD8C
		// (set) Token: 0x0600503D RID: 20541 RVA: 0x0017FBC8 File Offset: 0x0017DDC8
		public unsafe float CurrentArrestProgress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_get_CurrentArrestProgress_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_set_CurrentArrestProgress_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001827 RID: 6183
		// (get) Token: 0x0600503E RID: 20542 RVA: 0x0017FC08 File Offset: 0x0017DE08
		// (set) Token: 0x0600503F RID: 20543 RVA: 0x0017FC44 File Offset: 0x0017DE44
		public unsafe float CurrentBodySearchProgress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_get_CurrentBodySearchProgress_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_set_CurrentBodySearchProgress_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001828 RID: 6184
		// (get) Token: 0x06005040 RID: 20544 RVA: 0x0017FC84 File Offset: 0x0017DE84
		// (set) Token: 0x06005041 RID: 20545 RVA: 0x0017FCC0 File Offset: 0x0017DEC0
		public unsafe float TimeSinceLastBodySearch
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_get_TimeSinceLastBodySearch_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_set_TimeSinceLastBodySearch_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001829 RID: 6185
		// (get) Token: 0x06005042 RID: 20546 RVA: 0x0017FD00 File Offset: 0x0017DF00
		// (set) Token: 0x06005043 RID: 20547 RVA: 0x0017FD3C File Offset: 0x0017DF3C
		public unsafe bool EvadedArrest
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_get_EvadedArrest_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_set_EvadedArrest_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005044 RID: 20548 RVA: 0x0017FD7C File Offset: 0x0017DF7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174656, XrefRangeEnd = 174657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCrimeData.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005045 RID: 20549 RVA: 0x0017FDB8 File Offset: 0x0017DFB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174657, XrefRangeEnd = 174677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_Start_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005046 RID: 20550 RVA: 0x0017FDEC File Offset: 0x0017DFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174677, XrefRangeEnd = 174691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_OnDestroy_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005047 RID: 20551 RVA: 0x0017FE20 File Offset: 0x0017E020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174691, XrefRangeEnd = 174784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCrimeData.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005048 RID: 20552 RVA: 0x0017FE5C File Offset: 0x0017E05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174784, XrefRangeEnd = 174803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCrimeData.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005049 RID: 20553 RVA: 0x0017FE98 File Offset: 0x0017E098
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 174838, RefRangeEnd = 174868, XrefRangeStart = 174803, XrefRangeEnd = 174838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPursuitLevel(PlayerCrimeData.EPursuitLevel level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_SetPursuitLevel_Public_Void_EPursuitLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600504A RID: 20554 RVA: 0x0017FED8 File Offset: 0x0017E0D8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 174886, RefRangeEnd = 174893, XrefRangeStart = 174868, XrefRangeEnd = 174886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Escalate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_Escalate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600504B RID: 20555 RVA: 0x0017FF0C File Offset: 0x0017E10C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 174897, RefRangeEnd = 174898, XrefRangeStart = 174893, XrefRangeEnd = 174897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deescalate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_Deescalate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600504C RID: 20556 RVA: 0x0017FF40 File Offset: 0x0017E140
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 174920, RefRangeEnd = 174936, XrefRangeStart = 174898, XrefRangeEnd = 174920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordLastKnownPosition(bool resetTimeSinceSighted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref resetTimeSinceSighted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RecordLastKnownPosition_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600504D RID: 20557 RVA: 0x0017FF80 File Offset: 0x0017E180
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 174938, RefRangeEnd = 174939, XrefRangeStart = 174936, XrefRangeEnd = 174938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArrestProgress(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_SetArrestProgress_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600504E RID: 20558 RVA: 0x0017FFC0 File Offset: 0x0017E1C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 174939, RefRangeEnd = 174942, XrefRangeStart = 174939, XrefRangeEnd = 174939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetBodysearchCooldown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_ResetBodysearchCooldown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600504F RID: 20559 RVA: 0x0017FFF4 File Offset: 0x0017E1F4
		[CallerCount(0)]
		public unsafe void SetBodySearchProgress(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_SetBodySearchProgress_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005050 RID: 20560 RVA: 0x00180034 File Offset: 0x0017E234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174942, XrefRangeEnd = 174944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDie()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_OnDie_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005051 RID: 20561 RVA: 0x00180068 File Offset: 0x0017E268
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 174971, RefRangeEnd = 174987, XrefRangeStart = 174944, XrefRangeEnd = 174971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCrime(Crime crime, int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(crime);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_AddCrime_Public_Void_Crime_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005052 RID: 20562 RVA: 0x001800B8 File Offset: 0x0017E2B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 174990, RefRangeEnd = 174992, XrefRangeStart = 174987, XrefRangeEnd = 174990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearCrimes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_ClearCrimes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005053 RID: 20563 RVA: 0x001800EC File Offset: 0x0017E2EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 175004, RefRangeEnd = 175006, XrefRangeStart = 174992, XrefRangeEnd = 175004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCrimeOnRecord(Type crime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(crime);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_IsCrimeOnRecord_Public_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005054 RID: 20564 RVA: 0x0018013C File Offset: 0x0017E33C
		[CallerCount(0)]
		public unsafe void SetEvaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_SetEvaded_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005055 RID: 20565 RVA: 0x00180170 File Offset: 0x0017E370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175006, XrefRangeEnd = 175010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSleepStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_OnSleepStart_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005056 RID: 20566 RVA: 0x001801A4 File Offset: 0x0017E3A4
		[CallerCount(0)]
		public unsafe void UpdateEscalation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_UpdateEscalation_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005057 RID: 20567 RVA: 0x001801D8 File Offset: 0x0017E3D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175010, XrefRangeEnd = 175029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTimeout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_UpdateTimeout_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005058 RID: 20568 RVA: 0x0018020C File Offset: 0x0017E40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175029, XrefRangeEnd = 175035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMusic()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_UpdateMusic_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005059 RID: 20569 RVA: 0x00180240 File Offset: 0x0017E440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175035, XrefRangeEnd = 175049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TimeoutPursuit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_TimeoutPursuit_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600505A RID: 20570 RVA: 0x00180274 File Offset: 0x0017E474
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 175049, RefRangeEnd = 175052, XrefRangeStart = 175049, XrefRangeEnd = 175049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSearchTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_GetSearchTime_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600505B RID: 20571 RVA: 0x001802B0 File Offset: 0x0017E4B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175052, RefRangeEnd = 175053, XrefRangeStart = 175052, XrefRangeEnd = 175052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetShotAccuracy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_ResetShotAccuracy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600505C RID: 20572 RVA: 0x001802E4 File Offset: 0x0017E4E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175093, RefRangeEnd = 175094, XrefRangeStart = 175053, XrefRangeEnd = 175093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetShotAccuracyMultiplier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_GetShotAccuracyMultiplier_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600505D RID: 20573 RVA: 0x00180320 File Offset: 0x0017E520
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175105, RefRangeEnd = 175106, XrefRangeStart = 175094, XrefRangeEnd = 175105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordVehicleCollision(NPC victim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(victim);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RecordVehicleCollision_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600505E RID: 20574 RVA: 0x00180364 File Offset: 0x0017E564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175106, XrefRangeEnd = 175127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckNearestOfficer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_CheckNearestOfficer_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600505F RID: 20575 RVA: 0x00180398 File Offset: 0x0017E598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175127, XrefRangeEnd = 175151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerCrimeData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005060 RID: 20576 RVA: 0x001803D4 File Offset: 0x0017E5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175151, XrefRangeEnd = 175152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__53_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr__Awake_b__53_0_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005061 RID: 20577 RVA: 0x00180408 File Offset: 0x0017E608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175152, XrefRangeEnd = 175157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _CheckNearestOfficer_b__79_0(PoliceOfficer x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr__CheckNearestOfficer_b__79_0_Private_Single_PoliceOfficer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005062 RID: 20578 RVA: 0x00180458 File Offset: 0x0017E658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175157, XrefRangeEnd = 175202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCrimeData.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005063 RID: 20579 RVA: 0x00180494 File Offset: 0x0017E694
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCrimeData.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005064 RID: 20580 RVA: 0x001804D0 File Offset: 0x0017E6D0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCrimeData.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005065 RID: 20581 RVA: 0x0018050C File Offset: 0x0017E70C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175202, XrefRangeEnd = 175231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_set_CurrentPursuitLevel_2979171596(PlayerCrimeData.EPursuitLevel value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcWriter___Server_set_CurrentPursuitLevel_2979171596_Private_Void_EPursuitLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005066 RID: 20582 RVA: 0x0018054C File Offset: 0x0017E74C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 175238, RefRangeEnd = 175240, XrefRangeStart = 175231, XrefRangeEnd = 175238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___set_CurrentPursuitLevel_2979171596(PlayerCrimeData.EPursuitLevel value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcLogic___set_CurrentPursuitLevel_2979171596_Protected_Void_EPursuitLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005067 RID: 20583 RVA: 0x0018058C File Offset: 0x0017E78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175240, XrefRangeEnd = 175245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_set_CurrentPursuitLevel_2979171596(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcReader___Server_set_CurrentPursuitLevel_2979171596_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005068 RID: 20584 RVA: 0x001805F0 File Offset: 0x0017E7F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 175276, RefRangeEnd = 175278, XrefRangeStart = 175245, XrefRangeEnd = 175276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_set_LastKnownPosition_4276783012(Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcWriter___Server_set_LastKnownPosition_4276783012_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005069 RID: 20585 RVA: 0x00180630 File Offset: 0x0017E830
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175285, RefRangeEnd = 175286, XrefRangeStart = 175278, XrefRangeEnd = 175285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___set_LastKnownPosition_4276783012(Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcLogic___set_LastKnownPosition_4276783012_Protected_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600506A RID: 20586 RVA: 0x00180670 File Offset: 0x0017E870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175286, XrefRangeEnd = 175293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_set_LastKnownPosition_4276783012(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcReader___Server_set_LastKnownPosition_4276783012_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600506B RID: 20587 RVA: 0x001806D4 File Offset: 0x0017E8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175293, XrefRangeEnd = 175312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_RecordLastKnownPosition_1140765316(bool resetTimeSinceSighted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref resetTimeSinceSighted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcWriter___Observers_RecordLastKnownPosition_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600506C RID: 20588 RVA: 0x00180714 File Offset: 0x0017E914
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 175321, RefRangeEnd = 175324, XrefRangeStart = 175312, XrefRangeEnd = 175321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RecordLastKnownPosition_1140765316(bool resetTimeSinceSighted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref resetTimeSinceSighted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcLogic___RecordLastKnownPosition_1140765316_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600506D RID: 20589 RVA: 0x00180754 File Offset: 0x0017E954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175324, XrefRangeEnd = 175327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_RecordLastKnownPosition_1140765316(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcReader___Observers_RecordLastKnownPosition_1140765316_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700182A RID: 6186
		// (get) Token: 0x0600506E RID: 20590 RVA: 0x001807A4 File Offset: 0x0017E9A4
		// (set) Token: 0x0600506F RID: 20591 RVA: 0x001807E0 File Offset: 0x0017E9E0
		public unsafe PlayerCrimeData.EPursuitLevel SyncAccessor_<CurrentPursuitLevel>k__BackingField
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 60914, RefRangeEnd = 60954, XrefRangeStart = 60914, XrefRangeEnd = 60954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_sync___get_value__CurrentPursuitLevel_k__BackingField_Public_get_EPursuitLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 175335, RefRangeEnd = 175336, XrefRangeStart = 175327, XrefRangeEnd = 175335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_sync___set_value__CurrentPursuitLevel_k__BackingField_Public_set_Void_EPursuitLevel_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005070 RID: 20592 RVA: 0x0018082C File Offset: 0x0017EA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175336, XrefRangeEnd = 175341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_PlayerScripts_PlayerCrimeData(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCrimeData.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_PlayerScripts_PlayerCrimeData_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700182B RID: 6187
		// (get) Token: 0x06005071 RID: 20593 RVA: 0x001808A0 File Offset: 0x0017EAA0
		// (set) Token: 0x06005072 RID: 20594 RVA: 0x001808DC File Offset: 0x0017EADC
		public unsafe Vector3 SyncAccessor_<LastKnownPosition>k__BackingField
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 174637, RefRangeEnd = 174648, XrefRangeStart = 174637, XrefRangeEnd = 174648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_sync___get_value__LastKnownPosition_k__BackingField_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175341, XrefRangeEnd = 175349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_sync___set_value__LastKnownPosition_k__BackingField_Public_set_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005073 RID: 20595 RVA: 0x00180928 File Offset: 0x0017EB28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175414, RefRangeEnd = 175415, XrefRangeStart = 175349, XrefRangeEnd = 175414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005074 RID: 20596 RVA: 0x000262D8 File Offset: 0x000244D8
		public PlayerCrimeData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170017FF RID: 6143
		// (get) Token: 0x06005075 RID: 20597 RVA: 0x0018095C File Offset: 0x0017EB5C
		// (set) Token: 0x06005076 RID: 20598 RVA: 0x000262E1 File Offset: 0x000244E1
		public unsafe static float SEARCH_TIME_INVESTIGATING
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_INVESTIGATING, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_INVESTIGATING, (void*)(&value));
			}
		}

		// Token: 0x17001800 RID: 6144
		// (get) Token: 0x06005077 RID: 20599 RVA: 0x00180978 File Offset: 0x0017EB78
		// (set) Token: 0x06005078 RID: 20600 RVA: 0x000262EF File Offset: 0x000244EF
		public unsafe static float SEARCH_TIME_ARRESTING
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_ARRESTING, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_ARRESTING, (void*)(&value));
			}
		}

		// Token: 0x17001801 RID: 6145
		// (get) Token: 0x06005079 RID: 20601 RVA: 0x00180994 File Offset: 0x0017EB94
		// (set) Token: 0x0600507A RID: 20602 RVA: 0x000262FD File Offset: 0x000244FD
		public unsafe static float SEARCH_TIME_NONLETHAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_NONLETHAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_NONLETHAL, (void*)(&value));
			}
		}

		// Token: 0x17001802 RID: 6146
		// (get) Token: 0x0600507B RID: 20603 RVA: 0x001809B0 File Offset: 0x0017EBB0
		// (set) Token: 0x0600507C RID: 20604 RVA: 0x0002630B File Offset: 0x0002450B
		public unsafe static float SEARCH_TIME_LETHAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_LETHAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_LETHAL, (void*)(&value));
			}
		}

		// Token: 0x17001803 RID: 6147
		// (get) Token: 0x0600507D RID: 20605 RVA: 0x001809CC File Offset: 0x0017EBCC
		// (set) Token: 0x0600507E RID: 20606 RVA: 0x00026319 File Offset: 0x00024519
		public unsafe static float ESCALATION_TIME_ARRESTING
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_ESCALATION_TIME_ARRESTING, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_ESCALATION_TIME_ARRESTING, (void*)(&value));
			}
		}

		// Token: 0x17001804 RID: 6148
		// (get) Token: 0x0600507F RID: 20607 RVA: 0x001809E8 File Offset: 0x0017EBE8
		// (set) Token: 0x06005080 RID: 20608 RVA: 0x00026327 File Offset: 0x00024527
		public unsafe static float ESCALATION_TIME_NONLETHAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_ESCALATION_TIME_NONLETHAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_ESCALATION_TIME_NONLETHAL, (void*)(&value));
			}
		}

		// Token: 0x17001805 RID: 6149
		// (get) Token: 0x06005081 RID: 20609 RVA: 0x00180A04 File Offset: 0x0017EC04
		// (set) Token: 0x06005082 RID: 20610 RVA: 0x00026335 File Offset: 0x00024535
		public unsafe static float SHOT_COOLDOWN_MIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_SHOT_COOLDOWN_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_SHOT_COOLDOWN_MIN, (void*)(&value));
			}
		}

		// Token: 0x17001806 RID: 6150
		// (get) Token: 0x06005083 RID: 20611 RVA: 0x00180A20 File Offset: 0x0017EC20
		// (set) Token: 0x06005084 RID: 20612 RVA: 0x00026343 File Offset: 0x00024543
		public unsafe static float SHOT_COOLDOWN_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_SHOT_COOLDOWN_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_SHOT_COOLDOWN_MAX, (void*)(&value));
			}
		}

		// Token: 0x17001807 RID: 6151
		// (get) Token: 0x06005085 RID: 20613 RVA: 0x00180A3C File Offset: 0x0017EC3C
		// (set) Token: 0x06005086 RID: 20614 RVA: 0x00026351 File Offset: 0x00024551
		public unsafe static float VEHICLE_COLLISION_LIFETIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_VEHICLE_COLLISION_LIFETIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_VEHICLE_COLLISION_LIFETIME, (void*)(&value));
			}
		}

		// Token: 0x17001808 RID: 6152
		// (get) Token: 0x06005087 RID: 20615 RVA: 0x00180A58 File Offset: 0x0017EC58
		// (set) Token: 0x06005088 RID: 20616 RVA: 0x0002635F File Offset: 0x0002455F
		public unsafe static float VEHICLE_COLLISION_LIMIT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_VEHICLE_COLLISION_LIMIT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_VEHICLE_COLLISION_LIMIT, (void*)(&value));
			}
		}

		// Token: 0x17001809 RID: 6153
		// (get) Token: 0x06005089 RID: 20617 RVA: 0x00180A74 File Offset: 0x0017EC74
		// (set) Token: 0x0600508A RID: 20618 RVA: 0x0002636D File Offset: 0x0002456D
		public unsafe PoliceOfficer NearestOfficer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_NearestOfficer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_NearestOfficer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700180A RID: 6154
		// (get) Token: 0x0600508B RID: 20619 RVA: 0x00180AA4 File Offset: 0x0017ECA4
		// (set) Token: 0x0600508C RID: 20620 RVA: 0x0002638C File Offset: 0x0002458C
		public unsafe Player Player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_Player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_Player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700180B RID: 6155
		// (get) Token: 0x0600508D RID: 20621 RVA: 0x00180AD4 File Offset: 0x0017ECD4
		// (set) Token: 0x0600508E RID: 20622 RVA: 0x000263AB File Offset: 0x000245AB
		public unsafe AudioSourceController onPursuitEscapedSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_onPursuitEscapedSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_onPursuitEscapedSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700180C RID: 6156
		// (get) Token: 0x0600508F RID: 20623 RVA: 0x00180B04 File Offset: 0x0017ED04
		// (set) Token: 0x06005090 RID: 20624 RVA: 0x000263CA File Offset: 0x000245CA
		public unsafe PlayerCrimeData.EPursuitLevel _CurrentPursuitLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__CurrentPursuitLevel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__CurrentPursuitLevel_k__BackingField)) = value;
			}
		}

		// Token: 0x1700180D RID: 6157
		// (get) Token: 0x06005091 RID: 20625 RVA: 0x00180B2C File Offset: 0x0017ED2C
		// (set) Token: 0x06005092 RID: 20626 RVA: 0x000263E5 File Offset: 0x000245E5
		public unsafe Vector3 _LastKnownPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__LastKnownPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__LastKnownPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x1700180E RID: 6158
		// (get) Token: 0x06005093 RID: 20627 RVA: 0x00180B54 File Offset: 0x0017ED54
		// (set) Token: 0x06005094 RID: 20628 RVA: 0x00026400 File Offset: 0x00024600
		public unsafe List<PoliceOfficer> Pursuers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_Pursuers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PoliceOfficer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_Pursuers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700180F RID: 6159
		// (get) Token: 0x06005095 RID: 20629 RVA: 0x00180B84 File Offset: 0x0017ED84
		// (set) Token: 0x06005096 RID: 20630 RVA: 0x0002641F File Offset: 0x0002461F
		public unsafe float _CurrentArrestProgress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__CurrentArrestProgress_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__CurrentArrestProgress_k__BackingField)) = value;
			}
		}

		// Token: 0x17001810 RID: 6160
		// (get) Token: 0x06005097 RID: 20631 RVA: 0x00180BAC File Offset: 0x0017EDAC
		// (set) Token: 0x06005098 RID: 20632 RVA: 0x0002643A File Offset: 0x0002463A
		public unsafe float _CurrentBodySearchProgress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__CurrentBodySearchProgress_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__CurrentBodySearchProgress_k__BackingField)) = value;
			}
		}

		// Token: 0x17001811 RID: 6161
		// (get) Token: 0x06005099 RID: 20633 RVA: 0x00180BD4 File Offset: 0x0017EDD4
		// (set) Token: 0x0600509A RID: 20634 RVA: 0x00026455 File Offset: 0x00024655
		public unsafe float TimeSincePursuitStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_TimeSincePursuitStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_TimeSincePursuitStart)) = value;
			}
		}

		// Token: 0x17001812 RID: 6162
		// (get) Token: 0x0600509B RID: 20635 RVA: 0x00180BFC File Offset: 0x0017EDFC
		// (set) Token: 0x0600509C RID: 20636 RVA: 0x00026470 File Offset: 0x00024670
		public unsafe float CurrentPursuitLevelDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_CurrentPursuitLevelDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_CurrentPursuitLevelDuration)) = value;
			}
		}

		// Token: 0x17001813 RID: 6163
		// (get) Token: 0x0600509D RID: 20637 RVA: 0x00180C24 File Offset: 0x0017EE24
		// (set) Token: 0x0600509E RID: 20638 RVA: 0x0002648B File Offset: 0x0002468B
		public unsafe float TimeSinceSighted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_TimeSinceSighted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_TimeSinceSighted)) = value;
			}
		}

		// Token: 0x17001814 RID: 6164
		// (get) Token: 0x0600509F RID: 20639 RVA: 0x00180C4C File Offset: 0x0017EE4C
		// (set) Token: 0x060050A0 RID: 20640 RVA: 0x000264A6 File Offset: 0x000246A6
		public unsafe Dictionary<Crime, int> Crimes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_Crimes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Crime, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_Crimes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001815 RID: 6165
		// (get) Token: 0x060050A1 RID: 20641 RVA: 0x00180C7C File Offset: 0x0017EE7C
		// (set) Token: 0x060050A2 RID: 20642 RVA: 0x000264C5 File Offset: 0x000246C5
		public unsafe bool BodySearchPending
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_BodySearchPending);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_BodySearchPending)) = value;
			}
		}

		// Token: 0x17001816 RID: 6166
		// (get) Token: 0x060050A3 RID: 20643 RVA: 0x00180CA4 File Offset: 0x0017EEA4
		// (set) Token: 0x060050A4 RID: 20644 RVA: 0x000264E0 File Offset: 0x000246E0
		public unsafe float _TimeSinceLastBodySearch_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__TimeSinceLastBodySearch_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__TimeSinceLastBodySearch_k__BackingField)) = value;
			}
		}

		// Token: 0x17001817 RID: 6167
		// (get) Token: 0x060050A5 RID: 20645 RVA: 0x00180CCC File Offset: 0x0017EECC
		// (set) Token: 0x060050A6 RID: 20646 RVA: 0x000264FB File Offset: 0x000246FB
		public unsafe bool _EvadedArrest_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__EvadedArrest_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__EvadedArrest_k__BackingField)) = value;
			}
		}

		// Token: 0x17001818 RID: 6168
		// (get) Token: 0x060050A7 RID: 20647 RVA: 0x00180CF4 File Offset: 0x0017EEF4
		// (set) Token: 0x060050A8 RID: 20648 RVA: 0x00026516 File Offset: 0x00024716
		public unsafe float timeSinceLastShot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_timeSinceLastShot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_timeSinceLastShot)) = value;
			}
		}

		// Token: 0x17001819 RID: 6169
		// (get) Token: 0x060050A9 RID: 20649 RVA: 0x00180D1C File Offset: 0x0017EF1C
		// (set) Token: 0x060050AA RID: 20650 RVA: 0x00026531 File Offset: 0x00024731
		public unsafe List<PlayerCrimeData.VehicleCollisionInstance> Collisions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_Collisions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerCrimeData.VehicleCollisionInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_Collisions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700181A RID: 6170
		// (get) Token: 0x060050AB RID: 20651 RVA: 0x00180D4C File Offset: 0x0017EF4C
		// (set) Token: 0x060050AC RID: 20652 RVA: 0x00026550 File Offset: 0x00024750
		public unsafe MusicTrack _lightCombatTrack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__lightCombatTrack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicTrack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__lightCombatTrack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700181B RID: 6171
		// (get) Token: 0x060050AD RID: 20653 RVA: 0x00180D7C File Offset: 0x0017EF7C
		// (set) Token: 0x060050AE RID: 20654 RVA: 0x0002656F File Offset: 0x0002476F
		public unsafe MusicTrack _heavyCombatTrack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__heavyCombatTrack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicTrack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__heavyCombatTrack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700181C RID: 6172
		// (get) Token: 0x060050AF RID: 20655 RVA: 0x00180DAC File Offset: 0x0017EFAC
		// (set) Token: 0x060050B0 RID: 20656 RVA: 0x0002658E File Offset: 0x0002478E
		public unsafe float outOfSightTimeToDipMusic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_outOfSightTimeToDipMusic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_outOfSightTimeToDipMusic)) = value;
			}
		}

		// Token: 0x1700181D RID: 6173
		// (get) Token: 0x060050B1 RID: 20657 RVA: 0x00180DD4 File Offset: 0x0017EFD4
		// (set) Token: 0x060050B2 RID: 20658 RVA: 0x000265A9 File Offset: 0x000247A9
		public unsafe float minMusicVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_minMusicVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_minMusicVolume)) = value;
			}
		}

		// Token: 0x1700181E RID: 6174
		// (get) Token: 0x060050B3 RID: 20659 RVA: 0x00180DFC File Offset: 0x0017EFFC
		// (set) Token: 0x060050B4 RID: 20660 RVA: 0x000265C4 File Offset: 0x000247C4
		public unsafe float musicChangeRate_Down
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_musicChangeRate_Down);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_musicChangeRate_Down)) = value;
			}
		}

		// Token: 0x1700181F RID: 6175
		// (get) Token: 0x060050B5 RID: 20661 RVA: 0x00180E24 File Offset: 0x0017F024
		// (set) Token: 0x060050B6 RID: 20662 RVA: 0x000265DF File Offset: 0x000247DF
		public unsafe float musicChangeRate_Up
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_musicChangeRate_Up);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_musicChangeRate_Up)) = value;
			}
		}

		// Token: 0x17001820 RID: 6176
		// (get) Token: 0x060050B7 RID: 20663 RVA: 0x00180E4C File Offset: 0x0017F04C
		// (set) Token: 0x060050B8 RID: 20664 RVA: 0x000265FA File Offset: 0x000247FA
		public unsafe SyncVar<PlayerCrimeData.EPursuitLevel> syncVar____CurrentPursuitLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_syncVar____CurrentPursuitLevel_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<PlayerCrimeData.EPursuitLevel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_syncVar____CurrentPursuitLevel_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001821 RID: 6177
		// (get) Token: 0x060050B9 RID: 20665 RVA: 0x00180E7C File Offset: 0x0017F07C
		// (set) Token: 0x060050BA RID: 20666 RVA: 0x00026619 File Offset: 0x00024819
		public unsafe SyncVar<Vector3> syncVar____LastKnownPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_syncVar____LastKnownPosition_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_syncVar____LastKnownPosition_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001822 RID: 6178
		// (get) Token: 0x060050BB RID: 20667 RVA: 0x00180EAC File Offset: 0x0017F0AC
		// (set) Token: 0x060050BC RID: 20668 RVA: 0x00026638 File Offset: 0x00024838
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001823 RID: 6179
		// (get) Token: 0x060050BD RID: 20669 RVA: 0x00180ED4 File Offset: 0x0017F0D4
		// (set) Token: 0x060050BE RID: 20670 RVA: 0x00026653 File Offset: 0x00024853
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400366A RID: 13930
		private static readonly IntPtr NativeFieldInfoPtr_SEARCH_TIME_INVESTIGATING;

		// Token: 0x0400366B RID: 13931
		private static readonly IntPtr NativeFieldInfoPtr_SEARCH_TIME_ARRESTING;

		// Token: 0x0400366C RID: 13932
		private static readonly IntPtr NativeFieldInfoPtr_SEARCH_TIME_NONLETHAL;

		// Token: 0x0400366D RID: 13933
		private static readonly IntPtr NativeFieldInfoPtr_SEARCH_TIME_LETHAL;

		// Token: 0x0400366E RID: 13934
		private static readonly IntPtr NativeFieldInfoPtr_ESCALATION_TIME_ARRESTING;

		// Token: 0x0400366F RID: 13935
		private static readonly IntPtr NativeFieldInfoPtr_ESCALATION_TIME_NONLETHAL;

		// Token: 0x04003670 RID: 13936
		private static readonly IntPtr NativeFieldInfoPtr_SHOT_COOLDOWN_MIN;

		// Token: 0x04003671 RID: 13937
		private static readonly IntPtr NativeFieldInfoPtr_SHOT_COOLDOWN_MAX;

		// Token: 0x04003672 RID: 13938
		private static readonly IntPtr NativeFieldInfoPtr_VEHICLE_COLLISION_LIFETIME;

		// Token: 0x04003673 RID: 13939
		private static readonly IntPtr NativeFieldInfoPtr_VEHICLE_COLLISION_LIMIT;

		// Token: 0x04003674 RID: 13940
		private static readonly IntPtr NativeFieldInfoPtr_NearestOfficer;

		// Token: 0x04003675 RID: 13941
		private static readonly IntPtr NativeFieldInfoPtr_Player;

		// Token: 0x04003676 RID: 13942
		private static readonly IntPtr NativeFieldInfoPtr_onPursuitEscapedSound;

		// Token: 0x04003677 RID: 13943
		private static readonly IntPtr NativeFieldInfoPtr__CurrentPursuitLevel_k__BackingField;

		// Token: 0x04003678 RID: 13944
		private static readonly IntPtr NativeFieldInfoPtr__LastKnownPosition_k__BackingField;

		// Token: 0x04003679 RID: 13945
		private static readonly IntPtr NativeFieldInfoPtr_Pursuers;

		// Token: 0x0400367A RID: 13946
		private static readonly IntPtr NativeFieldInfoPtr__CurrentArrestProgress_k__BackingField;

		// Token: 0x0400367B RID: 13947
		private static readonly IntPtr NativeFieldInfoPtr__CurrentBodySearchProgress_k__BackingField;

		// Token: 0x0400367C RID: 13948
		private static readonly IntPtr NativeFieldInfoPtr_TimeSincePursuitStart;

		// Token: 0x0400367D RID: 13949
		private static readonly IntPtr NativeFieldInfoPtr_CurrentPursuitLevelDuration;

		// Token: 0x0400367E RID: 13950
		private static readonly IntPtr NativeFieldInfoPtr_TimeSinceSighted;

		// Token: 0x0400367F RID: 13951
		private static readonly IntPtr NativeFieldInfoPtr_Crimes;

		// Token: 0x04003680 RID: 13952
		private static readonly IntPtr NativeFieldInfoPtr_BodySearchPending;

		// Token: 0x04003681 RID: 13953
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceLastBodySearch_k__BackingField;

		// Token: 0x04003682 RID: 13954
		private static readonly IntPtr NativeFieldInfoPtr__EvadedArrest_k__BackingField;

		// Token: 0x04003683 RID: 13955
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastShot;

		// Token: 0x04003684 RID: 13956
		private static readonly IntPtr NativeFieldInfoPtr_Collisions;

		// Token: 0x04003685 RID: 13957
		private static readonly IntPtr NativeFieldInfoPtr__lightCombatTrack;

		// Token: 0x04003686 RID: 13958
		private static readonly IntPtr NativeFieldInfoPtr__heavyCombatTrack;

		// Token: 0x04003687 RID: 13959
		private static readonly IntPtr NativeFieldInfoPtr_outOfSightTimeToDipMusic;

		// Token: 0x04003688 RID: 13960
		private static readonly IntPtr NativeFieldInfoPtr_minMusicVolume;

		// Token: 0x04003689 RID: 13961
		private static readonly IntPtr NativeFieldInfoPtr_musicChangeRate_Down;

		// Token: 0x0400368A RID: 13962
		private static readonly IntPtr NativeFieldInfoPtr_musicChangeRate_Up;

		// Token: 0x0400368B RID: 13963
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____CurrentPursuitLevel_k__BackingField;

		// Token: 0x0400368C RID: 13964
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____LastKnownPosition_k__BackingField;

		// Token: 0x0400368D RID: 13965
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400368E RID: 13966
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400368F RID: 13967
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPursuitLevel_Public_get_EPursuitLevel_0;

		// Token: 0x04003690 RID: 13968
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPursuitLevel_Protected_set_Void_EPursuitLevel_0;

		// Token: 0x04003691 RID: 13969
		private static readonly IntPtr NativeMethodInfoPtr_get_LastKnownPosition_Public_get_Vector3_0;

		// Token: 0x04003692 RID: 13970
		private static readonly IntPtr NativeMethodInfoPtr_set_LastKnownPosition_Protected_set_Void_Vector3_0;

		// Token: 0x04003693 RID: 13971
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentArrestProgress_Public_get_Single_0;

		// Token: 0x04003694 RID: 13972
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentArrestProgress_Protected_set_Void_Single_0;

		// Token: 0x04003695 RID: 13973
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentBodySearchProgress_Public_get_Single_0;

		// Token: 0x04003696 RID: 13974
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentBodySearchProgress_Protected_set_Void_Single_0;

		// Token: 0x04003697 RID: 13975
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceLastBodySearch_Public_get_Single_0;

		// Token: 0x04003698 RID: 13976
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceLastBodySearch_Public_set_Void_Single_0;

		// Token: 0x04003699 RID: 13977
		private static readonly IntPtr NativeMethodInfoPtr_get_EvadedArrest_Public_get_Boolean_0;

		// Token: 0x0400369A RID: 13978
		private static readonly IntPtr NativeMethodInfoPtr_set_EvadedArrest_Protected_set_Void_Boolean_0;

		// Token: 0x0400369B RID: 13979
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400369C RID: 13980
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_1;

		// Token: 0x0400369D RID: 13981
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_1;

		// Token: 0x0400369E RID: 13982
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400369F RID: 13983
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040036A0 RID: 13984
		private static readonly IntPtr NativeMethodInfoPtr_SetPursuitLevel_Public_Void_EPursuitLevel_0;

		// Token: 0x040036A1 RID: 13985
		private static readonly IntPtr NativeMethodInfoPtr_Escalate_Public_Void_0;

		// Token: 0x040036A2 RID: 13986
		private static readonly IntPtr NativeMethodInfoPtr_Deescalate_Public_Void_0;

		// Token: 0x040036A3 RID: 13987
		private static readonly IntPtr NativeMethodInfoPtr_RecordLastKnownPosition_Public_Void_Boolean_0;

		// Token: 0x040036A4 RID: 13988
		private static readonly IntPtr NativeMethodInfoPtr_SetArrestProgress_Public_Void_Single_0;

		// Token: 0x040036A5 RID: 13989
		private static readonly IntPtr NativeMethodInfoPtr_ResetBodysearchCooldown_Public_Void_0;

		// Token: 0x040036A6 RID: 13990
		private static readonly IntPtr NativeMethodInfoPtr_SetBodySearchProgress_Public_Void_Single_0;

		// Token: 0x040036A7 RID: 13991
		private static readonly IntPtr NativeMethodInfoPtr_OnDie_Private_Void_1;

		// Token: 0x040036A8 RID: 13992
		private static readonly IntPtr NativeMethodInfoPtr_AddCrime_Public_Void_Crime_Int32_0;

		// Token: 0x040036A9 RID: 13993
		private static readonly IntPtr NativeMethodInfoPtr_ClearCrimes_Public_Void_0;

		// Token: 0x040036AA RID: 13994
		private static readonly IntPtr NativeMethodInfoPtr_IsCrimeOnRecord_Public_Boolean_Type_0;

		// Token: 0x040036AB RID: 13995
		private static readonly IntPtr NativeMethodInfoPtr_SetEvaded_Public_Void_0;

		// Token: 0x040036AC RID: 13996
		private static readonly IntPtr NativeMethodInfoPtr_OnSleepStart_Private_Void_1;

		// Token: 0x040036AD RID: 13997
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEscalation_Private_Void_1;

		// Token: 0x040036AE RID: 13998
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTimeout_Private_Void_1;

		// Token: 0x040036AF RID: 13999
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMusic_Private_Void_1;

		// Token: 0x040036B0 RID: 14000
		private static readonly IntPtr NativeMethodInfoPtr_TimeoutPursuit_Private_Void_1;

		// Token: 0x040036B1 RID: 14001
		private static readonly IntPtr NativeMethodInfoPtr_GetSearchTime_Public_Single_0;

		// Token: 0x040036B2 RID: 14002
		private static readonly IntPtr NativeMethodInfoPtr_ResetShotAccuracy_Public_Void_0;

		// Token: 0x040036B3 RID: 14003
		private static readonly IntPtr NativeMethodInfoPtr_GetShotAccuracyMultiplier_Public_Single_0;

		// Token: 0x040036B4 RID: 14004
		private static readonly IntPtr NativeMethodInfoPtr_RecordVehicleCollision_Public_Void_NPC_0;

		// Token: 0x040036B5 RID: 14005
		private static readonly IntPtr NativeMethodInfoPtr_CheckNearestOfficer_Private_Void_1;

		// Token: 0x040036B6 RID: 14006
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040036B7 RID: 14007
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__53_0_Private_Void_1;

		// Token: 0x040036B8 RID: 14008
		private static readonly IntPtr NativeMethodInfoPtr__CheckNearestOfficer_b__79_0_Private_Single_PoliceOfficer_0;

		// Token: 0x040036B9 RID: 14009
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040036BA RID: 14010
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040036BB RID: 14011
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040036BC RID: 14012
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_CurrentPursuitLevel_2979171596_Private_Void_EPursuitLevel_0;

		// Token: 0x040036BD RID: 14013
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___set_CurrentPursuitLevel_2979171596_Protected_Void_EPursuitLevel_0;

		// Token: 0x040036BE RID: 14014
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_set_CurrentPursuitLevel_2979171596_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040036BF RID: 14015
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_LastKnownPosition_4276783012_Private_Void_Vector3_0;

		// Token: 0x040036C0 RID: 14016
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___set_LastKnownPosition_4276783012_Protected_Void_Vector3_0;

		// Token: 0x040036C1 RID: 14017
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_set_LastKnownPosition_4276783012_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040036C2 RID: 14018
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_RecordLastKnownPosition_1140765316_Private_Void_Boolean_0;

		// Token: 0x040036C3 RID: 14019
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RecordLastKnownPosition_1140765316_Public_Void_Boolean_0;

		// Token: 0x040036C4 RID: 14020
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_RecordLastKnownPosition_1140765316_Private_Void_PooledReader_Channel_0;

		// Token: 0x040036C5 RID: 14021
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__CurrentPursuitLevel_k__BackingField_Public_get_EPursuitLevel_0;

		// Token: 0x040036C6 RID: 14022
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__CurrentPursuitLevel_k__BackingField_Public_set_Void_EPursuitLevel_Boolean_0;

		// Token: 0x040036C7 RID: 14023
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_PlayerScripts_PlayerCrimeData_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x040036C8 RID: 14024
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__LastKnownPosition_k__BackingField_Public_get_Vector3_0;

		// Token: 0x040036C9 RID: 14025
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__LastKnownPosition_k__BackingField_Public_set_Void_Vector3_Boolean_0;

		// Token: 0x040036CA RID: 14026
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;

		// Token: 0x0200099E RID: 2462
		public class VehicleCollisionInstance : Il2CppSystem.Object
		{
			// Token: 0x0600CB31 RID: 52017 RVA: 0x003115DC File Offset: 0x0030F7DC
			// Note: this type is marked as 'beforefieldinit'.
			static VehicleCollisionInstance()
			{
				Il2CppClassPointerStore<PlayerCrimeData.VehicleCollisionInstance>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "VehicleCollisionInstance");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCrimeData.VehicleCollisionInstance>.NativeClassPtr);
				PlayerCrimeData.VehicleCollisionInstance.NativeFieldInfoPtr_Victim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData.VehicleCollisionInstance>.NativeClassPtr, "Victim");
				PlayerCrimeData.VehicleCollisionInstance.NativeFieldInfoPtr_TimeSince = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData.VehicleCollisionInstance>.NativeClassPtr, "TimeSince");
				PlayerCrimeData.VehicleCollisionInstance.NativeMethodInfoPtr__ctor_Public_Void_NPC_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData.VehicleCollisionInstance>.NativeClassPtr, 100673426);
			}

			// Token: 0x0600CB32 RID: 52018 RVA: 0x00311644 File Offset: 0x0030F844
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70203, RefRangeEnd = 70204, XrefRangeStart = 70203, XrefRangeEnd = 70204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VehicleCollisionInstance(NPC victim, float timeSince) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCrimeData.VehicleCollisionInstance>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(victim);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeSince;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.VehicleCollisionInstance.NativeMethodInfoPtr__ctor_Public_Void_NPC_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB33 RID: 52019 RVA: 0x00062D2A File Offset: 0x00060F2A
			public VehicleCollisionInstance(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F4F RID: 16207
			// (get) Token: 0x0600CB34 RID: 52020 RVA: 0x003116A0 File Offset: 0x0030F8A0
			// (set) Token: 0x0600CB35 RID: 52021 RVA: 0x00062D33 File Offset: 0x00060F33
			public unsafe NPC Victim
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.VehicleCollisionInstance.NativeFieldInfoPtr_Victim);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.VehicleCollisionInstance.NativeFieldInfoPtr_Victim), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F50 RID: 16208
			// (get) Token: 0x0600CB36 RID: 52022 RVA: 0x003116D0 File Offset: 0x0030F8D0
			// (set) Token: 0x0600CB37 RID: 52023 RVA: 0x00062D52 File Offset: 0x00060F52
			public unsafe float TimeSince
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.VehicleCollisionInstance.NativeFieldInfoPtr_TimeSince);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.VehicleCollisionInstance.NativeFieldInfoPtr_TimeSince)) = value;
				}
			}

			// Token: 0x04008963 RID: 35171
			private static readonly IntPtr NativeFieldInfoPtr_Victim;

			// Token: 0x04008964 RID: 35172
			private static readonly IntPtr NativeFieldInfoPtr_TimeSince;

			// Token: 0x04008965 RID: 35173
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NPC_Single_0;
		}

		// Token: 0x0200099F RID: 2463
		[OriginalName("Assembly-CSharp.dll", "", "EPursuitLevel")]
		public enum EPursuitLevel
		{
			// Token: 0x04008967 RID: 35175
			None,
			// Token: 0x04008968 RID: 35176
			Investigating,
			// Token: 0x04008969 RID: 35177
			Arresting,
			// Token: 0x0400896A RID: 35178
			NonLethal,
			// Token: 0x0400896B RID: 35179
			Lethal
		}

		// Token: 0x020009A0 RID: 2464
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCrimeData+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CB38 RID: 52024 RVA: 0x003116F8 File Offset: 0x0030F8F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PlayerCrimeData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCrimeData.__c>.NativeClassPtr);
				PlayerCrimeData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData.__c>.NativeClassPtr, "<>9");
				PlayerCrimeData.__c.NativeFieldInfoPtr___9__53_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData.__c>.NativeClassPtr, "<>9__53_1");
				PlayerCrimeData.__c.NativeFieldInfoPtr___9__53_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData.__c>.NativeClassPtr, "<>9__53_2");
				PlayerCrimeData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData.__c>.NativeClassPtr, 100673428);
				PlayerCrimeData.__c.NativeMethodInfoPtr__Awake_b__53_1_Internal_Boolean_MusicTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData.__c>.NativeClassPtr, 100673429);
				PlayerCrimeData.__c.NativeMethodInfoPtr__Awake_b__53_2_Internal_Boolean_MusicTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData.__c>.NativeClassPtr, 100673430);
			}

			// Token: 0x0600CB39 RID: 52025 RVA: 0x0031179C File Offset: 0x0030F99C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCrimeData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB3A RID: 52026 RVA: 0x003117D8 File Offset: 0x0030F9D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174595, XrefRangeEnd = 174599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Awake_b__53_1(MusicTrack t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.__c.NativeMethodInfoPtr__Awake_b__53_1_Internal_Boolean_MusicTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CB3B RID: 52027 RVA: 0x00311828 File Offset: 0x0030FA28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174599, XrefRangeEnd = 174603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Awake_b__53_2(MusicTrack t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.__c.NativeMethodInfoPtr__Awake_b__53_2_Internal_Boolean_MusicTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CB3C RID: 52028 RVA: 0x00062D6D File Offset: 0x00060F6D
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F51 RID: 16209
			// (get) Token: 0x0600CB3D RID: 52029 RVA: 0x00311878 File Offset: 0x0030FA78
			// (set) Token: 0x0600CB3E RID: 52030 RVA: 0x00062D76 File Offset: 0x00060F76
			public unsafe static PlayerCrimeData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCrimeData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F52 RID: 16210
			// (get) Token: 0x0600CB3F RID: 52031 RVA: 0x003118A0 File Offset: 0x0030FAA0
			// (set) Token: 0x0600CB40 RID: 52032 RVA: 0x00062D88 File Offset: 0x00060F88
			public unsafe static Predicate<MusicTrack> __9__53_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.__c.NativeFieldInfoPtr___9__53_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<MusicTrack>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.__c.NativeFieldInfoPtr___9__53_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F53 RID: 16211
			// (get) Token: 0x0600CB41 RID: 52033 RVA: 0x003118C8 File Offset: 0x0030FAC8
			// (set) Token: 0x0600CB42 RID: 52034 RVA: 0x00062D9A File Offset: 0x00060F9A
			public unsafe static Predicate<MusicTrack> __9__53_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.__c.NativeFieldInfoPtr___9__53_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<MusicTrack>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.__c.NativeFieldInfoPtr___9__53_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400896C RID: 35180
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400896D RID: 35181
			private static readonly IntPtr NativeFieldInfoPtr___9__53_1;

			// Token: 0x0400896E RID: 35182
			private static readonly IntPtr NativeFieldInfoPtr___9__53_2;

			// Token: 0x0400896F RID: 35183
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008970 RID: 35184
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__53_1_Internal_Boolean_MusicTrack_0;

			// Token: 0x04008971 RID: 35185
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__53_2_Internal_Boolean_MusicTrack_0;
		}
	}
}
