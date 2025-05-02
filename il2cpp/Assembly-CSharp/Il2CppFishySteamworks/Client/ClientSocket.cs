using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSteamworks;
using Il2CppSystem;
using Il2CppSystem.Threading;

namespace Il2CppFishySteamworks.Client
{
	// Token: 0x02000792 RID: 1938
	public class ClientSocket : CommonSocket
	{
		// Token: 0x0600B7C4 RID: 47044 RVA: 0x002D9E10 File Offset: 0x002D8010
		// Note: this type is marked as 'beforefieldinit'.
		static ClientSocket()
		{
			Il2CppClassPointerStore<ClientSocket>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FishySteamworks.Client", "ClientSocket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr);
			ClientSocket.NativeFieldInfoPtr__onLocalConnectionStateCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, "_onLocalConnectionStateCallback");
			ClientSocket.NativeFieldInfoPtr__hostSteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, "_hostSteamID");
			ClientSocket.NativeFieldInfoPtr__socket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, "_socket");
			ClientSocket.NativeFieldInfoPtr__timeoutThread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, "_timeoutThread");
			ClientSocket.NativeFieldInfoPtr__connectTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, "_connectTimeout");
			ClientSocket.NativeFieldInfoPtr_CONNECT_TIMEOUT_DURATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, "CONNECT_TIMEOUT_DURATION");
			ClientSocket.NativeMethodInfoPtr_CheckTimeout_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, 100685876);
			ClientSocket.NativeMethodInfoPtr_StartConnection_Internal_Boolean_String_UInt16_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, 100685877);
			ClientSocket.NativeMethodInfoPtr_OnLocalConnectionState_Private_Void_SteamNetConnectionStatusChangedCallback_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, 100685878);
			ClientSocket.NativeMethodInfoPtr_StopConnection_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, 100685879);
			ClientSocket.NativeMethodInfoPtr_IterateIncoming_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, 100685880);
			ClientSocket.NativeMethodInfoPtr_SendToServer_Internal_Void_Byte_ArraySegment_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, 100685881);
			ClientSocket.NativeMethodInfoPtr_IterateOutgoing_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, 100685882);
			ClientSocket.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr, 100685883);
		}

		// Token: 0x0600B7C5 RID: 47045 RVA: 0x002D9F58 File Offset: 0x002D8158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312889, XrefRangeEnd = 312920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckTimeout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientSocket.NativeMethodInfoPtr_CheckTimeout_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7C6 RID: 47046 RVA: 0x002D9F8C File Offset: 0x002D818C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312920, XrefRangeEnd = 312957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartConnection(string address, ushort port, bool peerToPeer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(address);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref peerToPeer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientSocket.NativeMethodInfoPtr_StartConnection_Internal_Boolean_String_UInt16_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B7C7 RID: 47047 RVA: 0x002D9FF8 File Offset: 0x002D81F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312957, XrefRangeEnd = 312968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLocalConnectionState(SteamNetConnectionStatusChangedCallback_t args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientSocket.NativeMethodInfoPtr_OnLocalConnectionState_Private_Void_SteamNetConnectionStatusChangedCallback_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7C8 RID: 47048 RVA: 0x002DA040 File Offset: 0x002D8240
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 312987, RefRangeEnd = 312991, XrefRangeStart = 312968, XrefRangeEnd = 312987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StopConnection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientSocket.NativeMethodInfoPtr_StopConnection_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B7C9 RID: 47049 RVA: 0x002DA07C File Offset: 0x002D827C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313005, RefRangeEnd = 313006, XrefRangeStart = 312991, XrefRangeEnd = 313005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IterateIncoming()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientSocket.NativeMethodInfoPtr_IterateIncoming_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7CA RID: 47050 RVA: 0x002DA0B0 File Offset: 0x002D82B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313006, XrefRangeEnd = 313015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendToServer(byte channelId, ArraySegment<byte> segment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channelId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(segment));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientSocket.NativeMethodInfoPtr_SendToServer_Internal_Void_Byte_ArraySegment_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7CB RID: 47051 RVA: 0x002DA108 File Offset: 0x002D8308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313015, XrefRangeEnd = 313016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IterateOutgoing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientSocket.NativeMethodInfoPtr_IterateOutgoing_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7CC RID: 47052 RVA: 0x002DA13C File Offset: 0x002D833C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313016, XrefRangeEnd = 313025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClientSocket() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientSocket>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientSocket.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7CD RID: 47053 RVA: 0x0005A3B6 File Offset: 0x000585B6
		public ClientSocket(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038F4 RID: 14580
		// (get) Token: 0x0600B7CE RID: 47054 RVA: 0x002DA178 File Offset: 0x002D8378
		// (set) Token: 0x0600B7CF RID: 47055 RVA: 0x0005A3BF File Offset: 0x000585BF
		public unsafe Callback<SteamNetConnectionStatusChangedCallback_t> _onLocalConnectionStateCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientSocket.NativeFieldInfoPtr__onLocalConnectionStateCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Callback<SteamNetConnectionStatusChangedCallback_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientSocket.NativeFieldInfoPtr__onLocalConnectionStateCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038F5 RID: 14581
		// (get) Token: 0x0600B7D0 RID: 47056 RVA: 0x002DA1A8 File Offset: 0x002D83A8
		// (set) Token: 0x0600B7D1 RID: 47057 RVA: 0x0005A3DE File Offset: 0x000585DE
		public unsafe CSteamID _hostSteamID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientSocket.NativeFieldInfoPtr__hostSteamID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientSocket.NativeFieldInfoPtr__hostSteamID)) = value;
			}
		}

		// Token: 0x170038F6 RID: 14582
		// (get) Token: 0x0600B7D2 RID: 47058 RVA: 0x002DA1D0 File Offset: 0x002D83D0
		// (set) Token: 0x0600B7D3 RID: 47059 RVA: 0x0005A3F9 File Offset: 0x000585F9
		public unsafe HSteamNetConnection _socket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientSocket.NativeFieldInfoPtr__socket);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientSocket.NativeFieldInfoPtr__socket)) = value;
			}
		}

		// Token: 0x170038F7 RID: 14583
		// (get) Token: 0x0600B7D4 RID: 47060 RVA: 0x002DA1F8 File Offset: 0x002D83F8
		// (set) Token: 0x0600B7D5 RID: 47061 RVA: 0x0005A414 File Offset: 0x00058614
		public unsafe Thread _timeoutThread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientSocket.NativeFieldInfoPtr__timeoutThread);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Thread>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientSocket.NativeFieldInfoPtr__timeoutThread), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038F8 RID: 14584
		// (get) Token: 0x0600B7D6 RID: 47062 RVA: 0x002DA228 File Offset: 0x002D8428
		// (set) Token: 0x0600B7D7 RID: 47063 RVA: 0x0005A433 File Offset: 0x00058633
		public unsafe float _connectTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientSocket.NativeFieldInfoPtr__connectTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientSocket.NativeFieldInfoPtr__connectTimeout)) = value;
			}
		}

		// Token: 0x170038F9 RID: 14585
		// (get) Token: 0x0600B7D8 RID: 47064 RVA: 0x002DA250 File Offset: 0x002D8450
		// (set) Token: 0x0600B7D9 RID: 47065 RVA: 0x0005A44E File Offset: 0x0005864E
		public unsafe static float CONNECT_TIMEOUT_DURATION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ClientSocket.NativeFieldInfoPtr_CONNECT_TIMEOUT_DURATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClientSocket.NativeFieldInfoPtr_CONNECT_TIMEOUT_DURATION, (void*)(&value));
			}
		}

		// Token: 0x04007BCA RID: 31690
		private static readonly IntPtr NativeFieldInfoPtr__onLocalConnectionStateCallback;

		// Token: 0x04007BCB RID: 31691
		private static readonly IntPtr NativeFieldInfoPtr__hostSteamID;

		// Token: 0x04007BCC RID: 31692
		private static readonly IntPtr NativeFieldInfoPtr__socket;

		// Token: 0x04007BCD RID: 31693
		private static readonly IntPtr NativeFieldInfoPtr__timeoutThread;

		// Token: 0x04007BCE RID: 31694
		private static readonly IntPtr NativeFieldInfoPtr__connectTimeout;

		// Token: 0x04007BCF RID: 31695
		private static readonly IntPtr NativeFieldInfoPtr_CONNECT_TIMEOUT_DURATION;

		// Token: 0x04007BD0 RID: 31696
		private static readonly IntPtr NativeMethodInfoPtr_CheckTimeout_Private_Void_0;

		// Token: 0x04007BD1 RID: 31697
		private static readonly IntPtr NativeMethodInfoPtr_StartConnection_Internal_Boolean_String_UInt16_Boolean_0;

		// Token: 0x04007BD2 RID: 31698
		private static readonly IntPtr NativeMethodInfoPtr_OnLocalConnectionState_Private_Void_SteamNetConnectionStatusChangedCallback_t_0;

		// Token: 0x04007BD3 RID: 31699
		private static readonly IntPtr NativeMethodInfoPtr_StopConnection_Internal_Boolean_0;

		// Token: 0x04007BD4 RID: 31700
		private static readonly IntPtr NativeMethodInfoPtr_IterateIncoming_Internal_Void_0;

		// Token: 0x04007BD5 RID: 31701
		private static readonly IntPtr NativeMethodInfoPtr_SendToServer_Internal_Void_Byte_ArraySegment_1_Byte_0;

		// Token: 0x04007BD6 RID: 31702
		private static readonly IntPtr NativeMethodInfoPtr_IterateOutgoing_Internal_Void_0;

		// Token: 0x04007BD7 RID: 31703
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
