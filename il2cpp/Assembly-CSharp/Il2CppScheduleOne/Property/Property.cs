using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Delivery;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Misc;
using Il2CppScheduleOne.Money;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Property
{
	// Token: 0x0200050F RID: 1295
	public class Property : NetworkBehaviour
	{
		// Token: 0x0600729A RID: 29338 RVA: 0x001F50E4 File Offset: 0x001F32E4
		// Note: this type is marked as 'beforefieldinit'.
		static Property()
		{
			Il2CppClassPointerStore<Property>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property", "Property");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Property>.NativeClassPtr);
			Property.NativeFieldInfoPtr_Properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "Properties");
			Property.NativeFieldInfoPtr_UnownedProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "UnownedProperties");
			Property.NativeFieldInfoPtr_OwnedProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "OwnedProperties");
			Property.NativeFieldInfoPtr_onPropertyAcquired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "onPropertyAcquired");
			Property.NativeFieldInfoPtr_onThisPropertyAcquired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "onThisPropertyAcquired");
			Property.NativeFieldInfoPtr__IsOwned_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "<IsOwned>k__BackingField");
			Property.NativeFieldInfoPtr__Employees_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "<Employees>k__BackingField");
			Property.NativeFieldInfoPtr__WorldspaceUIContainer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "<WorldspaceUIContainer>k__BackingField");
			Property.NativeFieldInfoPtr__IsContentCulled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "<IsContentCulled>k__BackingField");
			Property.NativeFieldInfoPtr_propertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "propertyName");
			Property.NativeFieldInfoPtr_AvailableInDemo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "AvailableInDemo");
			Property.NativeFieldInfoPtr_propertyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "propertyCode");
			Property.NativeFieldInfoPtr_Price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "Price");
			Property.NativeFieldInfoPtr_DefaultRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "DefaultRotation");
			Property.NativeFieldInfoPtr_EmployeeCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "EmployeeCapacity");
			Property.NativeFieldInfoPtr_OwnedByDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "OwnedByDefault");
			Property.NativeFieldInfoPtr_DEBUG_SET_OWNED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "DEBUG_SET_OWNED");
			Property.NativeFieldInfoPtr_IsOwnedVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "IsOwnedVariable");
			Property.NativeFieldInfoPtr_ContentCullingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "ContentCullingEnabled");
			Property.NativeFieldInfoPtr_MinimumCullingDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "MinimumCullingDistance");
			Property.NativeFieldInfoPtr_ObjectsToCull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "ObjectsToCull");
			Property.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "Container");
			Property.NativeFieldInfoPtr_EmployeeContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "EmployeeContainer");
			Property.NativeFieldInfoPtr_SpawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "SpawnPoint");
			Property.NativeFieldInfoPtr_InteriorSpawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "InteriorSpawnPoint");
			Property.NativeFieldInfoPtr_ForSaleSign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "ForSaleSign");
			Property.NativeFieldInfoPtr_BoundingBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "BoundingBox");
			Property.NativeFieldInfoPtr_PoI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "PoI");
			Property.NativeFieldInfoPtr_ListingPoster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "ListingPoster");
			Property.NativeFieldInfoPtr_NPCSpawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "NPCSpawnPoint");
			Property.NativeFieldInfoPtr_EmployeeIdlePoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "EmployeeIdlePoints");
			Property.NativeFieldInfoPtr_Switches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "Switches");
			Property.NativeFieldInfoPtr_Toggleables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "Toggleables");
			Property.NativeFieldInfoPtr_DisposalArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "DisposalArea");
			Property.NativeFieldInfoPtr_LoadingDocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "LoadingDocks");
			Property.NativeFieldInfoPtr_BuildableItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "BuildableItems");
			Property.NativeFieldInfoPtr_Configurables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "Configurables");
			Property.NativeFieldInfoPtr_propertyBoundsColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "propertyBoundsColliders");
			Property.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "loader");
			Property.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			Property.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			Property.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "<HasChanged>k__BackingField");
			Property.NativeFieldInfoPtr_savedObjectPaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "savedObjectPaths");
			Property.NativeFieldInfoPtr_savedEmployeePaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "savedEmployeePaths");
			Property.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Property.PropertyAssembly-CSharp.dll_Excuted");
			Property.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Property.PropertyAssembly-CSharp.dll_Excuted");
			Property.NativeMethodInfoPtr_get_IsOwned_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677679);
			Property.NativeMethodInfoPtr_set_IsOwned_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677680);
			Property.NativeMethodInfoPtr_get_Employees_Public_get_List_1_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677681);
			Property.NativeMethodInfoPtr_set_Employees_Protected_set_Void_List_1_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677682);
			Property.NativeMethodInfoPtr_get_WorldspaceUIContainer_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677683);
			Property.NativeMethodInfoPtr_set_WorldspaceUIContainer_Protected_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677684);
			Property.NativeMethodInfoPtr_get_IsContentCulled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677685);
			Property.NativeMethodInfoPtr_set_IsContentCulled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677686);
			Property.NativeMethodInfoPtr_get_PropertyName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677687);
			Property.NativeMethodInfoPtr_get_PropertyCode_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677688);
			Property.NativeMethodInfoPtr_get_LoadingDockCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677689);
			Property.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677690);
			Property.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677691);
			Property.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677692);
			Property.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677693);
			Property.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677694);
			Property.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677695);
			Property.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677696);
			Property.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677697);
			Property.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677698);
			Property.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677699);
			Property.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677700);
			Property.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677701);
			Property.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677702);
			Property.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677703);
			Property.NativeMethodInfoPtr_AddConfigurable_Public_Void_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677704);
			Property.NativeMethodInfoPtr_RemoveConfigurable_Public_Void_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677705);
			Property.NativeMethodInfoPtr_UpdateCulling_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677706);
			Property.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677707);
			Property.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677708);
			Property.NativeMethodInfoPtr_GetNetworth_Protected_Virtual_New_Void_FloatContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677709);
			Property.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677710);
			Property.NativeMethodInfoPtr_SetOwned_Server_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677711);
			Property.NativeMethodInfoPtr_ReceiveOwned_Networked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677712);
			Property.NativeMethodInfoPtr_RecieveOwned_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677713);
			Property.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677714);
			Property.NativeMethodInfoPtr_SetOwned_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677715);
			Property.NativeMethodInfoPtr_SetBoundsVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677716);
			Property.NativeMethodInfoPtr_SetContentCulled_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677717);
			Property.NativeMethodInfoPtr_RegisterEmployee_Public_Int32_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677718);
			Property.NativeMethodInfoPtr_DeregisterEmployee_Public_Void_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677719);
			Property.NativeMethodInfoPtr_ToggleableActioned_Private_Void_InteractableToggleable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677720);
			Property.NativeMethodInfoPtr_SendToggleableState_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677721);
			Property.NativeMethodInfoPtr_SetToggleableState_Public_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677722);
			Property.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677723);
			Property.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677724);
			Property.NativeMethodInfoPtr_DeleteUnapprovedFiles_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677725);
			Property.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PropertyData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677726);
			Property.NativeMethodInfoPtr_DoBoundsContainPoint_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677727);
			Property.NativeMethodInfoPtr_IsPointInsideBox_Private_Boolean_Vector3_BoxCollider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677728);
			Property.NativeMethodInfoPtr_GetUnassignedBeds_Public_List_1_Bed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677729);
			Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677730);
			Property.NativeMethodInfoPtr__Awake_b__80_0_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677732);
			Property.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677733);
			Property.NativeMethodInfoPtr__RecieveOwned_b__93_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677734);
			Property.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677735);
			Property.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677736);
			Property.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677737);
			Property.NativeMethodInfoPtr_RpcWriter___Server_SetOwned_Server_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677738);
			Property.NativeMethodInfoPtr_RpcLogic___SetOwned_Server_2166136261_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677739);
			Property.NativeMethodInfoPtr_RpcReader___Server_SetOwned_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677740);
			Property.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveOwned_Networked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677741);
			Property.NativeMethodInfoPtr_RpcLogic___ReceiveOwned_Networked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677742);
			Property.NativeMethodInfoPtr_RpcReader___Observers_ReceiveOwned_Networked_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677743);
			Property.NativeMethodInfoPtr_RpcWriter___Server_SendToggleableState_3658436649_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677744);
			Property.NativeMethodInfoPtr_RpcLogic___SendToggleableState_3658436649_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677745);
			Property.NativeMethodInfoPtr_RpcReader___Server_SendToggleableState_3658436649_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677746);
			Property.NativeMethodInfoPtr_RpcWriter___Observers_SetToggleableState_338960014_Private_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677747);
			Property.NativeMethodInfoPtr_RpcLogic___SetToggleableState_338960014_Public_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677748);
			Property.NativeMethodInfoPtr_RpcReader___Observers_SetToggleableState_338960014_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677749);
			Property.NativeMethodInfoPtr_RpcWriter___Target_SetToggleableState_338960014_Private_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677750);
			Property.NativeMethodInfoPtr_RpcReader___Target_SetToggleableState_338960014_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677751);
			Property.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100677752);
		}

		// Token: 0x170022E7 RID: 8935
		// (get) Token: 0x0600729B RID: 29339 RVA: 0x001F5A60 File Offset: 0x001F3C60
		// (set) Token: 0x0600729C RID: 29340 RVA: 0x001F5A9C File Offset: 0x001F3C9C
		public unsafe bool IsOwned
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_IsOwned_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_set_IsOwned_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170022E8 RID: 8936
		// (get) Token: 0x0600729D RID: 29341 RVA: 0x001F5ADC File Offset: 0x001F3CDC
		// (set) Token: 0x0600729E RID: 29342 RVA: 0x001F5B1C File Offset: 0x001F3D1C
		public unsafe List<Employee> Employees
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_Employees_Public_get_List_1_Employee_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Employee>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_set_Employees_Protected_set_Void_List_1_Employee_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170022E9 RID: 8937
		// (get) Token: 0x0600729F RID: 29343 RVA: 0x001F5B60 File Offset: 0x001F3D60
		// (set) Token: 0x060072A0 RID: 29344 RVA: 0x001F5BA0 File Offset: 0x001F3DA0
		public unsafe RectTransform WorldspaceUIContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_WorldspaceUIContainer_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_set_WorldspaceUIContainer_Protected_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170022EA RID: 8938
		// (get) Token: 0x060072A1 RID: 29345 RVA: 0x001F5BE4 File Offset: 0x001F3DE4
		// (set) Token: 0x060072A2 RID: 29346 RVA: 0x001F5C20 File Offset: 0x001F3E20
		public unsafe bool IsContentCulled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_IsContentCulled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_set_IsContentCulled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170022EB RID: 8939
		// (get) Token: 0x060072A3 RID: 29347 RVA: 0x001F5C60 File Offset: 0x001F3E60
		public unsafe string PropertyName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_PropertyName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170022EC RID: 8940
		// (get) Token: 0x060072A4 RID: 29348 RVA: 0x001F5C98 File Offset: 0x001F3E98
		public unsafe string PropertyCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_PropertyCode_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170022ED RID: 8941
		// (get) Token: 0x060072A5 RID: 29349 RVA: 0x001F5CD0 File Offset: 0x001F3ED0
		public unsafe int LoadingDockCount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 224748, RefRangeEnd = 224751, XrefRangeStart = 224748, XrefRangeEnd = 224748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_LoadingDockCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170022EE RID: 8942
		// (get) Token: 0x060072A6 RID: 29350 RVA: 0x001F5D0C File Offset: 0x001F3F0C
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170022EF RID: 8943
		// (get) Token: 0x060072A7 RID: 29351 RVA: 0x001F5D44 File Offset: 0x001F3F44
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224751, XrefRangeEnd = 224753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170022F0 RID: 8944
		// (get) Token: 0x060072A8 RID: 29352 RVA: 0x001F5D7C File Offset: 0x001F3F7C
		public unsafe virtual Loader Loader
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 166410, RefRangeEnd = 166424, XrefRangeStart = 166410, XrefRangeEnd = 166424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x170022F1 RID: 8945
		// (get) Token: 0x060072A9 RID: 29353 RVA: 0x001F5DBC File Offset: 0x001F3FBC
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30138, RefRangeEnd = 30158, XrefRangeStart = 30138, XrefRangeEnd = 30158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170022F2 RID: 8946
		// (get) Token: 0x060072AA RID: 29354 RVA: 0x001F5DF8 File Offset: 0x001F3FF8
		// (set) Token: 0x060072AB RID: 29355 RVA: 0x001F5E38 File Offset: 0x001F4038
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170022F3 RID: 8947
		// (get) Token: 0x060072AC RID: 29356 RVA: 0x001F5E7C File Offset: 0x001F407C
		// (set) Token: 0x060072AD RID: 29357 RVA: 0x001F5EBC File Offset: 0x001F40BC
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 224753, RefRangeEnd = 224755, XrefRangeStart = 224753, XrefRangeEnd = 224753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224755, XrefRangeEnd = 224756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170022F4 RID: 8948
		// (get) Token: 0x060072AE RID: 29358 RVA: 0x001F5F00 File Offset: 0x001F4100
		// (set) Token: 0x060072AF RID: 29359 RVA: 0x001F5F3C File Offset: 0x001F413C
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060072B0 RID: 29360 RVA: 0x001F5F7C File Offset: 0x001F417C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224756, XrefRangeEnd = 224757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072B1 RID: 29361 RVA: 0x001F5FB8 File Offset: 0x001F41B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224757, XrefRangeEnd = 224763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072B2 RID: 29362 RVA: 0x001F5FF4 File Offset: 0x001F41F4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 224781, RefRangeEnd = 224786, XrefRangeStart = 224763, XrefRangeEnd = 224781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072B3 RID: 29363 RVA: 0x001F6030 File Offset: 0x001F4230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224786, XrefRangeEnd = 224787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072B4 RID: 29364 RVA: 0x001F606C File Offset: 0x001F426C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 224793, RefRangeEnd = 224805, XrefRangeStart = 224787, XrefRangeEnd = 224793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddConfigurable(IConfigurable configurable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configurable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_AddConfigurable_Public_Void_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072B5 RID: 29365 RVA: 0x001F60B0 File Offset: 0x001F42B0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 224811, RefRangeEnd = 224823, XrefRangeStart = 224805, XrefRangeEnd = 224811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveConfigurable(IConfigurable configurable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configurable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RemoveConfigurable_Public_Void_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072B6 RID: 29366 RVA: 0x001F60F4 File Offset: 0x001F42F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224845, RefRangeEnd = 224846, XrefRangeStart = 224823, XrefRangeEnd = 224845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCulling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_UpdateCulling_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072B7 RID: 29367 RVA: 0x001F6128 File Offset: 0x001F4328
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 224855, RefRangeEnd = 224857, XrefRangeStart = 224846, XrefRangeEnd = 224855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072B8 RID: 29368 RVA: 0x001F6178 File Offset: 0x001F4378
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224891, RefRangeEnd = 224892, XrefRangeStart = 224857, XrefRangeEnd = 224891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072B9 RID: 29369 RVA: 0x001F61B4 File Offset: 0x001F43B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224892, XrefRangeEnd = 224893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetNetworth(MoneyManager.FloatContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_GetNetworth_Protected_Virtual_New_Void_FloatContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072BA RID: 29370 RVA: 0x001F6204 File Offset: 0x001F4404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224893, XrefRangeEnd = 224912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072BB RID: 29371 RVA: 0x001F6240 File Offset: 0x001F4440
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 224933, RefRangeEnd = 224937, XrefRangeStart = 224912, XrefRangeEnd = 224933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOwned_Server()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_SetOwned_Server_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072BC RID: 29372 RVA: 0x001F6274 File Offset: 0x001F4474
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 224957, RefRangeEnd = 224959, XrefRangeStart = 224937, XrefRangeEnd = 224957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveOwned_Networked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_ReceiveOwned_Networked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072BD RID: 29373 RVA: 0x001F62A8 File Offset: 0x001F44A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 225015, RefRangeEnd = 225016, XrefRangeStart = 224959, XrefRangeEnd = 225015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RecieveOwned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_RecieveOwned_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072BE RID: 29374 RVA: 0x001F62E4 File Offset: 0x001F44E4
		[CallerCount(0)]
		public unsafe virtual bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060072BF RID: 29375 RVA: 0x001F632C File Offset: 0x001F452C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 225017, RefRangeEnd = 225020, XrefRangeStart = 225016, XrefRangeEnd = 225017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOwned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_SetOwned_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072C0 RID: 29376 RVA: 0x001F6360 File Offset: 0x001F4560
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBoundsVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_SetBoundsVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072C1 RID: 29377 RVA: 0x001F63A0 File Offset: 0x001F45A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225020, XrefRangeEnd = 225043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetContentCulled(bool culled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref culled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_SetContentCulled_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072C2 RID: 29378 RVA: 0x001F63EC File Offset: 0x001F45EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 225053, RefRangeEnd = 225054, XrefRangeStart = 225043, XrefRangeEnd = 225053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int RegisterEmployee(Employee emp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(emp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RegisterEmployee_Public_Int32_Employee_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060072C3 RID: 29379 RVA: 0x001F643C File Offset: 0x001F463C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 225058, RefRangeEnd = 225059, XrefRangeStart = 225054, XrefRangeEnd = 225058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeregisterEmployee(Employee emp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(emp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_DeregisterEmployee_Public_Void_Employee_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072C4 RID: 29380 RVA: 0x001F6480 File Offset: 0x001F4680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225059, XrefRangeEnd = 225074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleableActioned(InteractableToggleable toggleable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toggleable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_ToggleableActioned_Private_Void_InteractableToggleable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072C5 RID: 29381 RVA: 0x001F64C4 File Offset: 0x001F46C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225074, XrefRangeEnd = 225095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendToggleableState(int index, bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_SendToggleableState_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072C6 RID: 29382 RVA: 0x001F6510 File Offset: 0x001F4710
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 225130, RefRangeEnd = 225133, XrefRangeStart = 225095, XrefRangeEnd = 225130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetToggleableState(NetworkConnection conn, int index, bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_SetToggleableState_Public_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072C7 RID: 29383 RVA: 0x001F6570 File Offset: 0x001F4770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225133, XrefRangeEnd = 225165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060072C8 RID: 29384 RVA: 0x001F65B4 File Offset: 0x001F47B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225165, XrefRangeEnd = 225239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x060072C9 RID: 29385 RVA: 0x001F6610 File Offset: 0x001F4810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225239, XrefRangeEnd = 225266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DeleteUnapprovedFiles(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_DeleteUnapprovedFiles_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072CA RID: 29386 RVA: 0x001F6660 File Offset: 0x001F4860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225266, XrefRangeEnd = 225279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(PropertyData propertyData, string containerPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(propertyData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(containerPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PropertyData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072CB RID: 29387 RVA: 0x001F66C0 File Offset: 0x001F48C0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 225285, RefRangeEnd = 225291, XrefRangeStart = 225279, XrefRangeEnd = 225285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoBoundsContainPoint(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_DoBoundsContainPoint_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060072CC RID: 29388 RVA: 0x001F670C File Offset: 0x001F490C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 225301, RefRangeEnd = 225302, XrefRangeStart = 225291, XrefRangeEnd = 225301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPointInsideBox(Vector3 worldPoint, BoxCollider box)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldPoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(box);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_IsPointInsideBox_Private_Boolean_Vector3_BoxCollider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060072CD RID: 29389 RVA: 0x001F6768 File Offset: 0x001F4968
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 225327, RefRangeEnd = 225328, XrefRangeStart = 225302, XrefRangeEnd = 225327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Bed> GetUnassignedBeds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_GetUnassignedBeds_Public_List_1_Bed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Bed>>(intPtr3) : null;
		}

		// Token: 0x060072CE RID: 29390 RVA: 0x001F67A8 File Offset: 0x001F49A8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 225409, RefRangeEnd = 225414, XrefRangeStart = 225328, XrefRangeEnd = 225409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Property() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Property>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072CF RID: 29391 RVA: 0x001F67E4 File Offset: 0x001F49E4
		[CallerCount(0)]
		public unsafe void _Awake_b__80_0(bool <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <p0>;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr__Awake_b__80_0_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072D0 RID: 29392 RVA: 0x001F6824 File Offset: 0x001F4A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225414, XrefRangeEnd = 225419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060072D1 RID: 29393 RVA: 0x001F6864 File Offset: 0x001F4A64
		[CallerCount(0)]
		public unsafe bool _RecieveOwned_b__93_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr__RecieveOwned_b__93_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060072D2 RID: 29394 RVA: 0x001F68A0 File Offset: 0x001F4AA0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 225451, RefRangeEnd = 225456, XrefRangeStart = 225419, XrefRangeEnd = 225451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072D3 RID: 29395 RVA: 0x001F68DC File Offset: 0x001F4ADC
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072D4 RID: 29396 RVA: 0x001F6918 File Offset: 0x001F4B18
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072D5 RID: 29397 RVA: 0x001F6954 File Offset: 0x001F4B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225456, XrefRangeEnd = 225474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetOwned_Server_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcWriter___Server_SetOwned_Server_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072D6 RID: 29398 RVA: 0x001F6988 File Offset: 0x001F4B88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 224957, RefRangeEnd = 224959, XrefRangeStart = 224957, XrefRangeEnd = 224959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetOwned_Server_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcLogic___SetOwned_Server_2166136261_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072D7 RID: 29399 RVA: 0x001F69BC File Offset: 0x001F4BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225474, XrefRangeEnd = 225477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetOwned_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcReader___Server_SetOwned_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072D8 RID: 29400 RVA: 0x001F6A20 File Offset: 0x001F4C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225477, XrefRangeEnd = 225495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveOwned_Networked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveOwned_Networked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072D9 RID: 29401 RVA: 0x001F6A54 File Offset: 0x001F4C54
		[CallerCount(0)]
		public unsafe void RpcLogic___ReceiveOwned_Networked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcLogic___ReceiveOwned_Networked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072DA RID: 29402 RVA: 0x001F6A88 File Offset: 0x001F4C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225495, XrefRangeEnd = 225497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveOwned_Networked_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcReader___Observers_ReceiveOwned_Networked_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072DB RID: 29403 RVA: 0x001F6AD8 File Offset: 0x001F4CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendToggleableState_3658436649(int index, bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcWriter___Server_SendToggleableState_3658436649_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072DC RID: 29404 RVA: 0x001F6B24 File Offset: 0x001F4D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225497, XrefRangeEnd = 225498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendToggleableState_3658436649(int index, bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcLogic___SendToggleableState_3658436649_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072DD RID: 29405 RVA: 0x001F6B70 File Offset: 0x001F4D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225498, XrefRangeEnd = 225502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendToggleableState_3658436649(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcReader___Server_SendToggleableState_3658436649_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072DE RID: 29406 RVA: 0x001F6BD4 File Offset: 0x001F4DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225502, XrefRangeEnd = 225523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetToggleableState_338960014(NetworkConnection conn, int index, bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcWriter___Observers_SetToggleableState_338960014_Private_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072DF RID: 29407 RVA: 0x001F6C34 File Offset: 0x001F4E34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 225528, RefRangeEnd = 225530, XrefRangeStart = 225523, XrefRangeEnd = 225528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetToggleableState_338960014(NetworkConnection conn, int index, bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcLogic___SetToggleableState_338960014_Public_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072E0 RID: 29408 RVA: 0x001F6C94 File Offset: 0x001F4E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225530, XrefRangeEnd = 225534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetToggleableState_338960014(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcReader___Observers_SetToggleableState_338960014_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072E1 RID: 29409 RVA: 0x001F6CE4 File Offset: 0x001F4EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225534, XrefRangeEnd = 225546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetToggleableState_338960014(NetworkConnection conn, int index, bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcWriter___Target_SetToggleableState_338960014_Private_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072E2 RID: 29410 RVA: 0x001F6D44 File Offset: 0x001F4F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225546, XrefRangeEnd = 225551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetToggleableState_338960014(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcReader___Target_SetToggleableState_338960014_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072E3 RID: 29411 RVA: 0x001F6D94 File Offset: 0x001F4F94
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 225727, RefRangeEnd = 225733, XrefRangeStart = 225551, XrefRangeEnd = 225727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072E4 RID: 29412 RVA: 0x000367E8 File Offset: 0x000349E8
		public Property(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170022B9 RID: 8889
		// (get) Token: 0x060072E5 RID: 29413 RVA: 0x001F6DD0 File Offset: 0x001F4FD0
		// (set) Token: 0x060072E6 RID: 29414 RVA: 0x000367F1 File Offset: 0x000349F1
		public unsafe static List<Property> Properties
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Property.NativeFieldInfoPtr_Properties, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Property.NativeFieldInfoPtr_Properties, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022BA RID: 8890
		// (get) Token: 0x060072E7 RID: 29415 RVA: 0x001F6DF8 File Offset: 0x001F4FF8
		// (set) Token: 0x060072E8 RID: 29416 RVA: 0x00036803 File Offset: 0x00034A03
		public unsafe static List<Property> UnownedProperties
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Property.NativeFieldInfoPtr_UnownedProperties, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Property.NativeFieldInfoPtr_UnownedProperties, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022BB RID: 8891
		// (get) Token: 0x060072E9 RID: 29417 RVA: 0x001F6E20 File Offset: 0x001F5020
		// (set) Token: 0x060072EA RID: 29418 RVA: 0x00036815 File Offset: 0x00034A15
		public unsafe static List<Property> OwnedProperties
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Property.NativeFieldInfoPtr_OwnedProperties, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Property.NativeFieldInfoPtr_OwnedProperties, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022BC RID: 8892
		// (get) Token: 0x060072EB RID: 29419 RVA: 0x001F6E48 File Offset: 0x001F5048
		// (set) Token: 0x060072EC RID: 29420 RVA: 0x00036827 File Offset: 0x00034A27
		public unsafe static Property.PropertyChange onPropertyAcquired
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Property.NativeFieldInfoPtr_onPropertyAcquired, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property.PropertyChange>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Property.NativeFieldInfoPtr_onPropertyAcquired, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022BD RID: 8893
		// (get) Token: 0x060072ED RID: 29421 RVA: 0x001F6E70 File Offset: 0x001F5070
		// (set) Token: 0x060072EE RID: 29422 RVA: 0x00036839 File Offset: 0x00034A39
		public unsafe UnityEvent onThisPropertyAcquired
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_onThisPropertyAcquired);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_onThisPropertyAcquired), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022BE RID: 8894
		// (get) Token: 0x060072EF RID: 29423 RVA: 0x001F6EA0 File Offset: 0x001F50A0
		// (set) Token: 0x060072F0 RID: 29424 RVA: 0x00036858 File Offset: 0x00034A58
		public unsafe bool _IsOwned_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__IsOwned_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__IsOwned_k__BackingField)) = value;
			}
		}

		// Token: 0x170022BF RID: 8895
		// (get) Token: 0x060072F1 RID: 29425 RVA: 0x001F6EC8 File Offset: 0x001F50C8
		// (set) Token: 0x060072F2 RID: 29426 RVA: 0x00036873 File Offset: 0x00034A73
		public unsafe List<Employee> _Employees_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__Employees_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Employee>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__Employees_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022C0 RID: 8896
		// (get) Token: 0x060072F3 RID: 29427 RVA: 0x001F6EF8 File Offset: 0x001F50F8
		// (set) Token: 0x060072F4 RID: 29428 RVA: 0x00036892 File Offset: 0x00034A92
		public unsafe RectTransform _WorldspaceUIContainer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__WorldspaceUIContainer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__WorldspaceUIContainer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022C1 RID: 8897
		// (get) Token: 0x060072F5 RID: 29429 RVA: 0x001F6F28 File Offset: 0x001F5128
		// (set) Token: 0x060072F6 RID: 29430 RVA: 0x000368B1 File Offset: 0x00034AB1
		public unsafe bool _IsContentCulled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__IsContentCulled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__IsContentCulled_k__BackingField)) = value;
			}
		}

		// Token: 0x170022C2 RID: 8898
		// (get) Token: 0x060072F7 RID: 29431 RVA: 0x001F6F50 File Offset: 0x001F5150
		// (set) Token: 0x060072F8 RID: 29432 RVA: 0x000368CC File Offset: 0x00034ACC
		public unsafe string propertyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_propertyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_propertyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170022C3 RID: 8899
		// (get) Token: 0x060072F9 RID: 29433 RVA: 0x001F6F78 File Offset: 0x001F5178
		// (set) Token: 0x060072FA RID: 29434 RVA: 0x000368EB File Offset: 0x00034AEB
		public unsafe bool AvailableInDemo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_AvailableInDemo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_AvailableInDemo)) = value;
			}
		}

		// Token: 0x170022C4 RID: 8900
		// (get) Token: 0x060072FB RID: 29435 RVA: 0x001F6FA0 File Offset: 0x001F51A0
		// (set) Token: 0x060072FC RID: 29436 RVA: 0x00036906 File Offset: 0x00034B06
		public unsafe string propertyCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_propertyCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_propertyCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170022C5 RID: 8901
		// (get) Token: 0x060072FD RID: 29437 RVA: 0x001F6FC8 File Offset: 0x001F51C8
		// (set) Token: 0x060072FE RID: 29438 RVA: 0x00036925 File Offset: 0x00034B25
		public unsafe float Price
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Price);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Price)) = value;
			}
		}

		// Token: 0x170022C6 RID: 8902
		// (get) Token: 0x060072FF RID: 29439 RVA: 0x001F6FF0 File Offset: 0x001F51F0
		// (set) Token: 0x06007300 RID: 29440 RVA: 0x00036940 File Offset: 0x00034B40
		public unsafe float DefaultRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_DefaultRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_DefaultRotation)) = value;
			}
		}

		// Token: 0x170022C7 RID: 8903
		// (get) Token: 0x06007301 RID: 29441 RVA: 0x001F7018 File Offset: 0x001F5218
		// (set) Token: 0x06007302 RID: 29442 RVA: 0x0003695B File Offset: 0x00034B5B
		public unsafe int EmployeeCapacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_EmployeeCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_EmployeeCapacity)) = value;
			}
		}

		// Token: 0x170022C8 RID: 8904
		// (get) Token: 0x06007303 RID: 29443 RVA: 0x001F7040 File Offset: 0x001F5240
		// (set) Token: 0x06007304 RID: 29444 RVA: 0x00036976 File Offset: 0x00034B76
		public unsafe bool OwnedByDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_OwnedByDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_OwnedByDefault)) = value;
			}
		}

		// Token: 0x170022C9 RID: 8905
		// (get) Token: 0x06007305 RID: 29445 RVA: 0x001F7068 File Offset: 0x001F5268
		// (set) Token: 0x06007306 RID: 29446 RVA: 0x00036991 File Offset: 0x00034B91
		public unsafe bool DEBUG_SET_OWNED
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_DEBUG_SET_OWNED);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_DEBUG_SET_OWNED)) = value;
			}
		}

		// Token: 0x170022CA RID: 8906
		// (get) Token: 0x06007307 RID: 29447 RVA: 0x001F7090 File Offset: 0x001F5290
		// (set) Token: 0x06007308 RID: 29448 RVA: 0x000369AC File Offset: 0x00034BAC
		public unsafe string IsOwnedVariable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_IsOwnedVariable);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_IsOwnedVariable), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170022CB RID: 8907
		// (get) Token: 0x06007309 RID: 29449 RVA: 0x001F70B8 File Offset: 0x001F52B8
		// (set) Token: 0x0600730A RID: 29450 RVA: 0x000369CB File Offset: 0x00034BCB
		public unsafe bool ContentCullingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ContentCullingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ContentCullingEnabled)) = value;
			}
		}

		// Token: 0x170022CC RID: 8908
		// (get) Token: 0x0600730B RID: 29451 RVA: 0x001F70E0 File Offset: 0x001F52E0
		// (set) Token: 0x0600730C RID: 29452 RVA: 0x000369E6 File Offset: 0x00034BE6
		public unsafe float MinimumCullingDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_MinimumCullingDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_MinimumCullingDistance)) = value;
			}
		}

		// Token: 0x170022CD RID: 8909
		// (get) Token: 0x0600730D RID: 29453 RVA: 0x001F7108 File Offset: 0x001F5308
		// (set) Token: 0x0600730E RID: 29454 RVA: 0x00036A01 File Offset: 0x00034C01
		public unsafe Il2CppReferenceArray<GameObject> ObjectsToCull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ObjectsToCull);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ObjectsToCull), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022CE RID: 8910
		// (get) Token: 0x0600730F RID: 29455 RVA: 0x001F7138 File Offset: 0x001F5338
		// (set) Token: 0x06007310 RID: 29456 RVA: 0x00036A20 File Offset: 0x00034C20
		public unsafe PropertyContentsContainer Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyContentsContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022CF RID: 8911
		// (get) Token: 0x06007311 RID: 29457 RVA: 0x001F7168 File Offset: 0x001F5368
		// (set) Token: 0x06007312 RID: 29458 RVA: 0x00036A3F File Offset: 0x00034C3F
		public unsafe Transform EmployeeContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_EmployeeContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_EmployeeContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D0 RID: 8912
		// (get) Token: 0x06007313 RID: 29459 RVA: 0x001F7198 File Offset: 0x001F5398
		// (set) Token: 0x06007314 RID: 29460 RVA: 0x00036A5E File Offset: 0x00034C5E
		public unsafe Transform SpawnPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_SpawnPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_SpawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D1 RID: 8913
		// (get) Token: 0x06007315 RID: 29461 RVA: 0x001F71C8 File Offset: 0x001F53C8
		// (set) Token: 0x06007316 RID: 29462 RVA: 0x00036A7D File Offset: 0x00034C7D
		public unsafe Transform InteriorSpawnPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_InteriorSpawnPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_InteriorSpawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D2 RID: 8914
		// (get) Token: 0x06007317 RID: 29463 RVA: 0x001F71F8 File Offset: 0x001F53F8
		// (set) Token: 0x06007318 RID: 29464 RVA: 0x00036A9C File Offset: 0x00034C9C
		public unsafe GameObject ForSaleSign
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ForSaleSign);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ForSaleSign), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D3 RID: 8915
		// (get) Token: 0x06007319 RID: 29465 RVA: 0x001F7228 File Offset: 0x001F5428
		// (set) Token: 0x0600731A RID: 29466 RVA: 0x00036ABB File Offset: 0x00034CBB
		public unsafe GameObject BoundingBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_BoundingBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_BoundingBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D4 RID: 8916
		// (get) Token: 0x0600731B RID: 29467 RVA: 0x001F7258 File Offset: 0x001F5458
		// (set) Token: 0x0600731C RID: 29468 RVA: 0x00036ADA File Offset: 0x00034CDA
		public unsafe POI PoI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_PoI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_PoI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D5 RID: 8917
		// (get) Token: 0x0600731D RID: 29469 RVA: 0x001F7288 File Offset: 0x001F5488
		// (set) Token: 0x0600731E RID: 29470 RVA: 0x00036AF9 File Offset: 0x00034CF9
		public unsafe Transform ListingPoster
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ListingPoster);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ListingPoster), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D6 RID: 8918
		// (get) Token: 0x0600731F RID: 29471 RVA: 0x001F72B8 File Offset: 0x001F54B8
		// (set) Token: 0x06007320 RID: 29472 RVA: 0x00036B18 File Offset: 0x00034D18
		public unsafe Transform NPCSpawnPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_NPCSpawnPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_NPCSpawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D7 RID: 8919
		// (get) Token: 0x06007321 RID: 29473 RVA: 0x001F72E8 File Offset: 0x001F54E8
		// (set) Token: 0x06007322 RID: 29474 RVA: 0x00036B37 File Offset: 0x00034D37
		public unsafe Il2CppReferenceArray<Transform> EmployeeIdlePoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_EmployeeIdlePoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_EmployeeIdlePoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D8 RID: 8920
		// (get) Token: 0x06007323 RID: 29475 RVA: 0x001F7318 File Offset: 0x001F5518
		// (set) Token: 0x06007324 RID: 29476 RVA: 0x00036B56 File Offset: 0x00034D56
		public unsafe List<ModularSwitch> Switches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Switches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ModularSwitch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Switches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D9 RID: 8921
		// (get) Token: 0x06007325 RID: 29477 RVA: 0x001F7348 File Offset: 0x001F5548
		// (set) Token: 0x06007326 RID: 29478 RVA: 0x00036B75 File Offset: 0x00034D75
		public unsafe List<InteractableToggleable> Toggleables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Toggleables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InteractableToggleable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Toggleables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022DA RID: 8922
		// (get) Token: 0x06007327 RID: 29479 RVA: 0x001F7378 File Offset: 0x001F5578
		// (set) Token: 0x06007328 RID: 29480 RVA: 0x00036B94 File Offset: 0x00034D94
		public unsafe PropertyDisposalArea DisposalArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_DisposalArea);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyDisposalArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_DisposalArea), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022DB RID: 8923
		// (get) Token: 0x06007329 RID: 29481 RVA: 0x001F73A8 File Offset: 0x001F55A8
		// (set) Token: 0x0600732A RID: 29482 RVA: 0x00036BB3 File Offset: 0x00034DB3
		public unsafe Il2CppReferenceArray<LoadingDock> LoadingDocks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_LoadingDocks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LoadingDock>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_LoadingDocks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022DC RID: 8924
		// (get) Token: 0x0600732B RID: 29483 RVA: 0x001F73D8 File Offset: 0x001F55D8
		// (set) Token: 0x0600732C RID: 29484 RVA: 0x00036BD2 File Offset: 0x00034DD2
		public unsafe List<BuildableItem> BuildableItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_BuildableItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BuildableItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_BuildableItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022DD RID: 8925
		// (get) Token: 0x0600732D RID: 29485 RVA: 0x001F7408 File Offset: 0x001F5608
		// (set) Token: 0x0600732E RID: 29486 RVA: 0x00036BF1 File Offset: 0x00034DF1
		public unsafe List<IConfigurable> Configurables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Configurables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IConfigurable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Configurables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022DE RID: 8926
		// (get) Token: 0x0600732F RID: 29487 RVA: 0x001F7438 File Offset: 0x001F5638
		// (set) Token: 0x06007330 RID: 29488 RVA: 0x00036C10 File Offset: 0x00034E10
		public unsafe Il2CppReferenceArray<BoxCollider> propertyBoundsColliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_propertyBoundsColliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BoxCollider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_propertyBoundsColliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022DF RID: 8927
		// (get) Token: 0x06007331 RID: 29489 RVA: 0x001F7468 File Offset: 0x001F5668
		// (set) Token: 0x06007332 RID: 29490 RVA: 0x00036C2F File Offset: 0x00034E2F
		public unsafe PropertyLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022E0 RID: 8928
		// (get) Token: 0x06007333 RID: 29491 RVA: 0x001F7498 File Offset: 0x001F5698
		// (set) Token: 0x06007334 RID: 29492 RVA: 0x00036C4E File Offset: 0x00034E4E
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022E1 RID: 8929
		// (get) Token: 0x06007335 RID: 29493 RVA: 0x001F74C8 File Offset: 0x001F56C8
		// (set) Token: 0x06007336 RID: 29494 RVA: 0x00036C6D File Offset: 0x00034E6D
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022E2 RID: 8930
		// (get) Token: 0x06007337 RID: 29495 RVA: 0x001F74F8 File Offset: 0x001F56F8
		// (set) Token: 0x06007338 RID: 29496 RVA: 0x00036C8C File Offset: 0x00034E8C
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x170022E3 RID: 8931
		// (get) Token: 0x06007339 RID: 29497 RVA: 0x001F7520 File Offset: 0x001F5720
		// (set) Token: 0x0600733A RID: 29498 RVA: 0x00036CA7 File Offset: 0x00034EA7
		public unsafe List<string> savedObjectPaths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_savedObjectPaths);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_savedObjectPaths), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022E4 RID: 8932
		// (get) Token: 0x0600733B RID: 29499 RVA: 0x001F7550 File Offset: 0x001F5750
		// (set) Token: 0x0600733C RID: 29500 RVA: 0x00036CC6 File Offset: 0x00034EC6
		public unsafe List<string> savedEmployeePaths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_savedEmployeePaths);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_savedEmployeePaths), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022E5 RID: 8933
		// (get) Token: 0x0600733D RID: 29501 RVA: 0x001F7580 File Offset: 0x001F5780
		// (set) Token: 0x0600733E RID: 29502 RVA: 0x00036CE5 File Offset: 0x00034EE5
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170022E6 RID: 8934
		// (get) Token: 0x0600733F RID: 29503 RVA: 0x001F75A8 File Offset: 0x001F57A8
		// (set) Token: 0x06007340 RID: 29504 RVA: 0x00036D00 File Offset: 0x00034F00
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004E36 RID: 20022
		private static readonly IntPtr NativeFieldInfoPtr_Properties;

		// Token: 0x04004E37 RID: 20023
		private static readonly IntPtr NativeFieldInfoPtr_UnownedProperties;

		// Token: 0x04004E38 RID: 20024
		private static readonly IntPtr NativeFieldInfoPtr_OwnedProperties;

		// Token: 0x04004E39 RID: 20025
		private static readonly IntPtr NativeFieldInfoPtr_onPropertyAcquired;

		// Token: 0x04004E3A RID: 20026
		private static readonly IntPtr NativeFieldInfoPtr_onThisPropertyAcquired;

		// Token: 0x04004E3B RID: 20027
		private static readonly IntPtr NativeFieldInfoPtr__IsOwned_k__BackingField;

		// Token: 0x04004E3C RID: 20028
		private static readonly IntPtr NativeFieldInfoPtr__Employees_k__BackingField;

		// Token: 0x04004E3D RID: 20029
		private static readonly IntPtr NativeFieldInfoPtr__WorldspaceUIContainer_k__BackingField;

		// Token: 0x04004E3E RID: 20030
		private static readonly IntPtr NativeFieldInfoPtr__IsContentCulled_k__BackingField;

		// Token: 0x04004E3F RID: 20031
		private static readonly IntPtr NativeFieldInfoPtr_propertyName;

		// Token: 0x04004E40 RID: 20032
		private static readonly IntPtr NativeFieldInfoPtr_AvailableInDemo;

		// Token: 0x04004E41 RID: 20033
		private static readonly IntPtr NativeFieldInfoPtr_propertyCode;

		// Token: 0x04004E42 RID: 20034
		private static readonly IntPtr NativeFieldInfoPtr_Price;

		// Token: 0x04004E43 RID: 20035
		private static readonly IntPtr NativeFieldInfoPtr_DefaultRotation;

		// Token: 0x04004E44 RID: 20036
		private static readonly IntPtr NativeFieldInfoPtr_EmployeeCapacity;

		// Token: 0x04004E45 RID: 20037
		private static readonly IntPtr NativeFieldInfoPtr_OwnedByDefault;

		// Token: 0x04004E46 RID: 20038
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG_SET_OWNED;

		// Token: 0x04004E47 RID: 20039
		private static readonly IntPtr NativeFieldInfoPtr_IsOwnedVariable;

		// Token: 0x04004E48 RID: 20040
		private static readonly IntPtr NativeFieldInfoPtr_ContentCullingEnabled;

		// Token: 0x04004E49 RID: 20041
		private static readonly IntPtr NativeFieldInfoPtr_MinimumCullingDistance;

		// Token: 0x04004E4A RID: 20042
		private static readonly IntPtr NativeFieldInfoPtr_ObjectsToCull;

		// Token: 0x04004E4B RID: 20043
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04004E4C RID: 20044
		private static readonly IntPtr NativeFieldInfoPtr_EmployeeContainer;

		// Token: 0x04004E4D RID: 20045
		private static readonly IntPtr NativeFieldInfoPtr_SpawnPoint;

		// Token: 0x04004E4E RID: 20046
		private static readonly IntPtr NativeFieldInfoPtr_InteriorSpawnPoint;

		// Token: 0x04004E4F RID: 20047
		private static readonly IntPtr NativeFieldInfoPtr_ForSaleSign;

		// Token: 0x04004E50 RID: 20048
		private static readonly IntPtr NativeFieldInfoPtr_BoundingBox;

		// Token: 0x04004E51 RID: 20049
		private static readonly IntPtr NativeFieldInfoPtr_PoI;

		// Token: 0x04004E52 RID: 20050
		private static readonly IntPtr NativeFieldInfoPtr_ListingPoster;

		// Token: 0x04004E53 RID: 20051
		private static readonly IntPtr NativeFieldInfoPtr_NPCSpawnPoint;

		// Token: 0x04004E54 RID: 20052
		private static readonly IntPtr NativeFieldInfoPtr_EmployeeIdlePoints;

		// Token: 0x04004E55 RID: 20053
		private static readonly IntPtr NativeFieldInfoPtr_Switches;

		// Token: 0x04004E56 RID: 20054
		private static readonly IntPtr NativeFieldInfoPtr_Toggleables;

		// Token: 0x04004E57 RID: 20055
		private static readonly IntPtr NativeFieldInfoPtr_DisposalArea;

		// Token: 0x04004E58 RID: 20056
		private static readonly IntPtr NativeFieldInfoPtr_LoadingDocks;

		// Token: 0x04004E59 RID: 20057
		private static readonly IntPtr NativeFieldInfoPtr_BuildableItems;

		// Token: 0x04004E5A RID: 20058
		private static readonly IntPtr NativeFieldInfoPtr_Configurables;

		// Token: 0x04004E5B RID: 20059
		private static readonly IntPtr NativeFieldInfoPtr_propertyBoundsColliders;

		// Token: 0x04004E5C RID: 20060
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x04004E5D RID: 20061
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04004E5E RID: 20062
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04004E5F RID: 20063
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04004E60 RID: 20064
		private static readonly IntPtr NativeFieldInfoPtr_savedObjectPaths;

		// Token: 0x04004E61 RID: 20065
		private static readonly IntPtr NativeFieldInfoPtr_savedEmployeePaths;

		// Token: 0x04004E62 RID: 20066
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004E63 RID: 20067
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004E64 RID: 20068
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOwned_Public_get_Boolean_0;

		// Token: 0x04004E65 RID: 20069
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOwned_Protected_set_Void_Boolean_0;

		// Token: 0x04004E66 RID: 20070
		private static readonly IntPtr NativeMethodInfoPtr_get_Employees_Public_get_List_1_Employee_0;

		// Token: 0x04004E67 RID: 20071
		private static readonly IntPtr NativeMethodInfoPtr_set_Employees_Protected_set_Void_List_1_Employee_0;

		// Token: 0x04004E68 RID: 20072
		private static readonly IntPtr NativeMethodInfoPtr_get_WorldspaceUIContainer_Public_get_RectTransform_0;

		// Token: 0x04004E69 RID: 20073
		private static readonly IntPtr NativeMethodInfoPtr_set_WorldspaceUIContainer_Protected_set_Void_RectTransform_0;

		// Token: 0x04004E6A RID: 20074
		private static readonly IntPtr NativeMethodInfoPtr_get_IsContentCulled_Public_get_Boolean_0;

		// Token: 0x04004E6B RID: 20075
		private static readonly IntPtr NativeMethodInfoPtr_set_IsContentCulled_Public_set_Void_Boolean_0;

		// Token: 0x04004E6C RID: 20076
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertyName_Public_get_String_0;

		// Token: 0x04004E6D RID: 20077
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertyCode_Public_get_String_0;

		// Token: 0x04004E6E RID: 20078
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadingDockCount_Public_get_Int32_0;

		// Token: 0x04004E6F RID: 20079
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04004E70 RID: 20080
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04004E71 RID: 20081
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04004E72 RID: 20082
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04004E73 RID: 20083
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04004E74 RID: 20084
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04004E75 RID: 20085
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04004E76 RID: 20086
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04004E77 RID: 20087
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04004E78 RID: 20088
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04004E79 RID: 20089
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004E7A RID: 20090
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04004E7B RID: 20091
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1;

		// Token: 0x04004E7C RID: 20092
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x04004E7D RID: 20093
		private static readonly IntPtr NativeMethodInfoPtr_AddConfigurable_Public_Void_IConfigurable_0;

		// Token: 0x04004E7E RID: 20094
		private static readonly IntPtr NativeMethodInfoPtr_RemoveConfigurable_Public_Void_IConfigurable_0;

		// Token: 0x04004E7F RID: 20095
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCulling_Private_Void_0;

		// Token: 0x04004E80 RID: 20096
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04004E81 RID: 20097
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1;

		// Token: 0x04004E82 RID: 20098
		private static readonly IntPtr NativeMethodInfoPtr_GetNetworth_Protected_Virtual_New_Void_FloatContainer_0;

		// Token: 0x04004E83 RID: 20099
		private static readonly IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x04004E84 RID: 20100
		private static readonly IntPtr NativeMethodInfoPtr_SetOwned_Server_Protected_Void_0;

		// Token: 0x04004E85 RID: 20101
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveOwned_Networked_Private_Void_0;

		// Token: 0x04004E86 RID: 20102
		private static readonly IntPtr NativeMethodInfoPtr_RecieveOwned_Protected_Virtual_New_Void_1;

		// Token: 0x04004E87 RID: 20103
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0;

		// Token: 0x04004E88 RID: 20104
		private static readonly IntPtr NativeMethodInfoPtr_SetOwned_Public_Void_0;

		// Token: 0x04004E89 RID: 20105
		private static readonly IntPtr NativeMethodInfoPtr_SetBoundsVisible_Public_Void_Boolean_0;

		// Token: 0x04004E8A RID: 20106
		private static readonly IntPtr NativeMethodInfoPtr_SetContentCulled_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04004E8B RID: 20107
		private static readonly IntPtr NativeMethodInfoPtr_RegisterEmployee_Public_Int32_Employee_0;

		// Token: 0x04004E8C RID: 20108
		private static readonly IntPtr NativeMethodInfoPtr_DeregisterEmployee_Public_Void_Employee_0;

		// Token: 0x04004E8D RID: 20109
		private static readonly IntPtr NativeMethodInfoPtr_ToggleableActioned_Private_Void_InteractableToggleable_0;

		// Token: 0x04004E8E RID: 20110
		private static readonly IntPtr NativeMethodInfoPtr_SendToggleableState_Public_Void_Int32_Boolean_0;

		// Token: 0x04004E8F RID: 20111
		private static readonly IntPtr NativeMethodInfoPtr_SetToggleableState_Public_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x04004E90 RID: 20112
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04004E91 RID: 20113
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0;

		// Token: 0x04004E92 RID: 20114
		private static readonly IntPtr NativeMethodInfoPtr_DeleteUnapprovedFiles_Public_Virtual_New_Void_String_0;

		// Token: 0x04004E93 RID: 20115
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PropertyData_String_0;

		// Token: 0x04004E94 RID: 20116
		private static readonly IntPtr NativeMethodInfoPtr_DoBoundsContainPoint_Public_Boolean_Vector3_0;

		// Token: 0x04004E95 RID: 20117
		private static readonly IntPtr NativeMethodInfoPtr_IsPointInsideBox_Private_Boolean_Vector3_BoxCollider_0;

		// Token: 0x04004E96 RID: 20118
		private static readonly IntPtr NativeMethodInfoPtr_GetUnassignedBeds_Public_List_1_Bed_0;

		// Token: 0x04004E97 RID: 20119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004E98 RID: 20120
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__80_0_Private_Void_Boolean_0;

		// Token: 0x04004E99 RID: 20121
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04004E9A RID: 20122
		private static readonly IntPtr NativeMethodInfoPtr__RecieveOwned_b__93_1_Private_Boolean_0;

		// Token: 0x04004E9B RID: 20123
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004E9C RID: 20124
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004E9D RID: 20125
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004E9E RID: 20126
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetOwned_Server_2166136261_Private_Void_0;

		// Token: 0x04004E9F RID: 20127
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetOwned_Server_2166136261_Protected_Void_0;

		// Token: 0x04004EA0 RID: 20128
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetOwned_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004EA1 RID: 20129
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveOwned_Networked_2166136261_Private_Void_0;

		// Token: 0x04004EA2 RID: 20130
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveOwned_Networked_2166136261_Private_Void_0;

		// Token: 0x04004EA3 RID: 20131
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveOwned_Networked_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004EA4 RID: 20132
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendToggleableState_3658436649_Private_Void_Int32_Boolean_0;

		// Token: 0x04004EA5 RID: 20133
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendToggleableState_3658436649_Public_Void_Int32_Boolean_0;

		// Token: 0x04004EA6 RID: 20134
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendToggleableState_3658436649_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004EA7 RID: 20135
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetToggleableState_338960014_Private_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x04004EA8 RID: 20136
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetToggleableState_338960014_Public_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x04004EA9 RID: 20137
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetToggleableState_338960014_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004EAA RID: 20138
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetToggleableState_338960014_Private_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x04004EAB RID: 20139
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetToggleableState_338960014_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004EAC RID: 20140
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x02000A86 RID: 2694
		public sealed class PropertyChange : MulticastDelegate
		{
			// Token: 0x0600D228 RID: 53800 RVA: 0x00324A5C File Offset: 0x00322C5C
			// Note: this type is marked as 'beforefieldinit'.
			static PropertyChange()
			{
				Il2CppClassPointerStore<Property.PropertyChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Property>.NativeClassPtr, "PropertyChange");
				Property.PropertyChange.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.PropertyChange>.NativeClassPtr, 100677753);
				Property.PropertyChange.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.PropertyChange>.NativeClassPtr, 100677754);
				Property.PropertyChange.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Property_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.PropertyChange>.NativeClassPtr, 100677755);
				Property.PropertyChange.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.PropertyChange>.NativeClassPtr, 100677756);
			}

			// Token: 0x0600D229 RID: 53801 RVA: 0x00324AD0 File Offset: 0x00322CD0
			[CallerCount(632)]
			[CachedScanResults(RefRangeStart = 81889, RefRangeEnd = 82521, XrefRangeStart = 81889, XrefRangeEnd = 82521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PropertyChange(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Property.PropertyChange>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.PropertyChange.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D22A RID: 53802 RVA: 0x00324B2C File Offset: 0x00322D2C
			[CallerCount(0)]
			public unsafe void Invoke(Property property)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.PropertyChange.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D22B RID: 53803 RVA: 0x00324B70 File Offset: 0x00322D70
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74827, RefRangeEnd = 74828, XrefRangeStart = 74827, XrefRangeEnd = 74828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Property property, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.PropertyChange.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Property_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600D22C RID: 53804 RVA: 0x00324BE4 File Offset: 0x00322DE4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22499, RefRangeEnd = 22500, XrefRangeStart = 22499, XrefRangeEnd = 22500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.PropertyChange.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D22D RID: 53805 RVA: 0x00066579 File Offset: 0x00064779
			public PropertyChange(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D22E RID: 53806 RVA: 0x00066582 File Offset: 0x00064782
			public static implicit operator Property.PropertyChange(Action<Property> A_0)
			{
				return DelegateSupport.ConvertDelegate<Property.PropertyChange>(A_0);
			}

			// Token: 0x0600D22F RID: 53807 RVA: 0x0006658A File Offset: 0x0006478A
			public static Property.PropertyChange operator +(Property.PropertyChange A_0, Property.PropertyChange A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Property.PropertyChange>();
			}

			// Token: 0x0600D230 RID: 53808 RVA: 0x00066598 File Offset: 0x00064798
			public static Property.PropertyChange operator -(Property.PropertyChange A_0, Property.PropertyChange A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<Property.PropertyChange>();
				}
				return result;
			}

			// Token: 0x04008DC1 RID: 36289
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008DC2 RID: 36290
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Property_0;

			// Token: 0x04008DC3 RID: 36291
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Property_AsyncCallback_Object_0;

			// Token: 0x04008DC4 RID: 36292
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000A87 RID: 2695
		[ObfuscatedName("ScheduleOne.Property.Property+<<RecieveOwned>g__Wait|93_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D231 RID: 53809 RVA: 0x00324C28 File Offset: 0x00322E28
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique()
			{
				Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Property>.NativeClassPtr, "<<RecieveOwned>g__Wait|93_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr);
				Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>1__state");
				Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>2__current");
				Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>4__this");
				Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100677757);
				Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100677758);
				Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100677759);
				Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100677760);
				Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100677761);
				Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100677762);
			}

			// Token: 0x0600D232 RID: 53810 RVA: 0x00324D08 File Offset: 0x00322F08
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D233 RID: 53811 RVA: 0x00324D50 File Offset: 0x00322F50
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D234 RID: 53812 RVA: 0x00324D84 File Offset: 0x00322F84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224710, XrefRangeEnd = 224723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700413E RID: 16702
			// (get) Token: 0x0600D235 RID: 53813 RVA: 0x00324DC0 File Offset: 0x00322FC0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D236 RID: 53814 RVA: 0x00324E00 File Offset: 0x00323000
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224723, XrefRangeEnd = 224728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700413F RID: 16703
			// (get) Token: 0x0600D237 RID: 53815 RVA: 0x00324E34 File Offset: 0x00323034
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D238 RID: 53816 RVA: 0x000665A9 File Offset: 0x000647A9
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700413B RID: 16699
			// (get) Token: 0x0600D239 RID: 53817 RVA: 0x00324E74 File Offset: 0x00323074
			// (set) Token: 0x0600D23A RID: 53818 RVA: 0x000665B2 File Offset: 0x000647B2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700413C RID: 16700
			// (get) Token: 0x0600D23B RID: 53819 RVA: 0x00324E9C File Offset: 0x0032309C
			// (set) Token: 0x0600D23C RID: 53820 RVA: 0x000665CD File Offset: 0x000647CD
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700413D RID: 16701
			// (get) Token: 0x0600D23D RID: 53821 RVA: 0x00324ECC File Offset: 0x003230CC
			// (set) Token: 0x0600D23E RID: 53822 RVA: 0x000665EC File Offset: 0x000647EC
			public unsafe Property __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DC5 RID: 36293
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008DC6 RID: 36294
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008DC7 RID: 36295
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008DC8 RID: 36296
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008DC9 RID: 36297
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008DCA RID: 36298
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008DCB RID: 36299
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008DCC RID: 36300
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008DCD RID: 36301
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000A88 RID: 2696
		[ObfuscatedName("ScheduleOne.Property.Property+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D23F RID: 53823 RVA: 0x00324EFC File Offset: 0x003230FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Property.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Property>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Property.__c>.NativeClassPtr);
				Property.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property.__c>.NativeClassPtr, "<>9");
				Property.__c.NativeFieldInfoPtr___9__109_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property.__c>.NativeClassPtr, "<>9__109_0");
				Property.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.__c>.NativeClassPtr, 100677764);
				Property.__c.NativeMethodInfoPtr__GetUnassignedBeds_b__109_0_Internal_Boolean_Bed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.__c>.NativeClassPtr, 100677765);
			}

			// Token: 0x0600D240 RID: 53824 RVA: 0x00324F78 File Offset: 0x00323178
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Property.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D241 RID: 53825 RVA: 0x00324FB4 File Offset: 0x003231B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224728, XrefRangeEnd = 224733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetUnassignedBeds_b__109_0(Bed x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.__c.NativeMethodInfoPtr__GetUnassignedBeds_b__109_0_Internal_Boolean_Bed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D242 RID: 53826 RVA: 0x0006660B File Offset: 0x0006480B
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004140 RID: 16704
			// (get) Token: 0x0600D243 RID: 53827 RVA: 0x00325004 File Offset: 0x00323204
			// (set) Token: 0x0600D244 RID: 53828 RVA: 0x00066614 File Offset: 0x00064814
			public unsafe static Property.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Property.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Property.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004141 RID: 16705
			// (get) Token: 0x0600D245 RID: 53829 RVA: 0x0032502C File Offset: 0x0032322C
			// (set) Token: 0x0600D246 RID: 53830 RVA: 0x00066626 File Offset: 0x00064826
			public unsafe static Func<Bed, bool> __9__109_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Property.__c.NativeFieldInfoPtr___9__109_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Bed, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Property.__c.NativeFieldInfoPtr___9__109_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DCE RID: 36302
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008DCF RID: 36303
			private static readonly IntPtr NativeFieldInfoPtr___9__109_0;

			// Token: 0x04008DD0 RID: 36304
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DD1 RID: 36305
			private static readonly IntPtr NativeMethodInfoPtr__GetUnassignedBeds_b__109_0_Internal_Boolean_Bed_0;
		}

		// Token: 0x02000A89 RID: 2697
		[ObfuscatedName("ScheduleOne.Property.Property+<>c__DisplayClass80_0")]
		public sealed class __c__DisplayClass80_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D247 RID: 53831 RVA: 0x00325054 File Offset: 0x00323254
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass80_0()
			{
				Il2CppClassPointerStore<Property.__c__DisplayClass80_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Property>.NativeClassPtr, "<>c__DisplayClass80_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Property.__c__DisplayClass80_0>.NativeClassPtr);
				Property.__c__DisplayClass80_0.NativeFieldInfoPtr_toggleable1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property.__c__DisplayClass80_0>.NativeClassPtr, "toggleable1");
				Property.__c__DisplayClass80_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property.__c__DisplayClass80_0>.NativeClassPtr, "<>4__this");
				Property.__c__DisplayClass80_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.__c__DisplayClass80_0>.NativeClassPtr, 100677766);
				Property.__c__DisplayClass80_0.NativeMethodInfoPtr__Awake_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.__c__DisplayClass80_0>.NativeClassPtr, 100677767);
			}

			// Token: 0x0600D248 RID: 53832 RVA: 0x003250D0 File Offset: 0x003232D0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass80_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Property.__c__DisplayClass80_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.__c__DisplayClass80_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D249 RID: 53833 RVA: 0x0032510C File Offset: 0x0032330C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224733, XrefRangeEnd = 224748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.__c__DisplayClass80_0.NativeMethodInfoPtr__Awake_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D24A RID: 53834 RVA: 0x00066638 File Offset: 0x00064838
			public __c__DisplayClass80_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004142 RID: 16706
			// (get) Token: 0x0600D24B RID: 53835 RVA: 0x00325140 File Offset: 0x00323340
			// (set) Token: 0x0600D24C RID: 53836 RVA: 0x00066641 File Offset: 0x00064841
			public unsafe InteractableToggleable toggleable1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.__c__DisplayClass80_0.NativeFieldInfoPtr_toggleable1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableToggleable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.__c__DisplayClass80_0.NativeFieldInfoPtr_toggleable1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004143 RID: 16707
			// (get) Token: 0x0600D24D RID: 53837 RVA: 0x00325170 File Offset: 0x00323370
			// (set) Token: 0x0600D24E RID: 53838 RVA: 0x00066660 File Offset: 0x00064860
			public unsafe Property __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.__c__DisplayClass80_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.__c__DisplayClass80_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DD2 RID: 36306
			private static readonly IntPtr NativeFieldInfoPtr_toggleable1;

			// Token: 0x04008DD3 RID: 36307
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008DD4 RID: 36308
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DD5 RID: 36309
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__1_Internal_Void_0;
		}
	}
}
