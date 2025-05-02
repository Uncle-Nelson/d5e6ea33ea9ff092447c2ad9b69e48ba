using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200072C RID: 1836
	public class VendingMachine : NetworkBehaviour
	{
		// Token: 0x0600A612 RID: 42514 RVA: 0x00298E38 File Offset: 0x00297038
		// Note: this type is marked as 'beforefieldinit'.
		static VendingMachine()
		{
			Il2CppClassPointerStore<VendingMachine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "VendingMachine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr);
			VendingMachine.NativeFieldInfoPtr_AllMachines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "AllMachines");
			VendingMachine.NativeFieldInfoPtr_COST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "COST");
			VendingMachine.NativeFieldInfoPtr_REPAIR_TIME_DAYS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "REPAIR_TIME_DAYS");
			VendingMachine.NativeFieldInfoPtr_IMPACT_THRESHOLD_FREE_ITEM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "IMPACT_THRESHOLD_FREE_ITEM");
			VendingMachine.NativeFieldInfoPtr_IMPACT_THRESHOLD_FREE_ITEM_CHANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "IMPACT_THRESHOLD_FREE_ITEM_CHANCE");
			VendingMachine.NativeFieldInfoPtr_IMPACT_THRESHOLD_BREAK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "IMPACT_THRESHOLD_BREAK");
			VendingMachine.NativeFieldInfoPtr_MIN_CASH_DROP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "MIN_CASH_DROP");
			VendingMachine.NativeFieldInfoPtr_MAX_CASH_DROP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "MAX_CASH_DROP");
			VendingMachine.NativeFieldInfoPtr__IsBroken_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "<IsBroken>k__BackingField");
			VendingMachine.NativeFieldInfoPtr__DaysUntilRepair_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "<DaysUntilRepair>k__BackingField");
			VendingMachine.NativeFieldInfoPtr_LitStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "LitStartTime");
			VendingMachine.NativeFieldInfoPtr_LitOnEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "LitOnEndTime");
			VendingMachine.NativeFieldInfoPtr_CukePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "CukePrefab");
			VendingMachine.NativeFieldInfoPtr_CashPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "CashPrefab");
			VendingMachine.NativeFieldInfoPtr_DoorMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "DoorMesh");
			VendingMachine.NativeFieldInfoPtr_BodyMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "BodyMesh");
			VendingMachine.NativeFieldInfoPtr_DoorOffMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "DoorOffMat");
			VendingMachine.NativeFieldInfoPtr_DoorOnMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "DoorOnMat");
			VendingMachine.NativeFieldInfoPtr_BodyOffMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "BodyOffMat");
			VendingMachine.NativeFieldInfoPtr_BodyOnMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "BodyOnMat");
			VendingMachine.NativeFieldInfoPtr_Lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "Lights");
			VendingMachine.NativeFieldInfoPtr_PaySound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "PaySound");
			VendingMachine.NativeFieldInfoPtr_DispenseSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "DispenseSound");
			VendingMachine.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "Anim");
			VendingMachine.NativeFieldInfoPtr_ItemSpawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "ItemSpawnPoint");
			VendingMachine.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "IntObj");
			VendingMachine.NativeFieldInfoPtr_AccessPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "AccessPoint");
			VendingMachine.NativeFieldInfoPtr_Damageable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "Damageable");
			VendingMachine.NativeFieldInfoPtr_CashSpawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "CashSpawnPoint");
			VendingMachine.NativeFieldInfoPtr_onBreak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "onBreak");
			VendingMachine.NativeFieldInfoPtr_onRepair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "onRepair");
			VendingMachine.NativeFieldInfoPtr__lastDroppedItem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "<lastDroppedItem>k__BackingField");
			VendingMachine.NativeFieldInfoPtr_isLit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "isLit");
			VendingMachine.NativeFieldInfoPtr_purchaseInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "purchaseInProgress");
			VendingMachine.NativeFieldInfoPtr_timeOnLastFreeItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "timeOnLastFreeItem");
			VendingMachine.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "<GUID>k__BackingField");
			VendingMachine.NativeFieldInfoPtr_BakedGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "BakedGUID");
			VendingMachine.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.VendingMachineAssembly-CSharp.dll_Excuted");
			VendingMachine.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.VendingMachineAssembly-CSharp.dll_Excuted");
			VendingMachine.NativeMethodInfoPtr_get_IsBroken_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683608);
			VendingMachine.NativeMethodInfoPtr_set_IsBroken_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683609);
			VendingMachine.NativeMethodInfoPtr_get_DaysUntilRepair_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683610);
			VendingMachine.NativeMethodInfoPtr_set_DaysUntilRepair_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683611);
			VendingMachine.NativeMethodInfoPtr_get_lastDroppedItem_Public_get_ItemPickup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683612);
			VendingMachine.NativeMethodInfoPtr_set_lastDroppedItem_Protected_set_Void_ItemPickup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683613);
			VendingMachine.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683614);
			VendingMachine.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683615);
			VendingMachine.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683616);
			VendingMachine.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683617);
			VendingMachine.NativeMethodInfoPtr_Start_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683618);
			VendingMachine.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683619);
			VendingMachine.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683620);
			VendingMachine.NativeMethodInfoPtr_OnDestroy_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683621);
			VendingMachine.NativeMethodInfoPtr_MinPass_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683622);
			VendingMachine.NativeMethodInfoPtr_DayPass_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683623);
			VendingMachine.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683624);
			VendingMachine.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683625);
			VendingMachine.NativeMethodInfoPtr_LocalPurchase_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683626);
			VendingMachine.NativeMethodInfoPtr_SendPurchase_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683627);
			VendingMachine.NativeMethodInfoPtr_PurchaseRoutine_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683628);
			VendingMachine.NativeMethodInfoPtr_DropItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683629);
			VendingMachine.NativeMethodInfoPtr_RemoveLastDropped_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683630);
			VendingMachine.NativeMethodInfoPtr_Impacted_Private_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683631);
			VendingMachine.NativeMethodInfoPtr_SetLit_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683632);
			VendingMachine.NativeMethodInfoPtr_SendBreak_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683633);
			VendingMachine.NativeMethodInfoPtr_Break_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683634);
			VendingMachine.NativeMethodInfoPtr_Repair_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683635);
			VendingMachine.NativeMethodInfoPtr_DropCash_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683636);
			VendingMachine.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Void_GenericSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683637);
			VendingMachine.NativeMethodInfoPtr_GetSaveData_Public_Virtual_Final_New_GenericSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683638);
			VendingMachine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683639);
			VendingMachine.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683641);
			VendingMachine.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683642);
			VendingMachine.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683643);
			VendingMachine.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683644);
			VendingMachine.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683645);
			VendingMachine.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683646);
			VendingMachine.NativeMethodInfoPtr_RpcWriter___Server_SendPurchase_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683647);
			VendingMachine.NativeMethodInfoPtr_RpcLogic___SendPurchase_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683648);
			VendingMachine.NativeMethodInfoPtr_RpcReader___Server_SendPurchase_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683649);
			VendingMachine.NativeMethodInfoPtr_RpcWriter___Observers_PurchaseRoutine_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683650);
			VendingMachine.NativeMethodInfoPtr_RpcLogic___PurchaseRoutine_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683651);
			VendingMachine.NativeMethodInfoPtr_RpcReader___Observers_PurchaseRoutine_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683652);
			VendingMachine.NativeMethodInfoPtr_RpcWriter___Server_DropItem_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683653);
			VendingMachine.NativeMethodInfoPtr_RpcLogic___DropItem_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683654);
			VendingMachine.NativeMethodInfoPtr_RpcReader___Server_DropItem_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683655);
			VendingMachine.NativeMethodInfoPtr_RpcWriter___Server_SendBreak_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683656);
			VendingMachine.NativeMethodInfoPtr_RpcLogic___SendBreak_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683657);
			VendingMachine.NativeMethodInfoPtr_RpcReader___Server_SendBreak_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683658);
			VendingMachine.NativeMethodInfoPtr_RpcWriter___Observers_Break_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683659);
			VendingMachine.NativeMethodInfoPtr_RpcLogic___Break_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683660);
			VendingMachine.NativeMethodInfoPtr_RpcReader___Observers_Break_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683661);
			VendingMachine.NativeMethodInfoPtr_RpcWriter___Target_Break_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683662);
			VendingMachine.NativeMethodInfoPtr_RpcReader___Target_Break_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683663);
			VendingMachine.NativeMethodInfoPtr_RpcWriter___Observers_Repair_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683664);
			VendingMachine.NativeMethodInfoPtr_RpcLogic___Repair_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683665);
			VendingMachine.NativeMethodInfoPtr_RpcReader___Observers_Repair_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683666);
			VendingMachine.NativeMethodInfoPtr_RpcWriter___Server_DropCash_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683667);
			VendingMachine.NativeMethodInfoPtr_RpcLogic___DropCash_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683668);
			VendingMachine.NativeMethodInfoPtr_RpcReader___Server_DropCash_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683669);
			VendingMachine.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100683670);
		}

		// Token: 0x17003365 RID: 13157
		// (get) Token: 0x0600A613 RID: 42515 RVA: 0x0029964C File Offset: 0x0029784C
		// (set) Token: 0x0600A614 RID: 42516 RVA: 0x00299688 File Offset: 0x00297888
		public unsafe bool IsBroken
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_get_IsBroken_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_set_IsBroken_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003366 RID: 13158
		// (get) Token: 0x0600A615 RID: 42517 RVA: 0x002996C8 File Offset: 0x002978C8
		// (set) Token: 0x0600A616 RID: 42518 RVA: 0x00299704 File Offset: 0x00297904
		public unsafe int DaysUntilRepair
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_get_DaysUntilRepair_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_set_DaysUntilRepair_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003367 RID: 13159
		// (get) Token: 0x0600A617 RID: 42519 RVA: 0x00299744 File Offset: 0x00297944
		// (set) Token: 0x0600A618 RID: 42520 RVA: 0x00299784 File Offset: 0x00297984
		public unsafe ItemPickup lastDroppedItem
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_get_lastDroppedItem_Public_get_ItemPickup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemPickup>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_set_lastDroppedItem_Protected_set_Void_ItemPickup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003368 RID: 13160
		// (get) Token: 0x0600A619 RID: 42521 RVA: 0x002997C8 File Offset: 0x002979C8
		// (set) Token: 0x0600A61A RID: 42522 RVA: 0x00299804 File Offset: 0x00297A04
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A61B RID: 42523 RVA: 0x00299844 File Offset: 0x00297A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290291, XrefRangeEnd = 290294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegenerateGUID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A61C RID: 42524 RVA: 0x00299878 File Offset: 0x00297A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290294, XrefRangeEnd = 290295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VendingMachine.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A61D RID: 42525 RVA: 0x002998B4 File Offset: 0x00297AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290295, XrefRangeEnd = 290336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_Start_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A61E RID: 42526 RVA: 0x002998E8 File Offset: 0x00297AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290336, XrefRangeEnd = 290338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VendingMachine.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A61F RID: 42527 RVA: 0x00299938 File Offset: 0x00297B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290338, XrefRangeEnd = 290342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A620 RID: 42528 RVA: 0x00299978 File Offset: 0x00297B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290342, XrefRangeEnd = 290369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_OnDestroy_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A621 RID: 42529 RVA: 0x002999AC File Offset: 0x00297BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290369, XrefRangeEnd = 290375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_MinPass_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A622 RID: 42530 RVA: 0x002999E0 File Offset: 0x00297BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290375, XrefRangeEnd = 290384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DayPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_DayPass_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A623 RID: 42531 RVA: 0x00299A14 File Offset: 0x00297C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290384, XrefRangeEnd = 290392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A624 RID: 42532 RVA: 0x00299A48 File Offset: 0x00297C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290392, XrefRangeEnd = 290397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A625 RID: 42533 RVA: 0x00299A7C File Offset: 0x00297C7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290423, RefRangeEnd = 290424, XrefRangeStart = 290397, XrefRangeEnd = 290423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LocalPurchase()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_LocalPurchase_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A626 RID: 42534 RVA: 0x00299AB0 File Offset: 0x00297CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290424, XrefRangeEnd = 290445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPurchase()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_SendPurchase_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A627 RID: 42535 RVA: 0x00299AE4 File Offset: 0x00297CE4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 290466, RefRangeEnd = 290469, XrefRangeStart = 290445, XrefRangeEnd = 290466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PurchaseRoutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_PurchaseRoutine_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A628 RID: 42536 RVA: 0x00299B18 File Offset: 0x00297D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290469, XrefRangeEnd = 290487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DropItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_DropItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A629 RID: 42537 RVA: 0x00299B4C File Offset: 0x00297D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290487, XrefRangeEnd = 290497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveLastDropped()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RemoveLastDropped_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A62A RID: 42538 RVA: 0x00299B80 File Offset: 0x00297D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290497, XrefRangeEnd = 290509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Impacted(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_Impacted_Private_Void_Impact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A62B RID: 42539 RVA: 0x00299BC4 File Offset: 0x00297DC4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 290525, RefRangeEnd = 290531, XrefRangeStart = 290509, XrefRangeEnd = 290525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLit(bool lit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_SetLit_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A62C RID: 42540 RVA: 0x00299C04 File Offset: 0x00297E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290531, XrefRangeEnd = 290552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendBreak()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_SendBreak_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A62D RID: 42541 RVA: 0x00299C38 File Offset: 0x00297E38
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 290590, RefRangeEnd = 290595, XrefRangeStart = 290552, XrefRangeEnd = 290590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Break(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_Break_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A62E RID: 42542 RVA: 0x00299C7C File Offset: 0x00297E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290595, XrefRangeEnd = 290613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Repair()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_Repair_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A62F RID: 42543 RVA: 0x00299CB0 File Offset: 0x00297EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290613, XrefRangeEnd = 290631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DropCash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_DropCash_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A630 RID: 42544 RVA: 0x00299CE4 File Offset: 0x00297EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290631, XrefRangeEnd = 290638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(GenericSaveData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Void_GenericSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A631 RID: 42545 RVA: 0x00299D28 File Offset: 0x00297F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290638, XrefRangeEnd = 290649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GenericSaveData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_GetSaveData_Public_Virtual_Final_New_GenericSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GenericSaveData>(intPtr3) : null;
		}

		// Token: 0x0600A632 RID: 42546 RVA: 0x00299D68 File Offset: 0x00297F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290649, XrefRangeEnd = 290653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VendingMachine() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A633 RID: 42547 RVA: 0x00299DA4 File Offset: 0x00297FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290653, XrefRangeEnd = 290658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600A634 RID: 42548 RVA: 0x00299DE4 File Offset: 0x00297FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290658, XrefRangeEnd = 290663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600A635 RID: 42549 RVA: 0x00299E24 File Offset: 0x00298024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290663, XrefRangeEnd = 290668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600A636 RID: 42550 RVA: 0x00299E64 File Offset: 0x00298064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290668, XrefRangeEnd = 290718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VendingMachine.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A637 RID: 42551 RVA: 0x00299EA0 File Offset: 0x002980A0
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VendingMachine.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A638 RID: 42552 RVA: 0x00299EDC File Offset: 0x002980DC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VendingMachine.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A639 RID: 42553 RVA: 0x00299F18 File Offset: 0x00298118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290718, XrefRangeEnd = 290736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendPurchase_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcWriter___Server_SendPurchase_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A63A RID: 42554 RVA: 0x00299F4C File Offset: 0x0029814C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 290466, RefRangeEnd = 290469, XrefRangeStart = 290466, XrefRangeEnd = 290469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendPurchase_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcLogic___SendPurchase_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A63B RID: 42555 RVA: 0x00299F80 File Offset: 0x00298180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290736, XrefRangeEnd = 290739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendPurchase_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcReader___Server_SendPurchase_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A63C RID: 42556 RVA: 0x00299FE4 File Offset: 0x002981E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290739, XrefRangeEnd = 290757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_PurchaseRoutine_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcWriter___Observers_PurchaseRoutine_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A63D RID: 42557 RVA: 0x0029A018 File Offset: 0x00298218
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 290767, RefRangeEnd = 290770, XrefRangeStart = 290757, XrefRangeEnd = 290767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___PurchaseRoutine_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcLogic___PurchaseRoutine_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A63E RID: 42558 RVA: 0x0029A04C File Offset: 0x0029824C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290770, XrefRangeEnd = 290773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_PurchaseRoutine_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcReader___Observers_PurchaseRoutine_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A63F RID: 42559 RVA: 0x0029A09C File Offset: 0x0029829C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_DropItem_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcWriter___Server_DropItem_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A640 RID: 42560 RVA: 0x0029A0D0 File Offset: 0x002982D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290773, XrefRangeEnd = 290785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___DropItem_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcLogic___DropItem_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A641 RID: 42561 RVA: 0x0029A104 File Offset: 0x00298304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290785, XrefRangeEnd = 290797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_DropItem_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcReader___Server_DropItem_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A642 RID: 42562 RVA: 0x0029A168 File Offset: 0x00298368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290797, XrefRangeEnd = 290815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendBreak_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcWriter___Server_SendBreak_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A643 RID: 42563 RVA: 0x0029A19C File Offset: 0x0029839C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290815, XrefRangeEnd = 290816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendBreak_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcLogic___SendBreak_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A644 RID: 42564 RVA: 0x0029A1D0 File Offset: 0x002983D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290816, XrefRangeEnd = 290819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendBreak_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcReader___Server_SendBreak_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A645 RID: 42565 RVA: 0x0029A234 File Offset: 0x00298434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290819, XrefRangeEnd = 290837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Break_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcWriter___Observers_Break_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A646 RID: 42566 RVA: 0x0029A278 File Offset: 0x00298478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290837, XrefRangeEnd = 290839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Break_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcLogic___Break_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A647 RID: 42567 RVA: 0x0029A2BC File Offset: 0x002984BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290839, XrefRangeEnd = 290843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Break_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcReader___Observers_Break_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A648 RID: 42568 RVA: 0x0029A30C File Offset: 0x0029850C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290843, XrefRangeEnd = 290861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_Break_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcWriter___Target_Break_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A649 RID: 42569 RVA: 0x0029A350 File Offset: 0x00298550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290861, XrefRangeEnd = 290865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_Break_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcReader___Target_Break_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A64A RID: 42570 RVA: 0x0029A3A0 File Offset: 0x002985A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Repair_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcWriter___Observers_Repair_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A64B RID: 42571 RVA: 0x0029A3D4 File Offset: 0x002985D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290865, XrefRangeEnd = 290872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Repair_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcLogic___Repair_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A64C RID: 42572 RVA: 0x0029A408 File Offset: 0x00298608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290872, XrefRangeEnd = 290880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Repair_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcReader___Observers_Repair_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A64D RID: 42573 RVA: 0x0029A458 File Offset: 0x00298658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_DropCash_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcWriter___Server_DropCash_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A64E RID: 42574 RVA: 0x0029A48C File Offset: 0x0029868C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290902, RefRangeEnd = 290903, XrefRangeStart = 290880, XrefRangeEnd = 290902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___DropCash_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcLogic___DropCash_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A64F RID: 42575 RVA: 0x0029A4C0 File Offset: 0x002986C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290903, XrefRangeEnd = 290905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_DropCash_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcReader___Server_DropCash_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A650 RID: 42576 RVA: 0x0029A524 File Offset: 0x00298724
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290938, RefRangeEnd = 290939, XrefRangeStart = 290905, XrefRangeEnd = 290938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A651 RID: 42577 RVA: 0x00051D57 File Offset: 0x0004FF57
		public VendingMachine(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700333E RID: 13118
		// (get) Token: 0x0600A652 RID: 42578 RVA: 0x0029A558 File Offset: 0x00298758
		// (set) Token: 0x0600A653 RID: 42579 RVA: 0x00051D60 File Offset: 0x0004FF60
		public unsafe static List<VendingMachine> AllMachines
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VendingMachine.NativeFieldInfoPtr_AllMachines, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VendingMachine>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VendingMachine.NativeFieldInfoPtr_AllMachines, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700333F RID: 13119
		// (get) Token: 0x0600A654 RID: 42580 RVA: 0x0029A580 File Offset: 0x00298780
		// (set) Token: 0x0600A655 RID: 42581 RVA: 0x00051D72 File Offset: 0x0004FF72
		public unsafe static float COST
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VendingMachine.NativeFieldInfoPtr_COST, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VendingMachine.NativeFieldInfoPtr_COST, (void*)(&value));
			}
		}

		// Token: 0x17003340 RID: 13120
		// (get) Token: 0x0600A656 RID: 42582 RVA: 0x0029A59C File Offset: 0x0029879C
		// (set) Token: 0x0600A657 RID: 42583 RVA: 0x00051D80 File Offset: 0x0004FF80
		public unsafe static int REPAIR_TIME_DAYS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(VendingMachine.NativeFieldInfoPtr_REPAIR_TIME_DAYS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VendingMachine.NativeFieldInfoPtr_REPAIR_TIME_DAYS, (void*)(&value));
			}
		}

		// Token: 0x17003341 RID: 13121
		// (get) Token: 0x0600A658 RID: 42584 RVA: 0x0029A5B8 File Offset: 0x002987B8
		// (set) Token: 0x0600A659 RID: 42585 RVA: 0x00051D8E File Offset: 0x0004FF8E
		public unsafe static float IMPACT_THRESHOLD_FREE_ITEM
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VendingMachine.NativeFieldInfoPtr_IMPACT_THRESHOLD_FREE_ITEM, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VendingMachine.NativeFieldInfoPtr_IMPACT_THRESHOLD_FREE_ITEM, (void*)(&value));
			}
		}

		// Token: 0x17003342 RID: 13122
		// (get) Token: 0x0600A65A RID: 42586 RVA: 0x0029A5D4 File Offset: 0x002987D4
		// (set) Token: 0x0600A65B RID: 42587 RVA: 0x00051D9C File Offset: 0x0004FF9C
		public unsafe static float IMPACT_THRESHOLD_FREE_ITEM_CHANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VendingMachine.NativeFieldInfoPtr_IMPACT_THRESHOLD_FREE_ITEM_CHANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VendingMachine.NativeFieldInfoPtr_IMPACT_THRESHOLD_FREE_ITEM_CHANCE, (void*)(&value));
			}
		}

		// Token: 0x17003343 RID: 13123
		// (get) Token: 0x0600A65C RID: 42588 RVA: 0x0029A5F0 File Offset: 0x002987F0
		// (set) Token: 0x0600A65D RID: 42589 RVA: 0x00051DAA File Offset: 0x0004FFAA
		public unsafe static float IMPACT_THRESHOLD_BREAK
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VendingMachine.NativeFieldInfoPtr_IMPACT_THRESHOLD_BREAK, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VendingMachine.NativeFieldInfoPtr_IMPACT_THRESHOLD_BREAK, (void*)(&value));
			}
		}

		// Token: 0x17003344 RID: 13124
		// (get) Token: 0x0600A65E RID: 42590 RVA: 0x0029A60C File Offset: 0x0029880C
		// (set) Token: 0x0600A65F RID: 42591 RVA: 0x00051DB8 File Offset: 0x0004FFB8
		public unsafe static int MIN_CASH_DROP
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(VendingMachine.NativeFieldInfoPtr_MIN_CASH_DROP, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VendingMachine.NativeFieldInfoPtr_MIN_CASH_DROP, (void*)(&value));
			}
		}

		// Token: 0x17003345 RID: 13125
		// (get) Token: 0x0600A660 RID: 42592 RVA: 0x0029A628 File Offset: 0x00298828
		// (set) Token: 0x0600A661 RID: 42593 RVA: 0x00051DC6 File Offset: 0x0004FFC6
		public unsafe static int MAX_CASH_DROP
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(VendingMachine.NativeFieldInfoPtr_MAX_CASH_DROP, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VendingMachine.NativeFieldInfoPtr_MAX_CASH_DROP, (void*)(&value));
			}
		}

		// Token: 0x17003346 RID: 13126
		// (get) Token: 0x0600A662 RID: 42594 RVA: 0x0029A644 File Offset: 0x00298844
		// (set) Token: 0x0600A663 RID: 42595 RVA: 0x00051DD4 File Offset: 0x0004FFD4
		public unsafe bool _IsBroken_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr__IsBroken_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr__IsBroken_k__BackingField)) = value;
			}
		}

		// Token: 0x17003347 RID: 13127
		// (get) Token: 0x0600A664 RID: 42596 RVA: 0x0029A66C File Offset: 0x0029886C
		// (set) Token: 0x0600A665 RID: 42597 RVA: 0x00051DEF File Offset: 0x0004FFEF
		public unsafe int _DaysUntilRepair_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr__DaysUntilRepair_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr__DaysUntilRepair_k__BackingField)) = value;
			}
		}

		// Token: 0x17003348 RID: 13128
		// (get) Token: 0x0600A666 RID: 42598 RVA: 0x0029A694 File Offset: 0x00298894
		// (set) Token: 0x0600A667 RID: 42599 RVA: 0x00051E0A File Offset: 0x0005000A
		public unsafe int LitStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_LitStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_LitStartTime)) = value;
			}
		}

		// Token: 0x17003349 RID: 13129
		// (get) Token: 0x0600A668 RID: 42600 RVA: 0x0029A6BC File Offset: 0x002988BC
		// (set) Token: 0x0600A669 RID: 42601 RVA: 0x00051E25 File Offset: 0x00050025
		public unsafe int LitOnEndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_LitOnEndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_LitOnEndTime)) = value;
			}
		}

		// Token: 0x1700334A RID: 13130
		// (get) Token: 0x0600A66A RID: 42602 RVA: 0x0029A6E4 File Offset: 0x002988E4
		// (set) Token: 0x0600A66B RID: 42603 RVA: 0x00051E40 File Offset: 0x00050040
		public unsafe ItemPickup CukePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_CukePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemPickup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_CukePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700334B RID: 13131
		// (get) Token: 0x0600A66C RID: 42604 RVA: 0x0029A714 File Offset: 0x00298914
		// (set) Token: 0x0600A66D RID: 42605 RVA: 0x00051E5F File Offset: 0x0005005F
		public unsafe CashPickup CashPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_CashPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CashPickup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_CashPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700334C RID: 13132
		// (get) Token: 0x0600A66E RID: 42606 RVA: 0x0029A744 File Offset: 0x00298944
		// (set) Token: 0x0600A66F RID: 42607 RVA: 0x00051E7E File Offset: 0x0005007E
		public unsafe MeshRenderer DoorMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_DoorMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_DoorMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700334D RID: 13133
		// (get) Token: 0x0600A670 RID: 42608 RVA: 0x0029A774 File Offset: 0x00298974
		// (set) Token: 0x0600A671 RID: 42609 RVA: 0x00051E9D File Offset: 0x0005009D
		public unsafe MeshRenderer BodyMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_BodyMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_BodyMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700334E RID: 13134
		// (get) Token: 0x0600A672 RID: 42610 RVA: 0x0029A7A4 File Offset: 0x002989A4
		// (set) Token: 0x0600A673 RID: 42611 RVA: 0x00051EBC File Offset: 0x000500BC
		public unsafe Material DoorOffMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_DoorOffMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_DoorOffMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700334F RID: 13135
		// (get) Token: 0x0600A674 RID: 42612 RVA: 0x0029A7D4 File Offset: 0x002989D4
		// (set) Token: 0x0600A675 RID: 42613 RVA: 0x00051EDB File Offset: 0x000500DB
		public unsafe Material DoorOnMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_DoorOnMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_DoorOnMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003350 RID: 13136
		// (get) Token: 0x0600A676 RID: 42614 RVA: 0x0029A804 File Offset: 0x00298A04
		// (set) Token: 0x0600A677 RID: 42615 RVA: 0x00051EFA File Offset: 0x000500FA
		public unsafe Material BodyOffMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_BodyOffMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_BodyOffMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003351 RID: 13137
		// (get) Token: 0x0600A678 RID: 42616 RVA: 0x0029A834 File Offset: 0x00298A34
		// (set) Token: 0x0600A679 RID: 42617 RVA: 0x00051F19 File Offset: 0x00050119
		public unsafe Material BodyOnMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_BodyOnMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_BodyOnMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003352 RID: 13138
		// (get) Token: 0x0600A67A RID: 42618 RVA: 0x0029A864 File Offset: 0x00298A64
		// (set) Token: 0x0600A67B RID: 42619 RVA: 0x00051F38 File Offset: 0x00050138
		public unsafe Il2CppReferenceArray<OptimizedLight> Lights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_Lights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<OptimizedLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_Lights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003353 RID: 13139
		// (get) Token: 0x0600A67C RID: 42620 RVA: 0x0029A894 File Offset: 0x00298A94
		// (set) Token: 0x0600A67D RID: 42621 RVA: 0x00051F57 File Offset: 0x00050157
		public unsafe AudioSourceController PaySound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_PaySound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_PaySound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003354 RID: 13140
		// (get) Token: 0x0600A67E RID: 42622 RVA: 0x0029A8C4 File Offset: 0x00298AC4
		// (set) Token: 0x0600A67F RID: 42623 RVA: 0x00051F76 File Offset: 0x00050176
		public unsafe AudioSourceController DispenseSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_DispenseSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_DispenseSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003355 RID: 13141
		// (get) Token: 0x0600A680 RID: 42624 RVA: 0x0029A8F4 File Offset: 0x00298AF4
		// (set) Token: 0x0600A681 RID: 42625 RVA: 0x00051F95 File Offset: 0x00050195
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003356 RID: 13142
		// (get) Token: 0x0600A682 RID: 42626 RVA: 0x0029A924 File Offset: 0x00298B24
		// (set) Token: 0x0600A683 RID: 42627 RVA: 0x00051FB4 File Offset: 0x000501B4
		public unsafe Transform ItemSpawnPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_ItemSpawnPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_ItemSpawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003357 RID: 13143
		// (get) Token: 0x0600A684 RID: 42628 RVA: 0x0029A954 File Offset: 0x00298B54
		// (set) Token: 0x0600A685 RID: 42629 RVA: 0x00051FD3 File Offset: 0x000501D3
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003358 RID: 13144
		// (get) Token: 0x0600A686 RID: 42630 RVA: 0x0029A984 File Offset: 0x00298B84
		// (set) Token: 0x0600A687 RID: 42631 RVA: 0x00051FF2 File Offset: 0x000501F2
		public unsafe Transform AccessPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_AccessPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_AccessPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003359 RID: 13145
		// (get) Token: 0x0600A688 RID: 42632 RVA: 0x0029A9B4 File Offset: 0x00298BB4
		// (set) Token: 0x0600A689 RID: 42633 RVA: 0x00052011 File Offset: 0x00050211
		public unsafe PhysicsDamageable Damageable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_Damageable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhysicsDamageable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_Damageable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700335A RID: 13146
		// (get) Token: 0x0600A68A RID: 42634 RVA: 0x0029A9E4 File Offset: 0x00298BE4
		// (set) Token: 0x0600A68B RID: 42635 RVA: 0x00052030 File Offset: 0x00050230
		public unsafe Transform CashSpawnPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_CashSpawnPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_CashSpawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700335B RID: 13147
		// (get) Token: 0x0600A68C RID: 42636 RVA: 0x0029AA14 File Offset: 0x00298C14
		// (set) Token: 0x0600A68D RID: 42637 RVA: 0x0005204F File Offset: 0x0005024F
		public unsafe UnityEvent onBreak
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_onBreak);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_onBreak), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700335C RID: 13148
		// (get) Token: 0x0600A68E RID: 42638 RVA: 0x0029AA44 File Offset: 0x00298C44
		// (set) Token: 0x0600A68F RID: 42639 RVA: 0x0005206E File Offset: 0x0005026E
		public unsafe UnityEvent onRepair
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_onRepair);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_onRepair), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700335D RID: 13149
		// (get) Token: 0x0600A690 RID: 42640 RVA: 0x0029AA74 File Offset: 0x00298C74
		// (set) Token: 0x0600A691 RID: 42641 RVA: 0x0005208D File Offset: 0x0005028D
		public unsafe ItemPickup _lastDroppedItem_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr__lastDroppedItem_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemPickup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr__lastDroppedItem_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700335E RID: 13150
		// (get) Token: 0x0600A692 RID: 42642 RVA: 0x0029AAA4 File Offset: 0x00298CA4
		// (set) Token: 0x0600A693 RID: 42643 RVA: 0x000520AC File Offset: 0x000502AC
		public unsafe bool isLit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_isLit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_isLit)) = value;
			}
		}

		// Token: 0x1700335F RID: 13151
		// (get) Token: 0x0600A694 RID: 42644 RVA: 0x0029AACC File Offset: 0x00298CCC
		// (set) Token: 0x0600A695 RID: 42645 RVA: 0x000520C7 File Offset: 0x000502C7
		public unsafe bool purchaseInProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_purchaseInProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_purchaseInProgress)) = value;
			}
		}

		// Token: 0x17003360 RID: 13152
		// (get) Token: 0x0600A696 RID: 42646 RVA: 0x0029AAF4 File Offset: 0x00298CF4
		// (set) Token: 0x0600A697 RID: 42647 RVA: 0x000520E2 File Offset: 0x000502E2
		public unsafe float timeOnLastFreeItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_timeOnLastFreeItem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_timeOnLastFreeItem)) = value;
			}
		}

		// Token: 0x17003361 RID: 13153
		// (get) Token: 0x0600A698 RID: 42648 RVA: 0x0029AB1C File Offset: 0x00298D1C
		// (set) Token: 0x0600A699 RID: 42649 RVA: 0x000520FD File Offset: 0x000502FD
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17003362 RID: 13154
		// (get) Token: 0x0600A69A RID: 42650 RVA: 0x0029AB44 File Offset: 0x00298D44
		// (set) Token: 0x0600A69B RID: 42651 RVA: 0x00052118 File Offset: 0x00050318
		public unsafe string BakedGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_BakedGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_BakedGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003363 RID: 13155
		// (get) Token: 0x0600A69C RID: 42652 RVA: 0x0029AB6C File Offset: 0x00298D6C
		// (set) Token: 0x0600A69D RID: 42653 RVA: 0x00052137 File Offset: 0x00050337
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17003364 RID: 13156
		// (get) Token: 0x0600A69E RID: 42654 RVA: 0x0029AB94 File Offset: 0x00298D94
		// (set) Token: 0x0600A69F RID: 42655 RVA: 0x00052152 File Offset: 0x00050352
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006F5D RID: 28509
		private static readonly IntPtr NativeFieldInfoPtr_AllMachines;

		// Token: 0x04006F5E RID: 28510
		private static readonly IntPtr NativeFieldInfoPtr_COST;

		// Token: 0x04006F5F RID: 28511
		private static readonly IntPtr NativeFieldInfoPtr_REPAIR_TIME_DAYS;

		// Token: 0x04006F60 RID: 28512
		private static readonly IntPtr NativeFieldInfoPtr_IMPACT_THRESHOLD_FREE_ITEM;

		// Token: 0x04006F61 RID: 28513
		private static readonly IntPtr NativeFieldInfoPtr_IMPACT_THRESHOLD_FREE_ITEM_CHANCE;

		// Token: 0x04006F62 RID: 28514
		private static readonly IntPtr NativeFieldInfoPtr_IMPACT_THRESHOLD_BREAK;

		// Token: 0x04006F63 RID: 28515
		private static readonly IntPtr NativeFieldInfoPtr_MIN_CASH_DROP;

		// Token: 0x04006F64 RID: 28516
		private static readonly IntPtr NativeFieldInfoPtr_MAX_CASH_DROP;

		// Token: 0x04006F65 RID: 28517
		private static readonly IntPtr NativeFieldInfoPtr__IsBroken_k__BackingField;

		// Token: 0x04006F66 RID: 28518
		private static readonly IntPtr NativeFieldInfoPtr__DaysUntilRepair_k__BackingField;

		// Token: 0x04006F67 RID: 28519
		private static readonly IntPtr NativeFieldInfoPtr_LitStartTime;

		// Token: 0x04006F68 RID: 28520
		private static readonly IntPtr NativeFieldInfoPtr_LitOnEndTime;

		// Token: 0x04006F69 RID: 28521
		private static readonly IntPtr NativeFieldInfoPtr_CukePrefab;

		// Token: 0x04006F6A RID: 28522
		private static readonly IntPtr NativeFieldInfoPtr_CashPrefab;

		// Token: 0x04006F6B RID: 28523
		private static readonly IntPtr NativeFieldInfoPtr_DoorMesh;

		// Token: 0x04006F6C RID: 28524
		private static readonly IntPtr NativeFieldInfoPtr_BodyMesh;

		// Token: 0x04006F6D RID: 28525
		private static readonly IntPtr NativeFieldInfoPtr_DoorOffMat;

		// Token: 0x04006F6E RID: 28526
		private static readonly IntPtr NativeFieldInfoPtr_DoorOnMat;

		// Token: 0x04006F6F RID: 28527
		private static readonly IntPtr NativeFieldInfoPtr_BodyOffMat;

		// Token: 0x04006F70 RID: 28528
		private static readonly IntPtr NativeFieldInfoPtr_BodyOnMat;

		// Token: 0x04006F71 RID: 28529
		private static readonly IntPtr NativeFieldInfoPtr_Lights;

		// Token: 0x04006F72 RID: 28530
		private static readonly IntPtr NativeFieldInfoPtr_PaySound;

		// Token: 0x04006F73 RID: 28531
		private static readonly IntPtr NativeFieldInfoPtr_DispenseSound;

		// Token: 0x04006F74 RID: 28532
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x04006F75 RID: 28533
		private static readonly IntPtr NativeFieldInfoPtr_ItemSpawnPoint;

		// Token: 0x04006F76 RID: 28534
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04006F77 RID: 28535
		private static readonly IntPtr NativeFieldInfoPtr_AccessPoint;

		// Token: 0x04006F78 RID: 28536
		private static readonly IntPtr NativeFieldInfoPtr_Damageable;

		// Token: 0x04006F79 RID: 28537
		private static readonly IntPtr NativeFieldInfoPtr_CashSpawnPoint;

		// Token: 0x04006F7A RID: 28538
		private static readonly IntPtr NativeFieldInfoPtr_onBreak;

		// Token: 0x04006F7B RID: 28539
		private static readonly IntPtr NativeFieldInfoPtr_onRepair;

		// Token: 0x04006F7C RID: 28540
		private static readonly IntPtr NativeFieldInfoPtr__lastDroppedItem_k__BackingField;

		// Token: 0x04006F7D RID: 28541
		private static readonly IntPtr NativeFieldInfoPtr_isLit;

		// Token: 0x04006F7E RID: 28542
		private static readonly IntPtr NativeFieldInfoPtr_purchaseInProgress;

		// Token: 0x04006F7F RID: 28543
		private static readonly IntPtr NativeFieldInfoPtr_timeOnLastFreeItem;

		// Token: 0x04006F80 RID: 28544
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04006F81 RID: 28545
		private static readonly IntPtr NativeFieldInfoPtr_BakedGUID;

		// Token: 0x04006F82 RID: 28546
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006F83 RID: 28547
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006F84 RID: 28548
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBroken_Public_get_Boolean_0;

		// Token: 0x04006F85 RID: 28549
		private static readonly IntPtr NativeMethodInfoPtr_set_IsBroken_Protected_set_Void_Boolean_0;

		// Token: 0x04006F86 RID: 28550
		private static readonly IntPtr NativeMethodInfoPtr_get_DaysUntilRepair_Public_get_Int32_0;

		// Token: 0x04006F87 RID: 28551
		private static readonly IntPtr NativeMethodInfoPtr_set_DaysUntilRepair_Protected_set_Void_Int32_0;

		// Token: 0x04006F88 RID: 28552
		private static readonly IntPtr NativeMethodInfoPtr_get_lastDroppedItem_Public_get_ItemPickup_0;

		// Token: 0x04006F89 RID: 28553
		private static readonly IntPtr NativeMethodInfoPtr_set_lastDroppedItem_Protected_set_Void_ItemPickup_0;

		// Token: 0x04006F8A RID: 28554
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04006F8B RID: 28555
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04006F8C RID: 28556
		private static readonly IntPtr NativeMethodInfoPtr_RegenerateGUID_Public_Void_0;

		// Token: 0x04006F8D RID: 28557
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04006F8E RID: 28558
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_1;

		// Token: 0x04006F8F RID: 28559
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04006F90 RID: 28560
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04006F91 RID: 28561
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_1;

		// Token: 0x04006F92 RID: 28562
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_1;

		// Token: 0x04006F93 RID: 28563
		private static readonly IntPtr NativeMethodInfoPtr_DayPass_Public_Void_0;

		// Token: 0x04006F94 RID: 28564
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04006F95 RID: 28565
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x04006F96 RID: 28566
		private static readonly IntPtr NativeMethodInfoPtr_LocalPurchase_Private_Void_1;

		// Token: 0x04006F97 RID: 28567
		private static readonly IntPtr NativeMethodInfoPtr_SendPurchase_Public_Void_0;

		// Token: 0x04006F98 RID: 28568
		private static readonly IntPtr NativeMethodInfoPtr_PurchaseRoutine_Public_Void_0;

		// Token: 0x04006F99 RID: 28569
		private static readonly IntPtr NativeMethodInfoPtr_DropItem_Public_Void_0;

		// Token: 0x04006F9A RID: 28570
		private static readonly IntPtr NativeMethodInfoPtr_RemoveLastDropped_Public_Void_0;

		// Token: 0x04006F9B RID: 28571
		private static readonly IntPtr NativeMethodInfoPtr_Impacted_Private_Void_Impact_0;

		// Token: 0x04006F9C RID: 28572
		private static readonly IntPtr NativeMethodInfoPtr_SetLit_Private_Void_Boolean_0;

		// Token: 0x04006F9D RID: 28573
		private static readonly IntPtr NativeMethodInfoPtr_SendBreak_Private_Void_1;

		// Token: 0x04006F9E RID: 28574
		private static readonly IntPtr NativeMethodInfoPtr_Break_Private_Void_NetworkConnection_0;

		// Token: 0x04006F9F RID: 28575
		private static readonly IntPtr NativeMethodInfoPtr_Repair_Private_Void_1;

		// Token: 0x04006FA0 RID: 28576
		private static readonly IntPtr NativeMethodInfoPtr_DropCash_Private_Void_1;

		// Token: 0x04006FA1 RID: 28577
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Void_GenericSaveData_0;

		// Token: 0x04006FA2 RID: 28578
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_Virtual_Final_New_GenericSaveData_0;

		// Token: 0x04006FA3 RID: 28579
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006FA4 RID: 28580
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04006FA5 RID: 28581
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1;

		// Token: 0x04006FA6 RID: 28582
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_2;

		// Token: 0x04006FA7 RID: 28583
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006FA8 RID: 28584
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006FA9 RID: 28585
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006FAA RID: 28586
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendPurchase_2166136261_Private_Void_1;

		// Token: 0x04006FAB RID: 28587
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendPurchase_2166136261_Public_Void_0;

		// Token: 0x04006FAC RID: 28588
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendPurchase_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006FAD RID: 28589
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_PurchaseRoutine_2166136261_Private_Void_1;

		// Token: 0x04006FAE RID: 28590
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___PurchaseRoutine_2166136261_Public_Void_0;

		// Token: 0x04006FAF RID: 28591
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_PurchaseRoutine_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006FB0 RID: 28592
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_DropItem_2166136261_Private_Void_1;

		// Token: 0x04006FB1 RID: 28593
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___DropItem_2166136261_Public_Void_0;

		// Token: 0x04006FB2 RID: 28594
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_DropItem_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006FB3 RID: 28595
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendBreak_2166136261_Private_Void_1;

		// Token: 0x04006FB4 RID: 28596
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendBreak_2166136261_Private_Void_1;

		// Token: 0x04006FB5 RID: 28597
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendBreak_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006FB6 RID: 28598
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Break_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04006FB7 RID: 28599
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Break_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04006FB8 RID: 28600
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Break_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006FB9 RID: 28601
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_Break_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04006FBA RID: 28602
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_Break_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006FBB RID: 28603
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Repair_2166136261_Private_Void_1;

		// Token: 0x04006FBC RID: 28604
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Repair_2166136261_Private_Void_1;

		// Token: 0x04006FBD RID: 28605
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Repair_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006FBE RID: 28606
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_DropCash_2166136261_Private_Void_1;

		// Token: 0x04006FBF RID: 28607
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___DropCash_2166136261_Private_Void_1;

		// Token: 0x04006FC0 RID: 28608
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_DropCash_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006FC1 RID: 28609
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;

		// Token: 0x02000BD1 RID: 3025
		[ObfuscatedName("ScheduleOne.ObjectScripts.VendingMachine+<<Impacted>g__BreakRoutine|64_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DE69 RID: 56937 RVA: 0x00347824 File Offset: 0x00345A24
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique()
			{
				Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "<<Impacted>g__BreakRoutine|64_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr, "<>1__state");
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr, "<>2__current");
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr, "<>4__this");
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr__cashDrop_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr, "<cashDrop>5__2");
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr, "<i>5__3");
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr, 100683671);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr, 100683672);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr, 100683673);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr, 100683674);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr, 100683675);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr, 100683676);
			}

			// Token: 0x0600DE6A RID: 56938 RVA: 0x0034792C File Offset: 0x00345B2C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE6B RID: 56939 RVA: 0x00347974 File Offset: 0x00345B74
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE6C RID: 56940 RVA: 0x003479A8 File Offset: 0x00345BA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290239, XrefRangeEnd = 290265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170044F5 RID: 17653
			// (get) Token: 0x0600DE6D RID: 56941 RVA: 0x003479E4 File Offset: 0x00345BE4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE6E RID: 56942 RVA: 0x00347A24 File Offset: 0x00345C24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290265, XrefRangeEnd = 290270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170044F6 RID: 17654
			// (get) Token: 0x0600DE6F RID: 56943 RVA: 0x00347A58 File Offset: 0x00345C58
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE70 RID: 56944 RVA: 0x0006C71B File Offset: 0x0006A91B
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044F0 RID: 17648
			// (get) Token: 0x0600DE71 RID: 56945 RVA: 0x00347A98 File Offset: 0x00345C98
			// (set) Token: 0x0600DE72 RID: 56946 RVA: 0x0006C724 File Offset: 0x0006A924
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170044F1 RID: 17649
			// (get) Token: 0x0600DE73 RID: 56947 RVA: 0x00347AC0 File Offset: 0x00345CC0
			// (set) Token: 0x0600DE74 RID: 56948 RVA: 0x0006C73F File Offset: 0x0006A93F
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044F2 RID: 17650
			// (get) Token: 0x0600DE75 RID: 56949 RVA: 0x00347AF0 File Offset: 0x00345CF0
			// (set) Token: 0x0600DE76 RID: 56950 RVA: 0x0006C75E File Offset: 0x0006A95E
			public unsafe VendingMachine __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VendingMachine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044F3 RID: 17651
			// (get) Token: 0x0600DE77 RID: 56951 RVA: 0x00347B20 File Offset: 0x00345D20
			// (set) Token: 0x0600DE78 RID: 56952 RVA: 0x0006C77D File Offset: 0x0006A97D
			public unsafe int _cashDrop_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr__cashDrop_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr__cashDrop_5__2)) = value;
				}
			}

			// Token: 0x170044F4 RID: 17652
			// (get) Token: 0x0600DE79 RID: 56953 RVA: 0x00347B48 File Offset: 0x00345D48
			// (set) Token: 0x0600DE7A RID: 56954 RVA: 0x0006C798 File Offset: 0x0006A998
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x040094EB RID: 38123
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040094EC RID: 38124
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040094ED RID: 38125
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040094EE RID: 38126
			private static readonly IntPtr NativeFieldInfoPtr__cashDrop_5__2;

			// Token: 0x040094EF RID: 38127
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x040094F0 RID: 38128
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040094F1 RID: 38129
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094F2 RID: 38130
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040094F3 RID: 38131
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040094F4 RID: 38132
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094F5 RID: 38133
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BD2 RID: 3026
		[ObfuscatedName("ScheduleOne.ObjectScripts.VendingMachine+<<Impacted>g__Drop|64_1>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0 : Il2CppSystem.Object
		{
			// Token: 0x0600DE7B RID: 56955 RVA: 0x00347B70 File Offset: 0x00345D70
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0()
			{
				Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "<<Impacted>g__Drop|64_1>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, "<>1__state");
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, "<>2__current");
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, "<>4__this");
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, 100683677);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, 100683678);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, 100683679);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, 100683680);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, 100683681);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, 100683682);
			}

			// Token: 0x0600DE7C RID: 56956 RVA: 0x00347C50 File Offset: 0x00345E50
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE7D RID: 56957 RVA: 0x00347C98 File Offset: 0x00345E98
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE7E RID: 56958 RVA: 0x00347CCC File Offset: 0x00345ECC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290270, XrefRangeEnd = 290275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170044FA RID: 17658
			// (get) Token: 0x0600DE7F RID: 56959 RVA: 0x00347D08 File Offset: 0x00345F08
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE80 RID: 56960 RVA: 0x00347D48 File Offset: 0x00345F48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290275, XrefRangeEnd = 290280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170044FB RID: 17659
			// (get) Token: 0x0600DE81 RID: 56961 RVA: 0x00347D7C File Offset: 0x00345F7C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE82 RID: 56962 RVA: 0x0006C7B3 File Offset: 0x0006A9B3
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044F7 RID: 17655
			// (get) Token: 0x0600DE83 RID: 56963 RVA: 0x00347DBC File Offset: 0x00345FBC
			// (set) Token: 0x0600DE84 RID: 56964 RVA: 0x0006C7BC File Offset: 0x0006A9BC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170044F8 RID: 17656
			// (get) Token: 0x0600DE85 RID: 56965 RVA: 0x00347DE4 File Offset: 0x00345FE4
			// (set) Token: 0x0600DE86 RID: 56966 RVA: 0x0006C7D7 File Offset: 0x0006A9D7
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044F9 RID: 17657
			// (get) Token: 0x0600DE87 RID: 56967 RVA: 0x00347E14 File Offset: 0x00346014
			// (set) Token: 0x0600DE88 RID: 56968 RVA: 0x0006C7F6 File Offset: 0x0006A9F6
			public unsafe VendingMachine __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VendingMachine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040094F6 RID: 38134
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040094F7 RID: 38135
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040094F8 RID: 38136
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040094F9 RID: 38137
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040094FA RID: 38138
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094FB RID: 38139
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040094FC RID: 38140
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040094FD RID: 38141
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094FE RID: 38142
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BD3 RID: 3027
		[ObfuscatedName("ScheduleOne.ObjectScripts.VendingMachine+<<PurchaseRoutine>g__Routine|61_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1 : Il2CppSystem.Object
		{
			// Token: 0x0600DE89 RID: 56969 RVA: 0x00347E44 File Offset: 0x00346044
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1()
			{
				Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "<<PurchaseRoutine>g__Routine|61_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, "<>1__state");
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, "<>2__current");
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, "<>4__this");
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, 100683683);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, 100683684);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, 100683685);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, 100683686);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, 100683687);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, 100683688);
			}

			// Token: 0x0600DE8A RID: 56970 RVA: 0x00347F24 File Offset: 0x00346124
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE8B RID: 56971 RVA: 0x00347F6C File Offset: 0x0034616C
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE8C RID: 56972 RVA: 0x00347FA0 File Offset: 0x003461A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290280, XrefRangeEnd = 290286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170044FF RID: 17663
			// (get) Token: 0x0600DE8D RID: 56973 RVA: 0x00347FDC File Offset: 0x003461DC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE8E RID: 56974 RVA: 0x0034801C File Offset: 0x0034621C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290286, XrefRangeEnd = 290291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004500 RID: 17664
			// (get) Token: 0x0600DE8F RID: 56975 RVA: 0x00348050 File Offset: 0x00346250
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE90 RID: 56976 RVA: 0x0006C815 File Offset: 0x0006AA15
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044FC RID: 17660
			// (get) Token: 0x0600DE91 RID: 56977 RVA: 0x00348090 File Offset: 0x00346290
			// (set) Token: 0x0600DE92 RID: 56978 RVA: 0x0006C81E File Offset: 0x0006AA1E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170044FD RID: 17661
			// (get) Token: 0x0600DE93 RID: 56979 RVA: 0x003480B8 File Offset: 0x003462B8
			// (set) Token: 0x0600DE94 RID: 56980 RVA: 0x0006C839 File Offset: 0x0006AA39
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044FE RID: 17662
			// (get) Token: 0x0600DE95 RID: 56981 RVA: 0x003480E8 File Offset: 0x003462E8
			// (set) Token: 0x0600DE96 RID: 56982 RVA: 0x0006C858 File Offset: 0x0006AA58
			public unsafe VendingMachine __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VendingMachine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040094FF RID: 38143
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009500 RID: 38144
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009501 RID: 38145
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009502 RID: 38146
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009503 RID: 38147
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009504 RID: 38148
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009505 RID: 38149
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009506 RID: 38150
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009507 RID: 38151
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
