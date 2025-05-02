using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x02000398 RID: 920
	public class QualityField : ConfigField
	{
		// Token: 0x06004836 RID: 18486 RVA: 0x00161440 File Offset: 0x0015F640
		// Note: this type is marked as 'beforefieldinit'.
		static QualityField()
		{
			Il2CppClassPointerStore<QualityField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "QualityField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityField>.NativeClassPtr);
			QualityField.NativeFieldInfoPtr__Value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityField>.NativeClassPtr, "<Value>k__BackingField");
			QualityField.NativeFieldInfoPtr_onValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityField>.NativeClassPtr, "onValueChanged");
			QualityField.NativeMethodInfoPtr_get_Value_Public_get_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityField>.NativeClassPtr, 100672218);
			QualityField.NativeMethodInfoPtr_set_Value_Protected_set_Void_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityField>.NativeClassPtr, 100672219);
			QualityField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityField>.NativeClassPtr, 100672220);
			QualityField.NativeMethodInfoPtr_SetValue_Public_Void_EQuality_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityField>.NativeClassPtr, 100672221);
			QualityField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityField>.NativeClassPtr, 100672222);
			QualityField.NativeMethodInfoPtr_GetData_Public_QualityFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityField>.NativeClassPtr, 100672223);
			QualityField.NativeMethodInfoPtr_Load_Public_Void_QualityFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityField>.NativeClassPtr, 100672224);
		}

		// Token: 0x170015AA RID: 5546
		// (get) Token: 0x06004837 RID: 18487 RVA: 0x00161524 File Offset: 0x0015F724
		// (set) Token: 0x06004838 RID: 18488 RVA: 0x00161560 File Offset: 0x0015F760
		public unsafe EQuality Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityField.NativeMethodInfoPtr_get_Value_Public_get_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29997, RefRangeEnd = 29999, XrefRangeStart = 29997, XrefRangeEnd = 29999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityField.NativeMethodInfoPtr_set_Value_Protected_set_Void_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004839 RID: 18489 RVA: 0x001615A0 File Offset: 0x0015F7A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161959, XrefRangeEnd = 161967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600483A RID: 18490 RVA: 0x001615EC File Offset: 0x0015F7EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 161971, RefRangeEnd = 161973, XrefRangeStart = 161967, XrefRangeEnd = 161971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(EQuality value, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityField.NativeMethodInfoPtr_SetValue_Public_Void_EQuality_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600483B RID: 18491 RVA: 0x00161638 File Offset: 0x0015F838
		[CallerCount(0)]
		public unsafe override bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QualityField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600483C RID: 18492 RVA: 0x00161680 File Offset: 0x0015F880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161973, XrefRangeEnd = 161977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityFieldData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityField.NativeMethodInfoPtr_GetData_Public_QualityFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<QualityFieldData>(intPtr3) : null;
		}

		// Token: 0x0600483D RID: 18493 RVA: 0x001616C0 File Offset: 0x0015F8C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 161981, RefRangeEnd = 161982, XrefRangeStart = 161977, XrefRangeEnd = 161981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(QualityFieldData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityField.NativeMethodInfoPtr_Load_Public_Void_QualityFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600483E RID: 18494 RVA: 0x00022EF5 File Offset: 0x000210F5
		public QualityField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015A8 RID: 5544
		// (get) Token: 0x0600483F RID: 18495 RVA: 0x00161704 File Offset: 0x0015F904
		// (set) Token: 0x06004840 RID: 18496 RVA: 0x00022EFE File Offset: 0x000210FE
		public unsafe EQuality _Value_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityField.NativeFieldInfoPtr__Value_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityField.NativeFieldInfoPtr__Value_k__BackingField)) = value;
			}
		}

		// Token: 0x170015A9 RID: 5545
		// (get) Token: 0x06004841 RID: 18497 RVA: 0x0016172C File Offset: 0x0015F92C
		// (set) Token: 0x06004842 RID: 18498 RVA: 0x00022F19 File Offset: 0x00021119
		public unsafe UnityEvent<EQuality> onValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityField.NativeFieldInfoPtr_onValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<EQuality>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityField.NativeFieldInfoPtr_onValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040030A9 RID: 12457
		private static readonly IntPtr NativeFieldInfoPtr__Value_k__BackingField;

		// Token: 0x040030AA RID: 12458
		private static readonly IntPtr NativeFieldInfoPtr_onValueChanged;

		// Token: 0x040030AB RID: 12459
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_EQuality_0;

		// Token: 0x040030AC RID: 12460
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Protected_set_Void_EQuality_0;

		// Token: 0x040030AD RID: 12461
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x040030AE RID: 12462
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_EQuality_Boolean_0;

		// Token: 0x040030AF RID: 12463
		private static readonly IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0;

		// Token: 0x040030B0 RID: 12464
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_QualityFieldData_0;

		// Token: 0x040030B1 RID: 12465
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_QualityFieldData_0;
	}
}
