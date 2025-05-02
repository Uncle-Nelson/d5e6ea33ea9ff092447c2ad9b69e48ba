using System;
using Il2CppFishNet.Managing;
using Il2CppFishNet.Transporting;
using Il2CppFishySteamworks.Client;
using Il2CppFishySteamworks.Server;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppFishySteamworks
{
	// Token: 0x0200078F RID: 1935
	public class FishySteamworks : Transport
	{
		// Token: 0x0600B737 RID: 46903 RVA: 0x002D7AE0 File Offset: 0x002D5CE0
		// Note: this type is marked as 'beforefieldinit'.
		static FishySteamworks()
		{
			Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FishySteamworks", "FishySteamworks");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr);
			FishySteamworks.NativeFieldInfoPtr_LocalUserSteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "LocalUserSteamID");
			FishySteamworks.NativeFieldInfoPtr__serverBindAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "_serverBindAddress");
			FishySteamworks.NativeFieldInfoPtr__port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "_port");
			FishySteamworks.NativeFieldInfoPtr__maximumClients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "_maximumClients");
			FishySteamworks.NativeFieldInfoPtr__peerToPeer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "_peerToPeer");
			FishySteamworks.NativeFieldInfoPtr__clientAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "_clientAddress");
			FishySteamworks.NativeFieldInfoPtr__mtus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "_mtus");
			FishySteamworks.NativeFieldInfoPtr__client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "_client");
			FishySteamworks.NativeFieldInfoPtr__clientHost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "_clientHost");
			FishySteamworks.NativeFieldInfoPtr__server = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "_server");
			FishySteamworks.NativeFieldInfoPtr__shutdownCalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "_shutdownCalled");
			FishySteamworks.NativeFieldInfoPtr_CLIENT_HOST_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "CLIENT_HOST_ID");
			FishySteamworks.NativeFieldInfoPtr_OnClientConnectionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "OnClientConnectionState");
			FishySteamworks.NativeFieldInfoPtr_OnServerConnectionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "OnServerConnectionState");
			FishySteamworks.NativeFieldInfoPtr_OnRemoteConnectionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "OnRemoteConnectionState");
			FishySteamworks.NativeFieldInfoPtr_OnClientReceivedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "OnClientReceivedData");
			FishySteamworks.NativeFieldInfoPtr_OnServerReceivedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, "OnServerReceivedData");
			FishySteamworks.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685800);
			FishySteamworks.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_NetworkManager_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685801);
			FishySteamworks.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685802);
			FishySteamworks.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685803);
			FishySteamworks.NativeMethodInfoPtr_CreateChannelData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685804);
			FishySteamworks.NativeMethodInfoPtr_InitializeRelayNetworkAccess_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685805);
			FishySteamworks.NativeMethodInfoPtr_IsNetworkAccessAvailable_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685806);
			FishySteamworks.NativeMethodInfoPtr_GetConnectionAddress_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685807);
			FishySteamworks.NativeMethodInfoPtr_add_OnClientConnectionState_Public_Virtual_add_Void_Action_1_ClientConnectionStateArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685808);
			FishySteamworks.NativeMethodInfoPtr_remove_OnClientConnectionState_Public_Virtual_rem_Void_Action_1_ClientConnectionStateArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685809);
			FishySteamworks.NativeMethodInfoPtr_add_OnServerConnectionState_Public_Virtual_add_Void_Action_1_ServerConnectionStateArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685810);
			FishySteamworks.NativeMethodInfoPtr_remove_OnServerConnectionState_Public_Virtual_rem_Void_Action_1_ServerConnectionStateArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685811);
			FishySteamworks.NativeMethodInfoPtr_add_OnRemoteConnectionState_Public_Virtual_add_Void_Action_1_RemoteConnectionStateArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685812);
			FishySteamworks.NativeMethodInfoPtr_remove_OnRemoteConnectionState_Public_Virtual_rem_Void_Action_1_RemoteConnectionStateArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685813);
			FishySteamworks.NativeMethodInfoPtr_GetConnectionState_Public_Virtual_LocalConnectionState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685814);
			FishySteamworks.NativeMethodInfoPtr_GetConnectionState_Public_Virtual_RemoteConnectionState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685815);
			FishySteamworks.NativeMethodInfoPtr_HandleClientConnectionState_Public_Virtual_Void_ClientConnectionStateArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685816);
			FishySteamworks.NativeMethodInfoPtr_HandleServerConnectionState_Public_Virtual_Void_ServerConnectionStateArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685817);
			FishySteamworks.NativeMethodInfoPtr_HandleRemoteConnectionState_Public_Virtual_Void_RemoteConnectionStateArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685818);
			FishySteamworks.NativeMethodInfoPtr_IterateIncoming_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685819);
			FishySteamworks.NativeMethodInfoPtr_IterateOutgoing_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685820);
			FishySteamworks.NativeMethodInfoPtr_add_OnClientReceivedData_Public_Virtual_add_Void_Action_1_ClientReceivedDataArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685821);
			FishySteamworks.NativeMethodInfoPtr_remove_OnClientReceivedData_Public_Virtual_rem_Void_Action_1_ClientReceivedDataArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685822);
			FishySteamworks.NativeMethodInfoPtr_HandleClientReceivedDataArgs_Public_Virtual_Void_ClientReceivedDataArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685823);
			FishySteamworks.NativeMethodInfoPtr_add_OnServerReceivedData_Public_Virtual_add_Void_Action_1_ServerReceivedDataArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685824);
			FishySteamworks.NativeMethodInfoPtr_remove_OnServerReceivedData_Public_Virtual_rem_Void_Action_1_ServerReceivedDataArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685825);
			FishySteamworks.NativeMethodInfoPtr_HandleServerReceivedDataArgs_Public_Virtual_Void_ServerReceivedDataArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685826);
			FishySteamworks.NativeMethodInfoPtr_SendToServer_Public_Virtual_Void_Byte_ArraySegment_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685827);
			FishySteamworks.NativeMethodInfoPtr_SendToClient_Public_Virtual_Void_Byte_ArraySegment_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685828);
			FishySteamworks.NativeMethodInfoPtr_GetMaximumClients_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685829);
			FishySteamworks.NativeMethodInfoPtr_SetMaximumClients_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685830);
			FishySteamworks.NativeMethodInfoPtr_SetClientAddress_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685831);
			FishySteamworks.NativeMethodInfoPtr_SetServerBindAddress_Public_Virtual_Void_String_IPAddressType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685832);
			FishySteamworks.NativeMethodInfoPtr_SetPort_Public_Virtual_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685833);
			FishySteamworks.NativeMethodInfoPtr_StartConnection_Public_Virtual_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685834);
			FishySteamworks.NativeMethodInfoPtr_StopConnection_Public_Virtual_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685835);
			FishySteamworks.NativeMethodInfoPtr_StopConnection_Public_Virtual_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685836);
			FishySteamworks.NativeMethodInfoPtr_Shutdown_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685837);
			FishySteamworks.NativeMethodInfoPtr_StartServer_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685838);
			FishySteamworks.NativeMethodInfoPtr_StopServer_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685839);
			FishySteamworks.NativeMethodInfoPtr_StartClient_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685840);
			FishySteamworks.NativeMethodInfoPtr_StopClient_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685841);
			FishySteamworks.NativeMethodInfoPtr_StopClient_Private_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685842);
			FishySteamworks.NativeMethodInfoPtr_GetMTU_Public_Virtual_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685843);
			FishySteamworks.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr, 100685844);
		}

		// Token: 0x0600B738 RID: 46904 RVA: 0x002D7FE8 File Offset: 0x002D61E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312219, XrefRangeEnd = 312222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B739 RID: 46905 RVA: 0x002D8024 File Offset: 0x002D6224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312222, XrefRangeEnd = 312302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(NetworkManager networkManager, int transportIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transportIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_NetworkManager_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B73A RID: 46906 RVA: 0x002D8080 File Offset: 0x002D6280
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishySteamworks.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B73B RID: 46907 RVA: 0x002D80B4 File Offset: 0x002D62B4
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishySteamworks.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B73C RID: 46908 RVA: 0x002D80E8 File Offset: 0x002D62E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312302, XrefRangeEnd = 312308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateChannelData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishySteamworks.NativeMethodInfoPtr_CreateChannelData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B73D RID: 46909 RVA: 0x002D811C File Offset: 0x002D631C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312312, RefRangeEnd = 312313, XrefRangeStart = 312308, XrefRangeEnd = 312312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InitializeRelayNetworkAccess()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishySteamworks.NativeMethodInfoPtr_InitializeRelayNetworkAccess_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B73E RID: 46910 RVA: 0x002D8158 File Offset: 0x002D6358
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312315, RefRangeEnd = 312317, XrefRangeStart = 312313, XrefRangeEnd = 312315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNetworkAccessAvailable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishySteamworks.NativeMethodInfoPtr_IsNetworkAccessAvailable_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B73F RID: 46911 RVA: 0x002D8194 File Offset: 0x002D6394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312317, XrefRangeEnd = 312330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetConnectionAddress(int connectionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_GetConnectionAddress_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600B740 RID: 46912 RVA: 0x002D81E4 File Offset: 0x002D63E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312330, XrefRangeEnd = 312335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void add_OnClientConnectionState(Action<ClientConnectionStateArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_add_OnClientConnectionState_Public_Virtual_add_Void_Action_1_ClientConnectionStateArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B741 RID: 46913 RVA: 0x002D8234 File Offset: 0x002D6434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312335, XrefRangeEnd = 312340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void remove_OnClientConnectionState(Action<ClientConnectionStateArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_remove_OnClientConnectionState_Public_Virtual_rem_Void_Action_1_ClientConnectionStateArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B742 RID: 46914 RVA: 0x002D8284 File Offset: 0x002D6484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312340, XrefRangeEnd = 312345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void add_OnServerConnectionState(Action<ServerConnectionStateArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_add_OnServerConnectionState_Public_Virtual_add_Void_Action_1_ServerConnectionStateArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B743 RID: 46915 RVA: 0x002D82D4 File Offset: 0x002D64D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312345, XrefRangeEnd = 312350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void remove_OnServerConnectionState(Action<ServerConnectionStateArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_remove_OnServerConnectionState_Public_Virtual_rem_Void_Action_1_ServerConnectionStateArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B744 RID: 46916 RVA: 0x002D8324 File Offset: 0x002D6524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312350, XrefRangeEnd = 312355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void add_OnRemoteConnectionState(Action<RemoteConnectionStateArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_add_OnRemoteConnectionState_Public_Virtual_add_Void_Action_1_RemoteConnectionStateArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B745 RID: 46917 RVA: 0x002D8374 File Offset: 0x002D6574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312355, XrefRangeEnd = 312360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void remove_OnRemoteConnectionState(Action<RemoteConnectionStateArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_remove_OnRemoteConnectionState_Public_Virtual_rem_Void_Action_1_RemoteConnectionStateArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B746 RID: 46918 RVA: 0x002D83C4 File Offset: 0x002D65C4
		[CallerCount(0)]
		public unsafe override LocalConnectionState GetConnectionState(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref server;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_GetConnectionState_Public_Virtual_LocalConnectionState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B747 RID: 46919 RVA: 0x002D8418 File Offset: 0x002D6618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312360, XrefRangeEnd = 312364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override RemoteConnectionState GetConnectionState(int connectionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_GetConnectionState_Public_Virtual_RemoteConnectionState_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B748 RID: 46920 RVA: 0x002D846C File Offset: 0x002D666C
		[CallerCount(0)]
		public unsafe override void HandleClientConnectionState(ClientConnectionStateArgs connectionStateArgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionStateArgs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_HandleClientConnectionState_Public_Virtual_Void_ClientConnectionStateArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B749 RID: 46921 RVA: 0x002D84B8 File Offset: 0x002D66B8
		[CallerCount(0)]
		public unsafe override void HandleServerConnectionState(ServerConnectionStateArgs connectionStateArgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionStateArgs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_HandleServerConnectionState_Public_Virtual_Void_ServerConnectionStateArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B74A RID: 46922 RVA: 0x002D8504 File Offset: 0x002D6704
		[CallerCount(0)]
		public unsafe override void HandleRemoteConnectionState(RemoteConnectionStateArgs connectionStateArgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionStateArgs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_HandleRemoteConnectionState_Public_Virtual_Void_RemoteConnectionStateArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B74B RID: 46923 RVA: 0x002D8550 File Offset: 0x002D6750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312364, XrefRangeEnd = 312382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void IterateIncoming(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref server;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_IterateIncoming_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B74C RID: 46924 RVA: 0x002D859C File Offset: 0x002D679C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312382, XrefRangeEnd = 312383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void IterateOutgoing(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref server;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_IterateOutgoing_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B74D RID: 46925 RVA: 0x002D85E8 File Offset: 0x002D67E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312383, XrefRangeEnd = 312388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void add_OnClientReceivedData(Action<ClientReceivedDataArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_add_OnClientReceivedData_Public_Virtual_add_Void_Action_1_ClientReceivedDataArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B74E RID: 46926 RVA: 0x002D8638 File Offset: 0x002D6838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312388, XrefRangeEnd = 312393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void remove_OnClientReceivedData(Action<ClientReceivedDataArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_remove_OnClientReceivedData_Public_Virtual_rem_Void_Action_1_ClientReceivedDataArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B74F RID: 46927 RVA: 0x002D8688 File Offset: 0x002D6888
		[CallerCount(0)]
		public unsafe override void HandleClientReceivedDataArgs(ClientReceivedDataArgs receivedDataArgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(receivedDataArgs));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_HandleClientReceivedDataArgs_Public_Virtual_Void_ClientReceivedDataArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B750 RID: 46928 RVA: 0x002D86DC File Offset: 0x002D68DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312393, XrefRangeEnd = 312398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void add_OnServerReceivedData(Action<ServerReceivedDataArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_add_OnServerReceivedData_Public_Virtual_add_Void_Action_1_ServerReceivedDataArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B751 RID: 46929 RVA: 0x002D872C File Offset: 0x002D692C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312398, XrefRangeEnd = 312403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void remove_OnServerReceivedData(Action<ServerReceivedDataArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_remove_OnServerReceivedData_Public_Virtual_rem_Void_Action_1_ServerReceivedDataArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B752 RID: 46930 RVA: 0x002D877C File Offset: 0x002D697C
		[CallerCount(0)]
		public unsafe override void HandleServerReceivedDataArgs(ServerReceivedDataArgs receivedDataArgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(receivedDataArgs));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_HandleServerReceivedDataArgs_Public_Virtual_Void_ServerReceivedDataArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B753 RID: 46931 RVA: 0x002D87D0 File Offset: 0x002D69D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312403, XrefRangeEnd = 312431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SendToServer(byte channelId, ArraySegment<byte> segment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channelId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(segment));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_SendToServer_Public_Virtual_Void_Byte_ArraySegment_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B754 RID: 46932 RVA: 0x002D8830 File Offset: 0x002D6A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312431, XrefRangeEnd = 312432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SendToClient(byte channelId, ArraySegment<byte> segment, int connectionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channelId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(segment));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref connectionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_SendToClient_Public_Virtual_Void_Byte_ArraySegment_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B755 RID: 46933 RVA: 0x002D88A0 File Offset: 0x002D6AA0
		[CallerCount(0)]
		public unsafe override int GetMaximumClients()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_GetMaximumClients_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B756 RID: 46934 RVA: 0x002D88E8 File Offset: 0x002D6AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312432, XrefRangeEnd = 312436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetMaximumClients(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_SetMaximumClients_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B757 RID: 46935 RVA: 0x002D8934 File Offset: 0x002D6B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetClientAddress(string address)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(address);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_SetClientAddress_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B758 RID: 46936 RVA: 0x002D8984 File Offset: 0x002D6B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetServerBindAddress(string address, IPAddressType addressType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(address);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addressType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_SetServerBindAddress_Public_Virtual_Void_String_IPAddressType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B759 RID: 46937 RVA: 0x002D89E0 File Offset: 0x002D6BE0
		[CallerCount(0)]
		public unsafe override void SetPort(ushort port)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref port;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_SetPort_Public_Virtual_Void_UInt16_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B75A RID: 46938 RVA: 0x002D8A2C File Offset: 0x002D6C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312436, XrefRangeEnd = 312438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool StartConnection(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref server;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_StartConnection_Public_Virtual_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B75B RID: 46939 RVA: 0x002D8A80 File Offset: 0x002D6C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312438, XrefRangeEnd = 312440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool StopConnection(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref server;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_StopConnection_Public_Virtual_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B75C RID: 46940 RVA: 0x002D8AD4 File Offset: 0x002D6CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312440, XrefRangeEnd = 312451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool StopConnection(int connectionId, bool immediately)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref immediately;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_StopConnection_Public_Virtual_Boolean_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B75D RID: 46941 RVA: 0x002D8B38 File Offset: 0x002D6D38
		[CallerCount(0)]
		public unsafe override void Shutdown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_Shutdown_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B75E RID: 46942 RVA: 0x002D8B74 File Offset: 0x002D6D74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312464, RefRangeEnd = 312465, XrefRangeStart = 312451, XrefRangeEnd = 312464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishySteamworks.NativeMethodInfoPtr_StartServer_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B75F RID: 46943 RVA: 0x002D8BB0 File Offset: 0x002D6DB0
		[CallerCount(0)]
		public unsafe bool StopServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishySteamworks.NativeMethodInfoPtr_StopServer_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B760 RID: 46944 RVA: 0x002D8BEC File Offset: 0x002D6DEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312470, RefRangeEnd = 312471, XrefRangeStart = 312465, XrefRangeEnd = 312470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartClient(string address)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(address);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishySteamworks.NativeMethodInfoPtr_StartClient_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B761 RID: 46945 RVA: 0x002D8C3C File Offset: 0x002D6E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312471, XrefRangeEnd = 312473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StopClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishySteamworks.NativeMethodInfoPtr_StopClient_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B762 RID: 46946 RVA: 0x002D8C78 File Offset: 0x002D6E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312473, XrefRangeEnd = 312484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StopClient(int connectionId, bool immediately)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref immediately;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishySteamworks.NativeMethodInfoPtr_StopClient_Private_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B763 RID: 46947 RVA: 0x002D8CD0 File Offset: 0x002D6ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312484, XrefRangeEnd = 312487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetMTU(byte channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FishySteamworks.NativeMethodInfoPtr_GetMTU_Public_Virtual_Int32_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B764 RID: 46948 RVA: 0x002D8D24 File Offset: 0x002D6F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312487, XrefRangeEnd = 312493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FishySteamworks() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FishySteamworks>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FishySteamworks.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B765 RID: 46949 RVA: 0x0005A013 File Offset: 0x00058213
		public FishySteamworks(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038D5 RID: 14549
		// (get) Token: 0x0600B766 RID: 46950 RVA: 0x002D8D60 File Offset: 0x002D6F60
		// (set) Token: 0x0600B767 RID: 46951 RVA: 0x0005A01C File Offset: 0x0005821C
		public unsafe ulong LocalUserSteamID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_LocalUserSteamID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_LocalUserSteamID)) = value;
			}
		}

		// Token: 0x170038D6 RID: 14550
		// (get) Token: 0x0600B768 RID: 46952 RVA: 0x002D8D88 File Offset: 0x002D6F88
		// (set) Token: 0x0600B769 RID: 46953 RVA: 0x0005A037 File Offset: 0x00058237
		public unsafe string _serverBindAddress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__serverBindAddress);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__serverBindAddress), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170038D7 RID: 14551
		// (get) Token: 0x0600B76A RID: 46954 RVA: 0x002D8DB0 File Offset: 0x002D6FB0
		// (set) Token: 0x0600B76B RID: 46955 RVA: 0x0005A056 File Offset: 0x00058256
		public unsafe ushort _port
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__port);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__port)) = value;
			}
		}

		// Token: 0x170038D8 RID: 14552
		// (get) Token: 0x0600B76C RID: 46956 RVA: 0x002D8DD8 File Offset: 0x002D6FD8
		// (set) Token: 0x0600B76D RID: 46957 RVA: 0x0005A071 File Offset: 0x00058271
		public unsafe ushort _maximumClients
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__maximumClients);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__maximumClients)) = value;
			}
		}

		// Token: 0x170038D9 RID: 14553
		// (get) Token: 0x0600B76E RID: 46958 RVA: 0x002D8E00 File Offset: 0x002D7000
		// (set) Token: 0x0600B76F RID: 46959 RVA: 0x0005A08C File Offset: 0x0005828C
		public unsafe bool _peerToPeer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__peerToPeer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__peerToPeer)) = value;
			}
		}

		// Token: 0x170038DA RID: 14554
		// (get) Token: 0x0600B770 RID: 46960 RVA: 0x002D8E28 File Offset: 0x002D7028
		// (set) Token: 0x0600B771 RID: 46961 RVA: 0x0005A0A7 File Offset: 0x000582A7
		public unsafe string _clientAddress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__clientAddress);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__clientAddress), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170038DB RID: 14555
		// (get) Token: 0x0600B772 RID: 46962 RVA: 0x002D8E50 File Offset: 0x002D7050
		// (set) Token: 0x0600B773 RID: 46963 RVA: 0x0005A0C6 File Offset: 0x000582C6
		public unsafe Il2CppStructArray<int> _mtus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__mtus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__mtus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038DC RID: 14556
		// (get) Token: 0x0600B774 RID: 46964 RVA: 0x002D8E80 File Offset: 0x002D7080
		// (set) Token: 0x0600B775 RID: 46965 RVA: 0x0005A0E5 File Offset: 0x000582E5
		public unsafe ClientSocket _client
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__client);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientSocket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__client), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038DD RID: 14557
		// (get) Token: 0x0600B776 RID: 46966 RVA: 0x002D8EB0 File Offset: 0x002D70B0
		// (set) Token: 0x0600B777 RID: 46967 RVA: 0x0005A104 File Offset: 0x00058304
		public unsafe ClientHostSocket _clientHost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__clientHost);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientHostSocket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__clientHost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038DE RID: 14558
		// (get) Token: 0x0600B778 RID: 46968 RVA: 0x002D8EE0 File Offset: 0x002D70E0
		// (set) Token: 0x0600B779 RID: 46969 RVA: 0x0005A123 File Offset: 0x00058323
		public unsafe ServerSocket _server
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__server);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerSocket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__server), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038DF RID: 14559
		// (get) Token: 0x0600B77A RID: 46970 RVA: 0x002D8F10 File Offset: 0x002D7110
		// (set) Token: 0x0600B77B RID: 46971 RVA: 0x0005A142 File Offset: 0x00058342
		public unsafe bool _shutdownCalled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__shutdownCalled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr__shutdownCalled)) = value;
			}
		}

		// Token: 0x170038E0 RID: 14560
		// (get) Token: 0x0600B77C RID: 46972 RVA: 0x002D8F38 File Offset: 0x002D7138
		// (set) Token: 0x0600B77D RID: 46973 RVA: 0x0005A15D File Offset: 0x0005835D
		public unsafe static int CLIENT_HOST_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(FishySteamworks.NativeFieldInfoPtr_CLIENT_HOST_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FishySteamworks.NativeFieldInfoPtr_CLIENT_HOST_ID, (void*)(&value));
			}
		}

		// Token: 0x170038E1 RID: 14561
		// (get) Token: 0x0600B77E RID: 46974 RVA: 0x002D8F54 File Offset: 0x002D7154
		// (set) Token: 0x0600B77F RID: 46975 RVA: 0x0005A16B File Offset: 0x0005836B
		public unsafe Action<ClientConnectionStateArgs> OnClientConnectionState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_OnClientConnectionState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ClientConnectionStateArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_OnClientConnectionState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038E2 RID: 14562
		// (get) Token: 0x0600B780 RID: 46976 RVA: 0x002D8F84 File Offset: 0x002D7184
		// (set) Token: 0x0600B781 RID: 46977 RVA: 0x0005A18A File Offset: 0x0005838A
		public unsafe Action<ServerConnectionStateArgs> OnServerConnectionState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_OnServerConnectionState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ServerConnectionStateArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_OnServerConnectionState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038E3 RID: 14563
		// (get) Token: 0x0600B782 RID: 46978 RVA: 0x002D8FB4 File Offset: 0x002D71B4
		// (set) Token: 0x0600B783 RID: 46979 RVA: 0x0005A1A9 File Offset: 0x000583A9
		public unsafe Action<RemoteConnectionStateArgs> OnRemoteConnectionState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_OnRemoteConnectionState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<RemoteConnectionStateArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_OnRemoteConnectionState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038E4 RID: 14564
		// (get) Token: 0x0600B784 RID: 46980 RVA: 0x002D8FE4 File Offset: 0x002D71E4
		// (set) Token: 0x0600B785 RID: 46981 RVA: 0x0005A1C8 File Offset: 0x000583C8
		public unsafe Action<ClientReceivedDataArgs> OnClientReceivedData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_OnClientReceivedData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ClientReceivedDataArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_OnClientReceivedData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038E5 RID: 14565
		// (get) Token: 0x0600B786 RID: 46982 RVA: 0x002D9014 File Offset: 0x002D7214
		// (set) Token: 0x0600B787 RID: 46983 RVA: 0x0005A1E7 File Offset: 0x000583E7
		public unsafe Action<ServerReceivedDataArgs> OnServerReceivedData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_OnServerReceivedData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ServerReceivedDataArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FishySteamworks.NativeFieldInfoPtr_OnServerReceivedData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007B62 RID: 31586
		private static readonly IntPtr NativeFieldInfoPtr_LocalUserSteamID;

		// Token: 0x04007B63 RID: 31587
		private static readonly IntPtr NativeFieldInfoPtr__serverBindAddress;

		// Token: 0x04007B64 RID: 31588
		private static readonly IntPtr NativeFieldInfoPtr__port;

		// Token: 0x04007B65 RID: 31589
		private static readonly IntPtr NativeFieldInfoPtr__maximumClients;

		// Token: 0x04007B66 RID: 31590
		private static readonly IntPtr NativeFieldInfoPtr__peerToPeer;

		// Token: 0x04007B67 RID: 31591
		private static readonly IntPtr NativeFieldInfoPtr__clientAddress;

		// Token: 0x04007B68 RID: 31592
		private static readonly IntPtr NativeFieldInfoPtr__mtus;

		// Token: 0x04007B69 RID: 31593
		private static readonly IntPtr NativeFieldInfoPtr__client;

		// Token: 0x04007B6A RID: 31594
		private static readonly IntPtr NativeFieldInfoPtr__clientHost;

		// Token: 0x04007B6B RID: 31595
		private static readonly IntPtr NativeFieldInfoPtr__server;

		// Token: 0x04007B6C RID: 31596
		private static readonly IntPtr NativeFieldInfoPtr__shutdownCalled;

		// Token: 0x04007B6D RID: 31597
		private static readonly IntPtr NativeFieldInfoPtr_CLIENT_HOST_ID;

		// Token: 0x04007B6E RID: 31598
		private static readonly IntPtr NativeFieldInfoPtr_OnClientConnectionState;

		// Token: 0x04007B6F RID: 31599
		private static readonly IntPtr NativeFieldInfoPtr_OnServerConnectionState;

		// Token: 0x04007B70 RID: 31600
		private static readonly IntPtr NativeFieldInfoPtr_OnRemoteConnectionState;

		// Token: 0x04007B71 RID: 31601
		private static readonly IntPtr NativeFieldInfoPtr_OnClientReceivedData;

		// Token: 0x04007B72 RID: 31602
		private static readonly IntPtr NativeFieldInfoPtr_OnServerReceivedData;

		// Token: 0x04007B73 RID: 31603
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04007B74 RID: 31604
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_NetworkManager_Int32_0;

		// Token: 0x04007B75 RID: 31605
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04007B76 RID: 31606
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04007B77 RID: 31607
		private static readonly IntPtr NativeMethodInfoPtr_CreateChannelData_Private_Void_0;

		// Token: 0x04007B78 RID: 31608
		private static readonly IntPtr NativeMethodInfoPtr_InitializeRelayNetworkAccess_Private_Boolean_0;

		// Token: 0x04007B79 RID: 31609
		private static readonly IntPtr NativeMethodInfoPtr_IsNetworkAccessAvailable_Public_Boolean_0;

		// Token: 0x04007B7A RID: 31610
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionAddress_Public_Virtual_String_Int32_0;

		// Token: 0x04007B7B RID: 31611
		private static readonly IntPtr NativeMethodInfoPtr_add_OnClientConnectionState_Public_Virtual_add_Void_Action_1_ClientConnectionStateArgs_0;

		// Token: 0x04007B7C RID: 31612
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnClientConnectionState_Public_Virtual_rem_Void_Action_1_ClientConnectionStateArgs_0;

		// Token: 0x04007B7D RID: 31613
		private static readonly IntPtr NativeMethodInfoPtr_add_OnServerConnectionState_Public_Virtual_add_Void_Action_1_ServerConnectionStateArgs_0;

		// Token: 0x04007B7E RID: 31614
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnServerConnectionState_Public_Virtual_rem_Void_Action_1_ServerConnectionStateArgs_0;

		// Token: 0x04007B7F RID: 31615
		private static readonly IntPtr NativeMethodInfoPtr_add_OnRemoteConnectionState_Public_Virtual_add_Void_Action_1_RemoteConnectionStateArgs_0;

		// Token: 0x04007B80 RID: 31616
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnRemoteConnectionState_Public_Virtual_rem_Void_Action_1_RemoteConnectionStateArgs_0;

		// Token: 0x04007B81 RID: 31617
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionState_Public_Virtual_LocalConnectionState_Boolean_0;

		// Token: 0x04007B82 RID: 31618
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionState_Public_Virtual_RemoteConnectionState_Int32_0;

		// Token: 0x04007B83 RID: 31619
		private static readonly IntPtr NativeMethodInfoPtr_HandleClientConnectionState_Public_Virtual_Void_ClientConnectionStateArgs_0;

		// Token: 0x04007B84 RID: 31620
		private static readonly IntPtr NativeMethodInfoPtr_HandleServerConnectionState_Public_Virtual_Void_ServerConnectionStateArgs_0;

		// Token: 0x04007B85 RID: 31621
		private static readonly IntPtr NativeMethodInfoPtr_HandleRemoteConnectionState_Public_Virtual_Void_RemoteConnectionStateArgs_0;

		// Token: 0x04007B86 RID: 31622
		private static readonly IntPtr NativeMethodInfoPtr_IterateIncoming_Public_Virtual_Void_Boolean_0;

		// Token: 0x04007B87 RID: 31623
		private static readonly IntPtr NativeMethodInfoPtr_IterateOutgoing_Public_Virtual_Void_Boolean_0;

		// Token: 0x04007B88 RID: 31624
		private static readonly IntPtr NativeMethodInfoPtr_add_OnClientReceivedData_Public_Virtual_add_Void_Action_1_ClientReceivedDataArgs_0;

		// Token: 0x04007B89 RID: 31625
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnClientReceivedData_Public_Virtual_rem_Void_Action_1_ClientReceivedDataArgs_0;

		// Token: 0x04007B8A RID: 31626
		private static readonly IntPtr NativeMethodInfoPtr_HandleClientReceivedDataArgs_Public_Virtual_Void_ClientReceivedDataArgs_0;

		// Token: 0x04007B8B RID: 31627
		private static readonly IntPtr NativeMethodInfoPtr_add_OnServerReceivedData_Public_Virtual_add_Void_Action_1_ServerReceivedDataArgs_0;

		// Token: 0x04007B8C RID: 31628
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnServerReceivedData_Public_Virtual_rem_Void_Action_1_ServerReceivedDataArgs_0;

		// Token: 0x04007B8D RID: 31629
		private static readonly IntPtr NativeMethodInfoPtr_HandleServerReceivedDataArgs_Public_Virtual_Void_ServerReceivedDataArgs_0;

		// Token: 0x04007B8E RID: 31630
		private static readonly IntPtr NativeMethodInfoPtr_SendToServer_Public_Virtual_Void_Byte_ArraySegment_1_Byte_0;

		// Token: 0x04007B8F RID: 31631
		private static readonly IntPtr NativeMethodInfoPtr_SendToClient_Public_Virtual_Void_Byte_ArraySegment_1_Byte_Int32_0;

		// Token: 0x04007B90 RID: 31632
		private static readonly IntPtr NativeMethodInfoPtr_GetMaximumClients_Public_Virtual_Int32_0;

		// Token: 0x04007B91 RID: 31633
		private static readonly IntPtr NativeMethodInfoPtr_SetMaximumClients_Public_Virtual_Void_Int32_0;

		// Token: 0x04007B92 RID: 31634
		private static readonly IntPtr NativeMethodInfoPtr_SetClientAddress_Public_Virtual_Void_String_0;

		// Token: 0x04007B93 RID: 31635
		private static readonly IntPtr NativeMethodInfoPtr_SetServerBindAddress_Public_Virtual_Void_String_IPAddressType_0;

		// Token: 0x04007B94 RID: 31636
		private static readonly IntPtr NativeMethodInfoPtr_SetPort_Public_Virtual_Void_UInt16_0;

		// Token: 0x04007B95 RID: 31637
		private static readonly IntPtr NativeMethodInfoPtr_StartConnection_Public_Virtual_Boolean_Boolean_0;

		// Token: 0x04007B96 RID: 31638
		private static readonly IntPtr NativeMethodInfoPtr_StopConnection_Public_Virtual_Boolean_Boolean_0;

		// Token: 0x04007B97 RID: 31639
		private static readonly IntPtr NativeMethodInfoPtr_StopConnection_Public_Virtual_Boolean_Int32_Boolean_0;

		// Token: 0x04007B98 RID: 31640
		private static readonly IntPtr NativeMethodInfoPtr_Shutdown_Public_Virtual_Void_0;

		// Token: 0x04007B99 RID: 31641
		private static readonly IntPtr NativeMethodInfoPtr_StartServer_Private_Boolean_0;

		// Token: 0x04007B9A RID: 31642
		private static readonly IntPtr NativeMethodInfoPtr_StopServer_Private_Boolean_0;

		// Token: 0x04007B9B RID: 31643
		private static readonly IntPtr NativeMethodInfoPtr_StartClient_Private_Boolean_String_0;

		// Token: 0x04007B9C RID: 31644
		private static readonly IntPtr NativeMethodInfoPtr_StopClient_Private_Boolean_0;

		// Token: 0x04007B9D RID: 31645
		private static readonly IntPtr NativeMethodInfoPtr_StopClient_Private_Boolean_Int32_Boolean_0;

		// Token: 0x04007B9E RID: 31646
		private static readonly IntPtr NativeMethodInfoPtr_GetMTU_Public_Virtual_Int32_Byte_0;

		// Token: 0x04007B9F RID: 31647
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
