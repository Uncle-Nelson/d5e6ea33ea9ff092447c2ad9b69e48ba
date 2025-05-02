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
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.NPCs.Relation;
using Il2CppScheduleOne.NPCs.Schedules;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Properties;
using Il2CppScheduleOne.Quests;
using Il2CppScheduleOne.UI.Handover;
using Il2CppScheduleOne.UI.Phone.Messages;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x0200040D RID: 1037
	public class Customer : NetworkBehaviour
	{
		// Token: 0x060058C1 RID: 22721 RVA: 0x0019D9B8 File Offset: 0x0019BBB8
		// Note: this type is marked as 'beforefieldinit'.
		static Customer()
		{
			Il2CppClassPointerStore<Customer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "Customer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer>.NativeClassPtr);
			Customer.NativeFieldInfoPtr_onCustomerUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "onCustomerUnlocked");
			Customer.NativeFieldInfoPtr_UnlockedCustomers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "UnlockedCustomers");
			Customer.NativeFieldInfoPtr_AFFINITY_MAX_EFFECT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "AFFINITY_MAX_EFFECT");
			Customer.NativeFieldInfoPtr_PROPERTY_MAX_EFFECT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "PROPERTY_MAX_EFFECT");
			Customer.NativeFieldInfoPtr_QUALITY_MAX_EFFECT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "QUALITY_MAX_EFFECT");
			Customer.NativeFieldInfoPtr_DEAL_REJECTED_RELATIONSHIP_CHANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "DEAL_REJECTED_RELATIONSHIP_CHANGE");
			Customer.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "DEBUG");
			Customer.NativeFieldInfoPtr_APPROACH_MIN_ADDICTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "APPROACH_MIN_ADDICTION");
			Customer.NativeFieldInfoPtr_APPROACH_CHANCE_PER_DAY_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "APPROACH_CHANCE_PER_DAY_MAX");
			Customer.NativeFieldInfoPtr_APPROACH_MIN_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "APPROACH_MIN_COOLDOWN");
			Customer.NativeFieldInfoPtr_APPROACH_MAX_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "APPROACH_MAX_COOLDOWN");
			Customer.NativeFieldInfoPtr_DEAL_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "DEAL_COOLDOWN");
			Customer.NativeFieldInfoPtr_PlayerAcceptMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "PlayerAcceptMessages");
			Customer.NativeFieldInfoPtr_PlayerRejectMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "PlayerRejectMessages");
			Customer.NativeFieldInfoPtr_DEAL_ATTENDANCE_TOLERANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "DEAL_ATTENDANCE_TOLERANCE");
			Customer.NativeFieldInfoPtr_MIN_TRAVEL_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "MIN_TRAVEL_TIME");
			Customer.NativeFieldInfoPtr_MAX_TRAVEL_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "MAX_TRAVEL_TIME");
			Customer.NativeFieldInfoPtr_OFFER_EXPIRY_TIME_MINS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "OFFER_EXPIRY_TIME_MINS");
			Customer.NativeFieldInfoPtr_MIN_ORDER_APPEAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "MIN_ORDER_APPEAL");
			Customer.NativeFieldInfoPtr_ADDICTION_DRAIN_PER_DAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "ADDICTION_DRAIN_PER_DAY");
			Customer.NativeFieldInfoPtr_SAMPLE_REQUIRES_RECOMMENDATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "SAMPLE_REQUIRES_RECOMMENDATION");
			Customer.NativeFieldInfoPtr_MIN_NORMALIZED_RELATIONSHIP_FOR_RECOMMENDATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "MIN_NORMALIZED_RELATIONSHIP_FOR_RECOMMENDATION");
			Customer.NativeFieldInfoPtr_RELATIONSHIP_FOR_GUARANTEED_DEALER_RECOMMENDATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "RELATIONSHIP_FOR_GUARANTEED_DEALER_RECOMMENDATION");
			Customer.NativeFieldInfoPtr_RELATIONSHIP_FOR_GUARANTEED_SUPPLIER_RECOMMENDATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "RELATIONSHIP_FOR_GUARANTEED_SUPPLIER_RECOMMENDATION");
			Customer.NativeFieldInfoPtr__CurrentAddiction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<CurrentAddiction>k__BackingField");
			Customer.NativeFieldInfoPtr_offeredContractInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "offeredContractInfo");
			Customer.NativeFieldInfoPtr__OfferedContractTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<OfferedContractTime>k__BackingField");
			Customer.NativeFieldInfoPtr__CurrentContract_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<CurrentContract>k__BackingField");
			Customer.NativeFieldInfoPtr__IsAwaitingDelivery_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<IsAwaitingDelivery>k__BackingField");
			Customer.NativeFieldInfoPtr__TimeSinceLastDealCompleted_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<TimeSinceLastDealCompleted>k__BackingField");
			Customer.NativeFieldInfoPtr__TimeSinceLastDealOffered_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<TimeSinceLastDealOffered>k__BackingField");
			Customer.NativeFieldInfoPtr__TimeSincePlayerApproached_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<TimeSincePlayerApproached>k__BackingField");
			Customer.NativeFieldInfoPtr__TimeSinceInstantDealOffered_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<TimeSinceInstantDealOffered>k__BackingField");
			Customer.NativeFieldInfoPtr__OfferedDeals_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<OfferedDeals>k__BackingField");
			Customer.NativeFieldInfoPtr__CompletedDeliveries_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<CompletedDeliveries>k__BackingField");
			Customer.NativeFieldInfoPtr__HasBeenRecommended_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<HasBeenRecommended>k__BackingField");
			Customer.NativeFieldInfoPtr__NPC_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<NPC>k__BackingField");
			Customer.NativeFieldInfoPtr__AssignedDealer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<AssignedDealer>k__BackingField");
			Customer.NativeFieldInfoPtr_DealSignal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "DealSignal");
			Customer.NativeFieldInfoPtr_AvailableInDemo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "AvailableInDemo");
			Customer.NativeFieldInfoPtr_customerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "customerData");
			Customer.NativeFieldInfoPtr_DefaultDeliveryLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "DefaultDeliveryLocation");
			Customer.NativeFieldInfoPtr_CanRecommendFriends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "CanRecommendFriends");
			Customer.NativeFieldInfoPtr_onUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "onUnlocked");
			Customer.NativeFieldInfoPtr_onDealCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "onDealCompleted");
			Customer.NativeFieldInfoPtr_onContractAssigned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "onContractAssigned");
			Customer.NativeFieldInfoPtr_awaitingSample = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "awaitingSample");
			Customer.NativeFieldInfoPtr_sampleChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "sampleChoice");
			Customer.NativeFieldInfoPtr_completeContractChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "completeContractChoice");
			Customer.NativeFieldInfoPtr_offerDealChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "offerDealChoice");
			Customer.NativeFieldInfoPtr_awaitingDealGreeting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "awaitingDealGreeting");
			Customer.NativeFieldInfoPtr_minsSinceUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "minsSinceUnlocked");
			Customer.NativeFieldInfoPtr_sampleOfferedToday = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "sampleOfferedToday");
			Customer.NativeFieldInfoPtr__potentialCustomerPoI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<potentialCustomerPoI>k__BackingField");
			Customer.NativeFieldInfoPtr_currentAffinityData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "currentAffinityData");
			Customer.NativeFieldInfoPtr_pendingInstantDeal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "pendingInstantDeal");
			Customer.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			Customer.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			Customer.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<HasChanged>k__BackingField");
			Customer.NativeFieldInfoPtr_consumedSample = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "consumedSample");
			Customer.NativeFieldInfoPtr_syncVar____CurrentAddiction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "syncVar___<CurrentAddiction>k__BackingField");
			Customer.NativeFieldInfoPtr_syncVar____HasBeenRecommended_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "syncVar___<HasBeenRecommended>k__BackingField");
			Customer.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Economy.CustomerAssembly-CSharp.dll_Excuted");
			Customer.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Economy.CustomerAssembly-CSharp.dll_Excuted");
			Customer.NativeMethodInfoPtr_get_CurrentAddiction_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674507);
			Customer.NativeMethodInfoPtr_set_CurrentAddiction_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674508);
			Customer.NativeMethodInfoPtr_get_OfferedContractInfo_Public_get_ContractInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674509);
			Customer.NativeMethodInfoPtr_set_OfferedContractInfo_Protected_set_Void_ContractInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674510);
			Customer.NativeMethodInfoPtr_get_OfferedContractTime_Public_get_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674511);
			Customer.NativeMethodInfoPtr_set_OfferedContractTime_Protected_set_Void_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674512);
			Customer.NativeMethodInfoPtr_get_CurrentContract_Public_get_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674513);
			Customer.NativeMethodInfoPtr_set_CurrentContract_Protected_set_Void_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674514);
			Customer.NativeMethodInfoPtr_get_IsAwaitingDelivery_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674515);
			Customer.NativeMethodInfoPtr_set_IsAwaitingDelivery_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674516);
			Customer.NativeMethodInfoPtr_get_TimeSinceLastDealCompleted_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674517);
			Customer.NativeMethodInfoPtr_set_TimeSinceLastDealCompleted_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674518);
			Customer.NativeMethodInfoPtr_get_TimeSinceLastDealOffered_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674519);
			Customer.NativeMethodInfoPtr_set_TimeSinceLastDealOffered_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674520);
			Customer.NativeMethodInfoPtr_get_TimeSincePlayerApproached_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674521);
			Customer.NativeMethodInfoPtr_set_TimeSincePlayerApproached_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674522);
			Customer.NativeMethodInfoPtr_get_TimeSinceInstantDealOffered_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674523);
			Customer.NativeMethodInfoPtr_set_TimeSinceInstantDealOffered_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674524);
			Customer.NativeMethodInfoPtr_get_OfferedDeals_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674525);
			Customer.NativeMethodInfoPtr_set_OfferedDeals_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674526);
			Customer.NativeMethodInfoPtr_get_CompletedDeliveries_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674527);
			Customer.NativeMethodInfoPtr_set_CompletedDeliveries_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674528);
			Customer.NativeMethodInfoPtr_get_HasBeenRecommended_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674529);
			Customer.NativeMethodInfoPtr_set_HasBeenRecommended_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674530);
			Customer.NativeMethodInfoPtr_get_NPC_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674531);
			Customer.NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674532);
			Customer.NativeMethodInfoPtr_get_AssignedDealer_Public_get_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674533);
			Customer.NativeMethodInfoPtr_set_AssignedDealer_Protected_set_Void_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674534);
			Customer.NativeMethodInfoPtr_get_CustomerData_Public_get_CustomerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674535);
			Customer.NativeMethodInfoPtr_get_OrderableProducts_Public_get_List_1_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674536);
			Customer.NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674537);
			Customer.NativeMethodInfoPtr_get_potentialCustomerPoI_Public_get_NPCPoI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674538);
			Customer.NativeMethodInfoPtr_set_potentialCustomerPoI_Private_set_Void_NPCPoI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674539);
			Customer.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674540);
			Customer.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674541);
			Customer.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674542);
			Customer.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674543);
			Customer.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674544);
			Customer.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674545);
			Customer.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674546);
			Customer.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674547);
			Customer.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674548);
			Customer.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674549);
			Customer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674550);
			Customer.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674551);
			Customer.NativeMethodInfoPtr_Start_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674552);
			Customer.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674553);
			Customer.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674554);
			Customer.NativeMethodInfoPtr_OnDestroy_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674555);
			Customer.NativeMethodInfoPtr_SetUpDialogue_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674556);
			Customer.NativeMethodInfoPtr_SetupPoI_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674557);
			Customer.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674558);
			Customer.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674559);
			Customer.NativeMethodInfoPtr_DayPass_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674560);
			Customer.NativeMethodInfoPtr_UpdateDealAttendance_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674561);
			Customer.NativeMethodInfoPtr_ConfigureDealSignal_Private_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674562);
			Customer.NativeMethodInfoPtr_UpdateOfferExpiry_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674563);
			Customer.NativeMethodInfoPtr_CheckContractGeneration_Private_ContractInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674564);
			Customer.NativeMethodInfoPtr_GetWeightedRandomProduct_Private_ProductDefinition_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674565);
			Customer.NativeMethodInfoPtr_OnCustomerUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674566);
			Customer.NativeMethodInfoPtr_SetHasBeenRecommended_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674567);
			Customer.NativeMethodInfoPtr_OfferContract_Public_Virtual_New_Void_ContractInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674568);
			Customer.NativeMethodInfoPtr_SetOfferedContract_Private_Void_ContractInfo_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674569);
			Customer.NativeMethodInfoPtr_ExpireOffer_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674570);
			Customer.NativeMethodInfoPtr_AssignContract_Public_Virtual_New_Void_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674571);
			Customer.NativeMethodInfoPtr_NotifyPlayerOfContract_Protected_Virtual_New_Void_ContractInfo_MessageChain_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674572);
			Customer.NativeMethodInfoPtr_SendSetUpResponseCallbacks_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674573);
			Customer.NativeMethodInfoPtr_SetUpResponseCallbacks_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674574);
			Customer.NativeMethodInfoPtr_AcceptContractClicked_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674575);
			Customer.NativeMethodInfoPtr_CounterOfferClicked_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674576);
			Customer.NativeMethodInfoPtr_SendCounteroffer_Protected_Virtual_New_Void_ProductDefinition_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674577);
			Customer.NativeMethodInfoPtr_ProcessCounterOfferServerSide_Private_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674578);
			Customer.NativeMethodInfoPtr_SetContractIsCounterOffer_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674579);
			Customer.NativeMethodInfoPtr_PlayerAcceptedContract_Protected_Virtual_New_Void_EDealWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674580);
			Customer.NativeMethodInfoPtr_SendContractAccepted_Private_Void_EDealWindow_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674581);
			Customer.NativeMethodInfoPtr_ContractAccepted_Public_Virtual_New_String_EDealWindow_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674582);
			Customer.NativeMethodInfoPtr_ReceiveContractAccepted_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674583);
			Customer.NativeMethodInfoPtr_PlayContractAcceptedReaction_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674584);
			Customer.NativeMethodInfoPtr_EvaluateCounteroffer_Protected_Virtual_New_Boolean_ProductDefinition_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674585);
			Customer.NativeMethodInfoPtr_GetValueProposition_Public_Static_Single_ProductDefinition_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674586);
			Customer.NativeMethodInfoPtr_ContractRejected_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674587);
			Customer.NativeMethodInfoPtr_ReceiveContractRejected_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674588);
			Customer.NativeMethodInfoPtr_PlayContractRejectedReaction_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674589);
			Customer.NativeMethodInfoPtr_SetIsAwaitingDelivery_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674590);
			Customer.NativeMethodInfoPtr_IsAtDealLocation_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674591);
			Customer.NativeMethodInfoPtr_UpdatePotentialCustomerPoI_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674592);
			Customer.NativeMethodInfoPtr_SetPotentialCustomerPoIEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674593);
			Customer.NativeMethodInfoPtr_ShouldTryGenerateDeal_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674594);
			Customer.NativeMethodInfoPtr_OfferDealItems_Public_Virtual_New_Void_List_1_ItemInstance_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674595);
			Customer.NativeMethodInfoPtr_CustomerRejectedDeal_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674596);
			Customer.NativeMethodInfoPtr_ProcessHandover_Public_Virtual_New_Void_EHandoverOutcome_Contract_List_1_ItemInstance_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674597);
			Customer.NativeMethodInfoPtr_ProcessHandoverServerSide_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674598);
			Customer.NativeMethodInfoPtr_ProcessHandoverClient_Private_Void_Single_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674599);
			Customer.NativeMethodInfoPtr_ContractWellReceived_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674600);
			Customer.NativeMethodInfoPtr_RecommendDealer_Private_Void_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674601);
			Customer.NativeMethodInfoPtr_RecommendSupplier_Private_Void_Supplier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674602);
			Customer.NativeMethodInfoPtr_RecommendCustomer_Private_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674603);
			Customer.NativeMethodInfoPtr_CurrentContractEnded_Public_Virtual_New_Void_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674604);
			Customer.NativeMethodInfoPtr_EvaluateDelivery_Public_Virtual_New_Single_Contract_List_1_ItemInstance_byref_Single_byref_EDrugType_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674605);
			Customer.NativeMethodInfoPtr_ChangeAddiction_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674606);
			Customer.NativeMethodInfoPtr_ConsumeProduct_Private_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674607);
			Customer.NativeMethodInfoPtr_ShowOfferDealOption_Protected_Virtual_New_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674608);
			Customer.NativeMethodInfoPtr_OfferDealValid_Protected_Virtual_New_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674609);
			Customer.NativeMethodInfoPtr_InstantDealOffered_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674610);
			Customer.NativeMethodInfoPtr_GetOfferSuccessChance_Public_Single_List_1_ItemInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674611);
			Customer.NativeMethodInfoPtr_ShouldTryApproachPlayer_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674612);
			Customer.NativeMethodInfoPtr_RequestProduct_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674613);
			Customer.NativeMethodInfoPtr_RequestProduct_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674614);
			Customer.NativeMethodInfoPtr_PlayerRejectedProductRequest_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674615);
			Customer.NativeMethodInfoPtr_RejectProductRequestOffer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674616);
			Customer.NativeMethodInfoPtr_RejectProductRequestOffer_Local_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674617);
			Customer.NativeMethodInfoPtr_AssignDealer_Public_Void_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674618);
			Customer.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674619);
			Customer.NativeMethodInfoPtr_GetCustomerData_Public_CustomerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674620);
			Customer.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674621);
			Customer.NativeMethodInfoPtr_ReceiveCustomerData_Private_Void_NetworkConnection_CustomerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674622);
			Customer.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_CustomerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674623);
			Customer.NativeMethodInfoPtr_IsReadyForHandover_Protected_Virtual_New_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674624);
			Customer.NativeMethodInfoPtr_IsHandoverChoiceValid_Protected_Virtual_New_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674625);
			Customer.NativeMethodInfoPtr_HandoverChosen_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674626);
			Customer.NativeMethodInfoPtr_ShowDirectApproachOption_Protected_Virtual_New_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674627);
			Customer.NativeMethodInfoPtr_IsUnlockable_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674628);
			Customer.NativeMethodInfoPtr_SampleOptionValid_Protected_Virtual_New_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674629);
			Customer.NativeMethodInfoPtr_KnownAndRecommended_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674630);
			Customer.NativeMethodInfoPtr_SampleOffered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674631);
			Customer.NativeMethodInfoPtr_GetSampleRequestSuccessChance_Protected_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674632);
			Customer.NativeMethodInfoPtr_SampleAccepted_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674633);
			Customer.NativeMethodInfoPtr_GetSampleSuccess_Private_Single_List_1_ItemInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674634);
			Customer.NativeMethodInfoPtr_ProcessSample_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674635);
			Customer.NativeMethodInfoPtr_ProcessSampleServerSide_Private_Void_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674636);
			Customer.NativeMethodInfoPtr_ProcessSampleClient_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674637);
			Customer.NativeMethodInfoPtr_SampleConsumed_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674638);
			Customer.NativeMethodInfoPtr_EndWait_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674639);
			Customer.NativeMethodInfoPtr_DirectApproachRejected_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674640);
			Customer.NativeMethodInfoPtr_SampleWasSufficient_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674641);
			Customer.NativeMethodInfoPtr_SampleWasInsufficient_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674642);
			Customer.NativeMethodInfoPtr_GetProductEnjoyment_Public_Single_ProductDefinition_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674643);
			Customer.NativeMethodInfoPtr_GetOrderedDrugTypes_Public_List_1_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674644);
			Customer.NativeMethodInfoPtr_AdjustAffinity_Public_Void_EDrugType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674645);
			Customer.NativeMethodInfoPtr_AutocreateCustomerSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674646);
			Customer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674647);
			Customer.NativeMethodInfoPtr__Awake_b__131_0_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674649);
			Customer.NativeMethodInfoPtr__Start_b__133_1_Private_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674650);
			Customer.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674651);
			Customer.NativeMethodInfoPtr_Method_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674652);
			Customer.NativeMethodInfoPtr__HandoverChosen_b__207_0_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674653);
			Customer.NativeMethodInfoPtr__GetOrderedDrugTypes_b__225_0_Private_Single_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674654);
			Customer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674655);
			Customer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674656);
			Customer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674657);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_ConfigureDealSignal_338960014_Private_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674658);
			Customer.NativeMethodInfoPtr_RpcLogic___ConfigureDealSignal_338960014_Private_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674659);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_ConfigureDealSignal_338960014_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674660);
			Customer.NativeMethodInfoPtr_RpcWriter___Target_ConfigureDealSignal_338960014_Private_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674661);
			Customer.NativeMethodInfoPtr_RpcReader___Target_ConfigureDealSignal_338960014_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674662);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_SetOfferedContract_4277245194_Private_Void_ContractInfo_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674663);
			Customer.NativeMethodInfoPtr_RpcLogic___SetOfferedContract_4277245194_Private_Void_ContractInfo_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674664);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_SetOfferedContract_4277245194_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674665);
			Customer.NativeMethodInfoPtr_RpcWriter___Server_ExpireOffer_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674666);
			Customer.NativeMethodInfoPtr_RpcLogic___ExpireOffer_2166136261_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674667);
			Customer.NativeMethodInfoPtr_RpcReader___Server_ExpireOffer_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674668);
			Customer.NativeMethodInfoPtr_RpcWriter___Server_SendSetUpResponseCallbacks_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674669);
			Customer.NativeMethodInfoPtr_RpcLogic___SendSetUpResponseCallbacks_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674670);
			Customer.NativeMethodInfoPtr_RpcReader___Server_SendSetUpResponseCallbacks_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674671);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_SetUpResponseCallbacks_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674672);
			Customer.NativeMethodInfoPtr_RpcLogic___SetUpResponseCallbacks_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674673);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_SetUpResponseCallbacks_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674674);
			Customer.NativeMethodInfoPtr_RpcWriter___Server_ProcessCounterOfferServerSide_900355577_Private_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674675);
			Customer.NativeMethodInfoPtr_RpcLogic___ProcessCounterOfferServerSide_900355577_Private_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674676);
			Customer.NativeMethodInfoPtr_RpcReader___Server_ProcessCounterOfferServerSide_900355577_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674677);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_SetContractIsCounterOffer_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674678);
			Customer.NativeMethodInfoPtr_RpcLogic___SetContractIsCounterOffer_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674679);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_SetContractIsCounterOffer_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674680);
			Customer.NativeMethodInfoPtr_RpcWriter___Server_SendContractAccepted_507093020_Private_Void_EDealWindow_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674681);
			Customer.NativeMethodInfoPtr_RpcLogic___SendContractAccepted_507093020_Private_Void_EDealWindow_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674682);
			Customer.NativeMethodInfoPtr_RpcReader___Server_SendContractAccepted_507093020_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674683);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveContractAccepted_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674684);
			Customer.NativeMethodInfoPtr_RpcLogic___ReceiveContractAccepted_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674685);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_ReceiveContractAccepted_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674686);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveContractRejected_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674687);
			Customer.NativeMethodInfoPtr_RpcLogic___ReceiveContractRejected_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674688);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_ReceiveContractRejected_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674689);
			Customer.NativeMethodInfoPtr_RpcWriter___Server_ProcessHandoverServerSide_3760244802_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674690);
			Customer.NativeMethodInfoPtr_RpcLogic___ProcessHandoverServerSide_3760244802_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674691);
			Customer.NativeMethodInfoPtr_RpcReader___Server_ProcessHandoverServerSide_3760244802_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674692);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_ProcessHandoverClient_537707335_Private_Void_Single_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674693);
			Customer.NativeMethodInfoPtr_RpcLogic___ProcessHandoverClient_537707335_Private_Void_Single_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674694);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_ProcessHandoverClient_537707335_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674695);
			Customer.NativeMethodInfoPtr_RpcWriter___Server_ChangeAddiction_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674696);
			Customer.NativeMethodInfoPtr_RpcLogic___ChangeAddiction_431000436_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674697);
			Customer.NativeMethodInfoPtr_RpcReader___Server_ChangeAddiction_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674698);
			Customer.NativeMethodInfoPtr_RpcWriter___Server_RejectProductRequestOffer_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674699);
			Customer.NativeMethodInfoPtr_RpcLogic___RejectProductRequestOffer_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674700);
			Customer.NativeMethodInfoPtr_RpcReader___Server_RejectProductRequestOffer_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674701);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_RejectProductRequestOffer_Local_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674702);
			Customer.NativeMethodInfoPtr_RpcLogic___RejectProductRequestOffer_Local_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674703);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_RejectProductRequestOffer_Local_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674704);
			Customer.NativeMethodInfoPtr_RpcWriter___Target_ReceiveCustomerData_2280244125_Private_Void_NetworkConnection_CustomerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674705);
			Customer.NativeMethodInfoPtr_RpcLogic___ReceiveCustomerData_2280244125_Private_Void_NetworkConnection_CustomerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674706);
			Customer.NativeMethodInfoPtr_RpcReader___Target_ReceiveCustomerData_2280244125_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674707);
			Customer.NativeMethodInfoPtr_RpcWriter___Server_ProcessSampleServerSide_3704012609_Private_Void_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674708);
			Customer.NativeMethodInfoPtr_RpcLogic___ProcessSampleServerSide_3704012609_Private_Void_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674709);
			Customer.NativeMethodInfoPtr_RpcReader___Server_ProcessSampleServerSide_3704012609_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674710);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_ProcessSampleClient_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674711);
			Customer.NativeMethodInfoPtr_RpcLogic___ProcessSampleClient_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674712);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_ProcessSampleClient_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674713);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_SampleWasSufficient_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674714);
			Customer.NativeMethodInfoPtr_RpcLogic___SampleWasSufficient_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674715);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_SampleWasSufficient_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674716);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_SampleWasInsufficient_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674717);
			Customer.NativeMethodInfoPtr_RpcLogic___SampleWasInsufficient_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674718);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_SampleWasInsufficient_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674719);
			Customer.NativeMethodInfoPtr_RpcWriter___Server_AdjustAffinity_3036964899_Private_Void_EDrugType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674720);
			Customer.NativeMethodInfoPtr_RpcLogic___AdjustAffinity_3036964899_Public_Void_EDrugType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674721);
			Customer.NativeMethodInfoPtr_RpcReader___Server_AdjustAffinity_3036964899_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674722);
			Customer.NativeMethodInfoPtr_sync___get_value__CurrentAddiction_k__BackingField_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674723);
			Customer.NativeMethodInfoPtr_sync___set_value__CurrentAddiction_k__BackingField_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674724);
			Customer.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Customer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674725);
			Customer.NativeMethodInfoPtr_sync___get_value__HasBeenRecommended_k__BackingField_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674726);
			Customer.NativeMethodInfoPtr_sync___set_value__HasBeenRecommended_k__BackingField_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674727);
			Customer.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674728);
		}

		// Token: 0x17001B0D RID: 6925
		// (get) Token: 0x060058C2 RID: 22722 RVA: 0x0019F02C File Offset: 0x0019D22C
		// (set) Token: 0x060058C3 RID: 22723 RVA: 0x0019F068 File Offset: 0x0019D268
		public unsafe float CurrentAddiction
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 86625, RefRangeEnd = 86627, XrefRangeStart = 86625, XrefRangeEnd = 86627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_CurrentAddiction_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 186687, RefRangeEnd = 186691, XrefRangeStart = 186680, XrefRangeEnd = 186687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_CurrentAddiction_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B0E RID: 6926
		// (get) Token: 0x060058C4 RID: 22724 RVA: 0x0019F0A8 File Offset: 0x0019D2A8
		// (set) Token: 0x060058C5 RID: 22725 RVA: 0x0019F0E8 File Offset: 0x0019D2E8
		public unsafe ContractInfo OfferedContractInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_OfferedContractInfo_Public_get_ContractInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContractInfo>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_OfferedContractInfo_Protected_set_Void_ContractInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B0F RID: 6927
		// (get) Token: 0x060058C6 RID: 22726 RVA: 0x0019F12C File Offset: 0x0019D32C
		// (set) Token: 0x060058C7 RID: 22727 RVA: 0x0019F168 File Offset: 0x0019D368
		public unsafe GameDateTime OfferedContractTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_OfferedContractTime_Public_get_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_OfferedContractTime_Protected_set_Void_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B10 RID: 6928
		// (get) Token: 0x060058C8 RID: 22728 RVA: 0x0019F1A8 File Offset: 0x0019D3A8
		// (set) Token: 0x060058C9 RID: 22729 RVA: 0x0019F1E8 File Offset: 0x0019D3E8
		public unsafe Contract CurrentContract
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_CurrentContract_Public_get_Contract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Contract>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_CurrentContract_Protected_set_Void_Contract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B11 RID: 6929
		// (get) Token: 0x060058CA RID: 22730 RVA: 0x0019F22C File Offset: 0x0019D42C
		// (set) Token: 0x060058CB RID: 22731 RVA: 0x0019F268 File Offset: 0x0019D468
		public unsafe bool IsAwaitingDelivery
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_IsAwaitingDelivery_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_IsAwaitingDelivery_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B12 RID: 6930
		// (get) Token: 0x060058CC RID: 22732 RVA: 0x0019F2A8 File Offset: 0x0019D4A8
		// (set) Token: 0x060058CD RID: 22733 RVA: 0x0019F2E4 File Offset: 0x0019D4E4
		public unsafe int TimeSinceLastDealCompleted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_TimeSinceLastDealCompleted_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_TimeSinceLastDealCompleted_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B13 RID: 6931
		// (get) Token: 0x060058CE RID: 22734 RVA: 0x0019F324 File Offset: 0x0019D524
		// (set) Token: 0x060058CF RID: 22735 RVA: 0x0019F360 File Offset: 0x0019D560
		public unsafe int TimeSinceLastDealOffered
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_TimeSinceLastDealOffered_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_TimeSinceLastDealOffered_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B14 RID: 6932
		// (get) Token: 0x060058D0 RID: 22736 RVA: 0x0019F3A0 File Offset: 0x0019D5A0
		// (set) Token: 0x060058D1 RID: 22737 RVA: 0x0019F3DC File Offset: 0x0019D5DC
		public unsafe int TimeSincePlayerApproached
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_TimeSincePlayerApproached_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_TimeSincePlayerApproached_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B15 RID: 6933
		// (get) Token: 0x060058D2 RID: 22738 RVA: 0x0019F41C File Offset: 0x0019D61C
		// (set) Token: 0x060058D3 RID: 22739 RVA: 0x0019F458 File Offset: 0x0019D658
		public unsafe int TimeSinceInstantDealOffered
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_TimeSinceInstantDealOffered_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_TimeSinceInstantDealOffered_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B16 RID: 6934
		// (get) Token: 0x060058D4 RID: 22740 RVA: 0x0019F498 File Offset: 0x0019D698
		// (set) Token: 0x060058D5 RID: 22741 RVA: 0x0019F4D4 File Offset: 0x0019D6D4
		public unsafe int OfferedDeals
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_OfferedDeals_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_OfferedDeals_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B17 RID: 6935
		// (get) Token: 0x060058D6 RID: 22742 RVA: 0x0019F514 File Offset: 0x0019D714
		// (set) Token: 0x060058D7 RID: 22743 RVA: 0x0019F550 File Offset: 0x0019D750
		public unsafe int CompletedDeliveries
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_CompletedDeliveries_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_CompletedDeliveries_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B18 RID: 6936
		// (get) Token: 0x060058D8 RID: 22744 RVA: 0x0019F590 File Offset: 0x0019D790
		// (set) Token: 0x060058D9 RID: 22745 RVA: 0x0019F5CC File Offset: 0x0019D7CC
		public unsafe bool HasBeenRecommended
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_HasBeenRecommended_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 186698, RefRangeEnd = 186701, XrefRangeStart = 186691, XrefRangeEnd = 186698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_HasBeenRecommended_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B19 RID: 6937
		// (get) Token: 0x060058DA RID: 22746 RVA: 0x0019F60C File Offset: 0x0019D80C
		// (set) Token: 0x060058DB RID: 22747 RVA: 0x0019F64C File Offset: 0x0019D84C
		public unsafe NPC NPC
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_NPC_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B1A RID: 6938
		// (get) Token: 0x060058DC RID: 22748 RVA: 0x0019F690 File Offset: 0x0019D890
		// (set) Token: 0x060058DD RID: 22749 RVA: 0x0019F6D0 File Offset: 0x0019D8D0
		public unsafe Dealer AssignedDealer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_AssignedDealer_Public_get_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr3) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 115205, RefRangeEnd = 115213, XrefRangeStart = 115205, XrefRangeEnd = 115213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_AssignedDealer_Protected_set_Void_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B1B RID: 6939
		// (get) Token: 0x060058DE RID: 22750 RVA: 0x0019F714 File Offset: 0x0019D914
		public unsafe CustomerData CustomerData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_CustomerData_Public_get_CustomerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomerData>(intPtr3) : null;
			}
		}

		// Token: 0x17001B1C RID: 6940
		// (get) Token: 0x060058DF RID: 22751 RVA: 0x0019F754 File Offset: 0x0019D954
		public unsafe List<ProductDefinition> OrderableProducts
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 186710, RefRangeEnd = 186734, XrefRangeStart = 186701, XrefRangeEnd = 186710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_OrderableProducts_Public_get_List_1_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ProductDefinition>>(intPtr3) : null;
			}
		}

		// Token: 0x17001B1D RID: 6941
		// (get) Token: 0x060058E0 RID: 22752 RVA: 0x0019F794 File Offset: 0x0019D994
		public unsafe DialogueDatabase dialogueDatabase
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueDatabase>(intPtr3) : null;
			}
		}

		// Token: 0x17001B1E RID: 6942
		// (get) Token: 0x060058E1 RID: 22753 RVA: 0x0019F7D4 File Offset: 0x0019D9D4
		// (set) Token: 0x060058E2 RID: 22754 RVA: 0x0019F814 File Offset: 0x0019DA14
		public unsafe NPCPoI potentialCustomerPoI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_potentialCustomerPoI_Public_get_NPCPoI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_potentialCustomerPoI_Private_set_Void_NPCPoI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B1F RID: 6943
		// (get) Token: 0x060058E3 RID: 22755 RVA: 0x0019F858 File Offset: 0x0019DA58
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186734, XrefRangeEnd = 186736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001B20 RID: 6944
		// (get) Token: 0x060058E4 RID: 22756 RVA: 0x0019F890 File Offset: 0x0019DA90
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186736, XrefRangeEnd = 186738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001B21 RID: 6945
		// (get) Token: 0x060058E5 RID: 22757 RVA: 0x0019F8C8 File Offset: 0x0019DAC8
		public unsafe virtual Loader Loader
		{
			[CallerCount(65)]
			[CachedScanResults(RefRangeStart = 31227, RefRangeEnd = 31292, XrefRangeStart = 31227, XrefRangeEnd = 31292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17001B22 RID: 6946
		// (get) Token: 0x060058E6 RID: 22758 RVA: 0x0019F908 File Offset: 0x0019DB08
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(183)]
			[CachedScanResults(RefRangeStart = 35953, RefRangeEnd = 36136, XrefRangeStart = 35953, XrefRangeEnd = 36136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001B23 RID: 6947
		// (get) Token: 0x060058E7 RID: 22759 RVA: 0x0019F944 File Offset: 0x0019DB44
		// (set) Token: 0x060058E8 RID: 22760 RVA: 0x0019F984 File Offset: 0x0019DB84
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 166364, RefRangeEnd = 166379, XrefRangeStart = 166364, XrefRangeEnd = 166379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186738, XrefRangeEnd = 186739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B24 RID: 6948
		// (get) Token: 0x060058E9 RID: 22761 RVA: 0x0019F9C8 File Offset: 0x0019DBC8
		// (set) Token: 0x060058EA RID: 22762 RVA: 0x0019FA08 File Offset: 0x0019DC08
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186739, XrefRangeEnd = 186740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B25 RID: 6949
		// (get) Token: 0x060058EB RID: 22763 RVA: 0x0019FA4C File Offset: 0x0019DC4C
		// (set) Token: 0x060058EC RID: 22764 RVA: 0x0019FA88 File Offset: 0x0019DC88
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060058ED RID: 22765 RVA: 0x0019FAC8 File Offset: 0x0019DCC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186740, XrefRangeEnd = 186741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058EE RID: 22766 RVA: 0x0019FB04 File Offset: 0x0019DD04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186741, XrefRangeEnd = 186796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058EF RID: 22767 RVA: 0x0019FB40 File Offset: 0x0019DD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186796, XrefRangeEnd = 186877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_Start_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058F0 RID: 22768 RVA: 0x0019FB74 File Offset: 0x0019DD74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186877, XrefRangeEnd = 186879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058F1 RID: 22769 RVA: 0x0019FBB0 File Offset: 0x0019DDB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186879, XrefRangeEnd = 186903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058F2 RID: 22770 RVA: 0x0019FC00 File Offset: 0x0019DE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186903, XrefRangeEnd = 186911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_OnDestroy_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058F3 RID: 22771 RVA: 0x0019FC34 File Offset: 0x0019DE34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 187014, RefRangeEnd = 187015, XrefRangeStart = 186911, XrefRangeEnd = 187014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUpDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SetUpDialogue_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058F4 RID: 22772 RVA: 0x0019FC68 File Offset: 0x0019DE68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 187045, RefRangeEnd = 187046, XrefRangeStart = 187015, XrefRangeEnd = 187045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupPoI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SetupPoI_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058F5 RID: 22773 RVA: 0x0019FC9C File Offset: 0x0019DE9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187046, XrefRangeEnd = 187052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058F6 RID: 22774 RVA: 0x0019FCD8 File Offset: 0x0019DED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187052, XrefRangeEnd = 187129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058F7 RID: 22775 RVA: 0x0019FD14 File Offset: 0x0019DF14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187129, XrefRangeEnd = 187131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DayPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_DayPass_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058F8 RID: 22776 RVA: 0x0019FD50 File Offset: 0x0019DF50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 187188, RefRangeEnd = 187189, XrefRangeStart = 187131, XrefRangeEnd = 187188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDealAttendance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_UpdateDealAttendance_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058F9 RID: 22777 RVA: 0x0019FD84 File Offset: 0x0019DF84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 187201, RefRangeEnd = 187204, XrefRangeStart = 187189, XrefRangeEnd = 187201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureDealSignal(NetworkConnection conn, int startTime, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ConfigureDealSignal_Private_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058FA RID: 22778 RVA: 0x0019FDE4 File Offset: 0x0019DFE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 187223, RefRangeEnd = 187224, XrefRangeStart = 187204, XrefRangeEnd = 187223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateOfferExpiry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_UpdateOfferExpiry_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058FB RID: 22779 RVA: 0x0019FE18 File Offset: 0x0019E018
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 187343, RefRangeEnd = 187344, XrefRangeStart = 187224, XrefRangeEnd = 187343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContractInfo CheckContractGeneration(bool force = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref force;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_CheckContractGeneration_Private_ContractInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContractInfo>(intPtr3) : null;
		}

		// Token: 0x060058FC RID: 22780 RVA: 0x0019FE64 File Offset: 0x0019E064
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 187430, RefRangeEnd = 187431, XrefRangeStart = 187344, XrefRangeEnd = 187430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductDefinition GetWeightedRandomProduct(out float appeal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &appeal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_GetWeightedRandomProduct_Private_ProductDefinition_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr3) : null;
		}

		// Token: 0x060058FD RID: 22781 RVA: 0x0019FEB0 File Offset: 0x0019E0B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187431, XrefRangeEnd = 187460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCustomerUnlocked(NPCRelationData.EUnlockType unlockType, bool notify)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref unlockType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_OnCustomerUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058FE RID: 22782 RVA: 0x0019FF08 File Offset: 0x0019E108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187460, XrefRangeEnd = 187461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHasBeenRecommended()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SetHasBeenRecommended_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058FF RID: 22783 RVA: 0x0019FF3C File Offset: 0x0019E13C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187461, XrefRangeEnd = 187503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OfferContract(ContractInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_OfferContract_Public_Virtual_New_Void_ContractInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005900 RID: 22784 RVA: 0x0019FF8C File Offset: 0x0019E18C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187503, XrefRangeEnd = 187523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOfferedContract(ContractInfo info, GameDateTime offerTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offerTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SetOfferedContract_Private_Void_ContractInfo_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005901 RID: 22785 RVA: 0x0019FFDC File Offset: 0x0019E1DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187523, XrefRangeEnd = 187544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ExpireOffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_ExpireOffer_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005902 RID: 22786 RVA: 0x001A0018 File Offset: 0x0019E218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187544, XrefRangeEnd = 187556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AssignContract(Contract contract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_AssignContract_Public_Virtual_New_Void_Contract_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005903 RID: 22787 RVA: 0x001A0068 File Offset: 0x0019E268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187556, XrefRangeEnd = 187610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NotifyPlayerOfContract(ContractInfo contract, MessageChain offerMessage, bool canAccept, bool canReject, bool canCounterOffer = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(offerMessage);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canAccept;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canReject;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canCounterOffer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_NotifyPlayerOfContract_Protected_Virtual_New_Void_ContractInfo_MessageChain_Boolean_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005904 RID: 22788 RVA: 0x001A00F4 File Offset: 0x0019E2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187610, XrefRangeEnd = 187631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendSetUpResponseCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SendSetUpResponseCallbacks_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005905 RID: 22789 RVA: 0x001A0128 File Offset: 0x0019E328
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 187652, RefRangeEnd = 187657, XrefRangeStart = 187631, XrefRangeEnd = 187652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUpResponseCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SetUpResponseCallbacks_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005906 RID: 22790 RVA: 0x001A015C File Offset: 0x0019E35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187657, XrefRangeEnd = 187668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AcceptContractClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_AcceptContractClicked_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005907 RID: 22791 RVA: 0x001A0198 File Offset: 0x0019E398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187668, XrefRangeEnd = 187687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CounterOfferClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_CounterOfferClicked_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005908 RID: 22792 RVA: 0x001A01D4 File Offset: 0x0019E3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187687, XrefRangeEnd = 187730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendCounteroffer(ProductDefinition product, int quantity, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_SendCounteroffer_Protected_Virtual_New_Void_ProductDefinition_Int32_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005909 RID: 22793 RVA: 0x001A0240 File Offset: 0x0019E440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187730, XrefRangeEnd = 187743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessCounterOfferServerSide(string productID, int quantity, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ProcessCounterOfferServerSide_Private_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600590A RID: 22794 RVA: 0x001A02A0 File Offset: 0x0019E4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187743, XrefRangeEnd = 187762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContractIsCounterOffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SetContractIsCounterOffer_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600590B RID: 22795 RVA: 0x001A02D4 File Offset: 0x0019E4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187762, XrefRangeEnd = 187831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayerAcceptedContract(EDealWindow window)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref window;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_PlayerAcceptedContract_Protected_Virtual_New_Void_EDealWindow_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600590C RID: 22796 RVA: 0x001A0320 File Offset: 0x0019E520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187831, XrefRangeEnd = 187851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendContractAccepted(EDealWindow window, bool trackContract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref window;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackContract;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SendContractAccepted_Private_Void_EDealWindow_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600590D RID: 22797 RVA: 0x001A036C File Offset: 0x0019E56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187851, XrefRangeEnd = 187887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ContractAccepted(EDealWindow window, bool trackContract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref window;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackContract;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_ContractAccepted_Public_Virtual_New_String_EDealWindow_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600590E RID: 22798 RVA: 0x001A03CC File Offset: 0x0019E5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187887, XrefRangeEnd = 187908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveContractAccepted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ReceiveContractAccepted_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600590F RID: 22799 RVA: 0x001A0400 File Offset: 0x0019E600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187908, XrefRangeEnd = 187914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayContractAcceptedReaction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_PlayContractAcceptedReaction_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005910 RID: 22800 RVA: 0x001A043C File Offset: 0x0019E63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187914, XrefRangeEnd = 187944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool EvaluateCounteroffer(ProductDefinition product, int quantity, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_EvaluateCounteroffer_Protected_Virtual_New_Boolean_ProductDefinition_Int32_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005911 RID: 22801 RVA: 0x001A04B0 File Offset: 0x0019E6B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187944, XrefRangeEnd = 187945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetValueProposition(ProductDefinition product, float price)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_GetValueProposition_Public_Static_Single_ProductDefinition_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005912 RID: 22802 RVA: 0x001A0500 File Offset: 0x0019E700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187945, XrefRangeEnd = 187974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ContractRejected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_ContractRejected_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005913 RID: 22803 RVA: 0x001A053C File Offset: 0x0019E73C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187974, XrefRangeEnd = 187995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveContractRejected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ReceiveContractRejected_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005914 RID: 22804 RVA: 0x001A0570 File Offset: 0x0019E770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187995, XrefRangeEnd = 188001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayContractRejectedReaction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_PlayContractRejectedReaction_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005915 RID: 22805 RVA: 0x001A05AC File Offset: 0x0019E7AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188001, XrefRangeEnd = 188022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsAwaitingDelivery(bool awaiting)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref awaiting;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_SetIsAwaitingDelivery_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005916 RID: 22806 RVA: 0x001A05F8 File Offset: 0x0019E7F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 188031, RefRangeEnd = 188033, XrefRangeStart = 188022, XrefRangeEnd = 188031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtDealLocation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_IsAtDealLocation_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005917 RID: 22807 RVA: 0x001A0634 File Offset: 0x0019E834
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 188039, RefRangeEnd = 188042, XrefRangeStart = 188033, XrefRangeEnd = 188039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePotentialCustomerPoI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_UpdatePotentialCustomerPoI_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005918 RID: 22808 RVA: 0x001A0668 File Offset: 0x0019E868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188042, XrefRangeEnd = 188047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPotentialCustomerPoIEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SetPotentialCustomerPoIEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005919 RID: 22809 RVA: 0x001A06A8 File Offset: 0x0019E8A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188047, XrefRangeEnd = 188062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldTryGenerateDeal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_ShouldTryGenerateDeal_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600591A RID: 22810 RVA: 0x001A06F0 File Offset: 0x0019E8F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188062, XrefRangeEnd = 188070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OfferDealItems(List<ItemInstance> items, bool offeredByPlayer, out bool accepted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offeredByPlayer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &accepted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_OfferDealItems_Public_Virtual_New_Void_List_1_ItemInstance_Boolean_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600591B RID: 22811 RVA: 0x001A075C File Offset: 0x0019E95C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188070, XrefRangeEnd = 188103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CustomerRejectedDeal(bool offeredByPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref offeredByPlayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_CustomerRejectedDeal_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600591C RID: 22812 RVA: 0x001A07A8 File Offset: 0x0019E9A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188103, XrefRangeEnd = 188258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ProcessHandover(HandoverScreen.EHandoverOutcome outcome, Contract contract, List<ItemInstance> items, bool handoverByPlayer, bool giveBonuses = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handoverByPlayer;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref giveBonuses;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_ProcessHandover_Public_Virtual_New_Void_EHandoverOutcome_Contract_List_1_ItemInstance_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600591D RID: 22813 RVA: 0x001A0834 File Offset: 0x0019EA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188258, XrefRangeEnd = 188274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessHandoverServerSide(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, bool handoverByPlayer, float totalPayment, ProductList productList, float satisfaction, NetworkObject dealer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handoverByPlayer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalPayment;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(productList);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref satisfaction;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ProcessHandoverServerSide_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600591E RID: 22814 RVA: 0x001A08D4 File Offset: 0x0019EAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188274, XrefRangeEnd = 188286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessHandoverClient(float satisfaction, bool handoverByPlayer, string npcToRecommend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref satisfaction;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handoverByPlayer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcToRecommend);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ProcessHandoverClient_Private_Void_Single_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600591F RID: 22815 RVA: 0x001A0934 File Offset: 0x0019EB34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 188306, RefRangeEnd = 188308, XrefRangeStart = 188286, XrefRangeEnd = 188306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ContractWellReceived(string npcToRecommend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcToRecommend);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ContractWellReceived_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005920 RID: 22816 RVA: 0x001A0978 File Offset: 0x0019EB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188308, XrefRangeEnd = 188389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecommendDealer(Dealer dealer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RecommendDealer_Private_Void_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005921 RID: 22817 RVA: 0x001A09BC File Offset: 0x0019EBBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188389, XrefRangeEnd = 188458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecommendSupplier(Supplier supplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(supplier);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RecommendSupplier_Private_Void_Supplier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005922 RID: 22818 RVA: 0x001A0A00 File Offset: 0x0019EC00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188458, XrefRangeEnd = 188541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecommendCustomer(Customer friend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(friend);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RecommendCustomer_Private_Void_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005923 RID: 22819 RVA: 0x001A0A44 File Offset: 0x0019EC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188541, XrefRangeEnd = 188548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CurrentContractEnded(EQuestState outcome)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_CurrentContractEnded_Public_Virtual_New_Void_EQuestState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005924 RID: 22820 RVA: 0x001A0A90 File Offset: 0x0019EC90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188548, XrefRangeEnd = 188637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float EvaluateDelivery(Contract contract, List<ItemInstance> providedItems, out float highestAddiction, out EDrugType mainTypeType, out int matchedProductCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(providedItems);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &highestAddiction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &mainTypeType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &matchedProductCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_EvaluateDelivery_Public_Virtual_New_Single_Contract_List_1_ItemInstance_byref_Single_byref_EDrugType_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005925 RID: 22821 RVA: 0x001A0B28 File Offset: 0x0019ED28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 188656, RefRangeEnd = 188658, XrefRangeStart = 188637, XrefRangeEnd = 188656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeAddiction(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ChangeAddiction_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005926 RID: 22822 RVA: 0x001A0B68 File Offset: 0x0019ED68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188658, XrefRangeEnd = 188671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConsumeProduct(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ConsumeProduct_Private_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005927 RID: 22823 RVA: 0x001A0BAC File Offset: 0x0019EDAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188671, XrefRangeEnd = 188683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShowOfferDealOption(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_ShowOfferDealOption_Protected_Virtual_New_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005928 RID: 22824 RVA: 0x001A0C00 File Offset: 0x0019EE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188683, XrefRangeEnd = 188692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool OfferDealValid(out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_OfferDealValid_Protected_Virtual_New_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005929 RID: 22825 RVA: 0x001A0C64 File Offset: 0x0019EE64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188692, XrefRangeEnd = 188704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InstantDealOffered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_InstantDealOffered_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600592A RID: 22826 RVA: 0x001A0CA0 File Offset: 0x0019EEA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 188787, RefRangeEnd = 188789, XrefRangeStart = 188704, XrefRangeEnd = 188787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetOfferSuccessChance(List<ItemInstance> items, float askingPrice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref askingPrice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_GetOfferSuccessChance_Public_Single_List_1_ItemInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600592B RID: 22827 RVA: 0x001A0CFC File Offset: 0x0019EEFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188789, XrefRangeEnd = 188820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldTryApproachPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_ShouldTryApproachPlayer_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600592C RID: 22828 RVA: 0x001A0D44 File Offset: 0x0019EF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188820, XrefRangeEnd = 188825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestProduct()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RequestProduct_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600592D RID: 22829 RVA: 0x001A0D78 File Offset: 0x0019EF78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 188837, RefRangeEnd = 188839, XrefRangeStart = 188825, XrefRangeEnd = 188837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestProduct(Player target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RequestProduct_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600592E RID: 22830 RVA: 0x001A0DBC File Offset: 0x0019EFBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 188859, RefRangeEnd = 188860, XrefRangeStart = 188839, XrefRangeEnd = 188859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerRejectedProductRequest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_PlayerRejectedProductRequest_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600592F RID: 22831 RVA: 0x001A0DF0 File Offset: 0x0019EFF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 188878, RefRangeEnd = 188879, XrefRangeStart = 188860, XrefRangeEnd = 188878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RejectProductRequestOffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RejectProductRequestOffer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005930 RID: 22832 RVA: 0x001A0E24 File Offset: 0x0019F024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188879, XrefRangeEnd = 188900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RejectProductRequestOffer_Local()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RejectProductRequestOffer_Local_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005931 RID: 22833 RVA: 0x001A0E58 File Offset: 0x0019F058
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 115205, RefRangeEnd = 115213, XrefRangeStart = 115205, XrefRangeEnd = 115213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignDealer(Dealer dealer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_AssignDealer_Public_Void_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005932 RID: 22834 RVA: 0x001A0E9C File Offset: 0x0019F09C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188900, XrefRangeEnd = 188902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005933 RID: 22835 RVA: 0x001A0EE0 File Offset: 0x0019F0E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 188927, RefRangeEnd = 188929, XrefRangeStart = 188902, XrefRangeEnd = 188927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomerData GetCustomerData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_GetCustomerData_Public_CustomerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomerData>(intPtr3) : null;
		}

		// Token: 0x06005934 RID: 22836 RVA: 0x001A0F20 File Offset: 0x0019F120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188929, XrefRangeEnd = 188935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06005935 RID: 22837 RVA: 0x001A0F7C File Offset: 0x0019F17C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188935, XrefRangeEnd = 188954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveCustomerData(NetworkConnection conn, CustomerData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ReceiveCustomerData_Private_Void_NetworkConnection_CustomerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005936 RID: 22838 RVA: 0x001A0FD0 File Offset: 0x0019F1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188954, XrefRangeEnd = 188975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(CustomerData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_CustomerData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005937 RID: 22839 RVA: 0x001A1020 File Offset: 0x0019F220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188975, XrefRangeEnd = 188983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsReadyForHandover(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_IsReadyForHandover_Protected_Virtual_New_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005938 RID: 22840 RVA: 0x001A1074 File Offset: 0x0019F274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188983, XrefRangeEnd = 189003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsHandoverChoiceValid(out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_IsHandoverChoiceValid_Protected_Virtual_New_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005939 RID: 22841 RVA: 0x001A10D8 File Offset: 0x0019F2D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189003, XrefRangeEnd = 189014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandoverChosen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_HandoverChosen_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600593A RID: 22842 RVA: 0x001A110C File Offset: 0x0019F30C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189014, XrefRangeEnd = 189022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShowDirectApproachOption(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_ShowDirectApproachOption_Protected_Virtual_New_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600593B RID: 22843 RVA: 0x001A1160 File Offset: 0x0019F360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189022, XrefRangeEnd = 189029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsUnlockable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_IsUnlockable_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600593C RID: 22844 RVA: 0x001A11A8 File Offset: 0x0019F3A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189029, XrefRangeEnd = 189047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool SampleOptionValid(out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_SampleOptionValid_Protected_Virtual_New_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600593D RID: 22845 RVA: 0x001A120C File Offset: 0x0019F40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189047, XrefRangeEnd = 189055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool KnownAndRecommended()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_KnownAndRecommended_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600593E RID: 22846 RVA: 0x001A1248 File Offset: 0x0019F448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189055, XrefRangeEnd = 189056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SampleOffered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SampleOffered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600593F RID: 22847 RVA: 0x001A127C File Offset: 0x0019F47C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189056, XrefRangeEnd = 189062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float GetSampleRequestSuccessChance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_GetSampleRequestSuccessChance_Protected_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005940 RID: 22848 RVA: 0x001A12C4 File Offset: 0x0019F4C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189062, XrefRangeEnd = 189080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SampleAccepted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_SampleAccepted_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005941 RID: 22849 RVA: 0x001A1300 File Offset: 0x0019F500
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 189114, RefRangeEnd = 189115, XrefRangeStart = 189080, XrefRangeEnd = 189114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSampleSuccess(List<ItemInstance> items, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_GetSampleSuccess_Private_Single_List_1_ItemInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005942 RID: 22850 RVA: 0x001A135C File Offset: 0x0019F55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189115, XrefRangeEnd = 189145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessSample(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ProcessSample_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005943 RID: 22851 RVA: 0x001A13BC File Offset: 0x0019F5BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189145, XrefRangeEnd = 189167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessSampleServerSide(List<ItemInstance> items)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ProcessSampleServerSide_Private_Void_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005944 RID: 22852 RVA: 0x001A1400 File Offset: 0x0019F600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189167, XrefRangeEnd = 189188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessSampleClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ProcessSampleClient_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005945 RID: 22853 RVA: 0x001A1434 File Offset: 0x0019F634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189188, XrefRangeEnd = 189289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SampleConsumed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SampleConsumed_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005946 RID: 22854 RVA: 0x001A1468 File Offset: 0x0019F668
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 189298, RefRangeEnd = 189301, XrefRangeStart = 189289, XrefRangeEnd = 189298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndWait()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_EndWait_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005947 RID: 22855 RVA: 0x001A149C File Offset: 0x0019F69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189301, XrefRangeEnd = 189321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DirectApproachRejected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_DirectApproachRejected_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005948 RID: 22856 RVA: 0x001A14D8 File Offset: 0x0019F6D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189321, XrefRangeEnd = 189339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SampleWasSufficient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SampleWasSufficient_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005949 RID: 22857 RVA: 0x001A150C File Offset: 0x0019F70C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189339, XrefRangeEnd = 189357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SampleWasInsufficient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SampleWasInsufficient_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600594A RID: 22858 RVA: 0x001A1540 File Offset: 0x0019F740
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 189390, RefRangeEnd = 189395, XrefRangeStart = 189357, XrefRangeEnd = 189390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetProductEnjoyment(ProductDefinition product, EQuality quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_GetProductEnjoyment_Public_Single_ProductDefinition_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600594B RID: 22859 RVA: 0x001A159C File Offset: 0x0019F79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189395, XrefRangeEnd = 189424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<EDrugType> GetOrderedDrugTypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_GetOrderedDrugTypes_Public_List_1_EDrugType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<EDrugType>>(intPtr3) : null;
		}

		// Token: 0x0600594C RID: 22860 RVA: 0x001A15DC File Offset: 0x0019F7DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189424, XrefRangeEnd = 189444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdjustAffinity(EDrugType drugType, float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref drugType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_AdjustAffinity_Public_Void_EDrugType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600594D RID: 22861 RVA: 0x001A1628 File Offset: 0x0019F828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189444, XrefRangeEnd = 189454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AutocreateCustomerSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_AutocreateCustomerSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600594E RID: 22862 RVA: 0x001A165C File Offset: 0x0019F85C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189454, XrefRangeEnd = 189467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Customer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600594F RID: 22863 RVA: 0x001A1698 File Offset: 0x0019F898
		[CallerCount(0)]
		public unsafe void _Awake_b__131_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr__Awake_b__131_0_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005950 RID: 22864 RVA: 0x001A16CC File Offset: 0x0019F8CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189467, XrefRangeEnd = 189468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__133_1(NPCRelationData.EUnlockType <p0>, bool <p1>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <p0>;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref <p1>;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr__Start_b__133_1_Private_Void_EUnlockType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005951 RID: 22865 RVA: 0x001A1718 File Offset: 0x0019F918
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 189494, RefRangeEnd = 189495, XrefRangeStart = 189468, XrefRangeEnd = 189494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005952 RID: 22866 RVA: 0x001A174C File Offset: 0x0019F94C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189495, XrefRangeEnd = 189554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_PDM_0(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, float askingPrice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref askingPrice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_Method_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005953 RID: 22867 RVA: 0x001A17AC File Offset: 0x0019F9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189554, XrefRangeEnd = 189555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _HandoverChosen_b__207_0(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr__HandoverChosen_b__207_0_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005954 RID: 22868 RVA: 0x001A180C File Offset: 0x0019FA0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189555, XrefRangeEnd = 189568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _GetOrderedDrugTypes_b__225_0(EDrugType x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr__GetOrderedDrugTypes_b__225_0_Private_Single_EDrugType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005955 RID: 22869 RVA: 0x001A1858 File Offset: 0x0019FA58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189568, XrefRangeEnd = 189727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005956 RID: 22870 RVA: 0x001A1894 File Offset: 0x0019FA94
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005957 RID: 22871 RVA: 0x001A18D0 File Offset: 0x0019FAD0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005958 RID: 22872 RVA: 0x001A190C File Offset: 0x0019FB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189727, XrefRangeEnd = 189748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ConfigureDealSignal_338960014(NetworkConnection conn, int startTime, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_ConfigureDealSignal_338960014_Private_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005959 RID: 22873 RVA: 0x001A196C File Offset: 0x0019FB6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189748, XrefRangeEnd = 189751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ConfigureDealSignal_338960014(NetworkConnection conn, int startTime, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ConfigureDealSignal_338960014_Private_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600595A RID: 22874 RVA: 0x001A19CC File Offset: 0x0019FBCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189751, XrefRangeEnd = 189757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ConfigureDealSignal_338960014(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_ConfigureDealSignal_338960014_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600595B RID: 22875 RVA: 0x001A1A1C File Offset: 0x0019FC1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189757, XrefRangeEnd = 189769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ConfigureDealSignal_338960014(NetworkConnection conn, int startTime, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Target_ConfigureDealSignal_338960014_Private_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600595C RID: 22876 RVA: 0x001A1A7C File Offset: 0x0019FC7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189769, XrefRangeEnd = 189775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ConfigureDealSignal_338960014(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Target_ConfigureDealSignal_338960014_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600595D RID: 22877 RVA: 0x001A1ACC File Offset: 0x0019FCCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetOfferedContract_4277245194(ContractInfo info, GameDateTime offerTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offerTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_SetOfferedContract_4277245194_Private_Void_ContractInfo_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600595E RID: 22878 RVA: 0x001A1B1C File Offset: 0x0019FD1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189775, XrefRangeEnd = 189776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetOfferedContract_4277245194(ContractInfo info, GameDateTime offerTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offerTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___SetOfferedContract_4277245194_Private_Void_ContractInfo_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600595F RID: 22879 RVA: 0x001A1B6C File Offset: 0x0019FD6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189776, XrefRangeEnd = 189780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetOfferedContract_4277245194(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_SetOfferedContract_4277245194_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005960 RID: 22880 RVA: 0x001A1BBC File Offset: 0x0019FDBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189780, XrefRangeEnd = 189798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ExpireOffer_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Server_ExpireOffer_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005961 RID: 22881 RVA: 0x001A1BF0 File Offset: 0x0019FDF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 189805, RefRangeEnd = 189807, XrefRangeStart = 189798, XrefRangeEnd = 189805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___ExpireOffer_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_RpcLogic___ExpireOffer_2166136261_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005962 RID: 22882 RVA: 0x001A1C2C File Offset: 0x0019FE2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189807, XrefRangeEnd = 189810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ExpireOffer_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Server_ExpireOffer_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005963 RID: 22883 RVA: 0x001A1C90 File Offset: 0x0019FE90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189810, XrefRangeEnd = 189828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendSetUpResponseCallbacks_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Server_SendSetUpResponseCallbacks_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005964 RID: 22884 RVA: 0x001A1CC4 File Offset: 0x0019FEC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189828, XrefRangeEnd = 189829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendSetUpResponseCallbacks_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___SendSetUpResponseCallbacks_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005965 RID: 22885 RVA: 0x001A1CF8 File Offset: 0x0019FEF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189829, XrefRangeEnd = 189832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendSetUpResponseCallbacks_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Server_SendSetUpResponseCallbacks_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005966 RID: 22886 RVA: 0x001A1D5C File Offset: 0x0019FF5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189832, XrefRangeEnd = 189850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetUpResponseCallbacks_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_SetUpResponseCallbacks_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005967 RID: 22887 RVA: 0x001A1D90 File Offset: 0x0019FF90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 189891, RefRangeEnd = 189893, XrefRangeStart = 189850, XrefRangeEnd = 189891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetUpResponseCallbacks_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___SetUpResponseCallbacks_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005968 RID: 22888 RVA: 0x001A1DC4 File Offset: 0x0019FFC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189893, XrefRangeEnd = 189896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetUpResponseCallbacks_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_SetUpResponseCallbacks_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005969 RID: 22889 RVA: 0x001A1E14 File Offset: 0x001A0014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ProcessCounterOfferServerSide_900355577(string productID, int quantity, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Server_ProcessCounterOfferServerSide_900355577_Private_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600596A RID: 22890 RVA: 0x001A1E74 File Offset: 0x001A0074
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 189981, RefRangeEnd = 189982, XrefRangeStart = 189896, XrefRangeEnd = 189981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ProcessCounterOfferServerSide_900355577(string productID, int quantity, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ProcessCounterOfferServerSide_900355577_Private_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600596B RID: 22891 RVA: 0x001A1ED4 File Offset: 0x001A00D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189982, XrefRangeEnd = 189988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ProcessCounterOfferServerSide_900355577(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Server_ProcessCounterOfferServerSide_900355577_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600596C RID: 22892 RVA: 0x001A1F38 File Offset: 0x001A0138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189988, XrefRangeEnd = 190006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetContractIsCounterOffer_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_SetContractIsCounterOffer_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600596D RID: 22893 RVA: 0x001A1F6C File Offset: 0x001A016C
		[CallerCount(0)]
		public unsafe void RpcLogic___SetContractIsCounterOffer_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___SetContractIsCounterOffer_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600596E RID: 22894 RVA: 0x001A1FA0 File Offset: 0x001A01A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190006, XrefRangeEnd = 190008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetContractIsCounterOffer_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_SetContractIsCounterOffer_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600596F RID: 22895 RVA: 0x001A1FF0 File Offset: 0x001A01F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendContractAccepted_507093020(EDealWindow window, bool trackContract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref window;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackContract;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Server_SendContractAccepted_507093020_Private_Void_EDealWindow_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005970 RID: 22896 RVA: 0x001A203C File Offset: 0x001A023C
		[CallerCount(0)]
		public unsafe void RpcLogic___SendContractAccepted_507093020(EDealWindow window, bool trackContract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref window;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackContract;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___SendContractAccepted_507093020_Private_Void_EDealWindow_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005971 RID: 22897 RVA: 0x001A2088 File Offset: 0x001A0288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190008, XrefRangeEnd = 190010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendContractAccepted_507093020(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Server_SendContractAccepted_507093020_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005972 RID: 22898 RVA: 0x001A20EC File Offset: 0x001A02EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190010, XrefRangeEnd = 190028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveContractAccepted_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveContractAccepted_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005973 RID: 22899 RVA: 0x001A2120 File Offset: 0x001A0320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190028, XrefRangeEnd = 190029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveContractAccepted_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ReceiveContractAccepted_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005974 RID: 22900 RVA: 0x001A2154 File Offset: 0x001A0354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190029, XrefRangeEnd = 190032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveContractAccepted_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_ReceiveContractAccepted_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005975 RID: 22901 RVA: 0x001A21A4 File Offset: 0x001A03A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190032, XrefRangeEnd = 190050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveContractRejected_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveContractRejected_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005976 RID: 22902 RVA: 0x001A21D8 File Offset: 0x001A03D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveContractRejected_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ReceiveContractRejected_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005977 RID: 22903 RVA: 0x001A220C File Offset: 0x001A040C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveContractRejected_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_ReceiveContractRejected_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005978 RID: 22904 RVA: 0x001A225C File Offset: 0x001A045C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ProcessHandoverServerSide_3760244802(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, bool handoverByPlayer, float totalPayment, ProductList productList, float satisfaction, NetworkObject dealer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handoverByPlayer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalPayment;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(productList);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref satisfaction;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Server_ProcessHandoverServerSide_3760244802_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005979 RID: 22905 RVA: 0x001A22FC File Offset: 0x001A04FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190212, RefRangeEnd = 190213, XrefRangeStart = 190050, XrefRangeEnd = 190212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ProcessHandoverServerSide_3760244802(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, bool handoverByPlayer, float totalPayment, ProductList productList, float satisfaction, NetworkObject dealer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handoverByPlayer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalPayment;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(productList);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref satisfaction;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ProcessHandoverServerSide_3760244802_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600597A RID: 22906 RVA: 0x001A239C File Offset: 0x001A059C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190213, XrefRangeEnd = 190221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ProcessHandoverServerSide_3760244802(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Server_ProcessHandoverServerSide_3760244802_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600597B RID: 22907 RVA: 0x001A2400 File Offset: 0x001A0600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ProcessHandoverClient_537707335(float satisfaction, bool handoverByPlayer, string npcToRecommend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref satisfaction;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handoverByPlayer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcToRecommend);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_ProcessHandoverClient_537707335_Private_Void_Single_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600597C RID: 22908 RVA: 0x001A2460 File Offset: 0x001A0660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190221, XrefRangeEnd = 190227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ProcessHandoverClient_537707335(float satisfaction, bool handoverByPlayer, string npcToRecommend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref satisfaction;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handoverByPlayer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcToRecommend);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ProcessHandoverClient_537707335_Private_Void_Single_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600597D RID: 22909 RVA: 0x001A24C0 File Offset: 0x001A06C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190227, XrefRangeEnd = 190235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ProcessHandoverClient_537707335(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_ProcessHandoverClient_537707335_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600597E RID: 22910 RVA: 0x001A2510 File Offset: 0x001A0710
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 188656, RefRangeEnd = 188658, XrefRangeStart = 188656, XrefRangeEnd = 188658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ChangeAddiction_431000436(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Server_ChangeAddiction_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600597F RID: 22911 RVA: 0x001A2550 File Offset: 0x001A0750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190235, XrefRangeEnd = 190236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ChangeAddiction_431000436(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ChangeAddiction_431000436_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005980 RID: 22912 RVA: 0x001A2590 File Offset: 0x001A0790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190236, XrefRangeEnd = 190239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ChangeAddiction_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Server_ChangeAddiction_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005981 RID: 22913 RVA: 0x001A25F4 File Offset: 0x001A07F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 188878, RefRangeEnd = 188879, XrefRangeStart = 188878, XrefRangeEnd = 188879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_RejectProductRequestOffer_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Server_RejectProductRequestOffer_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005982 RID: 22914 RVA: 0x001A2628 File Offset: 0x001A0828
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190271, RefRangeEnd = 190272, XrefRangeStart = 190239, XrefRangeEnd = 190271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RejectProductRequestOffer_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___RejectProductRequestOffer_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005983 RID: 22915 RVA: 0x001A265C File Offset: 0x001A085C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190272, XrefRangeEnd = 190274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_RejectProductRequestOffer_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Server_RejectProductRequestOffer_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005984 RID: 22916 RVA: 0x001A26C0 File Offset: 0x001A08C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190274, XrefRangeEnd = 190292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_RejectProductRequestOffer_Local_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_RejectProductRequestOffer_Local_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005985 RID: 22917 RVA: 0x001A26F4 File Offset: 0x001A08F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 190301, RefRangeEnd = 190304, XrefRangeStart = 190292, XrefRangeEnd = 190301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RejectProductRequestOffer_Local_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___RejectProductRequestOffer_Local_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005986 RID: 22918 RVA: 0x001A2728 File Offset: 0x001A0928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190304, XrefRangeEnd = 190307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_RejectProductRequestOffer_Local_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_RejectProductRequestOffer_Local_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005987 RID: 22919 RVA: 0x001A2778 File Offset: 0x001A0978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceiveCustomerData_2280244125(NetworkConnection conn, CustomerData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Target_ReceiveCustomerData_2280244125_Private_Void_NetworkConnection_CustomerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005988 RID: 22920 RVA: 0x001A27CC File Offset: 0x001A09CC
		[CallerCount(0)]
		public unsafe void RpcLogic___ReceiveCustomerData_2280244125(NetworkConnection conn, CustomerData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ReceiveCustomerData_2280244125_Private_Void_NetworkConnection_CustomerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005989 RID: 22921 RVA: 0x001A2820 File Offset: 0x001A0A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190307, XrefRangeEnd = 190310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceiveCustomerData_2280244125(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Target_ReceiveCustomerData_2280244125_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600598A RID: 22922 RVA: 0x001A2870 File Offset: 0x001A0A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190310, XrefRangeEnd = 190329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ProcessSampleServerSide_3704012609(List<ItemInstance> items)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Server_ProcessSampleServerSide_3704012609_Private_Void_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600598B RID: 22923 RVA: 0x001A28B4 File Offset: 0x001A0AB4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 190369, RefRangeEnd = 190374, XrefRangeStart = 190329, XrefRangeEnd = 190369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ProcessSampleServerSide_3704012609(List<ItemInstance> items)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ProcessSampleServerSide_3704012609_Private_Void_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600598C RID: 22924 RVA: 0x001A28F8 File Offset: 0x001A0AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190374, XrefRangeEnd = 190378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ProcessSampleServerSide_3704012609(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Server_ProcessSampleServerSide_3704012609_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600598D RID: 22925 RVA: 0x001A295C File Offset: 0x001A0B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190378, XrefRangeEnd = 190396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ProcessSampleClient_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_ProcessSampleClient_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600598E RID: 22926 RVA: 0x001A2990 File Offset: 0x001A0B90
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 190403, RefRangeEnd = 190406, XrefRangeStart = 190396, XrefRangeEnd = 190403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ProcessSampleClient_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ProcessSampleClient_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600598F RID: 22927 RVA: 0x001A29C4 File Offset: 0x001A0BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190406, XrefRangeEnd = 190409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ProcessSampleClient_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_ProcessSampleClient_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005990 RID: 22928 RVA: 0x001A2A14 File Offset: 0x001A0C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SampleWasSufficient_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_SampleWasSufficient_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005991 RID: 22929 RVA: 0x001A2A48 File Offset: 0x001A0C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190409, XrefRangeEnd = 190417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SampleWasSufficient_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___SampleWasSufficient_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005992 RID: 22930 RVA: 0x001A2A7C File Offset: 0x001A0C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190417, XrefRangeEnd = 190426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SampleWasSufficient_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_SampleWasSufficient_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005993 RID: 22931 RVA: 0x001A2ACC File Offset: 0x001A0CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SampleWasInsufficient_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_SampleWasInsufficient_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005994 RID: 22932 RVA: 0x001A2B00 File Offset: 0x001A0D00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190449, RefRangeEnd = 190450, XrefRangeStart = 190426, XrefRangeEnd = 190449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SampleWasInsufficient_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___SampleWasInsufficient_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005995 RID: 22933 RVA: 0x001A2B34 File Offset: 0x001A0D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190450, XrefRangeEnd = 190452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SampleWasInsufficient_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_SampleWasInsufficient_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005996 RID: 22934 RVA: 0x001A2B84 File Offset: 0x001A0D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_AdjustAffinity_3036964899(EDrugType drugType, float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref drugType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Server_AdjustAffinity_3036964899_Private_Void_EDrugType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005997 RID: 22935 RVA: 0x001A2BD0 File Offset: 0x001A0DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190452, XrefRangeEnd = 190465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AdjustAffinity_3036964899(EDrugType drugType, float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref drugType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___AdjustAffinity_3036964899_Public_Void_EDrugType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005998 RID: 22936 RVA: 0x001A2C1C File Offset: 0x001A0E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190465, XrefRangeEnd = 190481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_AdjustAffinity_3036964899(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Server_AdjustAffinity_3036964899_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001B26 RID: 6950
		// (get) Token: 0x06005999 RID: 22937 RVA: 0x001A2C80 File Offset: 0x001A0E80
		// (set) Token: 0x0600599A RID: 22938 RVA: 0x001A2CBC File Offset: 0x001A0EBC
		public unsafe float SyncAccessor_<CurrentAddiction>k__BackingField
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 86625, RefRangeEnd = 86627, XrefRangeStart = 86625, XrefRangeEnd = 86627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_sync___get_value__CurrentAddiction_k__BackingField_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 190489, RefRangeEnd = 190490, XrefRangeStart = 190481, XrefRangeEnd = 190489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_sync___set_value__CurrentAddiction_k__BackingField_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600599B RID: 22939 RVA: 0x001A2D08 File Offset: 0x001A0F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190490, XrefRangeEnd = 190495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Economy_Customer(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Customer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001B27 RID: 6951
		// (get) Token: 0x0600599C RID: 22940 RVA: 0x001A2D7C File Offset: 0x001A0F7C
		// (set) Token: 0x0600599D RID: 22941 RVA: 0x001A2DB8 File Offset: 0x001A0FB8
		public unsafe bool SyncAccessor_<HasBeenRecommended>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_sync___get_value__HasBeenRecommended_k__BackingField_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190495, XrefRangeEnd = 190503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_sync___set_value__HasBeenRecommended_k__BackingField_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600599E RID: 22942 RVA: 0x001A2E04 File Offset: 0x001A1004
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190533, RefRangeEnd = 190534, XrefRangeStart = 190503, XrefRangeEnd = 190533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600599F RID: 22943 RVA: 0x0002A2FE File Offset: 0x000284FE
		public Customer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001ACD RID: 6861
		// (get) Token: 0x060059A0 RID: 22944 RVA: 0x001A2E40 File Offset: 0x001A1040
		// (set) Token: 0x060059A1 RID: 22945 RVA: 0x0002A307 File Offset: 0x00028507
		public unsafe static Action<Customer> onCustomerUnlocked
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_onCustomerUnlocked, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Customer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_onCustomerUnlocked, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ACE RID: 6862
		// (get) Token: 0x060059A2 RID: 22946 RVA: 0x001A2E68 File Offset: 0x001A1068
		// (set) Token: 0x060059A3 RID: 22947 RVA: 0x0002A319 File Offset: 0x00028519
		public unsafe static List<Customer> UnlockedCustomers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_UnlockedCustomers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Customer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_UnlockedCustomers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ACF RID: 6863
		// (get) Token: 0x060059A4 RID: 22948 RVA: 0x001A2E90 File Offset: 0x001A1090
		// (set) Token: 0x060059A5 RID: 22949 RVA: 0x0002A32B File Offset: 0x0002852B
		public unsafe static float AFFINITY_MAX_EFFECT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_AFFINITY_MAX_EFFECT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_AFFINITY_MAX_EFFECT, (void*)(&value));
			}
		}

		// Token: 0x17001AD0 RID: 6864
		// (get) Token: 0x060059A6 RID: 22950 RVA: 0x001A2EAC File Offset: 0x001A10AC
		// (set) Token: 0x060059A7 RID: 22951 RVA: 0x0002A339 File Offset: 0x00028539
		public unsafe static float PROPERTY_MAX_EFFECT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_PROPERTY_MAX_EFFECT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_PROPERTY_MAX_EFFECT, (void*)(&value));
			}
		}

		// Token: 0x17001AD1 RID: 6865
		// (get) Token: 0x060059A8 RID: 22952 RVA: 0x001A2EC8 File Offset: 0x001A10C8
		// (set) Token: 0x060059A9 RID: 22953 RVA: 0x0002A347 File Offset: 0x00028547
		public unsafe static float QUALITY_MAX_EFFECT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_QUALITY_MAX_EFFECT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_QUALITY_MAX_EFFECT, (void*)(&value));
			}
		}

		// Token: 0x17001AD2 RID: 6866
		// (get) Token: 0x060059AA RID: 22954 RVA: 0x001A2EE4 File Offset: 0x001A10E4
		// (set) Token: 0x060059AB RID: 22955 RVA: 0x0002A355 File Offset: 0x00028555
		public unsafe static float DEAL_REJECTED_RELATIONSHIP_CHANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_DEAL_REJECTED_RELATIONSHIP_CHANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_DEAL_REJECTED_RELATIONSHIP_CHANGE, (void*)(&value));
			}
		}

		// Token: 0x17001AD3 RID: 6867
		// (get) Token: 0x060059AC RID: 22956 RVA: 0x001A2F00 File Offset: 0x001A1100
		// (set) Token: 0x060059AD RID: 22957 RVA: 0x0002A363 File Offset: 0x00028563
		public unsafe bool DEBUG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x17001AD4 RID: 6868
		// (get) Token: 0x060059AE RID: 22958 RVA: 0x001A2F28 File Offset: 0x001A1128
		// (set) Token: 0x060059AF RID: 22959 RVA: 0x0002A37E File Offset: 0x0002857E
		public unsafe static float APPROACH_MIN_ADDICTION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_APPROACH_MIN_ADDICTION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_APPROACH_MIN_ADDICTION, (void*)(&value));
			}
		}

		// Token: 0x17001AD5 RID: 6869
		// (get) Token: 0x060059B0 RID: 22960 RVA: 0x001A2F44 File Offset: 0x001A1144
		// (set) Token: 0x060059B1 RID: 22961 RVA: 0x0002A38C File Offset: 0x0002858C
		public unsafe static float APPROACH_CHANCE_PER_DAY_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_APPROACH_CHANCE_PER_DAY_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_APPROACH_CHANCE_PER_DAY_MAX, (void*)(&value));
			}
		}

		// Token: 0x17001AD6 RID: 6870
		// (get) Token: 0x060059B2 RID: 22962 RVA: 0x001A2F60 File Offset: 0x001A1160
		// (set) Token: 0x060059B3 RID: 22963 RVA: 0x0002A39A File Offset: 0x0002859A
		public unsafe static float APPROACH_MIN_COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_APPROACH_MIN_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_APPROACH_MIN_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17001AD7 RID: 6871
		// (get) Token: 0x060059B4 RID: 22964 RVA: 0x001A2F7C File Offset: 0x001A117C
		// (set) Token: 0x060059B5 RID: 22965 RVA: 0x0002A3A8 File Offset: 0x000285A8
		public unsafe static float APPROACH_MAX_COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_APPROACH_MAX_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_APPROACH_MAX_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17001AD8 RID: 6872
		// (get) Token: 0x060059B6 RID: 22966 RVA: 0x001A2F98 File Offset: 0x001A1198
		// (set) Token: 0x060059B7 RID: 22967 RVA: 0x0002A3B6 File Offset: 0x000285B6
		public unsafe static int DEAL_COOLDOWN
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_DEAL_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_DEAL_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17001AD9 RID: 6873
		// (get) Token: 0x060059B8 RID: 22968 RVA: 0x001A2FB4 File Offset: 0x001A11B4
		// (set) Token: 0x060059B9 RID: 22969 RVA: 0x0002A3C4 File Offset: 0x000285C4
		public unsafe static Il2CppStringArray PlayerAcceptMessages
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_PlayerAcceptMessages, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_PlayerAcceptMessages, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ADA RID: 6874
		// (get) Token: 0x060059BA RID: 22970 RVA: 0x001A2FDC File Offset: 0x001A11DC
		// (set) Token: 0x060059BB RID: 22971 RVA: 0x0002A3D6 File Offset: 0x000285D6
		public unsafe static Il2CppStringArray PlayerRejectMessages
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_PlayerRejectMessages, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_PlayerRejectMessages, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ADB RID: 6875
		// (get) Token: 0x060059BC RID: 22972 RVA: 0x001A3004 File Offset: 0x001A1204
		// (set) Token: 0x060059BD RID: 22973 RVA: 0x0002A3E8 File Offset: 0x000285E8
		public unsafe static int DEAL_ATTENDANCE_TOLERANCE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_DEAL_ATTENDANCE_TOLERANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_DEAL_ATTENDANCE_TOLERANCE, (void*)(&value));
			}
		}

		// Token: 0x17001ADC RID: 6876
		// (get) Token: 0x060059BE RID: 22974 RVA: 0x001A3020 File Offset: 0x001A1220
		// (set) Token: 0x060059BF RID: 22975 RVA: 0x0002A3F6 File Offset: 0x000285F6
		public unsafe static int MIN_TRAVEL_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_MIN_TRAVEL_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_MIN_TRAVEL_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001ADD RID: 6877
		// (get) Token: 0x060059C0 RID: 22976 RVA: 0x001A303C File Offset: 0x001A123C
		// (set) Token: 0x060059C1 RID: 22977 RVA: 0x0002A404 File Offset: 0x00028604
		public unsafe static int MAX_TRAVEL_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_MAX_TRAVEL_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_MAX_TRAVEL_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001ADE RID: 6878
		// (get) Token: 0x060059C2 RID: 22978 RVA: 0x001A3058 File Offset: 0x001A1258
		// (set) Token: 0x060059C3 RID: 22979 RVA: 0x0002A412 File Offset: 0x00028612
		public unsafe static int OFFER_EXPIRY_TIME_MINS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_OFFER_EXPIRY_TIME_MINS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_OFFER_EXPIRY_TIME_MINS, (void*)(&value));
			}
		}

		// Token: 0x17001ADF RID: 6879
		// (get) Token: 0x060059C4 RID: 22980 RVA: 0x001A3074 File Offset: 0x001A1274
		// (set) Token: 0x060059C5 RID: 22981 RVA: 0x0002A420 File Offset: 0x00028620
		public unsafe static float MIN_ORDER_APPEAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_MIN_ORDER_APPEAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_MIN_ORDER_APPEAL, (void*)(&value));
			}
		}

		// Token: 0x17001AE0 RID: 6880
		// (get) Token: 0x060059C6 RID: 22982 RVA: 0x001A3090 File Offset: 0x001A1290
		// (set) Token: 0x060059C7 RID: 22983 RVA: 0x0002A42E File Offset: 0x0002862E
		public unsafe static float ADDICTION_DRAIN_PER_DAY
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_ADDICTION_DRAIN_PER_DAY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_ADDICTION_DRAIN_PER_DAY, (void*)(&value));
			}
		}

		// Token: 0x17001AE1 RID: 6881
		// (get) Token: 0x060059C8 RID: 22984 RVA: 0x001A30AC File Offset: 0x001A12AC
		// (set) Token: 0x060059C9 RID: 22985 RVA: 0x0002A43C File Offset: 0x0002863C
		public unsafe static bool SAMPLE_REQUIRES_RECOMMENDATION
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_SAMPLE_REQUIRES_RECOMMENDATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_SAMPLE_REQUIRES_RECOMMENDATION, (void*)(&value));
			}
		}

		// Token: 0x17001AE2 RID: 6882
		// (get) Token: 0x060059CA RID: 22986 RVA: 0x001A30C8 File Offset: 0x001A12C8
		// (set) Token: 0x060059CB RID: 22987 RVA: 0x0002A44A File Offset: 0x0002864A
		public unsafe static float MIN_NORMALIZED_RELATIONSHIP_FOR_RECOMMENDATION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_MIN_NORMALIZED_RELATIONSHIP_FOR_RECOMMENDATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_MIN_NORMALIZED_RELATIONSHIP_FOR_RECOMMENDATION, (void*)(&value));
			}
		}

		// Token: 0x17001AE3 RID: 6883
		// (get) Token: 0x060059CC RID: 22988 RVA: 0x001A30E4 File Offset: 0x001A12E4
		// (set) Token: 0x060059CD RID: 22989 RVA: 0x0002A458 File Offset: 0x00028658
		public unsafe static float RELATIONSHIP_FOR_GUARANTEED_DEALER_RECOMMENDATION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_RELATIONSHIP_FOR_GUARANTEED_DEALER_RECOMMENDATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_RELATIONSHIP_FOR_GUARANTEED_DEALER_RECOMMENDATION, (void*)(&value));
			}
		}

		// Token: 0x17001AE4 RID: 6884
		// (get) Token: 0x060059CE RID: 22990 RVA: 0x001A3100 File Offset: 0x001A1300
		// (set) Token: 0x060059CF RID: 22991 RVA: 0x0002A466 File Offset: 0x00028666
		public unsafe static float RELATIONSHIP_FOR_GUARANTEED_SUPPLIER_RECOMMENDATION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_RELATIONSHIP_FOR_GUARANTEED_SUPPLIER_RECOMMENDATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_RELATIONSHIP_FOR_GUARANTEED_SUPPLIER_RECOMMENDATION, (void*)(&value));
			}
		}

		// Token: 0x17001AE5 RID: 6885
		// (get) Token: 0x060059D0 RID: 22992 RVA: 0x001A311C File Offset: 0x001A131C
		// (set) Token: 0x060059D1 RID: 22993 RVA: 0x0002A474 File Offset: 0x00028674
		public unsafe float _CurrentAddiction_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__CurrentAddiction_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__CurrentAddiction_k__BackingField)) = value;
			}
		}

		// Token: 0x17001AE6 RID: 6886
		// (get) Token: 0x060059D2 RID: 22994 RVA: 0x001A3144 File Offset: 0x001A1344
		// (set) Token: 0x060059D3 RID: 22995 RVA: 0x0002A48F File Offset: 0x0002868F
		public unsafe ContractInfo offeredContractInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_offeredContractInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContractInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_offeredContractInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AE7 RID: 6887
		// (get) Token: 0x060059D4 RID: 22996 RVA: 0x001A3174 File Offset: 0x001A1374
		// (set) Token: 0x060059D5 RID: 22997 RVA: 0x0002A4AE File Offset: 0x000286AE
		public unsafe GameDateTime _OfferedContractTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__OfferedContractTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__OfferedContractTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17001AE8 RID: 6888
		// (get) Token: 0x060059D6 RID: 22998 RVA: 0x001A319C File Offset: 0x001A139C
		// (set) Token: 0x060059D7 RID: 22999 RVA: 0x0002A4C9 File Offset: 0x000286C9
		public unsafe Contract _CurrentContract_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__CurrentContract_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Contract>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__CurrentContract_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AE9 RID: 6889
		// (get) Token: 0x060059D8 RID: 23000 RVA: 0x001A31CC File Offset: 0x001A13CC
		// (set) Token: 0x060059D9 RID: 23001 RVA: 0x0002A4E8 File Offset: 0x000286E8
		public unsafe bool _IsAwaitingDelivery_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__IsAwaitingDelivery_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__IsAwaitingDelivery_k__BackingField)) = value;
			}
		}

		// Token: 0x17001AEA RID: 6890
		// (get) Token: 0x060059DA RID: 23002 RVA: 0x001A31F4 File Offset: 0x001A13F4
		// (set) Token: 0x060059DB RID: 23003 RVA: 0x0002A503 File Offset: 0x00028703
		public unsafe int _TimeSinceLastDealCompleted_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__TimeSinceLastDealCompleted_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__TimeSinceLastDealCompleted_k__BackingField)) = value;
			}
		}

		// Token: 0x17001AEB RID: 6891
		// (get) Token: 0x060059DC RID: 23004 RVA: 0x001A321C File Offset: 0x001A141C
		// (set) Token: 0x060059DD RID: 23005 RVA: 0x0002A51E File Offset: 0x0002871E
		public unsafe int _TimeSinceLastDealOffered_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__TimeSinceLastDealOffered_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__TimeSinceLastDealOffered_k__BackingField)) = value;
			}
		}

		// Token: 0x17001AEC RID: 6892
		// (get) Token: 0x060059DE RID: 23006 RVA: 0x001A3244 File Offset: 0x001A1444
		// (set) Token: 0x060059DF RID: 23007 RVA: 0x0002A539 File Offset: 0x00028739
		public unsafe int _TimeSincePlayerApproached_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__TimeSincePlayerApproached_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__TimeSincePlayerApproached_k__BackingField)) = value;
			}
		}

		// Token: 0x17001AED RID: 6893
		// (get) Token: 0x060059E0 RID: 23008 RVA: 0x001A326C File Offset: 0x001A146C
		// (set) Token: 0x060059E1 RID: 23009 RVA: 0x0002A554 File Offset: 0x00028754
		public unsafe int _TimeSinceInstantDealOffered_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__TimeSinceInstantDealOffered_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__TimeSinceInstantDealOffered_k__BackingField)) = value;
			}
		}

		// Token: 0x17001AEE RID: 6894
		// (get) Token: 0x060059E2 RID: 23010 RVA: 0x001A3294 File Offset: 0x001A1494
		// (set) Token: 0x060059E3 RID: 23011 RVA: 0x0002A56F File Offset: 0x0002876F
		public unsafe int _OfferedDeals_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__OfferedDeals_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__OfferedDeals_k__BackingField)) = value;
			}
		}

		// Token: 0x17001AEF RID: 6895
		// (get) Token: 0x060059E4 RID: 23012 RVA: 0x001A32BC File Offset: 0x001A14BC
		// (set) Token: 0x060059E5 RID: 23013 RVA: 0x0002A58A File Offset: 0x0002878A
		public unsafe int _CompletedDeliveries_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__CompletedDeliveries_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__CompletedDeliveries_k__BackingField)) = value;
			}
		}

		// Token: 0x17001AF0 RID: 6896
		// (get) Token: 0x060059E6 RID: 23014 RVA: 0x001A32E4 File Offset: 0x001A14E4
		// (set) Token: 0x060059E7 RID: 23015 RVA: 0x0002A5A5 File Offset: 0x000287A5
		public unsafe bool _HasBeenRecommended_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__HasBeenRecommended_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__HasBeenRecommended_k__BackingField)) = value;
			}
		}

		// Token: 0x17001AF1 RID: 6897
		// (get) Token: 0x060059E8 RID: 23016 RVA: 0x001A330C File Offset: 0x001A150C
		// (set) Token: 0x060059E9 RID: 23017 RVA: 0x0002A5C0 File Offset: 0x000287C0
		public unsafe NPC _NPC_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__NPC_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__NPC_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF2 RID: 6898
		// (get) Token: 0x060059EA RID: 23018 RVA: 0x001A333C File Offset: 0x001A153C
		// (set) Token: 0x060059EB RID: 23019 RVA: 0x0002A5DF File Offset: 0x000287DF
		public unsafe Dealer _AssignedDealer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__AssignedDealer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__AssignedDealer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF3 RID: 6899
		// (get) Token: 0x060059EC RID: 23020 RVA: 0x001A336C File Offset: 0x001A156C
		// (set) Token: 0x060059ED RID: 23021 RVA: 0x0002A5FE File Offset: 0x000287FE
		public unsafe NPCSignal_WaitForDelivery DealSignal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_DealSignal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCSignal_WaitForDelivery>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_DealSignal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF4 RID: 6900
		// (get) Token: 0x060059EE RID: 23022 RVA: 0x001A339C File Offset: 0x001A159C
		// (set) Token: 0x060059EF RID: 23023 RVA: 0x0002A61D File Offset: 0x0002881D
		public unsafe bool AvailableInDemo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_AvailableInDemo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_AvailableInDemo)) = value;
			}
		}

		// Token: 0x17001AF5 RID: 6901
		// (get) Token: 0x060059F0 RID: 23024 RVA: 0x001A33C4 File Offset: 0x001A15C4
		// (set) Token: 0x060059F1 RID: 23025 RVA: 0x0002A638 File Offset: 0x00028838
		public unsafe CustomerData customerData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_customerData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomerData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_customerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF6 RID: 6902
		// (get) Token: 0x060059F2 RID: 23026 RVA: 0x001A33F4 File Offset: 0x001A15F4
		// (set) Token: 0x060059F3 RID: 23027 RVA: 0x0002A657 File Offset: 0x00028857
		public unsafe DeliveryLocation DefaultDeliveryLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_DefaultDeliveryLocation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryLocation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_DefaultDeliveryLocation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF7 RID: 6903
		// (get) Token: 0x060059F4 RID: 23028 RVA: 0x001A3424 File Offset: 0x001A1624
		// (set) Token: 0x060059F5 RID: 23029 RVA: 0x0002A676 File Offset: 0x00028876
		public unsafe bool CanRecommendFriends
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_CanRecommendFriends);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_CanRecommendFriends)) = value;
			}
		}

		// Token: 0x17001AF8 RID: 6904
		// (get) Token: 0x060059F6 RID: 23030 RVA: 0x001A344C File Offset: 0x001A164C
		// (set) Token: 0x060059F7 RID: 23031 RVA: 0x0002A691 File Offset: 0x00028891
		public unsafe UnityEvent onUnlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_onUnlocked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_onUnlocked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AF9 RID: 6905
		// (get) Token: 0x060059F8 RID: 23032 RVA: 0x001A347C File Offset: 0x001A167C
		// (set) Token: 0x060059F9 RID: 23033 RVA: 0x0002A6B0 File Offset: 0x000288B0
		public unsafe UnityEvent onDealCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_onDealCompleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_onDealCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AFA RID: 6906
		// (get) Token: 0x060059FA RID: 23034 RVA: 0x001A34AC File Offset: 0x001A16AC
		// (set) Token: 0x060059FB RID: 23035 RVA: 0x0002A6CF File Offset: 0x000288CF
		public unsafe UnityEvent<Contract> onContractAssigned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_onContractAssigned);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Contract>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_onContractAssigned), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AFB RID: 6907
		// (get) Token: 0x060059FC RID: 23036 RVA: 0x001A34DC File Offset: 0x001A16DC
		// (set) Token: 0x060059FD RID: 23037 RVA: 0x0002A6EE File Offset: 0x000288EE
		public unsafe bool awaitingSample
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_awaitingSample);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_awaitingSample)) = value;
			}
		}

		// Token: 0x17001AFC RID: 6908
		// (get) Token: 0x060059FE RID: 23038 RVA: 0x001A3504 File Offset: 0x001A1704
		// (set) Token: 0x060059FF RID: 23039 RVA: 0x0002A709 File Offset: 0x00028909
		public unsafe DialogueController.DialogueChoice sampleChoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_sampleChoice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_sampleChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AFD RID: 6909
		// (get) Token: 0x06005A00 RID: 23040 RVA: 0x001A3534 File Offset: 0x001A1734
		// (set) Token: 0x06005A01 RID: 23041 RVA: 0x0002A728 File Offset: 0x00028928
		public unsafe DialogueController.DialogueChoice completeContractChoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_completeContractChoice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_completeContractChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AFE RID: 6910
		// (get) Token: 0x06005A02 RID: 23042 RVA: 0x001A3564 File Offset: 0x001A1764
		// (set) Token: 0x06005A03 RID: 23043 RVA: 0x0002A747 File Offset: 0x00028947
		public unsafe DialogueController.DialogueChoice offerDealChoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_offerDealChoice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_offerDealChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AFF RID: 6911
		// (get) Token: 0x06005A04 RID: 23044 RVA: 0x001A3594 File Offset: 0x001A1794
		// (set) Token: 0x06005A05 RID: 23045 RVA: 0x0002A766 File Offset: 0x00028966
		public unsafe DialogueController.GreetingOverride awaitingDealGreeting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_awaitingDealGreeting);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.GreetingOverride>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_awaitingDealGreeting), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B00 RID: 6912
		// (get) Token: 0x06005A06 RID: 23046 RVA: 0x001A35C4 File Offset: 0x001A17C4
		// (set) Token: 0x06005A07 RID: 23047 RVA: 0x0002A785 File Offset: 0x00028985
		public unsafe int minsSinceUnlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_minsSinceUnlocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_minsSinceUnlocked)) = value;
			}
		}

		// Token: 0x17001B01 RID: 6913
		// (get) Token: 0x06005A08 RID: 23048 RVA: 0x001A35EC File Offset: 0x001A17EC
		// (set) Token: 0x06005A09 RID: 23049 RVA: 0x0002A7A0 File Offset: 0x000289A0
		public unsafe bool sampleOfferedToday
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_sampleOfferedToday);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_sampleOfferedToday)) = value;
			}
		}

		// Token: 0x17001B02 RID: 6914
		// (get) Token: 0x06005A0A RID: 23050 RVA: 0x001A3614 File Offset: 0x001A1814
		// (set) Token: 0x06005A0B RID: 23051 RVA: 0x0002A7BB File Offset: 0x000289BB
		public unsafe NPCPoI _potentialCustomerPoI_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__potentialCustomerPoI_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCPoI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__potentialCustomerPoI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B03 RID: 6915
		// (get) Token: 0x06005A0C RID: 23052 RVA: 0x001A3644 File Offset: 0x001A1844
		// (set) Token: 0x06005A0D RID: 23053 RVA: 0x0002A7DA File Offset: 0x000289DA
		public unsafe CustomerAffinityData currentAffinityData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_currentAffinityData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomerAffinityData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_currentAffinityData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B04 RID: 6916
		// (get) Token: 0x06005A0E RID: 23054 RVA: 0x001A3674 File Offset: 0x001A1874
		// (set) Token: 0x06005A0F RID: 23055 RVA: 0x0002A7F9 File Offset: 0x000289F9
		public unsafe bool pendingInstantDeal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_pendingInstantDeal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_pendingInstantDeal)) = value;
			}
		}

		// Token: 0x17001B05 RID: 6917
		// (get) Token: 0x06005A10 RID: 23056 RVA: 0x001A369C File Offset: 0x001A189C
		// (set) Token: 0x06005A11 RID: 23057 RVA: 0x0002A814 File Offset: 0x00028A14
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B06 RID: 6918
		// (get) Token: 0x06005A12 RID: 23058 RVA: 0x001A36CC File Offset: 0x001A18CC
		// (set) Token: 0x06005A13 RID: 23059 RVA: 0x0002A833 File Offset: 0x00028A33
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B07 RID: 6919
		// (get) Token: 0x06005A14 RID: 23060 RVA: 0x001A36FC File Offset: 0x001A18FC
		// (set) Token: 0x06005A15 RID: 23061 RVA: 0x0002A852 File Offset: 0x00028A52
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x17001B08 RID: 6920
		// (get) Token: 0x06005A16 RID: 23062 RVA: 0x001A3724 File Offset: 0x001A1924
		// (set) Token: 0x06005A17 RID: 23063 RVA: 0x0002A86D File Offset: 0x00028A6D
		public unsafe ProductItemInstance consumedSample
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_consumedSample);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_consumedSample), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B09 RID: 6921
		// (get) Token: 0x06005A18 RID: 23064 RVA: 0x001A3754 File Offset: 0x001A1954
		// (set) Token: 0x06005A19 RID: 23065 RVA: 0x0002A88C File Offset: 0x00028A8C
		public unsafe SyncVar<float> syncVar____CurrentAddiction_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_syncVar____CurrentAddiction_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_syncVar____CurrentAddiction_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B0A RID: 6922
		// (get) Token: 0x06005A1A RID: 23066 RVA: 0x001A3784 File Offset: 0x001A1984
		// (set) Token: 0x06005A1B RID: 23067 RVA: 0x0002A8AB File Offset: 0x00028AAB
		public unsafe SyncVar<bool> syncVar____HasBeenRecommended_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_syncVar____HasBeenRecommended_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_syncVar____HasBeenRecommended_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B0B RID: 6923
		// (get) Token: 0x06005A1C RID: 23068 RVA: 0x001A37B4 File Offset: 0x001A19B4
		// (set) Token: 0x06005A1D RID: 23069 RVA: 0x0002A8CA File Offset: 0x00028ACA
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001B0C RID: 6924
		// (get) Token: 0x06005A1E RID: 23070 RVA: 0x001A37DC File Offset: 0x001A19DC
		// (set) Token: 0x06005A1F RID: 23071 RVA: 0x0002A8E5 File Offset: 0x00028AE5
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003C70 RID: 15472
		private static readonly IntPtr NativeFieldInfoPtr_onCustomerUnlocked;

		// Token: 0x04003C71 RID: 15473
		private static readonly IntPtr NativeFieldInfoPtr_UnlockedCustomers;

		// Token: 0x04003C72 RID: 15474
		private static readonly IntPtr NativeFieldInfoPtr_AFFINITY_MAX_EFFECT;

		// Token: 0x04003C73 RID: 15475
		private static readonly IntPtr NativeFieldInfoPtr_PROPERTY_MAX_EFFECT;

		// Token: 0x04003C74 RID: 15476
		private static readonly IntPtr NativeFieldInfoPtr_QUALITY_MAX_EFFECT;

		// Token: 0x04003C75 RID: 15477
		private static readonly IntPtr NativeFieldInfoPtr_DEAL_REJECTED_RELATIONSHIP_CHANGE;

		// Token: 0x04003C76 RID: 15478
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04003C77 RID: 15479
		private static readonly IntPtr NativeFieldInfoPtr_APPROACH_MIN_ADDICTION;

		// Token: 0x04003C78 RID: 15480
		private static readonly IntPtr NativeFieldInfoPtr_APPROACH_CHANCE_PER_DAY_MAX;

		// Token: 0x04003C79 RID: 15481
		private static readonly IntPtr NativeFieldInfoPtr_APPROACH_MIN_COOLDOWN;

		// Token: 0x04003C7A RID: 15482
		private static readonly IntPtr NativeFieldInfoPtr_APPROACH_MAX_COOLDOWN;

		// Token: 0x04003C7B RID: 15483
		private static readonly IntPtr NativeFieldInfoPtr_DEAL_COOLDOWN;

		// Token: 0x04003C7C RID: 15484
		private static readonly IntPtr NativeFieldInfoPtr_PlayerAcceptMessages;

		// Token: 0x04003C7D RID: 15485
		private static readonly IntPtr NativeFieldInfoPtr_PlayerRejectMessages;

		// Token: 0x04003C7E RID: 15486
		private static readonly IntPtr NativeFieldInfoPtr_DEAL_ATTENDANCE_TOLERANCE;

		// Token: 0x04003C7F RID: 15487
		private static readonly IntPtr NativeFieldInfoPtr_MIN_TRAVEL_TIME;

		// Token: 0x04003C80 RID: 15488
		private static readonly IntPtr NativeFieldInfoPtr_MAX_TRAVEL_TIME;

		// Token: 0x04003C81 RID: 15489
		private static readonly IntPtr NativeFieldInfoPtr_OFFER_EXPIRY_TIME_MINS;

		// Token: 0x04003C82 RID: 15490
		private static readonly IntPtr NativeFieldInfoPtr_MIN_ORDER_APPEAL;

		// Token: 0x04003C83 RID: 15491
		private static readonly IntPtr NativeFieldInfoPtr_ADDICTION_DRAIN_PER_DAY;

		// Token: 0x04003C84 RID: 15492
		private static readonly IntPtr NativeFieldInfoPtr_SAMPLE_REQUIRES_RECOMMENDATION;

		// Token: 0x04003C85 RID: 15493
		private static readonly IntPtr NativeFieldInfoPtr_MIN_NORMALIZED_RELATIONSHIP_FOR_RECOMMENDATION;

		// Token: 0x04003C86 RID: 15494
		private static readonly IntPtr NativeFieldInfoPtr_RELATIONSHIP_FOR_GUARANTEED_DEALER_RECOMMENDATION;

		// Token: 0x04003C87 RID: 15495
		private static readonly IntPtr NativeFieldInfoPtr_RELATIONSHIP_FOR_GUARANTEED_SUPPLIER_RECOMMENDATION;

		// Token: 0x04003C88 RID: 15496
		private static readonly IntPtr NativeFieldInfoPtr__CurrentAddiction_k__BackingField;

		// Token: 0x04003C89 RID: 15497
		private static readonly IntPtr NativeFieldInfoPtr_offeredContractInfo;

		// Token: 0x04003C8A RID: 15498
		private static readonly IntPtr NativeFieldInfoPtr__OfferedContractTime_k__BackingField;

		// Token: 0x04003C8B RID: 15499
		private static readonly IntPtr NativeFieldInfoPtr__CurrentContract_k__BackingField;

		// Token: 0x04003C8C RID: 15500
		private static readonly IntPtr NativeFieldInfoPtr__IsAwaitingDelivery_k__BackingField;

		// Token: 0x04003C8D RID: 15501
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceLastDealCompleted_k__BackingField;

		// Token: 0x04003C8E RID: 15502
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceLastDealOffered_k__BackingField;

		// Token: 0x04003C8F RID: 15503
		private static readonly IntPtr NativeFieldInfoPtr__TimeSincePlayerApproached_k__BackingField;

		// Token: 0x04003C90 RID: 15504
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceInstantDealOffered_k__BackingField;

		// Token: 0x04003C91 RID: 15505
		private static readonly IntPtr NativeFieldInfoPtr__OfferedDeals_k__BackingField;

		// Token: 0x04003C92 RID: 15506
		private static readonly IntPtr NativeFieldInfoPtr__CompletedDeliveries_k__BackingField;

		// Token: 0x04003C93 RID: 15507
		private static readonly IntPtr NativeFieldInfoPtr__HasBeenRecommended_k__BackingField;

		// Token: 0x04003C94 RID: 15508
		private static readonly IntPtr NativeFieldInfoPtr__NPC_k__BackingField;

		// Token: 0x04003C95 RID: 15509
		private static readonly IntPtr NativeFieldInfoPtr__AssignedDealer_k__BackingField;

		// Token: 0x04003C96 RID: 15510
		private static readonly IntPtr NativeFieldInfoPtr_DealSignal;

		// Token: 0x04003C97 RID: 15511
		private static readonly IntPtr NativeFieldInfoPtr_AvailableInDemo;

		// Token: 0x04003C98 RID: 15512
		private static readonly IntPtr NativeFieldInfoPtr_customerData;

		// Token: 0x04003C99 RID: 15513
		private static readonly IntPtr NativeFieldInfoPtr_DefaultDeliveryLocation;

		// Token: 0x04003C9A RID: 15514
		private static readonly IntPtr NativeFieldInfoPtr_CanRecommendFriends;

		// Token: 0x04003C9B RID: 15515
		private static readonly IntPtr NativeFieldInfoPtr_onUnlocked;

		// Token: 0x04003C9C RID: 15516
		private static readonly IntPtr NativeFieldInfoPtr_onDealCompleted;

		// Token: 0x04003C9D RID: 15517
		private static readonly IntPtr NativeFieldInfoPtr_onContractAssigned;

		// Token: 0x04003C9E RID: 15518
		private static readonly IntPtr NativeFieldInfoPtr_awaitingSample;

		// Token: 0x04003C9F RID: 15519
		private static readonly IntPtr NativeFieldInfoPtr_sampleChoice;

		// Token: 0x04003CA0 RID: 15520
		private static readonly IntPtr NativeFieldInfoPtr_completeContractChoice;

		// Token: 0x04003CA1 RID: 15521
		private static readonly IntPtr NativeFieldInfoPtr_offerDealChoice;

		// Token: 0x04003CA2 RID: 15522
		private static readonly IntPtr NativeFieldInfoPtr_awaitingDealGreeting;

		// Token: 0x04003CA3 RID: 15523
		private static readonly IntPtr NativeFieldInfoPtr_minsSinceUnlocked;

		// Token: 0x04003CA4 RID: 15524
		private static readonly IntPtr NativeFieldInfoPtr_sampleOfferedToday;

		// Token: 0x04003CA5 RID: 15525
		private static readonly IntPtr NativeFieldInfoPtr__potentialCustomerPoI_k__BackingField;

		// Token: 0x04003CA6 RID: 15526
		private static readonly IntPtr NativeFieldInfoPtr_currentAffinityData;

		// Token: 0x04003CA7 RID: 15527
		private static readonly IntPtr NativeFieldInfoPtr_pendingInstantDeal;

		// Token: 0x04003CA8 RID: 15528
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04003CA9 RID: 15529
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04003CAA RID: 15530
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04003CAB RID: 15531
		private static readonly IntPtr NativeFieldInfoPtr_consumedSample;

		// Token: 0x04003CAC RID: 15532
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____CurrentAddiction_k__BackingField;

		// Token: 0x04003CAD RID: 15533
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____HasBeenRecommended_k__BackingField;

		// Token: 0x04003CAE RID: 15534
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003CAF RID: 15535
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003CB0 RID: 15536
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentAddiction_Public_get_Single_0;

		// Token: 0x04003CB1 RID: 15537
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentAddiction_Protected_set_Void_Single_0;

		// Token: 0x04003CB2 RID: 15538
		private static readonly IntPtr NativeMethodInfoPtr_get_OfferedContractInfo_Public_get_ContractInfo_0;

		// Token: 0x04003CB3 RID: 15539
		private static readonly IntPtr NativeMethodInfoPtr_set_OfferedContractInfo_Protected_set_Void_ContractInfo_0;

		// Token: 0x04003CB4 RID: 15540
		private static readonly IntPtr NativeMethodInfoPtr_get_OfferedContractTime_Public_get_GameDateTime_0;

		// Token: 0x04003CB5 RID: 15541
		private static readonly IntPtr NativeMethodInfoPtr_set_OfferedContractTime_Protected_set_Void_GameDateTime_0;

		// Token: 0x04003CB6 RID: 15542
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentContract_Public_get_Contract_0;

		// Token: 0x04003CB7 RID: 15543
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentContract_Protected_set_Void_Contract_0;

		// Token: 0x04003CB8 RID: 15544
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAwaitingDelivery_Public_get_Boolean_0;

		// Token: 0x04003CB9 RID: 15545
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAwaitingDelivery_Protected_set_Void_Boolean_0;

		// Token: 0x04003CBA RID: 15546
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceLastDealCompleted_Public_get_Int32_0;

		// Token: 0x04003CBB RID: 15547
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceLastDealCompleted_Protected_set_Void_Int32_0;

		// Token: 0x04003CBC RID: 15548
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceLastDealOffered_Public_get_Int32_0;

		// Token: 0x04003CBD RID: 15549
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceLastDealOffered_Protected_set_Void_Int32_0;

		// Token: 0x04003CBE RID: 15550
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSincePlayerApproached_Public_get_Int32_0;

		// Token: 0x04003CBF RID: 15551
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSincePlayerApproached_Protected_set_Void_Int32_0;

		// Token: 0x04003CC0 RID: 15552
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceInstantDealOffered_Public_get_Int32_0;

		// Token: 0x04003CC1 RID: 15553
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceInstantDealOffered_Protected_set_Void_Int32_0;

		// Token: 0x04003CC2 RID: 15554
		private static readonly IntPtr NativeMethodInfoPtr_get_OfferedDeals_Public_get_Int32_0;

		// Token: 0x04003CC3 RID: 15555
		private static readonly IntPtr NativeMethodInfoPtr_set_OfferedDeals_Protected_set_Void_Int32_0;

		// Token: 0x04003CC4 RID: 15556
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletedDeliveries_Public_get_Int32_0;

		// Token: 0x04003CC5 RID: 15557
		private static readonly IntPtr NativeMethodInfoPtr_set_CompletedDeliveries_Protected_set_Void_Int32_0;

		// Token: 0x04003CC6 RID: 15558
		private static readonly IntPtr NativeMethodInfoPtr_get_HasBeenRecommended_Public_get_Boolean_0;

		// Token: 0x04003CC7 RID: 15559
		private static readonly IntPtr NativeMethodInfoPtr_set_HasBeenRecommended_Protected_set_Void_Boolean_0;

		// Token: 0x04003CC8 RID: 15560
		private static readonly IntPtr NativeMethodInfoPtr_get_NPC_Public_get_NPC_0;

		// Token: 0x04003CC9 RID: 15561
		private static readonly IntPtr NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0;

		// Token: 0x04003CCA RID: 15562
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedDealer_Public_get_Dealer_0;

		// Token: 0x04003CCB RID: 15563
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedDealer_Protected_set_Void_Dealer_0;

		// Token: 0x04003CCC RID: 15564
		private static readonly IntPtr NativeMethodInfoPtr_get_CustomerData_Public_get_CustomerData_0;

		// Token: 0x04003CCD RID: 15565
		private static readonly IntPtr NativeMethodInfoPtr_get_OrderableProducts_Public_get_List_1_ProductDefinition_0;

		// Token: 0x04003CCE RID: 15566
		private static readonly IntPtr NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0;

		// Token: 0x04003CCF RID: 15567
		private static readonly IntPtr NativeMethodInfoPtr_get_potentialCustomerPoI_Public_get_NPCPoI_0;

		// Token: 0x04003CD0 RID: 15568
		private static readonly IntPtr NativeMethodInfoPtr_set_potentialCustomerPoI_Private_set_Void_NPCPoI_0;

		// Token: 0x04003CD1 RID: 15569
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04003CD2 RID: 15570
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04003CD3 RID: 15571
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04003CD4 RID: 15572
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003CD5 RID: 15573
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04003CD6 RID: 15574
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04003CD7 RID: 15575
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04003CD8 RID: 15576
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04003CD9 RID: 15577
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003CDA RID: 15578
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04003CDB RID: 15579
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04003CDC RID: 15580
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0;

		// Token: 0x04003CDD RID: 15581
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_1;

		// Token: 0x04003CDE RID: 15582
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x04003CDF RID: 15583
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003CE0 RID: 15584
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_1;

		// Token: 0x04003CE1 RID: 15585
		private static readonly IntPtr NativeMethodInfoPtr_SetUpDialogue_Private_Void_1;

		// Token: 0x04003CE2 RID: 15586
		private static readonly IntPtr NativeMethodInfoPtr_SetupPoI_Private_Void_1;

		// Token: 0x04003CE3 RID: 15587
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04003CE4 RID: 15588
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_1;

		// Token: 0x04003CE5 RID: 15589
		private static readonly IntPtr NativeMethodInfoPtr_DayPass_Protected_Virtual_New_Void_1;

		// Token: 0x04003CE6 RID: 15590
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDealAttendance_Private_Void_1;

		// Token: 0x04003CE7 RID: 15591
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureDealSignal_Private_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x04003CE8 RID: 15592
		private static readonly IntPtr NativeMethodInfoPtr_UpdateOfferExpiry_Private_Void_1;

		// Token: 0x04003CE9 RID: 15593
		private static readonly IntPtr NativeMethodInfoPtr_CheckContractGeneration_Private_ContractInfo_Boolean_0;

		// Token: 0x04003CEA RID: 15594
		private static readonly IntPtr NativeMethodInfoPtr_GetWeightedRandomProduct_Private_ProductDefinition_byref_Single_0;

		// Token: 0x04003CEB RID: 15595
		private static readonly IntPtr NativeMethodInfoPtr_OnCustomerUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0;

		// Token: 0x04003CEC RID: 15596
		private static readonly IntPtr NativeMethodInfoPtr_SetHasBeenRecommended_Public_Void_0;

		// Token: 0x04003CED RID: 15597
		private static readonly IntPtr NativeMethodInfoPtr_OfferContract_Public_Virtual_New_Void_ContractInfo_0;

		// Token: 0x04003CEE RID: 15598
		private static readonly IntPtr NativeMethodInfoPtr_SetOfferedContract_Private_Void_ContractInfo_GameDateTime_0;

		// Token: 0x04003CEF RID: 15599
		private static readonly IntPtr NativeMethodInfoPtr_ExpireOffer_Public_Virtual_New_Void_0;

		// Token: 0x04003CF0 RID: 15600
		private static readonly IntPtr NativeMethodInfoPtr_AssignContract_Public_Virtual_New_Void_Contract_0;

		// Token: 0x04003CF1 RID: 15601
		private static readonly IntPtr NativeMethodInfoPtr_NotifyPlayerOfContract_Protected_Virtual_New_Void_ContractInfo_MessageChain_Boolean_Boolean_Boolean_0;

		// Token: 0x04003CF2 RID: 15602
		private static readonly IntPtr NativeMethodInfoPtr_SendSetUpResponseCallbacks_Private_Void_1;

		// Token: 0x04003CF3 RID: 15603
		private static readonly IntPtr NativeMethodInfoPtr_SetUpResponseCallbacks_Private_Void_1;

		// Token: 0x04003CF4 RID: 15604
		private static readonly IntPtr NativeMethodInfoPtr_AcceptContractClicked_Protected_Virtual_New_Void_1;

		// Token: 0x04003CF5 RID: 15605
		private static readonly IntPtr NativeMethodInfoPtr_CounterOfferClicked_Protected_Virtual_New_Void_1;

		// Token: 0x04003CF6 RID: 15606
		private static readonly IntPtr NativeMethodInfoPtr_SendCounteroffer_Protected_Virtual_New_Void_ProductDefinition_Int32_Single_0;

		// Token: 0x04003CF7 RID: 15607
		private static readonly IntPtr NativeMethodInfoPtr_ProcessCounterOfferServerSide_Private_Void_String_Int32_Single_0;

		// Token: 0x04003CF8 RID: 15608
		private static readonly IntPtr NativeMethodInfoPtr_SetContractIsCounterOffer_Private_Void_1;

		// Token: 0x04003CF9 RID: 15609
		private static readonly IntPtr NativeMethodInfoPtr_PlayerAcceptedContract_Protected_Virtual_New_Void_EDealWindow_0;

		// Token: 0x04003CFA RID: 15610
		private static readonly IntPtr NativeMethodInfoPtr_SendContractAccepted_Private_Void_EDealWindow_Boolean_0;

		// Token: 0x04003CFB RID: 15611
		private static readonly IntPtr NativeMethodInfoPtr_ContractAccepted_Public_Virtual_New_String_EDealWindow_Boolean_0;

		// Token: 0x04003CFC RID: 15612
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveContractAccepted_Private_Void_1;

		// Token: 0x04003CFD RID: 15613
		private static readonly IntPtr NativeMethodInfoPtr_PlayContractAcceptedReaction_Protected_Virtual_New_Void_1;

		// Token: 0x04003CFE RID: 15614
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateCounteroffer_Protected_Virtual_New_Boolean_ProductDefinition_Int32_Single_0;

		// Token: 0x04003CFF RID: 15615
		private static readonly IntPtr NativeMethodInfoPtr_GetValueProposition_Public_Static_Single_ProductDefinition_Single_0;

		// Token: 0x04003D00 RID: 15616
		private static readonly IntPtr NativeMethodInfoPtr_ContractRejected_Protected_Virtual_New_Void_1;

		// Token: 0x04003D01 RID: 15617
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveContractRejected_Private_Void_1;

		// Token: 0x04003D02 RID: 15618
		private static readonly IntPtr NativeMethodInfoPtr_PlayContractRejectedReaction_Protected_Virtual_New_Void_1;

		// Token: 0x04003D03 RID: 15619
		private static readonly IntPtr NativeMethodInfoPtr_SetIsAwaitingDelivery_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04003D04 RID: 15620
		private static readonly IntPtr NativeMethodInfoPtr_IsAtDealLocation_Public_Boolean_0;

		// Token: 0x04003D05 RID: 15621
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePotentialCustomerPoI_Private_Void_1;

		// Token: 0x04003D06 RID: 15622
		private static readonly IntPtr NativeMethodInfoPtr_SetPotentialCustomerPoIEnabled_Public_Void_Boolean_0;

		// Token: 0x04003D07 RID: 15623
		private static readonly IntPtr NativeMethodInfoPtr_ShouldTryGenerateDeal_Protected_Virtual_New_Boolean_0;

		// Token: 0x04003D08 RID: 15624
		private static readonly IntPtr NativeMethodInfoPtr_OfferDealItems_Public_Virtual_New_Void_List_1_ItemInstance_Boolean_byref_Boolean_0;

		// Token: 0x04003D09 RID: 15625
		private static readonly IntPtr NativeMethodInfoPtr_CustomerRejectedDeal_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04003D0A RID: 15626
		private static readonly IntPtr NativeMethodInfoPtr_ProcessHandover_Public_Virtual_New_Void_EHandoverOutcome_Contract_List_1_ItemInstance_Boolean_Boolean_0;

		// Token: 0x04003D0B RID: 15627
		private static readonly IntPtr NativeMethodInfoPtr_ProcessHandoverServerSide_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0;

		// Token: 0x04003D0C RID: 15628
		private static readonly IntPtr NativeMethodInfoPtr_ProcessHandoverClient_Private_Void_Single_Boolean_String_0;

		// Token: 0x04003D0D RID: 15629
		private static readonly IntPtr NativeMethodInfoPtr_ContractWellReceived_Public_Void_String_0;

		// Token: 0x04003D0E RID: 15630
		private static readonly IntPtr NativeMethodInfoPtr_RecommendDealer_Private_Void_Dealer_0;

		// Token: 0x04003D0F RID: 15631
		private static readonly IntPtr NativeMethodInfoPtr_RecommendSupplier_Private_Void_Supplier_0;

		// Token: 0x04003D10 RID: 15632
		private static readonly IntPtr NativeMethodInfoPtr_RecommendCustomer_Private_Void_Customer_0;

		// Token: 0x04003D11 RID: 15633
		private static readonly IntPtr NativeMethodInfoPtr_CurrentContractEnded_Public_Virtual_New_Void_EQuestState_0;

		// Token: 0x04003D12 RID: 15634
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateDelivery_Public_Virtual_New_Single_Contract_List_1_ItemInstance_byref_Single_byref_EDrugType_byref_Int32_0;

		// Token: 0x04003D13 RID: 15635
		private static readonly IntPtr NativeMethodInfoPtr_ChangeAddiction_Public_Void_Single_0;

		// Token: 0x04003D14 RID: 15636
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeProduct_Private_Void_ItemInstance_0;

		// Token: 0x04003D15 RID: 15637
		private static readonly IntPtr NativeMethodInfoPtr_ShowOfferDealOption_Protected_Virtual_New_Boolean_Boolean_0;

		// Token: 0x04003D16 RID: 15638
		private static readonly IntPtr NativeMethodInfoPtr_OfferDealValid_Protected_Virtual_New_Boolean_byref_String_0;

		// Token: 0x04003D17 RID: 15639
		private static readonly IntPtr NativeMethodInfoPtr_InstantDealOffered_Protected_Virtual_New_Void_1;

		// Token: 0x04003D18 RID: 15640
		private static readonly IntPtr NativeMethodInfoPtr_GetOfferSuccessChance_Public_Single_List_1_ItemInstance_Single_0;

		// Token: 0x04003D19 RID: 15641
		private static readonly IntPtr NativeMethodInfoPtr_ShouldTryApproachPlayer_Protected_Virtual_New_Boolean_0;

		// Token: 0x04003D1A RID: 15642
		private static readonly IntPtr NativeMethodInfoPtr_RequestProduct_Public_Void_0;

		// Token: 0x04003D1B RID: 15643
		private static readonly IntPtr NativeMethodInfoPtr_RequestProduct_Public_Void_Player_0;

		// Token: 0x04003D1C RID: 15644
		private static readonly IntPtr NativeMethodInfoPtr_PlayerRejectedProductRequest_Public_Void_0;

		// Token: 0x04003D1D RID: 15645
		private static readonly IntPtr NativeMethodInfoPtr_RejectProductRequestOffer_Public_Void_0;

		// Token: 0x04003D1E RID: 15646
		private static readonly IntPtr NativeMethodInfoPtr_RejectProductRequestOffer_Local_Private_Void_1;

		// Token: 0x04003D1F RID: 15647
		private static readonly IntPtr NativeMethodInfoPtr_AssignDealer_Public_Void_Dealer_0;

		// Token: 0x04003D20 RID: 15648
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04003D21 RID: 15649
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomerData_Public_CustomerData_0;

		// Token: 0x04003D22 RID: 15650
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0;

		// Token: 0x04003D23 RID: 15651
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveCustomerData_Private_Void_NetworkConnection_CustomerData_0;

		// Token: 0x04003D24 RID: 15652
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_CustomerData_0;

		// Token: 0x04003D25 RID: 15653
		private static readonly IntPtr NativeMethodInfoPtr_IsReadyForHandover_Protected_Virtual_New_Boolean_Boolean_0;

		// Token: 0x04003D26 RID: 15654
		private static readonly IntPtr NativeMethodInfoPtr_IsHandoverChoiceValid_Protected_Virtual_New_Boolean_byref_String_0;

		// Token: 0x04003D27 RID: 15655
		private static readonly IntPtr NativeMethodInfoPtr_HandoverChosen_Public_Void_0;

		// Token: 0x04003D28 RID: 15656
		private static readonly IntPtr NativeMethodInfoPtr_ShowDirectApproachOption_Protected_Virtual_New_Boolean_Boolean_0;

		// Token: 0x04003D29 RID: 15657
		private static readonly IntPtr NativeMethodInfoPtr_IsUnlockable_Public_Virtual_New_Boolean_0;

		// Token: 0x04003D2A RID: 15658
		private static readonly IntPtr NativeMethodInfoPtr_SampleOptionValid_Protected_Virtual_New_Boolean_byref_String_0;

		// Token: 0x04003D2B RID: 15659
		private static readonly IntPtr NativeMethodInfoPtr_KnownAndRecommended_Public_Boolean_0;

		// Token: 0x04003D2C RID: 15660
		private static readonly IntPtr NativeMethodInfoPtr_SampleOffered_Public_Void_0;

		// Token: 0x04003D2D RID: 15661
		private static readonly IntPtr NativeMethodInfoPtr_GetSampleRequestSuccessChance_Protected_Virtual_New_Single_0;

		// Token: 0x04003D2E RID: 15662
		private static readonly IntPtr NativeMethodInfoPtr_SampleAccepted_Protected_Virtual_New_Void_1;

		// Token: 0x04003D2F RID: 15663
		private static readonly IntPtr NativeMethodInfoPtr_GetSampleSuccess_Private_Single_List_1_ItemInstance_Single_0;

		// Token: 0x04003D30 RID: 15664
		private static readonly IntPtr NativeMethodInfoPtr_ProcessSample_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0;

		// Token: 0x04003D31 RID: 15665
		private static readonly IntPtr NativeMethodInfoPtr_ProcessSampleServerSide_Private_Void_List_1_ItemInstance_0;

		// Token: 0x04003D32 RID: 15666
		private static readonly IntPtr NativeMethodInfoPtr_ProcessSampleClient_Private_Void_1;

		// Token: 0x04003D33 RID: 15667
		private static readonly IntPtr NativeMethodInfoPtr_SampleConsumed_Private_Void_1;

		// Token: 0x04003D34 RID: 15668
		private static readonly IntPtr NativeMethodInfoPtr_EndWait_Private_Void_1;

		// Token: 0x04003D35 RID: 15669
		private static readonly IntPtr NativeMethodInfoPtr_DirectApproachRejected_Protected_Virtual_New_Void_1;

		// Token: 0x04003D36 RID: 15670
		private static readonly IntPtr NativeMethodInfoPtr_SampleWasSufficient_Private_Void_1;

		// Token: 0x04003D37 RID: 15671
		private static readonly IntPtr NativeMethodInfoPtr_SampleWasInsufficient_Private_Void_1;

		// Token: 0x04003D38 RID: 15672
		private static readonly IntPtr NativeMethodInfoPtr_GetProductEnjoyment_Public_Single_ProductDefinition_EQuality_0;

		// Token: 0x04003D39 RID: 15673
		private static readonly IntPtr NativeMethodInfoPtr_GetOrderedDrugTypes_Public_List_1_EDrugType_0;

		// Token: 0x04003D3A RID: 15674
		private static readonly IntPtr NativeMethodInfoPtr_AdjustAffinity_Public_Void_EDrugType_Single_0;

		// Token: 0x04003D3B RID: 15675
		private static readonly IntPtr NativeMethodInfoPtr_AutocreateCustomerSettings_Public_Void_0;

		// Token: 0x04003D3C RID: 15676
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003D3D RID: 15677
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__131_0_Private_Void_1;

		// Token: 0x04003D3E RID: 15678
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__133_1_Private_Void_EUnlockType_Boolean_0;

		// Token: 0x04003D3F RID: 15679
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;

		// Token: 0x04003D40 RID: 15680
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_PDM_0;

		// Token: 0x04003D41 RID: 15681
		private static readonly IntPtr NativeMethodInfoPtr__HandoverChosen_b__207_0_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0;

		// Token: 0x04003D42 RID: 15682
		private static readonly IntPtr NativeMethodInfoPtr__GetOrderedDrugTypes_b__225_0_Private_Single_EDrugType_0;

		// Token: 0x04003D43 RID: 15683
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003D44 RID: 15684
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003D45 RID: 15685
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003D46 RID: 15686
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ConfigureDealSignal_338960014_Private_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x04003D47 RID: 15687
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ConfigureDealSignal_338960014_Private_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x04003D48 RID: 15688
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ConfigureDealSignal_338960014_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003D49 RID: 15689
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ConfigureDealSignal_338960014_Private_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x04003D4A RID: 15690
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ConfigureDealSignal_338960014_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003D4B RID: 15691
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetOfferedContract_4277245194_Private_Void_ContractInfo_GameDateTime_0;

		// Token: 0x04003D4C RID: 15692
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetOfferedContract_4277245194_Private_Void_ContractInfo_GameDateTime_0;

		// Token: 0x04003D4D RID: 15693
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetOfferedContract_4277245194_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003D4E RID: 15694
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ExpireOffer_2166136261_Private_Void_1;

		// Token: 0x04003D4F RID: 15695
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ExpireOffer_2166136261_Public_Virtual_New_Void_0;

		// Token: 0x04003D50 RID: 15696
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ExpireOffer_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003D51 RID: 15697
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendSetUpResponseCallbacks_2166136261_Private_Void_1;

		// Token: 0x04003D52 RID: 15698
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendSetUpResponseCallbacks_2166136261_Private_Void_1;

		// Token: 0x04003D53 RID: 15699
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendSetUpResponseCallbacks_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003D54 RID: 15700
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetUpResponseCallbacks_2166136261_Private_Void_1;

		// Token: 0x04003D55 RID: 15701
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetUpResponseCallbacks_2166136261_Private_Void_1;

		// Token: 0x04003D56 RID: 15702
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetUpResponseCallbacks_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003D57 RID: 15703
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ProcessCounterOfferServerSide_900355577_Private_Void_String_Int32_Single_0;

		// Token: 0x04003D58 RID: 15704
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ProcessCounterOfferServerSide_900355577_Private_Void_String_Int32_Single_0;

		// Token: 0x04003D59 RID: 15705
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ProcessCounterOfferServerSide_900355577_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003D5A RID: 15706
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetContractIsCounterOffer_2166136261_Private_Void_1;

		// Token: 0x04003D5B RID: 15707
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetContractIsCounterOffer_2166136261_Private_Void_1;

		// Token: 0x04003D5C RID: 15708
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetContractIsCounterOffer_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003D5D RID: 15709
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendContractAccepted_507093020_Private_Void_EDealWindow_Boolean_0;

		// Token: 0x04003D5E RID: 15710
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendContractAccepted_507093020_Private_Void_EDealWindow_Boolean_0;

		// Token: 0x04003D5F RID: 15711
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendContractAccepted_507093020_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003D60 RID: 15712
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveContractAccepted_2166136261_Private_Void_1;

		// Token: 0x04003D61 RID: 15713
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveContractAccepted_2166136261_Private_Void_1;

		// Token: 0x04003D62 RID: 15714
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveContractAccepted_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003D63 RID: 15715
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveContractRejected_2166136261_Private_Void_1;

		// Token: 0x04003D64 RID: 15716
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveContractRejected_2166136261_Private_Void_1;

		// Token: 0x04003D65 RID: 15717
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveContractRejected_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003D66 RID: 15718
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ProcessHandoverServerSide_3760244802_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0;

		// Token: 0x04003D67 RID: 15719
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ProcessHandoverServerSide_3760244802_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0;

		// Token: 0x04003D68 RID: 15720
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ProcessHandoverServerSide_3760244802_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003D69 RID: 15721
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ProcessHandoverClient_537707335_Private_Void_Single_Boolean_String_0;

		// Token: 0x04003D6A RID: 15722
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ProcessHandoverClient_537707335_Private_Void_Single_Boolean_String_0;

		// Token: 0x04003D6B RID: 15723
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ProcessHandoverClient_537707335_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003D6C RID: 15724
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ChangeAddiction_431000436_Private_Void_Single_0;

		// Token: 0x04003D6D RID: 15725
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ChangeAddiction_431000436_Public_Void_Single_0;

		// Token: 0x04003D6E RID: 15726
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ChangeAddiction_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003D6F RID: 15727
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_RejectProductRequestOffer_2166136261_Private_Void_1;

		// Token: 0x04003D70 RID: 15728
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RejectProductRequestOffer_2166136261_Public_Void_0;

		// Token: 0x04003D71 RID: 15729
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_RejectProductRequestOffer_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003D72 RID: 15730
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_RejectProductRequestOffer_Local_2166136261_Private_Void_1;

		// Token: 0x04003D73 RID: 15731
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RejectProductRequestOffer_Local_2166136261_Private_Void_1;

		// Token: 0x04003D74 RID: 15732
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_RejectProductRequestOffer_Local_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003D75 RID: 15733
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceiveCustomerData_2280244125_Private_Void_NetworkConnection_CustomerData_0;

		// Token: 0x04003D76 RID: 15734
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveCustomerData_2280244125_Private_Void_NetworkConnection_CustomerData_0;

		// Token: 0x04003D77 RID: 15735
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceiveCustomerData_2280244125_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003D78 RID: 15736
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ProcessSampleServerSide_3704012609_Private_Void_List_1_ItemInstance_0;

		// Token: 0x04003D79 RID: 15737
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ProcessSampleServerSide_3704012609_Private_Void_List_1_ItemInstance_0;

		// Token: 0x04003D7A RID: 15738
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ProcessSampleServerSide_3704012609_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003D7B RID: 15739
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ProcessSampleClient_2166136261_Private_Void_1;

		// Token: 0x04003D7C RID: 15740
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ProcessSampleClient_2166136261_Private_Void_1;

		// Token: 0x04003D7D RID: 15741
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ProcessSampleClient_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003D7E RID: 15742
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SampleWasSufficient_2166136261_Private_Void_1;

		// Token: 0x04003D7F RID: 15743
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SampleWasSufficient_2166136261_Private_Void_1;

		// Token: 0x04003D80 RID: 15744
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SampleWasSufficient_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003D81 RID: 15745
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SampleWasInsufficient_2166136261_Private_Void_1;

		// Token: 0x04003D82 RID: 15746
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SampleWasInsufficient_2166136261_Private_Void_1;

		// Token: 0x04003D83 RID: 15747
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SampleWasInsufficient_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003D84 RID: 15748
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_AdjustAffinity_3036964899_Private_Void_EDrugType_Single_0;

		// Token: 0x04003D85 RID: 15749
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AdjustAffinity_3036964899_Public_Void_EDrugType_Single_0;

		// Token: 0x04003D86 RID: 15750
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_AdjustAffinity_3036964899_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003D87 RID: 15751
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__CurrentAddiction_k__BackingField_Public_get_Single_0;

		// Token: 0x04003D88 RID: 15752
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__CurrentAddiction_k__BackingField_Public_set_Void_Single_Boolean_0;

		// Token: 0x04003D89 RID: 15753
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Customer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04003D8A RID: 15754
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__HasBeenRecommended_k__BackingField_Public_get_Boolean_0;

		// Token: 0x04003D8B RID: 15755
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__HasBeenRecommended_k__BackingField_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x04003D8C RID: 15756
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x020009D4 RID: 2516
		[Serializable]
		public class ScheduleGroupPair : Il2CppSystem.Object
		{
			// Token: 0x0600CCE6 RID: 52454 RVA: 0x0031648C File Offset: 0x0031468C
			// Note: this type is marked as 'beforefieldinit'.
			static ScheduleGroupPair()
			{
				Il2CppClassPointerStore<Customer.ScheduleGroupPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "ScheduleGroupPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.ScheduleGroupPair>.NativeClassPtr);
				Customer.ScheduleGroupPair.NativeFieldInfoPtr_NormalScheduleGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.ScheduleGroupPair>.NativeClassPtr, "NormalScheduleGroup");
				Customer.ScheduleGroupPair.NativeFieldInfoPtr_CurfewScheduleGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.ScheduleGroupPair>.NativeClassPtr, "CurfewScheduleGroup");
				Customer.ScheduleGroupPair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.ScheduleGroupPair>.NativeClassPtr, 100674729);
			}

			// Token: 0x0600CCE7 RID: 52455 RVA: 0x003164F4 File Offset: 0x003146F4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ScheduleGroupPair() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.ScheduleGroupPair>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.ScheduleGroupPair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CCE8 RID: 52456 RVA: 0x00063A60 File Offset: 0x00061C60
			public ScheduleGroupPair(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FD1 RID: 16337
			// (get) Token: 0x0600CCE9 RID: 52457 RVA: 0x00316530 File Offset: 0x00314730
			// (set) Token: 0x0600CCEA RID: 52458 RVA: 0x00063A69 File Offset: 0x00061C69
			public unsafe GameObject NormalScheduleGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.ScheduleGroupPair.NativeFieldInfoPtr_NormalScheduleGroup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.ScheduleGroupPair.NativeFieldInfoPtr_NormalScheduleGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FD2 RID: 16338
			// (get) Token: 0x0600CCEB RID: 52459 RVA: 0x00316560 File Offset: 0x00314760
			// (set) Token: 0x0600CCEC RID: 52460 RVA: 0x00063A88 File Offset: 0x00061C88
			public unsafe GameObject CurfewScheduleGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.ScheduleGroupPair.NativeFieldInfoPtr_CurfewScheduleGroup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.ScheduleGroupPair.NativeFieldInfoPtr_CurfewScheduleGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A82 RID: 35458
			private static readonly IntPtr NativeFieldInfoPtr_NormalScheduleGroup;

			// Token: 0x04008A83 RID: 35459
			private static readonly IntPtr NativeFieldInfoPtr_CurfewScheduleGroup;

			// Token: 0x04008A84 RID: 35460
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009D5 RID: 2517
		[Serializable]
		public class CustomerPreference : Il2CppSystem.Object
		{
			// Token: 0x0600CCED RID: 52461 RVA: 0x00316590 File Offset: 0x00314790
			// Note: this type is marked as 'beforefieldinit'.
			static CustomerPreference()
			{
				Il2CppClassPointerStore<Customer.CustomerPreference>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "CustomerPreference");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.CustomerPreference>.NativeClassPtr);
				Customer.CustomerPreference.NativeFieldInfoPtr_DrugType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.CustomerPreference>.NativeClassPtr, "DrugType");
				Customer.CustomerPreference.NativeFieldInfoPtr_Definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.CustomerPreference>.NativeClassPtr, "Definition");
				Customer.CustomerPreference.NativeFieldInfoPtr_MinimumQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.CustomerPreference>.NativeClassPtr, "MinimumQuality");
				Customer.CustomerPreference.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.CustomerPreference>.NativeClassPtr, 100674730);
			}

			// Token: 0x0600CCEE RID: 52462 RVA: 0x0031660C File Offset: 0x0031480C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CustomerPreference() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.CustomerPreference>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.CustomerPreference.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CCEF RID: 52463 RVA: 0x00063AA7 File Offset: 0x00061CA7
			public CustomerPreference(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FD3 RID: 16339
			// (get) Token: 0x0600CCF0 RID: 52464 RVA: 0x00316648 File Offset: 0x00314848
			// (set) Token: 0x0600CCF1 RID: 52465 RVA: 0x00063AB0 File Offset: 0x00061CB0
			public unsafe EDrugType DrugType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.CustomerPreference.NativeFieldInfoPtr_DrugType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.CustomerPreference.NativeFieldInfoPtr_DrugType)) = value;
				}
			}

			// Token: 0x17003FD4 RID: 16340
			// (get) Token: 0x0600CCF2 RID: 52466 RVA: 0x00316670 File Offset: 0x00314870
			// (set) Token: 0x0600CCF3 RID: 52467 RVA: 0x00063ACB File Offset: 0x00061CCB
			public unsafe ProductDefinition Definition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.CustomerPreference.NativeFieldInfoPtr_Definition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.CustomerPreference.NativeFieldInfoPtr_Definition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FD5 RID: 16341
			// (get) Token: 0x0600CCF4 RID: 52468 RVA: 0x003166A0 File Offset: 0x003148A0
			// (set) Token: 0x0600CCF5 RID: 52469 RVA: 0x00063AEA File Offset: 0x00061CEA
			public unsafe EQuality MinimumQuality
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.CustomerPreference.NativeFieldInfoPtr_MinimumQuality);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.CustomerPreference.NativeFieldInfoPtr_MinimumQuality)) = value;
				}
			}

			// Token: 0x04008A85 RID: 35461
			private static readonly IntPtr NativeFieldInfoPtr_DrugType;

			// Token: 0x04008A86 RID: 35462
			private static readonly IntPtr NativeFieldInfoPtr_Definition;

			// Token: 0x04008A87 RID: 35463
			private static readonly IntPtr NativeFieldInfoPtr_MinimumQuality;

			// Token: 0x04008A88 RID: 35464
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009D6 RID: 2518
		[OriginalName("Assembly-CSharp.dll", "", "ESampleFeedback")]
		public enum ESampleFeedback
		{
			// Token: 0x04008A8A RID: 35466
			WrongProduct,
			// Token: 0x04008A8B RID: 35467
			WrongQuality,
			// Token: 0x04008A8C RID: 35468
			Correct
		}

		// Token: 0x020009D7 RID: 2519
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CCF6 RID: 52470 RVA: 0x003166C8 File Offset: 0x003148C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Customer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c>.NativeClassPtr);
				Customer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c>.NativeClassPtr, "<>9");
				Customer.__c.NativeFieldInfoPtr___9__132_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c>.NativeClassPtr, "<>9__132_0");
				Customer.__c.NativeFieldInfoPtr___9__186_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c>.NativeClassPtr, "<>9__186_1");
				Customer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c>.NativeClassPtr, 100674732);
				Customer.__c.NativeMethodInfoPtr__OnValidate_b__132_0_Internal_Boolean_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c>.NativeClassPtr, 100674733);
				Customer.__c.NativeMethodInfoPtr__EvaluateDelivery_b__186_1_Internal_EQuality_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c>.NativeClassPtr, 100674734);
			}

			// Token: 0x0600CCF7 RID: 52471 RVA: 0x0031676C File Offset: 0x0031496C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CCF8 RID: 52472 RVA: 0x003167A8 File Offset: 0x003149A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186584, XrefRangeEnd = 186590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnValidate_b__132_0(NPCAction x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c.NativeMethodInfoPtr__OnValidate_b__132_0_Internal_Boolean_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CCF9 RID: 52473 RVA: 0x003167F8 File Offset: 0x003149F8
			[CallerCount(0)]
			public unsafe EQuality _EvaluateDelivery_b__186_1(ProductItemInstance x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c.NativeMethodInfoPtr__EvaluateDelivery_b__186_1_Internal_EQuality_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CCFA RID: 52474 RVA: 0x00063B05 File Offset: 0x00061D05
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FD6 RID: 16342
			// (get) Token: 0x0600CCFB RID: 52475 RVA: 0x00316848 File Offset: 0x00314A48
			// (set) Token: 0x0600CCFC RID: 52476 RVA: 0x00063B0E File Offset: 0x00061D0E
			public unsafe static Customer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Customer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Customer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FD7 RID: 16343
			// (get) Token: 0x0600CCFD RID: 52477 RVA: 0x00316870 File Offset: 0x00314A70
			// (set) Token: 0x0600CCFE RID: 52478 RVA: 0x00063B20 File Offset: 0x00061D20
			public unsafe static Predicate<NPCAction> __9__132_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Customer.__c.NativeFieldInfoPtr___9__132_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<NPCAction>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Customer.__c.NativeFieldInfoPtr___9__132_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FD8 RID: 16344
			// (get) Token: 0x0600CCFF RID: 52479 RVA: 0x00316898 File Offset: 0x00314A98
			// (set) Token: 0x0600CD00 RID: 52480 RVA: 0x00063B32 File Offset: 0x00061D32
			public unsafe static Func<ProductItemInstance, EQuality> __9__186_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Customer.__c.NativeFieldInfoPtr___9__186_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ProductItemInstance, EQuality>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Customer.__c.NativeFieldInfoPtr___9__186_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A8D RID: 35469
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008A8E RID: 35470
			private static readonly IntPtr NativeFieldInfoPtr___9__132_0;

			// Token: 0x04008A8F RID: 35471
			private static readonly IntPtr NativeFieldInfoPtr___9__186_1;

			// Token: 0x04008A90 RID: 35472
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A91 RID: 35473
			private static readonly IntPtr NativeMethodInfoPtr__OnValidate_b__132_0_Internal_Boolean_NPCAction_0;

			// Token: 0x04008A92 RID: 35474
			private static readonly IntPtr NativeMethodInfoPtr__EvaluateDelivery_b__186_1_Internal_EQuality_ProductItemInstance_0;
		}

		// Token: 0x020009D8 RID: 2520
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass146_0")]
		public sealed class __c__DisplayClass146_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CD01 RID: 52481 RVA: 0x003168C0 File Offset: 0x00314AC0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass146_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass146_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass146_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass146_0>.NativeClassPtr);
				Customer.__c__DisplayClass146_0.NativeFieldInfoPtr_productAppeal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass146_0>.NativeClassPtr, "productAppeal");
				Customer.__c__DisplayClass146_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass146_0>.NativeClassPtr, 100674735);
				Customer.__c__DisplayClass146_0.NativeMethodInfoPtr__GetWeightedRandomProduct_b__0_Internal_Single_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass146_0>.NativeClassPtr, 100674736);
			}

			// Token: 0x0600CD02 RID: 52482 RVA: 0x00316928 File Offset: 0x00314B28
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass146_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass146_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass146_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD03 RID: 52483 RVA: 0x00316964 File Offset: 0x00314B64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186590, XrefRangeEnd = 186594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetWeightedRandomProduct_b__0(ProductDefinition x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass146_0.NativeMethodInfoPtr__GetWeightedRandomProduct_b__0_Internal_Single_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD04 RID: 52484 RVA: 0x00063B44 File Offset: 0x00061D44
			public __c__DisplayClass146_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FD9 RID: 16345
			// (get) Token: 0x0600CD05 RID: 52485 RVA: 0x003169B4 File Offset: 0x00314BB4
			// (set) Token: 0x0600CD06 RID: 52486 RVA: 0x00063B4D File Offset: 0x00061D4D
			public unsafe Dictionary<ProductDefinition, float> productAppeal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass146_0.NativeFieldInfoPtr_productAppeal);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ProductDefinition, float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass146_0.NativeFieldInfoPtr_productAppeal), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A93 RID: 35475
			private static readonly IntPtr NativeFieldInfoPtr_productAppeal;

			// Token: 0x04008A94 RID: 35476
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A95 RID: 35477
			private static readonly IntPtr NativeMethodInfoPtr__GetWeightedRandomProduct_b__0_Internal_Single_ProductDefinition_0;
		}

		// Token: 0x020009D9 RID: 2521
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass182_0")]
		public sealed class __c__DisplayClass182_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CD07 RID: 52487 RVA: 0x003169E4 File Offset: 0x00314BE4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass182_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass182_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass182_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass182_0>.NativeClassPtr);
				Customer.__c__DisplayClass182_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass182_0>.NativeClassPtr, "<>4__this");
				Customer.__c__DisplayClass182_0.NativeFieldInfoPtr_alreadyRecommended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass182_0>.NativeClassPtr, "alreadyRecommended");
				Customer.__c__DisplayClass182_0.NativeFieldInfoPtr_dealer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass182_0>.NativeClassPtr, "dealer");
				Customer.__c__DisplayClass182_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass182_0>.NativeClassPtr, 100674737);
				Customer.__c__DisplayClass182_0.NativeMethodInfoPtr__RecommendDealer_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass182_0>.NativeClassPtr, 100674738);
			}

			// Token: 0x0600CD08 RID: 52488 RVA: 0x00316A74 File Offset: 0x00314C74
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass182_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass182_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass182_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD09 RID: 52489 RVA: 0x00316AB0 File Offset: 0x00314CB0
			[CallerCount(0)]
			public unsafe bool _RecommendDealer_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass182_0.NativeMethodInfoPtr__RecommendDealer_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD0A RID: 52490 RVA: 0x00063B6C File Offset: 0x00061D6C
			public __c__DisplayClass182_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FDA RID: 16346
			// (get) Token: 0x0600CD0B RID: 52491 RVA: 0x00316AEC File Offset: 0x00314CEC
			// (set) Token: 0x0600CD0C RID: 52492 RVA: 0x00063B75 File Offset: 0x00061D75
			public unsafe Customer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FDB RID: 16347
			// (get) Token: 0x0600CD0D RID: 52493 RVA: 0x00316B1C File Offset: 0x00314D1C
			// (set) Token: 0x0600CD0E RID: 52494 RVA: 0x00063B94 File Offset: 0x00061D94
			public unsafe bool alreadyRecommended
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_0.NativeFieldInfoPtr_alreadyRecommended);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_0.NativeFieldInfoPtr_alreadyRecommended)) = value;
				}
			}

			// Token: 0x17003FDC RID: 16348
			// (get) Token: 0x0600CD0F RID: 52495 RVA: 0x00316B44 File Offset: 0x00314D44
			// (set) Token: 0x0600CD10 RID: 52496 RVA: 0x00063BAF File Offset: 0x00061DAF
			public unsafe Dealer dealer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_0.NativeFieldInfoPtr_dealer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_0.NativeFieldInfoPtr_dealer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A96 RID: 35478
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008A97 RID: 35479
			private static readonly IntPtr NativeFieldInfoPtr_alreadyRecommended;

			// Token: 0x04008A98 RID: 35480
			private static readonly IntPtr NativeFieldInfoPtr_dealer;

			// Token: 0x04008A99 RID: 35481
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A9A RID: 35482
			private static readonly IntPtr NativeMethodInfoPtr__RecommendDealer_b__1_Internal_Boolean_0;
		}

		// Token: 0x020009DA RID: 2522
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass182_1")]
		public sealed class __c__DisplayClass182_1 : Il2CppSystem.Object
		{
			// Token: 0x0600CD11 RID: 52497 RVA: 0x00316B74 File Offset: 0x00314D74
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass182_1()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass182_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass182_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1>.NativeClassPtr);
				Customer.__c__DisplayClass182_1.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1>.NativeClassPtr, "container");
				Customer.__c__DisplayClass182_1.NativeFieldInfoPtr_field_Public___c__DisplayClass182_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1>.NativeClassPtr, "CS$<>8__locals1");
				Customer.__c__DisplayClass182_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1>.NativeClassPtr, 100674739);
				Customer.__c__DisplayClass182_1.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1>.NativeClassPtr, 100674740);
			}

			// Token: 0x0600CD12 RID: 52498 RVA: 0x00316BF0 File Offset: 0x00314DF0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass182_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass182_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD13 RID: 52499 RVA: 0x00316C2C File Offset: 0x00314E2C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 186618, RefRangeEnd = 186619, XrefRangeStart = 186613, XrefRangeEnd = 186618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass182_1.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CD14 RID: 52500 RVA: 0x00063BCE File Offset: 0x00061DCE
			public __c__DisplayClass182_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FDD RID: 16349
			// (get) Token: 0x0600CD15 RID: 52501 RVA: 0x00316C6C File Offset: 0x00314E6C
			// (set) Token: 0x0600CD16 RID: 52502 RVA: 0x00063BD7 File Offset: 0x00061DD7
			public unsafe DialogueContainer container
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_1.NativeFieldInfoPtr_container);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_1.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FDE RID: 16350
			// (get) Token: 0x0600CD17 RID: 52503 RVA: 0x00316C9C File Offset: 0x00314E9C
			// (set) Token: 0x0600CD18 RID: 52504 RVA: 0x00063BF6 File Offset: 0x00061DF6
			public unsafe Customer.__c__DisplayClass182_0 field_Public___c__DisplayClass182_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_1.NativeFieldInfoPtr_field_Public___c__DisplayClass182_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer.__c__DisplayClass182_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_1.NativeFieldInfoPtr_field_Public___c__DisplayClass182_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A9B RID: 35483
			private static readonly IntPtr NativeFieldInfoPtr_container;

			// Token: 0x04008A9C RID: 35484
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass182_0_0;

			// Token: 0x04008A9D RID: 35485
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A9E RID: 35486
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000C4F RID: 3151
			[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass182_1+<<RecommendDealer>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E313 RID: 58131 RVA: 0x00354F30 File Offset: 0x00353130
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1>.NativeClassPtr, "<<RecommendDealer>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674741);
					Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674742);
					Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674743);
					Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674744);
					Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674745);
					Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674746);
				}

				// Token: 0x0600E314 RID: 58132 RVA: 0x00355010 File Offset: 0x00353210
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E315 RID: 58133 RVA: 0x00355058 File Offset: 0x00353258
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E316 RID: 58134 RVA: 0x0035508C File Offset: 0x0035328C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186594, XrefRangeEnd = 186608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004676 RID: 18038
				// (get) Token: 0x0600E317 RID: 58135 RVA: 0x003550C8 File Offset: 0x003532C8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E318 RID: 58136 RVA: 0x00355108 File Offset: 0x00353308
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186608, XrefRangeEnd = 186613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004677 RID: 18039
				// (get) Token: 0x0600E319 RID: 58137 RVA: 0x0035513C File Offset: 0x0035333C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E31A RID: 58138 RVA: 0x0006EB2F File Offset: 0x0006CD2F
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004673 RID: 18035
				// (get) Token: 0x0600E31B RID: 58139 RVA: 0x0035517C File Offset: 0x0035337C
				// (set) Token: 0x0600E31C RID: 58140 RVA: 0x0006EB38 File Offset: 0x0006CD38
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004674 RID: 18036
				// (get) Token: 0x0600E31D RID: 58141 RVA: 0x003551A4 File Offset: 0x003533A4
				// (set) Token: 0x0600E31E RID: 58142 RVA: 0x0006EB53 File Offset: 0x0006CD53
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004675 RID: 18037
				// (get) Token: 0x0600E31F RID: 58143 RVA: 0x003551D4 File Offset: 0x003533D4
				// (set) Token: 0x0600E320 RID: 58144 RVA: 0x0006EB72 File Offset: 0x0006CD72
				public unsafe Customer.__c__DisplayClass182_1 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer.__c__DisplayClass182_1>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040097F9 RID: 38905
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040097FA RID: 38906
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040097FB RID: 38907
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040097FC RID: 38908
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040097FD RID: 38909
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040097FE RID: 38910
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040097FF RID: 38911
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009800 RID: 38912
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009801 RID: 38913
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020009DB RID: 2523
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass183_0")]
		public sealed class __c__DisplayClass183_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CD19 RID: 52505 RVA: 0x00316CCC File Offset: 0x00314ECC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass183_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass183_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass183_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0>.NativeClassPtr);
				Customer.__c__DisplayClass183_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0>.NativeClassPtr, "<>4__this");
				Customer.__c__DisplayClass183_0.NativeFieldInfoPtr_alreadyRecommended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0>.NativeClassPtr, "alreadyRecommended");
				Customer.__c__DisplayClass183_0.NativeFieldInfoPtr_supplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0>.NativeClassPtr, "supplier");
				Customer.__c__DisplayClass183_0.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0>.NativeClassPtr, "container");
				Customer.__c__DisplayClass183_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0>.NativeClassPtr, 100674747);
				Customer.__c__DisplayClass183_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0>.NativeClassPtr, 100674748);
			}

			// Token: 0x0600CD1A RID: 52506 RVA: 0x00316D70 File Offset: 0x00314F70
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass183_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass183_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD1B RID: 52507 RVA: 0x00316DAC File Offset: 0x00314FAC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 186635, RefRangeEnd = 186636, XrefRangeStart = 186630, XrefRangeEnd = 186635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass183_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CD1C RID: 52508 RVA: 0x00063C15 File Offset: 0x00061E15
			public __c__DisplayClass183_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FDF RID: 16351
			// (get) Token: 0x0600CD1D RID: 52509 RVA: 0x00316DEC File Offset: 0x00314FEC
			// (set) Token: 0x0600CD1E RID: 52510 RVA: 0x00063C1E File Offset: 0x00061E1E
			public unsafe Customer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FE0 RID: 16352
			// (get) Token: 0x0600CD1F RID: 52511 RVA: 0x00316E1C File Offset: 0x0031501C
			// (set) Token: 0x0600CD20 RID: 52512 RVA: 0x00063C3D File Offset: 0x00061E3D
			public unsafe bool alreadyRecommended
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.NativeFieldInfoPtr_alreadyRecommended);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.NativeFieldInfoPtr_alreadyRecommended)) = value;
				}
			}

			// Token: 0x17003FE1 RID: 16353
			// (get) Token: 0x0600CD21 RID: 52513 RVA: 0x00316E44 File Offset: 0x00315044
			// (set) Token: 0x0600CD22 RID: 52514 RVA: 0x00063C58 File Offset: 0x00061E58
			public unsafe Supplier supplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.NativeFieldInfoPtr_supplier);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.NativeFieldInfoPtr_supplier), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FE2 RID: 16354
			// (get) Token: 0x0600CD23 RID: 52515 RVA: 0x00316E74 File Offset: 0x00315074
			// (set) Token: 0x0600CD24 RID: 52516 RVA: 0x00063C77 File Offset: 0x00061E77
			public unsafe DialogueContainer container
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.NativeFieldInfoPtr_container);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A9F RID: 35487
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008AA0 RID: 35488
			private static readonly IntPtr NativeFieldInfoPtr_alreadyRecommended;

			// Token: 0x04008AA1 RID: 35489
			private static readonly IntPtr NativeFieldInfoPtr_supplier;

			// Token: 0x04008AA2 RID: 35490
			private static readonly IntPtr NativeFieldInfoPtr_container;

			// Token: 0x04008AA3 RID: 35491
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008AA4 RID: 35492
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000C50 RID: 3152
			[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass183_0+<<RecommendSupplier>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E321 RID: 58145 RVA: 0x00355204 File Offset: 0x00353404
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0>.NativeClassPtr, "<<RecommendSupplier>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674749);
					Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674750);
					Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674751);
					Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674752);
					Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674753);
					Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674754);
				}

				// Token: 0x0600E322 RID: 58146 RVA: 0x003552E4 File Offset: 0x003534E4
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E323 RID: 58147 RVA: 0x0035532C File Offset: 0x0035352C
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E324 RID: 58148 RVA: 0x00355360 File Offset: 0x00353560
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186619, XrefRangeEnd = 186625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700467B RID: 18043
				// (get) Token: 0x0600E325 RID: 58149 RVA: 0x0035539C File Offset: 0x0035359C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E326 RID: 58150 RVA: 0x003553DC File Offset: 0x003535DC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186625, XrefRangeEnd = 186630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700467C RID: 18044
				// (get) Token: 0x0600E327 RID: 58151 RVA: 0x00355410 File Offset: 0x00353610
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E328 RID: 58152 RVA: 0x0006EB91 File Offset: 0x0006CD91
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004678 RID: 18040
				// (get) Token: 0x0600E329 RID: 58153 RVA: 0x00355450 File Offset: 0x00353650
				// (set) Token: 0x0600E32A RID: 58154 RVA: 0x0006EB9A File Offset: 0x0006CD9A
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004679 RID: 18041
				// (get) Token: 0x0600E32B RID: 58155 RVA: 0x00355478 File Offset: 0x00353678
				// (set) Token: 0x0600E32C RID: 58156 RVA: 0x0006EBB5 File Offset: 0x0006CDB5
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700467A RID: 18042
				// (get) Token: 0x0600E32D RID: 58157 RVA: 0x003554A8 File Offset: 0x003536A8
				// (set) Token: 0x0600E32E RID: 58158 RVA: 0x0006EBD4 File Offset: 0x0006CDD4
				public unsafe Customer.__c__DisplayClass183_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer.__c__DisplayClass183_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009802 RID: 38914
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009803 RID: 38915
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009804 RID: 38916
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009805 RID: 38917
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009806 RID: 38918
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009807 RID: 38919
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009808 RID: 38920
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009809 RID: 38921
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400980A RID: 38922
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020009DC RID: 2524
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass184_0")]
		public sealed class __c__DisplayClass184_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CD25 RID: 52517 RVA: 0x00316EA4 File Offset: 0x003150A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass184_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass184_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass184_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0>.NativeClassPtr);
				Customer.__c__DisplayClass184_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0>.NativeClassPtr, "<>4__this");
				Customer.__c__DisplayClass184_0.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0>.NativeClassPtr, "container");
				Customer.__c__DisplayClass184_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0>.NativeClassPtr, 100674755);
				Customer.__c__DisplayClass184_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0>.NativeClassPtr, 100674756);
			}

			// Token: 0x0600CD26 RID: 52518 RVA: 0x00316F20 File Offset: 0x00315120
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass184_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass184_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD27 RID: 52519 RVA: 0x00316F5C File Offset: 0x0031515C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 186651, RefRangeEnd = 186652, XrefRangeStart = 186646, XrefRangeEnd = 186651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass184_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CD28 RID: 52520 RVA: 0x00063C96 File Offset: 0x00061E96
			public __c__DisplayClass184_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FE3 RID: 16355
			// (get) Token: 0x0600CD29 RID: 52521 RVA: 0x00316F9C File Offset: 0x0031519C
			// (set) Token: 0x0600CD2A RID: 52522 RVA: 0x00063C9F File Offset: 0x00061E9F
			public unsafe Customer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass184_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass184_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FE4 RID: 16356
			// (get) Token: 0x0600CD2B RID: 52523 RVA: 0x00316FCC File Offset: 0x003151CC
			// (set) Token: 0x0600CD2C RID: 52524 RVA: 0x00063CBE File Offset: 0x00061EBE
			public unsafe DialogueContainer container
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass184_0.NativeFieldInfoPtr_container);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass184_0.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008AA5 RID: 35493
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008AA6 RID: 35494
			private static readonly IntPtr NativeFieldInfoPtr_container;

			// Token: 0x04008AA7 RID: 35495
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008AA8 RID: 35496
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000C51 RID: 3153
			[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass184_0+<<RecommendCustomer>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E32F RID: 58159 RVA: 0x003554D8 File Offset: 0x003536D8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0>.NativeClassPtr, "<<RecommendCustomer>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674757);
					Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674758);
					Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674759);
					Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674760);
					Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674761);
					Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674762);
				}

				// Token: 0x0600E330 RID: 58160 RVA: 0x003555B8 File Offset: 0x003537B8
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E331 RID: 58161 RVA: 0x00355600 File Offset: 0x00353800
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E332 RID: 58162 RVA: 0x00355634 File Offset: 0x00353834
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186636, XrefRangeEnd = 186641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004680 RID: 18048
				// (get) Token: 0x0600E333 RID: 58163 RVA: 0x00355670 File Offset: 0x00353870
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E334 RID: 58164 RVA: 0x003556B0 File Offset: 0x003538B0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186641, XrefRangeEnd = 186646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004681 RID: 18049
				// (get) Token: 0x0600E335 RID: 58165 RVA: 0x003556E4 File Offset: 0x003538E4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E336 RID: 58166 RVA: 0x0006EBF3 File Offset: 0x0006CDF3
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700467D RID: 18045
				// (get) Token: 0x0600E337 RID: 58167 RVA: 0x00355724 File Offset: 0x00353924
				// (set) Token: 0x0600E338 RID: 58168 RVA: 0x0006EBFC File Offset: 0x0006CDFC
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700467E RID: 18046
				// (get) Token: 0x0600E339 RID: 58169 RVA: 0x0035574C File Offset: 0x0035394C
				// (set) Token: 0x0600E33A RID: 58170 RVA: 0x0006EC17 File Offset: 0x0006CE17
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700467F RID: 18047
				// (get) Token: 0x0600E33B RID: 58171 RVA: 0x0035577C File Offset: 0x0035397C
				// (set) Token: 0x0600E33C RID: 58172 RVA: 0x0006EC36 File Offset: 0x0006CE36
				public unsafe Customer.__c__DisplayClass184_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer.__c__DisplayClass184_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400980B RID: 38923
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400980C RID: 38924
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400980D RID: 38925
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400980E RID: 38926
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400980F RID: 38927
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009810 RID: 38928
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009811 RID: 38929
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009812 RID: 38930
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009813 RID: 38931
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020009DD RID: 2525
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass186_0")]
		public sealed class __c__DisplayClass186_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CD2D RID: 52525 RVA: 0x00316FFC File Offset: 0x003151FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass186_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass186_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass186_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass186_0>.NativeClassPtr);
				Customer.__c__DisplayClass186_0.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass186_0>.NativeClassPtr, "entry");
				Customer.__c__DisplayClass186_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass186_0>.NativeClassPtr, 100674763);
				Customer.__c__DisplayClass186_0.NativeMethodInfoPtr__EvaluateDelivery_b__0_Internal_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass186_0>.NativeClassPtr, 100674764);
			}

			// Token: 0x0600CD2E RID: 52526 RVA: 0x00317064 File Offset: 0x00315264
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass186_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass186_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass186_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD2F RID: 52527 RVA: 0x003170A0 File Offset: 0x003152A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _EvaluateDelivery_b__0(ItemInstance x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass186_0.NativeMethodInfoPtr__EvaluateDelivery_b__0_Internal_Boolean_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD30 RID: 52528 RVA: 0x00063CDD File Offset: 0x00061EDD
			public __c__DisplayClass186_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FE5 RID: 16357
			// (get) Token: 0x0600CD31 RID: 52529 RVA: 0x003170F0 File Offset: 0x003152F0
			// (set) Token: 0x0600CD32 RID: 52530 RVA: 0x00063CE6 File Offset: 0x00061EE6
			public unsafe ProductList.Entry entry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass186_0.NativeFieldInfoPtr_entry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductList.Entry>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass186_0.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008AA9 RID: 35497
			private static readonly IntPtr NativeFieldInfoPtr_entry;

			// Token: 0x04008AAA RID: 35498
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008AAB RID: 35499
			private static readonly IntPtr NativeMethodInfoPtr__EvaluateDelivery_b__0_Internal_Boolean_ItemInstance_0;
		}

		// Token: 0x020009DE RID: 2526
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass188_0")]
		public sealed class __c__DisplayClass188_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CD33 RID: 52531 RVA: 0x00317120 File Offset: 0x00315320
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass188_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass188_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass188_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0>.NativeClassPtr);
				Customer.__c__DisplayClass188_0.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0>.NativeClassPtr, "item");
				Customer.__c__DisplayClass188_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0>.NativeClassPtr, "<>4__this");
				Customer.__c__DisplayClass188_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0>.NativeClassPtr, 100674765);
				Customer.__c__DisplayClass188_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0>.NativeClassPtr, 100674766);
			}

			// Token: 0x0600CD34 RID: 52532 RVA: 0x0031719C File Offset: 0x0031539C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass188_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass188_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD35 RID: 52533 RVA: 0x003171D8 File Offset: 0x003153D8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 186670, RefRangeEnd = 186672, XrefRangeStart = 186665, XrefRangeEnd = 186670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass188_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CD36 RID: 52534 RVA: 0x00063D05 File Offset: 0x00061F05
			public __c__DisplayClass188_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FE6 RID: 16358
			// (get) Token: 0x0600CD37 RID: 52535 RVA: 0x00317218 File Offset: 0x00315418
			// (set) Token: 0x0600CD38 RID: 52536 RVA: 0x00063D0E File Offset: 0x00061F0E
			public unsafe ItemInstance item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass188_0.NativeFieldInfoPtr_item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass188_0.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FE7 RID: 16359
			// (get) Token: 0x0600CD39 RID: 52537 RVA: 0x00317248 File Offset: 0x00315448
			// (set) Token: 0x0600CD3A RID: 52538 RVA: 0x00063D2D File Offset: 0x00061F2D
			public unsafe Customer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass188_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass188_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008AAC RID: 35500
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x04008AAD RID: 35501
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008AAE RID: 35502
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008AAF RID: 35503
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000C52 RID: 3154
			[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass188_0+<<ConsumeProduct>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E33D RID: 58173 RVA: 0x003557AC File Offset: 0x003539AC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0>.NativeClassPtr, "<<ConsumeProduct>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674767);
					Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674768);
					Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674769);
					Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674770);
					Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674771);
					Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674772);
				}

				// Token: 0x0600E33E RID: 58174 RVA: 0x0035588C File Offset: 0x00353A8C
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E33F RID: 58175 RVA: 0x003558D4 File Offset: 0x00353AD4
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E340 RID: 58176 RVA: 0x00355908 File Offset: 0x00353B08
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186652, XrefRangeEnd = 186660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004685 RID: 18053
				// (get) Token: 0x0600E341 RID: 58177 RVA: 0x00355944 File Offset: 0x00353B44
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E342 RID: 58178 RVA: 0x00355984 File Offset: 0x00353B84
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186660, XrefRangeEnd = 186665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004686 RID: 18054
				// (get) Token: 0x0600E343 RID: 58179 RVA: 0x003559B8 File Offset: 0x00353BB8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E344 RID: 58180 RVA: 0x0006EC55 File Offset: 0x0006CE55
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004682 RID: 18050
				// (get) Token: 0x0600E345 RID: 58181 RVA: 0x003559F8 File Offset: 0x00353BF8
				// (set) Token: 0x0600E346 RID: 58182 RVA: 0x0006EC5E File Offset: 0x0006CE5E
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004683 RID: 18051
				// (get) Token: 0x0600E347 RID: 58183 RVA: 0x00355A20 File Offset: 0x00353C20
				// (set) Token: 0x0600E348 RID: 58184 RVA: 0x0006EC79 File Offset: 0x0006CE79
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004684 RID: 18052
				// (get) Token: 0x0600E349 RID: 58185 RVA: 0x00355A50 File Offset: 0x00353C50
				// (set) Token: 0x0600E34A RID: 58186 RVA: 0x0006EC98 File Offset: 0x0006CE98
				public unsafe Customer.__c__DisplayClass188_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer.__c__DisplayClass188_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009814 RID: 38932
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009815 RID: 38933
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009816 RID: 38934
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009817 RID: 38935
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009818 RID: 38936
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009819 RID: 38937
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400981A RID: 38938
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400981B RID: 38939
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400981C RID: 38940
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020009DF RID: 2527
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass224_0")]
		public sealed class __c__DisplayClass224_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CD3B RID: 52539 RVA: 0x00317278 File Offset: 0x00315478
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass224_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass224_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass224_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass224_0>.NativeClassPtr);
				Customer.__c__DisplayClass224_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass224_0>.NativeClassPtr, "<>4__this");
				Customer.__c__DisplayClass224_0.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass224_0>.NativeClassPtr, "i");
				Customer.__c__DisplayClass224_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass224_0>.NativeClassPtr, "<>9__0");
				Customer.__c__DisplayClass224_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass224_0>.NativeClassPtr, 100674773);
				Customer.__c__DisplayClass224_0.NativeMethodInfoPtr__GetProductEnjoyment_b__0_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass224_0>.NativeClassPtr, 100674774);
			}

			// Token: 0x0600CD3C RID: 52540 RVA: 0x00317308 File Offset: 0x00315508
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass224_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass224_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass224_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD3D RID: 52541 RVA: 0x00317344 File Offset: 0x00315544
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186672, XrefRangeEnd = 186680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetProductEnjoyment_b__0(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass224_0.NativeMethodInfoPtr__GetProductEnjoyment_b__0_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD3E RID: 52542 RVA: 0x00063D4C File Offset: 0x00061F4C
			public __c__DisplayClass224_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FE8 RID: 16360
			// (get) Token: 0x0600CD3F RID: 52543 RVA: 0x00317394 File Offset: 0x00315594
			// (set) Token: 0x0600CD40 RID: 52544 RVA: 0x00063D55 File Offset: 0x00061F55
			public unsafe Customer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass224_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass224_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FE9 RID: 16361
			// (get) Token: 0x0600CD41 RID: 52545 RVA: 0x003173C4 File Offset: 0x003155C4
			// (set) Token: 0x0600CD42 RID: 52546 RVA: 0x00063D74 File Offset: 0x00061F74
			public unsafe int i
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass224_0.NativeFieldInfoPtr_i);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass224_0.NativeFieldInfoPtr_i)) = value;
				}
			}

			// Token: 0x17003FEA RID: 16362
			// (get) Token: 0x0600CD43 RID: 52547 RVA: 0x003173EC File Offset: 0x003155EC
			// (set) Token: 0x0600CD44 RID: 52548 RVA: 0x00063D8F File Offset: 0x00061F8F
			public unsafe Predicate<Property> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass224_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Property>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass224_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008AB0 RID: 35504
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008AB1 RID: 35505
			private static readonly IntPtr NativeFieldInfoPtr_i;

			// Token: 0x04008AB2 RID: 35506
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04008AB3 RID: 35507
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008AB4 RID: 35508
			private static readonly IntPtr NativeMethodInfoPtr__GetProductEnjoyment_b__0_Internal_Boolean_Property_0;
		}

		// Token: 0x020009E0 RID: 2528
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass225_0")]
		public sealed class __c__DisplayClass225_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CD45 RID: 52549 RVA: 0x0031741C File Offset: 0x0031561C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass225_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass225_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass225_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass225_0>.NativeClassPtr);
				Customer.__c__DisplayClass225_0.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass225_0>.NativeClassPtr, "x");
				Customer.__c__DisplayClass225_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass225_0>.NativeClassPtr, 100674775);
				Customer.__c__DisplayClass225_0.NativeMethodInfoPtr__GetOrderedDrugTypes_b__1_Internal_Boolean_ProductTypeAffinity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass225_0>.NativeClassPtr, 100674776);
			}

			// Token: 0x0600CD46 RID: 52550 RVA: 0x00317484 File Offset: 0x00315684
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass225_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass225_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass225_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD47 RID: 52551 RVA: 0x003174C0 File Offset: 0x003156C0
			[CallerCount(0)]
			public unsafe bool _GetOrderedDrugTypes_b__1(ProductTypeAffinity y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass225_0.NativeMethodInfoPtr__GetOrderedDrugTypes_b__1_Internal_Boolean_ProductTypeAffinity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD48 RID: 52552 RVA: 0x00063DAE File Offset: 0x00061FAE
			public __c__DisplayClass225_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FEB RID: 16363
			// (get) Token: 0x0600CD49 RID: 52553 RVA: 0x00317510 File Offset: 0x00315710
			// (set) Token: 0x0600CD4A RID: 52554 RVA: 0x00063DB7 File Offset: 0x00061FB7
			public unsafe EDrugType x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass225_0.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass225_0.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x04008AB5 RID: 35509
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04008AB6 RID: 35510
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008AB7 RID: 35511
			private static readonly IntPtr NativeMethodInfoPtr__GetOrderedDrugTypes_b__1_Internal_Boolean_ProductTypeAffinity_0;
		}

		// Token: 0x020009E1 RID: 2529
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass226_0")]
		public sealed class __c__DisplayClass226_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CD4B RID: 52555 RVA: 0x00317538 File Offset: 0x00315738
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass226_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass226_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass226_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass226_0>.NativeClassPtr);
				Customer.__c__DisplayClass226_0.NativeFieldInfoPtr_drugType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass226_0>.NativeClassPtr, "drugType");
				Customer.__c__DisplayClass226_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass226_0>.NativeClassPtr, 100674777);
				Customer.__c__DisplayClass226_0.NativeMethodInfoPtr__AdjustAffinity_b__0_Internal_Boolean_ProductTypeAffinity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass226_0>.NativeClassPtr, 100674778);
			}

			// Token: 0x0600CD4C RID: 52556 RVA: 0x003175A0 File Offset: 0x003157A0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass226_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass226_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass226_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD4D RID: 52557 RVA: 0x003175DC File Offset: 0x003157DC
			[CallerCount(0)]
			public unsafe bool _AdjustAffinity_b__0(ProductTypeAffinity x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass226_0.NativeMethodInfoPtr__AdjustAffinity_b__0_Internal_Boolean_ProductTypeAffinity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD4E RID: 52558 RVA: 0x00063DD2 File Offset: 0x00061FD2
			public __c__DisplayClass226_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FEC RID: 16364
			// (get) Token: 0x0600CD4F RID: 52559 RVA: 0x0031762C File Offset: 0x0031582C
			// (set) Token: 0x0600CD50 RID: 52560 RVA: 0x00063DDB File Offset: 0x00061FDB
			public unsafe EDrugType drugType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass226_0.NativeFieldInfoPtr_drugType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass226_0.NativeFieldInfoPtr_drugType)) = value;
				}
			}

			// Token: 0x04008AB8 RID: 35512
			private static readonly IntPtr NativeFieldInfoPtr_drugType;

			// Token: 0x04008AB9 RID: 35513
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008ABA RID: 35514
			private static readonly IntPtr NativeMethodInfoPtr__AdjustAffinity_b__0_Internal_Boolean_ProductTypeAffinity_0;
		}
	}
}
