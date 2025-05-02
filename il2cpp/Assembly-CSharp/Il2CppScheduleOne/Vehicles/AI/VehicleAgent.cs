using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppPathfinding;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Math;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x02000508 RID: 1288
	public class VehicleAgent : MonoBehaviour
	{
		// Token: 0x0600713F RID: 28991 RVA: 0x001F1040 File Offset: 0x001EF240
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleAgent()
		{
			Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "VehicleAgent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr);
			VehicleAgent.NativeFieldInfoPtr_VehicleGraphName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "VehicleGraphName");
			VehicleAgent.NativeFieldInfoPtr_RoadGraphName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "RoadGraphName");
			VehicleAgent.NativeFieldInfoPtr_MaxDistanceFromPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "MaxDistanceFromPath");
			VehicleAgent.NativeFieldInfoPtr_MaxDistanceFromPathWhenReversing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "MaxDistanceFromPathWhenReversing");
			VehicleAgent.NativeFieldInfoPtr_MainGraphSamplePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "MainGraphSamplePoint");
			VehicleAgent.NativeFieldInfoPtr_MinRenavigationRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "MinRenavigationRate");
			VehicleAgent.NativeFieldInfoPtr_Steer_P = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Steer_P");
			VehicleAgent.NativeFieldInfoPtr_Steer_I = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Steer_I");
			VehicleAgent.NativeFieldInfoPtr_Steer_D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Steer_D");
			VehicleAgent.NativeFieldInfoPtr_Throttle_P = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Throttle_P");
			VehicleAgent.NativeFieldInfoPtr_Throttle_I = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Throttle_I");
			VehicleAgent.NativeFieldInfoPtr_Throttle_D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Throttle_D");
			VehicleAgent.NativeFieldInfoPtr_Steer_Rate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Steer_Rate");
			VehicleAgent.NativeFieldInfoPtr_MaxAxlePositionShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "MaxAxlePositionShift");
			VehicleAgent.NativeFieldInfoPtr_OBSTACLE_MIN_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "OBSTACLE_MIN_RANGE");
			VehicleAgent.NativeFieldInfoPtr_OBSTACLE_MAX_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "OBSTACLE_MAX_RANGE");
			VehicleAgent.NativeFieldInfoPtr_MAX_STEER_ANGLE_OVERRIDE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "MAX_STEER_ANGLE_OVERRIDE");
			VehicleAgent.NativeFieldInfoPtr_KINEMATIC_MODE_MIN_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "KINEMATIC_MODE_MIN_DISTANCE");
			VehicleAgent.NativeFieldInfoPtr_INFREQUENT_UPDATE_RATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "INFREQUENT_UPDATE_RATE");
			VehicleAgent.NativeFieldInfoPtr_DEBUG_MODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "DEBUG_MODE");
			VehicleAgent.NativeFieldInfoPtr__KinematicMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "<KinematicMode>k__BackingField");
			VehicleAgent.NativeFieldInfoPtr__AutoDriving_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "<AutoDriving>k__BackingField");
			VehicleAgent.NativeFieldInfoPtr__TargetLocation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "<TargetLocation>k__BackingField");
			VehicleAgent.NativeFieldInfoPtr_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Flags");
			VehicleAgent.NativeFieldInfoPtr_roadSeeker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "roadSeeker");
			VehicleAgent.NativeFieldInfoPtr_generalSeeker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "generalSeeker");
			VehicleAgent.NativeFieldInfoPtr_CTE_Origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "CTE_Origin");
			VehicleAgent.NativeFieldInfoPtr_FrontAxlePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "FrontAxlePosition");
			VehicleAgent.NativeFieldInfoPtr_RearAxlePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "RearAxlePosition");
			VehicleAgent.NativeFieldInfoPtr_sensor_FL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sensor_FL");
			VehicleAgent.NativeFieldInfoPtr_sensor_FM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sensor_FM");
			VehicleAgent.NativeFieldInfoPtr_sensor_FR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sensor_FR");
			VehicleAgent.NativeFieldInfoPtr_sensor_RR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sensor_RR");
			VehicleAgent.NativeFieldInfoPtr_sensor_RL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sensor_RL");
			VehicleAgent.NativeFieldInfoPtr_sweepMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sweepMask");
			VehicleAgent.NativeFieldInfoPtr_sweepOrigin_FL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sweepOrigin_FL");
			VehicleAgent.NativeFieldInfoPtr_sweepOrigin_FR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sweepOrigin_FR");
			VehicleAgent.NativeFieldInfoPtr_sweepOrigin_RL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sweepOrigin_RL");
			VehicleAgent.NativeFieldInfoPtr_sweepOrigin_RR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sweepOrigin_RR");
			VehicleAgent.NativeFieldInfoPtr_leftWheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "leftWheel");
			VehicleAgent.NativeFieldInfoPtr_rightWheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "rightWheel");
			VehicleAgent.NativeFieldInfoPtr_sweepSegment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sweepSegment");
			VehicleAgent.NativeFieldInfoPtr_sampleStepSizeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sampleStepSizeMin");
			VehicleAgent.NativeFieldInfoPtr_sampleStepSizeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sampleStepSizeMax");
			VehicleAgent.NativeFieldInfoPtr_aheadPointSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "aheadPointSamples");
			VehicleAgent.NativeFieldInfoPtr_DestinationDistanceSlowThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "DestinationDistanceSlowThreshold");
			VehicleAgent.NativeFieldInfoPtr_DestinationArrivalThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "DestinationArrivalThreshold");
			VehicleAgent.NativeFieldInfoPtr_steerTargetFollowRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "steerTargetFollowRate");
			VehicleAgent.NativeFieldInfoPtr_steerPID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "steerPID");
			VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionMinRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "turnSpeedReductionMinRange");
			VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionMaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "turnSpeedReductionMaxRange");
			VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionDivisor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "turnSpeedReductionDivisor");
			VehicleAgent.NativeFieldInfoPtr_minTurnSpeedReductionAngleThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "minTurnSpeedReductionAngleThreshold");
			VehicleAgent.NativeFieldInfoPtr_minTurningSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "minTurningSpeed");
			VehicleAgent.NativeFieldInfoPtr_throttleMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "throttleMin");
			VehicleAgent.NativeFieldInfoPtr_throttleMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "throttleMax");
			VehicleAgent.NativeFieldInfoPtr_throttlePID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "throttlePID");
			VehicleAgent.NativeFieldInfoPtr_UnmarkedSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "UnmarkedSpeed");
			VehicleAgent.NativeFieldInfoPtr_ReverseSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "ReverseSpeed");
			VehicleAgent.NativeFieldInfoPtr_speedReductionTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "speedReductionTracker");
			VehicleAgent.NativeFieldInfoPtr_PursuitModeEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "PursuitModeEnabled");
			VehicleAgent.NativeFieldInfoPtr_PursuitTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "PursuitTarget");
			VehicleAgent.NativeFieldInfoPtr_PursuitDistanceUpdateThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "PursuitDistanceUpdateThreshold");
			VehicleAgent.NativeFieldInfoPtr_PursuitTargetLastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "PursuitTargetLastPosition");
			VehicleAgent.NativeFieldInfoPtr_Teleporter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Teleporter");
			VehicleAgent.NativeFieldInfoPtr_PositionHistoryTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "PositionHistoryTracker");
			VehicleAgent.NativeFieldInfoPtr_StuckTimeThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "StuckTimeThreshold");
			VehicleAgent.NativeFieldInfoPtr_StuckSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "StuckSamples");
			VehicleAgent.NativeFieldInfoPtr_StuckDistanceThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "StuckDistanceThreshold");
			VehicleAgent.NativeFieldInfoPtr_storedNavigationCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "storedNavigationCallback");
			VehicleAgent.NativeFieldInfoPtr_currentSpeedZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "currentSpeedZone");
			VehicleAgent.NativeFieldInfoPtr_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "vehicle");
			VehicleAgent.NativeFieldInfoPtr_wheelbase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "wheelbase");
			VehicleAgent.NativeFieldInfoPtr_wheeltrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "wheeltrack");
			VehicleAgent.NativeFieldInfoPtr_vehicleLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "vehicleLength");
			VehicleAgent.NativeFieldInfoPtr_vehicleWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "vehicleWidth");
			VehicleAgent.NativeFieldInfoPtr_turnRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "turnRadius");
			VehicleAgent.NativeFieldInfoPtr_sweepTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sweepTrack");
			VehicleAgent.NativeFieldInfoPtr_wheelBottomOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "wheelBottomOffset");
			VehicleAgent.NativeFieldInfoPtr_targetSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "targetSpeed");
			VehicleAgent.NativeFieldInfoPtr_targetSteerAngle_Normalized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "targetSteerAngle_Normalized");
			VehicleAgent.NativeFieldInfoPtr_lateralOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "lateralOffset");
			VehicleAgent.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "path");
			VehicleAgent.NativeFieldInfoPtr_timeSinceLastNavigationCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "timeSinceLastNavigationCall");
			VehicleAgent.NativeFieldInfoPtr_sweepTestFailedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sweepTestFailedTime");
			VehicleAgent.NativeFieldInfoPtr_currentNavigationSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "currentNavigationSettings");
			VehicleAgent.NativeFieldInfoPtr_navigationCalculationRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "navigationCalculationRoutine");
			VehicleAgent.NativeFieldInfoPtr_reverseCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "reverseCoroutine");
			VehicleAgent.NativeMethodInfoPtr_get_KinematicMode_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677533);
			VehicleAgent.NativeMethodInfoPtr_set_KinematicMode_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677534);
			VehicleAgent.NativeMethodInfoPtr_get_AutoDriving_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677535);
			VehicleAgent.NativeMethodInfoPtr_set_AutoDriving_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677536);
			VehicleAgent.NativeMethodInfoPtr_get_IsReversing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677537);
			VehicleAgent.NativeMethodInfoPtr_get_TargetLocation_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677538);
			VehicleAgent.NativeMethodInfoPtr_set_TargetLocation_Protected_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677539);
			VehicleAgent.NativeMethodInfoPtr_get_sampleStepSize_Protected_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677540);
			VehicleAgent.NativeMethodInfoPtr_get_turnSpeedReductionRange_Protected_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677541);
			VehicleAgent.NativeMethodInfoPtr_get_maxSteerAngle_Protected_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677542);
			VehicleAgent.NativeMethodInfoPtr_get_FrontOfVehiclePosition_Private_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677543);
			VehicleAgent.NativeMethodInfoPtr_get_NavigationCalculationInProgress_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677544);
			VehicleAgent.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677545);
			VehicleAgent.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677546);
			VehicleAgent.NativeMethodInfoPtr_InitializeVehicleData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677547);
			VehicleAgent.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677548);
			VehicleAgent.NativeMethodInfoPtr_InfrequentUpdate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677549);
			VehicleAgent.NativeMethodInfoPtr_LateUpdate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677550);
			VehicleAgent.NativeMethodInfoPtr_UpdateKinematic_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677551);
			VehicleAgent.NativeMethodInfoPtr_GetAxleGroundHit_Private_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677552);
			VehicleAgent.NativeMethodInfoPtr_UpdateSweep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677553);
			VehicleAgent.NativeMethodInfoPtr_UpdateSpeedReduction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677554);
			VehicleAgent.NativeMethodInfoPtr_UpdatePursuitMode_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677555);
			VehicleAgent.NativeMethodInfoPtr_UpdateStuckDetection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677556);
			VehicleAgent.NativeMethodInfoPtr_CheckDistanceFromPath_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677557);
			VehicleAgent.NativeMethodInfoPtr_UpdateOvertaking_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677558);
			VehicleAgent.NativeMethodInfoPtr_RefreshSpeedZone_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677559);
			VehicleAgent.NativeMethodInfoPtr_UpdateSpeed_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677560);
			VehicleAgent.NativeMethodInfoPtr_UpdateSteering_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677561);
			VehicleAgent.NativeMethodInfoPtr_Navigate_Public_Void_Vector3_NavigationSettings_NavigationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677562);
			VehicleAgent.NativeMethodInfoPtr_NavigationCalculationCallback_Private_Void_ENavigationCalculationResult_SmoothedPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677563);
			VehicleAgent.NativeMethodInfoPtr_EndDriving_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677564);
			VehicleAgent.NativeMethodInfoPtr_StopNavigating_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677565);
			VehicleAgent.NativeMethodInfoPtr_RecalculateNavigation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677566);
			VehicleAgent.NativeMethodInfoPtr_SweepTurn_Public_Boolean_ESweepType_Single_Boolean_byref_Single_byref_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677567);
			VehicleAgent.NativeMethodInfoPtr_BetterSweepTurn_Public_Void_ESweepType_Single_Boolean_LayerMask_byref_Single_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677568);
			VehicleAgent.NativeMethodInfoPtr_StartReverse_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677569);
			VehicleAgent.NativeMethodInfoPtr_Reverse_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677570);
			VehicleAgent.NativeMethodInfoPtr_StopReversing_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677571);
			VehicleAgent.NativeMethodInfoPtr_GetClosestForwardObstruction_Private_Collider_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677572);
			VehicleAgent.NativeMethodInfoPtr_IsOnVehicleGraph_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677573);
			VehicleAgent.NativeMethodInfoPtr_GetDistanceFromVehicleGraph_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677574);
			VehicleAgent.NativeMethodInfoPtr_GetPathLateralDirection_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677575);
			VehicleAgent.NativeMethodInfoPtr_GetIsStuck_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677576);
			VehicleAgent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677577);
			VehicleAgent.NativeMethodInfoPtr__Reverse_b__139_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677579);
		}

		// Token: 0x1700228E RID: 8846
		// (get) Token: 0x06007140 RID: 28992 RVA: 0x001F1AE8 File Offset: 0x001EFCE8
		// (set) Token: 0x06007141 RID: 28993 RVA: 0x001F1B24 File Offset: 0x001EFD24
		public unsafe bool KinematicMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_KinematicMode_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_set_KinematicMode_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700228F RID: 8847
		// (get) Token: 0x06007142 RID: 28994 RVA: 0x001F1B64 File Offset: 0x001EFD64
		// (set) Token: 0x06007143 RID: 28995 RVA: 0x001F1BA0 File Offset: 0x001EFDA0
		public unsafe bool AutoDriving
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_AutoDriving_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_set_AutoDriving_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002290 RID: 8848
		// (get) Token: 0x06007144 RID: 28996 RVA: 0x001F1BE0 File Offset: 0x001EFDE0
		public unsafe bool IsReversing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_IsReversing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002291 RID: 8849
		// (get) Token: 0x06007145 RID: 28997 RVA: 0x001F1C1C File Offset: 0x001EFE1C
		// (set) Token: 0x06007146 RID: 28998 RVA: 0x001F1C58 File Offset: 0x001EFE58
		public unsafe Vector3 TargetLocation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_TargetLocation_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_set_TargetLocation_Protected_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002292 RID: 8850
		// (get) Token: 0x06007147 RID: 28999 RVA: 0x001F1C98 File Offset: 0x001EFE98
		public unsafe float sampleStepSize
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 222756, RefRangeEnd = 222758, XrefRangeStart = 222755, XrefRangeEnd = 222756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_sampleStepSize_Protected_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002293 RID: 8851
		// (get) Token: 0x06007148 RID: 29000 RVA: 0x001F1CD4 File Offset: 0x001EFED4
		public unsafe float turnSpeedReductionRange
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222758, XrefRangeEnd = 222759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_turnSpeedReductionRange_Protected_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002294 RID: 8852
		// (get) Token: 0x06007149 RID: 29001 RVA: 0x001F1D10 File Offset: 0x001EFF10
		public unsafe float maxSteerAngle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222759, XrefRangeEnd = 222761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_maxSteerAngle_Protected_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002295 RID: 8853
		// (get) Token: 0x0600714A RID: 29002 RVA: 0x001F1D4C File Offset: 0x001EFF4C
		public unsafe Vector3 FrontOfVehiclePosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222761, XrefRangeEnd = 222765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_FrontOfVehiclePosition_Private_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002296 RID: 8854
		// (get) Token: 0x0600714B RID: 29003 RVA: 0x001F1D88 File Offset: 0x001EFF88
		public unsafe bool NavigationCalculationInProgress
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 222765, RefRangeEnd = 222766, XrefRangeStart = 222765, XrefRangeEnd = 222765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_NavigationCalculationInProgress_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600714C RID: 29004 RVA: 0x001F1DC4 File Offset: 0x001EFFC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222766, XrefRangeEnd = 222785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600714D RID: 29005 RVA: 0x001F1DF8 File Offset: 0x001EFFF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222785, XrefRangeEnd = 222795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAgent.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600714E RID: 29006 RVA: 0x001F1E34 File Offset: 0x001F0034
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222880, RefRangeEnd = 222881, XrefRangeStart = 222795, XrefRangeEnd = 222880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeVehicleData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_InitializeVehicleData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600714F RID: 29007 RVA: 0x001F1E68 File Offset: 0x001F0068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222881, XrefRangeEnd = 222913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAgent.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007150 RID: 29008 RVA: 0x001F1EA4 File Offset: 0x001F00A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222913, XrefRangeEnd = 222942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InfrequentUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_InfrequentUpdate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007151 RID: 29009 RVA: 0x001F1ED8 File Offset: 0x001F00D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222942, XrefRangeEnd = 222956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_LateUpdate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007152 RID: 29010 RVA: 0x001F1F0C File Offset: 0x001F010C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223048, RefRangeEnd = 223049, XrefRangeStart = 222956, XrefRangeEnd = 223048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateKinematic(float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_UpdateKinematic_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007153 RID: 29011 RVA: 0x001F1F4C File Offset: 0x001F014C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 223105, RefRangeEnd = 223107, XrefRangeStart = 223049, XrefRangeEnd = 223105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetAxleGroundHit(bool front)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref front;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_GetAxleGroundHit_Private_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007154 RID: 29012 RVA: 0x001F1F98 File Offset: 0x001F0198
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223122, RefRangeEnd = 223123, XrefRangeStart = 223107, XrefRangeEnd = 223122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSweep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_UpdateSweep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007155 RID: 29013 RVA: 0x001F1FCC File Offset: 0x001F01CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223224, RefRangeEnd = 223225, XrefRangeStart = 223123, XrefRangeEnd = 223224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSpeedReduction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_UpdateSpeedReduction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007156 RID: 29014 RVA: 0x001F2000 File Offset: 0x001F0200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223225, XrefRangeEnd = 223238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePursuitMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_UpdatePursuitMode_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007157 RID: 29015 RVA: 0x001F2034 File Offset: 0x001F0234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223238, XrefRangeEnd = 223262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateStuckDetection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_UpdateStuckDetection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007158 RID: 29016 RVA: 0x001F2068 File Offset: 0x001F0268
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223291, RefRangeEnd = 223292, XrefRangeStart = 223262, XrefRangeEnd = 223291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckDistanceFromPath()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_CheckDistanceFromPath_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007159 RID: 29017 RVA: 0x001F209C File Offset: 0x001F029C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223292, XrefRangeEnd = 223302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateOvertaking()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_UpdateOvertaking_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600715A RID: 29018 RVA: 0x001F20D0 File Offset: 0x001F02D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223302, XrefRangeEnd = 223342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshSpeedZone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAgent.NativeMethodInfoPtr_RefreshSpeedZone_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600715B RID: 29019 RVA: 0x001F210C File Offset: 0x001F030C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223342, XrefRangeEnd = 223351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateSpeed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAgent.NativeMethodInfoPtr_UpdateSpeed_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600715C RID: 29020 RVA: 0x001F2148 File Offset: 0x001F0348
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223407, RefRangeEnd = 223408, XrefRangeStart = 223351, XrefRangeEnd = 223407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSteering()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_UpdateSteering_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600715D RID: 29021 RVA: 0x001F217C File Offset: 0x001F037C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 223432, RefRangeEnd = 223438, XrefRangeStart = 223408, XrefRangeEnd = 223432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Navigate(Vector3 location, NavigationSettings settings = null, VehicleAgent.NavigationCallback callback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref location;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_Navigate_Public_Void_Vector3_NavigationSettings_NavigationCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600715E RID: 29022 RVA: 0x001F21E0 File Offset: 0x001F03E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223438, XrefRangeEnd = 223443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NavigationCalculationCallback(NavigationUtility.ENavigationCalculationResult result, PathSmoothingUtility.SmoothedPath _path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_NavigationCalculationCallback_Private_Void_ENavigationCalculationResult_SmoothedPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600715F RID: 29023 RVA: 0x001F2230 File Offset: 0x001F0430
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 223448, RefRangeEnd = 223450, XrefRangeStart = 223443, XrefRangeEnd = 223448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndDriving()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_EndDriving_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007160 RID: 29024 RVA: 0x001F2264 File Offset: 0x001F0464
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 223452, RefRangeEnd = 223457, XrefRangeStart = 223450, XrefRangeEnd = 223452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopNavigating()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_StopNavigating_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007161 RID: 29025 RVA: 0x001F2298 File Offset: 0x001F0498
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223458, RefRangeEnd = 223459, XrefRangeStart = 223457, XrefRangeEnd = 223458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateNavigation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_RecalculateNavigation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007162 RID: 29026 RVA: 0x001F22CC File Offset: 0x001F04CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 223540, RefRangeEnd = 223542, XrefRangeStart = 223459, XrefRangeEnd = 223540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SweepTurn(VehicleAgent.ESweepType sweep, float sweepAngle, bool reverse, out float hitDistance, out Vector3 hitPoint, float steerAngle = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sweep;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sweepAngle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reverse;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitDistance;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitPoint;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steerAngle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_SweepTurn_Public_Boolean_ESweepType_Single_Boolean_byref_Single_byref_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007163 RID: 29027 RVA: 0x001F2360 File Offset: 0x001F0560
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 223678, RefRangeEnd = 223680, XrefRangeStart = 223542, XrefRangeEnd = 223678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BetterSweepTurn(VehicleAgent.ESweepType sweep, float steerAngle, bool reverse, LayerMask mask, out float hitDistance, out Vector3 hitPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sweep;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steerAngle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reverse;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitDistance;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hitPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_BetterSweepTurn_Public_Void_ESweepType_Single_Boolean_LayerMask_byref_Single_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007164 RID: 29028 RVA: 0x001F23E8 File Offset: 0x001F05E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223680, XrefRangeEnd = 223689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartReverse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_StartReverse_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007165 RID: 29029 RVA: 0x001F241C File Offset: 0x001F061C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223689, XrefRangeEnd = 223694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Reverse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_Reverse_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06007166 RID: 29030 RVA: 0x001F245C File Offset: 0x001F065C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 223702, RefRangeEnd = 223705, XrefRangeStart = 223694, XrefRangeEnd = 223702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopReversing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_StopReversing_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007167 RID: 29031 RVA: 0x001F2490 File Offset: 0x001F0690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223705, XrefRangeEnd = 223763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Collider GetClosestForwardObstruction(out float obstructionDist)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &obstructionDist;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_GetClosestForwardObstruction_Private_Collider_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr3) : null;
		}

		// Token: 0x06007168 RID: 29032 RVA: 0x001F24DC File Offset: 0x001F06DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 223764, RefRangeEnd = 223766, XrefRangeStart = 223763, XrefRangeEnd = 223764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsOnVehicleGraph()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_IsOnVehicleGraph_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007169 RID: 29033 RVA: 0x001F2518 File Offset: 0x001F0718
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 223790, RefRangeEnd = 223793, XrefRangeStart = 223766, XrefRangeEnd = 223790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetDistanceFromVehicleGraph()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_GetDistanceFromVehicleGraph_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600716A RID: 29034 RVA: 0x001F2554 File Offset: 0x001F0754
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223804, RefRangeEnd = 223805, XrefRangeStart = 223793, XrefRangeEnd = 223804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPathLateralDirection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_GetPathLateralDirection_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600716B RID: 29035 RVA: 0x001F2590 File Offset: 0x001F0790
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 223824, RefRangeEnd = 223826, XrefRangeStart = 223805, XrefRangeEnd = 223824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetIsStuck()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_GetIsStuck_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600716C RID: 29036 RVA: 0x001F25CC File Offset: 0x001F07CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223826, XrefRangeEnd = 223831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleAgent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600716D RID: 29037 RVA: 0x001F2608 File Offset: 0x001F0808
		[CallerCount(0)]
		public unsafe bool _Reverse_b__139_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr__Reverse_b__139_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600716E RID: 29038 RVA: 0x00035CBD File Offset: 0x00033EBD
		public VehicleAgent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002236 RID: 8758
		// (get) Token: 0x0600716F RID: 29039 RVA: 0x001F2644 File Offset: 0x001F0844
		// (set) Token: 0x06007170 RID: 29040 RVA: 0x00035CC6 File Offset: 0x00033EC6
		public unsafe static string VehicleGraphName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_VehicleGraphName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_VehicleGraphName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002237 RID: 8759
		// (get) Token: 0x06007171 RID: 29041 RVA: 0x001F2664 File Offset: 0x001F0864
		// (set) Token: 0x06007172 RID: 29042 RVA: 0x00035CD8 File Offset: 0x00033ED8
		public unsafe static string RoadGraphName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_RoadGraphName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_RoadGraphName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002238 RID: 8760
		// (get) Token: 0x06007173 RID: 29043 RVA: 0x001F2684 File Offset: 0x001F0884
		// (set) Token: 0x06007174 RID: 29044 RVA: 0x00035CEA File Offset: 0x00033EEA
		public unsafe static float MaxDistanceFromPath
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_MaxDistanceFromPath, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_MaxDistanceFromPath, (void*)(&value));
			}
		}

		// Token: 0x17002239 RID: 8761
		// (get) Token: 0x06007175 RID: 29045 RVA: 0x001F26A0 File Offset: 0x001F08A0
		// (set) Token: 0x06007176 RID: 29046 RVA: 0x00035CF8 File Offset: 0x00033EF8
		public unsafe static float MaxDistanceFromPathWhenReversing
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_MaxDistanceFromPathWhenReversing, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_MaxDistanceFromPathWhenReversing, (void*)(&value));
			}
		}

		// Token: 0x1700223A RID: 8762
		// (get) Token: 0x06007177 RID: 29047 RVA: 0x001F26BC File Offset: 0x001F08BC
		// (set) Token: 0x06007178 RID: 29048 RVA: 0x00035D06 File Offset: 0x00033F06
		public unsafe static Vector3 MainGraphSamplePoint
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_MainGraphSamplePoint, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_MainGraphSamplePoint, (void*)(&value));
			}
		}

		// Token: 0x1700223B RID: 8763
		// (get) Token: 0x06007179 RID: 29049 RVA: 0x001F26D8 File Offset: 0x001F08D8
		// (set) Token: 0x0600717A RID: 29050 RVA: 0x00035D14 File Offset: 0x00033F14
		public unsafe static float MinRenavigationRate
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_MinRenavigationRate, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_MinRenavigationRate, (void*)(&value));
			}
		}

		// Token: 0x1700223C RID: 8764
		// (get) Token: 0x0600717B RID: 29051 RVA: 0x001F26F4 File Offset: 0x001F08F4
		// (set) Token: 0x0600717C RID: 29052 RVA: 0x00035D22 File Offset: 0x00033F22
		public unsafe static float Steer_P
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_Steer_P, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_Steer_P, (void*)(&value));
			}
		}

		// Token: 0x1700223D RID: 8765
		// (get) Token: 0x0600717D RID: 29053 RVA: 0x001F2710 File Offset: 0x001F0910
		// (set) Token: 0x0600717E RID: 29054 RVA: 0x00035D30 File Offset: 0x00033F30
		public unsafe static float Steer_I
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_Steer_I, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_Steer_I, (void*)(&value));
			}
		}

		// Token: 0x1700223E RID: 8766
		// (get) Token: 0x0600717F RID: 29055 RVA: 0x001F272C File Offset: 0x001F092C
		// (set) Token: 0x06007180 RID: 29056 RVA: 0x00035D3E File Offset: 0x00033F3E
		public unsafe static float Steer_D
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_Steer_D, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_Steer_D, (void*)(&value));
			}
		}

		// Token: 0x1700223F RID: 8767
		// (get) Token: 0x06007181 RID: 29057 RVA: 0x001F2748 File Offset: 0x001F0948
		// (set) Token: 0x06007182 RID: 29058 RVA: 0x00035D4C File Offset: 0x00033F4C
		public unsafe static float Throttle_P
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_Throttle_P, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_Throttle_P, (void*)(&value));
			}
		}

		// Token: 0x17002240 RID: 8768
		// (get) Token: 0x06007183 RID: 29059 RVA: 0x001F2764 File Offset: 0x001F0964
		// (set) Token: 0x06007184 RID: 29060 RVA: 0x00035D5A File Offset: 0x00033F5A
		public unsafe static float Throttle_I
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_Throttle_I, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_Throttle_I, (void*)(&value));
			}
		}

		// Token: 0x17002241 RID: 8769
		// (get) Token: 0x06007185 RID: 29061 RVA: 0x001F2780 File Offset: 0x001F0980
		// (set) Token: 0x06007186 RID: 29062 RVA: 0x00035D68 File Offset: 0x00033F68
		public unsafe static float Throttle_D
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_Throttle_D, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_Throttle_D, (void*)(&value));
			}
		}

		// Token: 0x17002242 RID: 8770
		// (get) Token: 0x06007187 RID: 29063 RVA: 0x001F279C File Offset: 0x001F099C
		// (set) Token: 0x06007188 RID: 29064 RVA: 0x00035D76 File Offset: 0x00033F76
		public unsafe static float Steer_Rate
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_Steer_Rate, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_Steer_Rate, (void*)(&value));
			}
		}

		// Token: 0x17002243 RID: 8771
		// (get) Token: 0x06007189 RID: 29065 RVA: 0x001F27B8 File Offset: 0x001F09B8
		// (set) Token: 0x0600718A RID: 29066 RVA: 0x00035D84 File Offset: 0x00033F84
		public unsafe static float MaxAxlePositionShift
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_MaxAxlePositionShift, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_MaxAxlePositionShift, (void*)(&value));
			}
		}

		// Token: 0x17002244 RID: 8772
		// (get) Token: 0x0600718B RID: 29067 RVA: 0x001F27D4 File Offset: 0x001F09D4
		// (set) Token: 0x0600718C RID: 29068 RVA: 0x00035D92 File Offset: 0x00033F92
		public unsafe static float OBSTACLE_MIN_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_OBSTACLE_MIN_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_OBSTACLE_MIN_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17002245 RID: 8773
		// (get) Token: 0x0600718D RID: 29069 RVA: 0x001F27F0 File Offset: 0x001F09F0
		// (set) Token: 0x0600718E RID: 29070 RVA: 0x00035DA0 File Offset: 0x00033FA0
		public unsafe static float OBSTACLE_MAX_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_OBSTACLE_MAX_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_OBSTACLE_MAX_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17002246 RID: 8774
		// (get) Token: 0x0600718F RID: 29071 RVA: 0x001F280C File Offset: 0x001F0A0C
		// (set) Token: 0x06007190 RID: 29072 RVA: 0x00035DAE File Offset: 0x00033FAE
		public unsafe static float MAX_STEER_ANGLE_OVERRIDE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_MAX_STEER_ANGLE_OVERRIDE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_MAX_STEER_ANGLE_OVERRIDE, (void*)(&value));
			}
		}

		// Token: 0x17002247 RID: 8775
		// (get) Token: 0x06007191 RID: 29073 RVA: 0x001F2828 File Offset: 0x001F0A28
		// (set) Token: 0x06007192 RID: 29074 RVA: 0x00035DBC File Offset: 0x00033FBC
		public unsafe static float KINEMATIC_MODE_MIN_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_KINEMATIC_MODE_MIN_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_KINEMATIC_MODE_MIN_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17002248 RID: 8776
		// (get) Token: 0x06007193 RID: 29075 RVA: 0x001F2844 File Offset: 0x001F0A44
		// (set) Token: 0x06007194 RID: 29076 RVA: 0x00035DCA File Offset: 0x00033FCA
		public unsafe static float INFREQUENT_UPDATE_RATE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_INFREQUENT_UPDATE_RATE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_INFREQUENT_UPDATE_RATE, (void*)(&value));
			}
		}

		// Token: 0x17002249 RID: 8777
		// (get) Token: 0x06007195 RID: 29077 RVA: 0x001F2860 File Offset: 0x001F0A60
		// (set) Token: 0x06007196 RID: 29078 RVA: 0x00035DD8 File Offset: 0x00033FD8
		public unsafe bool DEBUG_MODE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_DEBUG_MODE);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_DEBUG_MODE)) = value;
			}
		}

		// Token: 0x1700224A RID: 8778
		// (get) Token: 0x06007197 RID: 29079 RVA: 0x001F2888 File Offset: 0x001F0A88
		// (set) Token: 0x06007198 RID: 29080 RVA: 0x00035DF3 File Offset: 0x00033FF3
		public unsafe bool _KinematicMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr__KinematicMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr__KinematicMode_k__BackingField)) = value;
			}
		}

		// Token: 0x1700224B RID: 8779
		// (get) Token: 0x06007199 RID: 29081 RVA: 0x001F28B0 File Offset: 0x001F0AB0
		// (set) Token: 0x0600719A RID: 29082 RVA: 0x00035E0E File Offset: 0x0003400E
		public unsafe bool _AutoDriving_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr__AutoDriving_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr__AutoDriving_k__BackingField)) = value;
			}
		}

		// Token: 0x1700224C RID: 8780
		// (get) Token: 0x0600719B RID: 29083 RVA: 0x001F28D8 File Offset: 0x001F0AD8
		// (set) Token: 0x0600719C RID: 29084 RVA: 0x00035E29 File Offset: 0x00034029
		public unsafe Vector3 _TargetLocation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr__TargetLocation_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr__TargetLocation_k__BackingField)) = value;
			}
		}

		// Token: 0x1700224D RID: 8781
		// (get) Token: 0x0600719D RID: 29085 RVA: 0x001F2900 File Offset: 0x001F0B00
		// (set) Token: 0x0600719E RID: 29086 RVA: 0x00035E44 File Offset: 0x00034044
		public unsafe DriveFlags Flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_Flags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DriveFlags>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_Flags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700224E RID: 8782
		// (get) Token: 0x0600719F RID: 29087 RVA: 0x001F2930 File Offset: 0x001F0B30
		// (set) Token: 0x060071A0 RID: 29088 RVA: 0x00035E63 File Offset: 0x00034063
		public unsafe Seeker roadSeeker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_roadSeeker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Seeker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_roadSeeker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700224F RID: 8783
		// (get) Token: 0x060071A1 RID: 29089 RVA: 0x001F2960 File Offset: 0x001F0B60
		// (set) Token: 0x060071A2 RID: 29090 RVA: 0x00035E82 File Offset: 0x00034082
		public unsafe Seeker generalSeeker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_generalSeeker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Seeker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_generalSeeker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002250 RID: 8784
		// (get) Token: 0x060071A3 RID: 29091 RVA: 0x001F2990 File Offset: 0x001F0B90
		// (set) Token: 0x060071A4 RID: 29092 RVA: 0x00035EA1 File Offset: 0x000340A1
		public unsafe Transform CTE_Origin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_CTE_Origin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_CTE_Origin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002251 RID: 8785
		// (get) Token: 0x060071A5 RID: 29093 RVA: 0x001F29C0 File Offset: 0x001F0BC0
		// (set) Token: 0x060071A6 RID: 29094 RVA: 0x00035EC0 File Offset: 0x000340C0
		public unsafe Transform FrontAxlePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_FrontAxlePosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_FrontAxlePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002252 RID: 8786
		// (get) Token: 0x060071A7 RID: 29095 RVA: 0x001F29F0 File Offset: 0x001F0BF0
		// (set) Token: 0x060071A8 RID: 29096 RVA: 0x00035EDF File Offset: 0x000340DF
		public unsafe Transform RearAxlePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_RearAxlePosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_RearAxlePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002253 RID: 8787
		// (get) Token: 0x060071A9 RID: 29097 RVA: 0x001F2A20 File Offset: 0x001F0C20
		// (set) Token: 0x060071AA RID: 29098 RVA: 0x00035EFE File Offset: 0x000340FE
		public unsafe Sensor sensor_FL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_FL);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sensor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_FL), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002254 RID: 8788
		// (get) Token: 0x060071AB RID: 29099 RVA: 0x001F2A50 File Offset: 0x001F0C50
		// (set) Token: 0x060071AC RID: 29100 RVA: 0x00035F1D File Offset: 0x0003411D
		public unsafe Sensor sensor_FM
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_FM);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sensor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_FM), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002255 RID: 8789
		// (get) Token: 0x060071AD RID: 29101 RVA: 0x001F2A80 File Offset: 0x001F0C80
		// (set) Token: 0x060071AE RID: 29102 RVA: 0x00035F3C File Offset: 0x0003413C
		public unsafe Sensor sensor_FR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_FR);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sensor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_FR), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002256 RID: 8790
		// (get) Token: 0x060071AF RID: 29103 RVA: 0x001F2AB0 File Offset: 0x001F0CB0
		// (set) Token: 0x060071B0 RID: 29104 RVA: 0x00035F5B File Offset: 0x0003415B
		public unsafe Sensor sensor_RR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_RR);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sensor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_RR), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002257 RID: 8791
		// (get) Token: 0x060071B1 RID: 29105 RVA: 0x001F2AE0 File Offset: 0x001F0CE0
		// (set) Token: 0x060071B2 RID: 29106 RVA: 0x00035F7A File Offset: 0x0003417A
		public unsafe Sensor sensor_RL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_RL);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sensor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_RL), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002258 RID: 8792
		// (get) Token: 0x060071B3 RID: 29107 RVA: 0x001F2B10 File Offset: 0x001F0D10
		// (set) Token: 0x060071B4 RID: 29108 RVA: 0x00035F99 File Offset: 0x00034199
		public unsafe LayerMask sweepMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepMask)) = value;
			}
		}

		// Token: 0x17002259 RID: 8793
		// (get) Token: 0x060071B5 RID: 29109 RVA: 0x001F2B38 File Offset: 0x001F0D38
		// (set) Token: 0x060071B6 RID: 29110 RVA: 0x00035FB4 File Offset: 0x000341B4
		public unsafe Transform sweepOrigin_FL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepOrigin_FL);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepOrigin_FL), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700225A RID: 8794
		// (get) Token: 0x060071B7 RID: 29111 RVA: 0x001F2B68 File Offset: 0x001F0D68
		// (set) Token: 0x060071B8 RID: 29112 RVA: 0x00035FD3 File Offset: 0x000341D3
		public unsafe Transform sweepOrigin_FR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepOrigin_FR);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepOrigin_FR), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700225B RID: 8795
		// (get) Token: 0x060071B9 RID: 29113 RVA: 0x001F2B98 File Offset: 0x001F0D98
		// (set) Token: 0x060071BA RID: 29114 RVA: 0x00035FF2 File Offset: 0x000341F2
		public unsafe Transform sweepOrigin_RL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepOrigin_RL);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepOrigin_RL), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700225C RID: 8796
		// (get) Token: 0x060071BB RID: 29115 RVA: 0x001F2BC8 File Offset: 0x001F0DC8
		// (set) Token: 0x060071BC RID: 29116 RVA: 0x00036011 File Offset: 0x00034211
		public unsafe Transform sweepOrigin_RR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepOrigin_RR);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepOrigin_RR), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700225D RID: 8797
		// (get) Token: 0x060071BD RID: 29117 RVA: 0x001F2BF8 File Offset: 0x001F0DF8
		// (set) Token: 0x060071BE RID: 29118 RVA: 0x00036030 File Offset: 0x00034230
		public unsafe Wheel leftWheel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_leftWheel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Wheel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_leftWheel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700225E RID: 8798
		// (get) Token: 0x060071BF RID: 29119 RVA: 0x001F2C28 File Offset: 0x001F0E28
		// (set) Token: 0x060071C0 RID: 29120 RVA: 0x0003604F File Offset: 0x0003424F
		public unsafe Wheel rightWheel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_rightWheel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Wheel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_rightWheel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700225F RID: 8799
		// (get) Token: 0x060071C1 RID: 29121 RVA: 0x001F2C58 File Offset: 0x001F0E58
		// (set) Token: 0x060071C2 RID: 29122 RVA: 0x0003606E File Offset: 0x0003426E
		public unsafe static float sweepSegment
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_sweepSegment, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_sweepSegment, (void*)(&value));
			}
		}

		// Token: 0x17002260 RID: 8800
		// (get) Token: 0x060071C3 RID: 29123 RVA: 0x001F2C74 File Offset: 0x001F0E74
		// (set) Token: 0x060071C4 RID: 29124 RVA: 0x0003607C File Offset: 0x0003427C
		public unsafe float sampleStepSizeMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sampleStepSizeMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sampleStepSizeMin)) = value;
			}
		}

		// Token: 0x17002261 RID: 8801
		// (get) Token: 0x060071C5 RID: 29125 RVA: 0x001F2C9C File Offset: 0x001F0E9C
		// (set) Token: 0x060071C6 RID: 29126 RVA: 0x00036097 File Offset: 0x00034297
		public unsafe float sampleStepSizeMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sampleStepSizeMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sampleStepSizeMax)) = value;
			}
		}

		// Token: 0x17002262 RID: 8802
		// (get) Token: 0x060071C7 RID: 29127 RVA: 0x001F2CC4 File Offset: 0x001F0EC4
		// (set) Token: 0x060071C8 RID: 29128 RVA: 0x000360B2 File Offset: 0x000342B2
		public unsafe int aheadPointSamples
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_aheadPointSamples);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_aheadPointSamples)) = value;
			}
		}

		// Token: 0x17002263 RID: 8803
		// (get) Token: 0x060071C9 RID: 29129 RVA: 0x001F2CEC File Offset: 0x001F0EEC
		// (set) Token: 0x060071CA RID: 29130 RVA: 0x000360CD File Offset: 0x000342CD
		public unsafe static float DestinationDistanceSlowThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_DestinationDistanceSlowThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_DestinationDistanceSlowThreshold, (void*)(&value));
			}
		}

		// Token: 0x17002264 RID: 8804
		// (get) Token: 0x060071CB RID: 29131 RVA: 0x001F2D08 File Offset: 0x001F0F08
		// (set) Token: 0x060071CC RID: 29132 RVA: 0x000360DB File Offset: 0x000342DB
		public unsafe static float DestinationArrivalThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_DestinationArrivalThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_DestinationArrivalThreshold, (void*)(&value));
			}
		}

		// Token: 0x17002265 RID: 8805
		// (get) Token: 0x060071CD RID: 29133 RVA: 0x001F2D24 File Offset: 0x001F0F24
		// (set) Token: 0x060071CE RID: 29134 RVA: 0x000360E9 File Offset: 0x000342E9
		public unsafe float steerTargetFollowRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_steerTargetFollowRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_steerTargetFollowRate)) = value;
			}
		}

		// Token: 0x17002266 RID: 8806
		// (get) Token: 0x060071CF RID: 29135 RVA: 0x001F2D4C File Offset: 0x001F0F4C
		// (set) Token: 0x060071D0 RID: 29136 RVA: 0x00036104 File Offset: 0x00034304
		public unsafe SteerPID steerPID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_steerPID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteerPID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_steerPID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002267 RID: 8807
		// (get) Token: 0x060071D1 RID: 29137 RVA: 0x001F2D7C File Offset: 0x001F0F7C
		// (set) Token: 0x060071D2 RID: 29138 RVA: 0x00036123 File Offset: 0x00034323
		public unsafe float turnSpeedReductionMinRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionMinRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionMinRange)) = value;
			}
		}

		// Token: 0x17002268 RID: 8808
		// (get) Token: 0x060071D3 RID: 29139 RVA: 0x001F2DA4 File Offset: 0x001F0FA4
		// (set) Token: 0x060071D4 RID: 29140 RVA: 0x0003613E File Offset: 0x0003433E
		public unsafe float turnSpeedReductionMaxRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionMaxRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionMaxRange)) = value;
			}
		}

		// Token: 0x17002269 RID: 8809
		// (get) Token: 0x060071D5 RID: 29141 RVA: 0x001F2DCC File Offset: 0x001F0FCC
		// (set) Token: 0x060071D6 RID: 29142 RVA: 0x00036159 File Offset: 0x00034359
		public unsafe float turnSpeedReductionDivisor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionDivisor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionDivisor)) = value;
			}
		}

		// Token: 0x1700226A RID: 8810
		// (get) Token: 0x060071D7 RID: 29143 RVA: 0x001F2DF4 File Offset: 0x001F0FF4
		// (set) Token: 0x060071D8 RID: 29144 RVA: 0x00036174 File Offset: 0x00034374
		public unsafe float minTurnSpeedReductionAngleThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_minTurnSpeedReductionAngleThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_minTurnSpeedReductionAngleThreshold)) = value;
			}
		}

		// Token: 0x1700226B RID: 8811
		// (get) Token: 0x060071D9 RID: 29145 RVA: 0x001F2E1C File Offset: 0x001F101C
		// (set) Token: 0x060071DA RID: 29146 RVA: 0x0003618F File Offset: 0x0003438F
		public unsafe float minTurningSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_minTurningSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_minTurningSpeed)) = value;
			}
		}

		// Token: 0x1700226C RID: 8812
		// (get) Token: 0x060071DB RID: 29147 RVA: 0x001F2E44 File Offset: 0x001F1044
		// (set) Token: 0x060071DC RID: 29148 RVA: 0x000361AA File Offset: 0x000343AA
		public unsafe float throttleMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_throttleMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_throttleMin)) = value;
			}
		}

		// Token: 0x1700226D RID: 8813
		// (get) Token: 0x060071DD RID: 29149 RVA: 0x001F2E6C File Offset: 0x001F106C
		// (set) Token: 0x060071DE RID: 29150 RVA: 0x000361C5 File Offset: 0x000343C5
		public unsafe float throttleMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_throttleMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_throttleMax)) = value;
			}
		}

		// Token: 0x1700226E RID: 8814
		// (get) Token: 0x060071DF RID: 29151 RVA: 0x001F2E94 File Offset: 0x001F1094
		// (set) Token: 0x060071E0 RID: 29152 RVA: 0x000361E0 File Offset: 0x000343E0
		public unsafe PID throttlePID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_throttlePID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_throttlePID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700226F RID: 8815
		// (get) Token: 0x060071E1 RID: 29153 RVA: 0x001F2EC4 File Offset: 0x001F10C4
		// (set) Token: 0x060071E2 RID: 29154 RVA: 0x000361FF File Offset: 0x000343FF
		public unsafe static float UnmarkedSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_UnmarkedSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_UnmarkedSpeed, (void*)(&value));
			}
		}

		// Token: 0x17002270 RID: 8816
		// (get) Token: 0x060071E3 RID: 29155 RVA: 0x001F2EE0 File Offset: 0x001F10E0
		// (set) Token: 0x060071E4 RID: 29156 RVA: 0x0003620D File Offset: 0x0003440D
		public unsafe static float ReverseSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_ReverseSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_ReverseSpeed, (void*)(&value));
			}
		}

		// Token: 0x17002271 RID: 8817
		// (get) Token: 0x060071E5 RID: 29157 RVA: 0x001F2EFC File Offset: 0x001F10FC
		// (set) Token: 0x060071E6 RID: 29158 RVA: 0x0003621B File Offset: 0x0003441B
		public unsafe ValueTracker speedReductionTracker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_speedReductionTracker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueTracker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_speedReductionTracker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002272 RID: 8818
		// (get) Token: 0x060071E7 RID: 29159 RVA: 0x001F2F2C File Offset: 0x001F112C
		// (set) Token: 0x060071E8 RID: 29160 RVA: 0x0003623A File Offset: 0x0003443A
		public unsafe bool PursuitModeEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PursuitModeEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PursuitModeEnabled)) = value;
			}
		}

		// Token: 0x17002273 RID: 8819
		// (get) Token: 0x060071E9 RID: 29161 RVA: 0x001F2F54 File Offset: 0x001F1154
		// (set) Token: 0x060071EA RID: 29162 RVA: 0x00036255 File Offset: 0x00034455
		public unsafe Transform PursuitTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PursuitTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PursuitTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002274 RID: 8820
		// (get) Token: 0x060071EB RID: 29163 RVA: 0x001F2F84 File Offset: 0x001F1184
		// (set) Token: 0x060071EC RID: 29164 RVA: 0x00036274 File Offset: 0x00034474
		public unsafe float PursuitDistanceUpdateThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PursuitDistanceUpdateThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PursuitDistanceUpdateThreshold)) = value;
			}
		}

		// Token: 0x17002275 RID: 8821
		// (get) Token: 0x060071ED RID: 29165 RVA: 0x001F2FAC File Offset: 0x001F11AC
		// (set) Token: 0x060071EE RID: 29166 RVA: 0x0003628F File Offset: 0x0003448F
		public unsafe Vector3 PursuitTargetLastPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PursuitTargetLastPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PursuitTargetLastPosition)) = value;
			}
		}

		// Token: 0x17002276 RID: 8822
		// (get) Token: 0x060071EF RID: 29167 RVA: 0x001F2FD4 File Offset: 0x001F11D4
		// (set) Token: 0x060071F0 RID: 29168 RVA: 0x000362AA File Offset: 0x000344AA
		public unsafe VehicleTeleporter Teleporter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_Teleporter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleTeleporter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_Teleporter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002277 RID: 8823
		// (get) Token: 0x060071F1 RID: 29169 RVA: 0x001F3004 File Offset: 0x001F1204
		// (set) Token: 0x060071F2 RID: 29170 RVA: 0x000362C9 File Offset: 0x000344C9
		public unsafe PositionHistoryTracker PositionHistoryTracker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PositionHistoryTracker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PositionHistoryTracker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PositionHistoryTracker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002278 RID: 8824
		// (get) Token: 0x060071F3 RID: 29171 RVA: 0x001F3034 File Offset: 0x001F1234
		// (set) Token: 0x060071F4 RID: 29172 RVA: 0x000362E8 File Offset: 0x000344E8
		public unsafe float StuckTimeThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_StuckTimeThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_StuckTimeThreshold)) = value;
			}
		}

		// Token: 0x17002279 RID: 8825
		// (get) Token: 0x060071F5 RID: 29173 RVA: 0x001F305C File Offset: 0x001F125C
		// (set) Token: 0x060071F6 RID: 29174 RVA: 0x00036303 File Offset: 0x00034503
		public unsafe int StuckSamples
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_StuckSamples);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_StuckSamples)) = value;
			}
		}

		// Token: 0x1700227A RID: 8826
		// (get) Token: 0x060071F7 RID: 29175 RVA: 0x001F3084 File Offset: 0x001F1284
		// (set) Token: 0x060071F8 RID: 29176 RVA: 0x0003631E File Offset: 0x0003451E
		public unsafe float StuckDistanceThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_StuckDistanceThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_StuckDistanceThreshold)) = value;
			}
		}

		// Token: 0x1700227B RID: 8827
		// (get) Token: 0x060071F9 RID: 29177 RVA: 0x001F30AC File Offset: 0x001F12AC
		// (set) Token: 0x060071FA RID: 29178 RVA: 0x00036339 File Offset: 0x00034539
		public unsafe VehicleAgent.NavigationCallback storedNavigationCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_storedNavigationCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleAgent.NavigationCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_storedNavigationCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700227C RID: 8828
		// (get) Token: 0x060071FB RID: 29179 RVA: 0x001F30DC File Offset: 0x001F12DC
		// (set) Token: 0x060071FC RID: 29180 RVA: 0x00036358 File Offset: 0x00034558
		public unsafe SpeedZone currentSpeedZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_currentSpeedZone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpeedZone>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_currentSpeedZone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700227D RID: 8829
		// (get) Token: 0x060071FD RID: 29181 RVA: 0x001F310C File Offset: 0x001F130C
		// (set) Token: 0x060071FE RID: 29182 RVA: 0x00036377 File Offset: 0x00034577
		public unsafe LandVehicle vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700227E RID: 8830
		// (get) Token: 0x060071FF RID: 29183 RVA: 0x001F313C File Offset: 0x001F133C
		// (set) Token: 0x06007200 RID: 29184 RVA: 0x00036396 File Offset: 0x00034596
		public unsafe float wheelbase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_wheelbase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_wheelbase)) = value;
			}
		}

		// Token: 0x1700227F RID: 8831
		// (get) Token: 0x06007201 RID: 29185 RVA: 0x001F3164 File Offset: 0x001F1364
		// (set) Token: 0x06007202 RID: 29186 RVA: 0x000363B1 File Offset: 0x000345B1
		public unsafe float wheeltrack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_wheeltrack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_wheeltrack)) = value;
			}
		}

		// Token: 0x17002280 RID: 8832
		// (get) Token: 0x06007203 RID: 29187 RVA: 0x001F318C File Offset: 0x001F138C
		// (set) Token: 0x06007204 RID: 29188 RVA: 0x000363CC File Offset: 0x000345CC
		public unsafe float vehicleLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_vehicleLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_vehicleLength)) = value;
			}
		}

		// Token: 0x17002281 RID: 8833
		// (get) Token: 0x06007205 RID: 29189 RVA: 0x001F31B4 File Offset: 0x001F13B4
		// (set) Token: 0x06007206 RID: 29190 RVA: 0x000363E7 File Offset: 0x000345E7
		public unsafe float vehicleWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_vehicleWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_vehicleWidth)) = value;
			}
		}

		// Token: 0x17002282 RID: 8834
		// (get) Token: 0x06007207 RID: 29191 RVA: 0x001F31DC File Offset: 0x001F13DC
		// (set) Token: 0x06007208 RID: 29192 RVA: 0x00036402 File Offset: 0x00034602
		public unsafe float turnRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_turnRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_turnRadius)) = value;
			}
		}

		// Token: 0x17002283 RID: 8835
		// (get) Token: 0x06007209 RID: 29193 RVA: 0x001F3204 File Offset: 0x001F1404
		// (set) Token: 0x0600720A RID: 29194 RVA: 0x0003641D File Offset: 0x0003461D
		public unsafe float sweepTrack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepTrack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepTrack)) = value;
			}
		}

		// Token: 0x17002284 RID: 8836
		// (get) Token: 0x0600720B RID: 29195 RVA: 0x001F322C File Offset: 0x001F142C
		// (set) Token: 0x0600720C RID: 29196 RVA: 0x00036438 File Offset: 0x00034638
		public unsafe float wheelBottomOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_wheelBottomOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_wheelBottomOffset)) = value;
			}
		}

		// Token: 0x17002285 RID: 8837
		// (get) Token: 0x0600720D RID: 29197 RVA: 0x001F3254 File Offset: 0x001F1454
		// (set) Token: 0x0600720E RID: 29198 RVA: 0x00036453 File Offset: 0x00034653
		public unsafe float targetSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_targetSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_targetSpeed)) = value;
			}
		}

		// Token: 0x17002286 RID: 8838
		// (get) Token: 0x0600720F RID: 29199 RVA: 0x001F327C File Offset: 0x001F147C
		// (set) Token: 0x06007210 RID: 29200 RVA: 0x0003646E File Offset: 0x0003466E
		public unsafe float targetSteerAngle_Normalized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_targetSteerAngle_Normalized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_targetSteerAngle_Normalized)) = value;
			}
		}

		// Token: 0x17002287 RID: 8839
		// (get) Token: 0x06007211 RID: 29201 RVA: 0x001F32A4 File Offset: 0x001F14A4
		// (set) Token: 0x06007212 RID: 29202 RVA: 0x00036489 File Offset: 0x00034689
		public unsafe float lateralOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_lateralOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_lateralOffset)) = value;
			}
		}

		// Token: 0x17002288 RID: 8840
		// (get) Token: 0x06007213 RID: 29203 RVA: 0x001F32CC File Offset: 0x001F14CC
		// (set) Token: 0x06007214 RID: 29204 RVA: 0x000364A4 File Offset: 0x000346A4
		public unsafe PathSmoothingUtility.SmoothedPath path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_path);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathSmoothingUtility.SmoothedPath>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_path), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002289 RID: 8841
		// (get) Token: 0x06007215 RID: 29205 RVA: 0x001F32FC File Offset: 0x001F14FC
		// (set) Token: 0x06007216 RID: 29206 RVA: 0x000364C3 File Offset: 0x000346C3
		public unsafe float timeSinceLastNavigationCall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_timeSinceLastNavigationCall);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_timeSinceLastNavigationCall)) = value;
			}
		}

		// Token: 0x1700228A RID: 8842
		// (get) Token: 0x06007217 RID: 29207 RVA: 0x001F3324 File Offset: 0x001F1524
		// (set) Token: 0x06007218 RID: 29208 RVA: 0x000364DE File Offset: 0x000346DE
		public unsafe float sweepTestFailedTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepTestFailedTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepTestFailedTime)) = value;
			}
		}

		// Token: 0x1700228B RID: 8843
		// (get) Token: 0x06007219 RID: 29209 RVA: 0x001F334C File Offset: 0x001F154C
		// (set) Token: 0x0600721A RID: 29210 RVA: 0x000364F9 File Offset: 0x000346F9
		public unsafe NavigationSettings currentNavigationSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_currentNavigationSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_currentNavigationSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700228C RID: 8844
		// (get) Token: 0x0600721B RID: 29211 RVA: 0x001F337C File Offset: 0x001F157C
		// (set) Token: 0x0600721C RID: 29212 RVA: 0x00036518 File Offset: 0x00034718
		public unsafe Coroutine navigationCalculationRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_navigationCalculationRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_navigationCalculationRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700228D RID: 8845
		// (get) Token: 0x0600721D RID: 29213 RVA: 0x001F33AC File Offset: 0x001F15AC
		// (set) Token: 0x0600721E RID: 29214 RVA: 0x00036537 File Offset: 0x00034737
		public unsafe Coroutine reverseCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_reverseCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_reverseCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D58 RID: 19800
		private static readonly IntPtr NativeFieldInfoPtr_VehicleGraphName;

		// Token: 0x04004D59 RID: 19801
		private static readonly IntPtr NativeFieldInfoPtr_RoadGraphName;

		// Token: 0x04004D5A RID: 19802
		private static readonly IntPtr NativeFieldInfoPtr_MaxDistanceFromPath;

		// Token: 0x04004D5B RID: 19803
		private static readonly IntPtr NativeFieldInfoPtr_MaxDistanceFromPathWhenReversing;

		// Token: 0x04004D5C RID: 19804
		private static readonly IntPtr NativeFieldInfoPtr_MainGraphSamplePoint;

		// Token: 0x04004D5D RID: 19805
		private static readonly IntPtr NativeFieldInfoPtr_MinRenavigationRate;

		// Token: 0x04004D5E RID: 19806
		private static readonly IntPtr NativeFieldInfoPtr_Steer_P;

		// Token: 0x04004D5F RID: 19807
		private static readonly IntPtr NativeFieldInfoPtr_Steer_I;

		// Token: 0x04004D60 RID: 19808
		private static readonly IntPtr NativeFieldInfoPtr_Steer_D;

		// Token: 0x04004D61 RID: 19809
		private static readonly IntPtr NativeFieldInfoPtr_Throttle_P;

		// Token: 0x04004D62 RID: 19810
		private static readonly IntPtr NativeFieldInfoPtr_Throttle_I;

		// Token: 0x04004D63 RID: 19811
		private static readonly IntPtr NativeFieldInfoPtr_Throttle_D;

		// Token: 0x04004D64 RID: 19812
		private static readonly IntPtr NativeFieldInfoPtr_Steer_Rate;

		// Token: 0x04004D65 RID: 19813
		private static readonly IntPtr NativeFieldInfoPtr_MaxAxlePositionShift;

		// Token: 0x04004D66 RID: 19814
		private static readonly IntPtr NativeFieldInfoPtr_OBSTACLE_MIN_RANGE;

		// Token: 0x04004D67 RID: 19815
		private static readonly IntPtr NativeFieldInfoPtr_OBSTACLE_MAX_RANGE;

		// Token: 0x04004D68 RID: 19816
		private static readonly IntPtr NativeFieldInfoPtr_MAX_STEER_ANGLE_OVERRIDE;

		// Token: 0x04004D69 RID: 19817
		private static readonly IntPtr NativeFieldInfoPtr_KINEMATIC_MODE_MIN_DISTANCE;

		// Token: 0x04004D6A RID: 19818
		private static readonly IntPtr NativeFieldInfoPtr_INFREQUENT_UPDATE_RATE;

		// Token: 0x04004D6B RID: 19819
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG_MODE;

		// Token: 0x04004D6C RID: 19820
		private static readonly IntPtr NativeFieldInfoPtr__KinematicMode_k__BackingField;

		// Token: 0x04004D6D RID: 19821
		private static readonly IntPtr NativeFieldInfoPtr__AutoDriving_k__BackingField;

		// Token: 0x04004D6E RID: 19822
		private static readonly IntPtr NativeFieldInfoPtr__TargetLocation_k__BackingField;

		// Token: 0x04004D6F RID: 19823
		private static readonly IntPtr NativeFieldInfoPtr_Flags;

		// Token: 0x04004D70 RID: 19824
		private static readonly IntPtr NativeFieldInfoPtr_roadSeeker;

		// Token: 0x04004D71 RID: 19825
		private static readonly IntPtr NativeFieldInfoPtr_generalSeeker;

		// Token: 0x04004D72 RID: 19826
		private static readonly IntPtr NativeFieldInfoPtr_CTE_Origin;

		// Token: 0x04004D73 RID: 19827
		private static readonly IntPtr NativeFieldInfoPtr_FrontAxlePosition;

		// Token: 0x04004D74 RID: 19828
		private static readonly IntPtr NativeFieldInfoPtr_RearAxlePosition;

		// Token: 0x04004D75 RID: 19829
		private static readonly IntPtr NativeFieldInfoPtr_sensor_FL;

		// Token: 0x04004D76 RID: 19830
		private static readonly IntPtr NativeFieldInfoPtr_sensor_FM;

		// Token: 0x04004D77 RID: 19831
		private static readonly IntPtr NativeFieldInfoPtr_sensor_FR;

		// Token: 0x04004D78 RID: 19832
		private static readonly IntPtr NativeFieldInfoPtr_sensor_RR;

		// Token: 0x04004D79 RID: 19833
		private static readonly IntPtr NativeFieldInfoPtr_sensor_RL;

		// Token: 0x04004D7A RID: 19834
		private static readonly IntPtr NativeFieldInfoPtr_sweepMask;

		// Token: 0x04004D7B RID: 19835
		private static readonly IntPtr NativeFieldInfoPtr_sweepOrigin_FL;

		// Token: 0x04004D7C RID: 19836
		private static readonly IntPtr NativeFieldInfoPtr_sweepOrigin_FR;

		// Token: 0x04004D7D RID: 19837
		private static readonly IntPtr NativeFieldInfoPtr_sweepOrigin_RL;

		// Token: 0x04004D7E RID: 19838
		private static readonly IntPtr NativeFieldInfoPtr_sweepOrigin_RR;

		// Token: 0x04004D7F RID: 19839
		private static readonly IntPtr NativeFieldInfoPtr_leftWheel;

		// Token: 0x04004D80 RID: 19840
		private static readonly IntPtr NativeFieldInfoPtr_rightWheel;

		// Token: 0x04004D81 RID: 19841
		private static readonly IntPtr NativeFieldInfoPtr_sweepSegment;

		// Token: 0x04004D82 RID: 19842
		private static readonly IntPtr NativeFieldInfoPtr_sampleStepSizeMin;

		// Token: 0x04004D83 RID: 19843
		private static readonly IntPtr NativeFieldInfoPtr_sampleStepSizeMax;

		// Token: 0x04004D84 RID: 19844
		private static readonly IntPtr NativeFieldInfoPtr_aheadPointSamples;

		// Token: 0x04004D85 RID: 19845
		private static readonly IntPtr NativeFieldInfoPtr_DestinationDistanceSlowThreshold;

		// Token: 0x04004D86 RID: 19846
		private static readonly IntPtr NativeFieldInfoPtr_DestinationArrivalThreshold;

		// Token: 0x04004D87 RID: 19847
		private static readonly IntPtr NativeFieldInfoPtr_steerTargetFollowRate;

		// Token: 0x04004D88 RID: 19848
		private static readonly IntPtr NativeFieldInfoPtr_steerPID;

		// Token: 0x04004D89 RID: 19849
		private static readonly IntPtr NativeFieldInfoPtr_turnSpeedReductionMinRange;

		// Token: 0x04004D8A RID: 19850
		private static readonly IntPtr NativeFieldInfoPtr_turnSpeedReductionMaxRange;

		// Token: 0x04004D8B RID: 19851
		private static readonly IntPtr NativeFieldInfoPtr_turnSpeedReductionDivisor;

		// Token: 0x04004D8C RID: 19852
		private static readonly IntPtr NativeFieldInfoPtr_minTurnSpeedReductionAngleThreshold;

		// Token: 0x04004D8D RID: 19853
		private static readonly IntPtr NativeFieldInfoPtr_minTurningSpeed;

		// Token: 0x04004D8E RID: 19854
		private static readonly IntPtr NativeFieldInfoPtr_throttleMin;

		// Token: 0x04004D8F RID: 19855
		private static readonly IntPtr NativeFieldInfoPtr_throttleMax;

		// Token: 0x04004D90 RID: 19856
		private static readonly IntPtr NativeFieldInfoPtr_throttlePID;

		// Token: 0x04004D91 RID: 19857
		private static readonly IntPtr NativeFieldInfoPtr_UnmarkedSpeed;

		// Token: 0x04004D92 RID: 19858
		private static readonly IntPtr NativeFieldInfoPtr_ReverseSpeed;

		// Token: 0x04004D93 RID: 19859
		private static readonly IntPtr NativeFieldInfoPtr_speedReductionTracker;

		// Token: 0x04004D94 RID: 19860
		private static readonly IntPtr NativeFieldInfoPtr_PursuitModeEnabled;

		// Token: 0x04004D95 RID: 19861
		private static readonly IntPtr NativeFieldInfoPtr_PursuitTarget;

		// Token: 0x04004D96 RID: 19862
		private static readonly IntPtr NativeFieldInfoPtr_PursuitDistanceUpdateThreshold;

		// Token: 0x04004D97 RID: 19863
		private static readonly IntPtr NativeFieldInfoPtr_PursuitTargetLastPosition;

		// Token: 0x04004D98 RID: 19864
		private static readonly IntPtr NativeFieldInfoPtr_Teleporter;

		// Token: 0x04004D99 RID: 19865
		private static readonly IntPtr NativeFieldInfoPtr_PositionHistoryTracker;

		// Token: 0x04004D9A RID: 19866
		private static readonly IntPtr NativeFieldInfoPtr_StuckTimeThreshold;

		// Token: 0x04004D9B RID: 19867
		private static readonly IntPtr NativeFieldInfoPtr_StuckSamples;

		// Token: 0x04004D9C RID: 19868
		private static readonly IntPtr NativeFieldInfoPtr_StuckDistanceThreshold;

		// Token: 0x04004D9D RID: 19869
		private static readonly IntPtr NativeFieldInfoPtr_storedNavigationCallback;

		// Token: 0x04004D9E RID: 19870
		private static readonly IntPtr NativeFieldInfoPtr_currentSpeedZone;

		// Token: 0x04004D9F RID: 19871
		private static readonly IntPtr NativeFieldInfoPtr_vehicle;

		// Token: 0x04004DA0 RID: 19872
		private static readonly IntPtr NativeFieldInfoPtr_wheelbase;

		// Token: 0x04004DA1 RID: 19873
		private static readonly IntPtr NativeFieldInfoPtr_wheeltrack;

		// Token: 0x04004DA2 RID: 19874
		private static readonly IntPtr NativeFieldInfoPtr_vehicleLength;

		// Token: 0x04004DA3 RID: 19875
		private static readonly IntPtr NativeFieldInfoPtr_vehicleWidth;

		// Token: 0x04004DA4 RID: 19876
		private static readonly IntPtr NativeFieldInfoPtr_turnRadius;

		// Token: 0x04004DA5 RID: 19877
		private static readonly IntPtr NativeFieldInfoPtr_sweepTrack;

		// Token: 0x04004DA6 RID: 19878
		private static readonly IntPtr NativeFieldInfoPtr_wheelBottomOffset;

		// Token: 0x04004DA7 RID: 19879
		private static readonly IntPtr NativeFieldInfoPtr_targetSpeed;

		// Token: 0x04004DA8 RID: 19880
		private static readonly IntPtr NativeFieldInfoPtr_targetSteerAngle_Normalized;

		// Token: 0x04004DA9 RID: 19881
		private static readonly IntPtr NativeFieldInfoPtr_lateralOffset;

		// Token: 0x04004DAA RID: 19882
		private static readonly IntPtr NativeFieldInfoPtr_path;

		// Token: 0x04004DAB RID: 19883
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastNavigationCall;

		// Token: 0x04004DAC RID: 19884
		private static readonly IntPtr NativeFieldInfoPtr_sweepTestFailedTime;

		// Token: 0x04004DAD RID: 19885
		private static readonly IntPtr NativeFieldInfoPtr_currentNavigationSettings;

		// Token: 0x04004DAE RID: 19886
		private static readonly IntPtr NativeFieldInfoPtr_navigationCalculationRoutine;

		// Token: 0x04004DAF RID: 19887
		private static readonly IntPtr NativeFieldInfoPtr_reverseCoroutine;

		// Token: 0x04004DB0 RID: 19888
		private static readonly IntPtr NativeMethodInfoPtr_get_KinematicMode_Public_get_Boolean_0;

		// Token: 0x04004DB1 RID: 19889
		private static readonly IntPtr NativeMethodInfoPtr_set_KinematicMode_Protected_set_Void_Boolean_0;

		// Token: 0x04004DB2 RID: 19890
		private static readonly IntPtr NativeMethodInfoPtr_get_AutoDriving_Public_get_Boolean_0;

		// Token: 0x04004DB3 RID: 19891
		private static readonly IntPtr NativeMethodInfoPtr_set_AutoDriving_Protected_set_Void_Boolean_0;

		// Token: 0x04004DB4 RID: 19892
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReversing_Public_get_Boolean_0;

		// Token: 0x04004DB5 RID: 19893
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetLocation_Public_get_Vector3_0;

		// Token: 0x04004DB6 RID: 19894
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetLocation_Protected_set_Void_Vector3_0;

		// Token: 0x04004DB7 RID: 19895
		private static readonly IntPtr NativeMethodInfoPtr_get_sampleStepSize_Protected_get_Single_0;

		// Token: 0x04004DB8 RID: 19896
		private static readonly IntPtr NativeMethodInfoPtr_get_turnSpeedReductionRange_Protected_get_Single_0;

		// Token: 0x04004DB9 RID: 19897
		private static readonly IntPtr NativeMethodInfoPtr_get_maxSteerAngle_Protected_get_Single_0;

		// Token: 0x04004DBA RID: 19898
		private static readonly IntPtr NativeMethodInfoPtr_get_FrontOfVehiclePosition_Private_get_Vector3_0;

		// Token: 0x04004DBB RID: 19899
		private static readonly IntPtr NativeMethodInfoPtr_get_NavigationCalculationInProgress_Public_get_Boolean_0;

		// Token: 0x04004DBC RID: 19900
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004DBD RID: 19901
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04004DBE RID: 19902
		private static readonly IntPtr NativeMethodInfoPtr_InitializeVehicleData_Private_Void_0;

		// Token: 0x04004DBF RID: 19903
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004DC0 RID: 19904
		private static readonly IntPtr NativeMethodInfoPtr_InfrequentUpdate_Protected_Void_0;

		// Token: 0x04004DC1 RID: 19905
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Void_0;

		// Token: 0x04004DC2 RID: 19906
		private static readonly IntPtr NativeMethodInfoPtr_UpdateKinematic_Protected_Void_Single_0;

		// Token: 0x04004DC3 RID: 19907
		private static readonly IntPtr NativeMethodInfoPtr_GetAxleGroundHit_Private_Vector3_Boolean_0;

		// Token: 0x04004DC4 RID: 19908
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSweep_Private_Void_0;

		// Token: 0x04004DC5 RID: 19909
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSpeedReduction_Private_Void_0;

		// Token: 0x04004DC6 RID: 19910
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePursuitMode_Private_Void_0;

		// Token: 0x04004DC7 RID: 19911
		private static readonly IntPtr NativeMethodInfoPtr_UpdateStuckDetection_Private_Void_0;

		// Token: 0x04004DC8 RID: 19912
		private static readonly IntPtr NativeMethodInfoPtr_CheckDistanceFromPath_Private_Void_0;

		// Token: 0x04004DC9 RID: 19913
		private static readonly IntPtr NativeMethodInfoPtr_UpdateOvertaking_Private_Void_0;

		// Token: 0x04004DCA RID: 19914
		private static readonly IntPtr NativeMethodInfoPtr_RefreshSpeedZone_Protected_Virtual_New_Void_0;

		// Token: 0x04004DCB RID: 19915
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSpeed_Protected_Virtual_New_Void_0;

		// Token: 0x04004DCC RID: 19916
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSteering_Protected_Void_0;

		// Token: 0x04004DCD RID: 19917
		private static readonly IntPtr NativeMethodInfoPtr_Navigate_Public_Void_Vector3_NavigationSettings_NavigationCallback_0;

		// Token: 0x04004DCE RID: 19918
		private static readonly IntPtr NativeMethodInfoPtr_NavigationCalculationCallback_Private_Void_ENavigationCalculationResult_SmoothedPath_0;

		// Token: 0x04004DCF RID: 19919
		private static readonly IntPtr NativeMethodInfoPtr_EndDriving_Private_Void_0;

		// Token: 0x04004DD0 RID: 19920
		private static readonly IntPtr NativeMethodInfoPtr_StopNavigating_Public_Void_0;

		// Token: 0x04004DD1 RID: 19921
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateNavigation_Public_Void_0;

		// Token: 0x04004DD2 RID: 19922
		private static readonly IntPtr NativeMethodInfoPtr_SweepTurn_Public_Boolean_ESweepType_Single_Boolean_byref_Single_byref_Vector3_Single_0;

		// Token: 0x04004DD3 RID: 19923
		private static readonly IntPtr NativeMethodInfoPtr_BetterSweepTurn_Public_Void_ESweepType_Single_Boolean_LayerMask_byref_Single_byref_Vector3_0;

		// Token: 0x04004DD4 RID: 19924
		private static readonly IntPtr NativeMethodInfoPtr_StartReverse_Public_Void_0;

		// Token: 0x04004DD5 RID: 19925
		private static readonly IntPtr NativeMethodInfoPtr_Reverse_Public_IEnumerator_0;

		// Token: 0x04004DD6 RID: 19926
		private static readonly IntPtr NativeMethodInfoPtr_StopReversing_Private_Void_0;

		// Token: 0x04004DD7 RID: 19927
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestForwardObstruction_Private_Collider_byref_Single_0;

		// Token: 0x04004DD8 RID: 19928
		private static readonly IntPtr NativeMethodInfoPtr_IsOnVehicleGraph_Public_Boolean_0;

		// Token: 0x04004DD9 RID: 19929
		private static readonly IntPtr NativeMethodInfoPtr_GetDistanceFromVehicleGraph_Private_Single_0;

		// Token: 0x04004DDA RID: 19930
		private static readonly IntPtr NativeMethodInfoPtr_GetPathLateralDirection_Private_Vector3_0;

		// Token: 0x04004DDB RID: 19931
		private static readonly IntPtr NativeMethodInfoPtr_GetIsStuck_Public_Boolean_0;

		// Token: 0x04004DDC RID: 19932
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004DDD RID: 19933
		private static readonly IntPtr NativeMethodInfoPtr__Reverse_b__139_0_Private_Boolean_0;

		// Token: 0x02000A79 RID: 2681
		[OriginalName("Assembly-CSharp.dll", "", "ENavigationResult")]
		public enum ENavigationResult
		{
			// Token: 0x04008D79 RID: 36217
			Failed,
			// Token: 0x04008D7A RID: 36218
			Complete,
			// Token: 0x04008D7B RID: 36219
			Stopped
		}

		// Token: 0x02000A7A RID: 2682
		[OriginalName("Assembly-CSharp.dll", "", "EAgentStatus")]
		public enum EAgentStatus
		{
			// Token: 0x04008D7D RID: 36221
			Inactive,
			// Token: 0x04008D7E RID: 36222
			MovingToRoad,
			// Token: 0x04008D7F RID: 36223
			OnRoad
		}

		// Token: 0x02000A7B RID: 2683
		[OriginalName("Assembly-CSharp.dll", "", "EPathGroupStatus")]
		public enum EPathGroupStatus
		{
			// Token: 0x04008D81 RID: 36225
			Inactive,
			// Token: 0x04008D82 RID: 36226
			Calculating
		}

		// Token: 0x02000A7C RID: 2684
		[OriginalName("Assembly-CSharp.dll", "", "ESweepType")]
		public enum ESweepType
		{
			// Token: 0x04008D84 RID: 36228
			FL,
			// Token: 0x04008D85 RID: 36229
			FR,
			// Token: 0x04008D86 RID: 36230
			RL,
			// Token: 0x04008D87 RID: 36231
			RR
		}

		// Token: 0x02000A7D RID: 2685
		public sealed class NavigationCallback : MulticastDelegate
		{
			// Token: 0x0600D1BE RID: 53694 RVA: 0x003237CC File Offset: 0x003219CC
			// Note: this type is marked as 'beforefieldinit'.
			static NavigationCallback()
			{
				Il2CppClassPointerStore<VehicleAgent.NavigationCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "NavigationCallback");
				VehicleAgent.NavigationCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.NavigationCallback>.NativeClassPtr, 100677580);
				VehicleAgent.NavigationCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ENavigationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.NavigationCallback>.NativeClassPtr, 100677581);
				VehicleAgent.NavigationCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ENavigationResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.NavigationCallback>.NativeClassPtr, 100677582);
				VehicleAgent.NavigationCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.NavigationCallback>.NativeClassPtr, 100677583);
			}

			// Token: 0x0600D1BF RID: 53695 RVA: 0x00323840 File Offset: 0x00321A40
			[CallerCount(97)]
			[CachedScanResults(RefRangeStart = 222622, RefRangeEnd = 222719, XrefRangeStart = 222619, XrefRangeEnd = 222622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NavigationCallback(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleAgent.NavigationCallback>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NavigationCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1C0 RID: 53696 RVA: 0x0032389C File Offset: 0x00321A9C
			[CallerCount(0)]
			public unsafe void Invoke(VehicleAgent.ENavigationResult status)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref status;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NavigationCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ENavigationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1C1 RID: 53697 RVA: 0x003238DC File Offset: 0x00321ADC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222719, XrefRangeEnd = 222723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(VehicleAgent.ENavigationResult status, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref status;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NavigationCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ENavigationResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600D1C2 RID: 53698 RVA: 0x0032394C File Offset: 0x00321B4C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22499, RefRangeEnd = 22500, XrefRangeStart = 22499, XrefRangeEnd = 22500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NavigationCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1C3 RID: 53699 RVA: 0x00066265 File Offset: 0x00064465
			public NavigationCallback(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D1C4 RID: 53700 RVA: 0x0006626E File Offset: 0x0006446E
			public static implicit operator VehicleAgent.NavigationCallback(Action<VehicleAgent.ENavigationResult> A_0)
			{
				return DelegateSupport.ConvertDelegate<VehicleAgent.NavigationCallback>(A_0);
			}

			// Token: 0x0600D1C5 RID: 53701 RVA: 0x00066276 File Offset: 0x00064476
			public static VehicleAgent.NavigationCallback operator +(VehicleAgent.NavigationCallback A_0, VehicleAgent.NavigationCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VehicleAgent.NavigationCallback>();
			}

			// Token: 0x0600D1C6 RID: 53702 RVA: 0x00066284 File Offset: 0x00064484
			public static VehicleAgent.NavigationCallback operator -(VehicleAgent.NavigationCallback A_0, VehicleAgent.NavigationCallback A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<VehicleAgent.NavigationCallback>();
				}
				return result;
			}

			// Token: 0x04008D88 RID: 36232
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008D89 RID: 36233
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ENavigationResult_0;

			// Token: 0x04008D8A RID: 36234
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ENavigationResult_AsyncCallback_Object_0;

			// Token: 0x04008D8B RID: 36235
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000A7E RID: 2686
		[ObfuscatedName("ScheduleOne.Vehicles.AI.VehicleAgent+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D1C7 RID: 53703 RVA: 0x00323990 File Offset: 0x00321B90
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<VehicleAgent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleAgent.__c>.NativeClassPtr);
				VehicleAgent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent.__c>.NativeClassPtr, "<>9");
				VehicleAgent.__c.NativeFieldInfoPtr___9__120_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent.__c>.NativeClassPtr, "<>9__120_0");
				VehicleAgent.__c.NativeFieldInfoPtr___9__121_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent.__c>.NativeClassPtr, "<>9__121_0");
				VehicleAgent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.__c>.NativeClassPtr, 100677585);
				VehicleAgent.__c.NativeMethodInfoPtr__UpdateKinematic_b__120_0_Internal_Single_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.__c>.NativeClassPtr, 100677586);
				VehicleAgent.__c.NativeMethodInfoPtr__GetAxleGroundHit_b__121_0_Internal_Single_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.__c>.NativeClassPtr, 100677587);
			}

			// Token: 0x0600D1C8 RID: 53704 RVA: 0x00323A34 File Offset: 0x00321C34
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleAgent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1C9 RID: 53705 RVA: 0x00323A70 File Offset: 0x00321C70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222723, XrefRangeEnd = 222724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _UpdateKinematic_b__120_0(RaycastHit h)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref h;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.__c.NativeMethodInfoPtr__UpdateKinematic_b__120_0_Internal_Single_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D1CA RID: 53706 RVA: 0x00323ABC File Offset: 0x00321CBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetAxleGroundHit_b__121_0(RaycastHit h)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref h;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.__c.NativeMethodInfoPtr__GetAxleGroundHit_b__121_0_Internal_Single_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D1CB RID: 53707 RVA: 0x00066295 File Offset: 0x00064495
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700411D RID: 16669
			// (get) Token: 0x0600D1CC RID: 53708 RVA: 0x00323B08 File Offset: 0x00321D08
			// (set) Token: 0x0600D1CD RID: 53709 RVA: 0x0006629E File Offset: 0x0006449E
			public unsafe static VehicleAgent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VehicleAgent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleAgent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VehicleAgent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700411E RID: 16670
			// (get) Token: 0x0600D1CE RID: 53710 RVA: 0x00323B30 File Offset: 0x00321D30
			// (set) Token: 0x0600D1CF RID: 53711 RVA: 0x000662B0 File Offset: 0x000644B0
			public unsafe static Func<RaycastHit, float> __9__120_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VehicleAgent.__c.NativeFieldInfoPtr___9__120_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RaycastHit, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VehicleAgent.__c.NativeFieldInfoPtr___9__120_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700411F RID: 16671
			// (get) Token: 0x0600D1D0 RID: 53712 RVA: 0x00323B58 File Offset: 0x00321D58
			// (set) Token: 0x0600D1D1 RID: 53713 RVA: 0x000662C2 File Offset: 0x000644C2
			public unsafe static Func<RaycastHit, float> __9__121_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VehicleAgent.__c.NativeFieldInfoPtr___9__121_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RaycastHit, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VehicleAgent.__c.NativeFieldInfoPtr___9__121_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D8C RID: 36236
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008D8D RID: 36237
			private static readonly IntPtr NativeFieldInfoPtr___9__120_0;

			// Token: 0x04008D8E RID: 36238
			private static readonly IntPtr NativeFieldInfoPtr___9__121_0;

			// Token: 0x04008D8F RID: 36239
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D90 RID: 36240
			private static readonly IntPtr NativeMethodInfoPtr__UpdateKinematic_b__120_0_Internal_Single_RaycastHit_0;

			// Token: 0x04008D91 RID: 36241
			private static readonly IntPtr NativeMethodInfoPtr__GetAxleGroundHit_b__121_0_Internal_Single_RaycastHit_0;
		}

		// Token: 0x02000A7F RID: 2687
		[ObfuscatedName("ScheduleOne.Vehicles.AI.VehicleAgent+<>c__DisplayClass136_0")]
		public sealed class __c__DisplayClass136_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D1D2 RID: 53714 RVA: 0x00323B80 File Offset: 0x00321D80
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass136_0()
			{
				Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass136_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "<>c__DisplayClass136_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass136_0>.NativeClassPtr);
				VehicleAgent.__c__DisplayClass136_0.NativeFieldInfoPtr_castStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass136_0>.NativeClassPtr, "castStart");
				VehicleAgent.__c__DisplayClass136_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass136_0>.NativeClassPtr, "<>9__0");
				VehicleAgent.__c__DisplayClass136_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass136_0>.NativeClassPtr, 100677588);
				VehicleAgent.__c__DisplayClass136_0.NativeMethodInfoPtr__SweepTurn_b__0_Internal_Single_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass136_0>.NativeClassPtr, 100677589);
			}

			// Token: 0x0600D1D3 RID: 53715 RVA: 0x00323BFC File Offset: 0x00321DFC
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass136_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass136_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.__c__DisplayClass136_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1D4 RID: 53716 RVA: 0x00323C38 File Offset: 0x00321E38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222724, XrefRangeEnd = 222730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _SweepTurn_b__0(RaycastHit x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.__c__DisplayClass136_0.NativeMethodInfoPtr__SweepTurn_b__0_Internal_Single_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D1D5 RID: 53717 RVA: 0x000662D4 File Offset: 0x000644D4
			public __c__DisplayClass136_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004120 RID: 16672
			// (get) Token: 0x0600D1D6 RID: 53718 RVA: 0x00323C84 File Offset: 0x00321E84
			// (set) Token: 0x0600D1D7 RID: 53719 RVA: 0x000662DD File Offset: 0x000644DD
			public unsafe Vector3 castStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.__c__DisplayClass136_0.NativeFieldInfoPtr_castStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.__c__DisplayClass136_0.NativeFieldInfoPtr_castStart)) = value;
				}
			}

			// Token: 0x17004121 RID: 16673
			// (get) Token: 0x0600D1D8 RID: 53720 RVA: 0x00323CAC File Offset: 0x00321EAC
			// (set) Token: 0x0600D1D9 RID: 53721 RVA: 0x000662F8 File Offset: 0x000644F8
			public unsafe Func<RaycastHit, float> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.__c__DisplayClass136_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RaycastHit, float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.__c__DisplayClass136_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D92 RID: 36242
			private static readonly IntPtr NativeFieldInfoPtr_castStart;

			// Token: 0x04008D93 RID: 36243
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04008D94 RID: 36244
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D95 RID: 36245
			private static readonly IntPtr NativeMethodInfoPtr__SweepTurn_b__0_Internal_Single_RaycastHit_0;
		}

		// Token: 0x02000A80 RID: 2688
		[ObfuscatedName("ScheduleOne.Vehicles.AI.VehicleAgent+<>c__DisplayClass137_0")]
		public sealed class __c__DisplayClass137_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D1DA RID: 53722 RVA: 0x00323CDC File Offset: 0x00321EDC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass137_0()
			{
				Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass137_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "<>c__DisplayClass137_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass137_0>.NativeClassPtr);
				VehicleAgent.__c__DisplayClass137_0.NativeFieldInfoPtr_castStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass137_0>.NativeClassPtr, "castStart");
				VehicleAgent.__c__DisplayClass137_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass137_0>.NativeClassPtr, "<>9__0");
				VehicleAgent.__c__DisplayClass137_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass137_0>.NativeClassPtr, 100677590);
				VehicleAgent.__c__DisplayClass137_0.NativeMethodInfoPtr__BetterSweepTurn_b__0_Internal_Single_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass137_0>.NativeClassPtr, 100677591);
			}

			// Token: 0x0600D1DB RID: 53723 RVA: 0x00323D58 File Offset: 0x00321F58
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass137_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass137_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.__c__DisplayClass137_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1DC RID: 53724 RVA: 0x00323D94 File Offset: 0x00321F94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _BetterSweepTurn_b__0(RaycastHit x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.__c__DisplayClass137_0.NativeMethodInfoPtr__BetterSweepTurn_b__0_Internal_Single_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D1DD RID: 53725 RVA: 0x00066317 File Offset: 0x00064517
			public __c__DisplayClass137_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004122 RID: 16674
			// (get) Token: 0x0600D1DE RID: 53726 RVA: 0x00323DE0 File Offset: 0x00321FE0
			// (set) Token: 0x0600D1DF RID: 53727 RVA: 0x00066320 File Offset: 0x00064520
			public unsafe Vector3 castStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.__c__DisplayClass137_0.NativeFieldInfoPtr_castStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.__c__DisplayClass137_0.NativeFieldInfoPtr_castStart)) = value;
				}
			}

			// Token: 0x17004123 RID: 16675
			// (get) Token: 0x0600D1E0 RID: 53728 RVA: 0x00323E08 File Offset: 0x00322008
			// (set) Token: 0x0600D1E1 RID: 53729 RVA: 0x0006633B File Offset: 0x0006453B
			public unsafe Func<RaycastHit, float> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.__c__DisplayClass137_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RaycastHit, float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.__c__DisplayClass137_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D96 RID: 36246
			private static readonly IntPtr NativeFieldInfoPtr_castStart;

			// Token: 0x04008D97 RID: 36247
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04008D98 RID: 36248
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D99 RID: 36249
			private static readonly IntPtr NativeMethodInfoPtr__BetterSweepTurn_b__0_Internal_Single_RaycastHit_0;
		}

		// Token: 0x02000A81 RID: 2689
		[ObfuscatedName("ScheduleOne.Vehicles.AI.VehicleAgent+<Reverse>d__139")]
		public sealed class _Reverse_d__139 : Il2CppSystem.Object
		{
			// Token: 0x0600D1E2 RID: 53730 RVA: 0x00323E38 File Offset: 0x00322038
			// Note: this type is marked as 'beforefieldinit'.
			static _Reverse_d__139()
			{
				Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "<Reverse>d__139");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr);
				VehicleAgent._Reverse_d__139.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, "<>1__state");
				VehicleAgent._Reverse_d__139.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, "<>2__current");
				VehicleAgent._Reverse_d__139.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, "<>4__this");
				VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__futureTarget_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, "<futureTarget>5__2");
				VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__steerAngleNormal_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, "<steerAngleNormal>5__3");
				VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__frontWheel_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, "<frontWheel>5__4");
				VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__sweepAngle_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, "<sweepAngle>5__5");
				VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__reverseSweepDistanceMin_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, "<reverseSweepDistanceMin>5__6");
				VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__canBeginSwing_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, "<canBeginSwing>5__7");
				VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__faceTarget_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, "<faceTarget>5__8");
				VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__continueReversing_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, "<continueReversing>5__9");
				VehicleAgent._Reverse_d__139.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, 100677592);
				VehicleAgent._Reverse_d__139.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, 100677593);
				VehicleAgent._Reverse_d__139.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, 100677594);
				VehicleAgent._Reverse_d__139.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, 100677595);
				VehicleAgent._Reverse_d__139.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, 100677596);
				VehicleAgent._Reverse_d__139.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, 100677597);
			}

			// Token: 0x0600D1E3 RID: 53731 RVA: 0x00323FB8 File Offset: 0x003221B8
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Reverse_d__139(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent._Reverse_d__139.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1E4 RID: 53732 RVA: 0x00324000 File Offset: 0x00322200
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent._Reverse_d__139.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1E5 RID: 53733 RVA: 0x00324034 File Offset: 0x00322234
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222730, XrefRangeEnd = 222750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent._Reverse_d__139.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700412F RID: 16687
			// (get) Token: 0x0600D1E6 RID: 53734 RVA: 0x00324070 File Offset: 0x00322270
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent._Reverse_d__139.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D1E7 RID: 53735 RVA: 0x003240B0 File Offset: 0x003222B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222750, XrefRangeEnd = 222755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent._Reverse_d__139.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004130 RID: 16688
			// (get) Token: 0x0600D1E8 RID: 53736 RVA: 0x003240E4 File Offset: 0x003222E4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent._Reverse_d__139.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D1E9 RID: 53737 RVA: 0x0006635A File Offset: 0x0006455A
			public _Reverse_d__139(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004124 RID: 16676
			// (get) Token: 0x0600D1EA RID: 53738 RVA: 0x00324124 File Offset: 0x00322324
			// (set) Token: 0x0600D1EB RID: 53739 RVA: 0x00066363 File Offset: 0x00064563
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004125 RID: 16677
			// (get) Token: 0x0600D1EC RID: 53740 RVA: 0x0032414C File Offset: 0x0032234C
			// (set) Token: 0x0600D1ED RID: 53741 RVA: 0x0006637E File Offset: 0x0006457E
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004126 RID: 16678
			// (get) Token: 0x0600D1EE RID: 53742 RVA: 0x0032417C File Offset: 0x0032237C
			// (set) Token: 0x0600D1EF RID: 53743 RVA: 0x0006639D File Offset: 0x0006459D
			public unsafe VehicleAgent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleAgent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004127 RID: 16679
			// (get) Token: 0x0600D1F0 RID: 53744 RVA: 0x003241AC File Offset: 0x003223AC
			// (set) Token: 0x0600D1F1 RID: 53745 RVA: 0x000663BC File Offset: 0x000645BC
			public unsafe Vector3 _futureTarget_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__futureTarget_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__futureTarget_5__2)) = value;
				}
			}

			// Token: 0x17004128 RID: 16680
			// (get) Token: 0x0600D1F2 RID: 53746 RVA: 0x003241D4 File Offset: 0x003223D4
			// (set) Token: 0x0600D1F3 RID: 53747 RVA: 0x000663D7 File Offset: 0x000645D7
			public unsafe float _steerAngleNormal_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__steerAngleNormal_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__steerAngleNormal_5__3)) = value;
				}
			}

			// Token: 0x17004129 RID: 16681
			// (get) Token: 0x0600D1F4 RID: 53748 RVA: 0x003241FC File Offset: 0x003223FC
			// (set) Token: 0x0600D1F5 RID: 53749 RVA: 0x000663F2 File Offset: 0x000645F2
			public unsafe VehicleAgent.ESweepType _frontWheel_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__frontWheel_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__frontWheel_5__4)) = value;
				}
			}

			// Token: 0x1700412A RID: 16682
			// (get) Token: 0x0600D1F6 RID: 53750 RVA: 0x00324224 File Offset: 0x00322424
			// (set) Token: 0x0600D1F7 RID: 53751 RVA: 0x0006640D File Offset: 0x0006460D
			public unsafe float _sweepAngle_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__sweepAngle_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__sweepAngle_5__5)) = value;
				}
			}

			// Token: 0x1700412B RID: 16683
			// (get) Token: 0x0600D1F8 RID: 53752 RVA: 0x0032424C File Offset: 0x0032244C
			// (set) Token: 0x0600D1F9 RID: 53753 RVA: 0x00066428 File Offset: 0x00064628
			public unsafe float _reverseSweepDistanceMin_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__reverseSweepDistanceMin_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__reverseSweepDistanceMin_5__6)) = value;
				}
			}

			// Token: 0x1700412C RID: 16684
			// (get) Token: 0x0600D1FA RID: 53754 RVA: 0x00324274 File Offset: 0x00322474
			// (set) Token: 0x0600D1FB RID: 53755 RVA: 0x00066443 File Offset: 0x00064643
			public unsafe bool _canBeginSwing_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__canBeginSwing_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__canBeginSwing_5__7)) = value;
				}
			}

			// Token: 0x1700412D RID: 16685
			// (get) Token: 0x0600D1FC RID: 53756 RVA: 0x0032429C File Offset: 0x0032249C
			// (set) Token: 0x0600D1FD RID: 53757 RVA: 0x0006645E File Offset: 0x0006465E
			public unsafe Vector3 _faceTarget_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__faceTarget_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__faceTarget_5__8)) = value;
				}
			}

			// Token: 0x1700412E RID: 16686
			// (get) Token: 0x0600D1FE RID: 53758 RVA: 0x003242C4 File Offset: 0x003224C4
			// (set) Token: 0x0600D1FF RID: 53759 RVA: 0x00066479 File Offset: 0x00064679
			public unsafe bool _continueReversing_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__continueReversing_5__9);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__continueReversing_5__9)) = value;
				}
			}

			// Token: 0x04008D9A RID: 36250
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008D9B RID: 36251
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008D9C RID: 36252
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008D9D RID: 36253
			private static readonly IntPtr NativeFieldInfoPtr__futureTarget_5__2;

			// Token: 0x04008D9E RID: 36254
			private static readonly IntPtr NativeFieldInfoPtr__steerAngleNormal_5__3;

			// Token: 0x04008D9F RID: 36255
			private static readonly IntPtr NativeFieldInfoPtr__frontWheel_5__4;

			// Token: 0x04008DA0 RID: 36256
			private static readonly IntPtr NativeFieldInfoPtr__sweepAngle_5__5;

			// Token: 0x04008DA1 RID: 36257
			private static readonly IntPtr NativeFieldInfoPtr__reverseSweepDistanceMin_5__6;

			// Token: 0x04008DA2 RID: 36258
			private static readonly IntPtr NativeFieldInfoPtr__canBeginSwing_5__7;

			// Token: 0x04008DA3 RID: 36259
			private static readonly IntPtr NativeFieldInfoPtr__faceTarget_5__8;

			// Token: 0x04008DA4 RID: 36260
			private static readonly IntPtr NativeFieldInfoPtr__continueReversing_5__9;

			// Token: 0x04008DA5 RID: 36261
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008DA6 RID: 36262
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008DA7 RID: 36263
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008DA8 RID: 36264
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008DA9 RID: 36265
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008DAA RID: 36266
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
