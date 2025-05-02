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
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Lighting;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Tiles;
using Il2CppScheduleOne.UI.Management;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000733 RID: 1843
	public class Pot : GridItem
	{
		// Token: 0x0600A783 RID: 42883 RVA: 0x0029DAE4 File Offset: 0x0029BCE4
		// Note: this type is marked as 'beforefieldinit'.
		static Pot()
		{
			Il2CppClassPointerStore<Pot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "Pot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pot>.NativeClassPtr);
			Pot.NativeFieldInfoPtr_DryThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "DryThreshold");
			Pot.NativeFieldInfoPtr_WaterloggedThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "WaterloggedThreshold");
			Pot.NativeFieldInfoPtr_ROTATION_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "ROTATION_SPEED");
			Pot.NativeFieldInfoPtr_MAX_CAMERA_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "MAX_CAMERA_DISTANCE");
			Pot.NativeFieldInfoPtr_MIN_CAMERA_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "MIN_CAMERA_DISTANCE");
			Pot.NativeFieldInfoPtr_ModelTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "ModelTransform");
			Pot.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "IntObj");
			Pot.NativeFieldInfoPtr_PourableStartPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "PourableStartPoint");
			Pot.NativeFieldInfoPtr_SeedStartPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "SeedStartPoint");
			Pot.NativeFieldInfoPtr_SeedRestingPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "SeedRestingPoint");
			Pot.NativeFieldInfoPtr_WaterLoggedVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "WaterLoggedVisuals");
			Pot.NativeFieldInfoPtr_LookAtPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "LookAtPoint");
			Pot.NativeFieldInfoPtr_AdditivesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "AdditivesContainer");
			Pot.NativeFieldInfoPtr_PlantContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "PlantContainer");
			Pot.NativeFieldInfoPtr_IntObjLabel_Low = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "IntObjLabel_Low");
			Pot.NativeFieldInfoPtr_IntObjLabel_High = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "IntObjLabel_High");
			Pot.NativeFieldInfoPtr_uiPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "uiPoint");
			Pot.NativeFieldInfoPtr_configReplicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "configReplicator");
			Pot.NativeFieldInfoPtr_accessPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "accessPoints");
			Pot.NativeFieldInfoPtr_TaskBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "TaskBounds");
			Pot.NativeFieldInfoPtr_SoilCover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "SoilCover");
			Pot.NativeFieldInfoPtr_LeafDropPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "LeafDropPoint");
			Pot.NativeFieldInfoPtr_PoofParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "PoofParticles");
			Pot.NativeFieldInfoPtr_PoofSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "PoofSound");
			Pot.NativeFieldInfoPtr_WaterCanvasContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "WaterCanvasContainer");
			Pot.NativeFieldInfoPtr_WaterLevelCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "WaterLevelCanvas");
			Pot.NativeFieldInfoPtr_WaterLevelCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "WaterLevelCanvasGroup");
			Pot.NativeFieldInfoPtr_WaterLevelSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "WaterLevelSlider");
			Pot.NativeFieldInfoPtr_NoWaterIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "NoWaterIcon");
			Pot.NativeFieldInfoPtr_WorldspaceUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "WorldspaceUIPrefab");
			Pot.NativeFieldInfoPtr_typeIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "typeIcon");
			Pot.NativeFieldInfoPtr_CameraContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "CameraContainer");
			Pot.NativeFieldInfoPtr_MidshotPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "MidshotPosition");
			Pot.NativeFieldInfoPtr_CloseupPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "CloseupPosition");
			Pot.NativeFieldInfoPtr_FullshotPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "FullshotPosition");
			Pot.NativeFieldInfoPtr_BirdsEyePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "BirdsEyePosition");
			Pot.NativeFieldInfoPtr_AutoRotateCameraContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "AutoRotateCameraContainer");
			Pot.NativeFieldInfoPtr_Dirt_Flat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "Dirt_Flat");
			Pot.NativeFieldInfoPtr_Dirt_Parted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "Dirt_Parted");
			Pot.NativeFieldInfoPtr_SoilChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "SoilChunks");
			Pot.NativeFieldInfoPtr_DirtRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "DirtRenderers");
			Pot.NativeFieldInfoPtr_PotRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "PotRadius");
			Pot.NativeFieldInfoPtr_YieldMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "YieldMultiplier");
			Pot.NativeFieldInfoPtr_GrowSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "GrowSpeedMultiplier");
			Pot.NativeFieldInfoPtr_MoistureDrainMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "MoistureDrainMultiplier");
			Pot.NativeFieldInfoPtr_AlignLeafDropToPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "AlignLeafDropToPlayer");
			Pot.NativeFieldInfoPtr_SoilCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "SoilCapacity");
			Pot.NativeFieldInfoPtr_WaterCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "WaterCapacity");
			Pot.NativeFieldInfoPtr_WaterDrainPerHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "WaterDrainPerHour");
			Pot.NativeFieldInfoPtr_DirtMinScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "DirtMinScale");
			Pot.NativeFieldInfoPtr_DirtMaxScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "DirtMaxScale");
			Pot.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "Target");
			Pot.NativeFieldInfoPtr_LightSourceOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "LightSourceOverride");
			Pot.NativeFieldInfoPtr__SoilLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<SoilLevel>k__BackingField");
			Pot.NativeFieldInfoPtr__SoilID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<SoilID>k__BackingField");
			Pot.NativeFieldInfoPtr__RemainingSoilUses_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<RemainingSoilUses>k__BackingField");
			Pot.NativeFieldInfoPtr__WaterLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<WaterLevel>k__BackingField");
			Pot.NativeFieldInfoPtr__Plant_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<Plant>k__BackingField");
			Pot.NativeFieldInfoPtr_AppliedAdditives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "AppliedAdditives");
			Pot.NativeFieldInfoPtr__NPCUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<NPCUserObject>k__BackingField");
			Pot.NativeFieldInfoPtr__PlayerUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<PlayerUserObject>k__BackingField");
			Pot.NativeFieldInfoPtr__potConfiguration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<potConfiguration>k__BackingField");
			Pot.NativeFieldInfoPtr__WorldspaceUI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<WorldspaceUI>k__BackingField");
			Pot.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<CurrentPlayerConfigurer>k__BackingField");
			Pot.NativeFieldInfoPtr__InputSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<InputSlots>k__BackingField");
			Pot.NativeFieldInfoPtr__OutputSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<OutputSlots>k__BackingField");
			Pot.NativeFieldInfoPtr__Selectable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<Selectable>k__BackingField");
			Pot.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<IsAcceptingItems>k__BackingField");
			Pot.NativeFieldInfoPtr_intObjSetThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "intObjSetThisFrame");
			Pot.NativeFieldInfoPtr_outputSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "outputSlot");
			Pot.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "rotation");
			Pot.NativeFieldInfoPtr_rotationOverridden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "rotationOverridden");
			Pot.NativeFieldInfoPtr_appliedSoilDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "appliedSoilDefinition");
			Pot.NativeFieldInfoPtr_syncVar____SoilLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "syncVar___<SoilLevel>k__BackingField");
			Pot.NativeFieldInfoPtr_syncVar____SoilID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "syncVar___<SoilID>k__BackingField");
			Pot.NativeFieldInfoPtr_syncVar____RemainingSoilUses_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "syncVar___<RemainingSoilUses>k__BackingField");
			Pot.NativeFieldInfoPtr_syncVar____WaterLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "syncVar___<WaterLevel>k__BackingField");
			Pot.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "syncVar___<NPCUserObject>k__BackingField");
			Pot.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "syncVar___<PlayerUserObject>k__BackingField");
			Pot.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "syncVar___<CurrentPlayerConfigurer>k__BackingField");
			Pot.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.PotAssembly-CSharp.dll_Excuted");
			Pot.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.PotAssembly-CSharp.dll_Excuted");
			Pot.NativeMethodInfoPtr_get_SoilLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683786);
			Pot.NativeMethodInfoPtr_set_SoilLevel_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683787);
			Pot.NativeMethodInfoPtr_get_SoilID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683788);
			Pot.NativeMethodInfoPtr_set_SoilID_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683789);
			Pot.NativeMethodInfoPtr_get_RemainingSoilUses_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683790);
			Pot.NativeMethodInfoPtr_set_RemainingSoilUses_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683791);
			Pot.NativeMethodInfoPtr_get_WaterLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683792);
			Pot.NativeMethodInfoPtr_set_WaterLevel_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683793);
			Pot.NativeMethodInfoPtr_get_NormalizedWaterLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683794);
			Pot.NativeMethodInfoPtr_get_IsFilledWithSoil_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683795);
			Pot.NativeMethodInfoPtr_get_Plant_Public_get_Plant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683796);
			Pot.NativeMethodInfoPtr_set_Plant_Protected_set_Void_Plant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683797);
			Pot.NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683798);
			Pot.NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683799);
			Pot.NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683800);
			Pot.NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683801);
			Pot.NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683802);
			Pot.NativeMethodInfoPtr_get_potConfiguration_Protected_get_PotConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683803);
			Pot.NativeMethodInfoPtr_set_potConfiguration_Protected_set_Void_PotConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683804);
			Pot.NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683805);
			Pot.NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683806);
			Pot.NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683807);
			Pot.NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683808);
			Pot.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683809);
			Pot.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683810);
			Pot.NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683811);
			Pot.NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683812);
			Pot.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683813);
			Pot.NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683814);
			Pot.NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683815);
			Pot.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683816);
			Pot.NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683817);
			Pot.NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683818);
			Pot.NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683819);
			Pot.NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683820);
			Pot.NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683821);
			Pot.NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683822);
			Pot.NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683823);
			Pot.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683824);
			Pot.NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683825);
			Pot.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683826);
			Pot.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683827);
			Pot.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683828);
			Pot.NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683829);
			Pot.NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683830);
			Pot.NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683831);
			Pot.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683832);
			Pot.NativeMethodInfoPtr_UpdateCanvas_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683833);
			Pot.NativeMethodInfoPtr_OnMinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683834);
			Pot.NativeMethodInfoPtr_TimeSkipped_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683835);
			Pot.NativeMethodInfoPtr_ConfigureInteraction_Public_Void_String_EInteractableState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683836);
			Pot.NativeMethodInfoPtr_PositionCameraContainer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683837);
			Pot.NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683838);
			Pot.NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683839);
			Pot.NativeMethodInfoPtr_ResetPot_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683840);
			Pot.NativeMethodInfoPtr_GetAverageLightExposure_Public_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683841);
			Pot.NativeMethodInfoPtr_CanAcceptSeed_Public_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683842);
			Pot.NativeMethodInfoPtr_IsReadyForHarvest_Public_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683843);
			Pot.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683844);
			Pot.NativeMethodInfoPtr_OverrideRotation_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683845);
			Pot.NativeMethodInfoPtr_GetCameraPosition_Public_Transform_ECameraPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683846);
			Pot.NativeMethodInfoPtr_AddSoil_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683847);
			Pot.NativeMethodInfoPtr_SoilLevelChanged_Private_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683848);
			Pot.NativeMethodInfoPtr_UpdateSoilScale_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683849);
			Pot.NativeMethodInfoPtr_SetSoilID_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683850);
			Pot.NativeMethodInfoPtr_SetSoilUses_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683851);
			Pot.NativeMethodInfoPtr_PushSoilDataToServer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683852);
			Pot.NativeMethodInfoPtr_SendSoilData_Public_Void_String_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683853);
			Pot.NativeMethodInfoPtr_SetSoilState_Public_Void_ESoilState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683854);
			Pot.NativeMethodInfoPtr_UpdateSoilMaterial_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683855);
			Pot.NativeMethodInfoPtr_ChangeWaterAmount_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683856);
			Pot.NativeMethodInfoPtr_PushWaterDataToServer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683857);
			Pot.NativeMethodInfoPtr_SendWaterData_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683858);
			Pot.NativeMethodInfoPtr_WaterLevelChanged_Private_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683859);
			Pot.NativeMethodInfoPtr_SetTargetActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683860);
			Pot.NativeMethodInfoPtr_RandomizeTarget_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683861);
			Pot.NativeMethodInfoPtr_SendAdditive_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683862);
			Pot.NativeMethodInfoPtr_ApplyAdditive_Public_Void_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683863);
			Pot.NativeMethodInfoPtr_GetAdditiveGrowthMultiplier_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683864);
			Pot.NativeMethodInfoPtr_GetNetYieldChange_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683865);
			Pot.NativeMethodInfoPtr_GetNetQualityChange_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683866);
			Pot.NativeMethodInfoPtr_GetAdditive_Public_Additive_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683867);
			Pot.NativeMethodInfoPtr_FullyGrowPlant_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683868);
			Pot.NativeMethodInfoPtr_SendPlantSeed_Public_Void_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683869);
			Pot.NativeMethodInfoPtr_PlantSeed_Public_Void_NetworkConnection_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683870);
			Pot.NativeMethodInfoPtr_SetGrowProgress_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683871);
			Pot.NativeMethodInfoPtr_PlantSeed_Private_Void_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683872);
			Pot.NativeMethodInfoPtr_SetHarvestableActive_Public_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683873);
			Pot.NativeMethodInfoPtr_SetHarvestableActive_Local_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683874);
			Pot.NativeMethodInfoPtr_SendHarvestableActive_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683875);
			Pot.NativeMethodInfoPtr_SendHarvestableActive_Local_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683876);
			Pot.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683877);
			Pot.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683878);
			Pot.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683879);
			Pot.NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683880);
			Pot.NativeMethodInfoPtr_LoadPlant_Public_Virtual_New_Void_PlantData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683881);
			Pot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683882);
			Pot.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683883);
			Pot.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683884);
			Pot.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683885);
			Pot.NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683886);
			Pot.NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683887);
			Pot.NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683888);
			Pot.NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683889);
			Pot.NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683890);
			Pot.NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683891);
			Pot.NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683892);
			Pot.NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683893);
			Pot.NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683894);
			Pot.NativeMethodInfoPtr_RpcWriter___Observers_ResetPot_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683895);
			Pot.NativeMethodInfoPtr_RpcLogic___ResetPot_2166136261_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683896);
			Pot.NativeMethodInfoPtr_RpcReader___Observers_ResetPot_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683897);
			Pot.NativeMethodInfoPtr_RpcWriter___Server_SendSoilData_3104499779_Private_Void_String_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683898);
			Pot.NativeMethodInfoPtr_RpcLogic___SendSoilData_3104499779_Public_Void_String_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683899);
			Pot.NativeMethodInfoPtr_RpcReader___Server_SendSoilData_3104499779_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683900);
			Pot.NativeMethodInfoPtr_RpcWriter___Server_SendWaterData_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683901);
			Pot.NativeMethodInfoPtr_RpcLogic___SendWaterData_431000436_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683902);
			Pot.NativeMethodInfoPtr_RpcReader___Server_SendWaterData_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683903);
			Pot.NativeMethodInfoPtr_RpcWriter___Server_SendAdditive_310431262_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683904);
			Pot.NativeMethodInfoPtr_RpcLogic___SendAdditive_310431262_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683905);
			Pot.NativeMethodInfoPtr_RpcReader___Server_SendAdditive_310431262_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683906);
			Pot.NativeMethodInfoPtr_RpcWriter___Observers_ApplyAdditive_619441887_Private_Void_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683907);
			Pot.NativeMethodInfoPtr_RpcLogic___ApplyAdditive_619441887_Public_Void_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683908);
			Pot.NativeMethodInfoPtr_RpcReader___Observers_ApplyAdditive_619441887_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683909);
			Pot.NativeMethodInfoPtr_RpcWriter___Target_ApplyAdditive_619441887_Private_Void_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683910);
			Pot.NativeMethodInfoPtr_RpcReader___Target_ApplyAdditive_619441887_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683911);
			Pot.NativeMethodInfoPtr_RpcWriter___Observers_FullyGrowPlant_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683912);
			Pot.NativeMethodInfoPtr_RpcLogic___FullyGrowPlant_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683913);
			Pot.NativeMethodInfoPtr_RpcReader___Observers_FullyGrowPlant_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683914);
			Pot.NativeMethodInfoPtr_RpcWriter___Server_SendPlantSeed_2530605204_Private_Void_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683915);
			Pot.NativeMethodInfoPtr_RpcLogic___SendPlantSeed_2530605204_Public_Void_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683916);
			Pot.NativeMethodInfoPtr_RpcReader___Server_SendPlantSeed_2530605204_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683917);
			Pot.NativeMethodInfoPtr_RpcWriter___Observers_PlantSeed_709433087_Private_Void_NetworkConnection_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683918);
			Pot.NativeMethodInfoPtr_RpcLogic___PlantSeed_709433087_Public_Void_NetworkConnection_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683919);
			Pot.NativeMethodInfoPtr_RpcReader___Observers_PlantSeed_709433087_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683920);
			Pot.NativeMethodInfoPtr_RpcWriter___Target_PlantSeed_709433087_Private_Void_NetworkConnection_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683921);
			Pot.NativeMethodInfoPtr_RpcReader___Target_PlantSeed_709433087_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683922);
			Pot.NativeMethodInfoPtr_RpcWriter___Observers_SetGrowProgress_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683923);
			Pot.NativeMethodInfoPtr_RpcLogic___SetGrowProgress_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683924);
			Pot.NativeMethodInfoPtr_RpcReader___Observers_SetGrowProgress_431000436_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683925);
			Pot.NativeMethodInfoPtr_RpcWriter___Observers_SetHarvestableActive_338960014_Private_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683926);
			Pot.NativeMethodInfoPtr_RpcLogic___SetHarvestableActive_338960014_Public_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683927);
			Pot.NativeMethodInfoPtr_RpcReader___Observers_SetHarvestableActive_338960014_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683928);
			Pot.NativeMethodInfoPtr_RpcWriter___Target_SetHarvestableActive_338960014_Private_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683929);
			Pot.NativeMethodInfoPtr_RpcReader___Target_SetHarvestableActive_338960014_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683930);
			Pot.NativeMethodInfoPtr_RpcWriter___Server_SendHarvestableActive_3658436649_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683931);
			Pot.NativeMethodInfoPtr_RpcLogic___SendHarvestableActive_3658436649_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683932);
			Pot.NativeMethodInfoPtr_RpcReader___Server_SendHarvestableActive_3658436649_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683933);
			Pot.NativeMethodInfoPtr_sync___get_value__SoilLevel_k__BackingField_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683934);
			Pot.NativeMethodInfoPtr_sync___set_value__SoilLevel_k__BackingField_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683935);
			Pot.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ObjectScripts_Pot_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683936);
			Pot.NativeMethodInfoPtr_sync___get_value__SoilID_k__BackingField_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683937);
			Pot.NativeMethodInfoPtr_sync___set_value__SoilID_k__BackingField_Public_set_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683938);
			Pot.NativeMethodInfoPtr_sync___get_value__RemainingSoilUses_k__BackingField_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683939);
			Pot.NativeMethodInfoPtr_sync___set_value__RemainingSoilUses_k__BackingField_Public_set_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683940);
			Pot.NativeMethodInfoPtr_sync___get_value__WaterLevel_k__BackingField_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683941);
			Pot.NativeMethodInfoPtr_sync___set_value__WaterLevel_k__BackingField_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683942);
			Pot.NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683943);
			Pot.NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683944);
			Pot.NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683945);
			Pot.NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683946);
			Pot.NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683947);
			Pot.NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683948);
			Pot.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100683949);
		}

		// Token: 0x17003402 RID: 13314
		// (get) Token: 0x0600A784 RID: 42884 RVA: 0x0029EE4C File Offset: 0x0029D04C
		// (set) Token: 0x0600A785 RID: 42885 RVA: 0x0029EE88 File Offset: 0x0029D088
		public unsafe float SoilLevel
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 217558, RefRangeEnd = 217563, XrefRangeStart = 217558, XrefRangeEnd = 217563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_SoilLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 291888, RefRangeEnd = 291892, XrefRangeStart = 291881, XrefRangeEnd = 291888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_SoilLevel_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003403 RID: 13315
		// (get) Token: 0x0600A786 RID: 42886 RVA: 0x0029EEC8 File Offset: 0x0029D0C8
		// (set) Token: 0x0600A787 RID: 42887 RVA: 0x0029EF00 File Offset: 0x0029D100
		public unsafe string SoilID
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 186207, RefRangeEnd = 186215, XrefRangeStart = 186207, XrefRangeEnd = 186215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_SoilID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 291900, RefRangeEnd = 291904, XrefRangeStart = 291892, XrefRangeEnd = 291900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_SoilID_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003404 RID: 13316
		// (get) Token: 0x0600A788 RID: 42888 RVA: 0x0029EF44 File Offset: 0x0029D144
		// (set) Token: 0x0600A789 RID: 42889 RVA: 0x0029EF80 File Offset: 0x0029D180
		public unsafe int RemainingSoilUses
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_RemainingSoilUses_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 291911, RefRangeEnd = 291915, XrefRangeStart = 291904, XrefRangeEnd = 291911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_RemainingSoilUses_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003405 RID: 13317
		// (get) Token: 0x0600A78A RID: 42890 RVA: 0x0029EFC0 File Offset: 0x0029D1C0
		// (set) Token: 0x0600A78B RID: 42891 RVA: 0x0029EFFC File Offset: 0x0029D1FC
		public unsafe float WaterLevel
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 94037, RefRangeEnd = 94039, XrefRangeStart = 94037, XrefRangeEnd = 94039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_WaterLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 291922, RefRangeEnd = 291928, XrefRangeStart = 291915, XrefRangeEnd = 291922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_WaterLevel_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003406 RID: 13318
		// (get) Token: 0x0600A78C RID: 42892 RVA: 0x0029F03C File Offset: 0x0029D23C
		public unsafe float NormalizedWaterLevel
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 291928, RefRangeEnd = 291936, XrefRangeStart = 291928, XrefRangeEnd = 291928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_NormalizedWaterLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003407 RID: 13319
		// (get) Token: 0x0600A78D RID: 42893 RVA: 0x0029F078 File Offset: 0x0029D278
		public unsafe bool IsFilledWithSoil
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 291936, RefRangeEnd = 291944, XrefRangeStart = 291936, XrefRangeEnd = 291936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_IsFilledWithSoil_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003408 RID: 13320
		// (get) Token: 0x0600A78E RID: 42894 RVA: 0x0029F0B4 File Offset: 0x0029D2B4
		// (set) Token: 0x0600A78F RID: 42895 RVA: 0x0029F0F4 File Offset: 0x0029D2F4
		public unsafe Plant Plant
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 184208, RefRangeEnd = 184212, XrefRangeStart = 184208, XrefRangeEnd = 184212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_Plant_Public_get_Plant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Plant>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_Plant_Protected_set_Void_Plant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003409 RID: 13321
		// (get) Token: 0x0600A790 RID: 42896 RVA: 0x0029F138 File Offset: 0x0029D338
		// (set) Token: 0x0600A791 RID: 42897 RVA: 0x0029F178 File Offset: 0x0029D378
		public unsafe virtual NetworkObject NPCUserObject
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 183530, RefRangeEnd = 183533, XrefRangeStart = 183530, XrefRangeEnd = 183533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 291952, RefRangeEnd = 291954, XrefRangeStart = 291944, XrefRangeEnd = 291952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700340A RID: 13322
		// (get) Token: 0x0600A792 RID: 42898 RVA: 0x0029F1BC File Offset: 0x0029D3BC
		// (set) Token: 0x0600A793 RID: 42899 RVA: 0x0029F1FC File Offset: 0x0029D3FC
		public unsafe virtual NetworkObject PlayerUserObject
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 184821, RefRangeEnd = 184823, XrefRangeStart = 184821, XrefRangeEnd = 184823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291954, XrefRangeEnd = 291962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700340B RID: 13323
		// (get) Token: 0x0600A794 RID: 42900 RVA: 0x0029F240 File Offset: 0x0029D440
		public unsafe virtual EntityConfiguration Configuration
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 291962, RefRangeEnd = 291984, XrefRangeStart = 291962, XrefRangeEnd = 291962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityConfiguration>(intPtr3) : null;
			}
		}

		// Token: 0x1700340C RID: 13324
		// (get) Token: 0x0600A795 RID: 42901 RVA: 0x0029F280 File Offset: 0x0029D480
		// (set) Token: 0x0600A796 RID: 42902 RVA: 0x0029F2C0 File Offset: 0x0029D4C0
		public unsafe PotConfiguration potConfiguration
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 291962, RefRangeEnd = 291984, XrefRangeStart = 291962, XrefRangeEnd = 291984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_potConfiguration_Protected_get_PotConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PotConfiguration>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291984, XrefRangeEnd = 291985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_potConfiguration_Protected_set_Void_PotConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700340D RID: 13325
		// (get) Token: 0x0600A797 RID: 42903 RVA: 0x0029F304 File Offset: 0x0029D504
		public unsafe virtual ConfigurationReplicator ConfigReplicator
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 166536, RefRangeEnd = 166543, XrefRangeStart = 166536, XrefRangeEnd = 166543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr3) : null;
			}
		}

		// Token: 0x1700340E RID: 13326
		// (get) Token: 0x0600A798 RID: 42904 RVA: 0x0029F344 File Offset: 0x0029D544
		public unsafe virtual EConfigurableType ConfigurableType
		{
			[CallerCount(65)]
			[CachedScanResults(RefRangeStart = 31227, RefRangeEnd = 31292, XrefRangeStart = 31227, XrefRangeEnd = 31292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700340F RID: 13327
		// (get) Token: 0x0600A799 RID: 42905 RVA: 0x0029F380 File Offset: 0x0029D580
		// (set) Token: 0x0600A79A RID: 42906 RVA: 0x0029F3C0 File Offset: 0x0029D5C0
		public unsafe virtual WorldspaceUIElement WorldspaceUI
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 291985, RefRangeEnd = 291995, XrefRangeStart = 291985, XrefRangeEnd = 291985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291995, XrefRangeEnd = 291996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003410 RID: 13328
		// (get) Token: 0x0600A79B RID: 42907 RVA: 0x0029F404 File Offset: 0x0029D604
		// (set) Token: 0x0600A79C RID: 42908 RVA: 0x0029F444 File Offset: 0x0029D644
		public unsafe virtual NetworkObject CurrentPlayerConfigurer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 292004, RefRangeEnd = 292006, XrefRangeStart = 291996, XrefRangeEnd = 292004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A79D RID: 42909 RVA: 0x0029F488 File Offset: 0x0029D688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292006, XrefRangeEnd = 292028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetConfigurer(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17003411 RID: 13329
		// (get) Token: 0x0600A79E RID: 42910 RVA: 0x0029F4CC File Offset: 0x0029D6CC
		public unsafe virtual Sprite TypeIcon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x17003412 RID: 13330
		// (get) Token: 0x0600A79F RID: 42911 RVA: 0x0029F50C File Offset: 0x0029D70C
		public unsafe virtual Transform Transform
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 48833, RefRangeEnd = 48835, XrefRangeStart = 48833, XrefRangeEnd = 48835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17003413 RID: 13331
		// (get) Token: 0x0600A7A0 RID: 42912 RVA: 0x0029F54C File Offset: 0x0029D74C
		public unsafe virtual Transform UIPoint
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 166534, RefRangeEnd = 166535, XrefRangeStart = 166534, XrefRangeEnd = 166535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17003414 RID: 13332
		// (get) Token: 0x0600A7A1 RID: 42913 RVA: 0x0029F58C File Offset: 0x0029D78C
		public unsafe virtual bool CanBeSelected
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30138, RefRangeEnd = 30158, XrefRangeStart = 30138, XrefRangeEnd = 30158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003415 RID: 13333
		// (get) Token: 0x0600A7A2 RID: 42914 RVA: 0x0029F5C8 File Offset: 0x0029D7C8
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17003416 RID: 13334
		// (get) Token: 0x0600A7A3 RID: 42915 RVA: 0x0029F600 File Offset: 0x0029D800
		// (set) Token: 0x0600A7A4 RID: 42916 RVA: 0x0029F640 File Offset: 0x0029D840
		public unsafe virtual List<ItemSlot> InputSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292028, XrefRangeEnd = 292029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003417 RID: 13335
		// (get) Token: 0x0600A7A5 RID: 42917 RVA: 0x0029F684 File Offset: 0x0029D884
		// (set) Token: 0x0600A7A6 RID: 42918 RVA: 0x0029F6C4 File Offset: 0x0029D8C4
		public unsafe virtual List<ItemSlot> OutputSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292029, XrefRangeEnd = 292030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003418 RID: 13336
		// (get) Token: 0x0600A7A7 RID: 42919 RVA: 0x0029F708 File Offset: 0x0029D908
		public unsafe virtual Transform LinkOrigin
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 166534, RefRangeEnd = 166535, XrefRangeStart = 166534, XrefRangeEnd = 166535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17003419 RID: 13337
		// (get) Token: 0x0600A7A8 RID: 42920 RVA: 0x0029F748 File Offset: 0x0029D948
		public unsafe virtual Il2CppReferenceArray<Transform> AccessPoints
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 166544, RefRangeEnd = 166559, XrefRangeStart = 166544, XrefRangeEnd = 166559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr3) : null;
			}
		}

		// Token: 0x1700341A RID: 13338
		// (get) Token: 0x0600A7A9 RID: 42921 RVA: 0x0029F788 File Offset: 0x0029D988
		public unsafe virtual bool Selectable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700341B RID: 13339
		// (get) Token: 0x0600A7AA RID: 42922 RVA: 0x0029F7C4 File Offset: 0x0029D9C4
		// (set) Token: 0x0600A7AB RID: 42923 RVA: 0x0029F800 File Offset: 0x0029DA00
		public unsafe virtual bool IsAcceptingItems
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A7AC RID: 42924 RVA: 0x0029F840 File Offset: 0x0029DA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292030, XrefRangeEnd = 292036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7AD RID: 42925 RVA: 0x0029F87C File Offset: 0x0029DA7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292036, XrefRangeEnd = 292047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7AE RID: 42926 RVA: 0x0029F8B8 File Offset: 0x0029DAB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292047, XrefRangeEnd = 292091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7AF RID: 42927 RVA: 0x0029F908 File Offset: 0x0029DB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292091, XrefRangeEnd = 292108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendConfigurationToClient(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7B0 RID: 42928 RVA: 0x0029F94C File Offset: 0x0029DB4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292108, XrefRangeEnd = 292153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7B1 RID: 42929 RVA: 0x0029F9DC File Offset: 0x0029DBDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292153, XrefRangeEnd = 292199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DestroyItem(bool callOnServer = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref callOnServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7B2 RID: 42930 RVA: 0x0029FA28 File Offset: 0x0029DC28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292199, XrefRangeEnd = 292234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7B3 RID: 42931 RVA: 0x0029FA64 File Offset: 0x0029DC64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292293, RefRangeEnd = 292294, XrefRangeStart = 292234, XrefRangeEnd = 292293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCanvas()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_UpdateCanvas_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7B4 RID: 42932 RVA: 0x0029FA98 File Offset: 0x0029DC98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292294, XrefRangeEnd = 292300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_OnMinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7B5 RID: 42933 RVA: 0x0029FACC File Offset: 0x0029DCCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292300, XrefRangeEnd = 292321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TimeSkipped(int minsSkippped)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minsSkippped;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_TimeSkipped_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7B6 RID: 42934 RVA: 0x0029FB0C File Offset: 0x0029DD0C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 292325, RefRangeEnd = 292333, XrefRangeStart = 292321, XrefRangeEnd = 292325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureInteraction(string message, InteractableObject.EInteractableState state, bool useHighLabelPos = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useHighLabelPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_ConfigureInteraction_Public_Void_String_EInteractableState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7B7 RID: 42935 RVA: 0x0029FB6C File Offset: 0x0029DD6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 292355, RefRangeEnd = 292358, XrefRangeStart = 292333, XrefRangeEnd = 292355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PositionCameraContainer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_PositionCameraContainer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7B8 RID: 42936 RVA: 0x0029FBA0 File Offset: 0x0029DDA0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 292380, RefRangeEnd = 292386, XrefRangeStart = 292358, XrefRangeEnd = 292380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetPlayerUser(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7B9 RID: 42937 RVA: 0x0029FBE4 File Offset: 0x0029DDE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 292408, RefRangeEnd = 292410, XrefRangeStart = 292386, XrefRangeEnd = 292408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetNPCUser(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7BA RID: 42938 RVA: 0x0029FC28 File Offset: 0x0029DE28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292410, XrefRangeEnd = 292431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ResetPot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_ResetPot_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7BB RID: 42939 RVA: 0x0029FC64 File Offset: 0x0029DE64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292442, RefRangeEnd = 292443, XrefRangeStart = 292431, XrefRangeEnd = 292442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAverageLightExposure(out float growSpeedMultiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &growSpeedMultiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_GetAverageLightExposure_Public_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A7BC RID: 42940 RVA: 0x0029FCB0 File Offset: 0x0029DEB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292453, RefRangeEnd = 292454, XrefRangeStart = 292443, XrefRangeEnd = 292453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanAcceptSeed(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_CanAcceptSeed_Public_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600A7BD RID: 42941 RVA: 0x0029FD08 File Offset: 0x0029DF08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 292464, RefRangeEnd = 292466, XrefRangeStart = 292454, XrefRangeEnd = 292464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsReadyForHarvest(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_IsReadyForHarvest_Public_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600A7BE RID: 42942 RVA: 0x0029FD60 File Offset: 0x0029DF60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292466, XrefRangeEnd = 292482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBeDestroyed(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600A7BF RID: 42943 RVA: 0x0029FDC4 File Offset: 0x0029DFC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292482, RefRangeEnd = 292483, XrefRangeStart = 292482, XrefRangeEnd = 292482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideRotation(float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_OverrideRotation_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7C0 RID: 42944 RVA: 0x0029FE04 File Offset: 0x0029E004
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292483, RefRangeEnd = 292484, XrefRangeStart = 292483, XrefRangeEnd = 292483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetCameraPosition(Pot.ECameraPosition pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_GetCameraPosition_Public_Transform_ECameraPosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x0600A7C1 RID: 42945 RVA: 0x0029FE50 File Offset: 0x0029E050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292484, XrefRangeEnd = 292486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddSoil(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_AddSoil_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7C2 RID: 42946 RVA: 0x0029FE9C File Offset: 0x0029E09C
		[CallerCount(0)]
		public unsafe void SoilLevelChanged(float _prev, float _new, bool asServer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _prev;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _new;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref asServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SoilLevelChanged_Private_Void_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7C3 RID: 42947 RVA: 0x0029FEF8 File Offset: 0x0029E0F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292486, XrefRangeEnd = 292488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateSoilScale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_UpdateSoilScale_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7C4 RID: 42948 RVA: 0x0029FF34 File Offset: 0x0029E134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292488, XrefRangeEnd = 292497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetSoilID(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_SetSoilID_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7C5 RID: 42949 RVA: 0x0029FF84 File Offset: 0x0029E184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292497, XrefRangeEnd = 292498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetSoilUses(int uses)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref uses;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_SetSoilUses_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7C6 RID: 42950 RVA: 0x0029FFD0 File Offset: 0x0029E1D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 292511, RefRangeEnd = 292513, XrefRangeStart = 292498, XrefRangeEnd = 292511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushSoilDataToServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_PushSoilDataToServer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7C7 RID: 42951 RVA: 0x002A0004 File Offset: 0x0029E204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292513, XrefRangeEnd = 292526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendSoilData(string soilID, float soilLevel, int soilUses)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(soilID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref soilLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref soilUses;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SendSoilData_Public_Void_String_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7C8 RID: 42952 RVA: 0x002A0064 File Offset: 0x0029E264
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 292534, RefRangeEnd = 292540, XrefRangeStart = 292526, XrefRangeEnd = 292534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSoilState(Pot.ESoilState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SetSoilState_Public_Void_ESoilState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7C9 RID: 42953 RVA: 0x002A00A4 File Offset: 0x0029E2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292540, XrefRangeEnd = 292567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateSoilMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_UpdateSoilMaterial_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7CA RID: 42954 RVA: 0x002A00E0 File Offset: 0x0029E2E0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 292572, RefRangeEnd = 292577, XrefRangeStart = 292567, XrefRangeEnd = 292572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeWaterAmount(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_ChangeWaterAmount_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7CB RID: 42955 RVA: 0x002A0120 File Offset: 0x0029E320
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 292596, RefRangeEnd = 292598, XrefRangeStart = 292577, XrefRangeEnd = 292596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushWaterDataToServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_PushWaterDataToServer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7CC RID: 42956 RVA: 0x002A0154 File Offset: 0x0029E354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292598, XrefRangeEnd = 292617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendWaterData(float waterLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref waterLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SendWaterData_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7CD RID: 42957 RVA: 0x002A0194 File Offset: 0x0029E394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292617, XrefRangeEnd = 292620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WaterLevelChanged(float _prev, float _new, bool asServer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _prev;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _new;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref asServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_WaterLevelChanged_Private_Void_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7CE RID: 42958 RVA: 0x002A01F0 File Offset: 0x0029E3F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 292623, RefRangeEnd = 292627, XrefRangeStart = 292620, XrefRangeEnd = 292623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SetTargetActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7CF RID: 42959 RVA: 0x002A0230 File Offset: 0x0029E430
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 292638, RefRangeEnd = 292642, XrefRangeStart = 292627, XrefRangeEnd = 292638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RandomizeTarget_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7D0 RID: 42960 RVA: 0x002A0264 File Offset: 0x0029E464
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292664, RefRangeEnd = 292665, XrefRangeStart = 292642, XrefRangeEnd = 292664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendAdditive(string additiveAssetPath, bool initial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(additiveAssetPath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initial;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SendAdditive_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7D1 RID: 42961 RVA: 0x002A02B4 File Offset: 0x0029E4B4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 292709, RefRangeEnd = 292715, XrefRangeStart = 292665, XrefRangeEnd = 292709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyAdditive(NetworkConnection conn, string additiveAssetPath, bool initial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(additiveAssetPath);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initial;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_ApplyAdditive_Public_Void_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7D2 RID: 42962 RVA: 0x002A0318 File Offset: 0x0029E518
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292729, RefRangeEnd = 292730, XrefRangeStart = 292715, XrefRangeEnd = 292729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAdditiveGrowthMultiplier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_GetAdditiveGrowthMultiplier_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A7D3 RID: 42963 RVA: 0x002A0354 File Offset: 0x0029E554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292730, XrefRangeEnd = 292744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetNetYieldChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_GetNetYieldChange_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A7D4 RID: 42964 RVA: 0x002A0390 File Offset: 0x0029E590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292744, XrefRangeEnd = 292758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetNetQualityChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_GetNetQualityChange_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A7D5 RID: 42965 RVA: 0x002A03CC File Offset: 0x0029E5CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 292773, RefRangeEnd = 292775, XrefRangeStart = 292758, XrefRangeEnd = 292773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Additive GetAdditive(string additiveName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(additiveName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_GetAdditive_Public_Additive_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Additive>(intPtr3) : null;
		}

		// Token: 0x0600A7D6 RID: 42966 RVA: 0x002A041C File Offset: 0x0029E61C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292796, RefRangeEnd = 292797, XrefRangeStart = 292775, XrefRangeEnd = 292796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FullyGrowPlant()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_FullyGrowPlant_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7D7 RID: 42967 RVA: 0x002A0450 File Offset: 0x0029E650
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292821, RefRangeEnd = 292822, XrefRangeStart = 292797, XrefRangeEnd = 292821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPlantSeed(string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(seedID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalizedSeedProgress;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yieldLevel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref qualityLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SendPlantSeed_Public_Void_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7D8 RID: 42968 RVA: 0x002A04BC File Offset: 0x0029E6BC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 292870, RefRangeEnd = 292876, XrefRangeStart = 292822, XrefRangeEnd = 292870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlantSeed(NetworkConnection conn, string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(seedID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalizedSeedProgress;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yieldLevel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref qualityLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_PlantSeed_Public_Void_NetworkConnection_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7D9 RID: 42969 RVA: 0x002A053C File Offset: 0x0029E73C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292876, XrefRangeEnd = 292895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGrowProgress(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SetGrowProgress_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7DA RID: 42970 RVA: 0x002A057C File Offset: 0x0029E77C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 292931, RefRangeEnd = 292935, XrefRangeStart = 292895, XrefRangeEnd = 292931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlantSeed(string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(seedID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalizedSeedProgress;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yieldLevel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref qualityLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_PlantSeed_Private_Void_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7DB RID: 42971 RVA: 0x002A05E8 File Offset: 0x0029E7E8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 292981, RefRangeEnd = 292985, XrefRangeStart = 292935, XrefRangeEnd = 292981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHarvestableActive(NetworkConnection conn, int harvestableIndex, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref harvestableIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SetHarvestableActive_Public_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7DC RID: 42972 RVA: 0x002A0648 File Offset: 0x0029E848
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 293017, RefRangeEnd = 293022, XrefRangeStart = 292985, XrefRangeEnd = 293017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHarvestableActive_Local(int harvestableIndex, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref harvestableIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SetHarvestableActive_Local_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7DD RID: 42973 RVA: 0x002A0694 File Offset: 0x0029E894
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 293045, RefRangeEnd = 293047, XrefRangeStart = 293022, XrefRangeEnd = 293045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendHarvestableActive(int harvestableIndex, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref harvestableIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SendHarvestableActive_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7DE RID: 42974 RVA: 0x002A06E0 File Offset: 0x0029E8E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293047, XrefRangeEnd = 293048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendHarvestableActive_Local(int harvestableIndex, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref harvestableIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SendHarvestableActive_Local_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7DF RID: 42975 RVA: 0x002A072C File Offset: 0x0029E92C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 293075, RefRangeEnd = 293076, XrefRangeStart = 293048, XrefRangeEnd = 293075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual WorldspaceUIElement CreateWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr3) : null;
		}

		// Token: 0x0600A7E0 RID: 42976 RVA: 0x002A076C File Offset: 0x0029E96C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293076, XrefRangeEnd = 293080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7E1 RID: 42977 RVA: 0x002A07A0 File Offset: 0x0029E9A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293080, XrefRangeEnd = 293111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600A7E2 RID: 42978 RVA: 0x002A07E4 File Offset: 0x0029E9E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293111, XrefRangeEnd = 293133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x0600A7E3 RID: 42979 RVA: 0x002A0840 File Offset: 0x0029EA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293133, XrefRangeEnd = 293146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LoadPlant(PlantData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_LoadPlant_Public_Virtual_New_Void_PlantData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7E4 RID: 42980 RVA: 0x002A0890 File Offset: 0x0029EA90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293146, XrefRangeEnd = 293178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7E5 RID: 42981 RVA: 0x002A08CC File Offset: 0x0029EACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293178, XrefRangeEnd = 293363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7E6 RID: 42982 RVA: 0x002A0908 File Offset: 0x0029EB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293363, XrefRangeEnd = 293364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7E7 RID: 42983 RVA: 0x002A0944 File Offset: 0x0029EB44
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7E8 RID: 42984 RVA: 0x002A0980 File Offset: 0x0029EB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293364, XrefRangeEnd = 293383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7E9 RID: 42985 RVA: 0x002A09C4 File Offset: 0x0029EBC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 292004, RefRangeEnd = 292006, XrefRangeStart = 292004, XrefRangeEnd = 292006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7EA RID: 42986 RVA: 0x002A0A08 File Offset: 0x0029EC08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293383, XrefRangeEnd = 293387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7EB RID: 42987 RVA: 0x002A0A6C File Offset: 0x0029EC6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293387, XrefRangeEnd = 293406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7EC RID: 42988 RVA: 0x002A0AB0 File Offset: 0x0029ECB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 293430, RefRangeEnd = 293432, XrefRangeStart = 293406, XrefRangeEnd = 293430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7ED RID: 42989 RVA: 0x002A0AF4 File Offset: 0x0029ECF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293432, XrefRangeEnd = 293436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7EE RID: 42990 RVA: 0x002A0B58 File Offset: 0x0029ED58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293436, XrefRangeEnd = 293455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7EF RID: 42991 RVA: 0x002A0B9C File Offset: 0x0029ED9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 291952, RefRangeEnd = 291954, XrefRangeStart = 291952, XrefRangeEnd = 291954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7F0 RID: 42992 RVA: 0x002A0BE0 File Offset: 0x0029EDE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293455, XrefRangeEnd = 293459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7F1 RID: 42993 RVA: 0x002A0C44 File Offset: 0x0029EE44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293459, XrefRangeEnd = 293477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ResetPot_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Observers_ResetPot_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7F2 RID: 42994 RVA: 0x002A0C78 File Offset: 0x0029EE78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 293518, RefRangeEnd = 293520, XrefRangeStart = 293477, XrefRangeEnd = 293518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___ResetPot_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_RpcLogic___ResetPot_2166136261_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7F3 RID: 42995 RVA: 0x002A0CB4 File Offset: 0x0029EEB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293520, XrefRangeEnd = 293523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ResetPot_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Observers_ResetPot_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7F4 RID: 42996 RVA: 0x002A0D04 File Offset: 0x0029EF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendSoilData_3104499779(string soilID, float soilLevel, int soilUses)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(soilID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref soilLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref soilUses;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Server_SendSoilData_3104499779_Private_Void_String_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7F5 RID: 42997 RVA: 0x002A0D64 File Offset: 0x0029EF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293523, XrefRangeEnd = 293537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendSoilData_3104499779(string soilID, float soilLevel, int soilUses)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(soilID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref soilLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref soilUses;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___SendSoilData_3104499779_Public_Void_String_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7F6 RID: 42998 RVA: 0x002A0DC4 File Offset: 0x0029EFC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293537, XrefRangeEnd = 293556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendSoilData_3104499779(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Server_SendSoilData_3104499779_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7F7 RID: 42999 RVA: 0x002A0E28 File Offset: 0x0029F028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendWaterData_431000436(float waterLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref waterLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Server_SendWaterData_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7F8 RID: 43000 RVA: 0x002A0E68 File Offset: 0x0029F068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293556, XrefRangeEnd = 293557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendWaterData_431000436(float waterLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref waterLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___SendWaterData_431000436_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7F9 RID: 43001 RVA: 0x002A0EA8 File Offset: 0x0029F0A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293557, XrefRangeEnd = 293560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendWaterData_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Server_SendWaterData_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7FA RID: 43002 RVA: 0x002A0F0C File Offset: 0x0029F10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293560, XrefRangeEnd = 293580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendAdditive_310431262(string additiveAssetPath, bool initial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(additiveAssetPath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initial;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Server_SendAdditive_310431262_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7FB RID: 43003 RVA: 0x002A0F5C File Offset: 0x0029F15C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293580, XrefRangeEnd = 293581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendAdditive_310431262(string additiveAssetPath, bool initial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(additiveAssetPath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initial;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___SendAdditive_310431262_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7FC RID: 43004 RVA: 0x002A0FAC File Offset: 0x0029F1AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293581, XrefRangeEnd = 293585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendAdditive_310431262(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Server_SendAdditive_310431262_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7FD RID: 43005 RVA: 0x002A1010 File Offset: 0x0029F210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293585, XrefRangeEnd = 293605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ApplyAdditive_619441887(NetworkConnection conn, string additiveAssetPath, bool initial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(additiveAssetPath);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initial;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Observers_ApplyAdditive_619441887_Private_Void_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7FE RID: 43006 RVA: 0x002A1074 File Offset: 0x0029F274
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 293653, RefRangeEnd = 293656, XrefRangeStart = 293605, XrefRangeEnd = 293653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ApplyAdditive_619441887(NetworkConnection conn, string additiveAssetPath, bool initial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(additiveAssetPath);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initial;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___ApplyAdditive_619441887_Public_Void_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A7FF RID: 43007 RVA: 0x002A10D8 File Offset: 0x0029F2D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293656, XrefRangeEnd = 293660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ApplyAdditive_619441887(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Observers_ApplyAdditive_619441887_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A800 RID: 43008 RVA: 0x002A1128 File Offset: 0x0029F328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293660, XrefRangeEnd = 293671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ApplyAdditive_619441887(NetworkConnection conn, string additiveAssetPath, bool initial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(additiveAssetPath);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initial;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Target_ApplyAdditive_619441887_Private_Void_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A801 RID: 43009 RVA: 0x002A118C File Offset: 0x0029F38C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293671, XrefRangeEnd = 293675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ApplyAdditive_619441887(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Target_ApplyAdditive_619441887_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A802 RID: 43010 RVA: 0x002A11DC File Offset: 0x0029F3DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293675, XrefRangeEnd = 293693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_FullyGrowPlant_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Observers_FullyGrowPlant_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A803 RID: 43011 RVA: 0x002A1210 File Offset: 0x0029F410
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 293704, RefRangeEnd = 293706, XrefRangeStart = 293693, XrefRangeEnd = 293704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___FullyGrowPlant_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___FullyGrowPlant_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A804 RID: 43012 RVA: 0x002A1244 File Offset: 0x0029F444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293706, XrefRangeEnd = 293709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_FullyGrowPlant_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Observers_FullyGrowPlant_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A805 RID: 43013 RVA: 0x002A1294 File Offset: 0x0029F494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293709, XrefRangeEnd = 293722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendPlantSeed_2530605204(string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(seedID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalizedSeedProgress;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yieldLevel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref qualityLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Server_SendPlantSeed_2530605204_Private_Void_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A806 RID: 43014 RVA: 0x002A1300 File Offset: 0x0029F500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293722, XrefRangeEnd = 293723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendPlantSeed_2530605204(string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(seedID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalizedSeedProgress;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yieldLevel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref qualityLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___SendPlantSeed_2530605204_Public_Void_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A807 RID: 43015 RVA: 0x002A136C File Offset: 0x0029F56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293723, XrefRangeEnd = 293730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendPlantSeed_2530605204(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Server_SendPlantSeed_2530605204_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A808 RID: 43016 RVA: 0x002A13D0 File Offset: 0x0029F5D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293730, XrefRangeEnd = 293752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_PlantSeed_709433087(NetworkConnection conn, string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(seedID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalizedSeedProgress;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yieldLevel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref qualityLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Observers_PlantSeed_709433087_Private_Void_NetworkConnection_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A809 RID: 43017 RVA: 0x002A1450 File Offset: 0x0029F650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293752, XrefRangeEnd = 293753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___PlantSeed_709433087(NetworkConnection conn, string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(seedID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalizedSeedProgress;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yieldLevel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref qualityLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___PlantSeed_709433087_Public_Void_NetworkConnection_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A80A RID: 43018 RVA: 0x002A14D0 File Offset: 0x0029F6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293753, XrefRangeEnd = 293760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_PlantSeed_709433087(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Observers_PlantSeed_709433087_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A80B RID: 43019 RVA: 0x002A1520 File Offset: 0x0029F720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293760, XrefRangeEnd = 293773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_PlantSeed_709433087(NetworkConnection conn, string seedID, float normalizedSeedProgress, float yieldLevel, float qualityLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(seedID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalizedSeedProgress;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yieldLevel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref qualityLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Target_PlantSeed_709433087_Private_Void_NetworkConnection_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A80C RID: 43020 RVA: 0x002A15A0 File Offset: 0x0029F7A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293773, XrefRangeEnd = 293780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_PlantSeed_709433087(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Target_PlantSeed_709433087_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A80D RID: 43021 RVA: 0x002A15F0 File Offset: 0x0029F7F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetGrowProgress_431000436(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Observers_SetGrowProgress_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A80E RID: 43022 RVA: 0x002A1630 File Offset: 0x0029F830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293780, XrefRangeEnd = 293791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetGrowProgress_431000436(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___SetGrowProgress_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A80F RID: 43023 RVA: 0x002A1670 File Offset: 0x0029F870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293791, XrefRangeEnd = 293799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetGrowProgress_431000436(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Observers_SetGrowProgress_431000436_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A810 RID: 43024 RVA: 0x002A16C0 File Offset: 0x0029F8C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293799, XrefRangeEnd = 293820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetHarvestableActive_338960014(NetworkConnection conn, int harvestableIndex, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref harvestableIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Observers_SetHarvestableActive_338960014_Private_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A811 RID: 43025 RVA: 0x002A1720 File Offset: 0x0029F920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293820, XrefRangeEnd = 293821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetHarvestableActive_338960014(NetworkConnection conn, int harvestableIndex, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref harvestableIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___SetHarvestableActive_338960014_Public_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A812 RID: 43026 RVA: 0x002A1780 File Offset: 0x0029F980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293821, XrefRangeEnd = 293826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetHarvestableActive_338960014(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Observers_SetHarvestableActive_338960014_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A813 RID: 43027 RVA: 0x002A17D0 File Offset: 0x0029F9D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293826, XrefRangeEnd = 293838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetHarvestableActive_338960014(NetworkConnection conn, int harvestableIndex, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref harvestableIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Target_SetHarvestableActive_338960014_Private_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A814 RID: 43028 RVA: 0x002A1830 File Offset: 0x0029FA30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293838, XrefRangeEnd = 293843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetHarvestableActive_338960014(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Target_SetHarvestableActive_338960014_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A815 RID: 43029 RVA: 0x002A1880 File Offset: 0x0029FA80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293843, XrefRangeEnd = 293864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendHarvestableActive_3658436649(int harvestableIndex, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref harvestableIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Server_SendHarvestableActive_3658436649_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A816 RID: 43030 RVA: 0x002A18CC File Offset: 0x0029FACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293864, XrefRangeEnd = 293865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendHarvestableActive_3658436649(int harvestableIndex, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref harvestableIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___SendHarvestableActive_3658436649_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A817 RID: 43031 RVA: 0x002A1918 File Offset: 0x0029FB18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293865, XrefRangeEnd = 293870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendHarvestableActive_3658436649(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Server_SendHarvestableActive_3658436649_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700341C RID: 13340
		// (get) Token: 0x0600A818 RID: 43032 RVA: 0x002A197C File Offset: 0x0029FB7C
		// (set) Token: 0x0600A819 RID: 43033 RVA: 0x002A19B8 File Offset: 0x0029FBB8
		public unsafe float SyncAccessor_<SoilLevel>k__BackingField
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 217558, RefRangeEnd = 217563, XrefRangeStart = 217558, XrefRangeEnd = 217563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___get_value__SoilLevel_k__BackingField_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 293878, RefRangeEnd = 293880, XrefRangeStart = 293870, XrefRangeEnd = 293878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___set_value__SoilLevel_k__BackingField_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A81A RID: 43034 RVA: 0x002A1A04 File Offset: 0x0029FC04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293880, XrefRangeEnd = 293930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_ObjectScripts_Pot(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ObjectScripts_Pot_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700341D RID: 13341
		// (get) Token: 0x0600A81B RID: 43035 RVA: 0x002A1A78 File Offset: 0x0029FC78
		// (set) Token: 0x0600A81C RID: 43036 RVA: 0x002A1AB0 File Offset: 0x0029FCB0
		public unsafe string SyncAccessor_<SoilID>k__BackingField
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 186207, RefRangeEnd = 186215, XrefRangeStart = 186207, XrefRangeEnd = 186215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___get_value__SoilID_k__BackingField_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 293939, RefRangeEnd = 293941, XrefRangeStart = 293930, XrefRangeEnd = 293939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___set_value__SoilID_k__BackingField_Public_set_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700341E RID: 13342
		// (get) Token: 0x0600A81D RID: 43037 RVA: 0x002A1B00 File Offset: 0x0029FD00
		// (set) Token: 0x0600A81E RID: 43038 RVA: 0x002A1B3C File Offset: 0x0029FD3C
		public unsafe int SyncAccessor_<RemainingSoilUses>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___get_value__RemainingSoilUses_k__BackingField_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 293949, RefRangeEnd = 293951, XrefRangeStart = 293941, XrefRangeEnd = 293949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___set_value__RemainingSoilUses_k__BackingField_Public_set_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700341F RID: 13343
		// (get) Token: 0x0600A81F RID: 43039 RVA: 0x002A1B88 File Offset: 0x0029FD88
		// (set) Token: 0x0600A820 RID: 43040 RVA: 0x002A1BC4 File Offset: 0x0029FDC4
		public unsafe float SyncAccessor_<WaterLevel>k__BackingField
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 94037, RefRangeEnd = 94039, XrefRangeStart = 94037, XrefRangeEnd = 94039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___get_value__WaterLevel_k__BackingField_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 293959, RefRangeEnd = 293961, XrefRangeStart = 293951, XrefRangeEnd = 293959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___set_value__WaterLevel_k__BackingField_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003420 RID: 13344
		// (get) Token: 0x0600A821 RID: 43041 RVA: 0x002A1C10 File Offset: 0x0029FE10
		// (set) Token: 0x0600A822 RID: 43042 RVA: 0x002A1C50 File Offset: 0x0029FE50
		public unsafe NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 183530, RefRangeEnd = 183533, XrefRangeStart = 183530, XrefRangeEnd = 183533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 293970, RefRangeEnd = 293972, XrefRangeStart = 293961, XrefRangeEnd = 293970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003421 RID: 13345
		// (get) Token: 0x0600A823 RID: 43043 RVA: 0x002A1CA0 File Offset: 0x0029FEA0
		// (set) Token: 0x0600A824 RID: 43044 RVA: 0x002A1CE0 File Offset: 0x0029FEE0
		public unsafe NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 184821, RefRangeEnd = 184823, XrefRangeStart = 184821, XrefRangeEnd = 184823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 293981, RefRangeEnd = 293983, XrefRangeStart = 293972, XrefRangeEnd = 293981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003422 RID: 13346
		// (get) Token: 0x0600A825 RID: 43045 RVA: 0x002A1D30 File Offset: 0x0029FF30
		// (set) Token: 0x0600A826 RID: 43046 RVA: 0x002A1D70 File Offset: 0x0029FF70
		public unsafe NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 293992, RefRangeEnd = 293993, XrefRangeStart = 293983, XrefRangeEnd = 293992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A827 RID: 43047 RVA: 0x002A1DC0 File Offset: 0x0029FFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293993, XrefRangeEnd = 293999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A828 RID: 43048 RVA: 0x000528A2 File Offset: 0x00050AA2
		public Pot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170033B0 RID: 13232
		// (get) Token: 0x0600A829 RID: 43049 RVA: 0x002A1DFC File Offset: 0x0029FFFC
		// (set) Token: 0x0600A82A RID: 43050 RVA: 0x000528AB File Offset: 0x00050AAB
		public unsafe static float DryThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Pot.NativeFieldInfoPtr_DryThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Pot.NativeFieldInfoPtr_DryThreshold, (void*)(&value));
			}
		}

		// Token: 0x170033B1 RID: 13233
		// (get) Token: 0x0600A82B RID: 43051 RVA: 0x002A1E18 File Offset: 0x002A0018
		// (set) Token: 0x0600A82C RID: 43052 RVA: 0x000528B9 File Offset: 0x00050AB9
		public unsafe static float WaterloggedThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Pot.NativeFieldInfoPtr_WaterloggedThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Pot.NativeFieldInfoPtr_WaterloggedThreshold, (void*)(&value));
			}
		}

		// Token: 0x170033B2 RID: 13234
		// (get) Token: 0x0600A82D RID: 43053 RVA: 0x002A1E34 File Offset: 0x002A0034
		// (set) Token: 0x0600A82E RID: 43054 RVA: 0x000528C7 File Offset: 0x00050AC7
		public unsafe static float ROTATION_SPEED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Pot.NativeFieldInfoPtr_ROTATION_SPEED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Pot.NativeFieldInfoPtr_ROTATION_SPEED, (void*)(&value));
			}
		}

		// Token: 0x170033B3 RID: 13235
		// (get) Token: 0x0600A82F RID: 43055 RVA: 0x002A1E50 File Offset: 0x002A0050
		// (set) Token: 0x0600A830 RID: 43056 RVA: 0x000528D5 File Offset: 0x00050AD5
		public unsafe static float MAX_CAMERA_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Pot.NativeFieldInfoPtr_MAX_CAMERA_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Pot.NativeFieldInfoPtr_MAX_CAMERA_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x170033B4 RID: 13236
		// (get) Token: 0x0600A831 RID: 43057 RVA: 0x002A1E6C File Offset: 0x002A006C
		// (set) Token: 0x0600A832 RID: 43058 RVA: 0x000528E3 File Offset: 0x00050AE3
		public unsafe static float MIN_CAMERA_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Pot.NativeFieldInfoPtr_MIN_CAMERA_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Pot.NativeFieldInfoPtr_MIN_CAMERA_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x170033B5 RID: 13237
		// (get) Token: 0x0600A833 RID: 43059 RVA: 0x002A1E88 File Offset: 0x002A0088
		// (set) Token: 0x0600A834 RID: 43060 RVA: 0x000528F1 File Offset: 0x00050AF1
		public unsafe Transform ModelTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_ModelTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_ModelTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033B6 RID: 13238
		// (get) Token: 0x0600A835 RID: 43061 RVA: 0x002A1EB8 File Offset: 0x002A00B8
		// (set) Token: 0x0600A836 RID: 43062 RVA: 0x00052910 File Offset: 0x00050B10
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033B7 RID: 13239
		// (get) Token: 0x0600A837 RID: 43063 RVA: 0x002A1EE8 File Offset: 0x002A00E8
		// (set) Token: 0x0600A838 RID: 43064 RVA: 0x0005292F File Offset: 0x00050B2F
		public unsafe Transform PourableStartPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PourableStartPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PourableStartPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033B8 RID: 13240
		// (get) Token: 0x0600A839 RID: 43065 RVA: 0x002A1F18 File Offset: 0x002A0118
		// (set) Token: 0x0600A83A RID: 43066 RVA: 0x0005294E File Offset: 0x00050B4E
		public unsafe Transform SeedStartPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SeedStartPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SeedStartPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033B9 RID: 13241
		// (get) Token: 0x0600A83B RID: 43067 RVA: 0x002A1F48 File Offset: 0x002A0148
		// (set) Token: 0x0600A83C RID: 43068 RVA: 0x0005296D File Offset: 0x00050B6D
		public unsafe Transform SeedRestingPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SeedRestingPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SeedRestingPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033BA RID: 13242
		// (get) Token: 0x0600A83D RID: 43069 RVA: 0x002A1F78 File Offset: 0x002A0178
		// (set) Token: 0x0600A83E RID: 43070 RVA: 0x0005298C File Offset: 0x00050B8C
		public unsafe GameObject WaterLoggedVisuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterLoggedVisuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterLoggedVisuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033BB RID: 13243
		// (get) Token: 0x0600A83F RID: 43071 RVA: 0x002A1FA8 File Offset: 0x002A01A8
		// (set) Token: 0x0600A840 RID: 43072 RVA: 0x000529AB File Offset: 0x00050BAB
		public unsafe Transform LookAtPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_LookAtPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_LookAtPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033BC RID: 13244
		// (get) Token: 0x0600A841 RID: 43073 RVA: 0x002A1FD8 File Offset: 0x002A01D8
		// (set) Token: 0x0600A842 RID: 43074 RVA: 0x000529CA File Offset: 0x00050BCA
		public unsafe Transform AdditivesContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_AdditivesContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_AdditivesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033BD RID: 13245
		// (get) Token: 0x0600A843 RID: 43075 RVA: 0x002A2008 File Offset: 0x002A0208
		// (set) Token: 0x0600A844 RID: 43076 RVA: 0x000529E9 File Offset: 0x00050BE9
		public unsafe Transform PlantContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PlantContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PlantContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033BE RID: 13246
		// (get) Token: 0x0600A845 RID: 43077 RVA: 0x002A2038 File Offset: 0x002A0238
		// (set) Token: 0x0600A846 RID: 43078 RVA: 0x00052A08 File Offset: 0x00050C08
		public unsafe Transform IntObjLabel_Low
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_IntObjLabel_Low);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_IntObjLabel_Low), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033BF RID: 13247
		// (get) Token: 0x0600A847 RID: 43079 RVA: 0x002A2068 File Offset: 0x002A0268
		// (set) Token: 0x0600A848 RID: 43080 RVA: 0x00052A27 File Offset: 0x00050C27
		public unsafe Transform IntObjLabel_High
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_IntObjLabel_High);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_IntObjLabel_High), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033C0 RID: 13248
		// (get) Token: 0x0600A849 RID: 43081 RVA: 0x002A2098 File Offset: 0x002A0298
		// (set) Token: 0x0600A84A RID: 43082 RVA: 0x00052A46 File Offset: 0x00050C46
		public unsafe Transform uiPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_uiPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_uiPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033C1 RID: 13249
		// (get) Token: 0x0600A84B RID: 43083 RVA: 0x002A20C8 File Offset: 0x002A02C8
		// (set) Token: 0x0600A84C RID: 43084 RVA: 0x00052A65 File Offset: 0x00050C65
		public unsafe ConfigurationReplicator configReplicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_configReplicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_configReplicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033C2 RID: 13250
		// (get) Token: 0x0600A84D RID: 43085 RVA: 0x002A20F8 File Offset: 0x002A02F8
		// (set) Token: 0x0600A84E RID: 43086 RVA: 0x00052A84 File Offset: 0x00050C84
		public unsafe Il2CppReferenceArray<Transform> accessPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_accessPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_accessPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033C3 RID: 13251
		// (get) Token: 0x0600A84F RID: 43087 RVA: 0x002A2128 File Offset: 0x002A0328
		// (set) Token: 0x0600A850 RID: 43088 RVA: 0x00052AA3 File Offset: 0x00050CA3
		public unsafe Transform TaskBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_TaskBounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_TaskBounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033C4 RID: 13252
		// (get) Token: 0x0600A851 RID: 43089 RVA: 0x002A2158 File Offset: 0x002A0358
		// (set) Token: 0x0600A852 RID: 43090 RVA: 0x00052AC2 File Offset: 0x00050CC2
		public unsafe PotSoilCover SoilCover
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SoilCover);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotSoilCover>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SoilCover), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033C5 RID: 13253
		// (get) Token: 0x0600A853 RID: 43091 RVA: 0x002A2188 File Offset: 0x002A0388
		// (set) Token: 0x0600A854 RID: 43092 RVA: 0x00052AE1 File Offset: 0x00050CE1
		public unsafe Transform LeafDropPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_LeafDropPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_LeafDropPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033C6 RID: 13254
		// (get) Token: 0x0600A855 RID: 43093 RVA: 0x002A21B8 File Offset: 0x002A03B8
		// (set) Token: 0x0600A856 RID: 43094 RVA: 0x00052B00 File Offset: 0x00050D00
		public unsafe ParticleSystem PoofParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PoofParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PoofParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033C7 RID: 13255
		// (get) Token: 0x0600A857 RID: 43095 RVA: 0x002A21E8 File Offset: 0x002A03E8
		// (set) Token: 0x0600A858 RID: 43096 RVA: 0x00052B1F File Offset: 0x00050D1F
		public unsafe AudioSourceController PoofSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PoofSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PoofSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033C8 RID: 13256
		// (get) Token: 0x0600A859 RID: 43097 RVA: 0x002A2218 File Offset: 0x002A0418
		// (set) Token: 0x0600A85A RID: 43098 RVA: 0x00052B3E File Offset: 0x00050D3E
		public unsafe Transform WaterCanvasContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterCanvasContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterCanvasContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033C9 RID: 13257
		// (get) Token: 0x0600A85B RID: 43099 RVA: 0x002A2248 File Offset: 0x002A0448
		// (set) Token: 0x0600A85C RID: 43100 RVA: 0x00052B5D File Offset: 0x00050D5D
		public unsafe Canvas WaterLevelCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterLevelCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterLevelCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033CA RID: 13258
		// (get) Token: 0x0600A85D RID: 43101 RVA: 0x002A2278 File Offset: 0x002A0478
		// (set) Token: 0x0600A85E RID: 43102 RVA: 0x00052B7C File Offset: 0x00050D7C
		public unsafe CanvasGroup WaterLevelCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterLevelCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterLevelCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033CB RID: 13259
		// (get) Token: 0x0600A85F RID: 43103 RVA: 0x002A22A8 File Offset: 0x002A04A8
		// (set) Token: 0x0600A860 RID: 43104 RVA: 0x00052B9B File Offset: 0x00050D9B
		public unsafe Slider WaterLevelSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterLevelSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterLevelSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033CC RID: 13260
		// (get) Token: 0x0600A861 RID: 43105 RVA: 0x002A22D8 File Offset: 0x002A04D8
		// (set) Token: 0x0600A862 RID: 43106 RVA: 0x00052BBA File Offset: 0x00050DBA
		public unsafe GameObject NoWaterIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_NoWaterIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_NoWaterIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033CD RID: 13261
		// (get) Token: 0x0600A863 RID: 43107 RVA: 0x002A2308 File Offset: 0x002A0508
		// (set) Token: 0x0600A864 RID: 43108 RVA: 0x00052BD9 File Offset: 0x00050DD9
		public unsafe PotUIElement WorldspaceUIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WorldspaceUIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WorldspaceUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033CE RID: 13262
		// (get) Token: 0x0600A865 RID: 43109 RVA: 0x002A2338 File Offset: 0x002A0538
		// (set) Token: 0x0600A866 RID: 43110 RVA: 0x00052BF8 File Offset: 0x00050DF8
		public unsafe Sprite typeIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_typeIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_typeIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033CF RID: 13263
		// (get) Token: 0x0600A867 RID: 43111 RVA: 0x002A2368 File Offset: 0x002A0568
		// (set) Token: 0x0600A868 RID: 43112 RVA: 0x00052C17 File Offset: 0x00050E17
		public unsafe Transform CameraContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_CameraContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_CameraContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033D0 RID: 13264
		// (get) Token: 0x0600A869 RID: 43113 RVA: 0x002A2398 File Offset: 0x002A0598
		// (set) Token: 0x0600A86A RID: 43114 RVA: 0x00052C36 File Offset: 0x00050E36
		public unsafe Transform MidshotPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_MidshotPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_MidshotPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033D1 RID: 13265
		// (get) Token: 0x0600A86B RID: 43115 RVA: 0x002A23C8 File Offset: 0x002A05C8
		// (set) Token: 0x0600A86C RID: 43116 RVA: 0x00052C55 File Offset: 0x00050E55
		public unsafe Transform CloseupPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_CloseupPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_CloseupPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033D2 RID: 13266
		// (get) Token: 0x0600A86D RID: 43117 RVA: 0x002A23F8 File Offset: 0x002A05F8
		// (set) Token: 0x0600A86E RID: 43118 RVA: 0x00052C74 File Offset: 0x00050E74
		public unsafe Transform FullshotPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_FullshotPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_FullshotPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033D3 RID: 13267
		// (get) Token: 0x0600A86F RID: 43119 RVA: 0x002A2428 File Offset: 0x002A0628
		// (set) Token: 0x0600A870 RID: 43120 RVA: 0x00052C93 File Offset: 0x00050E93
		public unsafe Transform BirdsEyePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_BirdsEyePosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_BirdsEyePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033D4 RID: 13268
		// (get) Token: 0x0600A871 RID: 43121 RVA: 0x002A2458 File Offset: 0x002A0658
		// (set) Token: 0x0600A872 RID: 43122 RVA: 0x00052CB2 File Offset: 0x00050EB2
		public unsafe bool AutoRotateCameraContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_AutoRotateCameraContainer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_AutoRotateCameraContainer)) = value;
			}
		}

		// Token: 0x170033D5 RID: 13269
		// (get) Token: 0x0600A873 RID: 43123 RVA: 0x002A2480 File Offset: 0x002A0680
		// (set) Token: 0x0600A874 RID: 43124 RVA: 0x00052CCD File Offset: 0x00050ECD
		public unsafe Transform Dirt_Flat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_Dirt_Flat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_Dirt_Flat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033D6 RID: 13270
		// (get) Token: 0x0600A875 RID: 43125 RVA: 0x002A24B0 File Offset: 0x002A06B0
		// (set) Token: 0x0600A876 RID: 43126 RVA: 0x00052CEC File Offset: 0x00050EEC
		public unsafe Transform Dirt_Parted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_Dirt_Parted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_Dirt_Parted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033D7 RID: 13271
		// (get) Token: 0x0600A877 RID: 43127 RVA: 0x002A24E0 File Offset: 0x002A06E0
		// (set) Token: 0x0600A878 RID: 43128 RVA: 0x00052D0B File Offset: 0x00050F0B
		public unsafe Il2CppReferenceArray<SoilChunk> SoilChunks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SoilChunks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SoilChunk>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SoilChunks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033D8 RID: 13272
		// (get) Token: 0x0600A879 RID: 43129 RVA: 0x002A2510 File Offset: 0x002A0710
		// (set) Token: 0x0600A87A RID: 43130 RVA: 0x00052D2A File Offset: 0x00050F2A
		public unsafe List<MeshRenderer> DirtRenderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_DirtRenderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_DirtRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033D9 RID: 13273
		// (get) Token: 0x0600A87B RID: 43131 RVA: 0x002A2540 File Offset: 0x002A0740
		// (set) Token: 0x0600A87C RID: 43132 RVA: 0x00052D49 File Offset: 0x00050F49
		public unsafe float PotRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PotRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PotRadius)) = value;
			}
		}

		// Token: 0x170033DA RID: 13274
		// (get) Token: 0x0600A87D RID: 43133 RVA: 0x002A2568 File Offset: 0x002A0768
		// (set) Token: 0x0600A87E RID: 43134 RVA: 0x00052D64 File Offset: 0x00050F64
		public unsafe float YieldMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_YieldMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_YieldMultiplier)) = value;
			}
		}

		// Token: 0x170033DB RID: 13275
		// (get) Token: 0x0600A87F RID: 43135 RVA: 0x002A2590 File Offset: 0x002A0790
		// (set) Token: 0x0600A880 RID: 43136 RVA: 0x00052D7F File Offset: 0x00050F7F
		public unsafe float GrowSpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_GrowSpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_GrowSpeedMultiplier)) = value;
			}
		}

		// Token: 0x170033DC RID: 13276
		// (get) Token: 0x0600A881 RID: 43137 RVA: 0x002A25B8 File Offset: 0x002A07B8
		// (set) Token: 0x0600A882 RID: 43138 RVA: 0x00052D9A File Offset: 0x00050F9A
		public unsafe float MoistureDrainMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_MoistureDrainMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_MoistureDrainMultiplier)) = value;
			}
		}

		// Token: 0x170033DD RID: 13277
		// (get) Token: 0x0600A883 RID: 43139 RVA: 0x002A25E0 File Offset: 0x002A07E0
		// (set) Token: 0x0600A884 RID: 43140 RVA: 0x00052DB5 File Offset: 0x00050FB5
		public unsafe bool AlignLeafDropToPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_AlignLeafDropToPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_AlignLeafDropToPlayer)) = value;
			}
		}

		// Token: 0x170033DE RID: 13278
		// (get) Token: 0x0600A885 RID: 43141 RVA: 0x002A2608 File Offset: 0x002A0808
		// (set) Token: 0x0600A886 RID: 43142 RVA: 0x00052DD0 File Offset: 0x00050FD0
		public unsafe float SoilCapacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SoilCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SoilCapacity)) = value;
			}
		}

		// Token: 0x170033DF RID: 13279
		// (get) Token: 0x0600A887 RID: 43143 RVA: 0x002A2630 File Offset: 0x002A0830
		// (set) Token: 0x0600A888 RID: 43144 RVA: 0x00052DEB File Offset: 0x00050FEB
		public unsafe float WaterCapacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterCapacity)) = value;
			}
		}

		// Token: 0x170033E0 RID: 13280
		// (get) Token: 0x0600A889 RID: 43145 RVA: 0x002A2658 File Offset: 0x002A0858
		// (set) Token: 0x0600A88A RID: 43146 RVA: 0x00052E06 File Offset: 0x00051006
		public unsafe float WaterDrainPerHour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterDrainPerHour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WaterDrainPerHour)) = value;
			}
		}

		// Token: 0x170033E1 RID: 13281
		// (get) Token: 0x0600A88B RID: 43147 RVA: 0x002A2680 File Offset: 0x002A0880
		// (set) Token: 0x0600A88C RID: 43148 RVA: 0x00052E21 File Offset: 0x00051021
		public unsafe Vector3 DirtMinScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_DirtMinScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_DirtMinScale)) = value;
			}
		}

		// Token: 0x170033E2 RID: 13282
		// (get) Token: 0x0600A88D RID: 43149 RVA: 0x002A26A8 File Offset: 0x002A08A8
		// (set) Token: 0x0600A88E RID: 43150 RVA: 0x00052E3C File Offset: 0x0005103C
		public unsafe Vector3 DirtMaxScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_DirtMaxScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_DirtMaxScale)) = value;
			}
		}

		// Token: 0x170033E3 RID: 13283
		// (get) Token: 0x0600A88F RID: 43151 RVA: 0x002A26D0 File Offset: 0x002A08D0
		// (set) Token: 0x0600A890 RID: 43152 RVA: 0x00052E57 File Offset: 0x00051057
		public unsafe Transform Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_Target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033E4 RID: 13284
		// (get) Token: 0x0600A891 RID: 43153 RVA: 0x002A2700 File Offset: 0x002A0900
		// (set) Token: 0x0600A892 RID: 43154 RVA: 0x00052E76 File Offset: 0x00051076
		public unsafe UsableLightSource LightSourceOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_LightSourceOverride);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UsableLightSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_LightSourceOverride), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033E5 RID: 13285
		// (get) Token: 0x0600A893 RID: 43155 RVA: 0x002A2730 File Offset: 0x002A0930
		// (set) Token: 0x0600A894 RID: 43156 RVA: 0x00052E95 File Offset: 0x00051095
		public unsafe float _SoilLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__SoilLevel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__SoilLevel_k__BackingField)) = value;
			}
		}

		// Token: 0x170033E6 RID: 13286
		// (get) Token: 0x0600A895 RID: 43157 RVA: 0x002A2758 File Offset: 0x002A0958
		// (set) Token: 0x0600A896 RID: 43158 RVA: 0x00052EB0 File Offset: 0x000510B0
		public unsafe string _SoilID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__SoilID_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__SoilID_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170033E7 RID: 13287
		// (get) Token: 0x0600A897 RID: 43159 RVA: 0x002A2780 File Offset: 0x002A0980
		// (set) Token: 0x0600A898 RID: 43160 RVA: 0x00052ECF File Offset: 0x000510CF
		public unsafe int _RemainingSoilUses_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__RemainingSoilUses_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__RemainingSoilUses_k__BackingField)) = value;
			}
		}

		// Token: 0x170033E8 RID: 13288
		// (get) Token: 0x0600A899 RID: 43161 RVA: 0x002A27A8 File Offset: 0x002A09A8
		// (set) Token: 0x0600A89A RID: 43162 RVA: 0x00052EEA File Offset: 0x000510EA
		public unsafe float _WaterLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__WaterLevel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__WaterLevel_k__BackingField)) = value;
			}
		}

		// Token: 0x170033E9 RID: 13289
		// (get) Token: 0x0600A89B RID: 43163 RVA: 0x002A27D0 File Offset: 0x002A09D0
		// (set) Token: 0x0600A89C RID: 43164 RVA: 0x00052F05 File Offset: 0x00051105
		public unsafe Plant _Plant_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__Plant_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Plant>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__Plant_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033EA RID: 13290
		// (get) Token: 0x0600A89D RID: 43165 RVA: 0x002A2800 File Offset: 0x002A0A00
		// (set) Token: 0x0600A89E RID: 43166 RVA: 0x00052F24 File Offset: 0x00051124
		public unsafe List<Additive> AppliedAdditives
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_AppliedAdditives);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Additive>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_AppliedAdditives), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033EB RID: 13291
		// (get) Token: 0x0600A89F RID: 43167 RVA: 0x002A2830 File Offset: 0x002A0A30
		// (set) Token: 0x0600A8A0 RID: 43168 RVA: 0x00052F43 File Offset: 0x00051143
		public unsafe NetworkObject _NPCUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__NPCUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__NPCUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033EC RID: 13292
		// (get) Token: 0x0600A8A1 RID: 43169 RVA: 0x002A2860 File Offset: 0x002A0A60
		// (set) Token: 0x0600A8A2 RID: 43170 RVA: 0x00052F62 File Offset: 0x00051162
		public unsafe NetworkObject _PlayerUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__PlayerUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__PlayerUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033ED RID: 13293
		// (get) Token: 0x0600A8A3 RID: 43171 RVA: 0x002A2890 File Offset: 0x002A0A90
		// (set) Token: 0x0600A8A4 RID: 43172 RVA: 0x00052F81 File Offset: 0x00051181
		public unsafe PotConfiguration _potConfiguration_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__potConfiguration_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotConfiguration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__potConfiguration_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033EE RID: 13294
		// (get) Token: 0x0600A8A5 RID: 43173 RVA: 0x002A28C0 File Offset: 0x002A0AC0
		// (set) Token: 0x0600A8A6 RID: 43174 RVA: 0x00052FA0 File Offset: 0x000511A0
		public unsafe WorldspaceUIElement _WorldspaceUI_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__WorldspaceUI_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__WorldspaceUI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033EF RID: 13295
		// (get) Token: 0x0600A8A7 RID: 43175 RVA: 0x002A28F0 File Offset: 0x002A0AF0
		// (set) Token: 0x0600A8A8 RID: 43176 RVA: 0x00052FBF File Offset: 0x000511BF
		public unsafe NetworkObject _CurrentPlayerConfigurer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033F0 RID: 13296
		// (get) Token: 0x0600A8A9 RID: 43177 RVA: 0x002A2920 File Offset: 0x002A0B20
		// (set) Token: 0x0600A8AA RID: 43178 RVA: 0x00052FDE File Offset: 0x000511DE
		public unsafe List<ItemSlot> _InputSlots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__InputSlots_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__InputSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033F1 RID: 13297
		// (get) Token: 0x0600A8AB RID: 43179 RVA: 0x002A2950 File Offset: 0x002A0B50
		// (set) Token: 0x0600A8AC RID: 43180 RVA: 0x00052FFD File Offset: 0x000511FD
		public unsafe List<ItemSlot> _OutputSlots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__OutputSlots_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__OutputSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033F2 RID: 13298
		// (get) Token: 0x0600A8AD RID: 43181 RVA: 0x002A2980 File Offset: 0x002A0B80
		// (set) Token: 0x0600A8AE RID: 43182 RVA: 0x0005301C File Offset: 0x0005121C
		public unsafe bool _Selectable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__Selectable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__Selectable_k__BackingField)) = value;
			}
		}

		// Token: 0x170033F3 RID: 13299
		// (get) Token: 0x0600A8AF RID: 43183 RVA: 0x002A29A8 File Offset: 0x002A0BA8
		// (set) Token: 0x0600A8B0 RID: 43184 RVA: 0x00053037 File Offset: 0x00051237
		public unsafe bool _IsAcceptingItems_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField)) = value;
			}
		}

		// Token: 0x170033F4 RID: 13300
		// (get) Token: 0x0600A8B1 RID: 43185 RVA: 0x002A29D0 File Offset: 0x002A0BD0
		// (set) Token: 0x0600A8B2 RID: 43186 RVA: 0x00053052 File Offset: 0x00051252
		public unsafe bool intObjSetThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_intObjSetThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_intObjSetThisFrame)) = value;
			}
		}

		// Token: 0x170033F5 RID: 13301
		// (get) Token: 0x0600A8B3 RID: 43187 RVA: 0x002A29F8 File Offset: 0x002A0BF8
		// (set) Token: 0x0600A8B4 RID: 43188 RVA: 0x0005306D File Offset: 0x0005126D
		public unsafe ItemSlot outputSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_outputSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_outputSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033F6 RID: 13302
		// (get) Token: 0x0600A8B5 RID: 43189 RVA: 0x002A2A28 File Offset: 0x002A0C28
		// (set) Token: 0x0600A8B6 RID: 43190 RVA: 0x0005308C File Offset: 0x0005128C
		public unsafe float rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_rotation)) = value;
			}
		}

		// Token: 0x170033F7 RID: 13303
		// (get) Token: 0x0600A8B7 RID: 43191 RVA: 0x002A2A50 File Offset: 0x002A0C50
		// (set) Token: 0x0600A8B8 RID: 43192 RVA: 0x000530A7 File Offset: 0x000512A7
		public unsafe bool rotationOverridden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_rotationOverridden);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_rotationOverridden)) = value;
			}
		}

		// Token: 0x170033F8 RID: 13304
		// (get) Token: 0x0600A8B9 RID: 43193 RVA: 0x002A2A78 File Offset: 0x002A0C78
		// (set) Token: 0x0600A8BA RID: 43194 RVA: 0x000530C2 File Offset: 0x000512C2
		public unsafe SoilDefinition appliedSoilDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_appliedSoilDefinition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SoilDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_appliedSoilDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033F9 RID: 13305
		// (get) Token: 0x0600A8BB RID: 43195 RVA: 0x002A2AA8 File Offset: 0x002A0CA8
		// (set) Token: 0x0600A8BC RID: 43196 RVA: 0x000530E1 File Offset: 0x000512E1
		public unsafe SyncVar<float> syncVar____SoilLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____SoilLevel_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____SoilLevel_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033FA RID: 13306
		// (get) Token: 0x0600A8BD RID: 43197 RVA: 0x002A2AD8 File Offset: 0x002A0CD8
		// (set) Token: 0x0600A8BE RID: 43198 RVA: 0x00053100 File Offset: 0x00051300
		public unsafe SyncVar<string> syncVar____SoilID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____SoilID_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____SoilID_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033FB RID: 13307
		// (get) Token: 0x0600A8BF RID: 43199 RVA: 0x002A2B08 File Offset: 0x002A0D08
		// (set) Token: 0x0600A8C0 RID: 43200 RVA: 0x0005311F File Offset: 0x0005131F
		public unsafe SyncVar<int> syncVar____RemainingSoilUses_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____RemainingSoilUses_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____RemainingSoilUses_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033FC RID: 13308
		// (get) Token: 0x0600A8C1 RID: 43201 RVA: 0x002A2B38 File Offset: 0x002A0D38
		// (set) Token: 0x0600A8C2 RID: 43202 RVA: 0x0005313E File Offset: 0x0005133E
		public unsafe SyncVar<float> syncVar____WaterLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____WaterLevel_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____WaterLevel_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033FD RID: 13309
		// (get) Token: 0x0600A8C3 RID: 43203 RVA: 0x002A2B68 File Offset: 0x002A0D68
		// (set) Token: 0x0600A8C4 RID: 43204 RVA: 0x0005315D File Offset: 0x0005135D
		public unsafe SyncVar<NetworkObject> syncVar____NPCUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033FE RID: 13310
		// (get) Token: 0x0600A8C5 RID: 43205 RVA: 0x002A2B98 File Offset: 0x002A0D98
		// (set) Token: 0x0600A8C6 RID: 43206 RVA: 0x0005317C File Offset: 0x0005137C
		public unsafe SyncVar<NetworkObject> syncVar____PlayerUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033FF RID: 13311
		// (get) Token: 0x0600A8C7 RID: 43207 RVA: 0x002A2BC8 File Offset: 0x002A0DC8
		// (set) Token: 0x0600A8C8 RID: 43208 RVA: 0x0005319B File Offset: 0x0005139B
		public unsafe SyncVar<NetworkObject> syncVar____CurrentPlayerConfigurer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003400 RID: 13312
		// (get) Token: 0x0600A8C9 RID: 43209 RVA: 0x002A2BF8 File Offset: 0x002A0DF8
		// (set) Token: 0x0600A8CA RID: 43210 RVA: 0x000531BA File Offset: 0x000513BA
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17003401 RID: 13313
		// (get) Token: 0x0600A8CB RID: 43211 RVA: 0x002A2C20 File Offset: 0x002A0E20
		// (set) Token: 0x0600A8CC RID: 43212 RVA: 0x000531D5 File Offset: 0x000513D5
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400705B RID: 28763
		private static readonly IntPtr NativeFieldInfoPtr_DryThreshold;

		// Token: 0x0400705C RID: 28764
		private static readonly IntPtr NativeFieldInfoPtr_WaterloggedThreshold;

		// Token: 0x0400705D RID: 28765
		private static readonly IntPtr NativeFieldInfoPtr_ROTATION_SPEED;

		// Token: 0x0400705E RID: 28766
		private static readonly IntPtr NativeFieldInfoPtr_MAX_CAMERA_DISTANCE;

		// Token: 0x0400705F RID: 28767
		private static readonly IntPtr NativeFieldInfoPtr_MIN_CAMERA_DISTANCE;

		// Token: 0x04007060 RID: 28768
		private static readonly IntPtr NativeFieldInfoPtr_ModelTransform;

		// Token: 0x04007061 RID: 28769
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04007062 RID: 28770
		private static readonly IntPtr NativeFieldInfoPtr_PourableStartPoint;

		// Token: 0x04007063 RID: 28771
		private static readonly IntPtr NativeFieldInfoPtr_SeedStartPoint;

		// Token: 0x04007064 RID: 28772
		private static readonly IntPtr NativeFieldInfoPtr_SeedRestingPoint;

		// Token: 0x04007065 RID: 28773
		private static readonly IntPtr NativeFieldInfoPtr_WaterLoggedVisuals;

		// Token: 0x04007066 RID: 28774
		private static readonly IntPtr NativeFieldInfoPtr_LookAtPoint;

		// Token: 0x04007067 RID: 28775
		private static readonly IntPtr NativeFieldInfoPtr_AdditivesContainer;

		// Token: 0x04007068 RID: 28776
		private static readonly IntPtr NativeFieldInfoPtr_PlantContainer;

		// Token: 0x04007069 RID: 28777
		private static readonly IntPtr NativeFieldInfoPtr_IntObjLabel_Low;

		// Token: 0x0400706A RID: 28778
		private static readonly IntPtr NativeFieldInfoPtr_IntObjLabel_High;

		// Token: 0x0400706B RID: 28779
		private static readonly IntPtr NativeFieldInfoPtr_uiPoint;

		// Token: 0x0400706C RID: 28780
		private static readonly IntPtr NativeFieldInfoPtr_configReplicator;

		// Token: 0x0400706D RID: 28781
		private static readonly IntPtr NativeFieldInfoPtr_accessPoints;

		// Token: 0x0400706E RID: 28782
		private static readonly IntPtr NativeFieldInfoPtr_TaskBounds;

		// Token: 0x0400706F RID: 28783
		private static readonly IntPtr NativeFieldInfoPtr_SoilCover;

		// Token: 0x04007070 RID: 28784
		private static readonly IntPtr NativeFieldInfoPtr_LeafDropPoint;

		// Token: 0x04007071 RID: 28785
		private static readonly IntPtr NativeFieldInfoPtr_PoofParticles;

		// Token: 0x04007072 RID: 28786
		private static readonly IntPtr NativeFieldInfoPtr_PoofSound;

		// Token: 0x04007073 RID: 28787
		private static readonly IntPtr NativeFieldInfoPtr_WaterCanvasContainer;

		// Token: 0x04007074 RID: 28788
		private static readonly IntPtr NativeFieldInfoPtr_WaterLevelCanvas;

		// Token: 0x04007075 RID: 28789
		private static readonly IntPtr NativeFieldInfoPtr_WaterLevelCanvasGroup;

		// Token: 0x04007076 RID: 28790
		private static readonly IntPtr NativeFieldInfoPtr_WaterLevelSlider;

		// Token: 0x04007077 RID: 28791
		private static readonly IntPtr NativeFieldInfoPtr_NoWaterIcon;

		// Token: 0x04007078 RID: 28792
		private static readonly IntPtr NativeFieldInfoPtr_WorldspaceUIPrefab;

		// Token: 0x04007079 RID: 28793
		private static readonly IntPtr NativeFieldInfoPtr_typeIcon;

		// Token: 0x0400707A RID: 28794
		private static readonly IntPtr NativeFieldInfoPtr_CameraContainer;

		// Token: 0x0400707B RID: 28795
		private static readonly IntPtr NativeFieldInfoPtr_MidshotPosition;

		// Token: 0x0400707C RID: 28796
		private static readonly IntPtr NativeFieldInfoPtr_CloseupPosition;

		// Token: 0x0400707D RID: 28797
		private static readonly IntPtr NativeFieldInfoPtr_FullshotPosition;

		// Token: 0x0400707E RID: 28798
		private static readonly IntPtr NativeFieldInfoPtr_BirdsEyePosition;

		// Token: 0x0400707F RID: 28799
		private static readonly IntPtr NativeFieldInfoPtr_AutoRotateCameraContainer;

		// Token: 0x04007080 RID: 28800
		private static readonly IntPtr NativeFieldInfoPtr_Dirt_Flat;

		// Token: 0x04007081 RID: 28801
		private static readonly IntPtr NativeFieldInfoPtr_Dirt_Parted;

		// Token: 0x04007082 RID: 28802
		private static readonly IntPtr NativeFieldInfoPtr_SoilChunks;

		// Token: 0x04007083 RID: 28803
		private static readonly IntPtr NativeFieldInfoPtr_DirtRenderers;

		// Token: 0x04007084 RID: 28804
		private static readonly IntPtr NativeFieldInfoPtr_PotRadius;

		// Token: 0x04007085 RID: 28805
		private static readonly IntPtr NativeFieldInfoPtr_YieldMultiplier;

		// Token: 0x04007086 RID: 28806
		private static readonly IntPtr NativeFieldInfoPtr_GrowSpeedMultiplier;

		// Token: 0x04007087 RID: 28807
		private static readonly IntPtr NativeFieldInfoPtr_MoistureDrainMultiplier;

		// Token: 0x04007088 RID: 28808
		private static readonly IntPtr NativeFieldInfoPtr_AlignLeafDropToPlayer;

		// Token: 0x04007089 RID: 28809
		private static readonly IntPtr NativeFieldInfoPtr_SoilCapacity;

		// Token: 0x0400708A RID: 28810
		private static readonly IntPtr NativeFieldInfoPtr_WaterCapacity;

		// Token: 0x0400708B RID: 28811
		private static readonly IntPtr NativeFieldInfoPtr_WaterDrainPerHour;

		// Token: 0x0400708C RID: 28812
		private static readonly IntPtr NativeFieldInfoPtr_DirtMinScale;

		// Token: 0x0400708D RID: 28813
		private static readonly IntPtr NativeFieldInfoPtr_DirtMaxScale;

		// Token: 0x0400708E RID: 28814
		private static readonly IntPtr NativeFieldInfoPtr_Target;

		// Token: 0x0400708F RID: 28815
		private static readonly IntPtr NativeFieldInfoPtr_LightSourceOverride;

		// Token: 0x04007090 RID: 28816
		private static readonly IntPtr NativeFieldInfoPtr__SoilLevel_k__BackingField;

		// Token: 0x04007091 RID: 28817
		private static readonly IntPtr NativeFieldInfoPtr__SoilID_k__BackingField;

		// Token: 0x04007092 RID: 28818
		private static readonly IntPtr NativeFieldInfoPtr__RemainingSoilUses_k__BackingField;

		// Token: 0x04007093 RID: 28819
		private static readonly IntPtr NativeFieldInfoPtr__WaterLevel_k__BackingField;

		// Token: 0x04007094 RID: 28820
		private static readonly IntPtr NativeFieldInfoPtr__Plant_k__BackingField;

		// Token: 0x04007095 RID: 28821
		private static readonly IntPtr NativeFieldInfoPtr_AppliedAdditives;

		// Token: 0x04007096 RID: 28822
		private static readonly IntPtr NativeFieldInfoPtr__NPCUserObject_k__BackingField;

		// Token: 0x04007097 RID: 28823
		private static readonly IntPtr NativeFieldInfoPtr__PlayerUserObject_k__BackingField;

		// Token: 0x04007098 RID: 28824
		private static readonly IntPtr NativeFieldInfoPtr__potConfiguration_k__BackingField;

		// Token: 0x04007099 RID: 28825
		private static readonly IntPtr NativeFieldInfoPtr__WorldspaceUI_k__BackingField;

		// Token: 0x0400709A RID: 28826
		private static readonly IntPtr NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField;

		// Token: 0x0400709B RID: 28827
		private static readonly IntPtr NativeFieldInfoPtr__InputSlots_k__BackingField;

		// Token: 0x0400709C RID: 28828
		private static readonly IntPtr NativeFieldInfoPtr__OutputSlots_k__BackingField;

		// Token: 0x0400709D RID: 28829
		private static readonly IntPtr NativeFieldInfoPtr__Selectable_k__BackingField;

		// Token: 0x0400709E RID: 28830
		private static readonly IntPtr NativeFieldInfoPtr__IsAcceptingItems_k__BackingField;

		// Token: 0x0400709F RID: 28831
		private static readonly IntPtr NativeFieldInfoPtr_intObjSetThisFrame;

		// Token: 0x040070A0 RID: 28832
		private static readonly IntPtr NativeFieldInfoPtr_outputSlot;

		// Token: 0x040070A1 RID: 28833
		private static readonly IntPtr NativeFieldInfoPtr_rotation;

		// Token: 0x040070A2 RID: 28834
		private static readonly IntPtr NativeFieldInfoPtr_rotationOverridden;

		// Token: 0x040070A3 RID: 28835
		private static readonly IntPtr NativeFieldInfoPtr_appliedSoilDefinition;

		// Token: 0x040070A4 RID: 28836
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____SoilLevel_k__BackingField;

		// Token: 0x040070A5 RID: 28837
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____SoilID_k__BackingField;

		// Token: 0x040070A6 RID: 28838
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____RemainingSoilUses_k__BackingField;

		// Token: 0x040070A7 RID: 28839
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____WaterLevel_k__BackingField;

		// Token: 0x040070A8 RID: 28840
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField;

		// Token: 0x040070A9 RID: 28841
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField;

		// Token: 0x040070AA RID: 28842
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField;

		// Token: 0x040070AB RID: 28843
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040070AC RID: 28844
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040070AD RID: 28845
		private static readonly IntPtr NativeMethodInfoPtr_get_SoilLevel_Public_get_Single_0;

		// Token: 0x040070AE RID: 28846
		private static readonly IntPtr NativeMethodInfoPtr_set_SoilLevel_Protected_set_Void_Single_0;

		// Token: 0x040070AF RID: 28847
		private static readonly IntPtr NativeMethodInfoPtr_get_SoilID_Public_get_String_0;

		// Token: 0x040070B0 RID: 28848
		private static readonly IntPtr NativeMethodInfoPtr_set_SoilID_Protected_set_Void_String_0;

		// Token: 0x040070B1 RID: 28849
		private static readonly IntPtr NativeMethodInfoPtr_get_RemainingSoilUses_Public_get_Int32_0;

		// Token: 0x040070B2 RID: 28850
		private static readonly IntPtr NativeMethodInfoPtr_set_RemainingSoilUses_Protected_set_Void_Int32_0;

		// Token: 0x040070B3 RID: 28851
		private static readonly IntPtr NativeMethodInfoPtr_get_WaterLevel_Public_get_Single_0;

		// Token: 0x040070B4 RID: 28852
		private static readonly IntPtr NativeMethodInfoPtr_set_WaterLevel_Protected_set_Void_Single_0;

		// Token: 0x040070B5 RID: 28853
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedWaterLevel_Public_get_Single_0;

		// Token: 0x040070B6 RID: 28854
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFilledWithSoil_Public_get_Boolean_0;

		// Token: 0x040070B7 RID: 28855
		private static readonly IntPtr NativeMethodInfoPtr_get_Plant_Public_get_Plant_0;

		// Token: 0x040070B8 RID: 28856
		private static readonly IntPtr NativeMethodInfoPtr_set_Plant_Protected_set_Void_Plant_0;

		// Token: 0x040070B9 RID: 28857
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x040070BA RID: 28858
		private static readonly IntPtr NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x040070BB RID: 28859
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x040070BC RID: 28860
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x040070BD RID: 28861
		private static readonly IntPtr NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0;

		// Token: 0x040070BE RID: 28862
		private static readonly IntPtr NativeMethodInfoPtr_get_potConfiguration_Protected_get_PotConfiguration_0;

		// Token: 0x040070BF RID: 28863
		private static readonly IntPtr NativeMethodInfoPtr_set_potConfiguration_Protected_set_Void_PotConfiguration_0;

		// Token: 0x040070C0 RID: 28864
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0;

		// Token: 0x040070C1 RID: 28865
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0;

		// Token: 0x040070C2 RID: 28866
		private static readonly IntPtr NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0;

		// Token: 0x040070C3 RID: 28867
		private static readonly IntPtr NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0;

		// Token: 0x040070C4 RID: 28868
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x040070C5 RID: 28869
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x040070C6 RID: 28870
		private static readonly IntPtr NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x040070C7 RID: 28871
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0;

		// Token: 0x040070C8 RID: 28872
		private static readonly IntPtr NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x040070C9 RID: 28873
		private static readonly IntPtr NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x040070CA RID: 28874
		private static readonly IntPtr NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040070CB RID: 28875
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040070CC RID: 28876
		private static readonly IntPtr NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x040070CD RID: 28877
		private static readonly IntPtr NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x040070CE RID: 28878
		private static readonly IntPtr NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x040070CF RID: 28879
		private static readonly IntPtr NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x040070D0 RID: 28880
		private static readonly IntPtr NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x040070D1 RID: 28881
		private static readonly IntPtr NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x040070D2 RID: 28882
		private static readonly IntPtr NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040070D3 RID: 28883
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040070D4 RID: 28884
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0;

		// Token: 0x040070D5 RID: 28885
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040070D6 RID: 28886
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x040070D7 RID: 28887
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040070D8 RID: 28888
		private static readonly IntPtr NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0;

		// Token: 0x040070D9 RID: 28889
		private static readonly IntPtr NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0;

		// Token: 0x040070DA RID: 28890
		private static readonly IntPtr NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0;

		// Token: 0x040070DB RID: 28891
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040070DC RID: 28892
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCanvas_Protected_Void_0;

		// Token: 0x040070DD RID: 28893
		private static readonly IntPtr NativeMethodInfoPtr_OnMinPass_Private_Void_0;

		// Token: 0x040070DE RID: 28894
		private static readonly IntPtr NativeMethodInfoPtr_TimeSkipped_Private_Void_Int32_0;

		// Token: 0x040070DF RID: 28895
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureInteraction_Public_Void_String_EInteractableState_Boolean_0;

		// Token: 0x040070E0 RID: 28896
		private static readonly IntPtr NativeMethodInfoPtr_PositionCameraContainer_Public_Void_0;

		// Token: 0x040070E1 RID: 28897
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x040070E2 RID: 28898
		private static readonly IntPtr NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x040070E3 RID: 28899
		private static readonly IntPtr NativeMethodInfoPtr_ResetPot_Public_Virtual_New_Void_0;

		// Token: 0x040070E4 RID: 28900
		private static readonly IntPtr NativeMethodInfoPtr_GetAverageLightExposure_Public_Single_byref_Single_0;

		// Token: 0x040070E5 RID: 28901
		private static readonly IntPtr NativeMethodInfoPtr_CanAcceptSeed_Public_Boolean_byref_String_0;

		// Token: 0x040070E6 RID: 28902
		private static readonly IntPtr NativeMethodInfoPtr_IsReadyForHarvest_Public_Boolean_byref_String_0;

		// Token: 0x040070E7 RID: 28903
		private static readonly IntPtr NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0;

		// Token: 0x040070E8 RID: 28904
		private static readonly IntPtr NativeMethodInfoPtr_OverrideRotation_Public_Void_Single_0;

		// Token: 0x040070E9 RID: 28905
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraPosition_Public_Transform_ECameraPosition_0;

		// Token: 0x040070EA RID: 28906
		private static readonly IntPtr NativeMethodInfoPtr_AddSoil_Public_Virtual_New_Void_Single_0;

		// Token: 0x040070EB RID: 28907
		private static readonly IntPtr NativeMethodInfoPtr_SoilLevelChanged_Private_Void_Single_Single_Boolean_0;

		// Token: 0x040070EC RID: 28908
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSoilScale_Protected_Virtual_New_Void_0;

		// Token: 0x040070ED RID: 28909
		private static readonly IntPtr NativeMethodInfoPtr_SetSoilID_Public_Virtual_New_Void_String_0;

		// Token: 0x040070EE RID: 28910
		private static readonly IntPtr NativeMethodInfoPtr_SetSoilUses_Public_Virtual_New_Void_Int32_0;

		// Token: 0x040070EF RID: 28911
		private static readonly IntPtr NativeMethodInfoPtr_PushSoilDataToServer_Public_Void_0;

		// Token: 0x040070F0 RID: 28912
		private static readonly IntPtr NativeMethodInfoPtr_SendSoilData_Public_Void_String_Single_Int32_0;

		// Token: 0x040070F1 RID: 28913
		private static readonly IntPtr NativeMethodInfoPtr_SetSoilState_Public_Void_ESoilState_0;

		// Token: 0x040070F2 RID: 28914
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSoilMaterial_Protected_Virtual_New_Void_0;

		// Token: 0x040070F3 RID: 28915
		private static readonly IntPtr NativeMethodInfoPtr_ChangeWaterAmount_Public_Void_Single_0;

		// Token: 0x040070F4 RID: 28916
		private static readonly IntPtr NativeMethodInfoPtr_PushWaterDataToServer_Public_Void_0;

		// Token: 0x040070F5 RID: 28917
		private static readonly IntPtr NativeMethodInfoPtr_SendWaterData_Public_Void_Single_0;

		// Token: 0x040070F6 RID: 28918
		private static readonly IntPtr NativeMethodInfoPtr_WaterLevelChanged_Private_Void_Single_Single_Boolean_0;

		// Token: 0x040070F7 RID: 28919
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetActive_Public_Void_Boolean_0;

		// Token: 0x040070F8 RID: 28920
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeTarget_Public_Void_0;

		// Token: 0x040070F9 RID: 28921
		private static readonly IntPtr NativeMethodInfoPtr_SendAdditive_Public_Void_String_Boolean_0;

		// Token: 0x040070FA RID: 28922
		private static readonly IntPtr NativeMethodInfoPtr_ApplyAdditive_Public_Void_NetworkConnection_String_Boolean_0;

		// Token: 0x040070FB RID: 28923
		private static readonly IntPtr NativeMethodInfoPtr_GetAdditiveGrowthMultiplier_Public_Single_0;

		// Token: 0x040070FC RID: 28924
		private static readonly IntPtr NativeMethodInfoPtr_GetNetYieldChange_Public_Single_0;

		// Token: 0x040070FD RID: 28925
		private static readonly IntPtr NativeMethodInfoPtr_GetNetQualityChange_Public_Single_0;

		// Token: 0x040070FE RID: 28926
		private static readonly IntPtr NativeMethodInfoPtr_GetAdditive_Public_Additive_String_0;

		// Token: 0x040070FF RID: 28927
		private static readonly IntPtr NativeMethodInfoPtr_FullyGrowPlant_Public_Void_0;

		// Token: 0x04007100 RID: 28928
		private static readonly IntPtr NativeMethodInfoPtr_SendPlantSeed_Public_Void_String_Single_Single_Single_0;

		// Token: 0x04007101 RID: 28929
		private static readonly IntPtr NativeMethodInfoPtr_PlantSeed_Public_Void_NetworkConnection_String_Single_Single_Single_0;

		// Token: 0x04007102 RID: 28930
		private static readonly IntPtr NativeMethodInfoPtr_SetGrowProgress_Private_Void_Single_0;

		// Token: 0x04007103 RID: 28931
		private static readonly IntPtr NativeMethodInfoPtr_PlantSeed_Private_Void_String_Single_Single_Single_0;

		// Token: 0x04007104 RID: 28932
		private static readonly IntPtr NativeMethodInfoPtr_SetHarvestableActive_Public_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x04007105 RID: 28933
		private static readonly IntPtr NativeMethodInfoPtr_SetHarvestableActive_Local_Public_Void_Int32_Boolean_0;

		// Token: 0x04007106 RID: 28934
		private static readonly IntPtr NativeMethodInfoPtr_SendHarvestableActive_Public_Void_Int32_Boolean_0;

		// Token: 0x04007107 RID: 28935
		private static readonly IntPtr NativeMethodInfoPtr_SendHarvestableActive_Local_Public_Void_Int32_Boolean_0;

		// Token: 0x04007108 RID: 28936
		private static readonly IntPtr NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0;

		// Token: 0x04007109 RID: 28937
		private static readonly IntPtr NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400710A RID: 28938
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x0400710B RID: 28939
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0;

		// Token: 0x0400710C RID: 28940
		private static readonly IntPtr NativeMethodInfoPtr_LoadPlant_Public_Virtual_New_Void_PlantData_0;

		// Token: 0x0400710D RID: 28941
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400710E RID: 28942
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400710F RID: 28943
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04007110 RID: 28944
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04007111 RID: 28945
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04007112 RID: 28946
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04007113 RID: 28947
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007114 RID: 28948
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04007115 RID: 28949
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04007116 RID: 28950
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007117 RID: 28951
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04007118 RID: 28952
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04007119 RID: 28953
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400711A RID: 28954
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ResetPot_2166136261_Private_Void_0;

		// Token: 0x0400711B RID: 28955
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ResetPot_2166136261_Public_Virtual_New_Void_0;

		// Token: 0x0400711C RID: 28956
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ResetPot_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400711D RID: 28957
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendSoilData_3104499779_Private_Void_String_Single_Int32_0;

		// Token: 0x0400711E RID: 28958
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendSoilData_3104499779_Public_Void_String_Single_Int32_0;

		// Token: 0x0400711F RID: 28959
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendSoilData_3104499779_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007120 RID: 28960
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendWaterData_431000436_Private_Void_Single_0;

		// Token: 0x04007121 RID: 28961
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendWaterData_431000436_Public_Void_Single_0;

		// Token: 0x04007122 RID: 28962
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendWaterData_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007123 RID: 28963
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendAdditive_310431262_Private_Void_String_Boolean_0;

		// Token: 0x04007124 RID: 28964
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendAdditive_310431262_Public_Void_String_Boolean_0;

		// Token: 0x04007125 RID: 28965
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendAdditive_310431262_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007126 RID: 28966
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ApplyAdditive_619441887_Private_Void_NetworkConnection_String_Boolean_0;

		// Token: 0x04007127 RID: 28967
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ApplyAdditive_619441887_Public_Void_NetworkConnection_String_Boolean_0;

		// Token: 0x04007128 RID: 28968
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ApplyAdditive_619441887_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007129 RID: 28969
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ApplyAdditive_619441887_Private_Void_NetworkConnection_String_Boolean_0;

		// Token: 0x0400712A RID: 28970
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ApplyAdditive_619441887_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400712B RID: 28971
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_FullyGrowPlant_2166136261_Private_Void_0;

		// Token: 0x0400712C RID: 28972
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___FullyGrowPlant_2166136261_Public_Void_0;

		// Token: 0x0400712D RID: 28973
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_FullyGrowPlant_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400712E RID: 28974
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendPlantSeed_2530605204_Private_Void_String_Single_Single_Single_0;

		// Token: 0x0400712F RID: 28975
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendPlantSeed_2530605204_Public_Void_String_Single_Single_Single_0;

		// Token: 0x04007130 RID: 28976
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendPlantSeed_2530605204_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007131 RID: 28977
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_PlantSeed_709433087_Private_Void_NetworkConnection_String_Single_Single_Single_0;

		// Token: 0x04007132 RID: 28978
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___PlantSeed_709433087_Public_Void_NetworkConnection_String_Single_Single_Single_0;

		// Token: 0x04007133 RID: 28979
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_PlantSeed_709433087_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007134 RID: 28980
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_PlantSeed_709433087_Private_Void_NetworkConnection_String_Single_Single_Single_0;

		// Token: 0x04007135 RID: 28981
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_PlantSeed_709433087_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007136 RID: 28982
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetGrowProgress_431000436_Private_Void_Single_0;

		// Token: 0x04007137 RID: 28983
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetGrowProgress_431000436_Private_Void_Single_0;

		// Token: 0x04007138 RID: 28984
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetGrowProgress_431000436_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007139 RID: 28985
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetHarvestableActive_338960014_Private_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x0400713A RID: 28986
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetHarvestableActive_338960014_Public_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x0400713B RID: 28987
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetHarvestableActive_338960014_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400713C RID: 28988
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetHarvestableActive_338960014_Private_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x0400713D RID: 28989
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetHarvestableActive_338960014_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400713E RID: 28990
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendHarvestableActive_3658436649_Private_Void_Int32_Boolean_0;

		// Token: 0x0400713F RID: 28991
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendHarvestableActive_3658436649_Public_Void_Int32_Boolean_0;

		// Token: 0x04007140 RID: 28992
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendHarvestableActive_3658436649_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007141 RID: 28993
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__SoilLevel_k__BackingField_Public_get_Single_0;

		// Token: 0x04007142 RID: 28994
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__SoilLevel_k__BackingField_Public_set_Void_Single_Boolean_0;

		// Token: 0x04007143 RID: 28995
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ObjectScripts_Pot_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04007144 RID: 28996
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__SoilID_k__BackingField_Public_get_String_0;

		// Token: 0x04007145 RID: 28997
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__SoilID_k__BackingField_Public_set_Void_String_Boolean_0;

		// Token: 0x04007146 RID: 28998
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__RemainingSoilUses_k__BackingField_Public_get_Int32_0;

		// Token: 0x04007147 RID: 28999
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__RemainingSoilUses_k__BackingField_Public_set_Void_Int32_Boolean_0;

		// Token: 0x04007148 RID: 29000
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__WaterLevel_k__BackingField_Public_get_Single_0;

		// Token: 0x04007149 RID: 29001
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__WaterLevel_k__BackingField_Public_set_Void_Single_Boolean_0;

		// Token: 0x0400714A RID: 29002
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x0400714B RID: 29003
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x0400714C RID: 29004
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x0400714D RID: 29005
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x0400714E RID: 29006
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x0400714F RID: 29007
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x04007150 RID: 29008
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000BD5 RID: 3029
		[OriginalName("Assembly-CSharp.dll", "", "ECameraPosition")]
		public enum ECameraPosition
		{
			// Token: 0x04009515 RID: 38165
			Closeup,
			// Token: 0x04009516 RID: 38166
			Midshot,
			// Token: 0x04009517 RID: 38167
			Fullshot,
			// Token: 0x04009518 RID: 38168
			BirdsEye
		}

		// Token: 0x02000BD6 RID: 3030
		[OriginalName("Assembly-CSharp.dll", "", "ESoilState")]
		public enum ESoilState
		{
			// Token: 0x0400951A RID: 38170
			Flat,
			// Token: 0x0400951B RID: 38171
			Parted,
			// Token: 0x0400951C RID: 38172
			Packed
		}

		// Token: 0x02000BD7 RID: 3031
		[ObfuscatedName("ScheduleOne.ObjectScripts.Pot+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DEAB RID: 57003 RVA: 0x003484A0 File Offset: 0x003466A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Pot.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pot.__c>.NativeClassPtr);
				Pot.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c>.NativeClassPtr, "<>9");
				Pot.__c.NativeFieldInfoPtr___9__194_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c>.NativeClassPtr, "<>9__194_0");
				Pot.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c>.NativeClassPtr, 100683951);
				Pot.__c.NativeMethodInfoPtr__GetSaveString_b__194_0_Internal_String_Additive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c>.NativeClassPtr, 100683952);
			}

			// Token: 0x0600DEAC RID: 57004 RVA: 0x0034851C File Offset: 0x0034671C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pot.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DEAD RID: 57005 RVA: 0x00348558 File Offset: 0x00346758
			[CallerCount(0)]
			public unsafe string _GetSaveString_b__194_0(Additive x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c.NativeMethodInfoPtr__GetSaveString_b__194_0_Internal_String_Additive_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600DEAE RID: 57006 RVA: 0x0006C92A File Offset: 0x0006AB2A
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004509 RID: 17673
			// (get) Token: 0x0600DEAF RID: 57007 RVA: 0x003485A0 File Offset: 0x003467A0
			// (set) Token: 0x0600DEB0 RID: 57008 RVA: 0x0006C933 File Offset: 0x0006AB33
			public unsafe static Pot.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Pot.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Pot.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700450A RID: 17674
			// (get) Token: 0x0600DEB1 RID: 57009 RVA: 0x003485C8 File Offset: 0x003467C8
			// (set) Token: 0x0600DEB2 RID: 57010 RVA: 0x0006C945 File Offset: 0x0006AB45
			public unsafe static Converter<Additive, string> __9__194_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Pot.__c.NativeFieldInfoPtr___9__194_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Converter<Additive, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Pot.__c.NativeFieldInfoPtr___9__194_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400951D RID: 38173
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400951E RID: 38174
			private static readonly IntPtr NativeFieldInfoPtr___9__194_0;

			// Token: 0x0400951F RID: 38175
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009520 RID: 38176
			private static readonly IntPtr NativeMethodInfoPtr__GetSaveString_b__194_0_Internal_String_Additive_0;
		}

		// Token: 0x02000BD8 RID: 3032
		[ObfuscatedName("ScheduleOne.ObjectScripts.Pot+<>c__DisplayClass143_0")]
		public sealed class __c__DisplayClass143_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DEB3 RID: 57011 RVA: 0x003485F0 File Offset: 0x003467F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass143_0()
			{
				Il2CppClassPointerStore<Pot.__c__DisplayClass143_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<>c__DisplayClass143_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0>.NativeClassPtr);
				Pot.__c__DisplayClass143_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0>.NativeClassPtr, "<>4__this");
				Pot.__c__DisplayClass143_0.NativeFieldInfoPtr_conn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0>.NativeClassPtr, "conn");
				Pot.__c__DisplayClass143_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0>.NativeClassPtr, 100683953);
				Pot.__c__DisplayClass143_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0>.NativeClassPtr, 100683954);
				Pot.__c__DisplayClass143_0.NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0>.NativeClassPtr, 100683955);
			}

			// Token: 0x0600DEB4 RID: 57012 RVA: 0x00348680 File Offset: 0x00346880
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass143_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass143_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DEB5 RID: 57013 RVA: 0x003486BC File Offset: 0x003468BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291810, XrefRangeEnd = 291815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass143_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DEB6 RID: 57014 RVA: 0x003486FC File Offset: 0x003468FC
			[CallerCount(0)]
			public unsafe bool _SendConfigurationToClient_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass143_0.NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DEB7 RID: 57015 RVA: 0x0006C957 File Offset: 0x0006AB57
			public __c__DisplayClass143_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700450B RID: 17675
			// (get) Token: 0x0600DEB8 RID: 57016 RVA: 0x00348738 File Offset: 0x00346938
			// (set) Token: 0x0600DEB9 RID: 57017 RVA: 0x0006C960 File Offset: 0x0006AB60
			public unsafe Pot __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass143_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass143_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700450C RID: 17676
			// (get) Token: 0x0600DEBA RID: 57018 RVA: 0x00348768 File Offset: 0x00346968
			// (set) Token: 0x0600DEBB RID: 57019 RVA: 0x0006C97F File Offset: 0x0006AB7F
			public unsafe NetworkConnection conn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass143_0.NativeFieldInfoPtr_conn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkConnection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass143_0.NativeFieldInfoPtr_conn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009521 RID: 38177
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009522 RID: 38178
			private static readonly IntPtr NativeFieldInfoPtr_conn;

			// Token: 0x04009523 RID: 38179
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009524 RID: 38180
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04009525 RID: 38181
			private static readonly IntPtr NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0;

			// Token: 0x02000C85 RID: 3205
			[ObfuscatedName("ScheduleOne.ObjectScripts.Pot+<>c__DisplayClass143_0+<<SendConfigurationToClient>g__WaitForConfig|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E6D0 RID: 59088 RVA: 0x0035FECC File Offset: 0x0035E0CC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0>.NativeClassPtr, "<<SendConfigurationToClient>g__WaitForConfig|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683956);
					Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683957);
					Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683958);
					Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683959);
					Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683960);
					Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683961);
				}

				// Token: 0x0600E6D1 RID: 59089 RVA: 0x0035FFAC File Offset: 0x0035E1AC
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E6D2 RID: 59090 RVA: 0x0035FFF4 File Offset: 0x0035E1F4
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E6D3 RID: 59091 RVA: 0x00360028 File Offset: 0x0035E228
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291794, XrefRangeEnd = 291805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170047E5 RID: 18405
				// (get) Token: 0x0600E6D4 RID: 59092 RVA: 0x00360064 File Offset: 0x0035E264
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E6D5 RID: 59093 RVA: 0x003600A4 File Offset: 0x0035E2A4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291805, XrefRangeEnd = 291810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170047E6 RID: 18406
				// (get) Token: 0x0600E6D6 RID: 59094 RVA: 0x003600D8 File Offset: 0x0035E2D8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E6D7 RID: 59095 RVA: 0x00070B12 File Offset: 0x0006ED12
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170047E2 RID: 18402
				// (get) Token: 0x0600E6D8 RID: 59096 RVA: 0x00360118 File Offset: 0x0035E318
				// (set) Token: 0x0600E6D9 RID: 59097 RVA: 0x00070B1B File Offset: 0x0006ED1B
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170047E3 RID: 18403
				// (get) Token: 0x0600E6DA RID: 59098 RVA: 0x00360140 File Offset: 0x0035E340
				// (set) Token: 0x0600E6DB RID: 59099 RVA: 0x00070B36 File Offset: 0x0006ED36
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047E4 RID: 18404
				// (get) Token: 0x0600E6DC RID: 59100 RVA: 0x00360170 File Offset: 0x0035E370
				// (set) Token: 0x0600E6DD RID: 59101 RVA: 0x00070B55 File Offset: 0x0006ED55
				public unsafe Pot.__c__DisplayClass143_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot.__c__DisplayClass143_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass143_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009A3E RID: 39486
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009A3F RID: 39487
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009A40 RID: 39488
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009A41 RID: 39489
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009A42 RID: 39490
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009A43 RID: 39491
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009A44 RID: 39492
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009A45 RID: 39493
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009A46 RID: 39494
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000BD9 RID: 3033
		[ObfuscatedName("ScheduleOne.ObjectScripts.Pot+<>c__DisplayClass178_0")]
		public sealed class __c__DisplayClass178_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DEBC RID: 57020 RVA: 0x00348798 File Offset: 0x00346998
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass178_0()
			{
				Il2CppClassPointerStore<Pot.__c__DisplayClass178_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<>c__DisplayClass178_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pot.__c__DisplayClass178_0>.NativeClassPtr);
				Pot.__c__DisplayClass178_0.NativeFieldInfoPtr_additiveAssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass178_0>.NativeClassPtr, "additiveAssetPath");
				Pot.__c__DisplayClass178_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass178_0>.NativeClassPtr, 100683962);
				Pot.__c__DisplayClass178_0.NativeMethodInfoPtr__ApplyAdditive_b__0_Internal_Boolean_Additive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass178_0>.NativeClassPtr, 100683963);
			}

			// Token: 0x0600DEBD RID: 57021 RVA: 0x00348800 File Offset: 0x00346A00
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass178_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pot.__c__DisplayClass178_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass178_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DEBE RID: 57022 RVA: 0x0034883C File Offset: 0x00346A3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ApplyAdditive_b__0(Additive x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass178_0.NativeMethodInfoPtr__ApplyAdditive_b__0_Internal_Boolean_Additive_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DEBF RID: 57023 RVA: 0x0006C99E File Offset: 0x0006AB9E
			public __c__DisplayClass178_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700450D RID: 17677
			// (get) Token: 0x0600DEC0 RID: 57024 RVA: 0x0034888C File Offset: 0x00346A8C
			// (set) Token: 0x0600DEC1 RID: 57025 RVA: 0x0006C9A7 File Offset: 0x0006ABA7
			public unsafe string additiveAssetPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass178_0.NativeFieldInfoPtr_additiveAssetPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass178_0.NativeFieldInfoPtr_additiveAssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009526 RID: 38182
			private static readonly IntPtr NativeFieldInfoPtr_additiveAssetPath;

			// Token: 0x04009527 RID: 38183
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009528 RID: 38184
			private static readonly IntPtr NativeMethodInfoPtr__ApplyAdditive_b__0_Internal_Boolean_Additive_0;
		}

		// Token: 0x02000BDA RID: 3034
		[ObfuscatedName("ScheduleOne.ObjectScripts.Pot+<>c__DisplayClass182_0")]
		public sealed class __c__DisplayClass182_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DEC2 RID: 57026 RVA: 0x003488B4 File Offset: 0x00346AB4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass182_0()
			{
				Il2CppClassPointerStore<Pot.__c__DisplayClass182_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<>c__DisplayClass182_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pot.__c__DisplayClass182_0>.NativeClassPtr);
				Pot.__c__DisplayClass182_0.NativeFieldInfoPtr_additiveName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass182_0>.NativeClassPtr, "additiveName");
				Pot.__c__DisplayClass182_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass182_0>.NativeClassPtr, 100683964);
				Pot.__c__DisplayClass182_0.NativeMethodInfoPtr__GetAdditive_b__0_Internal_Boolean_Additive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass182_0>.NativeClassPtr, 100683965);
			}

			// Token: 0x0600DEC3 RID: 57027 RVA: 0x0034891C File Offset: 0x00346B1C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass182_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pot.__c__DisplayClass182_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass182_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DEC4 RID: 57028 RVA: 0x00348958 File Offset: 0x00346B58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAdditive_b__0(Additive x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass182_0.NativeMethodInfoPtr__GetAdditive_b__0_Internal_Boolean_Additive_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DEC5 RID: 57029 RVA: 0x0006C9C6 File Offset: 0x0006ABC6
			public __c__DisplayClass182_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700450E RID: 17678
			// (get) Token: 0x0600DEC6 RID: 57030 RVA: 0x003489A8 File Offset: 0x00346BA8
			// (set) Token: 0x0600DEC7 RID: 57031 RVA: 0x0006C9CF File Offset: 0x0006ABCF
			public unsafe string additiveName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass182_0.NativeFieldInfoPtr_additiveName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass182_0.NativeFieldInfoPtr_additiveName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009529 RID: 38185
			private static readonly IntPtr NativeFieldInfoPtr_additiveName;

			// Token: 0x0400952A RID: 38186
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400952B RID: 38187
			private static readonly IntPtr NativeMethodInfoPtr__GetAdditive_b__0_Internal_Boolean_Additive_0;
		}

		// Token: 0x02000BDB RID: 3035
		[ObfuscatedName("ScheduleOne.ObjectScripts.Pot+<>c__DisplayClass196_0")]
		public sealed class __c__DisplayClass196_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DEC8 RID: 57032 RVA: 0x003489D0 File Offset: 0x00346BD0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass196_0()
			{
				Il2CppClassPointerStore<Pot.__c__DisplayClass196_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<>c__DisplayClass196_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0>.NativeClassPtr);
				Pot.__c__DisplayClass196_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0>.NativeClassPtr, "<>4__this");
				Pot.__c__DisplayClass196_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0>.NativeClassPtr, "data");
				Pot.__c__DisplayClass196_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0>.NativeClassPtr, 100683966);
				Pot.__c__DisplayClass196_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0>.NativeClassPtr, 100683967);
				Pot.__c__DisplayClass196_0.NativeMethodInfoPtr__LoadPlant_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0>.NativeClassPtr, 100683968);
			}

			// Token: 0x0600DEC9 RID: 57033 RVA: 0x00348A60 File Offset: 0x00346C60
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass196_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass196_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DECA RID: 57034 RVA: 0x00348A9C File Offset: 0x00346C9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291874, XrefRangeEnd = 291879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass196_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DECB RID: 57035 RVA: 0x00348ADC File Offset: 0x00346CDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291879, XrefRangeEnd = 291881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadPlant_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass196_0.NativeMethodInfoPtr__LoadPlant_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DECC RID: 57036 RVA: 0x0006C9EE File Offset: 0x0006ABEE
			public __c__DisplayClass196_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700450F RID: 17679
			// (get) Token: 0x0600DECD RID: 57037 RVA: 0x00348B18 File Offset: 0x00346D18
			// (set) Token: 0x0600DECE RID: 57038 RVA: 0x0006C9F7 File Offset: 0x0006ABF7
			public unsafe Pot __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass196_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass196_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004510 RID: 17680
			// (get) Token: 0x0600DECF RID: 57039 RVA: 0x00348B48 File Offset: 0x00346D48
			// (set) Token: 0x0600DED0 RID: 57040 RVA: 0x0006CA16 File Offset: 0x0006AC16
			public unsafe PlantData data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass196_0.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlantData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass196_0.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400952C RID: 38188
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400952D RID: 38189
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x0400952E RID: 38190
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400952F RID: 38191
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04009530 RID: 38192
			private static readonly IntPtr NativeMethodInfoPtr__LoadPlant_b__1_Internal_Boolean_0;

			// Token: 0x02000C86 RID: 3206
			[ObfuscatedName("ScheduleOne.ObjectScripts.Pot+<>c__DisplayClass196_0+<<LoadPlant>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E6DE RID: 59102 RVA: 0x003601A0 File Offset: 0x0035E3A0
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0>.NativeClassPtr, "<<LoadPlant>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683969);
					Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683970);
					Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683971);
					Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683972);
					Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683973);
					Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683974);
				}

				// Token: 0x0600E6DF RID: 59103 RVA: 0x00360280 File Offset: 0x0035E480
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E6E0 RID: 59104 RVA: 0x003602C8 File Offset: 0x0035E4C8
				[CallerCount(13599)]
				[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E6E1 RID: 59105 RVA: 0x003602FC File Offset: 0x0035E4FC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291815, XrefRangeEnd = 291869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170047EA RID: 18410
				// (get) Token: 0x0600E6E2 RID: 59106 RVA: 0x00360338 File Offset: 0x0035E538
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E6E3 RID: 59107 RVA: 0x00360378 File Offset: 0x0035E578
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291869, XrefRangeEnd = 291874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170047EB RID: 18411
				// (get) Token: 0x0600E6E4 RID: 59108 RVA: 0x003603AC File Offset: 0x0035E5AC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E6E5 RID: 59109 RVA: 0x00070B74 File Offset: 0x0006ED74
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170047E7 RID: 18407
				// (get) Token: 0x0600E6E6 RID: 59110 RVA: 0x003603EC File Offset: 0x0035E5EC
				// (set) Token: 0x0600E6E7 RID: 59111 RVA: 0x00070B7D File Offset: 0x0006ED7D
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170047E8 RID: 18408
				// (get) Token: 0x0600E6E8 RID: 59112 RVA: 0x00360414 File Offset: 0x0035E614
				// (set) Token: 0x0600E6E9 RID: 59113 RVA: 0x00070B98 File Offset: 0x0006ED98
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047E9 RID: 18409
				// (get) Token: 0x0600E6EA RID: 59114 RVA: 0x00360444 File Offset: 0x0035E644
				// (set) Token: 0x0600E6EB RID: 59115 RVA: 0x00070BB7 File Offset: 0x0006EDB7
				public unsafe Pot.__c__DisplayClass196_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot.__c__DisplayClass196_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009A47 RID: 39495
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009A48 RID: 39496
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009A49 RID: 39497
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009A4A RID: 39498
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009A4B RID: 39499
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009A4C RID: 39500
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009A4D RID: 39501
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009A4E RID: 39502
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009A4F RID: 39503
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
