using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas.Characters
{
	// Token: 0x020002C1 RID: 705
	public class ThomasData : NPCData
	{
		// Token: 0x06003224 RID: 12836 RVA: 0x0010F510 File Offset: 0x0010D710
		// Note: this type is marked as 'beforefieldinit'.
		static ThomasData()
		{
			Il2CppClassPointerStore<ThomasData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas.Characters", "ThomasData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThomasData>.NativeClassPtr);
			ThomasData.NativeFieldInfoPtr_MeetingReminderSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThomasData>.NativeClassPtr, "MeetingReminderSent");
			ThomasData.NativeFieldInfoPtr_HandoverReminderSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThomasData>.NativeClassPtr, "HandoverReminderSent");
			ThomasData.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThomasData>.NativeClassPtr, 100668865);
		}

		// Token: 0x06003225 RID: 12837 RVA: 0x0010F57C File Offset: 0x0010D77C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131347, RefRangeEnd = 131348, XrefRangeStart = 131345, XrefRangeEnd = 131347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThomasData(string id, bool meetingReminderSent, bool handoverReminderSent) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThomasData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref meetingReminderSent;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handoverReminderSent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThomasData.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003226 RID: 12838 RVA: 0x0001AE59 File Offset: 0x00019059
		public ThomasData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700105D RID: 4189
		// (get) Token: 0x06003227 RID: 12839 RVA: 0x0010F5E4 File Offset: 0x0010D7E4
		// (set) Token: 0x06003228 RID: 12840 RVA: 0x0001AE62 File Offset: 0x00019062
		public unsafe bool MeetingReminderSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThomasData.NativeFieldInfoPtr_MeetingReminderSent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThomasData.NativeFieldInfoPtr_MeetingReminderSent)) = value;
			}
		}

		// Token: 0x1700105E RID: 4190
		// (get) Token: 0x06003229 RID: 12841 RVA: 0x0010F60C File Offset: 0x0010D80C
		// (set) Token: 0x0600322A RID: 12842 RVA: 0x0001AE7D File Offset: 0x0001907D
		public unsafe bool HandoverReminderSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThomasData.NativeFieldInfoPtr_HandoverReminderSent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThomasData.NativeFieldInfoPtr_HandoverReminderSent)) = value;
			}
		}

		// Token: 0x0400207B RID: 8315
		private static readonly IntPtr NativeFieldInfoPtr_MeetingReminderSent;

		// Token: 0x0400207C RID: 8316
		private static readonly IntPtr NativeFieldInfoPtr_HandoverReminderSent;

		// Token: 0x0400207D RID: 8317
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_0;
	}
}
