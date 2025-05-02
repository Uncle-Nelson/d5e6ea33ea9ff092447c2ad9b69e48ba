using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Vision;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Combat
{
	// Token: 0x02000498 RID: 1176
	public class CombatBehaviour : Il2CppScheduleOne.NPCs.Behaviour.Behaviour
	{
		// Token: 0x060065B8 RID: 26040 RVA: 0x001CA8D8 File Offset: 0x001C8AD8
		// Note: this type is marked as 'beforefieldinit'.
		static CombatBehaviour()
		{
			Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Combat", "CombatBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr);
			CombatBehaviour.NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "EXTRA_VISIBILITY_TIME");
			CombatBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "SEARCH_RADIUS_MIN");
			CombatBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "SEARCH_RADIUS_MAX");
			CombatBehaviour.NativeFieldInfoPtr_SEARCH_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "SEARCH_SPEED");
			CombatBehaviour.NativeFieldInfoPtr_CONSECUTIVE_MISS_ACCURACY_BOOST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "CONSECUTIVE_MISS_ACCURACY_BOOST");
			CombatBehaviour.NativeFieldInfoPtr_REACHED_DESTINATION_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "REACHED_DESTINATION_DISTANCE");
			CombatBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "<TargetPlayer>k__BackingField");
			CombatBehaviour.NativeFieldInfoPtr__IsSearching_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "<IsSearching>k__BackingField");
			CombatBehaviour.NativeFieldInfoPtr__TimeSinceTargetReacquired_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "<TimeSinceTargetReacquired>k__BackingField");
			CombatBehaviour.NativeFieldInfoPtr_GiveUpRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "GiveUpRange");
			CombatBehaviour.NativeFieldInfoPtr_GiveUpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "GiveUpTime");
			CombatBehaviour.NativeFieldInfoPtr_GiveUpAfterSuccessfulHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "GiveUpAfterSuccessfulHits");
			CombatBehaviour.NativeFieldInfoPtr_PlayAngryVO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "PlayAngryVO");
			CombatBehaviour.NativeFieldInfoPtr_DefaultMovementSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "DefaultMovementSpeed");
			CombatBehaviour.NativeFieldInfoPtr_DefaultWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "DefaultWeapon");
			CombatBehaviour.NativeFieldInfoPtr_VirtualPunchWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "VirtualPunchWeapon");
			CombatBehaviour.NativeFieldInfoPtr_DefaultSearchTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "DefaultSearchTime");
			CombatBehaviour.NativeFieldInfoPtr_overrideTargetDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "overrideTargetDistance");
			CombatBehaviour.NativeFieldInfoPtr_targetDistanceOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "targetDistanceOverride");
			CombatBehaviour.NativeFieldInfoPtr_isTargetRecentlyVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "isTargetRecentlyVisible");
			CombatBehaviour.NativeFieldInfoPtr_isTargetImmediatelyVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "isTargetImmediatelyVisible");
			CombatBehaviour.NativeFieldInfoPtr_timeSinceLastSighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "timeSinceLastSighting");
			CombatBehaviour.NativeFieldInfoPtr_playerSightedDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "playerSightedDuration");
			CombatBehaviour.NativeFieldInfoPtr_lastKnownTargetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "lastKnownTargetPosition");
			CombatBehaviour.NativeFieldInfoPtr_currentWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "currentWeapon");
			CombatBehaviour.NativeFieldInfoPtr_successfulHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "successfulHits");
			CombatBehaviour.NativeFieldInfoPtr_consecutiveMissedShots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "consecutiveMissedShots");
			CombatBehaviour.NativeFieldInfoPtr_rangedWeaponRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "rangedWeaponRoutine");
			CombatBehaviour.NativeFieldInfoPtr_searchRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "searchRoutine");
			CombatBehaviour.NativeFieldInfoPtr_currentSearchDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "currentSearchDestination");
			CombatBehaviour.NativeFieldInfoPtr_hasSearchDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "hasSearchDestination");
			CombatBehaviour.NativeFieldInfoPtr_nextAngryVO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "nextAngryVO");
			CombatBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Combat.CombatBehaviourAssembly-CSharp.dll_Excuted");
			CombatBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Combat.CombatBehaviourAssembly-CSharp.dll_Excuted");
			CombatBehaviour.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676155);
			CombatBehaviour.NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676156);
			CombatBehaviour.NativeMethodInfoPtr_get_IsSearching_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676157);
			CombatBehaviour.NativeMethodInfoPtr_set_IsSearching_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676158);
			CombatBehaviour.NativeMethodInfoPtr_get_TimeSinceTargetReacquired_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676159);
			CombatBehaviour.NativeMethodInfoPtr_set_TimeSinceTargetReacquired_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676160);
			CombatBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676161);
			CombatBehaviour.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676162);
			CombatBehaviour.NativeMethodInfoPtr_SetTarget_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676163);
			CombatBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676164);
			CombatBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676165);
			CombatBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676166);
			CombatBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676167);
			CombatBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676168);
			CombatBehaviour.NativeMethodInfoPtr_StartCombat_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676169);
			CombatBehaviour.NativeMethodInfoPtr_EndCombat_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676170);
			CombatBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676171);
			CombatBehaviour.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676172);
			CombatBehaviour.NativeMethodInfoPtr_UpdateTimeout_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676173);
			CombatBehaviour.NativeMethodInfoPtr_UpdateLookAt_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676174);
			CombatBehaviour.NativeMethodInfoPtr_SetMovementSpeed_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676175);
			CombatBehaviour.NativeMethodInfoPtr_SetWeapon_Protected_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676176);
			CombatBehaviour.NativeMethodInfoPtr_ClearWeapon_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676177);
			CombatBehaviour.NativeMethodInfoPtr_ReadyToAttack_Protected_Virtual_New_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676178);
			CombatBehaviour.NativeMethodInfoPtr_Attack_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676179);
			CombatBehaviour.NativeMethodInfoPtr_SucessfulHit_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676180);
			CombatBehaviour.NativeMethodInfoPtr_CheckPlayerVisibility_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676181);
			CombatBehaviour.NativeMethodInfoPtr_MarkPlayerVisible_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676182);
			CombatBehaviour.NativeMethodInfoPtr_IsPlayerVisible_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676183);
			CombatBehaviour.NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676184);
			CombatBehaviour.NativeMethodInfoPtr_GetSearchTime_Protected_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676185);
			CombatBehaviour.NativeMethodInfoPtr_StartSearching_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676186);
			CombatBehaviour.NativeMethodInfoPtr_StopSearching_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676187);
			CombatBehaviour.NativeMethodInfoPtr_SearchRoutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676188);
			CombatBehaviour.NativeMethodInfoPtr_GetNextSearchLocation_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676189);
			CombatBehaviour.NativeMethodInfoPtr_IsTargetValid_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676190);
			CombatBehaviour.NativeMethodInfoPtr_RepositionToTargetRange_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676191);
			CombatBehaviour.NativeMethodInfoPtr_GetRandomReachablePointNear_Private_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676192);
			CombatBehaviour.NativeMethodInfoPtr_GetMinTargetDistance_Protected_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676193);
			CombatBehaviour.NativeMethodInfoPtr_GetMaxTargetDistance_Protected_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676194);
			CombatBehaviour.NativeMethodInfoPtr_IsTargetInRange_Protected_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676195);
			CombatBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676196);
			CombatBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676197);
			CombatBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676198);
			CombatBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676199);
			CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetTarget_1824087381_Private_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676200);
			CombatBehaviour.NativeMethodInfoPtr_RpcLogic___SetTarget_1824087381_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676201);
			CombatBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetTarget_1824087381_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676202);
			CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetWeapon_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676203);
			CombatBehaviour.NativeMethodInfoPtr_RpcLogic___SetWeapon_3615296227_Protected_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676204);
			CombatBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetWeapon_3615296227_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676205);
			CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_ClearWeapon_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676206);
			CombatBehaviour.NativeMethodInfoPtr_RpcLogic___ClearWeapon_2166136261_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676207);
			CombatBehaviour.NativeMethodInfoPtr_RpcReader___Observers_ClearWeapon_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676208);
			CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_Attack_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676209);
			CombatBehaviour.NativeMethodInfoPtr_RpcLogic___Attack_2166136261_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676210);
			CombatBehaviour.NativeMethodInfoPtr_RpcReader___Observers_Attack_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676211);
			CombatBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676212);
		}

		// Token: 0x17001EC4 RID: 7876
		// (get) Token: 0x060065B9 RID: 26041 RVA: 0x001CB038 File Offset: 0x001C9238
		// (set) Token: 0x060065BA RID: 26042 RVA: 0x001CB078 File Offset: 0x001C9278
		public unsafe Player TargetPlayer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001EC5 RID: 7877
		// (get) Token: 0x060065BB RID: 26043 RVA: 0x001CB0BC File Offset: 0x001C92BC
		// (set) Token: 0x060065BC RID: 26044 RVA: 0x001CB0F8 File Offset: 0x001C92F8
		public unsafe bool IsSearching
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_get_IsSearching_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_set_IsSearching_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001EC6 RID: 7878
		// (get) Token: 0x060065BD RID: 26045 RVA: 0x001CB138 File Offset: 0x001C9338
		// (set) Token: 0x060065BE RID: 26046 RVA: 0x001CB174 File Offset: 0x001C9374
		public unsafe float TimeSinceTargetReacquired
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_get_TimeSinceTargetReacquired_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_set_TimeSinceTargetReacquired_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060065BF RID: 26047 RVA: 0x001CB1B4 File Offset: 0x001C93B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206274, XrefRangeEnd = 206291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065C0 RID: 26048 RVA: 0x001CB1F0 File Offset: 0x001C93F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206291, XrefRangeEnd = 206296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065C1 RID: 26049 RVA: 0x001CB240 File Offset: 0x001C9440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206296, XrefRangeEnd = 206301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetTarget(NetworkConnection conn, NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_SetTarget_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065C2 RID: 26050 RVA: 0x001CB2A0 File Offset: 0x001C94A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206301, XrefRangeEnd = 206308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065C3 RID: 26051 RVA: 0x001CB2DC File Offset: 0x001C94DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206308, XrefRangeEnd = 206309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065C4 RID: 26052 RVA: 0x001CB318 File Offset: 0x001C9518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206309, XrefRangeEnd = 206311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065C5 RID: 26053 RVA: 0x001CB354 File Offset: 0x001C9554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206311, XrefRangeEnd = 206313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065C6 RID: 26054 RVA: 0x001CB390 File Offset: 0x001C9590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065C7 RID: 26055 RVA: 0x001CB3CC File Offset: 0x001C95CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206313, XrefRangeEnd = 206338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartCombat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_StartCombat_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065C8 RID: 26056 RVA: 0x001CB408 File Offset: 0x001C9608
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206366, RefRangeEnd = 206368, XrefRangeStart = 206338, XrefRangeEnd = 206366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndCombat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_EndCombat_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065C9 RID: 26057 RVA: 0x001CB43C File Offset: 0x001C963C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206368, XrefRangeEnd = 206433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BehaviourUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065CA RID: 26058 RVA: 0x001CB478 File Offset: 0x001C9678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206433, XrefRangeEnd = 206436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065CB RID: 26059 RVA: 0x001CB4B4 File Offset: 0x001C96B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206436, XrefRangeEnd = 206438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTimeout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_UpdateTimeout_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065CC RID: 26060 RVA: 0x001CB4E8 File Offset: 0x001C96E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206438, XrefRangeEnd = 206445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateLookAt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_UpdateLookAt_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065CD RID: 26061 RVA: 0x001CB524 File Offset: 0x001C9724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206445, XrefRangeEnd = 206454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMovementSpeed(float speed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref speed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_SetMovementSpeed_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065CE RID: 26062 RVA: 0x001CB564 File Offset: 0x001C9764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206454, XrefRangeEnd = 206476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetWeapon(string weaponPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(weaponPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_SetWeapon_Protected_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065CF RID: 26063 RVA: 0x001CB5B4 File Offset: 0x001C97B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206497, RefRangeEnd = 206499, XrefRangeStart = 206476, XrefRangeEnd = 206497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearWeapon()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_ClearWeapon_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065D0 RID: 26064 RVA: 0x001CB5E8 File Offset: 0x001C97E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206499, XrefRangeEnd = 206504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ReadyToAttack(bool checkTarget = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref checkTarget;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_ReadyToAttack_Protected_Virtual_New_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060065D1 RID: 26065 RVA: 0x001CB63C File Offset: 0x001C983C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206504, XrefRangeEnd = 206525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Attack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_Attack_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065D2 RID: 26066 RVA: 0x001CB678 File Offset: 0x001C9878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206525, XrefRangeEnd = 206526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SucessfulHit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_SucessfulHit_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065D3 RID: 26067 RVA: 0x001CB6AC File Offset: 0x001C98AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206547, RefRangeEnd = 206549, XrefRangeStart = 206526, XrefRangeEnd = 206547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckPlayerVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_CheckPlayerVisibility_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065D4 RID: 26068 RVA: 0x001CB6E0 File Offset: 0x001C98E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206549, XrefRangeEnd = 206553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkPlayerVisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_MarkPlayerVisible_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065D5 RID: 26069 RVA: 0x001CB714 File Offset: 0x001C9914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayerVisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_IsPlayerVisible_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060065D6 RID: 26070 RVA: 0x001CB750 File Offset: 0x001C9950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206553, XrefRangeEnd = 206561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessVisionEvent(VisionEventReceipt visionEventReceipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visionEventReceipt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065D7 RID: 26071 RVA: 0x001CB794 File Offset: 0x001C9994
		[CallerCount(0)]
		public unsafe virtual float GetSearchTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_GetSearchTime_Protected_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060065D8 RID: 26072 RVA: 0x001CB7DC File Offset: 0x001C99DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206561, XrefRangeEnd = 206583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartSearching()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_StartSearching_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065D9 RID: 26073 RVA: 0x001CB810 File Offset: 0x001C9A10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206595, RefRangeEnd = 206597, XrefRangeStart = 206583, XrefRangeEnd = 206595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopSearching()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_StopSearching_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065DA RID: 26074 RVA: 0x001CB844 File Offset: 0x001C9A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206597, XrefRangeEnd = 206602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SearchRoutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_SearchRoutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060065DB RID: 26075 RVA: 0x001CB884 File Offset: 0x001C9A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206602, XrefRangeEnd = 206615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetNextSearchLocation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_GetNextSearchLocation_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060065DC RID: 26076 RVA: 0x001CB8C0 File Offset: 0x001C9AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206615, XrefRangeEnd = 206623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTargetValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_IsTargetValid_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060065DD RID: 26077 RVA: 0x001CB8FC File Offset: 0x001C9AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206623, XrefRangeEnd = 206632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RepositionToTargetRange(Vector3 origin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RepositionToTargetRange_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065DE RID: 26078 RVA: 0x001CB93C File Offset: 0x001C9B3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206651, RefRangeEnd = 206653, XrefRangeStart = 206632, XrefRangeEnd = 206651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetRandomReachablePointNear(Vector3 point, float randomRadius, float minDistance = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomRadius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_GetRandomReachablePointNear_Private_Vector3_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060065DF RID: 26079 RVA: 0x001CB9A4 File Offset: 0x001C9BA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206657, RefRangeEnd = 206659, XrefRangeStart = 206653, XrefRangeEnd = 206657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetMinTargetDistance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_GetMinTargetDistance_Protected_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060065E0 RID: 26080 RVA: 0x001CB9E0 File Offset: 0x001C9BE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206663, RefRangeEnd = 206664, XrefRangeStart = 206659, XrefRangeEnd = 206663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetMaxTargetDistance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_GetMaxTargetDistance_Protected_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060065E1 RID: 26081 RVA: 0x001CBA1C File Offset: 0x001C9C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206664, XrefRangeEnd = 206673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTargetInRange(Vector3 origin = default(Vector3))
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_IsTargetInRange_Protected_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060065E2 RID: 26082 RVA: 0x001CBA68 File Offset: 0x001C9C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206673, XrefRangeEnd = 206678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CombatBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065E3 RID: 26083 RVA: 0x001CBAA4 File Offset: 0x001C9CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206678, XrefRangeEnd = 206704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065E4 RID: 26084 RVA: 0x001CBAE0 File Offset: 0x001C9CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206704, XrefRangeEnd = 206705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065E5 RID: 26085 RVA: 0x001CBB1C File Offset: 0x001C9D1C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065E6 RID: 26086 RVA: 0x001CBB58 File Offset: 0x001C9D58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206734, RefRangeEnd = 206735, XrefRangeStart = 206705, XrefRangeEnd = 206734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetTarget_1824087381(NetworkConnection conn, NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetTarget_1824087381_Private_Void_NetworkConnection_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065E7 RID: 26087 RVA: 0x001CBBAC File Offset: 0x001C9DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206735, XrefRangeEnd = 206739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetTarget_1824087381(NetworkConnection conn, NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_RpcLogic___SetTarget_1824087381_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065E8 RID: 26088 RVA: 0x001CBC0C File Offset: 0x001C9E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206739, XrefRangeEnd = 206747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetTarget_1824087381(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetTarget_1824087381_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065E9 RID: 26089 RVA: 0x001CBC5C File Offset: 0x001C9E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206747, XrefRangeEnd = 206766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetWeapon_3615296227(string weaponPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(weaponPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetWeapon_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065EA RID: 26090 RVA: 0x001CBCA0 File Offset: 0x001C9EA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206805, RefRangeEnd = 206807, XrefRangeStart = 206766, XrefRangeEnd = 206805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetWeapon_3615296227(string weaponPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(weaponPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_RpcLogic___SetWeapon_3615296227_Protected_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065EB RID: 26091 RVA: 0x001CBCF0 File Offset: 0x001C9EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206807, XrefRangeEnd = 206811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetWeapon_3615296227(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetWeapon_3615296227_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065EC RID: 26092 RVA: 0x001CBD40 File Offset: 0x001C9F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206811, XrefRangeEnd = 206829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ClearWeapon_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_ClearWeapon_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065ED RID: 26093 RVA: 0x001CBD74 File Offset: 0x001C9F74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206850, RefRangeEnd = 206852, XrefRangeStart = 206829, XrefRangeEnd = 206850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ClearWeapon_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcLogic___ClearWeapon_2166136261_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065EE RID: 26094 RVA: 0x001CBDA8 File Offset: 0x001C9FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206852, XrefRangeEnd = 206855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ClearWeapon_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcReader___Observers_ClearWeapon_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065EF RID: 26095 RVA: 0x001CBDF8 File Offset: 0x001C9FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206855, XrefRangeEnd = 206873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Attack_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_Attack_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065F0 RID: 26096 RVA: 0x001CBE2C File Offset: 0x001CA02C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206877, RefRangeEnd = 206879, XrefRangeStart = 206873, XrefRangeEnd = 206877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___Attack_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_RpcLogic___Attack_2166136261_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065F1 RID: 26097 RVA: 0x001CBE68 File Offset: 0x001CA068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206879, XrefRangeEnd = 206882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Attack_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcReader___Observers_Attack_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065F2 RID: 26098 RVA: 0x001CBEB8 File Offset: 0x001CA0B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206882, XrefRangeEnd = 206899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065F3 RID: 26099 RVA: 0x00030231 File Offset: 0x0002E431
		public CombatBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EA2 RID: 7842
		// (get) Token: 0x060065F4 RID: 26100 RVA: 0x001CBEF4 File Offset: 0x001CA0F4
		// (set) Token: 0x060065F5 RID: 26101 RVA: 0x0003023A File Offset: 0x0002E43A
		public unsafe static float EXTRA_VISIBILITY_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CombatBehaviour.NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CombatBehaviour.NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001EA3 RID: 7843
		// (get) Token: 0x060065F6 RID: 26102 RVA: 0x001CBF10 File Offset: 0x001CA110
		// (set) Token: 0x060065F7 RID: 26103 RVA: 0x00030248 File Offset: 0x0002E448
		public unsafe static float SEARCH_RADIUS_MIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CombatBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CombatBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MIN, (void*)(&value));
			}
		}

		// Token: 0x17001EA4 RID: 7844
		// (get) Token: 0x060065F8 RID: 26104 RVA: 0x001CBF2C File Offset: 0x001CA12C
		// (set) Token: 0x060065F9 RID: 26105 RVA: 0x00030256 File Offset: 0x0002E456
		public unsafe static float SEARCH_RADIUS_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CombatBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CombatBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MAX, (void*)(&value));
			}
		}

		// Token: 0x17001EA5 RID: 7845
		// (get) Token: 0x060065FA RID: 26106 RVA: 0x001CBF48 File Offset: 0x001CA148
		// (set) Token: 0x060065FB RID: 26107 RVA: 0x00030264 File Offset: 0x0002E464
		public unsafe static float SEARCH_SPEED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CombatBehaviour.NativeFieldInfoPtr_SEARCH_SPEED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CombatBehaviour.NativeFieldInfoPtr_SEARCH_SPEED, (void*)(&value));
			}
		}

		// Token: 0x17001EA6 RID: 7846
		// (get) Token: 0x060065FC RID: 26108 RVA: 0x001CBF64 File Offset: 0x001CA164
		// (set) Token: 0x060065FD RID: 26109 RVA: 0x00030272 File Offset: 0x0002E472
		public unsafe static float CONSECUTIVE_MISS_ACCURACY_BOOST
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CombatBehaviour.NativeFieldInfoPtr_CONSECUTIVE_MISS_ACCURACY_BOOST, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CombatBehaviour.NativeFieldInfoPtr_CONSECUTIVE_MISS_ACCURACY_BOOST, (void*)(&value));
			}
		}

		// Token: 0x17001EA7 RID: 7847
		// (get) Token: 0x060065FE RID: 26110 RVA: 0x001CBF80 File Offset: 0x001CA180
		// (set) Token: 0x060065FF RID: 26111 RVA: 0x00030280 File Offset: 0x0002E480
		public unsafe static float REACHED_DESTINATION_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CombatBehaviour.NativeFieldInfoPtr_REACHED_DESTINATION_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CombatBehaviour.NativeFieldInfoPtr_REACHED_DESTINATION_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17001EA8 RID: 7848
		// (get) Token: 0x06006600 RID: 26112 RVA: 0x001CBF9C File Offset: 0x001CA19C
		// (set) Token: 0x06006601 RID: 26113 RVA: 0x0003028E File Offset: 0x0002E48E
		public unsafe Player _TargetPlayer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EA9 RID: 7849
		// (get) Token: 0x06006602 RID: 26114 RVA: 0x001CBFCC File Offset: 0x001CA1CC
		// (set) Token: 0x06006603 RID: 26115 RVA: 0x000302AD File Offset: 0x0002E4AD
		public unsafe bool _IsSearching_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr__IsSearching_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr__IsSearching_k__BackingField)) = value;
			}
		}

		// Token: 0x17001EAA RID: 7850
		// (get) Token: 0x06006604 RID: 26116 RVA: 0x001CBFF4 File Offset: 0x001CA1F4
		// (set) Token: 0x06006605 RID: 26117 RVA: 0x000302C8 File Offset: 0x0002E4C8
		public unsafe float _TimeSinceTargetReacquired_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr__TimeSinceTargetReacquired_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr__TimeSinceTargetReacquired_k__BackingField)) = value;
			}
		}

		// Token: 0x17001EAB RID: 7851
		// (get) Token: 0x06006606 RID: 26118 RVA: 0x001CC01C File Offset: 0x001CA21C
		// (set) Token: 0x06006607 RID: 26119 RVA: 0x000302E3 File Offset: 0x0002E4E3
		public unsafe float GiveUpRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_GiveUpRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_GiveUpRange)) = value;
			}
		}

		// Token: 0x17001EAC RID: 7852
		// (get) Token: 0x06006608 RID: 26120 RVA: 0x001CC044 File Offset: 0x001CA244
		// (set) Token: 0x06006609 RID: 26121 RVA: 0x000302FE File Offset: 0x0002E4FE
		public unsafe float GiveUpTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_GiveUpTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_GiveUpTime)) = value;
			}
		}

		// Token: 0x17001EAD RID: 7853
		// (get) Token: 0x0600660A RID: 26122 RVA: 0x001CC06C File Offset: 0x001CA26C
		// (set) Token: 0x0600660B RID: 26123 RVA: 0x00030319 File Offset: 0x0002E519
		public unsafe int GiveUpAfterSuccessfulHits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_GiveUpAfterSuccessfulHits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_GiveUpAfterSuccessfulHits)) = value;
			}
		}

		// Token: 0x17001EAE RID: 7854
		// (get) Token: 0x0600660C RID: 26124 RVA: 0x001CC094 File Offset: 0x001CA294
		// (set) Token: 0x0600660D RID: 26125 RVA: 0x00030334 File Offset: 0x0002E534
		public unsafe bool PlayAngryVO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_PlayAngryVO);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_PlayAngryVO)) = value;
			}
		}

		// Token: 0x17001EAF RID: 7855
		// (get) Token: 0x0600660E RID: 26126 RVA: 0x001CC0BC File Offset: 0x001CA2BC
		// (set) Token: 0x0600660F RID: 26127 RVA: 0x0003034F File Offset: 0x0002E54F
		public unsafe float DefaultMovementSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_DefaultMovementSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_DefaultMovementSpeed)) = value;
			}
		}

		// Token: 0x17001EB0 RID: 7856
		// (get) Token: 0x06006610 RID: 26128 RVA: 0x001CC0E4 File Offset: 0x001CA2E4
		// (set) Token: 0x06006611 RID: 26129 RVA: 0x0003036A File Offset: 0x0002E56A
		public unsafe AvatarWeapon DefaultWeapon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_DefaultWeapon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarWeapon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_DefaultWeapon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EB1 RID: 7857
		// (get) Token: 0x06006612 RID: 26130 RVA: 0x001CC114 File Offset: 0x001CA314
		// (set) Token: 0x06006613 RID: 26131 RVA: 0x00030389 File Offset: 0x0002E589
		public unsafe AvatarMeleeWeapon VirtualPunchWeapon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_VirtualPunchWeapon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarMeleeWeapon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_VirtualPunchWeapon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EB2 RID: 7858
		// (get) Token: 0x06006614 RID: 26132 RVA: 0x001CC144 File Offset: 0x001CA344
		// (set) Token: 0x06006615 RID: 26133 RVA: 0x000303A8 File Offset: 0x0002E5A8
		public unsafe float DefaultSearchTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_DefaultSearchTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_DefaultSearchTime)) = value;
			}
		}

		// Token: 0x17001EB3 RID: 7859
		// (get) Token: 0x06006616 RID: 26134 RVA: 0x001CC16C File Offset: 0x001CA36C
		// (set) Token: 0x06006617 RID: 26135 RVA: 0x000303C3 File Offset: 0x0002E5C3
		public unsafe bool overrideTargetDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_overrideTargetDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_overrideTargetDistance)) = value;
			}
		}

		// Token: 0x17001EB4 RID: 7860
		// (get) Token: 0x06006618 RID: 26136 RVA: 0x001CC194 File Offset: 0x001CA394
		// (set) Token: 0x06006619 RID: 26137 RVA: 0x000303DE File Offset: 0x0002E5DE
		public unsafe float targetDistanceOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_targetDistanceOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_targetDistanceOverride)) = value;
			}
		}

		// Token: 0x17001EB5 RID: 7861
		// (get) Token: 0x0600661A RID: 26138 RVA: 0x001CC1BC File Offset: 0x001CA3BC
		// (set) Token: 0x0600661B RID: 26139 RVA: 0x000303F9 File Offset: 0x0002E5F9
		public unsafe bool isTargetRecentlyVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_isTargetRecentlyVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_isTargetRecentlyVisible)) = value;
			}
		}

		// Token: 0x17001EB6 RID: 7862
		// (get) Token: 0x0600661C RID: 26140 RVA: 0x001CC1E4 File Offset: 0x001CA3E4
		// (set) Token: 0x0600661D RID: 26141 RVA: 0x00030414 File Offset: 0x0002E614
		public unsafe bool isTargetImmediatelyVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_isTargetImmediatelyVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_isTargetImmediatelyVisible)) = value;
			}
		}

		// Token: 0x17001EB7 RID: 7863
		// (get) Token: 0x0600661E RID: 26142 RVA: 0x001CC20C File Offset: 0x001CA40C
		// (set) Token: 0x0600661F RID: 26143 RVA: 0x0003042F File Offset: 0x0002E62F
		public unsafe float timeSinceLastSighting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_timeSinceLastSighting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_timeSinceLastSighting)) = value;
			}
		}

		// Token: 0x17001EB8 RID: 7864
		// (get) Token: 0x06006620 RID: 26144 RVA: 0x001CC234 File Offset: 0x001CA434
		// (set) Token: 0x06006621 RID: 26145 RVA: 0x0003044A File Offset: 0x0002E64A
		public unsafe float playerSightedDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_playerSightedDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_playerSightedDuration)) = value;
			}
		}

		// Token: 0x17001EB9 RID: 7865
		// (get) Token: 0x06006622 RID: 26146 RVA: 0x001CC25C File Offset: 0x001CA45C
		// (set) Token: 0x06006623 RID: 26147 RVA: 0x00030465 File Offset: 0x0002E665
		public unsafe Vector3 lastKnownTargetPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_lastKnownTargetPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_lastKnownTargetPosition)) = value;
			}
		}

		// Token: 0x17001EBA RID: 7866
		// (get) Token: 0x06006624 RID: 26148 RVA: 0x001CC284 File Offset: 0x001CA484
		// (set) Token: 0x06006625 RID: 26149 RVA: 0x00030480 File Offset: 0x0002E680
		public unsafe AvatarWeapon currentWeapon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_currentWeapon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarWeapon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_currentWeapon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EBB RID: 7867
		// (get) Token: 0x06006626 RID: 26150 RVA: 0x001CC2B4 File Offset: 0x001CA4B4
		// (set) Token: 0x06006627 RID: 26151 RVA: 0x0003049F File Offset: 0x0002E69F
		public unsafe int successfulHits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_successfulHits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_successfulHits)) = value;
			}
		}

		// Token: 0x17001EBC RID: 7868
		// (get) Token: 0x06006628 RID: 26152 RVA: 0x001CC2DC File Offset: 0x001CA4DC
		// (set) Token: 0x06006629 RID: 26153 RVA: 0x000304BA File Offset: 0x0002E6BA
		public unsafe int consecutiveMissedShots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_consecutiveMissedShots);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_consecutiveMissedShots)) = value;
			}
		}

		// Token: 0x17001EBD RID: 7869
		// (get) Token: 0x0600662A RID: 26154 RVA: 0x001CC304 File Offset: 0x001CA504
		// (set) Token: 0x0600662B RID: 26155 RVA: 0x000304D5 File Offset: 0x0002E6D5
		public unsafe Coroutine rangedWeaponRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_rangedWeaponRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_rangedWeaponRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EBE RID: 7870
		// (get) Token: 0x0600662C RID: 26156 RVA: 0x001CC334 File Offset: 0x001CA534
		// (set) Token: 0x0600662D RID: 26157 RVA: 0x000304F4 File Offset: 0x0002E6F4
		public unsafe Coroutine searchRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_searchRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_searchRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EBF RID: 7871
		// (get) Token: 0x0600662E RID: 26158 RVA: 0x001CC364 File Offset: 0x001CA564
		// (set) Token: 0x0600662F RID: 26159 RVA: 0x00030513 File Offset: 0x0002E713
		public unsafe Vector3 currentSearchDestination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_currentSearchDestination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_currentSearchDestination)) = value;
			}
		}

		// Token: 0x17001EC0 RID: 7872
		// (get) Token: 0x06006630 RID: 26160 RVA: 0x001CC38C File Offset: 0x001CA58C
		// (set) Token: 0x06006631 RID: 26161 RVA: 0x0003052E File Offset: 0x0002E72E
		public unsafe bool hasSearchDestination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_hasSearchDestination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_hasSearchDestination)) = value;
			}
		}

		// Token: 0x17001EC1 RID: 7873
		// (get) Token: 0x06006632 RID: 26162 RVA: 0x001CC3B4 File Offset: 0x001CA5B4
		// (set) Token: 0x06006633 RID: 26163 RVA: 0x00030549 File Offset: 0x0002E749
		public unsafe float nextAngryVO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_nextAngryVO);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_nextAngryVO)) = value;
			}
		}

		// Token: 0x17001EC2 RID: 7874
		// (get) Token: 0x06006634 RID: 26164 RVA: 0x001CC3DC File Offset: 0x001CA5DC
		// (set) Token: 0x06006635 RID: 26165 RVA: 0x00030564 File Offset: 0x0002E764
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001EC3 RID: 7875
		// (get) Token: 0x06006636 RID: 26166 RVA: 0x001CC404 File Offset: 0x001CA604
		// (set) Token: 0x06006637 RID: 26167 RVA: 0x0003057F File Offset: 0x0002E77F
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004568 RID: 17768
		private static readonly IntPtr NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME;

		// Token: 0x04004569 RID: 17769
		private static readonly IntPtr NativeFieldInfoPtr_SEARCH_RADIUS_MIN;

		// Token: 0x0400456A RID: 17770
		private static readonly IntPtr NativeFieldInfoPtr_SEARCH_RADIUS_MAX;

		// Token: 0x0400456B RID: 17771
		private static readonly IntPtr NativeFieldInfoPtr_SEARCH_SPEED;

		// Token: 0x0400456C RID: 17772
		private static readonly IntPtr NativeFieldInfoPtr_CONSECUTIVE_MISS_ACCURACY_BOOST;

		// Token: 0x0400456D RID: 17773
		private static readonly IntPtr NativeFieldInfoPtr_REACHED_DESTINATION_DISTANCE;

		// Token: 0x0400456E RID: 17774
		private static readonly IntPtr NativeFieldInfoPtr__TargetPlayer_k__BackingField;

		// Token: 0x0400456F RID: 17775
		private static readonly IntPtr NativeFieldInfoPtr__IsSearching_k__BackingField;

		// Token: 0x04004570 RID: 17776
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceTargetReacquired_k__BackingField;

		// Token: 0x04004571 RID: 17777
		private static readonly IntPtr NativeFieldInfoPtr_GiveUpRange;

		// Token: 0x04004572 RID: 17778
		private static readonly IntPtr NativeFieldInfoPtr_GiveUpTime;

		// Token: 0x04004573 RID: 17779
		private static readonly IntPtr NativeFieldInfoPtr_GiveUpAfterSuccessfulHits;

		// Token: 0x04004574 RID: 17780
		private static readonly IntPtr NativeFieldInfoPtr_PlayAngryVO;

		// Token: 0x04004575 RID: 17781
		private static readonly IntPtr NativeFieldInfoPtr_DefaultMovementSpeed;

		// Token: 0x04004576 RID: 17782
		private static readonly IntPtr NativeFieldInfoPtr_DefaultWeapon;

		// Token: 0x04004577 RID: 17783
		private static readonly IntPtr NativeFieldInfoPtr_VirtualPunchWeapon;

		// Token: 0x04004578 RID: 17784
		private static readonly IntPtr NativeFieldInfoPtr_DefaultSearchTime;

		// Token: 0x04004579 RID: 17785
		private static readonly IntPtr NativeFieldInfoPtr_overrideTargetDistance;

		// Token: 0x0400457A RID: 17786
		private static readonly IntPtr NativeFieldInfoPtr_targetDistanceOverride;

		// Token: 0x0400457B RID: 17787
		private static readonly IntPtr NativeFieldInfoPtr_isTargetRecentlyVisible;

		// Token: 0x0400457C RID: 17788
		private static readonly IntPtr NativeFieldInfoPtr_isTargetImmediatelyVisible;

		// Token: 0x0400457D RID: 17789
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastSighting;

		// Token: 0x0400457E RID: 17790
		private static readonly IntPtr NativeFieldInfoPtr_playerSightedDuration;

		// Token: 0x0400457F RID: 17791
		private static readonly IntPtr NativeFieldInfoPtr_lastKnownTargetPosition;

		// Token: 0x04004580 RID: 17792
		private static readonly IntPtr NativeFieldInfoPtr_currentWeapon;

		// Token: 0x04004581 RID: 17793
		private static readonly IntPtr NativeFieldInfoPtr_successfulHits;

		// Token: 0x04004582 RID: 17794
		private static readonly IntPtr NativeFieldInfoPtr_consecutiveMissedShots;

		// Token: 0x04004583 RID: 17795
		private static readonly IntPtr NativeFieldInfoPtr_rangedWeaponRoutine;

		// Token: 0x04004584 RID: 17796
		private static readonly IntPtr NativeFieldInfoPtr_searchRoutine;

		// Token: 0x04004585 RID: 17797
		private static readonly IntPtr NativeFieldInfoPtr_currentSearchDestination;

		// Token: 0x04004586 RID: 17798
		private static readonly IntPtr NativeFieldInfoPtr_hasSearchDestination;

		// Token: 0x04004587 RID: 17799
		private static readonly IntPtr NativeFieldInfoPtr_nextAngryVO;

		// Token: 0x04004588 RID: 17800
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004589 RID: 17801
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400458A RID: 17802
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0;

		// Token: 0x0400458B RID: 17803
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0;

		// Token: 0x0400458C RID: 17804
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSearching_Public_get_Boolean_0;

		// Token: 0x0400458D RID: 17805
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSearching_Protected_set_Void_Boolean_0;

		// Token: 0x0400458E RID: 17806
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceTargetReacquired_Public_get_Single_0;

		// Token: 0x0400458F RID: 17807
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceTargetReacquired_Protected_set_Void_Single_0;

		// Token: 0x04004590 RID: 17808
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004591 RID: 17809
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04004592 RID: 17810
		private static readonly IntPtr NativeMethodInfoPtr_SetTarget_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x04004593 RID: 17811
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1;

		// Token: 0x04004594 RID: 17812
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1;

		// Token: 0x04004595 RID: 17813
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1;

		// Token: 0x04004596 RID: 17814
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_1;

		// Token: 0x04004597 RID: 17815
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x04004598 RID: 17816
		private static readonly IntPtr NativeMethodInfoPtr_StartCombat_Protected_Virtual_New_Void_0;

		// Token: 0x04004599 RID: 17817
		private static readonly IntPtr NativeMethodInfoPtr_EndCombat_Protected_Void_0;

		// Token: 0x0400459A RID: 17818
		private static readonly IntPtr NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0;

		// Token: 0x0400459B RID: 17819
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x0400459C RID: 17820
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTimeout_Protected_Void_0;

		// Token: 0x0400459D RID: 17821
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLookAt_Protected_Virtual_New_Void_0;

		// Token: 0x0400459E RID: 17822
		private static readonly IntPtr NativeMethodInfoPtr_SetMovementSpeed_Protected_Void_Single_0;

		// Token: 0x0400459F RID: 17823
		private static readonly IntPtr NativeMethodInfoPtr_SetWeapon_Protected_Virtual_New_Void_String_0;

		// Token: 0x040045A0 RID: 17824
		private static readonly IntPtr NativeMethodInfoPtr_ClearWeapon_Protected_Void_0;

		// Token: 0x040045A1 RID: 17825
		private static readonly IntPtr NativeMethodInfoPtr_ReadyToAttack_Protected_Virtual_New_Boolean_Boolean_0;

		// Token: 0x040045A2 RID: 17826
		private static readonly IntPtr NativeMethodInfoPtr_Attack_Protected_Virtual_New_Void_0;

		// Token: 0x040045A3 RID: 17827
		private static readonly IntPtr NativeMethodInfoPtr_SucessfulHit_Protected_Void_0;

		// Token: 0x040045A4 RID: 17828
		private static readonly IntPtr NativeMethodInfoPtr_CheckPlayerVisibility_Protected_Void_0;

		// Token: 0x040045A5 RID: 17829
		private static readonly IntPtr NativeMethodInfoPtr_MarkPlayerVisible_Public_Void_0;

		// Token: 0x040045A6 RID: 17830
		private static readonly IntPtr NativeMethodInfoPtr_IsPlayerVisible_Protected_Boolean_0;

		// Token: 0x040045A7 RID: 17831
		private static readonly IntPtr NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0;

		// Token: 0x040045A8 RID: 17832
		private static readonly IntPtr NativeMethodInfoPtr_GetSearchTime_Protected_Virtual_New_Single_0;

		// Token: 0x040045A9 RID: 17833
		private static readonly IntPtr NativeMethodInfoPtr_StartSearching_Private_Void_0;

		// Token: 0x040045AA RID: 17834
		private static readonly IntPtr NativeMethodInfoPtr_StopSearching_Private_Void_0;

		// Token: 0x040045AB RID: 17835
		private static readonly IntPtr NativeMethodInfoPtr_SearchRoutine_Private_IEnumerator_0;

		// Token: 0x040045AC RID: 17836
		private static readonly IntPtr NativeMethodInfoPtr_GetNextSearchLocation_Private_Vector3_0;

		// Token: 0x040045AD RID: 17837
		private static readonly IntPtr NativeMethodInfoPtr_IsTargetValid_Protected_Boolean_0;

		// Token: 0x040045AE RID: 17838
		private static readonly IntPtr NativeMethodInfoPtr_RepositionToTargetRange_Private_Void_Vector3_0;

		// Token: 0x040045AF RID: 17839
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomReachablePointNear_Private_Vector3_Vector3_Single_Single_0;

		// Token: 0x040045B0 RID: 17840
		private static readonly IntPtr NativeMethodInfoPtr_GetMinTargetDistance_Protected_Single_0;

		// Token: 0x040045B1 RID: 17841
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxTargetDistance_Protected_Single_0;

		// Token: 0x040045B2 RID: 17842
		private static readonly IntPtr NativeMethodInfoPtr_IsTargetInRange_Protected_Boolean_Vector3_0;

		// Token: 0x040045B3 RID: 17843
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040045B4 RID: 17844
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040045B5 RID: 17845
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040045B6 RID: 17846
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040045B7 RID: 17847
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetTarget_1824087381_Private_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x040045B8 RID: 17848
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetTarget_1824087381_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x040045B9 RID: 17849
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetTarget_1824087381_Private_Void_PooledReader_Channel_0;

		// Token: 0x040045BA RID: 17850
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetWeapon_3615296227_Private_Void_String_0;

		// Token: 0x040045BB RID: 17851
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetWeapon_3615296227_Protected_Virtual_New_Void_String_0;

		// Token: 0x040045BC RID: 17852
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetWeapon_3615296227_Private_Void_PooledReader_Channel_0;

		// Token: 0x040045BD RID: 17853
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ClearWeapon_2166136261_Private_Void_0;

		// Token: 0x040045BE RID: 17854
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ClearWeapon_2166136261_Protected_Void_0;

		// Token: 0x040045BF RID: 17855
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ClearWeapon_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040045C0 RID: 17856
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Attack_2166136261_Private_Void_0;

		// Token: 0x040045C1 RID: 17857
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Attack_2166136261_Protected_Virtual_New_Void_0;

		// Token: 0x040045C2 RID: 17858
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Attack_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040045C3 RID: 17859
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000A31 RID: 2609
		[ObfuscatedName("ScheduleOne.Combat.CombatBehaviour+<SearchRoutine>d__68")]
		public sealed class _SearchRoutine_d__68 : Il2CppSystem.Object
		{
			// Token: 0x0600CF88 RID: 53128 RVA: 0x0031D89C File Offset: 0x0031BA9C
			// Note: this type is marked as 'beforefieldinit'.
			static _SearchRoutine_d__68()
			{
				Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "<SearchRoutine>d__68");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr);
				CombatBehaviour._SearchRoutine_d__68.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr, "<>1__state");
				CombatBehaviour._SearchRoutine_d__68.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr, "<>2__current");
				CombatBehaviour._SearchRoutine_d__68.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr, "<>4__this");
				CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr, 100676213);
				CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr, 100676214);
				CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr, 100676215);
				CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr, 100676216);
				CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr, 100676217);
				CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr, 100676218);
			}

			// Token: 0x0600CF89 RID: 53129 RVA: 0x0031D97C File Offset: 0x0031BB7C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SearchRoutine_d__68(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF8A RID: 53130 RVA: 0x0031D9C4 File Offset: 0x0031BBC4
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF8B RID: 53131 RVA: 0x0031D9F8 File Offset: 0x0031BBF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206268, XrefRangeEnd = 206269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004081 RID: 16513
			// (get) Token: 0x0600CF8C RID: 53132 RVA: 0x0031DA34 File Offset: 0x0031BC34
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CF8D RID: 53133 RVA: 0x0031DA74 File Offset: 0x0031BC74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206269, XrefRangeEnd = 206274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004082 RID: 16514
			// (get) Token: 0x0600CF8E RID: 53134 RVA: 0x0031DAA8 File Offset: 0x0031BCA8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CF8F RID: 53135 RVA: 0x00064FA8 File Offset: 0x000631A8
			public _SearchRoutine_d__68(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700407E RID: 16510
			// (get) Token: 0x0600CF90 RID: 53136 RVA: 0x0031DAE8 File Offset: 0x0031BCE8
			// (set) Token: 0x0600CF91 RID: 53137 RVA: 0x00064FB1 File Offset: 0x000631B1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._SearchRoutine_d__68.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._SearchRoutine_d__68.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700407F RID: 16511
			// (get) Token: 0x0600CF92 RID: 53138 RVA: 0x0031DB10 File Offset: 0x0031BD10
			// (set) Token: 0x0600CF93 RID: 53139 RVA: 0x00064FCC File Offset: 0x000631CC
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._SearchRoutine_d__68.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._SearchRoutine_d__68.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004080 RID: 16512
			// (get) Token: 0x0600CF94 RID: 53140 RVA: 0x0031DB40 File Offset: 0x0031BD40
			// (set) Token: 0x0600CF95 RID: 53141 RVA: 0x00064FEB File Offset: 0x000631EB
			public unsafe CombatBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._SearchRoutine_d__68.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CombatBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._SearchRoutine_d__68.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008BF9 RID: 35833
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008BFA RID: 35834
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008BFB RID: 35835
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008BFC RID: 35836
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008BFD RID: 35837
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008BFE RID: 35838
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008BFF RID: 35839
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008C00 RID: 35840
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008C01 RID: 35841
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
