using System;
using Il2Cpp;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Animation;
using Il2CppScheduleOne.Dragging;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Tools;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs
{
	// Token: 0x020002DA RID: 730
	public class NPCMovement : NetworkBehaviour
	{
		// Token: 0x06003518 RID: 13592 RVA: 0x0011B328 File Offset: 0x00119528
		// Note: this type is marked as 'beforefieldinit'.
		static NPCMovement()
		{
			Il2CppClassPointerStore<NPCMovement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs", "NPCMovement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr);
			NPCMovement.NativeFieldInfoPtr_VEHICLE_RUNOVER_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "VEHICLE_RUNOVER_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_SKATEBOARD_RUNOVER_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "SKATEBOARD_RUNOVER_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_LIGHT_FLINCH_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "LIGHT_FLINCH_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_HEAVY_FLINCH_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "HEAVY_FLINCH_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_RAGDOLL_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "RAGDOLL_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_MOMENTUM_ANNOYED_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "MOMENTUM_ANNOYED_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_MOMENTUM_LIGHT_FLINCH_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "MOMENTUM_LIGHT_FLINCH_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_MOMENTUM_HEAVY_FLINCH_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "MOMENTUM_HEAVY_FLINCH_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_MOMENTUM_RAGDOLL_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "MOMENTUM_RAGDOLL_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_USE_PATH_CACHE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "USE_PATH_CACHE");
			NPCMovement.NativeFieldInfoPtr_STUMBLE_DURATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "STUMBLE_DURATION");
			NPCMovement.NativeFieldInfoPtr_STUMBLE_FORCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "STUMBLE_FORCE");
			NPCMovement.NativeFieldInfoPtr_OBSTACLE_AVOIDANCE_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "OBSTACLE_AVOIDANCE_RANGE");
			NPCMovement.NativeFieldInfoPtr_PLAYER_DIST_IMPACT_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "PLAYER_DIST_IMPACT_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_cachedClosestReachablePoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "cachedClosestReachablePoints");
			NPCMovement.NativeFieldInfoPtr_cachedClosestPointKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "cachedClosestPointKeys");
			NPCMovement.NativeFieldInfoPtr_CLOSEST_REACHABLE_POINT_CACHE_MAX_SQR_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "CLOSEST_REACHABLE_POINT_CACHE_MAX_SQR_OFFSET");
			NPCMovement.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "DEBUG");
			NPCMovement.NativeFieldInfoPtr_WalkSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "WalkSpeed");
			NPCMovement.NativeFieldInfoPtr_RunSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "RunSpeed");
			NPCMovement.NativeFieldInfoPtr_MoveSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "MoveSpeedMultiplier");
			NPCMovement.NativeFieldInfoPtr_SlipperyMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "SlipperyMode");
			NPCMovement.NativeFieldInfoPtr_SlipperyModeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "SlipperyModeMultiplier");
			NPCMovement.NativeFieldInfoPtr_DefaultObstacleAvoidanceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "DefaultObstacleAvoidanceType");
			NPCMovement.NativeFieldInfoPtr_Agent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "Agent");
			NPCMovement.NativeFieldInfoPtr_SpeedController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "SpeedController");
			NPCMovement.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "npc");
			NPCMovement.NativeFieldInfoPtr_capsuleCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "capsuleCollider");
			NPCMovement.NativeFieldInfoPtr_anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "anim");
			NPCMovement.NativeFieldInfoPtr_ragdollCentralRB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "ragdollCentralRB");
			NPCMovement.NativeFieldInfoPtr_velocityCalculator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "velocityCalculator");
			NPCMovement.NativeFieldInfoPtr_RagdollDraggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "RagdollDraggable");
			NPCMovement.NativeFieldInfoPtr_RagdollDraggableCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "RagdollDraggableCollider");
			NPCMovement.NativeFieldInfoPtr_MovementSpeedScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "MovementSpeedScale");
			NPCMovement.NativeFieldInfoPtr__hasDestination_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<hasDestination>k__BackingField");
			NPCMovement.NativeFieldInfoPtr__IsPaused_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<IsPaused>k__BackingField");
			NPCMovement.NativeFieldInfoPtr__GravityMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<GravityMultiplier>k__BackingField");
			NPCMovement.NativeFieldInfoPtr__Stance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<Stance>k__BackingField");
			NPCMovement.NativeFieldInfoPtr__timeSinceHitByCar_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<timeSinceHitByCar>k__BackingField");
			NPCMovement.NativeFieldInfoPtr_ragdollTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "ragdollTime");
			NPCMovement.NativeFieldInfoPtr_ragdollStaticTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "ragdollStaticTime");
			NPCMovement.NativeFieldInfoPtr_onHitByCar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "onHitByCar");
			NPCMovement.NativeFieldInfoPtr_onRagdollStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "onRagdollStart");
			NPCMovement.NativeFieldInfoPtr_onRagdollEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "onRagdollEnd");
			NPCMovement.NativeFieldInfoPtr__CurrentDestination_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<CurrentDestination>k__BackingField");
			NPCMovement.NativeFieldInfoPtr__PathCache_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<PathCache>k__BackingField");
			NPCMovement.NativeFieldInfoPtr_cacheNextPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "cacheNextPath");
			NPCMovement.NativeFieldInfoPtr_currentDestination_Reachable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "currentDestination_Reachable");
			NPCMovement.NativeFieldInfoPtr_walkResultCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "walkResultCallback");
			NPCMovement.NativeFieldInfoPtr_currentMaxDistanceForSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "currentMaxDistanceForSuccess");
			NPCMovement.NativeFieldInfoPtr_forceIsMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "forceIsMoving");
			NPCMovement.NativeFieldInfoPtr_FaceDirectionRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "FaceDirectionRoutine");
			NPCMovement.NativeFieldInfoPtr_ragdollForceComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "ragdollForceComponents");
			NPCMovement.NativeFieldInfoPtr__Disoriented_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<Disoriented>k__BackingField");
			NPCMovement.NativeFieldInfoPtr_timeUntilNextStumble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "timeUntilNextStumble");
			NPCMovement.NativeFieldInfoPtr_timeSinceStumble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "timeSinceStumble");
			NPCMovement.NativeFieldInfoPtr_stumbleDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "stumbleDirection");
			NPCMovement.NativeFieldInfoPtr_desiredVelocityHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "desiredVelocityHistory");
			NPCMovement.NativeFieldInfoPtr_desiredVelocityHistoryLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "desiredVelocityHistoryLength");
			NPCMovement.NativeFieldInfoPtr_velocityHistorySpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "velocityHistorySpacing");
			NPCMovement.NativeFieldInfoPtr_timeSinceLastVelocityHistoryRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "timeSinceLastVelocityHistoryRecord");
			NPCMovement.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.NPCMovementAssembly-CSharp.dll_Excuted");
			NPCMovement.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.NPCMovementAssembly-CSharp.dll_Excuted");
			NPCMovement.NativeMethodInfoPtr_get_hasDestination_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669307);
			NPCMovement.NativeMethodInfoPtr_set_hasDestination_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669308);
			NPCMovement.NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669309);
			NPCMovement.NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669310);
			NPCMovement.NativeMethodInfoPtr_set_IsPaused_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669311);
			NPCMovement.NativeMethodInfoPtr_get_FootPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669312);
			NPCMovement.NativeMethodInfoPtr_get_GravityMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669313);
			NPCMovement.NativeMethodInfoPtr_set_GravityMultiplier_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669314);
			NPCMovement.NativeMethodInfoPtr_get_Stance_Public_get_EStance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669315);
			NPCMovement.NativeMethodInfoPtr_set_Stance_Protected_set_Void_EStance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669316);
			NPCMovement.NativeMethodInfoPtr_get_timeSinceHitByCar_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669317);
			NPCMovement.NativeMethodInfoPtr_set_timeSinceHitByCar_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669318);
			NPCMovement.NativeMethodInfoPtr_get_FaceDirectionInProgress_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669319);
			NPCMovement.NativeMethodInfoPtr_get_CurrentDestination_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669320);
			NPCMovement.NativeMethodInfoPtr_set_CurrentDestination_Protected_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669321);
			NPCMovement.NativeMethodInfoPtr_get_PathCache_Public_get_NPCPathCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669322);
			NPCMovement.NativeMethodInfoPtr_set_PathCache_Private_set_Void_NPCPathCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669323);
			NPCMovement.NativeMethodInfoPtr_get_Disoriented_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669324);
			NPCMovement.NativeMethodInfoPtr_set_Disoriented_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669325);
			NPCMovement.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669326);
			NPCMovement.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669327);
			NPCMovement.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669328);
			NPCMovement.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669329);
			NPCMovement.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669330);
			NPCMovement.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669331);
			NPCMovement.NativeMethodInfoPtr_UpdateRagdoll_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669332);
			NPCMovement.NativeMethodInfoPtr_Stumble_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669333);
			NPCMovement.NativeMethodInfoPtr_UpdateDestination_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669334);
			NPCMovement.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669335);
			NPCMovement.NativeMethodInfoPtr_UpdateStumble_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669336);
			NPCMovement.NativeMethodInfoPtr_UpdateSpeed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669337);
			NPCMovement.NativeMethodInfoPtr_RecordVelocity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669338);
			NPCMovement.NativeMethodInfoPtr_UpdateSlippery_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669339);
			NPCMovement.NativeMethodInfoPtr_UpdateCache_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669340);
			NPCMovement.NativeMethodInfoPtr_CanRecoverFromRagdoll_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669341);
			NPCMovement.NativeMethodInfoPtr_UpdateAvoidance_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669342);
			NPCMovement.NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669343);
			NPCMovement.NativeMethodInfoPtr_OnCollisionEnter_Public_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669344);
			NPCMovement.NativeMethodInfoPtr_CheckHit_Private_Void_Collider_Collider_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669345);
			NPCMovement.NativeMethodInfoPtr_Warp_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669346);
			NPCMovement.NativeMethodInfoPtr_Warp_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669347);
			NPCMovement.NativeMethodInfoPtr_ReceiveWarp_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669348);
			NPCMovement.NativeMethodInfoPtr_VisibilityChange_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669349);
			NPCMovement.NativeMethodInfoPtr_CanMove_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669350);
			NPCMovement.NativeMethodInfoPtr_SetAgentType_Public_Void_EAgentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669351);
			NPCMovement.NativeMethodInfoPtr_SetSeat_Public_Void_AvatarSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669352);
			NPCMovement.NativeMethodInfoPtr_SetStance_Public_Void_EStance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669353);
			NPCMovement.NativeMethodInfoPtr_SetGravityMultiplier_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669354);
			NPCMovement.NativeMethodInfoPtr_SetRagdollDraggable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669355);
			NPCMovement.NativeMethodInfoPtr_ActivateRagdoll_Server_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669356);
			NPCMovement.NativeMethodInfoPtr_ActivateRagdoll_Public_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669357);
			NPCMovement.NativeMethodInfoPtr_ApplyRagdollForce_Public_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669358);
			NPCMovement.NativeMethodInfoPtr_DeactivateRagdoll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669359);
			NPCMovement.NativeMethodInfoPtr_SmartSampleNavMesh_Private_Boolean_Vector3_byref_NavMeshHit_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669360);
			NPCMovement.NativeMethodInfoPtr_SetDestination_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669361);
			NPCMovement.NativeMethodInfoPtr_SetDestination_Public_Void_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669362);
			NPCMovement.NativeMethodInfoPtr_SetDestination_Public_Void_Vector3_Action_1_WalkResult_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669363);
			NPCMovement.NativeMethodInfoPtr_SetDestination_Private_Void_Vector3_Action_1_WalkResult_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669364);
			NPCMovement.NativeMethodInfoPtr_IsNPCPositionValid_Private_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669365);
			NPCMovement.NativeMethodInfoPtr_EndSetDestination_Private_Void_WalkResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669366);
			NPCMovement.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669367);
			NPCMovement.NativeMethodInfoPtr_WarpToNavMesh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669368);
			NPCMovement.NativeMethodInfoPtr_FacePoint_Public_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669369);
			NPCMovement.NativeMethodInfoPtr_FaceDirection_Public_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669370);
			NPCMovement.NativeMethodInfoPtr_FaceDirection_Process_Protected_IEnumerator_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669371);
			NPCMovement.NativeMethodInfoPtr_PauseMovement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669372);
			NPCMovement.NativeMethodInfoPtr_ResumeMovement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669373);
			NPCMovement.NativeMethodInfoPtr_IsAsCloseAsPossible_Public_Boolean_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669374);
			NPCMovement.NativeMethodInfoPtr_GetClosestReachablePoint_Public_Boolean_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669375);
			NPCMovement.NativeMethodInfoPtr_CanGetTo_Public_Boolean_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669376);
			NPCMovement.NativeMethodInfoPtr_CanGetTo_Public_Boolean_ITransitEntity_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669377);
			NPCMovement.NativeMethodInfoPtr_CanGetTo_Public_Boolean_Vector3_Single_byref_NavMeshPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669378);
			NPCMovement.NativeMethodInfoPtr_GetPathTo_Private_NavMeshPath_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669379);
			NPCMovement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669380);
			NPCMovement.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669382);
			NPCMovement.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669383);
			NPCMovement.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669384);
			NPCMovement.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveWarp_4276783012_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669385);
			NPCMovement.NativeMethodInfoPtr_RpcLogic___ReceiveWarp_4276783012_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669386);
			NPCMovement.NativeMethodInfoPtr_RpcReader___Observers_ReceiveWarp_4276783012_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669387);
			NPCMovement.NativeMethodInfoPtr_RpcWriter___Server_ActivateRagdoll_Server_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669388);
			NPCMovement.NativeMethodInfoPtr_RpcLogic___ActivateRagdoll_Server_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669389);
			NPCMovement.NativeMethodInfoPtr_RpcReader___Server_ActivateRagdoll_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669390);
			NPCMovement.NativeMethodInfoPtr_RpcWriter___Observers_ActivateRagdoll_2690242654_Private_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669391);
			NPCMovement.NativeMethodInfoPtr_RpcLogic___ActivateRagdoll_2690242654_Public_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669392);
			NPCMovement.NativeMethodInfoPtr_RpcReader___Observers_ActivateRagdoll_2690242654_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669393);
			NPCMovement.NativeMethodInfoPtr_RpcWriter___Observers_ApplyRagdollForce_2690242654_Private_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669394);
			NPCMovement.NativeMethodInfoPtr_RpcLogic___ApplyRagdollForce_2690242654_Public_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669395);
			NPCMovement.NativeMethodInfoPtr_RpcReader___Observers_ApplyRagdollForce_2690242654_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669396);
			NPCMovement.NativeMethodInfoPtr_RpcWriter___Observers_DeactivateRagdoll_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669397);
			NPCMovement.NativeMethodInfoPtr_RpcLogic___DeactivateRagdoll_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669398);
			NPCMovement.NativeMethodInfoPtr_RpcReader___Observers_DeactivateRagdoll_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669399);
			NPCMovement.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669400);
		}

		// Token: 0x1700115D RID: 4445
		// (get) Token: 0x06003519 RID: 13593 RVA: 0x0011BF88 File Offset: 0x0011A188
		// (set) Token: 0x0600351A RID: 13594 RVA: 0x0011BFC4 File Offset: 0x0011A1C4
		public unsafe bool hasDestination
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_hasDestination_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_hasDestination_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700115E RID: 4446
		// (get) Token: 0x0600351B RID: 13595 RVA: 0x0011C004 File Offset: 0x0011A204
		public unsafe bool IsMoving
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 136719, RefRangeEnd = 136793, XrefRangeStart = 136716, XrefRangeEnd = 136719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700115F RID: 4447
		// (get) Token: 0x0600351C RID: 13596 RVA: 0x0011C040 File Offset: 0x0011A240
		// (set) Token: 0x0600351D RID: 13597 RVA: 0x0011C07C File Offset: 0x0011A27C
		public unsafe bool IsPaused
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_IsPaused_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001160 RID: 4448
		// (get) Token: 0x0600351E RID: 13598 RVA: 0x0011C0BC File Offset: 0x0011A2BC
		public unsafe Vector3 FootPosition
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 136795, RefRangeEnd = 136807, XrefRangeStart = 136793, XrefRangeEnd = 136795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_FootPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001161 RID: 4449
		// (get) Token: 0x0600351F RID: 13599 RVA: 0x0011C0F8 File Offset: 0x0011A2F8
		// (set) Token: 0x06003520 RID: 13600 RVA: 0x0011C134 File Offset: 0x0011A334
		public unsafe float GravityMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_GravityMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_GravityMultiplier_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001162 RID: 4450
		// (get) Token: 0x06003521 RID: 13601 RVA: 0x0011C174 File Offset: 0x0011A374
		// (set) Token: 0x06003522 RID: 13602 RVA: 0x0011C1B0 File Offset: 0x0011A3B0
		public unsafe NPCMovement.EStance Stance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_Stance_Public_get_EStance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 136807, RefRangeEnd = 136812, XrefRangeStart = 136807, XrefRangeEnd = 136807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_Stance_Protected_set_Void_EStance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001163 RID: 4451
		// (get) Token: 0x06003523 RID: 13603 RVA: 0x0011C1F0 File Offset: 0x0011A3F0
		// (set) Token: 0x06003524 RID: 13604 RVA: 0x0011C22C File Offset: 0x0011A42C
		public unsafe float timeSinceHitByCar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_timeSinceHitByCar_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_timeSinceHitByCar_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001164 RID: 4452
		// (get) Token: 0x06003525 RID: 13605 RVA: 0x0011C26C File Offset: 0x0011A46C
		public unsafe bool FaceDirectionInProgress
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 136812, RefRangeEnd = 136815, XrefRangeStart = 136812, XrefRangeEnd = 136812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_FaceDirectionInProgress_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001165 RID: 4453
		// (get) Token: 0x06003526 RID: 13606 RVA: 0x0011C2A8 File Offset: 0x0011A4A8
		// (set) Token: 0x06003527 RID: 13607 RVA: 0x0011C2E4 File Offset: 0x0011A4E4
		public unsafe Vector3 CurrentDestination
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_CurrentDestination_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_CurrentDestination_Protected_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001166 RID: 4454
		// (get) Token: 0x06003528 RID: 13608 RVA: 0x0011C324 File Offset: 0x0011A524
		// (set) Token: 0x06003529 RID: 13609 RVA: 0x0011C364 File Offset: 0x0011A564
		public unsafe NPCPathCache PathCache
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_PathCache_Public_get_NPCPathCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCPathCache>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136815, XrefRangeEnd = 136816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_PathCache_Private_set_Void_NPCPathCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001167 RID: 4455
		// (get) Token: 0x0600352A RID: 13610 RVA: 0x0011C3A8 File Offset: 0x0011A5A8
		// (set) Token: 0x0600352B RID: 13611 RVA: 0x0011C3E4 File Offset: 0x0011A5E4
		public unsafe bool Disoriented
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_Disoriented_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_Disoriented_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600352C RID: 13612 RVA: 0x0011C424 File Offset: 0x0011A624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136816, XrefRangeEnd = 136817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600352D RID: 13613 RVA: 0x0011C460 File Offset: 0x0011A660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136817, XrefRangeEnd = 136831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600352E RID: 13614 RVA: 0x0011C494 File Offset: 0x0011A694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136831, XrefRangeEnd = 136834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600352F RID: 13615 RVA: 0x0011C4D0 File Offset: 0x0011A6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136834, XrefRangeEnd = 136835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003530 RID: 13616 RVA: 0x0011C520 File Offset: 0x0011A720
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003531 RID: 13617 RVA: 0x0011C55C File Offset: 0x0011A75C
		[CallerCount(0)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003532 RID: 13618 RVA: 0x0011C598 File Offset: 0x0011A798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136835, XrefRangeEnd = 136856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRagdoll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_UpdateRagdoll_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003533 RID: 13619 RVA: 0x0011C5CC File Offset: 0x0011A7CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136856, XrefRangeEnd = 136866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stumble()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_Stumble_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003534 RID: 13620 RVA: 0x0011C600 File Offset: 0x0011A800
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136889, RefRangeEnd = 136890, XrefRangeStart = 136866, XrefRangeEnd = 136889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_UpdateDestination_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003535 RID: 13621 RVA: 0x0011C634 File Offset: 0x0011A834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136890, XrefRangeEnd = 136940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003536 RID: 13622 RVA: 0x0011C670 File Offset: 0x0011A870
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136958, RefRangeEnd = 136959, XrefRangeStart = 136940, XrefRangeEnd = 136958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateStumble()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_UpdateStumble_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003537 RID: 13623 RVA: 0x0011C6A4 File Offset: 0x0011A8A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136959, XrefRangeEnd = 136963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSpeed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_UpdateSpeed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003538 RID: 13624 RVA: 0x0011C6D8 File Offset: 0x0011A8D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136963, XrefRangeEnd = 136967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordVelocity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RecordVelocity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003539 RID: 13625 RVA: 0x0011C70C File Offset: 0x0011A90C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136992, RefRangeEnd = 136993, XrefRangeStart = 136967, XrefRangeEnd = 136992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSlippery()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_UpdateSlippery_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600353A RID: 13626 RVA: 0x0011C740 File Offset: 0x0011A940
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137011, RefRangeEnd = 137012, XrefRangeStart = 136993, XrefRangeEnd = 137011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCache()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_UpdateCache_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600353B RID: 13627 RVA: 0x0011C774 File Offset: 0x0011A974
		[CallerCount(0)]
		public unsafe bool CanRecoverFromRagdoll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_CanRecoverFromRagdoll_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600353C RID: 13628 RVA: 0x0011C7B0 File Offset: 0x0011A9B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137012, XrefRangeEnd = 137019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAvoidance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_UpdateAvoidance_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600353D RID: 13629 RVA: 0x0011C7E4 File Offset: 0x0011A9E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137019, XrefRangeEnd = 137022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600353E RID: 13630 RVA: 0x0011C828 File Offset: 0x0011AA28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137022, XrefRangeEnd = 137028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionEnter(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_OnCollisionEnter_Public_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600353F RID: 13631 RVA: 0x0011C86C File Offset: 0x0011AA6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 137061, RefRangeEnd = 137063, XrefRangeStart = 137028, XrefRangeEnd = 137061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckHit(Collider other, Collider thisCollider, bool isCollision, Vector3 hitPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(thisCollider);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isCollision;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hitPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_CheckHit_Private_Void_Collider_Collider_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003540 RID: 13632 RVA: 0x0011C8DC File Offset: 0x0011AADC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 137067, RefRangeEnd = 137069, XrefRangeStart = 137063, XrefRangeEnd = 137067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Warp(Transform target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_Warp_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003541 RID: 13633 RVA: 0x0011C920 File Offset: 0x0011AB20
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 137086, RefRangeEnd = 137107, XrefRangeStart = 137069, XrefRangeEnd = 137086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Warp(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_Warp_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003542 RID: 13634 RVA: 0x0011C960 File Offset: 0x0011AB60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137107, XrefRangeEnd = 137128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveWarp(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_ReceiveWarp_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003543 RID: 13635 RVA: 0x0011C9A0 File Offset: 0x0011ABA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137128, XrefRangeEnd = 137131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VisibilityChange(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_VisibilityChange_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003544 RID: 13636 RVA: 0x0011C9E0 File Offset: 0x0011ABE0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 137133, RefRangeEnd = 137140, XrefRangeStart = 137131, XrefRangeEnd = 137133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_CanMove_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003545 RID: 13637 RVA: 0x0011CA1C File Offset: 0x0011AC1C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 137154, RefRangeEnd = 137165, XrefRangeStart = 137140, XrefRangeEnd = 137154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAgentType(NPCMovement.EAgentType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetAgentType_Public_Void_EAgentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003546 RID: 13638 RVA: 0x0011CA5C File Offset: 0x0011AC5C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 137174, RefRangeEnd = 137178, XrefRangeStart = 137165, XrefRangeEnd = 137174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSeat(AvatarSeat seat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(seat);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetSeat_Public_Void_AvatarSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003547 RID: 13639 RVA: 0x0011CAA0 File Offset: 0x0011ACA0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 136807, RefRangeEnd = 136812, XrefRangeStart = 136807, XrefRangeEnd = 136812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStance(NPCMovement.EStance stance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetStance_Public_Void_EStance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003548 RID: 13640 RVA: 0x0011CAE0 File Offset: 0x0011ACE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 137201, RefRangeEnd = 137204, XrefRangeStart = 137178, XrefRangeEnd = 137201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGravityMultiplier(float multiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetGravityMultiplier_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003549 RID: 13641 RVA: 0x0011CB20 File Offset: 0x0011AD20
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 137207, RefRangeEnd = 137212, XrefRangeStart = 137204, XrefRangeEnd = 137207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRagdollDraggable(bool draggable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref draggable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetRagdollDraggable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600354A RID: 13642 RVA: 0x0011CB60 File Offset: 0x0011AD60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 137233, RefRangeEnd = 137236, XrefRangeStart = 137212, XrefRangeEnd = 137233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateRagdoll_Server()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_ActivateRagdoll_Server_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600354B RID: 13643 RVA: 0x0011CB94 File Offset: 0x0011AD94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 137238, RefRangeEnd = 137240, XrefRangeStart = 137236, XrefRangeEnd = 137238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateRagdoll(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forcePoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceDir;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceMagnitude;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_ActivateRagdoll_Public_Void_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600354C RID: 13644 RVA: 0x0011CBF0 File Offset: 0x0011ADF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137240, XrefRangeEnd = 137242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyRagdollForce(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forcePoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceDir;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceMagnitude;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_ApplyRagdollForce_Public_Void_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600354D RID: 13645 RVA: 0x0011CC4C File Offset: 0x0011AE4C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 137263, RefRangeEnd = 137266, XrefRangeStart = 137242, XrefRangeEnd = 137263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeactivateRagdoll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_DeactivateRagdoll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600354E RID: 13646 RVA: 0x0011CC80 File Offset: 0x0011AE80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 137276, RefRangeEnd = 137278, XrefRangeStart = 137266, XrefRangeEnd = 137276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SmartSampleNavMesh(Vector3 position, out NavMeshHit hit, float minRadius = 1f, float maxRadius = 10f, int steps = 3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minRadius;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxRadius;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SmartSampleNavMesh_Private_Boolean_Vector3_byref_NavMeshHit_Single_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600354F RID: 13647 RVA: 0x0011CD04 File Offset: 0x0011AF04
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 137279, RefRangeEnd = 137300, XrefRangeStart = 137278, XrefRangeEnd = 137279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDestination(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetDestination_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003550 RID: 13648 RVA: 0x0011CD44 File Offset: 0x0011AF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137300, XrefRangeEnd = 137306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDestination(ITransitEntity entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetDestination_Public_Void_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003551 RID: 13649 RVA: 0x0011CD88 File Offset: 0x0011AF88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137307, RefRangeEnd = 137308, XrefRangeStart = 137306, XrefRangeEnd = 137307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDestination(Vector3 pos, Action<NPCMovement.WalkResult> callback = null, float maximumDistanceForSuccess = 1f, float cacheMaxDistSqr = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maximumDistanceForSuccess;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cacheMaxDistSqr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetDestination_Public_Void_Vector3_Action_1_WalkResult_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003552 RID: 13650 RVA: 0x0011CDF4 File Offset: 0x0011AFF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 137423, RefRangeEnd = 137426, XrefRangeStart = 137308, XrefRangeEnd = 137423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDestination(Vector3 pos, Action<NPCMovement.WalkResult> callback = null, bool interruptExistingCallback = true, float successThreshold = 1f, float cacheMaxDistSqr = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interruptExistingCallback;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref successThreshold;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cacheMaxDistSqr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetDestination_Private_Void_Vector3_Action_1_WalkResult_Boolean_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003553 RID: 13651 RVA: 0x0011CE70 File Offset: 0x0011B070
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137427, RefRangeEnd = 137428, XrefRangeStart = 137426, XrefRangeEnd = 137427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNPCPositionValid(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_IsNPCPositionValid_Private_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003554 RID: 13652 RVA: 0x0011CEBC File Offset: 0x0011B0BC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 137444, RefRangeEnd = 137450, XrefRangeStart = 137428, XrefRangeEnd = 137444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndSetDestination(NPCMovement.WalkResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_EndSetDestination_Private_Void_WalkResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003555 RID: 13653 RVA: 0x0011CEFC File Offset: 0x0011B0FC
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 137459, RefRangeEnd = 137495, XrefRangeStart = 137450, XrefRangeEnd = 137459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003556 RID: 13654 RVA: 0x0011CF30 File Offset: 0x0011B130
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WarpToNavMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_WarpToNavMesh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003557 RID: 13655 RVA: 0x0011CF64 File Offset: 0x0011B164
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 137515, RefRangeEnd = 137523, XrefRangeStart = 137495, XrefRangeEnd = 137515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FacePoint(Vector3 point, float lerpTime = 0.5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_FacePoint_Public_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003558 RID: 13656 RVA: 0x0011CFB0 File Offset: 0x0011B1B0
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 137546, RefRangeEnd = 137565, XrefRangeStart = 137523, XrefRangeEnd = 137546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FaceDirection(Vector3 forward, float lerpTime = 0.5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forward;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_FaceDirection_Public_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003559 RID: 13657 RVA: 0x0011CFFC File Offset: 0x0011B1FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137565, XrefRangeEnd = 137570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator FaceDirection_Process(Vector3 forward, float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forward;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_FaceDirection_Process_Protected_IEnumerator_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600355A RID: 13658 RVA: 0x0011D058 File Offset: 0x0011B258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137570, XrefRangeEnd = 137574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PauseMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_PauseMovement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600355B RID: 13659 RVA: 0x0011D08C File Offset: 0x0011B28C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137576, RefRangeEnd = 137577, XrefRangeStart = 137574, XrefRangeEnd = 137576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResumeMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_ResumeMovement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600355C RID: 13660 RVA: 0x0011D0C0 File Offset: 0x0011B2C0
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 137585, RefRangeEnd = 137602, XrefRangeStart = 137577, XrefRangeEnd = 137585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAsCloseAsPossible(Vector3 location, float distanceThreshold = 0.5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref location;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distanceThreshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_IsAsCloseAsPossible_Public_Boolean_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600355D RID: 13661 RVA: 0x0011D118 File Offset: 0x0011B318
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 137626, RefRangeEnd = 137629, XrefRangeStart = 137602, XrefRangeEnd = 137626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetClosestReachablePoint(Vector3 targetPosition, out Vector3 closestPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &closestPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_GetClosestReachablePoint_Public_Boolean_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600355E RID: 13662 RVA: 0x0011D170 File Offset: 0x0011B370
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 137630, RefRangeEnd = 137651, XrefRangeStart = 137629, XrefRangeEnd = 137630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanGetTo(Vector3 position, float proximityReq = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref proximityReq;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_CanGetTo_Public_Boolean_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600355F RID: 13663 RVA: 0x0011D1C8 File Offset: 0x0011B3C8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 137663, RefRangeEnd = 137667, XrefRangeStart = 137651, XrefRangeEnd = 137663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanGetTo(ITransitEntity entity, float proximityReq = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref proximityReq;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_CanGetTo_Public_Boolean_ITransitEntity_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003560 RID: 13664 RVA: 0x0011D224 File Offset: 0x0011B424
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 137698, RefRangeEnd = 137701, XrefRangeStart = 137667, XrefRangeEnd = 137698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanGetTo(Vector3 position, float proximityReq, out NavMeshPath path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref proximityReq;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_CanGetTo_Public_Boolean_Vector3_Single_byref_NavMeshPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			path = ((intPtr4 == 0) ? null : new NavMeshPath(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06003561 RID: 13665 RVA: 0x0011D2A0 File Offset: 0x0011B4A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137728, RefRangeEnd = 137729, XrefRangeStart = 137701, XrefRangeEnd = 137728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NavMeshPath GetPathTo(Vector3 position, float proximityReq = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref proximityReq;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_GetPathTo_Private_NavMeshPath_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NavMeshPath>(intPtr3) : null;
		}

		// Token: 0x06003562 RID: 13666 RVA: 0x0011D2FC File Offset: 0x0011B4FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137729, XrefRangeEnd = 137762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCMovement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003563 RID: 13667 RVA: 0x0011D338 File Offset: 0x0011B538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137762, XrefRangeEnd = 137794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003564 RID: 13668 RVA: 0x0011D374 File Offset: 0x0011B574
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003565 RID: 13669 RVA: 0x0011D3B0 File Offset: 0x0011B5B0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003566 RID: 13670 RVA: 0x0011D3EC File Offset: 0x0011B5EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveWarp_4276783012(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveWarp_4276783012_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003567 RID: 13671 RVA: 0x0011D42C File Offset: 0x0011B62C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137794, XrefRangeEnd = 137798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveWarp_4276783012(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcLogic___ReceiveWarp_4276783012_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003568 RID: 13672 RVA: 0x0011D46C File Offset: 0x0011B66C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137798, XrefRangeEnd = 137806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveWarp_4276783012(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcReader___Observers_ReceiveWarp_4276783012_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003569 RID: 13673 RVA: 0x0011D4BC File Offset: 0x0011B6BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137806, XrefRangeEnd = 137824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ActivateRagdoll_Server_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcWriter___Server_ActivateRagdoll_Server_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600356A RID: 13674 RVA: 0x0011D4F0 File Offset: 0x0011B6F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 137830, RefRangeEnd = 137832, XrefRangeStart = 137824, XrefRangeEnd = 137830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ActivateRagdoll_Server_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcLogic___ActivateRagdoll_Server_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600356B RID: 13675 RVA: 0x0011D524 File Offset: 0x0011B724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137832, XrefRangeEnd = 137835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ActivateRagdoll_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcReader___Server_ActivateRagdoll_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600356C RID: 13676 RVA: 0x0011D588 File Offset: 0x0011B788
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 137851, RefRangeEnd = 137853, XrefRangeStart = 137835, XrefRangeEnd = 137851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ActivateRagdoll_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forcePoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceDir;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceMagnitude;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcWriter___Observers_ActivateRagdoll_2690242654_Private_Void_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600356D RID: 13677 RVA: 0x0011D5E4 File Offset: 0x0011B7E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 137861, RefRangeEnd = 137864, XrefRangeStart = 137853, XrefRangeEnd = 137861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ActivateRagdoll_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forcePoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceDir;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceMagnitude;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcLogic___ActivateRagdoll_2690242654_Public_Void_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600356E RID: 13678 RVA: 0x0011D640 File Offset: 0x0011B840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137864, XrefRangeEnd = 137874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ActivateRagdoll_2690242654(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcReader___Observers_ActivateRagdoll_2690242654_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600356F RID: 13679 RVA: 0x0011D690 File Offset: 0x0011B890
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 137890, RefRangeEnd = 137892, XrefRangeStart = 137874, XrefRangeEnd = 137890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ApplyRagdollForce_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forcePoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceDir;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceMagnitude;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcWriter___Observers_ApplyRagdollForce_2690242654_Private_Void_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003570 RID: 13680 RVA: 0x0011D6EC File Offset: 0x0011B8EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 137929, RefRangeEnd = 137932, XrefRangeStart = 137892, XrefRangeEnd = 137929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ApplyRagdollForce_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forcePoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceDir;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceMagnitude;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcLogic___ApplyRagdollForce_2690242654_Public_Void_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003571 RID: 13681 RVA: 0x0011D748 File Offset: 0x0011B948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137932, XrefRangeEnd = 137942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ApplyRagdollForce_2690242654(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcReader___Observers_ApplyRagdollForce_2690242654_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003572 RID: 13682 RVA: 0x0011D798 File Offset: 0x0011B998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137942, XrefRangeEnd = 137960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_DeactivateRagdoll_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcWriter___Observers_DeactivateRagdoll_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003573 RID: 13683 RVA: 0x0011D7CC File Offset: 0x0011B9CC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 137996, RefRangeEnd = 138000, XrefRangeStart = 137960, XrefRangeEnd = 137996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___DeactivateRagdoll_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcLogic___DeactivateRagdoll_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003574 RID: 13684 RVA: 0x0011D800 File Offset: 0x0011BA00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138000, XrefRangeEnd = 138003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_DeactivateRagdoll_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcReader___Observers_DeactivateRagdoll_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003575 RID: 13685 RVA: 0x0011D850 File Offset: 0x0011BA50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 138042, RefRangeEnd = 138043, XrefRangeStart = 138003, XrefRangeEnd = 138042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003576 RID: 13686 RVA: 0x0001BF6F File Offset: 0x0001A16F
		public NPCMovement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700111E RID: 4382
		// (get) Token: 0x06003577 RID: 13687 RVA: 0x0011D88C File Offset: 0x0011BA8C
		// (set) Token: 0x06003578 RID: 13688 RVA: 0x0001BF78 File Offset: 0x0001A178
		public unsafe static float VEHICLE_RUNOVER_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_VEHICLE_RUNOVER_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_VEHICLE_RUNOVER_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x1700111F RID: 4383
		// (get) Token: 0x06003579 RID: 13689 RVA: 0x0011D8A8 File Offset: 0x0011BAA8
		// (set) Token: 0x0600357A RID: 13690 RVA: 0x0001BF86 File Offset: 0x0001A186
		public unsafe static float SKATEBOARD_RUNOVER_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_SKATEBOARD_RUNOVER_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_SKATEBOARD_RUNOVER_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17001120 RID: 4384
		// (get) Token: 0x0600357B RID: 13691 RVA: 0x0011D8C4 File Offset: 0x0011BAC4
		// (set) Token: 0x0600357C RID: 13692 RVA: 0x0001BF94 File Offset: 0x0001A194
		public unsafe static float LIGHT_FLINCH_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_LIGHT_FLINCH_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_LIGHT_FLINCH_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17001121 RID: 4385
		// (get) Token: 0x0600357D RID: 13693 RVA: 0x0011D8E0 File Offset: 0x0011BAE0
		// (set) Token: 0x0600357E RID: 13694 RVA: 0x0001BFA2 File Offset: 0x0001A1A2
		public unsafe static float HEAVY_FLINCH_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_HEAVY_FLINCH_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_HEAVY_FLINCH_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17001122 RID: 4386
		// (get) Token: 0x0600357F RID: 13695 RVA: 0x0011D8FC File Offset: 0x0011BAFC
		// (set) Token: 0x06003580 RID: 13696 RVA: 0x0001BFB0 File Offset: 0x0001A1B0
		public unsafe static float RAGDOLL_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_RAGDOLL_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_RAGDOLL_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17001123 RID: 4387
		// (get) Token: 0x06003581 RID: 13697 RVA: 0x0011D918 File Offset: 0x0011BB18
		// (set) Token: 0x06003582 RID: 13698 RVA: 0x0001BFBE File Offset: 0x0001A1BE
		public unsafe static float MOMENTUM_ANNOYED_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_MOMENTUM_ANNOYED_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_MOMENTUM_ANNOYED_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17001124 RID: 4388
		// (get) Token: 0x06003583 RID: 13699 RVA: 0x0011D934 File Offset: 0x0011BB34
		// (set) Token: 0x06003584 RID: 13700 RVA: 0x0001BFCC File Offset: 0x0001A1CC
		public unsafe static float MOMENTUM_LIGHT_FLINCH_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_MOMENTUM_LIGHT_FLINCH_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_MOMENTUM_LIGHT_FLINCH_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17001125 RID: 4389
		// (get) Token: 0x06003585 RID: 13701 RVA: 0x0011D950 File Offset: 0x0011BB50
		// (set) Token: 0x06003586 RID: 13702 RVA: 0x0001BFDA File Offset: 0x0001A1DA
		public unsafe static float MOMENTUM_HEAVY_FLINCH_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_MOMENTUM_HEAVY_FLINCH_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_MOMENTUM_HEAVY_FLINCH_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17001126 RID: 4390
		// (get) Token: 0x06003587 RID: 13703 RVA: 0x0011D96C File Offset: 0x0011BB6C
		// (set) Token: 0x06003588 RID: 13704 RVA: 0x0001BFE8 File Offset: 0x0001A1E8
		public unsafe static float MOMENTUM_RAGDOLL_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_MOMENTUM_RAGDOLL_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_MOMENTUM_RAGDOLL_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17001127 RID: 4391
		// (get) Token: 0x06003589 RID: 13705 RVA: 0x0011D988 File Offset: 0x0011BB88
		// (set) Token: 0x0600358A RID: 13706 RVA: 0x0001BFF6 File Offset: 0x0001A1F6
		public unsafe static bool USE_PATH_CACHE
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_USE_PATH_CACHE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_USE_PATH_CACHE, (void*)(&value));
			}
		}

		// Token: 0x17001128 RID: 4392
		// (get) Token: 0x0600358B RID: 13707 RVA: 0x0011D9A4 File Offset: 0x0011BBA4
		// (set) Token: 0x0600358C RID: 13708 RVA: 0x0001C004 File Offset: 0x0001A204
		public unsafe static float STUMBLE_DURATION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_STUMBLE_DURATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_STUMBLE_DURATION, (void*)(&value));
			}
		}

		// Token: 0x17001129 RID: 4393
		// (get) Token: 0x0600358D RID: 13709 RVA: 0x0011D9C0 File Offset: 0x0011BBC0
		// (set) Token: 0x0600358E RID: 13710 RVA: 0x0001C012 File Offset: 0x0001A212
		public unsafe static float STUMBLE_FORCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_STUMBLE_FORCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_STUMBLE_FORCE, (void*)(&value));
			}
		}

		// Token: 0x1700112A RID: 4394
		// (get) Token: 0x0600358F RID: 13711 RVA: 0x0011D9DC File Offset: 0x0011BBDC
		// (set) Token: 0x06003590 RID: 13712 RVA: 0x0001C020 File Offset: 0x0001A220
		public unsafe static float OBSTACLE_AVOIDANCE_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_OBSTACLE_AVOIDANCE_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_OBSTACLE_AVOIDANCE_RANGE, (void*)(&value));
			}
		}

		// Token: 0x1700112B RID: 4395
		// (get) Token: 0x06003591 RID: 13713 RVA: 0x0011D9F8 File Offset: 0x0011BBF8
		// (set) Token: 0x06003592 RID: 13714 RVA: 0x0001C02E File Offset: 0x0001A22E
		public unsafe static float PLAYER_DIST_IMPACT_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_PLAYER_DIST_IMPACT_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_PLAYER_DIST_IMPACT_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x1700112C RID: 4396
		// (get) Token: 0x06003593 RID: 13715 RVA: 0x0011DA14 File Offset: 0x0011BC14
		// (set) Token: 0x06003594 RID: 13716 RVA: 0x0001C03C File Offset: 0x0001A23C
		public unsafe static Dictionary<Vector3, Vector3> cachedClosestReachablePoints
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_cachedClosestReachablePoints, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Vector3, Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_cachedClosestReachablePoints, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700112D RID: 4397
		// (get) Token: 0x06003595 RID: 13717 RVA: 0x0011DA3C File Offset: 0x0011BC3C
		// (set) Token: 0x06003596 RID: 13718 RVA: 0x0001C04E File Offset: 0x0001A24E
		public unsafe static List<Vector3> cachedClosestPointKeys
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_cachedClosestPointKeys, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_cachedClosestPointKeys, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700112E RID: 4398
		// (get) Token: 0x06003597 RID: 13719 RVA: 0x0011DA64 File Offset: 0x0011BC64
		// (set) Token: 0x06003598 RID: 13720 RVA: 0x0001C060 File Offset: 0x0001A260
		public unsafe static float CLOSEST_REACHABLE_POINT_CACHE_MAX_SQR_OFFSET
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_CLOSEST_REACHABLE_POINT_CACHE_MAX_SQR_OFFSET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_CLOSEST_REACHABLE_POINT_CACHE_MAX_SQR_OFFSET, (void*)(&value));
			}
		}

		// Token: 0x1700112F RID: 4399
		// (get) Token: 0x06003599 RID: 13721 RVA: 0x0011DA80 File Offset: 0x0011BC80
		// (set) Token: 0x0600359A RID: 13722 RVA: 0x0001C06E File Offset: 0x0001A26E
		public unsafe bool DEBUG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x17001130 RID: 4400
		// (get) Token: 0x0600359B RID: 13723 RVA: 0x0011DAA8 File Offset: 0x0011BCA8
		// (set) Token: 0x0600359C RID: 13724 RVA: 0x0001C089 File Offset: 0x0001A289
		public unsafe float WalkSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_WalkSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_WalkSpeed)) = value;
			}
		}

		// Token: 0x17001131 RID: 4401
		// (get) Token: 0x0600359D RID: 13725 RVA: 0x0011DAD0 File Offset: 0x0011BCD0
		// (set) Token: 0x0600359E RID: 13726 RVA: 0x0001C0A4 File Offset: 0x0001A2A4
		public unsafe float RunSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_RunSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_RunSpeed)) = value;
			}
		}

		// Token: 0x17001132 RID: 4402
		// (get) Token: 0x0600359F RID: 13727 RVA: 0x0011DAF8 File Offset: 0x0011BCF8
		// (set) Token: 0x060035A0 RID: 13728 RVA: 0x0001C0BF File Offset: 0x0001A2BF
		public unsafe float MoveSpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_MoveSpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_MoveSpeedMultiplier)) = value;
			}
		}

		// Token: 0x17001133 RID: 4403
		// (get) Token: 0x060035A1 RID: 13729 RVA: 0x0011DB20 File Offset: 0x0011BD20
		// (set) Token: 0x060035A2 RID: 13730 RVA: 0x0001C0DA File Offset: 0x0001A2DA
		public unsafe bool SlipperyMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_SlipperyMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_SlipperyMode)) = value;
			}
		}

		// Token: 0x17001134 RID: 4404
		// (get) Token: 0x060035A3 RID: 13731 RVA: 0x0011DB48 File Offset: 0x0011BD48
		// (set) Token: 0x060035A4 RID: 13732 RVA: 0x0001C0F5 File Offset: 0x0001A2F5
		public unsafe float SlipperyModeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_SlipperyModeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_SlipperyModeMultiplier)) = value;
			}
		}

		// Token: 0x17001135 RID: 4405
		// (get) Token: 0x060035A5 RID: 13733 RVA: 0x0011DB70 File Offset: 0x0011BD70
		// (set) Token: 0x060035A6 RID: 13734 RVA: 0x0001C110 File Offset: 0x0001A310
		public unsafe ObstacleAvoidanceType DefaultObstacleAvoidanceType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_DefaultObstacleAvoidanceType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_DefaultObstacleAvoidanceType)) = value;
			}
		}

		// Token: 0x17001136 RID: 4406
		// (get) Token: 0x060035A7 RID: 13735 RVA: 0x0011DB98 File Offset: 0x0011BD98
		// (set) Token: 0x060035A8 RID: 13736 RVA: 0x0001C12B File Offset: 0x0001A32B
		public unsafe NavMeshAgent Agent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_Agent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavMeshAgent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_Agent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001137 RID: 4407
		// (get) Token: 0x060035A9 RID: 13737 RVA: 0x0011DBC8 File Offset: 0x0011BDC8
		// (set) Token: 0x060035AA RID: 13738 RVA: 0x0001C14A File Offset: 0x0001A34A
		public unsafe NPCSpeedController SpeedController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_SpeedController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCSpeedController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_SpeedController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001138 RID: 4408
		// (get) Token: 0x060035AB RID: 13739 RVA: 0x0011DBF8 File Offset: 0x0011BDF8
		// (set) Token: 0x060035AC RID: 13740 RVA: 0x0001C169 File Offset: 0x0001A369
		public unsafe NPC npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001139 RID: 4409
		// (get) Token: 0x060035AD RID: 13741 RVA: 0x0011DC28 File Offset: 0x0011BE28
		// (set) Token: 0x060035AE RID: 13742 RVA: 0x0001C188 File Offset: 0x0001A388
		public unsafe CapsuleCollider capsuleCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_capsuleCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CapsuleCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_capsuleCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700113A RID: 4410
		// (get) Token: 0x060035AF RID: 13743 RVA: 0x0011DC58 File Offset: 0x0011BE58
		// (set) Token: 0x060035B0 RID: 13744 RVA: 0x0001C1A7 File Offset: 0x0001A3A7
		public unsafe NPCAnimation anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700113B RID: 4411
		// (get) Token: 0x060035B1 RID: 13745 RVA: 0x0011DC88 File Offset: 0x0011BE88
		// (set) Token: 0x060035B2 RID: 13746 RVA: 0x0001C1C6 File Offset: 0x0001A3C6
		public unsafe Rigidbody ragdollCentralRB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_ragdollCentralRB);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_ragdollCentralRB), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700113C RID: 4412
		// (get) Token: 0x060035B3 RID: 13747 RVA: 0x0011DCB8 File Offset: 0x0011BEB8
		// (set) Token: 0x060035B4 RID: 13748 RVA: 0x0001C1E5 File Offset: 0x0001A3E5
		public unsafe SmoothedVelocityCalculator velocityCalculator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_velocityCalculator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_velocityCalculator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700113D RID: 4413
		// (get) Token: 0x060035B5 RID: 13749 RVA: 0x0011DCE8 File Offset: 0x0011BEE8
		// (set) Token: 0x060035B6 RID: 13750 RVA: 0x0001C204 File Offset: 0x0001A404
		public unsafe Draggable RagdollDraggable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_RagdollDraggable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_RagdollDraggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700113E RID: 4414
		// (get) Token: 0x060035B7 RID: 13751 RVA: 0x0011DD18 File Offset: 0x0011BF18
		// (set) Token: 0x060035B8 RID: 13752 RVA: 0x0001C223 File Offset: 0x0001A423
		public unsafe Collider RagdollDraggableCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_RagdollDraggableCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_RagdollDraggableCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700113F RID: 4415
		// (get) Token: 0x060035B9 RID: 13753 RVA: 0x0011DD48 File Offset: 0x0011BF48
		// (set) Token: 0x060035BA RID: 13754 RVA: 0x0001C242 File Offset: 0x0001A442
		public unsafe float MovementSpeedScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_MovementSpeedScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_MovementSpeedScale)) = value;
			}
		}

		// Token: 0x17001140 RID: 4416
		// (get) Token: 0x060035BB RID: 13755 RVA: 0x0011DD70 File Offset: 0x0011BF70
		// (set) Token: 0x060035BC RID: 13756 RVA: 0x0001C25D File Offset: 0x0001A45D
		public unsafe bool _hasDestination_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__hasDestination_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__hasDestination_k__BackingField)) = value;
			}
		}

		// Token: 0x17001141 RID: 4417
		// (get) Token: 0x060035BD RID: 13757 RVA: 0x0011DD98 File Offset: 0x0011BF98
		// (set) Token: 0x060035BE RID: 13758 RVA: 0x0001C278 File Offset: 0x0001A478
		public unsafe bool _IsPaused_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__IsPaused_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__IsPaused_k__BackingField)) = value;
			}
		}

		// Token: 0x17001142 RID: 4418
		// (get) Token: 0x060035BF RID: 13759 RVA: 0x0011DDC0 File Offset: 0x0011BFC0
		// (set) Token: 0x060035C0 RID: 13760 RVA: 0x0001C293 File Offset: 0x0001A493
		public unsafe float _GravityMultiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__GravityMultiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__GravityMultiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x17001143 RID: 4419
		// (get) Token: 0x060035C1 RID: 13761 RVA: 0x0011DDE8 File Offset: 0x0011BFE8
		// (set) Token: 0x060035C2 RID: 13762 RVA: 0x0001C2AE File Offset: 0x0001A4AE
		public unsafe NPCMovement.EStance _Stance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__Stance_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__Stance_k__BackingField)) = value;
			}
		}

		// Token: 0x17001144 RID: 4420
		// (get) Token: 0x060035C3 RID: 13763 RVA: 0x0011DE10 File Offset: 0x0011C010
		// (set) Token: 0x060035C4 RID: 13764 RVA: 0x0001C2C9 File Offset: 0x0001A4C9
		public unsafe float _timeSinceHitByCar_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__timeSinceHitByCar_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__timeSinceHitByCar_k__BackingField)) = value;
			}
		}

		// Token: 0x17001145 RID: 4421
		// (get) Token: 0x060035C5 RID: 13765 RVA: 0x0011DE38 File Offset: 0x0011C038
		// (set) Token: 0x060035C6 RID: 13766 RVA: 0x0001C2E4 File Offset: 0x0001A4E4
		public unsafe float ragdollTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_ragdollTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_ragdollTime)) = value;
			}
		}

		// Token: 0x17001146 RID: 4422
		// (get) Token: 0x060035C7 RID: 13767 RVA: 0x0011DE60 File Offset: 0x0011C060
		// (set) Token: 0x060035C8 RID: 13768 RVA: 0x0001C2FF File Offset: 0x0001A4FF
		public unsafe float ragdollStaticTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_ragdollStaticTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_ragdollStaticTime)) = value;
			}
		}

		// Token: 0x17001147 RID: 4423
		// (get) Token: 0x060035C9 RID: 13769 RVA: 0x0011DE88 File Offset: 0x0011C088
		// (set) Token: 0x060035CA RID: 13770 RVA: 0x0001C31A File Offset: 0x0001A51A
		public unsafe UnityEvent<LandVehicle> onHitByCar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_onHitByCar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_onHitByCar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001148 RID: 4424
		// (get) Token: 0x060035CB RID: 13771 RVA: 0x0011DEB8 File Offset: 0x0011C0B8
		// (set) Token: 0x060035CC RID: 13772 RVA: 0x0001C339 File Offset: 0x0001A539
		public unsafe UnityEvent onRagdollStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_onRagdollStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_onRagdollStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001149 RID: 4425
		// (get) Token: 0x060035CD RID: 13773 RVA: 0x0011DEE8 File Offset: 0x0011C0E8
		// (set) Token: 0x060035CE RID: 13774 RVA: 0x0001C358 File Offset: 0x0001A558
		public unsafe UnityEvent onRagdollEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_onRagdollEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_onRagdollEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700114A RID: 4426
		// (get) Token: 0x060035CF RID: 13775 RVA: 0x0011DF18 File Offset: 0x0011C118
		// (set) Token: 0x060035D0 RID: 13776 RVA: 0x0001C377 File Offset: 0x0001A577
		public unsafe Vector3 _CurrentDestination_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__CurrentDestination_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__CurrentDestination_k__BackingField)) = value;
			}
		}

		// Token: 0x1700114B RID: 4427
		// (get) Token: 0x060035D1 RID: 13777 RVA: 0x0011DF40 File Offset: 0x0011C140
		// (set) Token: 0x060035D2 RID: 13778 RVA: 0x0001C392 File Offset: 0x0001A592
		public unsafe NPCPathCache _PathCache_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__PathCache_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCPathCache>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__PathCache_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700114C RID: 4428
		// (get) Token: 0x060035D3 RID: 13779 RVA: 0x0011DF70 File Offset: 0x0011C170
		// (set) Token: 0x060035D4 RID: 13780 RVA: 0x0001C3B1 File Offset: 0x0001A5B1
		public unsafe bool cacheNextPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_cacheNextPath);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_cacheNextPath)) = value;
			}
		}

		// Token: 0x1700114D RID: 4429
		// (get) Token: 0x060035D5 RID: 13781 RVA: 0x0011DF98 File Offset: 0x0011C198
		// (set) Token: 0x060035D6 RID: 13782 RVA: 0x0001C3CC File Offset: 0x0001A5CC
		public unsafe Vector3 currentDestination_Reachable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_currentDestination_Reachable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_currentDestination_Reachable)) = value;
			}
		}

		// Token: 0x1700114E RID: 4430
		// (get) Token: 0x060035D7 RID: 13783 RVA: 0x0011DFC0 File Offset: 0x0011C1C0
		// (set) Token: 0x060035D8 RID: 13784 RVA: 0x0001C3E7 File Offset: 0x0001A5E7
		public unsafe Action<NPCMovement.WalkResult> walkResultCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_walkResultCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<NPCMovement.WalkResult>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_walkResultCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700114F RID: 4431
		// (get) Token: 0x060035D9 RID: 13785 RVA: 0x0011DFF0 File Offset: 0x0011C1F0
		// (set) Token: 0x060035DA RID: 13786 RVA: 0x0001C406 File Offset: 0x0001A606
		public unsafe float currentMaxDistanceForSuccess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_currentMaxDistanceForSuccess);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_currentMaxDistanceForSuccess)) = value;
			}
		}

		// Token: 0x17001150 RID: 4432
		// (get) Token: 0x060035DB RID: 13787 RVA: 0x0011E018 File Offset: 0x0011C218
		// (set) Token: 0x060035DC RID: 13788 RVA: 0x0001C421 File Offset: 0x0001A621
		public unsafe bool forceIsMoving
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_forceIsMoving);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_forceIsMoving)) = value;
			}
		}

		// Token: 0x17001151 RID: 4433
		// (get) Token: 0x060035DD RID: 13789 RVA: 0x0011E040 File Offset: 0x0011C240
		// (set) Token: 0x060035DE RID: 13790 RVA: 0x0001C43C File Offset: 0x0001A63C
		public unsafe Coroutine FaceDirectionRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_FaceDirectionRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_FaceDirectionRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001152 RID: 4434
		// (get) Token: 0x060035DF RID: 13791 RVA: 0x0011E070 File Offset: 0x0011C270
		// (set) Token: 0x060035E0 RID: 13792 RVA: 0x0001C45B File Offset: 0x0001A65B
		public unsafe List<ConstantForce> ragdollForceComponents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_ragdollForceComponents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ConstantForce>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_ragdollForceComponents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001153 RID: 4435
		// (get) Token: 0x060035E1 RID: 13793 RVA: 0x0011E0A0 File Offset: 0x0011C2A0
		// (set) Token: 0x060035E2 RID: 13794 RVA: 0x0001C47A File Offset: 0x0001A67A
		public unsafe bool _Disoriented_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__Disoriented_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__Disoriented_k__BackingField)) = value;
			}
		}

		// Token: 0x17001154 RID: 4436
		// (get) Token: 0x060035E3 RID: 13795 RVA: 0x0011E0C8 File Offset: 0x0011C2C8
		// (set) Token: 0x060035E4 RID: 13796 RVA: 0x0001C495 File Offset: 0x0001A695
		public unsafe float timeUntilNextStumble
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_timeUntilNextStumble);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_timeUntilNextStumble)) = value;
			}
		}

		// Token: 0x17001155 RID: 4437
		// (get) Token: 0x060035E5 RID: 13797 RVA: 0x0011E0F0 File Offset: 0x0011C2F0
		// (set) Token: 0x060035E6 RID: 13798 RVA: 0x0001C4B0 File Offset: 0x0001A6B0
		public unsafe float timeSinceStumble
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_timeSinceStumble);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_timeSinceStumble)) = value;
			}
		}

		// Token: 0x17001156 RID: 4438
		// (get) Token: 0x060035E7 RID: 13799 RVA: 0x0011E118 File Offset: 0x0011C318
		// (set) Token: 0x060035E8 RID: 13800 RVA: 0x0001C4CB File Offset: 0x0001A6CB
		public unsafe Vector3 stumbleDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_stumbleDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_stumbleDirection)) = value;
			}
		}

		// Token: 0x17001157 RID: 4439
		// (get) Token: 0x060035E9 RID: 13801 RVA: 0x0011E140 File Offset: 0x0011C340
		// (set) Token: 0x060035EA RID: 13802 RVA: 0x0001C4E6 File Offset: 0x0001A6E6
		public unsafe List<Vector3> desiredVelocityHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_desiredVelocityHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_desiredVelocityHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001158 RID: 4440
		// (get) Token: 0x060035EB RID: 13803 RVA: 0x0011E170 File Offset: 0x0011C370
		// (set) Token: 0x060035EC RID: 13804 RVA: 0x0001C505 File Offset: 0x0001A705
		public unsafe int desiredVelocityHistoryLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_desiredVelocityHistoryLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_desiredVelocityHistoryLength)) = value;
			}
		}

		// Token: 0x17001159 RID: 4441
		// (get) Token: 0x060035ED RID: 13805 RVA: 0x0011E198 File Offset: 0x0011C398
		// (set) Token: 0x060035EE RID: 13806 RVA: 0x0001C520 File Offset: 0x0001A720
		public unsafe float velocityHistorySpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_velocityHistorySpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_velocityHistorySpacing)) = value;
			}
		}

		// Token: 0x1700115A RID: 4442
		// (get) Token: 0x060035EF RID: 13807 RVA: 0x0011E1C0 File Offset: 0x0011C3C0
		// (set) Token: 0x060035F0 RID: 13808 RVA: 0x0001C53B File Offset: 0x0001A73B
		public unsafe float timeSinceLastVelocityHistoryRecord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_timeSinceLastVelocityHistoryRecord);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_timeSinceLastVelocityHistoryRecord)) = value;
			}
		}

		// Token: 0x1700115B RID: 4443
		// (get) Token: 0x060035F1 RID: 13809 RVA: 0x0011E1E8 File Offset: 0x0011C3E8
		// (set) Token: 0x060035F2 RID: 13810 RVA: 0x0001C556 File Offset: 0x0001A756
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700115C RID: 4444
		// (get) Token: 0x060035F3 RID: 13811 RVA: 0x0011E210 File Offset: 0x0011C410
		// (set) Token: 0x060035F4 RID: 13812 RVA: 0x0001C571 File Offset: 0x0001A771
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040022AC RID: 8876
		private static readonly IntPtr NativeFieldInfoPtr_VEHICLE_RUNOVER_THRESHOLD;

		// Token: 0x040022AD RID: 8877
		private static readonly IntPtr NativeFieldInfoPtr_SKATEBOARD_RUNOVER_THRESHOLD;

		// Token: 0x040022AE RID: 8878
		private static readonly IntPtr NativeFieldInfoPtr_LIGHT_FLINCH_THRESHOLD;

		// Token: 0x040022AF RID: 8879
		private static readonly IntPtr NativeFieldInfoPtr_HEAVY_FLINCH_THRESHOLD;

		// Token: 0x040022B0 RID: 8880
		private static readonly IntPtr NativeFieldInfoPtr_RAGDOLL_THRESHOLD;

		// Token: 0x040022B1 RID: 8881
		private static readonly IntPtr NativeFieldInfoPtr_MOMENTUM_ANNOYED_THRESHOLD;

		// Token: 0x040022B2 RID: 8882
		private static readonly IntPtr NativeFieldInfoPtr_MOMENTUM_LIGHT_FLINCH_THRESHOLD;

		// Token: 0x040022B3 RID: 8883
		private static readonly IntPtr NativeFieldInfoPtr_MOMENTUM_HEAVY_FLINCH_THRESHOLD;

		// Token: 0x040022B4 RID: 8884
		private static readonly IntPtr NativeFieldInfoPtr_MOMENTUM_RAGDOLL_THRESHOLD;

		// Token: 0x040022B5 RID: 8885
		private static readonly IntPtr NativeFieldInfoPtr_USE_PATH_CACHE;

		// Token: 0x040022B6 RID: 8886
		private static readonly IntPtr NativeFieldInfoPtr_STUMBLE_DURATION;

		// Token: 0x040022B7 RID: 8887
		private static readonly IntPtr NativeFieldInfoPtr_STUMBLE_FORCE;

		// Token: 0x040022B8 RID: 8888
		private static readonly IntPtr NativeFieldInfoPtr_OBSTACLE_AVOIDANCE_RANGE;

		// Token: 0x040022B9 RID: 8889
		private static readonly IntPtr NativeFieldInfoPtr_PLAYER_DIST_IMPACT_THRESHOLD;

		// Token: 0x040022BA RID: 8890
		private static readonly IntPtr NativeFieldInfoPtr_cachedClosestReachablePoints;

		// Token: 0x040022BB RID: 8891
		private static readonly IntPtr NativeFieldInfoPtr_cachedClosestPointKeys;

		// Token: 0x040022BC RID: 8892
		private static readonly IntPtr NativeFieldInfoPtr_CLOSEST_REACHABLE_POINT_CACHE_MAX_SQR_OFFSET;

		// Token: 0x040022BD RID: 8893
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x040022BE RID: 8894
		private static readonly IntPtr NativeFieldInfoPtr_WalkSpeed;

		// Token: 0x040022BF RID: 8895
		private static readonly IntPtr NativeFieldInfoPtr_RunSpeed;

		// Token: 0x040022C0 RID: 8896
		private static readonly IntPtr NativeFieldInfoPtr_MoveSpeedMultiplier;

		// Token: 0x040022C1 RID: 8897
		private static readonly IntPtr NativeFieldInfoPtr_SlipperyMode;

		// Token: 0x040022C2 RID: 8898
		private static readonly IntPtr NativeFieldInfoPtr_SlipperyModeMultiplier;

		// Token: 0x040022C3 RID: 8899
		private static readonly IntPtr NativeFieldInfoPtr_DefaultObstacleAvoidanceType;

		// Token: 0x040022C4 RID: 8900
		private static readonly IntPtr NativeFieldInfoPtr_Agent;

		// Token: 0x040022C5 RID: 8901
		private static readonly IntPtr NativeFieldInfoPtr_SpeedController;

		// Token: 0x040022C6 RID: 8902
		private static readonly IntPtr NativeFieldInfoPtr_npc;

		// Token: 0x040022C7 RID: 8903
		private static readonly IntPtr NativeFieldInfoPtr_capsuleCollider;

		// Token: 0x040022C8 RID: 8904
		private static readonly IntPtr NativeFieldInfoPtr_anim;

		// Token: 0x040022C9 RID: 8905
		private static readonly IntPtr NativeFieldInfoPtr_ragdollCentralRB;

		// Token: 0x040022CA RID: 8906
		private static readonly IntPtr NativeFieldInfoPtr_velocityCalculator;

		// Token: 0x040022CB RID: 8907
		private static readonly IntPtr NativeFieldInfoPtr_RagdollDraggable;

		// Token: 0x040022CC RID: 8908
		private static readonly IntPtr NativeFieldInfoPtr_RagdollDraggableCollider;

		// Token: 0x040022CD RID: 8909
		private static readonly IntPtr NativeFieldInfoPtr_MovementSpeedScale;

		// Token: 0x040022CE RID: 8910
		private static readonly IntPtr NativeFieldInfoPtr__hasDestination_k__BackingField;

		// Token: 0x040022CF RID: 8911
		private static readonly IntPtr NativeFieldInfoPtr__IsPaused_k__BackingField;

		// Token: 0x040022D0 RID: 8912
		private static readonly IntPtr NativeFieldInfoPtr__GravityMultiplier_k__BackingField;

		// Token: 0x040022D1 RID: 8913
		private static readonly IntPtr NativeFieldInfoPtr__Stance_k__BackingField;

		// Token: 0x040022D2 RID: 8914
		private static readonly IntPtr NativeFieldInfoPtr__timeSinceHitByCar_k__BackingField;

		// Token: 0x040022D3 RID: 8915
		private static readonly IntPtr NativeFieldInfoPtr_ragdollTime;

		// Token: 0x040022D4 RID: 8916
		private static readonly IntPtr NativeFieldInfoPtr_ragdollStaticTime;

		// Token: 0x040022D5 RID: 8917
		private static readonly IntPtr NativeFieldInfoPtr_onHitByCar;

		// Token: 0x040022D6 RID: 8918
		private static readonly IntPtr NativeFieldInfoPtr_onRagdollStart;

		// Token: 0x040022D7 RID: 8919
		private static readonly IntPtr NativeFieldInfoPtr_onRagdollEnd;

		// Token: 0x040022D8 RID: 8920
		private static readonly IntPtr NativeFieldInfoPtr__CurrentDestination_k__BackingField;

		// Token: 0x040022D9 RID: 8921
		private static readonly IntPtr NativeFieldInfoPtr__PathCache_k__BackingField;

		// Token: 0x040022DA RID: 8922
		private static readonly IntPtr NativeFieldInfoPtr_cacheNextPath;

		// Token: 0x040022DB RID: 8923
		private static readonly IntPtr NativeFieldInfoPtr_currentDestination_Reachable;

		// Token: 0x040022DC RID: 8924
		private static readonly IntPtr NativeFieldInfoPtr_walkResultCallback;

		// Token: 0x040022DD RID: 8925
		private static readonly IntPtr NativeFieldInfoPtr_currentMaxDistanceForSuccess;

		// Token: 0x040022DE RID: 8926
		private static readonly IntPtr NativeFieldInfoPtr_forceIsMoving;

		// Token: 0x040022DF RID: 8927
		private static readonly IntPtr NativeFieldInfoPtr_FaceDirectionRoutine;

		// Token: 0x040022E0 RID: 8928
		private static readonly IntPtr NativeFieldInfoPtr_ragdollForceComponents;

		// Token: 0x040022E1 RID: 8929
		private static readonly IntPtr NativeFieldInfoPtr__Disoriented_k__BackingField;

		// Token: 0x040022E2 RID: 8930
		private static readonly IntPtr NativeFieldInfoPtr_timeUntilNextStumble;

		// Token: 0x040022E3 RID: 8931
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceStumble;

		// Token: 0x040022E4 RID: 8932
		private static readonly IntPtr NativeFieldInfoPtr_stumbleDirection;

		// Token: 0x040022E5 RID: 8933
		private static readonly IntPtr NativeFieldInfoPtr_desiredVelocityHistory;

		// Token: 0x040022E6 RID: 8934
		private static readonly IntPtr NativeFieldInfoPtr_desiredVelocityHistoryLength;

		// Token: 0x040022E7 RID: 8935
		private static readonly IntPtr NativeFieldInfoPtr_velocityHistorySpacing;

		// Token: 0x040022E8 RID: 8936
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastVelocityHistoryRecord;

		// Token: 0x040022E9 RID: 8937
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040022EA RID: 8938
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040022EB RID: 8939
		private static readonly IntPtr NativeMethodInfoPtr_get_hasDestination_Public_get_Boolean_0;

		// Token: 0x040022EC RID: 8940
		private static readonly IntPtr NativeMethodInfoPtr_set_hasDestination_Protected_set_Void_Boolean_0;

		// Token: 0x040022ED RID: 8941
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0;

		// Token: 0x040022EE RID: 8942
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0;

		// Token: 0x040022EF RID: 8943
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPaused_Protected_set_Void_Boolean_0;

		// Token: 0x040022F0 RID: 8944
		private static readonly IntPtr NativeMethodInfoPtr_get_FootPosition_Public_get_Vector3_0;

		// Token: 0x040022F1 RID: 8945
		private static readonly IntPtr NativeMethodInfoPtr_get_GravityMultiplier_Public_get_Single_0;

		// Token: 0x040022F2 RID: 8946
		private static readonly IntPtr NativeMethodInfoPtr_set_GravityMultiplier_Protected_set_Void_Single_0;

		// Token: 0x040022F3 RID: 8947
		private static readonly IntPtr NativeMethodInfoPtr_get_Stance_Public_get_EStance_0;

		// Token: 0x040022F4 RID: 8948
		private static readonly IntPtr NativeMethodInfoPtr_set_Stance_Protected_set_Void_EStance_0;

		// Token: 0x040022F5 RID: 8949
		private static readonly IntPtr NativeMethodInfoPtr_get_timeSinceHitByCar_Public_get_Single_0;

		// Token: 0x040022F6 RID: 8950
		private static readonly IntPtr NativeMethodInfoPtr_set_timeSinceHitByCar_Protected_set_Void_Single_0;

		// Token: 0x040022F7 RID: 8951
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceDirectionInProgress_Public_get_Boolean_0;

		// Token: 0x040022F8 RID: 8952
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentDestination_Public_get_Vector3_0;

		// Token: 0x040022F9 RID: 8953
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentDestination_Protected_set_Void_Vector3_0;

		// Token: 0x040022FA RID: 8954
		private static readonly IntPtr NativeMethodInfoPtr_get_PathCache_Public_get_NPCPathCache_0;

		// Token: 0x040022FB RID: 8955
		private static readonly IntPtr NativeMethodInfoPtr_set_PathCache_Private_set_Void_NPCPathCache_0;

		// Token: 0x040022FC RID: 8956
		private static readonly IntPtr NativeMethodInfoPtr_get_Disoriented_Public_get_Boolean_0;

		// Token: 0x040022FD RID: 8957
		private static readonly IntPtr NativeMethodInfoPtr_set_Disoriented_Public_set_Void_Boolean_0;

		// Token: 0x040022FE RID: 8958
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040022FF RID: 8959
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04002300 RID: 8960
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x04002301 RID: 8961
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04002302 RID: 8962
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1;

		// Token: 0x04002303 RID: 8963
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x04002304 RID: 8964
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRagdoll_Private_Void_0;

		// Token: 0x04002305 RID: 8965
		private static readonly IntPtr NativeMethodInfoPtr_Stumble_Private_Void_0;

		// Token: 0x04002306 RID: 8966
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDestination_Private_Void_0;

		// Token: 0x04002307 RID: 8967
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x04002308 RID: 8968
		private static readonly IntPtr NativeMethodInfoPtr_UpdateStumble_Private_Void_0;

		// Token: 0x04002309 RID: 8969
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSpeed_Private_Void_0;

		// Token: 0x0400230A RID: 8970
		private static readonly IntPtr NativeMethodInfoPtr_RecordVelocity_Private_Void_0;

		// Token: 0x0400230B RID: 8971
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSlippery_Private_Void_0;

		// Token: 0x0400230C RID: 8972
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCache_Private_Void_0;

		// Token: 0x0400230D RID: 8973
		private static readonly IntPtr NativeMethodInfoPtr_CanRecoverFromRagdoll_Public_Boolean_0;

		// Token: 0x0400230E RID: 8974
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAvoidance_Private_Void_0;

		// Token: 0x0400230F RID: 8975
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0;

		// Token: 0x04002310 RID: 8976
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter_Public_Void_Collision_0;

		// Token: 0x04002311 RID: 8977
		private static readonly IntPtr NativeMethodInfoPtr_CheckHit_Private_Void_Collider_Collider_Boolean_Vector3_0;

		// Token: 0x04002312 RID: 8978
		private static readonly IntPtr NativeMethodInfoPtr_Warp_Public_Void_Transform_0;

		// Token: 0x04002313 RID: 8979
		private static readonly IntPtr NativeMethodInfoPtr_Warp_Public_Void_Vector3_0;

		// Token: 0x04002314 RID: 8980
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveWarp_Private_Void_Vector3_0;

		// Token: 0x04002315 RID: 8981
		private static readonly IntPtr NativeMethodInfoPtr_VisibilityChange_Public_Void_Boolean_0;

		// Token: 0x04002316 RID: 8982
		private static readonly IntPtr NativeMethodInfoPtr_CanMove_Public_Boolean_0;

		// Token: 0x04002317 RID: 8983
		private static readonly IntPtr NativeMethodInfoPtr_SetAgentType_Public_Void_EAgentType_0;

		// Token: 0x04002318 RID: 8984
		private static readonly IntPtr NativeMethodInfoPtr_SetSeat_Public_Void_AvatarSeat_0;

		// Token: 0x04002319 RID: 8985
		private static readonly IntPtr NativeMethodInfoPtr_SetStance_Public_Void_EStance_0;

		// Token: 0x0400231A RID: 8986
		private static readonly IntPtr NativeMethodInfoPtr_SetGravityMultiplier_Public_Void_Single_0;

		// Token: 0x0400231B RID: 8987
		private static readonly IntPtr NativeMethodInfoPtr_SetRagdollDraggable_Public_Void_Boolean_0;

		// Token: 0x0400231C RID: 8988
		private static readonly IntPtr NativeMethodInfoPtr_ActivateRagdoll_Server_Public_Void_0;

		// Token: 0x0400231D RID: 8989
		private static readonly IntPtr NativeMethodInfoPtr_ActivateRagdoll_Public_Void_Vector3_Vector3_Single_0;

		// Token: 0x0400231E RID: 8990
		private static readonly IntPtr NativeMethodInfoPtr_ApplyRagdollForce_Public_Void_Vector3_Vector3_Single_0;

		// Token: 0x0400231F RID: 8991
		private static readonly IntPtr NativeMethodInfoPtr_DeactivateRagdoll_Public_Void_0;

		// Token: 0x04002320 RID: 8992
		private static readonly IntPtr NativeMethodInfoPtr_SmartSampleNavMesh_Private_Boolean_Vector3_byref_NavMeshHit_Single_Single_Int32_0;

		// Token: 0x04002321 RID: 8993
		private static readonly IntPtr NativeMethodInfoPtr_SetDestination_Public_Void_Vector3_0;

		// Token: 0x04002322 RID: 8994
		private static readonly IntPtr NativeMethodInfoPtr_SetDestination_Public_Void_ITransitEntity_0;

		// Token: 0x04002323 RID: 8995
		private static readonly IntPtr NativeMethodInfoPtr_SetDestination_Public_Void_Vector3_Action_1_WalkResult_Single_Single_0;

		// Token: 0x04002324 RID: 8996
		private static readonly IntPtr NativeMethodInfoPtr_SetDestination_Private_Void_Vector3_Action_1_WalkResult_Boolean_Single_Single_0;

		// Token: 0x04002325 RID: 8997
		private static readonly IntPtr NativeMethodInfoPtr_IsNPCPositionValid_Private_Boolean_Vector3_0;

		// Token: 0x04002326 RID: 8998
		private static readonly IntPtr NativeMethodInfoPtr_EndSetDestination_Private_Void_WalkResult_0;

		// Token: 0x04002327 RID: 8999
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x04002328 RID: 9000
		private static readonly IntPtr NativeMethodInfoPtr_WarpToNavMesh_Public_Void_0;

		// Token: 0x04002329 RID: 9001
		private static readonly IntPtr NativeMethodInfoPtr_FacePoint_Public_Void_Vector3_Single_0;

		// Token: 0x0400232A RID: 9002
		private static readonly IntPtr NativeMethodInfoPtr_FaceDirection_Public_Void_Vector3_Single_0;

		// Token: 0x0400232B RID: 9003
		private static readonly IntPtr NativeMethodInfoPtr_FaceDirection_Process_Protected_IEnumerator_Vector3_Single_0;

		// Token: 0x0400232C RID: 9004
		private static readonly IntPtr NativeMethodInfoPtr_PauseMovement_Public_Void_0;

		// Token: 0x0400232D RID: 9005
		private static readonly IntPtr NativeMethodInfoPtr_ResumeMovement_Public_Void_0;

		// Token: 0x0400232E RID: 9006
		private static readonly IntPtr NativeMethodInfoPtr_IsAsCloseAsPossible_Public_Boolean_Vector3_Single_0;

		// Token: 0x0400232F RID: 9007
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestReachablePoint_Public_Boolean_Vector3_byref_Vector3_0;

		// Token: 0x04002330 RID: 9008
		private static readonly IntPtr NativeMethodInfoPtr_CanGetTo_Public_Boolean_Vector3_Single_0;

		// Token: 0x04002331 RID: 9009
		private static readonly IntPtr NativeMethodInfoPtr_CanGetTo_Public_Boolean_ITransitEntity_Single_0;

		// Token: 0x04002332 RID: 9010
		private static readonly IntPtr NativeMethodInfoPtr_CanGetTo_Public_Boolean_Vector3_Single_byref_NavMeshPath_0;

		// Token: 0x04002333 RID: 9011
		private static readonly IntPtr NativeMethodInfoPtr_GetPathTo_Private_NavMeshPath_Vector3_Single_0;

		// Token: 0x04002334 RID: 9012
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002335 RID: 9013
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002336 RID: 9014
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002337 RID: 9015
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002338 RID: 9016
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveWarp_4276783012_Private_Void_Vector3_0;

		// Token: 0x04002339 RID: 9017
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveWarp_4276783012_Private_Void_Vector3_0;

		// Token: 0x0400233A RID: 9018
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveWarp_4276783012_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400233B RID: 9019
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ActivateRagdoll_Server_2166136261_Private_Void_0;

		// Token: 0x0400233C RID: 9020
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ActivateRagdoll_Server_2166136261_Public_Void_0;

		// Token: 0x0400233D RID: 9021
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ActivateRagdoll_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400233E RID: 9022
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ActivateRagdoll_2690242654_Private_Void_Vector3_Vector3_Single_0;

		// Token: 0x0400233F RID: 9023
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ActivateRagdoll_2690242654_Public_Void_Vector3_Vector3_Single_0;

		// Token: 0x04002340 RID: 9024
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ActivateRagdoll_2690242654_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002341 RID: 9025
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ApplyRagdollForce_2690242654_Private_Void_Vector3_Vector3_Single_0;

		// Token: 0x04002342 RID: 9026
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ApplyRagdollForce_2690242654_Public_Void_Vector3_Vector3_Single_0;

		// Token: 0x04002343 RID: 9027
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ApplyRagdollForce_2690242654_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002344 RID: 9028
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_DeactivateRagdoll_2166136261_Private_Void_0;

		// Token: 0x04002345 RID: 9029
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___DeactivateRagdoll_2166136261_Public_Void_0;

		// Token: 0x04002346 RID: 9030
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_DeactivateRagdoll_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002347 RID: 9031
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x02000920 RID: 2336
		[OriginalName("Assembly-CSharp.dll", "", "EAgentType")]
		public enum EAgentType
		{
			// Token: 0x0400864A RID: 34378
			Humanoid,
			// Token: 0x0400864B RID: 34379
			BigHumanoid,
			// Token: 0x0400864C RID: 34380
			IgnoreCosts
		}

		// Token: 0x02000921 RID: 2337
		[OriginalName("Assembly-CSharp.dll", "", "EStance")]
		public enum EStance
		{
			// Token: 0x0400864E RID: 34382
			None,
			// Token: 0x0400864F RID: 34383
			Stanced
		}

		// Token: 0x02000922 RID: 2338
		[OriginalName("Assembly-CSharp.dll", "", "WalkResult")]
		public enum WalkResult
		{
			// Token: 0x04008651 RID: 34385
			Failed,
			// Token: 0x04008652 RID: 34386
			Interrupted,
			// Token: 0x04008653 RID: 34387
			Stopped,
			// Token: 0x04008654 RID: 34388
			Partial,
			// Token: 0x04008655 RID: 34389
			Success
		}

		// Token: 0x02000923 RID: 2339
		[ObfuscatedName("ScheduleOne.NPCs.NPCMovement+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C665 RID: 50789 RVA: 0x0030311C File Offset: 0x0030131C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NPCMovement.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCMovement.__c>.NativeClassPtr);
				NPCMovement.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement.__c>.NativeClassPtr, "<>9");
				NPCMovement.__c.NativeFieldInfoPtr___9__126_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement.__c>.NativeClassPtr, "<>9__126_1");
				NPCMovement.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement.__c>.NativeClassPtr, 100669402);
				NPCMovement.__c.NativeMethodInfoPtr__ApplyRagdollForce_b__126_1_Internal_Single___f__AnonymousType0_2_Rigidbody_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement.__c>.NativeClassPtr, 100669403);
			}

			// Token: 0x0600C666 RID: 50790 RVA: 0x00303198 File Offset: 0x00301398
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCMovement.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C667 RID: 50791 RVA: 0x003031D4 File Offset: 0x003013D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136675, XrefRangeEnd = 136676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ApplyRagdollForce_b__126_1(__f__AnonymousType0<Rigidbody, float> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.__c.NativeMethodInfoPtr__ApplyRagdollForce_b__126_1_Internal_Single___f__AnonymousType0_2_Rigidbody_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C668 RID: 50792 RVA: 0x00060912 File Offset: 0x0005EB12
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DD0 RID: 15824
			// (get) Token: 0x0600C669 RID: 50793 RVA: 0x00303224 File Offset: 0x00301424
			// (set) Token: 0x0600C66A RID: 50794 RVA: 0x0006091B File Offset: 0x0005EB1B
			public unsafe static NPCMovement.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCMovement.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCMovement.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCMovement.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DD1 RID: 15825
			// (get) Token: 0x0600C66B RID: 50795 RVA: 0x0030324C File Offset: 0x0030144C
			// (set) Token: 0x0600C66C RID: 50796 RVA: 0x0006092D File Offset: 0x0005EB2D
			public unsafe static Func<__f__AnonymousType0<Rigidbody, float>, float> __9__126_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCMovement.__c.NativeFieldInfoPtr___9__126_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<__f__AnonymousType0<Rigidbody, float>, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCMovement.__c.NativeFieldInfoPtr___9__126_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008656 RID: 34390
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008657 RID: 34391
			private static readonly IntPtr NativeFieldInfoPtr___9__126_1;

			// Token: 0x04008658 RID: 34392
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008659 RID: 34393
			private static readonly IntPtr NativeMethodInfoPtr__ApplyRagdollForce_b__126_1_Internal_Single___f__AnonymousType0_2_Rigidbody_Single_0;
		}

		// Token: 0x02000924 RID: 2340
		[ObfuscatedName("ScheduleOne.NPCs.NPCMovement+<>c__DisplayClass126_0")]
		public sealed class __c__DisplayClass126_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C66D RID: 50797 RVA: 0x00303274 File Offset: 0x00301474
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass126_0()
			{
				Il2CppClassPointerStore<NPCMovement.__c__DisplayClass126_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<>c__DisplayClass126_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass126_0>.NativeClassPtr);
				NPCMovement.__c__DisplayClass126_0.NativeFieldInfoPtr_forcePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass126_0>.NativeClassPtr, "forcePoint");
				NPCMovement.__c__DisplayClass126_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass126_0>.NativeClassPtr, 100669404);
				NPCMovement.__c__DisplayClass126_0.NativeMethodInfoPtr__ApplyRagdollForce_b__0_Internal___f__AnonymousType0_2_Rigidbody_Single_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass126_0>.NativeClassPtr, 100669405);
			}

			// Token: 0x0600C66E RID: 50798 RVA: 0x003032DC File Offset: 0x003014DC
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass126_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass126_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.__c__DisplayClass126_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C66F RID: 50799 RVA: 0x00303318 File Offset: 0x00301518
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136676, XrefRangeEnd = 136689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __f__AnonymousType0<Rigidbody, float> _ApplyRagdollForce_b__0(Rigidbody x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.__c__DisplayClass126_0.NativeMethodInfoPtr__ApplyRagdollForce_b__0_Internal___f__AnonymousType0_2_Rigidbody_Single_Rigidbody_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<__f__AnonymousType0<Rigidbody, float>>(intPtr3) : null;
			}

			// Token: 0x0600C670 RID: 50800 RVA: 0x0006093F File Offset: 0x0005EB3F
			public __c__DisplayClass126_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DD2 RID: 15826
			// (get) Token: 0x0600C671 RID: 50801 RVA: 0x00303368 File Offset: 0x00301568
			// (set) Token: 0x0600C672 RID: 50802 RVA: 0x00060948 File Offset: 0x0005EB48
			public unsafe Vector3 forcePoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass126_0.NativeFieldInfoPtr_forcePoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass126_0.NativeFieldInfoPtr_forcePoint)) = value;
				}
			}

			// Token: 0x0400865A RID: 34394
			private static readonly IntPtr NativeFieldInfoPtr_forcePoint;

			// Token: 0x0400865B RID: 34395
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400865C RID: 34396
			private static readonly IntPtr NativeMethodInfoPtr__ApplyRagdollForce_b__0_Internal___f__AnonymousType0_2_Rigidbody_Single_Rigidbody_0;
		}

		// Token: 0x02000925 RID: 2341
		[ObfuscatedName("ScheduleOne.NPCs.NPCMovement+<FaceDirection_Process>d__139")]
		public sealed class _FaceDirection_Process_d__139 : Il2CppSystem.Object
		{
			// Token: 0x0600C673 RID: 50803 RVA: 0x00303390 File Offset: 0x00301590
			// Note: this type is marked as 'beforefieldinit'.
			static _FaceDirection_Process_d__139()
			{
				Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<FaceDirection_Process>d__139");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr);
				NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, "<>1__state");
				NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, "<>2__current");
				NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, "lerpTime");
				NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, "<>4__this");
				NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr_forward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, "forward");
				NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr__startRot_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, "<startRot>5__2");
				NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, "<i>5__3");
				NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, 100669406);
				NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, 100669407);
				NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, 100669408);
				NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, 100669409);
				NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, 100669410);
				NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, 100669411);
			}

			// Token: 0x0600C674 RID: 50804 RVA: 0x003034C0 File Offset: 0x003016C0
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FaceDirection_Process_d__139(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C675 RID: 50805 RVA: 0x00303508 File Offset: 0x00301708
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C676 RID: 50806 RVA: 0x0030353C File Offset: 0x0030173C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136689, XrefRangeEnd = 136711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003DDA RID: 15834
			// (get) Token: 0x0600C677 RID: 50807 RVA: 0x00303578 File Offset: 0x00301778
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C678 RID: 50808 RVA: 0x003035B8 File Offset: 0x003017B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136711, XrefRangeEnd = 136716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003DDB RID: 15835
			// (get) Token: 0x0600C679 RID: 50809 RVA: 0x003035EC File Offset: 0x003017EC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C67A RID: 50810 RVA: 0x00060963 File Offset: 0x0005EB63
			public _FaceDirection_Process_d__139(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DD3 RID: 15827
			// (get) Token: 0x0600C67B RID: 50811 RVA: 0x0030362C File Offset: 0x0030182C
			// (set) Token: 0x0600C67C RID: 50812 RVA: 0x0006096C File Offset: 0x0005EB6C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003DD4 RID: 15828
			// (get) Token: 0x0600C67D RID: 50813 RVA: 0x00303654 File Offset: 0x00301854
			// (set) Token: 0x0600C67E RID: 50814 RVA: 0x00060987 File Offset: 0x0005EB87
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DD5 RID: 15829
			// (get) Token: 0x0600C67F RID: 50815 RVA: 0x00303684 File Offset: 0x00301884
			// (set) Token: 0x0600C680 RID: 50816 RVA: 0x000609A6 File Offset: 0x0005EBA6
			public unsafe float lerpTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr_lerpTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr_lerpTime)) = value;
				}
			}

			// Token: 0x17003DD6 RID: 15830
			// (get) Token: 0x0600C681 RID: 50817 RVA: 0x003036AC File Offset: 0x003018AC
			// (set) Token: 0x0600C682 RID: 50818 RVA: 0x000609C1 File Offset: 0x0005EBC1
			public unsafe NPCMovement __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCMovement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DD7 RID: 15831
			// (get) Token: 0x0600C683 RID: 50819 RVA: 0x003036DC File Offset: 0x003018DC
			// (set) Token: 0x0600C684 RID: 50820 RVA: 0x000609E0 File Offset: 0x0005EBE0
			public unsafe Vector3 forward
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr_forward);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr_forward)) = value;
				}
			}

			// Token: 0x17003DD8 RID: 15832
			// (get) Token: 0x0600C685 RID: 50821 RVA: 0x00303704 File Offset: 0x00301904
			// (set) Token: 0x0600C686 RID: 50822 RVA: 0x000609FB File Offset: 0x0005EBFB
			public unsafe Quaternion _startRot_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr__startRot_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr__startRot_5__2)) = value;
				}
			}

			// Token: 0x17003DD9 RID: 15833
			// (get) Token: 0x0600C687 RID: 50823 RVA: 0x0030372C File Offset: 0x0030192C
			// (set) Token: 0x0600C688 RID: 50824 RVA: 0x00060A16 File Offset: 0x0005EC16
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x0400865D RID: 34397
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400865E RID: 34398
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400865F RID: 34399
			private static readonly IntPtr NativeFieldInfoPtr_lerpTime;

			// Token: 0x04008660 RID: 34400
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008661 RID: 34401
			private static readonly IntPtr NativeFieldInfoPtr_forward;

			// Token: 0x04008662 RID: 34402
			private static readonly IntPtr NativeFieldInfoPtr__startRot_5__2;

			// Token: 0x04008663 RID: 34403
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x04008664 RID: 34404
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008665 RID: 34405
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008666 RID: 34406
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008667 RID: 34407
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008668 RID: 34408
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008669 RID: 34409
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
