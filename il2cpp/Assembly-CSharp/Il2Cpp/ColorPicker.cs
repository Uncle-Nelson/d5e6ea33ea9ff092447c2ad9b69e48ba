using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2Cpp
{
	// Token: 0x0200001E RID: 30
	public class ColorPicker : MonoBehaviour
	{
		// Token: 0x060001D6 RID: 470 RVA: 0x00076500 File Offset: 0x00074700
		// Note: this type is marked as 'beforefieldinit'.
		static ColorPicker()
		{
			Il2CppClassPointerStore<ColorPicker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ColorPicker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr);
			ColorPicker.NativeFieldInfoPtr_mainImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, "mainImage");
			ColorPicker.NativeFieldInfoPtr_pickerIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, "pickerIcon");
			ColorPicker.NativeFieldInfoPtr_colorPreview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, "colorPreview");
			ColorPicker.NativeFieldInfoPtr__activeCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, "_activeCursor");
			ColorPicker.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, "offset");
			ColorPicker.NativeFieldInfoPtr_UIControllerDEMO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, "UIControllerDEMO");
			ColorPicker.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, "Canvas");
			ColorPicker.NativeFieldInfoPtr__findColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, "_findColor");
			ColorPicker.NativeFieldInfoPtr_realSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, "realSize");
			ColorPicker.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, 100663468);
			ColorPicker.NativeMethodInfoPtr_CursorEnter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, 100663469);
			ColorPicker.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, 100663470);
			ColorPicker.NativeMethodInfoPtr_CursorMove_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, 100663471);
			ColorPicker.NativeMethodInfoPtr_CursorPickSkin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, 100663472);
			ColorPicker.NativeMethodInfoPtr_CursorPickEye_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, 100663473);
			ColorPicker.NativeMethodInfoPtr_CursorPickHair_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, 100663474);
			ColorPicker.NativeMethodInfoPtr_CursorPickUnderpants_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, 100663475);
			ColorPicker.NativeMethodInfoPtr_CursorExit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, 100663476);
			ColorPicker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr, 100663477);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x000766AC File Offset: 0x000748AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72300, XrefRangeEnd = 72304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorPicker.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x000766E0 File Offset: 0x000748E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72304, XrefRangeEnd = 72308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CursorEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorPicker.NativeMethodInfoPtr_CursorEnter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00076714 File Offset: 0x00074914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72308, XrefRangeEnd = 72309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorPicker.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00076748 File Offset: 0x00074948
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72322, RefRangeEnd = 72323, XrefRangeStart = 72309, XrefRangeEnd = 72322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CursorMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorPicker.NativeMethodInfoPtr_CursorMove_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0007677C File Offset: 0x0007497C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72323, XrefRangeEnd = 72324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CursorPickSkin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorPicker.NativeMethodInfoPtr_CursorPickSkin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000767B0 File Offset: 0x000749B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72324, XrefRangeEnd = 72325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CursorPickEye()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorPicker.NativeMethodInfoPtr_CursorPickEye_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000767E4 File Offset: 0x000749E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72325, XrefRangeEnd = 72326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CursorPickHair()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorPicker.NativeMethodInfoPtr_CursorPickHair_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00076818 File Offset: 0x00074A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72326, XrefRangeEnd = 72327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CursorPickUnderpants()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorPicker.NativeMethodInfoPtr_CursorPickUnderpants_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0007684C File Offset: 0x00074A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72327, XrefRangeEnd = 72331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CursorExit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorPicker.NativeMethodInfoPtr_CursorExit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00076880 File Offset: 0x00074A80
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorPicker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorPicker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorPicker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00003049 File Offset: 0x00001249
		public ColorPicker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x000768BC File Offset: 0x00074ABC
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x00003052 File Offset: 0x00001252
		public unsafe Image mainImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr_mainImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr_mainImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x000768EC File Offset: 0x00074AEC
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x00003071 File Offset: 0x00001271
		public unsafe RectTransform pickerIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr_pickerIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr_pickerIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x0007691C File Offset: 0x00074B1C
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x00003090 File Offset: 0x00001290
		public unsafe Image colorPreview
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr_colorPreview);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr_colorPreview), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x0007694C File Offset: 0x00074B4C
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x000030AF File Offset: 0x000012AF
		public unsafe bool _activeCursor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr__activeCursor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr__activeCursor)) = value;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001EA RID: 490 RVA: 0x00076974 File Offset: 0x00074B74
		// (set) Token: 0x060001EB RID: 491 RVA: 0x000030CA File Offset: 0x000012CA
		public unsafe Vector2 offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr_offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr_offset)) = value;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001EC RID: 492 RVA: 0x0007699C File Offset: 0x00074B9C
		// (set) Token: 0x060001ED RID: 493 RVA: 0x000030E5 File Offset: 0x000012E5
		public unsafe UIControllerDEMO UIControllerDEMO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr_UIControllerDEMO);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIControllerDEMO>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr_UIControllerDEMO), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001EE RID: 494 RVA: 0x000769CC File Offset: 0x00074BCC
		// (set) Token: 0x060001EF RID: 495 RVA: 0x00003104 File Offset: 0x00001304
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x000769FC File Offset: 0x00074BFC
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x00003123 File Offset: 0x00001323
		public unsafe Color _findColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr__findColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr__findColor)) = value;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00076A24 File Offset: 0x00074C24
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x0000313E File Offset: 0x0000133E
		public unsafe Vector2 realSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr_realSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorPicker.NativeFieldInfoPtr_realSize)) = value;
			}
		}

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeFieldInfoPtr_mainImage;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeFieldInfoPtr_pickerIcon;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeFieldInfoPtr_colorPreview;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeFieldInfoPtr__activeCursor;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeFieldInfoPtr_offset;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeFieldInfoPtr_UIControllerDEMO;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeFieldInfoPtr__findColor;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeFieldInfoPtr_realSize;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_CursorEnter_Public_Void_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_CursorMove_Public_Void_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_CursorPickSkin_Public_Void_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_CursorPickEye_Public_Void_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_CursorPickHair_Public_Void_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_CursorPickUnderpants_Public_Void_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_CursorExit_Public_Void_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
