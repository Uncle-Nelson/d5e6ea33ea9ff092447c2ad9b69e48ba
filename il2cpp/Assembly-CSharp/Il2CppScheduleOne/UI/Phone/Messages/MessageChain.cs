using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Phone.Messages
{
	// Token: 0x020006B1 RID: 1713
	[Serializable]
	public class MessageChain : Object
	{
		// Token: 0x06009A21 RID: 39457 RVA: 0x002735A4 File Offset: 0x002717A4
		// Note: this type is marked as 'beforefieldinit'.
		static MessageChain()
		{
			Il2CppClassPointerStore<MessageChain>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Messages", "MessageChain");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageChain>.NativeClassPtr);
			MessageChain.NativeFieldInfoPtr_Messages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageChain>.NativeClassPtr, "Messages");
			MessageChain.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageChain>.NativeClassPtr, "id");
			MessageChain.NativeMethodInfoPtr_Combine_Public_Static_MessageChain_MessageChain_MessageChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageChain>.NativeClassPtr, 100682274);
			MessageChain.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageChain>.NativeClassPtr, 100682275);
		}

		// Token: 0x06009A22 RID: 39458 RVA: 0x00273624 File Offset: 0x00271824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274530, XrefRangeEnd = 274546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MessageChain Combine(MessageChain a, MessageChain b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageChain.NativeMethodInfoPtr_Combine_Public_Static_MessageChain_MessageChain_MessageChain_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MessageChain>(intPtr3) : null;
		}

		// Token: 0x06009A23 RID: 39459 RVA: 0x0027367C File Offset: 0x0027187C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 274554, RefRangeEnd = 274563, XrefRangeStart = 274546, XrefRangeEnd = 274554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageChain() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageChain>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageChain.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A24 RID: 39460 RVA: 0x0004B443 File Offset: 0x00049643
		public MessageChain(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F68 RID: 12136
		// (get) Token: 0x06009A25 RID: 39461 RVA: 0x002736B8 File Offset: 0x002718B8
		// (set) Token: 0x06009A26 RID: 39462 RVA: 0x0004B44C File Offset: 0x0004964C
		public unsafe List<string> Messages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageChain.NativeFieldInfoPtr_Messages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageChain.NativeFieldInfoPtr_Messages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F69 RID: 12137
		// (get) Token: 0x06009A27 RID: 39463 RVA: 0x002736E8 File Offset: 0x002718E8
		// (set) Token: 0x06009A28 RID: 39464 RVA: 0x0004B46B File Offset: 0x0004966B
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageChain.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageChain.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x040067B7 RID: 26551
		private static readonly IntPtr NativeFieldInfoPtr_Messages;

		// Token: 0x040067B8 RID: 26552
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x040067B9 RID: 26553
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_MessageChain_MessageChain_MessageChain_0;

		// Token: 0x040067BA RID: 26554
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
