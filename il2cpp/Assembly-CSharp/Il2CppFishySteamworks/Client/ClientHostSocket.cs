using System;
using Il2CppFishNet.Transporting;
using Il2CppFishySteamworks.Server;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppFishySteamworks.Client
{
	// Token: 0x02000791 RID: 1937
	public class ClientHostSocket : CommonSocket
	{
		// Token: 0x0600B7B6 RID: 47030 RVA: 0x002D9A90 File Offset: 0x002D7C90
		// Note: this type is marked as 'beforefieldinit'.
		static ClientHostSocket()
		{
			Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FishySteamworks.Client", "ClientHostSocket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr);
			ClientHostSocket.NativeFieldInfoPtr__server = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr, "_server");
			ClientHostSocket.NativeFieldInfoPtr__incoming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr, "_incoming");
			ClientHostSocket.NativeMethodInfoPtr_CheckSetStarted_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr, 100685868);
			ClientHostSocket.NativeMethodInfoPtr_StartConnection_Internal_Boolean_ServerSocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr, 100685869);
			ClientHostSocket.NativeMethodInfoPtr_SetLocalConnectionState_Protected_Virtual_Void_LocalConnectionState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr, 100685870);
			ClientHostSocket.NativeMethodInfoPtr_StopConnection_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr, 100685871);
			ClientHostSocket.NativeMethodInfoPtr_IterateIncoming_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr, 100685872);
			ClientHostSocket.NativeMethodInfoPtr_ReceivedFromLocalServer_Internal_Void_LocalPacket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr, 100685873);
			ClientHostSocket.NativeMethodInfoPtr_SendToServer_Internal_Void_Byte_ArraySegment_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr, 100685874);
			ClientHostSocket.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr, 100685875);
		}

		// Token: 0x0600B7B7 RID: 47031 RVA: 0x002D9B88 File Offset: 0x002D7D88
		[CallerCount(0)]
		public unsafe void CheckSetStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientHostSocket.NativeMethodInfoPtr_CheckSetStarted_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7B8 RID: 47032 RVA: 0x002D9BBC File Offset: 0x002D7DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312825, XrefRangeEnd = 312827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartConnection(ServerSocket serverSocket)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(serverSocket);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientHostSocket.NativeMethodInfoPtr_StartConnection_Internal_Boolean_ServerSocket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B7B9 RID: 47033 RVA: 0x002D9C0C File Offset: 0x002D7E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312827, XrefRangeEnd = 312831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetLocalConnectionState(LocalConnectionState connectionState, bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionState;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref server;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClientHostSocket.NativeMethodInfoPtr_SetLocalConnectionState_Protected_Virtual_Void_LocalConnectionState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7BA RID: 47034 RVA: 0x002D9C64 File Offset: 0x002D7E64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312841, RefRangeEnd = 312843, XrefRangeStart = 312831, XrefRangeEnd = 312841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StopConnection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientHostSocket.NativeMethodInfoPtr_StopConnection_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B7BB RID: 47035 RVA: 0x002D9CA0 File Offset: 0x002D7EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312843, XrefRangeEnd = 312859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IterateIncoming()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientHostSocket.NativeMethodInfoPtr_IterateIncoming_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7BC RID: 47036 RVA: 0x002D9CD4 File Offset: 0x002D7ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312859, XrefRangeEnd = 312862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceivedFromLocalServer(LocalPacket packet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(packet));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientHostSocket.NativeMethodInfoPtr_ReceivedFromLocalServer_Internal_Void_LocalPacket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7BD RID: 47037 RVA: 0x002D9D1C File Offset: 0x002D7F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312862, XrefRangeEnd = 312877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendToServer(byte channelId, ArraySegment<byte> segment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channelId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(segment));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientHostSocket.NativeMethodInfoPtr_SendToServer_Internal_Void_Byte_ArraySegment_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7BE RID: 47038 RVA: 0x002D9D74 File Offset: 0x002D7F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312877, XrefRangeEnd = 312889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClientHostSocket() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientHostSocket>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientHostSocket.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7BF RID: 47039 RVA: 0x0005A36F File Offset: 0x0005856F
		public ClientHostSocket(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038F2 RID: 14578
		// (get) Token: 0x0600B7C0 RID: 47040 RVA: 0x002D9DB0 File Offset: 0x002D7FB0
		// (set) Token: 0x0600B7C1 RID: 47041 RVA: 0x0005A378 File Offset: 0x00058578
		public unsafe ServerSocket _server
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientHostSocket.NativeFieldInfoPtr__server);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerSocket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientHostSocket.NativeFieldInfoPtr__server), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038F3 RID: 14579
		// (get) Token: 0x0600B7C2 RID: 47042 RVA: 0x002D9DE0 File Offset: 0x002D7FE0
		// (set) Token: 0x0600B7C3 RID: 47043 RVA: 0x0005A397 File Offset: 0x00058597
		public unsafe Queue<LocalPacket> _incoming
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientHostSocket.NativeFieldInfoPtr__incoming);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<LocalPacket>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientHostSocket.NativeFieldInfoPtr__incoming), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007BC0 RID: 31680
		private static readonly IntPtr NativeFieldInfoPtr__server;

		// Token: 0x04007BC1 RID: 31681
		private static readonly IntPtr NativeFieldInfoPtr__incoming;

		// Token: 0x04007BC2 RID: 31682
		private static readonly IntPtr NativeMethodInfoPtr_CheckSetStarted_Internal_Void_0;

		// Token: 0x04007BC3 RID: 31683
		private static readonly IntPtr NativeMethodInfoPtr_StartConnection_Internal_Boolean_ServerSocket_0;

		// Token: 0x04007BC4 RID: 31684
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalConnectionState_Protected_Virtual_Void_LocalConnectionState_Boolean_0;

		// Token: 0x04007BC5 RID: 31685
		private static readonly IntPtr NativeMethodInfoPtr_StopConnection_Internal_Boolean_0;

		// Token: 0x04007BC6 RID: 31686
		private static readonly IntPtr NativeMethodInfoPtr_IterateIncoming_Internal_Void_0;

		// Token: 0x04007BC7 RID: 31687
		private static readonly IntPtr NativeMethodInfoPtr_ReceivedFromLocalServer_Internal_Void_LocalPacket_0;

		// Token: 0x04007BC8 RID: 31688
		private static readonly IntPtr NativeMethodInfoPtr_SendToServer_Internal_Void_Byte_ArraySegment_1_Byte_0;

		// Token: 0x04007BC9 RID: 31689
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
