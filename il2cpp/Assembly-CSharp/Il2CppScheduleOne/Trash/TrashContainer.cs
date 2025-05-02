using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x0200051E RID: 1310
	public class TrashContainer : NetworkBehaviour
	{
		// Token: 0x0600749E RID: 29854 RVA: 0x001FC22C File Offset: 0x001FA42C
		// Note: this type is marked as 'beforefieldinit'.
		static TrashContainer()
		{
			Il2CppClassPointerStore<TrashContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr);
			TrashContainer.NativeFieldInfoPtr__Content_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, "<Content>k__BackingField");
			TrashContainer.NativeFieldInfoPtr_TrashCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, "TrashCapacity");
			TrashContainer.NativeFieldInfoPtr_TrashBagDropLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, "TrashBagDropLocation");
			TrashContainer.NativeFieldInfoPtr_onTrashAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, "onTrashAdded");
			TrashContainer.NativeFieldInfoPtr_onTrashLevelChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, "onTrashLevelChanged");
			TrashContainer.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Trash.TrashContainerAssembly-CSharp.dll_Excuted");
			TrashContainer.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Trash.TrashContainerAssembly-CSharp.dll_Excuted");
			TrashContainer.NativeMethodInfoPtr_get_Content_Public_get_TrashContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677950);
			TrashContainer.NativeMethodInfoPtr_set_Content_Protected_set_Void_TrashContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677951);
			TrashContainer.NativeMethodInfoPtr_get_TrashLevel_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677952);
			TrashContainer.NativeMethodInfoPtr_get_NormalizedTrashLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677953);
			TrashContainer.NativeMethodInfoPtr_AddTrash_Public_Virtual_New_Void_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677954);
			TrashContainer.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677955);
			TrashContainer.NativeMethodInfoPtr_SendTrash_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677956);
			TrashContainer.NativeMethodInfoPtr_AddTrash_Private_Void_NetworkConnection_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677957);
			TrashContainer.NativeMethodInfoPtr_SendClear_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677958);
			TrashContainer.NativeMethodInfoPtr_Clear_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677959);
			TrashContainer.NativeMethodInfoPtr_LoadContent_Private_Void_NetworkConnection_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677960);
			TrashContainer.NativeMethodInfoPtr_TriggerEnter_Public_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677961);
			TrashContainer.NativeMethodInfoPtr_CanBeBagged_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677962);
			TrashContainer.NativeMethodInfoPtr_BagTrash_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677963);
			TrashContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677964);
			TrashContainer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677965);
			TrashContainer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677966);
			TrashContainer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677967);
			TrashContainer.NativeMethodInfoPtr_RpcWriter___Server_SendTrash_3643459082_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677968);
			TrashContainer.NativeMethodInfoPtr_RpcLogic___SendTrash_3643459082_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677969);
			TrashContainer.NativeMethodInfoPtr_RpcReader___Server_SendTrash_3643459082_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677970);
			TrashContainer.NativeMethodInfoPtr_RpcWriter___Observers_AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677971);
			TrashContainer.NativeMethodInfoPtr_RpcLogic___AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677972);
			TrashContainer.NativeMethodInfoPtr_RpcReader___Observers_AddTrash_3905681115_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677973);
			TrashContainer.NativeMethodInfoPtr_RpcWriter___Target_AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677974);
			TrashContainer.NativeMethodInfoPtr_RpcReader___Target_AddTrash_3905681115_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677975);
			TrashContainer.NativeMethodInfoPtr_RpcWriter___Server_SendClear_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677976);
			TrashContainer.NativeMethodInfoPtr_RpcLogic___SendClear_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677977);
			TrashContainer.NativeMethodInfoPtr_RpcReader___Server_SendClear_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677978);
			TrashContainer.NativeMethodInfoPtr_RpcWriter___Observers_Clear_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677979);
			TrashContainer.NativeMethodInfoPtr_RpcLogic___Clear_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677980);
			TrashContainer.NativeMethodInfoPtr_RpcReader___Observers_Clear_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677981);
			TrashContainer.NativeMethodInfoPtr_RpcWriter___Target_LoadContent_189522235_Private_Void_NetworkConnection_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677982);
			TrashContainer.NativeMethodInfoPtr_RpcLogic___LoadContent_189522235_Private_Void_NetworkConnection_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677983);
			TrashContainer.NativeMethodInfoPtr_RpcReader___Target_LoadContent_189522235_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677984);
			TrashContainer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677985);
		}

		// Token: 0x17002360 RID: 9056
		// (get) Token: 0x0600749F RID: 29855 RVA: 0x001FC5B8 File Offset: 0x001FA7B8
		// (set) Token: 0x060074A0 RID: 29856 RVA: 0x001FC5F8 File Offset: 0x001FA7F8
		public unsafe TrashContent Content
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_get_Content_Public_get_TrashContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashContent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_set_Content_Protected_set_Void_TrashContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002361 RID: 9057
		// (get) Token: 0x060074A1 RID: 29857 RVA: 0x001FC63C File Offset: 0x001FA83C
		public unsafe int TrashLevel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 227919, RefRangeEnd = 227920, XrefRangeStart = 227917, XrefRangeEnd = 227919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_get_TrashLevel_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002362 RID: 9058
		// (get) Token: 0x060074A2 RID: 29858 RVA: 0x001FC678 File Offset: 0x001FA878
		public unsafe float NormalizedTrashLevel
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 227921, RefRangeEnd = 227925, XrefRangeStart = 227920, XrefRangeEnd = 227921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_get_NormalizedTrashLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060074A3 RID: 29859 RVA: 0x001FC6B4 File Offset: 0x001FA8B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227925, XrefRangeEnd = 227965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddTrash(TrashItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainer.NativeMethodInfoPtr_AddTrash_Public_Virtual_New_Void_TrashItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074A4 RID: 29860 RVA: 0x001FC704 File Offset: 0x001FA904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227965, XrefRangeEnd = 227978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainer.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074A5 RID: 29861 RVA: 0x001FC754 File Offset: 0x001FA954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227978, XrefRangeEnd = 228001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendTrash(string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_SendTrash_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074A6 RID: 29862 RVA: 0x001FC7A4 File Offset: 0x001FA9A4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 228047, RefRangeEnd = 228051, XrefRangeStart = 228001, XrefRangeEnd = 228047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTrash(NetworkConnection conn, string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_AddTrash_Private_Void_NetworkConnection_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074A7 RID: 29863 RVA: 0x001FC808 File Offset: 0x001FAA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228051, XrefRangeEnd = 228072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendClear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_SendClear_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074A8 RID: 29864 RVA: 0x001FC83C File Offset: 0x001FAA3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 228093, RefRangeEnd = 228096, XrefRangeStart = 228072, XrefRangeEnd = 228093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_Clear_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074A9 RID: 29865 RVA: 0x001FC870 File Offset: 0x001FAA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228096, XrefRangeEnd = 228115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadContent(NetworkConnection conn, TrashContentData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_LoadContent_Private_Void_NetworkConnection_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074AA RID: 29866 RVA: 0x001FC8C4 File Offset: 0x001FAAC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228115, XrefRangeEnd = 228124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_TriggerEnter_Public_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074AB RID: 29867 RVA: 0x001FC908 File Offset: 0x001FAB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228124, XrefRangeEnd = 228125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanBeBagged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_CanBeBagged_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060074AC RID: 29868 RVA: 0x001FC944 File Offset: 0x001FAB44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 228174, RefRangeEnd = 228175, XrefRangeStart = 228125, XrefRangeEnd = 228174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BagTrash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_BagTrash_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074AD RID: 29869 RVA: 0x001FC978 File Offset: 0x001FAB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228175, XrefRangeEnd = 228181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074AE RID: 29870 RVA: 0x001FC9B4 File Offset: 0x001FABB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228181, XrefRangeEnd = 228219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074AF RID: 29871 RVA: 0x001FC9F0 File Offset: 0x001FABF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209173, RefRangeEnd = 209174, XrefRangeStart = 209173, XrefRangeEnd = 209174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074B0 RID: 29872 RVA: 0x001FCA2C File Offset: 0x001FAC2C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074B1 RID: 29873 RVA: 0x001FCA68 File Offset: 0x001FAC68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228219, XrefRangeEnd = 228240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendTrash_3643459082(string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcWriter___Server_SendTrash_3643459082_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074B2 RID: 29874 RVA: 0x001FCAB8 File Offset: 0x001FACB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228240, XrefRangeEnd = 228241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendTrash_3643459082(string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcLogic___SendTrash_3643459082_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074B3 RID: 29875 RVA: 0x001FCB08 File Offset: 0x001FAD08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228241, XrefRangeEnd = 228247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendTrash_3643459082(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcReader___Server_SendTrash_3643459082_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074B4 RID: 29876 RVA: 0x001FCB6C File Offset: 0x001FAD6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228247, XrefRangeEnd = 228268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddTrash_3905681115(NetworkConnection conn, string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcWriter___Observers_AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074B5 RID: 29877 RVA: 0x001FCBD0 File Offset: 0x001FADD0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 228273, RefRangeEnd = 228276, XrefRangeStart = 228268, XrefRangeEnd = 228273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddTrash_3905681115(NetworkConnection conn, string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcLogic___AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074B6 RID: 29878 RVA: 0x001FCC34 File Offset: 0x001FAE34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228276, XrefRangeEnd = 228282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddTrash_3905681115(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcReader___Observers_AddTrash_3905681115_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074B7 RID: 29879 RVA: 0x001FCC84 File Offset: 0x001FAE84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228282, XrefRangeEnd = 228294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_AddTrash_3905681115(NetworkConnection conn, string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcWriter___Target_AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074B8 RID: 29880 RVA: 0x001FCCE8 File Offset: 0x001FAEE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228294, XrefRangeEnd = 228300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_AddTrash_3905681115(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcReader___Target_AddTrash_3905681115_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074B9 RID: 29881 RVA: 0x001FCD38 File Offset: 0x001FAF38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228300, XrefRangeEnd = 228318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendClear_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcWriter___Server_SendClear_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074BA RID: 29882 RVA: 0x001FCD6C File Offset: 0x001FAF6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 228093, RefRangeEnd = 228096, XrefRangeStart = 228093, XrefRangeEnd = 228096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendClear_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcLogic___SendClear_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074BB RID: 29883 RVA: 0x001FCDA0 File Offset: 0x001FAFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228318, XrefRangeEnd = 228321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendClear_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcReader___Server_SendClear_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074BC RID: 29884 RVA: 0x001FCE04 File Offset: 0x001FB004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228321, XrefRangeEnd = 228339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Clear_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcWriter___Observers_Clear_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074BD RID: 29885 RVA: 0x001FCE38 File Offset: 0x001FB038
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 228342, RefRangeEnd = 228345, XrefRangeStart = 228339, XrefRangeEnd = 228342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Clear_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcLogic___Clear_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074BE RID: 29886 RVA: 0x001FCE6C File Offset: 0x001FB06C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228345, XrefRangeEnd = 228348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Clear_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcReader___Observers_Clear_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074BF RID: 29887 RVA: 0x001FCEBC File Offset: 0x001FB0BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_LoadContent_189522235(NetworkConnection conn, TrashContentData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcWriter___Target_LoadContent_189522235_Private_Void_NetworkConnection_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074C0 RID: 29888 RVA: 0x001FCF10 File Offset: 0x001FB110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228348, XrefRangeEnd = 228351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___LoadContent_189522235(NetworkConnection conn, TrashContentData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcLogic___LoadContent_189522235_Private_Void_NetworkConnection_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074C1 RID: 29889 RVA: 0x001FCF64 File Offset: 0x001FB164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228351, XrefRangeEnd = 228357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_LoadContent_189522235(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcReader___Target_LoadContent_189522235_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074C2 RID: 29890 RVA: 0x001FCFB4 File Offset: 0x001FB1B4
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074C3 RID: 29891 RVA: 0x00037622 File Offset: 0x00035822
		public TrashContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002359 RID: 9049
		// (get) Token: 0x060074C4 RID: 29892 RVA: 0x001FCFF0 File Offset: 0x001FB1F0
		// (set) Token: 0x060074C5 RID: 29893 RVA: 0x0003762B File Offset: 0x0003582B
		public unsafe TrashContent _Content_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr__Content_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr__Content_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700235A RID: 9050
		// (get) Token: 0x060074C6 RID: 29894 RVA: 0x001FD020 File Offset: 0x001FB220
		// (set) Token: 0x060074C7 RID: 29895 RVA: 0x0003764A File Offset: 0x0003584A
		public unsafe int TrashCapacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_TrashCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_TrashCapacity)) = value;
			}
		}

		// Token: 0x1700235B RID: 9051
		// (get) Token: 0x060074C8 RID: 29896 RVA: 0x001FD048 File Offset: 0x001FB248
		// (set) Token: 0x060074C9 RID: 29897 RVA: 0x00037665 File Offset: 0x00035865
		public unsafe Transform TrashBagDropLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_TrashBagDropLocation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_TrashBagDropLocation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700235C RID: 9052
		// (get) Token: 0x060074CA RID: 29898 RVA: 0x001FD078 File Offset: 0x001FB278
		// (set) Token: 0x060074CB RID: 29899 RVA: 0x00037684 File Offset: 0x00035884
		public unsafe UnityEvent<string> onTrashAdded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_onTrashAdded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_onTrashAdded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700235D RID: 9053
		// (get) Token: 0x060074CC RID: 29900 RVA: 0x001FD0A8 File Offset: 0x001FB2A8
		// (set) Token: 0x060074CD RID: 29901 RVA: 0x000376A3 File Offset: 0x000358A3
		public unsafe UnityEvent onTrashLevelChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_onTrashLevelChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_onTrashLevelChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700235E RID: 9054
		// (get) Token: 0x060074CE RID: 29902 RVA: 0x001FD0D8 File Offset: 0x001FB2D8
		// (set) Token: 0x060074CF RID: 29903 RVA: 0x000376C2 File Offset: 0x000358C2
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700235F RID: 9055
		// (get) Token: 0x060074D0 RID: 29904 RVA: 0x001FD100 File Offset: 0x001FB300
		// (set) Token: 0x060074D1 RID: 29905 RVA: 0x000376DD File Offset: 0x000358DD
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004F9E RID: 20382
		private static readonly IntPtr NativeFieldInfoPtr__Content_k__BackingField;

		// Token: 0x04004F9F RID: 20383
		private static readonly IntPtr NativeFieldInfoPtr_TrashCapacity;

		// Token: 0x04004FA0 RID: 20384
		private static readonly IntPtr NativeFieldInfoPtr_TrashBagDropLocation;

		// Token: 0x04004FA1 RID: 20385
		private static readonly IntPtr NativeFieldInfoPtr_onTrashAdded;

		// Token: 0x04004FA2 RID: 20386
		private static readonly IntPtr NativeFieldInfoPtr_onTrashLevelChanged;

		// Token: 0x04004FA3 RID: 20387
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004FA4 RID: 20388
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004FA5 RID: 20389
		private static readonly IntPtr NativeMethodInfoPtr_get_Content_Public_get_TrashContent_0;

		// Token: 0x04004FA6 RID: 20390
		private static readonly IntPtr NativeMethodInfoPtr_set_Content_Protected_set_Void_TrashContent_0;

		// Token: 0x04004FA7 RID: 20391
		private static readonly IntPtr NativeMethodInfoPtr_get_TrashLevel_Public_get_Int32_0;

		// Token: 0x04004FA8 RID: 20392
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedTrashLevel_Public_get_Single_0;

		// Token: 0x04004FA9 RID: 20393
		private static readonly IntPtr NativeMethodInfoPtr_AddTrash_Public_Virtual_New_Void_TrashItem_0;

		// Token: 0x04004FAA RID: 20394
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04004FAB RID: 20395
		private static readonly IntPtr NativeMethodInfoPtr_SendTrash_Private_Void_String_Int32_0;

		// Token: 0x04004FAC RID: 20396
		private static readonly IntPtr NativeMethodInfoPtr_AddTrash_Private_Void_NetworkConnection_String_Int32_0;

		// Token: 0x04004FAD RID: 20397
		private static readonly IntPtr NativeMethodInfoPtr_SendClear_Private_Void_0;

		// Token: 0x04004FAE RID: 20398
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Private_Void_0;

		// Token: 0x04004FAF RID: 20399
		private static readonly IntPtr NativeMethodInfoPtr_LoadContent_Private_Void_NetworkConnection_TrashContentData_0;

		// Token: 0x04004FB0 RID: 20400
		private static readonly IntPtr NativeMethodInfoPtr_TriggerEnter_Public_Void_Collider_0;

		// Token: 0x04004FB1 RID: 20401
		private static readonly IntPtr NativeMethodInfoPtr_CanBeBagged_Public_Boolean_0;

		// Token: 0x04004FB2 RID: 20402
		private static readonly IntPtr NativeMethodInfoPtr_BagTrash_Public_Void_0;

		// Token: 0x04004FB3 RID: 20403
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004FB4 RID: 20404
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004FB5 RID: 20405
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004FB6 RID: 20406
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004FB7 RID: 20407
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendTrash_3643459082_Private_Void_String_Int32_0;

		// Token: 0x04004FB8 RID: 20408
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendTrash_3643459082_Private_Void_String_Int32_0;

		// Token: 0x04004FB9 RID: 20409
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendTrash_3643459082_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004FBA RID: 20410
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0;

		// Token: 0x04004FBB RID: 20411
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0;

		// Token: 0x04004FBC RID: 20412
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddTrash_3905681115_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004FBD RID: 20413
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0;

		// Token: 0x04004FBE RID: 20414
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_AddTrash_3905681115_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004FBF RID: 20415
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendClear_2166136261_Private_Void_0;

		// Token: 0x04004FC0 RID: 20416
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendClear_2166136261_Private_Void_0;

		// Token: 0x04004FC1 RID: 20417
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendClear_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004FC2 RID: 20418
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Clear_2166136261_Private_Void_0;

		// Token: 0x04004FC3 RID: 20419
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Clear_2166136261_Private_Void_0;

		// Token: 0x04004FC4 RID: 20420
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Clear_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004FC5 RID: 20421
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_LoadContent_189522235_Private_Void_NetworkConnection_TrashContentData_0;

		// Token: 0x04004FC6 RID: 20422
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___LoadContent_189522235_Private_Void_NetworkConnection_TrashContentData_0;

		// Token: 0x04004FC7 RID: 20423
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_LoadContent_189522235_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004FC8 RID: 20424
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
