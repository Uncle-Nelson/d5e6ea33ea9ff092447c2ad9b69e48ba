using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000288 RID: 648
	[Serializable]
	public class MSGConversationData : SaveData
	{
		// Token: 0x0600300E RID: 12302 RVA: 0x001094EC File Offset: 0x001076EC
		// Note: this type is marked as 'beforefieldinit'.
		static MSGConversationData()
		{
			Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "MSGConversationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr);
			MSGConversationData.NativeFieldInfoPtr_ConversationIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr, "ConversationIndex");
			MSGConversationData.NativeFieldInfoPtr_Read = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr, "Read");
			MSGConversationData.NativeFieldInfoPtr_MessageHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr, "MessageHistory");
			MSGConversationData.NativeFieldInfoPtr_ActiveResponses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr, "ActiveResponses");
			MSGConversationData.NativeFieldInfoPtr_IsHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr, "IsHidden");
			MSGConversationData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_Il2CppReferenceArray_1_TextMessageData_Il2CppReferenceArray_1_TextResponseData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr, 100668799);
			MSGConversationData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr, 100668800);
		}

		// Token: 0x0600300F RID: 12303 RVA: 0x001095A8 File Offset: 0x001077A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130913, RefRangeEnd = 130914, XrefRangeStart = 130910, XrefRangeEnd = 130913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MSGConversationData(int conversationIndex, bool read, Il2CppReferenceArray<TextMessageData> messageHistory, Il2CppReferenceArray<TextResponseData> activeResponses, bool isHidden) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref conversationIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref read;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(messageHistory);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activeResponses);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHidden;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversationData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_Il2CppReferenceArray_1_TextMessageData_Il2CppReferenceArray_1_TextResponseData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003010 RID: 12304 RVA: 0x00109630 File Offset: 0x00107830
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130923, RefRangeEnd = 130924, XrefRangeStart = 130914, XrefRangeEnd = 130923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MSGConversationData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversationData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003011 RID: 12305 RVA: 0x000197E2 File Offset: 0x000179E2
		public MSGConversationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FAB RID: 4011
		// (get) Token: 0x06003012 RID: 12306 RVA: 0x0010966C File Offset: 0x0010786C
		// (set) Token: 0x06003013 RID: 12307 RVA: 0x000197EB File Offset: 0x000179EB
		public unsafe int ConversationIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_ConversationIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_ConversationIndex)) = value;
			}
		}

		// Token: 0x17000FAC RID: 4012
		// (get) Token: 0x06003014 RID: 12308 RVA: 0x00109694 File Offset: 0x00107894
		// (set) Token: 0x06003015 RID: 12309 RVA: 0x00019806 File Offset: 0x00017A06
		public unsafe bool Read
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_Read);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_Read)) = value;
			}
		}

		// Token: 0x17000FAD RID: 4013
		// (get) Token: 0x06003016 RID: 12310 RVA: 0x001096BC File Offset: 0x001078BC
		// (set) Token: 0x06003017 RID: 12311 RVA: 0x00019821 File Offset: 0x00017A21
		public unsafe Il2CppReferenceArray<TextMessageData> MessageHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_MessageHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMessageData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_MessageHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FAE RID: 4014
		// (get) Token: 0x06003018 RID: 12312 RVA: 0x001096EC File Offset: 0x001078EC
		// (set) Token: 0x06003019 RID: 12313 RVA: 0x00019840 File Offset: 0x00017A40
		public unsafe Il2CppReferenceArray<TextResponseData> ActiveResponses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_ActiveResponses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextResponseData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_ActiveResponses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FAF RID: 4015
		// (get) Token: 0x0600301A RID: 12314 RVA: 0x0010971C File Offset: 0x0010791C
		// (set) Token: 0x0600301B RID: 12315 RVA: 0x0001985F File Offset: 0x00017A5F
		public unsafe bool IsHidden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_IsHidden);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_IsHidden)) = value;
			}
		}

		// Token: 0x04001F88 RID: 8072
		private static readonly IntPtr NativeFieldInfoPtr_ConversationIndex;

		// Token: 0x04001F89 RID: 8073
		private static readonly IntPtr NativeFieldInfoPtr_Read;

		// Token: 0x04001F8A RID: 8074
		private static readonly IntPtr NativeFieldInfoPtr_MessageHistory;

		// Token: 0x04001F8B RID: 8075
		private static readonly IntPtr NativeFieldInfoPtr_ActiveResponses;

		// Token: 0x04001F8C RID: 8076
		private static readonly IntPtr NativeFieldInfoPtr_IsHidden;

		// Token: 0x04001F8D RID: 8077
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_Il2CppReferenceArray_1_TextMessageData_Il2CppReferenceArray_1_TextResponseData_Boolean_0;

		// Token: 0x04001F8E RID: 8078
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
