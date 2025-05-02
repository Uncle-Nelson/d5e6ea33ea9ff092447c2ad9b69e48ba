using System;
using System.Runtime.InteropServices;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
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
	// Token: 0x020007A1 RID: 1953
	[StructLayout(3, CharSet = 4)]
	public static class GeneratedReaders___Internal : Object
	{
		// Token: 0x0600B8D1 RID: 47313 RVA: 0x002DDFFC File Offset: 0x002DC1FC
		// Note: this type is marked as 'beforefieldinit'.
		static GeneratedReaders___Internal()
		{
			Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FishNet.Serializing.Generated", "GeneratedReaders___Internal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr);
			GeneratedReaders___Internal.NativeMethodInfoPtr_InitializeOnce_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686055);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Vision_VisionEventReceiptFishNet_Serializing_Generateds_Public_Static_VisionEventReceipt_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686056);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EVisualState_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686057);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EEventLevel_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686058);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Quests_ContractInfoFishNet_Serializing_Generateds_Public_Static_ContractInfo_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686059);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Product_ProductListFishNet_Serializing_Generateds_Public_Static_ProductList_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686060);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Entry_Reader_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686061);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_ItemFramework_EQualityFishNet_Serializing_Generateds_Public_Static_EQuality_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686062);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_List_1_Entry_Reader_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686063);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Quests_QuestWindowConfigFishNet_Serializing_Generateds_Public_Static_QuestWindowConfig_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686064);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_GameTime_GameDateTimeFishNet_Serializing_Generateds_Public_Static_GameDateTime_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686065);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EQuestAction_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686066);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Quests_EQuestStateFishNet_Serializing_Generateds_Public_Static_EQuestState_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686067);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Combat_ImpactFishNet_Serializing_Generateds_Public_Static_Impact_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686068);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Combat_EImpactTypeFishNet_Serializing_Generateds_Public_Static_EImpactType_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686069);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Vehicles_LandVehicleFishNet_Serializing_Generateds_Public_Static_LandVehicle_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686070);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_ECheckpointLocation_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686071);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_PlayerScripts_PlayerFishNet_Serializing_Generateds_Public_Static_Player_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686072);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___System_Collections_Generic_List`1_System_String_FishNet_Serializing_Generateds_Public_Static_List_1_String_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686073);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_DevUtilities_StringIntPairFishNet_Serializing_Generateds_Public_Static_StringIntPair_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686074);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_StringIntPair_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686075);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Messaging_MessageFishNet_Serializing_Generateds_Public_Static_Message_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686076);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_ESenderType_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686077);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_UI_Phone_Messages_MessageChainFishNet_Serializing_Generateds_Public_Static_MessageChain_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686078);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_MSGConversationDataFishNet_Serializing_Generateds_Public_Static_MSGConversationData_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686079);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_TextMessageDataFishNet_Serializing_Generateds_Public_Static_TextMessageData_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686080);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_TextMessageData_Reader_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686081);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_TextResponseDataFishNet_Serializing_Generateds_Public_Static_TextResponseData_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686082);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_TextResponseData_Reader_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686083);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Messaging_ResponseFishNet_Serializing_Generateds_Public_Static_Response_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686084);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___System_Collections_Generic_List`1_ScheduleOne_Messaging_Response_FishNet_Serializing_Generateds_Public_Static_List_1_Response_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686085);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___System_Collections_Generic_List`1_FishNet_Object_NetworkObject_FishNet_Serializing_Generateds_Public_Static_List_1_NetworkObject_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686086);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_AdvancedTransitRouteDataFishNet_Serializing_Generateds_Public_Static_AdvancedTransitRouteData_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686087);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EMode_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686088);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_AdvancedTransitRouteData_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686089);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Levelling_ERankFishNet_Serializing_Generateds_Public_Static_ERank_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686090);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Levelling_FullRankFishNet_Serializing_Generateds_Public_Static_FullRank_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686091);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_PlayerDataFishNet_Serializing_Generateds_Public_Static_PlayerData_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686092);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_VariableDataFishNet_Serializing_Generateds_Public_Static_VariableData_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686093);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_VariableData_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686094);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_AvatarFramework_AvatarSettingsFishNet_Serializing_Generateds_Public_Static_AvatarSettings_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686095);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EyeLidConfiguration_Reader_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686096);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_LayerSetting_Reader_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686097);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_List_1_LayerSetting_Reader_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686098);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_AccessorySetting_Reader_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686099);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_List_1_AccessorySetting_Reader_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686100);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_AvatarFramework_Customization_BasicAvatarSettingsFishNet_Serializing_Generateds_Public_Static_BasicAvatarSettings_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686101);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EPursuitLevel_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686102);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Property_PropertyFishNet_Serializing_Generateds_Public_Static_Property_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686103);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Employees_EEmployeeTypeFishNet_Serializing_Generateds_Public_Static_EEmployeeType_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686104);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Economy_EDealWindowFishNet_Serializing_Generateds_Public_Static_EDealWindow_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686105);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EHandoverOutcome_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686106);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___System_Collections_Generic_List`1_ScheduleOne_ItemFramework_ItemInstance_FishNet_Serializing_Generateds_Public_Static_List_1_ItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686107);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_CustomerDataFishNet_Serializing_Generateds_Public_Static_CustomerData_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686108);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppStringArray_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686109);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppStructArray_1_Single_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686110);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Product_EDrugTypeFishNet_Serializing_Generateds_Public_Static_EDrugType_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686111);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_GameDataFishNet_Serializing_Generateds_Public_Static_GameData_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686112);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_DevUtilities_GameSettingsFishNet_Serializing_Generateds_Public_Static_GameSettings_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686113);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Delivery_DeliveryInstanceFishNet_Serializing_Generateds_Public_Static_DeliveryInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686114);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Delivery_EDeliveryStatusFishNet_Serializing_Generateds_Public_Static_EDeliveryStatus_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686115);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Combat_ExplosionDataFishNet_Serializing_Generateds_Public_Static_ExplosionData_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686116);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_ECardSuit_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686117);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_ECardValue_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686118);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_NetworkObject_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686119);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EStage_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686120);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_ESymbol_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686121);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppStructArray_1_ESymbol_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686122);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Doors_EDoorSideFishNet_Serializing_Generateds_Public_Static_EDoorSide_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686123);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Vehicles_Modification_EVehicleColorFishNet_Serializing_Generateds_Public_Static_EVehicleColor_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686124);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Vehicles_ParkDataFishNet_Serializing_Generateds_Public_Static_ParkData_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686125);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Vehicles_EParkingAlignmentFishNet_Serializing_Generateds_Public_Static_EParkingAlignment_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686126);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_TrashContentDataFishNet_Serializing_Generateds_Public_Static_TrashContentData_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686127);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppStructArray_1_Int32_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686128);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Tiles_CoordinateFishNet_Serializing_Generateds_Public_Static_Coordinate_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686129);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Product_WeedAppearanceSettingsFishNet_Serializing_Generateds_Public_Static_WeedAppearanceSettings_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686130);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Product_CocaineAppearanceSettingsFishNet_Serializing_Generateds_Public_Static_CocaineAppearanceSettings_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686131);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Product_MethAppearanceSettingsFishNet_Serializing_Generateds_Public_Static_MethAppearanceSettings_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686132);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Product_NewMixOperationFishNet_Serializing_Generateds_Public_Static_NewMixOperation_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686133);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EState_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686134);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Tiles_CoordinateProceduralTilePairFishNet_Serializing_Generateds_Public_Static_CoordinateProceduralTilePair_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686135);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___System_Collections_Generic_List`1_ScheduleOne_Tiles_CoordinateProceduralTilePair_FishNet_Serializing_Generateds_Public_Static_List_1_CoordinateProceduralTilePair_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686136);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_ObjectScripts_ChemistryCookOperationFishNet_Serializing_Generateds_Public_Static_ChemistryCookOperation_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686137);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_ObjectScripts_DryingOperationFishNet_Serializing_Generateds_Public_Static_DryingOperation_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686138);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_ObjectScripts_OvenCookOperationFishNet_Serializing_Generateds_Public_Static_OvenCookOperation_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686139);
			GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_ObjectScripts_MixOperationFishNet_Serializing_Generateds_Public_Static_MixOperation_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedReaders___Internal>.NativeClassPtr, 100686140);
		}

		// Token: 0x0600B8D2 RID: 47314 RVA: 0x002DE6E4 File Offset: 0x002DC8E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315900, XrefRangeEnd = 316797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeOnce()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_InitializeOnce_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8D3 RID: 47315 RVA: 0x002DE70C File Offset: 0x002DC90C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316805, RefRangeEnd = 316807, XrefRangeStart = 316797, XrefRangeEnd = 316805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VisionEventReceipt Read___ScheduleOne_Vision_VisionEventReceiptFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Vision_VisionEventReceiptFishNet_Serializing_Generateds_Public_Static_VisionEventReceipt_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisionEventReceipt>(intPtr3) : null;
		}

		// Token: 0x0600B8D4 RID: 47316 RVA: 0x002DE750 File Offset: 0x002DC950
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316810, RefRangeEnd = 316862, XrefRangeStart = 316807, XrefRangeEnd = 316810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayerVisualState.EVisualState Method_Public_Static_EVisualState_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EVisualState_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8D5 RID: 47317 RVA: 0x002DE794 File Offset: 0x002DC994
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316810, RefRangeEnd = 316862, XrefRangeStart = 316810, XrefRangeEnd = 316862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VisionCone.EEventLevel Method_Public_Static_EEventLevel_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EEventLevel_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8D6 RID: 47318 RVA: 0x002DE7D8 File Offset: 0x002DC9D8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 316892, RefRangeEnd = 316897, XrefRangeStart = 316862, XrefRangeEnd = 316892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ContractInfo Read___ScheduleOne_Quests_ContractInfoFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Quests_ContractInfoFishNet_Serializing_Generateds_Public_Static_ContractInfo_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContractInfo>(intPtr3) : null;
		}

		// Token: 0x0600B8D7 RID: 47319 RVA: 0x002DE81C File Offset: 0x002DCA1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316905, RefRangeEnd = 316906, XrefRangeStart = 316897, XrefRangeEnd = 316905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProductList Read___ScheduleOne_Product_ProductListFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Product_ProductListFishNet_Serializing_Generateds_Public_Static_ProductList_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductList>(intPtr3) : null;
		}

		// Token: 0x0600B8D8 RID: 47320 RVA: 0x002DE860 File Offset: 0x002DCA60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316906, XrefRangeEnd = 316916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProductList.Entry Method_Public_Static_Entry_Reader_PDM_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Entry_Reader_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductList.Entry>(intPtr3) : null;
		}

		// Token: 0x0600B8D9 RID: 47321 RVA: 0x002DE8A4 File Offset: 0x002DCAA4
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316810, RefRangeEnd = 316862, XrefRangeStart = 316810, XrefRangeEnd = 316862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EQuality Read___ScheduleOne_ItemFramework_EQualityFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_ItemFramework_EQualityFishNet_Serializing_Generateds_Public_Static_EQuality_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8DA RID: 47322 RVA: 0x002DE8E8 File Offset: 0x002DCAE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316916, XrefRangeEnd = 316920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<ProductList.Entry> Method_Public_Static_List_1_Entry_Reader_PDM_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_List_1_Entry_Reader_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ProductList.Entry>>(intPtr3) : null;
		}

		// Token: 0x0600B8DB RID: 47323 RVA: 0x002DE92C File Offset: 0x002DCB2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316920, XrefRangeEnd = 316928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static QuestWindowConfig Read___ScheduleOne_Quests_QuestWindowConfigFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Quests_QuestWindowConfigFishNet_Serializing_Generateds_Public_Static_QuestWindowConfig_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<QuestWindowConfig>(intPtr3) : null;
		}

		// Token: 0x0600B8DC RID: 47324 RVA: 0x002DE970 File Offset: 0x002DCB70
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 316932, RefRangeEnd = 316939, XrefRangeStart = 316928, XrefRangeEnd = 316932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameDateTime Read___ScheduleOne_GameTime_GameDateTimeFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_GameTime_GameDateTimeFishNet_Serializing_Generateds_Public_Static_GameDateTime_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8DD RID: 47325 RVA: 0x002DE9B4 File Offset: 0x002DCBB4
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316810, RefRangeEnd = 316862, XrefRangeStart = 316810, XrefRangeEnd = 316862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static QuestManager.EQuestAction Method_Public_Static_EQuestAction_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EQuestAction_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8DE RID: 47326 RVA: 0x002DE9F8 File Offset: 0x002DCBF8
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316810, RefRangeEnd = 316862, XrefRangeStart = 316810, XrefRangeEnd = 316862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EQuestState Read___ScheduleOne_Quests_EQuestStateFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Quests_EQuestStateFishNet_Serializing_Generateds_Public_Static_EQuestState_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8DF RID: 47327 RVA: 0x002DEA3C File Offset: 0x002DCC3C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 316957, RefRangeEnd = 316961, XrefRangeStart = 316939, XrefRangeEnd = 316957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Impact Read___ScheduleOne_Combat_ImpactFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Combat_ImpactFishNet_Serializing_Generateds_Public_Static_Impact_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Impact>(intPtr3) : null;
		}

		// Token: 0x0600B8E0 RID: 47328 RVA: 0x002DEA80 File Offset: 0x002DCC80
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316810, RefRangeEnd = 316862, XrefRangeStart = 316810, XrefRangeEnd = 316862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EImpactType Read___ScheduleOne_Combat_EImpactTypeFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Combat_EImpactTypeFishNet_Serializing_Generateds_Public_Static_EImpactType_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8E1 RID: 47329 RVA: 0x002DEAC4 File Offset: 0x002DCCC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316964, RefRangeEnd = 316966, XrefRangeStart = 316961, XrefRangeEnd = 316964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LandVehicle Read___ScheduleOne_Vehicles_LandVehicleFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Vehicles_LandVehicleFishNet_Serializing_Generateds_Public_Static_LandVehicle_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
		}

		// Token: 0x0600B8E2 RID: 47330 RVA: 0x002DEB08 File Offset: 0x002DCD08
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316810, RefRangeEnd = 316862, XrefRangeStart = 316810, XrefRangeEnd = 316862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CheckpointManager.ECheckpointLocation Method_Public_Static_ECheckpointLocation_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_ECheckpointLocation_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8E3 RID: 47331 RVA: 0x002DEB4C File Offset: 0x002DCD4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316969, RefRangeEnd = 316970, XrefRangeStart = 316966, XrefRangeEnd = 316969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Player Read___ScheduleOne_PlayerScripts_PlayerFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_PlayerScripts_PlayerFishNet_Serializing_Generateds_Public_Static_Player_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
		}

		// Token: 0x0600B8E4 RID: 47332 RVA: 0x002DEB90 File Offset: 0x002DCD90
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 316974, RefRangeEnd = 316984, XrefRangeStart = 316970, XrefRangeEnd = 316974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<string> Read___System_Collections_Generic_List(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___System_Collections_Generic_List`1_System_String_FishNet_Serializing_Generateds_Public_Static_List_1_String_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x0600B8E5 RID: 47333 RVA: 0x002DEBD4 File Offset: 0x002DCDD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316984, XrefRangeEnd = 316992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StringIntPair Read___ScheduleOne_DevUtilities_StringIntPairFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_DevUtilities_StringIntPairFishNet_Serializing_Generateds_Public_Static_StringIntPair_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringIntPair>(intPtr3) : null;
		}

		// Token: 0x0600B8E6 RID: 47334 RVA: 0x002DEC18 File Offset: 0x002DCE18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316996, RefRangeEnd = 316997, XrefRangeStart = 316992, XrefRangeEnd = 316996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<StringIntPair> Method_Public_Static_Il2CppReferenceArray_1_StringIntPair_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_StringIntPair_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StringIntPair>>(intPtr3) : null;
		}

		// Token: 0x0600B8E7 RID: 47335 RVA: 0x002DEC5C File Offset: 0x002DCE5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317007, RefRangeEnd = 317009, XrefRangeStart = 316997, XrefRangeEnd = 317007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Message Read___ScheduleOne_Messaging_MessageFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Messaging_MessageFishNet_Serializing_Generateds_Public_Static_Message_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Message>(intPtr3) : null;
		}

		// Token: 0x0600B8E8 RID: 47336 RVA: 0x002DECA0 File Offset: 0x002DCEA0
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316810, RefRangeEnd = 316862, XrefRangeStart = 316810, XrefRangeEnd = 316862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Message.ESenderType Method_Public_Static_ESenderType_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_ESenderType_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8E9 RID: 47337 RVA: 0x002DECE4 File Offset: 0x002DCEE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317019, RefRangeEnd = 317021, XrefRangeStart = 317009, XrefRangeEnd = 317019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MessageChain Read___ScheduleOne_UI_Phone_Messages_MessageChainFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_UI_Phone_Messages_MessageChainFishNet_Serializing_Generateds_Public_Static_MessageChain_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MessageChain>(intPtr3) : null;
		}

		// Token: 0x0600B8EA RID: 47338 RVA: 0x002DED28 File Offset: 0x002DCF28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317043, RefRangeEnd = 317044, XrefRangeStart = 317021, XrefRangeEnd = 317043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MSGConversationData Read___ScheduleOne_Persistence_Datas_MSGConversationDataFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_MSGConversationDataFishNet_Serializing_Generateds_Public_Static_MSGConversationData_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MSGConversationData>(intPtr3) : null;
		}

		// Token: 0x0600B8EB RID: 47339 RVA: 0x002DED6C File Offset: 0x002DCF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317044, XrefRangeEnd = 317054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TextMessageData Read___ScheduleOne_Persistence_Datas_TextMessageDataFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_TextMessageDataFishNet_Serializing_Generateds_Public_Static_TextMessageData_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextMessageData>(intPtr3) : null;
		}

		// Token: 0x0600B8EC RID: 47340 RVA: 0x002DEDB0 File Offset: 0x002DCFB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317054, XrefRangeEnd = 317058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<TextMessageData> Method_Public_Static_Il2CppReferenceArray_1_TextMessageData_Reader_PDM_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_TextMessageData_Reader_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMessageData>>(intPtr3) : null;
		}

		// Token: 0x0600B8ED RID: 47341 RVA: 0x002DEDF4 File Offset: 0x002DCFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317058, XrefRangeEnd = 317066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TextResponseData Read___ScheduleOne_Persistence_Datas_TextResponseDataFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_TextResponseDataFishNet_Serializing_Generateds_Public_Static_TextResponseData_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextResponseData>(intPtr3) : null;
		}

		// Token: 0x0600B8EE RID: 47342 RVA: 0x002DEE38 File Offset: 0x002DD038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317066, XrefRangeEnd = 317070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<TextResponseData> Method_Public_Static_Il2CppReferenceArray_1_TextResponseData_Reader_PDM_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_TextResponseData_Reader_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextResponseData>>(intPtr3) : null;
		}

		// Token: 0x0600B8EF RID: 47343 RVA: 0x002DEE7C File Offset: 0x002DD07C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317070, XrefRangeEnd = 317078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Response Read___ScheduleOne_Messaging_ResponseFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Messaging_ResponseFishNet_Serializing_Generateds_Public_Static_Response_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Response>(intPtr3) : null;
		}

		// Token: 0x0600B8F0 RID: 47344 RVA: 0x002DEEC0 File Offset: 0x002DD0C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317082, RefRangeEnd = 317084, XrefRangeStart = 317078, XrefRangeEnd = 317082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Response> Read___System_Collections_Generic_List(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___System_Collections_Generic_List`1_ScheduleOne_Messaging_Response_FishNet_Serializing_Generateds_Public_Static_List_1_Response_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Response>>(intPtr3) : null;
		}

		// Token: 0x0600B8F1 RID: 47345 RVA: 0x002DEF04 File Offset: 0x002DD104
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317088, RefRangeEnd = 317090, XrefRangeStart = 317084, XrefRangeEnd = 317088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<NetworkObject> Read___System_Collections_Generic_List(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___System_Collections_Generic_List`1_FishNet_Object_NetworkObject_FishNet_Serializing_Generateds_Public_Static_List_1_NetworkObject_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NetworkObject>>(intPtr3) : null;
		}

		// Token: 0x0600B8F2 RID: 47346 RVA: 0x002DEF48 File Offset: 0x002DD148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317090, XrefRangeEnd = 317104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AdvancedTransitRouteData Read___ScheduleOne_Persistence_Datas_AdvancedTransitRouteDataFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_AdvancedTransitRouteDataFishNet_Serializing_Generateds_Public_Static_AdvancedTransitRouteData_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AdvancedTransitRouteData>(intPtr3) : null;
		}

		// Token: 0x0600B8F3 RID: 47347 RVA: 0x002DEF8C File Offset: 0x002DD18C
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316810, RefRangeEnd = 316862, XrefRangeStart = 316810, XrefRangeEnd = 316862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ManagementItemFilter.EMode Method_Public_Static_EMode_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EMode_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8F4 RID: 47348 RVA: 0x002DEFD0 File Offset: 0x002DD1D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317108, RefRangeEnd = 317110, XrefRangeStart = 317104, XrefRangeEnd = 317108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<AdvancedTransitRouteData> Method_Public_Static_Il2CppReferenceArray_1_AdvancedTransitRouteData_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_AdvancedTransitRouteData_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AdvancedTransitRouteData>>(intPtr3) : null;
		}

		// Token: 0x0600B8F5 RID: 47349 RVA: 0x002DF014 File Offset: 0x002DD214
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316810, RefRangeEnd = 316862, XrefRangeStart = 316810, XrefRangeEnd = 316862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ERank Read___ScheduleOne_Levelling_ERankFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Levelling_ERankFishNet_Serializing_Generateds_Public_Static_ERank_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8F6 RID: 47350 RVA: 0x002DF058 File Offset: 0x002DD258
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 316932, RefRangeEnd = 316939, XrefRangeStart = 316932, XrefRangeEnd = 316939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FullRank Read___ScheduleOne_Levelling_FullRankFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Levelling_FullRankFishNet_Serializing_Generateds_Public_Static_FullRank_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8F7 RID: 47351 RVA: 0x002DF09C File Offset: 0x002DD29C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317126, RefRangeEnd = 317128, XrefRangeStart = 317110, XrefRangeEnd = 317126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayerData Read___ScheduleOne_Persistence_Datas_PlayerDataFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_PlayerDataFishNet_Serializing_Generateds_Public_Static_PlayerData_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerData>(intPtr3) : null;
		}

		// Token: 0x0600B8F8 RID: 47352 RVA: 0x002DF0E0 File Offset: 0x002DD2E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317128, XrefRangeEnd = 317142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VariableData Read___ScheduleOne_Persistence_Datas_VariableDataFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_VariableDataFishNet_Serializing_Generateds_Public_Static_VariableData_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VariableData>(intPtr3) : null;
		}

		// Token: 0x0600B8F9 RID: 47353 RVA: 0x002DF124 File Offset: 0x002DD324
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317146, RefRangeEnd = 317148, XrefRangeStart = 317142, XrefRangeEnd = 317146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<VariableData> Method_Public_Static_Il2CppReferenceArray_1_VariableData_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_VariableData_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VariableData>>(intPtr3) : null;
		}

		// Token: 0x0600B8FA RID: 47354 RVA: 0x002DF168 File Offset: 0x002DD368
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317186, RefRangeEnd = 317188, XrefRangeStart = 317148, XrefRangeEnd = 317186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AvatarSettings Read___ScheduleOne_AvatarFramework_AvatarSettingsFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_AvatarFramework_AvatarSettingsFishNet_Serializing_Generateds_Public_Static_AvatarSettings_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr3) : null;
		}

		// Token: 0x0600B8FB RID: 47355 RVA: 0x002DF1AC File Offset: 0x002DD3AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317188, XrefRangeEnd = 317190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Eye.EyeLidConfiguration Method_Public_Static_EyeLidConfiguration_Reader_PDM_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EyeLidConfiguration_Reader_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8FC RID: 47356 RVA: 0x002DF1F0 File Offset: 0x002DD3F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317190, XrefRangeEnd = 317193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AvatarSettings.LayerSetting Method_Public_Static_LayerSetting_Reader_PDM_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_LayerSetting_Reader_PDM_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new AvatarSettings.LayerSetting(pointer);
		}

		// Token: 0x0600B8FD RID: 47357 RVA: 0x002DF22C File Offset: 0x002DD42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317193, XrefRangeEnd = 317197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<AvatarSettings.LayerSetting> Method_Public_Static_List_1_LayerSetting_Reader_PDM_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_List_1_LayerSetting_Reader_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<AvatarSettings.LayerSetting>>(intPtr3) : null;
		}

		// Token: 0x0600B8FE RID: 47358 RVA: 0x002DF270 File Offset: 0x002DD470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317197, XrefRangeEnd = 317204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AvatarSettings.AccessorySetting Method_Public_Static_AccessorySetting_Reader_PDM_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_AccessorySetting_Reader_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarSettings.AccessorySetting>(intPtr3) : null;
		}

		// Token: 0x0600B8FF RID: 47359 RVA: 0x002DF2B4 File Offset: 0x002DD4B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317204, XrefRangeEnd = 317208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<AvatarSettings.AccessorySetting> Method_Public_Static_List_1_AccessorySetting_Reader_PDM_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_List_1_AccessorySetting_Reader_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<AvatarSettings.AccessorySetting>>(intPtr3) : null;
		}

		// Token: 0x0600B900 RID: 47360 RVA: 0x002DF2F8 File Offset: 0x002DD4F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 317252, RefRangeEnd = 317255, XrefRangeStart = 317208, XrefRangeEnd = 317252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BasicAvatarSettings Read___ScheduleOne_AvatarFramework_Customization_BasicAvatarSettingsFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_AvatarFramework_Customization_BasicAvatarSettingsFishNet_Serializing_Generateds_Public_Static_BasicAvatarSettings_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BasicAvatarSettings>(intPtr3) : null;
		}

		// Token: 0x0600B901 RID: 47361 RVA: 0x002DF33C File Offset: 0x002DD53C
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316810, RefRangeEnd = 316862, XrefRangeStart = 316810, XrefRangeEnd = 316862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayerCrimeData.EPursuitLevel Method_Public_Static_EPursuitLevel_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EPursuitLevel_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B902 RID: 47362 RVA: 0x002DF380 File Offset: 0x002DD580
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317258, RefRangeEnd = 317259, XrefRangeStart = 317255, XrefRangeEnd = 317258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Property Read___ScheduleOne_Property_PropertyFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Property_PropertyFishNet_Serializing_Generateds_Public_Static_Property_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
		}

		// Token: 0x0600B903 RID: 47363 RVA: 0x002DF3C4 File Offset: 0x002DD5C4
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316810, RefRangeEnd = 316862, XrefRangeStart = 316810, XrefRangeEnd = 316862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EEmployeeType Read___ScheduleOne_Employees_EEmployeeTypeFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Employees_EEmployeeTypeFishNet_Serializing_Generateds_Public_Static_EEmployeeType_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B904 RID: 47364 RVA: 0x002DF408 File Offset: 0x002DD608
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316810, RefRangeEnd = 316862, XrefRangeStart = 316810, XrefRangeEnd = 316862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EDealWindow Read___ScheduleOne_Economy_EDealWindowFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Economy_EDealWindowFishNet_Serializing_Generateds_Public_Static_EDealWindow_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B905 RID: 47365 RVA: 0x002DF44C File Offset: 0x002DD64C
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316810, RefRangeEnd = 316862, XrefRangeStart = 316810, XrefRangeEnd = 316862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HandoverScreen.EHandoverOutcome Method_Public_Static_EHandoverOutcome_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EHandoverOutcome_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B906 RID: 47366 RVA: 0x002DF490 File Offset: 0x002DD690
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317263, RefRangeEnd = 317265, XrefRangeStart = 317259, XrefRangeEnd = 317263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<ItemInstance> Read___System_Collections_Generic_List(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___System_Collections_Generic_List`1_ScheduleOne_ItemFramework_ItemInstance_FishNet_Serializing_Generateds_Public_Static_List_1_ItemInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemInstance>>(intPtr3) : null;
		}

		// Token: 0x0600B907 RID: 47367 RVA: 0x002DF4D4 File Offset: 0x002DD6D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317301, RefRangeEnd = 317302, XrefRangeStart = 317265, XrefRangeEnd = 317301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppScheduleOne.Persistence.Datas.CustomerData Read___ScheduleOne_Persistence_Datas_CustomerDataFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_CustomerDataFishNet_Serializing_Generateds_Public_Static_CustomerData_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.Persistence.Datas.CustomerData>(intPtr3) : null;
		}

		// Token: 0x0600B908 RID: 47368 RVA: 0x002DF518 File Offset: 0x002DD718
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317306, RefRangeEnd = 317308, XrefRangeStart = 317302, XrefRangeEnd = 317306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray Method_Public_Static_Il2CppStringArray_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppStringArray_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600B909 RID: 47369 RVA: 0x002DF55C File Offset: 0x002DD75C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317324, RefRangeEnd = 317325, XrefRangeStart = 317308, XrefRangeEnd = 317324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<float> Method_Public_Static_Il2CppStructArray_1_Single_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppStructArray_1_Single_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr3) : null;
		}

		// Token: 0x0600B90A RID: 47370 RVA: 0x002DF5A0 File Offset: 0x002DD7A0
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316810, RefRangeEnd = 316862, XrefRangeStart = 316810, XrefRangeEnd = 316862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EDrugType Read___ScheduleOne_Product_EDrugTypeFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Product_EDrugTypeFishNet_Serializing_Generateds_Public_Static_EDrugType_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B90B RID: 47371 RVA: 0x002DF5E4 File Offset: 0x002DD7E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317345, RefRangeEnd = 317346, XrefRangeStart = 317325, XrefRangeEnd = 317345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameData Read___ScheduleOne_Persistence_Datas_GameDataFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_GameDataFishNet_Serializing_Generateds_Public_Static_GameData_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameData>(intPtr3) : null;
		}

		// Token: 0x0600B90C RID: 47372 RVA: 0x002DF628 File Offset: 0x002DD828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317346, XrefRangeEnd = 317350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameSettings Read___ScheduleOne_DevUtilities_GameSettingsFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_DevUtilities_GameSettingsFishNet_Serializing_Generateds_Public_Static_GameSettings_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameSettings>(intPtr3) : null;
		}

		// Token: 0x0600B90D RID: 47373 RVA: 0x002DF66C File Offset: 0x002DD86C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 317371, RefRangeEnd = 317374, XrefRangeStart = 317350, XrefRangeEnd = 317371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DeliveryInstance Read___ScheduleOne_Delivery_DeliveryInstanceFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Delivery_DeliveryInstanceFishNet_Serializing_Generateds_Public_Static_DeliveryInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeliveryInstance>(intPtr3) : null;
		}

		// Token: 0x0600B90E RID: 47374 RVA: 0x002DF6B0 File Offset: 0x002DD8B0
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316810, RefRangeEnd = 316862, XrefRangeStart = 316810, XrefRangeEnd = 316862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EDeliveryStatus Read___ScheduleOne_Delivery_EDeliveryStatusFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Delivery_EDeliveryStatusFishNet_Serializing_Generateds_Public_Static_EDeliveryStatus_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B90F RID: 47375 RVA: 0x002DF6F4 File Offset: 0x002DD8F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317378, RefRangeEnd = 317380, XrefRangeStart = 317374, XrefRangeEnd = 317378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ExplosionData Read___ScheduleOne_Combat_ExplosionDataFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Combat_ExplosionDataFishNet_Serializing_Generateds_Public_Static_ExplosionData_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B910 RID: 47376 RVA: 0x002DF738 File Offset: 0x002DD938
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316810, RefRangeEnd = 316862, XrefRangeStart = 316810, XrefRangeEnd = 316862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayingCard.ECardSuit Method_Public_Static_ECardSuit_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_ECardSuit_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B911 RID: 47377 RVA: 0x002DF77C File Offset: 0x002DD97C
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316810, RefRangeEnd = 316862, XrefRangeStart = 316810, XrefRangeEnd = 316862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayingCard.ECardValue Method_Public_Static_ECardValue_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_ECardValue_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B912 RID: 47378 RVA: 0x002DF7C0 File Offset: 0x002DD9C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317384, RefRangeEnd = 317386, XrefRangeStart = 317380, XrefRangeEnd = 317384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<NetworkObject> Method_Public_Static_Il2CppReferenceArray_1_NetworkObject_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_NetworkObject_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NetworkObject>>(intPtr3) : null;
		}

		// Token: 0x0600B913 RID: 47379 RVA: 0x002DF804 File Offset: 0x002DDA04
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316810, RefRangeEnd = 316862, XrefRangeStart = 316810, XrefRangeEnd = 316862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RTBGameController.EStage Method_Public_Static_EStage_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EStage_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B914 RID: 47380 RVA: 0x002DF848 File Offset: 0x002DDA48
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316810, RefRangeEnd = 316862, XrefRangeStart = 316810, XrefRangeEnd = 316862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SlotMachine.ESymbol Method_Public_Static_ESymbol_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_ESymbol_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B915 RID: 47381 RVA: 0x002DF88C File Offset: 0x002DDA8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317402, RefRangeEnd = 317403, XrefRangeStart = 317386, XrefRangeEnd = 317402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<SlotMachine.ESymbol> Method_Public_Static_Il2CppStructArray_1_ESymbol_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppStructArray_1_ESymbol_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<SlotMachine.ESymbol>>(intPtr3) : null;
		}

		// Token: 0x0600B916 RID: 47382 RVA: 0x002DF8D0 File Offset: 0x002DDAD0
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316810, RefRangeEnd = 316862, XrefRangeStart = 316810, XrefRangeEnd = 316862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EDoorSide Read___ScheduleOne_Doors_EDoorSideFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Doors_EDoorSideFishNet_Serializing_Generateds_Public_Static_EDoorSide_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B917 RID: 47383 RVA: 0x002DF914 File Offset: 0x002DDB14
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316810, RefRangeEnd = 316862, XrefRangeStart = 316810, XrefRangeEnd = 316862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EVehicleColor Read___ScheduleOne_Vehicles_Modification_EVehicleColorFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Vehicles_Modification_EVehicleColorFishNet_Serializing_Generateds_Public_Static_EVehicleColor_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B918 RID: 47384 RVA: 0x002DF958 File Offset: 0x002DDB58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317420, RefRangeEnd = 317422, XrefRangeStart = 317403, XrefRangeEnd = 317420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ParkData Read___ScheduleOne_Vehicles_ParkDataFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Vehicles_ParkDataFishNet_Serializing_Generateds_Public_Static_ParkData_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParkData>(intPtr3) : null;
		}

		// Token: 0x0600B919 RID: 47385 RVA: 0x002DF99C File Offset: 0x002DDB9C
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316810, RefRangeEnd = 316862, XrefRangeStart = 316810, XrefRangeEnd = 316862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EParkingAlignment Read___ScheduleOne_Vehicles_EParkingAlignmentFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Vehicles_EParkingAlignmentFishNet_Serializing_Generateds_Public_Static_EParkingAlignment_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B91A RID: 47386 RVA: 0x002DF9E0 File Offset: 0x002DDBE0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 317433, RefRangeEnd = 317437, XrefRangeStart = 317422, XrefRangeEnd = 317433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TrashContentData Read___ScheduleOne_Persistence_TrashContentDataFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Persistence_TrashContentDataFishNet_Serializing_Generateds_Public_Static_TrashContentData_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashContentData>(intPtr3) : null;
		}

		// Token: 0x0600B91B RID: 47387 RVA: 0x002DFA24 File Offset: 0x002DDC24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317453, RefRangeEnd = 317454, XrefRangeStart = 317437, XrefRangeEnd = 317453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<int> Method_Public_Static_Il2CppStructArray_1_Int32_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_Il2CppStructArray_1_Int32_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
		}

		// Token: 0x0600B91C RID: 47388 RVA: 0x002DFA68 File Offset: 0x002DDC68
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 317462, RefRangeEnd = 317468, XrefRangeStart = 317454, XrefRangeEnd = 317462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Coordinate Read___ScheduleOne_Tiles_CoordinateFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Tiles_CoordinateFishNet_Serializing_Generateds_Public_Static_Coordinate_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr3) : null;
		}

		// Token: 0x0600B91D RID: 47389 RVA: 0x002DFAAC File Offset: 0x002DDCAC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 317476, RefRangeEnd = 317479, XrefRangeStart = 317468, XrefRangeEnd = 317476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WeedAppearanceSettings Read___ScheduleOne_Product_WeedAppearanceSettingsFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Product_WeedAppearanceSettingsFishNet_Serializing_Generateds_Public_Static_WeedAppearanceSettings_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WeedAppearanceSettings>(intPtr3) : null;
		}

		// Token: 0x0600B91E RID: 47390 RVA: 0x002DFAF0 File Offset: 0x002DDCF0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 317485, RefRangeEnd = 317488, XrefRangeStart = 317479, XrefRangeEnd = 317485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CocaineAppearanceSettings Read___ScheduleOne_Product_CocaineAppearanceSettingsFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Product_CocaineAppearanceSettingsFishNet_Serializing_Generateds_Public_Static_CocaineAppearanceSettings_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CocaineAppearanceSettings>(intPtr3) : null;
		}

		// Token: 0x0600B91F RID: 47391 RVA: 0x002DFB34 File Offset: 0x002DDD34
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 317494, RefRangeEnd = 317497, XrefRangeStart = 317488, XrefRangeEnd = 317494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethAppearanceSettings Read___ScheduleOne_Product_MethAppearanceSettingsFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Product_MethAppearanceSettingsFishNet_Serializing_Generateds_Public_Static_MethAppearanceSettings_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethAppearanceSettings>(intPtr3) : null;
		}

		// Token: 0x0600B920 RID: 47392 RVA: 0x002DFB78 File Offset: 0x002DDD78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317505, RefRangeEnd = 317507, XrefRangeStart = 317497, XrefRangeEnd = 317505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NewMixOperation Read___ScheduleOne_Product_NewMixOperationFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Product_NewMixOperationFishNet_Serializing_Generateds_Public_Static_NewMixOperation_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NewMixOperation>(intPtr3) : null;
		}

		// Token: 0x0600B921 RID: 47393 RVA: 0x002DFBBC File Offset: 0x002DDDBC
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 316810, RefRangeEnd = 316862, XrefRangeStart = 316810, XrefRangeEnd = 316862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Recycler.EState Method_Public_Static_EState_Reader_0(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Method_Public_Static_EState_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B922 RID: 47394 RVA: 0x002DFC00 File Offset: 0x002DDE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317507, XrefRangeEnd = 317521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CoordinateProceduralTilePair Read___ScheduleOne_Tiles_CoordinateProceduralTilePairFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_Tiles_CoordinateProceduralTilePairFishNet_Serializing_Generateds_Public_Static_CoordinateProceduralTilePair_Reader_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new CoordinateProceduralTilePair(pointer);
		}

		// Token: 0x0600B923 RID: 47395 RVA: 0x002DFC3C File Offset: 0x002DDE3C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 317525, RefRangeEnd = 317529, XrefRangeStart = 317521, XrefRangeEnd = 317525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<CoordinateProceduralTilePair> Read___System_Collections_Generic_List(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___System_Collections_Generic_List`1_ScheduleOne_Tiles_CoordinateProceduralTilePair_FishNet_Serializing_Generateds_Public_Static_List_1_CoordinateProceduralTilePair_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<CoordinateProceduralTilePair>>(intPtr3) : null;
		}

		// Token: 0x0600B924 RID: 47396 RVA: 0x002DFC80 File Offset: 0x002DDE80
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 317541, RefRangeEnd = 317544, XrefRangeStart = 317529, XrefRangeEnd = 317541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ChemistryCookOperation Read___ScheduleOne_ObjectScripts_ChemistryCookOperationFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_ObjectScripts_ChemistryCookOperationFishNet_Serializing_Generateds_Public_Static_ChemistryCookOperation_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChemistryCookOperation>(intPtr3) : null;
		}

		// Token: 0x0600B925 RID: 47397 RVA: 0x002DFCC4 File Offset: 0x002DDEC4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 317556, RefRangeEnd = 317559, XrefRangeStart = 317544, XrefRangeEnd = 317556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DryingOperation Read___ScheduleOne_ObjectScripts_DryingOperationFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_ObjectScripts_DryingOperationFishNet_Serializing_Generateds_Public_Static_DryingOperation_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DryingOperation>(intPtr3) : null;
		}

		// Token: 0x0600B926 RID: 47398 RVA: 0x002DFD08 File Offset: 0x002DDF08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 317573, RefRangeEnd = 317576, XrefRangeStart = 317559, XrefRangeEnd = 317573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static OvenCookOperation Read___ScheduleOne_ObjectScripts_OvenCookOperationFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_ObjectScripts_OvenCookOperationFishNet_Serializing_Generateds_Public_Static_OvenCookOperation_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OvenCookOperation>(intPtr3) : null;
		}

		// Token: 0x0600B927 RID: 47399 RVA: 0x002DFD4C File Offset: 0x002DDF4C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 317588, RefRangeEnd = 317593, XrefRangeStart = 317576, XrefRangeEnd = 317588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MixOperation Read___ScheduleOne_ObjectScripts_MixOperationFishNet_Serializing_Generateds(Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedReaders___Internal.NativeMethodInfoPtr_Read___ScheduleOne_ObjectScripts_MixOperationFishNet_Serializing_Generateds_Public_Static_MixOperation_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MixOperation>(intPtr3) : null;
		}

		// Token: 0x0600B928 RID: 47400 RVA: 0x0005A8AB File Offset: 0x00058AAB
		public GeneratedReaders___Internal(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04007C9A RID: 31898
		private static readonly IntPtr NativeMethodInfoPtr_InitializeOnce_Private_Static_Void_0;

		// Token: 0x04007C9B RID: 31899
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Vision_VisionEventReceiptFishNet_Serializing_Generateds_Public_Static_VisionEventReceipt_Reader_0;

		// Token: 0x04007C9C RID: 31900
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_EVisualState_Reader_0;

		// Token: 0x04007C9D RID: 31901
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_EEventLevel_Reader_0;

		// Token: 0x04007C9E RID: 31902
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Quests_ContractInfoFishNet_Serializing_Generateds_Public_Static_ContractInfo_Reader_0;

		// Token: 0x04007C9F RID: 31903
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Product_ProductListFishNet_Serializing_Generateds_Public_Static_ProductList_Reader_0;

		// Token: 0x04007CA0 RID: 31904
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Entry_Reader_PDM_0;

		// Token: 0x04007CA1 RID: 31905
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_ItemFramework_EQualityFishNet_Serializing_Generateds_Public_Static_EQuality_Reader_0;

		// Token: 0x04007CA2 RID: 31906
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_List_1_Entry_Reader_PDM_0;

		// Token: 0x04007CA3 RID: 31907
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Quests_QuestWindowConfigFishNet_Serializing_Generateds_Public_Static_QuestWindowConfig_Reader_0;

		// Token: 0x04007CA4 RID: 31908
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_GameTime_GameDateTimeFishNet_Serializing_Generateds_Public_Static_GameDateTime_Reader_0;

		// Token: 0x04007CA5 RID: 31909
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_EQuestAction_Reader_0;

		// Token: 0x04007CA6 RID: 31910
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Quests_EQuestStateFishNet_Serializing_Generateds_Public_Static_EQuestState_Reader_0;

		// Token: 0x04007CA7 RID: 31911
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Combat_ImpactFishNet_Serializing_Generateds_Public_Static_Impact_Reader_0;

		// Token: 0x04007CA8 RID: 31912
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Combat_EImpactTypeFishNet_Serializing_Generateds_Public_Static_EImpactType_Reader_0;

		// Token: 0x04007CA9 RID: 31913
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Vehicles_LandVehicleFishNet_Serializing_Generateds_Public_Static_LandVehicle_Reader_0;

		// Token: 0x04007CAA RID: 31914
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_ECheckpointLocation_Reader_0;

		// Token: 0x04007CAB RID: 31915
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_PlayerScripts_PlayerFishNet_Serializing_Generateds_Public_Static_Player_Reader_0;

		// Token: 0x04007CAC RID: 31916
		private static readonly IntPtr NativeMethodInfoPtr_Read___System_Collections_Generic_List;

		// Token: 0x04007CAD RID: 31917
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_DevUtilities_StringIntPairFishNet_Serializing_Generateds_Public_Static_StringIntPair_Reader_0;

		// Token: 0x04007CAE RID: 31918
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_StringIntPair_Reader_0;

		// Token: 0x04007CAF RID: 31919
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Messaging_MessageFishNet_Serializing_Generateds_Public_Static_Message_Reader_0;

		// Token: 0x04007CB0 RID: 31920
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_ESenderType_Reader_0;

		// Token: 0x04007CB1 RID: 31921
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_UI_Phone_Messages_MessageChainFishNet_Serializing_Generateds_Public_Static_MessageChain_Reader_0;

		// Token: 0x04007CB2 RID: 31922
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_MSGConversationDataFishNet_Serializing_Generateds_Public_Static_MSGConversationData_Reader_0;

		// Token: 0x04007CB3 RID: 31923
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_TextMessageDataFishNet_Serializing_Generateds_Public_Static_TextMessageData_Reader_0;

		// Token: 0x04007CB4 RID: 31924
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_TextMessageData_Reader_PDM_0;

		// Token: 0x04007CB5 RID: 31925
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_TextResponseDataFishNet_Serializing_Generateds_Public_Static_TextResponseData_Reader_0;

		// Token: 0x04007CB6 RID: 31926
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_TextResponseData_Reader_PDM_0;

		// Token: 0x04007CB7 RID: 31927
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Messaging_ResponseFishNet_Serializing_Generateds_Public_Static_Response_Reader_0;

		// Token: 0x04007CB8 RID: 31928
		private static readonly IntPtr NativeMethodInfoPtr_Read___System_Collections_Generic_List;

		// Token: 0x04007CB9 RID: 31929
		private static readonly IntPtr NativeMethodInfoPtr_Read___System_Collections_Generic_List;

		// Token: 0x04007CBA RID: 31930
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_AdvancedTransitRouteDataFishNet_Serializing_Generateds_Public_Static_AdvancedTransitRouteData_Reader_0;

		// Token: 0x04007CBB RID: 31931
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_EMode_Reader_0;

		// Token: 0x04007CBC RID: 31932
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_AdvancedTransitRouteData_Reader_0;

		// Token: 0x04007CBD RID: 31933
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Levelling_ERankFishNet_Serializing_Generateds_Public_Static_ERank_Reader_0;

		// Token: 0x04007CBE RID: 31934
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Levelling_FullRankFishNet_Serializing_Generateds_Public_Static_FullRank_Reader_0;

		// Token: 0x04007CBF RID: 31935
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_PlayerDataFishNet_Serializing_Generateds_Public_Static_PlayerData_Reader_0;

		// Token: 0x04007CC0 RID: 31936
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_VariableDataFishNet_Serializing_Generateds_Public_Static_VariableData_Reader_0;

		// Token: 0x04007CC1 RID: 31937
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_VariableData_Reader_0;

		// Token: 0x04007CC2 RID: 31938
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_AvatarFramework_AvatarSettingsFishNet_Serializing_Generateds_Public_Static_AvatarSettings_Reader_0;

		// Token: 0x04007CC3 RID: 31939
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_EyeLidConfiguration_Reader_PDM_0;

		// Token: 0x04007CC4 RID: 31940
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_LayerSetting_Reader_PDM_0;

		// Token: 0x04007CC5 RID: 31941
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_List_1_LayerSetting_Reader_PDM_0;

		// Token: 0x04007CC6 RID: 31942
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_AccessorySetting_Reader_PDM_0;

		// Token: 0x04007CC7 RID: 31943
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_List_1_AccessorySetting_Reader_PDM_0;

		// Token: 0x04007CC8 RID: 31944
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_AvatarFramework_Customization_BasicAvatarSettingsFishNet_Serializing_Generateds_Public_Static_BasicAvatarSettings_Reader_0;

		// Token: 0x04007CC9 RID: 31945
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_EPursuitLevel_Reader_0;

		// Token: 0x04007CCA RID: 31946
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Property_PropertyFishNet_Serializing_Generateds_Public_Static_Property_Reader_0;

		// Token: 0x04007CCB RID: 31947
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Employees_EEmployeeTypeFishNet_Serializing_Generateds_Public_Static_EEmployeeType_Reader_0;

		// Token: 0x04007CCC RID: 31948
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Economy_EDealWindowFishNet_Serializing_Generateds_Public_Static_EDealWindow_Reader_0;

		// Token: 0x04007CCD RID: 31949
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_EHandoverOutcome_Reader_0;

		// Token: 0x04007CCE RID: 31950
		private static readonly IntPtr NativeMethodInfoPtr_Read___System_Collections_Generic_List;

		// Token: 0x04007CCF RID: 31951
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_CustomerDataFishNet_Serializing_Generateds_Public_Static_CustomerData_Reader_0;

		// Token: 0x04007CD0 RID: 31952
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Il2CppStringArray_Reader_0;

		// Token: 0x04007CD1 RID: 31953
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Il2CppStructArray_1_Single_Reader_0;

		// Token: 0x04007CD2 RID: 31954
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Product_EDrugTypeFishNet_Serializing_Generateds_Public_Static_EDrugType_Reader_0;

		// Token: 0x04007CD3 RID: 31955
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Persistence_Datas_GameDataFishNet_Serializing_Generateds_Public_Static_GameData_Reader_0;

		// Token: 0x04007CD4 RID: 31956
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_DevUtilities_GameSettingsFishNet_Serializing_Generateds_Public_Static_GameSettings_Reader_0;

		// Token: 0x04007CD5 RID: 31957
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Delivery_DeliveryInstanceFishNet_Serializing_Generateds_Public_Static_DeliveryInstance_Reader_0;

		// Token: 0x04007CD6 RID: 31958
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Delivery_EDeliveryStatusFishNet_Serializing_Generateds_Public_Static_EDeliveryStatus_Reader_0;

		// Token: 0x04007CD7 RID: 31959
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Combat_ExplosionDataFishNet_Serializing_Generateds_Public_Static_ExplosionData_Reader_0;

		// Token: 0x04007CD8 RID: 31960
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_ECardSuit_Reader_0;

		// Token: 0x04007CD9 RID: 31961
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_ECardValue_Reader_0;

		// Token: 0x04007CDA RID: 31962
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Il2CppReferenceArray_1_NetworkObject_Reader_0;

		// Token: 0x04007CDB RID: 31963
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_EStage_Reader_0;

		// Token: 0x04007CDC RID: 31964
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_ESymbol_Reader_0;

		// Token: 0x04007CDD RID: 31965
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Il2CppStructArray_1_ESymbol_Reader_0;

		// Token: 0x04007CDE RID: 31966
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Doors_EDoorSideFishNet_Serializing_Generateds_Public_Static_EDoorSide_Reader_0;

		// Token: 0x04007CDF RID: 31967
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Vehicles_Modification_EVehicleColorFishNet_Serializing_Generateds_Public_Static_EVehicleColor_Reader_0;

		// Token: 0x04007CE0 RID: 31968
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Vehicles_ParkDataFishNet_Serializing_Generateds_Public_Static_ParkData_Reader_0;

		// Token: 0x04007CE1 RID: 31969
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Vehicles_EParkingAlignmentFishNet_Serializing_Generateds_Public_Static_EParkingAlignment_Reader_0;

		// Token: 0x04007CE2 RID: 31970
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Persistence_TrashContentDataFishNet_Serializing_Generateds_Public_Static_TrashContentData_Reader_0;

		// Token: 0x04007CE3 RID: 31971
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Il2CppStructArray_1_Int32_Reader_0;

		// Token: 0x04007CE4 RID: 31972
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Tiles_CoordinateFishNet_Serializing_Generateds_Public_Static_Coordinate_Reader_0;

		// Token: 0x04007CE5 RID: 31973
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Product_WeedAppearanceSettingsFishNet_Serializing_Generateds_Public_Static_WeedAppearanceSettings_Reader_0;

		// Token: 0x04007CE6 RID: 31974
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Product_CocaineAppearanceSettingsFishNet_Serializing_Generateds_Public_Static_CocaineAppearanceSettings_Reader_0;

		// Token: 0x04007CE7 RID: 31975
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Product_MethAppearanceSettingsFishNet_Serializing_Generateds_Public_Static_MethAppearanceSettings_Reader_0;

		// Token: 0x04007CE8 RID: 31976
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Product_NewMixOperationFishNet_Serializing_Generateds_Public_Static_NewMixOperation_Reader_0;

		// Token: 0x04007CE9 RID: 31977
		private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_EState_Reader_0;

		// Token: 0x04007CEA RID: 31978
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_Tiles_CoordinateProceduralTilePairFishNet_Serializing_Generateds_Public_Static_CoordinateProceduralTilePair_Reader_0;

		// Token: 0x04007CEB RID: 31979
		private static readonly IntPtr NativeMethodInfoPtr_Read___System_Collections_Generic_List;

		// Token: 0x04007CEC RID: 31980
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_ObjectScripts_ChemistryCookOperationFishNet_Serializing_Generateds_Public_Static_ChemistryCookOperation_Reader_0;

		// Token: 0x04007CED RID: 31981
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_ObjectScripts_DryingOperationFishNet_Serializing_Generateds_Public_Static_DryingOperation_Reader_0;

		// Token: 0x04007CEE RID: 31982
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_ObjectScripts_OvenCookOperationFishNet_Serializing_Generateds_Public_Static_OvenCookOperation_Reader_0;

		// Token: 0x04007CEF RID: 31983
		private static readonly IntPtr NativeMethodInfoPtr_Read___ScheduleOne_ObjectScripts_MixOperationFishNet_Serializing_Generateds_Public_Static_MixOperation_Reader_0;
	}
}
