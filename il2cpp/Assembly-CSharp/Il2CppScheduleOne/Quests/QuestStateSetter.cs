using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001C8 RID: 456
	[Serializable]
	public class QuestStateSetter : Object
	{
		// Token: 0x060026FA RID: 9978 RVA: 0x000EAC7C File Offset: 0x000E8E7C
		// Note: this type is marked as 'beforefieldinit'.
		static QuestStateSetter()
		{
			Il2CppClassPointerStore<QuestStateSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "QuestStateSetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestStateSetter>.NativeClassPtr);
			QuestStateSetter.NativeFieldInfoPtr_QuestName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestStateSetter>.NativeClassPtr, "QuestName");
			QuestStateSetter.NativeFieldInfoPtr_SetQuestState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestStateSetter>.NativeClassPtr, "SetQuestState");
			QuestStateSetter.NativeFieldInfoPtr_QuestState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestStateSetter>.NativeClassPtr, "QuestState");
			QuestStateSetter.NativeFieldInfoPtr_SetQuestEntryState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestStateSetter>.NativeClassPtr, "SetQuestEntryState");
			QuestStateSetter.NativeFieldInfoPtr_QuestEntryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestStateSetter>.NativeClassPtr, "QuestEntryIndex");
			QuestStateSetter.NativeFieldInfoPtr_QuestEntryState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestStateSetter>.NativeClassPtr, "QuestEntryState");
			QuestStateSetter.NativeMethodInfoPtr_Execute_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestStateSetter>.NativeClassPtr, 100667654);
			QuestStateSetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestStateSetter>.NativeClassPtr, 100667655);
		}

		// Token: 0x060026FB RID: 9979 RVA: 0x000EAD4C File Offset: 0x000E8F4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117708, RefRangeEnd = 117709, XrefRangeStart = 117689, XrefRangeEnd = 117708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestStateSetter.NativeMethodInfoPtr_Execute_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026FC RID: 9980 RVA: 0x000EAD80 File Offset: 0x000E8F80
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestStateSetter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestStateSetter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestStateSetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026FD RID: 9981 RVA: 0x00015981 File Offset: 0x00013B81
		public QuestStateSetter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x060026FE RID: 9982 RVA: 0x000EADBC File Offset: 0x000E8FBC
		// (set) Token: 0x060026FF RID: 9983 RVA: 0x0001598A File Offset: 0x00013B8A
		public unsafe string QuestName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_QuestName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_QuestName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x06002700 RID: 9984 RVA: 0x000EADE4 File Offset: 0x000E8FE4
		// (set) Token: 0x06002701 RID: 9985 RVA: 0x000159A9 File Offset: 0x00013BA9
		public unsafe bool SetQuestState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_SetQuestState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_SetQuestState)) = value;
			}
		}

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x06002702 RID: 9986 RVA: 0x000EAE0C File Offset: 0x000E900C
		// (set) Token: 0x06002703 RID: 9987 RVA: 0x000159C4 File Offset: 0x00013BC4
		public unsafe QuestManager.EQuestAction QuestState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_QuestState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_QuestState)) = value;
			}
		}

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x06002704 RID: 9988 RVA: 0x000EAE34 File Offset: 0x000E9034
		// (set) Token: 0x06002705 RID: 9989 RVA: 0x000159DF File Offset: 0x00013BDF
		public unsafe bool SetQuestEntryState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_SetQuestEntryState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_SetQuestEntryState)) = value;
			}
		}

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x06002706 RID: 9990 RVA: 0x000EAE5C File Offset: 0x000E905C
		// (set) Token: 0x06002707 RID: 9991 RVA: 0x000159FA File Offset: 0x00013BFA
		public unsafe int QuestEntryIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_QuestEntryIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_QuestEntryIndex)) = value;
			}
		}

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x06002708 RID: 9992 RVA: 0x000EAE84 File Offset: 0x000E9084
		// (set) Token: 0x06002709 RID: 9993 RVA: 0x00015A15 File Offset: 0x00013C15
		public unsafe EQuestState QuestEntryState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_QuestEntryState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_QuestEntryState)) = value;
			}
		}

		// Token: 0x040019E9 RID: 6633
		private static readonly IntPtr NativeFieldInfoPtr_QuestName;

		// Token: 0x040019EA RID: 6634
		private static readonly IntPtr NativeFieldInfoPtr_SetQuestState;

		// Token: 0x040019EB RID: 6635
		private static readonly IntPtr NativeFieldInfoPtr_QuestState;

		// Token: 0x040019EC RID: 6636
		private static readonly IntPtr NativeFieldInfoPtr_SetQuestEntryState;

		// Token: 0x040019ED RID: 6637
		private static readonly IntPtr NativeFieldInfoPtr_QuestEntryIndex;

		// Token: 0x040019EE RID: 6638
		private static readonly IntPtr NativeFieldInfoPtr_QuestEntryState;

		// Token: 0x040019EF RID: 6639
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Void_0;

		// Token: 0x040019F0 RID: 6640
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
