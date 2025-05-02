using System;
using System.Runtime.InteropServices;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppScheduleOne.AvatarFramework.Customization;
using Il2CppScheduleOne.Casino;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.Delivery;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Doors;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Law;
using Il2CppScheduleOne.Levelling;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Messaging;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Persistence;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.Quests;
using Il2CppScheduleOne.Tiles;
using Il2CppScheduleOne.UI.Handover;
using Il2CppScheduleOne.UI.Phone.Messages;
using Il2CppScheduleOne.Vehicles;
using Il2CppScheduleOne.Vehicles.Modification;
using Il2CppScheduleOne.Vision;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppFishNet.Serializing.Generated
{
	// Token: 0x020007A0 RID: 1952
	[StructLayout(3, CharSet = 4)]
	public static class GeneratedWriters___Internal : Object
	{
		// Token: 0x0600B879 RID: 47225 RVA: 0x002DC164 File Offset: 0x002DA364
		// Note: this type is marked as 'beforefieldinit'.
		static GeneratedWriters___Internal()
		{
			Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FishNet.Serializing.Generated", "GeneratedWriters___Internal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr);
			GeneratedWriters___Internal.NativeMethodInfoPtr_InitializeOnce_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685969);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Vision_VisionEventReceiptFishNet_Serializing_Generated_Public_Static_Void_Writer_VisionEventReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685970);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EVisualState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685971);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EEventLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685972);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Quests_ContractInfoFishNet_Serializing_Generated_Public_Static_Void_Writer_ContractInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685973);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Product_ProductListFishNet_Serializing_Generated_Public_Static_Void_Writer_ProductList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685974);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Entry_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685975);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_ItemFramework_EQualityFishNet_Serializing_Generated_Public_Static_Void_Writer_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685976);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_List_1_Entry_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685977);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Quests_QuestWindowConfigFishNet_Serializing_Generated_Public_Static_Void_Writer_QuestWindowConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685978);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_GameTime_GameDateTimeFishNet_Serializing_Generated_Public_Static_Void_Writer_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685979);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EQuestAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685980);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Quests_EQuestStateFishNet_Serializing_Generated_Public_Static_Void_Writer_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685981);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Combat_ImpactFishNet_Serializing_Generated_Public_Static_Void_Writer_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685982);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Combat_EImpactTypeFishNet_Serializing_Generated_Public_Static_Void_Writer_EImpactType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685983);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Vehicles_LandVehicleFishNet_Serializing_Generated_Public_Static_Void_Writer_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685984);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_ECheckpointLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685985);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_PlayerScripts_PlayerFishNet_Serializing_Generated_Public_Static_Void_Writer_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685986);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___System_Collections_Generic_List`1_System_String_FishNet_Serializing_Generated_Public_Static_Void_Writer_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685987);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_DevUtilities_StringIntPairFishNet_Serializing_Generated_Public_Static_Void_Writer_StringIntPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685988);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_StringIntPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685989);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Messaging_MessageFishNet_Serializing_Generated_Public_Static_Void_Writer_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685990);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_ESenderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685991);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_UI_Phone_Messages_MessageChainFishNet_Serializing_Generated_Public_Static_Void_Writer_MessageChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685992);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_MSGConversationDataFishNet_Serializing_Generated_Public_Static_Void_Writer_MSGConversationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685993);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_TextMessageDataFishNet_Serializing_Generated_Public_Static_Void_Writer_TextMessageData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685994);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_TextMessageData_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685995);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_TextResponseDataFishNet_Serializing_Generated_Public_Static_Void_Writer_TextResponseData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685996);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_TextResponseData_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685997);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Messaging_ResponseFishNet_Serializing_Generated_Public_Static_Void_Writer_Response_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685998);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___System_Collections_Generic_List`1_ScheduleOne_Messaging_Response_FishNet_Serializing_Generated_Public_Static_Void_Writer_List_1_Response_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100685999);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___System_Collections_Generic_List`1_FishNet_Object_NetworkObject_FishNet_Serializing_Generated_Public_Static_Void_Writer_List_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686000);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_AdvancedTransitRouteDataFishNet_Serializing_Generated_Public_Static_Void_Writer_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686001);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686002);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686003);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Levelling_ERankFishNet_Serializing_Generated_Public_Static_Void_Writer_ERank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686004);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Levelling_FullRankFishNet_Serializing_Generated_Public_Static_Void_Writer_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686005);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_PlayerDataFishNet_Serializing_Generated_Public_Static_Void_Writer_PlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686006);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_VariableDataFishNet_Serializing_Generated_Public_Static_Void_Writer_VariableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686007);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_VariableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686008);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_AvatarFramework_AvatarSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686009);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EyeLidConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686010);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_LayerSetting_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686011);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_List_1_LayerSetting_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686012);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_AccessorySetting_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686013);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_List_1_AccessorySetting_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686014);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_AvatarFramework_Customization_BasicAvatarSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686015);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EPursuitLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686016);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Property_PropertyFishNet_Serializing_Generated_Public_Static_Void_Writer_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686017);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Employees_EEmployeeTypeFishNet_Serializing_Generated_Public_Static_Void_Writer_EEmployeeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686018);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Economy_EDealWindowFishNet_Serializing_Generated_Public_Static_Void_Writer_EDealWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686019);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EHandoverOutcome_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686020);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___System_Collections_Generic_List`1_ScheduleOne_ItemFramework_ItemInstance_FishNet_Serializing_Generated_Public_Static_Void_Writer_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686021);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_CustomerDataFishNet_Serializing_Generated_Public_Static_Void_Writer_CustomerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686022);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686023);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppStructArray_1_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686024);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Product_EDrugTypeFishNet_Serializing_Generated_Public_Static_Void_Writer_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686025);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_GameDataFishNet_Serializing_Generated_Public_Static_Void_Writer_GameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686026);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_DevUtilities_GameSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_GameSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686027);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Delivery_DeliveryInstanceFishNet_Serializing_Generated_Public_Static_Void_Writer_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686028);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Delivery_EDeliveryStatusFishNet_Serializing_Generated_Public_Static_Void_Writer_EDeliveryStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686029);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Combat_ExplosionDataFishNet_Serializing_Generated_Public_Static_Void_Writer_ExplosionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686030);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_ECardSuit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686031);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686032);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686033);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686034);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686035);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppStructArray_1_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686036);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Doors_EDoorSideFishNet_Serializing_Generated_Public_Static_Void_Writer_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686037);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Vehicles_Modification_EVehicleColorFishNet_Serializing_Generated_Public_Static_Void_Writer_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686038);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Vehicles_ParkDataFishNet_Serializing_Generated_Public_Static_Void_Writer_ParkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686039);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Vehicles_EParkingAlignmentFishNet_Serializing_Generated_Public_Static_Void_Writer_EParkingAlignment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686040);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_TrashContentDataFishNet_Serializing_Generated_Public_Static_Void_Writer_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686041);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppStructArray_1_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686042);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Tiles_CoordinateFishNet_Serializing_Generated_Public_Static_Void_Writer_Coordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686043);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Product_WeedAppearanceSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_WeedAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686044);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Product_CocaineAppearanceSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_CocaineAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686045);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Product_MethAppearanceSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_MethAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686046);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Product_NewMixOperationFishNet_Serializing_Generated_Public_Static_Void_Writer_NewMixOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686047);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686048);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Tiles_CoordinateProceduralTilePairFishNet_Serializing_Generated_Public_Static_Void_Writer_CoordinateProceduralTilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686049);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___System_Collections_Generic_List`1_ScheduleOne_Tiles_CoordinateProceduralTilePair_FishNet_Serializing_Generated_Public_Static_Void_Writer_List_1_CoordinateProceduralTilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686050);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_ObjectScripts_ChemistryCookOperationFishNet_Serializing_Generated_Public_Static_Void_Writer_ChemistryCookOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686051);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_ObjectScripts_DryingOperationFishNet_Serializing_Generated_Public_Static_Void_Writer_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686052);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_ObjectScripts_OvenCookOperationFishNet_Serializing_Generated_Public_Static_Void_Writer_OvenCookOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686053);
			GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_ObjectScripts_MixOperationFishNet_Serializing_Generated_Public_Static_Void_Writer_MixOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedWriters___Internal>.NativeClassPtr, 100686054);
		}

		// Token: 0x0600B87A RID: 47226 RVA: 0x002DC84C File Offset: 0x002DAA4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314129, XrefRangeEnd = 315026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeOnce()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_InitializeOnce_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B87B RID: 47227 RVA: 0x002DC874 File Offset: 0x002DAA74
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 315032, RefRangeEnd = 315036, XrefRangeStart = 315026, XrefRangeEnd = 315032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Vision_VisionEventReceiptFishNet_Serializing_Generated(this Writer writer, VisionEventReceipt value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Vision_VisionEventReceiptFishNet_Serializing_Generated_Public_Static_Void_Writer_VisionEventReceipt_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B87C RID: 47228 RVA: 0x002DC8BC File Offset: 0x002DAABC
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 315039, RefRangeEnd = 315147, XrefRangeStart = 315036, XrefRangeEnd = 315039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_EVisualState_0(this Writer writer, PlayerVisualState.EVisualState value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EVisualState_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B87D RID: 47229 RVA: 0x002DC900 File Offset: 0x002DAB00
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 315039, RefRangeEnd = 315147, XrefRangeStart = 315039, XrefRangeEnd = 315147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_EEventLevel_0(this Writer writer, VisionCone.EEventLevel value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EEventLevel_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B87E RID: 47230 RVA: 0x002DC944 File Offset: 0x002DAB44
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 315177, RefRangeEnd = 315187, XrefRangeStart = 315147, XrefRangeEnd = 315177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Quests_ContractInfoFishNet_Serializing_Generated(this Writer writer, ContractInfo value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Quests_ContractInfoFishNet_Serializing_Generated_Public_Static_Void_Writer_ContractInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B87F RID: 47231 RVA: 0x002DC98C File Offset: 0x002DAB8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 315192, RefRangeEnd = 315195, XrefRangeStart = 315187, XrefRangeEnd = 315192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Product_ProductListFishNet_Serializing_Generated(this Writer writer, ProductList value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Product_ProductListFishNet_Serializing_Generated_Public_Static_Void_Writer_ProductList_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B880 RID: 47232 RVA: 0x002DC9D4 File Offset: 0x002DABD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315195, XrefRangeEnd = 315203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_Entry_PDM_0(this Writer writer, ProductList.Entry value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Entry_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B881 RID: 47233 RVA: 0x002DCA1C File Offset: 0x002DAC1C
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 315039, RefRangeEnd = 315147, XrefRangeStart = 315039, XrefRangeEnd = 315147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_ItemFramework_EQualityFishNet_Serializing_Generated(this Writer writer, EQuality value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_ItemFramework_EQualityFishNet_Serializing_Generated_Public_Static_Void_Writer_EQuality_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B882 RID: 47234 RVA: 0x002DCA60 File Offset: 0x002DAC60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315203, XrefRangeEnd = 315207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_List_1_Entry_PDM_0(this Writer writer, List<ProductList.Entry> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_List_1_Entry_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B883 RID: 47235 RVA: 0x002DCAA8 File Offset: 0x002DACA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315207, XrefRangeEnd = 315215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Quests_QuestWindowConfigFishNet_Serializing_Generated(this Writer writer, QuestWindowConfig value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Quests_QuestWindowConfigFishNet_Serializing_Generated_Public_Static_Void_Writer_QuestWindowConfig_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B884 RID: 47236 RVA: 0x002DCAF0 File Offset: 0x002DACF0
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 315220, RefRangeEnd = 315237, XrefRangeStart = 315215, XrefRangeEnd = 315220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_GameTime_GameDateTimeFishNet_Serializing_Generated(this Writer writer, GameDateTime value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_GameTime_GameDateTimeFishNet_Serializing_Generated_Public_Static_Void_Writer_GameDateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B885 RID: 47237 RVA: 0x002DCB34 File Offset: 0x002DAD34
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 315039, RefRangeEnd = 315147, XrefRangeStart = 315039, XrefRangeEnd = 315147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_EQuestAction_0(this Writer writer, QuestManager.EQuestAction value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EQuestAction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B886 RID: 47238 RVA: 0x002DCB78 File Offset: 0x002DAD78
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 315039, RefRangeEnd = 315147, XrefRangeStart = 315039, XrefRangeEnd = 315147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Quests_EQuestStateFishNet_Serializing_Generated(this Writer writer, EQuestState value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Quests_EQuestStateFishNet_Serializing_Generated_Public_Static_Void_Writer_EQuestState_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B887 RID: 47239 RVA: 0x002DCBBC File Offset: 0x002DADBC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 315253, RefRangeEnd = 315261, XrefRangeStart = 315237, XrefRangeEnd = 315253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Combat_ImpactFishNet_Serializing_Generated(this Writer writer, Impact value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Combat_ImpactFishNet_Serializing_Generated_Public_Static_Void_Writer_Impact_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B888 RID: 47240 RVA: 0x002DCC04 File Offset: 0x002DAE04
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 315039, RefRangeEnd = 315147, XrefRangeStart = 315039, XrefRangeEnd = 315147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Combat_EImpactTypeFishNet_Serializing_Generated(this Writer writer, EImpactType value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Combat_EImpactTypeFishNet_Serializing_Generated_Public_Static_Void_Writer_EImpactType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B889 RID: 47241 RVA: 0x002DCC48 File Offset: 0x002DAE48
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 315263, RefRangeEnd = 315270, XrefRangeStart = 315261, XrefRangeEnd = 315263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Vehicles_LandVehicleFishNet_Serializing_Generated(this Writer writer, LandVehicle value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Vehicles_LandVehicleFishNet_Serializing_Generated_Public_Static_Void_Writer_LandVehicle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B88A RID: 47242 RVA: 0x002DCC90 File Offset: 0x002DAE90
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 315039, RefRangeEnd = 315147, XrefRangeStart = 315039, XrefRangeEnd = 315147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_ECheckpointLocation_0(this Writer writer, CheckpointManager.ECheckpointLocation value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_ECheckpointLocation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B88B RID: 47243 RVA: 0x002DCCD4 File Offset: 0x002DAED4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 315263, RefRangeEnd = 315270, XrefRangeStart = 315263, XrefRangeEnd = 315270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_PlayerScripts_PlayerFishNet_Serializing_Generated(this Writer writer, Player value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_PlayerScripts_PlayerFishNet_Serializing_Generated_Public_Static_Void_Writer_Player_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B88C RID: 47244 RVA: 0x002DCD1C File Offset: 0x002DAF1C
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 315274, RefRangeEnd = 315292, XrefRangeStart = 315270, XrefRangeEnd = 315274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___System_Collections_Generic_List(this Writer writer, List<string> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___System_Collections_Generic_List`1_System_String_FishNet_Serializing_Generated_Public_Static_Void_Writer_List_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B88D RID: 47245 RVA: 0x002DCD64 File Offset: 0x002DAF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315292, XrefRangeEnd = 315298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_DevUtilities_StringIntPairFishNet_Serializing_Generated(this Writer writer, StringIntPair value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_DevUtilities_StringIntPairFishNet_Serializing_Generated_Public_Static_Void_Writer_StringIntPair_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B88E RID: 47246 RVA: 0x002DCDAC File Offset: 0x002DAFAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 315302, RefRangeEnd = 315304, XrefRangeStart = 315298, XrefRangeEnd = 315302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_StringIntPair_0(this Writer writer, Il2CppReferenceArray<StringIntPair> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_StringIntPair_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B88F RID: 47247 RVA: 0x002DCDF4 File Offset: 0x002DAFF4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 315313, RefRangeEnd = 315318, XrefRangeStart = 315304, XrefRangeEnd = 315313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Messaging_MessageFishNet_Serializing_Generated(this Writer writer, Message value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Messaging_MessageFishNet_Serializing_Generated_Public_Static_Void_Writer_Message_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B890 RID: 47248 RVA: 0x002DCE3C File Offset: 0x002DB03C
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 315039, RefRangeEnd = 315147, XrefRangeStart = 315039, XrefRangeEnd = 315147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_ESenderType_0(this Writer writer, Message.ESenderType value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_ESenderType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B891 RID: 47249 RVA: 0x002DCE80 File Offset: 0x002DB080
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 315331, RefRangeEnd = 315336, XrefRangeStart = 315318, XrefRangeEnd = 315331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_UI_Phone_Messages_MessageChainFishNet_Serializing_Generated(this Writer writer, MessageChain value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_UI_Phone_Messages_MessageChainFishNet_Serializing_Generated_Public_Static_Void_Writer_MessageChain_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B892 RID: 47250 RVA: 0x002DCEC8 File Offset: 0x002DB0C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 315363, RefRangeEnd = 315365, XrefRangeStart = 315336, XrefRangeEnd = 315363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Persistence_Datas_MSGConversationDataFishNet_Serializing_Generated(this Writer writer, MSGConversationData value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_MSGConversationDataFishNet_Serializing_Generated_Public_Static_Void_Writer_MSGConversationData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B893 RID: 47251 RVA: 0x002DCF10 File Offset: 0x002DB110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315365, XrefRangeEnd = 315374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Persistence_Datas_TextMessageDataFishNet_Serializing_Generated(this Writer writer, TextMessageData value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_TextMessageDataFishNet_Serializing_Generated_Public_Static_Void_Writer_TextMessageData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B894 RID: 47252 RVA: 0x002DCF58 File Offset: 0x002DB158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315374, XrefRangeEnd = 315378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_TextMessageData_PDM_0(this Writer writer, Il2CppReferenceArray<TextMessageData> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_TextMessageData_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B895 RID: 47253 RVA: 0x002DCFA0 File Offset: 0x002DB1A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 315383, RefRangeEnd = 315387, XrefRangeStart = 315378, XrefRangeEnd = 315383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Persistence_Datas_TextResponseDataFishNet_Serializing_Generated(this Writer writer, TextResponseData value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_TextResponseDataFishNet_Serializing_Generated_Public_Static_Void_Writer_TextResponseData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B896 RID: 47254 RVA: 0x002DCFE8 File Offset: 0x002DB1E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315387, XrefRangeEnd = 315391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_TextResponseData_PDM_0(this Writer writer, Il2CppReferenceArray<TextResponseData> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_TextResponseData_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B897 RID: 47255 RVA: 0x002DD030 File Offset: 0x002DB230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315391, XrefRangeEnd = 315397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Messaging_ResponseFishNet_Serializing_Generated(this Writer writer, Response value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Messaging_ResponseFishNet_Serializing_Generated_Public_Static_Void_Writer_Response_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B898 RID: 47256 RVA: 0x002DD078 File Offset: 0x002DB278
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 315401, RefRangeEnd = 315406, XrefRangeStart = 315397, XrefRangeEnd = 315401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___System_Collections_Generic_List(this Writer writer, List<Response> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___System_Collections_Generic_List`1_ScheduleOne_Messaging_Response_FishNet_Serializing_Generated_Public_Static_Void_Writer_List_1_Response_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B899 RID: 47257 RVA: 0x002DD0C0 File Offset: 0x002DB2C0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 315410, RefRangeEnd = 315417, XrefRangeStart = 315406, XrefRangeEnd = 315410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___System_Collections_Generic_List(this Writer writer, List<NetworkObject> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___System_Collections_Generic_List`1_FishNet_Object_NetworkObject_FishNet_Serializing_Generated_Public_Static_Void_Writer_List_1_NetworkObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B89A RID: 47258 RVA: 0x002DD108 File Offset: 0x002DB308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315417, XrefRangeEnd = 315426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Persistence_Datas_AdvancedTransitRouteDataFishNet_Serializing_Generated(this Writer writer, AdvancedTransitRouteData value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_AdvancedTransitRouteDataFishNet_Serializing_Generated_Public_Static_Void_Writer_AdvancedTransitRouteData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B89B RID: 47259 RVA: 0x002DD150 File Offset: 0x002DB350
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 315039, RefRangeEnd = 315147, XrefRangeStart = 315039, XrefRangeEnd = 315147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_EMode_0(this Writer writer, ManagementItemFilter.EMode value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B89C RID: 47260 RVA: 0x002DD194 File Offset: 0x002DB394
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 315430, RefRangeEnd = 315437, XrefRangeStart = 315426, XrefRangeEnd = 315430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_AdvancedTransitRouteData_0(this Writer writer, Il2CppReferenceArray<AdvancedTransitRouteData> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_AdvancedTransitRouteData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B89D RID: 47261 RVA: 0x002DD1DC File Offset: 0x002DB3DC
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 315039, RefRangeEnd = 315147, XrefRangeStart = 315039, XrefRangeEnd = 315147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Levelling_ERankFishNet_Serializing_Generated(this Writer writer, ERank value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Levelling_ERankFishNet_Serializing_Generated_Public_Static_Void_Writer_ERank_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B89E RID: 47262 RVA: 0x002DD220 File Offset: 0x002DB420
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 315220, RefRangeEnd = 315237, XrefRangeStart = 315220, XrefRangeEnd = 315237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Levelling_FullRankFishNet_Serializing_Generated(this Writer writer, FullRank value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Levelling_FullRankFishNet_Serializing_Generated_Public_Static_Void_Writer_FullRank_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B89F RID: 47263 RVA: 0x002DD264 File Offset: 0x002DB464
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 315450, RefRangeEnd = 315454, XrefRangeStart = 315437, XrefRangeEnd = 315450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Persistence_Datas_PlayerDataFishNet_Serializing_Generated(this Writer writer, PlayerData value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_PlayerDataFishNet_Serializing_Generated_Public_Static_Void_Writer_PlayerData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8A0 RID: 47264 RVA: 0x002DD2AC File Offset: 0x002DB4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315454, XrefRangeEnd = 315463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Persistence_Datas_VariableDataFishNet_Serializing_Generated(this Writer writer, VariableData value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_VariableDataFishNet_Serializing_Generated_Public_Static_Void_Writer_VariableData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8A1 RID: 47265 RVA: 0x002DD2F4 File Offset: 0x002DB4F4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 315467, RefRangeEnd = 315471, XrefRangeStart = 315463, XrefRangeEnd = 315467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_VariableData_0(this Writer writer, Il2CppReferenceArray<VariableData> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_VariableData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8A2 RID: 47266 RVA: 0x002DD33C File Offset: 0x002DB53C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 315519, RefRangeEnd = 315524, XrefRangeStart = 315471, XrefRangeEnd = 315519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_AvatarFramework_AvatarSettingsFishNet_Serializing_Generated(this Writer writer, AvatarSettings value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_AvatarFramework_AvatarSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_AvatarSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8A3 RID: 47267 RVA: 0x002DD384 File Offset: 0x002DB584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315524, XrefRangeEnd = 315527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_EyeLidConfiguration_0(this Writer writer, Eye.EyeLidConfiguration value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EyeLidConfiguration_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8A4 RID: 47268 RVA: 0x002DD3C8 File Offset: 0x002DB5C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315527, XrefRangeEnd = 315529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_LayerSetting_PDM_0(this Writer writer, AvatarSettings.LayerSetting value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_LayerSetting_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8A5 RID: 47269 RVA: 0x002DD418 File Offset: 0x002DB618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315529, XrefRangeEnd = 315533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_List_1_LayerSetting_PDM_0(this Writer writer, List<AvatarSettings.LayerSetting> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_List_1_LayerSetting_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8A6 RID: 47270 RVA: 0x002DD460 File Offset: 0x002DB660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315533, XrefRangeEnd = 315536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_AccessorySetting_PDM_0(this Writer writer, AvatarSettings.AccessorySetting value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_AccessorySetting_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8A7 RID: 47271 RVA: 0x002DD4A8 File Offset: 0x002DB6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315536, XrefRangeEnd = 315540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_List_1_AccessorySetting_PDM_0(this Writer writer, List<AvatarSettings.AccessorySetting> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_List_1_AccessorySetting_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8A8 RID: 47272 RVA: 0x002DD4F0 File Offset: 0x002DB6F0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 315573, RefRangeEnd = 315579, XrefRangeStart = 315540, XrefRangeEnd = 315573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_AvatarFramework_Customization_BasicAvatarSettingsFishNet_Serializing_Generated(this Writer writer, BasicAvatarSettings value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_AvatarFramework_Customization_BasicAvatarSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_BasicAvatarSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8A9 RID: 47273 RVA: 0x002DD538 File Offset: 0x002DB738
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 315039, RefRangeEnd = 315147, XrefRangeStart = 315039, XrefRangeEnd = 315147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_EPursuitLevel_0(this Writer writer, PlayerCrimeData.EPursuitLevel value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EPursuitLevel_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8AA RID: 47274 RVA: 0x002DD57C File Offset: 0x002DB77C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 315263, RefRangeEnd = 315270, XrefRangeStart = 315263, XrefRangeEnd = 315270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Property_PropertyFishNet_Serializing_Generated(this Writer writer, Property value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Property_PropertyFishNet_Serializing_Generated_Public_Static_Void_Writer_Property_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8AB RID: 47275 RVA: 0x002DD5C4 File Offset: 0x002DB7C4
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 315039, RefRangeEnd = 315147, XrefRangeStart = 315039, XrefRangeEnd = 315147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Employees_EEmployeeTypeFishNet_Serializing_Generated(this Writer writer, EEmployeeType value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Employees_EEmployeeTypeFishNet_Serializing_Generated_Public_Static_Void_Writer_EEmployeeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8AC RID: 47276 RVA: 0x002DD608 File Offset: 0x002DB808
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 315039, RefRangeEnd = 315147, XrefRangeStart = 315039, XrefRangeEnd = 315147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Economy_EDealWindowFishNet_Serializing_Generated(this Writer writer, EDealWindow value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Economy_EDealWindowFishNet_Serializing_Generated_Public_Static_Void_Writer_EDealWindow_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8AD RID: 47277 RVA: 0x002DD64C File Offset: 0x002DB84C
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 315039, RefRangeEnd = 315147, XrefRangeStart = 315039, XrefRangeEnd = 315147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_EHandoverOutcome_0(this Writer writer, HandoverScreen.EHandoverOutcome value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EHandoverOutcome_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8AE RID: 47278 RVA: 0x002DD690 File Offset: 0x002DB890
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 315583, RefRangeEnd = 315589, XrefRangeStart = 315579, XrefRangeEnd = 315583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___System_Collections_Generic_List(this Writer writer, List<ItemInstance> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___System_Collections_Generic_List`1_ScheduleOne_ItemFramework_ItemInstance_FishNet_Serializing_Generated_Public_Static_Void_Writer_List_1_ItemInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8AF RID: 47279 RVA: 0x002DD6D8 File Offset: 0x002DB8D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 315632, RefRangeEnd = 315635, XrefRangeStart = 315589, XrefRangeEnd = 315632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Persistence_Datas_CustomerDataFishNet_Serializing_Generated(this Writer writer, Il2CppScheduleOne.Persistence.Datas.CustomerData value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_CustomerDataFishNet_Serializing_Generated_Public_Static_Void_Writer_CustomerData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8B0 RID: 47280 RVA: 0x002DD720 File Offset: 0x002DB920
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 315639, RefRangeEnd = 315643, XrefRangeStart = 315635, XrefRangeEnd = 315639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_Il2CppStringArray_0(this Writer writer, Il2CppStringArray value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8B1 RID: 47281 RVA: 0x002DD768 File Offset: 0x002DB968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315643, XrefRangeEnd = 315647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_Il2CppStructArray_1_Single_PDM_0(this Writer writer, Il2CppStructArray<float> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppStructArray_1_Single_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8B2 RID: 47282 RVA: 0x002DD7B0 File Offset: 0x002DB9B0
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 315039, RefRangeEnd = 315147, XrefRangeStart = 315039, XrefRangeEnd = 315147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Product_EDrugTypeFishNet_Serializing_Generated(this Writer writer, EDrugType value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Product_EDrugTypeFishNet_Serializing_Generated_Public_Static_Void_Writer_EDrugType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8B3 RID: 47283 RVA: 0x002DD7F4 File Offset: 0x002DB9F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 315660, RefRangeEnd = 315663, XrefRangeStart = 315647, XrefRangeEnd = 315660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Persistence_Datas_GameDataFishNet_Serializing_Generated(this Writer writer, GameData value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_GameDataFishNet_Serializing_Generated_Public_Static_Void_Writer_GameData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8B4 RID: 47284 RVA: 0x002DD83C File Offset: 0x002DBA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315663, XrefRangeEnd = 315667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_DevUtilities_GameSettingsFishNet_Serializing_Generated(this Writer writer, GameSettings value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_DevUtilities_GameSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_GameSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8B5 RID: 47285 RVA: 0x002DD884 File Offset: 0x002DBA84
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 315687, RefRangeEnd = 315694, XrefRangeStart = 315667, XrefRangeEnd = 315687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Delivery_DeliveryInstanceFishNet_Serializing_Generated(this Writer writer, DeliveryInstance value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Delivery_DeliveryInstanceFishNet_Serializing_Generated_Public_Static_Void_Writer_DeliveryInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8B6 RID: 47286 RVA: 0x002DD8CC File Offset: 0x002DBACC
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 315039, RefRangeEnd = 315147, XrefRangeStart = 315039, XrefRangeEnd = 315147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Delivery_EDeliveryStatusFishNet_Serializing_Generated(this Writer writer, EDeliveryStatus value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Delivery_EDeliveryStatusFishNet_Serializing_Generated_Public_Static_Void_Writer_EDeliveryStatus_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8B7 RID: 47287 RVA: 0x002DD910 File Offset: 0x002DBB10
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 315699, RefRangeEnd = 315703, XrefRangeStart = 315694, XrefRangeEnd = 315699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Combat_ExplosionDataFishNet_Serializing_Generated(this Writer writer, ExplosionData value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Combat_ExplosionDataFishNet_Serializing_Generated_Public_Static_Void_Writer_ExplosionData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8B8 RID: 47288 RVA: 0x002DD954 File Offset: 0x002DBB54
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 315039, RefRangeEnd = 315147, XrefRangeStart = 315039, XrefRangeEnd = 315147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_ECardSuit_0(this Writer writer, PlayingCard.ECardSuit value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_ECardSuit_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8B9 RID: 47289 RVA: 0x002DD998 File Offset: 0x002DBB98
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 315039, RefRangeEnd = 315147, XrefRangeStart = 315039, XrefRangeEnd = 315147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_ECardValue_0(this Writer writer, PlayingCard.ECardValue value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_ECardValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8BA RID: 47290 RVA: 0x002DD9DC File Offset: 0x002DBBDC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 315707, RefRangeEnd = 315711, XrefRangeStart = 315703, XrefRangeEnd = 315707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_NetworkObject_0(this Writer writer, Il2CppReferenceArray<NetworkObject> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_NetworkObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8BB RID: 47291 RVA: 0x002DDA24 File Offset: 0x002DBC24
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 315039, RefRangeEnd = 315147, XrefRangeStart = 315039, XrefRangeEnd = 315147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_EStage_0(this Writer writer, RTBGameController.EStage value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EStage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8BC RID: 47292 RVA: 0x002DDA68 File Offset: 0x002DBC68
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 315039, RefRangeEnd = 315147, XrefRangeStart = 315039, XrefRangeEnd = 315147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_ESymbol_0(this Writer writer, SlotMachine.ESymbol value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_ESymbol_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8BD RID: 47293 RVA: 0x002DDAAC File Offset: 0x002DBCAC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 315715, RefRangeEnd = 315718, XrefRangeStart = 315711, XrefRangeEnd = 315715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_Il2CppStructArray_1_ESymbol_0(this Writer writer, Il2CppStructArray<SlotMachine.ESymbol> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppStructArray_1_ESymbol_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8BE RID: 47294 RVA: 0x002DDAF4 File Offset: 0x002DBCF4
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 315039, RefRangeEnd = 315147, XrefRangeStart = 315039, XrefRangeEnd = 315147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Doors_EDoorSideFishNet_Serializing_Generated(this Writer writer, EDoorSide value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Doors_EDoorSideFishNet_Serializing_Generated_Public_Static_Void_Writer_EDoorSide_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8BF RID: 47295 RVA: 0x002DDB38 File Offset: 0x002DBD38
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 315039, RefRangeEnd = 315147, XrefRangeStart = 315039, XrefRangeEnd = 315147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Vehicles_Modification_EVehicleColorFishNet_Serializing_Generated(this Writer writer, EVehicleColor value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Vehicles_Modification_EVehicleColorFishNet_Serializing_Generated_Public_Static_Void_Writer_EVehicleColor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8C0 RID: 47296 RVA: 0x002DDB7C File Offset: 0x002DBD7C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 315725, RefRangeEnd = 315729, XrefRangeStart = 315718, XrefRangeEnd = 315725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Vehicles_ParkDataFishNet_Serializing_Generated(this Writer writer, ParkData value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Vehicles_ParkDataFishNet_Serializing_Generated_Public_Static_Void_Writer_ParkData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8C1 RID: 47297 RVA: 0x002DDBC4 File Offset: 0x002DBDC4
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 315039, RefRangeEnd = 315147, XrefRangeStart = 315039, XrefRangeEnd = 315147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Vehicles_EParkingAlignmentFishNet_Serializing_Generated(this Writer writer, EParkingAlignment value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Vehicles_EParkingAlignmentFishNet_Serializing_Generated_Public_Static_Void_Writer_EParkingAlignment_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8C2 RID: 47298 RVA: 0x002DDC08 File Offset: 0x002DBE08
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 315742, RefRangeEnd = 315748, XrefRangeStart = 315729, XrefRangeEnd = 315742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Persistence_TrashContentDataFishNet_Serializing_Generated(this Writer writer, TrashContentData value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Persistence_TrashContentDataFishNet_Serializing_Generated_Public_Static_Void_Writer_TrashContentData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8C3 RID: 47299 RVA: 0x002DDC50 File Offset: 0x002DBE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315748, XrefRangeEnd = 315752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_Il2CppStructArray_1_Int32_PDM_0(this Writer writer, Il2CppStructArray<int> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppStructArray_1_Int32_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8C4 RID: 47300 RVA: 0x002DDC98 File Offset: 0x002DBE98
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 315759, RefRangeEnd = 315780, XrefRangeStart = 315752, XrefRangeEnd = 315759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Tiles_CoordinateFishNet_Serializing_Generated(this Writer writer, Coordinate value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Tiles_CoordinateFishNet_Serializing_Generated_Public_Static_Void_Writer_Coordinate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8C5 RID: 47301 RVA: 0x002DDCE0 File Offset: 0x002DBEE0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 315787, RefRangeEnd = 315793, XrefRangeStart = 315780, XrefRangeEnd = 315787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Product_WeedAppearanceSettingsFishNet_Serializing_Generated(this Writer writer, WeedAppearanceSettings value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Product_WeedAppearanceSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_WeedAppearanceSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8C6 RID: 47302 RVA: 0x002DDD28 File Offset: 0x002DBF28
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 315798, RefRangeEnd = 315810, XrefRangeStart = 315793, XrefRangeEnd = 315798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Product_CocaineAppearanceSettingsFishNet_Serializing_Generated(this Writer writer, CocaineAppearanceSettings value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Product_CocaineAppearanceSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_CocaineAppearanceSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8C7 RID: 47303 RVA: 0x002DDD70 File Offset: 0x002DBF70
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 315798, RefRangeEnd = 315810, XrefRangeStart = 315798, XrefRangeEnd = 315810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Product_MethAppearanceSettingsFishNet_Serializing_Generated(this Writer writer, MethAppearanceSettings value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Product_MethAppearanceSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_MethAppearanceSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8C8 RID: 47304 RVA: 0x002DDDB8 File Offset: 0x002DBFB8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 315383, RefRangeEnd = 315387, XrefRangeStart = 315383, XrefRangeEnd = 315387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Product_NewMixOperationFishNet_Serializing_Generated(this Writer writer, NewMixOperation value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Product_NewMixOperationFishNet_Serializing_Generated_Public_Static_Void_Writer_NewMixOperation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8C9 RID: 47305 RVA: 0x002DDE00 File Offset: 0x002DC000
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 315039, RefRangeEnd = 315147, XrefRangeStart = 315039, XrefRangeEnd = 315147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Public_Static_Void_Writer_EState_0(this Writer writer, Recycler.EState value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EState_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8CA RID: 47306 RVA: 0x002DDE44 File Offset: 0x002DC044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315810, XrefRangeEnd = 315821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_Tiles_CoordinateProceduralTilePairFishNet_Serializing_Generated(this Writer writer, CoordinateProceduralTilePair value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_Tiles_CoordinateProceduralTilePairFishNet_Serializing_Generated_Public_Static_Void_Writer_CoordinateProceduralTilePair_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8CB RID: 47307 RVA: 0x002DDE94 File Offset: 0x002DC094
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 315825, RefRangeEnd = 315831, XrefRangeStart = 315821, XrefRangeEnd = 315825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___System_Collections_Generic_List(this Writer writer, List<CoordinateProceduralTilePair> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___System_Collections_Generic_List`1_ScheduleOne_Tiles_CoordinateProceduralTilePair_FishNet_Serializing_Generated_Public_Static_Void_Writer_List_1_CoordinateProceduralTilePair_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8CC RID: 47308 RVA: 0x002DDEDC File Offset: 0x002DC0DC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 315841, RefRangeEnd = 315847, XrefRangeStart = 315831, XrefRangeEnd = 315841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_ObjectScripts_ChemistryCookOperationFishNet_Serializing_Generated(this Writer writer, ChemistryCookOperation value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_ObjectScripts_ChemistryCookOperationFishNet_Serializing_Generated_Public_Static_Void_Writer_ChemistryCookOperation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8CD RID: 47309 RVA: 0x002DDF24 File Offset: 0x002DC124
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 315857, RefRangeEnd = 315864, XrefRangeStart = 315847, XrefRangeEnd = 315857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_ObjectScripts_DryingOperationFishNet_Serializing_Generated(this Writer writer, DryingOperation value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_ObjectScripts_DryingOperationFishNet_Serializing_Generated_Public_Static_Void_Writer_DryingOperation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8CE RID: 47310 RVA: 0x002DDF6C File Offset: 0x002DC16C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 315875, RefRangeEnd = 315881, XrefRangeStart = 315864, XrefRangeEnd = 315875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_ObjectScripts_OvenCookOperationFishNet_Serializing_Generated(this Writer writer, OvenCookOperation value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_ObjectScripts_OvenCookOperationFishNet_Serializing_Generated_Public_Static_Void_Writer_OvenCookOperation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8CF RID: 47311 RVA: 0x002DDFB4 File Offset: 0x002DC1B4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 315890, RefRangeEnd = 315900, XrefRangeStart = 315881, XrefRangeEnd = 315890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write___ScheduleOne_ObjectScripts_MixOperationFishNet_Serializing_Generated(this Writer writer, MixOperation value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedWriters___Internal.NativeMethodInfoPtr_Write___ScheduleOne_ObjectScripts_MixOperationFishNet_Serializing_Generated_Public_Static_Void_Writer_MixOperation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8D0 RID: 47312 RVA: 0x0005A8A2 File Offset: 0x00058AA2
		public GeneratedWriters___Internal(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04007C44 RID: 31812
		private static readonly IntPtr NativeMethodInfoPtr_InitializeOnce_Private_Static_Void_0;

		// Token: 0x04007C45 RID: 31813
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Vision_VisionEventReceiptFishNet_Serializing_Generated_Public_Static_Void_Writer_VisionEventReceipt_0;

		// Token: 0x04007C46 RID: 31814
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EVisualState_0;

		// Token: 0x04007C47 RID: 31815
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EEventLevel_0;

		// Token: 0x04007C48 RID: 31816
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Quests_ContractInfoFishNet_Serializing_Generated_Public_Static_Void_Writer_ContractInfo_0;

		// Token: 0x04007C49 RID: 31817
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Product_ProductListFishNet_Serializing_Generated_Public_Static_Void_Writer_ProductList_0;

		// Token: 0x04007C4A RID: 31818
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Entry_PDM_0;

		// Token: 0x04007C4B RID: 31819
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_ItemFramework_EQualityFishNet_Serializing_Generated_Public_Static_Void_Writer_EQuality_0;

		// Token: 0x04007C4C RID: 31820
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_List_1_Entry_PDM_0;

		// Token: 0x04007C4D RID: 31821
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Quests_QuestWindowConfigFishNet_Serializing_Generated_Public_Static_Void_Writer_QuestWindowConfig_0;

		// Token: 0x04007C4E RID: 31822
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_GameTime_GameDateTimeFishNet_Serializing_Generated_Public_Static_Void_Writer_GameDateTime_0;

		// Token: 0x04007C4F RID: 31823
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EQuestAction_0;

		// Token: 0x04007C50 RID: 31824
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Quests_EQuestStateFishNet_Serializing_Generated_Public_Static_Void_Writer_EQuestState_0;

		// Token: 0x04007C51 RID: 31825
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Combat_ImpactFishNet_Serializing_Generated_Public_Static_Void_Writer_Impact_0;

		// Token: 0x04007C52 RID: 31826
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Combat_EImpactTypeFishNet_Serializing_Generated_Public_Static_Void_Writer_EImpactType_0;

		// Token: 0x04007C53 RID: 31827
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Vehicles_LandVehicleFishNet_Serializing_Generated_Public_Static_Void_Writer_LandVehicle_0;

		// Token: 0x04007C54 RID: 31828
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_ECheckpointLocation_0;

		// Token: 0x04007C55 RID: 31829
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_PlayerScripts_PlayerFishNet_Serializing_Generated_Public_Static_Void_Writer_Player_0;

		// Token: 0x04007C56 RID: 31830
		private static readonly IntPtr NativeMethodInfoPtr_Write___System_Collections_Generic_List;

		// Token: 0x04007C57 RID: 31831
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_DevUtilities_StringIntPairFishNet_Serializing_Generated_Public_Static_Void_Writer_StringIntPair_0;

		// Token: 0x04007C58 RID: 31832
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_StringIntPair_0;

		// Token: 0x04007C59 RID: 31833
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Messaging_MessageFishNet_Serializing_Generated_Public_Static_Void_Writer_Message_0;

		// Token: 0x04007C5A RID: 31834
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_ESenderType_0;

		// Token: 0x04007C5B RID: 31835
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_UI_Phone_Messages_MessageChainFishNet_Serializing_Generated_Public_Static_Void_Writer_MessageChain_0;

		// Token: 0x04007C5C RID: 31836
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_MSGConversationDataFishNet_Serializing_Generated_Public_Static_Void_Writer_MSGConversationData_0;

		// Token: 0x04007C5D RID: 31837
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_TextMessageDataFishNet_Serializing_Generated_Public_Static_Void_Writer_TextMessageData_0;

		// Token: 0x04007C5E RID: 31838
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_TextMessageData_PDM_0;

		// Token: 0x04007C5F RID: 31839
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_TextResponseDataFishNet_Serializing_Generated_Public_Static_Void_Writer_TextResponseData_0;

		// Token: 0x04007C60 RID: 31840
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_TextResponseData_PDM_0;

		// Token: 0x04007C61 RID: 31841
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Messaging_ResponseFishNet_Serializing_Generated_Public_Static_Void_Writer_Response_0;

		// Token: 0x04007C62 RID: 31842
		private static readonly IntPtr NativeMethodInfoPtr_Write___System_Collections_Generic_List;

		// Token: 0x04007C63 RID: 31843
		private static readonly IntPtr NativeMethodInfoPtr_Write___System_Collections_Generic_List;

		// Token: 0x04007C64 RID: 31844
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_AdvancedTransitRouteDataFishNet_Serializing_Generated_Public_Static_Void_Writer_AdvancedTransitRouteData_0;

		// Token: 0x04007C65 RID: 31845
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EMode_0;

		// Token: 0x04007C66 RID: 31846
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_AdvancedTransitRouteData_0;

		// Token: 0x04007C67 RID: 31847
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Levelling_ERankFishNet_Serializing_Generated_Public_Static_Void_Writer_ERank_0;

		// Token: 0x04007C68 RID: 31848
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Levelling_FullRankFishNet_Serializing_Generated_Public_Static_Void_Writer_FullRank_0;

		// Token: 0x04007C69 RID: 31849
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_PlayerDataFishNet_Serializing_Generated_Public_Static_Void_Writer_PlayerData_0;

		// Token: 0x04007C6A RID: 31850
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_VariableDataFishNet_Serializing_Generated_Public_Static_Void_Writer_VariableData_0;

		// Token: 0x04007C6B RID: 31851
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_VariableData_0;

		// Token: 0x04007C6C RID: 31852
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_AvatarFramework_AvatarSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_AvatarSettings_0;

		// Token: 0x04007C6D RID: 31853
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EyeLidConfiguration_0;

		// Token: 0x04007C6E RID: 31854
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_LayerSetting_PDM_0;

		// Token: 0x04007C6F RID: 31855
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_List_1_LayerSetting_PDM_0;

		// Token: 0x04007C70 RID: 31856
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_AccessorySetting_PDM_0;

		// Token: 0x04007C71 RID: 31857
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_List_1_AccessorySetting_PDM_0;

		// Token: 0x04007C72 RID: 31858
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_AvatarFramework_Customization_BasicAvatarSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_BasicAvatarSettings_0;

		// Token: 0x04007C73 RID: 31859
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EPursuitLevel_0;

		// Token: 0x04007C74 RID: 31860
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Property_PropertyFishNet_Serializing_Generated_Public_Static_Void_Writer_Property_0;

		// Token: 0x04007C75 RID: 31861
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Employees_EEmployeeTypeFishNet_Serializing_Generated_Public_Static_Void_Writer_EEmployeeType_0;

		// Token: 0x04007C76 RID: 31862
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Economy_EDealWindowFishNet_Serializing_Generated_Public_Static_Void_Writer_EDealWindow_0;

		// Token: 0x04007C77 RID: 31863
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EHandoverOutcome_0;

		// Token: 0x04007C78 RID: 31864
		private static readonly IntPtr NativeMethodInfoPtr_Write___System_Collections_Generic_List;

		// Token: 0x04007C79 RID: 31865
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_CustomerDataFishNet_Serializing_Generated_Public_Static_Void_Writer_CustomerData_0;

		// Token: 0x04007C7A RID: 31866
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppStringArray_0;

		// Token: 0x04007C7B RID: 31867
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppStructArray_1_Single_PDM_0;

		// Token: 0x04007C7C RID: 31868
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Product_EDrugTypeFishNet_Serializing_Generated_Public_Static_Void_Writer_EDrugType_0;

		// Token: 0x04007C7D RID: 31869
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Persistence_Datas_GameDataFishNet_Serializing_Generated_Public_Static_Void_Writer_GameData_0;

		// Token: 0x04007C7E RID: 31870
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_DevUtilities_GameSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_GameSettings_0;

		// Token: 0x04007C7F RID: 31871
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Delivery_DeliveryInstanceFishNet_Serializing_Generated_Public_Static_Void_Writer_DeliveryInstance_0;

		// Token: 0x04007C80 RID: 31872
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Delivery_EDeliveryStatusFishNet_Serializing_Generated_Public_Static_Void_Writer_EDeliveryStatus_0;

		// Token: 0x04007C81 RID: 31873
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Combat_ExplosionDataFishNet_Serializing_Generated_Public_Static_Void_Writer_ExplosionData_0;

		// Token: 0x04007C82 RID: 31874
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_ECardSuit_0;

		// Token: 0x04007C83 RID: 31875
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_ECardValue_0;

		// Token: 0x04007C84 RID: 31876
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppReferenceArray_1_NetworkObject_0;

		// Token: 0x04007C85 RID: 31877
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EStage_0;

		// Token: 0x04007C86 RID: 31878
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_ESymbol_0;

		// Token: 0x04007C87 RID: 31879
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppStructArray_1_ESymbol_0;

		// Token: 0x04007C88 RID: 31880
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Doors_EDoorSideFishNet_Serializing_Generated_Public_Static_Void_Writer_EDoorSide_0;

		// Token: 0x04007C89 RID: 31881
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Vehicles_Modification_EVehicleColorFishNet_Serializing_Generated_Public_Static_Void_Writer_EVehicleColor_0;

		// Token: 0x04007C8A RID: 31882
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Vehicles_ParkDataFishNet_Serializing_Generated_Public_Static_Void_Writer_ParkData_0;

		// Token: 0x04007C8B RID: 31883
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Vehicles_EParkingAlignmentFishNet_Serializing_Generated_Public_Static_Void_Writer_EParkingAlignment_0;

		// Token: 0x04007C8C RID: 31884
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Persistence_TrashContentDataFishNet_Serializing_Generated_Public_Static_Void_Writer_TrashContentData_0;

		// Token: 0x04007C8D RID: 31885
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_Il2CppStructArray_1_Int32_PDM_0;

		// Token: 0x04007C8E RID: 31886
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Tiles_CoordinateFishNet_Serializing_Generated_Public_Static_Void_Writer_Coordinate_0;

		// Token: 0x04007C8F RID: 31887
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Product_WeedAppearanceSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_WeedAppearanceSettings_0;

		// Token: 0x04007C90 RID: 31888
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Product_CocaineAppearanceSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_CocaineAppearanceSettings_0;

		// Token: 0x04007C91 RID: 31889
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Product_MethAppearanceSettingsFishNet_Serializing_Generated_Public_Static_Void_Writer_MethAppearanceSettings_0;

		// Token: 0x04007C92 RID: 31890
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Product_NewMixOperationFishNet_Serializing_Generated_Public_Static_Void_Writer_NewMixOperation_0;

		// Token: 0x04007C93 RID: 31891
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_Writer_EState_0;

		// Token: 0x04007C94 RID: 31892
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_Tiles_CoordinateProceduralTilePairFishNet_Serializing_Generated_Public_Static_Void_Writer_CoordinateProceduralTilePair_0;

		// Token: 0x04007C95 RID: 31893
		private static readonly IntPtr NativeMethodInfoPtr_Write___System_Collections_Generic_List;

		// Token: 0x04007C96 RID: 31894
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_ObjectScripts_ChemistryCookOperationFishNet_Serializing_Generated_Public_Static_Void_Writer_ChemistryCookOperation_0;

		// Token: 0x04007C97 RID: 31895
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_ObjectScripts_DryingOperationFishNet_Serializing_Generated_Public_Static_Void_Writer_DryingOperation_0;

		// Token: 0x04007C98 RID: 31896
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_ObjectScripts_OvenCookOperationFishNet_Serializing_Generated_Public_Static_Void_Writer_OvenCookOperation_0;

		// Token: 0x04007C99 RID: 31897
		private static readonly IntPtr NativeMethodInfoPtr_Write___ScheduleOne_ObjectScripts_MixOperationFishNet_Serializing_Generated_Public_Static_Void_Writer_MixOperation_0;
	}
}
