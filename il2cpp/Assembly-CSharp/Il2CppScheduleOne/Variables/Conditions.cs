using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Variables
{
	// Token: 0x0200017E RID: 382
	[Serializable]
	public class Conditions : Object
	{
		// Token: 0x06001E9A RID: 7834 RVA: 0x000CFA94 File Offset: 0x000CDC94
		// Note: this type is marked as 'beforefieldinit'.
		static Conditions()
		{
			Il2CppClassPointerStore<Conditions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Variables", "Conditions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Conditions>.NativeClassPtr);
			Conditions.NativeFieldInfoPtr_EvaluationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conditions>.NativeClassPtr, "EvaluationType");
			Conditions.NativeFieldInfoPtr_ConditionList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conditions>.NativeClassPtr, "ConditionList");
			Conditions.NativeFieldInfoPtr_QuestConditionList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conditions>.NativeClassPtr, "QuestConditionList");
			Conditions.NativeMethodInfoPtr_Evaluate_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Conditions>.NativeClassPtr, 100666758);
			Conditions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Conditions>.NativeClassPtr, 100666759);
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x000CFB28 File Offset: 0x000CDD28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 107386, RefRangeEnd = 107388, XrefRangeStart = 107375, XrefRangeEnd = 107386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Conditions.NativeMethodInfoPtr_Evaluate_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x000CFB64 File Offset: 0x000CDD64
		[CallerCount(2261)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Conditions() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Conditions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Conditions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x00011435 File Offset: 0x0000F635
		public Conditions(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06001E9E RID: 7838 RVA: 0x000CFBA0 File Offset: 0x000CDDA0
		// (set) Token: 0x06001E9F RID: 7839 RVA: 0x0001143E File Offset: 0x0000F63E
		public unsafe Conditions.EEvaluationType EvaluationType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conditions.NativeFieldInfoPtr_EvaluationType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conditions.NativeFieldInfoPtr_EvaluationType)) = value;
			}
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06001EA0 RID: 7840 RVA: 0x000CFBC8 File Offset: 0x000CDDC8
		// (set) Token: 0x06001EA1 RID: 7841 RVA: 0x00011459 File Offset: 0x0000F659
		public unsafe Il2CppReferenceArray<Condition> ConditionList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conditions.NativeFieldInfoPtr_ConditionList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Condition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conditions.NativeFieldInfoPtr_ConditionList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06001EA2 RID: 7842 RVA: 0x000CFBF8 File Offset: 0x000CDDF8
		// (set) Token: 0x06001EA3 RID: 7843 RVA: 0x00011478 File Offset: 0x0000F678
		public unsafe Il2CppReferenceArray<QuestCondition> QuestConditionList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conditions.NativeFieldInfoPtr_QuestConditionList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<QuestCondition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conditions.NativeFieldInfoPtr_QuestConditionList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001457 RID: 5207
		private static readonly IntPtr NativeFieldInfoPtr_EvaluationType;

		// Token: 0x04001458 RID: 5208
		private static readonly IntPtr NativeFieldInfoPtr_ConditionList;

		// Token: 0x04001459 RID: 5209
		private static readonly IntPtr NativeFieldInfoPtr_QuestConditionList;

		// Token: 0x0400145A RID: 5210
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Boolean_0;

		// Token: 0x0400145B RID: 5211
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008B0 RID: 2224
		[OriginalName("Assembly-CSharp.dll", "", "EEvaluationType")]
		public enum EEvaluationType
		{
			// Token: 0x04008445 RID: 33861
			And,
			// Token: 0x04008446 RID: 33862
			Or
		}
	}
}
