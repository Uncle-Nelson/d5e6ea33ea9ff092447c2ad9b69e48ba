using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x020003E9 RID: 1001
	public class PlayerMovement : PlayerSingleton<PlayerMovement>
	{
		// Token: 0x06005167 RID: 20839 RVA: 0x001832BC File Offset: 0x001814BC
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerMovement()
		{
			Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "PlayerMovement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr);
			PlayerMovement.NativeFieldInfoPtr_DEV_SPRINT_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "DEV_SPRINT_MULTIPLIER");
			PlayerMovement.NativeFieldInfoPtr_GROUNDED_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "GROUNDED_THRESHOLD");
			PlayerMovement.NativeFieldInfoPtr_SLOPE_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "SLOPE_THRESHOLD");
			PlayerMovement.NativeFieldInfoPtr_WalkSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "WalkSpeed");
			PlayerMovement.NativeFieldInfoPtr_SprintMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "SprintMultiplier");
			PlayerMovement.NativeFieldInfoPtr_StaticMoveSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "StaticMoveSpeedMultiplier");
			PlayerMovement.NativeFieldInfoPtr_StaminaRestoreDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "StaminaRestoreDelay");
			PlayerMovement.NativeFieldInfoPtr_JumpMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "JumpMultiplier");
			PlayerMovement.NativeFieldInfoPtr_ControllerRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "ControllerRadius");
			PlayerMovement.NativeFieldInfoPtr_StandingControllerHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "StandingControllerHeight");
			PlayerMovement.NativeFieldInfoPtr_CrouchHeightMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "CrouchHeightMultiplier");
			PlayerMovement.NativeFieldInfoPtr_CrouchTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "CrouchTime");
			PlayerMovement.NativeFieldInfoPtr__GravityMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<GravityMultiplier>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr_StaminaDrainRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "StaminaDrainRate");
			PlayerMovement.NativeFieldInfoPtr_StaminaRestoreRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "StaminaRestoreRate");
			PlayerMovement.NativeFieldInfoPtr_StaminaReserveMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "StaminaReserveMax");
			PlayerMovement.NativeFieldInfoPtr_SprintChangeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "SprintChangeRate");
			PlayerMovement.NativeFieldInfoPtr_Player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "Player");
			PlayerMovement.NativeFieldInfoPtr_Controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "Controller");
			PlayerMovement.NativeFieldInfoPtr_sensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "sensitivity");
			PlayerMovement.NativeFieldInfoPtr_dead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "dead");
			PlayerMovement.NativeFieldInfoPtr_canMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "canMove");
			PlayerMovement.NativeFieldInfoPtr_canJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "canJump");
			PlayerMovement.NativeFieldInfoPtr_SprintingRequiresStamina = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "SprintingRequiresStamina");
			PlayerMovement.NativeFieldInfoPtr_MoveSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "MoveSpeedMultiplier");
			PlayerMovement.NativeFieldInfoPtr_SlipperyMovementMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "SlipperyMovementMultiplier");
			PlayerMovement.NativeFieldInfoPtr_jumpForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "jumpForce");
			PlayerMovement.NativeFieldInfoPtr_gravityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "gravityMultiplier");
			PlayerMovement.NativeFieldInfoPtr_groundDetectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "groundDetectionMask");
			PlayerMovement.NativeFieldInfoPtr_slopeForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "slopeForce");
			PlayerMovement.NativeFieldInfoPtr_slopeForceRayLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "slopeForceRayLength");
			PlayerMovement.NativeFieldInfoPtr_crouchSpeedMultipler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "crouchSpeedMultipler");
			PlayerMovement.NativeFieldInfoPtr_Crouched_VigIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "Crouched_VigIntensity");
			PlayerMovement.NativeFieldInfoPtr_Crouched_VigSmoothness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "Crouched_VigSmoothness");
			PlayerMovement.NativeFieldInfoPtr_visibilityPointsToScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "visibilityPointsToScale");
			PlayerMovement.NativeFieldInfoPtr_originalVisibilityPointOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "originalVisibilityPointOffsets");
			PlayerMovement.NativeFieldInfoPtr__playerHeight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<playerHeight>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr_movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "movement");
			PlayerMovement.NativeFieldInfoPtr_movementY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "movementY");
			PlayerMovement.NativeFieldInfoPtr__currentVehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<currentVehicle>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr_recentlyDrivenVehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "recentlyDrivenVehicles");
			PlayerMovement.NativeFieldInfoPtr_isJumping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "isJumping");
			PlayerMovement.NativeFieldInfoPtr__airTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<airTime>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr__isCrouched_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<isCrouched>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr__standingScale_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<standingScale>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr__isRagdolled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<isRagdolled>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr__isSprinting_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<isSprinting>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr__CurrentSprintMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<CurrentSprintMultiplier>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr_CurrentStaminaReserve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "CurrentStaminaReserve");
			PlayerMovement.NativeFieldInfoPtr__IsGrounded_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<IsGrounded>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr_onStaminaReserveChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "onStaminaReserveChanged");
			PlayerMovement.NativeFieldInfoPtr_onJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "onJump");
			PlayerMovement.NativeFieldInfoPtr_onLand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "onLand");
			PlayerMovement.NativeFieldInfoPtr_onCrouch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "onCrouch");
			PlayerMovement.NativeFieldInfoPtr_onUncrouch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "onUncrouch");
			PlayerMovement.NativeFieldInfoPtr_horizontalAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "horizontalAxis");
			PlayerMovement.NativeFieldInfoPtr_verticalAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "verticalAxis");
			PlayerMovement.NativeFieldInfoPtr_timeGrounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "timeGrounded");
			PlayerMovement.NativeFieldInfoPtr_movementEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "movementEvents");
			PlayerMovement.NativeFieldInfoPtr_timeSinceStaminaDrain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "timeSinceStaminaDrain");
			PlayerMovement.NativeFieldInfoPtr_sprintActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "sprintActive");
			PlayerMovement.NativeFieldInfoPtr_sprintReleased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "sprintReleased");
			PlayerMovement.NativeFieldInfoPtr_residualVelocityDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "residualVelocityDirection");
			PlayerMovement.NativeFieldInfoPtr_residualVelocityForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "residualVelocityForce");
			PlayerMovement.NativeFieldInfoPtr_residualVelocityDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "residualVelocityDuration");
			PlayerMovement.NativeFieldInfoPtr_residualVelocityTimeRemaining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "residualVelocityTimeRemaining");
			PlayerMovement.NativeFieldInfoPtr_teleport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "teleport");
			PlayerMovement.NativeFieldInfoPtr_teleportPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "teleportPosition");
			PlayerMovement.NativeFieldInfoPtr_sprintBlockers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "sprintBlockers");
			PlayerMovement.NativeFieldInfoPtr_lastFrameMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "lastFrameMovement");
			PlayerMovement.NativeFieldInfoPtr_playerRotCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "playerRotCoroutine");
			PlayerMovement.NativeMethodInfoPtr_get_GravityMultiplier_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673517);
			PlayerMovement.NativeMethodInfoPtr_set_GravityMultiplier_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673518);
			PlayerMovement.NativeMethodInfoPtr_get_playerHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673519);
			PlayerMovement.NativeMethodInfoPtr_set_playerHeight_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673520);
			PlayerMovement.NativeMethodInfoPtr_get_Movement_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673521);
			PlayerMovement.NativeMethodInfoPtr_get_currentVehicle_Public_get_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673522);
			PlayerMovement.NativeMethodInfoPtr_set_currentVehicle_Protected_set_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673523);
			PlayerMovement.NativeMethodInfoPtr_get_airTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673524);
			PlayerMovement.NativeMethodInfoPtr_set_airTime_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673525);
			PlayerMovement.NativeMethodInfoPtr_get_isCrouched_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673526);
			PlayerMovement.NativeMethodInfoPtr_set_isCrouched_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673527);
			PlayerMovement.NativeMethodInfoPtr_get_standingScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673528);
			PlayerMovement.NativeMethodInfoPtr_set_standingScale_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673529);
			PlayerMovement.NativeMethodInfoPtr_get_isRagdolled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673530);
			PlayerMovement.NativeMethodInfoPtr_set_isRagdolled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673531);
			PlayerMovement.NativeMethodInfoPtr_get_isSprinting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673532);
			PlayerMovement.NativeMethodInfoPtr_set_isSprinting_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673533);
			PlayerMovement.NativeMethodInfoPtr_get_CurrentSprintMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673534);
			PlayerMovement.NativeMethodInfoPtr_set_CurrentSprintMultiplier_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673535);
			PlayerMovement.NativeMethodInfoPtr_get_IsGrounded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673536);
			PlayerMovement.NativeMethodInfoPtr_set_IsGrounded_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673537);
			PlayerMovement.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673538);
			PlayerMovement.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673539);
			PlayerMovement.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673540);
			PlayerMovement.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673541);
			PlayerMovement.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673542);
			PlayerMovement.NativeMethodInfoPtr_Move_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673543);
			PlayerMovement.NativeMethodInfoPtr_ClampMovement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673544);
			PlayerMovement.NativeMethodInfoPtr_GetSurfaceAngle_Protected_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673545);
			PlayerMovement.NativeMethodInfoPtr_isGrounded_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673546);
			PlayerMovement.NativeMethodInfoPtr_UpdateHorizontalAxis_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673547);
			PlayerMovement.NativeMethodInfoPtr_UpdateVerticalAxis_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673548);
			PlayerMovement.NativeMethodInfoPtr_Jump_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673549);
			PlayerMovement.NativeMethodInfoPtr_TryToggleCrouch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673550);
			PlayerMovement.NativeMethodInfoPtr_CanStand_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673551);
			PlayerMovement.NativeMethodInfoPtr_SetCrouched_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673552);
			PlayerMovement.NativeMethodInfoPtr_UpdateCrouchVignetteEffect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673553);
			PlayerMovement.NativeMethodInfoPtr_UpdatePlayerHeight_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673554);
			PlayerMovement.NativeMethodInfoPtr_LerpPlayerRotation_Public_Void_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673555);
			PlayerMovement.NativeMethodInfoPtr_LerpPlayerRotation_Process_Private_IEnumerator_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673556);
			PlayerMovement.NativeMethodInfoPtr_EnterVehicle_Private_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673557);
			PlayerMovement.NativeMethodInfoPtr_ExitVehicle_Private_Void_LandVehicle_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673558);
			PlayerMovement.NativeMethodInfoPtr_Teleport_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673559);
			PlayerMovement.NativeMethodInfoPtr_SetResidualVelocity_Public_Void_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673560);
			PlayerMovement.NativeMethodInfoPtr_WarpToNavMesh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673561);
			PlayerMovement.NativeMethodInfoPtr_RegisterMovementEvent_Public_Void_Int32_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673562);
			PlayerMovement.NativeMethodInfoPtr_DeregisterMovementEvent_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673563);
			PlayerMovement.NativeMethodInfoPtr_UpdateMovementEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673564);
			PlayerMovement.NativeMethodInfoPtr_ChangeStamina_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673565);
			PlayerMovement.NativeMethodInfoPtr_SetStamina_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673566);
			PlayerMovement.NativeMethodInfoPtr_AddSprintBlocker_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673567);
			PlayerMovement.NativeMethodInfoPtr_RemoveSprintBlocker_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673568);
			PlayerMovement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673569);
			PlayerMovement.NativeMethodInfoPtr__Start_b__104_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673571);
		}

		// Token: 0x170018B1 RID: 6321
		// (get) Token: 0x06005168 RID: 20840 RVA: 0x00183CB0 File Offset: 0x00181EB0
		// (set) Token: 0x06005169 RID: 20841 RVA: 0x00183CE0 File Offset: 0x00181EE0
		public unsafe static float GravityMultiplier
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176920, XrefRangeEnd = 176924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_GravityMultiplier_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176924, XrefRangeEnd = 176928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_GravityMultiplier_Public_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170018B2 RID: 6322
		// (get) Token: 0x0600516A RID: 20842 RVA: 0x00183D14 File Offset: 0x00181F14
		// (set) Token: 0x0600516B RID: 20843 RVA: 0x00183D50 File Offset: 0x00181F50
		public unsafe float playerHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_playerHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_playerHeight_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170018B3 RID: 6323
		// (get) Token: 0x0600516C RID: 20844 RVA: 0x00183D90 File Offset: 0x00181F90
		public unsafe Vector3 Movement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_Movement_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170018B4 RID: 6324
		// (get) Token: 0x0600516D RID: 20845 RVA: 0x00183DCC File Offset: 0x00181FCC
		// (set) Token: 0x0600516E RID: 20846 RVA: 0x00183E0C File Offset: 0x0018200C
		public unsafe LandVehicle currentVehicle
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 31093, RefRangeEnd = 31100, XrefRangeStart = 31093, XrefRangeEnd = 31100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_currentVehicle_Public_get_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_currentVehicle_Protected_set_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170018B5 RID: 6325
		// (get) Token: 0x0600516F RID: 20847 RVA: 0x00183E50 File Offset: 0x00182050
		// (set) Token: 0x06005170 RID: 20848 RVA: 0x00183E8C File Offset: 0x0018208C
		public unsafe float airTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_airTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_airTime_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170018B6 RID: 6326
		// (get) Token: 0x06005171 RID: 20849 RVA: 0x00183ECC File Offset: 0x001820CC
		// (set) Token: 0x06005172 RID: 20850 RVA: 0x00183F08 File Offset: 0x00182108
		public unsafe bool isCrouched
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_isCrouched_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_isCrouched_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170018B7 RID: 6327
		// (get) Token: 0x06005173 RID: 20851 RVA: 0x00183F48 File Offset: 0x00182148
		// (set) Token: 0x06005174 RID: 20852 RVA: 0x00183F84 File Offset: 0x00182184
		public unsafe float standingScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_standingScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_standingScale_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170018B8 RID: 6328
		// (get) Token: 0x06005175 RID: 20853 RVA: 0x00183FC4 File Offset: 0x001821C4
		// (set) Token: 0x06005176 RID: 20854 RVA: 0x00184000 File Offset: 0x00182200
		public unsafe bool isRagdolled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_isRagdolled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_isRagdolled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170018B9 RID: 6329
		// (get) Token: 0x06005177 RID: 20855 RVA: 0x00184040 File Offset: 0x00182240
		// (set) Token: 0x06005178 RID: 20856 RVA: 0x0018407C File Offset: 0x0018227C
		public unsafe bool isSprinting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_isSprinting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_isSprinting_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170018BA RID: 6330
		// (get) Token: 0x06005179 RID: 20857 RVA: 0x001840BC File Offset: 0x001822BC
		// (set) Token: 0x0600517A RID: 20858 RVA: 0x001840F8 File Offset: 0x001822F8
		public unsafe float CurrentSprintMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_CurrentSprintMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_CurrentSprintMultiplier_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170018BB RID: 6331
		// (get) Token: 0x0600517B RID: 20859 RVA: 0x00184138 File Offset: 0x00182338
		// (set) Token: 0x0600517C RID: 20860 RVA: 0x00184174 File Offset: 0x00182374
		public unsafe bool IsGrounded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_IsGrounded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_IsGrounded_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600517D RID: 20861 RVA: 0x001841B4 File Offset: 0x001823B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176928, XrefRangeEnd = 176944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerMovement.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600517E RID: 20862 RVA: 0x001841F0 File Offset: 0x001823F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176944, XrefRangeEnd = 176987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerMovement.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600517F RID: 20863 RVA: 0x0018422C File Offset: 0x0018242C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176987, XrefRangeEnd = 177010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerMovement.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005180 RID: 20864 RVA: 0x00184268 File Offset: 0x00182468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177010, XrefRangeEnd = 177015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005181 RID: 20865 RVA: 0x0018429C File Offset: 0x0018249C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177015, XrefRangeEnd = 177019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005182 RID: 20866 RVA: 0x001842D0 File Offset: 0x001824D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177019, XrefRangeEnd = 177166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Move()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerMovement.NativeMethodInfoPtr_Move_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005183 RID: 20867 RVA: 0x0018430C File Offset: 0x0018250C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177172, RefRangeEnd = 177173, XrefRangeStart = 177166, XrefRangeEnd = 177172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClampMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_ClampMovement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005184 RID: 20868 RVA: 0x00184340 File Offset: 0x00182540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177173, XrefRangeEnd = 177182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSurfaceAngle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_GetSurfaceAngle_Protected_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005185 RID: 20869 RVA: 0x0018437C File Offset: 0x0018257C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177182, XrefRangeEnd = 177188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool isGrounded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_isGrounded_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005186 RID: 20870 RVA: 0x001843B8 File Offset: 0x001825B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177204, RefRangeEnd = 177205, XrefRangeStart = 177188, XrefRangeEnd = 177204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateHorizontalAxis()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_UpdateHorizontalAxis_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005187 RID: 20871 RVA: 0x001843EC File Offset: 0x001825EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177221, RefRangeEnd = 177222, XrefRangeStart = 177205, XrefRangeEnd = 177221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVerticalAxis()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_UpdateVerticalAxis_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005188 RID: 20872 RVA: 0x00184420 File Offset: 0x00182620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177222, XrefRangeEnd = 177227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Jump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_Jump_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005189 RID: 20873 RVA: 0x00184460 File Offset: 0x00182660
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 177230, RefRangeEnd = 177232, XrefRangeStart = 177227, XrefRangeEnd = 177230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryToggleCrouch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_TryToggleCrouch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600518A RID: 20874 RVA: 0x00184494 File Offset: 0x00182694
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177249, RefRangeEnd = 177250, XrefRangeStart = 177232, XrefRangeEnd = 177249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanStand()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_CanStand_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600518B RID: 20875 RVA: 0x001844D0 File Offset: 0x001826D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 177261, RefRangeEnd = 177264, XrefRangeStart = 177250, XrefRangeEnd = 177261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCrouched(bool c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_SetCrouched_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600518C RID: 20876 RVA: 0x00184510 File Offset: 0x00182710
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177280, RefRangeEnd = 177281, XrefRangeStart = 177264, XrefRangeEnd = 177280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCrouchVignetteEffect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_UpdateCrouchVignetteEffect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600518D RID: 20877 RVA: 0x00184544 File Offset: 0x00182744
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177306, RefRangeEnd = 177307, XrefRangeStart = 177281, XrefRangeEnd = 177306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePlayerHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_UpdatePlayerHeight_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600518E RID: 20878 RVA: 0x00184578 File Offset: 0x00182778
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177315, RefRangeEnd = 177316, XrefRangeStart = 177307, XrefRangeEnd = 177315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LerpPlayerRotation(Quaternion rotation, float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rotation;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_LerpPlayerRotation_Public_Void_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600518F RID: 20879 RVA: 0x001845C4 File Offset: 0x001827C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177316, XrefRangeEnd = 177321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LerpPlayerRotation_Process(Quaternion endRotation, float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endRotation;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_LerpPlayerRotation_Process_Private_IEnumerator_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005190 RID: 20880 RVA: 0x00184620 File Offset: 0x00182820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177321, XrefRangeEnd = 177333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnterVehicle(LandVehicle vehicle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_EnterVehicle_Private_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005191 RID: 20881 RVA: 0x00184664 File Offset: 0x00182864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177333, XrefRangeEnd = 177336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitVehicle(LandVehicle veh, Transform exitPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(veh);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exitPoint);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_ExitVehicle_Private_Void_LandVehicle_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005192 RID: 20882 RVA: 0x001846B8 File Offset: 0x001828B8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 177353, RefRangeEnd = 177363, XrefRangeStart = 177336, XrefRangeEnd = 177353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Teleport(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_Teleport_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005193 RID: 20883 RVA: 0x001846F8 File Offset: 0x001828F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 177364, RefRangeEnd = 177367, XrefRangeStart = 177363, XrefRangeEnd = 177364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetResidualVelocity(Vector3 dir, float force, float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dir;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_SetResidualVelocity_Public_Void_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005194 RID: 20884 RVA: 0x00184754 File Offset: 0x00182954
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177390, RefRangeEnd = 177391, XrefRangeStart = 177367, XrefRangeEnd = 177390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WarpToNavMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_WarpToNavMesh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005195 RID: 20885 RVA: 0x00184788 File Offset: 0x00182988
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 177418, RefRangeEnd = 177420, XrefRangeStart = 177391, XrefRangeEnd = 177418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterMovementEvent(int threshold, Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref threshold;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_RegisterMovementEvent_Public_Void_Int32_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005196 RID: 20886 RVA: 0x001847D8 File Offset: 0x001829D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 177448, RefRangeEnd = 177450, XrefRangeStart = 177420, XrefRangeEnd = 177448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeregisterMovementEvent(Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_DeregisterMovementEvent_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005197 RID: 20887 RVA: 0x0018481C File Offset: 0x00182A1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177481, RefRangeEnd = 177482, XrefRangeStart = 177450, XrefRangeEnd = 177481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMovementEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_UpdateMovementEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005198 RID: 20888 RVA: 0x00184850 File Offset: 0x00182A50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 177483, RefRangeEnd = 177486, XrefRangeStart = 177482, XrefRangeEnd = 177483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeStamina(float change, bool notify = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_ChangeStamina_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005199 RID: 20889 RVA: 0x0018489C File Offset: 0x00182A9C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 177491, RefRangeEnd = 177496, XrefRangeStart = 177486, XrefRangeEnd = 177491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStamina(float value, bool notify = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_SetStamina_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600519A RID: 20890 RVA: 0x001848E8 File Offset: 0x00182AE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177502, RefRangeEnd = 177503, XrefRangeStart = 177496, XrefRangeEnd = 177502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSprintBlocker(string tag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_AddSprintBlocker_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600519B RID: 20891 RVA: 0x0018492C File Offset: 0x00182B2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 177509, RefRangeEnd = 177511, XrefRangeStart = 177503, XrefRangeEnd = 177509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveSprintBlocker(string tag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_RemoveSprintBlocker_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600519C RID: 20892 RVA: 0x00184970 File Offset: 0x00182B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177511, XrefRangeEnd = 177561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerMovement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600519D RID: 20893 RVA: 0x001849AC File Offset: 0x00182BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177561, XrefRangeEnd = 177569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__104_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr__Start_b__104_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600519E RID: 20894 RVA: 0x00026B2A File Offset: 0x00024D2A
		public PlayerMovement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700186A RID: 6250
		// (get) Token: 0x0600519F RID: 20895 RVA: 0x001849E0 File Offset: 0x00182BE0
		// (set) Token: 0x060051A0 RID: 20896 RVA: 0x00026B33 File Offset: 0x00024D33
		public unsafe static float DEV_SPRINT_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_DEV_SPRINT_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_DEV_SPRINT_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x1700186B RID: 6251
		// (get) Token: 0x060051A1 RID: 20897 RVA: 0x001849FC File Offset: 0x00182BFC
		// (set) Token: 0x060051A2 RID: 20898 RVA: 0x00026B41 File Offset: 0x00024D41
		public unsafe static float GROUNDED_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_GROUNDED_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_GROUNDED_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x1700186C RID: 6252
		// (get) Token: 0x060051A3 RID: 20899 RVA: 0x00184A18 File Offset: 0x00182C18
		// (set) Token: 0x060051A4 RID: 20900 RVA: 0x00026B4F File Offset: 0x00024D4F
		public unsafe static float SLOPE_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_SLOPE_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_SLOPE_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x1700186D RID: 6253
		// (get) Token: 0x060051A5 RID: 20901 RVA: 0x00184A34 File Offset: 0x00182C34
		// (set) Token: 0x060051A6 RID: 20902 RVA: 0x00026B5D File Offset: 0x00024D5D
		public unsafe static float WalkSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_WalkSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_WalkSpeed, (void*)(&value));
			}
		}

		// Token: 0x1700186E RID: 6254
		// (get) Token: 0x060051A7 RID: 20903 RVA: 0x00184A50 File Offset: 0x00182C50
		// (set) Token: 0x060051A8 RID: 20904 RVA: 0x00026B6B File Offset: 0x00024D6B
		public unsafe static float SprintMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_SprintMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_SprintMultiplier, (void*)(&value));
			}
		}

		// Token: 0x1700186F RID: 6255
		// (get) Token: 0x060051A9 RID: 20905 RVA: 0x00184A6C File Offset: 0x00182C6C
		// (set) Token: 0x060051AA RID: 20906 RVA: 0x00026B79 File Offset: 0x00024D79
		public unsafe static float StaticMoveSpeedMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_StaticMoveSpeedMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_StaticMoveSpeedMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17001870 RID: 6256
		// (get) Token: 0x060051AB RID: 20907 RVA: 0x00184A88 File Offset: 0x00182C88
		// (set) Token: 0x060051AC RID: 20908 RVA: 0x00026B87 File Offset: 0x00024D87
		public unsafe static float StaminaRestoreDelay
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_StaminaRestoreDelay, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_StaminaRestoreDelay, (void*)(&value));
			}
		}

		// Token: 0x17001871 RID: 6257
		// (get) Token: 0x060051AD RID: 20909 RVA: 0x00184AA4 File Offset: 0x00182CA4
		// (set) Token: 0x060051AE RID: 20910 RVA: 0x00026B95 File Offset: 0x00024D95
		public unsafe static float JumpMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_JumpMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_JumpMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17001872 RID: 6258
		// (get) Token: 0x060051AF RID: 20911 RVA: 0x00184AC0 File Offset: 0x00182CC0
		// (set) Token: 0x060051B0 RID: 20912 RVA: 0x00026BA3 File Offset: 0x00024DA3
		public unsafe static float ControllerRadius
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_ControllerRadius, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_ControllerRadius, (void*)(&value));
			}
		}

		// Token: 0x17001873 RID: 6259
		// (get) Token: 0x060051B1 RID: 20913 RVA: 0x00184ADC File Offset: 0x00182CDC
		// (set) Token: 0x060051B2 RID: 20914 RVA: 0x00026BB1 File Offset: 0x00024DB1
		public unsafe static float StandingControllerHeight
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_StandingControllerHeight, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_StandingControllerHeight, (void*)(&value));
			}
		}

		// Token: 0x17001874 RID: 6260
		// (get) Token: 0x060051B3 RID: 20915 RVA: 0x00184AF8 File Offset: 0x00182CF8
		// (set) Token: 0x060051B4 RID: 20916 RVA: 0x00026BBF File Offset: 0x00024DBF
		public unsafe static float CrouchHeightMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_CrouchHeightMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_CrouchHeightMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17001875 RID: 6261
		// (get) Token: 0x060051B5 RID: 20917 RVA: 0x00184B14 File Offset: 0x00182D14
		// (set) Token: 0x060051B6 RID: 20918 RVA: 0x00026BCD File Offset: 0x00024DCD
		public unsafe static float CrouchTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_CrouchTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_CrouchTime, (void*)(&value));
			}
		}

		// Token: 0x17001876 RID: 6262
		// (get) Token: 0x060051B7 RID: 20919 RVA: 0x00184B30 File Offset: 0x00182D30
		// (set) Token: 0x060051B8 RID: 20920 RVA: 0x00026BDB File Offset: 0x00024DDB
		public unsafe static float _GravityMultiplier_k__BackingField
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr__GravityMultiplier_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr__GravityMultiplier_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17001877 RID: 6263
		// (get) Token: 0x060051B9 RID: 20921 RVA: 0x00184B4C File Offset: 0x00182D4C
		// (set) Token: 0x060051BA RID: 20922 RVA: 0x00026BE9 File Offset: 0x00024DE9
		public unsafe static float StaminaDrainRate
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_StaminaDrainRate, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_StaminaDrainRate, (void*)(&value));
			}
		}

		// Token: 0x17001878 RID: 6264
		// (get) Token: 0x060051BB RID: 20923 RVA: 0x00184B68 File Offset: 0x00182D68
		// (set) Token: 0x060051BC RID: 20924 RVA: 0x00026BF7 File Offset: 0x00024DF7
		public unsafe static float StaminaRestoreRate
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_StaminaRestoreRate, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_StaminaRestoreRate, (void*)(&value));
			}
		}

		// Token: 0x17001879 RID: 6265
		// (get) Token: 0x060051BD RID: 20925 RVA: 0x00184B84 File Offset: 0x00182D84
		// (set) Token: 0x060051BE RID: 20926 RVA: 0x00026C05 File Offset: 0x00024E05
		public unsafe static float StaminaReserveMax
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_StaminaReserveMax, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_StaminaReserveMax, (void*)(&value));
			}
		}

		// Token: 0x1700187A RID: 6266
		// (get) Token: 0x060051BF RID: 20927 RVA: 0x00184BA0 File Offset: 0x00182DA0
		// (set) Token: 0x060051C0 RID: 20928 RVA: 0x00026C13 File Offset: 0x00024E13
		public unsafe static float SprintChangeRate
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_SprintChangeRate, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_SprintChangeRate, (void*)(&value));
			}
		}

		// Token: 0x1700187B RID: 6267
		// (get) Token: 0x060051C1 RID: 20929 RVA: 0x00184BBC File Offset: 0x00182DBC
		// (set) Token: 0x060051C2 RID: 20930 RVA: 0x00026C21 File Offset: 0x00024E21
		public unsafe Player Player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_Player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_Player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700187C RID: 6268
		// (get) Token: 0x060051C3 RID: 20931 RVA: 0x00184BEC File Offset: 0x00182DEC
		// (set) Token: 0x060051C4 RID: 20932 RVA: 0x00026C40 File Offset: 0x00024E40
		public unsafe CharacterController Controller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_Controller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_Controller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700187D RID: 6269
		// (get) Token: 0x060051C5 RID: 20933 RVA: 0x00184C1C File Offset: 0x00182E1C
		// (set) Token: 0x060051C6 RID: 20934 RVA: 0x00026C5F File Offset: 0x00024E5F
		public unsafe float sensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_sensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_sensitivity)) = value;
			}
		}

		// Token: 0x1700187E RID: 6270
		// (get) Token: 0x060051C7 RID: 20935 RVA: 0x00184C44 File Offset: 0x00182E44
		// (set) Token: 0x060051C8 RID: 20936 RVA: 0x00026C7A File Offset: 0x00024E7A
		public unsafe float dead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_dead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_dead)) = value;
			}
		}

		// Token: 0x1700187F RID: 6271
		// (get) Token: 0x060051C9 RID: 20937 RVA: 0x00184C6C File Offset: 0x00182E6C
		// (set) Token: 0x060051CA RID: 20938 RVA: 0x00026C95 File Offset: 0x00024E95
		public unsafe bool canMove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_canMove);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_canMove)) = value;
			}
		}

		// Token: 0x17001880 RID: 6272
		// (get) Token: 0x060051CB RID: 20939 RVA: 0x00184C94 File Offset: 0x00182E94
		// (set) Token: 0x060051CC RID: 20940 RVA: 0x00026CB0 File Offset: 0x00024EB0
		public unsafe bool canJump
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_canJump);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_canJump)) = value;
			}
		}

		// Token: 0x17001881 RID: 6273
		// (get) Token: 0x060051CD RID: 20941 RVA: 0x00184CBC File Offset: 0x00182EBC
		// (set) Token: 0x060051CE RID: 20942 RVA: 0x00026CCB File Offset: 0x00024ECB
		public unsafe bool SprintingRequiresStamina
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_SprintingRequiresStamina);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_SprintingRequiresStamina)) = value;
			}
		}

		// Token: 0x17001882 RID: 6274
		// (get) Token: 0x060051CF RID: 20943 RVA: 0x00184CE4 File Offset: 0x00182EE4
		// (set) Token: 0x060051D0 RID: 20944 RVA: 0x00026CE6 File Offset: 0x00024EE6
		public unsafe float MoveSpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_MoveSpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_MoveSpeedMultiplier)) = value;
			}
		}

		// Token: 0x17001883 RID: 6275
		// (get) Token: 0x060051D1 RID: 20945 RVA: 0x00184D0C File Offset: 0x00182F0C
		// (set) Token: 0x060051D2 RID: 20946 RVA: 0x00026D01 File Offset: 0x00024F01
		public unsafe float SlipperyMovementMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_SlipperyMovementMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_SlipperyMovementMultiplier)) = value;
			}
		}

		// Token: 0x17001884 RID: 6276
		// (get) Token: 0x060051D3 RID: 20947 RVA: 0x00184D34 File Offset: 0x00182F34
		// (set) Token: 0x060051D4 RID: 20948 RVA: 0x00026D1C File Offset: 0x00024F1C
		public unsafe float jumpForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_jumpForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_jumpForce)) = value;
			}
		}

		// Token: 0x17001885 RID: 6277
		// (get) Token: 0x060051D5 RID: 20949 RVA: 0x00184D5C File Offset: 0x00182F5C
		// (set) Token: 0x060051D6 RID: 20950 RVA: 0x00026D37 File Offset: 0x00024F37
		public unsafe float gravityMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_gravityMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_gravityMultiplier)) = value;
			}
		}

		// Token: 0x17001886 RID: 6278
		// (get) Token: 0x060051D7 RID: 20951 RVA: 0x00184D84 File Offset: 0x00182F84
		// (set) Token: 0x060051D8 RID: 20952 RVA: 0x00026D52 File Offset: 0x00024F52
		public unsafe LayerMask groundDetectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_groundDetectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_groundDetectionMask)) = value;
			}
		}

		// Token: 0x17001887 RID: 6279
		// (get) Token: 0x060051D9 RID: 20953 RVA: 0x00184DAC File Offset: 0x00182FAC
		// (set) Token: 0x060051DA RID: 20954 RVA: 0x00026D6D File Offset: 0x00024F6D
		public unsafe float slopeForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_slopeForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_slopeForce)) = value;
			}
		}

		// Token: 0x17001888 RID: 6280
		// (get) Token: 0x060051DB RID: 20955 RVA: 0x00184DD4 File Offset: 0x00182FD4
		// (set) Token: 0x060051DC RID: 20956 RVA: 0x00026D88 File Offset: 0x00024F88
		public unsafe float slopeForceRayLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_slopeForceRayLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_slopeForceRayLength)) = value;
			}
		}

		// Token: 0x17001889 RID: 6281
		// (get) Token: 0x060051DD RID: 20957 RVA: 0x00184DFC File Offset: 0x00182FFC
		// (set) Token: 0x060051DE RID: 20958 RVA: 0x00026DA3 File Offset: 0x00024FA3
		public unsafe float crouchSpeedMultipler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_crouchSpeedMultipler);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_crouchSpeedMultipler)) = value;
			}
		}

		// Token: 0x1700188A RID: 6282
		// (get) Token: 0x060051DF RID: 20959 RVA: 0x00184E24 File Offset: 0x00183024
		// (set) Token: 0x060051E0 RID: 20960 RVA: 0x00026DBE File Offset: 0x00024FBE
		public unsafe float Crouched_VigIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_Crouched_VigIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_Crouched_VigIntensity)) = value;
			}
		}

		// Token: 0x1700188B RID: 6283
		// (get) Token: 0x060051E1 RID: 20961 RVA: 0x00184E4C File Offset: 0x0018304C
		// (set) Token: 0x060051E2 RID: 20962 RVA: 0x00026DD9 File Offset: 0x00024FD9
		public unsafe float Crouched_VigSmoothness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_Crouched_VigSmoothness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_Crouched_VigSmoothness)) = value;
			}
		}

		// Token: 0x1700188C RID: 6284
		// (get) Token: 0x060051E3 RID: 20963 RVA: 0x00184E74 File Offset: 0x00183074
		// (set) Token: 0x060051E4 RID: 20964 RVA: 0x00026DF4 File Offset: 0x00024FF4
		public unsafe List<Transform> visibilityPointsToScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_visibilityPointsToScale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_visibilityPointsToScale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700188D RID: 6285
		// (get) Token: 0x060051E5 RID: 20965 RVA: 0x00184EA4 File Offset: 0x001830A4
		// (set) Token: 0x060051E6 RID: 20966 RVA: 0x00026E13 File Offset: 0x00025013
		public unsafe Dictionary<Transform, float> originalVisibilityPointOffsets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_originalVisibilityPointOffsets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Transform, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_originalVisibilityPointOffsets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700188E RID: 6286
		// (get) Token: 0x060051E7 RID: 20967 RVA: 0x00184ED4 File Offset: 0x001830D4
		// (set) Token: 0x060051E8 RID: 20968 RVA: 0x00026E32 File Offset: 0x00025032
		public unsafe float _playerHeight_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__playerHeight_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__playerHeight_k__BackingField)) = value;
			}
		}

		// Token: 0x1700188F RID: 6287
		// (get) Token: 0x060051E9 RID: 20969 RVA: 0x00184EFC File Offset: 0x001830FC
		// (set) Token: 0x060051EA RID: 20970 RVA: 0x00026E4D File Offset: 0x0002504D
		public unsafe Vector3 movement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_movement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_movement)) = value;
			}
		}

		// Token: 0x17001890 RID: 6288
		// (get) Token: 0x060051EB RID: 20971 RVA: 0x00184F24 File Offset: 0x00183124
		// (set) Token: 0x060051EC RID: 20972 RVA: 0x00026E68 File Offset: 0x00025068
		public unsafe float movementY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_movementY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_movementY)) = value;
			}
		}

		// Token: 0x17001891 RID: 6289
		// (get) Token: 0x060051ED RID: 20973 RVA: 0x00184F4C File Offset: 0x0018314C
		// (set) Token: 0x060051EE RID: 20974 RVA: 0x00026E83 File Offset: 0x00025083
		public unsafe LandVehicle _currentVehicle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__currentVehicle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__currentVehicle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001892 RID: 6290
		// (get) Token: 0x060051EF RID: 20975 RVA: 0x00184F7C File Offset: 0x0018317C
		// (set) Token: 0x060051F0 RID: 20976 RVA: 0x00026EA2 File Offset: 0x000250A2
		public unsafe List<LandVehicle> recentlyDrivenVehicles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_recentlyDrivenVehicles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_recentlyDrivenVehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001893 RID: 6291
		// (get) Token: 0x060051F1 RID: 20977 RVA: 0x00184FAC File Offset: 0x001831AC
		// (set) Token: 0x060051F2 RID: 20978 RVA: 0x00026EC1 File Offset: 0x000250C1
		public unsafe bool isJumping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_isJumping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_isJumping)) = value;
			}
		}

		// Token: 0x17001894 RID: 6292
		// (get) Token: 0x060051F3 RID: 20979 RVA: 0x00184FD4 File Offset: 0x001831D4
		// (set) Token: 0x060051F4 RID: 20980 RVA: 0x00026EDC File Offset: 0x000250DC
		public unsafe float _airTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__airTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__airTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17001895 RID: 6293
		// (get) Token: 0x060051F5 RID: 20981 RVA: 0x00184FFC File Offset: 0x001831FC
		// (set) Token: 0x060051F6 RID: 20982 RVA: 0x00026EF7 File Offset: 0x000250F7
		public unsafe bool _isCrouched_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__isCrouched_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__isCrouched_k__BackingField)) = value;
			}
		}

		// Token: 0x17001896 RID: 6294
		// (get) Token: 0x060051F7 RID: 20983 RVA: 0x00185024 File Offset: 0x00183224
		// (set) Token: 0x060051F8 RID: 20984 RVA: 0x00026F12 File Offset: 0x00025112
		public unsafe float _standingScale_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__standingScale_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__standingScale_k__BackingField)) = value;
			}
		}

		// Token: 0x17001897 RID: 6295
		// (get) Token: 0x060051F9 RID: 20985 RVA: 0x0018504C File Offset: 0x0018324C
		// (set) Token: 0x060051FA RID: 20986 RVA: 0x00026F2D File Offset: 0x0002512D
		public unsafe bool _isRagdolled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__isRagdolled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__isRagdolled_k__BackingField)) = value;
			}
		}

		// Token: 0x17001898 RID: 6296
		// (get) Token: 0x060051FB RID: 20987 RVA: 0x00185074 File Offset: 0x00183274
		// (set) Token: 0x060051FC RID: 20988 RVA: 0x00026F48 File Offset: 0x00025148
		public unsafe bool _isSprinting_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__isSprinting_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__isSprinting_k__BackingField)) = value;
			}
		}

		// Token: 0x17001899 RID: 6297
		// (get) Token: 0x060051FD RID: 20989 RVA: 0x0018509C File Offset: 0x0018329C
		// (set) Token: 0x060051FE RID: 20990 RVA: 0x00026F63 File Offset: 0x00025163
		public unsafe float _CurrentSprintMultiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__CurrentSprintMultiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__CurrentSprintMultiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x1700189A RID: 6298
		// (get) Token: 0x060051FF RID: 20991 RVA: 0x001850C4 File Offset: 0x001832C4
		// (set) Token: 0x06005200 RID: 20992 RVA: 0x00026F7E File Offset: 0x0002517E
		public unsafe float CurrentStaminaReserve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_CurrentStaminaReserve);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_CurrentStaminaReserve)) = value;
			}
		}

		// Token: 0x1700189B RID: 6299
		// (get) Token: 0x06005201 RID: 20993 RVA: 0x001850EC File Offset: 0x001832EC
		// (set) Token: 0x06005202 RID: 20994 RVA: 0x00026F99 File Offset: 0x00025199
		public unsafe bool _IsGrounded_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__IsGrounded_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__IsGrounded_k__BackingField)) = value;
			}
		}

		// Token: 0x1700189C RID: 6300
		// (get) Token: 0x06005203 RID: 20995 RVA: 0x00185114 File Offset: 0x00183314
		// (set) Token: 0x06005204 RID: 20996 RVA: 0x00026FB4 File Offset: 0x000251B4
		public unsafe Action<float> onStaminaReserveChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onStaminaReserveChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onStaminaReserveChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700189D RID: 6301
		// (get) Token: 0x06005205 RID: 20997 RVA: 0x00185144 File Offset: 0x00183344
		// (set) Token: 0x06005206 RID: 20998 RVA: 0x00026FD3 File Offset: 0x000251D3
		public unsafe Action onJump
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onJump);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onJump), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700189E RID: 6302
		// (get) Token: 0x06005207 RID: 20999 RVA: 0x00185174 File Offset: 0x00183374
		// (set) Token: 0x06005208 RID: 21000 RVA: 0x00026FF2 File Offset: 0x000251F2
		public unsafe Action onLand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onLand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onLand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700189F RID: 6303
		// (get) Token: 0x06005209 RID: 21001 RVA: 0x001851A4 File Offset: 0x001833A4
		// (set) Token: 0x0600520A RID: 21002 RVA: 0x00027011 File Offset: 0x00025211
		public unsafe UnityEvent onCrouch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onCrouch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onCrouch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018A0 RID: 6304
		// (get) Token: 0x0600520B RID: 21003 RVA: 0x001851D4 File Offset: 0x001833D4
		// (set) Token: 0x0600520C RID: 21004 RVA: 0x00027030 File Offset: 0x00025230
		public unsafe UnityEvent onUncrouch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onUncrouch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onUncrouch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018A1 RID: 6305
		// (get) Token: 0x0600520D RID: 21005 RVA: 0x00185204 File Offset: 0x00183404
		// (set) Token: 0x0600520E RID: 21006 RVA: 0x0002704F File Offset: 0x0002524F
		public unsafe float horizontalAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_horizontalAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_horizontalAxis)) = value;
			}
		}

		// Token: 0x170018A2 RID: 6306
		// (get) Token: 0x0600520F RID: 21007 RVA: 0x0018522C File Offset: 0x0018342C
		// (set) Token: 0x06005210 RID: 21008 RVA: 0x0002706A File Offset: 0x0002526A
		public unsafe float verticalAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_verticalAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_verticalAxis)) = value;
			}
		}

		// Token: 0x170018A3 RID: 6307
		// (get) Token: 0x06005211 RID: 21009 RVA: 0x00185254 File Offset: 0x00183454
		// (set) Token: 0x06005212 RID: 21010 RVA: 0x00027085 File Offset: 0x00025285
		public unsafe float timeGrounded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_timeGrounded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_timeGrounded)) = value;
			}
		}

		// Token: 0x170018A4 RID: 6308
		// (get) Token: 0x06005213 RID: 21011 RVA: 0x0018527C File Offset: 0x0018347C
		// (set) Token: 0x06005214 RID: 21012 RVA: 0x000270A0 File Offset: 0x000252A0
		public unsafe Dictionary<int, PlayerMovement.MovementEvent> movementEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_movementEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, PlayerMovement.MovementEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_movementEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018A5 RID: 6309
		// (get) Token: 0x06005215 RID: 21013 RVA: 0x001852AC File Offset: 0x001834AC
		// (set) Token: 0x06005216 RID: 21014 RVA: 0x000270BF File Offset: 0x000252BF
		public unsafe float timeSinceStaminaDrain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_timeSinceStaminaDrain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_timeSinceStaminaDrain)) = value;
			}
		}

		// Token: 0x170018A6 RID: 6310
		// (get) Token: 0x06005217 RID: 21015 RVA: 0x001852D4 File Offset: 0x001834D4
		// (set) Token: 0x06005218 RID: 21016 RVA: 0x000270DA File Offset: 0x000252DA
		public unsafe bool sprintActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_sprintActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_sprintActive)) = value;
			}
		}

		// Token: 0x170018A7 RID: 6311
		// (get) Token: 0x06005219 RID: 21017 RVA: 0x001852FC File Offset: 0x001834FC
		// (set) Token: 0x0600521A RID: 21018 RVA: 0x000270F5 File Offset: 0x000252F5
		public unsafe bool sprintReleased
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_sprintReleased);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_sprintReleased)) = value;
			}
		}

		// Token: 0x170018A8 RID: 6312
		// (get) Token: 0x0600521B RID: 21019 RVA: 0x00185324 File Offset: 0x00183524
		// (set) Token: 0x0600521C RID: 21020 RVA: 0x00027110 File Offset: 0x00025310
		public unsafe Vector3 residualVelocityDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_residualVelocityDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_residualVelocityDirection)) = value;
			}
		}

		// Token: 0x170018A9 RID: 6313
		// (get) Token: 0x0600521D RID: 21021 RVA: 0x0018534C File Offset: 0x0018354C
		// (set) Token: 0x0600521E RID: 21022 RVA: 0x0002712B File Offset: 0x0002532B
		public unsafe float residualVelocityForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_residualVelocityForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_residualVelocityForce)) = value;
			}
		}

		// Token: 0x170018AA RID: 6314
		// (get) Token: 0x0600521F RID: 21023 RVA: 0x00185374 File Offset: 0x00183574
		// (set) Token: 0x06005220 RID: 21024 RVA: 0x00027146 File Offset: 0x00025346
		public unsafe float residualVelocityDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_residualVelocityDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_residualVelocityDuration)) = value;
			}
		}

		// Token: 0x170018AB RID: 6315
		// (get) Token: 0x06005221 RID: 21025 RVA: 0x0018539C File Offset: 0x0018359C
		// (set) Token: 0x06005222 RID: 21026 RVA: 0x00027161 File Offset: 0x00025361
		public unsafe float residualVelocityTimeRemaining
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_residualVelocityTimeRemaining);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_residualVelocityTimeRemaining)) = value;
			}
		}

		// Token: 0x170018AC RID: 6316
		// (get) Token: 0x06005223 RID: 21027 RVA: 0x001853C4 File Offset: 0x001835C4
		// (set) Token: 0x06005224 RID: 21028 RVA: 0x0002717C File Offset: 0x0002537C
		public unsafe bool teleport
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_teleport);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_teleport)) = value;
			}
		}

		// Token: 0x170018AD RID: 6317
		// (get) Token: 0x06005225 RID: 21029 RVA: 0x001853EC File Offset: 0x001835EC
		// (set) Token: 0x06005226 RID: 21030 RVA: 0x00027197 File Offset: 0x00025397
		public unsafe Vector3 teleportPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_teleportPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_teleportPosition)) = value;
			}
		}

		// Token: 0x170018AE RID: 6318
		// (get) Token: 0x06005227 RID: 21031 RVA: 0x00185414 File Offset: 0x00183614
		// (set) Token: 0x06005228 RID: 21032 RVA: 0x000271B2 File Offset: 0x000253B2
		public unsafe List<string> sprintBlockers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_sprintBlockers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_sprintBlockers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018AF RID: 6319
		// (get) Token: 0x06005229 RID: 21033 RVA: 0x00185444 File Offset: 0x00183644
		// (set) Token: 0x0600522A RID: 21034 RVA: 0x000271D1 File Offset: 0x000253D1
		public unsafe Vector3 lastFrameMovement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_lastFrameMovement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_lastFrameMovement)) = value;
			}
		}

		// Token: 0x170018B0 RID: 6320
		// (get) Token: 0x0600522B RID: 21035 RVA: 0x0018546C File Offset: 0x0018366C
		// (set) Token: 0x0600522C RID: 21036 RVA: 0x000271EC File Offset: 0x000253EC
		public unsafe Coroutine playerRotCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_playerRotCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_playerRotCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003741 RID: 14145
		private static readonly IntPtr NativeFieldInfoPtr_DEV_SPRINT_MULTIPLIER;

		// Token: 0x04003742 RID: 14146
		private static readonly IntPtr NativeFieldInfoPtr_GROUNDED_THRESHOLD;

		// Token: 0x04003743 RID: 14147
		private static readonly IntPtr NativeFieldInfoPtr_SLOPE_THRESHOLD;

		// Token: 0x04003744 RID: 14148
		private static readonly IntPtr NativeFieldInfoPtr_WalkSpeed;

		// Token: 0x04003745 RID: 14149
		private static readonly IntPtr NativeFieldInfoPtr_SprintMultiplier;

		// Token: 0x04003746 RID: 14150
		private static readonly IntPtr NativeFieldInfoPtr_StaticMoveSpeedMultiplier;

		// Token: 0x04003747 RID: 14151
		private static readonly IntPtr NativeFieldInfoPtr_StaminaRestoreDelay;

		// Token: 0x04003748 RID: 14152
		private static readonly IntPtr NativeFieldInfoPtr_JumpMultiplier;

		// Token: 0x04003749 RID: 14153
		private static readonly IntPtr NativeFieldInfoPtr_ControllerRadius;

		// Token: 0x0400374A RID: 14154
		private static readonly IntPtr NativeFieldInfoPtr_StandingControllerHeight;

		// Token: 0x0400374B RID: 14155
		private static readonly IntPtr NativeFieldInfoPtr_CrouchHeightMultiplier;

		// Token: 0x0400374C RID: 14156
		private static readonly IntPtr NativeFieldInfoPtr_CrouchTime;

		// Token: 0x0400374D RID: 14157
		private static readonly IntPtr NativeFieldInfoPtr__GravityMultiplier_k__BackingField;

		// Token: 0x0400374E RID: 14158
		private static readonly IntPtr NativeFieldInfoPtr_StaminaDrainRate;

		// Token: 0x0400374F RID: 14159
		private static readonly IntPtr NativeFieldInfoPtr_StaminaRestoreRate;

		// Token: 0x04003750 RID: 14160
		private static readonly IntPtr NativeFieldInfoPtr_StaminaReserveMax;

		// Token: 0x04003751 RID: 14161
		private static readonly IntPtr NativeFieldInfoPtr_SprintChangeRate;

		// Token: 0x04003752 RID: 14162
		private static readonly IntPtr NativeFieldInfoPtr_Player;

		// Token: 0x04003753 RID: 14163
		private static readonly IntPtr NativeFieldInfoPtr_Controller;

		// Token: 0x04003754 RID: 14164
		private static readonly IntPtr NativeFieldInfoPtr_sensitivity;

		// Token: 0x04003755 RID: 14165
		private static readonly IntPtr NativeFieldInfoPtr_dead;

		// Token: 0x04003756 RID: 14166
		private static readonly IntPtr NativeFieldInfoPtr_canMove;

		// Token: 0x04003757 RID: 14167
		private static readonly IntPtr NativeFieldInfoPtr_canJump;

		// Token: 0x04003758 RID: 14168
		private static readonly IntPtr NativeFieldInfoPtr_SprintingRequiresStamina;

		// Token: 0x04003759 RID: 14169
		private static readonly IntPtr NativeFieldInfoPtr_MoveSpeedMultiplier;

		// Token: 0x0400375A RID: 14170
		private static readonly IntPtr NativeFieldInfoPtr_SlipperyMovementMultiplier;

		// Token: 0x0400375B RID: 14171
		private static readonly IntPtr NativeFieldInfoPtr_jumpForce;

		// Token: 0x0400375C RID: 14172
		private static readonly IntPtr NativeFieldInfoPtr_gravityMultiplier;

		// Token: 0x0400375D RID: 14173
		private static readonly IntPtr NativeFieldInfoPtr_groundDetectionMask;

		// Token: 0x0400375E RID: 14174
		private static readonly IntPtr NativeFieldInfoPtr_slopeForce;

		// Token: 0x0400375F RID: 14175
		private static readonly IntPtr NativeFieldInfoPtr_slopeForceRayLength;

		// Token: 0x04003760 RID: 14176
		private static readonly IntPtr NativeFieldInfoPtr_crouchSpeedMultipler;

		// Token: 0x04003761 RID: 14177
		private static readonly IntPtr NativeFieldInfoPtr_Crouched_VigIntensity;

		// Token: 0x04003762 RID: 14178
		private static readonly IntPtr NativeFieldInfoPtr_Crouched_VigSmoothness;

		// Token: 0x04003763 RID: 14179
		private static readonly IntPtr NativeFieldInfoPtr_visibilityPointsToScale;

		// Token: 0x04003764 RID: 14180
		private static readonly IntPtr NativeFieldInfoPtr_originalVisibilityPointOffsets;

		// Token: 0x04003765 RID: 14181
		private static readonly IntPtr NativeFieldInfoPtr__playerHeight_k__BackingField;

		// Token: 0x04003766 RID: 14182
		private static readonly IntPtr NativeFieldInfoPtr_movement;

		// Token: 0x04003767 RID: 14183
		private static readonly IntPtr NativeFieldInfoPtr_movementY;

		// Token: 0x04003768 RID: 14184
		private static readonly IntPtr NativeFieldInfoPtr__currentVehicle_k__BackingField;

		// Token: 0x04003769 RID: 14185
		private static readonly IntPtr NativeFieldInfoPtr_recentlyDrivenVehicles;

		// Token: 0x0400376A RID: 14186
		private static readonly IntPtr NativeFieldInfoPtr_isJumping;

		// Token: 0x0400376B RID: 14187
		private static readonly IntPtr NativeFieldInfoPtr__airTime_k__BackingField;

		// Token: 0x0400376C RID: 14188
		private static readonly IntPtr NativeFieldInfoPtr__isCrouched_k__BackingField;

		// Token: 0x0400376D RID: 14189
		private static readonly IntPtr NativeFieldInfoPtr__standingScale_k__BackingField;

		// Token: 0x0400376E RID: 14190
		private static readonly IntPtr NativeFieldInfoPtr__isRagdolled_k__BackingField;

		// Token: 0x0400376F RID: 14191
		private static readonly IntPtr NativeFieldInfoPtr__isSprinting_k__BackingField;

		// Token: 0x04003770 RID: 14192
		private static readonly IntPtr NativeFieldInfoPtr__CurrentSprintMultiplier_k__BackingField;

		// Token: 0x04003771 RID: 14193
		private static readonly IntPtr NativeFieldInfoPtr_CurrentStaminaReserve;

		// Token: 0x04003772 RID: 14194
		private static readonly IntPtr NativeFieldInfoPtr__IsGrounded_k__BackingField;

		// Token: 0x04003773 RID: 14195
		private static readonly IntPtr NativeFieldInfoPtr_onStaminaReserveChanged;

		// Token: 0x04003774 RID: 14196
		private static readonly IntPtr NativeFieldInfoPtr_onJump;

		// Token: 0x04003775 RID: 14197
		private static readonly IntPtr NativeFieldInfoPtr_onLand;

		// Token: 0x04003776 RID: 14198
		private static readonly IntPtr NativeFieldInfoPtr_onCrouch;

		// Token: 0x04003777 RID: 14199
		private static readonly IntPtr NativeFieldInfoPtr_onUncrouch;

		// Token: 0x04003778 RID: 14200
		private static readonly IntPtr NativeFieldInfoPtr_horizontalAxis;

		// Token: 0x04003779 RID: 14201
		private static readonly IntPtr NativeFieldInfoPtr_verticalAxis;

		// Token: 0x0400377A RID: 14202
		private static readonly IntPtr NativeFieldInfoPtr_timeGrounded;

		// Token: 0x0400377B RID: 14203
		private static readonly IntPtr NativeFieldInfoPtr_movementEvents;

		// Token: 0x0400377C RID: 14204
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceStaminaDrain;

		// Token: 0x0400377D RID: 14205
		private static readonly IntPtr NativeFieldInfoPtr_sprintActive;

		// Token: 0x0400377E RID: 14206
		private static readonly IntPtr NativeFieldInfoPtr_sprintReleased;

		// Token: 0x0400377F RID: 14207
		private static readonly IntPtr NativeFieldInfoPtr_residualVelocityDirection;

		// Token: 0x04003780 RID: 14208
		private static readonly IntPtr NativeFieldInfoPtr_residualVelocityForce;

		// Token: 0x04003781 RID: 14209
		private static readonly IntPtr NativeFieldInfoPtr_residualVelocityDuration;

		// Token: 0x04003782 RID: 14210
		private static readonly IntPtr NativeFieldInfoPtr_residualVelocityTimeRemaining;

		// Token: 0x04003783 RID: 14211
		private static readonly IntPtr NativeFieldInfoPtr_teleport;

		// Token: 0x04003784 RID: 14212
		private static readonly IntPtr NativeFieldInfoPtr_teleportPosition;

		// Token: 0x04003785 RID: 14213
		private static readonly IntPtr NativeFieldInfoPtr_sprintBlockers;

		// Token: 0x04003786 RID: 14214
		private static readonly IntPtr NativeFieldInfoPtr_lastFrameMovement;

		// Token: 0x04003787 RID: 14215
		private static readonly IntPtr NativeFieldInfoPtr_playerRotCoroutine;

		// Token: 0x04003788 RID: 14216
		private static readonly IntPtr NativeMethodInfoPtr_get_GravityMultiplier_Public_Static_get_Single_0;

		// Token: 0x04003789 RID: 14217
		private static readonly IntPtr NativeMethodInfoPtr_set_GravityMultiplier_Public_Static_set_Void_Single_0;

		// Token: 0x0400378A RID: 14218
		private static readonly IntPtr NativeMethodInfoPtr_get_playerHeight_Public_get_Single_0;

		// Token: 0x0400378B RID: 14219
		private static readonly IntPtr NativeMethodInfoPtr_set_playerHeight_Protected_set_Void_Single_0;

		// Token: 0x0400378C RID: 14220
		private static readonly IntPtr NativeMethodInfoPtr_get_Movement_Public_get_Vector3_0;

		// Token: 0x0400378D RID: 14221
		private static readonly IntPtr NativeMethodInfoPtr_get_currentVehicle_Public_get_LandVehicle_0;

		// Token: 0x0400378E RID: 14222
		private static readonly IntPtr NativeMethodInfoPtr_set_currentVehicle_Protected_set_Void_LandVehicle_0;

		// Token: 0x0400378F RID: 14223
		private static readonly IntPtr NativeMethodInfoPtr_get_airTime_Public_get_Single_0;

		// Token: 0x04003790 RID: 14224
		private static readonly IntPtr NativeMethodInfoPtr_set_airTime_Protected_set_Void_Single_0;

		// Token: 0x04003791 RID: 14225
		private static readonly IntPtr NativeMethodInfoPtr_get_isCrouched_Public_get_Boolean_0;

		// Token: 0x04003792 RID: 14226
		private static readonly IntPtr NativeMethodInfoPtr_set_isCrouched_Protected_set_Void_Boolean_0;

		// Token: 0x04003793 RID: 14227
		private static readonly IntPtr NativeMethodInfoPtr_get_standingScale_Public_get_Single_0;

		// Token: 0x04003794 RID: 14228
		private static readonly IntPtr NativeMethodInfoPtr_set_standingScale_Protected_set_Void_Single_0;

		// Token: 0x04003795 RID: 14229
		private static readonly IntPtr NativeMethodInfoPtr_get_isRagdolled_Public_get_Boolean_0;

		// Token: 0x04003796 RID: 14230
		private static readonly IntPtr NativeMethodInfoPtr_set_isRagdolled_Protected_set_Void_Boolean_0;

		// Token: 0x04003797 RID: 14231
		private static readonly IntPtr NativeMethodInfoPtr_get_isSprinting_Public_get_Boolean_0;

		// Token: 0x04003798 RID: 14232
		private static readonly IntPtr NativeMethodInfoPtr_set_isSprinting_Protected_set_Void_Boolean_0;

		// Token: 0x04003799 RID: 14233
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSprintMultiplier_Public_get_Single_0;

		// Token: 0x0400379A RID: 14234
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentSprintMultiplier_Protected_set_Void_Single_0;

		// Token: 0x0400379B RID: 14235
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGrounded_Public_get_Boolean_0;

		// Token: 0x0400379C RID: 14236
		private static readonly IntPtr NativeMethodInfoPtr_set_IsGrounded_Private_set_Void_Boolean_0;

		// Token: 0x0400379D RID: 14237
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400379E RID: 14238
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400379F RID: 14239
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040037A0 RID: 14240
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040037A1 RID: 14241
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040037A2 RID: 14242
		private static readonly IntPtr NativeMethodInfoPtr_Move_Protected_Virtual_New_Void_0;

		// Token: 0x040037A3 RID: 14243
		private static readonly IntPtr NativeMethodInfoPtr_ClampMovement_Private_Void_0;

		// Token: 0x040037A4 RID: 14244
		private static readonly IntPtr NativeMethodInfoPtr_GetSurfaceAngle_Protected_Single_0;

		// Token: 0x040037A5 RID: 14245
		private static readonly IntPtr NativeMethodInfoPtr_isGrounded_Private_Boolean_0;

		// Token: 0x040037A6 RID: 14246
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHorizontalAxis_Protected_Void_0;

		// Token: 0x040037A7 RID: 14247
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVerticalAxis_Protected_Void_0;

		// Token: 0x040037A8 RID: 14248
		private static readonly IntPtr NativeMethodInfoPtr_Jump_Private_IEnumerator_0;

		// Token: 0x040037A9 RID: 14249
		private static readonly IntPtr NativeMethodInfoPtr_TryToggleCrouch_Private_Void_0;

		// Token: 0x040037AA RID: 14250
		private static readonly IntPtr NativeMethodInfoPtr_CanStand_Public_Boolean_0;

		// Token: 0x040037AB RID: 14251
		private static readonly IntPtr NativeMethodInfoPtr_SetCrouched_Public_Void_Boolean_0;

		// Token: 0x040037AC RID: 14252
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCrouchVignetteEffect_Private_Void_0;

		// Token: 0x040037AD RID: 14253
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePlayerHeight_Private_Void_0;

		// Token: 0x040037AE RID: 14254
		private static readonly IntPtr NativeMethodInfoPtr_LerpPlayerRotation_Public_Void_Quaternion_Single_0;

		// Token: 0x040037AF RID: 14255
		private static readonly IntPtr NativeMethodInfoPtr_LerpPlayerRotation_Process_Private_IEnumerator_Quaternion_Single_0;

		// Token: 0x040037B0 RID: 14256
		private static readonly IntPtr NativeMethodInfoPtr_EnterVehicle_Private_Void_LandVehicle_0;

		// Token: 0x040037B1 RID: 14257
		private static readonly IntPtr NativeMethodInfoPtr_ExitVehicle_Private_Void_LandVehicle_Transform_0;

		// Token: 0x040037B2 RID: 14258
		private static readonly IntPtr NativeMethodInfoPtr_Teleport_Public_Void_Vector3_0;

		// Token: 0x040037B3 RID: 14259
		private static readonly IntPtr NativeMethodInfoPtr_SetResidualVelocity_Public_Void_Vector3_Single_Single_0;

		// Token: 0x040037B4 RID: 14260
		private static readonly IntPtr NativeMethodInfoPtr_WarpToNavMesh_Public_Void_0;

		// Token: 0x040037B5 RID: 14261
		private static readonly IntPtr NativeMethodInfoPtr_RegisterMovementEvent_Public_Void_Int32_Action_0;

		// Token: 0x040037B6 RID: 14262
		private static readonly IntPtr NativeMethodInfoPtr_DeregisterMovementEvent_Public_Void_Action_0;

		// Token: 0x040037B7 RID: 14263
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMovementEvents_Private_Void_0;

		// Token: 0x040037B8 RID: 14264
		private static readonly IntPtr NativeMethodInfoPtr_ChangeStamina_Public_Void_Single_Boolean_0;

		// Token: 0x040037B9 RID: 14265
		private static readonly IntPtr NativeMethodInfoPtr_SetStamina_Public_Void_Single_Boolean_0;

		// Token: 0x040037BA RID: 14266
		private static readonly IntPtr NativeMethodInfoPtr_AddSprintBlocker_Public_Void_String_0;

		// Token: 0x040037BB RID: 14267
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSprintBlocker_Public_Void_String_0;

		// Token: 0x040037BC RID: 14268
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040037BD RID: 14269
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__104_0_Private_Void_0;

		// Token: 0x020009A8 RID: 2472
		public class MovementEvent : Il2CppSystem.Object
		{
			// Token: 0x0600CB73 RID: 52083 RVA: 0x003120F0 File Offset: 0x003102F0
			// Note: this type is marked as 'beforefieldinit'.
			static MovementEvent()
			{
				Il2CppClassPointerStore<PlayerMovement.MovementEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "MovementEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerMovement.MovementEvent>.NativeClassPtr);
				PlayerMovement.MovementEvent.NativeFieldInfoPtr_actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement.MovementEvent>.NativeClassPtr, "actions");
				PlayerMovement.MovementEvent.NativeFieldInfoPtr_LastUpdatedDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement.MovementEvent>.NativeClassPtr, "LastUpdatedDistance");
				PlayerMovement.MovementEvent.NativeMethodInfoPtr_Update_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement.MovementEvent>.NativeClassPtr, 100673572);
				PlayerMovement.MovementEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement.MovementEvent>.NativeClassPtr, 100673573);
			}

			// Token: 0x0600CB74 RID: 52084 RVA: 0x0031216C File Offset: 0x0031036C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 176865, RefRangeEnd = 176867, XrefRangeStart = 176851, XrefRangeEnd = 176865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Update(Vector3 newPosition)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref newPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.MovementEvent.NativeMethodInfoPtr_Update_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB75 RID: 52085 RVA: 0x003121AC File Offset: 0x003103AC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 176877, RefRangeEnd = 176878, XrefRangeStart = 176867, XrefRangeEnd = 176877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MovementEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerMovement.MovementEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.MovementEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB76 RID: 52086 RVA: 0x00062F34 File Offset: 0x00061134
			public MovementEvent(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F5F RID: 16223
			// (get) Token: 0x0600CB77 RID: 52087 RVA: 0x003121E8 File Offset: 0x003103E8
			// (set) Token: 0x0600CB78 RID: 52088 RVA: 0x00062F3D File Offset: 0x0006113D
			public unsafe List<Action> actions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.MovementEvent.NativeFieldInfoPtr_actions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.MovementEvent.NativeFieldInfoPtr_actions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F60 RID: 16224
			// (get) Token: 0x0600CB79 RID: 52089 RVA: 0x00312218 File Offset: 0x00310418
			// (set) Token: 0x0600CB7A RID: 52090 RVA: 0x00062F5C File Offset: 0x0006115C
			public unsafe Vector3 LastUpdatedDistance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.MovementEvent.NativeFieldInfoPtr_LastUpdatedDistance);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.MovementEvent.NativeFieldInfoPtr_LastUpdatedDistance)) = value;
				}
			}

			// Token: 0x04008989 RID: 35209
			private static readonly IntPtr NativeFieldInfoPtr_actions;

			// Token: 0x0400898A RID: 35210
			private static readonly IntPtr NativeFieldInfoPtr_LastUpdatedDistance;

			// Token: 0x0400898B RID: 35211
			private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_Vector3_0;

			// Token: 0x0400898C RID: 35212
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009A9 RID: 2473
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerMovement+<Jump>d__114")]
		public sealed class _Jump_d__114 : Il2CppSystem.Object
		{
			// Token: 0x0600CB7B RID: 52091 RVA: 0x00312240 File Offset: 0x00310440
			// Note: this type is marked as 'beforefieldinit'.
			static _Jump_d__114()
			{
				Il2CppClassPointerStore<PlayerMovement._Jump_d__114>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<Jump>d__114");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerMovement._Jump_d__114>.NativeClassPtr);
				PlayerMovement._Jump_d__114.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._Jump_d__114>.NativeClassPtr, "<>1__state");
				PlayerMovement._Jump_d__114.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._Jump_d__114>.NativeClassPtr, "<>2__current");
				PlayerMovement._Jump_d__114.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._Jump_d__114>.NativeClassPtr, "<>4__this");
				PlayerMovement._Jump_d__114.NativeFieldInfoPtr__savedSlopeLimit_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._Jump_d__114>.NativeClassPtr, "<savedSlopeLimit>5__2");
				PlayerMovement._Jump_d__114.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._Jump_d__114>.NativeClassPtr, 100673574);
				PlayerMovement._Jump_d__114.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._Jump_d__114>.NativeClassPtr, 100673575);
				PlayerMovement._Jump_d__114.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._Jump_d__114>.NativeClassPtr, 100673576);
				PlayerMovement._Jump_d__114.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._Jump_d__114>.NativeClassPtr, 100673577);
				PlayerMovement._Jump_d__114.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._Jump_d__114>.NativeClassPtr, 100673578);
				PlayerMovement._Jump_d__114.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._Jump_d__114>.NativeClassPtr, 100673579);
			}

			// Token: 0x0600CB7C RID: 52092 RVA: 0x00312334 File Offset: 0x00310534
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Jump_d__114(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerMovement._Jump_d__114>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._Jump_d__114.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB7D RID: 52093 RVA: 0x0031237C File Offset: 0x0031057C
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._Jump_d__114.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB7E RID: 52094 RVA: 0x003123B0 File Offset: 0x003105B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176878, XrefRangeEnd = 176897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._Jump_d__114.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003F65 RID: 16229
			// (get) Token: 0x0600CB7F RID: 52095 RVA: 0x003123EC File Offset: 0x003105EC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._Jump_d__114.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CB80 RID: 52096 RVA: 0x0031242C File Offset: 0x0031062C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176897, XrefRangeEnd = 176902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._Jump_d__114.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003F66 RID: 16230
			// (get) Token: 0x0600CB81 RID: 52097 RVA: 0x00312460 File Offset: 0x00310660
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._Jump_d__114.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CB82 RID: 52098 RVA: 0x00062F77 File Offset: 0x00061177
			public _Jump_d__114(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F61 RID: 16225
			// (get) Token: 0x0600CB83 RID: 52099 RVA: 0x003124A0 File Offset: 0x003106A0
			// (set) Token: 0x0600CB84 RID: 52100 RVA: 0x00062F80 File Offset: 0x00061180
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._Jump_d__114.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._Jump_d__114.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003F62 RID: 16226
			// (get) Token: 0x0600CB85 RID: 52101 RVA: 0x003124C8 File Offset: 0x003106C8
			// (set) Token: 0x0600CB86 RID: 52102 RVA: 0x00062F9B File Offset: 0x0006119B
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._Jump_d__114.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._Jump_d__114.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F63 RID: 16227
			// (get) Token: 0x0600CB87 RID: 52103 RVA: 0x003124F8 File Offset: 0x003106F8
			// (set) Token: 0x0600CB88 RID: 52104 RVA: 0x00062FBA File Offset: 0x000611BA
			public unsafe PlayerMovement __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._Jump_d__114.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerMovement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._Jump_d__114.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F64 RID: 16228
			// (get) Token: 0x0600CB89 RID: 52105 RVA: 0x00312528 File Offset: 0x00310728
			// (set) Token: 0x0600CB8A RID: 52106 RVA: 0x00062FD9 File Offset: 0x000611D9
			public unsafe float _savedSlopeLimit_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._Jump_d__114.NativeFieldInfoPtr__savedSlopeLimit_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._Jump_d__114.NativeFieldInfoPtr__savedSlopeLimit_5__2)) = value;
				}
			}

			// Token: 0x0400898D RID: 35213
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400898E RID: 35214
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400898F RID: 35215
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008990 RID: 35216
			private static readonly IntPtr NativeFieldInfoPtr__savedSlopeLimit_5__2;

			// Token: 0x04008991 RID: 35217
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008992 RID: 35218
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008993 RID: 35219
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008994 RID: 35220
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008995 RID: 35221
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008996 RID: 35222
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020009AA RID: 2474
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerMovement+<LerpPlayerRotation_Process>d__122")]
		public sealed class _LerpPlayerRotation_Process_d__122 : Il2CppSystem.Object
		{
			// Token: 0x0600CB8B RID: 52107 RVA: 0x00312550 File Offset: 0x00310750
			// Note: this type is marked as 'beforefieldinit'.
			static _LerpPlayerRotation_Process_d__122()
			{
				Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__122>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<LerpPlayerRotation_Process>d__122");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__122>.NativeClassPtr);
				PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__122>.NativeClassPtr, "<>1__state");
				PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__122>.NativeClassPtr, "<>2__current");
				PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__122>.NativeClassPtr, "<>4__this");
				PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr_endRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__122>.NativeClassPtr, "endRotation");
				PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__122>.NativeClassPtr, "lerpTime");
				PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr__startRot_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__122>.NativeClassPtr, "<startRot>5__2");
				PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__122>.NativeClassPtr, "<i>5__3");
				PlayerMovement._LerpPlayerRotation_Process_d__122.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__122>.NativeClassPtr, 100673580);
				PlayerMovement._LerpPlayerRotation_Process_d__122.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__122>.NativeClassPtr, 100673581);
				PlayerMovement._LerpPlayerRotation_Process_d__122.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__122>.NativeClassPtr, 100673582);
				PlayerMovement._LerpPlayerRotation_Process_d__122.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__122>.NativeClassPtr, 100673583);
				PlayerMovement._LerpPlayerRotation_Process_d__122.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__122>.NativeClassPtr, 100673584);
				PlayerMovement._LerpPlayerRotation_Process_d__122.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__122>.NativeClassPtr, 100673585);
			}

			// Token: 0x0600CB8C RID: 52108 RVA: 0x00312680 File Offset: 0x00310880
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LerpPlayerRotation_Process_d__122(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__122>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB8D RID: 52109 RVA: 0x003126C8 File Offset: 0x003108C8
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CB8E RID: 52110 RVA: 0x003126FC File Offset: 0x003108FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176902, XrefRangeEnd = 176915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003F6E RID: 16238
			// (get) Token: 0x0600CB8F RID: 52111 RVA: 0x00312738 File Offset: 0x00310938
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CB90 RID: 52112 RVA: 0x00312778 File Offset: 0x00310978
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176915, XrefRangeEnd = 176920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003F6F RID: 16239
			// (get) Token: 0x0600CB91 RID: 52113 RVA: 0x003127AC File Offset: 0x003109AC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CB92 RID: 52114 RVA: 0x00062FF4 File Offset: 0x000611F4
			public _LerpPlayerRotation_Process_d__122(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F67 RID: 16231
			// (get) Token: 0x0600CB93 RID: 52115 RVA: 0x003127EC File Offset: 0x003109EC
			// (set) Token: 0x0600CB94 RID: 52116 RVA: 0x00062FFD File Offset: 0x000611FD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003F68 RID: 16232
			// (get) Token: 0x0600CB95 RID: 52117 RVA: 0x00312814 File Offset: 0x00310A14
			// (set) Token: 0x0600CB96 RID: 52118 RVA: 0x00063018 File Offset: 0x00061218
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F69 RID: 16233
			// (get) Token: 0x0600CB97 RID: 52119 RVA: 0x00312844 File Offset: 0x00310A44
			// (set) Token: 0x0600CB98 RID: 52120 RVA: 0x00063037 File Offset: 0x00061237
			public unsafe PlayerMovement __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerMovement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F6A RID: 16234
			// (get) Token: 0x0600CB99 RID: 52121 RVA: 0x00312874 File Offset: 0x00310A74
			// (set) Token: 0x0600CB9A RID: 52122 RVA: 0x00063056 File Offset: 0x00061256
			public unsafe Quaternion endRotation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr_endRotation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr_endRotation)) = value;
				}
			}

			// Token: 0x17003F6B RID: 16235
			// (get) Token: 0x0600CB9B RID: 52123 RVA: 0x0031289C File Offset: 0x00310A9C
			// (set) Token: 0x0600CB9C RID: 52124 RVA: 0x00063071 File Offset: 0x00061271
			public unsafe float lerpTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr_lerpTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr_lerpTime)) = value;
				}
			}

			// Token: 0x17003F6C RID: 16236
			// (get) Token: 0x0600CB9D RID: 52125 RVA: 0x003128C4 File Offset: 0x00310AC4
			// (set) Token: 0x0600CB9E RID: 52126 RVA: 0x0006308C File Offset: 0x0006128C
			public unsafe Quaternion _startRot_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr__startRot_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr__startRot_5__2)) = value;
				}
			}

			// Token: 0x17003F6D RID: 16237
			// (get) Token: 0x0600CB9F RID: 52127 RVA: 0x003128EC File Offset: 0x00310AEC
			// (set) Token: 0x0600CBA0 RID: 52128 RVA: 0x000630A7 File Offset: 0x000612A7
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__122.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04008997 RID: 35223
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008998 RID: 35224
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008999 RID: 35225
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400899A RID: 35226
			private static readonly IntPtr NativeFieldInfoPtr_endRotation;

			// Token: 0x0400899B RID: 35227
			private static readonly IntPtr NativeFieldInfoPtr_lerpTime;

			// Token: 0x0400899C RID: 35228
			private static readonly IntPtr NativeFieldInfoPtr__startRot_5__2;

			// Token: 0x0400899D RID: 35229
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x0400899E RID: 35230
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400899F RID: 35231
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040089A0 RID: 35232
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040089A1 RID: 35233
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040089A2 RID: 35234
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040089A3 RID: 35235
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
