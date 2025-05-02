using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Police;
using Il2CppScheduleOne.Vision;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000360 RID: 864
	public class PursuitBehaviour : Behaviour
	{
		// Token: 0x0600429F RID: 17055 RVA: 0x0014C4EC File Offset: 0x0014A6EC
		// Note: this type is marked as 'beforefieldinit'.
		static PursuitBehaviour()
		{
			Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "PursuitBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr);
			PursuitBehaviour.NativeFieldInfoPtr_ARREST_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "ARREST_RANGE");
			PursuitBehaviour.NativeFieldInfoPtr_ARREST_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "ARREST_TIME");
			PursuitBehaviour.NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "EXTRA_VISIBILITY_TIME");
			PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_INVESTIGATING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "MOVE_SPEED_INVESTIGATING");
			PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_ARRESTING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "MOVE_SPEED_ARRESTING");
			PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_CHASE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "MOVE_SPEED_CHASE");
			PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_SHOOTING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "MOVE_SPEED_SHOOTING");
			PursuitBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "SEARCH_RADIUS_MIN");
			PursuitBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "SEARCH_RADIUS_MAX");
			PursuitBehaviour.NativeFieldInfoPtr_ARREST_MAX_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "ARREST_MAX_DISTANCE");
			PursuitBehaviour.NativeFieldInfoPtr_LEAVE_ARREST_CIRCLE_LIMIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "LEAVE_ARREST_CIRCLE_LIMIT");
			PursuitBehaviour.NativeFieldInfoPtr_CONSECUTIVE_MISS_ACCURACY_BOOST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "CONSECUTIVE_MISS_ACCURACY_BOOST");
			PursuitBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "<TargetPlayer>k__BackingField");
			PursuitBehaviour.NativeFieldInfoPtr__IsSearching_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "<IsSearching>k__BackingField");
			PursuitBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxVisibleDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "ArrestCircle_MaxVisibleDistance");
			PursuitBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "ArrestCircle_MaxOpacity");
			PursuitBehaviour.NativeFieldInfoPtr_isTargetVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "isTargetVisible");
			PursuitBehaviour.NativeFieldInfoPtr_isTargetStrictlyVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "isTargetStrictlyVisible");
			PursuitBehaviour.NativeFieldInfoPtr_arrestingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "arrestingEnabled");
			PursuitBehaviour.NativeFieldInfoPtr_timeSinceLastSighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "timeSinceLastSighting");
			PursuitBehaviour.NativeFieldInfoPtr_currentPursuitLevelDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "currentPursuitLevelDuration");
			PursuitBehaviour.NativeFieldInfoPtr_timeWithinArrestRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "timeWithinArrestRange");
			PursuitBehaviour.NativeFieldInfoPtr_playerSightedDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "playerSightedDuration");
			PursuitBehaviour.NativeFieldInfoPtr_distanceOnPursuitStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "distanceOnPursuitStart");
			PursuitBehaviour.NativeFieldInfoPtr_searchRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "searchRoutine");
			PursuitBehaviour.NativeFieldInfoPtr_rangedWeaponRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "rangedWeaponRoutine");
			PursuitBehaviour.NativeFieldInfoPtr_currentSearchDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "currentSearchDestination");
			PursuitBehaviour.NativeFieldInfoPtr_hasSearchDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "hasSearchDestination");
			PursuitBehaviour.NativeFieldInfoPtr_officer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "officer");
			PursuitBehaviour.NativeFieldInfoPtr_targetWasDrivingOnPursuitStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "targetWasDrivingOnPursuitStart");
			PursuitBehaviour.NativeFieldInfoPtr_wasInArrestCircleLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "wasInArrestCircleLastFrame");
			PursuitBehaviour.NativeFieldInfoPtr_leaveArrestCircleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "leaveArrestCircleCount");
			PursuitBehaviour.NativeFieldInfoPtr_rangedWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "rangedWeapon");
			PursuitBehaviour.NativeFieldInfoPtr_consecutiveMissedShots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "consecutiveMissedShots");
			PursuitBehaviour.NativeFieldInfoPtr_nextAngryVO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "nextAngryVO");
			PursuitBehaviour.NativeFieldInfoPtr_syncVar___isTargetVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "syncVar___isTargetVisible");
			PursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.PursuitBehaviourAssembly-CSharp.dll_Excuted");
			PursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.PursuitBehaviourAssembly-CSharp.dll_Excuted");
			PursuitBehaviour.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671419);
			PursuitBehaviour.NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671420);
			PursuitBehaviour.NativeMethodInfoPtr_get_IsSearching_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671421);
			PursuitBehaviour.NativeMethodInfoPtr_set_IsSearching_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671422);
			PursuitBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671423);
			PursuitBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671424);
			PursuitBehaviour.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671425);
			PursuitBehaviour.NativeMethodInfoPtr_AssignTarget_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671426);
			PursuitBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671427);
			PursuitBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671428);
			PursuitBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671429);
			PursuitBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671430);
			PursuitBehaviour.NativeMethodInfoPtr_IsTargetValid_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671431);
			PursuitBehaviour.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671432);
			PursuitBehaviour.NativeMethodInfoPtr_UpdateInvestigatingBehaviour_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671433);
			PursuitBehaviour.NativeMethodInfoPtr_UpdateArrestBehaviour_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671434);
			PursuitBehaviour.NativeMethodInfoPtr_UpdateArrest_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671435);
			PursuitBehaviour.NativeMethodInfoPtr_GetNewArrestDestination_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671436);
			PursuitBehaviour.NativeMethodInfoPtr_ClearSpeedControls_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671437);
			PursuitBehaviour.NativeMethodInfoPtr_UpdateNonLethalBehaviour_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671438);
			PursuitBehaviour.NativeMethodInfoPtr_UpdateLethalBehaviour_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671439);
			PursuitBehaviour.NativeMethodInfoPtr_RangedWeaponRoutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671440);
			PursuitBehaviour.NativeMethodInfoPtr_CanShoot_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671441);
			PursuitBehaviour.NativeMethodInfoPtr_Shoot_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671442);
			PursuitBehaviour.NativeMethodInfoPtr_SetWeaponRaised_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671443);
			PursuitBehaviour.NativeMethodInfoPtr_StopRangedWeaponRoutine_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671444);
			PursuitBehaviour.NativeMethodInfoPtr_UpdateLookAt_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671445);
			PursuitBehaviour.NativeMethodInfoPtr_UpdateEquippable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671446);
			PursuitBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671447);
			PursuitBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671448);
			PursuitBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671449);
			PursuitBehaviour.NativeMethodInfoPtr_Stop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671450);
			PursuitBehaviour.NativeMethodInfoPtr_ClearEquippables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671451);
			PursuitBehaviour.NativeMethodInfoPtr_CheckPlayerVisibility_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671452);
			PursuitBehaviour.NativeMethodInfoPtr_MarkPlayerVisible_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671453);
			PursuitBehaviour.NativeMethodInfoPtr_IsPlayerVisible_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671454);
			PursuitBehaviour.NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671455);
			PursuitBehaviour.NativeMethodInfoPtr_ProcessThirdPartyVisionEvent_Private_Void_VisionEventReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671456);
			PursuitBehaviour.NativeMethodInfoPtr_UpdateArrestCircle_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671457);
			PursuitBehaviour.NativeMethodInfoPtr_ResetArrestProgress_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671458);
			PursuitBehaviour.NativeMethodInfoPtr_SetArrestCircleAlpha_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671459);
			PursuitBehaviour.NativeMethodInfoPtr_SetArrestCircleColor_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671460);
			PursuitBehaviour.NativeMethodInfoPtr_StartSearching_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671461);
			PursuitBehaviour.NativeMethodInfoPtr_StopSearching_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671462);
			PursuitBehaviour.NativeMethodInfoPtr_SearchRoutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671463);
			PursuitBehaviour.NativeMethodInfoPtr_GetNextSearchLocation_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671464);
			PursuitBehaviour.NativeMethodInfoPtr_GetRandomReachablePointNear_Private_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671465);
			PursuitBehaviour.NativeMethodInfoPtr_SetWorldspaceIconsActive_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671466);
			PursuitBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671467);
			PursuitBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671468);
			PursuitBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671469);
			PursuitBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671470);
			PursuitBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_AssignTarget_1824087381_Private_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671471);
			PursuitBehaviour.NativeMethodInfoPtr_RpcLogic___AssignTarget_1824087381_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671472);
			PursuitBehaviour.NativeMethodInfoPtr_RpcReader___Observers_AssignTarget_1824087381_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671473);
			PursuitBehaviour.NativeMethodInfoPtr_sync___get_value_isTargetVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671474);
			PursuitBehaviour.NativeMethodInfoPtr_sync___set_value_isTargetVisible_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671475);
			PursuitBehaviour.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_NPCs_Behaviour_PursuitBehaviour_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671476);
			PursuitBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671477);
		}

		// Token: 0x17001456 RID: 5206
		// (get) Token: 0x060042A0 RID: 17056 RVA: 0x0014CCB0 File Offset: 0x0014AEB0
		// (set) Token: 0x060042A1 RID: 17057 RVA: 0x0014CCF0 File Offset: 0x0014AEF0
		public unsafe Player TargetPlayer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 115205, RefRangeEnd = 115213, XrefRangeStart = 115205, XrefRangeEnd = 115213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001457 RID: 5207
		// (get) Token: 0x060042A2 RID: 17058 RVA: 0x0014CD34 File Offset: 0x0014AF34
		// (set) Token: 0x060042A3 RID: 17059 RVA: 0x0014CD70 File Offset: 0x0014AF70
		public unsafe bool IsSearching
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_get_IsSearching_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_set_IsSearching_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060042A4 RID: 17060 RVA: 0x0014CDB0 File Offset: 0x0014AFB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153020, XrefRangeEnd = 153021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042A5 RID: 17061 RVA: 0x0014CDEC File Offset: 0x0014AFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153021, XrefRangeEnd = 153043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042A6 RID: 17062 RVA: 0x0014CE20 File Offset: 0x0014B020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153043, XrefRangeEnd = 153048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042A7 RID: 17063 RVA: 0x0014CE70 File Offset: 0x0014B070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153048, XrefRangeEnd = 153050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AssignTarget(NetworkConnection conn, NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_AssignTarget_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042A8 RID: 17064 RVA: 0x0014CED0 File Offset: 0x0014B0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153050, XrefRangeEnd = 153072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042A9 RID: 17065 RVA: 0x0014CF0C File Offset: 0x0014B10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153072, XrefRangeEnd = 153094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042AA RID: 17066 RVA: 0x0014CF48 File Offset: 0x0014B148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153094, XrefRangeEnd = 153099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BehaviourUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042AB RID: 17067 RVA: 0x0014CF84 File Offset: 0x0014B184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153099, XrefRangeEnd = 153123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042AC RID: 17068 RVA: 0x0014CFC0 File Offset: 0x0014B1C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 153128, RefRangeEnd = 153130, XrefRangeStart = 153123, XrefRangeEnd = 153128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTargetValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_IsTargetValid_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060042AD RID: 17069 RVA: 0x0014CFFC File Offset: 0x0014B1FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153130, XrefRangeEnd = 153132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042AE RID: 17070 RVA: 0x0014D038 File Offset: 0x0014B238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153132, XrefRangeEnd = 153153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateInvestigatingBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_UpdateInvestigatingBehaviour_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042AF RID: 17071 RVA: 0x0014D074 File Offset: 0x0014B274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153153, XrefRangeEnd = 153185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateArrestBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_UpdateArrestBehaviour_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042B0 RID: 17072 RVA: 0x0014D0B0 File Offset: 0x0014B2B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153201, RefRangeEnd = 153202, XrefRangeStart = 153185, XrefRangeEnd = 153201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateArrest(float tick)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref tick;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_UpdateArrest_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042B1 RID: 17073 RVA: 0x0014D0F0 File Offset: 0x0014B2F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153202, XrefRangeEnd = 153207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetNewArrestDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_GetNewArrestDestination_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060042B2 RID: 17074 RVA: 0x0014D12C File Offset: 0x0014B32C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 153235, RefRangeEnd = 153238, XrefRangeStart = 153207, XrefRangeEnd = 153235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearSpeedControls()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_ClearSpeedControls_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042B3 RID: 17075 RVA: 0x0014D160 File Offset: 0x0014B360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153238, XrefRangeEnd = 153242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateNonLethalBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_UpdateNonLethalBehaviour_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042B4 RID: 17076 RVA: 0x0014D19C File Offset: 0x0014B39C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateLethalBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_UpdateLethalBehaviour_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042B5 RID: 17077 RVA: 0x0014D1D8 File Offset: 0x0014B3D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 153247, RefRangeEnd = 153249, XrefRangeStart = 153242, XrefRangeEnd = 153247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator RangedWeaponRoutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_RangedWeaponRoutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060042B6 RID: 17078 RVA: 0x0014D218 File Offset: 0x0014B418
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153254, RefRangeEnd = 153255, XrefRangeStart = 153249, XrefRangeEnd = 153254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanShoot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_CanShoot_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060042B7 RID: 17079 RVA: 0x0014D254 File Offset: 0x0014B454
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153302, RefRangeEnd = 153303, XrefRangeStart = 153255, XrefRangeEnd = 153302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Shoot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_Shoot_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060042B8 RID: 17080 RVA: 0x0014D290 File Offset: 0x0014B490
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153308, RefRangeEnd = 153309, XrefRangeStart = 153303, XrefRangeEnd = 153308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWeaponRaised(bool raised)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref raised;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_SetWeaponRaised_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042B9 RID: 17081 RVA: 0x0014D2D0 File Offset: 0x0014B4D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 153311, RefRangeEnd = 153313, XrefRangeStart = 153309, XrefRangeEnd = 153311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopRangedWeaponRoutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_StopRangedWeaponRoutine_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042BA RID: 17082 RVA: 0x0014D304 File Offset: 0x0014B504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153313, XrefRangeEnd = 153320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateLookAt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_UpdateLookAt_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042BB RID: 17083 RVA: 0x0014D340 File Offset: 0x0014B540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153320, XrefRangeEnd = 153344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateEquippable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_UpdateEquippable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042BC RID: 17084 RVA: 0x0014D37C File Offset: 0x0014B57C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153344, XrefRangeEnd = 153346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042BD RID: 17085 RVA: 0x0014D3B8 File Offset: 0x0014B5B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153346, XrefRangeEnd = 153348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042BE RID: 17086 RVA: 0x0014D3F4 File Offset: 0x0014B5F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153348, XrefRangeEnd = 153350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042BF RID: 17087 RVA: 0x0014D430 File Offset: 0x0014B630
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 153384, RefRangeEnd = 153386, XrefRangeStart = 153350, XrefRangeEnd = 153384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_Stop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042C0 RID: 17088 RVA: 0x0014D464 File Offset: 0x0014B664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153386, XrefRangeEnd = 153397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearEquippables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_ClearEquippables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042C1 RID: 17089 RVA: 0x0014D498 File Offset: 0x0014B698
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 153423, RefRangeEnd = 153426, XrefRangeStart = 153397, XrefRangeEnd = 153423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckPlayerVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_CheckPlayerVisibility_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042C2 RID: 17090 RVA: 0x0014D4CC File Offset: 0x0014B6CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153430, RefRangeEnd = 153431, XrefRangeStart = 153426, XrefRangeEnd = 153430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkPlayerVisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_MarkPlayerVisible_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042C3 RID: 17091 RVA: 0x0014D500 File Offset: 0x0014B700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153431, XrefRangeEnd = 153434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayerVisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_IsPlayerVisible_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060042C4 RID: 17092 RVA: 0x0014D53C File Offset: 0x0014B73C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153434, XrefRangeEnd = 153444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessVisionEvent(VisionEventReceipt visionEventReceipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visionEventReceipt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042C5 RID: 17093 RVA: 0x0014D580 File Offset: 0x0014B780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153444, XrefRangeEnd = 153449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessThirdPartyVisionEvent(VisionEventReceipt visionEventReceipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visionEventReceipt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_ProcessThirdPartyVisionEvent_Private_Void_VisionEventReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042C6 RID: 17094 RVA: 0x0014D5C4 File Offset: 0x0014B7C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153449, XrefRangeEnd = 153473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateArrestCircle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_UpdateArrestCircle_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042C7 RID: 17095 RVA: 0x0014D600 File Offset: 0x0014B800
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153473, RefRangeEnd = 153474, XrefRangeStart = 153473, XrefRangeEnd = 153473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetArrestProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_ResetArrestProgress_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042C8 RID: 17096 RVA: 0x0014D634 File Offset: 0x0014B834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153474, XrefRangeEnd = 153476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArrestCircleAlpha(float alpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref alpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_SetArrestCircleAlpha_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042C9 RID: 17097 RVA: 0x0014D674 File Offset: 0x0014B874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153476, XrefRangeEnd = 153477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArrestCircleColor(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_SetArrestCircleColor_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042CA RID: 17098 RVA: 0x0014D6B4 File Offset: 0x0014B8B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 153485, RefRangeEnd = 153487, XrefRangeStart = 153477, XrefRangeEnd = 153485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartSearching()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_StartSearching_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042CB RID: 17099 RVA: 0x0014D6E8 File Offset: 0x0014B8E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153487, XrefRangeEnd = 153489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopSearching()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_StopSearching_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042CC RID: 17100 RVA: 0x0014D71C File Offset: 0x0014B91C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153489, XrefRangeEnd = 153494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SearchRoutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_SearchRoutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060042CD RID: 17101 RVA: 0x0014D75C File Offset: 0x0014B95C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153494, XrefRangeEnd = 153507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetNextSearchLocation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_GetNextSearchLocation_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060042CE RID: 17102 RVA: 0x0014D798 File Offset: 0x0014B998
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 153526, RefRangeEnd = 153529, XrefRangeStart = 153507, XrefRangeEnd = 153526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetRandomReachablePointNear(Vector3 point, float randomRadius, float minDistance = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomRadius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_GetRandomReachablePointNear_Private_Vector3_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060042CF RID: 17103 RVA: 0x0014D800 File Offset: 0x0014BA00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153529, XrefRangeEnd = 153530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWorldspaceIconsActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_SetWorldspaceIconsActive_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042D0 RID: 17104 RVA: 0x0014D840 File Offset: 0x0014BA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153530, XrefRangeEnd = 153533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PursuitBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042D1 RID: 17105 RVA: 0x0014D87C File Offset: 0x0014BA7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153533, XrefRangeEnd = 153557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042D2 RID: 17106 RVA: 0x0014D8B8 File Offset: 0x0014BAB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153557, XrefRangeEnd = 153558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042D3 RID: 17107 RVA: 0x0014D8F4 File Offset: 0x0014BAF4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042D4 RID: 17108 RVA: 0x0014D930 File Offset: 0x0014BB30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153587, RefRangeEnd = 153588, XrefRangeStart = 153558, XrefRangeEnd = 153587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AssignTarget_1824087381(NetworkConnection conn, NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_AssignTarget_1824087381_Private_Void_NetworkConnection_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042D5 RID: 17109 RVA: 0x0014D984 File Offset: 0x0014BB84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 153605, RefRangeEnd = 153607, XrefRangeStart = 153588, XrefRangeEnd = 153605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___AssignTarget_1824087381(NetworkConnection conn, NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_RpcLogic___AssignTarget_1824087381_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042D6 RID: 17110 RVA: 0x0014D9E4 File Offset: 0x0014BBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153607, XrefRangeEnd = 153612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AssignTarget_1824087381(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_RpcReader___Observers_AssignTarget_1824087381_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001458 RID: 5208
		// (get) Token: 0x060042D7 RID: 17111 RVA: 0x0014DA34 File Offset: 0x0014BC34
		// (set) Token: 0x060042D8 RID: 17112 RVA: 0x0014DA70 File Offset: 0x0014BC70
		public unsafe bool SyncAccessor_isTargetVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_sync___get_value_isTargetVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 153620, RefRangeEnd = 153624, XrefRangeStart = 153612, XrefRangeEnd = 153620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_sync___set_value_isTargetVisible_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060042D9 RID: 17113 RVA: 0x0014DABC File Offset: 0x0014BCBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153624, XrefRangeEnd = 153627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_NPCs_Behaviour_PursuitBehaviour(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_NPCs_Behaviour_PursuitBehaviour_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060042DA RID: 17114 RVA: 0x0014DB30 File Offset: 0x0014BD30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153671, RefRangeEnd = 153672, XrefRangeStart = 153627, XrefRangeEnd = 153671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042DB RID: 17115 RVA: 0x00020B56 File Offset: 0x0001ED56
		public PursuitBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001430 RID: 5168
		// (get) Token: 0x060042DC RID: 17116 RVA: 0x0014DB6C File Offset: 0x0014BD6C
		// (set) Token: 0x060042DD RID: 17117 RVA: 0x00020B5F File Offset: 0x0001ED5F
		public unsafe static float ARREST_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_ARREST_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_ARREST_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17001431 RID: 5169
		// (get) Token: 0x060042DE RID: 17118 RVA: 0x0014DB88 File Offset: 0x0014BD88
		// (set) Token: 0x060042DF RID: 17119 RVA: 0x00020B6D File Offset: 0x0001ED6D
		public unsafe static float ARREST_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_ARREST_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_ARREST_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001432 RID: 5170
		// (get) Token: 0x060042E0 RID: 17120 RVA: 0x0014DBA4 File Offset: 0x0014BDA4
		// (set) Token: 0x060042E1 RID: 17121 RVA: 0x00020B7B File Offset: 0x0001ED7B
		public unsafe static float EXTRA_VISIBILITY_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001433 RID: 5171
		// (get) Token: 0x060042E2 RID: 17122 RVA: 0x0014DBC0 File Offset: 0x0014BDC0
		// (set) Token: 0x060042E3 RID: 17123 RVA: 0x00020B89 File Offset: 0x0001ED89
		public unsafe static float MOVE_SPEED_INVESTIGATING
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_INVESTIGATING, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_INVESTIGATING, (void*)(&value));
			}
		}

		// Token: 0x17001434 RID: 5172
		// (get) Token: 0x060042E4 RID: 17124 RVA: 0x0014DBDC File Offset: 0x0014BDDC
		// (set) Token: 0x060042E5 RID: 17125 RVA: 0x00020B97 File Offset: 0x0001ED97
		public unsafe static float MOVE_SPEED_ARRESTING
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_ARRESTING, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_ARRESTING, (void*)(&value));
			}
		}

		// Token: 0x17001435 RID: 5173
		// (get) Token: 0x060042E6 RID: 17126 RVA: 0x0014DBF8 File Offset: 0x0014BDF8
		// (set) Token: 0x060042E7 RID: 17127 RVA: 0x00020BA5 File Offset: 0x0001EDA5
		public unsafe static float MOVE_SPEED_CHASE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_CHASE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_CHASE, (void*)(&value));
			}
		}

		// Token: 0x17001436 RID: 5174
		// (get) Token: 0x060042E8 RID: 17128 RVA: 0x0014DC14 File Offset: 0x0014BE14
		// (set) Token: 0x060042E9 RID: 17129 RVA: 0x00020BB3 File Offset: 0x0001EDB3
		public unsafe static float MOVE_SPEED_SHOOTING
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_SHOOTING, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_SHOOTING, (void*)(&value));
			}
		}

		// Token: 0x17001437 RID: 5175
		// (get) Token: 0x060042EA RID: 17130 RVA: 0x0014DC30 File Offset: 0x0014BE30
		// (set) Token: 0x060042EB RID: 17131 RVA: 0x00020BC1 File Offset: 0x0001EDC1
		public unsafe static float SEARCH_RADIUS_MIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MIN, (void*)(&value));
			}
		}

		// Token: 0x17001438 RID: 5176
		// (get) Token: 0x060042EC RID: 17132 RVA: 0x0014DC4C File Offset: 0x0014BE4C
		// (set) Token: 0x060042ED RID: 17133 RVA: 0x00020BCF File Offset: 0x0001EDCF
		public unsafe static float SEARCH_RADIUS_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MAX, (void*)(&value));
			}
		}

		// Token: 0x17001439 RID: 5177
		// (get) Token: 0x060042EE RID: 17134 RVA: 0x0014DC68 File Offset: 0x0014BE68
		// (set) Token: 0x060042EF RID: 17135 RVA: 0x00020BDD File Offset: 0x0001EDDD
		public unsafe static float ARREST_MAX_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_ARREST_MAX_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_ARREST_MAX_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x1700143A RID: 5178
		// (get) Token: 0x060042F0 RID: 17136 RVA: 0x0014DC84 File Offset: 0x0014BE84
		// (set) Token: 0x060042F1 RID: 17137 RVA: 0x00020BEB File Offset: 0x0001EDEB
		public unsafe static int LEAVE_ARREST_CIRCLE_LIMIT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_LEAVE_ARREST_CIRCLE_LIMIT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_LEAVE_ARREST_CIRCLE_LIMIT, (void*)(&value));
			}
		}

		// Token: 0x1700143B RID: 5179
		// (get) Token: 0x060042F2 RID: 17138 RVA: 0x0014DCA0 File Offset: 0x0014BEA0
		// (set) Token: 0x060042F3 RID: 17139 RVA: 0x00020BF9 File Offset: 0x0001EDF9
		public unsafe static float CONSECUTIVE_MISS_ACCURACY_BOOST
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_CONSECUTIVE_MISS_ACCURACY_BOOST, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_CONSECUTIVE_MISS_ACCURACY_BOOST, (void*)(&value));
			}
		}

		// Token: 0x1700143C RID: 5180
		// (get) Token: 0x060042F4 RID: 17140 RVA: 0x0014DCBC File Offset: 0x0014BEBC
		// (set) Token: 0x060042F5 RID: 17141 RVA: 0x00020C07 File Offset: 0x0001EE07
		public unsafe Player _TargetPlayer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700143D RID: 5181
		// (get) Token: 0x060042F6 RID: 17142 RVA: 0x0014DCEC File Offset: 0x0014BEEC
		// (set) Token: 0x060042F7 RID: 17143 RVA: 0x00020C26 File Offset: 0x0001EE26
		public unsafe bool _IsSearching_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr__IsSearching_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr__IsSearching_k__BackingField)) = value;
			}
		}

		// Token: 0x1700143E RID: 5182
		// (get) Token: 0x060042F8 RID: 17144 RVA: 0x0014DD14 File Offset: 0x0014BF14
		// (set) Token: 0x060042F9 RID: 17145 RVA: 0x00020C41 File Offset: 0x0001EE41
		public unsafe float ArrestCircle_MaxVisibleDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxVisibleDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxVisibleDistance)) = value;
			}
		}

		// Token: 0x1700143F RID: 5183
		// (get) Token: 0x060042FA RID: 17146 RVA: 0x0014DD3C File Offset: 0x0014BF3C
		// (set) Token: 0x060042FB RID: 17147 RVA: 0x00020C5C File Offset: 0x0001EE5C
		public unsafe float ArrestCircle_MaxOpacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxOpacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxOpacity)) = value;
			}
		}

		// Token: 0x17001440 RID: 5184
		// (get) Token: 0x060042FC RID: 17148 RVA: 0x0014DD64 File Offset: 0x0014BF64
		// (set) Token: 0x060042FD RID: 17149 RVA: 0x00020C77 File Offset: 0x0001EE77
		public unsafe bool isTargetVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_isTargetVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_isTargetVisible)) = value;
			}
		}

		// Token: 0x17001441 RID: 5185
		// (get) Token: 0x060042FE RID: 17150 RVA: 0x0014DD8C File Offset: 0x0014BF8C
		// (set) Token: 0x060042FF RID: 17151 RVA: 0x00020C92 File Offset: 0x0001EE92
		public unsafe bool isTargetStrictlyVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_isTargetStrictlyVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_isTargetStrictlyVisible)) = value;
			}
		}

		// Token: 0x17001442 RID: 5186
		// (get) Token: 0x06004300 RID: 17152 RVA: 0x0014DDB4 File Offset: 0x0014BFB4
		// (set) Token: 0x06004301 RID: 17153 RVA: 0x00020CAD File Offset: 0x0001EEAD
		public unsafe bool arrestingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_arrestingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_arrestingEnabled)) = value;
			}
		}

		// Token: 0x17001443 RID: 5187
		// (get) Token: 0x06004302 RID: 17154 RVA: 0x0014DDDC File Offset: 0x0014BFDC
		// (set) Token: 0x06004303 RID: 17155 RVA: 0x00020CC8 File Offset: 0x0001EEC8
		public unsafe float timeSinceLastSighting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_timeSinceLastSighting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_timeSinceLastSighting)) = value;
			}
		}

		// Token: 0x17001444 RID: 5188
		// (get) Token: 0x06004304 RID: 17156 RVA: 0x0014DE04 File Offset: 0x0014C004
		// (set) Token: 0x06004305 RID: 17157 RVA: 0x00020CE3 File Offset: 0x0001EEE3
		public unsafe float currentPursuitLevelDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_currentPursuitLevelDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_currentPursuitLevelDuration)) = value;
			}
		}

		// Token: 0x17001445 RID: 5189
		// (get) Token: 0x06004306 RID: 17158 RVA: 0x0014DE2C File Offset: 0x0014C02C
		// (set) Token: 0x06004307 RID: 17159 RVA: 0x00020CFE File Offset: 0x0001EEFE
		public unsafe float timeWithinArrestRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_timeWithinArrestRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_timeWithinArrestRange)) = value;
			}
		}

		// Token: 0x17001446 RID: 5190
		// (get) Token: 0x06004308 RID: 17160 RVA: 0x0014DE54 File Offset: 0x0014C054
		// (set) Token: 0x06004309 RID: 17161 RVA: 0x00020D19 File Offset: 0x0001EF19
		public unsafe float playerSightedDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_playerSightedDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_playerSightedDuration)) = value;
			}
		}

		// Token: 0x17001447 RID: 5191
		// (get) Token: 0x0600430A RID: 17162 RVA: 0x0014DE7C File Offset: 0x0014C07C
		// (set) Token: 0x0600430B RID: 17163 RVA: 0x00020D34 File Offset: 0x0001EF34
		public unsafe float distanceOnPursuitStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_distanceOnPursuitStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_distanceOnPursuitStart)) = value;
			}
		}

		// Token: 0x17001448 RID: 5192
		// (get) Token: 0x0600430C RID: 17164 RVA: 0x0014DEA4 File Offset: 0x0014C0A4
		// (set) Token: 0x0600430D RID: 17165 RVA: 0x00020D4F File Offset: 0x0001EF4F
		public unsafe Coroutine searchRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_searchRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_searchRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001449 RID: 5193
		// (get) Token: 0x0600430E RID: 17166 RVA: 0x0014DED4 File Offset: 0x0014C0D4
		// (set) Token: 0x0600430F RID: 17167 RVA: 0x00020D6E File Offset: 0x0001EF6E
		public unsafe Coroutine rangedWeaponRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_rangedWeaponRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_rangedWeaponRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700144A RID: 5194
		// (get) Token: 0x06004310 RID: 17168 RVA: 0x0014DF04 File Offset: 0x0014C104
		// (set) Token: 0x06004311 RID: 17169 RVA: 0x00020D8D File Offset: 0x0001EF8D
		public unsafe Vector3 currentSearchDestination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_currentSearchDestination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_currentSearchDestination)) = value;
			}
		}

		// Token: 0x1700144B RID: 5195
		// (get) Token: 0x06004312 RID: 17170 RVA: 0x0014DF2C File Offset: 0x0014C12C
		// (set) Token: 0x06004313 RID: 17171 RVA: 0x00020DA8 File Offset: 0x0001EFA8
		public unsafe bool hasSearchDestination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_hasSearchDestination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_hasSearchDestination)) = value;
			}
		}

		// Token: 0x1700144C RID: 5196
		// (get) Token: 0x06004314 RID: 17172 RVA: 0x0014DF54 File Offset: 0x0014C154
		// (set) Token: 0x06004315 RID: 17173 RVA: 0x00020DC3 File Offset: 0x0001EFC3
		public unsafe PoliceOfficer officer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_officer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_officer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700144D RID: 5197
		// (get) Token: 0x06004316 RID: 17174 RVA: 0x0014DF84 File Offset: 0x0014C184
		// (set) Token: 0x06004317 RID: 17175 RVA: 0x00020DE2 File Offset: 0x0001EFE2
		public unsafe bool targetWasDrivingOnPursuitStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_targetWasDrivingOnPursuitStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_targetWasDrivingOnPursuitStart)) = value;
			}
		}

		// Token: 0x1700144E RID: 5198
		// (get) Token: 0x06004318 RID: 17176 RVA: 0x0014DFAC File Offset: 0x0014C1AC
		// (set) Token: 0x06004319 RID: 17177 RVA: 0x00020DFD File Offset: 0x0001EFFD
		public unsafe bool wasInArrestCircleLastFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_wasInArrestCircleLastFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_wasInArrestCircleLastFrame)) = value;
			}
		}

		// Token: 0x1700144F RID: 5199
		// (get) Token: 0x0600431A RID: 17178 RVA: 0x0014DFD4 File Offset: 0x0014C1D4
		// (set) Token: 0x0600431B RID: 17179 RVA: 0x00020E18 File Offset: 0x0001F018
		public unsafe int leaveArrestCircleCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_leaveArrestCircleCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_leaveArrestCircleCount)) = value;
			}
		}

		// Token: 0x17001450 RID: 5200
		// (get) Token: 0x0600431C RID: 17180 RVA: 0x0014DFFC File Offset: 0x0014C1FC
		// (set) Token: 0x0600431D RID: 17181 RVA: 0x00020E33 File Offset: 0x0001F033
		public unsafe AvatarRangedWeapon rangedWeapon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_rangedWeapon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarRangedWeapon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_rangedWeapon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001451 RID: 5201
		// (get) Token: 0x0600431E RID: 17182 RVA: 0x0014E02C File Offset: 0x0014C22C
		// (set) Token: 0x0600431F RID: 17183 RVA: 0x00020E52 File Offset: 0x0001F052
		public unsafe int consecutiveMissedShots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_consecutiveMissedShots);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_consecutiveMissedShots)) = value;
			}
		}

		// Token: 0x17001452 RID: 5202
		// (get) Token: 0x06004320 RID: 17184 RVA: 0x0014E054 File Offset: 0x0014C254
		// (set) Token: 0x06004321 RID: 17185 RVA: 0x00020E6D File Offset: 0x0001F06D
		public unsafe float nextAngryVO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_nextAngryVO);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_nextAngryVO)) = value;
			}
		}

		// Token: 0x17001453 RID: 5203
		// (get) Token: 0x06004322 RID: 17186 RVA: 0x0014E07C File Offset: 0x0014C27C
		// (set) Token: 0x06004323 RID: 17187 RVA: 0x00020E88 File Offset: 0x0001F088
		public unsafe SyncVar<bool> syncVar___isTargetVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_syncVar___isTargetVisible);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_syncVar___isTargetVisible), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001454 RID: 5204
		// (get) Token: 0x06004324 RID: 17188 RVA: 0x0014E0AC File Offset: 0x0014C2AC
		// (set) Token: 0x06004325 RID: 17189 RVA: 0x00020EA7 File Offset: 0x0001F0A7
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001455 RID: 5205
		// (get) Token: 0x06004326 RID: 17190 RVA: 0x0014E0D4 File Offset: 0x0014C2D4
		// (set) Token: 0x06004327 RID: 17191 RVA: 0x00020EC2 File Offset: 0x0001F0C2
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002C8A RID: 11402
		private static readonly IntPtr NativeFieldInfoPtr_ARREST_RANGE;

		// Token: 0x04002C8B RID: 11403
		private static readonly IntPtr NativeFieldInfoPtr_ARREST_TIME;

		// Token: 0x04002C8C RID: 11404
		private static readonly IntPtr NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME;

		// Token: 0x04002C8D RID: 11405
		private static readonly IntPtr NativeFieldInfoPtr_MOVE_SPEED_INVESTIGATING;

		// Token: 0x04002C8E RID: 11406
		private static readonly IntPtr NativeFieldInfoPtr_MOVE_SPEED_ARRESTING;

		// Token: 0x04002C8F RID: 11407
		private static readonly IntPtr NativeFieldInfoPtr_MOVE_SPEED_CHASE;

		// Token: 0x04002C90 RID: 11408
		private static readonly IntPtr NativeFieldInfoPtr_MOVE_SPEED_SHOOTING;

		// Token: 0x04002C91 RID: 11409
		private static readonly IntPtr NativeFieldInfoPtr_SEARCH_RADIUS_MIN;

		// Token: 0x04002C92 RID: 11410
		private static readonly IntPtr NativeFieldInfoPtr_SEARCH_RADIUS_MAX;

		// Token: 0x04002C93 RID: 11411
		private static readonly IntPtr NativeFieldInfoPtr_ARREST_MAX_DISTANCE;

		// Token: 0x04002C94 RID: 11412
		private static readonly IntPtr NativeFieldInfoPtr_LEAVE_ARREST_CIRCLE_LIMIT;

		// Token: 0x04002C95 RID: 11413
		private static readonly IntPtr NativeFieldInfoPtr_CONSECUTIVE_MISS_ACCURACY_BOOST;

		// Token: 0x04002C96 RID: 11414
		private static readonly IntPtr NativeFieldInfoPtr__TargetPlayer_k__BackingField;

		// Token: 0x04002C97 RID: 11415
		private static readonly IntPtr NativeFieldInfoPtr__IsSearching_k__BackingField;

		// Token: 0x04002C98 RID: 11416
		private static readonly IntPtr NativeFieldInfoPtr_ArrestCircle_MaxVisibleDistance;

		// Token: 0x04002C99 RID: 11417
		private static readonly IntPtr NativeFieldInfoPtr_ArrestCircle_MaxOpacity;

		// Token: 0x04002C9A RID: 11418
		private static readonly IntPtr NativeFieldInfoPtr_isTargetVisible;

		// Token: 0x04002C9B RID: 11419
		private static readonly IntPtr NativeFieldInfoPtr_isTargetStrictlyVisible;

		// Token: 0x04002C9C RID: 11420
		private static readonly IntPtr NativeFieldInfoPtr_arrestingEnabled;

		// Token: 0x04002C9D RID: 11421
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastSighting;

		// Token: 0x04002C9E RID: 11422
		private static readonly IntPtr NativeFieldInfoPtr_currentPursuitLevelDuration;

		// Token: 0x04002C9F RID: 11423
		private static readonly IntPtr NativeFieldInfoPtr_timeWithinArrestRange;

		// Token: 0x04002CA0 RID: 11424
		private static readonly IntPtr NativeFieldInfoPtr_playerSightedDuration;

		// Token: 0x04002CA1 RID: 11425
		private static readonly IntPtr NativeFieldInfoPtr_distanceOnPursuitStart;

		// Token: 0x04002CA2 RID: 11426
		private static readonly IntPtr NativeFieldInfoPtr_searchRoutine;

		// Token: 0x04002CA3 RID: 11427
		private static readonly IntPtr NativeFieldInfoPtr_rangedWeaponRoutine;

		// Token: 0x04002CA4 RID: 11428
		private static readonly IntPtr NativeFieldInfoPtr_currentSearchDestination;

		// Token: 0x04002CA5 RID: 11429
		private static readonly IntPtr NativeFieldInfoPtr_hasSearchDestination;

		// Token: 0x04002CA6 RID: 11430
		private static readonly IntPtr NativeFieldInfoPtr_officer;

		// Token: 0x04002CA7 RID: 11431
		private static readonly IntPtr NativeFieldInfoPtr_targetWasDrivingOnPursuitStart;

		// Token: 0x04002CA8 RID: 11432
		private static readonly IntPtr NativeFieldInfoPtr_wasInArrestCircleLastFrame;

		// Token: 0x04002CA9 RID: 11433
		private static readonly IntPtr NativeFieldInfoPtr_leaveArrestCircleCount;

		// Token: 0x04002CAA RID: 11434
		private static readonly IntPtr NativeFieldInfoPtr_rangedWeapon;

		// Token: 0x04002CAB RID: 11435
		private static readonly IntPtr NativeFieldInfoPtr_consecutiveMissedShots;

		// Token: 0x04002CAC RID: 11436
		private static readonly IntPtr NativeFieldInfoPtr_nextAngryVO;

		// Token: 0x04002CAD RID: 11437
		private static readonly IntPtr NativeFieldInfoPtr_syncVar___isTargetVisible;

		// Token: 0x04002CAE RID: 11438
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002CAF RID: 11439
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002CB0 RID: 11440
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0;

		// Token: 0x04002CB1 RID: 11441
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0;

		// Token: 0x04002CB2 RID: 11442
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSearching_Public_get_Boolean_0;

		// Token: 0x04002CB3 RID: 11443
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSearching_Protected_set_Void_Boolean_0;

		// Token: 0x04002CB4 RID: 11444
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04002CB5 RID: 11445
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04002CB6 RID: 11446
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04002CB7 RID: 11447
		private static readonly IntPtr NativeMethodInfoPtr_AssignTarget_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x04002CB8 RID: 11448
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1;

		// Token: 0x04002CB9 RID: 11449
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1;

		// Token: 0x04002CBA RID: 11450
		private static readonly IntPtr NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0;

		// Token: 0x04002CBB RID: 11451
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x04002CBC RID: 11452
		private static readonly IntPtr NativeMethodInfoPtr_IsTargetValid_Private_Boolean_0;

		// Token: 0x04002CBD RID: 11453
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04002CBE RID: 11454
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInvestigatingBehaviour_Protected_Virtual_New_Void_0;

		// Token: 0x04002CBF RID: 11455
		private static readonly IntPtr NativeMethodInfoPtr_UpdateArrestBehaviour_Protected_Virtual_New_Void_0;

		// Token: 0x04002CC0 RID: 11456
		private static readonly IntPtr NativeMethodInfoPtr_UpdateArrest_Private_Void_Single_0;

		// Token: 0x04002CC1 RID: 11457
		private static readonly IntPtr NativeMethodInfoPtr_GetNewArrestDestination_Private_Vector3_0;

		// Token: 0x04002CC2 RID: 11458
		private static readonly IntPtr NativeMethodInfoPtr_ClearSpeedControls_Private_Void_0;

		// Token: 0x04002CC3 RID: 11459
		private static readonly IntPtr NativeMethodInfoPtr_UpdateNonLethalBehaviour_Protected_Virtual_New_Void_0;

		// Token: 0x04002CC4 RID: 11460
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLethalBehaviour_Protected_Virtual_New_Void_0;

		// Token: 0x04002CC5 RID: 11461
		private static readonly IntPtr NativeMethodInfoPtr_RangedWeaponRoutine_Private_IEnumerator_0;

		// Token: 0x04002CC6 RID: 11462
		private static readonly IntPtr NativeMethodInfoPtr_CanShoot_Private_Boolean_0;

		// Token: 0x04002CC7 RID: 11463
		private static readonly IntPtr NativeMethodInfoPtr_Shoot_Private_Boolean_0;

		// Token: 0x04002CC8 RID: 11464
		private static readonly IntPtr NativeMethodInfoPtr_SetWeaponRaised_Private_Void_Boolean_0;

		// Token: 0x04002CC9 RID: 11465
		private static readonly IntPtr NativeMethodInfoPtr_StopRangedWeaponRoutine_Private_Void_0;

		// Token: 0x04002CCA RID: 11466
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLookAt_Protected_Virtual_New_Void_0;

		// Token: 0x04002CCB RID: 11467
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEquippable_Protected_Virtual_New_Void_0;

		// Token: 0x04002CCC RID: 11468
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x04002CCD RID: 11469
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1;

		// Token: 0x04002CCE RID: 11470
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_1;

		// Token: 0x04002CCF RID: 11471
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Private_Void_0;

		// Token: 0x04002CD0 RID: 11472
		private static readonly IntPtr NativeMethodInfoPtr_ClearEquippables_Private_Void_0;

		// Token: 0x04002CD1 RID: 11473
		private static readonly IntPtr NativeMethodInfoPtr_CheckPlayerVisibility_Protected_Void_0;

		// Token: 0x04002CD2 RID: 11474
		private static readonly IntPtr NativeMethodInfoPtr_MarkPlayerVisible_Public_Void_0;

		// Token: 0x04002CD3 RID: 11475
		private static readonly IntPtr NativeMethodInfoPtr_IsPlayerVisible_Protected_Boolean_0;

		// Token: 0x04002CD4 RID: 11476
		private static readonly IntPtr NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0;

		// Token: 0x04002CD5 RID: 11477
		private static readonly IntPtr NativeMethodInfoPtr_ProcessThirdPartyVisionEvent_Private_Void_VisionEventReceipt_0;

		// Token: 0x04002CD6 RID: 11478
		private static readonly IntPtr NativeMethodInfoPtr_UpdateArrestCircle_Protected_Virtual_New_Void_0;

		// Token: 0x04002CD7 RID: 11479
		private static readonly IntPtr NativeMethodInfoPtr_ResetArrestProgress_Public_Void_0;

		// Token: 0x04002CD8 RID: 11480
		private static readonly IntPtr NativeMethodInfoPtr_SetArrestCircleAlpha_Private_Void_Single_0;

		// Token: 0x04002CD9 RID: 11481
		private static readonly IntPtr NativeMethodInfoPtr_SetArrestCircleColor_Private_Void_Color_0;

		// Token: 0x04002CDA RID: 11482
		private static readonly IntPtr NativeMethodInfoPtr_StartSearching_Private_Void_0;

		// Token: 0x04002CDB RID: 11483
		private static readonly IntPtr NativeMethodInfoPtr_StopSearching_Private_Void_0;

		// Token: 0x04002CDC RID: 11484
		private static readonly IntPtr NativeMethodInfoPtr_SearchRoutine_Private_IEnumerator_0;

		// Token: 0x04002CDD RID: 11485
		private static readonly IntPtr NativeMethodInfoPtr_GetNextSearchLocation_Private_Vector3_0;

		// Token: 0x04002CDE RID: 11486
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomReachablePointNear_Private_Vector3_Vector3_Single_Single_0;

		// Token: 0x04002CDF RID: 11487
		private static readonly IntPtr NativeMethodInfoPtr_SetWorldspaceIconsActive_Private_Void_Boolean_0;

		// Token: 0x04002CE0 RID: 11488
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002CE1 RID: 11489
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002CE2 RID: 11490
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002CE3 RID: 11491
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002CE4 RID: 11492
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AssignTarget_1824087381_Private_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x04002CE5 RID: 11493
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AssignTarget_1824087381_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x04002CE6 RID: 11494
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AssignTarget_1824087381_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002CE7 RID: 11495
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value_isTargetVisible_Public_get_Boolean_0;

		// Token: 0x04002CE8 RID: 11496
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value_isTargetVisible_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x04002CE9 RID: 11497
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_NPCs_Behaviour_PursuitBehaviour_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04002CEA RID: 11498
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000962 RID: 2402
		[OriginalName("Assembly-CSharp.dll", "", "EPursuitAction")]
		public enum EPursuitAction
		{
			// Token: 0x04008820 RID: 34848
			None,
			// Token: 0x04008821 RID: 34849
			Move,
			// Token: 0x04008822 RID: 34850
			Shoot,
			// Token: 0x04008823 RID: 34851
			MoveAndShoot
		}

		// Token: 0x02000963 RID: 2403
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.PursuitBehaviour+<RangedWeaponRoutine>d__59")]
		public sealed class _RangedWeaponRoutine_d__59 : Il2CppSystem.Object
		{
			// Token: 0x0600C920 RID: 51488 RVA: 0x0030B5F8 File Offset: 0x003097F8
			// Note: this type is marked as 'beforefieldinit'.
			static _RangedWeaponRoutine_d__59()
			{
				Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "<RangedWeaponRoutine>d__59");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr);
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, "<>1__state");
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, "<>2__current");
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, "<>4__this");
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr__currentAction_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, "<currentAction>5__2");
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr__currentActionDuration_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, "<currentActionDuration>5__3");
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr__currentActionTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, "<currentActionTime>5__4");
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, 100671478);
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, 100671479);
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, 100671480);
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, 100671481);
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, 100671482);
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, 100671483);
			}

			// Token: 0x0600C921 RID: 51489 RVA: 0x0030B714 File Offset: 0x00309914
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RangedWeaponRoutine_d__59(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C922 RID: 51490 RVA: 0x0030B75C File Offset: 0x0030995C
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C923 RID: 51491 RVA: 0x0030B790 File Offset: 0x00309990
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152893, XrefRangeEnd = 153009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003EC3 RID: 16067
			// (get) Token: 0x0600C924 RID: 51492 RVA: 0x0030B7CC File Offset: 0x003099CC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C925 RID: 51493 RVA: 0x0030B80C File Offset: 0x00309A0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153009, XrefRangeEnd = 153014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003EC4 RID: 16068
			// (get) Token: 0x0600C926 RID: 51494 RVA: 0x0030B840 File Offset: 0x00309A40
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C927 RID: 51495 RVA: 0x00061D4B File Offset: 0x0005FF4B
			public _RangedWeaponRoutine_d__59(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EBD RID: 16061
			// (get) Token: 0x0600C928 RID: 51496 RVA: 0x0030B880 File Offset: 0x00309A80
			// (set) Token: 0x0600C929 RID: 51497 RVA: 0x00061D54 File Offset: 0x0005FF54
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003EBE RID: 16062
			// (get) Token: 0x0600C92A RID: 51498 RVA: 0x0030B8A8 File Offset: 0x00309AA8
			// (set) Token: 0x0600C92B RID: 51499 RVA: 0x00061D6F File Offset: 0x0005FF6F
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EBF RID: 16063
			// (get) Token: 0x0600C92C RID: 51500 RVA: 0x0030B8D8 File Offset: 0x00309AD8
			// (set) Token: 0x0600C92D RID: 51501 RVA: 0x00061D8E File Offset: 0x0005FF8E
			public unsafe PursuitBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PursuitBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EC0 RID: 16064
			// (get) Token: 0x0600C92E RID: 51502 RVA: 0x0030B908 File Offset: 0x00309B08
			// (set) Token: 0x0600C92F RID: 51503 RVA: 0x00061DAD File Offset: 0x0005FFAD
			public unsafe PursuitBehaviour.EPursuitAction _currentAction_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr__currentAction_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr__currentAction_5__2)) = value;
				}
			}

			// Token: 0x17003EC1 RID: 16065
			// (get) Token: 0x0600C930 RID: 51504 RVA: 0x0030B930 File Offset: 0x00309B30
			// (set) Token: 0x0600C931 RID: 51505 RVA: 0x00061DC8 File Offset: 0x0005FFC8
			public unsafe float _currentActionDuration_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr__currentActionDuration_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr__currentActionDuration_5__3)) = value;
				}
			}

			// Token: 0x17003EC2 RID: 16066
			// (get) Token: 0x0600C932 RID: 51506 RVA: 0x0030B958 File Offset: 0x00309B58
			// (set) Token: 0x0600C933 RID: 51507 RVA: 0x00061DE3 File Offset: 0x0005FFE3
			public unsafe float _currentActionTime_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr__currentActionTime_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr__currentActionTime_5__4)) = value;
				}
			}

			// Token: 0x04008824 RID: 34852
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008825 RID: 34853
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008826 RID: 34854
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008827 RID: 34855
			private static readonly IntPtr NativeFieldInfoPtr__currentAction_5__2;

			// Token: 0x04008828 RID: 34856
			private static readonly IntPtr NativeFieldInfoPtr__currentActionDuration_5__3;

			// Token: 0x04008829 RID: 34857
			private static readonly IntPtr NativeFieldInfoPtr__currentActionTime_5__4;

			// Token: 0x0400882A RID: 34858
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400882B RID: 34859
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400882C RID: 34860
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400882D RID: 34861
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400882E RID: 34862
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400882F RID: 34863
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000964 RID: 2404
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.PursuitBehaviour+<SearchRoutine>d__82")]
		public sealed class _SearchRoutine_d__82 : Il2CppSystem.Object
		{
			// Token: 0x0600C934 RID: 51508 RVA: 0x0030B980 File Offset: 0x00309B80
			// Note: this type is marked as 'beforefieldinit'.
			static _SearchRoutine_d__82()
			{
				Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "<SearchRoutine>d__82");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr);
				PursuitBehaviour._SearchRoutine_d__82.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr, "<>1__state");
				PursuitBehaviour._SearchRoutine_d__82.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr, "<>2__current");
				PursuitBehaviour._SearchRoutine_d__82.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr, "<>4__this");
				PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr, 100671484);
				PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr, 100671485);
				PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr, 100671486);
				PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr, 100671487);
				PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr, 100671488);
				PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr, 100671489);
			}

			// Token: 0x0600C935 RID: 51509 RVA: 0x0030BA60 File Offset: 0x00309C60
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SearchRoutine_d__82(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C936 RID: 51510 RVA: 0x0030BAA8 File Offset: 0x00309CA8
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C937 RID: 51511 RVA: 0x0030BADC File Offset: 0x00309CDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153014, XrefRangeEnd = 153015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003EC8 RID: 16072
			// (get) Token: 0x0600C938 RID: 51512 RVA: 0x0030BB18 File Offset: 0x00309D18
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C939 RID: 51513 RVA: 0x0030BB58 File Offset: 0x00309D58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153015, XrefRangeEnd = 153020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003EC9 RID: 16073
			// (get) Token: 0x0600C93A RID: 51514 RVA: 0x0030BB8C File Offset: 0x00309D8C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C93B RID: 51515 RVA: 0x00061DFE File Offset: 0x0005FFFE
			public _SearchRoutine_d__82(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EC5 RID: 16069
			// (get) Token: 0x0600C93C RID: 51516 RVA: 0x0030BBCC File Offset: 0x00309DCC
			// (set) Token: 0x0600C93D RID: 51517 RVA: 0x00061E07 File Offset: 0x00060007
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._SearchRoutine_d__82.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._SearchRoutine_d__82.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003EC6 RID: 16070
			// (get) Token: 0x0600C93E RID: 51518 RVA: 0x0030BBF4 File Offset: 0x00309DF4
			// (set) Token: 0x0600C93F RID: 51519 RVA: 0x00061E22 File Offset: 0x00060022
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._SearchRoutine_d__82.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._SearchRoutine_d__82.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EC7 RID: 16071
			// (get) Token: 0x0600C940 RID: 51520 RVA: 0x0030BC24 File Offset: 0x00309E24
			// (set) Token: 0x0600C941 RID: 51521 RVA: 0x00061E41 File Offset: 0x00060041
			public unsafe PursuitBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._SearchRoutine_d__82.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PursuitBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._SearchRoutine_d__82.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008830 RID: 34864
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008831 RID: 34865
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008832 RID: 34866
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008833 RID: 34867
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008834 RID: 34868
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008835 RID: 34869
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008836 RID: 34870
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008837 RID: 34871
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008838 RID: 34872
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
