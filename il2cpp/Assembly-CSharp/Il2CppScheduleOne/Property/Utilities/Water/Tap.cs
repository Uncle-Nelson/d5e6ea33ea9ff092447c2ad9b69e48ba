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
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.Property.Utilities.Water
{
	// Token: 0x02000516 RID: 1302
	public class Tap : NetworkBehaviour
	{
		// Token: 0x060073A1 RID: 29601 RVA: 0x001F8AB0 File Offset: 0x001F6CB0
		// Note: this type is marked as 'beforefieldinit'.
		static Tap()
		{
			Il2CppClassPointerStore<Tap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property.Utilities.Water", "Tap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tap>.NativeClassPtr);
			Tap.NativeFieldInfoPtr_MaxFlowRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "MaxFlowRate");
			Tap.NativeFieldInfoPtr__IsHeldOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "<IsHeldOpen>k__BackingField");
			Tap.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "IntObj");
			Tap.NativeFieldInfoPtr_CameraPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "CameraPos");
			Tap.NativeFieldInfoPtr_WateringCamPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "WateringCamPos");
			Tap.NativeFieldInfoPtr_HandleCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "HandleCollider");
			Tap.NativeFieldInfoPtr_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "Handle");
			Tap.NativeFieldInfoPtr_HandleClickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "HandleClickable");
			Tap.NativeFieldInfoPtr_WaterParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "WaterParticles");
			Tap.NativeFieldInfoPtr_SqueakSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "SqueakSound");
			Tap.NativeFieldInfoPtr_WaterRunningSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "WaterRunningSound");
			Tap.NativeFieldInfoPtr__NPCUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "<NPCUserObject>k__BackingField");
			Tap.NativeFieldInfoPtr__PlayerUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "<PlayerUserObject>k__BackingField");
			Tap.NativeFieldInfoPtr_tapFlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "tapFlow");
			Tap.NativeFieldInfoPtr_wateringCanModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "wateringCanModel");
			Tap.NativeFieldInfoPtr_intObjSetThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "intObjSetThisFrame");
			Tap.NativeFieldInfoPtr_syncVar____IsHeldOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "syncVar___<IsHeldOpen>k__BackingField");
			Tap.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "syncVar___<NPCUserObject>k__BackingField");
			Tap.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "syncVar___<PlayerUserObject>k__BackingField");
			Tap.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Property.Utilities.Water.TapAssembly-CSharp.dll_Excuted");
			Tap.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tap>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Property.Utilities.Water.TapAssembly-CSharp.dll_Excuted");
			Tap.NativeMethodInfoPtr_get_IsHeldOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677832);
			Tap.NativeMethodInfoPtr_set_IsHeldOpen_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677833);
			Tap.NativeMethodInfoPtr_get_ActualFlowRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677834);
			Tap.NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677835);
			Tap.NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677836);
			Tap.NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677837);
			Tap.NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677838);
			Tap.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677839);
			Tap.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677840);
			Tap.NativeMethodInfoPtr_SetInteractableObject_Public_Void_String_EInteractableState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677841);
			Tap.NativeMethodInfoPtr_UpdateTapVisuals_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677842);
			Tap.NativeMethodInfoPtr_UpdateWaterSound_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677843);
			Tap.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677844);
			Tap.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677845);
			Tap.NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677846);
			Tap.NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677847);
			Tap.NativeMethodInfoPtr_SetHeldOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677848);
			Tap.NativeMethodInfoPtr_CanInteract_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677849);
			Tap.NativeMethodInfoPtr_SendWateringCanModel_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677850);
			Tap.NativeMethodInfoPtr_CreateWateringCanModel_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677851);
			Tap.NativeMethodInfoPtr_SendClearWateringCanModelModel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677852);
			Tap.NativeMethodInfoPtr_ClearWateringCanModel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677853);
			Tap.NativeMethodInfoPtr_CreateWateringCanModel_Local_Public_GameObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677854);
			Tap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677855);
			Tap.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677856);
			Tap.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677857);
			Tap.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677858);
			Tap.NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677859);
			Tap.NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677860);
			Tap.NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677861);
			Tap.NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677862);
			Tap.NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677863);
			Tap.NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677864);
			Tap.NativeMethodInfoPtr_RpcWriter___Server_SetHeldOpen_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677865);
			Tap.NativeMethodInfoPtr_RpcLogic___SetHeldOpen_1140765316_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677866);
			Tap.NativeMethodInfoPtr_RpcReader___Server_SetHeldOpen_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677867);
			Tap.NativeMethodInfoPtr_RpcWriter___Server_SendWateringCanModel_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677868);
			Tap.NativeMethodInfoPtr_RpcLogic___SendWateringCanModel_3615296227_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677869);
			Tap.NativeMethodInfoPtr_RpcReader___Server_SendWateringCanModel_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677870);
			Tap.NativeMethodInfoPtr_RpcWriter___Observers_CreateWateringCanModel_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677871);
			Tap.NativeMethodInfoPtr_RpcLogic___CreateWateringCanModel_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677872);
			Tap.NativeMethodInfoPtr_RpcReader___Observers_CreateWateringCanModel_3615296227_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677873);
			Tap.NativeMethodInfoPtr_RpcWriter___Server_SendClearWateringCanModelModel_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677874);
			Tap.NativeMethodInfoPtr_RpcLogic___SendClearWateringCanModelModel_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677875);
			Tap.NativeMethodInfoPtr_RpcReader___Server_SendClearWateringCanModelModel_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677876);
			Tap.NativeMethodInfoPtr_RpcWriter___Observers_ClearWateringCanModel_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677877);
			Tap.NativeMethodInfoPtr_RpcLogic___ClearWateringCanModel_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677878);
			Tap.NativeMethodInfoPtr_RpcReader___Observers_ClearWateringCanModel_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677879);
			Tap.NativeMethodInfoPtr_sync___get_value__IsHeldOpen_k__BackingField_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677880);
			Tap.NativeMethodInfoPtr_sync___set_value__IsHeldOpen_k__BackingField_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677881);
			Tap.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Property_Utilities_Water_Tap_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677882);
			Tap.NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677883);
			Tap.NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677884);
			Tap.NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677885);
			Tap.NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677886);
			Tap.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tap>.NativeClassPtr, 100677887);
		}

		// Token: 0x17002325 RID: 8997
		// (get) Token: 0x060073A2 RID: 29602 RVA: 0x001F90E4 File Offset: 0x001F72E4
		// (set) Token: 0x060073A3 RID: 29603 RVA: 0x001F9120 File Offset: 0x001F7320
		public unsafe bool IsHeldOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_get_IsHeldOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226305, XrefRangeEnd = 226312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_set_IsHeldOpen_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002326 RID: 8998
		// (get) Token: 0x060073A4 RID: 29604 RVA: 0x001F9160 File Offset: 0x001F7360
		public unsafe float ActualFlowRate
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 226312, RefRangeEnd = 226315, XrefRangeStart = 226312, XrefRangeEnd = 226312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_get_ActualFlowRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002327 RID: 8999
		// (get) Token: 0x060073A5 RID: 29605 RVA: 0x001F919C File Offset: 0x001F739C
		// (set) Token: 0x060073A6 RID: 29606 RVA: 0x001F91DC File Offset: 0x001F73DC
		public unsafe virtual NetworkObject NPCUserObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 226323, RefRangeEnd = 226325, XrefRangeStart = 226315, XrefRangeEnd = 226323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002328 RID: 9000
		// (get) Token: 0x060073A7 RID: 29607 RVA: 0x001F9220 File Offset: 0x001F7420
		// (set) Token: 0x060073A8 RID: 29608 RVA: 0x001F9260 File Offset: 0x001F7460
		public unsafe virtual NetworkObject PlayerUserObject
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 86730, RefRangeEnd = 86731, XrefRangeStart = 86730, XrefRangeEnd = 86731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226325, XrefRangeEnd = 226333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060073A9 RID: 29609 RVA: 0x001F92A4 File Offset: 0x001F74A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226333, XrefRangeEnd = 226347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tap.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073AA RID: 29610 RVA: 0x001F92E0 File Offset: 0x001F74E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226347, XrefRangeEnd = 226365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tap.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073AB RID: 29611 RVA: 0x001F931C File Offset: 0x001F751C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226365, XrefRangeEnd = 226366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractableObject(string message, InteractableObject.EInteractableState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_SetInteractableObject_Public_Void_String_EInteractableState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073AC RID: 29612 RVA: 0x001F936C File Offset: 0x001F756C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226366, XrefRangeEnd = 226370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTapVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_UpdateTapVisuals_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073AD RID: 29613 RVA: 0x001F93A0 File Offset: 0x001F75A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226370, XrefRangeEnd = 226372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateWaterSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_UpdateWaterSound_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073AE RID: 29614 RVA: 0x001F93D4 File Offset: 0x001F75D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226372, XrefRangeEnd = 226373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073AF RID: 29615 RVA: 0x001F9408 File Offset: 0x001F7608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226373, XrefRangeEnd = 226387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073B0 RID: 29616 RVA: 0x001F943C File Offset: 0x001F763C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 226409, RefRangeEnd = 226411, XrefRangeStart = 226387, XrefRangeEnd = 226409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetPlayerUser(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073B1 RID: 29617 RVA: 0x001F9480 File Offset: 0x001F7680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226411, XrefRangeEnd = 226433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetNPCUser(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073B2 RID: 29618 RVA: 0x001F94C4 File Offset: 0x001F76C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 226455, RefRangeEnd = 226458, XrefRangeStart = 226433, XrefRangeEnd = 226455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHeldOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_SetHeldOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073B3 RID: 29619 RVA: 0x001F9504 File Offset: 0x001F7704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226458, XrefRangeEnd = 226468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tap.NativeMethodInfoPtr_CanInteract_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060073B4 RID: 29620 RVA: 0x001F954C File Offset: 0x001F774C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 226490, RefRangeEnd = 226491, XrefRangeStart = 226468, XrefRangeEnd = 226490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendWateringCanModel(string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_SendWateringCanModel_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073B5 RID: 29621 RVA: 0x001F9590 File Offset: 0x001F7790
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 226514, RefRangeEnd = 226516, XrefRangeStart = 226491, XrefRangeEnd = 226514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateWateringCanModel(string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_CreateWateringCanModel_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073B6 RID: 29622 RVA: 0x001F95D4 File Offset: 0x001F77D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 226537, RefRangeEnd = 226538, XrefRangeStart = 226516, XrefRangeEnd = 226537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendClearWateringCanModelModel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_SendClearWateringCanModelModel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073B7 RID: 29623 RVA: 0x001F9608 File Offset: 0x001F7808
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 226559, RefRangeEnd = 226561, XrefRangeStart = 226538, XrefRangeEnd = 226559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearWateringCanModel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_ClearWateringCanModel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073B8 RID: 29624 RVA: 0x001F963C File Offset: 0x001F783C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 226606, RefRangeEnd = 226611, XrefRangeStart = 226561, XrefRangeEnd = 226606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject CreateWateringCanModel_Local(string ID, bool force = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_CreateWateringCanModel_Local_Public_GameObject_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x060073B9 RID: 29625 RVA: 0x001F969C File Offset: 0x001F789C
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 134906, RefRangeEnd = 134928, XrefRangeStart = 134906, XrefRangeEnd = 134928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tap() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073BA RID: 29626 RVA: 0x001F96D8 File Offset: 0x001F78D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226611, XrefRangeEnd = 226687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tap.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073BB RID: 29627 RVA: 0x001F9714 File Offset: 0x001F7914
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tap.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073BC RID: 29628 RVA: 0x001F9750 File Offset: 0x001F7950
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tap.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073BD RID: 29629 RVA: 0x001F978C File Offset: 0x001F798C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226687, XrefRangeEnd = 226706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073BE RID: 29630 RVA: 0x001F97D0 File Offset: 0x001F79D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 226730, RefRangeEnd = 226732, XrefRangeStart = 226706, XrefRangeEnd = 226730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073BF RID: 29631 RVA: 0x001F9814 File Offset: 0x001F7A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226732, XrefRangeEnd = 226736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073C0 RID: 29632 RVA: 0x001F9878 File Offset: 0x001F7A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226736, XrefRangeEnd = 226755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073C1 RID: 29633 RVA: 0x001F98BC File Offset: 0x001F7ABC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 226323, RefRangeEnd = 226325, XrefRangeStart = 226323, XrefRangeEnd = 226325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073C2 RID: 29634 RVA: 0x001F9900 File Offset: 0x001F7B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226755, XrefRangeEnd = 226759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073C3 RID: 29635 RVA: 0x001F9964 File Offset: 0x001F7B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226759, XrefRangeEnd = 226778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetHeldOpen_1140765316(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcWriter___Server_SetHeldOpen_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073C4 RID: 29636 RVA: 0x001F99A4 File Offset: 0x001F7BA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 226785, RefRangeEnd = 226787, XrefRangeStart = 226778, XrefRangeEnd = 226785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetHeldOpen_1140765316(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcLogic___SetHeldOpen_1140765316_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073C5 RID: 29637 RVA: 0x001F99E4 File Offset: 0x001F7BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226787, XrefRangeEnd = 226790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetHeldOpen_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcReader___Server_SetHeldOpen_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073C6 RID: 29638 RVA: 0x001F9A48 File Offset: 0x001F7C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226790, XrefRangeEnd = 226809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendWateringCanModel_3615296227(string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcWriter___Server_SendWateringCanModel_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073C7 RID: 29639 RVA: 0x001F9A8C File Offset: 0x001F7C8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 226514, RefRangeEnd = 226516, XrefRangeStart = 226514, XrefRangeEnd = 226516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendWateringCanModel_3615296227(string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcLogic___SendWateringCanModel_3615296227_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073C8 RID: 29640 RVA: 0x001F9AD0 File Offset: 0x001F7CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226809, XrefRangeEnd = 226813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendWateringCanModel_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcReader___Server_SendWateringCanModel_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073C9 RID: 29641 RVA: 0x001F9B34 File Offset: 0x001F7D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226813, XrefRangeEnd = 226832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_CreateWateringCanModel_3615296227(string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcWriter___Observers_CreateWateringCanModel_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073CA RID: 29642 RVA: 0x001F9B78 File Offset: 0x001F7D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226832, XrefRangeEnd = 226834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___CreateWateringCanModel_3615296227(string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcLogic___CreateWateringCanModel_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073CB RID: 29643 RVA: 0x001F9BBC File Offset: 0x001F7DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226834, XrefRangeEnd = 226839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_CreateWateringCanModel_3615296227(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcReader___Observers_CreateWateringCanModel_3615296227_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073CC RID: 29644 RVA: 0x001F9C0C File Offset: 0x001F7E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226839, XrefRangeEnd = 226857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendClearWateringCanModelModel_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcWriter___Server_SendClearWateringCanModelModel_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073CD RID: 29645 RVA: 0x001F9C40 File Offset: 0x001F7E40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 226559, RefRangeEnd = 226561, XrefRangeStart = 226559, XrefRangeEnd = 226561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendClearWateringCanModelModel_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcLogic___SendClearWateringCanModelModel_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073CE RID: 29646 RVA: 0x001F9C74 File Offset: 0x001F7E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226857, XrefRangeEnd = 226860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendClearWateringCanModelModel_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcReader___Server_SendClearWateringCanModelModel_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073CF RID: 29647 RVA: 0x001F9CD8 File Offset: 0x001F7ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226860, XrefRangeEnd = 226878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ClearWateringCanModel_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcWriter___Observers_ClearWateringCanModel_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073D0 RID: 29648 RVA: 0x001F9D0C File Offset: 0x001F7F0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 226886, RefRangeEnd = 226889, XrefRangeStart = 226878, XrefRangeEnd = 226886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ClearWateringCanModel_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcLogic___ClearWateringCanModel_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073D1 RID: 29649 RVA: 0x001F9D40 File Offset: 0x001F7F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226889, XrefRangeEnd = 226892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ClearWateringCanModel_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_RpcReader___Observers_ClearWateringCanModel_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002329 RID: 9001
		// (get) Token: 0x060073D2 RID: 29650 RVA: 0x001F9D90 File Offset: 0x001F7F90
		// (set) Token: 0x060073D3 RID: 29651 RVA: 0x001F9DCC File Offset: 0x001F7FCC
		public unsafe bool SyncAccessor_<IsHeldOpen>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_sync___get_value__IsHeldOpen_k__BackingField_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 226900, RefRangeEnd = 226902, XrefRangeStart = 226892, XrefRangeEnd = 226900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_sync___set_value__IsHeldOpen_k__BackingField_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060073D4 RID: 29652 RVA: 0x001F9E18 File Offset: 0x001F8018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226902, XrefRangeEnd = 226921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Property_Utilities_Water_Tap(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tap.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Property_Utilities_Water_Tap_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700232A RID: 9002
		// (get) Token: 0x060073D5 RID: 29653 RVA: 0x001F9E8C File Offset: 0x001F808C
		// (set) Token: 0x060073D6 RID: 29654 RVA: 0x001F9ECC File Offset: 0x001F80CC
		public unsafe NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 226930, RefRangeEnd = 226932, XrefRangeStart = 226921, XrefRangeEnd = 226930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700232B RID: 9003
		// (get) Token: 0x060073D7 RID: 29655 RVA: 0x001F9F1C File Offset: 0x001F811C
		// (set) Token: 0x060073D8 RID: 29656 RVA: 0x001F9F5C File Offset: 0x001F815C
		public unsafe NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 86730, RefRangeEnd = 86731, XrefRangeStart = 86730, XrefRangeEnd = 86731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 226941, RefRangeEnd = 226942, XrefRangeStart = 226932, XrefRangeEnd = 226941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060073D9 RID: 29657 RVA: 0x001F9FAC File Offset: 0x001F81AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226942, XrefRangeEnd = 226956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tap.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073DA RID: 29658 RVA: 0x00036F82 File Offset: 0x00035182
		public Tap(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002310 RID: 8976
		// (get) Token: 0x060073DB RID: 29659 RVA: 0x001F9FE0 File Offset: 0x001F81E0
		// (set) Token: 0x060073DC RID: 29660 RVA: 0x00036F8B File Offset: 0x0003518B
		public unsafe static float MaxFlowRate
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Tap.NativeFieldInfoPtr_MaxFlowRate, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Tap.NativeFieldInfoPtr_MaxFlowRate, (void*)(&value));
			}
		}

		// Token: 0x17002311 RID: 8977
		// (get) Token: 0x060073DD RID: 29661 RVA: 0x001F9FFC File Offset: 0x001F81FC
		// (set) Token: 0x060073DE RID: 29662 RVA: 0x00036F99 File Offset: 0x00035199
		public unsafe bool _IsHeldOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__IsHeldOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__IsHeldOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002312 RID: 8978
		// (get) Token: 0x060073DF RID: 29663 RVA: 0x001FA024 File Offset: 0x001F8224
		// (set) Token: 0x060073E0 RID: 29664 RVA: 0x00036FB4 File Offset: 0x000351B4
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002313 RID: 8979
		// (get) Token: 0x060073E1 RID: 29665 RVA: 0x001FA054 File Offset: 0x001F8254
		// (set) Token: 0x060073E2 RID: 29666 RVA: 0x00036FD3 File Offset: 0x000351D3
		public unsafe Transform CameraPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_CameraPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_CameraPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002314 RID: 8980
		// (get) Token: 0x060073E3 RID: 29667 RVA: 0x001FA084 File Offset: 0x001F8284
		// (set) Token: 0x060073E4 RID: 29668 RVA: 0x00036FF2 File Offset: 0x000351F2
		public unsafe Transform WateringCamPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_WateringCamPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_WateringCamPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002315 RID: 8981
		// (get) Token: 0x060073E5 RID: 29669 RVA: 0x001FA0B4 File Offset: 0x001F82B4
		// (set) Token: 0x060073E6 RID: 29670 RVA: 0x00037011 File Offset: 0x00035211
		public unsafe Collider HandleCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_HandleCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_HandleCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002316 RID: 8982
		// (get) Token: 0x060073E7 RID: 29671 RVA: 0x001FA0E4 File Offset: 0x001F82E4
		// (set) Token: 0x060073E8 RID: 29672 RVA: 0x00037030 File Offset: 0x00035230
		public unsafe Transform Handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_Handle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_Handle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002317 RID: 8983
		// (get) Token: 0x060073E9 RID: 29673 RVA: 0x001FA114 File Offset: 0x001F8314
		// (set) Token: 0x060073EA RID: 29674 RVA: 0x0003704F File Offset: 0x0003524F
		public unsafe Clickable HandleClickable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_HandleClickable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_HandleClickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002318 RID: 8984
		// (get) Token: 0x060073EB RID: 29675 RVA: 0x001FA144 File Offset: 0x001F8344
		// (set) Token: 0x060073EC RID: 29676 RVA: 0x0003706E File Offset: 0x0003526E
		public unsafe ParticleSystem WaterParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_WaterParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_WaterParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002319 RID: 8985
		// (get) Token: 0x060073ED RID: 29677 RVA: 0x001FA174 File Offset: 0x001F8374
		// (set) Token: 0x060073EE RID: 29678 RVA: 0x0003708D File Offset: 0x0003528D
		public unsafe AudioSourceController SqueakSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_SqueakSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_SqueakSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700231A RID: 8986
		// (get) Token: 0x060073EF RID: 29679 RVA: 0x001FA1A4 File Offset: 0x001F83A4
		// (set) Token: 0x060073F0 RID: 29680 RVA: 0x000370AC File Offset: 0x000352AC
		public unsafe AudioSourceController WaterRunningSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_WaterRunningSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_WaterRunningSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700231B RID: 8987
		// (get) Token: 0x060073F1 RID: 29681 RVA: 0x001FA1D4 File Offset: 0x001F83D4
		// (set) Token: 0x060073F2 RID: 29682 RVA: 0x000370CB File Offset: 0x000352CB
		public unsafe NetworkObject _NPCUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__NPCUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__NPCUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700231C RID: 8988
		// (get) Token: 0x060073F3 RID: 29683 RVA: 0x001FA204 File Offset: 0x001F8404
		// (set) Token: 0x060073F4 RID: 29684 RVA: 0x000370EA File Offset: 0x000352EA
		public unsafe NetworkObject _PlayerUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__PlayerUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr__PlayerUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700231D RID: 8989
		// (get) Token: 0x060073F5 RID: 29685 RVA: 0x001FA234 File Offset: 0x001F8434
		// (set) Token: 0x060073F6 RID: 29686 RVA: 0x00037109 File Offset: 0x00035309
		public unsafe float tapFlow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_tapFlow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_tapFlow)) = value;
			}
		}

		// Token: 0x1700231E RID: 8990
		// (get) Token: 0x060073F7 RID: 29687 RVA: 0x001FA25C File Offset: 0x001F845C
		// (set) Token: 0x060073F8 RID: 29688 RVA: 0x00037124 File Offset: 0x00035324
		public unsafe GameObject wateringCanModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_wateringCanModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_wateringCanModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700231F RID: 8991
		// (get) Token: 0x060073F9 RID: 29689 RVA: 0x001FA28C File Offset: 0x001F848C
		// (set) Token: 0x060073FA RID: 29690 RVA: 0x00037143 File Offset: 0x00035343
		public unsafe bool intObjSetThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_intObjSetThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_intObjSetThisFrame)) = value;
			}
		}

		// Token: 0x17002320 RID: 8992
		// (get) Token: 0x060073FB RID: 29691 RVA: 0x001FA2B4 File Offset: 0x001F84B4
		// (set) Token: 0x060073FC RID: 29692 RVA: 0x0003715E File Offset: 0x0003535E
		public unsafe SyncVar<bool> syncVar____IsHeldOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_syncVar____IsHeldOpen_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_syncVar____IsHeldOpen_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002321 RID: 8993
		// (get) Token: 0x060073FD RID: 29693 RVA: 0x001FA2E4 File Offset: 0x001F84E4
		// (set) Token: 0x060073FE RID: 29694 RVA: 0x0003717D File Offset: 0x0003537D
		public unsafe SyncVar<NetworkObject> syncVar____NPCUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002322 RID: 8994
		// (get) Token: 0x060073FF RID: 29695 RVA: 0x001FA314 File Offset: 0x001F8514
		// (set) Token: 0x06007400 RID: 29696 RVA: 0x0003719C File Offset: 0x0003539C
		public unsafe SyncVar<NetworkObject> syncVar____PlayerUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002323 RID: 8995
		// (get) Token: 0x06007401 RID: 29697 RVA: 0x001FA344 File Offset: 0x001F8544
		// (set) Token: 0x06007402 RID: 29698 RVA: 0x000371BB File Offset: 0x000353BB
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002324 RID: 8996
		// (get) Token: 0x06007403 RID: 29699 RVA: 0x001FA36C File Offset: 0x001F856C
		// (set) Token: 0x06007404 RID: 29700 RVA: 0x000371D6 File Offset: 0x000353D6
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tap.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004EEE RID: 20206
		private static readonly IntPtr NativeFieldInfoPtr_MaxFlowRate;

		// Token: 0x04004EEF RID: 20207
		private static readonly IntPtr NativeFieldInfoPtr__IsHeldOpen_k__BackingField;

		// Token: 0x04004EF0 RID: 20208
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04004EF1 RID: 20209
		private static readonly IntPtr NativeFieldInfoPtr_CameraPos;

		// Token: 0x04004EF2 RID: 20210
		private static readonly IntPtr NativeFieldInfoPtr_WateringCamPos;

		// Token: 0x04004EF3 RID: 20211
		private static readonly IntPtr NativeFieldInfoPtr_HandleCollider;

		// Token: 0x04004EF4 RID: 20212
		private static readonly IntPtr NativeFieldInfoPtr_Handle;

		// Token: 0x04004EF5 RID: 20213
		private static readonly IntPtr NativeFieldInfoPtr_HandleClickable;

		// Token: 0x04004EF6 RID: 20214
		private static readonly IntPtr NativeFieldInfoPtr_WaterParticles;

		// Token: 0x04004EF7 RID: 20215
		private static readonly IntPtr NativeFieldInfoPtr_SqueakSound;

		// Token: 0x04004EF8 RID: 20216
		private static readonly IntPtr NativeFieldInfoPtr_WaterRunningSound;

		// Token: 0x04004EF9 RID: 20217
		private static readonly IntPtr NativeFieldInfoPtr__NPCUserObject_k__BackingField;

		// Token: 0x04004EFA RID: 20218
		private static readonly IntPtr NativeFieldInfoPtr__PlayerUserObject_k__BackingField;

		// Token: 0x04004EFB RID: 20219
		private static readonly IntPtr NativeFieldInfoPtr_tapFlow;

		// Token: 0x04004EFC RID: 20220
		private static readonly IntPtr NativeFieldInfoPtr_wateringCanModel;

		// Token: 0x04004EFD RID: 20221
		private static readonly IntPtr NativeFieldInfoPtr_intObjSetThisFrame;

		// Token: 0x04004EFE RID: 20222
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____IsHeldOpen_k__BackingField;

		// Token: 0x04004EFF RID: 20223
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField;

		// Token: 0x04004F00 RID: 20224
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField;

		// Token: 0x04004F01 RID: 20225
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004F02 RID: 20226
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004F03 RID: 20227
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHeldOpen_Public_get_Boolean_0;

		// Token: 0x04004F04 RID: 20228
		private static readonly IntPtr NativeMethodInfoPtr_set_IsHeldOpen_Public_set_Void_Boolean_0;

		// Token: 0x04004F05 RID: 20229
		private static readonly IntPtr NativeMethodInfoPtr_get_ActualFlowRate_Public_get_Single_0;

		// Token: 0x04004F06 RID: 20230
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x04004F07 RID: 20231
		private static readonly IntPtr NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x04004F08 RID: 20232
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x04004F09 RID: 20233
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x04004F0A RID: 20234
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004F0B RID: 20235
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004F0C RID: 20236
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractableObject_Public_Void_String_EInteractableState_0;

		// Token: 0x04004F0D RID: 20237
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTapVisuals_Protected_Void_0;

		// Token: 0x04004F0E RID: 20238
		private static readonly IntPtr NativeMethodInfoPtr_UpdateWaterSound_Protected_Void_0;

		// Token: 0x04004F0F RID: 20239
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04004F10 RID: 20240
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x04004F11 RID: 20241
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04004F12 RID: 20242
		private static readonly IntPtr NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04004F13 RID: 20243
		private static readonly IntPtr NativeMethodInfoPtr_SetHeldOpen_Public_Void_Boolean_0;

		// Token: 0x04004F14 RID: 20244
		private static readonly IntPtr NativeMethodInfoPtr_CanInteract_Protected_Virtual_New_Boolean_0;

		// Token: 0x04004F15 RID: 20245
		private static readonly IntPtr NativeMethodInfoPtr_SendWateringCanModel_Public_Void_String_0;

		// Token: 0x04004F16 RID: 20246
		private static readonly IntPtr NativeMethodInfoPtr_CreateWateringCanModel_Private_Void_String_0;

		// Token: 0x04004F17 RID: 20247
		private static readonly IntPtr NativeMethodInfoPtr_SendClearWateringCanModelModel_Public_Void_0;

		// Token: 0x04004F18 RID: 20248
		private static readonly IntPtr NativeMethodInfoPtr_ClearWateringCanModel_Private_Void_0;

		// Token: 0x04004F19 RID: 20249
		private static readonly IntPtr NativeMethodInfoPtr_CreateWateringCanModel_Local_Public_GameObject_String_Boolean_0;

		// Token: 0x04004F1A RID: 20250
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004F1B RID: 20251
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004F1C RID: 20252
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004F1D RID: 20253
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004F1E RID: 20254
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04004F1F RID: 20255
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04004F20 RID: 20256
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004F21 RID: 20257
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04004F22 RID: 20258
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04004F23 RID: 20259
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004F24 RID: 20260
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetHeldOpen_1140765316_Private_Void_Boolean_0;

		// Token: 0x04004F25 RID: 20261
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetHeldOpen_1140765316_Public_Void_Boolean_0;

		// Token: 0x04004F26 RID: 20262
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetHeldOpen_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004F27 RID: 20263
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendWateringCanModel_3615296227_Private_Void_String_0;

		// Token: 0x04004F28 RID: 20264
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendWateringCanModel_3615296227_Public_Void_String_0;

		// Token: 0x04004F29 RID: 20265
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendWateringCanModel_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004F2A RID: 20266
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_CreateWateringCanModel_3615296227_Private_Void_String_0;

		// Token: 0x04004F2B RID: 20267
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___CreateWateringCanModel_3615296227_Private_Void_String_0;

		// Token: 0x04004F2C RID: 20268
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_CreateWateringCanModel_3615296227_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004F2D RID: 20269
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendClearWateringCanModelModel_2166136261_Private_Void_0;

		// Token: 0x04004F2E RID: 20270
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendClearWateringCanModelModel_2166136261_Public_Void_0;

		// Token: 0x04004F2F RID: 20271
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendClearWateringCanModelModel_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004F30 RID: 20272
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ClearWateringCanModel_2166136261_Private_Void_0;

		// Token: 0x04004F31 RID: 20273
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ClearWateringCanModel_2166136261_Private_Void_0;

		// Token: 0x04004F32 RID: 20274
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ClearWateringCanModel_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004F33 RID: 20275
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__IsHeldOpen_k__BackingField_Public_get_Boolean_0;

		// Token: 0x04004F34 RID: 20276
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__IsHeldOpen_k__BackingField_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x04004F35 RID: 20277
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Property_Utilities_Water_Tap_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04004F36 RID: 20278
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x04004F37 RID: 20279
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x04004F38 RID: 20280
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x04004F39 RID: 20281
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x04004F3A RID: 20282
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;
	}
}
