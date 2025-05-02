using System;
using Il2CppEPOOutline;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.EntityFramework
{
	// Token: 0x020003FD RID: 1021
	public class BuildableItem : NetworkBehaviour
	{
		// Token: 0x06005504 RID: 21764 RVA: 0x0018D9F0 File Offset: 0x0018BBF0
		// Note: this type is marked as 'beforefieldinit'.
		static BuildableItem()
		{
			Il2CppClassPointerStore<BuildableItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.EntityFramework", "BuildableItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr);
			BuildableItem.NativeFieldInfoPtr__ItemInstance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "<ItemInstance>k__BackingField");
			BuildableItem.NativeFieldInfoPtr__ParentProperty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "<ParentProperty>k__BackingField");
			BuildableItem.NativeFieldInfoPtr__IsDestroyed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "<IsDestroyed>k__BackingField");
			BuildableItem.NativeFieldInfoPtr__Initialized_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "<Initialized>k__BackingField");
			BuildableItem.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "<GUID>k__BackingField");
			BuildableItem.NativeFieldInfoPtr__IsCulled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "<IsCulled>k__BackingField");
			BuildableItem.NativeFieldInfoPtr_isGhost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "isGhost");
			BuildableItem.NativeFieldInfoPtr_buildHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "buildHandler");
			BuildableItem.NativeFieldInfoPtr_HoldDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "HoldDistance");
			BuildableItem.NativeFieldInfoPtr_BuildPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "BuildPoint");
			BuildableItem.NativeFieldInfoPtr_MidAirCenterPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "MidAirCenterPoint");
			BuildableItem.NativeFieldInfoPtr_BoundingCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "BoundingCollider");
			BuildableItem.NativeFieldInfoPtr_OutlineRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "OutlineRenderers");
			BuildableItem.NativeFieldInfoPtr_IncludeOutlineRendererChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "IncludeOutlineRendererChildren");
			BuildableItem.NativeFieldInfoPtr_OutlineEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "OutlineEffect");
			BuildableItem.NativeFieldInfoPtr_GameObjectsToCull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "GameObjectsToCull");
			BuildableItem.NativeFieldInfoPtr_MeshesToCull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "MeshesToCull");
			BuildableItem.NativeFieldInfoPtr_onInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "onInitialized");
			BuildableItem.NativeFieldInfoPtr_onDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "onDestroyed");
			BuildableItem.NativeFieldInfoPtr_onDestroyedWithParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "onDestroyedWithParameter");
			BuildableItem.NativeFieldInfoPtr__LocallyBuilt_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "<LocallyBuilt>k__BackingField");
			BuildableItem.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			BuildableItem.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			BuildableItem.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "<HasChanged>k__BackingField");
			BuildableItem.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.EntityFramework.BuildableItemAssembly-CSharp.dll_Excuted");
			BuildableItem.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.EntityFramework.BuildableItemAssembly-CSharp.dll_Excuted");
			BuildableItem.NativeMethodInfoPtr_get_ItemInstance_Public_get_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673859);
			BuildableItem.NativeMethodInfoPtr_set_ItemInstance_Protected_set_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673860);
			BuildableItem.NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673861);
			BuildableItem.NativeMethodInfoPtr_set_ParentProperty_Protected_set_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673862);
			BuildableItem.NativeMethodInfoPtr_get_IsDestroyed_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673863);
			BuildableItem.NativeMethodInfoPtr_set_IsDestroyed_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673864);
			BuildableItem.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673865);
			BuildableItem.NativeMethodInfoPtr_set_Initialized_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673866);
			BuildableItem.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673867);
			BuildableItem.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673868);
			BuildableItem.NativeMethodInfoPtr_get_IsCulled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673869);
			BuildableItem.NativeMethodInfoPtr_set_IsCulled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673870);
			BuildableItem.NativeMethodInfoPtr_get_BuildHandler_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673871);
			BuildableItem.NativeMethodInfoPtr_AddChildMeshes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673872);
			BuildableItem.NativeMethodInfoPtr_get_LocallyBuilt_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673873);
			BuildableItem.NativeMethodInfoPtr_set_LocallyBuilt_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673874);
			BuildableItem.NativeMethodInfoPtr_SetLocallyBuilt_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673875);
			BuildableItem.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673876);
			BuildableItem.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673877);
			BuildableItem.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673878);
			BuildableItem.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673879);
			BuildableItem.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673880);
			BuildableItem.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673881);
			BuildableItem.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673882);
			BuildableItem.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673883);
			BuildableItem.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673884);
			BuildableItem.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673885);
			BuildableItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673886);
			BuildableItem.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673887);
			BuildableItem.NativeMethodInfoPtr_GetProperty_Protected_Virtual_New_Property_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673888);
			BuildableItem.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673889);
			BuildableItem.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673890);
			BuildableItem.NativeMethodInfoPtr_SendInitToClient_Protected_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673891);
			BuildableItem.NativeMethodInfoPtr_SendBuildableItemData_Public_Void_ItemInstance_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673892);
			BuildableItem.NativeMethodInfoPtr_ReceiveBuildableItemData_Public_Void_NetworkConnection_ItemInstance_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673893);
			BuildableItem.NativeMethodInfoPtr_InitializeBuildableItem_Public_Virtual_New_Void_ItemInstance_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673894);
			BuildableItem.NativeMethodInfoPtr_CanBePickedUp_Public_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673895);
			BuildableItem.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_New_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673896);
			BuildableItem.NativeMethodInfoPtr_PickupItem_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673897);
			BuildableItem.NativeMethodInfoPtr_DestroyItem_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673898);
			BuildableItem.NativeMethodInfoPtr_Destroy_Networked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673899);
			BuildableItem.NativeMethodInfoPtr_DestroyItemWrapper_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673900);
			BuildableItem.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673901);
			BuildableItem.NativeMethodInfoPtr_GetColorFromOutlineColorEnum_Public_Static_Color32_EOutlineColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673902);
			BuildableItem.NativeMethodInfoPtr_ShowOutline_Public_Virtual_New_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673903);
			BuildableItem.NativeMethodInfoPtr_ShowOutline_Public_Void_EOutlineColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673904);
			BuildableItem.NativeMethodInfoPtr_HideOutline_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673905);
			BuildableItem.NativeMethodInfoPtr_GetFurthestPointFromBoundingCollider_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673906);
			BuildableItem.NativeMethodInfoPtr_GetPenetration_Public_Boolean_byref_Single_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673907);
			BuildableItem.NativeMethodInfoPtr_HasLoS_IgnoreBuildables_Private_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673908);
			BuildableItem.NativeMethodInfoPtr_SetCulled_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673909);
			BuildableItem.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673910);
			BuildableItem.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673911);
			BuildableItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673912);
			BuildableItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673913);
			BuildableItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673914);
			BuildableItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673915);
			BuildableItem.NativeMethodInfoPtr_RpcWriter___Server_SendBuildableItemData_3537728543_Private_Void_ItemInstance_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673916);
			BuildableItem.NativeMethodInfoPtr_RpcLogic___SendBuildableItemData_3537728543_Public_Void_ItemInstance_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673917);
			BuildableItem.NativeMethodInfoPtr_RpcReader___Server_SendBuildableItemData_3537728543_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673918);
			BuildableItem.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveBuildableItemData_3859851844_Private_Void_NetworkConnection_ItemInstance_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673919);
			BuildableItem.NativeMethodInfoPtr_RpcLogic___ReceiveBuildableItemData_3859851844_Public_Void_NetworkConnection_ItemInstance_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673920);
			BuildableItem.NativeMethodInfoPtr_RpcReader___Observers_ReceiveBuildableItemData_3859851844_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673921);
			BuildableItem.NativeMethodInfoPtr_RpcWriter___Target_ReceiveBuildableItemData_3859851844_Private_Void_NetworkConnection_ItemInstance_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673922);
			BuildableItem.NativeMethodInfoPtr_RpcReader___Target_ReceiveBuildableItemData_3859851844_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673923);
			BuildableItem.NativeMethodInfoPtr_RpcWriter___Server_Destroy_Networked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673924);
			BuildableItem.NativeMethodInfoPtr_RpcLogic___Destroy_Networked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673925);
			BuildableItem.NativeMethodInfoPtr_RpcReader___Server_Destroy_Networked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673926);
			BuildableItem.NativeMethodInfoPtr_RpcWriter___Observers_DestroyItemWrapper_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673927);
			BuildableItem.NativeMethodInfoPtr_RpcLogic___DestroyItemWrapper_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673928);
			BuildableItem.NativeMethodInfoPtr_RpcReader___Observers_DestroyItemWrapper_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673929);
			BuildableItem.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100673930);
		}

		// Token: 0x170019D5 RID: 6613
		// (get) Token: 0x06005505 RID: 21765 RVA: 0x0018E1C8 File Offset: 0x0018C3C8
		// (set) Token: 0x06005506 RID: 21766 RVA: 0x0018E208 File Offset: 0x0018C408
		public unsafe ItemInstance ItemInstance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_ItemInstance_Public_get_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180491, XrefRangeEnd = 180492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_set_ItemInstance_Protected_set_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170019D6 RID: 6614
		// (get) Token: 0x06005507 RID: 21767 RVA: 0x0018E24C File Offset: 0x0018C44C
		// (set) Token: 0x06005508 RID: 21768 RVA: 0x0018E28C File Offset: 0x0018C48C
		public unsafe virtual Property ParentProperty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_set_ParentProperty_Protected_set_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170019D7 RID: 6615
		// (get) Token: 0x06005509 RID: 21769 RVA: 0x0018E2D0 File Offset: 0x0018C4D0
		// (set) Token: 0x0600550A RID: 21770 RVA: 0x0018E30C File Offset: 0x0018C50C
		public unsafe virtual bool IsDestroyed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_IsDestroyed_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_set_IsDestroyed_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170019D8 RID: 6616
		// (get) Token: 0x0600550B RID: 21771 RVA: 0x0018E34C File Offset: 0x0018C54C
		// (set) Token: 0x0600550C RID: 21772 RVA: 0x0018E388 File Offset: 0x0018C588
		public unsafe bool Initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_set_Initialized_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170019D9 RID: 6617
		// (get) Token: 0x0600550D RID: 21773 RVA: 0x0018E3C8 File Offset: 0x0018C5C8
		// (set) Token: 0x0600550E RID: 21774 RVA: 0x0018E404 File Offset: 0x0018C604
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170019DA RID: 6618
		// (get) Token: 0x0600550F RID: 21775 RVA: 0x0018E444 File Offset: 0x0018C644
		// (set) Token: 0x06005510 RID: 21776 RVA: 0x0018E480 File Offset: 0x0018C680
		public unsafe bool IsCulled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_IsCulled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_set_IsCulled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170019DB RID: 6619
		// (get) Token: 0x06005511 RID: 21777 RVA: 0x0018E4C0 File Offset: 0x0018C6C0
		public unsafe GameObject BuildHandler
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_BuildHandler_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x06005512 RID: 21778 RVA: 0x0018E500 File Offset: 0x0018C700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180492, XrefRangeEnd = 180521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddChildMeshes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_AddChildMeshes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170019DC RID: 6620
		// (get) Token: 0x06005513 RID: 21779 RVA: 0x0018E534 File Offset: 0x0018C734
		// (set) Token: 0x06005514 RID: 21780 RVA: 0x0018E570 File Offset: 0x0018C770
		public unsafe bool LocallyBuilt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_LocallyBuilt_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_set_LocallyBuilt_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005515 RID: 21781 RVA: 0x0018E5B0 File Offset: 0x0018C7B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 180521, RefRangeEnd = 180524, XrefRangeStart = 180521, XrefRangeEnd = 180521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLocallyBuilt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_SetLocallyBuilt_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170019DD RID: 6621
		// (get) Token: 0x06005516 RID: 21782 RVA: 0x0018E5E4 File Offset: 0x0018C7E4
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 180529, RefRangeEnd = 180530, XrefRangeStart = 180524, XrefRangeEnd = 180529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170019DE RID: 6622
		// (get) Token: 0x06005517 RID: 21783 RVA: 0x0018E61C File Offset: 0x0018C81C
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180530, XrefRangeEnd = 180532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170019DF RID: 6623
		// (get) Token: 0x06005518 RID: 21784 RVA: 0x0018E654 File Offset: 0x0018C854
		public unsafe virtual Loader Loader
		{
			[CallerCount(65)]
			[CachedScanResults(RefRangeStart = 31227, RefRangeEnd = 31292, XrefRangeStart = 31227, XrefRangeEnd = 31292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x170019E0 RID: 6624
		// (get) Token: 0x06005519 RID: 21785 RVA: 0x0018E694 File Offset: 0x0018C894
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30138, RefRangeEnd = 30158, XrefRangeStart = 30138, XrefRangeEnd = 30158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170019E1 RID: 6625
		// (get) Token: 0x0600551A RID: 21786 RVA: 0x0018E6D0 File Offset: 0x0018C8D0
		// (set) Token: 0x0600551B RID: 21787 RVA: 0x0018E710 File Offset: 0x0018C910
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180532, XrefRangeEnd = 180533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170019E2 RID: 6626
		// (get) Token: 0x0600551C RID: 21788 RVA: 0x0018E754 File Offset: 0x0018C954
		// (set) Token: 0x0600551D RID: 21789 RVA: 0x0018E794 File Offset: 0x0018C994
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180533, XrefRangeEnd = 180534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170019E3 RID: 6627
		// (get) Token: 0x0600551E RID: 21790 RVA: 0x0018E7D8 File Offset: 0x0018C9D8
		// (set) Token: 0x0600551F RID: 21791 RVA: 0x0018E814 File Offset: 0x0018CA14
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005520 RID: 21792 RVA: 0x0018E854 File Offset: 0x0018CA54
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005521 RID: 21793 RVA: 0x0018E890 File Offset: 0x0018CA90
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 180549, RefRangeEnd = 180556, XrefRangeStart = 180534, XrefRangeEnd = 180549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005522 RID: 21794 RVA: 0x0018E8CC File Offset: 0x0018CACC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 180570, RefRangeEnd = 180571, XrefRangeStart = 180556, XrefRangeEnd = 180570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Property GetProperty(Transform searchTransform = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(searchTransform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_GetProperty_Protected_Virtual_New_Property_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
		}

		// Token: 0x06005523 RID: 21795 RVA: 0x0018E928 File Offset: 0x0018CB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180571, XrefRangeEnd = 180577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005524 RID: 21796 RVA: 0x0018E964 File Offset: 0x0018CB64
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 180579, RefRangeEnd = 180589, XrefRangeStart = 180577, XrefRangeEnd = 180579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005525 RID: 21797 RVA: 0x0018E9B4 File Offset: 0x0018CBB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180589, XrefRangeEnd = 180597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendInitToClient(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_SendInitToClient_Protected_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005526 RID: 21798 RVA: 0x0018EA04 File Offset: 0x0018CC04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180597, XrefRangeEnd = 180609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendBuildableItemData(ItemInstance instance, string GUID, string parentPropertyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentPropertyCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_SendBuildableItemData_Public_Void_ItemInstance_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005527 RID: 21799 RVA: 0x0018EA6C File Offset: 0x0018CC6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 180644, RefRangeEnd = 180647, XrefRangeStart = 180609, XrefRangeEnd = 180644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveBuildableItemData(NetworkConnection conn, ItemInstance instance, string GUID, string parentPropertyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentPropertyCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_ReceiveBuildableItemData_Public_Void_NetworkConnection_ItemInstance_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005528 RID: 21800 RVA: 0x0018EAE8 File Offset: 0x0018CCE8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 180728, RefRangeEnd = 180731, XrefRangeStart = 180647, XrefRangeEnd = 180728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeBuildableItem(ItemInstance instance, string GUID, string parentPropertyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentPropertyCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_InitializeBuildableItem_Public_Virtual_New_Void_ItemInstance_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005529 RID: 21801 RVA: 0x0018EB5C File Offset: 0x0018CD5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 180740, RefRangeEnd = 180742, XrefRangeStart = 180731, XrefRangeEnd = 180740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanBePickedUp(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_CanBePickedUp_Public_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600552A RID: 21802 RVA: 0x0018EBB4 File Offset: 0x0018CDB4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 180745, RefRangeEnd = 180758, XrefRangeStart = 180742, XrefRangeEnd = 180745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanBeDestroyed(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_New_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600552B RID: 21803 RVA: 0x0018EC18 File Offset: 0x0018CE18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180758, XrefRangeEnd = 180768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PickupItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_PickupItem_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600552C RID: 21804 RVA: 0x0018EC54 File Offset: 0x0018CE54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 180797, RefRangeEnd = 180799, XrefRangeStart = 180768, XrefRangeEnd = 180797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyItem(bool callOnServer = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref callOnServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_DestroyItem_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600552D RID: 21805 RVA: 0x0018ECA0 File Offset: 0x0018CEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180799, XrefRangeEnd = 180817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy_Networked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_Destroy_Networked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600552E RID: 21806 RVA: 0x0018ECD4 File Offset: 0x0018CED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180817, XrefRangeEnd = 180835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyItemWrapper()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_DestroyItemWrapper_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600552F RID: 21807 RVA: 0x0018ED08 File Offset: 0x0018CF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180835, XrefRangeEnd = 180839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005530 RID: 21808 RVA: 0x0018ED48 File Offset: 0x0018CF48
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 180839, RefRangeEnd = 180844, XrefRangeStart = 180839, XrefRangeEnd = 180839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color32 GetColorFromOutlineColorEnum(BuildableItem.EOutlineColor col)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_GetColorFromOutlineColorEnum_Public_Static_Color32_EOutlineColor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005531 RID: 21809 RVA: 0x0018ED88 File Offset: 0x0018CF88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 180901, RefRangeEnd = 180902, XrefRangeStart = 180844, XrefRangeEnd = 180901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ShowOutline(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_ShowOutline_Public_Virtual_New_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005532 RID: 21810 RVA: 0x0018EDD4 File Offset: 0x0018CFD4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 180905, RefRangeEnd = 180909, XrefRangeStart = 180902, XrefRangeEnd = 180905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowOutline(BuildableItem.EOutlineColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_ShowOutline_Public_Void_EOutlineColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005533 RID: 21811 RVA: 0x0018EE14 File Offset: 0x0018D014
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 180918, RefRangeEnd = 180919, XrefRangeStart = 180909, XrefRangeEnd = 180918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HideOutline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_HideOutline_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005534 RID: 21812 RVA: 0x0018EE50 File Offset: 0x0018D050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180919, XrefRangeEnd = 180998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetFurthestPointFromBoundingCollider(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_GetFurthestPointFromBoundingCollider_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005535 RID: 21813 RVA: 0x0018EE9C File Offset: 0x0018D09C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 181189, RefRangeEnd = 181195, XrefRangeStart = 180998, XrefRangeEnd = 181189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetPenetration(out float x, out float z, out float y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &z;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_GetPenetration_Public_Boolean_byref_Single_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005536 RID: 21814 RVA: 0x0018EF04 File Offset: 0x0018D104
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 181224, RefRangeEnd = 181230, XrefRangeStart = 181195, XrefRangeEnd = 181224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasLoS_IgnoreBuildables(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_HasLoS_IgnoreBuildables_Private_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005537 RID: 21815 RVA: 0x0018EF50 File Offset: 0x0018D150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181230, XrefRangeEnd = 181254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetCulled(bool culled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref culled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_SetCulled_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005538 RID: 21816 RVA: 0x0018EF9C File Offset: 0x0018D19C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181254, XrefRangeEnd = 181259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005539 RID: 21817 RVA: 0x0018EFE0 File Offset: 0x0018D1E0
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 181265, RefRangeEnd = 181281, XrefRangeStart = 181259, XrefRangeEnd = 181265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x0600553A RID: 21818 RVA: 0x0018F03C File Offset: 0x0018D23C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 181301, RefRangeEnd = 181305, XrefRangeStart = 181281, XrefRangeEnd = 181301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildableItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600553B RID: 21819 RVA: 0x0018F078 File Offset: 0x0018D278
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 181337, RefRangeEnd = 181341, XrefRangeStart = 181305, XrefRangeEnd = 181337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600553C RID: 21820 RVA: 0x0018F0B4 File Offset: 0x0018D2B4
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600553D RID: 21821 RVA: 0x0018F0F0 File Offset: 0x0018D2F0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600553E RID: 21822 RVA: 0x0018F12C File Offset: 0x0018D32C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendBuildableItemData_3537728543(ItemInstance instance, string GUID, string parentPropertyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentPropertyCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcWriter___Server_SendBuildableItemData_3537728543_Private_Void_ItemInstance_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600553F RID: 21823 RVA: 0x0018F194 File Offset: 0x0018D394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181341, XrefRangeEnd = 181342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendBuildableItemData_3537728543(ItemInstance instance, string GUID, string parentPropertyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentPropertyCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcLogic___SendBuildableItemData_3537728543_Public_Void_ItemInstance_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005540 RID: 21824 RVA: 0x0018F1FC File Offset: 0x0018D3FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181342, XrefRangeEnd = 181347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendBuildableItemData_3537728543(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcReader___Server_SendBuildableItemData_3537728543_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005541 RID: 21825 RVA: 0x0018F260 File Offset: 0x0018D460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181347, XrefRangeEnd = 181368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveBuildableItemData_3859851844(NetworkConnection conn, ItemInstance instance, string GUID, string parentPropertyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentPropertyCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveBuildableItemData_3859851844_Private_Void_NetworkConnection_ItemInstance_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005542 RID: 21826 RVA: 0x0018F2DC File Offset: 0x0018D4DC
		[CallerCount(0)]
		public unsafe void RpcLogic___ReceiveBuildableItemData_3859851844(NetworkConnection conn, ItemInstance instance, string GUID, string parentPropertyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentPropertyCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcLogic___ReceiveBuildableItemData_3859851844_Public_Void_NetworkConnection_ItemInstance_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005543 RID: 21827 RVA: 0x0018F358 File Offset: 0x0018D558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181368, XrefRangeEnd = 181372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveBuildableItemData_3859851844(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcReader___Observers_ReceiveBuildableItemData_3859851844_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005544 RID: 21828 RVA: 0x0018F3A8 File Offset: 0x0018D5A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181372, XrefRangeEnd = 181384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceiveBuildableItemData_3859851844(NetworkConnection conn, ItemInstance instance, string GUID, string parentPropertyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentPropertyCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcWriter___Target_ReceiveBuildableItemData_3859851844_Private_Void_NetworkConnection_ItemInstance_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005545 RID: 21829 RVA: 0x0018F424 File Offset: 0x0018D624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181384, XrefRangeEnd = 181389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceiveBuildableItemData_3859851844(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcReader___Target_ReceiveBuildableItemData_3859851844_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005546 RID: 21830 RVA: 0x0018F474 File Offset: 0x0018D674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_Destroy_Networked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcWriter___Server_Destroy_Networked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005547 RID: 21831 RVA: 0x0018F4A8 File Offset: 0x0018D6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181389, XrefRangeEnd = 181412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Destroy_Networked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcLogic___Destroy_Networked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005548 RID: 21832 RVA: 0x0018F4DC File Offset: 0x0018D6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181412, XrefRangeEnd = 181436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_Destroy_Networked_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcReader___Server_Destroy_Networked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005549 RID: 21833 RVA: 0x0018F540 File Offset: 0x0018D740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_DestroyItemWrapper_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcWriter___Observers_DestroyItemWrapper_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600554A RID: 21834 RVA: 0x0018F574 File Offset: 0x0018D774
		[CallerCount(0)]
		public unsafe void RpcLogic___DestroyItemWrapper_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcLogic___DestroyItemWrapper_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600554B RID: 21835 RVA: 0x0018F5A8 File Offset: 0x0018D7A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181436, XrefRangeEnd = 181437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_DestroyItemWrapper_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcReader___Observers_DestroyItemWrapper_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600554C RID: 21836 RVA: 0x0018F5F8 File Offset: 0x0018D7F8
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600554D RID: 21837 RVA: 0x00028D19 File Offset: 0x00026F19
		public BuildableItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170019BB RID: 6587
		// (get) Token: 0x0600554E RID: 21838 RVA: 0x0018F634 File Offset: 0x0018D834
		// (set) Token: 0x0600554F RID: 21839 RVA: 0x00028D22 File Offset: 0x00026F22
		public unsafe ItemInstance _ItemInstance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__ItemInstance_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__ItemInstance_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019BC RID: 6588
		// (get) Token: 0x06005550 RID: 21840 RVA: 0x0018F664 File Offset: 0x0018D864
		// (set) Token: 0x06005551 RID: 21841 RVA: 0x00028D41 File Offset: 0x00026F41
		public unsafe Property _ParentProperty_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__ParentProperty_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__ParentProperty_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019BD RID: 6589
		// (get) Token: 0x06005552 RID: 21842 RVA: 0x0018F694 File Offset: 0x0018D894
		// (set) Token: 0x06005553 RID: 21843 RVA: 0x00028D60 File Offset: 0x00026F60
		public unsafe bool _IsDestroyed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__IsDestroyed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__IsDestroyed_k__BackingField)) = value;
			}
		}

		// Token: 0x170019BE RID: 6590
		// (get) Token: 0x06005554 RID: 21844 RVA: 0x0018F6BC File Offset: 0x0018D8BC
		// (set) Token: 0x06005555 RID: 21845 RVA: 0x00028D7B File Offset: 0x00026F7B
		public unsafe bool _Initialized_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__Initialized_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__Initialized_k__BackingField)) = value;
			}
		}

		// Token: 0x170019BF RID: 6591
		// (get) Token: 0x06005556 RID: 21846 RVA: 0x0018F6E4 File Offset: 0x0018D8E4
		// (set) Token: 0x06005557 RID: 21847 RVA: 0x00028D96 File Offset: 0x00026F96
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x170019C0 RID: 6592
		// (get) Token: 0x06005558 RID: 21848 RVA: 0x0018F70C File Offset: 0x0018D90C
		// (set) Token: 0x06005559 RID: 21849 RVA: 0x00028DB1 File Offset: 0x00026FB1
		public unsafe bool _IsCulled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__IsCulled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__IsCulled_k__BackingField)) = value;
			}
		}

		// Token: 0x170019C1 RID: 6593
		// (get) Token: 0x0600555A RID: 21850 RVA: 0x0018F734 File Offset: 0x0018D934
		// (set) Token: 0x0600555B RID: 21851 RVA: 0x00028DCC File Offset: 0x00026FCC
		public unsafe bool isGhost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_isGhost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_isGhost)) = value;
			}
		}

		// Token: 0x170019C2 RID: 6594
		// (get) Token: 0x0600555C RID: 21852 RVA: 0x0018F75C File Offset: 0x0018D95C
		// (set) Token: 0x0600555D RID: 21853 RVA: 0x00028DE7 File Offset: 0x00026FE7
		public unsafe GameObject buildHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_buildHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_buildHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C3 RID: 6595
		// (get) Token: 0x0600555E RID: 21854 RVA: 0x0018F78C File Offset: 0x0018D98C
		// (set) Token: 0x0600555F RID: 21855 RVA: 0x00028E06 File Offset: 0x00027006
		public unsafe float HoldDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_HoldDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_HoldDistance)) = value;
			}
		}

		// Token: 0x170019C4 RID: 6596
		// (get) Token: 0x06005560 RID: 21856 RVA: 0x0018F7B4 File Offset: 0x0018D9B4
		// (set) Token: 0x06005561 RID: 21857 RVA: 0x00028E21 File Offset: 0x00027021
		public unsafe Transform BuildPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_BuildPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_BuildPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C5 RID: 6597
		// (get) Token: 0x06005562 RID: 21858 RVA: 0x0018F7E4 File Offset: 0x0018D9E4
		// (set) Token: 0x06005563 RID: 21859 RVA: 0x00028E40 File Offset: 0x00027040
		public unsafe Transform MidAirCenterPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_MidAirCenterPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_MidAirCenterPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C6 RID: 6598
		// (get) Token: 0x06005564 RID: 21860 RVA: 0x0018F814 File Offset: 0x0018DA14
		// (set) Token: 0x06005565 RID: 21861 RVA: 0x00028E5F File Offset: 0x0002705F
		public unsafe BoxCollider BoundingCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_BoundingCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_BoundingCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C7 RID: 6599
		// (get) Token: 0x06005566 RID: 21862 RVA: 0x0018F844 File Offset: 0x0018DA44
		// (set) Token: 0x06005567 RID: 21863 RVA: 0x00028E7E File Offset: 0x0002707E
		public unsafe List<GameObject> OutlineRenderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_OutlineRenderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_OutlineRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C8 RID: 6600
		// (get) Token: 0x06005568 RID: 21864 RVA: 0x0018F874 File Offset: 0x0018DA74
		// (set) Token: 0x06005569 RID: 21865 RVA: 0x00028E9D File Offset: 0x0002709D
		public unsafe bool IncludeOutlineRendererChildren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_IncludeOutlineRendererChildren);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_IncludeOutlineRendererChildren)) = value;
			}
		}

		// Token: 0x170019C9 RID: 6601
		// (get) Token: 0x0600556A RID: 21866 RVA: 0x0018F89C File Offset: 0x0018DA9C
		// (set) Token: 0x0600556B RID: 21867 RVA: 0x00028EB8 File Offset: 0x000270B8
		public unsafe Outlinable OutlineEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_OutlineEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Outlinable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_OutlineEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019CA RID: 6602
		// (get) Token: 0x0600556C RID: 21868 RVA: 0x0018F8CC File Offset: 0x0018DACC
		// (set) Token: 0x0600556D RID: 21869 RVA: 0x00028ED7 File Offset: 0x000270D7
		public unsafe Il2CppReferenceArray<GameObject> GameObjectsToCull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_GameObjectsToCull);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_GameObjectsToCull), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019CB RID: 6603
		// (get) Token: 0x0600556E RID: 21870 RVA: 0x0018F8FC File Offset: 0x0018DAFC
		// (set) Token: 0x0600556F RID: 21871 RVA: 0x00028EF6 File Offset: 0x000270F6
		public unsafe List<MeshRenderer> MeshesToCull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_MeshesToCull);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_MeshesToCull), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019CC RID: 6604
		// (get) Token: 0x06005570 RID: 21872 RVA: 0x0018F92C File Offset: 0x0018DB2C
		// (set) Token: 0x06005571 RID: 21873 RVA: 0x00028F15 File Offset: 0x00027115
		public unsafe UnityEvent onInitialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_onInitialized);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_onInitialized), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019CD RID: 6605
		// (get) Token: 0x06005572 RID: 21874 RVA: 0x0018F95C File Offset: 0x0018DB5C
		// (set) Token: 0x06005573 RID: 21875 RVA: 0x00028F34 File Offset: 0x00027134
		public unsafe UnityEvent onDestroyed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_onDestroyed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_onDestroyed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019CE RID: 6606
		// (get) Token: 0x06005574 RID: 21876 RVA: 0x0018F98C File Offset: 0x0018DB8C
		// (set) Token: 0x06005575 RID: 21877 RVA: 0x00028F53 File Offset: 0x00027153
		public unsafe Action<BuildableItem> onDestroyedWithParameter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_onDestroyedWithParameter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BuildableItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_onDestroyedWithParameter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019CF RID: 6607
		// (get) Token: 0x06005576 RID: 21878 RVA: 0x0018F9BC File Offset: 0x0018DBBC
		// (set) Token: 0x06005577 RID: 21879 RVA: 0x00028F72 File Offset: 0x00027172
		public unsafe bool _LocallyBuilt_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__LocallyBuilt_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__LocallyBuilt_k__BackingField)) = value;
			}
		}

		// Token: 0x170019D0 RID: 6608
		// (get) Token: 0x06005578 RID: 21880 RVA: 0x0018F9E4 File Offset: 0x0018DBE4
		// (set) Token: 0x06005579 RID: 21881 RVA: 0x00028F8D File Offset: 0x0002718D
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019D1 RID: 6609
		// (get) Token: 0x0600557A RID: 21882 RVA: 0x0018FA14 File Offset: 0x0018DC14
		// (set) Token: 0x0600557B RID: 21883 RVA: 0x00028FAC File Offset: 0x000271AC
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019D2 RID: 6610
		// (get) Token: 0x0600557C RID: 21884 RVA: 0x0018FA44 File Offset: 0x0018DC44
		// (set) Token: 0x0600557D RID: 21885 RVA: 0x00028FCB File Offset: 0x000271CB
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x170019D3 RID: 6611
		// (get) Token: 0x0600557E RID: 21886 RVA: 0x0018FA6C File Offset: 0x0018DC6C
		// (set) Token: 0x0600557F RID: 21887 RVA: 0x00028FE6 File Offset: 0x000271E6
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170019D4 RID: 6612
		// (get) Token: 0x06005580 RID: 21888 RVA: 0x0018FA94 File Offset: 0x0018DC94
		// (set) Token: 0x06005581 RID: 21889 RVA: 0x00029001 File Offset: 0x00027201
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003986 RID: 14726
		private static readonly IntPtr NativeFieldInfoPtr__ItemInstance_k__BackingField;

		// Token: 0x04003987 RID: 14727
		private static readonly IntPtr NativeFieldInfoPtr__ParentProperty_k__BackingField;

		// Token: 0x04003988 RID: 14728
		private static readonly IntPtr NativeFieldInfoPtr__IsDestroyed_k__BackingField;

		// Token: 0x04003989 RID: 14729
		private static readonly IntPtr NativeFieldInfoPtr__Initialized_k__BackingField;

		// Token: 0x0400398A RID: 14730
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x0400398B RID: 14731
		private static readonly IntPtr NativeFieldInfoPtr__IsCulled_k__BackingField;

		// Token: 0x0400398C RID: 14732
		private static readonly IntPtr NativeFieldInfoPtr_isGhost;

		// Token: 0x0400398D RID: 14733
		private static readonly IntPtr NativeFieldInfoPtr_buildHandler;

		// Token: 0x0400398E RID: 14734
		private static readonly IntPtr NativeFieldInfoPtr_HoldDistance;

		// Token: 0x0400398F RID: 14735
		private static readonly IntPtr NativeFieldInfoPtr_BuildPoint;

		// Token: 0x04003990 RID: 14736
		private static readonly IntPtr NativeFieldInfoPtr_MidAirCenterPoint;

		// Token: 0x04003991 RID: 14737
		private static readonly IntPtr NativeFieldInfoPtr_BoundingCollider;

		// Token: 0x04003992 RID: 14738
		private static readonly IntPtr NativeFieldInfoPtr_OutlineRenderers;

		// Token: 0x04003993 RID: 14739
		private static readonly IntPtr NativeFieldInfoPtr_IncludeOutlineRendererChildren;

		// Token: 0x04003994 RID: 14740
		private static readonly IntPtr NativeFieldInfoPtr_OutlineEffect;

		// Token: 0x04003995 RID: 14741
		private static readonly IntPtr NativeFieldInfoPtr_GameObjectsToCull;

		// Token: 0x04003996 RID: 14742
		private static readonly IntPtr NativeFieldInfoPtr_MeshesToCull;

		// Token: 0x04003997 RID: 14743
		private static readonly IntPtr NativeFieldInfoPtr_onInitialized;

		// Token: 0x04003998 RID: 14744
		private static readonly IntPtr NativeFieldInfoPtr_onDestroyed;

		// Token: 0x04003999 RID: 14745
		private static readonly IntPtr NativeFieldInfoPtr_onDestroyedWithParameter;

		// Token: 0x0400399A RID: 14746
		private static readonly IntPtr NativeFieldInfoPtr__LocallyBuilt_k__BackingField;

		// Token: 0x0400399B RID: 14747
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x0400399C RID: 14748
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x0400399D RID: 14749
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x0400399E RID: 14750
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400399F RID: 14751
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040039A0 RID: 14752
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemInstance_Public_get_ItemInstance_0;

		// Token: 0x040039A1 RID: 14753
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemInstance_Protected_set_Void_ItemInstance_0;

		// Token: 0x040039A2 RID: 14754
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0;

		// Token: 0x040039A3 RID: 14755
		private static readonly IntPtr NativeMethodInfoPtr_set_ParentProperty_Protected_set_Void_Property_0;

		// Token: 0x040039A4 RID: 14756
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDestroyed_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040039A5 RID: 14757
		private static readonly IntPtr NativeMethodInfoPtr_set_IsDestroyed_Protected_set_Void_Boolean_0;

		// Token: 0x040039A6 RID: 14758
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0;

		// Token: 0x040039A7 RID: 14759
		private static readonly IntPtr NativeMethodInfoPtr_set_Initialized_Protected_set_Void_Boolean_0;

		// Token: 0x040039A8 RID: 14760
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x040039A9 RID: 14761
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x040039AA RID: 14762
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCulled_Public_get_Boolean_0;

		// Token: 0x040039AB RID: 14763
		private static readonly IntPtr NativeMethodInfoPtr_set_IsCulled_Protected_set_Void_Boolean_0;

		// Token: 0x040039AC RID: 14764
		private static readonly IntPtr NativeMethodInfoPtr_get_BuildHandler_Public_get_GameObject_0;

		// Token: 0x040039AD RID: 14765
		private static readonly IntPtr NativeMethodInfoPtr_AddChildMeshes_Public_Void_0;

		// Token: 0x040039AE RID: 14766
		private static readonly IntPtr NativeMethodInfoPtr_get_LocallyBuilt_Public_get_Boolean_0;

		// Token: 0x040039AF RID: 14767
		private static readonly IntPtr NativeMethodInfoPtr_set_LocallyBuilt_Protected_set_Void_Boolean_0;

		// Token: 0x040039B0 RID: 14768
		private static readonly IntPtr NativeMethodInfoPtr_SetLocallyBuilt_Public_Void_0;

		// Token: 0x040039B1 RID: 14769
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040039B2 RID: 14770
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040039B3 RID: 14771
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x040039B4 RID: 14772
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040039B5 RID: 14773
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x040039B6 RID: 14774
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x040039B7 RID: 14775
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x040039B8 RID: 14776
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x040039B9 RID: 14777
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040039BA RID: 14778
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x040039BB RID: 14779
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040039BC RID: 14780
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1;

		// Token: 0x040039BD RID: 14781
		private static readonly IntPtr NativeMethodInfoPtr_GetProperty_Protected_Virtual_New_Property_Transform_0;

		// Token: 0x040039BE RID: 14782
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x040039BF RID: 14783
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040039C0 RID: 14784
		private static readonly IntPtr NativeMethodInfoPtr_SendInitToClient_Protected_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x040039C1 RID: 14785
		private static readonly IntPtr NativeMethodInfoPtr_SendBuildableItemData_Public_Void_ItemInstance_String_String_0;

		// Token: 0x040039C2 RID: 14786
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveBuildableItemData_Public_Void_NetworkConnection_ItemInstance_String_String_0;

		// Token: 0x040039C3 RID: 14787
		private static readonly IntPtr NativeMethodInfoPtr_InitializeBuildableItem_Public_Virtual_New_Void_ItemInstance_String_String_0;

		// Token: 0x040039C4 RID: 14788
		private static readonly IntPtr NativeMethodInfoPtr_CanBePickedUp_Public_Boolean_byref_String_0;

		// Token: 0x040039C5 RID: 14789
		private static readonly IntPtr NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_New_Boolean_byref_String_0;

		// Token: 0x040039C6 RID: 14790
		private static readonly IntPtr NativeMethodInfoPtr_PickupItem_Public_Virtual_New_Void_0;

		// Token: 0x040039C7 RID: 14791
		private static readonly IntPtr NativeMethodInfoPtr_DestroyItem_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040039C8 RID: 14792
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Networked_Private_Void_0;

		// Token: 0x040039C9 RID: 14793
		private static readonly IntPtr NativeMethodInfoPtr_DestroyItemWrapper_Private_Void_0;

		// Token: 0x040039CA RID: 14794
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x040039CB RID: 14795
		private static readonly IntPtr NativeMethodInfoPtr_GetColorFromOutlineColorEnum_Public_Static_Color32_EOutlineColor_0;

		// Token: 0x040039CC RID: 14796
		private static readonly IntPtr NativeMethodInfoPtr_ShowOutline_Public_Virtual_New_Void_Color_0;

		// Token: 0x040039CD RID: 14797
		private static readonly IntPtr NativeMethodInfoPtr_ShowOutline_Public_Void_EOutlineColor_0;

		// Token: 0x040039CE RID: 14798
		private static readonly IntPtr NativeMethodInfoPtr_HideOutline_Public_Virtual_New_Void_0;

		// Token: 0x040039CF RID: 14799
		private static readonly IntPtr NativeMethodInfoPtr_GetFurthestPointFromBoundingCollider_Public_Vector3_Vector3_0;

		// Token: 0x040039D0 RID: 14800
		private static readonly IntPtr NativeMethodInfoPtr_GetPenetration_Public_Boolean_byref_Single_byref_Single_byref_Single_0;

		// Token: 0x040039D1 RID: 14801
		private static readonly IntPtr NativeMethodInfoPtr_HasLoS_IgnoreBuildables_Private_Boolean_Vector3_0;

		// Token: 0x040039D2 RID: 14802
		private static readonly IntPtr NativeMethodInfoPtr_SetCulled_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040039D3 RID: 14803
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x040039D4 RID: 14804
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0;

		// Token: 0x040039D5 RID: 14805
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040039D6 RID: 14806
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040039D7 RID: 14807
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040039D8 RID: 14808
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040039D9 RID: 14809
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendBuildableItemData_3537728543_Private_Void_ItemInstance_String_String_0;

		// Token: 0x040039DA RID: 14810
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendBuildableItemData_3537728543_Public_Void_ItemInstance_String_String_0;

		// Token: 0x040039DB RID: 14811
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendBuildableItemData_3537728543_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040039DC RID: 14812
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveBuildableItemData_3859851844_Private_Void_NetworkConnection_ItemInstance_String_String_0;

		// Token: 0x040039DD RID: 14813
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveBuildableItemData_3859851844_Public_Void_NetworkConnection_ItemInstance_String_String_0;

		// Token: 0x040039DE RID: 14814
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveBuildableItemData_3859851844_Private_Void_PooledReader_Channel_0;

		// Token: 0x040039DF RID: 14815
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceiveBuildableItemData_3859851844_Private_Void_NetworkConnection_ItemInstance_String_String_0;

		// Token: 0x040039E0 RID: 14816
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceiveBuildableItemData_3859851844_Private_Void_PooledReader_Channel_0;

		// Token: 0x040039E1 RID: 14817
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_Destroy_Networked_2166136261_Private_Void_0;

		// Token: 0x040039E2 RID: 14818
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Destroy_Networked_2166136261_Private_Void_0;

		// Token: 0x040039E3 RID: 14819
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_Destroy_Networked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040039E4 RID: 14820
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_DestroyItemWrapper_2166136261_Private_Void_0;

		// Token: 0x040039E5 RID: 14821
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___DestroyItemWrapper_2166136261_Private_Void_0;

		// Token: 0x040039E6 RID: 14822
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_DestroyItemWrapper_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040039E7 RID: 14823
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x020009BA RID: 2490
		[OriginalName("Assembly-CSharp.dll", "", "EOutlineColor")]
		public enum EOutlineColor
		{
			// Token: 0x04008A00 RID: 35328
			White,
			// Token: 0x04008A01 RID: 35329
			Blue,
			// Token: 0x04008A02 RID: 35330
			LightBlue
		}

		// Token: 0x020009BB RID: 2491
		[ObfuscatedName("ScheduleOne.EntityFramework.BuildableItem+<>c__DisplayClass75_0")]
		public sealed class __c__DisplayClass75_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CC23 RID: 52259 RVA: 0x00313F78 File Offset: 0x00312178
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass75_0()
			{
				Il2CppClassPointerStore<BuildableItem.__c__DisplayClass75_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "<>c__DisplayClass75_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildableItem.__c__DisplayClass75_0>.NativeClassPtr);
				BuildableItem.__c__DisplayClass75_0.NativeFieldInfoPtr_parentPropertyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem.__c__DisplayClass75_0>.NativeClassPtr, "parentPropertyCode");
				BuildableItem.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem.__c__DisplayClass75_0>.NativeClassPtr, 100673931);
				BuildableItem.__c__DisplayClass75_0.NativeMethodInfoPtr__InitializeBuildableItem_b__0_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem.__c__DisplayClass75_0>.NativeClassPtr, 100673932);
				BuildableItem.__c__DisplayClass75_0.NativeMethodInfoPtr__InitializeBuildableItem_b__1_Internal_Boolean_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem.__c__DisplayClass75_0>.NativeClassPtr, 100673933);
			}

			// Token: 0x0600CC24 RID: 52260 RVA: 0x00313FF4 File Offset: 0x003121F4
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass75_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildableItem.__c__DisplayClass75_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CC25 RID: 52261 RVA: 0x00314030 File Offset: 0x00312230
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180489, XrefRangeEnd = 180491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _InitializeBuildableItem_b__0(Property p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.__c__DisplayClass75_0.NativeMethodInfoPtr__InitializeBuildableItem_b__0_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CC26 RID: 52262 RVA: 0x00314080 File Offset: 0x00312280
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _InitializeBuildableItem_b__1(Business b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.__c__DisplayClass75_0.NativeMethodInfoPtr__InitializeBuildableItem_b__1_Internal_Boolean_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CC27 RID: 52263 RVA: 0x000634E9 File Offset: 0x000616E9
			public __c__DisplayClass75_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F99 RID: 16281
			// (get) Token: 0x0600CC28 RID: 52264 RVA: 0x003140D0 File Offset: 0x003122D0
			// (set) Token: 0x0600CC29 RID: 52265 RVA: 0x000634F2 File Offset: 0x000616F2
			public unsafe string parentPropertyCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.__c__DisplayClass75_0.NativeFieldInfoPtr_parentPropertyCode);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.__c__DisplayClass75_0.NativeFieldInfoPtr_parentPropertyCode), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008A03 RID: 35331
			private static readonly IntPtr NativeFieldInfoPtr_parentPropertyCode;

			// Token: 0x04008A04 RID: 35332
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A05 RID: 35333
			private static readonly IntPtr NativeMethodInfoPtr__InitializeBuildableItem_b__0_Internal_Boolean_Property_0;

			// Token: 0x04008A06 RID: 35334
			private static readonly IntPtr NativeMethodInfoPtr__InitializeBuildableItem_b__1_Internal_Boolean_Business_0;
		}
	}
}
