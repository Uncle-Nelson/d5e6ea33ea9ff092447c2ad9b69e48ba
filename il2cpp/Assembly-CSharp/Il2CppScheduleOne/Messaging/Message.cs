using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Messaging
{
	// Token: 0x02000374 RID: 884
	[Serializable]
	public class Message : Object
	{
		// Token: 0x060044D9 RID: 17625 RVA: 0x00153AA8 File Offset: 0x00151CA8
		// Note: this type is marked as 'beforefieldinit'.
		static Message()
		{
			Il2CppClassPointerStore<Message>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Messaging", "Message");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Message>.NativeClassPtr);
			Message.NativeFieldInfoPtr_messageId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Message>.NativeClassPtr, "messageId");
			Message.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Message>.NativeClassPtr, "text");
			Message.NativeFieldInfoPtr_sender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Message>.NativeClassPtr, "sender");
			Message.NativeFieldInfoPtr_endOfGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Message>.NativeClassPtr, "endOfGroup");
			Message.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Message>.NativeClassPtr, 100671702);
			Message.NativeMethodInfoPtr__ctor_Public_Void_String_ESenderType_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Message>.NativeClassPtr, 100671703);
			Message.NativeMethodInfoPtr__ctor_Public_Void_TextMessageData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Message>.NativeClassPtr, 100671704);
			Message.NativeMethodInfoPtr_GetSaveData_Public_TextMessageData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Message>.NativeClassPtr, 100671705);
		}

		// Token: 0x060044DA RID: 17626 RVA: 0x00153B78 File Offset: 0x00151D78
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 155631, RefRangeEnd = 155635, XrefRangeStart = 155630, XrefRangeEnd = 155631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Message() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Message>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Message.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044DB RID: 17627 RVA: 0x00153BB4 File Offset: 0x00151DB4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 155638, RefRangeEnd = 155644, XrefRangeStart = 155635, XrefRangeEnd = 155638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Message(string _text, Message.ESenderType _type, bool _endOfGroup = false, int _messageId = -1) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Message>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _endOfGroup;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _messageId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Message.NativeMethodInfoPtr__ctor_Public_Void_String_ESenderType_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044DC RID: 17628 RVA: 0x00153C2C File Offset: 0x00151E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155644, XrefRangeEnd = 155646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Message(TextMessageData data) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Message>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Message.NativeMethodInfoPtr__ctor_Public_Void_TextMessageData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044DD RID: 17629 RVA: 0x00153C78 File Offset: 0x00151E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155646, XrefRangeEnd = 155650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextMessageData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Message.NativeMethodInfoPtr_GetSaveData_Public_TextMessageData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextMessageData>(intPtr3) : null;
		}

		// Token: 0x060044DE RID: 17630 RVA: 0x000219AD File Offset: 0x0001FBAD
		public Message(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014CE RID: 5326
		// (get) Token: 0x060044DF RID: 17631 RVA: 0x00153CB8 File Offset: 0x00151EB8
		// (set) Token: 0x060044E0 RID: 17632 RVA: 0x000219B6 File Offset: 0x0001FBB6
		public unsafe int messageId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr_messageId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr_messageId)) = value;
			}
		}

		// Token: 0x170014CF RID: 5327
		// (get) Token: 0x060044E1 RID: 17633 RVA: 0x00153CE0 File Offset: 0x00151EE0
		// (set) Token: 0x060044E2 RID: 17634 RVA: 0x000219D1 File Offset: 0x0001FBD1
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170014D0 RID: 5328
		// (get) Token: 0x060044E3 RID: 17635 RVA: 0x00153D08 File Offset: 0x00151F08
		// (set) Token: 0x060044E4 RID: 17636 RVA: 0x000219F0 File Offset: 0x0001FBF0
		public unsafe Message.ESenderType sender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr_sender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr_sender)) = value;
			}
		}

		// Token: 0x170014D1 RID: 5329
		// (get) Token: 0x060044E5 RID: 17637 RVA: 0x00153D30 File Offset: 0x00151F30
		// (set) Token: 0x060044E6 RID: 17638 RVA: 0x00021A0B File Offset: 0x0001FC0B
		public unsafe bool endOfGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr_endOfGroup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr_endOfGroup)) = value;
			}
		}

		// Token: 0x04002E1C RID: 11804
		private static readonly IntPtr NativeFieldInfoPtr_messageId;

		// Token: 0x04002E1D RID: 11805
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04002E1E RID: 11806
		private static readonly IntPtr NativeFieldInfoPtr_sender;

		// Token: 0x04002E1F RID: 11807
		private static readonly IntPtr NativeFieldInfoPtr_endOfGroup;

		// Token: 0x04002E20 RID: 11808
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002E21 RID: 11809
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_ESenderType_Boolean_Int32_0;

		// Token: 0x04002E22 RID: 11810
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextMessageData_0;

		// Token: 0x04002E23 RID: 11811
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_TextMessageData_0;

		// Token: 0x0200096A RID: 2410
		[OriginalName("Assembly-CSharp.dll", "", "ESenderType")]
		public enum ESenderType
		{
			// Token: 0x04008851 RID: 34897
			Player,
			// Token: 0x04008852 RID: 34898
			Other
		}
	}
}
