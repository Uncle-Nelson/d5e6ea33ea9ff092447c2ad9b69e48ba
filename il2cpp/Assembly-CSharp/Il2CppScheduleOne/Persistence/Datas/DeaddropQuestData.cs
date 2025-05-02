using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne.Quests;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002B0 RID: 688
	[Serializable]
	public class DeaddropQuestData : QuestData
	{
		// Token: 0x0600318C RID: 12684 RVA: 0x0010DC08 File Offset: 0x0010BE08
		// Note: this type is marked as 'beforefieldinit'.
		static DeaddropQuestData()
		{
			Il2CppClassPointerStore<DeaddropQuestData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "DeaddropQuestData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeaddropQuestData>.NativeClassPtr);
			DeaddropQuestData.NativeFieldInfoPtr_DeaddropGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeaddropQuestData>.NativeClassPtr, "DeaddropGUID");
			DeaddropQuestData.NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_Boolean_String_String_Boolean_GameDateTimeData_Il2CppReferenceArray_1_QuestEntryData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeaddropQuestData>.NativeClassPtr, 100668841);
		}

		// Token: 0x0600318D RID: 12685 RVA: 0x0010DC60 File Offset: 0x0010BE60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131143, RefRangeEnd = 131144, XrefRangeStart = 131141, XrefRangeEnd = 131143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeaddropQuestData(string guid, EQuestState state, bool isTracked, string title, string desc, bool isTimed, GameDateTimeData expiry, Il2CppReferenceArray<QuestEntryData> entries, string deaddropGUID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeaddropQuestData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTracked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(desc);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTimed;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(expiry);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entries);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(deaddropGUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeaddropQuestData.NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_Boolean_String_String_Boolean_GameDateTimeData_Il2CppReferenceArray_1_QuestEntryData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600318E RID: 12686 RVA: 0x0001A834 File Offset: 0x00018A34
		public DeaddropQuestData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700102D RID: 4141
		// (get) Token: 0x0600318F RID: 12687 RVA: 0x0010DD38 File Offset: 0x0010BF38
		// (set) Token: 0x06003190 RID: 12688 RVA: 0x0001A83D File Offset: 0x00018A3D
		public unsafe string DeaddropGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeaddropQuestData.NativeFieldInfoPtr_DeaddropGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeaddropQuestData.NativeFieldInfoPtr_DeaddropGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002034 RID: 8244
		private static readonly IntPtr NativeFieldInfoPtr_DeaddropGUID;

		// Token: 0x04002035 RID: 8245
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_Boolean_String_String_Boolean_GameDateTimeData_Il2CppReferenceArray_1_QuestEntryData_String_0;
	}
}
