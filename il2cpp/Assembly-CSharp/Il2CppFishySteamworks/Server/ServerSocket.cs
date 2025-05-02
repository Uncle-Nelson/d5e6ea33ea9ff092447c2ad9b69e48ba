using System;
using System.Runtime.InteropServices;
using Il2CppFishNet.Transporting;
using Il2CppFishySteamworks.Client;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSteamworks;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppFishySteamworks.Server
{
	// Token: 0x02000790 RID: 1936
	public class ServerSocket : CommonSocket
	{
		// Token: 0x0600B788 RID: 46984 RVA: 0x002D9044 File Offset: 0x002D7244
		// Note: this type is marked as 'beforefieldinit'.
		static ServerSocket()
		{
			Il2CppClassPointerStore<ServerSocket>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FishySteamworks.Server", "ServerSocket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr);
			ServerSocket.NativeFieldInfoPtr__steamConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_steamConnections");
			ServerSocket.NativeFieldInfoPtr__steamIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_steamIds");
			ServerSocket.NativeFieldInfoPtr__maximumClients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_maximumClients");
			ServerSocket.NativeFieldInfoPtr__nextConnectionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_nextConnectionId");
			ServerSocket.NativeFieldInfoPtr__socket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_socket");
			ServerSocket.NativeFieldInfoPtr__clientHostIncoming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_clientHostIncoming");
			ServerSocket.NativeFieldInfoPtr__clientHostStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_clientHostStarted");
			ServerSocket.NativeFieldInfoPtr__onRemoteConnectionStateCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_onRemoteConnectionStateCallback");
			ServerSocket.NativeFieldInfoPtr__cachedConnectionIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_cachedConnectionIds");
			ServerSocket.NativeFieldInfoPtr__clientHost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_clientHost");
			ServerSocket.NativeFieldInfoPtr__iteratingConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_iteratingConnections");
			ServerSocket.NativeFieldInfoPtr__pendingConnectionChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "_pendingConnectionChanges");
			ServerSocket.NativeMethodInfoPtr_GetConnectionState_Internal_RemoteConnectionState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685845);
			ServerSocket.NativeMethodInfoPtr_ResetInvalidSocket_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685846);
			ServerSocket.NativeMethodInfoPtr_StartConnection_Internal_Boolean_String_UInt16_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685847);
			ServerSocket.NativeMethodInfoPtr_StopConnection_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685848);
			ServerSocket.NativeMethodInfoPtr_StopConnection_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685849);
			ServerSocket.NativeMethodInfoPtr_StopConnection_Private_Boolean_Int32_HSteamNetConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685850);
			ServerSocket.NativeMethodInfoPtr_OnRemoteConnectionState_Private_Void_SteamNetConnectionStatusChangedCallback_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685851);
			ServerSocket.NativeMethodInfoPtr_AddConnection_Private_Void_Int32_HSteamNetConnection_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685852);
			ServerSocket.NativeMethodInfoPtr_RemoveConnection_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685853);
			ServerSocket.NativeMethodInfoPtr_IterateOutgoing_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685854);
			ServerSocket.NativeMethodInfoPtr_IterateIncoming_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685855);
			ServerSocket.NativeMethodInfoPtr_ProcessPendingConnectionChanges_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685856);
			ServerSocket.NativeMethodInfoPtr_SendToClient_Internal_Void_Byte_ArraySegment_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685857);
			ServerSocket.NativeMethodInfoPtr_GetConnectionAddress_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685858);
			ServerSocket.NativeMethodInfoPtr_SetMaximumClients_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685859);
			ServerSocket.NativeMethodInfoPtr_GetMaximumClients_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685860);
			ServerSocket.NativeMethodInfoPtr_SetClientHostSocket_Internal_Void_ClientHostSocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685861);
			ServerSocket.NativeMethodInfoPtr_OnClientHostState_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685862);
			ServerSocket.NativeMethodInfoPtr_ReceivedFromClientHost_Internal_Void_LocalPacket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685863);
			ServerSocket.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, 100685864);
		}

		// Token: 0x0600B789 RID: 46985 RVA: 0x002D92F4 File Offset: 0x002D74F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312501, XrefRangeEnd = 312505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemoteConnectionState GetConnectionState(int connectionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_GetConnectionState_Internal_RemoteConnectionState_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B78A RID: 46986 RVA: 0x002D9340 File Offset: 0x002D7540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312505, XrefRangeEnd = 312511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetInvalidSocket()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_ResetInvalidSocket_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B78B RID: 46987 RVA: 0x002D9374 File Offset: 0x002D7574
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312545, RefRangeEnd = 312546, XrefRangeStart = 312511, XrefRangeEnd = 312545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartConnection(string address, ushort port, int maximumClients, bool peerToPeer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(address);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maximumClients;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref peerToPeer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_StartConnection_Internal_Boolean_String_UInt16_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B78C RID: 46988 RVA: 0x002D93EC File Offset: 0x002D75EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312546, XrefRangeEnd = 312562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StopConnection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_StopConnection_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B78D RID: 46989 RVA: 0x002D9428 File Offset: 0x002D7628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312562, XrefRangeEnd = 312573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StopConnection(int connectionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_StopConnection_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B78E RID: 46990 RVA: 0x002D9474 File Offset: 0x002D7674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312573, XrefRangeEnd = 312583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StopConnection(int connectionId, HSteamNetConnection socket)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref socket;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_StopConnection_Private_Boolean_Int32_HSteamNetConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B78F RID: 46991 RVA: 0x002D94CC File Offset: 0x002D76CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312583, XrefRangeEnd = 312604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRemoteConnectionState(SteamNetConnectionStatusChangedCallback_t args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_OnRemoteConnectionState_Private_Void_SteamNetConnectionStatusChangedCallback_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B790 RID: 46992 RVA: 0x002D9514 File Offset: 0x002D7714
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312621, RefRangeEnd = 312622, XrefRangeStart = 312604, XrefRangeEnd = 312621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddConnection(int connectionId, HSteamNetConnection steamConnection, CSteamID steamId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamConnection;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_AddConnection_Private_Void_Int32_HSteamNetConnection_CSteamID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B791 RID: 46993 RVA: 0x002D9570 File Offset: 0x002D7770
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312639, RefRangeEnd = 312640, XrefRangeStart = 312622, XrefRangeEnd = 312639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveConnection(int connectionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_RemoveConnection_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B792 RID: 46994 RVA: 0x002D95B0 File Offset: 0x002D77B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312640, XrefRangeEnd = 312662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IterateOutgoing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_IterateOutgoing_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B793 RID: 46995 RVA: 0x002D95E4 File Offset: 0x002D77E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312695, RefRangeEnd = 312696, XrefRangeStart = 312662, XrefRangeEnd = 312695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IterateIncoming()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_IterateIncoming_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B794 RID: 46996 RVA: 0x002D9618 File Offset: 0x002D7818
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312718, RefRangeEnd = 312720, XrefRangeStart = 312696, XrefRangeEnd = 312718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessPendingConnectionChanges()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_ProcessPendingConnectionChanges_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B795 RID: 46997 RVA: 0x002D964C File Offset: 0x002D784C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312739, RefRangeEnd = 312740, XrefRangeStart = 312720, XrefRangeEnd = 312739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendToClient(byte channelId, ArraySegment<byte> segment, int connectionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channelId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(segment));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref connectionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_SendToClient_Internal_Void_Byte_ArraySegment_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B796 RID: 46998 RVA: 0x002D96B0 File Offset: 0x002D78B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312740, XrefRangeEnd = 312753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetConnectionAddress(int connectionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_GetConnectionAddress_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600B797 RID: 46999 RVA: 0x002D96F4 File Offset: 0x002D78F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312753, XrefRangeEnd = 312757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaximumClients(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_SetMaximumClients_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B798 RID: 47000 RVA: 0x002D9734 File Offset: 0x002D7934
		[CallerCount(0)]
		public unsafe int GetMaximumClients()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_GetMaximumClients_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B799 RID: 47001 RVA: 0x002D9770 File Offset: 0x002D7970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetClientHostSocket(ClientHostSocket socket)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(socket);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_SetClientHostSocket_Internal_Void_ClientHostSocket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B79A RID: 47002 RVA: 0x002D97B4 File Offset: 0x002D79B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312780, RefRangeEnd = 312782, XrefRangeStart = 312757, XrefRangeEnd = 312780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClientHostState(bool started)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref started;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_OnClientHostState_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B79B RID: 47003 RVA: 0x002D97F4 File Offset: 0x002D79F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312782, XrefRangeEnd = 312785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceivedFromClientHost(LocalPacket packet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(packet));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr_ReceivedFromClientHost_Internal_Void_LocalPacket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B79C RID: 47004 RVA: 0x002D983C File Offset: 0x002D7A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312785, XrefRangeEnd = 312825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServerSocket() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B79D RID: 47005 RVA: 0x0005A206 File Offset: 0x00058406
		public ServerSocket(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038E6 RID: 14566
		// (get) Token: 0x0600B79E RID: 47006 RVA: 0x002D9878 File Offset: 0x002D7A78
		// (set) Token: 0x0600B79F RID: 47007 RVA: 0x0005A20F File Offset: 0x0005840F
		public unsafe BidirectionalDictionary<HSteamNetConnection, int> _steamConnections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__steamConnections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BidirectionalDictionary<HSteamNetConnection, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__steamConnections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038E7 RID: 14567
		// (get) Token: 0x0600B7A0 RID: 47008 RVA: 0x002D98A8 File Offset: 0x002D7AA8
		// (set) Token: 0x0600B7A1 RID: 47009 RVA: 0x0005A22E File Offset: 0x0005842E
		public unsafe BidirectionalDictionary<CSteamID, int> _steamIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__steamIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BidirectionalDictionary<CSteamID, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__steamIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038E8 RID: 14568
		// (get) Token: 0x0600B7A2 RID: 47010 RVA: 0x002D98D8 File Offset: 0x002D7AD8
		// (set) Token: 0x0600B7A3 RID: 47011 RVA: 0x0005A24D File Offset: 0x0005844D
		public unsafe int _maximumClients
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__maximumClients);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__maximumClients)) = value;
			}
		}

		// Token: 0x170038E9 RID: 14569
		// (get) Token: 0x0600B7A4 RID: 47012 RVA: 0x002D9900 File Offset: 0x002D7B00
		// (set) Token: 0x0600B7A5 RID: 47013 RVA: 0x0005A268 File Offset: 0x00058468
		public unsafe int _nextConnectionId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__nextConnectionId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__nextConnectionId)) = value;
			}
		}

		// Token: 0x170038EA RID: 14570
		// (get) Token: 0x0600B7A6 RID: 47014 RVA: 0x002D9928 File Offset: 0x002D7B28
		// (set) Token: 0x0600B7A7 RID: 47015 RVA: 0x0005A283 File Offset: 0x00058483
		public unsafe HSteamListenSocket _socket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__socket);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__socket)) = value;
			}
		}

		// Token: 0x170038EB RID: 14571
		// (get) Token: 0x0600B7A8 RID: 47016 RVA: 0x002D9950 File Offset: 0x002D7B50
		// (set) Token: 0x0600B7A9 RID: 47017 RVA: 0x0005A29E File Offset: 0x0005849E
		public unsafe Queue<LocalPacket> _clientHostIncoming
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__clientHostIncoming);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<LocalPacket>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__clientHostIncoming), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038EC RID: 14572
		// (get) Token: 0x0600B7AA RID: 47018 RVA: 0x002D9980 File Offset: 0x002D7B80
		// (set) Token: 0x0600B7AB RID: 47019 RVA: 0x0005A2BD File Offset: 0x000584BD
		public unsafe bool _clientHostStarted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__clientHostStarted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__clientHostStarted)) = value;
			}
		}

		// Token: 0x170038ED RID: 14573
		// (get) Token: 0x0600B7AC RID: 47020 RVA: 0x002D99A8 File Offset: 0x002D7BA8
		// (set) Token: 0x0600B7AD RID: 47021 RVA: 0x0005A2D8 File Offset: 0x000584D8
		public unsafe Callback<SteamNetConnectionStatusChangedCallback_t> _onRemoteConnectionStateCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__onRemoteConnectionStateCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Callback<SteamNetConnectionStatusChangedCallback_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__onRemoteConnectionStateCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038EE RID: 14574
		// (get) Token: 0x0600B7AE RID: 47022 RVA: 0x002D99D8 File Offset: 0x002D7BD8
		// (set) Token: 0x0600B7AF RID: 47023 RVA: 0x0005A2F7 File Offset: 0x000584F7
		public unsafe Queue<int> _cachedConnectionIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__cachedConnectionIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__cachedConnectionIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038EF RID: 14575
		// (get) Token: 0x0600B7B0 RID: 47024 RVA: 0x002D9A08 File Offset: 0x002D7C08
		// (set) Token: 0x0600B7B1 RID: 47025 RVA: 0x0005A316 File Offset: 0x00058516
		public unsafe ClientHostSocket _clientHost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__clientHost);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientHostSocket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__clientHost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038F0 RID: 14576
		// (get) Token: 0x0600B7B2 RID: 47026 RVA: 0x002D9A38 File Offset: 0x002D7C38
		// (set) Token: 0x0600B7B3 RID: 47027 RVA: 0x0005A335 File Offset: 0x00058535
		public unsafe bool _iteratingConnections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__iteratingConnections);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__iteratingConnections)) = value;
			}
		}

		// Token: 0x170038F1 RID: 14577
		// (get) Token: 0x0600B7B4 RID: 47028 RVA: 0x002D9A60 File Offset: 0x002D7C60
		// (set) Token: 0x0600B7B5 RID: 47029 RVA: 0x0005A350 File Offset: 0x00058550
		public unsafe List<ServerSocket.ConnectionChange> _pendingConnectionChanges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__pendingConnectionChanges);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ServerSocket.ConnectionChange>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSocket.NativeFieldInfoPtr__pendingConnectionChanges), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007BA0 RID: 31648
		private static readonly IntPtr NativeFieldInfoPtr__steamConnections;

		// Token: 0x04007BA1 RID: 31649
		private static readonly IntPtr NativeFieldInfoPtr__steamIds;

		// Token: 0x04007BA2 RID: 31650
		private static readonly IntPtr NativeFieldInfoPtr__maximumClients;

		// Token: 0x04007BA3 RID: 31651
		private static readonly IntPtr NativeFieldInfoPtr__nextConnectionId;

		// Token: 0x04007BA4 RID: 31652
		private static readonly IntPtr NativeFieldInfoPtr__socket;

		// Token: 0x04007BA5 RID: 31653
		private static readonly IntPtr NativeFieldInfoPtr__clientHostIncoming;

		// Token: 0x04007BA6 RID: 31654
		private static readonly IntPtr NativeFieldInfoPtr__clientHostStarted;

		// Token: 0x04007BA7 RID: 31655
		private static readonly IntPtr NativeFieldInfoPtr__onRemoteConnectionStateCallback;

		// Token: 0x04007BA8 RID: 31656
		private static readonly IntPtr NativeFieldInfoPtr__cachedConnectionIds;

		// Token: 0x04007BA9 RID: 31657
		private static readonly IntPtr NativeFieldInfoPtr__clientHost;

		// Token: 0x04007BAA RID: 31658
		private static readonly IntPtr NativeFieldInfoPtr__iteratingConnections;

		// Token: 0x04007BAB RID: 31659
		private static readonly IntPtr NativeFieldInfoPtr__pendingConnectionChanges;

		// Token: 0x04007BAC RID: 31660
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionState_Internal_RemoteConnectionState_Int32_0;

		// Token: 0x04007BAD RID: 31661
		private static readonly IntPtr NativeMethodInfoPtr_ResetInvalidSocket_Internal_Void_0;

		// Token: 0x04007BAE RID: 31662
		private static readonly IntPtr NativeMethodInfoPtr_StartConnection_Internal_Boolean_String_UInt16_Int32_Boolean_0;

		// Token: 0x04007BAF RID: 31663
		private static readonly IntPtr NativeMethodInfoPtr_StopConnection_Internal_Boolean_0;

		// Token: 0x04007BB0 RID: 31664
		private static readonly IntPtr NativeMethodInfoPtr_StopConnection_Internal_Boolean_Int32_0;

		// Token: 0x04007BB1 RID: 31665
		private static readonly IntPtr NativeMethodInfoPtr_StopConnection_Private_Boolean_Int32_HSteamNetConnection_0;

		// Token: 0x04007BB2 RID: 31666
		private static readonly IntPtr NativeMethodInfoPtr_OnRemoteConnectionState_Private_Void_SteamNetConnectionStatusChangedCallback_t_0;

		// Token: 0x04007BB3 RID: 31667
		private static readonly IntPtr NativeMethodInfoPtr_AddConnection_Private_Void_Int32_HSteamNetConnection_CSteamID_0;

		// Token: 0x04007BB4 RID: 31668
		private static readonly IntPtr NativeMethodInfoPtr_RemoveConnection_Private_Void_Int32_0;

		// Token: 0x04007BB5 RID: 31669
		private static readonly IntPtr NativeMethodInfoPtr_IterateOutgoing_Internal_Void_0;

		// Token: 0x04007BB6 RID: 31670
		private static readonly IntPtr NativeMethodInfoPtr_IterateIncoming_Internal_Void_0;

		// Token: 0x04007BB7 RID: 31671
		private static readonly IntPtr NativeMethodInfoPtr_ProcessPendingConnectionChanges_Private_Void_0;

		// Token: 0x04007BB8 RID: 31672
		private static readonly IntPtr NativeMethodInfoPtr_SendToClient_Internal_Void_Byte_ArraySegment_1_Byte_Int32_0;

		// Token: 0x04007BB9 RID: 31673
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionAddress_Internal_String_Int32_0;

		// Token: 0x04007BBA RID: 31674
		private static readonly IntPtr NativeMethodInfoPtr_SetMaximumClients_Internal_Void_Int32_0;

		// Token: 0x04007BBB RID: 31675
		private static readonly IntPtr NativeMethodInfoPtr_GetMaximumClients_Internal_Int32_0;

		// Token: 0x04007BBC RID: 31676
		private static readonly IntPtr NativeMethodInfoPtr_SetClientHostSocket_Internal_Void_ClientHostSocket_0;

		// Token: 0x04007BBD RID: 31677
		private static readonly IntPtr NativeMethodInfoPtr_OnClientHostState_Internal_Void_Boolean_0;

		// Token: 0x04007BBE RID: 31678
		private static readonly IntPtr NativeMethodInfoPtr_ReceivedFromClientHost_Internal_Void_LocalPacket_0;

		// Token: 0x04007BBF RID: 31679
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C0B RID: 3083
		[StructLayout(2)]
		public struct ConnectionChange
		{
			// Token: 0x0600E051 RID: 57425 RVA: 0x0034D154 File Offset: 0x0034B354
			// Note: this type is marked as 'beforefieldinit'.
			static ConnectionChange()
			{
				Il2CppClassPointerStore<ServerSocket.ConnectionChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerSocket>.NativeClassPtr, "ConnectionChange");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerSocket.ConnectionChange>.NativeClassPtr);
				ServerSocket.ConnectionChange.NativeFieldInfoPtr_ConnectionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket.ConnectionChange>.NativeClassPtr, "ConnectionId");
				ServerSocket.ConnectionChange.NativeFieldInfoPtr_SteamConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket.ConnectionChange>.NativeClassPtr, "SteamConnection");
				ServerSocket.ConnectionChange.NativeFieldInfoPtr_SteamId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSocket.ConnectionChange>.NativeClassPtr, "SteamId");
				ServerSocket.ConnectionChange.NativeMethodInfoPtr_get_IsConnect_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket.ConnectionChange>.NativeClassPtr, 100685865);
				ServerSocket.ConnectionChange.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket.ConnectionChange>.NativeClassPtr, 100685866);
				ServerSocket.ConnectionChange.NativeMethodInfoPtr__ctor_Public_Void_Int32_HSteamNetConnection_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSocket.ConnectionChange>.NativeClassPtr, 100685867);
			}

			// Token: 0x17004582 RID: 17794
			// (get) Token: 0x0600E052 RID: 57426 RVA: 0x0034D1F8 File Offset: 0x0034B3F8
			public unsafe bool IsConnect
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312493, XrefRangeEnd = 312497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.ConnectionChange.NativeMethodInfoPtr_get_IsConnect_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600E053 RID: 57427 RVA: 0x0034D228 File Offset: 0x0034B428
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312497, XrefRangeEnd = 312501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConnectionChange(int id)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.ConnectionChange.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E054 RID: 57428 RVA: 0x0034D25C File Offset: 0x0034B45C
			[CallerCount(0)]
			public unsafe ConnectionChange(int id, HSteamNetConnection steamConnection, CSteamID steamId)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref id;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamConnection;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSocket.ConnectionChange.NativeMethodInfoPtr__ctor_Public_Void_Int32_HSteamNetConnection_CSteamID_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E055 RID: 57429 RVA: 0x0006D5B5 File Offset: 0x0006B7B5
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerSocket.ConnectionChange>.NativeClassPtr, ref this));
			}

			// Token: 0x04009640 RID: 38464
			private static readonly IntPtr NativeFieldInfoPtr_ConnectionId;

			// Token: 0x04009641 RID: 38465
			private static readonly IntPtr NativeFieldInfoPtr_SteamConnection;

			// Token: 0x04009642 RID: 38466
			private static readonly IntPtr NativeFieldInfoPtr_SteamId;

			// Token: 0x04009643 RID: 38467
			private static readonly IntPtr NativeMethodInfoPtr_get_IsConnect_Public_get_Boolean_0;

			// Token: 0x04009644 RID: 38468
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009645 RID: 38469
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_HSteamNetConnection_CSteamID_0;

			// Token: 0x04009646 RID: 38470
			[FieldOffset(0)]
			public int ConnectionId;

			// Token: 0x04009647 RID: 38471
			[FieldOffset(4)]
			public HSteamNetConnection SteamConnection;

			// Token: 0x04009648 RID: 38472
			[FieldOffset(8)]
			public CSteamID SteamId;
		}
	}
}
