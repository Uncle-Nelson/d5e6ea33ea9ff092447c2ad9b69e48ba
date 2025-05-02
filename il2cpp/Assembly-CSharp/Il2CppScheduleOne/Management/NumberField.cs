using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x02000395 RID: 917
	public class NumberField : ConfigField
	{
		// Token: 0x060047F6 RID: 18422 RVA: 0x00160634 File Offset: 0x0015E834
		// Note: this type is marked as 'beforefieldinit'.
		static NumberField()
		{
			Il2CppClassPointerStore<NumberField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "NumberField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberField>.NativeClassPtr);
			NumberField.NativeFieldInfoPtr__Value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberField>.NativeClassPtr, "<Value>k__BackingField");
			NumberField.NativeFieldInfoPtr__MinValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberField>.NativeClassPtr, "<MinValue>k__BackingField");
			NumberField.NativeFieldInfoPtr__MaxValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberField>.NativeClassPtr, "<MaxValue>k__BackingField");
			NumberField.NativeFieldInfoPtr__WholeNumbers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberField>.NativeClassPtr, "<WholeNumbers>k__BackingField");
			NumberField.NativeFieldInfoPtr_onItemChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberField>.NativeClassPtr, "onItemChanged");
			NumberField.NativeMethodInfoPtr_get_Value_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672190);
			NumberField.NativeMethodInfoPtr_set_Value_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672191);
			NumberField.NativeMethodInfoPtr_get_MinValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672192);
			NumberField.NativeMethodInfoPtr_set_MinValue_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672193);
			NumberField.NativeMethodInfoPtr_get_MaxValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672194);
			NumberField.NativeMethodInfoPtr_set_MaxValue_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672195);
			NumberField.NativeMethodInfoPtr_get_WholeNumbers_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672196);
			NumberField.NativeMethodInfoPtr_set_WholeNumbers_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672197);
			NumberField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672198);
			NumberField.NativeMethodInfoPtr_SetValue_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672199);
			NumberField.NativeMethodInfoPtr_Configure_Public_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672200);
			NumberField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672201);
			NumberField.NativeMethodInfoPtr_GetData_Public_NumberFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672202);
			NumberField.NativeMethodInfoPtr_Load_Public_Void_NumberFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberField>.NativeClassPtr, 100672203);
		}

		// Token: 0x1700159A RID: 5530
		// (get) Token: 0x060047F7 RID: 18423 RVA: 0x001607E0 File Offset: 0x0015E9E0
		// (set) Token: 0x060047F8 RID: 18424 RVA: 0x0016081C File Offset: 0x0015EA1C
		public unsafe float Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_get_Value_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 90261, RefRangeEnd = 90265, XrefRangeStart = 90261, XrefRangeEnd = 90265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_set_Value_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700159B RID: 5531
		// (get) Token: 0x060047F9 RID: 18425 RVA: 0x0016085C File Offset: 0x0015EA5C
		// (set) Token: 0x060047FA RID: 18426 RVA: 0x00160898 File Offset: 0x0015EA98
		public unsafe float MinValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_get_MinValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 29999, RefRangeEnd = 30010, XrefRangeStart = 29999, XrefRangeEnd = 30010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_set_MinValue_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700159C RID: 5532
		// (get) Token: 0x060047FB RID: 18427 RVA: 0x001608D8 File Offset: 0x0015EAD8
		// (set) Token: 0x060047FC RID: 18428 RVA: 0x00160914 File Offset: 0x0015EB14
		public unsafe float MaxValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_get_MaxValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29962, RefRangeEnd = 29963, XrefRangeStart = 29962, XrefRangeEnd = 29963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_set_MaxValue_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700159D RID: 5533
		// (get) Token: 0x060047FD RID: 18429 RVA: 0x00160954 File Offset: 0x0015EB54
		// (set) Token: 0x060047FE RID: 18430 RVA: 0x00160990 File Offset: 0x0015EB90
		public unsafe bool WholeNumbers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_get_WholeNumbers_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_set_WholeNumbers_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047FF RID: 18431 RVA: 0x001609D0 File Offset: 0x0015EBD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161623, XrefRangeEnd = 161631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumberField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004800 RID: 18432 RVA: 0x00160A1C File Offset: 0x0015EC1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 161635, RefRangeEnd = 161636, XrefRangeStart = 161631, XrefRangeEnd = 161635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(float value, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_SetValue_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004801 RID: 18433 RVA: 0x00160A68 File Offset: 0x0015EC68
		[CallerCount(0)]
		public unsafe void Configure(float minValue, float maxValue, bool wholeNumbers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minValue;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wholeNumbers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_Configure_Public_Void_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004802 RID: 18434 RVA: 0x00160AC4 File Offset: 0x0015ECC4
		[CallerCount(0)]
		public unsafe override bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NumberField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004803 RID: 18435 RVA: 0x00160B0C File Offset: 0x0015ED0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161636, XrefRangeEnd = 161640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberFieldData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_GetData_Public_NumberFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberFieldData>(intPtr3) : null;
		}

		// Token: 0x06004804 RID: 18436 RVA: 0x00160B4C File Offset: 0x0015ED4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 161644, RefRangeEnd = 161645, XrefRangeStart = 161640, XrefRangeEnd = 161644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(NumberFieldData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberField.NativeMethodInfoPtr_Load_Public_Void_NumberFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004805 RID: 18437 RVA: 0x00022D21 File Offset: 0x00020F21
		public NumberField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001595 RID: 5525
		// (get) Token: 0x06004806 RID: 18438 RVA: 0x00160B90 File Offset: 0x0015ED90
		// (set) Token: 0x06004807 RID: 18439 RVA: 0x00022D2A File Offset: 0x00020F2A
		public unsafe float _Value_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr__Value_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr__Value_k__BackingField)) = value;
			}
		}

		// Token: 0x17001596 RID: 5526
		// (get) Token: 0x06004808 RID: 18440 RVA: 0x00160BB8 File Offset: 0x0015EDB8
		// (set) Token: 0x06004809 RID: 18441 RVA: 0x00022D45 File Offset: 0x00020F45
		public unsafe float _MinValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr__MinValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr__MinValue_k__BackingField)) = value;
			}
		}

		// Token: 0x17001597 RID: 5527
		// (get) Token: 0x0600480A RID: 18442 RVA: 0x00160BE0 File Offset: 0x0015EDE0
		// (set) Token: 0x0600480B RID: 18443 RVA: 0x00022D60 File Offset: 0x00020F60
		public unsafe float _MaxValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr__MaxValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr__MaxValue_k__BackingField)) = value;
			}
		}

		// Token: 0x17001598 RID: 5528
		// (get) Token: 0x0600480C RID: 18444 RVA: 0x00160C08 File Offset: 0x0015EE08
		// (set) Token: 0x0600480D RID: 18445 RVA: 0x00022D7B File Offset: 0x00020F7B
		public unsafe bool _WholeNumbers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr__WholeNumbers_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr__WholeNumbers_k__BackingField)) = value;
			}
		}

		// Token: 0x17001599 RID: 5529
		// (get) Token: 0x0600480E RID: 18446 RVA: 0x00160C30 File Offset: 0x0015EE30
		// (set) Token: 0x0600480F RID: 18447 RVA: 0x00022D96 File Offset: 0x00020F96
		public unsafe UnityEvent<float> onItemChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr_onItemChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberField.NativeFieldInfoPtr_onItemChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400307E RID: 12414
		private static readonly IntPtr NativeFieldInfoPtr__Value_k__BackingField;

		// Token: 0x0400307F RID: 12415
		private static readonly IntPtr NativeFieldInfoPtr__MinValue_k__BackingField;

		// Token: 0x04003080 RID: 12416
		private static readonly IntPtr NativeFieldInfoPtr__MaxValue_k__BackingField;

		// Token: 0x04003081 RID: 12417
		private static readonly IntPtr NativeFieldInfoPtr__WholeNumbers_k__BackingField;

		// Token: 0x04003082 RID: 12418
		private static readonly IntPtr NativeFieldInfoPtr_onItemChanged;

		// Token: 0x04003083 RID: 12419
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Single_0;

		// Token: 0x04003084 RID: 12420
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Protected_set_Void_Single_0;

		// Token: 0x04003085 RID: 12421
		private static readonly IntPtr NativeMethodInfoPtr_get_MinValue_Public_get_Single_0;

		// Token: 0x04003086 RID: 12422
		private static readonly IntPtr NativeMethodInfoPtr_set_MinValue_Protected_set_Void_Single_0;

		// Token: 0x04003087 RID: 12423
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxValue_Public_get_Single_0;

		// Token: 0x04003088 RID: 12424
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxValue_Protected_set_Void_Single_0;

		// Token: 0x04003089 RID: 12425
		private static readonly IntPtr NativeMethodInfoPtr_get_WholeNumbers_Public_get_Boolean_0;

		// Token: 0x0400308A RID: 12426
		private static readonly IntPtr NativeMethodInfoPtr_set_WholeNumbers_Protected_set_Void_Boolean_0;

		// Token: 0x0400308B RID: 12427
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x0400308C RID: 12428
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Single_Boolean_0;

		// Token: 0x0400308D RID: 12429
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Void_Single_Single_Boolean_0;

		// Token: 0x0400308E RID: 12430
		private static readonly IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0;

		// Token: 0x0400308F RID: 12431
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_NumberFieldData_0;

		// Token: 0x04003090 RID: 12432
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_NumberFieldData_0;
	}
}
