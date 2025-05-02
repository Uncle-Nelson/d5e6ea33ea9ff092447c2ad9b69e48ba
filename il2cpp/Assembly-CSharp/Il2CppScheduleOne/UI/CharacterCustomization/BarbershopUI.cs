using System;
using Il2CppHSVPicker;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.CharacterCustomization
{
	// Token: 0x020006F7 RID: 1783
	public class BarbershopUI : CharacterCustomizationUI
	{
		// Token: 0x06009FDF RID: 40927 RVA: 0x00284B2C File Offset: 0x00282D2C
		// Note: this type is marked as 'beforefieldinit'.
		static BarbershopUI()
		{
			Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCustomization", "BarbershopUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr);
			BarbershopUI.NativeFieldInfoPtr_ColorPicker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, "ColorPicker");
			BarbershopUI.NativeFieldInfoPtr_ApplyColorButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, "ApplyColorButton");
			BarbershopUI.NativeFieldInfoPtr_appliedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, "appliedColor");
			BarbershopUI.NativeMethodInfoPtr_IsOptionCurrentlyApplied_Public_Virtual_Boolean_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, 100682858);
			BarbershopUI.NativeMethodInfoPtr_OptionSelected_Public_Virtual_Void_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, 100682859);
			BarbershopUI.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, 100682860);
			BarbershopUI.NativeMethodInfoPtr_Open_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, 100682861);
			BarbershopUI.NativeMethodInfoPtr_ColorFieldChanged_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, 100682862);
			BarbershopUI.NativeMethodInfoPtr_ApplyColorChange_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, 100682863);
			BarbershopUI.NativeMethodInfoPtr_RevertColorChange_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, 100682864);
			BarbershopUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, 100682865);
		}

		// Token: 0x06009FE0 RID: 40928 RVA: 0x00284C38 File Offset: 0x00282E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282137, XrefRangeEnd = 282139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsOptionCurrentlyApplied(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BarbershopUI.NativeMethodInfoPtr_IsOptionCurrentlyApplied_Public_Virtual_Boolean_CharacterCustomizationOption_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009FE1 RID: 40929 RVA: 0x00284C90 File Offset: 0x00282E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282139, XrefRangeEnd = 282145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OptionSelected(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BarbershopUI.NativeMethodInfoPtr_OptionSelected_Public_Virtual_Void_CharacterCustomizationOption_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FE2 RID: 40930 RVA: 0x00284CE0 File Offset: 0x00282EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282145, XrefRangeEnd = 282153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BarbershopUI.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FE3 RID: 40931 RVA: 0x00284D1C File Offset: 0x00282F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282153, XrefRangeEnd = 282157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BarbershopUI.NativeMethodInfoPtr_Open_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FE4 RID: 40932 RVA: 0x00284D58 File Offset: 0x00282F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282157, XrefRangeEnd = 282161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ColorFieldChanged(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BarbershopUI.NativeMethodInfoPtr_ColorFieldChanged_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FE5 RID: 40933 RVA: 0x00284D98 File Offset: 0x00282F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282161, XrefRangeEnd = 282165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyColorChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BarbershopUI.NativeMethodInfoPtr_ApplyColorChange_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FE6 RID: 40934 RVA: 0x00284DCC File Offset: 0x00282FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282165, XrefRangeEnd = 282170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RevertColorChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BarbershopUI.NativeMethodInfoPtr_RevertColorChange_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FE7 RID: 40935 RVA: 0x00284E00 File Offset: 0x00283000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282170, XrefRangeEnd = 282175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BarbershopUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BarbershopUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FE8 RID: 40936 RVA: 0x0004E92A File Offset: 0x0004CB2A
		public BarbershopUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003143 RID: 12611
		// (get) Token: 0x06009FE9 RID: 40937 RVA: 0x00284E3C File Offset: 0x0028303C
		// (set) Token: 0x06009FEA RID: 40938 RVA: 0x0004E933 File Offset: 0x0004CB33
		public unsafe ColorPicker ColorPicker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarbershopUI.NativeFieldInfoPtr_ColorPicker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorPicker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarbershopUI.NativeFieldInfoPtr_ColorPicker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003144 RID: 12612
		// (get) Token: 0x06009FEB RID: 40939 RVA: 0x00284E6C File Offset: 0x0028306C
		// (set) Token: 0x06009FEC RID: 40940 RVA: 0x0004E952 File Offset: 0x0004CB52
		public unsafe Button ApplyColorButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarbershopUI.NativeFieldInfoPtr_ApplyColorButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarbershopUI.NativeFieldInfoPtr_ApplyColorButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003145 RID: 12613
		// (get) Token: 0x06009FED RID: 40941 RVA: 0x00284E9C File Offset: 0x0028309C
		// (set) Token: 0x06009FEE RID: 40942 RVA: 0x0004E971 File Offset: 0x0004CB71
		public unsafe Color appliedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarbershopUI.NativeFieldInfoPtr_appliedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarbershopUI.NativeFieldInfoPtr_appliedColor)) = value;
			}
		}

		// Token: 0x04006B36 RID: 27446
		private static readonly IntPtr NativeFieldInfoPtr_ColorPicker;

		// Token: 0x04006B37 RID: 27447
		private static readonly IntPtr NativeFieldInfoPtr_ApplyColorButton;

		// Token: 0x04006B38 RID: 27448
		private static readonly IntPtr NativeFieldInfoPtr_appliedColor;

		// Token: 0x04006B39 RID: 27449
		private static readonly IntPtr NativeMethodInfoPtr_IsOptionCurrentlyApplied_Public_Virtual_Boolean_CharacterCustomizationOption_0;

		// Token: 0x04006B3A RID: 27450
		private static readonly IntPtr NativeMethodInfoPtr_OptionSelected_Public_Virtual_Void_CharacterCustomizationOption_0;

		// Token: 0x04006B3B RID: 27451
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04006B3C RID: 27452
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_Void_0;

		// Token: 0x04006B3D RID: 27453
		private static readonly IntPtr NativeMethodInfoPtr_ColorFieldChanged_Public_Void_Color_0;

		// Token: 0x04006B3E RID: 27454
		private static readonly IntPtr NativeMethodInfoPtr_ApplyColorChange_Public_Void_0;

		// Token: 0x04006B3F RID: 27455
		private static readonly IntPtr NativeMethodInfoPtr_RevertColorChange_Public_Void_0;

		// Token: 0x04006B40 RID: 27456
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
