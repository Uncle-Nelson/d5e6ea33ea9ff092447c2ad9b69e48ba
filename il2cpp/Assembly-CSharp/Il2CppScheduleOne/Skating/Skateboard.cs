using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Tools;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Skating
{
	// Token: 0x020001A4 RID: 420
	public class Skateboard : NetworkBehaviour
	{
		// Token: 0x06002276 RID: 8822 RVA: 0x000DC464 File Offset: 0x000DA664
		// Note: this type is marked as 'beforefieldinit'.
		static Skateboard()
		{
			Il2CppClassPointerStore<Skateboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Skating", "Skateboard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Skateboard>.NativeClassPtr);
			Skateboard.NativeFieldInfoPtr_GroundedRaycastDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "GroundedRaycastDistance");
			Skateboard.NativeFieldInfoPtr_JumpCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpCooldown");
			Skateboard.NativeFieldInfoPtr_JumpForceMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpForceMin");
			Skateboard.NativeFieldInfoPtr_JumpForceBuildTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpForceBuildTime");
			Skateboard.NativeFieldInfoPtr_PushCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PushCooldown");
			Skateboard.NativeFieldInfoPtr_PushStaminaConsumption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PushStaminaConsumption");
			Skateboard.NativeFieldInfoPtr_PitchLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PitchLimit");
			Skateboard.NativeFieldInfoPtr_RollLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "RollLimit");
			Skateboard.NativeFieldInfoPtr_CurrentSpeed_Kmh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "CurrentSpeed_Kmh");
			Skateboard.NativeFieldInfoPtr__CurrentSteerInput_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "<CurrentSteerInput>k__BackingField");
			Skateboard.NativeFieldInfoPtr__JumpBuildAmount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "<JumpBuildAmount>k__BackingField");
			Skateboard.NativeFieldInfoPtr__Rider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "<Rider>k__BackingField");
			Skateboard.NativeFieldInfoPtr_Rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Rb");
			Skateboard.NativeFieldInfoPtr_CoM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "CoM");
			Skateboard.NativeFieldInfoPtr_HoverPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "HoverPoints");
			Skateboard.NativeFieldInfoPtr_FrontAxlePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "FrontAxlePosition");
			Skateboard.NativeFieldInfoPtr_RearAxlePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "RearAxlePosition");
			Skateboard.NativeFieldInfoPtr_PlayerContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PlayerContainer");
			Skateboard.NativeFieldInfoPtr_Animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Animation");
			Skateboard.NativeFieldInfoPtr_VelocityCalculator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "VelocityCalculator");
			Skateboard.NativeFieldInfoPtr_Accelerometer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Accelerometer");
			Skateboard.NativeFieldInfoPtr_Equippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Equippable");
			Skateboard.NativeFieldInfoPtr_IKAlignmentsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "IKAlignmentsContainer");
			Skateboard.NativeFieldInfoPtr_TurnForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "TurnForce");
			Skateboard.NativeFieldInfoPtr_TurnChangeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "TurnChangeRate");
			Skateboard.NativeFieldInfoPtr_TurnReturnToRestRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "TurnReturnToRestRate");
			Skateboard.NativeFieldInfoPtr_TurnSpeedBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "TurnSpeedBoost");
			Skateboard.NativeFieldInfoPtr_TurnForceMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "TurnForceMap");
			Skateboard.NativeFieldInfoPtr_Gravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Gravity");
			Skateboard.NativeFieldInfoPtr_BrakeForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "BrakeForce");
			Skateboard.NativeFieldInfoPtr_ReverseTopSpeed_Kmh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "ReverseTopSpeed_Kmh");
			Skateboard.NativeFieldInfoPtr_GroundDetectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "GroundDetectionMask");
			Skateboard.NativeFieldInfoPtr_MainColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "MainColliders");
			Skateboard.NativeFieldInfoPtr_RotationClampForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "RotationClampForce");
			Skateboard.NativeFieldInfoPtr_FrictionEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "FrictionEnabled");
			Skateboard.NativeFieldInfoPtr_LongitudinalFrictionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "LongitudinalFrictionCurve");
			Skateboard.NativeFieldInfoPtr_LongitudinalFrictionMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "LongitudinalFrictionMultiplier");
			Skateboard.NativeFieldInfoPtr_LateralFrictionForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "LateralFrictionForceMultiplier");
			Skateboard.NativeFieldInfoPtr_JumpForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpForce");
			Skateboard.NativeFieldInfoPtr_JumpDuration_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpDuration_Min");
			Skateboard.NativeFieldInfoPtr_JumpDuration_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpDuration_Max");
			Skateboard.NativeFieldInfoPtr_FrontAxleJumpCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "FrontAxleJumpCurve");
			Skateboard.NativeFieldInfoPtr_RearAxleJumpCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "RearAxleJumpCurve");
			Skateboard.NativeFieldInfoPtr_JumpForwardForceCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpForwardForceCurve");
			Skateboard.NativeFieldInfoPtr_JumpForwardBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpForwardBoost");
			Skateboard.NativeFieldInfoPtr_HoverForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "HoverForce");
			Skateboard.NativeFieldInfoPtr_HoverRayLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "HoverRayLength");
			Skateboard.NativeFieldInfoPtr_HoverHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "HoverHeight");
			Skateboard.NativeFieldInfoPtr_Hover_P = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Hover_P");
			Skateboard.NativeFieldInfoPtr_Hover_I = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Hover_I");
			Skateboard.NativeFieldInfoPtr_Hover_D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Hover_D");
			Skateboard.NativeFieldInfoPtr_TopSpeed_Kmh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "TopSpeed_Kmh");
			Skateboard.NativeFieldInfoPtr_PushForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PushForceMultiplier");
			Skateboard.NativeFieldInfoPtr_PushForceMultiplierMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PushForceMultiplierMap");
			Skateboard.NativeFieldInfoPtr_PushForceDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PushForceDuration");
			Skateboard.NativeFieldInfoPtr_PushDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PushDelay");
			Skateboard.NativeFieldInfoPtr_PushForceCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PushForceCurve");
			Skateboard.NativeFieldInfoPtr_AirMovementEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "AirMovementEnabled");
			Skateboard.NativeFieldInfoPtr_AirMovementForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "AirMovementForce");
			Skateboard.NativeFieldInfoPtr_AirMovementJumpReductionDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "AirMovementJumpReductionDuration");
			Skateboard.NativeFieldInfoPtr_AirMovementJumpReductionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "AirMovementJumpReductionCurve");
			Skateboard.NativeFieldInfoPtr_OnPushStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "OnPushStart");
			Skateboard.NativeFieldInfoPtr_OnJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "OnJump");
			Skateboard.NativeFieldInfoPtr_OnLand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "OnLand");
			Skateboard.NativeFieldInfoPtr_horizontalInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "horizontalInput");
			Skateboard.NativeFieldInfoPtr_jumpReleased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "jumpReleased");
			Skateboard.NativeFieldInfoPtr_timeSinceLastJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "timeSinceLastJump");
			Skateboard.NativeFieldInfoPtr_timeGrounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "timeGrounded");
			Skateboard.NativeFieldInfoPtr_timeAirborne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "timeAirborne");
			Skateboard.NativeFieldInfoPtr_jumpHeldTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "jumpHeldTime");
			Skateboard.NativeFieldInfoPtr_frontAxleForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "frontAxleForce");
			Skateboard.NativeFieldInfoPtr_rearAxleForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "rearAxleForce");
			Skateboard.NativeFieldInfoPtr_jumpForwardForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "jumpForwardForce");
			Skateboard.NativeFieldInfoPtr_hoverPIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "hoverPIDs");
			Skateboard.NativeFieldInfoPtr_pushQueued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "pushQueued");
			Skateboard.NativeFieldInfoPtr_isPushing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "isPushing");
			Skateboard.NativeFieldInfoPtr_thisFramePushForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "thisFramePushForce");
			Skateboard.NativeFieldInfoPtr_timeSincePushStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "timeSincePushStart");
			Skateboard.NativeFieldInfoPtr_braking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "braking");
			Skateboard.NativeFieldInfoPtr_syncVar____JumpBuildAmount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "syncVar___<JumpBuildAmount>k__BackingField");
			Skateboard.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Skating.SkateboardAssembly-CSharp.dll_Excuted");
			Skateboard.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Skating.SkateboardAssembly-CSharp.dll_Excuted");
			Skateboard.NativeMethodInfoPtr_get_CurrentSteerInput_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667189);
			Skateboard.NativeMethodInfoPtr_set_CurrentSteerInput_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667190);
			Skateboard.NativeMethodInfoPtr_get_IsPushing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667191);
			Skateboard.NativeMethodInfoPtr_get_TimeSincePushStart_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667192);
			Skateboard.NativeMethodInfoPtr_get_isGrounded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667193);
			Skateboard.NativeMethodInfoPtr_get_AirTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667194);
			Skateboard.NativeMethodInfoPtr_get_JumpBuildAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667195);
			Skateboard.NativeMethodInfoPtr_set_JumpBuildAmount_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667196);
			Skateboard.NativeMethodInfoPtr_get_Rider_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667197);
			Skateboard.NativeMethodInfoPtr_set_Rider_Private_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667198);
			Skateboard.NativeMethodInfoPtr_get_TopSpeed_Ms_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667199);
			Skateboard.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667200);
			Skateboard.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667201);
			Skateboard.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667202);
			Skateboard.NativeMethodInfoPtr_GetInput_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667203);
			Skateboard.NativeMethodInfoPtr_FixedUpdate_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667204);
			Skateboard.NativeMethodInfoPtr_LateUpdate_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667205);
			Skateboard.NativeMethodInfoPtr_ApplyInput_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667206);
			Skateboard.NativeMethodInfoPtr_ApplyLateralFriction_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667207);
			Skateboard.NativeMethodInfoPtr_UpdateHover_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667208);
			Skateboard.NativeMethodInfoPtr_ApplyGravity_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667209);
			Skateboard.NativeMethodInfoPtr_CheckGrounded_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667210);
			Skateboard.NativeMethodInfoPtr_CheckJump_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667211);
			Skateboard.NativeMethodInfoPtr_SendJump_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667212);
			Skateboard.NativeMethodInfoPtr_ReceiveJump_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667213);
			Skateboard.NativeMethodInfoPtr_Jump_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667214);
			Skateboard.NativeMethodInfoPtr_Push_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667215);
			Skateboard.NativeMethodInfoPtr_IsGrounded_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667216);
			Skateboard.NativeMethodInfoPtr_IsGrounded_Public_Boolean_byref_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667217);
			Skateboard.NativeMethodInfoPtr_SetVelocity_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667218);
			Skateboard.NativeMethodInfoPtr_ClampRotation_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667219);
			Skateboard.NativeMethodInfoPtr_ApplyPlayerScale_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667220);
			Skateboard.NativeMethodInfoPtr_GetSurfaceSmoothness_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667221);
			Skateboard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667222);
			Skateboard.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667223);
			Skateboard.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667224);
			Skateboard.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667225);
			Skateboard.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667226);
			Skateboard.NativeMethodInfoPtr_RpcWriter___Server_set_JumpBuildAmount_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667227);
			Skateboard.NativeMethodInfoPtr_RpcLogic___set_JumpBuildAmount_431000436_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667228);
			Skateboard.NativeMethodInfoPtr_RpcReader___Server_set_JumpBuildAmount_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667229);
			Skateboard.NativeMethodInfoPtr_RpcWriter___Server_SendJump_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667230);
			Skateboard.NativeMethodInfoPtr_RpcLogic___SendJump_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667231);
			Skateboard.NativeMethodInfoPtr_RpcReader___Server_SendJump_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667232);
			Skateboard.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveJump_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667233);
			Skateboard.NativeMethodInfoPtr_RpcLogic___ReceiveJump_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667234);
			Skateboard.NativeMethodInfoPtr_RpcReader___Observers_ReceiveJump_431000436_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667235);
			Skateboard.NativeMethodInfoPtr_sync___get_value__JumpBuildAmount_k__BackingField_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667236);
			Skateboard.NativeMethodInfoPtr_sync___set_value__JumpBuildAmount_k__BackingField_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667237);
			Skateboard.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Skating_Skateboard_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667238);
			Skateboard.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667239);
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x06002277 RID: 8823 RVA: 0x000DCEF8 File Offset: 0x000DB0F8
		// (set) Token: 0x06002278 RID: 8824 RVA: 0x000DCF34 File Offset: 0x000DB134
		public unsafe float CurrentSteerInput
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 86625, RefRangeEnd = 86627, XrefRangeStart = 86625, XrefRangeEnd = 86627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_get_CurrentSteerInput_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_set_CurrentSteerInput_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x06002279 RID: 8825 RVA: 0x000DCF74 File Offset: 0x000DB174
		public unsafe bool IsPushing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_get_IsPushing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x0600227A RID: 8826 RVA: 0x000DCFB0 File Offset: 0x000DB1B0
		public unsafe float TimeSincePushStart
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_get_TimeSincePushStart_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x0600227B RID: 8827 RVA: 0x000DCFEC File Offset: 0x000DB1EC
		public unsafe bool isGrounded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_get_isGrounded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x0600227C RID: 8828 RVA: 0x000DD028 File Offset: 0x000DB228
		public unsafe float AirTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_get_AirTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x0600227D RID: 8829 RVA: 0x000DD064 File Offset: 0x000DB264
		// (set) Token: 0x0600227E RID: 8830 RVA: 0x000DD0A0 File Offset: 0x000DB2A0
		public unsafe float JumpBuildAmount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_get_JumpBuildAmount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111853, XrefRangeEnd = 111882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_set_JumpBuildAmount_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x0600227F RID: 8831 RVA: 0x000DD0E0 File Offset: 0x000DB2E0
		// (set) Token: 0x06002280 RID: 8832 RVA: 0x000DD120 File Offset: 0x000DB320
		public unsafe Player Rider
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_get_Rider_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_set_Rider_Private_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x06002281 RID: 8833 RVA: 0x000DD164 File Offset: 0x000DB364
		public unsafe float TopSpeed_Ms
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_get_TopSpeed_Ms_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002282 RID: 8834 RVA: 0x000DD1A0 File Offset: 0x000DB3A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111882, XrefRangeEnd = 111883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Skateboard.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002283 RID: 8835 RVA: 0x000DD1DC File Offset: 0x000DB3DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111883, XrefRangeEnd = 111896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Skateboard.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002284 RID: 8836 RVA: 0x000DD218 File Offset: 0x000DB418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111896, XrefRangeEnd = 111899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002285 RID: 8837 RVA: 0x000DD24C File Offset: 0x000DB44C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111974, RefRangeEnd = 111975, XrefRangeStart = 111899, XrefRangeEnd = 111974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_GetInput_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002286 RID: 8838 RVA: 0x000DD280 File Offset: 0x000DB480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111975, XrefRangeEnd = 111993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_FixedUpdate_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002287 RID: 8839 RVA: 0x000DD2B4 File Offset: 0x000DB4B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111993, XrefRangeEnd = 111995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_LateUpdate_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002288 RID: 8840 RVA: 0x000DD2E8 File Offset: 0x000DB4E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112045, RefRangeEnd = 112046, XrefRangeStart = 111995, XrefRangeEnd = 112045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_ApplyInput_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002289 RID: 8841 RVA: 0x000DD31C File Offset: 0x000DB51C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112073, RefRangeEnd = 112074, XrefRangeStart = 112046, XrefRangeEnd = 112073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyLateralFriction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_ApplyLateralFriction_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600228A RID: 8842 RVA: 0x000DD350 File Offset: 0x000DB550
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112119, RefRangeEnd = 112120, XrefRangeStart = 112074, XrefRangeEnd = 112119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateHover()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_UpdateHover_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x000DD384 File Offset: 0x000DB584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112120, XrefRangeEnd = 112132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyGravity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_ApplyGravity_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600228C RID: 8844 RVA: 0x000DD3B8 File Offset: 0x000DB5B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112134, RefRangeEnd = 112135, XrefRangeStart = 112132, XrefRangeEnd = 112134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckGrounded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_CheckGrounded_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600228D RID: 8845 RVA: 0x000DD3EC File Offset: 0x000DB5EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112166, RefRangeEnd = 112167, XrefRangeStart = 112135, XrefRangeEnd = 112166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckJump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_CheckJump_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600228E RID: 8846 RVA: 0x000DD420 File Offset: 0x000DB620
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 112200, RefRangeEnd = 112202, XrefRangeStart = 112167, XrefRangeEnd = 112200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendJump(float jumpHeldTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref jumpHeldTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_SendJump_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x000DD460 File Offset: 0x000DB660
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 112224, RefRangeEnd = 112226, XrefRangeStart = 112202, XrefRangeEnd = 112224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveJump(float _jumpHeldTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _jumpHeldTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_ReceiveJump_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002290 RID: 8848 RVA: 0x000DD4A0 File Offset: 0x000DB6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112226, XrefRangeEnd = 112241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Jump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_Jump_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002291 RID: 8849 RVA: 0x000DD4D4 File Offset: 0x000DB6D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112241, XrefRangeEnd = 112248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_Push_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x000DD508 File Offset: 0x000DB708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112248, XrefRangeEnd = 112249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGrounded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_IsGrounded_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x000DD544 File Offset: 0x000DB744
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 112268, RefRangeEnd = 112273, XrefRangeStart = 112249, XrefRangeEnd = 112268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGrounded(out RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_IsGrounded_Public_Boolean_byref_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002294 RID: 8852 RVA: 0x000DD590 File Offset: 0x000DB790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112273, XrefRangeEnd = 112275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVelocity(Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_SetVelocity_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002295 RID: 8853 RVA: 0x000DD5D0 File Offset: 0x000DB7D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112308, RefRangeEnd = 112309, XrefRangeStart = 112275, XrefRangeEnd = 112308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClampRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_ClampRotation_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x000DD604 File Offset: 0x000DB804
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 112316, RefRangeEnd = 112318, XrefRangeStart = 112309, XrefRangeEnd = 112316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPlayerScale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_ApplyPlayerScale_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x000DD638 File Offset: 0x000DB838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112318, XrefRangeEnd = 112325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSurfaceSmoothness()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_GetSurfaceSmoothness_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002298 RID: 8856 RVA: 0x000DD674 File Offset: 0x000DB874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112325, XrefRangeEnd = 112333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Skateboard() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Skateboard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002299 RID: 8857 RVA: 0x000DD6B0 File Offset: 0x000DB8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112333, XrefRangeEnd = 112338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600229A RID: 8858 RVA: 0x000DD6F0 File Offset: 0x000DB8F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112338, XrefRangeEnd = 112374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Skateboard.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600229B RID: 8859 RVA: 0x000DD72C File Offset: 0x000DB92C
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Skateboard.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600229C RID: 8860 RVA: 0x000DD768 File Offset: 0x000DB968
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Skateboard.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600229D RID: 8861 RVA: 0x000DD7A4 File Offset: 0x000DB9A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_set_JumpBuildAmount_431000436(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcWriter___Server_set_JumpBuildAmount_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600229E RID: 8862 RVA: 0x000DD7E4 File Offset: 0x000DB9E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112374, XrefRangeEnd = 112381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___set_JumpBuildAmount_431000436(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcLogic___set_JumpBuildAmount_431000436_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600229F RID: 8863 RVA: 0x000DD824 File Offset: 0x000DBA24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112381, XrefRangeEnd = 112391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_set_JumpBuildAmount_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcReader___Server_set_JumpBuildAmount_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022A0 RID: 8864 RVA: 0x000DD888 File Offset: 0x000DBA88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112391, XrefRangeEnd = 112420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendJump_431000436(float jumpHeldTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref jumpHeldTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcWriter___Server_SendJump_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022A1 RID: 8865 RVA: 0x000DD8C8 File Offset: 0x000DBAC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 112224, RefRangeEnd = 112226, XrefRangeStart = 112224, XrefRangeEnd = 112226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendJump_431000436(float jumpHeldTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref jumpHeldTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcLogic___SendJump_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022A2 RID: 8866 RVA: 0x000DD908 File Offset: 0x000DBB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112420, XrefRangeEnd = 112425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendJump_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcReader___Server_SendJump_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022A3 RID: 8867 RVA: 0x000DD96C File Offset: 0x000DBB6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112425, XrefRangeEnd = 112444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveJump_431000436(float _jumpHeldTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _jumpHeldTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveJump_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022A4 RID: 8868 RVA: 0x000DD9AC File Offset: 0x000DBBAC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 112448, RefRangeEnd = 112451, XrefRangeStart = 112444, XrefRangeEnd = 112448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveJump_431000436(float _jumpHeldTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _jumpHeldTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcLogic___ReceiveJump_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022A5 RID: 8869 RVA: 0x000DD9EC File Offset: 0x000DBBEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112451, XrefRangeEnd = 112455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveJump_431000436(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcReader___Observers_ReceiveJump_431000436_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x060022A6 RID: 8870 RVA: 0x000DDA3C File Offset: 0x000DBC3C
		// (set) Token: 0x060022A7 RID: 8871 RVA: 0x000DDA78 File Offset: 0x000DBC78
		public unsafe float SyncAccessor_<JumpBuildAmount>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_sync___get_value__JumpBuildAmount_k__BackingField_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112455, XrefRangeEnd = 112463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_sync___set_value__JumpBuildAmount_k__BackingField_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022A8 RID: 8872 RVA: 0x000DDAC4 File Offset: 0x000DBCC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112463, XrefRangeEnd = 112464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Skating_Skateboard(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Skateboard.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Skating_Skateboard_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022A9 RID: 8873 RVA: 0x000DDB38 File Offset: 0x000DBD38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112488, RefRangeEnd = 112489, XrefRangeStart = 112464, XrefRangeEnd = 112488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022AA RID: 8874 RVA: 0x000133C7 File Offset: 0x000115C7
		public Skateboard(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x060022AB RID: 8875 RVA: 0x000DDB6C File Offset: 0x000DBD6C
		// (set) Token: 0x060022AC RID: 8876 RVA: 0x000133D0 File Offset: 0x000115D0
		public unsafe static float GroundedRaycastDistance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard.NativeFieldInfoPtr_GroundedRaycastDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard.NativeFieldInfoPtr_GroundedRaycastDistance, (void*)(&value));
			}
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x060022AD RID: 8877 RVA: 0x000DDB88 File Offset: 0x000DBD88
		// (set) Token: 0x060022AE RID: 8878 RVA: 0x000133DE File Offset: 0x000115DE
		public unsafe static float JumpCooldown
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard.NativeFieldInfoPtr_JumpCooldown, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard.NativeFieldInfoPtr_JumpCooldown, (void*)(&value));
			}
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x060022AF RID: 8879 RVA: 0x000DDBA4 File Offset: 0x000DBDA4
		// (set) Token: 0x060022B0 RID: 8880 RVA: 0x000133EC File Offset: 0x000115EC
		public unsafe static float JumpForceMin
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard.NativeFieldInfoPtr_JumpForceMin, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard.NativeFieldInfoPtr_JumpForceMin, (void*)(&value));
			}
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x060022B1 RID: 8881 RVA: 0x000DDBC0 File Offset: 0x000DBDC0
		// (set) Token: 0x060022B2 RID: 8882 RVA: 0x000133FA File Offset: 0x000115FA
		public unsafe static float JumpForceBuildTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard.NativeFieldInfoPtr_JumpForceBuildTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard.NativeFieldInfoPtr_JumpForceBuildTime, (void*)(&value));
			}
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x060022B3 RID: 8883 RVA: 0x000DDBDC File Offset: 0x000DBDDC
		// (set) Token: 0x060022B4 RID: 8884 RVA: 0x00013408 File Offset: 0x00011608
		public unsafe static float PushCooldown
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard.NativeFieldInfoPtr_PushCooldown, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard.NativeFieldInfoPtr_PushCooldown, (void*)(&value));
			}
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x060022B5 RID: 8885 RVA: 0x000DDBF8 File Offset: 0x000DBDF8
		// (set) Token: 0x060022B6 RID: 8886 RVA: 0x00013416 File Offset: 0x00011616
		public unsafe static float PushStaminaConsumption
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard.NativeFieldInfoPtr_PushStaminaConsumption, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard.NativeFieldInfoPtr_PushStaminaConsumption, (void*)(&value));
			}
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x060022B7 RID: 8887 RVA: 0x000DDC14 File Offset: 0x000DBE14
		// (set) Token: 0x060022B8 RID: 8888 RVA: 0x00013424 File Offset: 0x00011624
		public unsafe static float PitchLimit
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard.NativeFieldInfoPtr_PitchLimit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard.NativeFieldInfoPtr_PitchLimit, (void*)(&value));
			}
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x060022B9 RID: 8889 RVA: 0x000DDC30 File Offset: 0x000DBE30
		// (set) Token: 0x060022BA RID: 8890 RVA: 0x00013432 File Offset: 0x00011632
		public unsafe static float RollLimit
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard.NativeFieldInfoPtr_RollLimit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard.NativeFieldInfoPtr_RollLimit, (void*)(&value));
			}
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x060022BB RID: 8891 RVA: 0x000DDC4C File Offset: 0x000DBE4C
		// (set) Token: 0x060022BC RID: 8892 RVA: 0x00013440 File Offset: 0x00011640
		public unsafe float CurrentSpeed_Kmh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_CurrentSpeed_Kmh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_CurrentSpeed_Kmh)) = value;
			}
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x060022BD RID: 8893 RVA: 0x000DDC74 File Offset: 0x000DBE74
		// (set) Token: 0x060022BE RID: 8894 RVA: 0x0001345B File Offset: 0x0001165B
		public unsafe float _CurrentSteerInput_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr__CurrentSteerInput_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr__CurrentSteerInput_k__BackingField)) = value;
			}
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x060022BF RID: 8895 RVA: 0x000DDC9C File Offset: 0x000DBE9C
		// (set) Token: 0x060022C0 RID: 8896 RVA: 0x00013476 File Offset: 0x00011676
		public unsafe float _JumpBuildAmount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr__JumpBuildAmount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr__JumpBuildAmount_k__BackingField)) = value;
			}
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x060022C1 RID: 8897 RVA: 0x000DDCC4 File Offset: 0x000DBEC4
		// (set) Token: 0x060022C2 RID: 8898 RVA: 0x00013491 File Offset: 0x00011691
		public unsafe Player _Rider_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr__Rider_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr__Rider_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x060022C3 RID: 8899 RVA: 0x000DDCF4 File Offset: 0x000DBEF4
		// (set) Token: 0x060022C4 RID: 8900 RVA: 0x000134B0 File Offset: 0x000116B0
		public unsafe Rigidbody Rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x060022C5 RID: 8901 RVA: 0x000DDD24 File Offset: 0x000DBF24
		// (set) Token: 0x060022C6 RID: 8902 RVA: 0x000134CF File Offset: 0x000116CF
		public unsafe Transform CoM
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_CoM);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_CoM), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x060022C7 RID: 8903 RVA: 0x000DDD54 File Offset: 0x000DBF54
		// (set) Token: 0x060022C8 RID: 8904 RVA: 0x000134EE File Offset: 0x000116EE
		public unsafe Il2CppReferenceArray<Transform> HoverPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_HoverPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_HoverPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x060022C9 RID: 8905 RVA: 0x000DDD84 File Offset: 0x000DBF84
		// (set) Token: 0x060022CA RID: 8906 RVA: 0x0001350D File Offset: 0x0001170D
		public unsafe Transform FrontAxlePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_FrontAxlePosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_FrontAxlePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x060022CB RID: 8907 RVA: 0x000DDDB4 File Offset: 0x000DBFB4
		// (set) Token: 0x060022CC RID: 8908 RVA: 0x0001352C File Offset: 0x0001172C
		public unsafe Transform RearAxlePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_RearAxlePosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_RearAxlePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x060022CD RID: 8909 RVA: 0x000DDDE4 File Offset: 0x000DBFE4
		// (set) Token: 0x060022CE RID: 8910 RVA: 0x0001354B File Offset: 0x0001174B
		public unsafe Transform PlayerContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PlayerContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PlayerContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x060022CF RID: 8911 RVA: 0x000DDE14 File Offset: 0x000DC014
		// (set) Token: 0x060022D0 RID: 8912 RVA: 0x0001356A File Offset: 0x0001176A
		public unsafe SkateboardAnimation Animation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Animation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Animation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x060022D1 RID: 8913 RVA: 0x000DDE44 File Offset: 0x000DC044
		// (set) Token: 0x060022D2 RID: 8914 RVA: 0x00013589 File Offset: 0x00011789
		public unsafe SmoothedVelocityCalculator VelocityCalculator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_VelocityCalculator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_VelocityCalculator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x060022D3 RID: 8915 RVA: 0x000DDE74 File Offset: 0x000DC074
		// (set) Token: 0x060022D4 RID: 8916 RVA: 0x000135A8 File Offset: 0x000117A8
		public unsafe AverageAcceleration Accelerometer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Accelerometer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AverageAcceleration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Accelerometer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x060022D5 RID: 8917 RVA: 0x000DDEA4 File Offset: 0x000DC0A4
		// (set) Token: 0x060022D6 RID: 8918 RVA: 0x000135C7 File Offset: 0x000117C7
		public unsafe Skateboard_Equippable Equippable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Equippable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard_Equippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Equippable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x060022D7 RID: 8919 RVA: 0x000DDED4 File Offset: 0x000DC0D4
		// (set) Token: 0x060022D8 RID: 8920 RVA: 0x000135E6 File Offset: 0x000117E6
		public unsafe Transform IKAlignmentsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_IKAlignmentsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_IKAlignmentsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x060022D9 RID: 8921 RVA: 0x000DDF04 File Offset: 0x000DC104
		// (set) Token: 0x060022DA RID: 8922 RVA: 0x00013605 File Offset: 0x00011805
		public unsafe float TurnForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnForce)) = value;
			}
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x060022DB RID: 8923 RVA: 0x000DDF2C File Offset: 0x000DC12C
		// (set) Token: 0x060022DC RID: 8924 RVA: 0x00013620 File Offset: 0x00011820
		public unsafe float TurnChangeRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnChangeRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnChangeRate)) = value;
			}
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x060022DD RID: 8925 RVA: 0x000DDF54 File Offset: 0x000DC154
		// (set) Token: 0x060022DE RID: 8926 RVA: 0x0001363B File Offset: 0x0001183B
		public unsafe float TurnReturnToRestRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnReturnToRestRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnReturnToRestRate)) = value;
			}
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x060022DF RID: 8927 RVA: 0x000DDF7C File Offset: 0x000DC17C
		// (set) Token: 0x060022E0 RID: 8928 RVA: 0x00013656 File Offset: 0x00011856
		public unsafe float TurnSpeedBoost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnSpeedBoost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnSpeedBoost)) = value;
			}
		}

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x060022E1 RID: 8929 RVA: 0x000DDFA4 File Offset: 0x000DC1A4
		// (set) Token: 0x060022E2 RID: 8930 RVA: 0x00013671 File Offset: 0x00011871
		public unsafe AnimationCurve TurnForceMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnForceMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnForceMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x060022E3 RID: 8931 RVA: 0x000DDFD4 File Offset: 0x000DC1D4
		// (set) Token: 0x060022E4 RID: 8932 RVA: 0x00013690 File Offset: 0x00011890
		public unsafe float Gravity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Gravity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Gravity)) = value;
			}
		}

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x060022E5 RID: 8933 RVA: 0x000DDFFC File Offset: 0x000DC1FC
		// (set) Token: 0x060022E6 RID: 8934 RVA: 0x000136AB File Offset: 0x000118AB
		public unsafe float BrakeForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_BrakeForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_BrakeForce)) = value;
			}
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x060022E7 RID: 8935 RVA: 0x000DE024 File Offset: 0x000DC224
		// (set) Token: 0x060022E8 RID: 8936 RVA: 0x000136C6 File Offset: 0x000118C6
		public unsafe float ReverseTopSpeed_Kmh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_ReverseTopSpeed_Kmh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_ReverseTopSpeed_Kmh)) = value;
			}
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x060022E9 RID: 8937 RVA: 0x000DE04C File Offset: 0x000DC24C
		// (set) Token: 0x060022EA RID: 8938 RVA: 0x000136E1 File Offset: 0x000118E1
		public unsafe LayerMask GroundDetectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_GroundDetectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_GroundDetectionMask)) = value;
			}
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x060022EB RID: 8939 RVA: 0x000DE074 File Offset: 0x000DC274
		// (set) Token: 0x060022EC RID: 8940 RVA: 0x000136FC File Offset: 0x000118FC
		public unsafe Il2CppReferenceArray<Collider> MainColliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_MainColliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_MainColliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x060022ED RID: 8941 RVA: 0x000DE0A4 File Offset: 0x000DC2A4
		// (set) Token: 0x060022EE RID: 8942 RVA: 0x0001371B File Offset: 0x0001191B
		public unsafe float RotationClampForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_RotationClampForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_RotationClampForce)) = value;
			}
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x060022EF RID: 8943 RVA: 0x000DE0CC File Offset: 0x000DC2CC
		// (set) Token: 0x060022F0 RID: 8944 RVA: 0x00013736 File Offset: 0x00011936
		public unsafe bool FrictionEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_FrictionEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_FrictionEnabled)) = value;
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x060022F1 RID: 8945 RVA: 0x000DE0F4 File Offset: 0x000DC2F4
		// (set) Token: 0x060022F2 RID: 8946 RVA: 0x00013751 File Offset: 0x00011951
		public unsafe AnimationCurve LongitudinalFrictionCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_LongitudinalFrictionCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_LongitudinalFrictionCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x060022F3 RID: 8947 RVA: 0x000DE124 File Offset: 0x000DC324
		// (set) Token: 0x060022F4 RID: 8948 RVA: 0x00013770 File Offset: 0x00011970
		public unsafe float LongitudinalFrictionMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_LongitudinalFrictionMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_LongitudinalFrictionMultiplier)) = value;
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x060022F5 RID: 8949 RVA: 0x000DE14C File Offset: 0x000DC34C
		// (set) Token: 0x060022F6 RID: 8950 RVA: 0x0001378B File Offset: 0x0001198B
		public unsafe float LateralFrictionForceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_LateralFrictionForceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_LateralFrictionForceMultiplier)) = value;
			}
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x060022F7 RID: 8951 RVA: 0x000DE174 File Offset: 0x000DC374
		// (set) Token: 0x060022F8 RID: 8952 RVA: 0x000137A6 File Offset: 0x000119A6
		public unsafe float JumpForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpForce)) = value;
			}
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x060022F9 RID: 8953 RVA: 0x000DE19C File Offset: 0x000DC39C
		// (set) Token: 0x060022FA RID: 8954 RVA: 0x000137C1 File Offset: 0x000119C1
		public unsafe float JumpDuration_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpDuration_Min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpDuration_Min)) = value;
			}
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x060022FB RID: 8955 RVA: 0x000DE1C4 File Offset: 0x000DC3C4
		// (set) Token: 0x060022FC RID: 8956 RVA: 0x000137DC File Offset: 0x000119DC
		public unsafe float JumpDuration_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpDuration_Max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpDuration_Max)) = value;
			}
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x060022FD RID: 8957 RVA: 0x000DE1EC File Offset: 0x000DC3EC
		// (set) Token: 0x060022FE RID: 8958 RVA: 0x000137F7 File Offset: 0x000119F7
		public unsafe AnimationCurve FrontAxleJumpCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_FrontAxleJumpCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_FrontAxleJumpCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x060022FF RID: 8959 RVA: 0x000DE21C File Offset: 0x000DC41C
		// (set) Token: 0x06002300 RID: 8960 RVA: 0x00013816 File Offset: 0x00011A16
		public unsafe AnimationCurve RearAxleJumpCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_RearAxleJumpCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_RearAxleJumpCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x06002301 RID: 8961 RVA: 0x000DE24C File Offset: 0x000DC44C
		// (set) Token: 0x06002302 RID: 8962 RVA: 0x00013835 File Offset: 0x00011A35
		public unsafe AnimationCurve JumpForwardForceCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpForwardForceCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpForwardForceCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x06002303 RID: 8963 RVA: 0x000DE27C File Offset: 0x000DC47C
		// (set) Token: 0x06002304 RID: 8964 RVA: 0x00013854 File Offset: 0x00011A54
		public unsafe float JumpForwardBoost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpForwardBoost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpForwardBoost)) = value;
			}
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x06002305 RID: 8965 RVA: 0x000DE2A4 File Offset: 0x000DC4A4
		// (set) Token: 0x06002306 RID: 8966 RVA: 0x0001386F File Offset: 0x00011A6F
		public unsafe float HoverForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_HoverForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_HoverForce)) = value;
			}
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x06002307 RID: 8967 RVA: 0x000DE2CC File Offset: 0x000DC4CC
		// (set) Token: 0x06002308 RID: 8968 RVA: 0x0001388A File Offset: 0x00011A8A
		public unsafe float HoverRayLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_HoverRayLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_HoverRayLength)) = value;
			}
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x06002309 RID: 8969 RVA: 0x000DE2F4 File Offset: 0x000DC4F4
		// (set) Token: 0x0600230A RID: 8970 RVA: 0x000138A5 File Offset: 0x00011AA5
		public unsafe float HoverHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_HoverHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_HoverHeight)) = value;
			}
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x0600230B RID: 8971 RVA: 0x000DE31C File Offset: 0x000DC51C
		// (set) Token: 0x0600230C RID: 8972 RVA: 0x000138C0 File Offset: 0x00011AC0
		public unsafe float Hover_P
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Hover_P);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Hover_P)) = value;
			}
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x0600230D RID: 8973 RVA: 0x000DE344 File Offset: 0x000DC544
		// (set) Token: 0x0600230E RID: 8974 RVA: 0x000138DB File Offset: 0x00011ADB
		public unsafe float Hover_I
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Hover_I);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Hover_I)) = value;
			}
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x0600230F RID: 8975 RVA: 0x000DE36C File Offset: 0x000DC56C
		// (set) Token: 0x06002310 RID: 8976 RVA: 0x000138F6 File Offset: 0x00011AF6
		public unsafe float Hover_D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Hover_D);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Hover_D)) = value;
			}
		}

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x06002311 RID: 8977 RVA: 0x000DE394 File Offset: 0x000DC594
		// (set) Token: 0x06002312 RID: 8978 RVA: 0x00013911 File Offset: 0x00011B11
		public unsafe float TopSpeed_Kmh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TopSpeed_Kmh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TopSpeed_Kmh)) = value;
			}
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x06002313 RID: 8979 RVA: 0x000DE3BC File Offset: 0x000DC5BC
		// (set) Token: 0x06002314 RID: 8980 RVA: 0x0001392C File Offset: 0x00011B2C
		public unsafe float PushForceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushForceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushForceMultiplier)) = value;
			}
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x06002315 RID: 8981 RVA: 0x000DE3E4 File Offset: 0x000DC5E4
		// (set) Token: 0x06002316 RID: 8982 RVA: 0x00013947 File Offset: 0x00011B47
		public unsafe AnimationCurve PushForceMultiplierMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushForceMultiplierMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushForceMultiplierMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x06002317 RID: 8983 RVA: 0x000DE414 File Offset: 0x000DC614
		// (set) Token: 0x06002318 RID: 8984 RVA: 0x00013966 File Offset: 0x00011B66
		public unsafe float PushForceDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushForceDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushForceDuration)) = value;
			}
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x06002319 RID: 8985 RVA: 0x000DE43C File Offset: 0x000DC63C
		// (set) Token: 0x0600231A RID: 8986 RVA: 0x00013981 File Offset: 0x00011B81
		public unsafe float PushDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushDelay)) = value;
			}
		}

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x0600231B RID: 8987 RVA: 0x000DE464 File Offset: 0x000DC664
		// (set) Token: 0x0600231C RID: 8988 RVA: 0x0001399C File Offset: 0x00011B9C
		public unsafe AnimationCurve PushForceCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushForceCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushForceCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x0600231D RID: 8989 RVA: 0x000DE494 File Offset: 0x000DC694
		// (set) Token: 0x0600231E RID: 8990 RVA: 0x000139BB File Offset: 0x00011BBB
		public unsafe bool AirMovementEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_AirMovementEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_AirMovementEnabled)) = value;
			}
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x0600231F RID: 8991 RVA: 0x000DE4BC File Offset: 0x000DC6BC
		// (set) Token: 0x06002320 RID: 8992 RVA: 0x000139D6 File Offset: 0x00011BD6
		public unsafe float AirMovementForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_AirMovementForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_AirMovementForce)) = value;
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x06002321 RID: 8993 RVA: 0x000DE4E4 File Offset: 0x000DC6E4
		// (set) Token: 0x06002322 RID: 8994 RVA: 0x000139F1 File Offset: 0x00011BF1
		public unsafe float AirMovementJumpReductionDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_AirMovementJumpReductionDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_AirMovementJumpReductionDuration)) = value;
			}
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x06002323 RID: 8995 RVA: 0x000DE50C File Offset: 0x000DC70C
		// (set) Token: 0x06002324 RID: 8996 RVA: 0x00013A0C File Offset: 0x00011C0C
		public unsafe AnimationCurve AirMovementJumpReductionCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_AirMovementJumpReductionCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_AirMovementJumpReductionCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x06002325 RID: 8997 RVA: 0x000DE53C File Offset: 0x000DC73C
		// (set) Token: 0x06002326 RID: 8998 RVA: 0x00013A2B File Offset: 0x00011C2B
		public unsafe UnityEvent OnPushStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_OnPushStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_OnPushStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x06002327 RID: 8999 RVA: 0x000DE56C File Offset: 0x000DC76C
		// (set) Token: 0x06002328 RID: 9000 RVA: 0x00013A4A File Offset: 0x00011C4A
		public unsafe UnityEvent<float> OnJump
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_OnJump);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_OnJump), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x06002329 RID: 9001 RVA: 0x000DE59C File Offset: 0x000DC79C
		// (set) Token: 0x0600232A RID: 9002 RVA: 0x00013A69 File Offset: 0x00011C69
		public unsafe UnityEvent OnLand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_OnLand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_OnLand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x0600232B RID: 9003 RVA: 0x000DE5CC File Offset: 0x000DC7CC
		// (set) Token: 0x0600232C RID: 9004 RVA: 0x00013A88 File Offset: 0x00011C88
		public unsafe int horizontalInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_horizontalInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_horizontalInput)) = value;
			}
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x0600232D RID: 9005 RVA: 0x000DE5F4 File Offset: 0x000DC7F4
		// (set) Token: 0x0600232E RID: 9006 RVA: 0x00013AA3 File Offset: 0x00011CA3
		public unsafe bool jumpReleased
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_jumpReleased);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_jumpReleased)) = value;
			}
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x0600232F RID: 9007 RVA: 0x000DE61C File Offset: 0x000DC81C
		// (set) Token: 0x06002330 RID: 9008 RVA: 0x00013ABE File Offset: 0x00011CBE
		public unsafe float timeSinceLastJump
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_timeSinceLastJump);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_timeSinceLastJump)) = value;
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x06002331 RID: 9009 RVA: 0x000DE644 File Offset: 0x000DC844
		// (set) Token: 0x06002332 RID: 9010 RVA: 0x00013AD9 File Offset: 0x00011CD9
		public unsafe float timeGrounded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_timeGrounded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_timeGrounded)) = value;
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x06002333 RID: 9011 RVA: 0x000DE66C File Offset: 0x000DC86C
		// (set) Token: 0x06002334 RID: 9012 RVA: 0x00013AF4 File Offset: 0x00011CF4
		public unsafe float timeAirborne
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_timeAirborne);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_timeAirborne)) = value;
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x06002335 RID: 9013 RVA: 0x000DE694 File Offset: 0x000DC894
		// (set) Token: 0x06002336 RID: 9014 RVA: 0x00013B0F File Offset: 0x00011D0F
		public unsafe float jumpHeldTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_jumpHeldTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_jumpHeldTime)) = value;
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x06002337 RID: 9015 RVA: 0x000DE6BC File Offset: 0x000DC8BC
		// (set) Token: 0x06002338 RID: 9016 RVA: 0x00013B2A File Offset: 0x00011D2A
		public unsafe float frontAxleForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_frontAxleForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_frontAxleForce)) = value;
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x06002339 RID: 9017 RVA: 0x000DE6E4 File Offset: 0x000DC8E4
		// (set) Token: 0x0600233A RID: 9018 RVA: 0x00013B45 File Offset: 0x00011D45
		public unsafe float rearAxleForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_rearAxleForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_rearAxleForce)) = value;
			}
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x0600233B RID: 9019 RVA: 0x000DE70C File Offset: 0x000DC90C
		// (set) Token: 0x0600233C RID: 9020 RVA: 0x00013B60 File Offset: 0x00011D60
		public unsafe float jumpForwardForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_jumpForwardForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_jumpForwardForce)) = value;
			}
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x0600233D RID: 9021 RVA: 0x000DE734 File Offset: 0x000DC934
		// (set) Token: 0x0600233E RID: 9022 RVA: 0x00013B7B File Offset: 0x00011D7B
		public unsafe List<PID> hoverPIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_hoverPIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_hoverPIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x0600233F RID: 9023 RVA: 0x000DE764 File Offset: 0x000DC964
		// (set) Token: 0x06002340 RID: 9024 RVA: 0x00013B9A File Offset: 0x00011D9A
		public unsafe bool pushQueued
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_pushQueued);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_pushQueued)) = value;
			}
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x06002341 RID: 9025 RVA: 0x000DE78C File Offset: 0x000DC98C
		// (set) Token: 0x06002342 RID: 9026 RVA: 0x00013BB5 File Offset: 0x00011DB5
		public unsafe bool isPushing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_isPushing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_isPushing)) = value;
			}
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x06002343 RID: 9027 RVA: 0x000DE7B4 File Offset: 0x000DC9B4
		// (set) Token: 0x06002344 RID: 9028 RVA: 0x00013BD0 File Offset: 0x00011DD0
		public unsafe float thisFramePushForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_thisFramePushForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_thisFramePushForce)) = value;
			}
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x06002345 RID: 9029 RVA: 0x000DE7DC File Offset: 0x000DC9DC
		// (set) Token: 0x06002346 RID: 9030 RVA: 0x00013BEB File Offset: 0x00011DEB
		public unsafe float timeSincePushStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_timeSincePushStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_timeSincePushStart)) = value;
			}
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x06002347 RID: 9031 RVA: 0x000DE804 File Offset: 0x000DCA04
		// (set) Token: 0x06002348 RID: 9032 RVA: 0x00013C06 File Offset: 0x00011E06
		public unsafe bool braking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_braking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_braking)) = value;
			}
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x06002349 RID: 9033 RVA: 0x000DE82C File Offset: 0x000DCA2C
		// (set) Token: 0x0600234A RID: 9034 RVA: 0x00013C21 File Offset: 0x00011E21
		public unsafe SyncVar<float> syncVar____JumpBuildAmount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_syncVar____JumpBuildAmount_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_syncVar____JumpBuildAmount_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x0600234B RID: 9035 RVA: 0x000DE85C File Offset: 0x000DCA5C
		// (set) Token: 0x0600234C RID: 9036 RVA: 0x00013C40 File Offset: 0x00011E40
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x0600234D RID: 9037 RVA: 0x000DE884 File Offset: 0x000DCA84
		// (set) Token: 0x0600234E RID: 9038 RVA: 0x00013C5B File Offset: 0x00011E5B
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040016F1 RID: 5873
		private static readonly IntPtr NativeFieldInfoPtr_GroundedRaycastDistance;

		// Token: 0x040016F2 RID: 5874
		private static readonly IntPtr NativeFieldInfoPtr_JumpCooldown;

		// Token: 0x040016F3 RID: 5875
		private static readonly IntPtr NativeFieldInfoPtr_JumpForceMin;

		// Token: 0x040016F4 RID: 5876
		private static readonly IntPtr NativeFieldInfoPtr_JumpForceBuildTime;

		// Token: 0x040016F5 RID: 5877
		private static readonly IntPtr NativeFieldInfoPtr_PushCooldown;

		// Token: 0x040016F6 RID: 5878
		private static readonly IntPtr NativeFieldInfoPtr_PushStaminaConsumption;

		// Token: 0x040016F7 RID: 5879
		private static readonly IntPtr NativeFieldInfoPtr_PitchLimit;

		// Token: 0x040016F8 RID: 5880
		private static readonly IntPtr NativeFieldInfoPtr_RollLimit;

		// Token: 0x040016F9 RID: 5881
		private static readonly IntPtr NativeFieldInfoPtr_CurrentSpeed_Kmh;

		// Token: 0x040016FA RID: 5882
		private static readonly IntPtr NativeFieldInfoPtr__CurrentSteerInput_k__BackingField;

		// Token: 0x040016FB RID: 5883
		private static readonly IntPtr NativeFieldInfoPtr__JumpBuildAmount_k__BackingField;

		// Token: 0x040016FC RID: 5884
		private static readonly IntPtr NativeFieldInfoPtr__Rider_k__BackingField;

		// Token: 0x040016FD RID: 5885
		private static readonly IntPtr NativeFieldInfoPtr_Rb;

		// Token: 0x040016FE RID: 5886
		private static readonly IntPtr NativeFieldInfoPtr_CoM;

		// Token: 0x040016FF RID: 5887
		private static readonly IntPtr NativeFieldInfoPtr_HoverPoints;

		// Token: 0x04001700 RID: 5888
		private static readonly IntPtr NativeFieldInfoPtr_FrontAxlePosition;

		// Token: 0x04001701 RID: 5889
		private static readonly IntPtr NativeFieldInfoPtr_RearAxlePosition;

		// Token: 0x04001702 RID: 5890
		private static readonly IntPtr NativeFieldInfoPtr_PlayerContainer;

		// Token: 0x04001703 RID: 5891
		private static readonly IntPtr NativeFieldInfoPtr_Animation;

		// Token: 0x04001704 RID: 5892
		private static readonly IntPtr NativeFieldInfoPtr_VelocityCalculator;

		// Token: 0x04001705 RID: 5893
		private static readonly IntPtr NativeFieldInfoPtr_Accelerometer;

		// Token: 0x04001706 RID: 5894
		private static readonly IntPtr NativeFieldInfoPtr_Equippable;

		// Token: 0x04001707 RID: 5895
		private static readonly IntPtr NativeFieldInfoPtr_IKAlignmentsContainer;

		// Token: 0x04001708 RID: 5896
		private static readonly IntPtr NativeFieldInfoPtr_TurnForce;

		// Token: 0x04001709 RID: 5897
		private static readonly IntPtr NativeFieldInfoPtr_TurnChangeRate;

		// Token: 0x0400170A RID: 5898
		private static readonly IntPtr NativeFieldInfoPtr_TurnReturnToRestRate;

		// Token: 0x0400170B RID: 5899
		private static readonly IntPtr NativeFieldInfoPtr_TurnSpeedBoost;

		// Token: 0x0400170C RID: 5900
		private static readonly IntPtr NativeFieldInfoPtr_TurnForceMap;

		// Token: 0x0400170D RID: 5901
		private static readonly IntPtr NativeFieldInfoPtr_Gravity;

		// Token: 0x0400170E RID: 5902
		private static readonly IntPtr NativeFieldInfoPtr_BrakeForce;

		// Token: 0x0400170F RID: 5903
		private static readonly IntPtr NativeFieldInfoPtr_ReverseTopSpeed_Kmh;

		// Token: 0x04001710 RID: 5904
		private static readonly IntPtr NativeFieldInfoPtr_GroundDetectionMask;

		// Token: 0x04001711 RID: 5905
		private static readonly IntPtr NativeFieldInfoPtr_MainColliders;

		// Token: 0x04001712 RID: 5906
		private static readonly IntPtr NativeFieldInfoPtr_RotationClampForce;

		// Token: 0x04001713 RID: 5907
		private static readonly IntPtr NativeFieldInfoPtr_FrictionEnabled;

		// Token: 0x04001714 RID: 5908
		private static readonly IntPtr NativeFieldInfoPtr_LongitudinalFrictionCurve;

		// Token: 0x04001715 RID: 5909
		private static readonly IntPtr NativeFieldInfoPtr_LongitudinalFrictionMultiplier;

		// Token: 0x04001716 RID: 5910
		private static readonly IntPtr NativeFieldInfoPtr_LateralFrictionForceMultiplier;

		// Token: 0x04001717 RID: 5911
		private static readonly IntPtr NativeFieldInfoPtr_JumpForce;

		// Token: 0x04001718 RID: 5912
		private static readonly IntPtr NativeFieldInfoPtr_JumpDuration_Min;

		// Token: 0x04001719 RID: 5913
		private static readonly IntPtr NativeFieldInfoPtr_JumpDuration_Max;

		// Token: 0x0400171A RID: 5914
		private static readonly IntPtr NativeFieldInfoPtr_FrontAxleJumpCurve;

		// Token: 0x0400171B RID: 5915
		private static readonly IntPtr NativeFieldInfoPtr_RearAxleJumpCurve;

		// Token: 0x0400171C RID: 5916
		private static readonly IntPtr NativeFieldInfoPtr_JumpForwardForceCurve;

		// Token: 0x0400171D RID: 5917
		private static readonly IntPtr NativeFieldInfoPtr_JumpForwardBoost;

		// Token: 0x0400171E RID: 5918
		private static readonly IntPtr NativeFieldInfoPtr_HoverForce;

		// Token: 0x0400171F RID: 5919
		private static readonly IntPtr NativeFieldInfoPtr_HoverRayLength;

		// Token: 0x04001720 RID: 5920
		private static readonly IntPtr NativeFieldInfoPtr_HoverHeight;

		// Token: 0x04001721 RID: 5921
		private static readonly IntPtr NativeFieldInfoPtr_Hover_P;

		// Token: 0x04001722 RID: 5922
		private static readonly IntPtr NativeFieldInfoPtr_Hover_I;

		// Token: 0x04001723 RID: 5923
		private static readonly IntPtr NativeFieldInfoPtr_Hover_D;

		// Token: 0x04001724 RID: 5924
		private static readonly IntPtr NativeFieldInfoPtr_TopSpeed_Kmh;

		// Token: 0x04001725 RID: 5925
		private static readonly IntPtr NativeFieldInfoPtr_PushForceMultiplier;

		// Token: 0x04001726 RID: 5926
		private static readonly IntPtr NativeFieldInfoPtr_PushForceMultiplierMap;

		// Token: 0x04001727 RID: 5927
		private static readonly IntPtr NativeFieldInfoPtr_PushForceDuration;

		// Token: 0x04001728 RID: 5928
		private static readonly IntPtr NativeFieldInfoPtr_PushDelay;

		// Token: 0x04001729 RID: 5929
		private static readonly IntPtr NativeFieldInfoPtr_PushForceCurve;

		// Token: 0x0400172A RID: 5930
		private static readonly IntPtr NativeFieldInfoPtr_AirMovementEnabled;

		// Token: 0x0400172B RID: 5931
		private static readonly IntPtr NativeFieldInfoPtr_AirMovementForce;

		// Token: 0x0400172C RID: 5932
		private static readonly IntPtr NativeFieldInfoPtr_AirMovementJumpReductionDuration;

		// Token: 0x0400172D RID: 5933
		private static readonly IntPtr NativeFieldInfoPtr_AirMovementJumpReductionCurve;

		// Token: 0x0400172E RID: 5934
		private static readonly IntPtr NativeFieldInfoPtr_OnPushStart;

		// Token: 0x0400172F RID: 5935
		private static readonly IntPtr NativeFieldInfoPtr_OnJump;

		// Token: 0x04001730 RID: 5936
		private static readonly IntPtr NativeFieldInfoPtr_OnLand;

		// Token: 0x04001731 RID: 5937
		private static readonly IntPtr NativeFieldInfoPtr_horizontalInput;

		// Token: 0x04001732 RID: 5938
		private static readonly IntPtr NativeFieldInfoPtr_jumpReleased;

		// Token: 0x04001733 RID: 5939
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastJump;

		// Token: 0x04001734 RID: 5940
		private static readonly IntPtr NativeFieldInfoPtr_timeGrounded;

		// Token: 0x04001735 RID: 5941
		private static readonly IntPtr NativeFieldInfoPtr_timeAirborne;

		// Token: 0x04001736 RID: 5942
		private static readonly IntPtr NativeFieldInfoPtr_jumpHeldTime;

		// Token: 0x04001737 RID: 5943
		private static readonly IntPtr NativeFieldInfoPtr_frontAxleForce;

		// Token: 0x04001738 RID: 5944
		private static readonly IntPtr NativeFieldInfoPtr_rearAxleForce;

		// Token: 0x04001739 RID: 5945
		private static readonly IntPtr NativeFieldInfoPtr_jumpForwardForce;

		// Token: 0x0400173A RID: 5946
		private static readonly IntPtr NativeFieldInfoPtr_hoverPIDs;

		// Token: 0x0400173B RID: 5947
		private static readonly IntPtr NativeFieldInfoPtr_pushQueued;

		// Token: 0x0400173C RID: 5948
		private static readonly IntPtr NativeFieldInfoPtr_isPushing;

		// Token: 0x0400173D RID: 5949
		private static readonly IntPtr NativeFieldInfoPtr_thisFramePushForce;

		// Token: 0x0400173E RID: 5950
		private static readonly IntPtr NativeFieldInfoPtr_timeSincePushStart;

		// Token: 0x0400173F RID: 5951
		private static readonly IntPtr NativeFieldInfoPtr_braking;

		// Token: 0x04001740 RID: 5952
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____JumpBuildAmount_k__BackingField;

		// Token: 0x04001741 RID: 5953
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04001742 RID: 5954
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04001743 RID: 5955
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSteerInput_Public_get_Single_0;

		// Token: 0x04001744 RID: 5956
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentSteerInput_Protected_set_Void_Single_0;

		// Token: 0x04001745 RID: 5957
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPushing_Public_get_Boolean_0;

		// Token: 0x04001746 RID: 5958
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSincePushStart_Public_get_Single_0;

		// Token: 0x04001747 RID: 5959
		private static readonly IntPtr NativeMethodInfoPtr_get_isGrounded_Public_get_Boolean_0;

		// Token: 0x04001748 RID: 5960
		private static readonly IntPtr NativeMethodInfoPtr_get_AirTime_Public_get_Single_0;

		// Token: 0x04001749 RID: 5961
		private static readonly IntPtr NativeMethodInfoPtr_get_JumpBuildAmount_Public_get_Single_0;

		// Token: 0x0400174A RID: 5962
		private static readonly IntPtr NativeMethodInfoPtr_set_JumpBuildAmount_Public_set_Void_Single_0;

		// Token: 0x0400174B RID: 5963
		private static readonly IntPtr NativeMethodInfoPtr_get_Rider_Public_get_Player_0;

		// Token: 0x0400174C RID: 5964
		private static readonly IntPtr NativeMethodInfoPtr_set_Rider_Private_set_Void_Player_0;

		// Token: 0x0400174D RID: 5965
		private static readonly IntPtr NativeMethodInfoPtr_get_TopSpeed_Ms_Public_get_Single_0;

		// Token: 0x0400174E RID: 5966
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400174F RID: 5967
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x04001750 RID: 5968
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04001751 RID: 5969
		private static readonly IntPtr NativeMethodInfoPtr_GetInput_Private_Void_1;

		// Token: 0x04001752 RID: 5970
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_1;

		// Token: 0x04001753 RID: 5971
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_1;

		// Token: 0x04001754 RID: 5972
		private static readonly IntPtr NativeMethodInfoPtr_ApplyInput_Private_Void_1;

		// Token: 0x04001755 RID: 5973
		private static readonly IntPtr NativeMethodInfoPtr_ApplyLateralFriction_Private_Void_1;

		// Token: 0x04001756 RID: 5974
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHover_Private_Void_1;

		// Token: 0x04001757 RID: 5975
		private static readonly IntPtr NativeMethodInfoPtr_ApplyGravity_Private_Void_1;

		// Token: 0x04001758 RID: 5976
		private static readonly IntPtr NativeMethodInfoPtr_CheckGrounded_Private_Void_1;

		// Token: 0x04001759 RID: 5977
		private static readonly IntPtr NativeMethodInfoPtr_CheckJump_Private_Void_1;

		// Token: 0x0400175A RID: 5978
		private static readonly IntPtr NativeMethodInfoPtr_SendJump_Private_Void_Single_0;

		// Token: 0x0400175B RID: 5979
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveJump_Private_Void_Single_0;

		// Token: 0x0400175C RID: 5980
		private static readonly IntPtr NativeMethodInfoPtr_Jump_Private_Void_1;

		// Token: 0x0400175D RID: 5981
		private static readonly IntPtr NativeMethodInfoPtr_Push_Private_Void_1;

		// Token: 0x0400175E RID: 5982
		private static readonly IntPtr NativeMethodInfoPtr_IsGrounded_Public_Boolean_0;

		// Token: 0x0400175F RID: 5983
		private static readonly IntPtr NativeMethodInfoPtr_IsGrounded_Public_Boolean_byref_RaycastHit_0;

		// Token: 0x04001760 RID: 5984
		private static readonly IntPtr NativeMethodInfoPtr_SetVelocity_Public_Void_Vector3_0;

		// Token: 0x04001761 RID: 5985
		private static readonly IntPtr NativeMethodInfoPtr_ClampRotation_Private_Void_1;

		// Token: 0x04001762 RID: 5986
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPlayerScale_Public_Void_0;

		// Token: 0x04001763 RID: 5987
		private static readonly IntPtr NativeMethodInfoPtr_GetSurfaceSmoothness_Public_Single_0;

		// Token: 0x04001764 RID: 5988
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001765 RID: 5989
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04001766 RID: 5990
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04001767 RID: 5991
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04001768 RID: 5992
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04001769 RID: 5993
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_JumpBuildAmount_431000436_Private_Void_Single_0;

		// Token: 0x0400176A RID: 5994
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___set_JumpBuildAmount_431000436_Public_Void_Single_0;

		// Token: 0x0400176B RID: 5995
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_set_JumpBuildAmount_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400176C RID: 5996
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendJump_431000436_Private_Void_Single_0;

		// Token: 0x0400176D RID: 5997
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendJump_431000436_Private_Void_Single_0;

		// Token: 0x0400176E RID: 5998
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendJump_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400176F RID: 5999
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveJump_431000436_Private_Void_Single_0;

		// Token: 0x04001770 RID: 6000
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveJump_431000436_Private_Void_Single_0;

		// Token: 0x04001771 RID: 6001
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveJump_431000436_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001772 RID: 6002
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__JumpBuildAmount_k__BackingField_Public_get_Single_0;

		// Token: 0x04001773 RID: 6003
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__JumpBuildAmount_k__BackingField_Public_set_Void_Single_Boolean_0;

		// Token: 0x04001774 RID: 6004
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Skating_Skateboard_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04001775 RID: 6005
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;

		// Token: 0x020008C8 RID: 2248
		[ObfuscatedName("ScheduleOne.Skating.Skateboard+<<Push>g__Push|113_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C3D8 RID: 50136 RVA: 0x002FBEDC File Offset: 0x002FA0DC
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique()
			{
				Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "<<Push>g__Push|113_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr);
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, "<>1__state");
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, "<>2__current");
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, "<>4__this");
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, "<i>5__2");
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, 100667240);
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, 100667241);
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, 100667242);
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, 100667243);
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, 100667244);
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, 100667245);
			}

			// Token: 0x0600C3D9 RID: 50137 RVA: 0x002FBFD0 File Offset: 0x002FA1D0
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C3DA RID: 50138 RVA: 0x002FC018 File Offset: 0x002FA218
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C3DB RID: 50139 RVA: 0x002FC04C File Offset: 0x002FA24C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111816, XrefRangeEnd = 111825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003D28 RID: 15656
			// (get) Token: 0x0600C3DC RID: 50140 RVA: 0x002FC088 File Offset: 0x002FA288
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C3DD RID: 50141 RVA: 0x002FC0C8 File Offset: 0x002FA2C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111825, XrefRangeEnd = 111830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003D29 RID: 15657
			// (get) Token: 0x0600C3DE RID: 50142 RVA: 0x002FC0FC File Offset: 0x002FA2FC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C3DF RID: 50143 RVA: 0x0005F538 File Offset: 0x0005D738
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D24 RID: 15652
			// (get) Token: 0x0600C3E0 RID: 50144 RVA: 0x002FC13C File Offset: 0x002FA33C
			// (set) Token: 0x0600C3E1 RID: 50145 RVA: 0x0005F541 File Offset: 0x0005D741
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003D25 RID: 15653
			// (get) Token: 0x0600C3E2 RID: 50146 RVA: 0x002FC164 File Offset: 0x002FA364
			// (set) Token: 0x0600C3E3 RID: 50147 RVA: 0x0005F55C File Offset: 0x0005D75C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D26 RID: 15654
			// (get) Token: 0x0600C3E4 RID: 50148 RVA: 0x002FC194 File Offset: 0x002FA394
			// (set) Token: 0x0600C3E5 RID: 50149 RVA: 0x0005F57B File Offset: 0x0005D77B
			public unsafe Skateboard __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D27 RID: 15655
			// (get) Token: 0x0600C3E6 RID: 50150 RVA: 0x002FC1C4 File Offset: 0x002FA3C4
			// (set) Token: 0x0600C3E7 RID: 50151 RVA: 0x0005F59A File Offset: 0x0005D79A
			public unsafe float _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x040084C3 RID: 33987
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040084C4 RID: 33988
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040084C5 RID: 33989
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040084C6 RID: 33990
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x040084C7 RID: 33991
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040084C8 RID: 33992
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040084C9 RID: 33993
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040084CA RID: 33994
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040084CB RID: 33995
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040084CC RID: 33996
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020008C9 RID: 2249
		[ObfuscatedName("ScheduleOne.Skating.Skateboard+<>c__DisplayClass112_0")]
		public sealed class __c__DisplayClass112_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C3E8 RID: 50152 RVA: 0x002FC1EC File Offset: 0x002FA3EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass112_0()
			{
				Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "<>c__DisplayClass112_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0>.NativeClassPtr);
				Skateboard.__c__DisplayClass112_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0>.NativeClassPtr, "<>4__this");
				Skateboard.__c__DisplayClass112_0.NativeFieldInfoPtr_JumpDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0>.NativeClassPtr, "JumpDuration");
				Skateboard.__c__DisplayClass112_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0>.NativeClassPtr, 100667246);
				Skateboard.__c__DisplayClass112_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0>.NativeClassPtr, 100667247);
			}

			// Token: 0x0600C3E9 RID: 50153 RVA: 0x002FC268 File Offset: 0x002FA468
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass112_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.__c__DisplayClass112_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C3EA RID: 50154 RVA: 0x002FC2A4 File Offset: 0x002FA4A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111848, XrefRangeEnd = 111853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.__c__DisplayClass112_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C3EB RID: 50155 RVA: 0x0005F5B5 File Offset: 0x0005D7B5
			public __c__DisplayClass112_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D2A RID: 15658
			// (get) Token: 0x0600C3EC RID: 50156 RVA: 0x002FC2E4 File Offset: 0x002FA4E4
			// (set) Token: 0x0600C3ED RID: 50157 RVA: 0x0005F5BE File Offset: 0x0005D7BE
			public unsafe Skateboard __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D2B RID: 15659
			// (get) Token: 0x0600C3EE RID: 50158 RVA: 0x002FC314 File Offset: 0x002FA514
			// (set) Token: 0x0600C3EF RID: 50159 RVA: 0x0005F5DD File Offset: 0x0005D7DD
			public unsafe float JumpDuration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.NativeFieldInfoPtr_JumpDuration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.NativeFieldInfoPtr_JumpDuration)) = value;
				}
			}

			// Token: 0x040084CD RID: 33997
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040084CE RID: 33998
			private static readonly IntPtr NativeFieldInfoPtr_JumpDuration;

			// Token: 0x040084CF RID: 33999
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040084D0 RID: 34000
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C32 RID: 3122
			[ObfuscatedName("ScheduleOne.Skating.Skateboard+<>c__DisplayClass112_0+<<Jump>g__Jump|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E153 RID: 57683 RVA: 0x0034F808 File Offset: 0x0034DA08
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0>.NativeClassPtr, "<<Jump>g__Jump|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<i>5__2");
					Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100667248);
					Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100667249);
					Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100667250);
					Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100667251);
					Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100667252);
					Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100667253);
				}

				// Token: 0x0600E154 RID: 57684 RVA: 0x0034F8FC File Offset: 0x0034DAFC
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E155 RID: 57685 RVA: 0x0034F944 File Offset: 0x0034DB44
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E156 RID: 57686 RVA: 0x0034F978 File Offset: 0x0034DB78
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111830, XrefRangeEnd = 111843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170045D1 RID: 17873
				// (get) Token: 0x0600E157 RID: 57687 RVA: 0x0034F9B4 File Offset: 0x0034DBB4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E158 RID: 57688 RVA: 0x0034F9F4 File Offset: 0x0034DBF4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111843, XrefRangeEnd = 111848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170045D2 RID: 17874
				// (get) Token: 0x0600E159 RID: 57689 RVA: 0x0034FA28 File Offset: 0x0034DC28
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E15A RID: 57690 RVA: 0x0006DDC2 File Offset: 0x0006BFC2
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170045CD RID: 17869
				// (get) Token: 0x0600E15B RID: 57691 RVA: 0x0034FA68 File Offset: 0x0034DC68
				// (set) Token: 0x0600E15C RID: 57692 RVA: 0x0006DDCB File Offset: 0x0006BFCB
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170045CE RID: 17870
				// (get) Token: 0x0600E15D RID: 57693 RVA: 0x0034FA90 File Offset: 0x0034DC90
				// (set) Token: 0x0600E15E RID: 57694 RVA: 0x0006DDE6 File Offset: 0x0006BFE6
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045CF RID: 17871
				// (get) Token: 0x0600E15F RID: 57695 RVA: 0x0034FAC0 File Offset: 0x0034DCC0
				// (set) Token: 0x0600E160 RID: 57696 RVA: 0x0006DE05 File Offset: 0x0006C005
				public unsafe Skateboard.__c__DisplayClass112_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard.__c__DisplayClass112_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045D0 RID: 17872
				// (get) Token: 0x0600E161 RID: 57697 RVA: 0x0034FAF0 File Offset: 0x0034DCF0
				// (set) Token: 0x0600E162 RID: 57698 RVA: 0x0006DE24 File Offset: 0x0006C024
				public unsafe float _i_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x040096DF RID: 38623
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040096E0 RID: 38624
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040096E1 RID: 38625
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040096E2 RID: 38626
				private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x040096E3 RID: 38627
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040096E4 RID: 38628
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040096E5 RID: 38629
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040096E6 RID: 38630
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040096E7 RID: 38631
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040096E8 RID: 38632
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
