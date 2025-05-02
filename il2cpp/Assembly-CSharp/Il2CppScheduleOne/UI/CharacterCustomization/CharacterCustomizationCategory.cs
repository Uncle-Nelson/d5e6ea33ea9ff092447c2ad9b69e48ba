using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.CharacterCustomization
{
	// Token: 0x020006F8 RID: 1784
	public class CharacterCustomizationCategory : MonoBehaviour
	{
		// Token: 0x06009FEF RID: 40943 RVA: 0x00284EC4 File Offset: 0x002830C4
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCustomizationCategory()
		{
			Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCustomization", "CharacterCustomizationCategory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr);
			CharacterCustomizationCategory.NativeFieldInfoPtr_CategoryName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "CategoryName");
			CharacterCustomizationCategory.NativeFieldInfoPtr_TitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "TitleText");
			CharacterCustomizationCategory.NativeFieldInfoPtr_BackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "BackButton");
			CharacterCustomizationCategory.NativeFieldInfoPtr_ScrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "ScrollRect");
			CharacterCustomizationCategory.NativeFieldInfoPtr_ui = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "ui");
			CharacterCustomizationCategory.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "options");
			CharacterCustomizationCategory.NativeFieldInfoPtr_onOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "onOpen");
			CharacterCustomizationCategory.NativeFieldInfoPtr_onClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "onClose");
			CharacterCustomizationCategory.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, 100682866);
			CharacterCustomizationCategory.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, 100682867);
			CharacterCustomizationCategory.NativeMethodInfoPtr_Back_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, 100682868);
			CharacterCustomizationCategory.NativeMethodInfoPtr_OptionSelected_Private_Void_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, 100682869);
			CharacterCustomizationCategory.NativeMethodInfoPtr_OptionDeselected_Private_Void_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, 100682870);
			CharacterCustomizationCategory.NativeMethodInfoPtr_OptionPurchased_Private_Void_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, 100682871);
			CharacterCustomizationCategory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, 100682872);
		}

		// Token: 0x06009FF0 RID: 40944 RVA: 0x00285020 File Offset: 0x00283220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282192, XrefRangeEnd = 282239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FF1 RID: 40945 RVA: 0x00285054 File Offset: 0x00283254
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282252, RefRangeEnd = 282253, XrefRangeStart = 282239, XrefRangeEnd = 282252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FF2 RID: 40946 RVA: 0x00285088 File Offset: 0x00283288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282253, XrefRangeEnd = 282258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Back()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.NativeMethodInfoPtr_Back_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FF3 RID: 40947 RVA: 0x002850BC File Offset: 0x002832BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282258, XrefRangeEnd = 282264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptionSelected(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.NativeMethodInfoPtr_OptionSelected_Private_Void_CharacterCustomizationOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FF4 RID: 40948 RVA: 0x00285100 File Offset: 0x00283300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282264, XrefRangeEnd = 282265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptionDeselected(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.NativeMethodInfoPtr_OptionDeselected_Private_Void_CharacterCustomizationOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FF5 RID: 40949 RVA: 0x00285144 File Offset: 0x00283344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282265, XrefRangeEnd = 282275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptionPurchased(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.NativeMethodInfoPtr_OptionPurchased_Private_Void_CharacterCustomizationOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FF6 RID: 40950 RVA: 0x00285188 File Offset: 0x00283388
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCustomizationCategory() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FF7 RID: 40951 RVA: 0x0004E98C File Offset: 0x0004CB8C
		public CharacterCustomizationCategory(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003146 RID: 12614
		// (get) Token: 0x06009FF8 RID: 40952 RVA: 0x002851C4 File Offset: 0x002833C4
		// (set) Token: 0x06009FF9 RID: 40953 RVA: 0x0004E995 File Offset: 0x0004CB95
		public unsafe string CategoryName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_CategoryName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_CategoryName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003147 RID: 12615
		// (get) Token: 0x06009FFA RID: 40954 RVA: 0x002851EC File Offset: 0x002833EC
		// (set) Token: 0x06009FFB RID: 40955 RVA: 0x0004E9B4 File Offset: 0x0004CBB4
		public unsafe TextMeshProUGUI TitleText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_TitleText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_TitleText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003148 RID: 12616
		// (get) Token: 0x06009FFC RID: 40956 RVA: 0x0028521C File Offset: 0x0028341C
		// (set) Token: 0x06009FFD RID: 40957 RVA: 0x0004E9D3 File Offset: 0x0004CBD3
		public unsafe Button BackButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_BackButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_BackButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003149 RID: 12617
		// (get) Token: 0x06009FFE RID: 40958 RVA: 0x0028524C File Offset: 0x0028344C
		// (set) Token: 0x06009FFF RID: 40959 RVA: 0x0004E9F2 File Offset: 0x0004CBF2
		public unsafe ScrollRect ScrollRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_ScrollRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_ScrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700314A RID: 12618
		// (get) Token: 0x0600A000 RID: 40960 RVA: 0x0028527C File Offset: 0x0028347C
		// (set) Token: 0x0600A001 RID: 40961 RVA: 0x0004EA11 File Offset: 0x0004CC11
		public unsafe CharacterCustomizationUI ui
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_ui);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomizationUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_ui), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700314B RID: 12619
		// (get) Token: 0x0600A002 RID: 40962 RVA: 0x002852AC File Offset: 0x002834AC
		// (set) Token: 0x0600A003 RID: 40963 RVA: 0x0004EA30 File Offset: 0x0004CC30
		public unsafe Il2CppReferenceArray<CharacterCustomizationOption> options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CharacterCustomizationOption>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700314C RID: 12620
		// (get) Token: 0x0600A004 RID: 40964 RVA: 0x002852DC File Offset: 0x002834DC
		// (set) Token: 0x0600A005 RID: 40965 RVA: 0x0004EA4F File Offset: 0x0004CC4F
		public unsafe UnityEvent onOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_onOpen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_onOpen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700314D RID: 12621
		// (get) Token: 0x0600A006 RID: 40966 RVA: 0x0028530C File Offset: 0x0028350C
		// (set) Token: 0x0600A007 RID: 40967 RVA: 0x0004EA6E File Offset: 0x0004CC6E
		public unsafe UnityEvent onClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_onClose);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_onClose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006B41 RID: 27457
		private static readonly IntPtr NativeFieldInfoPtr_CategoryName;

		// Token: 0x04006B42 RID: 27458
		private static readonly IntPtr NativeFieldInfoPtr_TitleText;

		// Token: 0x04006B43 RID: 27459
		private static readonly IntPtr NativeFieldInfoPtr_BackButton;

		// Token: 0x04006B44 RID: 27460
		private static readonly IntPtr NativeFieldInfoPtr_ScrollRect;

		// Token: 0x04006B45 RID: 27461
		private static readonly IntPtr NativeFieldInfoPtr_ui;

		// Token: 0x04006B46 RID: 27462
		private static readonly IntPtr NativeFieldInfoPtr_options;

		// Token: 0x04006B47 RID: 27463
		private static readonly IntPtr NativeFieldInfoPtr_onOpen;

		// Token: 0x04006B48 RID: 27464
		private static readonly IntPtr NativeFieldInfoPtr_onClose;

		// Token: 0x04006B49 RID: 27465
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006B4A RID: 27466
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04006B4B RID: 27467
		private static readonly IntPtr NativeMethodInfoPtr_Back_Public_Void_0;

		// Token: 0x04006B4C RID: 27468
		private static readonly IntPtr NativeMethodInfoPtr_OptionSelected_Private_Void_CharacterCustomizationOption_0;

		// Token: 0x04006B4D RID: 27469
		private static readonly IntPtr NativeMethodInfoPtr_OptionDeselected_Private_Void_CharacterCustomizationOption_0;

		// Token: 0x04006B4E RID: 27470
		private static readonly IntPtr NativeMethodInfoPtr_OptionPurchased_Private_Void_CharacterCustomizationOption_0;

		// Token: 0x04006B4F RID: 27471
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BA7 RID: 2983
		[ObfuscatedName("ScheduleOne.UI.CharacterCustomization.CharacterCustomizationCategory+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DCBE RID: 56510 RVA: 0x00342D2C File Offset: 0x00340F2C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass8_0>.NativeClassPtr);
				CharacterCustomizationCategory.__c__DisplayClass8_0.NativeFieldInfoPtr_option = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass8_0>.NativeClassPtr, "option");
				CharacterCustomizationCategory.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				CharacterCustomizationCategory.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass8_0>.NativeClassPtr, 100682873);
				CharacterCustomizationCategory.__c__DisplayClass8_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass8_0>.NativeClassPtr, 100682874);
				CharacterCustomizationCategory.__c__DisplayClass8_0.NativeMethodInfoPtr__Awake_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass8_0>.NativeClassPtr, 100682875);
				CharacterCustomizationCategory.__c__DisplayClass8_0.NativeMethodInfoPtr__Awake_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass8_0>.NativeClassPtr, 100682876);
			}

			// Token: 0x0600DCBF RID: 56511 RVA: 0x00342DD0 File Offset: 0x00340FD0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCC0 RID: 56512 RVA: 0x00342E0C File Offset: 0x0034100C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282175, XrefRangeEnd = 282181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.__c__DisplayClass8_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCC1 RID: 56513 RVA: 0x00342E40 File Offset: 0x00341040
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282181, XrefRangeEnd = 282182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.__c__DisplayClass8_0.NativeMethodInfoPtr__Awake_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCC2 RID: 56514 RVA: 0x00342E74 File Offset: 0x00341074
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282182, XrefRangeEnd = 282192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.__c__DisplayClass8_0.NativeMethodInfoPtr__Awake_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCC3 RID: 56515 RVA: 0x0006B92F File Offset: 0x00069B2F
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700446C RID: 17516
			// (get) Token: 0x0600DCC4 RID: 56516 RVA: 0x00342EA8 File Offset: 0x003410A8
			// (set) Token: 0x0600DCC5 RID: 56517 RVA: 0x0006B938 File Offset: 0x00069B38
			public unsafe CharacterCustomizationOption option
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.__c__DisplayClass8_0.NativeFieldInfoPtr_option);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomizationOption>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.__c__DisplayClass8_0.NativeFieldInfoPtr_option), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700446D RID: 17517
			// (get) Token: 0x0600DCC6 RID: 56518 RVA: 0x00342ED8 File Offset: 0x003410D8
			// (set) Token: 0x0600DCC7 RID: 56519 RVA: 0x0006B957 File Offset: 0x00069B57
			public unsafe CharacterCustomizationCategory __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomizationCategory>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040093F0 RID: 37872
			private static readonly IntPtr NativeFieldInfoPtr_option;

			// Token: 0x040093F1 RID: 37873
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040093F2 RID: 37874
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040093F3 RID: 37875
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Void_0;

			// Token: 0x040093F4 RID: 37876
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__1_Internal_Void_0;

			// Token: 0x040093F5 RID: 37877
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__2_Internal_Void_0;
		}
	}
}
