using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Quests;
using Il2CppSystem;

namespace Il2CppScheduleOne.Variables
{
	// Token: 0x02000180 RID: 384
	[Serializable]
	public class QuestCondition : Object
	{
		// Token: 0x06001EA9 RID: 7849 RVA: 0x000CFDFC File Offset: 0x000CDFFC
		// Note: this type is marked as 'beforefieldinit'.
		static QuestCondition()
		{
			Il2CppClassPointerStore<QuestCondition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Variables", "QuestCondition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr);
			QuestCondition.NativeFieldInfoPtr_CheckQuestState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr, "CheckQuestState");
			QuestCondition.NativeFieldInfoPtr_QuestName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr, "QuestName");
			QuestCondition.NativeFieldInfoPtr_QuestState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr, "QuestState");
			QuestCondition.NativeFieldInfoPtr_CheckQuestEntryState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr, "CheckQuestEntryState");
			QuestCondition.NativeFieldInfoPtr_QuestEntryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr, "QuestEntryIndex");
			QuestCondition.NativeFieldInfoPtr_QuestEntryState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr, "QuestEntryState");
			QuestCondition.NativeMethodInfoPtr_Evaluate_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr, 100666763);
			QuestCondition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr, 100666764);
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x000CFECC File Offset: 0x000CE0CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107404, XrefRangeEnd = 107420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestCondition.NativeMethodInfoPtr_Evaluate_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EAB RID: 7851 RVA: 0x000CFF08 File Offset: 0x000CE108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107420, XrefRangeEnd = 107425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestCondition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestCondition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x000114A0 File Offset: 0x0000F6A0
		public QuestCondition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06001EAD RID: 7853 RVA: 0x000CFF44 File Offset: 0x000CE144
		// (set) Token: 0x06001EAE RID: 7854 RVA: 0x000114A9 File Offset: 0x0000F6A9
		public unsafe bool CheckQuestState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_CheckQuestState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_CheckQuestState)) = value;
			}
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06001EAF RID: 7855 RVA: 0x000CFF6C File Offset: 0x000CE16C
		// (set) Token: 0x06001EB0 RID: 7856 RVA: 0x000114C4 File Offset: 0x0000F6C4
		public unsafe string QuestName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_QuestName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_QuestName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06001EB1 RID: 7857 RVA: 0x000CFF94 File Offset: 0x000CE194
		// (set) Token: 0x06001EB2 RID: 7858 RVA: 0x000114E3 File Offset: 0x0000F6E3
		public unsafe EQuestState QuestState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_QuestState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_QuestState)) = value;
			}
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06001EB3 RID: 7859 RVA: 0x000CFFBC File Offset: 0x000CE1BC
		// (set) Token: 0x06001EB4 RID: 7860 RVA: 0x000114FE File Offset: 0x0000F6FE
		public unsafe bool CheckQuestEntryState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_CheckQuestEntryState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_CheckQuestEntryState)) = value;
			}
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06001EB5 RID: 7861 RVA: 0x000CFFE4 File Offset: 0x000CE1E4
		// (set) Token: 0x06001EB6 RID: 7862 RVA: 0x00011519 File Offset: 0x0000F719
		public unsafe int QuestEntryIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_QuestEntryIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_QuestEntryIndex)) = value;
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06001EB7 RID: 7863 RVA: 0x000D000C File Offset: 0x000CE20C
		// (set) Token: 0x06001EB8 RID: 7864 RVA: 0x00011534 File Offset: 0x0000F734
		public unsafe EQuestState QuestEntryState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_QuestEntryState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_QuestEntryState)) = value;
			}
		}

		// Token: 0x0400145F RID: 5215
		private static readonly IntPtr NativeFieldInfoPtr_CheckQuestState;

		// Token: 0x04001460 RID: 5216
		private static readonly IntPtr NativeFieldInfoPtr_QuestName;

		// Token: 0x04001461 RID: 5217
		private static readonly IntPtr NativeFieldInfoPtr_QuestState;

		// Token: 0x04001462 RID: 5218
		private static readonly IntPtr NativeFieldInfoPtr_CheckQuestEntryState;

		// Token: 0x04001463 RID: 5219
		private static readonly IntPtr NativeFieldInfoPtr_QuestEntryIndex;

		// Token: 0x04001464 RID: 5220
		private static readonly IntPtr NativeFieldInfoPtr_QuestEntryState;

		// Token: 0x04001465 RID: 5221
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Boolean_0;

		// Token: 0x04001466 RID: 5222
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
