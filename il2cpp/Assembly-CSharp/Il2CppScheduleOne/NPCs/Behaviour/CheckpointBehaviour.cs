using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Law;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Police;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000344 RID: 836
	public class CheckpointBehaviour : Behaviour
	{
		// Token: 0x06003E21 RID: 15905 RVA: 0x0013B11C File Offset: 0x0013931C
		// Note: this type is marked as 'beforefieldinit'.
		static CheckpointBehaviour()
		{
			Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "CheckpointBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr);
			CheckpointBehaviour.NativeFieldInfoPtr_LOOK_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "LOOK_TIME");
			CheckpointBehaviour.NativeFieldInfoPtr__AssignedCheckpoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "<AssignedCheckpoint>k__BackingField");
			CheckpointBehaviour.NativeFieldInfoPtr__Checkpoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "<Checkpoint>k__BackingField");
			CheckpointBehaviour.NativeFieldInfoPtr__IsSearching_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "<IsSearching>k__BackingField");
			CheckpointBehaviour.NativeFieldInfoPtr__CurrentSearchedVehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "<CurrentSearchedVehicle>k__BackingField");
			CheckpointBehaviour.NativeFieldInfoPtr__Initiator_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "<Initiator>k__BackingField");
			CheckpointBehaviour.NativeFieldInfoPtr_currentLookTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "currentLookTime");
			CheckpointBehaviour.NativeFieldInfoPtr_trunkOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "trunkOpened");
			CheckpointBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.CheckpointBehaviourAssembly-CSharp.dll_Excuted");
			CheckpointBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.CheckpointBehaviourAssembly-CSharp.dll_Excuted");
			CheckpointBehaviour.NativeMethodInfoPtr_get_AssignedCheckpoint_Public_get_ECheckpointLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670565);
			CheckpointBehaviour.NativeMethodInfoPtr_set_AssignedCheckpoint_Protected_set_Void_ECheckpointLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670566);
			CheckpointBehaviour.NativeMethodInfoPtr_get_Checkpoint_Public_get_RoadCheckpoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670567);
			CheckpointBehaviour.NativeMethodInfoPtr_set_Checkpoint_Protected_set_Void_RoadCheckpoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670568);
			CheckpointBehaviour.NativeMethodInfoPtr_get_IsSearching_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670569);
			CheckpointBehaviour.NativeMethodInfoPtr_set_IsSearching_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670570);
			CheckpointBehaviour.NativeMethodInfoPtr_get_CurrentSearchedVehicle_Public_get_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670571);
			CheckpointBehaviour.NativeMethodInfoPtr_set_CurrentSearchedVehicle_Protected_set_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670572);
			CheckpointBehaviour.NativeMethodInfoPtr_get_Initiator_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670573);
			CheckpointBehaviour.NativeMethodInfoPtr_set_Initiator_Protected_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670574);
			CheckpointBehaviour.NativeMethodInfoPtr_get_standPoint_Private_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670575);
			CheckpointBehaviour.NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670576);
			CheckpointBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670577);
			CheckpointBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670578);
			CheckpointBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670579);
			CheckpointBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670580);
			CheckpointBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670581);
			CheckpointBehaviour.NativeMethodInfoPtr_SetCheckpoint_Public_Void_ECheckpointLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670582);
			CheckpointBehaviour.NativeMethodInfoPtr_SetInitiator_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670583);
			CheckpointBehaviour.NativeMethodInfoPtr_StartSearch_Public_Void_NetworkObject_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670584);
			CheckpointBehaviour.NativeMethodInfoPtr_StopSearch_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670585);
			CheckpointBehaviour.NativeMethodInfoPtr_SetIsSearching_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670586);
			CheckpointBehaviour.NativeMethodInfoPtr_GetSearchPoint_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670587);
			CheckpointBehaviour.NativeMethodInfoPtr_ConcludeSearch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670588);
			CheckpointBehaviour.NativeMethodInfoPtr_DoesVehicleContainIllicitItems_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670589);
			CheckpointBehaviour.NativeMethodInfoPtr_PlayerWalkedThroughCheckPoint_Private_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670590);
			CheckpointBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670591);
			CheckpointBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670592);
			CheckpointBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670593);
			CheckpointBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670594);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetCheckpoint_4087078542_Private_Void_ECheckpointLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670595);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___SetCheckpoint_4087078542_Public_Void_ECheckpointLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670596);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetCheckpoint_4087078542_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670597);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetInitiator_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670598);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___SetInitiator_3323014238_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670599);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetInitiator_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670600);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Server_StartSearch_3694055493_Private_Void_NetworkObject_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670601);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___StartSearch_3694055493_Public_Void_NetworkObject_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670602);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Server_StartSearch_3694055493_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670603);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Server_StopSearch_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670604);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___StopSearch_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670605);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Server_StopSearch_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670606);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetIsSearching_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670607);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___SetIsSearching_1140765316_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670608);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetIsSearching_1140765316_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670609);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_ConcludeSearch_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670610);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___ConcludeSearch_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670611);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Observers_ConcludeSearch_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670612);
			CheckpointBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670613);
		}

		// Token: 0x1700133E RID: 4926
		// (get) Token: 0x06003E22 RID: 15906 RVA: 0x0013B5E8 File Offset: 0x001397E8
		// (set) Token: 0x06003E23 RID: 15907 RVA: 0x0013B624 File Offset: 0x00139824
		public unsafe CheckpointManager.ECheckpointLocation AssignedCheckpoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_get_AssignedCheckpoint_Public_get_ECheckpointLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_set_AssignedCheckpoint_Protected_set_Void_ECheckpointLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700133F RID: 4927
		// (get) Token: 0x06003E24 RID: 15908 RVA: 0x0013B664 File Offset: 0x00139864
		// (set) Token: 0x06003E25 RID: 15909 RVA: 0x0013B6A4 File Offset: 0x001398A4
		public unsafe RoadCheckpoint Checkpoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_get_Checkpoint_Public_get_RoadCheckpoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RoadCheckpoint>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 115214, RefRangeEnd = 115215, XrefRangeStart = 115214, XrefRangeEnd = 115215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_set_Checkpoint_Protected_set_Void_RoadCheckpoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001340 RID: 4928
		// (get) Token: 0x06003E26 RID: 15910 RVA: 0x0013B6E8 File Offset: 0x001398E8
		// (set) Token: 0x06003E27 RID: 15911 RVA: 0x0013B724 File Offset: 0x00139924
		public unsafe bool IsSearching
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_get_IsSearching_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_set_IsSearching_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001341 RID: 4929
		// (get) Token: 0x06003E28 RID: 15912 RVA: 0x0013B764 File Offset: 0x00139964
		// (set) Token: 0x06003E29 RID: 15913 RVA: 0x0013B7A4 File Offset: 0x001399A4
		public unsafe LandVehicle CurrentSearchedVehicle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_get_CurrentSearchedVehicle_Public_get_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145823, XrefRangeEnd = 145824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_set_CurrentSearchedVehicle_Protected_set_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001342 RID: 4930
		// (get) Token: 0x06003E2A RID: 15914 RVA: 0x0013B7E8 File Offset: 0x001399E8
		// (set) Token: 0x06003E2B RID: 15915 RVA: 0x0013B828 File Offset: 0x00139A28
		public unsafe Player Initiator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_get_Initiator_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145824, XrefRangeEnd = 145825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_set_Initiator_Protected_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001343 RID: 4931
		// (get) Token: 0x06003E2C RID: 15916 RVA: 0x0013B86C File Offset: 0x00139A6C
		public unsafe Transform standPoint
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 145830, RefRangeEnd = 145833, XrefRangeStart = 145825, XrefRangeEnd = 145830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_get_standPoint_Private_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17001344 RID: 4932
		// (get) Token: 0x06003E2D RID: 15917 RVA: 0x0013B8AC File Offset: 0x00139AAC
		public unsafe DialogueDatabase dialogueDatabase
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145833, XrefRangeEnd = 145834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueDatabase>(intPtr3) : null;
			}
		}

		// Token: 0x06003E2E RID: 15918 RVA: 0x0013B8EC File Offset: 0x00139AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145834, XrefRangeEnd = 145859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E2F RID: 15919 RVA: 0x0013B928 File Offset: 0x00139B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145859, XrefRangeEnd = 145884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E30 RID: 15920 RVA: 0x0013B964 File Offset: 0x00139B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145884, XrefRangeEnd = 145908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E31 RID: 15921 RVA: 0x0013B9A0 File Offset: 0x00139BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145908, XrefRangeEnd = 145932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E32 RID: 15922 RVA: 0x0013B9DC File Offset: 0x00139BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145932, XrefRangeEnd = 146016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E33 RID: 15923 RVA: 0x0013BA18 File Offset: 0x00139C18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 146036, RefRangeEnd = 146037, XrefRangeStart = 146016, XrefRangeEnd = 146036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCheckpoint(CheckpointManager.ECheckpointLocation loc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref loc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_SetCheckpoint_Public_Void_ECheckpointLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E34 RID: 15924 RVA: 0x0013BA58 File Offset: 0x00139C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146037, XrefRangeEnd = 146062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInitiator(NetworkObject init)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(init);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_SetInitiator_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E35 RID: 15925 RVA: 0x0013BA9C File Offset: 0x00139C9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 146085, RefRangeEnd = 146086, XrefRangeStart = 146062, XrefRangeEnd = 146085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartSearch(NetworkObject targetVehicle, NetworkObject initiator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetVehicle);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(initiator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_StartSearch_Public_Void_NetworkObject_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E36 RID: 15926 RVA: 0x0013BAF0 File Offset: 0x00139CF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 146107, RefRangeEnd = 146109, XrefRangeStart = 146086, XrefRangeEnd = 146107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopSearch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_StopSearch_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E37 RID: 15927 RVA: 0x0013BB24 File Offset: 0x00139D24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 146131, RefRangeEnd = 146133, XrefRangeStart = 146109, XrefRangeEnd = 146131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsSearching(bool s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref s;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_SetIsSearching_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E38 RID: 15928 RVA: 0x0013BB64 File Offset: 0x00139D64
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 146138, RefRangeEnd = 146141, XrefRangeStart = 146133, XrefRangeEnd = 146138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetSearchPoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_GetSearchPoint_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003E39 RID: 15929 RVA: 0x0013BBA0 File Offset: 0x00139DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146141, XrefRangeEnd = 146162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConcludeSearch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_ConcludeSearch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E3A RID: 15930 RVA: 0x0013BBD4 File Offset: 0x00139DD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 146215, RefRangeEnd = 146216, XrefRangeStart = 146162, XrefRangeEnd = 146215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesVehicleContainIllicitItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_DoesVehicleContainIllicitItems_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003E3B RID: 15931 RVA: 0x0013BC10 File Offset: 0x00139E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146216, XrefRangeEnd = 146271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerWalkedThroughCheckPoint(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_PlayerWalkedThroughCheckPoint_Private_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E3C RID: 15932 RVA: 0x0013BC54 File Offset: 0x00139E54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CheckpointBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E3D RID: 15933 RVA: 0x0013BC90 File Offset: 0x00139E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146271, XrefRangeEnd = 146310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E3E RID: 15934 RVA: 0x0013BCCC File Offset: 0x00139ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146310, XrefRangeEnd = 146311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E3F RID: 15935 RVA: 0x0013BD08 File Offset: 0x00139F08
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E40 RID: 15936 RVA: 0x0013BD44 File Offset: 0x00139F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146311, XrefRangeEnd = 146330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetCheckpoint_4087078542(CheckpointManager.ECheckpointLocation loc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref loc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetCheckpoint_4087078542_Private_Void_ECheckpointLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E41 RID: 15937 RVA: 0x0013BD84 File Offset: 0x00139F84
		[CallerCount(0)]
		public unsafe void RpcLogic___SetCheckpoint_4087078542(CheckpointManager.ECheckpointLocation loc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref loc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___SetCheckpoint_4087078542_Public_Void_ECheckpointLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E42 RID: 15938 RVA: 0x0013BDC4 File Offset: 0x00139FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146330, XrefRangeEnd = 146333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetCheckpoint_4087078542(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetCheckpoint_4087078542_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E43 RID: 15939 RVA: 0x0013BE14 File Offset: 0x0013A014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146333, XrefRangeEnd = 146352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetInitiator_3323014238(NetworkObject init)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(init);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetInitiator_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E44 RID: 15940 RVA: 0x0013BE58 File Offset: 0x0013A058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146352, XrefRangeEnd = 146357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetInitiator_3323014238(NetworkObject init)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(init);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___SetInitiator_3323014238_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E45 RID: 15941 RVA: 0x0013BE9C File Offset: 0x0013A09C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146357, XrefRangeEnd = 146364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetInitiator_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetInitiator_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E46 RID: 15942 RVA: 0x0013BEEC File Offset: 0x0013A0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146364, XrefRangeEnd = 146384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_StartSearch_3694055493(NetworkObject targetVehicle, NetworkObject initiator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetVehicle);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(initiator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Server_StartSearch_3694055493_Private_Void_NetworkObject_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E47 RID: 15943 RVA: 0x0013BF40 File Offset: 0x0013A140
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 146422, RefRangeEnd = 146425, XrefRangeStart = 146384, XrefRangeEnd = 146422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StartSearch_3694055493(NetworkObject targetVehicle, NetworkObject initiator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetVehicle);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(initiator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___StartSearch_3694055493_Public_Void_NetworkObject_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E48 RID: 15944 RVA: 0x0013BF94 File Offset: 0x0013A194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146425, XrefRangeEnd = 146430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_StartSearch_3694055493(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Server_StartSearch_3694055493_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E49 RID: 15945 RVA: 0x0013BFF8 File Offset: 0x0013A1F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146430, XrefRangeEnd = 146448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_StopSearch_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Server_StopSearch_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E4A RID: 15946 RVA: 0x0013C02C File Offset: 0x0013A22C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 146461, RefRangeEnd = 146463, XrefRangeStart = 146448, XrefRangeEnd = 146461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StopSearch_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___StopSearch_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E4B RID: 15947 RVA: 0x0013C060 File Offset: 0x0013A260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146463, XrefRangeEnd = 146466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_StopSearch_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Server_StopSearch_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E4C RID: 15948 RVA: 0x0013C0C4 File Offset: 0x0013A2C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146466, XrefRangeEnd = 146485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetIsSearching_1140765316(bool s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref s;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetIsSearching_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E4D RID: 15949 RVA: 0x0013C104 File Offset: 0x0013A304
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 146490, RefRangeEnd = 146492, XrefRangeStart = 146485, XrefRangeEnd = 146490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetIsSearching_1140765316(bool s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref s;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___SetIsSearching_1140765316_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E4E RID: 15950 RVA: 0x0013C144 File Offset: 0x0013A344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146492, XrefRangeEnd = 146495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetIsSearching_1140765316(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetIsSearching_1140765316_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E4F RID: 15951 RVA: 0x0013C194 File Offset: 0x0013A394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146495, XrefRangeEnd = 146513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ConcludeSearch_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_ConcludeSearch_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E50 RID: 15952 RVA: 0x0013C1C8 File Offset: 0x0013A3C8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 146573, RefRangeEnd = 146578, XrefRangeStart = 146513, XrefRangeEnd = 146573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ConcludeSearch_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___ConcludeSearch_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E51 RID: 15953 RVA: 0x0013C1FC File Offset: 0x0013A3FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146578, XrefRangeEnd = 146581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ConcludeSearch_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Observers_ConcludeSearch_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E52 RID: 15954 RVA: 0x0013C24C File Offset: 0x0013A44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E53 RID: 15955 RVA: 0x0001F447 File Offset: 0x0001D647
		public CheckpointBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001334 RID: 4916
		// (get) Token: 0x06003E54 RID: 15956 RVA: 0x0013C288 File Offset: 0x0013A488
		// (set) Token: 0x06003E55 RID: 15957 RVA: 0x0001F450 File Offset: 0x0001D650
		public unsafe static float LOOK_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CheckpointBehaviour.NativeFieldInfoPtr_LOOK_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CheckpointBehaviour.NativeFieldInfoPtr_LOOK_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001335 RID: 4917
		// (get) Token: 0x06003E56 RID: 15958 RVA: 0x0013C2A4 File Offset: 0x0013A4A4
		// (set) Token: 0x06003E57 RID: 15959 RVA: 0x0001F45E File Offset: 0x0001D65E
		public unsafe CheckpointManager.ECheckpointLocation _AssignedCheckpoint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__AssignedCheckpoint_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__AssignedCheckpoint_k__BackingField)) = value;
			}
		}

		// Token: 0x17001336 RID: 4918
		// (get) Token: 0x06003E58 RID: 15960 RVA: 0x0013C2CC File Offset: 0x0013A4CC
		// (set) Token: 0x06003E59 RID: 15961 RVA: 0x0001F479 File Offset: 0x0001D679
		public unsafe RoadCheckpoint _Checkpoint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__Checkpoint_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoadCheckpoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__Checkpoint_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001337 RID: 4919
		// (get) Token: 0x06003E5A RID: 15962 RVA: 0x0013C2FC File Offset: 0x0013A4FC
		// (set) Token: 0x06003E5B RID: 15963 RVA: 0x0001F498 File Offset: 0x0001D698
		public unsafe bool _IsSearching_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__IsSearching_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__IsSearching_k__BackingField)) = value;
			}
		}

		// Token: 0x17001338 RID: 4920
		// (get) Token: 0x06003E5C RID: 15964 RVA: 0x0013C324 File Offset: 0x0013A524
		// (set) Token: 0x06003E5D RID: 15965 RVA: 0x0001F4B3 File Offset: 0x0001D6B3
		public unsafe LandVehicle _CurrentSearchedVehicle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__CurrentSearchedVehicle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__CurrentSearchedVehicle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001339 RID: 4921
		// (get) Token: 0x06003E5E RID: 15966 RVA: 0x0013C354 File Offset: 0x0013A554
		// (set) Token: 0x06003E5F RID: 15967 RVA: 0x0001F4D2 File Offset: 0x0001D6D2
		public unsafe Player _Initiator_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__Initiator_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__Initiator_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700133A RID: 4922
		// (get) Token: 0x06003E60 RID: 15968 RVA: 0x0013C384 File Offset: 0x0013A584
		// (set) Token: 0x06003E61 RID: 15969 RVA: 0x0001F4F1 File Offset: 0x0001D6F1
		public unsafe float currentLookTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr_currentLookTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr_currentLookTime)) = value;
			}
		}

		// Token: 0x1700133B RID: 4923
		// (get) Token: 0x06003E62 RID: 15970 RVA: 0x0013C3AC File Offset: 0x0013A5AC
		// (set) Token: 0x06003E63 RID: 15971 RVA: 0x0001F50C File Offset: 0x0001D70C
		public unsafe bool trunkOpened
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr_trunkOpened);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr_trunkOpened)) = value;
			}
		}

		// Token: 0x1700133C RID: 4924
		// (get) Token: 0x06003E64 RID: 15972 RVA: 0x0013C3D4 File Offset: 0x0013A5D4
		// (set) Token: 0x06003E65 RID: 15973 RVA: 0x0001F527 File Offset: 0x0001D727
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700133D RID: 4925
		// (get) Token: 0x06003E66 RID: 15974 RVA: 0x0013C3FC File Offset: 0x0013A5FC
		// (set) Token: 0x06003E67 RID: 15975 RVA: 0x0001F542 File Offset: 0x0001D742
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002913 RID: 10515
		private static readonly IntPtr NativeFieldInfoPtr_LOOK_TIME;

		// Token: 0x04002914 RID: 10516
		private static readonly IntPtr NativeFieldInfoPtr__AssignedCheckpoint_k__BackingField;

		// Token: 0x04002915 RID: 10517
		private static readonly IntPtr NativeFieldInfoPtr__Checkpoint_k__BackingField;

		// Token: 0x04002916 RID: 10518
		private static readonly IntPtr NativeFieldInfoPtr__IsSearching_k__BackingField;

		// Token: 0x04002917 RID: 10519
		private static readonly IntPtr NativeFieldInfoPtr__CurrentSearchedVehicle_k__BackingField;

		// Token: 0x04002918 RID: 10520
		private static readonly IntPtr NativeFieldInfoPtr__Initiator_k__BackingField;

		// Token: 0x04002919 RID: 10521
		private static readonly IntPtr NativeFieldInfoPtr_currentLookTime;

		// Token: 0x0400291A RID: 10522
		private static readonly IntPtr NativeFieldInfoPtr_trunkOpened;

		// Token: 0x0400291B RID: 10523
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400291C RID: 10524
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400291D RID: 10525
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedCheckpoint_Public_get_ECheckpointLocation_0;

		// Token: 0x0400291E RID: 10526
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedCheckpoint_Protected_set_Void_ECheckpointLocation_0;

		// Token: 0x0400291F RID: 10527
		private static readonly IntPtr NativeMethodInfoPtr_get_Checkpoint_Public_get_RoadCheckpoint_0;

		// Token: 0x04002920 RID: 10528
		private static readonly IntPtr NativeMethodInfoPtr_set_Checkpoint_Protected_set_Void_RoadCheckpoint_0;

		// Token: 0x04002921 RID: 10529
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSearching_Public_get_Boolean_0;

		// Token: 0x04002922 RID: 10530
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSearching_Protected_set_Void_Boolean_0;

		// Token: 0x04002923 RID: 10531
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSearchedVehicle_Public_get_LandVehicle_0;

		// Token: 0x04002924 RID: 10532
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentSearchedVehicle_Protected_set_Void_LandVehicle_0;

		// Token: 0x04002925 RID: 10533
		private static readonly IntPtr NativeMethodInfoPtr_get_Initiator_Public_get_Player_0;

		// Token: 0x04002926 RID: 10534
		private static readonly IntPtr NativeMethodInfoPtr_set_Initiator_Protected_set_Void_Player_0;

		// Token: 0x04002927 RID: 10535
		private static readonly IntPtr NativeMethodInfoPtr_get_standPoint_Private_get_Transform_0;

		// Token: 0x04002928 RID: 10536
		private static readonly IntPtr NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0;

		// Token: 0x04002929 RID: 10537
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0;

		// Token: 0x0400292A RID: 10538
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0;

		// Token: 0x0400292B RID: 10539
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_0;

		// Token: 0x0400292C RID: 10540
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0;

		// Token: 0x0400292D RID: 10541
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x0400292E RID: 10542
		private static readonly IntPtr NativeMethodInfoPtr_SetCheckpoint_Public_Void_ECheckpointLocation_0;

		// Token: 0x0400292F RID: 10543
		private static readonly IntPtr NativeMethodInfoPtr_SetInitiator_Public_Void_NetworkObject_0;

		// Token: 0x04002930 RID: 10544
		private static readonly IntPtr NativeMethodInfoPtr_StartSearch_Public_Void_NetworkObject_NetworkObject_0;

		// Token: 0x04002931 RID: 10545
		private static readonly IntPtr NativeMethodInfoPtr_StopSearch_Public_Void_0;

		// Token: 0x04002932 RID: 10546
		private static readonly IntPtr NativeMethodInfoPtr_SetIsSearching_Public_Void_Boolean_0;

		// Token: 0x04002933 RID: 10547
		private static readonly IntPtr NativeMethodInfoPtr_GetSearchPoint_Private_Vector3_0;

		// Token: 0x04002934 RID: 10548
		private static readonly IntPtr NativeMethodInfoPtr_ConcludeSearch_Private_Void_0;

		// Token: 0x04002935 RID: 10549
		private static readonly IntPtr NativeMethodInfoPtr_DoesVehicleContainIllicitItems_Private_Boolean_0;

		// Token: 0x04002936 RID: 10550
		private static readonly IntPtr NativeMethodInfoPtr_PlayerWalkedThroughCheckPoint_Private_Void_Player_0;

		// Token: 0x04002937 RID: 10551
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002938 RID: 10552
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002939 RID: 10553
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400293A RID: 10554
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400293B RID: 10555
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetCheckpoint_4087078542_Private_Void_ECheckpointLocation_0;

		// Token: 0x0400293C RID: 10556
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetCheckpoint_4087078542_Public_Void_ECheckpointLocation_0;

		// Token: 0x0400293D RID: 10557
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetCheckpoint_4087078542_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400293E RID: 10558
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetInitiator_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x0400293F RID: 10559
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetInitiator_3323014238_Public_Void_NetworkObject_0;

		// Token: 0x04002940 RID: 10560
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetInitiator_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002941 RID: 10561
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_StartSearch_3694055493_Private_Void_NetworkObject_NetworkObject_0;

		// Token: 0x04002942 RID: 10562
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StartSearch_3694055493_Public_Void_NetworkObject_NetworkObject_0;

		// Token: 0x04002943 RID: 10563
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_StartSearch_3694055493_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002944 RID: 10564
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_StopSearch_2166136261_Private_Void_0;

		// Token: 0x04002945 RID: 10565
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StopSearch_2166136261_Public_Void_0;

		// Token: 0x04002946 RID: 10566
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_StopSearch_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002947 RID: 10567
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetIsSearching_1140765316_Private_Void_Boolean_0;

		// Token: 0x04002948 RID: 10568
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetIsSearching_1140765316_Public_Void_Boolean_0;

		// Token: 0x04002949 RID: 10569
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetIsSearching_1140765316_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400294A RID: 10570
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ConcludeSearch_2166136261_Private_Void_0;

		// Token: 0x0400294B RID: 10571
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ConcludeSearch_2166136261_Private_Void_0;

		// Token: 0x0400294C RID: 10572
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ConcludeSearch_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400294D RID: 10573
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0200093F RID: 2367
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.CheckpointBehaviour+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C771 RID: 51057 RVA: 0x003062A4 File Offset: 0x003044A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CheckpointBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckpointBehaviour.__c>.NativeClassPtr);
				CheckpointBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour.__c>.NativeClassPtr, "<>9");
				CheckpointBehaviour.__c.NativeFieldInfoPtr___9__39_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour.__c>.NativeClassPtr, "<>9__39_0");
				CheckpointBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour.__c>.NativeClassPtr, 100670615);
				CheckpointBehaviour.__c.NativeMethodInfoPtr__DoesVehicleContainIllicitItems_b__39_0_Internal_ItemInstance_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour.__c>.NativeClassPtr, 100670616);
			}

			// Token: 0x0600C772 RID: 51058 RVA: 0x00306320 File Offset: 0x00304520
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CheckpointBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C773 RID: 51059 RVA: 0x0030635C File Offset: 0x0030455C
			[CallerCount(0)]
			public unsafe ItemInstance _DoesVehicleContainIllicitItems_b__39_0(ItemSlot x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.__c.NativeMethodInfoPtr__DoesVehicleContainIllicitItems_b__39_0_Internal_ItemInstance_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
			}

			// Token: 0x0600C774 RID: 51060 RVA: 0x000610D6 File Offset: 0x0005F2D6
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E25 RID: 15909
			// (get) Token: 0x0600C775 RID: 51061 RVA: 0x003063AC File Offset: 0x003045AC
			// (set) Token: 0x0600C776 RID: 51062 RVA: 0x000610DF File Offset: 0x0005F2DF
			public unsafe static CheckpointBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CheckpointBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CheckpointBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CheckpointBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E26 RID: 15910
			// (get) Token: 0x0600C777 RID: 51063 RVA: 0x003063D4 File Offset: 0x003045D4
			// (set) Token: 0x0600C778 RID: 51064 RVA: 0x000610F1 File Offset: 0x0005F2F1
			public unsafe static Func<ItemSlot, ItemInstance> __9__39_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CheckpointBehaviour.__c.NativeFieldInfoPtr___9__39_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ItemSlot, ItemInstance>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CheckpointBehaviour.__c.NativeFieldInfoPtr___9__39_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040086FD RID: 34557
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040086FE RID: 34558
			private static readonly IntPtr NativeFieldInfoPtr___9__39_0;

			// Token: 0x040086FF RID: 34559
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008700 RID: 34560
			private static readonly IntPtr NativeMethodInfoPtr__DoesVehicleContainIllicitItems_b__39_0_Internal_ItemInstance_ItemSlot_0;
		}
	}
}
