using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Quests;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002B1 RID: 689
	[Serializable]
	public class QuestData : SaveData
	{
		// Token: 0x06003191 RID: 12689 RVA: 0x0010DD60 File Offset: 0x0010BF60
		// Note: this type is marked as 'beforefieldinit'.
		static QuestData()
		{
			Il2CppClassPointerStore<QuestData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "QuestData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestData>.NativeClassPtr);
			QuestData.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestData>.NativeClassPtr, "GUID");
			QuestData.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestData>.NativeClassPtr, "State");
			QuestData.NativeFieldInfoPtr_IsTracked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestData>.NativeClassPtr, "IsTracked");
			QuestData.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestData>.NativeClassPtr, "Title");
			QuestData.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestData>.NativeClassPtr, "Description");
			QuestData.NativeFieldInfoPtr_Expires = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestData>.NativeClassPtr, "Expires");
			QuestData.NativeFieldInfoPtr_ExpiryDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestData>.NativeClassPtr, "ExpiryDate");
			QuestData.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestData>.NativeClassPtr, "Entries");
			QuestData.NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_Boolean_String_String_Boolean_GameDateTimeData_Il2CppReferenceArray_1_QuestEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestData>.NativeClassPtr, 100668842);
		}

		// Token: 0x06003192 RID: 12690 RVA: 0x0010DE44 File Offset: 0x0010C044
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 131150, RefRangeEnd = 131153, XrefRangeStart = 131144, XrefRangeEnd = 131150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestData(string guid, EQuestState state, bool isTracked, string title, string desc, bool expires, GameDateTimeData expiry, Il2CppReferenceArray<QuestEntryData> entries) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTracked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(desc);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expires;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(expiry);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entries);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestData.NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_Boolean_String_String_Boolean_GameDateTimeData_Il2CppReferenceArray_1_QuestEntryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003193 RID: 12691 RVA: 0x0001A85C File Offset: 0x00018A5C
		public QuestData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700102E RID: 4142
		// (get) Token: 0x06003194 RID: 12692 RVA: 0x0010DF08 File Offset: 0x0010C108
		// (set) Token: 0x06003195 RID: 12693 RVA: 0x0001A865 File Offset: 0x00018A65
		public unsafe string GUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700102F RID: 4143
		// (get) Token: 0x06003196 RID: 12694 RVA: 0x0010DF30 File Offset: 0x0010C130
		// (set) Token: 0x06003197 RID: 12695 RVA: 0x0001A884 File Offset: 0x00018A84
		public unsafe EQuestState State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_State);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_State)) = value;
			}
		}

		// Token: 0x17001030 RID: 4144
		// (get) Token: 0x06003198 RID: 12696 RVA: 0x0010DF58 File Offset: 0x0010C158
		// (set) Token: 0x06003199 RID: 12697 RVA: 0x0001A89F File Offset: 0x00018A9F
		public unsafe bool IsTracked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_IsTracked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_IsTracked)) = value;
			}
		}

		// Token: 0x17001031 RID: 4145
		// (get) Token: 0x0600319A RID: 12698 RVA: 0x0010DF80 File Offset: 0x0010C180
		// (set) Token: 0x0600319B RID: 12699 RVA: 0x0001A8BA File Offset: 0x00018ABA
		public unsafe string Title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_Title);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_Title), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001032 RID: 4146
		// (get) Token: 0x0600319C RID: 12700 RVA: 0x0010DFA8 File Offset: 0x0010C1A8
		// (set) Token: 0x0600319D RID: 12701 RVA: 0x0001A8D9 File Offset: 0x00018AD9
		public unsafe string Description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_Description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001033 RID: 4147
		// (get) Token: 0x0600319E RID: 12702 RVA: 0x0010DFD0 File Offset: 0x0010C1D0
		// (set) Token: 0x0600319F RID: 12703 RVA: 0x0001A8F8 File Offset: 0x00018AF8
		public unsafe bool Expires
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_Expires);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_Expires)) = value;
			}
		}

		// Token: 0x17001034 RID: 4148
		// (get) Token: 0x060031A0 RID: 12704 RVA: 0x0010DFF8 File Offset: 0x0010C1F8
		// (set) Token: 0x060031A1 RID: 12705 RVA: 0x0001A913 File Offset: 0x00018B13
		public unsafe GameDateTimeData ExpiryDate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_ExpiryDate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameDateTimeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_ExpiryDate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001035 RID: 4149
		// (get) Token: 0x060031A2 RID: 12706 RVA: 0x0010E028 File Offset: 0x0010C228
		// (set) Token: 0x060031A3 RID: 12707 RVA: 0x0001A932 File Offset: 0x00018B32
		public unsafe Il2CppReferenceArray<QuestEntryData> Entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_Entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<QuestEntryData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002036 RID: 8246
		private static readonly IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x04002037 RID: 8247
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x04002038 RID: 8248
		private static readonly IntPtr NativeFieldInfoPtr_IsTracked;

		// Token: 0x04002039 RID: 8249
		private static readonly IntPtr NativeFieldInfoPtr_Title;

		// Token: 0x0400203A RID: 8250
		private static readonly IntPtr NativeFieldInfoPtr_Description;

		// Token: 0x0400203B RID: 8251
		private static readonly IntPtr NativeFieldInfoPtr_Expires;

		// Token: 0x0400203C RID: 8252
		private static readonly IntPtr NativeFieldInfoPtr_ExpiryDate;

		// Token: 0x0400203D RID: 8253
		private static readonly IntPtr NativeFieldInfoPtr_Entries;

		// Token: 0x0400203E RID: 8254
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_Boolean_String_String_Boolean_GameDateTimeData_Il2CppReferenceArray_1_QuestEntryData_0;
	}
}
