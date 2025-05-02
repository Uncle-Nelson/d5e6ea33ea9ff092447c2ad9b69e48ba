using System;
using Il2CppFishNet.Component.Transforming;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.Tiles;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x0200056F RID: 1391
	public class Pallet : NetworkBehaviour
	{
		// Token: 0x06007A30 RID: 31280 RVA: 0x0020E390 File Offset: 0x0020C590
		// Note: this type is marked as 'beforefieldinit'.
		static Pallet()
		{
			Il2CppClassPointerStore<Pallet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "Pallet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pallet>.NativeClassPtr);
			Pallet.NativeFieldInfoPtr_palletsOwnedByLocalPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "palletsOwnedByLocalPlayer");
			Pallet.NativeFieldInfoPtr_sizeX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "sizeX");
			Pallet.NativeFieldInfoPtr_sizeY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "sizeY");
			Pallet.NativeFieldInfoPtr__storedItemContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "_storedItemContainer");
			Pallet.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "rb");
			Pallet.NativeFieldInfoPtr_storageGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "storageGrid");
			Pallet.NativeFieldInfoPtr_networkTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "networkTransform");
			Pallet.NativeFieldInfoPtr_forkliftsInContact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "forkliftsInContact");
			Pallet.NativeFieldInfoPtr_currentSlotGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "currentSlotGUID");
			Pallet.NativeFieldInfoPtr_currentSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "currentSlot");
			Pallet.NativeFieldInfoPtr_timeSinceSlotCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "timeSinceSlotCheck");
			Pallet.NativeFieldInfoPtr_timeBoundToSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "timeBoundToSlot");
			Pallet.NativeFieldInfoPtr_rb_Mass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "rb_Mass");
			Pallet.NativeFieldInfoPtr_rb_Drag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "rb_Drag");
			Pallet.NativeFieldInfoPtr_rb_AngularDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "rb_AngularDrag");
			Pallet.NativeFieldInfoPtr__reservedItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "_reservedItems");
			Pallet.NativeFieldInfoPtr_completedJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "completedJobs");
			Pallet.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Storage.PalletAssembly-CSharp.dll_Excuted");
			Pallet.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Storage.PalletAssembly-CSharp.dll_Excuted");
			Pallet.NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678588);
			Pallet.NativeMethodInfoPtr_get_carriedByForklift_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678589);
			Pallet.NativeMethodInfoPtr_get_storedItemContainer_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678590);
			Pallet.NativeMethodInfoPtr_get_reservedItems_Public_Virtual_Final_New_get_Dictionary_2_StoredItem_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678591);
			Pallet.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678592);
			Pallet.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678593);
			Pallet.NativeMethodInfoPtr_SetOwner_Protected_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678594);
			Pallet.NativeMethodInfoPtr_OnOwnershipClient_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678595);
			Pallet.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678596);
			Pallet.NativeMethodInfoPtr_SendItemsToClient_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678597);
			Pallet.NativeMethodInfoPtr_DestroyPallet_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678598);
			Pallet.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678599);
			Pallet.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678600);
			Pallet.NativeMethodInfoPtr_SetPosition_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678601);
			Pallet.NativeMethodInfoPtr_UpdateOwnership_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678602);
			Pallet.NativeMethodInfoPtr_BindToSlot_Server_Public_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678603);
			Pallet.NativeMethodInfoPtr_BindToSlot_Private_Void_NetworkConnection_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678604);
			Pallet.NativeMethodInfoPtr_ExitSlot_Server_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678605);
			Pallet.NativeMethodInfoPtr_ExitSlot_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678606);
			Pallet.NativeMethodInfoPtr_TriggerStay_Public_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678607);
			Pallet.NativeMethodInfoPtr_GetStoredItems_Public_Virtual_Final_New_List_1_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678608);
			Pallet.NativeMethodInfoPtr_GetStorageGrids_Public_Virtual_Final_New_List_1_StorageGrid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678609);
			Pallet.NativeMethodInfoPtr_CreateStoredItem_Public_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678610);
			Pallet.NativeMethodInfoPtr_CreateStoredItem_Server_Private_Void_StorableItemInstance_Int32_Vector2_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678611);
			Pallet.NativeMethodInfoPtr_DestroyStoredItem_Public_Void_Int32_Coordinate_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678612);
			Pallet.NativeMethodInfoPtr_DestroyStoredItem_Server_Private_Void_Int32_Coordinate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678613);
			Pallet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678614);
			Pallet.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678616);
			Pallet.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678617);
			Pallet.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678618);
			Pallet.NativeMethodInfoPtr_RpcWriter___Server_SetOwner_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678619);
			Pallet.NativeMethodInfoPtr_RpcLogic___SetOwner_328543758_Protected_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678620);
			Pallet.NativeMethodInfoPtr_RpcReader___Server_SetOwner_328543758_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678621);
			Pallet.NativeMethodInfoPtr_RpcWriter___Server_BindToSlot_Server_1272046255_Private_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678622);
			Pallet.NativeMethodInfoPtr_RpcLogic___BindToSlot_Server_1272046255_Public_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678623);
			Pallet.NativeMethodInfoPtr_RpcReader___Server_BindToSlot_Server_1272046255_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678624);
			Pallet.NativeMethodInfoPtr_RpcWriter___Observers_BindToSlot_454078614_Private_Void_NetworkConnection_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678625);
			Pallet.NativeMethodInfoPtr_RpcLogic___BindToSlot_454078614_Private_Void_NetworkConnection_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678626);
			Pallet.NativeMethodInfoPtr_RpcReader___Observers_BindToSlot_454078614_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678627);
			Pallet.NativeMethodInfoPtr_RpcWriter___Target_BindToSlot_454078614_Private_Void_NetworkConnection_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678628);
			Pallet.NativeMethodInfoPtr_RpcReader___Target_BindToSlot_454078614_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678629);
			Pallet.NativeMethodInfoPtr_RpcWriter___Server_ExitSlot_Server_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678630);
			Pallet.NativeMethodInfoPtr_RpcLogic___ExitSlot_Server_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678631);
			Pallet.NativeMethodInfoPtr_RpcReader___Server_ExitSlot_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678632);
			Pallet.NativeMethodInfoPtr_RpcWriter___Observers_ExitSlot_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678633);
			Pallet.NativeMethodInfoPtr_RpcLogic___ExitSlot_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678634);
			Pallet.NativeMethodInfoPtr_RpcReader___Observers_ExitSlot_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678635);
			Pallet.NativeMethodInfoPtr_RpcWriter___Observers_CreateStoredItem_913707843_Private_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678636);
			Pallet.NativeMethodInfoPtr_RpcLogic___CreateStoredItem_913707843_Public_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678637);
			Pallet.NativeMethodInfoPtr_RpcReader___Observers_CreateStoredItem_913707843_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678638);
			Pallet.NativeMethodInfoPtr_RpcWriter___Target_CreateStoredItem_913707843_Private_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678639);
			Pallet.NativeMethodInfoPtr_RpcReader___Target_CreateStoredItem_913707843_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678640);
			Pallet.NativeMethodInfoPtr_RpcWriter___Server_CreateStoredItem_Server_1890711751_Private_Void_StorableItemInstance_Int32_Vector2_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678641);
			Pallet.NativeMethodInfoPtr_RpcLogic___CreateStoredItem_Server_1890711751_Private_Void_StorableItemInstance_Int32_Vector2_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678642);
			Pallet.NativeMethodInfoPtr_RpcReader___Server_CreateStoredItem_Server_1890711751_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678643);
			Pallet.NativeMethodInfoPtr_RpcWriter___Observers_DestroyStoredItem_3261517793_Private_Void_Int32_Coordinate_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678644);
			Pallet.NativeMethodInfoPtr_RpcLogic___DestroyStoredItem_3261517793_Public_Void_Int32_Coordinate_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678645);
			Pallet.NativeMethodInfoPtr_RpcReader___Observers_DestroyStoredItem_3261517793_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678646);
			Pallet.NativeMethodInfoPtr_RpcWriter___Server_DestroyStoredItem_Server_3952619116_Private_Void_Int32_Coordinate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678647);
			Pallet.NativeMethodInfoPtr_RpcLogic___DestroyStoredItem_Server_3952619116_Private_Void_Int32_Coordinate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678648);
			Pallet.NativeMethodInfoPtr_RpcReader___Server_DestroyStoredItem_Server_3952619116_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678649);
			Pallet.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678650);
		}

		// Token: 0x1700250F RID: 9487
		// (get) Token: 0x06007A31 RID: 31281 RVA: 0x0020EA14 File Offset: 0x0020CC14
		public unsafe bool isEmpty
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233948, XrefRangeEnd = 233949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002510 RID: 9488
		// (get) Token: 0x06007A32 RID: 31282 RVA: 0x0020EA50 File Offset: 0x0020CC50
		public unsafe bool carriedByForklift
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233949, XrefRangeEnd = 233950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_get_carriedByForklift_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002511 RID: 9489
		// (get) Token: 0x06007A33 RID: 31283 RVA: 0x0020EA8C File Offset: 0x0020CC8C
		public unsafe virtual Transform storedItemContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_get_storedItemContainer_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17002512 RID: 9490
		// (get) Token: 0x06007A34 RID: 31284 RVA: 0x0020EACC File Offset: 0x0020CCCC
		public unsafe virtual Dictionary<StoredItem, Employee> reservedItems
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 86730, RefRangeEnd = 86731, XrefRangeStart = 86730, XrefRangeEnd = 86731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_get_reservedItems_Public_Virtual_Final_New_get_Dictionary_2_StoredItem_Employee_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<StoredItem, Employee>>(intPtr3) : null;
			}
		}

		// Token: 0x06007A35 RID: 31285 RVA: 0x0020EB0C File Offset: 0x0020CD0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233950, XrefRangeEnd = 233954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A36 RID: 31286 RVA: 0x0020EB48 File Offset: 0x0020CD48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233954, XrefRangeEnd = 233961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A37 RID: 31287 RVA: 0x0020EB84 File Offset: 0x0020CD84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233961, XrefRangeEnd = 233980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetOwner(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_SetOwner_Protected_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A38 RID: 31288 RVA: 0x0020EBD4 File Offset: 0x0020CDD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233980, XrefRangeEnd = 234004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnOwnershipClient(NetworkConnection prevOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prevOwner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_OnOwnershipClient_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A39 RID: 31289 RVA: 0x0020EC24 File Offset: 0x0020CE24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234004, XrefRangeEnd = 234011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A3A RID: 31290 RVA: 0x0020EC74 File Offset: 0x0020CE74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 234029, RefRangeEnd = 234030, XrefRangeStart = 234011, XrefRangeEnd = 234029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendItemsToClient(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_SendItemsToClient_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A3B RID: 31291 RVA: 0x0020ECB8 File Offset: 0x0020CEB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234030, XrefRangeEnd = 234031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyPallet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_DestroyPallet_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A3C RID: 31292 RVA: 0x0020ECF4 File Offset: 0x0020CEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234031, XrefRangeEnd = 234037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A3D RID: 31293 RVA: 0x0020ED30 File Offset: 0x0020CF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234037, XrefRangeEnd = 234131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A3E RID: 31294 RVA: 0x0020ED6C File Offset: 0x0020CF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234131, XrefRangeEnd = 234133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPosition(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_SetPosition_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A3F RID: 31295 RVA: 0x0020EDAC File Offset: 0x0020CFAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 234150, RefRangeEnd = 234151, XrefRangeStart = 234133, XrefRangeEnd = 234150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateOwnership()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_UpdateOwnership_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A40 RID: 31296 RVA: 0x0020EDE0 File Offset: 0x0020CFE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 234173, RefRangeEnd = 234175, XrefRangeStart = 234151, XrefRangeEnd = 234173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BindToSlot_Server(Guid slotGuid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref slotGuid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_BindToSlot_Server_Public_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A41 RID: 31297 RVA: 0x0020EE20 File Offset: 0x0020D020
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 234208, RefRangeEnd = 234212, XrefRangeStart = 234175, XrefRangeEnd = 234208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BindToSlot(NetworkConnection conn, Guid slotGuid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slotGuid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_BindToSlot_Private_Void_NetworkConnection_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A42 RID: 31298 RVA: 0x0020EE70 File Offset: 0x0020D070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234212, XrefRangeEnd = 234233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitSlot_Server()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_ExitSlot_Server_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A43 RID: 31299 RVA: 0x0020EEA4 File Offset: 0x0020D0A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 234251, RefRangeEnd = 234254, XrefRangeStart = 234233, XrefRangeEnd = 234251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitSlot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_ExitSlot_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A44 RID: 31300 RVA: 0x0020EED8 File Offset: 0x0020D0D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 234283, RefRangeEnd = 234284, XrefRangeStart = 234254, XrefRangeEnd = 234283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_TriggerStay_Public_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A45 RID: 31301 RVA: 0x0020EF1C File Offset: 0x0020D11C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234284, XrefRangeEnd = 234293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<StoredItem> GetStoredItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_GetStoredItems_Public_Virtual_Final_New_List_1_StoredItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<StoredItem>>(intPtr3) : null;
		}

		// Token: 0x06007A46 RID: 31302 RVA: 0x0020EF5C File Offset: 0x0020D15C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 234302, RefRangeEnd = 234304, XrefRangeStart = 234293, XrefRangeEnd = 234302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<StorageGrid> GetStorageGrids()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_GetStorageGrids_Public_Virtual_Final_New_List_1_StorageGrid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<StorageGrid>>(intPtr3) : null;
		}

		// Token: 0x06007A47 RID: 31303 RVA: 0x0020EF9C File Offset: 0x0020D19C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234304, XrefRangeEnd = 234305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateStoredItem(NetworkConnection conn, StorableItemInstance item, int gridIndex, Vector2 originCoord, float rotation, string jobID = "", bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoord;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_CreateStoredItem_Public_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A48 RID: 31304 RVA: 0x0020F03C File Offset: 0x0020D23C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234305, XrefRangeEnd = 234330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateStoredItem_Server(StorableItemInstance data, int gridIndex, Vector2 originCoord, float rotation, string jobID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoord;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_CreateStoredItem_Server_Private_Void_StorableItemInstance_Int32_Vector2_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A49 RID: 31305 RVA: 0x0020F0BC File Offset: 0x0020D2BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234330, XrefRangeEnd = 234356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyStoredItem(int gridIndex, Coordinate coord, string jobID = "", bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_DestroyStoredItem_Public_Void_Int32_Coordinate_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A4A RID: 31306 RVA: 0x0020F12C File Offset: 0x0020D32C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234356, XrefRangeEnd = 234369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyStoredItem_Server(int gridIndex, Coordinate coord, string jobID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_DestroyStoredItem_Server_Private_Void_Int32_Coordinate_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A4B RID: 31307 RVA: 0x0020F190 File Offset: 0x0020D390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234369, XrefRangeEnd = 234391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pallet() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pallet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A4C RID: 31308 RVA: 0x0020F1CC File Offset: 0x0020D3CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234391, XrefRangeEnd = 234459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A4D RID: 31309 RVA: 0x0020F208 File Offset: 0x0020D408
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 234459, RefRangeEnd = 234460, XrefRangeStart = 234459, XrefRangeEnd = 234459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A4E RID: 31310 RVA: 0x0020F244 File Offset: 0x0020D444
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A4F RID: 31311 RVA: 0x0020F280 File Offset: 0x0020D480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetOwner_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcWriter___Server_SetOwner_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A50 RID: 31312 RVA: 0x0020F2C4 File Offset: 0x0020D4C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 234504, RefRangeEnd = 234505, XrefRangeStart = 234460, XrefRangeEnd = 234504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetOwner_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_RpcLogic___SetOwner_328543758_Protected_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A51 RID: 31313 RVA: 0x0020F314 File Offset: 0x0020D514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234505, XrefRangeEnd = 234508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetOwner_328543758(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcReader___Server_SetOwner_328543758_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A52 RID: 31314 RVA: 0x0020F378 File Offset: 0x0020D578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234508, XrefRangeEnd = 234519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_BindToSlot_Server_1272046255(Guid slotGuid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref slotGuid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcWriter___Server_BindToSlot_Server_1272046255_Private_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A53 RID: 31315 RVA: 0x0020F3B8 File Offset: 0x0020D5B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234519, XrefRangeEnd = 234520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___BindToSlot_Server_1272046255(Guid slotGuid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref slotGuid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcLogic___BindToSlot_Server_1272046255_Public_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A54 RID: 31316 RVA: 0x0020F3F8 File Offset: 0x0020D5F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234520, XrefRangeEnd = 234524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_BindToSlot_Server_1272046255(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcReader___Server_BindToSlot_Server_1272046255_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A55 RID: 31317 RVA: 0x0020F45C File Offset: 0x0020D65C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234524, XrefRangeEnd = 234535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_BindToSlot_454078614(NetworkConnection conn, Guid slotGuid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slotGuid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcWriter___Observers_BindToSlot_454078614_Private_Void_NetworkConnection_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A56 RID: 31318 RVA: 0x0020F4AC File Offset: 0x0020D6AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 234604, RefRangeEnd = 234606, XrefRangeStart = 234535, XrefRangeEnd = 234604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___BindToSlot_454078614(NetworkConnection conn, Guid slotGuid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slotGuid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcLogic___BindToSlot_454078614_Private_Void_NetworkConnection_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A57 RID: 31319 RVA: 0x0020F4FC File Offset: 0x0020D6FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234606, XrefRangeEnd = 234609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_BindToSlot_454078614(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcReader___Observers_BindToSlot_454078614_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A58 RID: 31320 RVA: 0x0020F54C File Offset: 0x0020D74C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234609, XrefRangeEnd = 234620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_BindToSlot_454078614(NetworkConnection conn, Guid slotGuid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slotGuid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcWriter___Target_BindToSlot_454078614_Private_Void_NetworkConnection_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A59 RID: 31321 RVA: 0x0020F59C File Offset: 0x0020D79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234620, XrefRangeEnd = 234624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_BindToSlot_454078614(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcReader___Target_BindToSlot_454078614_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A5A RID: 31322 RVA: 0x0020F5EC File Offset: 0x0020D7EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234624, XrefRangeEnd = 234642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ExitSlot_Server_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcWriter___Server_ExitSlot_Server_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A5B RID: 31323 RVA: 0x0020F620 File Offset: 0x0020D820
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 234251, RefRangeEnd = 234254, XrefRangeStart = 234251, XrefRangeEnd = 234254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ExitSlot_Server_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcLogic___ExitSlot_Server_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A5C RID: 31324 RVA: 0x0020F654 File Offset: 0x0020D854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234642, XrefRangeEnd = 234645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ExitSlot_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcReader___Server_ExitSlot_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A5D RID: 31325 RVA: 0x0020F6B8 File Offset: 0x0020D8B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 234251, RefRangeEnd = 234254, XrefRangeStart = 234251, XrefRangeEnd = 234254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ExitSlot_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcWriter___Observers_ExitSlot_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A5E RID: 31326 RVA: 0x0020F6EC File Offset: 0x0020D8EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 234685, RefRangeEnd = 234686, XrefRangeStart = 234645, XrefRangeEnd = 234685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ExitSlot_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcLogic___ExitSlot_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A5F RID: 31327 RVA: 0x0020F720 File Offset: 0x0020D920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234686, XrefRangeEnd = 234688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ExitSlot_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcReader___Observers_ExitSlot_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A60 RID: 31328 RVA: 0x0020F770 File Offset: 0x0020D970
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 234714, RefRangeEnd = 234717, XrefRangeStart = 234688, XrefRangeEnd = 234714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_CreateStoredItem_913707843(NetworkConnection conn, StorableItemInstance item, int gridIndex, Vector2 originCoord, float rotation, string jobID = "", bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoord;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcWriter___Observers_CreateStoredItem_913707843_Private_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A61 RID: 31329 RVA: 0x0020F810 File Offset: 0x0020DA10
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 234756, RefRangeEnd = 234761, XrefRangeStart = 234717, XrefRangeEnd = 234756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___CreateStoredItem_913707843(NetworkConnection conn, StorableItemInstance item, int gridIndex, Vector2 originCoord, float rotation, string jobID = "", bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoord;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcLogic___CreateStoredItem_913707843_Public_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A62 RID: 31330 RVA: 0x0020F8B0 File Offset: 0x0020DAB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234761, XrefRangeEnd = 234771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_CreateStoredItem_913707843(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcReader___Observers_CreateStoredItem_913707843_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A63 RID: 31331 RVA: 0x0020F900 File Offset: 0x0020DB00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 234788, RefRangeEnd = 234790, XrefRangeStart = 234771, XrefRangeEnd = 234788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_CreateStoredItem_913707843(NetworkConnection conn, StorableItemInstance item, int gridIndex, Vector2 originCoord, float rotation, string jobID = "", bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoord;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcWriter___Target_CreateStoredItem_913707843_Private_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A64 RID: 31332 RVA: 0x0020F9A0 File Offset: 0x0020DBA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234790, XrefRangeEnd = 234800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_CreateStoredItem_913707843(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcReader___Target_CreateStoredItem_913707843_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A65 RID: 31333 RVA: 0x0020F9F0 File Offset: 0x0020DBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234800, XrefRangeEnd = 234825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_CreateStoredItem_Server_1890711751(StorableItemInstance data, int gridIndex, Vector2 originCoord, float rotation, string jobID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoord;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcWriter___Server_CreateStoredItem_Server_1890711751_Private_Void_StorableItemInstance_Int32_Vector2_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A66 RID: 31334 RVA: 0x0020FA70 File Offset: 0x0020DC70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234825, XrefRangeEnd = 234827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___CreateStoredItem_Server_1890711751(StorableItemInstance data, int gridIndex, Vector2 originCoord, float rotation, string jobID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoord;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcLogic___CreateStoredItem_Server_1890711751_Private_Void_StorableItemInstance_Int32_Vector2_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A67 RID: 31335 RVA: 0x0020FAF0 File Offset: 0x0020DCF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234827, XrefRangeEnd = 234837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_CreateStoredItem_Server_1890711751(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcReader___Server_CreateStoredItem_Server_1890711751_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A68 RID: 31336 RVA: 0x0020FB54 File Offset: 0x0020DD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234837, XrefRangeEnd = 234851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_DestroyStoredItem_3261517793(int gridIndex, Coordinate coord, string jobID = "", bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcWriter___Observers_DestroyStoredItem_3261517793_Private_Void_Int32_Coordinate_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A69 RID: 31337 RVA: 0x0020FBC4 File Offset: 0x0020DDC4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 234911, RefRangeEnd = 234915, XrefRangeStart = 234851, XrefRangeEnd = 234911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___DestroyStoredItem_3261517793(int gridIndex, Coordinate coord, string jobID = "", bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcLogic___DestroyStoredItem_3261517793_Public_Void_Int32_Coordinate_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A6A RID: 31338 RVA: 0x0020FC34 File Offset: 0x0020DE34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234915, XrefRangeEnd = 234922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_DestroyStoredItem_3261517793(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcReader___Observers_DestroyStoredItem_3261517793_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A6B RID: 31339 RVA: 0x0020FC84 File Offset: 0x0020DE84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_DestroyStoredItem_Server_3952619116(int gridIndex, Coordinate coord, string jobID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcWriter___Server_DestroyStoredItem_Server_3952619116_Private_Void_Int32_Coordinate_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A6C RID: 31340 RVA: 0x0020FCE8 File Offset: 0x0020DEE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234922, XrefRangeEnd = 234947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___DestroyStoredItem_Server_3952619116(int gridIndex, Coordinate coord, string jobID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gridIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcLogic___DestroyStoredItem_Server_3952619116_Private_Void_Int32_Coordinate_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A6D RID: 31341 RVA: 0x0020FD4C File Offset: 0x0020DF4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234947, XrefRangeEnd = 234977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_DestroyStoredItem_Server_3952619116(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcReader___Server_DestroyStoredItem_Server_3952619116_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A6E RID: 31342 RVA: 0x0020FDB0 File Offset: 0x0020DFB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234977, XrefRangeEnd = 234980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A6F RID: 31343 RVA: 0x0003A289 File Offset: 0x00038489
		public Pallet(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024FC RID: 9468
		// (get) Token: 0x06007A70 RID: 31344 RVA: 0x0020FDEC File Offset: 0x0020DFEC
		// (set) Token: 0x06007A71 RID: 31345 RVA: 0x0003A292 File Offset: 0x00038492
		public unsafe static List<Pallet> palletsOwnedByLocalPlayer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Pallet.NativeFieldInfoPtr_palletsOwnedByLocalPlayer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Pallet>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Pallet.NativeFieldInfoPtr_palletsOwnedByLocalPlayer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024FD RID: 9469
		// (get) Token: 0x06007A72 RID: 31346 RVA: 0x0020FE14 File Offset: 0x0020E014
		// (set) Token: 0x06007A73 RID: 31347 RVA: 0x0003A2A4 File Offset: 0x000384A4
		public unsafe static int sizeX
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Pallet.NativeFieldInfoPtr_sizeX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Pallet.NativeFieldInfoPtr_sizeX, (void*)(&value));
			}
		}

		// Token: 0x170024FE RID: 9470
		// (get) Token: 0x06007A74 RID: 31348 RVA: 0x0020FE30 File Offset: 0x0020E030
		// (set) Token: 0x06007A75 RID: 31349 RVA: 0x0003A2B2 File Offset: 0x000384B2
		public unsafe static int sizeY
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Pallet.NativeFieldInfoPtr_sizeY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Pallet.NativeFieldInfoPtr_sizeY, (void*)(&value));
			}
		}

		// Token: 0x170024FF RID: 9471
		// (get) Token: 0x06007A76 RID: 31350 RVA: 0x0020FE4C File Offset: 0x0020E04C
		// (set) Token: 0x06007A77 RID: 31351 RVA: 0x0003A2C0 File Offset: 0x000384C0
		public unsafe Transform _storedItemContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr__storedItemContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr__storedItemContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002500 RID: 9472
		// (get) Token: 0x06007A78 RID: 31352 RVA: 0x0020FE7C File Offset: 0x0020E07C
		// (set) Token: 0x06007A79 RID: 31353 RVA: 0x0003A2DF File Offset: 0x000384DF
		public unsafe Rigidbody rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002501 RID: 9473
		// (get) Token: 0x06007A7A RID: 31354 RVA: 0x0020FEAC File Offset: 0x0020E0AC
		// (set) Token: 0x06007A7B RID: 31355 RVA: 0x0003A2FE File Offset: 0x000384FE
		public unsafe StorageGrid storageGrid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_storageGrid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageGrid>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_storageGrid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002502 RID: 9474
		// (get) Token: 0x06007A7C RID: 31356 RVA: 0x0020FEDC File Offset: 0x0020E0DC
		// (set) Token: 0x06007A7D RID: 31357 RVA: 0x0003A31D File Offset: 0x0003851D
		public unsafe NetworkTransform networkTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_networkTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_networkTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002503 RID: 9475
		// (get) Token: 0x06007A7E RID: 31358 RVA: 0x0020FF0C File Offset: 0x0020E10C
		// (set) Token: 0x06007A7F RID: 31359 RVA: 0x0003A33C File Offset: 0x0003853C
		public unsafe List<Forklift> forkliftsInContact
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_forkliftsInContact);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Forklift>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_forkliftsInContact), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002504 RID: 9476
		// (get) Token: 0x06007A80 RID: 31360 RVA: 0x0020FF3C File Offset: 0x0020E13C
		// (set) Token: 0x06007A81 RID: 31361 RVA: 0x0003A35B File Offset: 0x0003855B
		public unsafe Guid currentSlotGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_currentSlotGUID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_currentSlotGUID)) = value;
			}
		}

		// Token: 0x17002505 RID: 9477
		// (get) Token: 0x06007A82 RID: 31362 RVA: 0x0020FF64 File Offset: 0x0020E164
		// (set) Token: 0x06007A83 RID: 31363 RVA: 0x0003A376 File Offset: 0x00038576
		public unsafe PalletSlot currentSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_currentSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PalletSlot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_currentSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002506 RID: 9478
		// (get) Token: 0x06007A84 RID: 31364 RVA: 0x0020FF94 File Offset: 0x0020E194
		// (set) Token: 0x06007A85 RID: 31365 RVA: 0x0003A395 File Offset: 0x00038595
		public unsafe float timeSinceSlotCheck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_timeSinceSlotCheck);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_timeSinceSlotCheck)) = value;
			}
		}

		// Token: 0x17002507 RID: 9479
		// (get) Token: 0x06007A86 RID: 31366 RVA: 0x0020FFBC File Offset: 0x0020E1BC
		// (set) Token: 0x06007A87 RID: 31367 RVA: 0x0003A3B0 File Offset: 0x000385B0
		public unsafe float timeBoundToSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_timeBoundToSlot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_timeBoundToSlot)) = value;
			}
		}

		// Token: 0x17002508 RID: 9480
		// (get) Token: 0x06007A88 RID: 31368 RVA: 0x0020FFE4 File Offset: 0x0020E1E4
		// (set) Token: 0x06007A89 RID: 31369 RVA: 0x0003A3CB File Offset: 0x000385CB
		public unsafe float rb_Mass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_rb_Mass);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_rb_Mass)) = value;
			}
		}

		// Token: 0x17002509 RID: 9481
		// (get) Token: 0x06007A8A RID: 31370 RVA: 0x0021000C File Offset: 0x0020E20C
		// (set) Token: 0x06007A8B RID: 31371 RVA: 0x0003A3E6 File Offset: 0x000385E6
		public unsafe float rb_Drag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_rb_Drag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_rb_Drag)) = value;
			}
		}

		// Token: 0x1700250A RID: 9482
		// (get) Token: 0x06007A8C RID: 31372 RVA: 0x00210034 File Offset: 0x0020E234
		// (set) Token: 0x06007A8D RID: 31373 RVA: 0x0003A401 File Offset: 0x00038601
		public unsafe float rb_AngularDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_rb_AngularDrag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_rb_AngularDrag)) = value;
			}
		}

		// Token: 0x1700250B RID: 9483
		// (get) Token: 0x06007A8E RID: 31374 RVA: 0x0021005C File Offset: 0x0020E25C
		// (set) Token: 0x06007A8F RID: 31375 RVA: 0x0003A41C File Offset: 0x0003861C
		public unsafe Dictionary<StoredItem, Employee> _reservedItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr__reservedItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<StoredItem, Employee>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr__reservedItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700250C RID: 9484
		// (get) Token: 0x06007A90 RID: 31376 RVA: 0x0021008C File Offset: 0x0020E28C
		// (set) Token: 0x06007A91 RID: 31377 RVA: 0x0003A43B File Offset: 0x0003863B
		public unsafe List<string> completedJobs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_completedJobs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_completedJobs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700250D RID: 9485
		// (get) Token: 0x06007A92 RID: 31378 RVA: 0x002100BC File Offset: 0x0020E2BC
		// (set) Token: 0x06007A93 RID: 31379 RVA: 0x0003A45A File Offset: 0x0003865A
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700250E RID: 9486
		// (get) Token: 0x06007A94 RID: 31380 RVA: 0x002100E4 File Offset: 0x0020E2E4
		// (set) Token: 0x06007A95 RID: 31381 RVA: 0x0003A475 File Offset: 0x00038675
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400531F RID: 21279
		private static readonly IntPtr NativeFieldInfoPtr_palletsOwnedByLocalPlayer;

		// Token: 0x04005320 RID: 21280
		private static readonly IntPtr NativeFieldInfoPtr_sizeX;

		// Token: 0x04005321 RID: 21281
		private static readonly IntPtr NativeFieldInfoPtr_sizeY;

		// Token: 0x04005322 RID: 21282
		private static readonly IntPtr NativeFieldInfoPtr__storedItemContainer;

		// Token: 0x04005323 RID: 21283
		private static readonly IntPtr NativeFieldInfoPtr_rb;

		// Token: 0x04005324 RID: 21284
		private static readonly IntPtr NativeFieldInfoPtr_storageGrid;

		// Token: 0x04005325 RID: 21285
		private static readonly IntPtr NativeFieldInfoPtr_networkTransform;

		// Token: 0x04005326 RID: 21286
		private static readonly IntPtr NativeFieldInfoPtr_forkliftsInContact;

		// Token: 0x04005327 RID: 21287
		private static readonly IntPtr NativeFieldInfoPtr_currentSlotGUID;

		// Token: 0x04005328 RID: 21288
		private static readonly IntPtr NativeFieldInfoPtr_currentSlot;

		// Token: 0x04005329 RID: 21289
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceSlotCheck;

		// Token: 0x0400532A RID: 21290
		private static readonly IntPtr NativeFieldInfoPtr_timeBoundToSlot;

		// Token: 0x0400532B RID: 21291
		private static readonly IntPtr NativeFieldInfoPtr_rb_Mass;

		// Token: 0x0400532C RID: 21292
		private static readonly IntPtr NativeFieldInfoPtr_rb_Drag;

		// Token: 0x0400532D RID: 21293
		private static readonly IntPtr NativeFieldInfoPtr_rb_AngularDrag;

		// Token: 0x0400532E RID: 21294
		private static readonly IntPtr NativeFieldInfoPtr__reservedItems;

		// Token: 0x0400532F RID: 21295
		private static readonly IntPtr NativeFieldInfoPtr_completedJobs;

		// Token: 0x04005330 RID: 21296
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04005331 RID: 21297
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04005332 RID: 21298
		private static readonly IntPtr NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0;

		// Token: 0x04005333 RID: 21299
		private static readonly IntPtr NativeMethodInfoPtr_get_carriedByForklift_Protected_get_Boolean_0;

		// Token: 0x04005334 RID: 21300
		private static readonly IntPtr NativeMethodInfoPtr_get_storedItemContainer_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04005335 RID: 21301
		private static readonly IntPtr NativeMethodInfoPtr_get_reservedItems_Public_Virtual_Final_New_get_Dictionary_2_StoredItem_Employee_0;

		// Token: 0x04005336 RID: 21302
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04005337 RID: 21303
		private static readonly IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x04005338 RID: 21304
		private static readonly IntPtr NativeMethodInfoPtr_SetOwner_Protected_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x04005339 RID: 21305
		private static readonly IntPtr NativeMethodInfoPtr_OnOwnershipClient_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x0400533A RID: 21306
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x0400533B RID: 21307
		private static readonly IntPtr NativeMethodInfoPtr_SendItemsToClient_Private_Void_NetworkConnection_0;

		// Token: 0x0400533C RID: 21308
		private static readonly IntPtr NativeMethodInfoPtr_DestroyPallet_Public_Virtual_New_Void_0;

		// Token: 0x0400533D RID: 21309
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1;

		// Token: 0x0400533E RID: 21310
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x0400533F RID: 21311
		private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Private_Void_Vector3_0;

		// Token: 0x04005340 RID: 21312
		private static readonly IntPtr NativeMethodInfoPtr_UpdateOwnership_Private_Void_0;

		// Token: 0x04005341 RID: 21313
		private static readonly IntPtr NativeMethodInfoPtr_BindToSlot_Server_Public_Void_Guid_0;

		// Token: 0x04005342 RID: 21314
		private static readonly IntPtr NativeMethodInfoPtr_BindToSlot_Private_Void_NetworkConnection_Guid_0;

		// Token: 0x04005343 RID: 21315
		private static readonly IntPtr NativeMethodInfoPtr_ExitSlot_Server_Public_Void_0;

		// Token: 0x04005344 RID: 21316
		private static readonly IntPtr NativeMethodInfoPtr_ExitSlot_Private_Void_0;

		// Token: 0x04005345 RID: 21317
		private static readonly IntPtr NativeMethodInfoPtr_TriggerStay_Public_Void_Collider_0;

		// Token: 0x04005346 RID: 21318
		private static readonly IntPtr NativeMethodInfoPtr_GetStoredItems_Public_Virtual_Final_New_List_1_StoredItem_0;

		// Token: 0x04005347 RID: 21319
		private static readonly IntPtr NativeMethodInfoPtr_GetStorageGrids_Public_Virtual_Final_New_List_1_StorageGrid_0;

		// Token: 0x04005348 RID: 21320
		private static readonly IntPtr NativeMethodInfoPtr_CreateStoredItem_Public_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0;

		// Token: 0x04005349 RID: 21321
		private static readonly IntPtr NativeMethodInfoPtr_CreateStoredItem_Server_Private_Void_StorableItemInstance_Int32_Vector2_Single_String_0;

		// Token: 0x0400534A RID: 21322
		private static readonly IntPtr NativeMethodInfoPtr_DestroyStoredItem_Public_Void_Int32_Coordinate_String_Boolean_0;

		// Token: 0x0400534B RID: 21323
		private static readonly IntPtr NativeMethodInfoPtr_DestroyStoredItem_Server_Private_Void_Int32_Coordinate_String_0;

		// Token: 0x0400534C RID: 21324
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400534D RID: 21325
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400534E RID: 21326
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400534F RID: 21327
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04005350 RID: 21328
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetOwner_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04005351 RID: 21329
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetOwner_328543758_Protected_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x04005352 RID: 21330
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetOwner_328543758_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04005353 RID: 21331
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_BindToSlot_Server_1272046255_Private_Void_Guid_0;

		// Token: 0x04005354 RID: 21332
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___BindToSlot_Server_1272046255_Public_Void_Guid_0;

		// Token: 0x04005355 RID: 21333
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_BindToSlot_Server_1272046255_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04005356 RID: 21334
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_BindToSlot_454078614_Private_Void_NetworkConnection_Guid_0;

		// Token: 0x04005357 RID: 21335
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___BindToSlot_454078614_Private_Void_NetworkConnection_Guid_0;

		// Token: 0x04005358 RID: 21336
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_BindToSlot_454078614_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005359 RID: 21337
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_BindToSlot_454078614_Private_Void_NetworkConnection_Guid_0;

		// Token: 0x0400535A RID: 21338
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_BindToSlot_454078614_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400535B RID: 21339
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ExitSlot_Server_2166136261_Private_Void_0;

		// Token: 0x0400535C RID: 21340
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ExitSlot_Server_2166136261_Public_Void_0;

		// Token: 0x0400535D RID: 21341
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ExitSlot_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400535E RID: 21342
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ExitSlot_2166136261_Private_Void_0;

		// Token: 0x0400535F RID: 21343
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ExitSlot_2166136261_Private_Void_0;

		// Token: 0x04005360 RID: 21344
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ExitSlot_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005361 RID: 21345
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_CreateStoredItem_913707843_Private_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0;

		// Token: 0x04005362 RID: 21346
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___CreateStoredItem_913707843_Public_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0;

		// Token: 0x04005363 RID: 21347
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_CreateStoredItem_913707843_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005364 RID: 21348
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_CreateStoredItem_913707843_Private_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0;

		// Token: 0x04005365 RID: 21349
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_CreateStoredItem_913707843_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005366 RID: 21350
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_CreateStoredItem_Server_1890711751_Private_Void_StorableItemInstance_Int32_Vector2_Single_String_0;

		// Token: 0x04005367 RID: 21351
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___CreateStoredItem_Server_1890711751_Private_Void_StorableItemInstance_Int32_Vector2_Single_String_0;

		// Token: 0x04005368 RID: 21352
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_CreateStoredItem_Server_1890711751_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04005369 RID: 21353
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_DestroyStoredItem_3261517793_Private_Void_Int32_Coordinate_String_Boolean_0;

		// Token: 0x0400536A RID: 21354
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___DestroyStoredItem_3261517793_Public_Void_Int32_Coordinate_String_Boolean_0;

		// Token: 0x0400536B RID: 21355
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_DestroyStoredItem_3261517793_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400536C RID: 21356
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_DestroyStoredItem_Server_3952619116_Private_Void_Int32_Coordinate_String_0;

		// Token: 0x0400536D RID: 21357
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___DestroyStoredItem_Server_3952619116_Private_Void_Int32_Coordinate_String_0;

		// Token: 0x0400536E RID: 21358
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_DestroyStoredItem_Server_3952619116_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400536F RID: 21359
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;
	}
}
