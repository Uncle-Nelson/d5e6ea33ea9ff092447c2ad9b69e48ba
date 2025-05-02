using System;
using Il2CppEPOOutline;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppPathfinding;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Money;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Storage;
using Il2CppScheduleOne.Tools;
using Il2CppScheduleOne.Vehicles.AI;
using Il2CppScheduleOne.Vehicles.Modification;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004E1 RID: 1249
	public class LandVehicle : NetworkBehaviour
	{
		// Token: 0x06006D14 RID: 27924 RVA: 0x001E3990 File Offset: 0x001E1B90
		// Note: this type is marked as 'beforefieldinit'.
		static LandVehicle()
		{
			Il2CppClassPointerStore<LandVehicle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "LandVehicle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr);
			LandVehicle.NativeFieldInfoPtr_KINEMATIC_THRESHOLD_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "KINEMATIC_THRESHOLD_DISTANCE");
			LandVehicle.NativeFieldInfoPtr_MAX_TURNOVER_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "MAX_TURNOVER_SPEED");
			LandVehicle.NativeFieldInfoPtr_TURNOVER_FORCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "TURNOVER_FORCE");
			LandVehicle.NativeFieldInfoPtr_USE_WHEEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "USE_WHEEL");
			LandVehicle.NativeFieldInfoPtr_SPEED_DISPLAY_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "SPEED_DISPLAY_MULTIPLIER");
			LandVehicle.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "DEBUG");
			LandVehicle.NativeFieldInfoPtr_vehicleName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "vehicleName");
			LandVehicle.NativeFieldInfoPtr_vehicleCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "vehicleCode");
			LandVehicle.NativeFieldInfoPtr_vehiclePrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "vehiclePrice");
			LandVehicle.NativeFieldInfoPtr__IsPlayerOwned_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<IsPlayerOwned>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__IsVisible_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<IsVisible>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_UseHumanoidCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "UseHumanoidCollider");
			LandVehicle.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<GUID>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_SpawnAsPlayerOwned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "SpawnAsPlayerOwned");
			LandVehicle.NativeFieldInfoPtr__DistanceToLocalCamera_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<DistanceToLocalCamera>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_vehicleModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "vehicleModel");
			LandVehicle.NativeFieldInfoPtr_driveWheels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "driveWheels");
			LandVehicle.NativeFieldInfoPtr_steerWheels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "steerWheels");
			LandVehicle.NativeFieldInfoPtr_handbrakeWheels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "handbrakeWheels");
			LandVehicle.NativeFieldInfoPtr_wheels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "wheels");
			LandVehicle.NativeFieldInfoPtr_intObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "intObj");
			LandVehicle.NativeFieldInfoPtr_exitPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "exitPoints");
			LandVehicle.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "rb");
			LandVehicle.NativeFieldInfoPtr_Seats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "Seats");
			LandVehicle.NativeFieldInfoPtr_boundingBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "boundingBox");
			LandVehicle.NativeFieldInfoPtr_Agent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "Agent");
			LandVehicle.NativeFieldInfoPtr_VelocityCalculator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "VelocityCalculator");
			LandVehicle.NativeFieldInfoPtr_Trunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "Trunk");
			LandVehicle.NativeFieldInfoPtr_NavMeshObstacle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "NavMeshObstacle");
			LandVehicle.NativeFieldInfoPtr_NavmeshCut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "NavmeshCut");
			LandVehicle.NativeFieldInfoPtr_HumanoidColliderContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "HumanoidColliderContainer");
			LandVehicle.NativeFieldInfoPtr_POI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "POI");
			LandVehicle.NativeFieldInfoPtr_centerOfMass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "centerOfMass");
			LandVehicle.NativeFieldInfoPtr_cameraOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "cameraOrigin");
			LandVehicle.NativeFieldInfoPtr_lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "lights");
			LandVehicle.NativeFieldInfoPtr_maxSteeringAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "maxSteeringAngle");
			LandVehicle.NativeFieldInfoPtr_steerRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "steerRate");
			LandVehicle.NativeFieldInfoPtr_flipSteer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "flipSteer");
			LandVehicle.NativeFieldInfoPtr__MaxSteerAngleOverridden_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<MaxSteerAngleOverridden>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__OverriddenMaxSteerAngle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<OverriddenMaxSteerAngle>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_motorTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "motorTorque");
			LandVehicle.NativeFieldInfoPtr_TopSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "TopSpeed");
			LandVehicle.NativeFieldInfoPtr_diffGearing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "diffGearing");
			LandVehicle.NativeFieldInfoPtr_handBrakeForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "handBrakeForce");
			LandVehicle.NativeFieldInfoPtr_brakeForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "brakeForce");
			LandVehicle.NativeFieldInfoPtr_downforce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "downforce");
			LandVehicle.NativeFieldInfoPtr_reverseMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "reverseMultiplier");
			LandVehicle.NativeFieldInfoPtr_BodyMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "BodyMeshes");
			LandVehicle.NativeFieldInfoPtr_DefaultColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "DefaultColor");
			LandVehicle.NativeFieldInfoPtr__OwnedColor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<OwnedColor>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_DisplayedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "DisplayedColor");
			LandVehicle.NativeFieldInfoPtr_outlineRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "outlineRenderers");
			LandVehicle.NativeFieldInfoPtr_outlineEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "outlineEffect");
			LandVehicle.NativeFieldInfoPtr_overrideControls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "overrideControls");
			LandVehicle.NativeFieldInfoPtr_throttleOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "throttleOverride");
			LandVehicle.NativeFieldInfoPtr_steerOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "steerOverride");
			LandVehicle.NativeFieldInfoPtr_Storage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "Storage");
			LandVehicle.NativeFieldInfoPtr_localPlayerSeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "localPlayerSeat");
			LandVehicle.NativeFieldInfoPtr__localPlayerIsDriver_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<localPlayerIsDriver>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__localPlayerIsInVehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<localPlayerIsInVehicle>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__isOccupied_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<isOccupied>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__OccupantNPCs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<OccupantNPCs>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__speed_Kmh_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<speed_Kmh>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_previousSpeeds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "previousSpeeds");
			LandVehicle.NativeFieldInfoPtr_previousSpeedsSampleSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "previousSpeedsSampleSize");
			LandVehicle.NativeFieldInfoPtr__currentThrottle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<currentThrottle>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_currentSteerAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "currentSteerAngle");
			LandVehicle.NativeFieldInfoPtr_lastFrameSteerAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "lastFrameSteerAngle");
			LandVehicle.NativeFieldInfoPtr_lastReplicatedSteerAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "lastReplicatedSteerAngle");
			LandVehicle.NativeFieldInfoPtr_justExitedVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "justExitedVehicle");
			LandVehicle.NativeFieldInfoPtr__brakesApplied_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<brakesApplied>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__isReversing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<isReversing>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__isStatic_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<isStatic>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__handbrakeApplied_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<handbrakeApplied>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_lastFramePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "lastFramePosition");
			LandVehicle.NativeFieldInfoPtr_closestExitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "closestExitPoint");
			LandVehicle.NativeFieldInfoPtr_CurrentParkData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "CurrentParkData");
			LandVehicle.NativeFieldInfoPtr__CurrentParkingLot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<CurrentParkingLot>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__CurrentParkingSpot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<CurrentParkingSpot>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "loader");
			LandVehicle.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<HasChanged>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_onPlayerEnterVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "onPlayerEnterVehicle");
			LandVehicle.NativeFieldInfoPtr_onPlayerExitVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "onPlayerExitVehicle");
			LandVehicle.NativeFieldInfoPtr_onVehicleStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "onVehicleStart");
			LandVehicle.NativeFieldInfoPtr_onVehicleStop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "onVehicleStop");
			LandVehicle.NativeFieldInfoPtr_onHandbrakeApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "onHandbrakeApplied");
			LandVehicle.NativeFieldInfoPtr_onCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "onCollision");
			LandVehicle.NativeFieldInfoPtr_syncVar___currentSteerAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "syncVar___currentSteerAngle");
			LandVehicle.NativeFieldInfoPtr_syncVar____brakesApplied_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "syncVar___<brakesApplied>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_syncVar____isReversing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "syncVar___<isReversing>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Vehicles.LandVehicleAssembly-CSharp.dll_Excuted");
			LandVehicle.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Vehicles.LandVehicleAssembly-CSharp.dll_Excuted");
			LandVehicle.NativeMethodInfoPtr_get_VehicleName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677079);
			LandVehicle.NativeMethodInfoPtr_get_VehicleCode_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677080);
			LandVehicle.NativeMethodInfoPtr_get_VehiclePrice_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677081);
			LandVehicle.NativeMethodInfoPtr_get_IsPlayerOwned_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677082);
			LandVehicle.NativeMethodInfoPtr_set_IsPlayerOwned_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677083);
			LandVehicle.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677084);
			LandVehicle.NativeMethodInfoPtr_set_IsVisible_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677085);
			LandVehicle.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677086);
			LandVehicle.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677087);
			LandVehicle.NativeMethodInfoPtr_get_DistanceToLocalCamera_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677088);
			LandVehicle.NativeMethodInfoPtr_set_DistanceToLocalCamera_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677089);
			LandVehicle.NativeMethodInfoPtr_get_boundingBoxDimensions_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677090);
			LandVehicle.NativeMethodInfoPtr_get_driverEntryPoint_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677091);
			LandVehicle.NativeMethodInfoPtr_get_Rb_Public_get_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677092);
			LandVehicle.NativeMethodInfoPtr_get_ActualMaxSteeringAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677093);
			LandVehicle.NativeMethodInfoPtr_get_MaxSteerAngleOverridden_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677094);
			LandVehicle.NativeMethodInfoPtr_set_MaxSteerAngleOverridden_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677095);
			LandVehicle.NativeMethodInfoPtr_get_OverriddenMaxSteerAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677096);
			LandVehicle.NativeMethodInfoPtr_set_OverriddenMaxSteerAngle_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677097);
			LandVehicle.NativeMethodInfoPtr_get_OwnedColor_Public_get_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677098);
			LandVehicle.NativeMethodInfoPtr_set_OwnedColor_Private_set_Void_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677099);
			LandVehicle.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677100);
			LandVehicle.NativeMethodInfoPtr_get_CurrentPlayerOccupancy_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677101);
			LandVehicle.NativeMethodInfoPtr_get_localPlayerIsDriver_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677102);
			LandVehicle.NativeMethodInfoPtr_set_localPlayerIsDriver_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677103);
			LandVehicle.NativeMethodInfoPtr_get_localPlayerIsInVehicle_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677104);
			LandVehicle.NativeMethodInfoPtr_set_localPlayerIsInVehicle_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677105);
			LandVehicle.NativeMethodInfoPtr_get_isOccupied_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677106);
			LandVehicle.NativeMethodInfoPtr_set_isOccupied_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677107);
			LandVehicle.NativeMethodInfoPtr_get_DriverPlayer_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677108);
			LandVehicle.NativeMethodInfoPtr_get_OccupantPlayers_Public_get_List_1_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677109);
			LandVehicle.NativeMethodInfoPtr_get_OccupantNPCs_Public_get_Il2CppReferenceArray_1_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677110);
			LandVehicle.NativeMethodInfoPtr_set_OccupantNPCs_Protected_set_Void_Il2CppReferenceArray_1_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677111);
			LandVehicle.NativeMethodInfoPtr_get_speed_Kmh_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677112);
			LandVehicle.NativeMethodInfoPtr_set_speed_Kmh_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677113);
			LandVehicle.NativeMethodInfoPtr_get_speed_Ms_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677114);
			LandVehicle.NativeMethodInfoPtr_get_speed_Mph_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677115);
			LandVehicle.NativeMethodInfoPtr_get_currentThrottle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677116);
			LandVehicle.NativeMethodInfoPtr_set_currentThrottle_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677117);
			LandVehicle.NativeMethodInfoPtr_get_brakesApplied_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677118);
			LandVehicle.NativeMethodInfoPtr_set_brakesApplied_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677119);
			LandVehicle.NativeMethodInfoPtr_get_isReversing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677120);
			LandVehicle.NativeMethodInfoPtr_set_isReversing_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677121);
			LandVehicle.NativeMethodInfoPtr_get_isStatic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677122);
			LandVehicle.NativeMethodInfoPtr_set_isStatic_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677123);
			LandVehicle.NativeMethodInfoPtr_get_handbrakeApplied_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677124);
			LandVehicle.NativeMethodInfoPtr_set_handbrakeApplied_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677125);
			LandVehicle.NativeMethodInfoPtr_get_boundingBaseOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677126);
			LandVehicle.NativeMethodInfoPtr_get_isParked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677127);
			LandVehicle.NativeMethodInfoPtr_get_CurrentParkingLot_Public_get_ParkingLot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677128);
			LandVehicle.NativeMethodInfoPtr_set_CurrentParkingLot_Protected_set_Void_ParkingLot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677129);
			LandVehicle.NativeMethodInfoPtr_get_CurrentParkingSpot_Public_get_ParkingSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677130);
			LandVehicle.NativeMethodInfoPtr_set_CurrentParkingSpot_Protected_set_Void_ParkingSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677131);
			LandVehicle.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677132);
			LandVehicle.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677133);
			LandVehicle.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677134);
			LandVehicle.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677135);
			LandVehicle.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677136);
			LandVehicle.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677137);
			LandVehicle.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677138);
			LandVehicle.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677139);
			LandVehicle.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677140);
			LandVehicle.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677141);
			LandVehicle.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677142);
			LandVehicle.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677143);
			LandVehicle.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677144);
			LandVehicle.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677145);
			LandVehicle.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677146);
			LandVehicle.NativeMethodInfoPtr_SetIsPlayerOwned_Public_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677147);
			LandVehicle.NativeMethodInfoPtr_RefreshPoI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677148);
			LandVehicle.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677149);
			LandVehicle.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677150);
			LandVehicle.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677151);
			LandVehicle.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677152);
			LandVehicle.NativeMethodInfoPtr_GetNetworth_Private_Void_FloatContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677153);
			LandVehicle.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677154);
			LandVehicle.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677155);
			LandVehicle.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677156);
			LandVehicle.NativeMethodInfoPtr_OnMinPass_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677157);
			LandVehicle.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677158);
			LandVehicle.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677159);
			LandVehicle.NativeMethodInfoPtr_SetOwner_Protected_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677160);
			LandVehicle.NativeMethodInfoPtr_OnOwnerChanged_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677161);
			LandVehicle.NativeMethodInfoPtr_SetTransform_Server_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677162);
			LandVehicle.NativeMethodInfoPtr_SetTransform_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677163);
			LandVehicle.NativeMethodInfoPtr_DestroyVehicle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677164);
			LandVehicle.NativeMethodInfoPtr_UpdateThrottle_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677165);
			LandVehicle.NativeMethodInfoPtr_ApplyThrottle_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677166);
			LandVehicle.NativeMethodInfoPtr_ApplyHandbrake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677167);
			LandVehicle.NativeMethodInfoPtr_SetSteeringAngle_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677168);
			LandVehicle.NativeMethodInfoPtr_UpdateSteerAngle_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677169);
			LandVehicle.NativeMethodInfoPtr_ApplySteerAngle_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677170);
			LandVehicle.NativeMethodInfoPtr_DelaySetStatic_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677171);
			LandVehicle.NativeMethodInfoPtr_SetIsStatic_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677172);
			LandVehicle.NativeMethodInfoPtr_AlignTo_Public_Void_Transform_EParkingAlignment_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677173);
			LandVehicle.NativeMethodInfoPtr_GetAlignmentTransform_Public_Tuple_2_Vector3_Quaternion_Transform_EParkingAlignment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677174);
			LandVehicle.NativeMethodInfoPtr_GetVehicleValue_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677175);
			LandVehicle.NativeMethodInfoPtr_OverrideMaxSteerAngle_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677176);
			LandVehicle.NativeMethodInfoPtr_ResetMaxSteerAngle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677177);
			LandVehicle.NativeMethodInfoPtr_SetObstaclesActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677178);
			LandVehicle.NativeMethodInfoPtr_GetFirstFreeSeat_Public_VehicleSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677179);
			LandVehicle.NativeMethodInfoPtr_SetSeatOccupant_Private_Void_NetworkConnection_Int32_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677180);
			LandVehicle.NativeMethodInfoPtr_SetSeatOccupant_Server_Private_Void_Int32_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677181);
			LandVehicle.NativeMethodInfoPtr_Hovered_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677182);
			LandVehicle.NativeMethodInfoPtr_Interacted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677183);
			LandVehicle.NativeMethodInfoPtr_EnterVehicle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677184);
			LandVehicle.NativeMethodInfoPtr_ExitVehicle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677185);
			LandVehicle.NativeMethodInfoPtr_EndJustExited_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677186);
			LandVehicle.NativeMethodInfoPtr_GetExitPoint_Public_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677187);
			LandVehicle.NativeMethodInfoPtr_GetClosestExitPoint_Private_Transform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677188);
			LandVehicle.NativeMethodInfoPtr_GetValidExitPoint_Private_Transform_List_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677189);
			LandVehicle.NativeMethodInfoPtr_AddNPCOccupant_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677190);
			LandVehicle.NativeMethodInfoPtr_RemoveNPCOccupant_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677191);
			LandVehicle.NativeMethodInfoPtr_CanBeRecovered_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677192);
			LandVehicle.NativeMethodInfoPtr_RecoverVehicle_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677193);
			LandVehicle.NativeMethodInfoPtr_SendOwnedColor_Public_Void_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677194);
			LandVehicle.NativeMethodInfoPtr_SetOwnedColor_Protected_Virtual_New_Void_NetworkConnection_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677195);
			LandVehicle.NativeMethodInfoPtr_ApplyColor_Public_Virtual_New_Void_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677196);
			LandVehicle.NativeMethodInfoPtr_ApplyOwnedColor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677197);
			LandVehicle.NativeMethodInfoPtr_ShowOutline_Public_Void_EOutlineColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677198);
			LandVehicle.NativeMethodInfoPtr_HideOutline_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677199);
			LandVehicle.NativeMethodInfoPtr_Park_Networked_Private_Void_NetworkConnection_ParkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677200);
			LandVehicle.NativeMethodInfoPtr_Park_Public_Void_NetworkConnection_ParkData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677201);
			LandVehicle.NativeMethodInfoPtr_ExitPark_Networked_Public_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677202);
			LandVehicle.NativeMethodInfoPtr_ExitPark_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677203);
			LandVehicle.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677204);
			LandVehicle.NativeMethodInfoPtr_GetContents_Public_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677205);
			LandVehicle.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677206);
			LandVehicle.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677207);
			LandVehicle.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_VehicleData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677208);
			LandVehicle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677209);
			LandVehicle.NativeMethodInfoPtr__ApplyColor_b__249_0_Private_Boolean_VehicleColorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677210);
			LandVehicle.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677211);
			LandVehicle.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677212);
			LandVehicle.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677213);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_SetIsPlayerOwned_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677214);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SetIsPlayerOwned_214505783_Public_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677215);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_SetIsPlayerOwned_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677216);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_SetIsPlayerOwned_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677217);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Target_SetIsPlayerOwned_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677218);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetOwner_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677219);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SetOwner_328543758_Protected_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677220);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetOwner_328543758_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677221);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_OnOwnerChanged_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677222);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___OnOwnerChanged_2166136261_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677223);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_OnOwnerChanged_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677224);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetTransform_Server_3848837105_Private_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677225);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SetTransform_Server_3848837105_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677226);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetTransform_Server_3848837105_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677227);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_SetTransform_3848837105_Private_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677228);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SetTransform_3848837105_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677229);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_SetTransform_3848837105_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677230);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetSteeringAngle_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677231);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SetSteeringAngle_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677232);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetSteeringAngle_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677233);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677234);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677235);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_SetSeatOccupant_3428404692_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677236);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677237);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Target_SetSeatOccupant_3428404692_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677238);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetSeatOccupant_Server_3266232555_Private_Void_Int32_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677239);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SetSeatOccupant_Server_3266232555_Private_Void_Int32_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677240);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetSeatOccupant_Server_3266232555_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677241);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SendOwnedColor_911055161_Private_Void_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677242);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SendOwnedColor_911055161_Public_Void_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677243);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SendOwnedColor_911055161_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677244);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_SetOwnedColor_1679996372_Private_Void_NetworkConnection_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677245);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SetOwnedColor_1679996372_Protected_Virtual_New_Void_NetworkConnection_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677246);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Target_SetOwnedColor_1679996372_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677247);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_SetOwnedColor_1679996372_Private_Void_NetworkConnection_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677248);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_SetOwnedColor_1679996372_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677249);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677250);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677251);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_Park_Networked_2633993806_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677252);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677253);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Target_Park_Networked_2633993806_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677254);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_ExitPark_Networked_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677255);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___ExitPark_Networked_214505783_Public_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677256);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_ExitPark_Networked_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677257);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_ExitPark_Networked_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677258);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Target_ExitPark_Networked_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677259);
			LandVehicle.NativeMethodInfoPtr_sync___get_value_currentSteerAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677260);
			LandVehicle.NativeMethodInfoPtr_sync___set_value_currentSteerAngle_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677261);
			LandVehicle.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Vehicles_LandVehicle_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677262);
			LandVehicle.NativeMethodInfoPtr_sync___get_value__brakesApplied_k__BackingField_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677263);
			LandVehicle.NativeMethodInfoPtr_sync___set_value__brakesApplied_k__BackingField_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677264);
			LandVehicle.NativeMethodInfoPtr_sync___get_value__isReversing_k__BackingField_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677265);
			LandVehicle.NativeMethodInfoPtr_sync___set_value__isReversing_k__BackingField_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677266);
			LandVehicle.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677267);
		}

		// Token: 0x17002126 RID: 8486
		// (get) Token: 0x06006D15 RID: 27925 RVA: 0x001E4FDC File Offset: 0x001E31DC
		public unsafe string VehicleName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_VehicleName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002127 RID: 8487
		// (get) Token: 0x06006D16 RID: 27926 RVA: 0x001E5014 File Offset: 0x001E3214
		public unsafe string VehicleCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_VehicleCode_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002128 RID: 8488
		// (get) Token: 0x06006D17 RID: 27927 RVA: 0x001E504C File Offset: 0x001E324C
		public unsafe float VehiclePrice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_VehiclePrice_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002129 RID: 8489
		// (get) Token: 0x06006D18 RID: 27928 RVA: 0x001E5088 File Offset: 0x001E3288
		// (set) Token: 0x06006D19 RID: 27929 RVA: 0x001E50C4 File Offset: 0x001E32C4
		public unsafe bool IsPlayerOwned
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_IsPlayerOwned_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_IsPlayerOwned_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700212A RID: 8490
		// (get) Token: 0x06006D1A RID: 27930 RVA: 0x001E5104 File Offset: 0x001E3304
		// (set) Token: 0x06006D1B RID: 27931 RVA: 0x001E5140 File Offset: 0x001E3340
		public unsafe bool IsVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_IsVisible_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700212B RID: 8491
		// (get) Token: 0x06006D1C RID: 27932 RVA: 0x001E5180 File Offset: 0x001E3380
		// (set) Token: 0x06006D1D RID: 27933 RVA: 0x001E51BC File Offset: 0x001E33BC
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700212C RID: 8492
		// (get) Token: 0x06006D1E RID: 27934 RVA: 0x001E51FC File Offset: 0x001E33FC
		// (set) Token: 0x06006D1F RID: 27935 RVA: 0x001E5238 File Offset: 0x001E3438
		public unsafe float DistanceToLocalCamera
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_DistanceToLocalCamera_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_DistanceToLocalCamera_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700212D RID: 8493
		// (get) Token: 0x06006D20 RID: 27936 RVA: 0x001E5278 File Offset: 0x001E3478
		public unsafe Vector3 boundingBoxDimensions
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 217857, RefRangeEnd = 217866, XrefRangeStart = 217848, XrefRangeEnd = 217857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_boundingBoxDimensions_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700212E RID: 8494
		// (get) Token: 0x06006D21 RID: 27937 RVA: 0x001E52B4 File Offset: 0x001E34B4
		public unsafe Transform driverEntryPoint
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217866, XrefRangeEnd = 217870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_driverEntryPoint_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x1700212F RID: 8495
		// (get) Token: 0x06006D22 RID: 27938 RVA: 0x001E52F4 File Offset: 0x001E34F4
		public unsafe Rigidbody Rb
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_Rb_Public_get_Rigidbody_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr3) : null;
			}
		}

		// Token: 0x17002130 RID: 8496
		// (get) Token: 0x06006D23 RID: 27939 RVA: 0x001E5334 File Offset: 0x001E3534
		public unsafe float ActualMaxSteeringAngle
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 217870, RefRangeEnd = 217878, XrefRangeStart = 217870, XrefRangeEnd = 217870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_ActualMaxSteeringAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002131 RID: 8497
		// (get) Token: 0x06006D24 RID: 27940 RVA: 0x001E5370 File Offset: 0x001E3570
		// (set) Token: 0x06006D25 RID: 27941 RVA: 0x001E53AC File Offset: 0x001E35AC
		public unsafe bool MaxSteerAngleOverridden
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_MaxSteerAngleOverridden_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_MaxSteerAngleOverridden_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002132 RID: 8498
		// (get) Token: 0x06006D26 RID: 27942 RVA: 0x001E53EC File Offset: 0x001E35EC
		// (set) Token: 0x06006D27 RID: 27943 RVA: 0x001E5428 File Offset: 0x001E3628
		public unsafe float OverriddenMaxSteerAngle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_OverriddenMaxSteerAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_OverriddenMaxSteerAngle_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002133 RID: 8499
		// (get) Token: 0x06006D28 RID: 27944 RVA: 0x001E5468 File Offset: 0x001E3668
		// (set) Token: 0x06006D29 RID: 27945 RVA: 0x001E54A4 File Offset: 0x001E36A4
		public unsafe EVehicleColor OwnedColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_OwnedColor_Public_get_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_OwnedColor_Private_set_Void_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002134 RID: 8500
		// (get) Token: 0x06006D2A RID: 27946 RVA: 0x001E54E4 File Offset: 0x001E36E4
		public unsafe int Capacity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002135 RID: 8501
		// (get) Token: 0x06006D2B RID: 27947 RVA: 0x001E5520 File Offset: 0x001E3720
		public unsafe int CurrentPlayerOccupancy
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 217896, RefRangeEnd = 217900, XrefRangeStart = 217878, XrefRangeEnd = 217896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_CurrentPlayerOccupancy_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002136 RID: 8502
		// (get) Token: 0x06006D2C RID: 27948 RVA: 0x001E555C File Offset: 0x001E375C
		// (set) Token: 0x06006D2D RID: 27949 RVA: 0x001E5598 File Offset: 0x001E3798
		public unsafe bool localPlayerIsDriver
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_localPlayerIsDriver_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_localPlayerIsDriver_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002137 RID: 8503
		// (get) Token: 0x06006D2E RID: 27950 RVA: 0x001E55D8 File Offset: 0x001E37D8
		// (set) Token: 0x06006D2F RID: 27951 RVA: 0x001E5614 File Offset: 0x001E3814
		public unsafe bool localPlayerIsInVehicle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_localPlayerIsInVehicle_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_localPlayerIsInVehicle_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002138 RID: 8504
		// (get) Token: 0x06006D30 RID: 27952 RVA: 0x001E5654 File Offset: 0x001E3854
		// (set) Token: 0x06006D31 RID: 27953 RVA: 0x001E5690 File Offset: 0x001E3890
		public unsafe bool isOccupied
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_isOccupied_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_isOccupied_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002139 RID: 8505
		// (get) Token: 0x06006D32 RID: 27954 RVA: 0x001E56D0 File Offset: 0x001E38D0
		public unsafe Player DriverPlayer
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 217904, RefRangeEnd = 217918, XrefRangeStart = 217900, XrefRangeEnd = 217904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_DriverPlayer_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
		}

		// Token: 0x1700213A RID: 8506
		// (get) Token: 0x06006D33 RID: 27955 RVA: 0x001E5710 File Offset: 0x001E3910
		public unsafe List<Player> OccupantPlayers
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 217956, RefRangeEnd = 217958, XrefRangeStart = 217918, XrefRangeEnd = 217956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_OccupantPlayers_Public_get_List_1_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Player>>(intPtr3) : null;
			}
		}

		// Token: 0x1700213B RID: 8507
		// (get) Token: 0x06006D34 RID: 27956 RVA: 0x001E5750 File Offset: 0x001E3950
		// (set) Token: 0x06006D35 RID: 27957 RVA: 0x001E5790 File Offset: 0x001E3990
		public unsafe Il2CppReferenceArray<NPC> OccupantNPCs
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 166544, RefRangeEnd = 166559, XrefRangeStart = 166544, XrefRangeEnd = 166559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_OccupantNPCs_Public_get_Il2CppReferenceArray_1_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NPC>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_OccupantNPCs_Protected_set_Void_Il2CppReferenceArray_1_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700213C RID: 8508
		// (get) Token: 0x06006D36 RID: 27958 RVA: 0x001E57D4 File Offset: 0x001E39D4
		// (set) Token: 0x06006D37 RID: 27959 RVA: 0x001E5810 File Offset: 0x001E3A10
		public unsafe float speed_Kmh
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_speed_Kmh_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_speed_Kmh_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700213D RID: 8509
		// (get) Token: 0x06006D38 RID: 27960 RVA: 0x001E5850 File Offset: 0x001E3A50
		public unsafe float speed_Ms
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_speed_Ms_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700213E RID: 8510
		// (get) Token: 0x06006D39 RID: 27961 RVA: 0x001E588C File Offset: 0x001E3A8C
		public unsafe float speed_Mph
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_speed_Mph_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700213F RID: 8511
		// (get) Token: 0x06006D3A RID: 27962 RVA: 0x001E58C8 File Offset: 0x001E3AC8
		// (set) Token: 0x06006D3B RID: 27963 RVA: 0x001E5904 File Offset: 0x001E3B04
		public unsafe float currentThrottle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_currentThrottle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_currentThrottle_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002140 RID: 8512
		// (get) Token: 0x06006D3C RID: 27964 RVA: 0x001E5944 File Offset: 0x001E3B44
		// (set) Token: 0x06006D3D RID: 27965 RVA: 0x001E5980 File Offset: 0x001E3B80
		public unsafe bool brakesApplied
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 217958, RefRangeEnd = 217960, XrefRangeStart = 217958, XrefRangeEnd = 217958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_brakesApplied_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 217967, RefRangeEnd = 217972, XrefRangeStart = 217960, XrefRangeEnd = 217967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_brakesApplied_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002141 RID: 8513
		// (get) Token: 0x06006D3E RID: 27966 RVA: 0x001E59C0 File Offset: 0x001E3BC0
		// (set) Token: 0x06006D3F RID: 27967 RVA: 0x001E59FC File Offset: 0x001E3BFC
		public unsafe bool isReversing
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 217972, RefRangeEnd = 217974, XrefRangeStart = 217972, XrefRangeEnd = 217972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_isReversing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 217981, RefRangeEnd = 217984, XrefRangeStart = 217974, XrefRangeEnd = 217981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_isReversing_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002142 RID: 8514
		// (get) Token: 0x06006D40 RID: 27968 RVA: 0x001E5A3C File Offset: 0x001E3C3C
		// (set) Token: 0x06006D41 RID: 27969 RVA: 0x001E5A78 File Offset: 0x001E3C78
		public unsafe bool isStatic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_isStatic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_isStatic_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002143 RID: 8515
		// (get) Token: 0x06006D42 RID: 27970 RVA: 0x001E5AB8 File Offset: 0x001E3CB8
		// (set) Token: 0x06006D43 RID: 27971 RVA: 0x001E5AF4 File Offset: 0x001E3CF4
		public unsafe bool handbrakeApplied
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_handbrakeApplied_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_handbrakeApplied_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002144 RID: 8516
		// (get) Token: 0x06006D44 RID: 27972 RVA: 0x001E5B34 File Offset: 0x001E3D34
		public unsafe float boundingBaseOffset
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217984, XrefRangeEnd = 217989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_boundingBaseOffset_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002145 RID: 8517
		// (get) Token: 0x06006D45 RID: 27973 RVA: 0x001E5B70 File Offset: 0x001E3D70
		public unsafe bool isParked
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 217993, RefRangeEnd = 217994, XrefRangeStart = 217989, XrefRangeEnd = 217993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_isParked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002146 RID: 8518
		// (get) Token: 0x06006D46 RID: 27974 RVA: 0x001E5BAC File Offset: 0x001E3DAC
		// (set) Token: 0x06006D47 RID: 27975 RVA: 0x001E5BEC File Offset: 0x001E3DEC
		public unsafe ParkingLot CurrentParkingLot
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_CurrentParkingLot_Public_get_ParkingLot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParkingLot>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217994, XrefRangeEnd = 217995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_CurrentParkingLot_Protected_set_Void_ParkingLot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002147 RID: 8519
		// (get) Token: 0x06006D48 RID: 27976 RVA: 0x001E5C30 File Offset: 0x001E3E30
		// (set) Token: 0x06006D49 RID: 27977 RVA: 0x001E5C70 File Offset: 0x001E3E70
		public unsafe ParkingSpot CurrentParkingSpot
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 118993, RefRangeEnd = 118994, XrefRangeStart = 118993, XrefRangeEnd = 118994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_CurrentParkingSpot_Public_get_ParkingSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParkingSpot>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_CurrentParkingSpot_Protected_set_Void_ParkingSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002148 RID: 8520
		// (get) Token: 0x06006D4A RID: 27978 RVA: 0x001E5CB4 File Offset: 0x001E3EB4
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 218000, RefRangeEnd = 218002, XrefRangeStart = 217995, XrefRangeEnd = 218000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002149 RID: 8521
		// (get) Token: 0x06006D4B RID: 27979 RVA: 0x001E5CEC File Offset: 0x001E3EEC
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218002, XrefRangeEnd = 218004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700214A RID: 8522
		// (get) Token: 0x06006D4C RID: 27980 RVA: 0x001E5D24 File Offset: 0x001E3F24
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x1700214B RID: 8523
		// (get) Token: 0x06006D4D RID: 27981 RVA: 0x001E5D64 File Offset: 0x001E3F64
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30138, RefRangeEnd = 30158, XrefRangeStart = 30138, XrefRangeEnd = 30158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700214C RID: 8524
		// (get) Token: 0x06006D4E RID: 27982 RVA: 0x001E5DA0 File Offset: 0x001E3FA0
		// (set) Token: 0x06006D4F RID: 27983 RVA: 0x001E5DE0 File Offset: 0x001E3FE0
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218004, XrefRangeEnd = 218005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700214D RID: 8525
		// (get) Token: 0x06006D50 RID: 27984 RVA: 0x001E5E24 File Offset: 0x001E4024
		// (set) Token: 0x06006D51 RID: 27985 RVA: 0x001E5E64 File Offset: 0x001E4064
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218005, XrefRangeEnd = 218006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700214E RID: 8526
		// (get) Token: 0x06006D52 RID: 27986 RVA: 0x001E5EA8 File Offset: 0x001E40A8
		// (set) Token: 0x06006D53 RID: 27987 RVA: 0x001E5EE4 File Offset: 0x001E40E4
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006D54 RID: 27988 RVA: 0x001E5F24 File Offset: 0x001E4124
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218007, RefRangeEnd = 218008, XrefRangeStart = 218006, XrefRangeEnd = 218007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D55 RID: 27989 RVA: 0x001E5F60 File Offset: 0x001E4160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218008, XrefRangeEnd = 218014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D56 RID: 27990 RVA: 0x001E5F9C File Offset: 0x001E419C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218014, XrefRangeEnd = 218020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D57 RID: 27991 RVA: 0x001E5FD8 File Offset: 0x001E41D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218020, XrefRangeEnd = 218034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D58 RID: 27992 RVA: 0x001E6028 File Offset: 0x001E4228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218034, XrefRangeEnd = 218041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D59 RID: 27993 RVA: 0x001E6064 File Offset: 0x001E4264
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 218083, RefRangeEnd = 218086, XrefRangeStart = 218041, XrefRangeEnd = 218083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsPlayerOwned(NetworkConnection conn, bool playerOwned)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerOwned;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetIsPlayerOwned_Public_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D5A RID: 27994 RVA: 0x001E60B4 File Offset: 0x001E42B4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 218096, RefRangeEnd = 218102, XrefRangeStart = 218086, XrefRangeEnd = 218096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshPoI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RefreshPoI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D5B RID: 27995 RVA: 0x001E60E8 File Offset: 0x001E42E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218106, RefRangeEnd = 218107, XrefRangeStart = 218102, XrefRangeEnd = 218106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D5C RID: 27996 RVA: 0x001E6128 File Offset: 0x001E4328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218107, XrefRangeEnd = 218231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D5D RID: 27997 RVA: 0x001E6164 File Offset: 0x001E4364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218231, XrefRangeEnd = 218233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D5E RID: 27998 RVA: 0x001E61A8 File Offset: 0x001E43A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218233, XrefRangeEnd = 218287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D5F RID: 27999 RVA: 0x001E61E4 File Offset: 0x001E43E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218287, XrefRangeEnd = 218288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetNetworth(MoneyManager.FloatContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetNetworth_Private_Void_FloatContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D60 RID: 28000 RVA: 0x001E6228 File Offset: 0x001E4428
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218333, RefRangeEnd = 218334, XrefRangeStart = 218288, XrefRangeEnd = 218333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D61 RID: 28001 RVA: 0x001E6264 File Offset: 0x001E4464
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D62 RID: 28002 RVA: 0x001E6298 File Offset: 0x001E4498
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218427, RefRangeEnd = 218428, XrefRangeStart = 218334, XrefRangeEnd = 218427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D63 RID: 28003 RVA: 0x001E62D4 File Offset: 0x001E44D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218428, XrefRangeEnd = 218449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_OnMinPass_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D64 RID: 28004 RVA: 0x001E6310 File Offset: 0x001E4510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218449, XrefRangeEnd = 218461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D65 RID: 28005 RVA: 0x001E634C File Offset: 0x001E454C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218461, XrefRangeEnd = 218464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionEnter(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D66 RID: 28006 RVA: 0x001E6390 File Offset: 0x001E4590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218464, XrefRangeEnd = 218483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetOwner(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_SetOwner_Protected_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D67 RID: 28007 RVA: 0x001E63E0 File Offset: 0x001E45E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218483, XrefRangeEnd = 218501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnOwnerChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_OnOwnerChanged_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D68 RID: 28008 RVA: 0x001E641C File Offset: 0x001E461C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218503, RefRangeEnd = 218504, XrefRangeStart = 218501, XrefRangeEnd = 218503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTransform_Server(Vector3 pos, Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetTransform_Server_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D69 RID: 28009 RVA: 0x001E6468 File Offset: 0x001E4668
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 218511, RefRangeEnd = 218518, XrefRangeStart = 218504, XrefRangeEnd = 218511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTransform(Vector3 pos, Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetTransform_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D6A RID: 28010 RVA: 0x001E64B4 File Offset: 0x001E46B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218518, XrefRangeEnd = 218546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_DestroyVehicle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D6B RID: 28011 RVA: 0x001E64E8 File Offset: 0x001E46E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218546, XrefRangeEnd = 218551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateThrottle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_UpdateThrottle_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D6C RID: 28012 RVA: 0x001E6524 File Offset: 0x001E4724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218551, XrefRangeEnd = 218610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyThrottle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_ApplyThrottle_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D6D RID: 28013 RVA: 0x001E6560 File Offset: 0x001E4760
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 218613, RefRangeEnd = 218615, XrefRangeStart = 218610, XrefRangeEnd = 218613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyHandbrake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_ApplyHandbrake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D6E RID: 28014 RVA: 0x001E6594 File Offset: 0x001E4794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218615, XrefRangeEnd = 218634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSteeringAngle(float sa)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sa;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetSteeringAngle_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D6F RID: 28015 RVA: 0x001E65D4 File Offset: 0x001E47D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218634, XrefRangeEnd = 218704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateSteerAngle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_UpdateSteerAngle_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D70 RID: 28016 RVA: 0x001E6610 File Offset: 0x001E4810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218704, XrefRangeEnd = 218706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplySteerAngle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_ApplySteerAngle_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D71 RID: 28017 RVA: 0x001E664C File Offset: 0x001E484C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218706, XrefRangeEnd = 218714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DelaySetStatic(bool stat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_DelaySetStatic_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D72 RID: 28018 RVA: 0x001E668C File Offset: 0x001E488C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218714, XrefRangeEnd = 218730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsStatic(bool stat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_SetIsStatic_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D73 RID: 28019 RVA: 0x001E66D8 File Offset: 0x001E48D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 218741, RefRangeEnd = 218745, XrefRangeStart = 218730, XrefRangeEnd = 218741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignTo(Transform target, EParkingAlignment type, bool network = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_AlignTo_Public_Void_Transform_EParkingAlignment_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D74 RID: 28020 RVA: 0x001E6738 File Offset: 0x001E4938
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 218762, RefRangeEnd = 218765, XrefRangeStart = 218745, XrefRangeEnd = 218762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tuple<Vector3, Quaternion> GetAlignmentTransform(Transform target, EParkingAlignment type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetAlignmentTransform_Public_Tuple_2_Vector3_Quaternion_Transform_EParkingAlignment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tuple<Vector3, Quaternion>>(intPtr3) : null;
		}

		// Token: 0x06006D75 RID: 28021 RVA: 0x001E6798 File Offset: 0x001E4998
		[CallerCount(0)]
		public unsafe float GetVehicleValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetVehicleValue_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006D76 RID: 28022 RVA: 0x001E67D4 File Offset: 0x001E49D4
		[CallerCount(0)]
		public unsafe void OverrideMaxSteerAngle(float maxAngle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref maxAngle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_OverrideMaxSteerAngle_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D77 RID: 28023 RVA: 0x001E6814 File Offset: 0x001E4A14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218765, RefRangeEnd = 218766, XrefRangeStart = 218765, XrefRangeEnd = 218765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetMaxSteerAngle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_ResetMaxSteerAngle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D78 RID: 28024 RVA: 0x001E6848 File Offset: 0x001E4A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218766, XrefRangeEnd = 218769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetObstaclesActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetObstaclesActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D79 RID: 28025 RVA: 0x001E6888 File Offset: 0x001E4A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218769, XrefRangeEnd = 218771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleSeat GetFirstFreeSeat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetFirstFreeSeat_Public_VehicleSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VehicleSeat>(intPtr3) : null;
		}

		// Token: 0x06006D7A RID: 28026 RVA: 0x001E68C8 File Offset: 0x001E4AC8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 218817, RefRangeEnd = 218821, XrefRangeStart = 218771, XrefRangeEnd = 218817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSeatOccupant(NetworkConnection conn, int seatIndex, NetworkConnection occupant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seatIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(occupant);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetSeatOccupant_Private_Void_NetworkConnection_Int32_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D7B RID: 28027 RVA: 0x001E692C File Offset: 0x001E4B2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 218844, RefRangeEnd = 218846, XrefRangeStart = 218821, XrefRangeEnd = 218844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSeatOccupant_Server(int seatIndex, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref seatIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetSeatOccupant_Server_Private_Void_Int32_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D7C RID: 28028 RVA: 0x001E697C File Offset: 0x001E4B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218846, XrefRangeEnd = 218851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_Hovered_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D7D RID: 28029 RVA: 0x001E69B0 File Offset: 0x001E4BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218851, XrefRangeEnd = 218853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_Interacted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D7E RID: 28030 RVA: 0x001E69E4 File Offset: 0x001E4BE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218910, RefRangeEnd = 218911, XrefRangeStart = 218853, XrefRangeEnd = 218910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnterVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_EnterVehicle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D7F RID: 28031 RVA: 0x001E6A18 File Offset: 0x001E4C18
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 218970, RefRangeEnd = 218974, XrefRangeStart = 218911, XrefRangeEnd = 218970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_ExitVehicle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D80 RID: 28032 RVA: 0x001E6A4C File Offset: 0x001E4C4C
		[CallerCount(0)]
		public unsafe void EndJustExited()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_EndJustExited_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D81 RID: 28033 RVA: 0x001E6A80 File Offset: 0x001E4C80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218978, RefRangeEnd = 218979, XrefRangeStart = 218974, XrefRangeEnd = 218978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetExitPoint(int seatIndex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref seatIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetExitPoint_Public_Transform_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06006D82 RID: 28034 RVA: 0x001E6ACC File Offset: 0x001E4CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218979, XrefRangeEnd = 218995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetClosestExitPoint(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetClosestExitPoint_Private_Transform_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06006D83 RID: 28035 RVA: 0x001E6B18 File Offset: 0x001E4D18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219032, RefRangeEnd = 219033, XrefRangeStart = 218995, XrefRangeEnd = 219032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetValidExitPoint(List<Transform> possibleExitPoints)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(possibleExitPoints);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetValidExitPoint_Private_Transform_List_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06006D84 RID: 28036 RVA: 0x001E6B68 File Offset: 0x001E4D68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219067, RefRangeEnd = 219068, XrefRangeStart = 219033, XrefRangeEnd = 219067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNPCOccupant(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_AddNPCOccupant_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D85 RID: 28037 RVA: 0x001E6BAC File Offset: 0x001E4DAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219100, RefRangeEnd = 219101, XrefRangeStart = 219068, XrefRangeEnd = 219100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveNPCOccupant(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RemoveNPCOccupant_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D86 RID: 28038 RVA: 0x001E6BF0 File Offset: 0x001E4DF0
		[CallerCount(0)]
		public unsafe virtual bool CanBeRecovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_CanBeRecovered_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006D87 RID: 28039 RVA: 0x001E6C38 File Offset: 0x001E4E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219101, XrefRangeEnd = 219117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RecoverVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_RecoverVehicle_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D88 RID: 28040 RVA: 0x001E6C74 File Offset: 0x001E4E74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219138, RefRangeEnd = 219139, XrefRangeStart = 219117, XrefRangeEnd = 219138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOwnedColor(EVehicleColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SendOwnedColor_Public_Void_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D89 RID: 28041 RVA: 0x001E6CB4 File Offset: 0x001E4EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219139, XrefRangeEnd = 219181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetOwnedColor(NetworkConnection conn, EVehicleColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_SetOwnedColor_Protected_Virtual_New_Void_NetworkConnection_EVehicleColor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D8A RID: 28042 RVA: 0x001E6D10 File Offset: 0x001E4F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219181, XrefRangeEnd = 219198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyColor(EVehicleColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_ApplyColor_Public_Virtual_New_Void_EVehicleColor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D8B RID: 28043 RVA: 0x001E6D5C File Offset: 0x001E4F5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219198, RefRangeEnd = 219199, XrefRangeStart = 219198, XrefRangeEnd = 219198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyOwnedColor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_ApplyOwnedColor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D8C RID: 28044 RVA: 0x001E6D90 File Offset: 0x001E4F90
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 219242, RefRangeEnd = 219245, XrefRangeStart = 219199, XrefRangeEnd = 219242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowOutline(BuildableItem.EOutlineColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_ShowOutline_Public_Void_EOutlineColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D8D RID: 28045 RVA: 0x001E6DD0 File Offset: 0x001E4FD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 219250, RefRangeEnd = 219252, XrefRangeStart = 219245, XrefRangeEnd = 219250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideOutline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_HideOutline_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D8E RID: 28046 RVA: 0x001E6E04 File Offset: 0x001E5004
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 219294, RefRangeEnd = 219296, XrefRangeStart = 219252, XrefRangeEnd = 219294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Park_Networked(NetworkConnection conn, ParkData parkData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parkData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_Park_Networked_Private_Void_NetworkConnection_ParkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D8F RID: 28047 RVA: 0x001E6E58 File Offset: 0x001E5058
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 219331, RefRangeEnd = 219337, XrefRangeStart = 219296, XrefRangeEnd = 219331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Park(NetworkConnection conn, ParkData parkData, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parkData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_Park_Public_Void_NetworkConnection_ParkData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D90 RID: 28048 RVA: 0x001E6EBC File Offset: 0x001E50BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219379, RefRangeEnd = 219380, XrefRangeStart = 219337, XrefRangeEnd = 219379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitPark_Networked(NetworkConnection conn, bool moveToExitPoint = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveToExitPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_ExitPark_Networked_Public_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D91 RID: 28049 RVA: 0x001E6F0C File Offset: 0x001E510C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 219398, RefRangeEnd = 219404, XrefRangeStart = 219380, XrefRangeEnd = 219398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitPark(bool moveToExitPoint = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref moveToExitPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_ExitPark_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D92 RID: 28050 RVA: 0x001E6F4C File Offset: 0x001E514C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 219411, RefRangeEnd = 219415, XrefRangeStart = 219404, XrefRangeEnd = 219411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D93 RID: 28051 RVA: 0x001E6F8C File Offset: 0x001E518C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219415, XrefRangeEnd = 219429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ItemInstance> GetContents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetContents_Public_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemInstance>>(intPtr3) : null;
		}

		// Token: 0x06006D94 RID: 28052 RVA: 0x001E6FCC File Offset: 0x001E51CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219429, XrefRangeEnd = 219438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06006D95 RID: 28053 RVA: 0x001E7010 File Offset: 0x001E5210
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 219466, RefRangeEnd = 219468, XrefRangeStart = 219438, XrefRangeEnd = 219466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06006D96 RID: 28054 RVA: 0x001E706C File Offset: 0x001E526C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219499, RefRangeEnd = 219500, XrefRangeStart = 219468, XrefRangeEnd = 219499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(VehicleData data, string containerPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(containerPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_VehicleData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D97 RID: 28055 RVA: 0x001E70CC File Offset: 0x001E52CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 219587, RefRangeEnd = 219589, XrefRangeStart = 219500, XrefRangeEnd = 219587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LandVehicle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D98 RID: 28056 RVA: 0x001E7108 File Offset: 0x001E5308
		[CallerCount(0)]
		public unsafe bool _ApplyColor_b__249_0(VehicleColors.VehicleColorData x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr__ApplyColor_b__249_0_Private_Boolean_VehicleColorData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006D99 RID: 28057 RVA: 0x001E7158 File Offset: 0x001E5358
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 219725, RefRangeEnd = 219727, XrefRangeStart = 219589, XrefRangeEnd = 219725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D9A RID: 28058 RVA: 0x001E7194 File Offset: 0x001E5394
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219727, RefRangeEnd = 219728, XrefRangeStart = 219727, XrefRangeEnd = 219727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D9B RID: 28059 RVA: 0x001E71D0 File Offset: 0x001E53D0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D9C RID: 28060 RVA: 0x001E720C File Offset: 0x001E540C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219728, XrefRangeEnd = 219747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetIsPlayerOwned_214505783(NetworkConnection conn, bool playerOwned)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerOwned;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_SetIsPlayerOwned_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D9D RID: 28061 RVA: 0x001E725C File Offset: 0x001E545C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 219758, RefRangeEnd = 219761, XrefRangeStart = 219747, XrefRangeEnd = 219758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetIsPlayerOwned_214505783(NetworkConnection conn, bool playerOwned)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerOwned;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___SetIsPlayerOwned_214505783_Public_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D9E RID: 28062 RVA: 0x001E72AC File Offset: 0x001E54AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219761, XrefRangeEnd = 219764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetIsPlayerOwned_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_SetIsPlayerOwned_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D9F RID: 28063 RVA: 0x001E72FC File Offset: 0x001E54FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219764, XrefRangeEnd = 219783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetIsPlayerOwned_214505783(NetworkConnection conn, bool playerOwned)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerOwned;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_SetIsPlayerOwned_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DA0 RID: 28064 RVA: 0x001E734C File Offset: 0x001E554C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219783, XrefRangeEnd = 219786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetIsPlayerOwned_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Target_SetIsPlayerOwned_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DA1 RID: 28065 RVA: 0x001E739C File Offset: 0x001E559C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetOwner_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetOwner_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DA2 RID: 28066 RVA: 0x001E73E0 File Offset: 0x001E55E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219786, XrefRangeEnd = 219788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetOwner_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_RpcLogic___SetOwner_328543758_Protected_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DA3 RID: 28067 RVA: 0x001E7430 File Offset: 0x001E5630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219788, XrefRangeEnd = 219791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetOwner_328543758(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetOwner_328543758_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DA4 RID: 28068 RVA: 0x001E7494 File Offset: 0x001E5694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_OnOwnerChanged_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_OnOwnerChanged_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DA5 RID: 28069 RVA: 0x001E74C8 File Offset: 0x001E56C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219816, RefRangeEnd = 219817, XrefRangeStart = 219791, XrefRangeEnd = 219816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___OnOwnerChanged_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_RpcLogic___OnOwnerChanged_2166136261_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DA6 RID: 28070 RVA: 0x001E7504 File Offset: 0x001E5704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219817, XrefRangeEnd = 219819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_OnOwnerChanged_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_OnOwnerChanged_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DA7 RID: 28071 RVA: 0x001E7554 File Offset: 0x001E5754
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 219852, RefRangeEnd = 219854, XrefRangeStart = 219819, XrefRangeEnd = 219852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetTransform_Server_3848837105(Vector3 pos, Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetTransform_Server_3848837105_Private_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DA8 RID: 28072 RVA: 0x001E75A0 File Offset: 0x001E57A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219854, XrefRangeEnd = 219855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetTransform_Server_3848837105(Vector3 pos, Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___SetTransform_Server_3848837105_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DA9 RID: 28073 RVA: 0x001E75EC File Offset: 0x001E57EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219855, XrefRangeEnd = 219863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetTransform_Server_3848837105(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetTransform_Server_3848837105_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DAA RID: 28074 RVA: 0x001E7650 File Offset: 0x001E5850
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219887, RefRangeEnd = 219888, XrefRangeStart = 219863, XrefRangeEnd = 219887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetTransform_3848837105(Vector3 pos, Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_SetTransform_3848837105_Private_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DAB RID: 28075 RVA: 0x001E769C File Offset: 0x001E589C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219888, XrefRangeEnd = 219894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetTransform_3848837105(Vector3 pos, Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___SetTransform_3848837105_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DAC RID: 28076 RVA: 0x001E76E8 File Offset: 0x001E58E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219894, XrefRangeEnd = 219907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetTransform_3848837105(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_SetTransform_3848837105_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DAD RID: 28077 RVA: 0x001E7738 File Offset: 0x001E5938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetSteeringAngle_431000436(float sa)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sa;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetSteeringAngle_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DAE RID: 28078 RVA: 0x001E7778 File Offset: 0x001E5978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219907, XrefRangeEnd = 219914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetSteeringAngle_431000436(float sa)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sa;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___SetSteeringAngle_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DAF RID: 28079 RVA: 0x001E77B8 File Offset: 0x001E59B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219914, XrefRangeEnd = 219923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetSteeringAngle_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetSteeringAngle_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DB0 RID: 28080 RVA: 0x001E781C File Offset: 0x001E5A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219923, XrefRangeEnd = 219944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetSeatOccupant_3428404692(NetworkConnection conn, int seatIndex, NetworkConnection occupant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seatIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(occupant);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DB1 RID: 28081 RVA: 0x001E7880 File Offset: 0x001E5A80
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 219973, RefRangeEnd = 219976, XrefRangeStart = 219944, XrefRangeEnd = 219973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetSeatOccupant_3428404692(NetworkConnection conn, int seatIndex, NetworkConnection occupant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seatIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(occupant);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DB2 RID: 28082 RVA: 0x001E78E4 File Offset: 0x001E5AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219976, XrefRangeEnd = 219982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetSeatOccupant_3428404692(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_SetSeatOccupant_3428404692_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DB3 RID: 28083 RVA: 0x001E7934 File Offset: 0x001E5B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219982, XrefRangeEnd = 219994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetSeatOccupant_3428404692(NetworkConnection conn, int seatIndex, NetworkConnection occupant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seatIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(occupant);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DB4 RID: 28084 RVA: 0x001E7998 File Offset: 0x001E5B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219994, XrefRangeEnd = 220000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetSeatOccupant_3428404692(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Target_SetSeatOccupant_3428404692_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DB5 RID: 28085 RVA: 0x001E79E8 File Offset: 0x001E5BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220000, XrefRangeEnd = 220021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetSeatOccupant_Server_3266232555(int seatIndex, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref seatIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetSeatOccupant_Server_3266232555_Private_Void_Int32_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DB6 RID: 28086 RVA: 0x001E7A38 File Offset: 0x001E5C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220021, XrefRangeEnd = 220022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetSeatOccupant_Server_3266232555(int seatIndex, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref seatIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___SetSeatOccupant_Server_3266232555_Private_Void_Int32_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DB7 RID: 28087 RVA: 0x001E7A88 File Offset: 0x001E5C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220022, XrefRangeEnd = 220028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetSeatOccupant_Server_3266232555(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetSeatOccupant_Server_3266232555_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DB8 RID: 28088 RVA: 0x001E7AEC File Offset: 0x001E5CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220028, XrefRangeEnd = 220047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendOwnedColor_911055161(EVehicleColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SendOwnedColor_911055161_Private_Void_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DB9 RID: 28089 RVA: 0x001E7B2C File Offset: 0x001E5D2C
		[CallerCount(0)]
		public unsafe void RpcLogic___SendOwnedColor_911055161(EVehicleColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___SendOwnedColor_911055161_Public_Void_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DBA RID: 28090 RVA: 0x001E7B6C File Offset: 0x001E5D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220047, XrefRangeEnd = 220050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendOwnedColor_911055161(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SendOwnedColor_911055161_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DBB RID: 28091 RVA: 0x001E7BD0 File Offset: 0x001E5DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220050, XrefRangeEnd = 220069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetOwnedColor_1679996372(NetworkConnection conn, EVehicleColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_SetOwnedColor_1679996372_Private_Void_NetworkConnection_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DBC RID: 28092 RVA: 0x001E7C20 File Offset: 0x001E5E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220069, XrefRangeEnd = 220070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetOwnedColor_1679996372(NetworkConnection conn, EVehicleColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_RpcLogic___SetOwnedColor_1679996372_Protected_Virtual_New_Void_NetworkConnection_EVehicleColor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DBD RID: 28093 RVA: 0x001E7C7C File Offset: 0x001E5E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220070, XrefRangeEnd = 220074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetOwnedColor_1679996372(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Target_SetOwnedColor_1679996372_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DBE RID: 28094 RVA: 0x001E7CCC File Offset: 0x001E5ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220074, XrefRangeEnd = 220093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetOwnedColor_1679996372(NetworkConnection conn, EVehicleColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_SetOwnedColor_1679996372_Private_Void_NetworkConnection_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DBF RID: 28095 RVA: 0x001E7D1C File Offset: 0x001E5F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220093, XrefRangeEnd = 220097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetOwnedColor_1679996372(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_SetOwnedColor_1679996372_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DC0 RID: 28096 RVA: 0x001E7D6C File Offset: 0x001E5F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220097, XrefRangeEnd = 220116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Park_Networked_2633993806(NetworkConnection conn, ParkData parkData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parkData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DC1 RID: 28097 RVA: 0x001E7DC0 File Offset: 0x001E5FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220116, XrefRangeEnd = 220117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Park_Networked_2633993806(NetworkConnection conn, ParkData parkData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parkData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DC2 RID: 28098 RVA: 0x001E7E14 File Offset: 0x001E6014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220117, XrefRangeEnd = 220121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Park_Networked_2633993806(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_Park_Networked_2633993806_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DC3 RID: 28099 RVA: 0x001E7E64 File Offset: 0x001E6064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220121, XrefRangeEnd = 220140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_Park_Networked_2633993806(NetworkConnection conn, ParkData parkData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parkData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DC4 RID: 28100 RVA: 0x001E7EB8 File Offset: 0x001E60B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220140, XrefRangeEnd = 220144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_Park_Networked_2633993806(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Target_Park_Networked_2633993806_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DC5 RID: 28101 RVA: 0x001E7F08 File Offset: 0x001E6108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220144, XrefRangeEnd = 220163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ExitPark_Networked_214505783(NetworkConnection conn, bool moveToExitPoint = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveToExitPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_ExitPark_Networked_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DC6 RID: 28102 RVA: 0x001E7F58 File Offset: 0x001E6158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220163, XrefRangeEnd = 220164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ExitPark_Networked_214505783(NetworkConnection conn, bool moveToExitPoint = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveToExitPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___ExitPark_Networked_214505783_Public_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DC7 RID: 28103 RVA: 0x001E7FA8 File Offset: 0x001E61A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220164, XrefRangeEnd = 220167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ExitPark_Networked_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_ExitPark_Networked_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DC8 RID: 28104 RVA: 0x001E7FF8 File Offset: 0x001E61F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220167, XrefRangeEnd = 220186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ExitPark_Networked_214505783(NetworkConnection conn, bool moveToExitPoint = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveToExitPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_ExitPark_Networked_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DC9 RID: 28105 RVA: 0x001E8048 File Offset: 0x001E6248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220186, XrefRangeEnd = 220189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ExitPark_Networked_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Target_ExitPark_Networked_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700214F RID: 8527
		// (get) Token: 0x06006DCA RID: 28106 RVA: 0x001E8098 File Offset: 0x001E6298
		// (set) Token: 0x06006DCB RID: 28107 RVA: 0x001E80D4 File Offset: 0x001E62D4
		public unsafe float SyncAccessor_currentSteerAngle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_sync___get_value_currentSteerAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 220197, RefRangeEnd = 220201, XrefRangeStart = 220189, XrefRangeEnd = 220197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_sync___set_value_currentSteerAngle_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006DCC RID: 28108 RVA: 0x001E8120 File Offset: 0x001E6320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220201, XrefRangeEnd = 220206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Vehicles_LandVehicle(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Vehicles_LandVehicle_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17002150 RID: 8528
		// (get) Token: 0x06006DCD RID: 28109 RVA: 0x001E8194 File Offset: 0x001E6394
		// (set) Token: 0x06006DCE RID: 28110 RVA: 0x001E81D0 File Offset: 0x001E63D0
		public unsafe bool SyncAccessor_<brakesApplied>k__BackingField
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 217958, RefRangeEnd = 217960, XrefRangeStart = 217958, XrefRangeEnd = 217960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_sync___get_value__brakesApplied_k__BackingField_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220206, XrefRangeEnd = 220214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_sync___set_value__brakesApplied_k__BackingField_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002151 RID: 8529
		// (get) Token: 0x06006DCF RID: 28111 RVA: 0x001E821C File Offset: 0x001E641C
		// (set) Token: 0x06006DD0 RID: 28112 RVA: 0x001E8258 File Offset: 0x001E6458
		public unsafe bool SyncAccessor_<isReversing>k__BackingField
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 217972, RefRangeEnd = 217974, XrefRangeStart = 217972, XrefRangeEnd = 217974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_sync___get_value__isReversing_k__BackingField_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220214, XrefRangeEnd = 220222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_sync___set_value__isReversing_k__BackingField_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006DD1 RID: 28113 RVA: 0x001E82A4 File Offset: 0x001E64A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 220264, RefRangeEnd = 220267, XrefRangeStart = 220222, XrefRangeEnd = 220264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DD2 RID: 28114 RVA: 0x00033A42 File Offset: 0x00031C42
		public LandVehicle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020C8 RID: 8392
		// (get) Token: 0x06006DD3 RID: 28115 RVA: 0x001E82E0 File Offset: 0x001E64E0
		// (set) Token: 0x06006DD4 RID: 28116 RVA: 0x00033A4B File Offset: 0x00031C4B
		public unsafe static float KINEMATIC_THRESHOLD_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LandVehicle.NativeFieldInfoPtr_KINEMATIC_THRESHOLD_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LandVehicle.NativeFieldInfoPtr_KINEMATIC_THRESHOLD_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x170020C9 RID: 8393
		// (get) Token: 0x06006DD5 RID: 28117 RVA: 0x001E82FC File Offset: 0x001E64FC
		// (set) Token: 0x06006DD6 RID: 28118 RVA: 0x00033A59 File Offset: 0x00031C59
		public unsafe static float MAX_TURNOVER_SPEED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LandVehicle.NativeFieldInfoPtr_MAX_TURNOVER_SPEED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LandVehicle.NativeFieldInfoPtr_MAX_TURNOVER_SPEED, (void*)(&value));
			}
		}

		// Token: 0x170020CA RID: 8394
		// (get) Token: 0x06006DD7 RID: 28119 RVA: 0x001E8318 File Offset: 0x001E6518
		// (set) Token: 0x06006DD8 RID: 28120 RVA: 0x00033A67 File Offset: 0x00031C67
		public unsafe static float TURNOVER_FORCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LandVehicle.NativeFieldInfoPtr_TURNOVER_FORCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LandVehicle.NativeFieldInfoPtr_TURNOVER_FORCE, (void*)(&value));
			}
		}

		// Token: 0x170020CB RID: 8395
		// (get) Token: 0x06006DD9 RID: 28121 RVA: 0x001E8334 File Offset: 0x001E6534
		// (set) Token: 0x06006DDA RID: 28122 RVA: 0x00033A75 File Offset: 0x00031C75
		public unsafe static bool USE_WHEEL
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(LandVehicle.NativeFieldInfoPtr_USE_WHEEL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LandVehicle.NativeFieldInfoPtr_USE_WHEEL, (void*)(&value));
			}
		}

		// Token: 0x170020CC RID: 8396
		// (get) Token: 0x06006DDB RID: 28123 RVA: 0x001E8350 File Offset: 0x001E6550
		// (set) Token: 0x06006DDC RID: 28124 RVA: 0x00033A83 File Offset: 0x00031C83
		public unsafe static float SPEED_DISPLAY_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LandVehicle.NativeFieldInfoPtr_SPEED_DISPLAY_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LandVehicle.NativeFieldInfoPtr_SPEED_DISPLAY_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x170020CD RID: 8397
		// (get) Token: 0x06006DDD RID: 28125 RVA: 0x001E836C File Offset: 0x001E656C
		// (set) Token: 0x06006DDE RID: 28126 RVA: 0x00033A91 File Offset: 0x00031C91
		public unsafe bool DEBUG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x170020CE RID: 8398
		// (get) Token: 0x06006DDF RID: 28127 RVA: 0x001E8394 File Offset: 0x001E6594
		// (set) Token: 0x06006DE0 RID: 28128 RVA: 0x00033AAC File Offset: 0x00031CAC
		public unsafe string vehicleName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_vehicleName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_vehicleName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170020CF RID: 8399
		// (get) Token: 0x06006DE1 RID: 28129 RVA: 0x001E83BC File Offset: 0x001E65BC
		// (set) Token: 0x06006DE2 RID: 28130 RVA: 0x00033ACB File Offset: 0x00031CCB
		public unsafe string vehicleCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_vehicleCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_vehicleCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170020D0 RID: 8400
		// (get) Token: 0x06006DE3 RID: 28131 RVA: 0x001E83E4 File Offset: 0x001E65E4
		// (set) Token: 0x06006DE4 RID: 28132 RVA: 0x00033AEA File Offset: 0x00031CEA
		public unsafe float vehiclePrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_vehiclePrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_vehiclePrice)) = value;
			}
		}

		// Token: 0x170020D1 RID: 8401
		// (get) Token: 0x06006DE5 RID: 28133 RVA: 0x001E840C File Offset: 0x001E660C
		// (set) Token: 0x06006DE6 RID: 28134 RVA: 0x00033B05 File Offset: 0x00031D05
		public unsafe bool _IsPlayerOwned_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__IsPlayerOwned_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__IsPlayerOwned_k__BackingField)) = value;
			}
		}

		// Token: 0x170020D2 RID: 8402
		// (get) Token: 0x06006DE7 RID: 28135 RVA: 0x001E8434 File Offset: 0x001E6634
		// (set) Token: 0x06006DE8 RID: 28136 RVA: 0x00033B20 File Offset: 0x00031D20
		public unsafe bool _IsVisible_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__IsVisible_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__IsVisible_k__BackingField)) = value;
			}
		}

		// Token: 0x170020D3 RID: 8403
		// (get) Token: 0x06006DE9 RID: 28137 RVA: 0x001E845C File Offset: 0x001E665C
		// (set) Token: 0x06006DEA RID: 28138 RVA: 0x00033B3B File Offset: 0x00031D3B
		public unsafe bool UseHumanoidCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_UseHumanoidCollider);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_UseHumanoidCollider)) = value;
			}
		}

		// Token: 0x170020D4 RID: 8404
		// (get) Token: 0x06006DEB RID: 28139 RVA: 0x001E8484 File Offset: 0x001E6684
		// (set) Token: 0x06006DEC RID: 28140 RVA: 0x00033B56 File Offset: 0x00031D56
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x170020D5 RID: 8405
		// (get) Token: 0x06006DED RID: 28141 RVA: 0x001E84AC File Offset: 0x001E66AC
		// (set) Token: 0x06006DEE RID: 28142 RVA: 0x00033B71 File Offset: 0x00031D71
		public unsafe bool SpawnAsPlayerOwned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_SpawnAsPlayerOwned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_SpawnAsPlayerOwned)) = value;
			}
		}

		// Token: 0x170020D6 RID: 8406
		// (get) Token: 0x06006DEF RID: 28143 RVA: 0x001E84D4 File Offset: 0x001E66D4
		// (set) Token: 0x06006DF0 RID: 28144 RVA: 0x00033B8C File Offset: 0x00031D8C
		public unsafe float _DistanceToLocalCamera_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__DistanceToLocalCamera_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__DistanceToLocalCamera_k__BackingField)) = value;
			}
		}

		// Token: 0x170020D7 RID: 8407
		// (get) Token: 0x06006DF1 RID: 28145 RVA: 0x001E84FC File Offset: 0x001E66FC
		// (set) Token: 0x06006DF2 RID: 28146 RVA: 0x00033BA7 File Offset: 0x00031DA7
		public unsafe GameObject vehicleModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_vehicleModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_vehicleModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020D8 RID: 8408
		// (get) Token: 0x06006DF3 RID: 28147 RVA: 0x001E852C File Offset: 0x001E672C
		// (set) Token: 0x06006DF4 RID: 28148 RVA: 0x00033BC6 File Offset: 0x00031DC6
		public unsafe Il2CppReferenceArray<WheelCollider> driveWheels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_driveWheels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WheelCollider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_driveWheels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020D9 RID: 8409
		// (get) Token: 0x06006DF5 RID: 28149 RVA: 0x001E855C File Offset: 0x001E675C
		// (set) Token: 0x06006DF6 RID: 28150 RVA: 0x00033BE5 File Offset: 0x00031DE5
		public unsafe Il2CppReferenceArray<WheelCollider> steerWheels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_steerWheels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WheelCollider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_steerWheels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020DA RID: 8410
		// (get) Token: 0x06006DF7 RID: 28151 RVA: 0x001E858C File Offset: 0x001E678C
		// (set) Token: 0x06006DF8 RID: 28152 RVA: 0x00033C04 File Offset: 0x00031E04
		public unsafe Il2CppReferenceArray<WheelCollider> handbrakeWheels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_handbrakeWheels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WheelCollider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_handbrakeWheels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020DB RID: 8411
		// (get) Token: 0x06006DF9 RID: 28153 RVA: 0x001E85BC File Offset: 0x001E67BC
		// (set) Token: 0x06006DFA RID: 28154 RVA: 0x00033C23 File Offset: 0x00031E23
		public unsafe List<Wheel> wheels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_wheels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Wheel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_wheels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020DC RID: 8412
		// (get) Token: 0x06006DFB RID: 28155 RVA: 0x001E85EC File Offset: 0x001E67EC
		// (set) Token: 0x06006DFC RID: 28156 RVA: 0x00033C42 File Offset: 0x00031E42
		public unsafe InteractableObject intObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_intObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_intObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020DD RID: 8413
		// (get) Token: 0x06006DFD RID: 28157 RVA: 0x001E861C File Offset: 0x001E681C
		// (set) Token: 0x06006DFE RID: 28158 RVA: 0x00033C61 File Offset: 0x00031E61
		public unsafe List<Transform> exitPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_exitPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_exitPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020DE RID: 8414
		// (get) Token: 0x06006DFF RID: 28159 RVA: 0x001E864C File Offset: 0x001E684C
		// (set) Token: 0x06006E00 RID: 28160 RVA: 0x00033C80 File Offset: 0x00031E80
		public unsafe Rigidbody rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020DF RID: 8415
		// (get) Token: 0x06006E01 RID: 28161 RVA: 0x001E867C File Offset: 0x001E687C
		// (set) Token: 0x06006E02 RID: 28162 RVA: 0x00033C9F File Offset: 0x00031E9F
		public unsafe Il2CppReferenceArray<VehicleSeat> Seats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Seats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VehicleSeat>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Seats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020E0 RID: 8416
		// (get) Token: 0x06006E03 RID: 28163 RVA: 0x001E86AC File Offset: 0x001E68AC
		// (set) Token: 0x06006E04 RID: 28164 RVA: 0x00033CBE File Offset: 0x00031EBE
		public unsafe BoxCollider boundingBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_boundingBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_boundingBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020E1 RID: 8417
		// (get) Token: 0x06006E05 RID: 28165 RVA: 0x001E86DC File Offset: 0x001E68DC
		// (set) Token: 0x06006E06 RID: 28166 RVA: 0x00033CDD File Offset: 0x00031EDD
		public unsafe VehicleAgent Agent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Agent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleAgent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Agent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020E2 RID: 8418
		// (get) Token: 0x06006E07 RID: 28167 RVA: 0x001E870C File Offset: 0x001E690C
		// (set) Token: 0x06006E08 RID: 28168 RVA: 0x00033CFC File Offset: 0x00031EFC
		public unsafe SmoothedVelocityCalculator VelocityCalculator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_VelocityCalculator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_VelocityCalculator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020E3 RID: 8419
		// (get) Token: 0x06006E09 RID: 28169 RVA: 0x001E873C File Offset: 0x001E693C
		// (set) Token: 0x06006E0A RID: 28170 RVA: 0x00033D1B File Offset: 0x00031F1B
		public unsafe StorageDoorAnimation Trunk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Trunk);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageDoorAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Trunk), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020E4 RID: 8420
		// (get) Token: 0x06006E0B RID: 28171 RVA: 0x001E876C File Offset: 0x001E696C
		// (set) Token: 0x06006E0C RID: 28172 RVA: 0x00033D3A File Offset: 0x00031F3A
		public unsafe NavMeshObstacle NavMeshObstacle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_NavMeshObstacle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavMeshObstacle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_NavMeshObstacle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020E5 RID: 8421
		// (get) Token: 0x06006E0D RID: 28173 RVA: 0x001E879C File Offset: 0x001E699C
		// (set) Token: 0x06006E0E RID: 28174 RVA: 0x00033D59 File Offset: 0x00031F59
		public unsafe NavmeshCut NavmeshCut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_NavmeshCut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavmeshCut>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_NavmeshCut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020E6 RID: 8422
		// (get) Token: 0x06006E0F RID: 28175 RVA: 0x001E87CC File Offset: 0x001E69CC
		// (set) Token: 0x06006E10 RID: 28176 RVA: 0x00033D78 File Offset: 0x00031F78
		public unsafe VehicleHumanoidCollider HumanoidColliderContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_HumanoidColliderContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleHumanoidCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_HumanoidColliderContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020E7 RID: 8423
		// (get) Token: 0x06006E11 RID: 28177 RVA: 0x001E87FC File Offset: 0x001E69FC
		// (set) Token: 0x06006E12 RID: 28178 RVA: 0x00033D97 File Offset: 0x00031F97
		public unsafe POI POI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_POI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_POI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020E8 RID: 8424
		// (get) Token: 0x06006E13 RID: 28179 RVA: 0x001E882C File Offset: 0x001E6A2C
		// (set) Token: 0x06006E14 RID: 28180 RVA: 0x00033DB6 File Offset: 0x00031FB6
		public unsafe Transform centerOfMass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_centerOfMass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_centerOfMass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020E9 RID: 8425
		// (get) Token: 0x06006E15 RID: 28181 RVA: 0x001E885C File Offset: 0x001E6A5C
		// (set) Token: 0x06006E16 RID: 28182 RVA: 0x00033DD5 File Offset: 0x00031FD5
		public unsafe Transform cameraOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_cameraOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_cameraOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020EA RID: 8426
		// (get) Token: 0x06006E17 RID: 28183 RVA: 0x001E888C File Offset: 0x001E6A8C
		// (set) Token: 0x06006E18 RID: 28184 RVA: 0x00033DF4 File Offset: 0x00031FF4
		public unsafe VehicleLights lights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_lights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleLights>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_lights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020EB RID: 8427
		// (get) Token: 0x06006E19 RID: 28185 RVA: 0x001E88BC File Offset: 0x001E6ABC
		// (set) Token: 0x06006E1A RID: 28186 RVA: 0x00033E13 File Offset: 0x00032013
		public unsafe float maxSteeringAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_maxSteeringAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_maxSteeringAngle)) = value;
			}
		}

		// Token: 0x170020EC RID: 8428
		// (get) Token: 0x06006E1B RID: 28187 RVA: 0x001E88E4 File Offset: 0x001E6AE4
		// (set) Token: 0x06006E1C RID: 28188 RVA: 0x00033E2E File Offset: 0x0003202E
		public unsafe float steerRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_steerRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_steerRate)) = value;
			}
		}

		// Token: 0x170020ED RID: 8429
		// (get) Token: 0x06006E1D RID: 28189 RVA: 0x001E890C File Offset: 0x001E6B0C
		// (set) Token: 0x06006E1E RID: 28190 RVA: 0x00033E49 File Offset: 0x00032049
		public unsafe bool flipSteer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_flipSteer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_flipSteer)) = value;
			}
		}

		// Token: 0x170020EE RID: 8430
		// (get) Token: 0x06006E1F RID: 28191 RVA: 0x001E8934 File Offset: 0x001E6B34
		// (set) Token: 0x06006E20 RID: 28192 RVA: 0x00033E64 File Offset: 0x00032064
		public unsafe bool _MaxSteerAngleOverridden_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__MaxSteerAngleOverridden_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__MaxSteerAngleOverridden_k__BackingField)) = value;
			}
		}

		// Token: 0x170020EF RID: 8431
		// (get) Token: 0x06006E21 RID: 28193 RVA: 0x001E895C File Offset: 0x001E6B5C
		// (set) Token: 0x06006E22 RID: 28194 RVA: 0x00033E7F File Offset: 0x0003207F
		public unsafe float _OverriddenMaxSteerAngle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__OverriddenMaxSteerAngle_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__OverriddenMaxSteerAngle_k__BackingField)) = value;
			}
		}

		// Token: 0x170020F0 RID: 8432
		// (get) Token: 0x06006E23 RID: 28195 RVA: 0x001E8984 File Offset: 0x001E6B84
		// (set) Token: 0x06006E24 RID: 28196 RVA: 0x00033E9A File Offset: 0x0003209A
		public unsafe AnimationCurve motorTorque
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_motorTorque);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_motorTorque), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020F1 RID: 8433
		// (get) Token: 0x06006E25 RID: 28197 RVA: 0x001E89B4 File Offset: 0x001E6BB4
		// (set) Token: 0x06006E26 RID: 28198 RVA: 0x00033EB9 File Offset: 0x000320B9
		public unsafe float TopSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_TopSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_TopSpeed)) = value;
			}
		}

		// Token: 0x170020F2 RID: 8434
		// (get) Token: 0x06006E27 RID: 28199 RVA: 0x001E89DC File Offset: 0x001E6BDC
		// (set) Token: 0x06006E28 RID: 28200 RVA: 0x00033ED4 File Offset: 0x000320D4
		public unsafe float diffGearing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_diffGearing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_diffGearing)) = value;
			}
		}

		// Token: 0x170020F3 RID: 8435
		// (get) Token: 0x06006E29 RID: 28201 RVA: 0x001E8A04 File Offset: 0x001E6C04
		// (set) Token: 0x06006E2A RID: 28202 RVA: 0x00033EEF File Offset: 0x000320EF
		public unsafe float handBrakeForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_handBrakeForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_handBrakeForce)) = value;
			}
		}

		// Token: 0x170020F4 RID: 8436
		// (get) Token: 0x06006E2B RID: 28203 RVA: 0x001E8A2C File Offset: 0x001E6C2C
		// (set) Token: 0x06006E2C RID: 28204 RVA: 0x00033F0A File Offset: 0x0003210A
		public unsafe AnimationCurve brakeForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_brakeForce);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_brakeForce), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020F5 RID: 8437
		// (get) Token: 0x06006E2D RID: 28205 RVA: 0x001E8A5C File Offset: 0x001E6C5C
		// (set) Token: 0x06006E2E RID: 28206 RVA: 0x00033F29 File Offset: 0x00032129
		public unsafe float downforce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_downforce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_downforce)) = value;
			}
		}

		// Token: 0x170020F6 RID: 8438
		// (get) Token: 0x06006E2F RID: 28207 RVA: 0x001E8A84 File Offset: 0x001E6C84
		// (set) Token: 0x06006E30 RID: 28208 RVA: 0x00033F44 File Offset: 0x00032144
		public unsafe float reverseMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_reverseMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_reverseMultiplier)) = value;
			}
		}

		// Token: 0x170020F7 RID: 8439
		// (get) Token: 0x06006E31 RID: 28209 RVA: 0x001E8AAC File Offset: 0x001E6CAC
		// (set) Token: 0x06006E32 RID: 28210 RVA: 0x00033F5F File Offset: 0x0003215F
		public unsafe Il2CppReferenceArray<LandVehicle.BodyMesh> BodyMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_BodyMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LandVehicle.BodyMesh>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_BodyMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020F8 RID: 8440
		// (get) Token: 0x06006E33 RID: 28211 RVA: 0x001E8ADC File Offset: 0x001E6CDC
		// (set) Token: 0x06006E34 RID: 28212 RVA: 0x00033F7E File Offset: 0x0003217E
		public unsafe EVehicleColor DefaultColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_DefaultColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_DefaultColor)) = value;
			}
		}

		// Token: 0x170020F9 RID: 8441
		// (get) Token: 0x06006E35 RID: 28213 RVA: 0x001E8B04 File Offset: 0x001E6D04
		// (set) Token: 0x06006E36 RID: 28214 RVA: 0x00033F99 File Offset: 0x00032199
		public unsafe EVehicleColor _OwnedColor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__OwnedColor_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__OwnedColor_k__BackingField)) = value;
			}
		}

		// Token: 0x170020FA RID: 8442
		// (get) Token: 0x06006E37 RID: 28215 RVA: 0x001E8B2C File Offset: 0x001E6D2C
		// (set) Token: 0x06006E38 RID: 28216 RVA: 0x00033FB4 File Offset: 0x000321B4
		public unsafe EVehicleColor DisplayedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_DisplayedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_DisplayedColor)) = value;
			}
		}

		// Token: 0x170020FB RID: 8443
		// (get) Token: 0x06006E39 RID: 28217 RVA: 0x001E8B54 File Offset: 0x001E6D54
		// (set) Token: 0x06006E3A RID: 28218 RVA: 0x00033FCF File Offset: 0x000321CF
		public unsafe List<GameObject> outlineRenderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_outlineRenderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_outlineRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020FC RID: 8444
		// (get) Token: 0x06006E3B RID: 28219 RVA: 0x001E8B84 File Offset: 0x001E6D84
		// (set) Token: 0x06006E3C RID: 28220 RVA: 0x00033FEE File Offset: 0x000321EE
		public unsafe Outlinable outlineEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_outlineEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Outlinable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_outlineEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020FD RID: 8445
		// (get) Token: 0x06006E3D RID: 28221 RVA: 0x001E8BB4 File Offset: 0x001E6DB4
		// (set) Token: 0x06006E3E RID: 28222 RVA: 0x0003400D File Offset: 0x0003220D
		public unsafe bool overrideControls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_overrideControls);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_overrideControls)) = value;
			}
		}

		// Token: 0x170020FE RID: 8446
		// (get) Token: 0x06006E3F RID: 28223 RVA: 0x001E8BDC File Offset: 0x001E6DDC
		// (set) Token: 0x06006E40 RID: 28224 RVA: 0x00034028 File Offset: 0x00032228
		public unsafe float throttleOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_throttleOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_throttleOverride)) = value;
			}
		}

		// Token: 0x170020FF RID: 8447
		// (get) Token: 0x06006E41 RID: 28225 RVA: 0x001E8C04 File Offset: 0x001E6E04
		// (set) Token: 0x06006E42 RID: 28226 RVA: 0x00034043 File Offset: 0x00032243
		public unsafe float steerOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_steerOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_steerOverride)) = value;
			}
		}

		// Token: 0x17002100 RID: 8448
		// (get) Token: 0x06006E43 RID: 28227 RVA: 0x001E8C2C File Offset: 0x001E6E2C
		// (set) Token: 0x06006E44 RID: 28228 RVA: 0x0003405E File Offset: 0x0003225E
		public unsafe StorageEntity Storage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Storage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Storage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002101 RID: 8449
		// (get) Token: 0x06006E45 RID: 28229 RVA: 0x001E8C5C File Offset: 0x001E6E5C
		// (set) Token: 0x06006E46 RID: 28230 RVA: 0x0003407D File Offset: 0x0003227D
		public unsafe VehicleSeat localPlayerSeat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_localPlayerSeat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleSeat>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_localPlayerSeat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002102 RID: 8450
		// (get) Token: 0x06006E47 RID: 28231 RVA: 0x001E8C8C File Offset: 0x001E6E8C
		// (set) Token: 0x06006E48 RID: 28232 RVA: 0x0003409C File Offset: 0x0003229C
		public unsafe bool _localPlayerIsDriver_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__localPlayerIsDriver_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__localPlayerIsDriver_k__BackingField)) = value;
			}
		}

		// Token: 0x17002103 RID: 8451
		// (get) Token: 0x06006E49 RID: 28233 RVA: 0x001E8CB4 File Offset: 0x001E6EB4
		// (set) Token: 0x06006E4A RID: 28234 RVA: 0x000340B7 File Offset: 0x000322B7
		public unsafe bool _localPlayerIsInVehicle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__localPlayerIsInVehicle_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__localPlayerIsInVehicle_k__BackingField)) = value;
			}
		}

		// Token: 0x17002104 RID: 8452
		// (get) Token: 0x06006E4B RID: 28235 RVA: 0x001E8CDC File Offset: 0x001E6EDC
		// (set) Token: 0x06006E4C RID: 28236 RVA: 0x000340D2 File Offset: 0x000322D2
		public unsafe bool _isOccupied_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__isOccupied_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__isOccupied_k__BackingField)) = value;
			}
		}

		// Token: 0x17002105 RID: 8453
		// (get) Token: 0x06006E4D RID: 28237 RVA: 0x001E8D04 File Offset: 0x001E6F04
		// (set) Token: 0x06006E4E RID: 28238 RVA: 0x000340ED File Offset: 0x000322ED
		public unsafe Il2CppReferenceArray<NPC> _OccupantNPCs_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__OccupantNPCs_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__OccupantNPCs_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002106 RID: 8454
		// (get) Token: 0x06006E4F RID: 28239 RVA: 0x001E8D34 File Offset: 0x001E6F34
		// (set) Token: 0x06006E50 RID: 28240 RVA: 0x0003410C File Offset: 0x0003230C
		public unsafe float _speed_Kmh_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__speed_Kmh_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__speed_Kmh_k__BackingField)) = value;
			}
		}

		// Token: 0x17002107 RID: 8455
		// (get) Token: 0x06006E51 RID: 28241 RVA: 0x001E8D5C File Offset: 0x001E6F5C
		// (set) Token: 0x06006E52 RID: 28242 RVA: 0x00034127 File Offset: 0x00032327
		public unsafe List<float> previousSpeeds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_previousSpeeds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_previousSpeeds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002108 RID: 8456
		// (get) Token: 0x06006E53 RID: 28243 RVA: 0x001E8D8C File Offset: 0x001E6F8C
		// (set) Token: 0x06006E54 RID: 28244 RVA: 0x00034146 File Offset: 0x00032346
		public unsafe int previousSpeedsSampleSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_previousSpeedsSampleSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_previousSpeedsSampleSize)) = value;
			}
		}

		// Token: 0x17002109 RID: 8457
		// (get) Token: 0x06006E55 RID: 28245 RVA: 0x001E8DB4 File Offset: 0x001E6FB4
		// (set) Token: 0x06006E56 RID: 28246 RVA: 0x00034161 File Offset: 0x00032361
		public unsafe float _currentThrottle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__currentThrottle_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__currentThrottle_k__BackingField)) = value;
			}
		}

		// Token: 0x1700210A RID: 8458
		// (get) Token: 0x06006E57 RID: 28247 RVA: 0x001E8DDC File Offset: 0x001E6FDC
		// (set) Token: 0x06006E58 RID: 28248 RVA: 0x0003417C File Offset: 0x0003237C
		public unsafe float currentSteerAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_currentSteerAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_currentSteerAngle)) = value;
			}
		}

		// Token: 0x1700210B RID: 8459
		// (get) Token: 0x06006E59 RID: 28249 RVA: 0x001E8E04 File Offset: 0x001E7004
		// (set) Token: 0x06006E5A RID: 28250 RVA: 0x00034197 File Offset: 0x00032397
		public unsafe float lastFrameSteerAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_lastFrameSteerAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_lastFrameSteerAngle)) = value;
			}
		}

		// Token: 0x1700210C RID: 8460
		// (get) Token: 0x06006E5B RID: 28251 RVA: 0x001E8E2C File Offset: 0x001E702C
		// (set) Token: 0x06006E5C RID: 28252 RVA: 0x000341B2 File Offset: 0x000323B2
		public unsafe float lastReplicatedSteerAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_lastReplicatedSteerAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_lastReplicatedSteerAngle)) = value;
			}
		}

		// Token: 0x1700210D RID: 8461
		// (get) Token: 0x06006E5D RID: 28253 RVA: 0x001E8E54 File Offset: 0x001E7054
		// (set) Token: 0x06006E5E RID: 28254 RVA: 0x000341CD File Offset: 0x000323CD
		public unsafe bool justExitedVehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_justExitedVehicle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_justExitedVehicle)) = value;
			}
		}

		// Token: 0x1700210E RID: 8462
		// (get) Token: 0x06006E5F RID: 28255 RVA: 0x001E8E7C File Offset: 0x001E707C
		// (set) Token: 0x06006E60 RID: 28256 RVA: 0x000341E8 File Offset: 0x000323E8
		public unsafe bool _brakesApplied_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__brakesApplied_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__brakesApplied_k__BackingField)) = value;
			}
		}

		// Token: 0x1700210F RID: 8463
		// (get) Token: 0x06006E61 RID: 28257 RVA: 0x001E8EA4 File Offset: 0x001E70A4
		// (set) Token: 0x06006E62 RID: 28258 RVA: 0x00034203 File Offset: 0x00032403
		public unsafe bool _isReversing_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__isReversing_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__isReversing_k__BackingField)) = value;
			}
		}

		// Token: 0x17002110 RID: 8464
		// (get) Token: 0x06006E63 RID: 28259 RVA: 0x001E8ECC File Offset: 0x001E70CC
		// (set) Token: 0x06006E64 RID: 28260 RVA: 0x0003421E File Offset: 0x0003241E
		public unsafe bool _isStatic_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__isStatic_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__isStatic_k__BackingField)) = value;
			}
		}

		// Token: 0x17002111 RID: 8465
		// (get) Token: 0x06006E65 RID: 28261 RVA: 0x001E8EF4 File Offset: 0x001E70F4
		// (set) Token: 0x06006E66 RID: 28262 RVA: 0x00034239 File Offset: 0x00032439
		public unsafe bool _handbrakeApplied_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__handbrakeApplied_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__handbrakeApplied_k__BackingField)) = value;
			}
		}

		// Token: 0x17002112 RID: 8466
		// (get) Token: 0x06006E67 RID: 28263 RVA: 0x001E8F1C File Offset: 0x001E711C
		// (set) Token: 0x06006E68 RID: 28264 RVA: 0x00034254 File Offset: 0x00032454
		public unsafe Vector3 lastFramePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_lastFramePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_lastFramePosition)) = value;
			}
		}

		// Token: 0x17002113 RID: 8467
		// (get) Token: 0x06006E69 RID: 28265 RVA: 0x001E8F44 File Offset: 0x001E7144
		// (set) Token: 0x06006E6A RID: 28266 RVA: 0x0003426F File Offset: 0x0003246F
		public unsafe Transform closestExitPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_closestExitPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_closestExitPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002114 RID: 8468
		// (get) Token: 0x06006E6B RID: 28267 RVA: 0x001E8F74 File Offset: 0x001E7174
		// (set) Token: 0x06006E6C RID: 28268 RVA: 0x0003428E File Offset: 0x0003248E
		public unsafe ParkData CurrentParkData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_CurrentParkData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParkData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_CurrentParkData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002115 RID: 8469
		// (get) Token: 0x06006E6D RID: 28269 RVA: 0x001E8FA4 File Offset: 0x001E71A4
		// (set) Token: 0x06006E6E RID: 28270 RVA: 0x000342AD File Offset: 0x000324AD
		public unsafe ParkingLot _CurrentParkingLot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__CurrentParkingLot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParkingLot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__CurrentParkingLot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002116 RID: 8470
		// (get) Token: 0x06006E6F RID: 28271 RVA: 0x001E8FD4 File Offset: 0x001E71D4
		// (set) Token: 0x06006E70 RID: 28272 RVA: 0x000342CC File Offset: 0x000324CC
		public unsafe ParkingSpot _CurrentParkingSpot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__CurrentParkingSpot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParkingSpot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__CurrentParkingSpot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002117 RID: 8471
		// (get) Token: 0x06006E71 RID: 28273 RVA: 0x001E9004 File Offset: 0x001E7204
		// (set) Token: 0x06006E72 RID: 28274 RVA: 0x000342EB File Offset: 0x000324EB
		public unsafe VehicleLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002118 RID: 8472
		// (get) Token: 0x06006E73 RID: 28275 RVA: 0x001E9034 File Offset: 0x001E7234
		// (set) Token: 0x06006E74 RID: 28276 RVA: 0x0003430A File Offset: 0x0003250A
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002119 RID: 8473
		// (get) Token: 0x06006E75 RID: 28277 RVA: 0x001E9064 File Offset: 0x001E7264
		// (set) Token: 0x06006E76 RID: 28278 RVA: 0x00034329 File Offset: 0x00032529
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700211A RID: 8474
		// (get) Token: 0x06006E77 RID: 28279 RVA: 0x001E9094 File Offset: 0x001E7294
		// (set) Token: 0x06006E78 RID: 28280 RVA: 0x00034348 File Offset: 0x00032548
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x1700211B RID: 8475
		// (get) Token: 0x06006E79 RID: 28281 RVA: 0x001E90BC File Offset: 0x001E72BC
		// (set) Token: 0x06006E7A RID: 28282 RVA: 0x00034363 File Offset: 0x00032563
		public unsafe LandVehicle.VehiclePlayerEvent onPlayerEnterVehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onPlayerEnterVehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle.VehiclePlayerEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onPlayerEnterVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700211C RID: 8476
		// (get) Token: 0x06006E7B RID: 28283 RVA: 0x001E90EC File Offset: 0x001E72EC
		// (set) Token: 0x06006E7C RID: 28284 RVA: 0x00034382 File Offset: 0x00032582
		public unsafe LandVehicle.VehiclePlayerEvent onPlayerExitVehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onPlayerExitVehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle.VehiclePlayerEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onPlayerExitVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700211D RID: 8477
		// (get) Token: 0x06006E7D RID: 28285 RVA: 0x001E911C File Offset: 0x001E731C
		// (set) Token: 0x06006E7E RID: 28286 RVA: 0x000343A1 File Offset: 0x000325A1
		public unsafe UnityEvent onVehicleStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onVehicleStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onVehicleStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700211E RID: 8478
		// (get) Token: 0x06006E7F RID: 28287 RVA: 0x001E914C File Offset: 0x001E734C
		// (set) Token: 0x06006E80 RID: 28288 RVA: 0x000343C0 File Offset: 0x000325C0
		public unsafe UnityEvent onVehicleStop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onVehicleStop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onVehicleStop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700211F RID: 8479
		// (get) Token: 0x06006E81 RID: 28289 RVA: 0x001E917C File Offset: 0x001E737C
		// (set) Token: 0x06006E82 RID: 28290 RVA: 0x000343DF File Offset: 0x000325DF
		public unsafe UnityEvent onHandbrakeApplied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onHandbrakeApplied);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onHandbrakeApplied), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002120 RID: 8480
		// (get) Token: 0x06006E83 RID: 28291 RVA: 0x001E91AC File Offset: 0x001E73AC
		// (set) Token: 0x06006E84 RID: 28292 RVA: 0x000343FE File Offset: 0x000325FE
		public unsafe UnityEvent<Collision> onCollision
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onCollision);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Collision>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onCollision), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002121 RID: 8481
		// (get) Token: 0x06006E85 RID: 28293 RVA: 0x001E91DC File Offset: 0x001E73DC
		// (set) Token: 0x06006E86 RID: 28294 RVA: 0x0003441D File Offset: 0x0003261D
		public unsafe SyncVar<float> syncVar___currentSteerAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_syncVar___currentSteerAngle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_syncVar___currentSteerAngle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002122 RID: 8482
		// (get) Token: 0x06006E87 RID: 28295 RVA: 0x001E920C File Offset: 0x001E740C
		// (set) Token: 0x06006E88 RID: 28296 RVA: 0x0003443C File Offset: 0x0003263C
		public unsafe SyncVar<bool> syncVar____brakesApplied_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_syncVar____brakesApplied_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_syncVar____brakesApplied_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002123 RID: 8483
		// (get) Token: 0x06006E89 RID: 28297 RVA: 0x001E923C File Offset: 0x001E743C
		// (set) Token: 0x06006E8A RID: 28298 RVA: 0x0003445B File Offset: 0x0003265B
		public unsafe SyncVar<bool> syncVar____isReversing_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_syncVar____isReversing_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_syncVar____isReversing_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002124 RID: 8484
		// (get) Token: 0x06006E8B RID: 28299 RVA: 0x001E926C File Offset: 0x001E746C
		// (set) Token: 0x06006E8C RID: 28300 RVA: 0x0003447A File Offset: 0x0003267A
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002125 RID: 8485
		// (get) Token: 0x06006E8D RID: 28301 RVA: 0x001E9294 File Offset: 0x001E7494
		// (set) Token: 0x06006E8E RID: 28302 RVA: 0x00034495 File Offset: 0x00032695
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004A90 RID: 19088
		private static readonly IntPtr NativeFieldInfoPtr_KINEMATIC_THRESHOLD_DISTANCE;

		// Token: 0x04004A91 RID: 19089
		private static readonly IntPtr NativeFieldInfoPtr_MAX_TURNOVER_SPEED;

		// Token: 0x04004A92 RID: 19090
		private static readonly IntPtr NativeFieldInfoPtr_TURNOVER_FORCE;

		// Token: 0x04004A93 RID: 19091
		private static readonly IntPtr NativeFieldInfoPtr_USE_WHEEL;

		// Token: 0x04004A94 RID: 19092
		private static readonly IntPtr NativeFieldInfoPtr_SPEED_DISPLAY_MULTIPLIER;

		// Token: 0x04004A95 RID: 19093
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04004A96 RID: 19094
		private static readonly IntPtr NativeFieldInfoPtr_vehicleName;

		// Token: 0x04004A97 RID: 19095
		private static readonly IntPtr NativeFieldInfoPtr_vehicleCode;

		// Token: 0x04004A98 RID: 19096
		private static readonly IntPtr NativeFieldInfoPtr_vehiclePrice;

		// Token: 0x04004A99 RID: 19097
		private static readonly IntPtr NativeFieldInfoPtr__IsPlayerOwned_k__BackingField;

		// Token: 0x04004A9A RID: 19098
		private static readonly IntPtr NativeFieldInfoPtr__IsVisible_k__BackingField;

		// Token: 0x04004A9B RID: 19099
		private static readonly IntPtr NativeFieldInfoPtr_UseHumanoidCollider;

		// Token: 0x04004A9C RID: 19100
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04004A9D RID: 19101
		private static readonly IntPtr NativeFieldInfoPtr_SpawnAsPlayerOwned;

		// Token: 0x04004A9E RID: 19102
		private static readonly IntPtr NativeFieldInfoPtr__DistanceToLocalCamera_k__BackingField;

		// Token: 0x04004A9F RID: 19103
		private static readonly IntPtr NativeFieldInfoPtr_vehicleModel;

		// Token: 0x04004AA0 RID: 19104
		private static readonly IntPtr NativeFieldInfoPtr_driveWheels;

		// Token: 0x04004AA1 RID: 19105
		private static readonly IntPtr NativeFieldInfoPtr_steerWheels;

		// Token: 0x04004AA2 RID: 19106
		private static readonly IntPtr NativeFieldInfoPtr_handbrakeWheels;

		// Token: 0x04004AA3 RID: 19107
		private static readonly IntPtr NativeFieldInfoPtr_wheels;

		// Token: 0x04004AA4 RID: 19108
		private static readonly IntPtr NativeFieldInfoPtr_intObj;

		// Token: 0x04004AA5 RID: 19109
		private static readonly IntPtr NativeFieldInfoPtr_exitPoints;

		// Token: 0x04004AA6 RID: 19110
		private static readonly IntPtr NativeFieldInfoPtr_rb;

		// Token: 0x04004AA7 RID: 19111
		private static readonly IntPtr NativeFieldInfoPtr_Seats;

		// Token: 0x04004AA8 RID: 19112
		private static readonly IntPtr NativeFieldInfoPtr_boundingBox;

		// Token: 0x04004AA9 RID: 19113
		private static readonly IntPtr NativeFieldInfoPtr_Agent;

		// Token: 0x04004AAA RID: 19114
		private static readonly IntPtr NativeFieldInfoPtr_VelocityCalculator;

		// Token: 0x04004AAB RID: 19115
		private static readonly IntPtr NativeFieldInfoPtr_Trunk;

		// Token: 0x04004AAC RID: 19116
		private static readonly IntPtr NativeFieldInfoPtr_NavMeshObstacle;

		// Token: 0x04004AAD RID: 19117
		private static readonly IntPtr NativeFieldInfoPtr_NavmeshCut;

		// Token: 0x04004AAE RID: 19118
		private static readonly IntPtr NativeFieldInfoPtr_HumanoidColliderContainer;

		// Token: 0x04004AAF RID: 19119
		private static readonly IntPtr NativeFieldInfoPtr_POI;

		// Token: 0x04004AB0 RID: 19120
		private static readonly IntPtr NativeFieldInfoPtr_centerOfMass;

		// Token: 0x04004AB1 RID: 19121
		private static readonly IntPtr NativeFieldInfoPtr_cameraOrigin;

		// Token: 0x04004AB2 RID: 19122
		private static readonly IntPtr NativeFieldInfoPtr_lights;

		// Token: 0x04004AB3 RID: 19123
		private static readonly IntPtr NativeFieldInfoPtr_maxSteeringAngle;

		// Token: 0x04004AB4 RID: 19124
		private static readonly IntPtr NativeFieldInfoPtr_steerRate;

		// Token: 0x04004AB5 RID: 19125
		private static readonly IntPtr NativeFieldInfoPtr_flipSteer;

		// Token: 0x04004AB6 RID: 19126
		private static readonly IntPtr NativeFieldInfoPtr__MaxSteerAngleOverridden_k__BackingField;

		// Token: 0x04004AB7 RID: 19127
		private static readonly IntPtr NativeFieldInfoPtr__OverriddenMaxSteerAngle_k__BackingField;

		// Token: 0x04004AB8 RID: 19128
		private static readonly IntPtr NativeFieldInfoPtr_motorTorque;

		// Token: 0x04004AB9 RID: 19129
		private static readonly IntPtr NativeFieldInfoPtr_TopSpeed;

		// Token: 0x04004ABA RID: 19130
		private static readonly IntPtr NativeFieldInfoPtr_diffGearing;

		// Token: 0x04004ABB RID: 19131
		private static readonly IntPtr NativeFieldInfoPtr_handBrakeForce;

		// Token: 0x04004ABC RID: 19132
		private static readonly IntPtr NativeFieldInfoPtr_brakeForce;

		// Token: 0x04004ABD RID: 19133
		private static readonly IntPtr NativeFieldInfoPtr_downforce;

		// Token: 0x04004ABE RID: 19134
		private static readonly IntPtr NativeFieldInfoPtr_reverseMultiplier;

		// Token: 0x04004ABF RID: 19135
		private static readonly IntPtr NativeFieldInfoPtr_BodyMeshes;

		// Token: 0x04004AC0 RID: 19136
		private static readonly IntPtr NativeFieldInfoPtr_DefaultColor;

		// Token: 0x04004AC1 RID: 19137
		private static readonly IntPtr NativeFieldInfoPtr__OwnedColor_k__BackingField;

		// Token: 0x04004AC2 RID: 19138
		private static readonly IntPtr NativeFieldInfoPtr_DisplayedColor;

		// Token: 0x04004AC3 RID: 19139
		private static readonly IntPtr NativeFieldInfoPtr_outlineRenderers;

		// Token: 0x04004AC4 RID: 19140
		private static readonly IntPtr NativeFieldInfoPtr_outlineEffect;

		// Token: 0x04004AC5 RID: 19141
		private static readonly IntPtr NativeFieldInfoPtr_overrideControls;

		// Token: 0x04004AC6 RID: 19142
		private static readonly IntPtr NativeFieldInfoPtr_throttleOverride;

		// Token: 0x04004AC7 RID: 19143
		private static readonly IntPtr NativeFieldInfoPtr_steerOverride;

		// Token: 0x04004AC8 RID: 19144
		private static readonly IntPtr NativeFieldInfoPtr_Storage;

		// Token: 0x04004AC9 RID: 19145
		private static readonly IntPtr NativeFieldInfoPtr_localPlayerSeat;

		// Token: 0x04004ACA RID: 19146
		private static readonly IntPtr NativeFieldInfoPtr__localPlayerIsDriver_k__BackingField;

		// Token: 0x04004ACB RID: 19147
		private static readonly IntPtr NativeFieldInfoPtr__localPlayerIsInVehicle_k__BackingField;

		// Token: 0x04004ACC RID: 19148
		private static readonly IntPtr NativeFieldInfoPtr__isOccupied_k__BackingField;

		// Token: 0x04004ACD RID: 19149
		private static readonly IntPtr NativeFieldInfoPtr__OccupantNPCs_k__BackingField;

		// Token: 0x04004ACE RID: 19150
		private static readonly IntPtr NativeFieldInfoPtr__speed_Kmh_k__BackingField;

		// Token: 0x04004ACF RID: 19151
		private static readonly IntPtr NativeFieldInfoPtr_previousSpeeds;

		// Token: 0x04004AD0 RID: 19152
		private static readonly IntPtr NativeFieldInfoPtr_previousSpeedsSampleSize;

		// Token: 0x04004AD1 RID: 19153
		private static readonly IntPtr NativeFieldInfoPtr__currentThrottle_k__BackingField;

		// Token: 0x04004AD2 RID: 19154
		private static readonly IntPtr NativeFieldInfoPtr_currentSteerAngle;

		// Token: 0x04004AD3 RID: 19155
		private static readonly IntPtr NativeFieldInfoPtr_lastFrameSteerAngle;

		// Token: 0x04004AD4 RID: 19156
		private static readonly IntPtr NativeFieldInfoPtr_lastReplicatedSteerAngle;

		// Token: 0x04004AD5 RID: 19157
		private static readonly IntPtr NativeFieldInfoPtr_justExitedVehicle;

		// Token: 0x04004AD6 RID: 19158
		private static readonly IntPtr NativeFieldInfoPtr__brakesApplied_k__BackingField;

		// Token: 0x04004AD7 RID: 19159
		private static readonly IntPtr NativeFieldInfoPtr__isReversing_k__BackingField;

		// Token: 0x04004AD8 RID: 19160
		private static readonly IntPtr NativeFieldInfoPtr__isStatic_k__BackingField;

		// Token: 0x04004AD9 RID: 19161
		private static readonly IntPtr NativeFieldInfoPtr__handbrakeApplied_k__BackingField;

		// Token: 0x04004ADA RID: 19162
		private static readonly IntPtr NativeFieldInfoPtr_lastFramePosition;

		// Token: 0x04004ADB RID: 19163
		private static readonly IntPtr NativeFieldInfoPtr_closestExitPoint;

		// Token: 0x04004ADC RID: 19164
		private static readonly IntPtr NativeFieldInfoPtr_CurrentParkData;

		// Token: 0x04004ADD RID: 19165
		private static readonly IntPtr NativeFieldInfoPtr__CurrentParkingLot_k__BackingField;

		// Token: 0x04004ADE RID: 19166
		private static readonly IntPtr NativeFieldInfoPtr__CurrentParkingSpot_k__BackingField;

		// Token: 0x04004ADF RID: 19167
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x04004AE0 RID: 19168
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04004AE1 RID: 19169
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04004AE2 RID: 19170
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04004AE3 RID: 19171
		private static readonly IntPtr NativeFieldInfoPtr_onPlayerEnterVehicle;

		// Token: 0x04004AE4 RID: 19172
		private static readonly IntPtr NativeFieldInfoPtr_onPlayerExitVehicle;

		// Token: 0x04004AE5 RID: 19173
		private static readonly IntPtr NativeFieldInfoPtr_onVehicleStart;

		// Token: 0x04004AE6 RID: 19174
		private static readonly IntPtr NativeFieldInfoPtr_onVehicleStop;

		// Token: 0x04004AE7 RID: 19175
		private static readonly IntPtr NativeFieldInfoPtr_onHandbrakeApplied;

		// Token: 0x04004AE8 RID: 19176
		private static readonly IntPtr NativeFieldInfoPtr_onCollision;

		// Token: 0x04004AE9 RID: 19177
		private static readonly IntPtr NativeFieldInfoPtr_syncVar___currentSteerAngle;

		// Token: 0x04004AEA RID: 19178
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____brakesApplied_k__BackingField;

		// Token: 0x04004AEB RID: 19179
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____isReversing_k__BackingField;

		// Token: 0x04004AEC RID: 19180
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004AED RID: 19181
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004AEE RID: 19182
		private static readonly IntPtr NativeMethodInfoPtr_get_VehicleName_Public_get_String_0;

		// Token: 0x04004AEF RID: 19183
		private static readonly IntPtr NativeMethodInfoPtr_get_VehicleCode_Public_get_String_0;

		// Token: 0x04004AF0 RID: 19184
		private static readonly IntPtr NativeMethodInfoPtr_get_VehiclePrice_Public_get_Single_0;

		// Token: 0x04004AF1 RID: 19185
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlayerOwned_Public_get_Boolean_0;

		// Token: 0x04004AF2 RID: 19186
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPlayerOwned_Protected_set_Void_Boolean_0;

		// Token: 0x04004AF3 RID: 19187
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0;

		// Token: 0x04004AF4 RID: 19188
		private static readonly IntPtr NativeMethodInfoPtr_set_IsVisible_Protected_set_Void_Boolean_0;

		// Token: 0x04004AF5 RID: 19189
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04004AF6 RID: 19190
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04004AF7 RID: 19191
		private static readonly IntPtr NativeMethodInfoPtr_get_DistanceToLocalCamera_Public_get_Single_0;

		// Token: 0x04004AF8 RID: 19192
		private static readonly IntPtr NativeMethodInfoPtr_set_DistanceToLocalCamera_Private_set_Void_Single_0;

		// Token: 0x04004AF9 RID: 19193
		private static readonly IntPtr NativeMethodInfoPtr_get_boundingBoxDimensions_Public_get_Vector3_0;

		// Token: 0x04004AFA RID: 19194
		private static readonly IntPtr NativeMethodInfoPtr_get_driverEntryPoint_Public_get_Transform_0;

		// Token: 0x04004AFB RID: 19195
		private static readonly IntPtr NativeMethodInfoPtr_get_Rb_Public_get_Rigidbody_0;

		// Token: 0x04004AFC RID: 19196
		private static readonly IntPtr NativeMethodInfoPtr_get_ActualMaxSteeringAngle_Public_get_Single_0;

		// Token: 0x04004AFD RID: 19197
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxSteerAngleOverridden_Public_get_Boolean_0;

		// Token: 0x04004AFE RID: 19198
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxSteerAngleOverridden_Private_set_Void_Boolean_0;

		// Token: 0x04004AFF RID: 19199
		private static readonly IntPtr NativeMethodInfoPtr_get_OverriddenMaxSteerAngle_Public_get_Single_0;

		// Token: 0x04004B00 RID: 19200
		private static readonly IntPtr NativeMethodInfoPtr_set_OverriddenMaxSteerAngle_Private_set_Void_Single_0;

		// Token: 0x04004B01 RID: 19201
		private static readonly IntPtr NativeMethodInfoPtr_get_OwnedColor_Public_get_EVehicleColor_0;

		// Token: 0x04004B02 RID: 19202
		private static readonly IntPtr NativeMethodInfoPtr_set_OwnedColor_Private_set_Void_EVehicleColor_0;

		// Token: 0x04004B03 RID: 19203
		private static readonly IntPtr NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0;

		// Token: 0x04004B04 RID: 19204
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPlayerOccupancy_Public_get_Int32_0;

		// Token: 0x04004B05 RID: 19205
		private static readonly IntPtr NativeMethodInfoPtr_get_localPlayerIsDriver_Public_get_Boolean_0;

		// Token: 0x04004B06 RID: 19206
		private static readonly IntPtr NativeMethodInfoPtr_set_localPlayerIsDriver_Protected_set_Void_Boolean_0;

		// Token: 0x04004B07 RID: 19207
		private static readonly IntPtr NativeMethodInfoPtr_get_localPlayerIsInVehicle_Public_get_Boolean_0;

		// Token: 0x04004B08 RID: 19208
		private static readonly IntPtr NativeMethodInfoPtr_set_localPlayerIsInVehicle_Protected_set_Void_Boolean_0;

		// Token: 0x04004B09 RID: 19209
		private static readonly IntPtr NativeMethodInfoPtr_get_isOccupied_Public_get_Boolean_0;

		// Token: 0x04004B0A RID: 19210
		private static readonly IntPtr NativeMethodInfoPtr_set_isOccupied_Private_set_Void_Boolean_0;

		// Token: 0x04004B0B RID: 19211
		private static readonly IntPtr NativeMethodInfoPtr_get_DriverPlayer_Public_get_Player_0;

		// Token: 0x04004B0C RID: 19212
		private static readonly IntPtr NativeMethodInfoPtr_get_OccupantPlayers_Public_get_List_1_Player_0;

		// Token: 0x04004B0D RID: 19213
		private static readonly IntPtr NativeMethodInfoPtr_get_OccupantNPCs_Public_get_Il2CppReferenceArray_1_NPC_0;

		// Token: 0x04004B0E RID: 19214
		private static readonly IntPtr NativeMethodInfoPtr_set_OccupantNPCs_Protected_set_Void_Il2CppReferenceArray_1_NPC_0;

		// Token: 0x04004B0F RID: 19215
		private static readonly IntPtr NativeMethodInfoPtr_get_speed_Kmh_Public_get_Single_0;

		// Token: 0x04004B10 RID: 19216
		private static readonly IntPtr NativeMethodInfoPtr_set_speed_Kmh_Protected_set_Void_Single_0;

		// Token: 0x04004B11 RID: 19217
		private static readonly IntPtr NativeMethodInfoPtr_get_speed_Ms_Public_get_Single_0;

		// Token: 0x04004B12 RID: 19218
		private static readonly IntPtr NativeMethodInfoPtr_get_speed_Mph_Public_get_Single_0;

		// Token: 0x04004B13 RID: 19219
		private static readonly IntPtr NativeMethodInfoPtr_get_currentThrottle_Public_get_Single_0;

		// Token: 0x04004B14 RID: 19220
		private static readonly IntPtr NativeMethodInfoPtr_set_currentThrottle_Protected_set_Void_Single_0;

		// Token: 0x04004B15 RID: 19221
		private static readonly IntPtr NativeMethodInfoPtr_get_brakesApplied_Public_get_Boolean_0;

		// Token: 0x04004B16 RID: 19222
		private static readonly IntPtr NativeMethodInfoPtr_set_brakesApplied_Public_set_Void_Boolean_0;

		// Token: 0x04004B17 RID: 19223
		private static readonly IntPtr NativeMethodInfoPtr_get_isReversing_Public_get_Boolean_0;

		// Token: 0x04004B18 RID: 19224
		private static readonly IntPtr NativeMethodInfoPtr_set_isReversing_Public_set_Void_Boolean_0;

		// Token: 0x04004B19 RID: 19225
		private static readonly IntPtr NativeMethodInfoPtr_get_isStatic_Public_get_Boolean_0;

		// Token: 0x04004B1A RID: 19226
		private static readonly IntPtr NativeMethodInfoPtr_set_isStatic_Protected_set_Void_Boolean_0;

		// Token: 0x04004B1B RID: 19227
		private static readonly IntPtr NativeMethodInfoPtr_get_handbrakeApplied_Public_get_Boolean_0;

		// Token: 0x04004B1C RID: 19228
		private static readonly IntPtr NativeMethodInfoPtr_set_handbrakeApplied_Protected_set_Void_Boolean_0;

		// Token: 0x04004B1D RID: 19229
		private static readonly IntPtr NativeMethodInfoPtr_get_boundingBaseOffset_Public_get_Single_0;

		// Token: 0x04004B1E RID: 19230
		private static readonly IntPtr NativeMethodInfoPtr_get_isParked_Public_get_Boolean_0;

		// Token: 0x04004B1F RID: 19231
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentParkingLot_Public_get_ParkingLot_0;

		// Token: 0x04004B20 RID: 19232
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentParkingLot_Protected_set_Void_ParkingLot_0;

		// Token: 0x04004B21 RID: 19233
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentParkingSpot_Public_get_ParkingSpot_0;

		// Token: 0x04004B22 RID: 19234
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentParkingSpot_Protected_set_Void_ParkingSpot_0;

		// Token: 0x04004B23 RID: 19235
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04004B24 RID: 19236
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04004B25 RID: 19237
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04004B26 RID: 19238
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04004B27 RID: 19239
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04004B28 RID: 19240
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04004B29 RID: 19241
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04004B2A RID: 19242
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04004B2B RID: 19243
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04004B2C RID: 19244
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04004B2D RID: 19245
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004B2E RID: 19246
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04004B2F RID: 19247
		private static readonly IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x04004B30 RID: 19248
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04004B31 RID: 19249
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x04004B32 RID: 19250
		private static readonly IntPtr NativeMethodInfoPtr_SetIsPlayerOwned_Public_Void_NetworkConnection_Boolean_0;

		// Token: 0x04004B33 RID: 19251
		private static readonly IntPtr NativeMethodInfoPtr_RefreshPoI_Private_Void_0;

		// Token: 0x04004B34 RID: 19252
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04004B35 RID: 19253
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1;

		// Token: 0x04004B36 RID: 19254
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04004B37 RID: 19255
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1;

		// Token: 0x04004B38 RID: 19256
		private static readonly IntPtr NativeMethodInfoPtr_GetNetworth_Private_Void_FloatContainer_0;

		// Token: 0x04004B39 RID: 19257
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1;

		// Token: 0x04004B3A RID: 19258
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04004B3B RID: 19259
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x04004B3C RID: 19260
		private static readonly IntPtr NativeMethodInfoPtr_OnMinPass_Protected_Virtual_New_Void_1;

		// Token: 0x04004B3D RID: 19261
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x04004B3E RID: 19262
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0;

		// Token: 0x04004B3F RID: 19263
		private static readonly IntPtr NativeMethodInfoPtr_SetOwner_Protected_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x04004B40 RID: 19264
		private static readonly IntPtr NativeMethodInfoPtr_OnOwnerChanged_Protected_Virtual_New_Void_1;

		// Token: 0x04004B41 RID: 19265
		private static readonly IntPtr NativeMethodInfoPtr_SetTransform_Server_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04004B42 RID: 19266
		private static readonly IntPtr NativeMethodInfoPtr_SetTransform_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04004B43 RID: 19267
		private static readonly IntPtr NativeMethodInfoPtr_DestroyVehicle_Public_Void_0;

		// Token: 0x04004B44 RID: 19268
		private static readonly IntPtr NativeMethodInfoPtr_UpdateThrottle_Protected_Virtual_New_Void_1;

		// Token: 0x04004B45 RID: 19269
		private static readonly IntPtr NativeMethodInfoPtr_ApplyThrottle_Protected_Virtual_New_Void_1;

		// Token: 0x04004B46 RID: 19270
		private static readonly IntPtr NativeMethodInfoPtr_ApplyHandbrake_Public_Void_0;

		// Token: 0x04004B47 RID: 19271
		private static readonly IntPtr NativeMethodInfoPtr_SetSteeringAngle_Private_Void_Single_0;

		// Token: 0x04004B48 RID: 19272
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSteerAngle_Protected_Virtual_New_Void_1;

		// Token: 0x04004B49 RID: 19273
		private static readonly IntPtr NativeMethodInfoPtr_ApplySteerAngle_Protected_Virtual_New_Void_1;

		// Token: 0x04004B4A RID: 19274
		private static readonly IntPtr NativeMethodInfoPtr_DelaySetStatic_Private_Void_Boolean_0;

		// Token: 0x04004B4B RID: 19275
		private static readonly IntPtr NativeMethodInfoPtr_SetIsStatic_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04004B4C RID: 19276
		private static readonly IntPtr NativeMethodInfoPtr_AlignTo_Public_Void_Transform_EParkingAlignment_Boolean_0;

		// Token: 0x04004B4D RID: 19277
		private static readonly IntPtr NativeMethodInfoPtr_GetAlignmentTransform_Public_Tuple_2_Vector3_Quaternion_Transform_EParkingAlignment_0;

		// Token: 0x04004B4E RID: 19278
		private static readonly IntPtr NativeMethodInfoPtr_GetVehicleValue_Public_Single_0;

		// Token: 0x04004B4F RID: 19279
		private static readonly IntPtr NativeMethodInfoPtr_OverrideMaxSteerAngle_Public_Void_Single_0;

		// Token: 0x04004B50 RID: 19280
		private static readonly IntPtr NativeMethodInfoPtr_ResetMaxSteerAngle_Public_Void_0;

		// Token: 0x04004B51 RID: 19281
		private static readonly IntPtr NativeMethodInfoPtr_SetObstaclesActive_Public_Void_Boolean_0;

		// Token: 0x04004B52 RID: 19282
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstFreeSeat_Public_VehicleSeat_0;

		// Token: 0x04004B53 RID: 19283
		private static readonly IntPtr NativeMethodInfoPtr_SetSeatOccupant_Private_Void_NetworkConnection_Int32_NetworkConnection_0;

		// Token: 0x04004B54 RID: 19284
		private static readonly IntPtr NativeMethodInfoPtr_SetSeatOccupant_Server_Private_Void_Int32_NetworkConnection_0;

		// Token: 0x04004B55 RID: 19285
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Private_Void_0;

		// Token: 0x04004B56 RID: 19286
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Private_Void_0;

		// Token: 0x04004B57 RID: 19287
		private static readonly IntPtr NativeMethodInfoPtr_EnterVehicle_Private_Void_0;

		// Token: 0x04004B58 RID: 19288
		private static readonly IntPtr NativeMethodInfoPtr_ExitVehicle_Public_Void_0;

		// Token: 0x04004B59 RID: 19289
		private static readonly IntPtr NativeMethodInfoPtr_EndJustExited_Private_Void_0;

		// Token: 0x04004B5A RID: 19290
		private static readonly IntPtr NativeMethodInfoPtr_GetExitPoint_Public_Transform_Int32_0;

		// Token: 0x04004B5B RID: 19291
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestExitPoint_Private_Transform_Vector3_0;

		// Token: 0x04004B5C RID: 19292
		private static readonly IntPtr NativeMethodInfoPtr_GetValidExitPoint_Private_Transform_List_1_Transform_0;

		// Token: 0x04004B5D RID: 19293
		private static readonly IntPtr NativeMethodInfoPtr_AddNPCOccupant_Public_Void_NPC_0;

		// Token: 0x04004B5E RID: 19294
		private static readonly IntPtr NativeMethodInfoPtr_RemoveNPCOccupant_Public_Void_NPC_0;

		// Token: 0x04004B5F RID: 19295
		private static readonly IntPtr NativeMethodInfoPtr_CanBeRecovered_Public_Virtual_New_Boolean_0;

		// Token: 0x04004B60 RID: 19296
		private static readonly IntPtr NativeMethodInfoPtr_RecoverVehicle_Public_Virtual_New_Void_0;

		// Token: 0x04004B61 RID: 19297
		private static readonly IntPtr NativeMethodInfoPtr_SendOwnedColor_Public_Void_EVehicleColor_0;

		// Token: 0x04004B62 RID: 19298
		private static readonly IntPtr NativeMethodInfoPtr_SetOwnedColor_Protected_Virtual_New_Void_NetworkConnection_EVehicleColor_0;

		// Token: 0x04004B63 RID: 19299
		private static readonly IntPtr NativeMethodInfoPtr_ApplyColor_Public_Virtual_New_Void_EVehicleColor_0;

		// Token: 0x04004B64 RID: 19300
		private static readonly IntPtr NativeMethodInfoPtr_ApplyOwnedColor_Public_Void_0;

		// Token: 0x04004B65 RID: 19301
		private static readonly IntPtr NativeMethodInfoPtr_ShowOutline_Public_Void_EOutlineColor_0;

		// Token: 0x04004B66 RID: 19302
		private static readonly IntPtr NativeMethodInfoPtr_HideOutline_Public_Void_0;

		// Token: 0x04004B67 RID: 19303
		private static readonly IntPtr NativeMethodInfoPtr_Park_Networked_Private_Void_NetworkConnection_ParkData_0;

		// Token: 0x04004B68 RID: 19304
		private static readonly IntPtr NativeMethodInfoPtr_Park_Public_Void_NetworkConnection_ParkData_Boolean_0;

		// Token: 0x04004B69 RID: 19305
		private static readonly IntPtr NativeMethodInfoPtr_ExitPark_Networked_Public_Void_NetworkConnection_Boolean_0;

		// Token: 0x04004B6A RID: 19306
		private static readonly IntPtr NativeMethodInfoPtr_ExitPark_Public_Void_Boolean_0;

		// Token: 0x04004B6B RID: 19307
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x04004B6C RID: 19308
		private static readonly IntPtr NativeMethodInfoPtr_GetContents_Public_List_1_ItemInstance_0;

		// Token: 0x04004B6D RID: 19309
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04004B6E RID: 19310
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0;

		// Token: 0x04004B6F RID: 19311
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_VehicleData_String_0;

		// Token: 0x04004B70 RID: 19312
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004B71 RID: 19313
		private static readonly IntPtr NativeMethodInfoPtr__ApplyColor_b__249_0_Private_Boolean_VehicleColorData_0;

		// Token: 0x04004B72 RID: 19314
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004B73 RID: 19315
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004B74 RID: 19316
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004B75 RID: 19317
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetIsPlayerOwned_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04004B76 RID: 19318
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetIsPlayerOwned_214505783_Public_Void_NetworkConnection_Boolean_0;

		// Token: 0x04004B77 RID: 19319
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetIsPlayerOwned_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004B78 RID: 19320
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetIsPlayerOwned_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04004B79 RID: 19321
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetIsPlayerOwned_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004B7A RID: 19322
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetOwner_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04004B7B RID: 19323
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetOwner_328543758_Protected_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x04004B7C RID: 19324
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetOwner_328543758_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004B7D RID: 19325
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_OnOwnerChanged_2166136261_Private_Void_0;

		// Token: 0x04004B7E RID: 19326
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___OnOwnerChanged_2166136261_Protected_Virtual_New_Void_1;

		// Token: 0x04004B7F RID: 19327
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_OnOwnerChanged_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004B80 RID: 19328
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetTransform_Server_3848837105_Private_Void_Vector3_Quaternion_0;

		// Token: 0x04004B81 RID: 19329
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetTransform_Server_3848837105_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04004B82 RID: 19330
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetTransform_Server_3848837105_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004B83 RID: 19331
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetTransform_3848837105_Private_Void_Vector3_Quaternion_0;

		// Token: 0x04004B84 RID: 19332
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetTransform_3848837105_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04004B85 RID: 19333
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetTransform_3848837105_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004B86 RID: 19334
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetSteeringAngle_431000436_Private_Void_Single_0;

		// Token: 0x04004B87 RID: 19335
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetSteeringAngle_431000436_Private_Void_Single_0;

		// Token: 0x04004B88 RID: 19336
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetSteeringAngle_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004B89 RID: 19337
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0;

		// Token: 0x04004B8A RID: 19338
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0;

		// Token: 0x04004B8B RID: 19339
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetSeatOccupant_3428404692_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004B8C RID: 19340
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0;

		// Token: 0x04004B8D RID: 19341
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetSeatOccupant_3428404692_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004B8E RID: 19342
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetSeatOccupant_Server_3266232555_Private_Void_Int32_NetworkConnection_0;

		// Token: 0x04004B8F RID: 19343
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetSeatOccupant_Server_3266232555_Private_Void_Int32_NetworkConnection_0;

		// Token: 0x04004B90 RID: 19344
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetSeatOccupant_Server_3266232555_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004B91 RID: 19345
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendOwnedColor_911055161_Private_Void_EVehicleColor_0;

		// Token: 0x04004B92 RID: 19346
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendOwnedColor_911055161_Public_Void_EVehicleColor_0;

		// Token: 0x04004B93 RID: 19347
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendOwnedColor_911055161_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004B94 RID: 19348
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetOwnedColor_1679996372_Private_Void_NetworkConnection_EVehicleColor_0;

		// Token: 0x04004B95 RID: 19349
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetOwnedColor_1679996372_Protected_Virtual_New_Void_NetworkConnection_EVehicleColor_0;

		// Token: 0x04004B96 RID: 19350
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetOwnedColor_1679996372_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004B97 RID: 19351
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetOwnedColor_1679996372_Private_Void_NetworkConnection_EVehicleColor_0;

		// Token: 0x04004B98 RID: 19352
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetOwnedColor_1679996372_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004B99 RID: 19353
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0;

		// Token: 0x04004B9A RID: 19354
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0;

		// Token: 0x04004B9B RID: 19355
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Park_Networked_2633993806_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004B9C RID: 19356
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0;

		// Token: 0x04004B9D RID: 19357
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_Park_Networked_2633993806_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004B9E RID: 19358
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ExitPark_Networked_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04004B9F RID: 19359
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ExitPark_Networked_214505783_Public_Void_NetworkConnection_Boolean_0;

		// Token: 0x04004BA0 RID: 19360
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ExitPark_Networked_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004BA1 RID: 19361
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ExitPark_Networked_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04004BA2 RID: 19362
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ExitPark_Networked_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004BA3 RID: 19363
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value_currentSteerAngle_Public_get_Single_0;

		// Token: 0x04004BA4 RID: 19364
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value_currentSteerAngle_Public_set_Void_Single_Boolean_0;

		// Token: 0x04004BA5 RID: 19365
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Vehicles_LandVehicle_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04004BA6 RID: 19366
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__brakesApplied_k__BackingField_Public_get_Boolean_0;

		// Token: 0x04004BA7 RID: 19367
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__brakesApplied_k__BackingField_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x04004BA8 RID: 19368
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__isReversing_k__BackingField_Public_get_Boolean_0;

		// Token: 0x04004BA9 RID: 19369
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__isReversing_k__BackingField_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x04004BAA RID: 19370
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x02000A66 RID: 2662
		[Serializable]
		public class BodyMesh : Il2CppSystem.Object
		{
			// Token: 0x0600D0FE RID: 53502 RVA: 0x0032169C File Offset: 0x0031F89C
			// Note: this type is marked as 'beforefieldinit'.
			static BodyMesh()
			{
				Il2CppClassPointerStore<LandVehicle.BodyMesh>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "BodyMesh");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandVehicle.BodyMesh>.NativeClassPtr);
				LandVehicle.BodyMesh.NativeFieldInfoPtr_Renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.BodyMesh>.NativeClassPtr, "Renderer");
				LandVehicle.BodyMesh.NativeFieldInfoPtr_MaterialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.BodyMesh>.NativeClassPtr, "MaterialIndex");
				LandVehicle.BodyMesh.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.BodyMesh>.NativeClassPtr, 100677268);
			}

			// Token: 0x0600D0FF RID: 53503 RVA: 0x00321704 File Offset: 0x0031F904
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BodyMesh() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandVehicle.BodyMesh>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.BodyMesh.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D100 RID: 53504 RVA: 0x00065C13 File Offset: 0x00063E13
			public BodyMesh(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040E9 RID: 16617
			// (get) Token: 0x0600D101 RID: 53505 RVA: 0x00321740 File Offset: 0x0031F940
			// (set) Token: 0x0600D102 RID: 53506 RVA: 0x00065C1C File Offset: 0x00063E1C
			public unsafe MeshRenderer Renderer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.BodyMesh.NativeFieldInfoPtr_Renderer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.BodyMesh.NativeFieldInfoPtr_Renderer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040EA RID: 16618
			// (get) Token: 0x0600D103 RID: 53507 RVA: 0x00321770 File Offset: 0x0031F970
			// (set) Token: 0x0600D104 RID: 53508 RVA: 0x00065C3B File Offset: 0x00063E3B
			public unsafe int MaterialIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.BodyMesh.NativeFieldInfoPtr_MaterialIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.BodyMesh.NativeFieldInfoPtr_MaterialIndex)) = value;
				}
			}

			// Token: 0x04008D09 RID: 36105
			private static readonly IntPtr NativeFieldInfoPtr_Renderer;

			// Token: 0x04008D0A RID: 36106
			private static readonly IntPtr NativeFieldInfoPtr_MaterialIndex;

			// Token: 0x04008D0B RID: 36107
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A67 RID: 2663
		public sealed class VehiclePlayerEvent : MulticastDelegate
		{
			// Token: 0x0600D105 RID: 53509 RVA: 0x00321798 File Offset: 0x0031F998
			// Note: this type is marked as 'beforefieldinit'.
			static VehiclePlayerEvent()
			{
				Il2CppClassPointerStore<LandVehicle.VehiclePlayerEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "VehiclePlayerEvent");
				LandVehicle.VehiclePlayerEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.VehiclePlayerEvent>.NativeClassPtr, 100677269);
				LandVehicle.VehiclePlayerEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.VehiclePlayerEvent>.NativeClassPtr, 100677270);
				LandVehicle.VehiclePlayerEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Player_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.VehiclePlayerEvent>.NativeClassPtr, 100677271);
				LandVehicle.VehiclePlayerEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.VehiclePlayerEvent>.NativeClassPtr, 100677272);
			}

			// Token: 0x0600D106 RID: 53510 RVA: 0x0032180C File Offset: 0x0031FA0C
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 106479, RefRangeEnd = 106558, XrefRangeStart = 106479, XrefRangeEnd = 106558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VehiclePlayerEvent(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandVehicle.VehiclePlayerEvent>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.VehiclePlayerEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D107 RID: 53511 RVA: 0x00321868 File Offset: 0x0031FA68
			[CallerCount(0)]
			public unsafe void Invoke(Player player)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.VehiclePlayerEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D108 RID: 53512 RVA: 0x003218AC File Offset: 0x0031FAAC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74827, RefRangeEnd = 74828, XrefRangeStart = 74827, XrefRangeEnd = 74828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Player player, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.VehiclePlayerEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Player_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600D109 RID: 53513 RVA: 0x00321920 File Offset: 0x0031FB20
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22499, RefRangeEnd = 22500, XrefRangeStart = 22499, XrefRangeEnd = 22500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.VehiclePlayerEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D10A RID: 53514 RVA: 0x00065C56 File Offset: 0x00063E56
			public VehiclePlayerEvent(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D10B RID: 53515 RVA: 0x00065C5F File Offset: 0x00063E5F
			public static implicit operator LandVehicle.VehiclePlayerEvent(Action<Player> A_0)
			{
				return DelegateSupport.ConvertDelegate<LandVehicle.VehiclePlayerEvent>(A_0);
			}

			// Token: 0x0600D10C RID: 53516 RVA: 0x00065C67 File Offset: 0x00063E67
			public static LandVehicle.VehiclePlayerEvent operator +(LandVehicle.VehiclePlayerEvent A_0, LandVehicle.VehiclePlayerEvent A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<LandVehicle.VehiclePlayerEvent>();
			}

			// Token: 0x0600D10D RID: 53517 RVA: 0x00065C75 File Offset: 0x00063E75
			public static LandVehicle.VehiclePlayerEvent operator -(LandVehicle.VehiclePlayerEvent A_0, LandVehicle.VehiclePlayerEvent A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<LandVehicle.VehiclePlayerEvent>();
				}
				return result;
			}

			// Token: 0x04008D0C RID: 36108
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008D0D RID: 36109
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Player_0;

			// Token: 0x04008D0E RID: 36110
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Player_AsyncCallback_Object_0;

			// Token: 0x04008D0F RID: 36111
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000A68 RID: 2664
		[ObfuscatedName("ScheduleOne.Vehicles.LandVehicle+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D10E RID: 53518 RVA: 0x00321964 File Offset: 0x0031FB64
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr);
				LandVehicle.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, "<>9");
				LandVehicle.__c.NativeFieldInfoPtr___9__96_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, "<>9__96_0");
				LandVehicle.__c.NativeFieldInfoPtr___9__113_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, "<>9__113_0");
				LandVehicle.__c.NativeFieldInfoPtr___9__113_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, "<>9__113_1");
				LandVehicle.__c.NativeFieldInfoPtr___9__233_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, "<>9__233_0");
				LandVehicle.__c.NativeFieldInfoPtr___9__243_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, "<>9__243_0");
				LandVehicle.__c.NativeFieldInfoPtr___9__244_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, "<>9__244_0");
				LandVehicle.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, 100677274);
				LandVehicle.__c.NativeMethodInfoPtr__get_CurrentPlayerOccupancy_b__96_0_Internal_Boolean_VehicleSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, 100677275);
				LandVehicle.__c.NativeMethodInfoPtr__get_OccupantPlayers_b__113_0_Internal_Boolean_VehicleSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, 100677276);
				LandVehicle.__c.NativeMethodInfoPtr__get_OccupantPlayers_b__113_1_Internal_Player_VehicleSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, 100677277);
				LandVehicle.__c.NativeMethodInfoPtr__SetSeatOccupant_b__233_0_Internal_Boolean_VehicleSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, 100677278);
				LandVehicle.__c.NativeMethodInfoPtr__AddNPCOccupant_b__243_0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, 100677279);
				LandVehicle.__c.NativeMethodInfoPtr__RemoveNPCOccupant_b__244_0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, 100677280);
			}

			// Token: 0x0600D10F RID: 53519 RVA: 0x00321AA8 File Offset: 0x0031FCA8
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D110 RID: 53520 RVA: 0x00321AE4 File Offset: 0x0031FCE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217819, XrefRangeEnd = 217824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_CurrentPlayerOccupancy_b__96_0(VehicleSeat s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c.NativeMethodInfoPtr__get_CurrentPlayerOccupancy_b__96_0_Internal_Boolean_VehicleSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D111 RID: 53521 RVA: 0x00321B34 File Offset: 0x0031FD34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_OccupantPlayers_b__113_0(VehicleSeat s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c.NativeMethodInfoPtr__get_OccupantPlayers_b__113_0_Internal_Boolean_VehicleSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D112 RID: 53522 RVA: 0x00321B84 File Offset: 0x0031FD84
			[CallerCount(0)]
			public unsafe Player _get_OccupantPlayers_b__113_1(VehicleSeat s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c.NativeMethodInfoPtr__get_OccupantPlayers_b__113_1_Internal_Player_VehicleSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}

			// Token: 0x0600D113 RID: 53523 RVA: 0x00321BD4 File Offset: 0x0031FDD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetSeatOccupant_b__233_0(VehicleSeat s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c.NativeMethodInfoPtr__SetSeatOccupant_b__233_0_Internal_Boolean_VehicleSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D114 RID: 53524 RVA: 0x00321C24 File Offset: 0x0031FE24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217824, XrefRangeEnd = 217828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddNPCOccupant_b__243_0(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c.NativeMethodInfoPtr__AddNPCOccupant_b__243_0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D115 RID: 53525 RVA: 0x00321C74 File Offset: 0x0031FE74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217828, XrefRangeEnd = 217832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveNPCOccupant_b__244_0(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c.NativeMethodInfoPtr__RemoveNPCOccupant_b__244_0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D116 RID: 53526 RVA: 0x00065C86 File Offset: 0x00063E86
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040EB RID: 16619
			// (get) Token: 0x0600D117 RID: 53527 RVA: 0x00321CC4 File Offset: 0x0031FEC4
			// (set) Token: 0x0600D118 RID: 53528 RVA: 0x00065C8F File Offset: 0x00063E8F
			public unsafe static LandVehicle.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LandVehicle.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LandVehicle.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040EC RID: 16620
			// (get) Token: 0x0600D119 RID: 53529 RVA: 0x00321CEC File Offset: 0x0031FEEC
			// (set) Token: 0x0600D11A RID: 53530 RVA: 0x00065CA1 File Offset: 0x00063EA1
			public unsafe static Func<VehicleSeat, bool> __9__96_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LandVehicle.__c.NativeFieldInfoPtr___9__96_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VehicleSeat, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LandVehicle.__c.NativeFieldInfoPtr___9__96_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040ED RID: 16621
			// (get) Token: 0x0600D11B RID: 53531 RVA: 0x00321D14 File Offset: 0x0031FF14
			// (set) Token: 0x0600D11C RID: 53532 RVA: 0x00065CB3 File Offset: 0x00063EB3
			public unsafe static Func<VehicleSeat, bool> __9__113_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LandVehicle.__c.NativeFieldInfoPtr___9__113_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VehicleSeat, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LandVehicle.__c.NativeFieldInfoPtr___9__113_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040EE RID: 16622
			// (get) Token: 0x0600D11D RID: 53533 RVA: 0x00321D3C File Offset: 0x0031FF3C
			// (set) Token: 0x0600D11E RID: 53534 RVA: 0x00065CC5 File Offset: 0x00063EC5
			public unsafe static Func<VehicleSeat, Player> __9__113_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LandVehicle.__c.NativeFieldInfoPtr___9__113_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VehicleSeat, Player>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LandVehicle.__c.NativeFieldInfoPtr___9__113_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040EF RID: 16623
			// (get) Token: 0x0600D11F RID: 53535 RVA: 0x00321D64 File Offset: 0x0031FF64
			// (set) Token: 0x0600D120 RID: 53536 RVA: 0x00065CD7 File Offset: 0x00063ED7
			public unsafe static Func<VehicleSeat, bool> __9__233_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LandVehicle.__c.NativeFieldInfoPtr___9__233_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VehicleSeat, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LandVehicle.__c.NativeFieldInfoPtr___9__233_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040F0 RID: 16624
			// (get) Token: 0x0600D121 RID: 53537 RVA: 0x00321D8C File Offset: 0x0031FF8C
			// (set) Token: 0x0600D122 RID: 53538 RVA: 0x00065CE9 File Offset: 0x00063EE9
			public unsafe static Func<NPC, bool> __9__243_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LandVehicle.__c.NativeFieldInfoPtr___9__243_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NPC, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LandVehicle.__c.NativeFieldInfoPtr___9__243_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040F1 RID: 16625
			// (get) Token: 0x0600D123 RID: 53539 RVA: 0x00321DB4 File Offset: 0x0031FFB4
			// (set) Token: 0x0600D124 RID: 53540 RVA: 0x00065CFB File Offset: 0x00063EFB
			public unsafe static Func<NPC, bool> __9__244_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LandVehicle.__c.NativeFieldInfoPtr___9__244_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NPC, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LandVehicle.__c.NativeFieldInfoPtr___9__244_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D10 RID: 36112
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008D11 RID: 36113
			private static readonly IntPtr NativeFieldInfoPtr___9__96_0;

			// Token: 0x04008D12 RID: 36114
			private static readonly IntPtr NativeFieldInfoPtr___9__113_0;

			// Token: 0x04008D13 RID: 36115
			private static readonly IntPtr NativeFieldInfoPtr___9__113_1;

			// Token: 0x04008D14 RID: 36116
			private static readonly IntPtr NativeFieldInfoPtr___9__233_0;

			// Token: 0x04008D15 RID: 36117
			private static readonly IntPtr NativeFieldInfoPtr___9__243_0;

			// Token: 0x04008D16 RID: 36118
			private static readonly IntPtr NativeFieldInfoPtr___9__244_0;

			// Token: 0x04008D17 RID: 36119
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D18 RID: 36120
			private static readonly IntPtr NativeMethodInfoPtr__get_CurrentPlayerOccupancy_b__96_0_Internal_Boolean_VehicleSeat_0;

			// Token: 0x04008D19 RID: 36121
			private static readonly IntPtr NativeMethodInfoPtr__get_OccupantPlayers_b__113_0_Internal_Boolean_VehicleSeat_0;

			// Token: 0x04008D1A RID: 36122
			private static readonly IntPtr NativeMethodInfoPtr__get_OccupantPlayers_b__113_1_Internal_Player_VehicleSeat_0;

			// Token: 0x04008D1B RID: 36123
			private static readonly IntPtr NativeMethodInfoPtr__SetSeatOccupant_b__233_0_Internal_Boolean_VehicleSeat_0;

			// Token: 0x04008D1C RID: 36124
			private static readonly IntPtr NativeMethodInfoPtr__AddNPCOccupant_b__243_0_Internal_Boolean_NPC_0;

			// Token: 0x04008D1D RID: 36125
			private static readonly IntPtr NativeMethodInfoPtr__RemoveNPCOccupant_b__244_0_Internal_Boolean_NPC_0;
		}

		// Token: 0x02000A69 RID: 2665
		[ObfuscatedName("ScheduleOne.Vehicles.LandVehicle+<>c__DisplayClass224_0")]
		public sealed class __c__DisplayClass224_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D125 RID: 53541 RVA: 0x00321DDC File Offset: 0x0031FFDC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass224_0()
			{
				Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<>c__DisplayClass224_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0>.NativeClassPtr);
				LandVehicle.__c__DisplayClass224_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0>.NativeClassPtr, "<>4__this");
				LandVehicle.__c__DisplayClass224_0.NativeFieldInfoPtr_stat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0>.NativeClassPtr, "stat");
				LandVehicle.__c__DisplayClass224_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0>.NativeClassPtr, 100677281);
				LandVehicle.__c__DisplayClass224_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0>.NativeClassPtr, 100677282);
			}

			// Token: 0x0600D126 RID: 53542 RVA: 0x00321E58 File Offset: 0x00320058
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass224_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c__DisplayClass224_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D127 RID: 53543 RVA: 0x00321E94 File Offset: 0x00320094
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 217847, RefRangeEnd = 217848, XrefRangeStart = 217842, XrefRangeEnd = 217847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c__DisplayClass224_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D128 RID: 53544 RVA: 0x00065D0D File Offset: 0x00063F0D
			public __c__DisplayClass224_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040F2 RID: 16626
			// (get) Token: 0x0600D129 RID: 53545 RVA: 0x00321ED4 File Offset: 0x003200D4
			// (set) Token: 0x0600D12A RID: 53546 RVA: 0x00065D16 File Offset: 0x00063F16
			public unsafe LandVehicle __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.__c__DisplayClass224_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.__c__DisplayClass224_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040F3 RID: 16627
			// (get) Token: 0x0600D12B RID: 53547 RVA: 0x00321F04 File Offset: 0x00320104
			// (set) Token: 0x0600D12C RID: 53548 RVA: 0x00065D35 File Offset: 0x00063F35
			public unsafe bool stat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.__c__DisplayClass224_0.NativeFieldInfoPtr_stat);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.__c__DisplayClass224_0.NativeFieldInfoPtr_stat)) = value;
				}
			}

			// Token: 0x04008D1E RID: 36126
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008D1F RID: 36127
			private static readonly IntPtr NativeFieldInfoPtr_stat;

			// Token: 0x04008D20 RID: 36128
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D21 RID: 36129
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000C60 RID: 3168
			[ObfuscatedName("ScheduleOne.Vehicles.LandVehicle+<>c__DisplayClass224_0+<<DelaySetStatic>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E407 RID: 58375 RVA: 0x00357EC4 File Offset: 0x003560C4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0>.NativeClassPtr, "<<DelaySetStatic>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677283);
					LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677284);
					LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677285);
					LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677286);
					LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677287);
					LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677288);
				}

				// Token: 0x0600E408 RID: 58376 RVA: 0x00357FA4 File Offset: 0x003561A4
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E409 RID: 58377 RVA: 0x00357FEC File Offset: 0x003561EC
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E40A RID: 58378 RVA: 0x00358020 File Offset: 0x00356220
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217832, XrefRangeEnd = 217837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170046CB RID: 18123
				// (get) Token: 0x0600E40B RID: 58379 RVA: 0x0035805C File Offset: 0x0035625C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E40C RID: 58380 RVA: 0x0035809C File Offset: 0x0035629C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217837, XrefRangeEnd = 217842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170046CC RID: 18124
				// (get) Token: 0x0600E40D RID: 58381 RVA: 0x003580D0 File Offset: 0x003562D0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E40E RID: 58382 RVA: 0x0006F26A File Offset: 0x0006D46A
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170046C8 RID: 18120
				// (get) Token: 0x0600E40F RID: 58383 RVA: 0x00358110 File Offset: 0x00356310
				// (set) Token: 0x0600E410 RID: 58384 RVA: 0x0006F273 File Offset: 0x0006D473
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170046C9 RID: 18121
				// (get) Token: 0x0600E411 RID: 58385 RVA: 0x00358138 File Offset: 0x00356338
				// (set) Token: 0x0600E412 RID: 58386 RVA: 0x0006F28E File Offset: 0x0006D48E
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046CA RID: 18122
				// (get) Token: 0x0600E413 RID: 58387 RVA: 0x00358168 File Offset: 0x00356368
				// (set) Token: 0x0600E414 RID: 58388 RVA: 0x0006F2AD File Offset: 0x0006D4AD
				public unsafe LandVehicle.__c__DisplayClass224_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle.__c__DisplayClass224_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400988F RID: 39055
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009890 RID: 39056
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009891 RID: 39057
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009892 RID: 39058
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009893 RID: 39059
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009894 RID: 39060
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009895 RID: 39061
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009896 RID: 39062
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009897 RID: 39063
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
