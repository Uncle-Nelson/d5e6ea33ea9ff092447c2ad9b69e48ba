using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Variables
{
	// Token: 0x0200017D RID: 381
	[Serializable]
	public class Condition : Object
	{
		// Token: 0x06001E90 RID: 7824 RVA: 0x000CF910 File Offset: 0x000CDB10
		// Note: this type is marked as 'beforefieldinit'.
		static Condition()
		{
			Il2CppClassPointerStore<Condition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Variables", "Condition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Condition>.NativeClassPtr);
			Condition.NativeFieldInfoPtr_VariableName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Condition>.NativeClassPtr, "VariableName");
			Condition.NativeFieldInfoPtr_Operator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Condition>.NativeClassPtr, "Operator");
			Condition.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Condition>.NativeClassPtr, "Value");
			Condition.NativeMethodInfoPtr_Evaluate_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition>.NativeClassPtr, 100666756);
			Condition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition>.NativeClassPtr, 100666757);
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x000CF9A4 File Offset: 0x000CDBA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107349, XrefRangeEnd = 107366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Condition.NativeMethodInfoPtr_Evaluate_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E92 RID: 7826 RVA: 0x000CF9E0 File Offset: 0x000CDBE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107366, XrefRangeEnd = 107375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Condition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Condition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Condition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E93 RID: 7827 RVA: 0x000113D3 File Offset: 0x0000F5D3
		public Condition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06001E94 RID: 7828 RVA: 0x000CFA1C File Offset: 0x000CDC1C
		// (set) Token: 0x06001E95 RID: 7829 RVA: 0x000113DC File Offset: 0x0000F5DC
		public unsafe string VariableName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_VariableName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_VariableName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06001E96 RID: 7830 RVA: 0x000CFA44 File Offset: 0x000CDC44
		// (set) Token: 0x06001E97 RID: 7831 RVA: 0x000113FB File Offset: 0x0000F5FB
		public unsafe Condition.EConditionType Operator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_Operator);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_Operator)) = value;
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06001E98 RID: 7832 RVA: 0x000CFA6C File Offset: 0x000CDC6C
		// (set) Token: 0x06001E99 RID: 7833 RVA: 0x00011416 File Offset: 0x0000F616
		public unsafe string Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_Value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_Value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001452 RID: 5202
		private static readonly IntPtr NativeFieldInfoPtr_VariableName;

		// Token: 0x04001453 RID: 5203
		private static readonly IntPtr NativeFieldInfoPtr_Operator;

		// Token: 0x04001454 RID: 5204
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001455 RID: 5205
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Boolean_0;

		// Token: 0x04001456 RID: 5206
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008AF RID: 2223
		[OriginalName("Assembly-CSharp.dll", "", "EConditionType")]
		public enum EConditionType
		{
			// Token: 0x0400843E RID: 33854
			GreaterThan,
			// Token: 0x0400843F RID: 33855
			LessThan,
			// Token: 0x04008440 RID: 33856
			EqualTo,
			// Token: 0x04008441 RID: 33857
			NotEqualTo,
			// Token: 0x04008442 RID: 33858
			GreaterThanOrEqualTo,
			// Token: 0x04008443 RID: 33859
			LessThanOrEqualTo
		}
	}
}
