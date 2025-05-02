using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Construction.Features;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Construction
{
	// Token: 0x02000720 RID: 1824
	public class FeatureIcon : MonoBehaviour
	{
		// Token: 0x0600A435 RID: 42037 RVA: 0x002929C0 File Offset: 0x00290BC0
		// Note: this type is marked as 'beforefieldinit'.
		static FeatureIcon()
		{
			Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Construction", "FeatureIcon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr);
			FeatureIcon.NativeFieldInfoPtr_selectedFeatureIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, "selectedFeatureIcon");
			FeatureIcon.NativeFieldInfoPtr_rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, "rectTransform");
			FeatureIcon.NativeFieldInfoPtr_icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, "icon");
			FeatureIcon.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, "text");
			FeatureIcon.NativeFieldInfoPtr_background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, "background");
			FeatureIcon.NativeFieldInfoPtr__feature_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, "<feature>k__BackingField");
			FeatureIcon.NativeFieldInfoPtr__isSelected_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, "<isSelected>k__BackingField");
			FeatureIcon.NativeFieldInfoPtr_hovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, "hovered");
			FeatureIcon.NativeMethodInfoPtr_get_feature_Public_get_Feature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683371);
			FeatureIcon.NativeMethodInfoPtr_set_feature_Protected_set_Void_Feature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683372);
			FeatureIcon.NativeMethodInfoPtr_get_isSelected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683373);
			FeatureIcon.NativeMethodInfoPtr_set_isSelected_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683374);
			FeatureIcon.NativeMethodInfoPtr_AssignFeature_Public_Void_Feature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683375);
			FeatureIcon.NativeMethodInfoPtr_UpdateTransform_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683376);
			FeatureIcon.NativeMethodInfoPtr_Clicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683377);
			FeatureIcon.NativeMethodInfoPtr_SetIsSelected_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683378);
			FeatureIcon.NativeMethodInfoPtr_UpdateColors_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683379);
			FeatureIcon.NativeMethodInfoPtr_PointerEnter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683380);
			FeatureIcon.NativeMethodInfoPtr_PointerExit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683381);
			FeatureIcon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr, 100683382);
		}

		// Token: 0x170032AF RID: 12975
		// (get) Token: 0x0600A436 RID: 42038 RVA: 0x00292B80 File Offset: 0x00290D80
		// (set) Token: 0x0600A437 RID: 42039 RVA: 0x00292BC0 File Offset: 0x00290DC0
		public unsafe Feature feature
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35358, RefRangeEnd = 35359, XrefRangeStart = 35358, XrefRangeEnd = 35359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr_get_feature_Public_get_Feature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Feature>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr_set_feature_Protected_set_Void_Feature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170032B0 RID: 12976
		// (get) Token: 0x0600A438 RID: 42040 RVA: 0x00292C04 File Offset: 0x00290E04
		// (set) Token: 0x0600A439 RID: 42041 RVA: 0x00292C40 File Offset: 0x00290E40
		public unsafe bool isSelected
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr_get_isSelected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 50985, RefRangeEnd = 50988, XrefRangeStart = 50985, XrefRangeEnd = 50988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr_set_isSelected_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A43A RID: 42042 RVA: 0x00292C80 File Offset: 0x00290E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287566, XrefRangeEnd = 287571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignFeature(Feature _feature)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_feature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr_AssignFeature_Public_Void_Feature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A43B RID: 42043 RVA: 0x00292CC4 File Offset: 0x00290EC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 287600, RefRangeEnd = 287601, XrefRangeStart = 287571, XrefRangeEnd = 287600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr_UpdateTransform_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A43C RID: 42044 RVA: 0x00292CF8 File Offset: 0x00290EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287601, XrefRangeEnd = 287611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr_Clicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A43D RID: 42045 RVA: 0x00292D2C File Offset: 0x00290F2C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 287634, RefRangeEnd = 287637, XrefRangeStart = 287611, XrefRangeEnd = 287634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsSelected(bool s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref s;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr_SetIsSelected_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A43E RID: 42046 RVA: 0x00292D6C File Offset: 0x00290F6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 287637, RefRangeEnd = 287638, XrefRangeStart = 287637, XrefRangeEnd = 287637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateColors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr_UpdateColors_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A43F RID: 42047 RVA: 0x00292DA0 File Offset: 0x00290FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287638, XrefRangeEnd = 287641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PointerEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr_PointerEnter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A440 RID: 42048 RVA: 0x00292DD4 File Offset: 0x00290FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287641, XrefRangeEnd = 287643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PointerExit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr_PointerExit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A441 RID: 42049 RVA: 0x00292E08 File Offset: 0x00291008
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FeatureIcon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FeatureIcon>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureIcon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A442 RID: 42050 RVA: 0x00050EB5 File Offset: 0x0004F0B5
		public FeatureIcon(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170032A7 RID: 12967
		// (get) Token: 0x0600A443 RID: 42051 RVA: 0x00292E44 File Offset: 0x00291044
		// (set) Token: 0x0600A444 RID: 42052 RVA: 0x00050EBE File Offset: 0x0004F0BE
		public unsafe static FeatureIcon selectedFeatureIcon
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FeatureIcon.NativeFieldInfoPtr_selectedFeatureIcon, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FeatureIcon>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FeatureIcon.NativeFieldInfoPtr_selectedFeatureIcon, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032A8 RID: 12968
		// (get) Token: 0x0600A445 RID: 42053 RVA: 0x00292E6C File Offset: 0x0029106C
		// (set) Token: 0x0600A446 RID: 42054 RVA: 0x00050ED0 File Offset: 0x0004F0D0
		public unsafe RectTransform rectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr_rectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr_rectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032A9 RID: 12969
		// (get) Token: 0x0600A447 RID: 42055 RVA: 0x00292E9C File Offset: 0x0029109C
		// (set) Token: 0x0600A448 RID: 42056 RVA: 0x00050EEF File Offset: 0x0004F0EF
		public unsafe Image icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr_icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr_icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032AA RID: 12970
		// (get) Token: 0x0600A449 RID: 42057 RVA: 0x00292ECC File Offset: 0x002910CC
		// (set) Token: 0x0600A44A RID: 42058 RVA: 0x00050F0E File Offset: 0x0004F10E
		public unsafe TextMeshProUGUI text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032AB RID: 12971
		// (get) Token: 0x0600A44B RID: 42059 RVA: 0x00292EFC File Offset: 0x002910FC
		// (set) Token: 0x0600A44C RID: 42060 RVA: 0x00050F2D File Offset: 0x0004F12D
		public unsafe Image background
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr_background);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr_background), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032AC RID: 12972
		// (get) Token: 0x0600A44D RID: 42061 RVA: 0x00292F2C File Offset: 0x0029112C
		// (set) Token: 0x0600A44E RID: 42062 RVA: 0x00050F4C File Offset: 0x0004F14C
		public unsafe Feature _feature_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr__feature_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Feature>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr__feature_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032AD RID: 12973
		// (get) Token: 0x0600A44F RID: 42063 RVA: 0x00292F5C File Offset: 0x0029115C
		// (set) Token: 0x0600A450 RID: 42064 RVA: 0x00050F6B File Offset: 0x0004F16B
		public unsafe bool _isSelected_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr__isSelected_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr__isSelected_k__BackingField)) = value;
			}
		}

		// Token: 0x170032AE RID: 12974
		// (get) Token: 0x0600A451 RID: 42065 RVA: 0x00292F84 File Offset: 0x00291184
		// (set) Token: 0x0600A452 RID: 42066 RVA: 0x00050F86 File Offset: 0x0004F186
		public unsafe bool hovered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr_hovered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureIcon.NativeFieldInfoPtr_hovered)) = value;
			}
		}

		// Token: 0x04006E18 RID: 28184
		private static readonly IntPtr NativeFieldInfoPtr_selectedFeatureIcon;

		// Token: 0x04006E19 RID: 28185
		private static readonly IntPtr NativeFieldInfoPtr_rectTransform;

		// Token: 0x04006E1A RID: 28186
		private static readonly IntPtr NativeFieldInfoPtr_icon;

		// Token: 0x04006E1B RID: 28187
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04006E1C RID: 28188
		private static readonly IntPtr NativeFieldInfoPtr_background;

		// Token: 0x04006E1D RID: 28189
		private static readonly IntPtr NativeFieldInfoPtr__feature_k__BackingField;

		// Token: 0x04006E1E RID: 28190
		private static readonly IntPtr NativeFieldInfoPtr__isSelected_k__BackingField;

		// Token: 0x04006E1F RID: 28191
		private static readonly IntPtr NativeFieldInfoPtr_hovered;

		// Token: 0x04006E20 RID: 28192
		private static readonly IntPtr NativeMethodInfoPtr_get_feature_Public_get_Feature_0;

		// Token: 0x04006E21 RID: 28193
		private static readonly IntPtr NativeMethodInfoPtr_set_feature_Protected_set_Void_Feature_0;

		// Token: 0x04006E22 RID: 28194
		private static readonly IntPtr NativeMethodInfoPtr_get_isSelected_Public_get_Boolean_0;

		// Token: 0x04006E23 RID: 28195
		private static readonly IntPtr NativeMethodInfoPtr_set_isSelected_Protected_set_Void_Boolean_0;

		// Token: 0x04006E24 RID: 28196
		private static readonly IntPtr NativeMethodInfoPtr_AssignFeature_Public_Void_Feature_0;

		// Token: 0x04006E25 RID: 28197
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTransform_Public_Void_0;

		// Token: 0x04006E26 RID: 28198
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Public_Void_0;

		// Token: 0x04006E27 RID: 28199
		private static readonly IntPtr NativeMethodInfoPtr_SetIsSelected_Public_Void_Boolean_0;

		// Token: 0x04006E28 RID: 28200
		private static readonly IntPtr NativeMethodInfoPtr_UpdateColors_Private_Void_0;

		// Token: 0x04006E29 RID: 28201
		private static readonly IntPtr NativeMethodInfoPtr_PointerEnter_Public_Void_0;

		// Token: 0x04006E2A RID: 28202
		private static readonly IntPtr NativeMethodInfoPtr_PointerExit_Public_Void_0;

		// Token: 0x04006E2B RID: 28203
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
