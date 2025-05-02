using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Quests;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002B2 RID: 690
	[Serializable]
	public class QuestEntryData : SaveData
	{
		// Token: 0x060031A4 RID: 12708 RVA: 0x0010E058 File Offset: 0x0010C258
		// Note: this type is marked as 'beforefieldinit'.
		static QuestEntryData()
		{
			Il2CppClassPointerStore<QuestEntryData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "QuestEntryData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestEntryData>.NativeClassPtr);
			QuestEntryData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntryData>.NativeClassPtr, "Name");
			QuestEntryData.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntryData>.NativeClassPtr, "State");
			QuestEntryData.NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntryData>.NativeClassPtr, 100668843);
			QuestEntryData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntryData>.NativeClassPtr, 100668844);
		}

		// Token: 0x060031A5 RID: 12709 RVA: 0x0010E0D8 File Offset: 0x0010C2D8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 130714, RefRangeEnd = 130719, XrefRangeStart = 130714, XrefRangeEnd = 130719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestEntryData(string name, EQuestState state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestEntryData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntryData.NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031A6 RID: 12710 RVA: 0x0010E134 File Offset: 0x0010C334
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130519, RefRangeEnd = 130520, XrefRangeStart = 130519, XrefRangeEnd = 130520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestEntryData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestEntryData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntryData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031A7 RID: 12711 RVA: 0x0001A951 File Offset: 0x00018B51
		public QuestEntryData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001036 RID: 4150
		// (get) Token: 0x060031A8 RID: 12712 RVA: 0x0010E170 File Offset: 0x0010C370
		// (set) Token: 0x060031A9 RID: 12713 RVA: 0x0001A95A File Offset: 0x00018B5A
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntryData.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntryData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001037 RID: 4151
		// (get) Token: 0x060031AA RID: 12714 RVA: 0x0010E198 File Offset: 0x0010C398
		// (set) Token: 0x060031AB RID: 12715 RVA: 0x0001A979 File Offset: 0x00018B79
		public unsafe EQuestState State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntryData.NativeFieldInfoPtr_State);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntryData.NativeFieldInfoPtr_State)) = value;
			}
		}

		// Token: 0x0400203F RID: 8255
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04002040 RID: 8256
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x04002041 RID: 8257
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_0;

		// Token: 0x04002042 RID: 8258
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
