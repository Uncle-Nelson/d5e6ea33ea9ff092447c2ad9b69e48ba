using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Management;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006CB RID: 1739
	public class QualityFieldUI : MonoBehaviour
	{
		// Token: 0x06009C35 RID: 39989 RVA: 0x0027957C File Offset: 0x0027777C
		// Note: this type is marked as 'beforefieldinit'.
		static QualityFieldUI()
		{
			Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "QualityFieldUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr);
			QualityFieldUI.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, "<Fields>k__BackingField");
			QualityFieldUI.NativeFieldInfoPtr_FieldLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, "FieldLabel");
			QualityFieldUI.NativeFieldInfoPtr_QualityButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, "QualityButtons");
			QualityFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_QualityField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, 100682472);
			QualityFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_QualityField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, 100682473);
			QualityFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_QualityField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, 100682474);
			QualityFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, 100682475);
			QualityFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, 100682476);
			QualityFieldUI.NativeMethodInfoPtr_ValueChanged_Public_Void_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, 100682477);
			QualityFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, 100682478);
		}

		// Token: 0x1700301C RID: 12316
		// (get) Token: 0x06009C36 RID: 39990 RVA: 0x00279674 File Offset: 0x00277874
		// (set) Token: 0x06009C37 RID: 39991 RVA: 0x002796B4 File Offset: 0x002778B4
		public unsafe List<QualityField> Fields
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17399, RefRangeEnd = 17400, XrefRangeStart = 17399, XrefRangeEnd = 17400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_QualityField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<QualityField>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_QualityField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009C38 RID: 39992 RVA: 0x002796F8 File Offset: 0x002778F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 277419, RefRangeEnd = 277420, XrefRangeStart = 277378, XrefRangeEnd = 277419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(List<QualityField> field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_QualityField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C39 RID: 39993 RVA: 0x0027973C File Offset: 0x0027793C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 277434, RefRangeEnd = 277435, XrefRangeStart = 277420, XrefRangeEnd = 277434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh(EQuality value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C3A RID: 39994 RVA: 0x0027977C File Offset: 0x0027797C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277435, XrefRangeEnd = 277442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreFieldsUniform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009C3B RID: 39995 RVA: 0x002797B8 File Offset: 0x002779B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277442, XrefRangeEnd = 277448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValueChanged(EQuality value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.NativeMethodInfoPtr_ValueChanged_Public_Void_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C3C RID: 39996 RVA: 0x002797F8 File Offset: 0x002779F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277448, XrefRangeEnd = 277456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityFieldUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C3D RID: 39997 RVA: 0x0004C930 File Offset: 0x0004AB30
		public QualityFieldUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003019 RID: 12313
		// (get) Token: 0x06009C3E RID: 39998 RVA: 0x00279834 File Offset: 0x00277A34
		// (set) Token: 0x06009C3F RID: 39999 RVA: 0x0004C939 File Offset: 0x0004AB39
		public unsafe List<QualityField> _Fields_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.NativeFieldInfoPtr__Fields_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<QualityField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700301A RID: 12314
		// (get) Token: 0x06009C40 RID: 40000 RVA: 0x00279864 File Offset: 0x00277A64
		// (set) Token: 0x06009C41 RID: 40001 RVA: 0x0004C958 File Offset: 0x0004AB58
		public unsafe TextMeshProUGUI FieldLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.NativeFieldInfoPtr_FieldLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.NativeFieldInfoPtr_FieldLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700301B RID: 12315
		// (get) Token: 0x06009C42 RID: 40002 RVA: 0x00279894 File Offset: 0x00277A94
		// (set) Token: 0x06009C43 RID: 40003 RVA: 0x0004C977 File Offset: 0x0004AB77
		public unsafe Il2CppReferenceArray<Button> QualityButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.NativeFieldInfoPtr_QualityButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.NativeFieldInfoPtr_QualityButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040068EE RID: 26862
		private static readonly IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x040068EF RID: 26863
		private static readonly IntPtr NativeFieldInfoPtr_FieldLabel;

		// Token: 0x040068F0 RID: 26864
		private static readonly IntPtr NativeFieldInfoPtr_QualityButtons;

		// Token: 0x040068F1 RID: 26865
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_get_List_1_QualityField_0;

		// Token: 0x040068F2 RID: 26866
		private static readonly IntPtr NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_QualityField_0;

		// Token: 0x040068F3 RID: 26867
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Void_List_1_QualityField_0;

		// Token: 0x040068F4 RID: 26868
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_EQuality_0;

		// Token: 0x040068F5 RID: 26869
		private static readonly IntPtr NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0;

		// Token: 0x040068F6 RID: 26870
		private static readonly IntPtr NativeMethodInfoPtr_ValueChanged_Public_Void_EQuality_0;

		// Token: 0x040068F7 RID: 26871
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B8E RID: 2958
		[ObfuscatedName("ScheduleOne.UI.Management.QualityFieldUI+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DBF6 RID: 56310 RVA: 0x003409EC File Offset: 0x0033EBEC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<QualityFieldUI.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<QualityFieldUI>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityFieldUI.__c__DisplayClass6_0>.NativeClassPtr);
				QualityFieldUI.__c__DisplayClass6_0.NativeFieldInfoPtr_quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityFieldUI.__c__DisplayClass6_0>.NativeClassPtr, "quality");
				QualityFieldUI.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityFieldUI.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
				QualityFieldUI.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI.__c__DisplayClass6_0>.NativeClassPtr, 100682479);
				QualityFieldUI.__c__DisplayClass6_0.NativeMethodInfoPtr__Bind_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldUI.__c__DisplayClass6_0>.NativeClassPtr, 100682480);
			}

			// Token: 0x0600DBF7 RID: 56311 RVA: 0x00340A68 File Offset: 0x0033EC68
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityFieldUI.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBF8 RID: 56312 RVA: 0x00340AA4 File Offset: 0x0033ECA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277372, XrefRangeEnd = 277378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Bind_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldUI.__c__DisplayClass6_0.NativeMethodInfoPtr__Bind_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBF9 RID: 56313 RVA: 0x0006B295 File Offset: 0x00069495
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004433 RID: 17459
			// (get) Token: 0x0600DBFA RID: 56314 RVA: 0x00340AD8 File Offset: 0x0033ECD8
			// (set) Token: 0x0600DBFB RID: 56315 RVA: 0x0006B29E File Offset: 0x0006949E
			public unsafe EQuality quality
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.__c__DisplayClass6_0.NativeFieldInfoPtr_quality);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.__c__DisplayClass6_0.NativeFieldInfoPtr_quality)) = value;
				}
			}

			// Token: 0x17004434 RID: 17460
			// (get) Token: 0x0600DBFC RID: 56316 RVA: 0x00340B00 File Offset: 0x0033ED00
			// (set) Token: 0x0600DBFD RID: 56317 RVA: 0x0006B2B9 File Offset: 0x000694B9
			public unsafe QualityFieldUI __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<QualityFieldUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldUI.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009379 RID: 37753
			private static readonly IntPtr NativeFieldInfoPtr_quality;

			// Token: 0x0400937A RID: 37754
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400937B RID: 37755
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400937C RID: 37756
			private static readonly IntPtr NativeMethodInfoPtr__Bind_b__0_Internal_Void_0;
		}
	}
}
