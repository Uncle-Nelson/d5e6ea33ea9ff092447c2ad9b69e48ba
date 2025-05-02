using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006C8 RID: 1736
	public class NumberFieldUI : MonoBehaviour
	{
		// Token: 0x06009BE0 RID: 39904 RVA: 0x00278510 File Offset: 0x00276710
		// Note: this type is marked as 'beforefieldinit'.
		static NumberFieldUI()
		{
			Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "NumberFieldUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr);
			NumberFieldUI.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, "<Fields>k__BackingField");
			NumberFieldUI.NativeFieldInfoPtr_FieldLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, "FieldLabel");
			NumberFieldUI.NativeFieldInfoPtr_Slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, "Slider");
			NumberFieldUI.NativeFieldInfoPtr_ValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, "ValueLabel");
			NumberFieldUI.NativeFieldInfoPtr_MinValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, "MinValueLabel");
			NumberFieldUI.NativeFieldInfoPtr_MaxValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, "MaxValueLabel");
			NumberFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_NumberField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, 100682442);
			NumberFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_NumberField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, 100682443);
			NumberFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_NumberField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, 100682444);
			NumberFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, 100682445);
			NumberFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, 100682446);
			NumberFieldUI.NativeMethodInfoPtr_ValueChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, 100682447);
			NumberFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr, 100682448);
		}

		// Token: 0x17003002 RID: 12290
		// (get) Token: 0x06009BE1 RID: 39905 RVA: 0x00278644 File Offset: 0x00276844
		// (set) Token: 0x06009BE2 RID: 39906 RVA: 0x00278684 File Offset: 0x00276884
		public unsafe List<NumberField> Fields
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_NumberField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NumberField>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_NumberField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009BE3 RID: 39907 RVA: 0x002786C8 File Offset: 0x002768C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276919, RefRangeEnd = 276920, XrefRangeStart = 276861, XrefRangeEnd = 276919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(List<NumberField> field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_NumberField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BE4 RID: 39908 RVA: 0x0027870C File Offset: 0x0027690C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276920, XrefRangeEnd = 276931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh(float newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BE5 RID: 39909 RVA: 0x0027874C File Offset: 0x0027694C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276931, XrefRangeEnd = 276938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreFieldsUniform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009BE6 RID: 39910 RVA: 0x00278788 File Offset: 0x00276988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276938, XrefRangeEnd = 276944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValueChanged(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFieldUI.NativeMethodInfoPtr_ValueChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BE7 RID: 39911 RVA: 0x002787C8 File Offset: 0x002769C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276944, XrefRangeEnd = 276952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberFieldUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumberFieldUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BE8 RID: 39912 RVA: 0x0004C5EF File Offset: 0x0004A7EF
		public NumberFieldUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FFC RID: 12284
		// (get) Token: 0x06009BE9 RID: 39913 RVA: 0x00278804 File Offset: 0x00276A04
		// (set) Token: 0x06009BEA RID: 39914 RVA: 0x0004C5F8 File Offset: 0x0004A7F8
		public unsafe List<NumberField> _Fields_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr__Fields_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NumberField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FFD RID: 12285
		// (get) Token: 0x06009BEB RID: 39915 RVA: 0x00278834 File Offset: 0x00276A34
		// (set) Token: 0x06009BEC RID: 39916 RVA: 0x0004C617 File Offset: 0x0004A817
		public unsafe TextMeshProUGUI FieldLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_FieldLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_FieldLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FFE RID: 12286
		// (get) Token: 0x06009BED RID: 39917 RVA: 0x00278864 File Offset: 0x00276A64
		// (set) Token: 0x06009BEE RID: 39918 RVA: 0x0004C636 File Offset: 0x0004A836
		public unsafe Slider Slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_Slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_Slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FFF RID: 12287
		// (get) Token: 0x06009BEF RID: 39919 RVA: 0x00278894 File Offset: 0x00276A94
		// (set) Token: 0x06009BF0 RID: 39920 RVA: 0x0004C655 File Offset: 0x0004A855
		public unsafe TextMeshProUGUI ValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_ValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_ValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003000 RID: 12288
		// (get) Token: 0x06009BF1 RID: 39921 RVA: 0x002788C4 File Offset: 0x00276AC4
		// (set) Token: 0x06009BF2 RID: 39922 RVA: 0x0004C674 File Offset: 0x0004A874
		public unsafe TextMeshProUGUI MinValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_MinValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_MinValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003001 RID: 12289
		// (get) Token: 0x06009BF3 RID: 39923 RVA: 0x002788F4 File Offset: 0x00276AF4
		// (set) Token: 0x06009BF4 RID: 39924 RVA: 0x0004C693 File Offset: 0x0004A893
		public unsafe TextMeshProUGUI MaxValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_MaxValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFieldUI.NativeFieldInfoPtr_MaxValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040068B9 RID: 26809
		private static readonly IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x040068BA RID: 26810
		private static readonly IntPtr NativeFieldInfoPtr_FieldLabel;

		// Token: 0x040068BB RID: 26811
		private static readonly IntPtr NativeFieldInfoPtr_Slider;

		// Token: 0x040068BC RID: 26812
		private static readonly IntPtr NativeFieldInfoPtr_ValueLabel;

		// Token: 0x040068BD RID: 26813
		private static readonly IntPtr NativeFieldInfoPtr_MinValueLabel;

		// Token: 0x040068BE RID: 26814
		private static readonly IntPtr NativeFieldInfoPtr_MaxValueLabel;

		// Token: 0x040068BF RID: 26815
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_get_List_1_NumberField_0;

		// Token: 0x040068C0 RID: 26816
		private static readonly IntPtr NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_NumberField_0;

		// Token: 0x040068C1 RID: 26817
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Void_List_1_NumberField_0;

		// Token: 0x040068C2 RID: 26818
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_Single_0;

		// Token: 0x040068C3 RID: 26819
		private static readonly IntPtr NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0;

		// Token: 0x040068C4 RID: 26820
		private static readonly IntPtr NativeMethodInfoPtr_ValueChanged_Public_Void_Single_0;

		// Token: 0x040068C5 RID: 26821
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
