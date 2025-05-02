using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002B6 RID: 694
	[Serializable]
	public class TextMessageData : Object
	{
		// Token: 0x060031CA RID: 12746 RVA: 0x0010E680 File Offset: 0x0010C880
		// Note: this type is marked as 'beforefieldinit'.
		static TextMessageData()
		{
			Il2CppClassPointerStore<TextMessageData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "TextMessageData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr);
			TextMessageData.NativeFieldInfoPtr_Sender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr, "Sender");
			TextMessageData.NativeFieldInfoPtr_MessageID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr, "MessageID");
			TextMessageData.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr, "Text");
			TextMessageData.NativeFieldInfoPtr_EndOfChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr, "EndOfChain");
			TextMessageData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr, 100668851);
			TextMessageData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr, 100668852);
		}

		// Token: 0x060031CB RID: 12747 RVA: 0x0010E728 File Offset: 0x0010C928
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131294, RefRangeEnd = 131296, XrefRangeStart = 131292, XrefRangeEnd = 131294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextMessageData(int sender, int messageID, string text, bool endOfChain) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sender;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref messageID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endOfChain;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMessageData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031CC RID: 12748 RVA: 0x0010E7A0 File Offset: 0x0010C9A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131301, RefRangeEnd = 131302, XrefRangeStart = 131296, XrefRangeEnd = 131301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextMessageData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMessageData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031CD RID: 12749 RVA: 0x0001AAA0 File Offset: 0x00018CA0
		public TextMessageData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001042 RID: 4162
		// (get) Token: 0x060031CE RID: 12750 RVA: 0x0010E7DC File Offset: 0x0010C9DC
		// (set) Token: 0x060031CF RID: 12751 RVA: 0x0001AAA9 File Offset: 0x00018CA9
		public unsafe int Sender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMessageData.NativeFieldInfoPtr_Sender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMessageData.NativeFieldInfoPtr_Sender)) = value;
			}
		}

		// Token: 0x17001043 RID: 4163
		// (get) Token: 0x060031D0 RID: 12752 RVA: 0x0010E804 File Offset: 0x0010CA04
		// (set) Token: 0x060031D1 RID: 12753 RVA: 0x0001AAC4 File Offset: 0x00018CC4
		public unsafe int MessageID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMessageData.NativeFieldInfoPtr_MessageID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMessageData.NativeFieldInfoPtr_MessageID)) = value;
			}
		}

		// Token: 0x17001044 RID: 4164
		// (get) Token: 0x060031D2 RID: 12754 RVA: 0x0010E82C File Offset: 0x0010CA2C
		// (set) Token: 0x060031D3 RID: 12755 RVA: 0x0001AADF File Offset: 0x00018CDF
		public unsafe string Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMessageData.NativeFieldInfoPtr_Text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMessageData.NativeFieldInfoPtr_Text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001045 RID: 4165
		// (get) Token: 0x060031D4 RID: 12756 RVA: 0x0010E854 File Offset: 0x0010CA54
		// (set) Token: 0x060031D5 RID: 12757 RVA: 0x0001AAFE File Offset: 0x00018CFE
		public unsafe bool EndOfChain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMessageData.NativeFieldInfoPtr_EndOfChain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMessageData.NativeFieldInfoPtr_EndOfChain)) = value;
			}
		}

		// Token: 0x04002052 RID: 8274
		private static readonly IntPtr NativeFieldInfoPtr_Sender;

		// Token: 0x04002053 RID: 8275
		private static readonly IntPtr NativeFieldInfoPtr_MessageID;

		// Token: 0x04002054 RID: 8276
		private static readonly IntPtr NativeFieldInfoPtr_Text;

		// Token: 0x04002055 RID: 8277
		private static readonly IntPtr NativeFieldInfoPtr_EndOfChain;

		// Token: 0x04002056 RID: 8278
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_Boolean_0;

		// Token: 0x04002057 RID: 8279
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
