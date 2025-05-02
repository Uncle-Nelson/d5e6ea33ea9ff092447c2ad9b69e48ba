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
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.NPCs.Relation;
using Il2CppScheduleOne.NPCs.Schedules;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Quests;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x02000412 RID: 1042
	public class Dealer : NPC
	{
		// Token: 0x06005A79 RID: 23161 RVA: 0x001A4710 File Offset: 0x001A2910
		// Note: this type is marked as 'beforefieldinit'.
		static Dealer()
		{
			Il2CppClassPointerStore<Dealer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "Dealer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dealer>.NativeClassPtr);
			Dealer.NativeFieldInfoPtr_MAX_CUSTOMERS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "MAX_CUSTOMERS");
			Dealer.NativeFieldInfoPtr_DEAL_ARRIVAL_DELAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "DEAL_ARRIVAL_DELAY");
			Dealer.NativeFieldInfoPtr_MIN_TRAVEL_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "MIN_TRAVEL_TIME");
			Dealer.NativeFieldInfoPtr_MAX_TRAVEL_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "MAX_TRAVEL_TIME");
			Dealer.NativeFieldInfoPtr_OVERFLOW_SLOT_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "OVERFLOW_SLOT_COUNT");
			Dealer.NativeFieldInfoPtr_CASH_REMINDER_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "CASH_REMINDER_THRESHOLD");
			Dealer.NativeFieldInfoPtr_RELATIONSHIP_CHANGE_PER_DEAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "RELATIONSHIP_CHANGE_PER_DEAL");
			Dealer.NativeFieldInfoPtr_onDealerRecruited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "onDealerRecruited");
			Dealer.NativeFieldInfoPtr_DealerLabelColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "DealerLabelColor");
			Dealer.NativeFieldInfoPtr_AllDealers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "AllDealers");
			Dealer.NativeFieldInfoPtr__IsRecruited_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<IsRecruited>k__BackingField");
			Dealer.NativeFieldInfoPtr__ItemSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<ItemSlots>k__BackingField");
			Dealer.NativeFieldInfoPtr_InitialCustomers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "InitialCustomers");
			Dealer.NativeFieldInfoPtr_InitialItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "InitialItems");
			Dealer.NativeFieldInfoPtr_Home = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "Home");
			Dealer.NativeFieldInfoPtr_DealSignal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "DealSignal");
			Dealer.NativeFieldInfoPtr_HomeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "HomeEvent");
			Dealer.NativeFieldInfoPtr_DialogueController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "DialogueController");
			Dealer.NativeFieldInfoPtr_RecruitDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "RecruitDialogue");
			Dealer.NativeFieldInfoPtr_CollectCashDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "CollectCashDialogue");
			Dealer.NativeFieldInfoPtr_AssignCustomersDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "AssignCustomersDialogue");
			Dealer.NativeFieldInfoPtr_HomeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "HomeName");
			Dealer.NativeFieldInfoPtr_SigningFee = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "SigningFee");
			Dealer.NativeFieldInfoPtr_Cut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "Cut");
			Dealer.NativeFieldInfoPtr_SellInsufficientQualityItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "SellInsufficientQualityItems");
			Dealer.NativeFieldInfoPtr_SellExcessQualityItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "SellExcessQualityItems");
			Dealer.NativeFieldInfoPtr_CompletedDealsVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "CompletedDealsVariable");
			Dealer.NativeFieldInfoPtr__Cash_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<Cash>k__BackingField");
			Dealer.NativeFieldInfoPtr_AssignedCustomers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "AssignedCustomers");
			Dealer.NativeFieldInfoPtr_ActiveContracts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "ActiveContracts");
			Dealer.NativeFieldInfoPtr__HasBeenRecommended_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<HasBeenRecommended>k__BackingField");
			Dealer.NativeFieldInfoPtr_onRecommended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "onRecommended");
			Dealer.NativeFieldInfoPtr_OverflowSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "OverflowSlots");
			Dealer.NativeFieldInfoPtr_currentContract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "currentContract");
			Dealer.NativeFieldInfoPtr_recruitChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "recruitChoice");
			Dealer.NativeFieldInfoPtr_collectCashChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "collectCashChoice");
			Dealer.NativeFieldInfoPtr_assignCustomersChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "assignCustomersChoice");
			Dealer.NativeFieldInfoPtr__potentialDealerPoI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<potentialDealerPoI>k__BackingField");
			Dealer.NativeFieldInfoPtr__dealerPoI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<dealerPoI>k__BackingField");
			Dealer.NativeFieldInfoPtr_acceptedContractGUIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "acceptedContractGUIDs");
			Dealer.NativeFieldInfoPtr_itemCountOnTradeStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "itemCountOnTradeStart");
			Dealer.NativeFieldInfoPtr_syncVar____Cash_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "syncVar___<Cash>k__BackingField");
			Dealer.NativeFieldInfoPtr_syncVar___acceptedContractGUIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "syncVar___acceptedContractGUIDs");
			Dealer.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Economy.DealerAssembly-CSharp.dll_Excuted");
			Dealer.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Economy.DealerAssembly-CSharp.dll_Excuted");
			Dealer.NativeMethodInfoPtr_get_IsRecruited_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674813);
			Dealer.NativeMethodInfoPtr_set_IsRecruited_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674814);
			Dealer.NativeMethodInfoPtr_get_ItemSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674815);
			Dealer.NativeMethodInfoPtr_set_ItemSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674816);
			Dealer.NativeMethodInfoPtr_get_Cash_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674817);
			Dealer.NativeMethodInfoPtr_set_Cash_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674818);
			Dealer.NativeMethodInfoPtr_get_HasBeenRecommended_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674819);
			Dealer.NativeMethodInfoPtr_set_HasBeenRecommended_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674820);
			Dealer.NativeMethodInfoPtr_get_potentialDealerPoI_Public_get_NPCPoI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674821);
			Dealer.NativeMethodInfoPtr_set_potentialDealerPoI_Protected_set_Void_NPCPoI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674822);
			Dealer.NativeMethodInfoPtr_get_dealerPoI_Public_get_NPCPoI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674823);
			Dealer.NativeMethodInfoPtr_set_dealerPoI_Protected_set_Void_NPCPoI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674824);
			Dealer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674825);
			Dealer.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674826);
			Dealer.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674827);
			Dealer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674828);
			Dealer.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674829);
			Dealer.NativeMethodInfoPtr_SetupPoI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674830);
			Dealer.NativeMethodInfoPtr_SetUpDialogue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674831);
			Dealer.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674832);
			Dealer.NativeMethodInfoPtr_MarkAsRecommended_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674833);
			Dealer.NativeMethodInfoPtr_SetRecommended_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674834);
			Dealer.NativeMethodInfoPtr_InitialRecruitment_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674835);
			Dealer.NativeMethodInfoPtr_SetIsRecruited_Public_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674836);
			Dealer.NativeMethodInfoPtr_OnDealerUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674837);
			Dealer.NativeMethodInfoPtr_UpdatePotentialDealerPoI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674838);
			Dealer.NativeMethodInfoPtr_TradeItems_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674839);
			Dealer.NativeMethodInfoPtr_TradeItemsDone_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674840);
			Dealer.NativeMethodInfoPtr_CanCollectCash_Private_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674841);
			Dealer.NativeMethodInfoPtr_UpdateCollectCashChoice_Private_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674842);
			Dealer.NativeMethodInfoPtr_CollectCash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674843);
			Dealer.NativeMethodInfoPtr_UpdateCurrentDeal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674844);
			Dealer.NativeMethodInfoPtr_CanOfferRecruitment_Private_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674845);
			Dealer.NativeMethodInfoPtr_CheckAttendStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674846);
			Dealer.NativeMethodInfoPtr_ShouldAcceptContract_Public_Virtual_New_Boolean_ContractInfo_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674847);
			Dealer.NativeMethodInfoPtr_ContractedOffered_Public_Virtual_New_Void_ContractInfo_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674848);
			Dealer.NativeMethodInfoPtr_SendAddCustomer_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674849);
			Dealer.NativeMethodInfoPtr_AddCustomer_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674850);
			Dealer.NativeMethodInfoPtr_AddCustomer_Protected_Virtual_New_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674851);
			Dealer.NativeMethodInfoPtr_SendRemoveCustomer_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674852);
			Dealer.NativeMethodInfoPtr_RemoveCustomer_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674853);
			Dealer.NativeMethodInfoPtr_RemoveCustomer_Public_Virtual_New_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674854);
			Dealer.NativeMethodInfoPtr_ChangeCash_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674855);
			Dealer.NativeMethodInfoPtr_SetCash_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674856);
			Dealer.NativeMethodInfoPtr_CompletedDeal_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674857);
			Dealer.NativeMethodInfoPtr_SubmitPayment_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674858);
			Dealer.NativeMethodInfoPtr_GetOrderableProducts_Public_List_1_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674859);
			Dealer.NativeMethodInfoPtr_GetProductCount_Public_Int32_String_EQuality_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674860);
			Dealer.NativeMethodInfoPtr_GetDealWindow_Private_EDealWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674861);
			Dealer.NativeMethodInfoPtr_GetContractCountInWindow_Private_Int32_EDealWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674862);
			Dealer.NativeMethodInfoPtr_CustomerContractStarted_Private_Void_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674863);
			Dealer.NativeMethodInfoPtr_CustomerContractEnded_Private_Void_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674864);
			Dealer.NativeMethodInfoPtr_SortContracts_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674865);
			Dealer.NativeMethodInfoPtr_RecruitmentRequested_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674866);
			Dealer.NativeMethodInfoPtr_RemoveContractItems_Public_Boolean_Contract_EQuality_byref_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674867);
			Dealer.NativeMethodInfoPtr_GetItems_Private_List_1_ItemInstance_String_Int32_Func_2_ProductItemInstance_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674868);
			Dealer.NativeMethodInfoPtr_GetAllSlots_Public_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674869);
			Dealer.NativeMethodInfoPtr_AddItemToInventory_Public_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674870);
			Dealer.NativeMethodInfoPtr_TryMoveOverflowItems_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674871);
			Dealer.NativeMethodInfoPtr_GetTotalInventoryItemCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674872);
			Dealer.NativeMethodInfoPtr_SetStoredInstance_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674873);
			Dealer.NativeMethodInfoPtr_SetStoredInstance_Internal_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674874);
			Dealer.NativeMethodInfoPtr_SetItemSlotQuantity_Public_Virtual_Final_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674875);
			Dealer.NativeMethodInfoPtr_SetItemSlotQuantity_Internal_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674876);
			Dealer.NativeMethodInfoPtr_SetSlotLocked_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674877);
			Dealer.NativeMethodInfoPtr_SetSlotLocked_Internal_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674878);
			Dealer.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674879);
			Dealer.NativeMethodInfoPtr_Load_Public_Virtual_Void_NPCData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674880);
			Dealer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674881);
			Dealer.NativeMethodInfoPtr__Awake_b__59_0_Private_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674883);
			Dealer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674884);
			Dealer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674885);
			Dealer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674886);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_MarkAsRecommended_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674887);
			Dealer.NativeMethodInfoPtr_RpcLogic___MarkAsRecommended_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674888);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_MarkAsRecommended_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674889);
			Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetRecommended_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674890);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetRecommended_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674891);
			Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetRecommended_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674892);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_InitialRecruitment_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674893);
			Dealer.NativeMethodInfoPtr_RpcLogic___InitialRecruitment_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674894);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_InitialRecruitment_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674895);
			Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetIsRecruited_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674896);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetIsRecruited_328543758_Public_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674897);
			Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetIsRecruited_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674898);
			Dealer.NativeMethodInfoPtr_RpcWriter___Target_SetIsRecruited_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674899);
			Dealer.NativeMethodInfoPtr_RpcReader___Target_SetIsRecruited_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674900);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_SendAddCustomer_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674901);
			Dealer.NativeMethodInfoPtr_RpcLogic___SendAddCustomer_3615296227_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674902);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_SendAddCustomer_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674903);
			Dealer.NativeMethodInfoPtr_RpcWriter___Observers_AddCustomer_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674904);
			Dealer.NativeMethodInfoPtr_RpcLogic___AddCustomer_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674905);
			Dealer.NativeMethodInfoPtr_RpcReader___Observers_AddCustomer_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674906);
			Dealer.NativeMethodInfoPtr_RpcWriter___Target_AddCustomer_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674907);
			Dealer.NativeMethodInfoPtr_RpcReader___Target_AddCustomer_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674908);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_SendRemoveCustomer_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674909);
			Dealer.NativeMethodInfoPtr_RpcLogic___SendRemoveCustomer_3615296227_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674910);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_SendRemoveCustomer_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674911);
			Dealer.NativeMethodInfoPtr_RpcWriter___Observers_RemoveCustomer_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674912);
			Dealer.NativeMethodInfoPtr_RpcLogic___RemoveCustomer_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674913);
			Dealer.NativeMethodInfoPtr_RpcReader___Observers_RemoveCustomer_3615296227_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674914);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetCash_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674915);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetCash_431000436_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674916);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_SetCash_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674917);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_CompletedDeal_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674918);
			Dealer.NativeMethodInfoPtr_RpcLogic___CompletedDeal_2166136261_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674919);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_CompletedDeal_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674920);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_SubmitPayment_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674921);
			Dealer.NativeMethodInfoPtr_RpcLogic___SubmitPayment_431000436_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674922);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_SubmitPayment_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674923);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetStoredInstance_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674924);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_2652194801_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674925);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_SetStoredInstance_2652194801_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674926);
			Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674927);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674928);
			Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674929);
			Dealer.NativeMethodInfoPtr_RpcWriter___Target_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674930);
			Dealer.NativeMethodInfoPtr_RpcReader___Target_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674931);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetItemSlotQuantity_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674932);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_1692629761_Public_Virtual_Final_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674933);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_SetItemSlotQuantity_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674934);
			Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674935);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674936);
			Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674937);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetSlotLocked_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674938);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_3170825843_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674939);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_SetSlotLocked_3170825843_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674940);
			Dealer.NativeMethodInfoPtr_RpcWriter___Target_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674941);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674942);
			Dealer.NativeMethodInfoPtr_RpcReader___Target_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674943);
			Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674944);
			Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674945);
			Dealer.NativeMethodInfoPtr_sync___get_value__Cash_k__BackingField_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674946);
			Dealer.NativeMethodInfoPtr_sync___set_value__Cash_k__BackingField_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674947);
			Dealer.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Dealer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674948);
			Dealer.NativeMethodInfoPtr_sync___get_value_acceptedContractGUIDs_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674949);
			Dealer.NativeMethodInfoPtr_sync___set_value_acceptedContractGUIDs_Public_set_Void_List_1_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674950);
			Dealer.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674951);
		}

		// Token: 0x17001B73 RID: 7027
		// (get) Token: 0x06005A7A RID: 23162 RVA: 0x001A558C File Offset: 0x001A378C
		// (set) Token: 0x06005A7B RID: 23163 RVA: 0x001A55C8 File Offset: 0x001A37C8
		public unsafe bool IsRecruited
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_get_IsRecruited_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_set_IsRecruited_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B74 RID: 7028
		// (get) Token: 0x06005A7C RID: 23164 RVA: 0x001A5608 File Offset: 0x001A3808
		// (set) Token: 0x06005A7D RID: 23165 RVA: 0x001A5648 File Offset: 0x001A3848
		public unsafe virtual List<ItemSlot> ItemSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_get_ItemSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_set_ItemSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B75 RID: 7029
		// (get) Token: 0x06005A7E RID: 23166 RVA: 0x001A568C File Offset: 0x001A388C
		// (set) Token: 0x06005A7F RID: 23167 RVA: 0x001A56C8 File Offset: 0x001A38C8
		public unsafe float Cash
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 190916, RefRangeEnd = 190918, XrefRangeStart = 190916, XrefRangeEnd = 190916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_get_Cash_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190918, XrefRangeEnd = 190925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_set_Cash_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B76 RID: 7030
		// (get) Token: 0x06005A80 RID: 23168 RVA: 0x001A5708 File Offset: 0x001A3908
		// (set) Token: 0x06005A81 RID: 23169 RVA: 0x001A5744 File Offset: 0x001A3944
		public unsafe bool HasBeenRecommended
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_get_HasBeenRecommended_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_set_HasBeenRecommended_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B77 RID: 7031
		// (get) Token: 0x06005A82 RID: 23170 RVA: 0x001A5784 File Offset: 0x001A3984
		// (set) Token: 0x06005A83 RID: 23171 RVA: 0x001A57C4 File Offset: 0x001A39C4
		public unsafe NPCPoI potentialDealerPoI
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 94047, RefRangeEnd = 94051, XrefRangeStart = 94047, XrefRangeEnd = 94051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_get_potentialDealerPoI_Public_get_NPCPoI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCPoI>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_set_potentialDealerPoI_Protected_set_Void_NPCPoI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B78 RID: 7032
		// (get) Token: 0x06005A84 RID: 23172 RVA: 0x001A5808 File Offset: 0x001A3A08
		// (set) Token: 0x06005A85 RID: 23173 RVA: 0x001A5848 File Offset: 0x001A3A48
		public unsafe NPCPoI dealerPoI
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 183530, RefRangeEnd = 183533, XrefRangeStart = 183530, XrefRangeEnd = 183533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_get_dealerPoI_Public_get_NPCPoI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCPoI>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_set_dealerPoI_Protected_set_Void_NPCPoI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005A86 RID: 23174 RVA: 0x001A588C File Offset: 0x001A3A8C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 190926, RefRangeEnd = 190932, XrefRangeStart = 190925, XrefRangeEnd = 190926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A87 RID: 23175 RVA: 0x001A58C8 File Offset: 0x001A3AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190932, XrefRangeEnd = 190935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A88 RID: 23176 RVA: 0x001A5904 File Offset: 0x001A3B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190935, XrefRangeEnd = 190944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A89 RID: 23177 RVA: 0x001A5940 File Offset: 0x001A3B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190944, XrefRangeEnd = 191002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A8A RID: 23178 RVA: 0x001A597C File Offset: 0x001A3B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191002, XrefRangeEnd = 191019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A8B RID: 23179 RVA: 0x001A59CC File Offset: 0x001A3BCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191072, RefRangeEnd = 191073, XrefRangeStart = 191019, XrefRangeEnd = 191072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupPoI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetupPoI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A8C RID: 23180 RVA: 0x001A5A00 File Offset: 0x001A3C00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191103, RefRangeEnd = 191104, XrefRangeStart = 191073, XrefRangeEnd = 191103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUpDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetUpDialogue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A8D RID: 23181 RVA: 0x001A5A34 File Offset: 0x001A3C34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191122, RefRangeEnd = 191123, XrefRangeStart = 191104, XrefRangeEnd = 191122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A8E RID: 23182 RVA: 0x001A5A70 File Offset: 0x001A3C70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191144, RefRangeEnd = 191145, XrefRangeStart = 191123, XrefRangeEnd = 191144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkAsRecommended()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_MarkAsRecommended_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A8F RID: 23183 RVA: 0x001A5AA4 File Offset: 0x001A3CA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 191165, RefRangeEnd = 191168, XrefRangeStart = 191145, XrefRangeEnd = 191165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRecommended()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetRecommended_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A90 RID: 23184 RVA: 0x001A5AD8 File Offset: 0x001A3CD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191188, RefRangeEnd = 191189, XrefRangeStart = 191168, XrefRangeEnd = 191188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitialRecruitment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_InitialRecruitment_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A91 RID: 23185 RVA: 0x001A5B0C File Offset: 0x001A3D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191189, XrefRangeEnd = 191226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsRecruited(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_SetIsRecruited_Public_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A92 RID: 23186 RVA: 0x001A5B5C File Offset: 0x001A3D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191226, XrefRangeEnd = 191231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDealerUnlocked(NPCRelationData.EUnlockType unlockType, bool b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref unlockType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_OnDealerUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A93 RID: 23187 RVA: 0x001A5BB4 File Offset: 0x001A3DB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191246, RefRangeEnd = 191247, XrefRangeStart = 191231, XrefRangeEnd = 191246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdatePotentialDealerPoI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_UpdatePotentialDealerPoI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A94 RID: 23188 RVA: 0x001A5BF0 File Offset: 0x001A3DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191247, XrefRangeEnd = 191270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TradeItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_TradeItems_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A95 RID: 23189 RVA: 0x001A5C24 File Offset: 0x001A3E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191270, XrefRangeEnd = 191289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TradeItemsDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_TradeItemsDone_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A96 RID: 23190 RVA: 0x001A5C58 File Offset: 0x001A3E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191289, XrefRangeEnd = 191292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanCollectCash(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_CanCollectCash_Private_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005A97 RID: 23191 RVA: 0x001A5CB0 File Offset: 0x001A3EB0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 191299, RefRangeEnd = 191302, XrefRangeStart = 191292, XrefRangeEnd = 191299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCollectCashChoice(float oldCash, float newCash, bool asServer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldCash;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newCash;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref asServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_UpdateCollectCashChoice_Private_Void_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A98 RID: 23192 RVA: 0x001A5D0C File Offset: 0x001A3F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191302, XrefRangeEnd = 191309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CollectCash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_CollectCash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A99 RID: 23193 RVA: 0x001A5D40 File Offset: 0x001A3F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191309, XrefRangeEnd = 191313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCurrentDeal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_UpdateCurrentDeal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A9A RID: 23194 RVA: 0x001A5D74 File Offset: 0x001A3F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191313, XrefRangeEnd = 191320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanOfferRecruitment(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_CanOfferRecruitment_Private_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005A9B RID: 23195 RVA: 0x001A5DCC File Offset: 0x001A3FCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191362, RefRangeEnd = 191363, XrefRangeStart = 191320, XrefRangeEnd = 191362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckAttendStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_CheckAttendStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A9C RID: 23196 RVA: 0x001A5E00 File Offset: 0x001A4000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191363, XrefRangeEnd = 191405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldAcceptContract(ContractInfo contractInfo, Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contractInfo);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_ShouldAcceptContract_Public_Virtual_New_Boolean_ContractInfo_Customer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005A9D RID: 23197 RVA: 0x001A5E6C File Offset: 0x001A406C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191405, XrefRangeEnd = 191422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ContractedOffered(ContractInfo contractInfo, Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contractInfo);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_ContractedOffered_Public_Virtual_New_Void_ContractInfo_Customer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A9E RID: 23198 RVA: 0x001A5ECC File Offset: 0x001A40CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 191444, RefRangeEnd = 191447, XrefRangeStart = 191422, XrefRangeEnd = 191444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendAddCustomer(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SendAddCustomer_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A9F RID: 23199 RVA: 0x001A5F10 File Offset: 0x001A4110
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 191489, RefRangeEnd = 191493, XrefRangeStart = 191447, XrefRangeEnd = 191489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCustomer(NetworkConnection conn, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_AddCustomer_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AA0 RID: 23200 RVA: 0x001A5F64 File Offset: 0x001A4164
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191511, RefRangeEnd = 191512, XrefRangeStart = 191493, XrefRangeEnd = 191511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddCustomer(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_AddCustomer_Protected_Virtual_New_Void_Customer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AA1 RID: 23201 RVA: 0x001A5FB4 File Offset: 0x001A41B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 191534, RefRangeEnd = 191536, XrefRangeStart = 191512, XrefRangeEnd = 191534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendRemoveCustomer(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SendRemoveCustomer_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AA2 RID: 23202 RVA: 0x001A5FF8 File Offset: 0x001A41F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 191558, RefRangeEnd = 191560, XrefRangeStart = 191536, XrefRangeEnd = 191558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCustomer(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RemoveCustomer_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AA3 RID: 23203 RVA: 0x001A603C File Offset: 0x001A423C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191576, RefRangeEnd = 191577, XrefRangeStart = 191560, XrefRangeEnd = 191576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveCustomer(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_RemoveCustomer_Public_Virtual_New_Void_Customer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AA4 RID: 23204 RVA: 0x001A608C File Offset: 0x001A428C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191577, XrefRangeEnd = 191578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeCash(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_ChangeCash_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AA5 RID: 23205 RVA: 0x001A60CC File Offset: 0x001A42CC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 191597, RefRangeEnd = 191602, XrefRangeStart = 191578, XrefRangeEnd = 191597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCash(float cash)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetCash_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AA6 RID: 23206 RVA: 0x001A610C File Offset: 0x001A430C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191602, XrefRangeEnd = 191620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CompletedDeal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_CompletedDeal_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AA7 RID: 23207 RVA: 0x001A6148 File Offset: 0x001A4348
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191639, RefRangeEnd = 191640, XrefRangeStart = 191620, XrefRangeEnd = 191639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubmitPayment(float payment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref payment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SubmitPayment_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AA8 RID: 23208 RVA: 0x001A6188 File Offset: 0x001A4388
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191694, RefRangeEnd = 191695, XrefRangeStart = 191640, XrefRangeEnd = 191694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ProductDefinition> GetOrderableProducts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_GetOrderableProducts_Public_List_1_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ProductDefinition>>(intPtr3) : null;
		}

		// Token: 0x06005AA9 RID: 23209 RVA: 0x001A61C8 File Offset: 0x001A43C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 191715, RefRangeEnd = 191717, XrefRangeStart = 191695, XrefRangeEnd = 191715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetProductCount(string productID, EQuality minQuality, EQuality maxQuality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minQuality;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxQuality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_GetProductCount_Public_Int32_String_EQuality_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005AAA RID: 23210 RVA: 0x001A6234 File Offset: 0x001A4434
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191767, RefRangeEnd = 191768, XrefRangeStart = 191717, XrefRangeEnd = 191767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EDealWindow GetDealWindow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_GetDealWindow_Private_EDealWindow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005AAB RID: 23211 RVA: 0x001A6270 File Offset: 0x001A4470
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191787, RefRangeEnd = 191788, XrefRangeStart = 191768, XrefRangeEnd = 191787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetContractCountInWindow(EDealWindow window)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref window;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_GetContractCountInWindow_Private_Int32_EDealWindow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005AAC RID: 23212 RVA: 0x001A62BC File Offset: 0x001A44BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191816, RefRangeEnd = 191817, XrefRangeStart = 191788, XrefRangeEnd = 191816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CustomerContractStarted(Contract contract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_CustomerContractStarted_Private_Void_Contract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AAD RID: 23213 RVA: 0x001A6300 File Offset: 0x001A4500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191817, XrefRangeEnd = 191834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CustomerContractEnded(Contract contract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_CustomerContractEnded_Private_Void_Contract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AAE RID: 23214 RVA: 0x001A6344 File Offset: 0x001A4544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191834, XrefRangeEnd = 191856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortContracts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SortContracts_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AAF RID: 23215 RVA: 0x001A6378 File Offset: 0x001A4578
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RecruitmentRequested()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_RecruitmentRequested_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AB0 RID: 23216 RVA: 0x001A63B4 File Offset: 0x001A45B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191900, RefRangeEnd = 191901, XrefRangeStart = 191856, XrefRangeEnd = 191900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RemoveContractItems(Contract contract, EQuality targetQuality, out List<ItemInstance> items)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetQuality;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RemoveContractItems_Public_Boolean_Contract_EQuality_byref_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			items = ((intPtr4 == 0) ? null : new List<ItemInstance>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005AB1 RID: 23217 RVA: 0x001A6434 File Offset: 0x001A4634
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 192077, RefRangeEnd = 192078, XrefRangeStart = 191901, XrefRangeEnd = 192077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ItemInstance> GetItems(string ID, int requiredQuantity, Func<ProductItemInstance, bool> qualityCheck, out int returnedQuantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requiredQuantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(qualityCheck);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &returnedQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_GetItems_Private_List_1_ItemInstance_String_Int32_Func_2_ProductItemInstance_Boolean_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemInstance>>(intPtr3) : null;
		}

		// Token: 0x06005AB2 RID: 23218 RVA: 0x001A64B4 File Offset: 0x001A46B4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 192087, RefRangeEnd = 192093, XrefRangeStart = 192078, XrefRangeEnd = 192087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ItemSlot> GetAllSlots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_GetAllSlots_Public_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
		}

		// Token: 0x06005AB3 RID: 23219 RVA: 0x001A64F4 File Offset: 0x001A46F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 192111, RefRangeEnd = 192112, XrefRangeStart = 192093, XrefRangeEnd = 192111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddItemToInventory(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_AddItemToInventory_Public_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AB4 RID: 23220 RVA: 0x001A6538 File Offset: 0x001A4738
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 192117, RefRangeEnd = 192119, XrefRangeStart = 192112, XrefRangeEnd = 192117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryMoveOverflowItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_TryMoveOverflowItems_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AB5 RID: 23221 RVA: 0x001A656C File Offset: 0x001A476C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 192134, RefRangeEnd = 192136, XrefRangeStart = 192119, XrefRangeEnd = 192134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTotalInventoryItemCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_GetTotalInventoryItemCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005AB6 RID: 23222 RVA: 0x001A65A8 File Offset: 0x001A47A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192136, XrefRangeEnd = 192163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetStoredInstance_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AB7 RID: 23223 RVA: 0x001A660C File Offset: 0x001A480C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 192188, RefRangeEnd = 192191, XrefRangeStart = 192163, XrefRangeEnd = 192188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetStoredInstance_Internal_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AB8 RID: 23224 RVA: 0x001A6670 File Offset: 0x001A4870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192191, XrefRangeEnd = 192216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetItemSlotQuantity_Public_Virtual_Final_New_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AB9 RID: 23225 RVA: 0x001A66BC File Offset: 0x001A48BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 192244, RefRangeEnd = 192247, XrefRangeStart = 192216, XrefRangeEnd = 192244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetItemSlotQuantity_Internal_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ABA RID: 23226 RVA: 0x001A6708 File Offset: 0x001A4908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192247, XrefRangeEnd = 192276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetSlotLocked_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ABB RID: 23227 RVA: 0x001A678C File Offset: 0x001A498C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 192326, RefRangeEnd = 192329, XrefRangeStart = 192276, XrefRangeEnd = 192326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetSlotLocked_Internal_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ABC RID: 23228 RVA: 0x001A6810 File Offset: 0x001A4A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192329, XrefRangeEnd = 192355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005ABD RID: 23229 RVA: 0x001A6854 File Offset: 0x001A4A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192355, XrefRangeEnd = 192447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(NPCData data, string containerPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(containerPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_Load_Public_Virtual_Void_NPCData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ABE RID: 23230 RVA: 0x001A68B4 File Offset: 0x001A4AB4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 192500, RefRangeEnd = 192506, XrefRangeStart = 192447, XrefRangeEnd = 192500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dealer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dealer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ABF RID: 23231 RVA: 0x001A68F0 File Offset: 0x001A4AF0
		[CallerCount(0)]
		public unsafe void _Awake_b__59_0(NPCRelationData.EUnlockType <p0>, bool <p1>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <p0>;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref <p1>;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr__Awake_b__59_0_Private_Void_EUnlockType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AC0 RID: 23232 RVA: 0x001A693C File Offset: 0x001A4B3C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 192669, RefRangeEnd = 192675, XrefRangeStart = 192506, XrefRangeEnd = 192669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AC1 RID: 23233 RVA: 0x001A6978 File Offset: 0x001A4B78
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 192676, RefRangeEnd = 192682, XrefRangeStart = 192675, XrefRangeEnd = 192676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AC2 RID: 23234 RVA: 0x001A69B4 File Offset: 0x001A4BB4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AC3 RID: 23235 RVA: 0x001A69F0 File Offset: 0x001A4BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192682, XrefRangeEnd = 192700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_MarkAsRecommended_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_MarkAsRecommended_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AC4 RID: 23236 RVA: 0x001A6A24 File Offset: 0x001A4C24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 191165, RefRangeEnd = 191168, XrefRangeStart = 191165, XrefRangeEnd = 191168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___MarkAsRecommended_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___MarkAsRecommended_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AC5 RID: 23237 RVA: 0x001A6A58 File Offset: 0x001A4C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192700, XrefRangeEnd = 192703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_MarkAsRecommended_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_MarkAsRecommended_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AC6 RID: 23238 RVA: 0x001A6ABC File Offset: 0x001A4CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192703, XrefRangeEnd = 192721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetRecommended_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetRecommended_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AC7 RID: 23239 RVA: 0x001A6AF0 File Offset: 0x001A4CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192721, XrefRangeEnd = 192722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetRecommended_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetRecommended_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AC8 RID: 23240 RVA: 0x001A6B24 File Offset: 0x001A4D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192722, XrefRangeEnd = 192725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetRecommended_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetRecommended_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AC9 RID: 23241 RVA: 0x001A6B74 File Offset: 0x001A4D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192725, XrefRangeEnd = 192743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_InitialRecruitment_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_InitialRecruitment_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ACA RID: 23242 RVA: 0x001A6BA8 File Offset: 0x001A4DA8
		[CallerCount(0)]
		public unsafe void RpcLogic___InitialRecruitment_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___InitialRecruitment_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ACB RID: 23243 RVA: 0x001A6BDC File Offset: 0x001A4DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192743, XrefRangeEnd = 192745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_InitialRecruitment_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_InitialRecruitment_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ACC RID: 23244 RVA: 0x001A6C40 File Offset: 0x001A4E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192745, XrefRangeEnd = 192763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetIsRecruited_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetIsRecruited_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ACD RID: 23245 RVA: 0x001A6C84 File Offset: 0x001A4E84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 192825, RefRangeEnd = 192828, XrefRangeStart = 192763, XrefRangeEnd = 192825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetIsRecruited_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_RpcLogic___SetIsRecruited_328543758_Public_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ACE RID: 23246 RVA: 0x001A6CD4 File Offset: 0x001A4ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192828, XrefRangeEnd = 192831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetIsRecruited_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetIsRecruited_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ACF RID: 23247 RVA: 0x001A6D24 File Offset: 0x001A4F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192831, XrefRangeEnd = 192849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetIsRecruited_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Target_SetIsRecruited_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AD0 RID: 23248 RVA: 0x001A6D68 File Offset: 0x001A4F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192849, XrefRangeEnd = 192852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetIsRecruited_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Target_SetIsRecruited_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AD1 RID: 23249 RVA: 0x001A6DB8 File Offset: 0x001A4FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192852, XrefRangeEnd = 192871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendAddCustomer_3615296227(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_SendAddCustomer_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AD2 RID: 23250 RVA: 0x001A6DFC File Offset: 0x001A4FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192871, XrefRangeEnd = 192872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendAddCustomer_3615296227(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SendAddCustomer_3615296227_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AD3 RID: 23251 RVA: 0x001A6E40 File Offset: 0x001A5040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192872, XrefRangeEnd = 192876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendAddCustomer_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_SendAddCustomer_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AD4 RID: 23252 RVA: 0x001A6EA4 File Offset: 0x001A50A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192876, XrefRangeEnd = 192895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddCustomer_2971853958(NetworkConnection conn, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Observers_AddCustomer_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AD5 RID: 23253 RVA: 0x001A6EF8 File Offset: 0x001A50F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 192923, RefRangeEnd = 192926, XrefRangeStart = 192895, XrefRangeEnd = 192923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddCustomer_2971853958(NetworkConnection conn, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___AddCustomer_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AD6 RID: 23254 RVA: 0x001A6F4C File Offset: 0x001A514C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192926, XrefRangeEnd = 192930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddCustomer_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Observers_AddCustomer_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AD7 RID: 23255 RVA: 0x001A6F9C File Offset: 0x001A519C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192930, XrefRangeEnd = 192949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_AddCustomer_2971853958(NetworkConnection conn, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Target_AddCustomer_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AD8 RID: 23256 RVA: 0x001A6FF0 File Offset: 0x001A51F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192949, XrefRangeEnd = 192953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_AddCustomer_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Target_AddCustomer_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AD9 RID: 23257 RVA: 0x001A7040 File Offset: 0x001A5240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192953, XrefRangeEnd = 192972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendRemoveCustomer_3615296227(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_SendRemoveCustomer_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ADA RID: 23258 RVA: 0x001A7084 File Offset: 0x001A5284
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 191558, RefRangeEnd = 191560, XrefRangeStart = 191558, XrefRangeEnd = 191560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendRemoveCustomer_3615296227(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SendRemoveCustomer_3615296227_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ADB RID: 23259 RVA: 0x001A70C8 File Offset: 0x001A52C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192972, XrefRangeEnd = 192976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendRemoveCustomer_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_SendRemoveCustomer_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ADC RID: 23260 RVA: 0x001A712C File Offset: 0x001A532C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192976, XrefRangeEnd = 192995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_RemoveCustomer_3615296227(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Observers_RemoveCustomer_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ADD RID: 23261 RVA: 0x001A7170 File Offset: 0x001A5370
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 193023, RefRangeEnd = 193026, XrefRangeStart = 192995, XrefRangeEnd = 193023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RemoveCustomer_3615296227(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___RemoveCustomer_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ADE RID: 23262 RVA: 0x001A71B4 File Offset: 0x001A53B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193026, XrefRangeEnd = 193030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_RemoveCustomer_3615296227(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Observers_RemoveCustomer_3615296227_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ADF RID: 23263 RVA: 0x001A7204 File Offset: 0x001A5404
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 191597, RefRangeEnd = 191602, XrefRangeStart = 191597, XrefRangeEnd = 191602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetCash_431000436(float cash)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetCash_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AE0 RID: 23264 RVA: 0x001A7244 File Offset: 0x001A5444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193030, XrefRangeEnd = 193039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetCash_431000436(float cash)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetCash_431000436_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AE1 RID: 23265 RVA: 0x001A7284 File Offset: 0x001A5484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193039, XrefRangeEnd = 193050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetCash_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_SetCash_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AE2 RID: 23266 RVA: 0x001A72E8 File Offset: 0x001A54E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_CompletedDeal_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_CompletedDeal_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AE3 RID: 23267 RVA: 0x001A731C File Offset: 0x001A551C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193065, RefRangeEnd = 193066, XrefRangeStart = 193050, XrefRangeEnd = 193065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___CompletedDeal_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_RpcLogic___CompletedDeal_2166136261_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AE4 RID: 23268 RVA: 0x001A7358 File Offset: 0x001A5558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193066, XrefRangeEnd = 193068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_CompletedDeal_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_CompletedDeal_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AE5 RID: 23269 RVA: 0x001A73BC File Offset: 0x001A55BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191639, RefRangeEnd = 191640, XrefRangeStart = 191639, XrefRangeEnd = 191640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SubmitPayment_431000436(float payment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref payment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_SubmitPayment_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AE6 RID: 23270 RVA: 0x001A73FC File Offset: 0x001A55FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193068, XrefRangeEnd = 193092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SubmitPayment_431000436(float payment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref payment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SubmitPayment_431000436_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AE7 RID: 23271 RVA: 0x001A743C File Offset: 0x001A563C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193092, XrefRangeEnd = 193118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SubmitPayment_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_SubmitPayment_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AE8 RID: 23272 RVA: 0x001A74A0 File Offset: 0x001A56A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193118, XrefRangeEnd = 193131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetStoredInstance_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AE9 RID: 23273 RVA: 0x001A7504 File Offset: 0x001A5704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193131, XrefRangeEnd = 193135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_2652194801_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AEA RID: 23274 RVA: 0x001A7568 File Offset: 0x001A5768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193135, XrefRangeEnd = 193143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_SetStoredInstance_2652194801_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AEB RID: 23275 RVA: 0x001A75CC File Offset: 0x001A57CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193143, XrefRangeEnd = 193164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AEC RID: 23276 RVA: 0x001A7630 File Offset: 0x001A5830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193164, XrefRangeEnd = 193170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AED RID: 23277 RVA: 0x001A7694 File Offset: 0x001A5894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193170, XrefRangeEnd = 193178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AEE RID: 23278 RVA: 0x001A76E4 File Offset: 0x001A58E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193178, XrefRangeEnd = 193190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Target_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AEF RID: 23279 RVA: 0x001A7748 File Offset: 0x001A5948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193190, XrefRangeEnd = 193199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Target_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AF0 RID: 23280 RVA: 0x001A7798 File Offset: 0x001A5998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193199, XrefRangeEnd = 193221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetItemSlotQuantity_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AF1 RID: 23281 RVA: 0x001A77E4 File Offset: 0x001A59E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193221, XrefRangeEnd = 193222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_1692629761_Public_Virtual_Final_New_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AF2 RID: 23282 RVA: 0x001A7830 File Offset: 0x001A5A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193222, XrefRangeEnd = 193229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_SetItemSlotQuantity_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AF3 RID: 23283 RVA: 0x001A7894 File Offset: 0x001A5A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193229, XrefRangeEnd = 193251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AF4 RID: 23284 RVA: 0x001A78E0 File Offset: 0x001A5AE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193256, RefRangeEnd = 193257, XrefRangeStart = 193251, XrefRangeEnd = 193256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AF5 RID: 23285 RVA: 0x001A792C File Offset: 0x001A5B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193257, XrefRangeEnd = 193264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AF6 RID: 23286 RVA: 0x001A797C File Offset: 0x001A5B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193264, XrefRangeEnd = 193279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetSlotLocked_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AF7 RID: 23287 RVA: 0x001A7A00 File Offset: 0x001A5C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193279, XrefRangeEnd = 193283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_3170825843_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AF8 RID: 23288 RVA: 0x001A7A84 File Offset: 0x001A5C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193283, XrefRangeEnd = 193292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_SetSlotLocked_3170825843_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AF9 RID: 23289 RVA: 0x001A7AE8 File Offset: 0x001A5CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193292, XrefRangeEnd = 193306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Target_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AFA RID: 23290 RVA: 0x001A7B6C File Offset: 0x001A5D6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 193314, RefRangeEnd = 193317, XrefRangeStart = 193306, XrefRangeEnd = 193314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AFB RID: 23291 RVA: 0x001A7BF0 File Offset: 0x001A5DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193317, XrefRangeEnd = 193325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Target_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AFC RID: 23292 RVA: 0x001A7C40 File Offset: 0x001A5E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193325, XrefRangeEnd = 193348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AFD RID: 23293 RVA: 0x001A7CC4 File Offset: 0x001A5EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193348, XrefRangeEnd = 193355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001B79 RID: 7033
		// (get) Token: 0x06005AFE RID: 23294 RVA: 0x001A7D14 File Offset: 0x001A5F14
		// (set) Token: 0x06005AFF RID: 23295 RVA: 0x001A7D50 File Offset: 0x001A5F50
		public unsafe float SyncAccessor_<Cash>k__BackingField
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 190916, RefRangeEnd = 190918, XrefRangeStart = 190916, XrefRangeEnd = 190918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_sync___get_value__Cash_k__BackingField_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 193363, RefRangeEnd = 193365, XrefRangeStart = 193355, XrefRangeEnd = 193363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_sync___set_value__Cash_k__BackingField_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005B00 RID: 23296 RVA: 0x001A7D9C File Offset: 0x001A5F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193365, XrefRangeEnd = 193377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Economy_Dealer(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Dealer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001B7A RID: 7034
		// (get) Token: 0x06005B01 RID: 23297 RVA: 0x001A7E10 File Offset: 0x001A6010
		// (set) Token: 0x06005B02 RID: 23298 RVA: 0x001A7E50 File Offset: 0x001A6050
		public unsafe List<string> SyncAccessor_acceptedContractGUIDs
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 184821, RefRangeEnd = 184823, XrefRangeStart = 184821, XrefRangeEnd = 184823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_sync___get_value_acceptedContractGUIDs_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 193386, RefRangeEnd = 193387, XrefRangeStart = 193377, XrefRangeEnd = 193386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_sync___set_value_acceptedContractGUIDs_Public_set_Void_List_1_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005B03 RID: 23299 RVA: 0x001A7EA0 File Offset: 0x001A60A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193428, RefRangeEnd = 193429, XrefRangeStart = 193387, XrefRangeEnd = 193428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B04 RID: 23300 RVA: 0x0002AC56 File Offset: 0x00028E56
		public Dealer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B46 RID: 6982
		// (get) Token: 0x06005B05 RID: 23301 RVA: 0x001A7EDC File Offset: 0x001A60DC
		// (set) Token: 0x06005B06 RID: 23302 RVA: 0x0002AC5F File Offset: 0x00028E5F
		public unsafe static int MAX_CUSTOMERS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_MAX_CUSTOMERS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_MAX_CUSTOMERS, (void*)(&value));
			}
		}

		// Token: 0x17001B47 RID: 6983
		// (get) Token: 0x06005B07 RID: 23303 RVA: 0x001A7EF8 File Offset: 0x001A60F8
		// (set) Token: 0x06005B08 RID: 23304 RVA: 0x0002AC6D File Offset: 0x00028E6D
		public unsafe static int DEAL_ARRIVAL_DELAY
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_DEAL_ARRIVAL_DELAY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_DEAL_ARRIVAL_DELAY, (void*)(&value));
			}
		}

		// Token: 0x17001B48 RID: 6984
		// (get) Token: 0x06005B09 RID: 23305 RVA: 0x001A7F14 File Offset: 0x001A6114
		// (set) Token: 0x06005B0A RID: 23306 RVA: 0x0002AC7B File Offset: 0x00028E7B
		public unsafe static int MIN_TRAVEL_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_MIN_TRAVEL_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_MIN_TRAVEL_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001B49 RID: 6985
		// (get) Token: 0x06005B0B RID: 23307 RVA: 0x001A7F30 File Offset: 0x001A6130
		// (set) Token: 0x06005B0C RID: 23308 RVA: 0x0002AC89 File Offset: 0x00028E89
		public unsafe static int MAX_TRAVEL_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_MAX_TRAVEL_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_MAX_TRAVEL_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001B4A RID: 6986
		// (get) Token: 0x06005B0D RID: 23309 RVA: 0x001A7F4C File Offset: 0x001A614C
		// (set) Token: 0x06005B0E RID: 23310 RVA: 0x0002AC97 File Offset: 0x00028E97
		public unsafe static int OVERFLOW_SLOT_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_OVERFLOW_SLOT_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_OVERFLOW_SLOT_COUNT, (void*)(&value));
			}
		}

		// Token: 0x17001B4B RID: 6987
		// (get) Token: 0x06005B0F RID: 23311 RVA: 0x001A7F68 File Offset: 0x001A6168
		// (set) Token: 0x06005B10 RID: 23312 RVA: 0x0002ACA5 File Offset: 0x00028EA5
		public unsafe static float CASH_REMINDER_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_CASH_REMINDER_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_CASH_REMINDER_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17001B4C RID: 6988
		// (get) Token: 0x06005B11 RID: 23313 RVA: 0x001A7F84 File Offset: 0x001A6184
		// (set) Token: 0x06005B12 RID: 23314 RVA: 0x0002ACB3 File Offset: 0x00028EB3
		public unsafe static float RELATIONSHIP_CHANGE_PER_DEAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_RELATIONSHIP_CHANGE_PER_DEAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_RELATIONSHIP_CHANGE_PER_DEAL, (void*)(&value));
			}
		}

		// Token: 0x17001B4D RID: 6989
		// (get) Token: 0x06005B13 RID: 23315 RVA: 0x001A7FA0 File Offset: 0x001A61A0
		// (set) Token: 0x06005B14 RID: 23316 RVA: 0x0002ACC1 File Offset: 0x00028EC1
		public unsafe static Action<Dealer> onDealerRecruited
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_onDealerRecruited, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Dealer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_onDealerRecruited, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B4E RID: 6990
		// (get) Token: 0x06005B15 RID: 23317 RVA: 0x001A7FC8 File Offset: 0x001A61C8
		// (set) Token: 0x06005B16 RID: 23318 RVA: 0x0002ACD3 File Offset: 0x00028ED3
		public unsafe static Color32 DealerLabelColor
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_DealerLabelColor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_DealerLabelColor, (void*)(&value));
			}
		}

		// Token: 0x17001B4F RID: 6991
		// (get) Token: 0x06005B17 RID: 23319 RVA: 0x001A7FE4 File Offset: 0x001A61E4
		// (set) Token: 0x06005B18 RID: 23320 RVA: 0x0002ACE1 File Offset: 0x00028EE1
		public unsafe static List<Dealer> AllDealers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_AllDealers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Dealer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_AllDealers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B50 RID: 6992
		// (get) Token: 0x06005B19 RID: 23321 RVA: 0x001A800C File Offset: 0x001A620C
		// (set) Token: 0x06005B1A RID: 23322 RVA: 0x0002ACF3 File Offset: 0x00028EF3
		public unsafe bool _IsRecruited_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__IsRecruited_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__IsRecruited_k__BackingField)) = value;
			}
		}

		// Token: 0x17001B51 RID: 6993
		// (get) Token: 0x06005B1B RID: 23323 RVA: 0x001A8034 File Offset: 0x001A6234
		// (set) Token: 0x06005B1C RID: 23324 RVA: 0x0002AD0E File Offset: 0x00028F0E
		public unsafe List<ItemSlot> _ItemSlots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__ItemSlots_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__ItemSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B52 RID: 6994
		// (get) Token: 0x06005B1D RID: 23325 RVA: 0x001A8064 File Offset: 0x001A6264
		// (set) Token: 0x06005B1E RID: 23326 RVA: 0x0002AD2D File Offset: 0x00028F2D
		public unsafe List<Customer> InitialCustomers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_InitialCustomers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Customer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_InitialCustomers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B53 RID: 6995
		// (get) Token: 0x06005B1F RID: 23327 RVA: 0x001A8094 File Offset: 0x001A6294
		// (set) Token: 0x06005B20 RID: 23328 RVA: 0x0002AD4C File Offset: 0x00028F4C
		public unsafe List<ProductDefinition> InitialItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_InitialItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_InitialItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B54 RID: 6996
		// (get) Token: 0x06005B21 RID: 23329 RVA: 0x001A80C4 File Offset: 0x001A62C4
		// (set) Token: 0x06005B22 RID: 23330 RVA: 0x0002AD6B File Offset: 0x00028F6B
		public unsafe NPCEnterableBuilding Home
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_Home);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCEnterableBuilding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_Home), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B55 RID: 6997
		// (get) Token: 0x06005B23 RID: 23331 RVA: 0x001A80F4 File Offset: 0x001A62F4
		// (set) Token: 0x06005B24 RID: 23332 RVA: 0x0002AD8A File Offset: 0x00028F8A
		public unsafe NPCSignal_HandleDeal DealSignal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_DealSignal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCSignal_HandleDeal>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_DealSignal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B56 RID: 6998
		// (get) Token: 0x06005B25 RID: 23333 RVA: 0x001A8124 File Offset: 0x001A6324
		// (set) Token: 0x06005B26 RID: 23334 RVA: 0x0002ADA9 File Offset: 0x00028FA9
		public unsafe NPCEvent_StayInBuilding HomeEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_HomeEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCEvent_StayInBuilding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_HomeEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B57 RID: 6999
		// (get) Token: 0x06005B27 RID: 23335 RVA: 0x001A8154 File Offset: 0x001A6354
		// (set) Token: 0x06005B28 RID: 23336 RVA: 0x0002ADC8 File Offset: 0x00028FC8
		public unsafe DialogueController_Dealer DialogueController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_DialogueController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController_Dealer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_DialogueController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B58 RID: 7000
		// (get) Token: 0x06005B29 RID: 23337 RVA: 0x001A8184 File Offset: 0x001A6384
		// (set) Token: 0x06005B2A RID: 23338 RVA: 0x0002ADE7 File Offset: 0x00028FE7
		public unsafe DialogueContainer RecruitDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_RecruitDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_RecruitDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B59 RID: 7001
		// (get) Token: 0x06005B2B RID: 23339 RVA: 0x001A81B4 File Offset: 0x001A63B4
		// (set) Token: 0x06005B2C RID: 23340 RVA: 0x0002AE06 File Offset: 0x00029006
		public unsafe DialogueContainer CollectCashDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_CollectCashDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_CollectCashDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B5A RID: 7002
		// (get) Token: 0x06005B2D RID: 23341 RVA: 0x001A81E4 File Offset: 0x001A63E4
		// (set) Token: 0x06005B2E RID: 23342 RVA: 0x0002AE25 File Offset: 0x00029025
		public unsafe DialogueContainer AssignCustomersDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_AssignCustomersDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_AssignCustomersDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B5B RID: 7003
		// (get) Token: 0x06005B2F RID: 23343 RVA: 0x001A8214 File Offset: 0x001A6414
		// (set) Token: 0x06005B30 RID: 23344 RVA: 0x0002AE44 File Offset: 0x00029044
		public unsafe string HomeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_HomeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_HomeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001B5C RID: 7004
		// (get) Token: 0x06005B31 RID: 23345 RVA: 0x001A823C File Offset: 0x001A643C
		// (set) Token: 0x06005B32 RID: 23346 RVA: 0x0002AE63 File Offset: 0x00029063
		public unsafe float SigningFee
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_SigningFee);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_SigningFee)) = value;
			}
		}

		// Token: 0x17001B5D RID: 7005
		// (get) Token: 0x06005B33 RID: 23347 RVA: 0x001A8264 File Offset: 0x001A6464
		// (set) Token: 0x06005B34 RID: 23348 RVA: 0x0002AE7E File Offset: 0x0002907E
		public unsafe float Cut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_Cut);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_Cut)) = value;
			}
		}

		// Token: 0x17001B5E RID: 7006
		// (get) Token: 0x06005B35 RID: 23349 RVA: 0x001A828C File Offset: 0x001A648C
		// (set) Token: 0x06005B36 RID: 23350 RVA: 0x0002AE99 File Offset: 0x00029099
		public unsafe bool SellInsufficientQualityItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_SellInsufficientQualityItems);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_SellInsufficientQualityItems)) = value;
			}
		}

		// Token: 0x17001B5F RID: 7007
		// (get) Token: 0x06005B37 RID: 23351 RVA: 0x001A82B4 File Offset: 0x001A64B4
		// (set) Token: 0x06005B38 RID: 23352 RVA: 0x0002AEB4 File Offset: 0x000290B4
		public unsafe bool SellExcessQualityItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_SellExcessQualityItems);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_SellExcessQualityItems)) = value;
			}
		}

		// Token: 0x17001B60 RID: 7008
		// (get) Token: 0x06005B39 RID: 23353 RVA: 0x001A82DC File Offset: 0x001A64DC
		// (set) Token: 0x06005B3A RID: 23354 RVA: 0x0002AECF File Offset: 0x000290CF
		public unsafe string CompletedDealsVariable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_CompletedDealsVariable);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_CompletedDealsVariable), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001B61 RID: 7009
		// (get) Token: 0x06005B3B RID: 23355 RVA: 0x001A8304 File Offset: 0x001A6504
		// (set) Token: 0x06005B3C RID: 23356 RVA: 0x0002AEEE File Offset: 0x000290EE
		public unsafe float _Cash_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__Cash_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__Cash_k__BackingField)) = value;
			}
		}

		// Token: 0x17001B62 RID: 7010
		// (get) Token: 0x06005B3D RID: 23357 RVA: 0x001A832C File Offset: 0x001A652C
		// (set) Token: 0x06005B3E RID: 23358 RVA: 0x0002AF09 File Offset: 0x00029109
		public unsafe List<Customer> AssignedCustomers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_AssignedCustomers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Customer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_AssignedCustomers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B63 RID: 7011
		// (get) Token: 0x06005B3F RID: 23359 RVA: 0x001A835C File Offset: 0x001A655C
		// (set) Token: 0x06005B40 RID: 23360 RVA: 0x0002AF28 File Offset: 0x00029128
		public unsafe List<Contract> ActiveContracts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_ActiveContracts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Contract>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_ActiveContracts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B64 RID: 7012
		// (get) Token: 0x06005B41 RID: 23361 RVA: 0x001A838C File Offset: 0x001A658C
		// (set) Token: 0x06005B42 RID: 23362 RVA: 0x0002AF47 File Offset: 0x00029147
		public unsafe bool _HasBeenRecommended_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__HasBeenRecommended_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__HasBeenRecommended_k__BackingField)) = value;
			}
		}

		// Token: 0x17001B65 RID: 7013
		// (get) Token: 0x06005B43 RID: 23363 RVA: 0x001A83B4 File Offset: 0x001A65B4
		// (set) Token: 0x06005B44 RID: 23364 RVA: 0x0002AF62 File Offset: 0x00029162
		public unsafe UnityEvent onRecommended
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_onRecommended);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_onRecommended), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B66 RID: 7014
		// (get) Token: 0x06005B45 RID: 23365 RVA: 0x001A83E4 File Offset: 0x001A65E4
		// (set) Token: 0x06005B46 RID: 23366 RVA: 0x0002AF81 File Offset: 0x00029181
		public unsafe Il2CppReferenceArray<ItemSlot> OverflowSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_OverflowSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_OverflowSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B67 RID: 7015
		// (get) Token: 0x06005B47 RID: 23367 RVA: 0x001A8414 File Offset: 0x001A6614
		// (set) Token: 0x06005B48 RID: 23368 RVA: 0x0002AFA0 File Offset: 0x000291A0
		public unsafe Contract currentContract
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_currentContract);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Contract>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_currentContract), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B68 RID: 7016
		// (get) Token: 0x06005B49 RID: 23369 RVA: 0x001A8444 File Offset: 0x001A6644
		// (set) Token: 0x06005B4A RID: 23370 RVA: 0x0002AFBF File Offset: 0x000291BF
		public unsafe DialogueController.DialogueChoice recruitChoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_recruitChoice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_recruitChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B69 RID: 7017
		// (get) Token: 0x06005B4B RID: 23371 RVA: 0x001A8474 File Offset: 0x001A6674
		// (set) Token: 0x06005B4C RID: 23372 RVA: 0x0002AFDE File Offset: 0x000291DE
		public unsafe DialogueController.DialogueChoice collectCashChoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_collectCashChoice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_collectCashChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B6A RID: 7018
		// (get) Token: 0x06005B4D RID: 23373 RVA: 0x001A84A4 File Offset: 0x001A66A4
		// (set) Token: 0x06005B4E RID: 23374 RVA: 0x0002AFFD File Offset: 0x000291FD
		public unsafe DialogueController.DialogueChoice assignCustomersChoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_assignCustomersChoice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_assignCustomersChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B6B RID: 7019
		// (get) Token: 0x06005B4F RID: 23375 RVA: 0x001A84D4 File Offset: 0x001A66D4
		// (set) Token: 0x06005B50 RID: 23376 RVA: 0x0002B01C File Offset: 0x0002921C
		public unsafe NPCPoI _potentialDealerPoI_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__potentialDealerPoI_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCPoI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__potentialDealerPoI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B6C RID: 7020
		// (get) Token: 0x06005B51 RID: 23377 RVA: 0x001A8504 File Offset: 0x001A6704
		// (set) Token: 0x06005B52 RID: 23378 RVA: 0x0002B03B File Offset: 0x0002923B
		public unsafe NPCPoI _dealerPoI_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__dealerPoI_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCPoI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__dealerPoI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B6D RID: 7021
		// (get) Token: 0x06005B53 RID: 23379 RVA: 0x001A8534 File Offset: 0x001A6734
		// (set) Token: 0x06005B54 RID: 23380 RVA: 0x0002B05A File Offset: 0x0002925A
		public unsafe List<string> acceptedContractGUIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_acceptedContractGUIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_acceptedContractGUIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B6E RID: 7022
		// (get) Token: 0x06005B55 RID: 23381 RVA: 0x001A8564 File Offset: 0x001A6764
		// (set) Token: 0x06005B56 RID: 23382 RVA: 0x0002B079 File Offset: 0x00029279
		public unsafe int itemCountOnTradeStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_itemCountOnTradeStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_itemCountOnTradeStart)) = value;
			}
		}

		// Token: 0x17001B6F RID: 7023
		// (get) Token: 0x06005B57 RID: 23383 RVA: 0x001A858C File Offset: 0x001A678C
		// (set) Token: 0x06005B58 RID: 23384 RVA: 0x0002B094 File Offset: 0x00029294
		public unsafe SyncVar<float> syncVar____Cash_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_syncVar____Cash_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_syncVar____Cash_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B70 RID: 7024
		// (get) Token: 0x06005B59 RID: 23385 RVA: 0x001A85BC File Offset: 0x001A67BC
		// (set) Token: 0x06005B5A RID: 23386 RVA: 0x0002B0B3 File Offset: 0x000292B3
		public unsafe SyncVar<List<string>> syncVar___acceptedContractGUIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_syncVar___acceptedContractGUIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<List<string>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_syncVar___acceptedContractGUIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B71 RID: 7025
		// (get) Token: 0x06005B5B RID: 23387 RVA: 0x001A85EC File Offset: 0x001A67EC
		// (set) Token: 0x06005B5C RID: 23388 RVA: 0x0002B0D2 File Offset: 0x000292D2
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001B72 RID: 7026
		// (get) Token: 0x06005B5D RID: 23389 RVA: 0x001A8614 File Offset: 0x001A6814
		// (set) Token: 0x06005B5E RID: 23390 RVA: 0x0002B0ED File Offset: 0x000292ED
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003DC1 RID: 15809
		private static readonly IntPtr NativeFieldInfoPtr_MAX_CUSTOMERS;

		// Token: 0x04003DC2 RID: 15810
		private static readonly IntPtr NativeFieldInfoPtr_DEAL_ARRIVAL_DELAY;

		// Token: 0x04003DC3 RID: 15811
		private static readonly IntPtr NativeFieldInfoPtr_MIN_TRAVEL_TIME;

		// Token: 0x04003DC4 RID: 15812
		private static readonly IntPtr NativeFieldInfoPtr_MAX_TRAVEL_TIME;

		// Token: 0x04003DC5 RID: 15813
		private static readonly IntPtr NativeFieldInfoPtr_OVERFLOW_SLOT_COUNT;

		// Token: 0x04003DC6 RID: 15814
		private static readonly IntPtr NativeFieldInfoPtr_CASH_REMINDER_THRESHOLD;

		// Token: 0x04003DC7 RID: 15815
		private static readonly IntPtr NativeFieldInfoPtr_RELATIONSHIP_CHANGE_PER_DEAL;

		// Token: 0x04003DC8 RID: 15816
		private static readonly IntPtr NativeFieldInfoPtr_onDealerRecruited;

		// Token: 0x04003DC9 RID: 15817
		private static readonly IntPtr NativeFieldInfoPtr_DealerLabelColor;

		// Token: 0x04003DCA RID: 15818
		private static readonly IntPtr NativeFieldInfoPtr_AllDealers;

		// Token: 0x04003DCB RID: 15819
		private static readonly IntPtr NativeFieldInfoPtr__IsRecruited_k__BackingField;

		// Token: 0x04003DCC RID: 15820
		private static readonly IntPtr NativeFieldInfoPtr__ItemSlots_k__BackingField;

		// Token: 0x04003DCD RID: 15821
		private static readonly IntPtr NativeFieldInfoPtr_InitialCustomers;

		// Token: 0x04003DCE RID: 15822
		private static readonly IntPtr NativeFieldInfoPtr_InitialItems;

		// Token: 0x04003DCF RID: 15823
		private static readonly IntPtr NativeFieldInfoPtr_Home;

		// Token: 0x04003DD0 RID: 15824
		private static readonly IntPtr NativeFieldInfoPtr_DealSignal;

		// Token: 0x04003DD1 RID: 15825
		private static readonly IntPtr NativeFieldInfoPtr_HomeEvent;

		// Token: 0x04003DD2 RID: 15826
		private static readonly IntPtr NativeFieldInfoPtr_DialogueController;

		// Token: 0x04003DD3 RID: 15827
		private static readonly IntPtr NativeFieldInfoPtr_RecruitDialogue;

		// Token: 0x04003DD4 RID: 15828
		private static readonly IntPtr NativeFieldInfoPtr_CollectCashDialogue;

		// Token: 0x04003DD5 RID: 15829
		private static readonly IntPtr NativeFieldInfoPtr_AssignCustomersDialogue;

		// Token: 0x04003DD6 RID: 15830
		private static readonly IntPtr NativeFieldInfoPtr_HomeName;

		// Token: 0x04003DD7 RID: 15831
		private static readonly IntPtr NativeFieldInfoPtr_SigningFee;

		// Token: 0x04003DD8 RID: 15832
		private static readonly IntPtr NativeFieldInfoPtr_Cut;

		// Token: 0x04003DD9 RID: 15833
		private static readonly IntPtr NativeFieldInfoPtr_SellInsufficientQualityItems;

		// Token: 0x04003DDA RID: 15834
		private static readonly IntPtr NativeFieldInfoPtr_SellExcessQualityItems;

		// Token: 0x04003DDB RID: 15835
		private static readonly IntPtr NativeFieldInfoPtr_CompletedDealsVariable;

		// Token: 0x04003DDC RID: 15836
		private static readonly IntPtr NativeFieldInfoPtr__Cash_k__BackingField;

		// Token: 0x04003DDD RID: 15837
		private static readonly IntPtr NativeFieldInfoPtr_AssignedCustomers;

		// Token: 0x04003DDE RID: 15838
		private static readonly IntPtr NativeFieldInfoPtr_ActiveContracts;

		// Token: 0x04003DDF RID: 15839
		private static readonly IntPtr NativeFieldInfoPtr__HasBeenRecommended_k__BackingField;

		// Token: 0x04003DE0 RID: 15840
		private static readonly IntPtr NativeFieldInfoPtr_onRecommended;

		// Token: 0x04003DE1 RID: 15841
		private static readonly IntPtr NativeFieldInfoPtr_OverflowSlots;

		// Token: 0x04003DE2 RID: 15842
		private static readonly IntPtr NativeFieldInfoPtr_currentContract;

		// Token: 0x04003DE3 RID: 15843
		private static readonly IntPtr NativeFieldInfoPtr_recruitChoice;

		// Token: 0x04003DE4 RID: 15844
		private static readonly IntPtr NativeFieldInfoPtr_collectCashChoice;

		// Token: 0x04003DE5 RID: 15845
		private static readonly IntPtr NativeFieldInfoPtr_assignCustomersChoice;

		// Token: 0x04003DE6 RID: 15846
		private static readonly IntPtr NativeFieldInfoPtr__potentialDealerPoI_k__BackingField;

		// Token: 0x04003DE7 RID: 15847
		private static readonly IntPtr NativeFieldInfoPtr__dealerPoI_k__BackingField;

		// Token: 0x04003DE8 RID: 15848
		private static readonly IntPtr NativeFieldInfoPtr_acceptedContractGUIDs;

		// Token: 0x04003DE9 RID: 15849
		private static readonly IntPtr NativeFieldInfoPtr_itemCountOnTradeStart;

		// Token: 0x04003DEA RID: 15850
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____Cash_k__BackingField;

		// Token: 0x04003DEB RID: 15851
		private static readonly IntPtr NativeFieldInfoPtr_syncVar___acceptedContractGUIDs;

		// Token: 0x04003DEC RID: 15852
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003DED RID: 15853
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003DEE RID: 15854
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRecruited_Public_get_Boolean_0;

		// Token: 0x04003DEF RID: 15855
		private static readonly IntPtr NativeMethodInfoPtr_set_IsRecruited_Private_set_Void_Boolean_0;

		// Token: 0x04003DF0 RID: 15856
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x04003DF1 RID: 15857
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x04003DF2 RID: 15858
		private static readonly IntPtr NativeMethodInfoPtr_get_Cash_Public_get_Single_0;

		// Token: 0x04003DF3 RID: 15859
		private static readonly IntPtr NativeMethodInfoPtr_set_Cash_Private_set_Void_Single_0;

		// Token: 0x04003DF4 RID: 15860
		private static readonly IntPtr NativeMethodInfoPtr_get_HasBeenRecommended_Public_get_Boolean_0;

		// Token: 0x04003DF5 RID: 15861
		private static readonly IntPtr NativeMethodInfoPtr_set_HasBeenRecommended_Private_set_Void_Boolean_0;

		// Token: 0x04003DF6 RID: 15862
		private static readonly IntPtr NativeMethodInfoPtr_get_potentialDealerPoI_Public_get_NPCPoI_0;

		// Token: 0x04003DF7 RID: 15863
		private static readonly IntPtr NativeMethodInfoPtr_set_potentialDealerPoI_Protected_set_Void_NPCPoI_0;

		// Token: 0x04003DF8 RID: 15864
		private static readonly IntPtr NativeMethodInfoPtr_get_dealerPoI_Public_get_NPCPoI_0;

		// Token: 0x04003DF9 RID: 15865
		private static readonly IntPtr NativeMethodInfoPtr_set_dealerPoI_Protected_set_Void_NPCPoI_0;

		// Token: 0x04003DFA RID: 15866
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04003DFB RID: 15867
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_1;

		// Token: 0x04003DFC RID: 15868
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1;

		// Token: 0x04003DFD RID: 15869
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x04003DFE RID: 15870
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003DFF RID: 15871
		private static readonly IntPtr NativeMethodInfoPtr_SetupPoI_Private_Void_0;

		// Token: 0x04003E00 RID: 15872
		private static readonly IntPtr NativeMethodInfoPtr_SetUpDialogue_Private_Void_0;

		// Token: 0x04003E01 RID: 15873
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_1;

		// Token: 0x04003E02 RID: 15874
		private static readonly IntPtr NativeMethodInfoPtr_MarkAsRecommended_Public_Void_0;

		// Token: 0x04003E03 RID: 15875
		private static readonly IntPtr NativeMethodInfoPtr_SetRecommended_Private_Void_0;

		// Token: 0x04003E04 RID: 15876
		private static readonly IntPtr NativeMethodInfoPtr_InitialRecruitment_Public_Void_0;

		// Token: 0x04003E05 RID: 15877
		private static readonly IntPtr NativeMethodInfoPtr_SetIsRecruited_Public_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x04003E06 RID: 15878
		private static readonly IntPtr NativeMethodInfoPtr_OnDealerUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0;

		// Token: 0x04003E07 RID: 15879
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePotentialDealerPoI_Protected_Virtual_New_Void_0;

		// Token: 0x04003E08 RID: 15880
		private static readonly IntPtr NativeMethodInfoPtr_TradeItems_Private_Void_0;

		// Token: 0x04003E09 RID: 15881
		private static readonly IntPtr NativeMethodInfoPtr_TradeItemsDone_Private_Void_0;

		// Token: 0x04003E0A RID: 15882
		private static readonly IntPtr NativeMethodInfoPtr_CanCollectCash_Private_Boolean_byref_String_0;

		// Token: 0x04003E0B RID: 15883
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCollectCashChoice_Private_Void_Single_Single_Boolean_0;

		// Token: 0x04003E0C RID: 15884
		private static readonly IntPtr NativeMethodInfoPtr_CollectCash_Private_Void_0;

		// Token: 0x04003E0D RID: 15885
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCurrentDeal_Private_Void_0;

		// Token: 0x04003E0E RID: 15886
		private static readonly IntPtr NativeMethodInfoPtr_CanOfferRecruitment_Private_Boolean_byref_String_0;

		// Token: 0x04003E0F RID: 15887
		private static readonly IntPtr NativeMethodInfoPtr_CheckAttendStart_Private_Void_0;

		// Token: 0x04003E10 RID: 15888
		private static readonly IntPtr NativeMethodInfoPtr_ShouldAcceptContract_Public_Virtual_New_Boolean_ContractInfo_Customer_0;

		// Token: 0x04003E11 RID: 15889
		private static readonly IntPtr NativeMethodInfoPtr_ContractedOffered_Public_Virtual_New_Void_ContractInfo_Customer_0;

		// Token: 0x04003E12 RID: 15890
		private static readonly IntPtr NativeMethodInfoPtr_SendAddCustomer_Public_Void_String_0;

		// Token: 0x04003E13 RID: 15891
		private static readonly IntPtr NativeMethodInfoPtr_AddCustomer_Private_Void_NetworkConnection_String_0;

		// Token: 0x04003E14 RID: 15892
		private static readonly IntPtr NativeMethodInfoPtr_AddCustomer_Protected_Virtual_New_Void_Customer_0;

		// Token: 0x04003E15 RID: 15893
		private static readonly IntPtr NativeMethodInfoPtr_SendRemoveCustomer_Public_Void_String_0;

		// Token: 0x04003E16 RID: 15894
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCustomer_Private_Void_String_0;

		// Token: 0x04003E17 RID: 15895
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCustomer_Public_Virtual_New_Void_Customer_0;

		// Token: 0x04003E18 RID: 15896
		private static readonly IntPtr NativeMethodInfoPtr_ChangeCash_Public_Void_Single_0;

		// Token: 0x04003E19 RID: 15897
		private static readonly IntPtr NativeMethodInfoPtr_SetCash_Public_Void_Single_0;

		// Token: 0x04003E1A RID: 15898
		private static readonly IntPtr NativeMethodInfoPtr_CompletedDeal_Public_Virtual_New_Void_0;

		// Token: 0x04003E1B RID: 15899
		private static readonly IntPtr NativeMethodInfoPtr_SubmitPayment_Public_Void_Single_0;

		// Token: 0x04003E1C RID: 15900
		private static readonly IntPtr NativeMethodInfoPtr_GetOrderableProducts_Public_List_1_ProductDefinition_0;

		// Token: 0x04003E1D RID: 15901
		private static readonly IntPtr NativeMethodInfoPtr_GetProductCount_Public_Int32_String_EQuality_EQuality_0;

		// Token: 0x04003E1E RID: 15902
		private static readonly IntPtr NativeMethodInfoPtr_GetDealWindow_Private_EDealWindow_0;

		// Token: 0x04003E1F RID: 15903
		private static readonly IntPtr NativeMethodInfoPtr_GetContractCountInWindow_Private_Int32_EDealWindow_0;

		// Token: 0x04003E20 RID: 15904
		private static readonly IntPtr NativeMethodInfoPtr_CustomerContractStarted_Private_Void_Contract_0;

		// Token: 0x04003E21 RID: 15905
		private static readonly IntPtr NativeMethodInfoPtr_CustomerContractEnded_Private_Void_Contract_0;

		// Token: 0x04003E22 RID: 15906
		private static readonly IntPtr NativeMethodInfoPtr_SortContracts_Private_Void_0;

		// Token: 0x04003E23 RID: 15907
		private static readonly IntPtr NativeMethodInfoPtr_RecruitmentRequested_Protected_Virtual_New_Void_0;

		// Token: 0x04003E24 RID: 15908
		private static readonly IntPtr NativeMethodInfoPtr_RemoveContractItems_Public_Boolean_Contract_EQuality_byref_List_1_ItemInstance_0;

		// Token: 0x04003E25 RID: 15909
		private static readonly IntPtr NativeMethodInfoPtr_GetItems_Private_List_1_ItemInstance_String_Int32_Func_2_ProductItemInstance_Boolean_byref_Int32_0;

		// Token: 0x04003E26 RID: 15910
		private static readonly IntPtr NativeMethodInfoPtr_GetAllSlots_Public_List_1_ItemSlot_0;

		// Token: 0x04003E27 RID: 15911
		private static readonly IntPtr NativeMethodInfoPtr_AddItemToInventory_Public_Void_ItemInstance_0;

		// Token: 0x04003E28 RID: 15912
		private static readonly IntPtr NativeMethodInfoPtr_TryMoveOverflowItems_Public_Void_0;

		// Token: 0x04003E29 RID: 15913
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalInventoryItemCount_Public_Int32_0;

		// Token: 0x04003E2A RID: 15914
		private static readonly IntPtr NativeMethodInfoPtr_SetStoredInstance_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04003E2B RID: 15915
		private static readonly IntPtr NativeMethodInfoPtr_SetStoredInstance_Internal_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04003E2C RID: 15916
		private static readonly IntPtr NativeMethodInfoPtr_SetItemSlotQuantity_Public_Virtual_Final_New_Void_Int32_Int32_0;

		// Token: 0x04003E2D RID: 15917
		private static readonly IntPtr NativeMethodInfoPtr_SetItemSlotQuantity_Internal_Private_Void_Int32_Int32_0;

		// Token: 0x04003E2E RID: 15918
		private static readonly IntPtr NativeMethodInfoPtr_SetSlotLocked_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04003E2F RID: 15919
		private static readonly IntPtr NativeMethodInfoPtr_SetSlotLocked_Internal_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04003E30 RID: 15920
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04003E31 RID: 15921
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_NPCData_String_0;

		// Token: 0x04003E32 RID: 15922
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003E33 RID: 15923
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__59_0_Private_Void_EUnlockType_Boolean_0;

		// Token: 0x04003E34 RID: 15924
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003E35 RID: 15925
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003E36 RID: 15926
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003E37 RID: 15927
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_MarkAsRecommended_2166136261_Private_Void_0;

		// Token: 0x04003E38 RID: 15928
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___MarkAsRecommended_2166136261_Public_Void_0;

		// Token: 0x04003E39 RID: 15929
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_MarkAsRecommended_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003E3A RID: 15930
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetRecommended_2166136261_Private_Void_0;

		// Token: 0x04003E3B RID: 15931
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetRecommended_2166136261_Private_Void_0;

		// Token: 0x04003E3C RID: 15932
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetRecommended_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003E3D RID: 15933
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_InitialRecruitment_2166136261_Private_Void_0;

		// Token: 0x04003E3E RID: 15934
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___InitialRecruitment_2166136261_Public_Void_0;

		// Token: 0x04003E3F RID: 15935
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_InitialRecruitment_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003E40 RID: 15936
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetIsRecruited_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04003E41 RID: 15937
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetIsRecruited_328543758_Public_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x04003E42 RID: 15938
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetIsRecruited_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003E43 RID: 15939
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetIsRecruited_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04003E44 RID: 15940
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetIsRecruited_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003E45 RID: 15941
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendAddCustomer_3615296227_Private_Void_String_0;

		// Token: 0x04003E46 RID: 15942
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendAddCustomer_3615296227_Public_Void_String_0;

		// Token: 0x04003E47 RID: 15943
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendAddCustomer_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003E48 RID: 15944
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddCustomer_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x04003E49 RID: 15945
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddCustomer_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x04003E4A RID: 15946
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddCustomer_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003E4B RID: 15947
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_AddCustomer_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x04003E4C RID: 15948
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_AddCustomer_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003E4D RID: 15949
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendRemoveCustomer_3615296227_Private_Void_String_0;

		// Token: 0x04003E4E RID: 15950
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendRemoveCustomer_3615296227_Public_Void_String_0;

		// Token: 0x04003E4F RID: 15951
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendRemoveCustomer_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003E50 RID: 15952
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_RemoveCustomer_3615296227_Private_Void_String_0;

		// Token: 0x04003E51 RID: 15953
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RemoveCustomer_3615296227_Private_Void_String_0;

		// Token: 0x04003E52 RID: 15954
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_RemoveCustomer_3615296227_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003E53 RID: 15955
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetCash_431000436_Private_Void_Single_0;

		// Token: 0x04003E54 RID: 15956
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetCash_431000436_Public_Void_Single_0;

		// Token: 0x04003E55 RID: 15957
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetCash_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003E56 RID: 15958
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_CompletedDeal_2166136261_Private_Void_0;

		// Token: 0x04003E57 RID: 15959
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___CompletedDeal_2166136261_Public_Virtual_New_Void_0;

		// Token: 0x04003E58 RID: 15960
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_CompletedDeal_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003E59 RID: 15961
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SubmitPayment_431000436_Private_Void_Single_0;

		// Token: 0x04003E5A RID: 15962
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SubmitPayment_431000436_Public_Void_Single_0;

		// Token: 0x04003E5B RID: 15963
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SubmitPayment_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003E5C RID: 15964
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetStoredInstance_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04003E5D RID: 15965
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetStoredInstance_2652194801_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04003E5E RID: 15966
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetStoredInstance_2652194801_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003E5F RID: 15967
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04003E60 RID: 15968
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04003E61 RID: 15969
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003E62 RID: 15970
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04003E63 RID: 15971
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003E64 RID: 15972
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetItemSlotQuantity_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x04003E65 RID: 15973
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_1692629761_Public_Virtual_Final_New_Void_Int32_Int32_0;

		// Token: 0x04003E66 RID: 15974
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetItemSlotQuantity_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003E67 RID: 15975
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x04003E68 RID: 15976
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x04003E69 RID: 15977
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003E6A RID: 15978
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetSlotLocked_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04003E6B RID: 15979
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetSlotLocked_3170825843_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04003E6C RID: 15980
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetSlotLocked_3170825843_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003E6D RID: 15981
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04003E6E RID: 15982
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04003E6F RID: 15983
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003E70 RID: 15984
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04003E71 RID: 15985
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003E72 RID: 15986
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__Cash_k__BackingField_Public_get_Single_0;

		// Token: 0x04003E73 RID: 15987
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__Cash_k__BackingField_Public_set_Void_Single_Boolean_0;

		// Token: 0x04003E74 RID: 15988
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Dealer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04003E75 RID: 15989
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value_acceptedContractGUIDs_Public_get_List_1_String_0;

		// Token: 0x04003E76 RID: 15990
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value_acceptedContractGUIDs_Public_set_Void_List_1_String_Boolean_0;

		// Token: 0x04003E77 RID: 15991
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x020009E6 RID: 2534
		[ObfuscatedName("ScheduleOne.Economy.Dealer+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CD6C RID: 52588 RVA: 0x00317B6C File Offset: 0x00315D6C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr);
				Dealer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, "<>9");
				Dealer.__c.NativeFieldInfoPtr___9__99_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, "<>9__99_0");
				Dealer.__c.NativeFieldInfoPtr___9__102_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, "<>9__102_0");
				Dealer.__c.NativeFieldInfoPtr___9__102_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, "<>9__102_1");
				Dealer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, 100674953);
				Dealer.__c.NativeMethodInfoPtr__SortContracts_b__99_0_Internal_Int32_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, 100674954);
				Dealer.__c.NativeMethodInfoPtr__GetItems_b__102_0_Internal_Int32_ItemSlot_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, 100674955);
				Dealer.__c.NativeMethodInfoPtr__GetItems_b__102_1_Internal_Int32_ItemSlot_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, 100674956);
			}

			// Token: 0x0600CD6D RID: 52589 RVA: 0x00317C38 File Offset: 0x00315E38
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD6E RID: 52590 RVA: 0x00317C74 File Offset: 0x00315E74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190883, XrefRangeEnd = 190885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SortContracts_b__99_0(Contract x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c.NativeMethodInfoPtr__SortContracts_b__99_0_Internal_Int32_Contract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD6F RID: 52591 RVA: 0x00317CC4 File Offset: 0x00315EC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190885, XrefRangeEnd = 190891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetItems_b__102_0(ItemSlot x, ItemSlot y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c.NativeMethodInfoPtr__GetItems_b__102_0_Internal_Int32_ItemSlot_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD70 RID: 52592 RVA: 0x00317D24 File Offset: 0x00315F24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190891, XrefRangeEnd = 190897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetItems_b__102_1(ItemSlot x, ItemSlot y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c.NativeMethodInfoPtr__GetItems_b__102_1_Internal_Int32_ItemSlot_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD71 RID: 52593 RVA: 0x00063E93 File Offset: 0x00062093
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FF2 RID: 16370
			// (get) Token: 0x0600CD72 RID: 52594 RVA: 0x00317D84 File Offset: 0x00315F84
			// (set) Token: 0x0600CD73 RID: 52595 RVA: 0x00063E9C File Offset: 0x0006209C
			public unsafe static Dealer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Dealer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Dealer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FF3 RID: 16371
			// (get) Token: 0x0600CD74 RID: 52596 RVA: 0x00317DAC File Offset: 0x00315FAC
			// (set) Token: 0x0600CD75 RID: 52597 RVA: 0x00063EAE File Offset: 0x000620AE
			public unsafe static Func<Contract, int> __9__99_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Dealer.__c.NativeFieldInfoPtr___9__99_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Contract, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Dealer.__c.NativeFieldInfoPtr___9__99_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FF4 RID: 16372
			// (get) Token: 0x0600CD76 RID: 52598 RVA: 0x00317DD4 File Offset: 0x00315FD4
			// (set) Token: 0x0600CD77 RID: 52599 RVA: 0x00063EC0 File Offset: 0x000620C0
			public unsafe static Comparison<ItemSlot> __9__102_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Dealer.__c.NativeFieldInfoPtr___9__102_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<ItemSlot>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Dealer.__c.NativeFieldInfoPtr___9__102_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FF5 RID: 16373
			// (get) Token: 0x0600CD78 RID: 52600 RVA: 0x00317DFC File Offset: 0x00315FFC
			// (set) Token: 0x0600CD79 RID: 52601 RVA: 0x00063ED2 File Offset: 0x000620D2
			public unsafe static Comparison<ItemSlot> __9__102_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Dealer.__c.NativeFieldInfoPtr___9__102_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<ItemSlot>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Dealer.__c.NativeFieldInfoPtr___9__102_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008AC9 RID: 35529
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008ACA RID: 35530
			private static readonly IntPtr NativeFieldInfoPtr___9__99_0;

			// Token: 0x04008ACB RID: 35531
			private static readonly IntPtr NativeFieldInfoPtr___9__102_0;

			// Token: 0x04008ACC RID: 35532
			private static readonly IntPtr NativeFieldInfoPtr___9__102_1;

			// Token: 0x04008ACD RID: 35533
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008ACE RID: 35534
			private static readonly IntPtr NativeMethodInfoPtr__SortContracts_b__99_0_Internal_Int32_Contract_0;

			// Token: 0x04008ACF RID: 35535
			private static readonly IntPtr NativeMethodInfoPtr__GetItems_b__102_0_Internal_Int32_ItemSlot_ItemSlot_0;

			// Token: 0x04008AD0 RID: 35536
			private static readonly IntPtr NativeMethodInfoPtr__GetItems_b__102_1_Internal_Int32_ItemSlot_ItemSlot_0;
		}

		// Token: 0x020009E7 RID: 2535
		[ObfuscatedName("ScheduleOne.Economy.Dealer+<>c__DisplayClass101_0")]
		public sealed class __c__DisplayClass101_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CD7A RID: 52602 RVA: 0x00317E24 File Offset: 0x00316024
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass101_0()
			{
				Il2CppClassPointerStore<Dealer.__c__DisplayClass101_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<>c__DisplayClass101_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dealer.__c__DisplayClass101_0>.NativeClassPtr);
				Dealer.__c__DisplayClass101_0.NativeFieldInfoPtr_targetQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c__DisplayClass101_0>.NativeClassPtr, "targetQuality");
				Dealer.__c__DisplayClass101_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c__DisplayClass101_0>.NativeClassPtr, "<>4__this");
				Dealer.__c__DisplayClass101_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c__DisplayClass101_0>.NativeClassPtr, 100674957);
				Dealer.__c__DisplayClass101_0.NativeMethodInfoPtr_Method_Internal_Boolean_ProductItemInstance_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c__DisplayClass101_0>.NativeClassPtr, 100674958);
			}

			// Token: 0x0600CD7B RID: 52603 RVA: 0x00317EA0 File Offset: 0x003160A0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass101_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dealer.__c__DisplayClass101_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c__DisplayClass101_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD7C RID: 52604 RVA: 0x00317EDC File Offset: 0x003160DC
			[CallerCount(0)]
			public unsafe bool Method_Internal_Boolean_ProductItemInstance_PDM_0(ProductItemInstance product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c__DisplayClass101_0.NativeMethodInfoPtr_Method_Internal_Boolean_ProductItemInstance_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD7D RID: 52605 RVA: 0x00063EE4 File Offset: 0x000620E4
			public __c__DisplayClass101_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FF6 RID: 16374
			// (get) Token: 0x0600CD7E RID: 52606 RVA: 0x00317F2C File Offset: 0x0031612C
			// (set) Token: 0x0600CD7F RID: 52607 RVA: 0x00063EED File Offset: 0x000620ED
			public unsafe EQuality targetQuality
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass101_0.NativeFieldInfoPtr_targetQuality);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass101_0.NativeFieldInfoPtr_targetQuality)) = value;
				}
			}

			// Token: 0x17003FF7 RID: 16375
			// (get) Token: 0x0600CD80 RID: 52608 RVA: 0x00317F54 File Offset: 0x00316154
			// (set) Token: 0x0600CD81 RID: 52609 RVA: 0x00063F08 File Offset: 0x00062108
			public unsafe Dealer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass101_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass101_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008AD1 RID: 35537
			private static readonly IntPtr NativeFieldInfoPtr_targetQuality;

			// Token: 0x04008AD2 RID: 35538
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008AD3 RID: 35539
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008AD4 RID: 35540
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Boolean_ProductItemInstance_PDM_0;
		}

		// Token: 0x020009E8 RID: 2536
		[ObfuscatedName("ScheduleOne.Economy.Dealer+<>c__DisplayClass93_0")]
		public sealed class __c__DisplayClass93_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CD82 RID: 52610 RVA: 0x00317F84 File Offset: 0x00316184
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass93_0()
			{
				Il2CppClassPointerStore<Dealer.__c__DisplayClass93_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<>c__DisplayClass93_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dealer.__c__DisplayClass93_0>.NativeClassPtr);
				Dealer.__c__DisplayClass93_0.NativeFieldInfoPtr_product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c__DisplayClass93_0>.NativeClassPtr, "product");
				Dealer.__c__DisplayClass93_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c__DisplayClass93_0>.NativeClassPtr, 100674959);
				Dealer.__c__DisplayClass93_0.NativeMethodInfoPtr__GetOrderableProducts_b__0_Internal_Boolean_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c__DisplayClass93_0>.NativeClassPtr, 100674960);
			}

			// Token: 0x0600CD83 RID: 52611 RVA: 0x00317FEC File Offset: 0x003161EC
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass93_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dealer.__c__DisplayClass93_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c__DisplayClass93_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD84 RID: 52612 RVA: 0x00318028 File Offset: 0x00316228
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190897, XrefRangeEnd = 190899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetOrderableProducts_b__0(ProductDefinition x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c__DisplayClass93_0.NativeMethodInfoPtr__GetOrderableProducts_b__0_Internal_Boolean_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD85 RID: 52613 RVA: 0x00063F27 File Offset: 0x00062127
			public __c__DisplayClass93_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FF8 RID: 16376
			// (get) Token: 0x0600CD86 RID: 52614 RVA: 0x00318078 File Offset: 0x00316278
			// (set) Token: 0x0600CD87 RID: 52615 RVA: 0x00063F30 File Offset: 0x00062130
			public unsafe ProductItemInstance product
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass93_0.NativeFieldInfoPtr_product);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductItemInstance>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass93_0.NativeFieldInfoPtr_product), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008AD5 RID: 35541
			private static readonly IntPtr NativeFieldInfoPtr_product;

			// Token: 0x04008AD6 RID: 35542
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008AD7 RID: 35543
			private static readonly IntPtr NativeMethodInfoPtr__GetOrderableProducts_b__0_Internal_Boolean_ProductDefinition_0;
		}

		// Token: 0x020009E9 RID: 2537
		[ObfuscatedName("ScheduleOne.Economy.Dealer+<>c__DisplayClass97_0")]
		public sealed class __c__DisplayClass97_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CD88 RID: 52616 RVA: 0x003180A8 File Offset: 0x003162A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass97_0()
			{
				Il2CppClassPointerStore<Dealer.__c__DisplayClass97_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<>c__DisplayClass97_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dealer.__c__DisplayClass97_0>.NativeClassPtr);
				Dealer.__c__DisplayClass97_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c__DisplayClass97_0>.NativeClassPtr, "<>4__this");
				Dealer.__c__DisplayClass97_0.NativeFieldInfoPtr_contract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c__DisplayClass97_0>.NativeClassPtr, "contract");
				Dealer.__c__DisplayClass97_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c__DisplayClass97_0>.NativeClassPtr, 100674961);
				Dealer.__c__DisplayClass97_0.NativeMethodInfoPtr__CustomerContractStarted_b__0_Internal_Void_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c__DisplayClass97_0>.NativeClassPtr, 100674962);
			}

			// Token: 0x0600CD89 RID: 52617 RVA: 0x00318124 File Offset: 0x00316324
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass97_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dealer.__c__DisplayClass97_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c__DisplayClass97_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD8A RID: 52618 RVA: 0x00318160 File Offset: 0x00316360
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190899, XrefRangeEnd = 190916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CustomerContractStarted_b__0(EQuestState <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <p0>;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c__DisplayClass97_0.NativeMethodInfoPtr__CustomerContractStarted_b__0_Internal_Void_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD8B RID: 52619 RVA: 0x00063F4F File Offset: 0x0006214F
			public __c__DisplayClass97_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FF9 RID: 16377
			// (get) Token: 0x0600CD8C RID: 52620 RVA: 0x003181A0 File Offset: 0x003163A0
			// (set) Token: 0x0600CD8D RID: 52621 RVA: 0x00063F58 File Offset: 0x00062158
			public unsafe Dealer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass97_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass97_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FFA RID: 16378
			// (get) Token: 0x0600CD8E RID: 52622 RVA: 0x003181D0 File Offset: 0x003163D0
			// (set) Token: 0x0600CD8F RID: 52623 RVA: 0x00063F77 File Offset: 0x00062177
			public unsafe Contract contract
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass97_0.NativeFieldInfoPtr_contract);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Contract>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass97_0.NativeFieldInfoPtr_contract), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008AD8 RID: 35544
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008AD9 RID: 35545
			private static readonly IntPtr NativeFieldInfoPtr_contract;

			// Token: 0x04008ADA RID: 35546
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008ADB RID: 35547
			private static readonly IntPtr NativeMethodInfoPtr__CustomerContractStarted_b__0_Internal_Void_EQuestState_0;
		}
	}
}
