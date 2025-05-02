using System;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSteamworks;
using Il2CppSystem;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Collections.Generic;

namespace Il2CppFishySteamworks
{
	// Token: 0x0200078D RID: 1933
	public class CommonSocket : Object
	{
		// Token: 0x0600B716 RID: 46870 RVA: 0x002D743C File Offset: 0x002D563C
		// Note: this type is marked as 'beforefieldinit'.
		static CommonSocket()
		{
			Il2CppClassPointerStore<CommonSocket>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FishySteamworks", "CommonSocket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr);
			CommonSocket.NativeFieldInfoPtr__connectionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, "_connectionState");
			CommonSocket.NativeFieldInfoPtr_PeerToPeer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, "PeerToPeer");
			CommonSocket.NativeFieldInfoPtr_Transport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, "Transport");
			CommonSocket.NativeFieldInfoPtr_MessagePointers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, "MessagePointers");
			CommonSocket.NativeFieldInfoPtr_InboundBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, "InboundBuffer");
			CommonSocket.NativeFieldInfoPtr_MAX_MESSAGES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, "MAX_MESSAGES");
			CommonSocket.NativeMethodInfoPtr_GetLocalConnectionState_Internal_LocalConnectionState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, 100685790);
			CommonSocket.NativeMethodInfoPtr_SetLocalConnectionState_Protected_Virtual_New_Void_LocalConnectionState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, 100685791);
			CommonSocket.NativeMethodInfoPtr_Initialize_Internal_Virtual_New_Void_Transport_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, 100685792);
			CommonSocket.NativeMethodInfoPtr_GetIPBytes_Protected_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, 100685793);
			CommonSocket.NativeMethodInfoPtr_Send_Protected_EResult_HSteamNetConnection_ArraySegment_1_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, 100685794);
			CommonSocket.NativeMethodInfoPtr_ClearQueue_Internal_Void_ConcurrentQueue_1_LocalPacket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, 100685795);
			CommonSocket.NativeMethodInfoPtr_ClearQueue_Internal_Void_Queue_1_LocalPacket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, 100685796);
			CommonSocket.NativeMethodInfoPtr_GetMessage_Protected_Void_IntPtr_Il2CppStructArray_1_Byte_byref_ArraySegment_1_Byte_byref_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, 100685797);
			CommonSocket.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr, 100685798);
		}

		// Token: 0x0600B717 RID: 46871 RVA: 0x002D7598 File Offset: 0x002D5798
		[CallerCount(0)]
		public unsafe LocalConnectionState GetLocalConnectionState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommonSocket.NativeMethodInfoPtr_GetLocalConnectionState_Internal_LocalConnectionState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B718 RID: 46872 RVA: 0x002D75D4 File Offset: 0x002D57D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 312114, RefRangeEnd = 312117, XrefRangeStart = 312113, XrefRangeEnd = 312114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLocalConnectionState(LocalConnectionState connectionState, bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connectionState;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref server;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CommonSocket.NativeMethodInfoPtr_SetLocalConnectionState_Protected_Virtual_New_Void_LocalConnectionState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B719 RID: 46873 RVA: 0x002D762C File Offset: 0x002D582C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312117, XrefRangeEnd = 312127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(Transport t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CommonSocket.NativeMethodInfoPtr_Initialize_Internal_Virtual_New_Void_Transport_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B71A RID: 46874 RVA: 0x002D767C File Offset: 0x002D587C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312135, RefRangeEnd = 312137, XrefRangeStart = 312127, XrefRangeEnd = 312135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetIPBytes(string address)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(address);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommonSocket.NativeMethodInfoPtr_GetIPBytes_Protected_Il2CppStructArray_1_Byte_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600B71B RID: 46875 RVA: 0x002D76CC File Offset: 0x002D58CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 312169, RefRangeEnd = 312172, XrefRangeStart = 312137, XrefRangeEnd = 312169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EResult Send(HSteamNetConnection steamConnection, ArraySegment<byte> segment, byte channelId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref steamConnection;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(segment));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channelId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommonSocket.NativeMethodInfoPtr_Send_Protected_EResult_HSteamNetConnection_ArraySegment_1_Byte_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B71C RID: 46876 RVA: 0x002D773C File Offset: 0x002D593C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312172, XrefRangeEnd = 312180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearQueue(ConcurrentQueue<LocalPacket> queue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(queue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommonSocket.NativeMethodInfoPtr_ClearQueue_Internal_Void_ConcurrentQueue_1_LocalPacket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B71D RID: 46877 RVA: 0x002D7780 File Offset: 0x002D5980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312180, XrefRangeEnd = 312189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearQueue(Queue<LocalPacket> queue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(queue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommonSocket.NativeMethodInfoPtr_ClearQueue_Internal_Void_Queue_1_LocalPacket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B71E RID: 46878 RVA: 0x002D77C4 File Offset: 0x002D59C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312201, RefRangeEnd = 312202, XrefRangeStart = 312189, XrefRangeEnd = 312201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetMessage(IntPtr ptr, Il2CppStructArray<byte> buffer, out ArraySegment<byte> segment, out byte channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr2 = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr2 = ref ptr;
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr3 = &intPtr;
			ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &channel;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CommonSocket.NativeMethodInfoPtr_GetMessage_Protected_Void_IntPtr_Il2CppStructArray_1_Byte_byref_ArraySegment_1_Byte_byref_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			segment = ((intPtr4 == 0) ? null : new ArraySegment<byte>(intPtr4));
		}

		// Token: 0x0600B71F RID: 46879 RVA: 0x002D7844 File Offset: 0x002D5A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312202, XrefRangeEnd = 312207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CommonSocket() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommonSocket>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommonSocket.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B720 RID: 46880 RVA: 0x00059EF9 File Offset: 0x000580F9
		public CommonSocket(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038CC RID: 14540
		// (get) Token: 0x0600B721 RID: 46881 RVA: 0x002D7880 File Offset: 0x002D5A80
		// (set) Token: 0x0600B722 RID: 46882 RVA: 0x00059F02 File Offset: 0x00058102
		public unsafe LocalConnectionState _connectionState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommonSocket.NativeFieldInfoPtr__connectionState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommonSocket.NativeFieldInfoPtr__connectionState)) = value;
			}
		}

		// Token: 0x170038CD RID: 14541
		// (get) Token: 0x0600B723 RID: 46883 RVA: 0x002D78A8 File Offset: 0x002D5AA8
		// (set) Token: 0x0600B724 RID: 46884 RVA: 0x00059F1D File Offset: 0x0005811D
		public unsafe bool PeerToPeer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommonSocket.NativeFieldInfoPtr_PeerToPeer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommonSocket.NativeFieldInfoPtr_PeerToPeer)) = value;
			}
		}

		// Token: 0x170038CE RID: 14542
		// (get) Token: 0x0600B725 RID: 46885 RVA: 0x002D78D0 File Offset: 0x002D5AD0
		// (set) Token: 0x0600B726 RID: 46886 RVA: 0x00059F38 File Offset: 0x00058138
		public unsafe Transport Transport
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommonSocket.NativeFieldInfoPtr_Transport);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transport>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommonSocket.NativeFieldInfoPtr_Transport), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038CF RID: 14543
		// (get) Token: 0x0600B727 RID: 46887 RVA: 0x002D7900 File Offset: 0x002D5B00
		// (set) Token: 0x0600B728 RID: 46888 RVA: 0x00059F57 File Offset: 0x00058157
		public unsafe Il2CppStructArray<IntPtr> MessagePointers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommonSocket.NativeFieldInfoPtr_MessagePointers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<IntPtr>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommonSocket.NativeFieldInfoPtr_MessagePointers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038D0 RID: 14544
		// (get) Token: 0x0600B729 RID: 46889 RVA: 0x002D7930 File Offset: 0x002D5B30
		// (set) Token: 0x0600B72A RID: 46890 RVA: 0x00059F76 File Offset: 0x00058176
		public unsafe Il2CppStructArray<byte> InboundBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommonSocket.NativeFieldInfoPtr_InboundBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommonSocket.NativeFieldInfoPtr_InboundBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038D1 RID: 14545
		// (get) Token: 0x0600B72B RID: 46891 RVA: 0x002D7960 File Offset: 0x002D5B60
		// (set) Token: 0x0600B72C RID: 46892 RVA: 0x00059F95 File Offset: 0x00058195
		public unsafe static int MAX_MESSAGES
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CommonSocket.NativeFieldInfoPtr_MAX_MESSAGES, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CommonSocket.NativeFieldInfoPtr_MAX_MESSAGES, (void*)(&value));
			}
		}

		// Token: 0x04007B4F RID: 31567
		private static readonly IntPtr NativeFieldInfoPtr__connectionState;

		// Token: 0x04007B50 RID: 31568
		private static readonly IntPtr NativeFieldInfoPtr_PeerToPeer;

		// Token: 0x04007B51 RID: 31569
		private static readonly IntPtr NativeFieldInfoPtr_Transport;

		// Token: 0x04007B52 RID: 31570
		private static readonly IntPtr NativeFieldInfoPtr_MessagePointers;

		// Token: 0x04007B53 RID: 31571
		private static readonly IntPtr NativeFieldInfoPtr_InboundBuffer;

		// Token: 0x04007B54 RID: 31572
		private static readonly IntPtr NativeFieldInfoPtr_MAX_MESSAGES;

		// Token: 0x04007B55 RID: 31573
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalConnectionState_Internal_LocalConnectionState_0;

		// Token: 0x04007B56 RID: 31574
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalConnectionState_Protected_Virtual_New_Void_LocalConnectionState_Boolean_0;

		// Token: 0x04007B57 RID: 31575
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Virtual_New_Void_Transport_0;

		// Token: 0x04007B58 RID: 31576
		private static readonly IntPtr NativeMethodInfoPtr_GetIPBytes_Protected_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04007B59 RID: 31577
		private static readonly IntPtr NativeMethodInfoPtr_Send_Protected_EResult_HSteamNetConnection_ArraySegment_1_Byte_Byte_0;

		// Token: 0x04007B5A RID: 31578
		private static readonly IntPtr NativeMethodInfoPtr_ClearQueue_Internal_Void_ConcurrentQueue_1_LocalPacket_0;

		// Token: 0x04007B5B RID: 31579
		private static readonly IntPtr NativeMethodInfoPtr_ClearQueue_Internal_Void_Queue_1_LocalPacket_0;

		// Token: 0x04007B5C RID: 31580
		private static readonly IntPtr NativeMethodInfoPtr_GetMessage_Protected_Void_IntPtr_Il2CppStructArray_1_Byte_byref_ArraySegment_1_Byte_byref_Byte_0;

		// Token: 0x04007B5D RID: 31581
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
