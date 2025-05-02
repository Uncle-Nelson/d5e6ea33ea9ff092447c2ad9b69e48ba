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
using Il2CppScheduleOne.Misc;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Product.Packaging;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Police
{
	// Token: 0x020001FA RID: 506
	public class RoadCheckpoint : NetworkBehaviour
	{
		// Token: 0x06002967 RID: 10599 RVA: 0x000F3E3C File Offset: 0x000F203C
		// Note: this type is marked as 'beforefieldinit'.
		static RoadCheckpoint()
		{
			Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Police", "RoadCheckpoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr);
			RoadCheckpoint.NativeFieldInfoPtr_MAX_TIME_OPEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "MAX_TIME_OPEN");
			RoadCheckpoint.NativeFieldInfoPtr__ActivationState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "<ActivationState>k__BackingField");
			RoadCheckpoint.NativeFieldInfoPtr_appliedState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "appliedState");
			RoadCheckpoint.NativeFieldInfoPtr__Gate1Open_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "<Gate1Open>k__BackingField");
			RoadCheckpoint.NativeFieldInfoPtr__Gate2Open_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "<Gate2Open>k__BackingField");
			RoadCheckpoint.NativeFieldInfoPtr_AssignedNPCs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "AssignedNPCs");
			RoadCheckpoint.NativeFieldInfoPtr_MaxStealthLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "MaxStealthLevel");
			RoadCheckpoint.NativeFieldInfoPtr_OpenForNPCs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "OpenForNPCs");
			RoadCheckpoint.NativeFieldInfoPtr_EnabledOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "EnabledOnStart");
			RoadCheckpoint.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "container");
			RoadCheckpoint.NativeFieldInfoPtr_Stopper1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "Stopper1");
			RoadCheckpoint.NativeFieldInfoPtr_Stopper2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "Stopper2");
			RoadCheckpoint.NativeFieldInfoPtr_SearchArea1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "SearchArea1");
			RoadCheckpoint.NativeFieldInfoPtr_SearchArea2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "SearchArea2");
			RoadCheckpoint.NativeFieldInfoPtr_VehicleObstacle1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "VehicleObstacle1");
			RoadCheckpoint.NativeFieldInfoPtr_VehicleObstacle2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "VehicleObstacle2");
			RoadCheckpoint.NativeFieldInfoPtr_NPCVehicleDetectionArea1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "NPCVehicleDetectionArea1");
			RoadCheckpoint.NativeFieldInfoPtr_NPCVehicleDetectionArea2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "NPCVehicleDetectionArea2");
			RoadCheckpoint.NativeFieldInfoPtr_ImmediateVehicleDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "ImmediateVehicleDetector");
			RoadCheckpoint.NativeFieldInfoPtr_TrafficCones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "TrafficCones");
			RoadCheckpoint.NativeFieldInfoPtr_StandPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "StandPoints");
			RoadCheckpoint.NativeFieldInfoPtr_trafficConeOriginalTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "trafficConeOriginalTransforms");
			RoadCheckpoint.NativeFieldInfoPtr_timeSinceGate1Open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "timeSinceGate1Open");
			RoadCheckpoint.NativeFieldInfoPtr_vehicleDetectedSinceGate1Open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "vehicleDetectedSinceGate1Open");
			RoadCheckpoint.NativeFieldInfoPtr_timeSinceGate2Open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "timeSinceGate2Open");
			RoadCheckpoint.NativeFieldInfoPtr_vehicleDetectedSinceGate2Open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "vehicleDetectedSinceGate2Open");
			RoadCheckpoint.NativeFieldInfoPtr_onPlayerWalkThrough = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "onPlayerWalkThrough");
			RoadCheckpoint.NativeFieldInfoPtr_syncVar____Gate1Open_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "syncVar___<Gate1Open>k__BackingField");
			RoadCheckpoint.NativeFieldInfoPtr_syncVar____Gate2Open_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "syncVar___<Gate2Open>k__BackingField");
			RoadCheckpoint.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Police.RoadCheckpointAssembly-CSharp.dll_Excuted");
			RoadCheckpoint.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Police.RoadCheckpointAssembly-CSharp.dll_Excuted");
			RoadCheckpoint.NativeMethodInfoPtr_get_ActivationState_Public_get_ECheckpointState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100667983);
			RoadCheckpoint.NativeMethodInfoPtr_set_ActivationState_Protected_set_Void_ECheckpointState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100667984);
			RoadCheckpoint.NativeMethodInfoPtr_get_Gate1Open_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100667985);
			RoadCheckpoint.NativeMethodInfoPtr_set_Gate1Open_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100667986);
			RoadCheckpoint.NativeMethodInfoPtr_get_Gate2Open_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100667987);
			RoadCheckpoint.NativeMethodInfoPtr_set_Gate2Open_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100667988);
			RoadCheckpoint.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100667989);
			RoadCheckpoint.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100667990);
			RoadCheckpoint.NativeMethodInfoPtr_ApplyState_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100667991);
			RoadCheckpoint.NativeMethodInfoPtr_Enable_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100667992);
			RoadCheckpoint.NativeMethodInfoPtr_Disable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100667993);
			RoadCheckpoint.NativeMethodInfoPtr_SetGate1Open_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100667994);
			RoadCheckpoint.NativeMethodInfoPtr_SetGate2Open_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100667995);
			RoadCheckpoint.NativeMethodInfoPtr_ResetTrafficCones_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100667996);
			RoadCheckpoint.NativeMethodInfoPtr_PlayerDetected_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100667997);
			RoadCheckpoint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100667998);
			RoadCheckpoint.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100667999);
			RoadCheckpoint.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668000);
			RoadCheckpoint.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668001);
			RoadCheckpoint.NativeMethodInfoPtr_RpcWriter___Observers_Enable_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668002);
			RoadCheckpoint.NativeMethodInfoPtr_RpcLogic___Enable_328543758_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668003);
			RoadCheckpoint.NativeMethodInfoPtr_RpcReader___Observers_Enable_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668004);
			RoadCheckpoint.NativeMethodInfoPtr_RpcWriter___Target_Enable_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668005);
			RoadCheckpoint.NativeMethodInfoPtr_RpcReader___Target_Enable_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668006);
			RoadCheckpoint.NativeMethodInfoPtr_RpcWriter___Observers_Disable_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668007);
			RoadCheckpoint.NativeMethodInfoPtr_RpcLogic___Disable_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668008);
			RoadCheckpoint.NativeMethodInfoPtr_RpcReader___Observers_Disable_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668009);
			RoadCheckpoint.NativeMethodInfoPtr_sync___get_value__Gate1Open_k__BackingField_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668010);
			RoadCheckpoint.NativeMethodInfoPtr_sync___set_value__Gate1Open_k__BackingField_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668011);
			RoadCheckpoint.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Police_RoadCheckpoint_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668012);
			RoadCheckpoint.NativeMethodInfoPtr_sync___get_value__Gate2Open_k__BackingField_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668013);
			RoadCheckpoint.NativeMethodInfoPtr_sync___set_value__Gate2Open_k__BackingField_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668014);
			RoadCheckpoint.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668015);
		}

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x06002968 RID: 10600 RVA: 0x000F436C File Offset: 0x000F256C
		// (set) Token: 0x06002969 RID: 10601 RVA: 0x000F43A8 File Offset: 0x000F25A8
		public unsafe RoadCheckpoint.ECheckpointState ActivationState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_get_ActivationState_Public_get_ECheckpointState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_set_ActivationState_Protected_set_Void_ECheckpointState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x0600296A RID: 10602 RVA: 0x000F43E8 File Offset: 0x000F25E8
		// (set) Token: 0x0600296B RID: 10603 RVA: 0x000F4424 File Offset: 0x000F2624
		public unsafe bool Gate1Open
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_get_Gate1Open_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 119942, RefRangeEnd = 119946, XrefRangeStart = 119935, XrefRangeEnd = 119942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_set_Gate1Open_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x0600296C RID: 10604 RVA: 0x000F4464 File Offset: 0x000F2664
		// (set) Token: 0x0600296D RID: 10605 RVA: 0x000F44A0 File Offset: 0x000F26A0
		public unsafe bool Gate2Open
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_get_Gate2Open_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 119953, RefRangeEnd = 119956, XrefRangeStart = 119946, XrefRangeEnd = 119953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_set_Gate2Open_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600296E RID: 10606 RVA: 0x000F44E0 File Offset: 0x000F26E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119956, XrefRangeEnd = 119957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoadCheckpoint.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x000F451C File Offset: 0x000F271C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119957, XrefRangeEnd = 119980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoadCheckpoint.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002970 RID: 10608 RVA: 0x000F4558 File Offset: 0x000F2758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119980, XrefRangeEnd = 119983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoadCheckpoint.NativeMethodInfoPtr_ApplyState_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002971 RID: 10609 RVA: 0x000F4594 File Offset: 0x000F2794
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 120020, RefRangeEnd = 120024, XrefRangeStart = 119983, XrefRangeEnd = 120020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enable(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_Enable_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002972 RID: 10610 RVA: 0x000F45D8 File Offset: 0x000F27D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 120045, RefRangeEnd = 120047, XrefRangeStart = 120024, XrefRangeEnd = 120045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_Disable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002973 RID: 10611 RVA: 0x000F460C File Offset: 0x000F280C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 119942, RefRangeEnd = 119946, XrefRangeStart = 119942, XrefRangeEnd = 119946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGate1Open(bool o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref o;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_SetGate1Open_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002974 RID: 10612 RVA: 0x000F464C File Offset: 0x000F284C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 119953, RefRangeEnd = 119956, XrefRangeStart = 119953, XrefRangeEnd = 119956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGate2Open(bool o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref o;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_SetGate2Open_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002975 RID: 10613 RVA: 0x000F468C File Offset: 0x000F288C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 120062, RefRangeEnd = 120066, XrefRangeStart = 120047, XrefRangeEnd = 120062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetTrafficCones()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_ResetTrafficCones_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002976 RID: 10614 RVA: 0x000F46C0 File Offset: 0x000F28C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120066, XrefRangeEnd = 120069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerDetected(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_PlayerDetected_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002977 RID: 10615 RVA: 0x000F4704 File Offset: 0x000F2904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120069, XrefRangeEnd = 120084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RoadCheckpoint() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002978 RID: 10616 RVA: 0x000F4740 File Offset: 0x000F2940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120084, XrefRangeEnd = 120126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoadCheckpoint.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x000F477C File Offset: 0x000F297C
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoadCheckpoint.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x000F47B8 File Offset: 0x000F29B8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoadCheckpoint.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x000F47F4 File Offset: 0x000F29F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120126, XrefRangeEnd = 120144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Enable_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_RpcWriter___Observers_Enable_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x000F4838 File Offset: 0x000F2A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120144, XrefRangeEnd = 120145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Enable_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_RpcLogic___Enable_328543758_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x000F487C File Offset: 0x000F2A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120145, XrefRangeEnd = 120148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Enable_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_RpcReader___Observers_Enable_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600297E RID: 10622 RVA: 0x000F48CC File Offset: 0x000F2ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120148, XrefRangeEnd = 120166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_Enable_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_RpcWriter___Target_Enable_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600297F RID: 10623 RVA: 0x000F4910 File Offset: 0x000F2B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120166, XrefRangeEnd = 120169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_Enable_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_RpcReader___Target_Enable_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002980 RID: 10624 RVA: 0x000F4960 File Offset: 0x000F2B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120169, XrefRangeEnd = 120187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Disable_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_RpcWriter___Observers_Disable_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002981 RID: 10625 RVA: 0x000F4994 File Offset: 0x000F2B94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 120200, RefRangeEnd = 120202, XrefRangeStart = 120187, XrefRangeEnd = 120200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Disable_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_RpcLogic___Disable_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002982 RID: 10626 RVA: 0x000F49C8 File Offset: 0x000F2BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120202, XrefRangeEnd = 120205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Disable_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_RpcReader___Observers_Disable_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x06002983 RID: 10627 RVA: 0x000F4A18 File Offset: 0x000F2C18
		// (set) Token: 0x06002984 RID: 10628 RVA: 0x000F4A54 File Offset: 0x000F2C54
		public unsafe bool SyncAccessor_<Gate1Open>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_sync___get_value__Gate1Open_k__BackingField_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 120213, RefRangeEnd = 120214, XrefRangeStart = 120205, XrefRangeEnd = 120213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_sync___set_value__Gate1Open_k__BackingField_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002985 RID: 10629 RVA: 0x000F4AA0 File Offset: 0x000F2CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120214, XrefRangeEnd = 120217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Police_RoadCheckpoint(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoadCheckpoint.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Police_RoadCheckpoint_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x06002986 RID: 10630 RVA: 0x000F4B14 File Offset: 0x000F2D14
		// (set) Token: 0x06002987 RID: 10631 RVA: 0x000F4B50 File Offset: 0x000F2D50
		public unsafe bool SyncAccessor_<Gate2Open>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_sync___get_value__Gate2Open_k__BackingField_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120217, XrefRangeEnd = 120225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_sync___set_value__Gate2Open_k__BackingField_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002988 RID: 10632 RVA: 0x000F4B9C File Offset: 0x000F2D9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 120242, RefRangeEnd = 120243, XrefRangeStart = 120225, XrefRangeEnd = 120242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoadCheckpoint.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002989 RID: 10633 RVA: 0x0001664C File Offset: 0x0001484C
		public RoadCheckpoint(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x0600298A RID: 10634 RVA: 0x000F4BD8 File Offset: 0x000F2DD8
		// (set) Token: 0x0600298B RID: 10635 RVA: 0x00016655 File Offset: 0x00014855
		public unsafe static float MAX_TIME_OPEN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(RoadCheckpoint.NativeFieldInfoPtr_MAX_TIME_OPEN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RoadCheckpoint.NativeFieldInfoPtr_MAX_TIME_OPEN, (void*)(&value));
			}
		}

		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x0600298C RID: 10636 RVA: 0x000F4BF4 File Offset: 0x000F2DF4
		// (set) Token: 0x0600298D RID: 10637 RVA: 0x00016663 File Offset: 0x00014863
		public unsafe RoadCheckpoint.ECheckpointState _ActivationState_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr__ActivationState_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr__ActivationState_k__BackingField)) = value;
			}
		}

		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x0600298E RID: 10638 RVA: 0x000F4C1C File Offset: 0x000F2E1C
		// (set) Token: 0x0600298F RID: 10639 RVA: 0x0001667E File Offset: 0x0001487E
		public unsafe RoadCheckpoint.ECheckpointState appliedState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_appliedState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_appliedState)) = value;
			}
		}

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x06002990 RID: 10640 RVA: 0x000F4C44 File Offset: 0x000F2E44
		// (set) Token: 0x06002991 RID: 10641 RVA: 0x00016699 File Offset: 0x00014899
		public unsafe bool _Gate1Open_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr__Gate1Open_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr__Gate1Open_k__BackingField)) = value;
			}
		}

		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x06002992 RID: 10642 RVA: 0x000F4C6C File Offset: 0x000F2E6C
		// (set) Token: 0x06002993 RID: 10643 RVA: 0x000166B4 File Offset: 0x000148B4
		public unsafe bool _Gate2Open_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr__Gate2Open_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr__Gate2Open_k__BackingField)) = value;
			}
		}

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x06002994 RID: 10644 RVA: 0x000F4C94 File Offset: 0x000F2E94
		// (set) Token: 0x06002995 RID: 10645 RVA: 0x000166CF File Offset: 0x000148CF
		public unsafe List<NPC> AssignedNPCs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_AssignedNPCs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_AssignedNPCs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x06002996 RID: 10646 RVA: 0x000F4CC4 File Offset: 0x000F2EC4
		// (set) Token: 0x06002997 RID: 10647 RVA: 0x000166EE File Offset: 0x000148EE
		public unsafe EStealthLevel MaxStealthLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_MaxStealthLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_MaxStealthLevel)) = value;
			}
		}

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x06002998 RID: 10648 RVA: 0x000F4CEC File Offset: 0x000F2EEC
		// (set) Token: 0x06002999 RID: 10649 RVA: 0x00016709 File Offset: 0x00014909
		public unsafe bool OpenForNPCs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_OpenForNPCs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_OpenForNPCs)) = value;
			}
		}

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x0600299A RID: 10650 RVA: 0x000F4D14 File Offset: 0x000F2F14
		// (set) Token: 0x0600299B RID: 10651 RVA: 0x00016724 File Offset: 0x00014924
		public unsafe bool EnabledOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_EnabledOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_EnabledOnStart)) = value;
			}
		}

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x0600299C RID: 10652 RVA: 0x000F4D3C File Offset: 0x000F2F3C
		// (set) Token: 0x0600299D RID: 10653 RVA: 0x0001673F File Offset: 0x0001493F
		public unsafe GameObject container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x0600299E RID: 10654 RVA: 0x000F4D6C File Offset: 0x000F2F6C
		// (set) Token: 0x0600299F RID: 10655 RVA: 0x0001675E File Offset: 0x0001495E
		public unsafe CarStopper Stopper1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_Stopper1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CarStopper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_Stopper1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x060029A0 RID: 10656 RVA: 0x000F4D9C File Offset: 0x000F2F9C
		// (set) Token: 0x060029A1 RID: 10657 RVA: 0x0001677D File Offset: 0x0001497D
		public unsafe CarStopper Stopper2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_Stopper2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CarStopper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_Stopper2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x060029A2 RID: 10658 RVA: 0x000F4DCC File Offset: 0x000F2FCC
		// (set) Token: 0x060029A3 RID: 10659 RVA: 0x0001679C File Offset: 0x0001499C
		public unsafe VehicleDetector SearchArea1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_SearchArea1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_SearchArea1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x060029A4 RID: 10660 RVA: 0x000F4DFC File Offset: 0x000F2FFC
		// (set) Token: 0x060029A5 RID: 10661 RVA: 0x000167BB File Offset: 0x000149BB
		public unsafe VehicleDetector SearchArea2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_SearchArea2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_SearchArea2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x060029A6 RID: 10662 RVA: 0x000F4E2C File Offset: 0x000F302C
		// (set) Token: 0x060029A7 RID: 10663 RVA: 0x000167DA File Offset: 0x000149DA
		public unsafe VehicleObstacle VehicleObstacle1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_VehicleObstacle1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleObstacle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_VehicleObstacle1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x060029A8 RID: 10664 RVA: 0x000F4E5C File Offset: 0x000F305C
		// (set) Token: 0x060029A9 RID: 10665 RVA: 0x000167F9 File Offset: 0x000149F9
		public unsafe VehicleObstacle VehicleObstacle2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_VehicleObstacle2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleObstacle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_VehicleObstacle2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x060029AA RID: 10666 RVA: 0x000F4E8C File Offset: 0x000F308C
		// (set) Token: 0x060029AB RID: 10667 RVA: 0x00016818 File Offset: 0x00014A18
		public unsafe VehicleDetector NPCVehicleDetectionArea1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_NPCVehicleDetectionArea1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_NPCVehicleDetectionArea1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x060029AC RID: 10668 RVA: 0x000F4EBC File Offset: 0x000F30BC
		// (set) Token: 0x060029AD RID: 10669 RVA: 0x00016837 File Offset: 0x00014A37
		public unsafe VehicleDetector NPCVehicleDetectionArea2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_NPCVehicleDetectionArea2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_NPCVehicleDetectionArea2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x060029AE RID: 10670 RVA: 0x000F4EEC File Offset: 0x000F30EC
		// (set) Token: 0x060029AF RID: 10671 RVA: 0x00016856 File Offset: 0x00014A56
		public unsafe VehicleDetector ImmediateVehicleDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_ImmediateVehicleDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_ImmediateVehicleDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x060029B0 RID: 10672 RVA: 0x000F4F1C File Offset: 0x000F311C
		// (set) Token: 0x060029B1 RID: 10673 RVA: 0x00016875 File Offset: 0x00014A75
		public unsafe Il2CppReferenceArray<Rigidbody> TrafficCones
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_TrafficCones);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Rigidbody>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_TrafficCones), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x060029B2 RID: 10674 RVA: 0x000F4F4C File Offset: 0x000F314C
		// (set) Token: 0x060029B3 RID: 10675 RVA: 0x00016894 File Offset: 0x00014A94
		public unsafe Il2CppReferenceArray<Transform> StandPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_StandPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_StandPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x060029B4 RID: 10676 RVA: 0x000F4F7C File Offset: 0x000F317C
		// (set) Token: 0x060029B5 RID: 10677 RVA: 0x000168B3 File Offset: 0x00014AB3
		public unsafe Dictionary<Rigidbody, Tuple<Vector3, Quaternion>> trafficConeOriginalTransforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_trafficConeOriginalTransforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Rigidbody, Tuple<Vector3, Quaternion>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_trafficConeOriginalTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x060029B6 RID: 10678 RVA: 0x000F4FAC File Offset: 0x000F31AC
		// (set) Token: 0x060029B7 RID: 10679 RVA: 0x000168D2 File Offset: 0x00014AD2
		public unsafe float timeSinceGate1Open
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_timeSinceGate1Open);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_timeSinceGate1Open)) = value;
			}
		}

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x060029B8 RID: 10680 RVA: 0x000F4FD4 File Offset: 0x000F31D4
		// (set) Token: 0x060029B9 RID: 10681 RVA: 0x000168ED File Offset: 0x00014AED
		public unsafe bool vehicleDetectedSinceGate1Open
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_vehicleDetectedSinceGate1Open);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_vehicleDetectedSinceGate1Open)) = value;
			}
		}

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x060029BA RID: 10682 RVA: 0x000F4FFC File Offset: 0x000F31FC
		// (set) Token: 0x060029BB RID: 10683 RVA: 0x00016908 File Offset: 0x00014B08
		public unsafe float timeSinceGate2Open
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_timeSinceGate2Open);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_timeSinceGate2Open)) = value;
			}
		}

		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x060029BC RID: 10684 RVA: 0x000F5024 File Offset: 0x000F3224
		// (set) Token: 0x060029BD RID: 10685 RVA: 0x00016923 File Offset: 0x00014B23
		public unsafe bool vehicleDetectedSinceGate2Open
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_vehicleDetectedSinceGate2Open);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_vehicleDetectedSinceGate2Open)) = value;
			}
		}

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x060029BE RID: 10686 RVA: 0x000F504C File Offset: 0x000F324C
		// (set) Token: 0x060029BF RID: 10687 RVA: 0x0001693E File Offset: 0x00014B3E
		public unsafe UnityEvent<Player> onPlayerWalkThrough
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_onPlayerWalkThrough);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_onPlayerWalkThrough), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x060029C0 RID: 10688 RVA: 0x000F507C File Offset: 0x000F327C
		// (set) Token: 0x060029C1 RID: 10689 RVA: 0x0001695D File Offset: 0x00014B5D
		public unsafe SyncVar<bool> syncVar____Gate1Open_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_syncVar____Gate1Open_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_syncVar____Gate1Open_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x060029C2 RID: 10690 RVA: 0x000F50AC File Offset: 0x000F32AC
		// (set) Token: 0x060029C3 RID: 10691 RVA: 0x0001697C File Offset: 0x00014B7C
		public unsafe SyncVar<bool> syncVar____Gate2Open_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_syncVar____Gate2Open_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_syncVar____Gate2Open_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x060029C4 RID: 10692 RVA: 0x000F50DC File Offset: 0x000F32DC
		// (set) Token: 0x060029C5 RID: 10693 RVA: 0x0001699B File Offset: 0x00014B9B
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x060029C6 RID: 10694 RVA: 0x000F5104 File Offset: 0x000F3304
		// (set) Token: 0x060029C7 RID: 10695 RVA: 0x000169B6 File Offset: 0x00014BB6
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04001B84 RID: 7044
		private static readonly IntPtr NativeFieldInfoPtr_MAX_TIME_OPEN;

		// Token: 0x04001B85 RID: 7045
		private static readonly IntPtr NativeFieldInfoPtr__ActivationState_k__BackingField;

		// Token: 0x04001B86 RID: 7046
		private static readonly IntPtr NativeFieldInfoPtr_appliedState;

		// Token: 0x04001B87 RID: 7047
		private static readonly IntPtr NativeFieldInfoPtr__Gate1Open_k__BackingField;

		// Token: 0x04001B88 RID: 7048
		private static readonly IntPtr NativeFieldInfoPtr__Gate2Open_k__BackingField;

		// Token: 0x04001B89 RID: 7049
		private static readonly IntPtr NativeFieldInfoPtr_AssignedNPCs;

		// Token: 0x04001B8A RID: 7050
		private static readonly IntPtr NativeFieldInfoPtr_MaxStealthLevel;

		// Token: 0x04001B8B RID: 7051
		private static readonly IntPtr NativeFieldInfoPtr_OpenForNPCs;

		// Token: 0x04001B8C RID: 7052
		private static readonly IntPtr NativeFieldInfoPtr_EnabledOnStart;

		// Token: 0x04001B8D RID: 7053
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x04001B8E RID: 7054
		private static readonly IntPtr NativeFieldInfoPtr_Stopper1;

		// Token: 0x04001B8F RID: 7055
		private static readonly IntPtr NativeFieldInfoPtr_Stopper2;

		// Token: 0x04001B90 RID: 7056
		private static readonly IntPtr NativeFieldInfoPtr_SearchArea1;

		// Token: 0x04001B91 RID: 7057
		private static readonly IntPtr NativeFieldInfoPtr_SearchArea2;

		// Token: 0x04001B92 RID: 7058
		private static readonly IntPtr NativeFieldInfoPtr_VehicleObstacle1;

		// Token: 0x04001B93 RID: 7059
		private static readonly IntPtr NativeFieldInfoPtr_VehicleObstacle2;

		// Token: 0x04001B94 RID: 7060
		private static readonly IntPtr NativeFieldInfoPtr_NPCVehicleDetectionArea1;

		// Token: 0x04001B95 RID: 7061
		private static readonly IntPtr NativeFieldInfoPtr_NPCVehicleDetectionArea2;

		// Token: 0x04001B96 RID: 7062
		private static readonly IntPtr NativeFieldInfoPtr_ImmediateVehicleDetector;

		// Token: 0x04001B97 RID: 7063
		private static readonly IntPtr NativeFieldInfoPtr_TrafficCones;

		// Token: 0x04001B98 RID: 7064
		private static readonly IntPtr NativeFieldInfoPtr_StandPoints;

		// Token: 0x04001B99 RID: 7065
		private static readonly IntPtr NativeFieldInfoPtr_trafficConeOriginalTransforms;

		// Token: 0x04001B9A RID: 7066
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceGate1Open;

		// Token: 0x04001B9B RID: 7067
		private static readonly IntPtr NativeFieldInfoPtr_vehicleDetectedSinceGate1Open;

		// Token: 0x04001B9C RID: 7068
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceGate2Open;

		// Token: 0x04001B9D RID: 7069
		private static readonly IntPtr NativeFieldInfoPtr_vehicleDetectedSinceGate2Open;

		// Token: 0x04001B9E RID: 7070
		private static readonly IntPtr NativeFieldInfoPtr_onPlayerWalkThrough;

		// Token: 0x04001B9F RID: 7071
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____Gate1Open_k__BackingField;

		// Token: 0x04001BA0 RID: 7072
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____Gate2Open_k__BackingField;

		// Token: 0x04001BA1 RID: 7073
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04001BA2 RID: 7074
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04001BA3 RID: 7075
		private static readonly IntPtr NativeMethodInfoPtr_get_ActivationState_Public_get_ECheckpointState_0;

		// Token: 0x04001BA4 RID: 7076
		private static readonly IntPtr NativeMethodInfoPtr_set_ActivationState_Protected_set_Void_ECheckpointState_0;

		// Token: 0x04001BA5 RID: 7077
		private static readonly IntPtr NativeMethodInfoPtr_get_Gate1Open_Public_get_Boolean_0;

		// Token: 0x04001BA6 RID: 7078
		private static readonly IntPtr NativeMethodInfoPtr_set_Gate1Open_Protected_set_Void_Boolean_0;

		// Token: 0x04001BA7 RID: 7079
		private static readonly IntPtr NativeMethodInfoPtr_get_Gate2Open_Public_get_Boolean_0;

		// Token: 0x04001BA8 RID: 7080
		private static readonly IntPtr NativeMethodInfoPtr_set_Gate2Open_Protected_set_Void_Boolean_0;

		// Token: 0x04001BA9 RID: 7081
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04001BAA RID: 7082
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1;

		// Token: 0x04001BAB RID: 7083
		private static readonly IntPtr NativeMethodInfoPtr_ApplyState_Protected_Virtual_New_Void_1;

		// Token: 0x04001BAC RID: 7084
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Void_NetworkConnection_0;

		// Token: 0x04001BAD RID: 7085
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Void_0;

		// Token: 0x04001BAE RID: 7086
		private static readonly IntPtr NativeMethodInfoPtr_SetGate1Open_Public_Void_Boolean_0;

		// Token: 0x04001BAF RID: 7087
		private static readonly IntPtr NativeMethodInfoPtr_SetGate2Open_Public_Void_Boolean_0;

		// Token: 0x04001BB0 RID: 7088
		private static readonly IntPtr NativeMethodInfoPtr_ResetTrafficCones_Private_Void_0;

		// Token: 0x04001BB1 RID: 7089
		private static readonly IntPtr NativeMethodInfoPtr_PlayerDetected_Public_Void_Player_0;

		// Token: 0x04001BB2 RID: 7090
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001BB3 RID: 7091
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04001BB4 RID: 7092
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04001BB5 RID: 7093
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04001BB6 RID: 7094
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Enable_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04001BB7 RID: 7095
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Enable_328543758_Public_Void_NetworkConnection_0;

		// Token: 0x04001BB8 RID: 7096
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Enable_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001BB9 RID: 7097
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_Enable_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04001BBA RID: 7098
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_Enable_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001BBB RID: 7099
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Disable_2166136261_Private_Void_0;

		// Token: 0x04001BBC RID: 7100
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Disable_2166136261_Public_Void_0;

		// Token: 0x04001BBD RID: 7101
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Disable_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001BBE RID: 7102
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__Gate1Open_k__BackingField_Public_get_Boolean_0;

		// Token: 0x04001BBF RID: 7103
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__Gate1Open_k__BackingField_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x04001BC0 RID: 7104
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Police_RoadCheckpoint_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04001BC1 RID: 7105
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__Gate2Open_k__BackingField_Public_get_Boolean_0;

		// Token: 0x04001BC2 RID: 7106
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__Gate2Open_k__BackingField_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x04001BC3 RID: 7107
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x020008DD RID: 2269
		[OriginalName("Assembly-CSharp.dll", "", "ECheckpointState")]
		public enum ECheckpointState
		{
			// Token: 0x04008524 RID: 34084
			Disabled,
			// Token: 0x04008525 RID: 34085
			Enabled
		}
	}
}
