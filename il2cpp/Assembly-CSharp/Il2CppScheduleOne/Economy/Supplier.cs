using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.Messaging;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.NPCs.Relation;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.UI.Phone;
using Il2CppScheduleOne.UI.Shop;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x0200041A RID: 1050
	public class Supplier : NPC
	{
		// Token: 0x06005BBE RID: 23486 RVA: 0x001A9628 File Offset: 0x001A7828
		// Note: this type is marked as 'beforefieldinit'.
		static Supplier()
		{
			Il2CppClassPointerStore<Supplier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "Supplier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Supplier>.NativeClassPtr);
			Supplier.NativeFieldInfoPtr_MEETUP_RELATIONSHIP_REQUIREMENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "MEETUP_RELATIONSHIP_REQUIREMENT");
			Supplier.NativeFieldInfoPtr_MEETUP_DURATION_MINS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "MEETUP_DURATION_MINS");
			Supplier.NativeFieldInfoPtr_MEETING_COOLDOWN_MINS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "MEETING_COOLDOWN_MINS");
			Supplier.NativeFieldInfoPtr_DEADDROP_WAIT_PER_ITEM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "DEADDROP_WAIT_PER_ITEM");
			Supplier.NativeFieldInfoPtr_DEADDROP_MAX_WAIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "DEADDROP_MAX_WAIT");
			Supplier.NativeFieldInfoPtr_DEADDROP_ITEM_LIMIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "DEADDROP_ITEM_LIMIT");
			Supplier.NativeFieldInfoPtr_DELIVERY_RELATIONSHIP_REQUIREMENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "DELIVERY_RELATIONSHIP_REQUIREMENT");
			Supplier.NativeFieldInfoPtr_SupplierLabelColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "SupplierLabelColor");
			Supplier.NativeFieldInfoPtr__Status_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "<Status>k__BackingField");
			Supplier.NativeFieldInfoPtr__DeliveriesEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "<DeliveriesEnabled>k__BackingField");
			Supplier.NativeFieldInfoPtr_MinOrderLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "MinOrderLimit");
			Supplier.NativeFieldInfoPtr_MaxOrderLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "MaxOrderLimit");
			Supplier.NativeFieldInfoPtr_OnlineShopItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "OnlineShopItems");
			Supplier.NativeFieldInfoPtr_SupplierRecommendMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "SupplierRecommendMessage");
			Supplier.NativeFieldInfoPtr_SupplierUnlockHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "SupplierUnlockHint");
			Supplier.NativeFieldInfoPtr_Shop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "Shop");
			Supplier.NativeFieldInfoPtr_Stash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "Stash");
			Supplier.NativeFieldInfoPtr_onDeaddropReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "onDeaddropReady");
			Supplier.NativeFieldInfoPtr_minsSinceMeetingStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "minsSinceMeetingStart");
			Supplier.NativeFieldInfoPtr_minsSinceLastMeetingEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "minsSinceLastMeetingEnd");
			Supplier.NativeFieldInfoPtr_currentLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "currentLocation");
			Supplier.NativeFieldInfoPtr_dialogueController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "dialogueController");
			Supplier.NativeFieldInfoPtr_meetingGreeting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "meetingGreeting");
			Supplier.NativeFieldInfoPtr_meetingChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "meetingChoice");
			Supplier.NativeFieldInfoPtr_debt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "debt");
			Supplier.NativeFieldInfoPtr_deadDropPreparing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "deadDropPreparing");
			Supplier.NativeFieldInfoPtr__minsUntilDeaddropReady_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "<minsUntilDeaddropReady>k__BackingField");
			Supplier.NativeFieldInfoPtr_deaddropItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "deaddropItems");
			Supplier.NativeFieldInfoPtr_minsSinceDeaddropOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "minsSinceDeaddropOrder");
			Supplier.NativeFieldInfoPtr_repaymentReminderSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "repaymentReminderSent");
			Supplier.NativeFieldInfoPtr_syncVar___debt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "syncVar___debt");
			Supplier.NativeFieldInfoPtr_syncVar___deadDropPreparing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "syncVar___deadDropPreparing");
			Supplier.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Economy.SupplierAssembly-CSharp.dll_Excuted");
			Supplier.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Economy.SupplierAssembly-CSharp.dll_Excuted");
			Supplier.NativeMethodInfoPtr_get_Status_Public_get_ESupplierStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674991);
			Supplier.NativeMethodInfoPtr_set_Status_Private_set_Void_ESupplierStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674992);
			Supplier.NativeMethodInfoPtr_get_DeliveriesEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674993);
			Supplier.NativeMethodInfoPtr_set_DeliveriesEnabled_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674994);
			Supplier.NativeMethodInfoPtr_get_Debt_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674995);
			Supplier.NativeMethodInfoPtr_get_minsUntilDeaddropReady_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674996);
			Supplier.NativeMethodInfoPtr_set_minsUntilDeaddropReady_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674997);
			Supplier.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674998);
			Supplier.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100674999);
			Supplier.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675000);
			Supplier.NativeMethodInfoPtr_SendUnlocked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675001);
			Supplier.NativeMethodInfoPtr_SetUnlocked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675002);
			Supplier.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675003);
			Supplier.NativeMethodInfoPtr_HourPass_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675004);
			Supplier.NativeMethodInfoPtr_OnTimeSkip_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675005);
			Supplier.NativeMethodInfoPtr_MeetAtLocation_Public_Void_NetworkConnection_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675006);
			Supplier.NativeMethodInfoPtr_EndMeeting_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675007);
			Supplier.NativeMethodInfoPtr_SupplierUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675008);
			Supplier.NativeMethodInfoPtr_RelationshipChange_Protected_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675009);
			Supplier.NativeMethodInfoPtr_EnableDeliveries_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675010);
			Supplier.NativeMethodInfoPtr_SetUnlockMessage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675011);
			Supplier.NativeMethodInfoPtr_CreateMessageConversation_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675012);
			Supplier.NativeMethodInfoPtr_DeaddropRequested_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675013);
			Supplier.NativeMethodInfoPtr_DeaddropConfirmed_Protected_Virtual_New_Void_List_1_CartEntry_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675014);
			Supplier.NativeMethodInfoPtr_SetDeaddrop_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675015);
			Supplier.NativeMethodInfoPtr_ChangeDebt_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675016);
			Supplier.NativeMethodInfoPtr_TryRecoverDebt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675017);
			Supplier.NativeMethodInfoPtr_CompleteDeaddrop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675018);
			Supplier.NativeMethodInfoPtr_SendDebtReminder_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675019);
			Supplier.NativeMethodInfoPtr_MeetupRequested_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675020);
			Supplier.NativeMethodInfoPtr_PayDebtRequested_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675021);
			Supplier.NativeMethodInfoPtr_GetAppropriateLocation_Protected_SupplierLocation_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675022);
			Supplier.NativeMethodInfoPtr_IsDeadDropValid_Private_Boolean_SendableMessage_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675023);
			Supplier.NativeMethodInfoPtr_IsMeetupValid_Private_Boolean_SendableMessage_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675024);
			Supplier.NativeMethodInfoPtr_GetDeadDropLimit_Public_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675025);
			Supplier.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675026);
			Supplier.NativeMethodInfoPtr_Load_Public_Virtual_Void_NPCData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675027);
			Supplier.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675028);
			Supplier.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675030);
			Supplier.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675031);
			Supplier.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675032);
			Supplier.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675033);
			Supplier.NativeMethodInfoPtr_RpcWriter___Server_SendUnlocked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675034);
			Supplier.NativeMethodInfoPtr_RpcLogic___SendUnlocked_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675035);
			Supplier.NativeMethodInfoPtr_RpcReader___Server_SendUnlocked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675036);
			Supplier.NativeMethodInfoPtr_RpcWriter___Observers_SetUnlocked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675037);
			Supplier.NativeMethodInfoPtr_RpcLogic___SetUnlocked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675038);
			Supplier.NativeMethodInfoPtr_RpcReader___Observers_SetUnlocked_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675039);
			Supplier.NativeMethodInfoPtr_RpcWriter___Observers_MeetAtLocation_3470796954_Private_Void_NetworkConnection_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675040);
			Supplier.NativeMethodInfoPtr_RpcLogic___MeetAtLocation_3470796954_Public_Void_NetworkConnection_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675041);
			Supplier.NativeMethodInfoPtr_RpcReader___Observers_MeetAtLocation_3470796954_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675042);
			Supplier.NativeMethodInfoPtr_RpcWriter___Observers_EnableDeliveries_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675043);
			Supplier.NativeMethodInfoPtr_RpcLogic___EnableDeliveries_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675044);
			Supplier.NativeMethodInfoPtr_RpcReader___Observers_EnableDeliveries_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675045);
			Supplier.NativeMethodInfoPtr_RpcWriter___Target_EnableDeliveries_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675046);
			Supplier.NativeMethodInfoPtr_RpcReader___Target_EnableDeliveries_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675047);
			Supplier.NativeMethodInfoPtr_RpcWriter___Server_SetDeaddrop_3971994486_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675048);
			Supplier.NativeMethodInfoPtr_RpcLogic___SetDeaddrop_3971994486_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675049);
			Supplier.NativeMethodInfoPtr_RpcReader___Server_SetDeaddrop_3971994486_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675050);
			Supplier.NativeMethodInfoPtr_RpcWriter___Server_ChangeDebt_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675051);
			Supplier.NativeMethodInfoPtr_RpcLogic___ChangeDebt_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675052);
			Supplier.NativeMethodInfoPtr_RpcReader___Server_ChangeDebt_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675053);
			Supplier.NativeMethodInfoPtr_sync___get_value_debt_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675054);
			Supplier.NativeMethodInfoPtr_sync___set_value_debt_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675055);
			Supplier.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Supplier_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675056);
			Supplier.NativeMethodInfoPtr_sync___get_value_deadDropPreparing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675057);
			Supplier.NativeMethodInfoPtr_sync___set_value_deadDropPreparing_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675058);
			Supplier.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675059);
		}

		// Token: 0x17001BBD RID: 7101
		// (get) Token: 0x06005BBF RID: 23487 RVA: 0x001A9E50 File Offset: 0x001A8050
		// (set) Token: 0x06005BC0 RID: 23488 RVA: 0x001A9E8C File Offset: 0x001A808C
		public unsafe Supplier.ESupplierStatus Status
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_get_Status_Public_get_ESupplierStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_set_Status_Private_set_Void_ESupplierStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001BBE RID: 7102
		// (get) Token: 0x06005BC1 RID: 23489 RVA: 0x001A9ECC File Offset: 0x001A80CC
		// (set) Token: 0x06005BC2 RID: 23490 RVA: 0x001A9F08 File Offset: 0x001A8108
		public unsafe bool DeliveriesEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_get_DeliveriesEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_set_DeliveriesEnabled_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001BBF RID: 7103
		// (get) Token: 0x06005BC3 RID: 23491 RVA: 0x001A9F48 File Offset: 0x001A8148
		public unsafe float Debt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_get_Debt_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001BC0 RID: 7104
		// (get) Token: 0x06005BC4 RID: 23492 RVA: 0x001A9F84 File Offset: 0x001A8184
		// (set) Token: 0x06005BC5 RID: 23493 RVA: 0x001A9FC0 File Offset: 0x001A81C0
		public unsafe int minsUntilDeaddropReady
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_get_minsUntilDeaddropReady_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_set_minsUntilDeaddropReady_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005BC6 RID: 23494 RVA: 0x001AA000 File Offset: 0x001A8200
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 142072, RefRangeEnd = 142075, XrefRangeStart = 142072, XrefRangeEnd = 142075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BC7 RID: 23495 RVA: 0x001AA03C File Offset: 0x001A823C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193643, XrefRangeEnd = 193779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BC8 RID: 23496 RVA: 0x001AA078 File Offset: 0x001A8278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193779, XrefRangeEnd = 193790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BC9 RID: 23497 RVA: 0x001AA0C8 File Offset: 0x001A82C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193808, RefRangeEnd = 193809, XrefRangeStart = 193790, XrefRangeEnd = 193808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendUnlocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_SendUnlocked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BCA RID: 23498 RVA: 0x001AA0FC File Offset: 0x001A82FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193809, XrefRangeEnd = 193827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUnlocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_SetUnlocked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BCB RID: 23499 RVA: 0x001AA130 File Offset: 0x001A8330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193827, XrefRangeEnd = 193840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BCC RID: 23500 RVA: 0x001AA16C File Offset: 0x001A836C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193840, XrefRangeEnd = 193857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HourPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_HourPass_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BCD RID: 23501 RVA: 0x001AA1A0 File Offset: 0x001A83A0
		[CallerCount(0)]
		public unsafe void OnTimeSkip(int minsSlept)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minsSlept;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_OnTimeSkip_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BCE RID: 23502 RVA: 0x001AA1E0 File Offset: 0x001A83E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 193883, RefRangeEnd = 193885, XrefRangeStart = 193857, XrefRangeEnd = 193883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MeetAtLocation(NetworkConnection conn, int locationIndex, int expireIn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locationIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expireIn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_MeetAtLocation_Public_Void_NetworkConnection_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BCF RID: 23503 RVA: 0x001AA240 File Offset: 0x001A8440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193885, XrefRangeEnd = 193893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndMeeting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_EndMeeting_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BD0 RID: 23504 RVA: 0x001AA274 File Offset: 0x001A8474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193893, XrefRangeEnd = 193899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SupplierUnlocked(NPCRelationData.EUnlockType type, bool notify)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_SupplierUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BD1 RID: 23505 RVA: 0x001AA2CC File Offset: 0x001A84CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193899, XrefRangeEnd = 193926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RelationshipChange(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_RelationshipChange_Protected_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BD2 RID: 23506 RVA: 0x001AA318 File Offset: 0x001A8518
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 193963, RefRangeEnd = 193965, XrefRangeStart = 193926, XrefRangeEnd = 193963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableDeliveries(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_EnableDeliveries_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BD3 RID: 23507 RVA: 0x001AA35C File Offset: 0x001A855C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193965, XrefRangeEnd = 193971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUnlockMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_SetUnlockMessage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BD4 RID: 23508 RVA: 0x001AA390 File Offset: 0x001A8590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193971, XrefRangeEnd = 194026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CreateMessageConversation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_CreateMessageConversation_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BD5 RID: 23509 RVA: 0x001AA3CC File Offset: 0x001A85CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194026, XrefRangeEnd = 194043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DeaddropRequested()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_DeaddropRequested_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BD6 RID: 23510 RVA: 0x001AA408 File Offset: 0x001A8608
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194165, RefRangeEnd = 194166, XrefRangeStart = 194043, XrefRangeEnd = 194165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DeaddropConfirmed(List<PhoneShopInterface.CartEntry> cart, float totalPrice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cart);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalPrice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_DeaddropConfirmed_Protected_Virtual_New_Void_List_1_CartEntry_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BD7 RID: 23511 RVA: 0x001AA464 File Offset: 0x001A8664
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 194187, RefRangeEnd = 194189, XrefRangeStart = 194166, XrefRangeEnd = 194187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDeaddrop(Il2CppReferenceArray<StringIntPair> items, int minsUntilReady)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minsUntilReady;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_SetDeaddrop_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BD8 RID: 23512 RVA: 0x001AA4B4 File Offset: 0x001A86B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 194211, RefRangeEnd = 194213, XrefRangeStart = 194189, XrefRangeEnd = 194211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeDebt(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_ChangeDebt_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BD9 RID: 23513 RVA: 0x001AA4F4 File Offset: 0x001A86F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194253, RefRangeEnd = 194254, XrefRangeStart = 194213, XrefRangeEnd = 194253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryRecoverDebt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_TryRecoverDebt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BDA RID: 23514 RVA: 0x001AA528 File Offset: 0x001A8728
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194331, RefRangeEnd = 194332, XrefRangeStart = 194254, XrefRangeEnd = 194331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteDeaddrop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_CompleteDeaddrop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BDB RID: 23515 RVA: 0x001AA55C File Offset: 0x001A875C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194332, XrefRangeEnd = 194347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendDebtReminder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_SendDebtReminder_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BDC RID: 23516 RVA: 0x001AA590 File Offset: 0x001A8790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194347, XrefRangeEnd = 194365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MeetupRequested()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_MeetupRequested_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BDD RID: 23517 RVA: 0x001AA5CC File Offset: 0x001A87CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194365, XrefRangeEnd = 194380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PayDebtRequested()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_PayDebtRequested_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BDE RID: 23518 RVA: 0x001AA608 File Offset: 0x001A8808
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194465, RefRangeEnd = 194466, XrefRangeStart = 194380, XrefRangeEnd = 194465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SupplierLocation GetAppropriateLocation(out int locationIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &locationIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_GetAppropriateLocation_Protected_SupplierLocation_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SupplierLocation>(intPtr3) : null;
		}

		// Token: 0x06005BDF RID: 23519 RVA: 0x001AA654 File Offset: 0x001A8854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194466, XrefRangeEnd = 194470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDeadDropValid(SendableMessage message, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_IsDeadDropValid_Private_Boolean_SendableMessage_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005BE0 RID: 23520 RVA: 0x001AA6BC File Offset: 0x001A88BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194470, XrefRangeEnd = 194476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMeetupValid(SendableMessage message, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_IsMeetupValid_Private_Boolean_SendableMessage_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005BE1 RID: 23521 RVA: 0x001AA724 File Offset: 0x001A8924
		[CallerCount(0)]
		public unsafe virtual float GetDeadDropLimit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_GetDeadDropLimit_Public_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005BE2 RID: 23522 RVA: 0x001AA76C File Offset: 0x001A896C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194476, XrefRangeEnd = 194481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005BE3 RID: 23523 RVA: 0x001AA7B0 File Offset: 0x001A89B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194481, XrefRangeEnd = 194508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(NPCData data, string containerPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(containerPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_Load_Public_Virtual_Void_NPCData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BE4 RID: 23524 RVA: 0x001AA810 File Offset: 0x001A8A10
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 194517, RefRangeEnd = 194520, XrefRangeStart = 194508, XrefRangeEnd = 194517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Supplier() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Supplier>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BE5 RID: 23525 RVA: 0x001AA84C File Offset: 0x001A8A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194520, XrefRangeEnd = 194525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005BE6 RID: 23526 RVA: 0x001AA88C File Offset: 0x001A8A8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 194595, RefRangeEnd = 194598, XrefRangeStart = 194525, XrefRangeEnd = 194595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BE7 RID: 23527 RVA: 0x001AA8C8 File Offset: 0x001A8AC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 194599, RefRangeEnd = 194602, XrefRangeStart = 194598, XrefRangeEnd = 194599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BE8 RID: 23528 RVA: 0x001AA904 File Offset: 0x001A8B04
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BE9 RID: 23529 RVA: 0x001AA940 File Offset: 0x001A8B40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193808, RefRangeEnd = 193809, XrefRangeStart = 193808, XrefRangeEnd = 193809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendUnlocked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcWriter___Server_SendUnlocked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BEA RID: 23530 RVA: 0x001AA974 File Offset: 0x001A8B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendUnlocked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcLogic___SendUnlocked_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BEB RID: 23531 RVA: 0x001AA9A8 File Offset: 0x001A8BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194602, XrefRangeEnd = 194612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendUnlocked_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcReader___Server_SendUnlocked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BEC RID: 23532 RVA: 0x001AAA0C File Offset: 0x001A8C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetUnlocked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcWriter___Observers_SetUnlocked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BED RID: 23533 RVA: 0x001AAA40 File Offset: 0x001A8C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194612, XrefRangeEnd = 194613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetUnlocked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcLogic___SetUnlocked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BEE RID: 23534 RVA: 0x001AAA74 File Offset: 0x001A8C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194613, XrefRangeEnd = 194614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetUnlocked_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcReader___Observers_SetUnlocked_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BEF RID: 23535 RVA: 0x001AAAC4 File Offset: 0x001A8CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194614, XrefRangeEnd = 194628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_MeetAtLocation_3470796954(NetworkConnection conn, int locationIndex, int expireIn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locationIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expireIn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcWriter___Observers_MeetAtLocation_3470796954_Private_Void_NetworkConnection_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BF0 RID: 23536 RVA: 0x001AAB24 File Offset: 0x001A8D24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 194675, RefRangeEnd = 194677, XrefRangeStart = 194628, XrefRangeEnd = 194675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___MeetAtLocation_3470796954(NetworkConnection conn, int locationIndex, int expireIn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locationIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expireIn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcLogic___MeetAtLocation_3470796954_Public_Void_NetworkConnection_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BF1 RID: 23537 RVA: 0x001AAB84 File Offset: 0x001A8D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194677, XrefRangeEnd = 194685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_MeetAtLocation_3470796954(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcReader___Observers_MeetAtLocation_3470796954_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BF2 RID: 23538 RVA: 0x001AABD4 File Offset: 0x001A8DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194685, XrefRangeEnd = 194703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_EnableDeliveries_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcWriter___Observers_EnableDeliveries_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BF3 RID: 23539 RVA: 0x001AAC18 File Offset: 0x001A8E18
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 194714, RefRangeEnd = 194717, XrefRangeStart = 194703, XrefRangeEnd = 194714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___EnableDeliveries_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcLogic___EnableDeliveries_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BF4 RID: 23540 RVA: 0x001AAC5C File Offset: 0x001A8E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194717, XrefRangeEnd = 194720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_EnableDeliveries_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcReader___Observers_EnableDeliveries_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BF5 RID: 23541 RVA: 0x001AACAC File Offset: 0x001A8EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194720, XrefRangeEnd = 194738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_EnableDeliveries_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcWriter___Target_EnableDeliveries_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BF6 RID: 23542 RVA: 0x001AACF0 File Offset: 0x001A8EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194738, XrefRangeEnd = 194741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_EnableDeliveries_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcReader___Target_EnableDeliveries_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BF7 RID: 23543 RVA: 0x001AAD40 File Offset: 0x001A8F40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 194187, RefRangeEnd = 194189, XrefRangeStart = 194187, XrefRangeEnd = 194189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetDeaddrop_3971994486(Il2CppReferenceArray<StringIntPair> items, int minsUntilReady)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minsUntilReady;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcWriter___Server_SetDeaddrop_3971994486_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BF8 RID: 23544 RVA: 0x001AAD90 File Offset: 0x001A8F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194741, XrefRangeEnd = 194757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetDeaddrop_3971994486(Il2CppReferenceArray<StringIntPair> items, int minsUntilReady)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minsUntilReady;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcLogic___SetDeaddrop_3971994486_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BF9 RID: 23545 RVA: 0x001AADE0 File Offset: 0x001A8FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194757, XrefRangeEnd = 194775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetDeaddrop_3971994486(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcReader___Server_SetDeaddrop_3971994486_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BFA RID: 23546 RVA: 0x001AAE44 File Offset: 0x001A9044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194775, XrefRangeEnd = 194794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ChangeDebt_431000436(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcWriter___Server_ChangeDebt_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BFB RID: 23547 RVA: 0x001AAE84 File Offset: 0x001A9084
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 194802, RefRangeEnd = 194804, XrefRangeStart = 194794, XrefRangeEnd = 194802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ChangeDebt_431000436(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcLogic___ChangeDebt_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BFC RID: 23548 RVA: 0x001AAEC4 File Offset: 0x001A90C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194804, XrefRangeEnd = 194808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ChangeDebt_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcReader___Server_ChangeDebt_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001BC1 RID: 7105
		// (get) Token: 0x06005BFD RID: 23549 RVA: 0x001AAF28 File Offset: 0x001A9128
		// (set) Token: 0x06005BFE RID: 23550 RVA: 0x001AAF64 File Offset: 0x001A9164
		public unsafe float SyncAccessor_debt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_sync___get_value_debt_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 194816, RefRangeEnd = 194817, XrefRangeStart = 194808, XrefRangeEnd = 194816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_sync___set_value_debt_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005BFF RID: 23551 RVA: 0x001AAFB0 File Offset: 0x001A91B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194817, XrefRangeEnd = 194822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Economy_Supplier(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Supplier_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001BC2 RID: 7106
		// (get) Token: 0x06005C00 RID: 23552 RVA: 0x001AB024 File Offset: 0x001A9224
		// (set) Token: 0x06005C01 RID: 23553 RVA: 0x001AB060 File Offset: 0x001A9260
		public unsafe bool SyncAccessor_deadDropPreparing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_sync___get_value_deadDropPreparing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194822, XrefRangeEnd = 194830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_sync___set_value_deadDropPreparing_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005C02 RID: 23554 RVA: 0x001AB0AC File Offset: 0x001A92AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194830, XrefRangeEnd = 194831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C03 RID: 23555 RVA: 0x0002B46D File Offset: 0x0002966D
		public Supplier(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B9B RID: 7067
		// (get) Token: 0x06005C04 RID: 23556 RVA: 0x001AB0E8 File Offset: 0x001A92E8
		// (set) Token: 0x06005C05 RID: 23557 RVA: 0x0002B476 File Offset: 0x00029676
		public unsafe static float MEETUP_RELATIONSHIP_REQUIREMENT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Supplier.NativeFieldInfoPtr_MEETUP_RELATIONSHIP_REQUIREMENT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Supplier.NativeFieldInfoPtr_MEETUP_RELATIONSHIP_REQUIREMENT, (void*)(&value));
			}
		}

		// Token: 0x17001B9C RID: 7068
		// (get) Token: 0x06005C06 RID: 23558 RVA: 0x001AB104 File Offset: 0x001A9304
		// (set) Token: 0x06005C07 RID: 23559 RVA: 0x0002B484 File Offset: 0x00029684
		public unsafe static int MEETUP_DURATION_MINS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Supplier.NativeFieldInfoPtr_MEETUP_DURATION_MINS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Supplier.NativeFieldInfoPtr_MEETUP_DURATION_MINS, (void*)(&value));
			}
		}

		// Token: 0x17001B9D RID: 7069
		// (get) Token: 0x06005C08 RID: 23560 RVA: 0x001AB120 File Offset: 0x001A9320
		// (set) Token: 0x06005C09 RID: 23561 RVA: 0x0002B492 File Offset: 0x00029692
		public unsafe static int MEETING_COOLDOWN_MINS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Supplier.NativeFieldInfoPtr_MEETING_COOLDOWN_MINS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Supplier.NativeFieldInfoPtr_MEETING_COOLDOWN_MINS, (void*)(&value));
			}
		}

		// Token: 0x17001B9E RID: 7070
		// (get) Token: 0x06005C0A RID: 23562 RVA: 0x001AB13C File Offset: 0x001A933C
		// (set) Token: 0x06005C0B RID: 23563 RVA: 0x0002B4A0 File Offset: 0x000296A0
		public unsafe static int DEADDROP_WAIT_PER_ITEM
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Supplier.NativeFieldInfoPtr_DEADDROP_WAIT_PER_ITEM, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Supplier.NativeFieldInfoPtr_DEADDROP_WAIT_PER_ITEM, (void*)(&value));
			}
		}

		// Token: 0x17001B9F RID: 7071
		// (get) Token: 0x06005C0C RID: 23564 RVA: 0x001AB158 File Offset: 0x001A9358
		// (set) Token: 0x06005C0D RID: 23565 RVA: 0x0002B4AE File Offset: 0x000296AE
		public unsafe static int DEADDROP_MAX_WAIT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Supplier.NativeFieldInfoPtr_DEADDROP_MAX_WAIT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Supplier.NativeFieldInfoPtr_DEADDROP_MAX_WAIT, (void*)(&value));
			}
		}

		// Token: 0x17001BA0 RID: 7072
		// (get) Token: 0x06005C0E RID: 23566 RVA: 0x001AB174 File Offset: 0x001A9374
		// (set) Token: 0x06005C0F RID: 23567 RVA: 0x0002B4BC File Offset: 0x000296BC
		public unsafe static int DEADDROP_ITEM_LIMIT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Supplier.NativeFieldInfoPtr_DEADDROP_ITEM_LIMIT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Supplier.NativeFieldInfoPtr_DEADDROP_ITEM_LIMIT, (void*)(&value));
			}
		}

		// Token: 0x17001BA1 RID: 7073
		// (get) Token: 0x06005C10 RID: 23568 RVA: 0x001AB190 File Offset: 0x001A9390
		// (set) Token: 0x06005C11 RID: 23569 RVA: 0x0002B4CA File Offset: 0x000296CA
		public unsafe static float DELIVERY_RELATIONSHIP_REQUIREMENT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Supplier.NativeFieldInfoPtr_DELIVERY_RELATIONSHIP_REQUIREMENT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Supplier.NativeFieldInfoPtr_DELIVERY_RELATIONSHIP_REQUIREMENT, (void*)(&value));
			}
		}

		// Token: 0x17001BA2 RID: 7074
		// (get) Token: 0x06005C12 RID: 23570 RVA: 0x001AB1AC File Offset: 0x001A93AC
		// (set) Token: 0x06005C13 RID: 23571 RVA: 0x0002B4D8 File Offset: 0x000296D8
		public unsafe static Color32 SupplierLabelColor
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(Supplier.NativeFieldInfoPtr_SupplierLabelColor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Supplier.NativeFieldInfoPtr_SupplierLabelColor, (void*)(&value));
			}
		}

		// Token: 0x17001BA3 RID: 7075
		// (get) Token: 0x06005C14 RID: 23572 RVA: 0x001AB1C8 File Offset: 0x001A93C8
		// (set) Token: 0x06005C15 RID: 23573 RVA: 0x0002B4E6 File Offset: 0x000296E6
		public unsafe Supplier.ESupplierStatus _Status_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__Status_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__Status_k__BackingField)) = value;
			}
		}

		// Token: 0x17001BA4 RID: 7076
		// (get) Token: 0x06005C16 RID: 23574 RVA: 0x001AB1F0 File Offset: 0x001A93F0
		// (set) Token: 0x06005C17 RID: 23575 RVA: 0x0002B501 File Offset: 0x00029701
		public unsafe bool _DeliveriesEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__DeliveriesEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__DeliveriesEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17001BA5 RID: 7077
		// (get) Token: 0x06005C18 RID: 23576 RVA: 0x001AB218 File Offset: 0x001A9418
		// (set) Token: 0x06005C19 RID: 23577 RVA: 0x0002B51C File Offset: 0x0002971C
		public unsafe float MinOrderLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_MinOrderLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_MinOrderLimit)) = value;
			}
		}

		// Token: 0x17001BA6 RID: 7078
		// (get) Token: 0x06005C1A RID: 23578 RVA: 0x001AB240 File Offset: 0x001A9440
		// (set) Token: 0x06005C1B RID: 23579 RVA: 0x0002B537 File Offset: 0x00029737
		public unsafe float MaxOrderLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_MaxOrderLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_MaxOrderLimit)) = value;
			}
		}

		// Token: 0x17001BA7 RID: 7079
		// (get) Token: 0x06005C1C RID: 23580 RVA: 0x001AB268 File Offset: 0x001A9468
		// (set) Token: 0x06005C1D RID: 23581 RVA: 0x0002B552 File Offset: 0x00029752
		public unsafe Il2CppReferenceArray<PhoneShopInterface.Listing> OnlineShopItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_OnlineShopItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PhoneShopInterface.Listing>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_OnlineShopItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BA8 RID: 7080
		// (get) Token: 0x06005C1E RID: 23582 RVA: 0x001AB298 File Offset: 0x001A9498
		// (set) Token: 0x06005C1F RID: 23583 RVA: 0x0002B571 File Offset: 0x00029771
		public unsafe string SupplierRecommendMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_SupplierRecommendMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_SupplierRecommendMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001BA9 RID: 7081
		// (get) Token: 0x06005C20 RID: 23584 RVA: 0x001AB2C0 File Offset: 0x001A94C0
		// (set) Token: 0x06005C21 RID: 23585 RVA: 0x0002B590 File Offset: 0x00029790
		public unsafe string SupplierUnlockHint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_SupplierUnlockHint);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_SupplierUnlockHint), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001BAA RID: 7082
		// (get) Token: 0x06005C22 RID: 23586 RVA: 0x001AB2E8 File Offset: 0x001A94E8
		// (set) Token: 0x06005C23 RID: 23587 RVA: 0x0002B5AF File Offset: 0x000297AF
		public unsafe ShopInterface Shop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_Shop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_Shop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BAB RID: 7083
		// (get) Token: 0x06005C24 RID: 23588 RVA: 0x001AB318 File Offset: 0x001A9518
		// (set) Token: 0x06005C25 RID: 23589 RVA: 0x0002B5CE File Offset: 0x000297CE
		public unsafe SupplierStash Stash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_Stash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SupplierStash>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_Stash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BAC RID: 7084
		// (get) Token: 0x06005C26 RID: 23590 RVA: 0x001AB348 File Offset: 0x001A9548
		// (set) Token: 0x06005C27 RID: 23591 RVA: 0x0002B5ED File Offset: 0x000297ED
		public unsafe UnityEvent onDeaddropReady
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_onDeaddropReady);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_onDeaddropReady), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BAD RID: 7085
		// (get) Token: 0x06005C28 RID: 23592 RVA: 0x001AB378 File Offset: 0x001A9578
		// (set) Token: 0x06005C29 RID: 23593 RVA: 0x0002B60C File Offset: 0x0002980C
		public unsafe int minsSinceMeetingStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_minsSinceMeetingStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_minsSinceMeetingStart)) = value;
			}
		}

		// Token: 0x17001BAE RID: 7086
		// (get) Token: 0x06005C2A RID: 23594 RVA: 0x001AB3A0 File Offset: 0x001A95A0
		// (set) Token: 0x06005C2B RID: 23595 RVA: 0x0002B627 File Offset: 0x00029827
		public unsafe int minsSinceLastMeetingEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_minsSinceLastMeetingEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_minsSinceLastMeetingEnd)) = value;
			}
		}

		// Token: 0x17001BAF RID: 7087
		// (get) Token: 0x06005C2C RID: 23596 RVA: 0x001AB3C8 File Offset: 0x001A95C8
		// (set) Token: 0x06005C2D RID: 23597 RVA: 0x0002B642 File Offset: 0x00029842
		public unsafe SupplierLocation currentLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_currentLocation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SupplierLocation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_currentLocation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BB0 RID: 7088
		// (get) Token: 0x06005C2E RID: 23598 RVA: 0x001AB3F8 File Offset: 0x001A95F8
		// (set) Token: 0x06005C2F RID: 23599 RVA: 0x0002B661 File Offset: 0x00029861
		public unsafe DialogueController dialogueController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_dialogueController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_dialogueController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BB1 RID: 7089
		// (get) Token: 0x06005C30 RID: 23600 RVA: 0x001AB428 File Offset: 0x001A9628
		// (set) Token: 0x06005C31 RID: 23601 RVA: 0x0002B680 File Offset: 0x00029880
		public unsafe DialogueController.GreetingOverride meetingGreeting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_meetingGreeting);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.GreetingOverride>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_meetingGreeting), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BB2 RID: 7090
		// (get) Token: 0x06005C32 RID: 23602 RVA: 0x001AB458 File Offset: 0x001A9658
		// (set) Token: 0x06005C33 RID: 23603 RVA: 0x0002B69F File Offset: 0x0002989F
		public unsafe DialogueController.DialogueChoice meetingChoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_meetingChoice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_meetingChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BB3 RID: 7091
		// (get) Token: 0x06005C34 RID: 23604 RVA: 0x001AB488 File Offset: 0x001A9688
		// (set) Token: 0x06005C35 RID: 23605 RVA: 0x0002B6BE File Offset: 0x000298BE
		public unsafe float debt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_debt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_debt)) = value;
			}
		}

		// Token: 0x17001BB4 RID: 7092
		// (get) Token: 0x06005C36 RID: 23606 RVA: 0x001AB4B0 File Offset: 0x001A96B0
		// (set) Token: 0x06005C37 RID: 23607 RVA: 0x0002B6D9 File Offset: 0x000298D9
		public unsafe bool deadDropPreparing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_deadDropPreparing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_deadDropPreparing)) = value;
			}
		}

		// Token: 0x17001BB5 RID: 7093
		// (get) Token: 0x06005C38 RID: 23608 RVA: 0x001AB4D8 File Offset: 0x001A96D8
		// (set) Token: 0x06005C39 RID: 23609 RVA: 0x0002B6F4 File Offset: 0x000298F4
		public unsafe int _minsUntilDeaddropReady_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__minsUntilDeaddropReady_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__minsUntilDeaddropReady_k__BackingField)) = value;
			}
		}

		// Token: 0x17001BB6 RID: 7094
		// (get) Token: 0x06005C3A RID: 23610 RVA: 0x001AB500 File Offset: 0x001A9700
		// (set) Token: 0x06005C3B RID: 23611 RVA: 0x0002B70F File Offset: 0x0002990F
		public unsafe Il2CppReferenceArray<StringIntPair> deaddropItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_deaddropItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StringIntPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_deaddropItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BB7 RID: 7095
		// (get) Token: 0x06005C3C RID: 23612 RVA: 0x001AB530 File Offset: 0x001A9730
		// (set) Token: 0x06005C3D RID: 23613 RVA: 0x0002B72E File Offset: 0x0002992E
		public unsafe int minsSinceDeaddropOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_minsSinceDeaddropOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_minsSinceDeaddropOrder)) = value;
			}
		}

		// Token: 0x17001BB8 RID: 7096
		// (get) Token: 0x06005C3E RID: 23614 RVA: 0x001AB558 File Offset: 0x001A9758
		// (set) Token: 0x06005C3F RID: 23615 RVA: 0x0002B749 File Offset: 0x00029949
		public unsafe bool repaymentReminderSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_repaymentReminderSent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_repaymentReminderSent)) = value;
			}
		}

		// Token: 0x17001BB9 RID: 7097
		// (get) Token: 0x06005C40 RID: 23616 RVA: 0x001AB580 File Offset: 0x001A9780
		// (set) Token: 0x06005C41 RID: 23617 RVA: 0x0002B764 File Offset: 0x00029964
		public unsafe SyncVar<float> syncVar___debt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_syncVar___debt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_syncVar___debt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BBA RID: 7098
		// (get) Token: 0x06005C42 RID: 23618 RVA: 0x001AB5B0 File Offset: 0x001A97B0
		// (set) Token: 0x06005C43 RID: 23619 RVA: 0x0002B783 File Offset: 0x00029983
		public unsafe SyncVar<bool> syncVar___deadDropPreparing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_syncVar___deadDropPreparing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_syncVar___deadDropPreparing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BBB RID: 7099
		// (get) Token: 0x06005C44 RID: 23620 RVA: 0x001AB5E0 File Offset: 0x001A97E0
		// (set) Token: 0x06005C45 RID: 23621 RVA: 0x0002B7A2 File Offset: 0x000299A2
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001BBC RID: 7100
		// (get) Token: 0x06005C46 RID: 23622 RVA: 0x001AB608 File Offset: 0x001A9808
		// (set) Token: 0x06005C47 RID: 23623 RVA: 0x0002B7BD File Offset: 0x000299BD
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003EBD RID: 16061
		private static readonly IntPtr NativeFieldInfoPtr_MEETUP_RELATIONSHIP_REQUIREMENT;

		// Token: 0x04003EBE RID: 16062
		private static readonly IntPtr NativeFieldInfoPtr_MEETUP_DURATION_MINS;

		// Token: 0x04003EBF RID: 16063
		private static readonly IntPtr NativeFieldInfoPtr_MEETING_COOLDOWN_MINS;

		// Token: 0x04003EC0 RID: 16064
		private static readonly IntPtr NativeFieldInfoPtr_DEADDROP_WAIT_PER_ITEM;

		// Token: 0x04003EC1 RID: 16065
		private static readonly IntPtr NativeFieldInfoPtr_DEADDROP_MAX_WAIT;

		// Token: 0x04003EC2 RID: 16066
		private static readonly IntPtr NativeFieldInfoPtr_DEADDROP_ITEM_LIMIT;

		// Token: 0x04003EC3 RID: 16067
		private static readonly IntPtr NativeFieldInfoPtr_DELIVERY_RELATIONSHIP_REQUIREMENT;

		// Token: 0x04003EC4 RID: 16068
		private static readonly IntPtr NativeFieldInfoPtr_SupplierLabelColor;

		// Token: 0x04003EC5 RID: 16069
		private static readonly IntPtr NativeFieldInfoPtr__Status_k__BackingField;

		// Token: 0x04003EC6 RID: 16070
		private static readonly IntPtr NativeFieldInfoPtr__DeliveriesEnabled_k__BackingField;

		// Token: 0x04003EC7 RID: 16071
		private static readonly IntPtr NativeFieldInfoPtr_MinOrderLimit;

		// Token: 0x04003EC8 RID: 16072
		private static readonly IntPtr NativeFieldInfoPtr_MaxOrderLimit;

		// Token: 0x04003EC9 RID: 16073
		private static readonly IntPtr NativeFieldInfoPtr_OnlineShopItems;

		// Token: 0x04003ECA RID: 16074
		private static readonly IntPtr NativeFieldInfoPtr_SupplierRecommendMessage;

		// Token: 0x04003ECB RID: 16075
		private static readonly IntPtr NativeFieldInfoPtr_SupplierUnlockHint;

		// Token: 0x04003ECC RID: 16076
		private static readonly IntPtr NativeFieldInfoPtr_Shop;

		// Token: 0x04003ECD RID: 16077
		private static readonly IntPtr NativeFieldInfoPtr_Stash;

		// Token: 0x04003ECE RID: 16078
		private static readonly IntPtr NativeFieldInfoPtr_onDeaddropReady;

		// Token: 0x04003ECF RID: 16079
		private static readonly IntPtr NativeFieldInfoPtr_minsSinceMeetingStart;

		// Token: 0x04003ED0 RID: 16080
		private static readonly IntPtr NativeFieldInfoPtr_minsSinceLastMeetingEnd;

		// Token: 0x04003ED1 RID: 16081
		private static readonly IntPtr NativeFieldInfoPtr_currentLocation;

		// Token: 0x04003ED2 RID: 16082
		private static readonly IntPtr NativeFieldInfoPtr_dialogueController;

		// Token: 0x04003ED3 RID: 16083
		private static readonly IntPtr NativeFieldInfoPtr_meetingGreeting;

		// Token: 0x04003ED4 RID: 16084
		private static readonly IntPtr NativeFieldInfoPtr_meetingChoice;

		// Token: 0x04003ED5 RID: 16085
		private static readonly IntPtr NativeFieldInfoPtr_debt;

		// Token: 0x04003ED6 RID: 16086
		private static readonly IntPtr NativeFieldInfoPtr_deadDropPreparing;

		// Token: 0x04003ED7 RID: 16087
		private static readonly IntPtr NativeFieldInfoPtr__minsUntilDeaddropReady_k__BackingField;

		// Token: 0x04003ED8 RID: 16088
		private static readonly IntPtr NativeFieldInfoPtr_deaddropItems;

		// Token: 0x04003ED9 RID: 16089
		private static readonly IntPtr NativeFieldInfoPtr_minsSinceDeaddropOrder;

		// Token: 0x04003EDA RID: 16090
		private static readonly IntPtr NativeFieldInfoPtr_repaymentReminderSent;

		// Token: 0x04003EDB RID: 16091
		private static readonly IntPtr NativeFieldInfoPtr_syncVar___debt;

		// Token: 0x04003EDC RID: 16092
		private static readonly IntPtr NativeFieldInfoPtr_syncVar___deadDropPreparing;

		// Token: 0x04003EDD RID: 16093
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003EDE RID: 16094
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003EDF RID: 16095
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_get_ESupplierStatus_0;

		// Token: 0x04003EE0 RID: 16096
		private static readonly IntPtr NativeMethodInfoPtr_set_Status_Private_set_Void_ESupplierStatus_0;

		// Token: 0x04003EE1 RID: 16097
		private static readonly IntPtr NativeMethodInfoPtr_get_DeliveriesEnabled_Public_get_Boolean_0;

		// Token: 0x04003EE2 RID: 16098
		private static readonly IntPtr NativeMethodInfoPtr_set_DeliveriesEnabled_Private_set_Void_Boolean_0;

		// Token: 0x04003EE3 RID: 16099
		private static readonly IntPtr NativeMethodInfoPtr_get_Debt_Public_get_Single_0;

		// Token: 0x04003EE4 RID: 16100
		private static readonly IntPtr NativeMethodInfoPtr_get_minsUntilDeaddropReady_Public_get_Int32_0;

		// Token: 0x04003EE5 RID: 16101
		private static readonly IntPtr NativeMethodInfoPtr_set_minsUntilDeaddropReady_Private_set_Void_Int32_0;

		// Token: 0x04003EE6 RID: 16102
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04003EE7 RID: 16103
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x04003EE8 RID: 16104
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003EE9 RID: 16105
		private static readonly IntPtr NativeMethodInfoPtr_SendUnlocked_Public_Void_0;

		// Token: 0x04003EEA RID: 16106
		private static readonly IntPtr NativeMethodInfoPtr_SetUnlocked_Private_Void_0;

		// Token: 0x04003EEB RID: 16107
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_1;

		// Token: 0x04003EEC RID: 16108
		private static readonly IntPtr NativeMethodInfoPtr_HourPass_Protected_Void_0;

		// Token: 0x04003EED RID: 16109
		private static readonly IntPtr NativeMethodInfoPtr_OnTimeSkip_Private_Void_Int32_0;

		// Token: 0x04003EEE RID: 16110
		private static readonly IntPtr NativeMethodInfoPtr_MeetAtLocation_Public_Void_NetworkConnection_Int32_Int32_0;

		// Token: 0x04003EEF RID: 16111
		private static readonly IntPtr NativeMethodInfoPtr_EndMeeting_Public_Void_0;

		// Token: 0x04003EF0 RID: 16112
		private static readonly IntPtr NativeMethodInfoPtr_SupplierUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0;

		// Token: 0x04003EF1 RID: 16113
		private static readonly IntPtr NativeMethodInfoPtr_RelationshipChange_Protected_Virtual_New_Void_Single_0;

		// Token: 0x04003EF2 RID: 16114
		private static readonly IntPtr NativeMethodInfoPtr_EnableDeliveries_Private_Void_NetworkConnection_0;

		// Token: 0x04003EF3 RID: 16115
		private static readonly IntPtr NativeMethodInfoPtr_SetUnlockMessage_Public_Void_0;

		// Token: 0x04003EF4 RID: 16116
		private static readonly IntPtr NativeMethodInfoPtr_CreateMessageConversation_Protected_Virtual_Void_1;

		// Token: 0x04003EF5 RID: 16117
		private static readonly IntPtr NativeMethodInfoPtr_DeaddropRequested_Protected_Virtual_New_Void_0;

		// Token: 0x04003EF6 RID: 16118
		private static readonly IntPtr NativeMethodInfoPtr_DeaddropConfirmed_Protected_Virtual_New_Void_List_1_CartEntry_Single_0;

		// Token: 0x04003EF7 RID: 16119
		private static readonly IntPtr NativeMethodInfoPtr_SetDeaddrop_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0;

		// Token: 0x04003EF8 RID: 16120
		private static readonly IntPtr NativeMethodInfoPtr_ChangeDebt_Private_Void_Single_0;

		// Token: 0x04003EF9 RID: 16121
		private static readonly IntPtr NativeMethodInfoPtr_TryRecoverDebt_Private_Void_0;

		// Token: 0x04003EFA RID: 16122
		private static readonly IntPtr NativeMethodInfoPtr_CompleteDeaddrop_Private_Void_0;

		// Token: 0x04003EFB RID: 16123
		private static readonly IntPtr NativeMethodInfoPtr_SendDebtReminder_Private_Void_0;

		// Token: 0x04003EFC RID: 16124
		private static readonly IntPtr NativeMethodInfoPtr_MeetupRequested_Protected_Virtual_New_Void_0;

		// Token: 0x04003EFD RID: 16125
		private static readonly IntPtr NativeMethodInfoPtr_PayDebtRequested_Protected_Virtual_New_Void_0;

		// Token: 0x04003EFE RID: 16126
		private static readonly IntPtr NativeMethodInfoPtr_GetAppropriateLocation_Protected_SupplierLocation_byref_Int32_0;

		// Token: 0x04003EFF RID: 16127
		private static readonly IntPtr NativeMethodInfoPtr_IsDeadDropValid_Private_Boolean_SendableMessage_byref_String_0;

		// Token: 0x04003F00 RID: 16128
		private static readonly IntPtr NativeMethodInfoPtr_IsMeetupValid_Private_Boolean_SendableMessage_byref_String_0;

		// Token: 0x04003F01 RID: 16129
		private static readonly IntPtr NativeMethodInfoPtr_GetDeadDropLimit_Public_Virtual_New_Single_0;

		// Token: 0x04003F02 RID: 16130
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04003F03 RID: 16131
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_NPCData_String_0;

		// Token: 0x04003F04 RID: 16132
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003F05 RID: 16133
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04003F06 RID: 16134
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003F07 RID: 16135
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003F08 RID: 16136
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003F09 RID: 16137
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendUnlocked_2166136261_Private_Void_0;

		// Token: 0x04003F0A RID: 16138
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendUnlocked_2166136261_Public_Void_0;

		// Token: 0x04003F0B RID: 16139
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendUnlocked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003F0C RID: 16140
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetUnlocked_2166136261_Private_Void_0;

		// Token: 0x04003F0D RID: 16141
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetUnlocked_2166136261_Private_Void_0;

		// Token: 0x04003F0E RID: 16142
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetUnlocked_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003F0F RID: 16143
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_MeetAtLocation_3470796954_Private_Void_NetworkConnection_Int32_Int32_0;

		// Token: 0x04003F10 RID: 16144
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___MeetAtLocation_3470796954_Public_Void_NetworkConnection_Int32_Int32_0;

		// Token: 0x04003F11 RID: 16145
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_MeetAtLocation_3470796954_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003F12 RID: 16146
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_EnableDeliveries_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04003F13 RID: 16147
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___EnableDeliveries_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04003F14 RID: 16148
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_EnableDeliveries_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003F15 RID: 16149
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_EnableDeliveries_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04003F16 RID: 16150
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_EnableDeliveries_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003F17 RID: 16151
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetDeaddrop_3971994486_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0;

		// Token: 0x04003F18 RID: 16152
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetDeaddrop_3971994486_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0;

		// Token: 0x04003F19 RID: 16153
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetDeaddrop_3971994486_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003F1A RID: 16154
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ChangeDebt_431000436_Private_Void_Single_0;

		// Token: 0x04003F1B RID: 16155
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ChangeDebt_431000436_Private_Void_Single_0;

		// Token: 0x04003F1C RID: 16156
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ChangeDebt_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003F1D RID: 16157
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value_debt_Public_get_Single_0;

		// Token: 0x04003F1E RID: 16158
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value_debt_Public_set_Void_Single_Boolean_0;

		// Token: 0x04003F1F RID: 16159
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Supplier_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04003F20 RID: 16160
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value_deadDropPreparing_Public_get_Boolean_0;

		// Token: 0x04003F21 RID: 16161
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value_deadDropPreparing_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x04003F22 RID: 16162
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x020009EC RID: 2540
		[OriginalName("Assembly-CSharp.dll", "", "ESupplierStatus")]
		public enum ESupplierStatus
		{
			// Token: 0x04008AE3 RID: 35555
			Idle,
			// Token: 0x04008AE4 RID: 35556
			PreppingDeadDrop,
			// Token: 0x04008AE5 RID: 35557
			Meeting
		}

		// Token: 0x020009ED RID: 2541
		[ObfuscatedName("ScheduleOne.Economy.Supplier+<<EnableDeliveries>g__Wait|54_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600CD9D RID: 52637 RVA: 0x00318410 File Offset: 0x00316610
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique()
			{
				Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "<<EnableDeliveries>g__Wait|54_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique>.NativeClassPtr);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique>.NativeClassPtr, "<>1__state");
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique>.NativeClassPtr, "<>2__current");
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique>.NativeClassPtr, "<>4__this");
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique>.NativeClassPtr, 100675060);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique>.NativeClassPtr, 100675061);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique>.NativeClassPtr, 100675062);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique>.NativeClassPtr, 100675063);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique>.NativeClassPtr, 100675064);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique>.NativeClassPtr, 100675065);
			}

			// Token: 0x0600CD9E RID: 52638 RVA: 0x003184F0 File Offset: 0x003166F0
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD9F RID: 52639 RVA: 0x00318538 File Offset: 0x00316738
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CDA0 RID: 52640 RVA: 0x0031856C File Offset: 0x0031676C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193612, XrefRangeEnd = 193633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004001 RID: 16385
			// (get) Token: 0x0600CDA1 RID: 52641 RVA: 0x003185A8 File Offset: 0x003167A8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CDA2 RID: 52642 RVA: 0x003185E8 File Offset: 0x003167E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193633, XrefRangeEnd = 193638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004002 RID: 16386
			// (get) Token: 0x0600CDA3 RID: 52643 RVA: 0x0031861C File Offset: 0x0031681C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CDA4 RID: 52644 RVA: 0x00063FE7 File Offset: 0x000621E7
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FFE RID: 16382
			// (get) Token: 0x0600CDA5 RID: 52645 RVA: 0x0031865C File Offset: 0x0031685C
			// (set) Token: 0x0600CDA6 RID: 52646 RVA: 0x00063FF0 File Offset: 0x000621F0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003FFF RID: 16383
			// (get) Token: 0x0600CDA7 RID: 52647 RVA: 0x00318684 File Offset: 0x00316884
			// (set) Token: 0x0600CDA8 RID: 52648 RVA: 0x0006400B File Offset: 0x0006220B
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004000 RID: 16384
			// (get) Token: 0x0600CDA9 RID: 52649 RVA: 0x003186B4 File Offset: 0x003168B4
			// (set) Token: 0x0600CDAA RID: 52650 RVA: 0x0006402A File Offset: 0x0006222A
			public unsafe Supplier __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008AE6 RID: 35558
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008AE7 RID: 35559
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008AE8 RID: 35560
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008AE9 RID: 35561
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008AEA RID: 35562
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008AEB RID: 35563
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008AEC RID: 35564
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008AED RID: 35565
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008AEE RID: 35566
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020009EE RID: 2542
		[ObfuscatedName("ScheduleOne.Economy.Supplier+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CDAB RID: 52651 RVA: 0x003186E4 File Offset: 0x003168E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr);
				Supplier.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr, "<>9");
				Supplier.__c.NativeFieldInfoPtr___9__54_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr, "<>9__54_1");
				Supplier.__c.NativeFieldInfoPtr___9__58_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr, "<>9__58_0");
				Supplier.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr, 100675067);
				Supplier.__c.NativeMethodInfoPtr__EnableDeliveries_b__54_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr, 100675068);
				Supplier.__c.NativeMethodInfoPtr__DeaddropConfirmed_b__58_0_Internal_Int32_CartEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr, 100675069);
			}

			// Token: 0x0600CDAC RID: 52652 RVA: 0x00318788 File Offset: 0x00316988
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CDAD RID: 52653 RVA: 0x003187C4 File Offset: 0x003169C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193638, XrefRangeEnd = 193641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _EnableDeliveries_b__54_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.__c.NativeMethodInfoPtr__EnableDeliveries_b__54_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CDAE RID: 52654 RVA: 0x00318800 File Offset: 0x00316A00
			[CallerCount(0)]
			public unsafe int _DeaddropConfirmed_b__58_0(PhoneShopInterface.CartEntry x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.__c.NativeMethodInfoPtr__DeaddropConfirmed_b__58_0_Internal_Int32_CartEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CDAF RID: 52655 RVA: 0x00064049 File Offset: 0x00062249
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004003 RID: 16387
			// (get) Token: 0x0600CDB0 RID: 52656 RVA: 0x00318850 File Offset: 0x00316A50
			// (set) Token: 0x0600CDB1 RID: 52657 RVA: 0x00064052 File Offset: 0x00062252
			public unsafe static Supplier.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Supplier.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Supplier.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004004 RID: 16388
			// (get) Token: 0x0600CDB2 RID: 52658 RVA: 0x00318878 File Offset: 0x00316A78
			// (set) Token: 0x0600CDB3 RID: 52659 RVA: 0x00064064 File Offset: 0x00062264
			public unsafe static Func<bool> __9__54_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Supplier.__c.NativeFieldInfoPtr___9__54_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Supplier.__c.NativeFieldInfoPtr___9__54_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004005 RID: 16389
			// (get) Token: 0x0600CDB4 RID: 52660 RVA: 0x003188A0 File Offset: 0x00316AA0
			// (set) Token: 0x0600CDB5 RID: 52661 RVA: 0x00064076 File Offset: 0x00062276
			public unsafe static Func<PhoneShopInterface.CartEntry, int> __9__58_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Supplier.__c.NativeFieldInfoPtr___9__58_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PhoneShopInterface.CartEntry, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Supplier.__c.NativeFieldInfoPtr___9__58_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008AEF RID: 35567
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008AF0 RID: 35568
			private static readonly IntPtr NativeFieldInfoPtr___9__54_1;

			// Token: 0x04008AF1 RID: 35569
			private static readonly IntPtr NativeFieldInfoPtr___9__58_0;

			// Token: 0x04008AF2 RID: 35570
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008AF3 RID: 35571
			private static readonly IntPtr NativeMethodInfoPtr__EnableDeliveries_b__54_1_Internal_Boolean_0;

			// Token: 0x04008AF4 RID: 35572
			private static readonly IntPtr NativeMethodInfoPtr__DeaddropConfirmed_b__58_0_Internal_Int32_CartEntry_0;
		}

		// Token: 0x020009EF RID: 2543
		[ObfuscatedName("ScheduleOne.Economy.Supplier+<>c__DisplayClass43_0")]
		public sealed class __c__DisplayClass43_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CDB6 RID: 52662 RVA: 0x003188C8 File Offset: 0x00316AC8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass43_0()
			{
				Il2CppClassPointerStore<Supplier.__c__DisplayClass43_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "<>c__DisplayClass43_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Supplier.__c__DisplayClass43_0>.NativeClassPtr);
				Supplier.__c__DisplayClass43_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.__c__DisplayClass43_0>.NativeClassPtr, "<>4__this");
				Supplier.__c__DisplayClass43_0.NativeFieldInfoPtr_orderCompleteDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.__c__DisplayClass43_0>.NativeClassPtr, "orderCompleteDialogue");
				Supplier.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.__c__DisplayClass43_0>.NativeClassPtr, 100675070);
				Supplier.__c__DisplayClass43_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.__c__DisplayClass43_0>.NativeClassPtr, 100675071);
				Supplier.__c__DisplayClass43_0.NativeMethodInfoPtr__Start_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.__c__DisplayClass43_0>.NativeClassPtr, 100675072);
			}

			// Token: 0x0600CDB7 RID: 52663 RVA: 0x00318958 File Offset: 0x00316B58
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass43_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Supplier.__c__DisplayClass43_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CDB8 RID: 52664 RVA: 0x00318994 File Offset: 0x00316B94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193641, XrefRangeEnd = 193642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.__c__DisplayClass43_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CDB9 RID: 52665 RVA: 0x003189C8 File Offset: 0x00316BC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193642, XrefRangeEnd = 193643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.__c__DisplayClass43_0.NativeMethodInfoPtr__Start_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CDBA RID: 52666 RVA: 0x00064088 File Offset: 0x00062288
			public __c__DisplayClass43_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004006 RID: 16390
			// (get) Token: 0x0600CDBB RID: 52667 RVA: 0x003189FC File Offset: 0x00316BFC
			// (set) Token: 0x0600CDBC RID: 52668 RVA: 0x00064091 File Offset: 0x00062291
			public unsafe Supplier __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.__c__DisplayClass43_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.__c__DisplayClass43_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004007 RID: 16391
			// (get) Token: 0x0600CDBD RID: 52669 RVA: 0x00318A2C File Offset: 0x00316C2C
			// (set) Token: 0x0600CDBE RID: 52670 RVA: 0x000640B0 File Offset: 0x000622B0
			public unsafe string orderCompleteDialogue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.__c__DisplayClass43_0.NativeFieldInfoPtr_orderCompleteDialogue);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.__c__DisplayClass43_0.NativeFieldInfoPtr_orderCompleteDialogue), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008AF5 RID: 35573
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008AF6 RID: 35574
			private static readonly IntPtr NativeFieldInfoPtr_orderCompleteDialogue;

			// Token: 0x04008AF7 RID: 35575
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008AF8 RID: 35576
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;

			// Token: 0x04008AF9 RID: 35577
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_Internal_Void_0;
		}
	}
}
