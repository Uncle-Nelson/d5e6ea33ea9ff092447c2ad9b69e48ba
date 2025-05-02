using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Construction.Features;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Construction.Features
{
	// Token: 0x02000722 RID: 1826
	public class FI_ColorPicker : FI_Base
	{
		// Token: 0x0600A475 RID: 42101 RVA: 0x00293614 File Offset: 0x00291814
		// Note: this type is marked as 'beforefieldinit'.
		static FI_ColorPicker()
		{
			Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Construction.Features", "FI_ColorPicker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr);
			FI_ColorPicker.NativeFieldInfoPtr_colorButtonContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, "colorButtonContainer");
			FI_ColorPicker.NativeFieldInfoPtr_buyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, "buyButton");
			FI_ColorPicker.NativeFieldInfoPtr_buyButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, "buyButtonText");
			FI_ColorPicker.NativeFieldInfoPtr_colorLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, "colorLabel");
			FI_ColorPicker.NativeFieldInfoPtr_bar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, "bar");
			FI_ColorPicker.NativeFieldInfoPtr_colorButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, "colorButtonPrefab");
			FI_ColorPicker.NativeFieldInfoPtr_onSelectionChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, "onSelectionChanged");
			FI_ColorPicker.NativeFieldInfoPtr_onSelectionPurchased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, "onSelectionPurchased");
			FI_ColorPicker.NativeFieldInfoPtr_specificFeature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, "specificFeature");
			FI_ColorPicker.NativeFieldInfoPtr_selectionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, "selectionIndex");
			FI_ColorPicker.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Feature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, 100683395);
			FI_ColorPicker.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, 100683396);
			FI_ColorPicker.NativeMethodInfoPtr_BuyButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, 100683397);
			FI_ColorPicker.NativeMethodInfoPtr_Select_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, 100683398);
			FI_ColorPicker.NativeMethodInfoPtr_UpdateSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, 100683399);
			FI_ColorPicker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, 100683400);
		}

		// Token: 0x0600A476 RID: 42102 RVA: 0x00293784 File Offset: 0x00291984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287827, XrefRangeEnd = 287878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(Feature _feature)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_feature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FI_ColorPicker.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Feature_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A477 RID: 42103 RVA: 0x002937D4 File Offset: 0x002919D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287878, XrefRangeEnd = 287886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FI_ColorPicker.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A478 RID: 42104 RVA: 0x00293810 File Offset: 0x00291A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287886, XrefRangeEnd = 287914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuyButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_ColorPicker.NativeMethodInfoPtr_BuyButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A479 RID: 42105 RVA: 0x00293844 File Offset: 0x00291A44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287924, RefRangeEnd = 287926, XrefRangeStart = 287914, XrefRangeEnd = 287924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Select(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_ColorPicker.NativeMethodInfoPtr_Select_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A47A RID: 42106 RVA: 0x00293884 File Offset: 0x00291A84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 287987, RefRangeEnd = 287990, XrefRangeStart = 287926, XrefRangeEnd = 287987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_ColorPicker.NativeMethodInfoPtr_UpdateSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A47B RID: 42107 RVA: 0x002938B8 File Offset: 0x00291AB8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FI_ColorPicker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_ColorPicker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A47C RID: 42108 RVA: 0x000510DC File Offset: 0x0004F2DC
		public FI_ColorPicker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170032BC RID: 12988
		// (get) Token: 0x0600A47D RID: 42109 RVA: 0x002938F4 File Offset: 0x00291AF4
		// (set) Token: 0x0600A47E RID: 42110 RVA: 0x000510E5 File Offset: 0x0004F2E5
		public unsafe RectTransform colorButtonContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_colorButtonContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_colorButtonContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032BD RID: 12989
		// (get) Token: 0x0600A47F RID: 42111 RVA: 0x00293924 File Offset: 0x00291B24
		// (set) Token: 0x0600A480 RID: 42112 RVA: 0x00051104 File Offset: 0x0004F304
		public unsafe Button buyButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_buyButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_buyButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032BE RID: 12990
		// (get) Token: 0x0600A481 RID: 42113 RVA: 0x00293954 File Offset: 0x00291B54
		// (set) Token: 0x0600A482 RID: 42114 RVA: 0x00051123 File Offset: 0x0004F323
		public unsafe TextMeshProUGUI buyButtonText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_buyButtonText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_buyButtonText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032BF RID: 12991
		// (get) Token: 0x0600A483 RID: 42115 RVA: 0x00293984 File Offset: 0x00291B84
		// (set) Token: 0x0600A484 RID: 42116 RVA: 0x00051142 File Offset: 0x0004F342
		public unsafe TextMeshProUGUI colorLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_colorLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_colorLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032C0 RID: 12992
		// (get) Token: 0x0600A485 RID: 42117 RVA: 0x002939B4 File Offset: 0x00291BB4
		// (set) Token: 0x0600A486 RID: 42118 RVA: 0x00051161 File Offset: 0x0004F361
		public unsafe RectTransform bar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_bar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_bar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032C1 RID: 12993
		// (get) Token: 0x0600A487 RID: 42119 RVA: 0x002939E4 File Offset: 0x00291BE4
		// (set) Token: 0x0600A488 RID: 42120 RVA: 0x00051180 File Offset: 0x0004F380
		public unsafe GameObject colorButtonPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_colorButtonPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_colorButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032C2 RID: 12994
		// (get) Token: 0x0600A489 RID: 42121 RVA: 0x00293A14 File Offset: 0x00291C14
		// (set) Token: 0x0600A48A RID: 42122 RVA: 0x0005119F File Offset: 0x0004F39F
		public unsafe UnityEvent<ColorFeature.NamedColor> onSelectionChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_onSelectionChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<ColorFeature.NamedColor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_onSelectionChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032C3 RID: 12995
		// (get) Token: 0x0600A48B RID: 42123 RVA: 0x00293A44 File Offset: 0x00291C44
		// (set) Token: 0x0600A48C RID: 42124 RVA: 0x000511BE File Offset: 0x0004F3BE
		public unsafe UnityEvent<ColorFeature.NamedColor> onSelectionPurchased
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_onSelectionPurchased);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<ColorFeature.NamedColor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_onSelectionPurchased), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032C4 RID: 12996
		// (get) Token: 0x0600A48D RID: 42125 RVA: 0x00293A74 File Offset: 0x00291C74
		// (set) Token: 0x0600A48E RID: 42126 RVA: 0x000511DD File Offset: 0x0004F3DD
		public unsafe ColorFeature specificFeature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_specificFeature);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorFeature>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_specificFeature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032C5 RID: 12997
		// (get) Token: 0x0600A48F RID: 42127 RVA: 0x00293AA4 File Offset: 0x00291CA4
		// (set) Token: 0x0600A490 RID: 42128 RVA: 0x000511FC File Offset: 0x0004F3FC
		public unsafe int selectionIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_selectionIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_selectionIndex)) = value;
			}
		}

		// Token: 0x04006E42 RID: 28226
		private static readonly IntPtr NativeFieldInfoPtr_colorButtonContainer;

		// Token: 0x04006E43 RID: 28227
		private static readonly IntPtr NativeFieldInfoPtr_buyButton;

		// Token: 0x04006E44 RID: 28228
		private static readonly IntPtr NativeFieldInfoPtr_buyButtonText;

		// Token: 0x04006E45 RID: 28229
		private static readonly IntPtr NativeFieldInfoPtr_colorLabel;

		// Token: 0x04006E46 RID: 28230
		private static readonly IntPtr NativeFieldInfoPtr_bar;

		// Token: 0x04006E47 RID: 28231
		private static readonly IntPtr NativeFieldInfoPtr_colorButtonPrefab;

		// Token: 0x04006E48 RID: 28232
		private static readonly IntPtr NativeFieldInfoPtr_onSelectionChanged;

		// Token: 0x04006E49 RID: 28233
		private static readonly IntPtr NativeFieldInfoPtr_onSelectionPurchased;

		// Token: 0x04006E4A RID: 28234
		private static readonly IntPtr NativeFieldInfoPtr_specificFeature;

		// Token: 0x04006E4B RID: 28235
		private static readonly IntPtr NativeFieldInfoPtr_selectionIndex;

		// Token: 0x04006E4C RID: 28236
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Feature_0;

		// Token: 0x04006E4D RID: 28237
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04006E4E RID: 28238
		private static readonly IntPtr NativeMethodInfoPtr_BuyButtonClicked_Public_Void_0;

		// Token: 0x04006E4F RID: 28239
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Void_Int32_0;

		// Token: 0x04006E50 RID: 28240
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSelection_Private_Void_0;

		// Token: 0x04006E51 RID: 28241
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BC7 RID: 3015
		[ObfuscatedName("ScheduleOne.UI.Construction.Features.FI_ColorPicker+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DDDE RID: 56798 RVA: 0x0034601C File Offset: 0x0034421C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<FI_ColorPicker.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FI_ColorPicker.__c__DisplayClass10_0>.NativeClassPtr);
				FI_ColorPicker.__c__DisplayClass10_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker.__c__DisplayClass10_0>.NativeClassPtr, "index");
				FI_ColorPicker.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
				FI_ColorPicker.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_ColorPicker.__c__DisplayClass10_0>.NativeClassPtr, 100683401);
				FI_ColorPicker.__c__DisplayClass10_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_ColorPicker.__c__DisplayClass10_0>.NativeClassPtr, 100683402);
			}

			// Token: 0x0600DDDF RID: 56799 RVA: 0x00346098 File Offset: 0x00344298
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FI_ColorPicker.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_ColorPicker.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDE0 RID: 56800 RVA: 0x003460D4 File Offset: 0x003442D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287825, XrefRangeEnd = 287827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_ColorPicker.__c__DisplayClass10_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDE1 RID: 56801 RVA: 0x0006C237 File Offset: 0x0006A437
			public __c__DisplayClass10_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044BC RID: 17596
			// (get) Token: 0x0600DDE2 RID: 56802 RVA: 0x00346108 File Offset: 0x00344308
			// (set) Token: 0x0600DDE3 RID: 56803 RVA: 0x0006C240 File Offset: 0x0006A440
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.__c__DisplayClass10_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.__c__DisplayClass10_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x170044BD RID: 17597
			// (get) Token: 0x0600DDE4 RID: 56804 RVA: 0x00346130 File Offset: 0x00344330
			// (set) Token: 0x0600DDE5 RID: 56805 RVA: 0x0006C25B File Offset: 0x0006A45B
			public unsafe FI_ColorPicker __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FI_ColorPicker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009497 RID: 38039
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04009498 RID: 38040
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009499 RID: 38041
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400949A RID: 38042
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0;
		}
	}
}
