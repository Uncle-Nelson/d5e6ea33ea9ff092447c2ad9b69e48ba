using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Clothing;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.CharacterCreator
{
	// Token: 0x020006FD RID: 1789
	public class CharacterCreatorColor : CharacterCreatorField<Color>
	{
		// Token: 0x0600A08D RID: 41101 RVA: 0x00286CE0 File Offset: 0x00284EE0
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCreatorColor()
		{
			Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCreator", "CharacterCreatorColor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr);
			CharacterCreatorColor.NativeFieldInfoPtr_ClothingColorsToUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, "ClothingColorsToUse");
			CharacterCreatorColor.NativeFieldInfoPtr_OptionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, "OptionContainer");
			CharacterCreatorColor.NativeFieldInfoPtr_UseClothingColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, "UseClothingColors");
			CharacterCreatorColor.NativeFieldInfoPtr_Colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, "Colors");
			CharacterCreatorColor.NativeFieldInfoPtr_OptionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, "OptionPrefab");
			CharacterCreatorColor.NativeFieldInfoPtr_optionButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, "optionButtons");
			CharacterCreatorColor.NativeFieldInfoPtr_selectedButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, "selectedButton");
			CharacterCreatorColor.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, 100682936);
			CharacterCreatorColor.NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, 100682937);
			CharacterCreatorColor.NativeMethodInfoPtr_OptionClicked_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, 100682938);
			CharacterCreatorColor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, 100682939);
		}

		// Token: 0x0600A08E RID: 41102 RVA: 0x00286DEC File Offset: 0x00284FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282721, XrefRangeEnd = 282780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorColor.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A08F RID: 41103 RVA: 0x00286E28 File Offset: 0x00285028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282780, XrefRangeEnd = 282804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorColor.NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A090 RID: 41104 RVA: 0x00286E64 File Offset: 0x00285064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282804, XrefRangeEnd = 282815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptionClicked(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorColor.NativeMethodInfoPtr_OptionClicked_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A091 RID: 41105 RVA: 0x00286EA4 File Offset: 0x002850A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282815, XrefRangeEnd = 282825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCreatorColor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorColor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A092 RID: 41106 RVA: 0x0004EF65 File Offset: 0x0004D165
		public CharacterCreatorColor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700317A RID: 12666
		// (get) Token: 0x0600A093 RID: 41107 RVA: 0x00286EE0 File Offset: 0x002850E0
		// (set) Token: 0x0600A094 RID: 41108 RVA: 0x0004EF6E File Offset: 0x0004D16E
		public unsafe static Il2CppStructArray<EClothingColor> ClothingColorsToUse
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CharacterCreatorColor.NativeFieldInfoPtr_ClothingColorsToUse, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<EClothingColor>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CharacterCreatorColor.NativeFieldInfoPtr_ClothingColorsToUse, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700317B RID: 12667
		// (get) Token: 0x0600A095 RID: 41109 RVA: 0x00286F08 File Offset: 0x00285108
		// (set) Token: 0x0600A096 RID: 41110 RVA: 0x0004EF80 File Offset: 0x0004D180
		public unsafe RectTransform OptionContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_OptionContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_OptionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700317C RID: 12668
		// (get) Token: 0x0600A097 RID: 41111 RVA: 0x00286F38 File Offset: 0x00285138
		// (set) Token: 0x0600A098 RID: 41112 RVA: 0x0004EF9F File Offset: 0x0004D19F
		public unsafe bool UseClothingColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_UseClothingColors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_UseClothingColors)) = value;
			}
		}

		// Token: 0x1700317D RID: 12669
		// (get) Token: 0x0600A099 RID: 41113 RVA: 0x00286F60 File Offset: 0x00285160
		// (set) Token: 0x0600A09A RID: 41114 RVA: 0x0004EFBA File Offset: 0x0004D1BA
		public unsafe List<Color> Colors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_Colors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_Colors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700317E RID: 12670
		// (get) Token: 0x0600A09B RID: 41115 RVA: 0x00286F90 File Offset: 0x00285190
		// (set) Token: 0x0600A09C RID: 41116 RVA: 0x0004EFD9 File Offset: 0x0004D1D9
		public unsafe GameObject OptionPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_OptionPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_OptionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700317F RID: 12671
		// (get) Token: 0x0600A09D RID: 41117 RVA: 0x00286FC0 File Offset: 0x002851C0
		// (set) Token: 0x0600A09E RID: 41118 RVA: 0x0004EFF8 File Offset: 0x0004D1F8
		public unsafe List<Button> optionButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_optionButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_optionButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003180 RID: 12672
		// (get) Token: 0x0600A09F RID: 41119 RVA: 0x00286FF0 File Offset: 0x002851F0
		// (set) Token: 0x0600A0A0 RID: 41120 RVA: 0x0004F017 File Offset: 0x0004D217
		public unsafe Button selectedButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_selectedButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.NativeFieldInfoPtr_selectedButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006BA5 RID: 27557
		private static readonly IntPtr NativeFieldInfoPtr_ClothingColorsToUse;

		// Token: 0x04006BA6 RID: 27558
		private static readonly IntPtr NativeFieldInfoPtr_OptionContainer;

		// Token: 0x04006BA7 RID: 27559
		private static readonly IntPtr NativeFieldInfoPtr_UseClothingColors;

		// Token: 0x04006BA8 RID: 27560
		private static readonly IntPtr NativeFieldInfoPtr_Colors;

		// Token: 0x04006BA9 RID: 27561
		private static readonly IntPtr NativeFieldInfoPtr_OptionPrefab;

		// Token: 0x04006BAA RID: 27562
		private static readonly IntPtr NativeFieldInfoPtr_optionButtons;

		// Token: 0x04006BAB RID: 27563
		private static readonly IntPtr NativeFieldInfoPtr_selectedButton;

		// Token: 0x04006BAC RID: 27564
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006BAD RID: 27565
		private static readonly IntPtr NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0;

		// Token: 0x04006BAE RID: 27566
		private static readonly IntPtr NativeMethodInfoPtr_OptionClicked_Public_Void_Color_0;

		// Token: 0x04006BAF RID: 27567
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BAB RID: 2987
		[ObfuscatedName("ScheduleOne.UI.CharacterCreator.CharacterCreatorColor+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DCEC RID: 56556 RVA: 0x003435FC File Offset: 0x003417FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<CharacterCreatorColor.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCreatorColor>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorColor.__c__DisplayClass7_0>.NativeClassPtr);
				CharacterCreatorColor.__c__DisplayClass7_0.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor.__c__DisplayClass7_0>.NativeClassPtr, "col");
				CharacterCreatorColor.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorColor.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				CharacterCreatorColor.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorColor.__c__DisplayClass7_0>.NativeClassPtr, 100682941);
				CharacterCreatorColor.__c__DisplayClass7_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorColor.__c__DisplayClass7_0>.NativeClassPtr, 100682942);
			}

			// Token: 0x0600DCED RID: 56557 RVA: 0x00343678 File Offset: 0x00341878
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorColor.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorColor.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCEE RID: 56558 RVA: 0x003436B4 File Offset: 0x003418B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282719, XrefRangeEnd = 282721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorColor.__c__DisplayClass7_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCEF RID: 56559 RVA: 0x0006BA81 File Offset: 0x00069C81
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700447A RID: 17530
			// (get) Token: 0x0600DCF0 RID: 56560 RVA: 0x003436E8 File Offset: 0x003418E8
			// (set) Token: 0x0600DCF1 RID: 56561 RVA: 0x0006BA8A File Offset: 0x00069C8A
			public unsafe Color col
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.__c__DisplayClass7_0.NativeFieldInfoPtr_col);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.__c__DisplayClass7_0.NativeFieldInfoPtr_col)) = value;
				}
			}

			// Token: 0x1700447B RID: 17531
			// (get) Token: 0x0600DCF2 RID: 56562 RVA: 0x00343710 File Offset: 0x00341910
			// (set) Token: 0x0600DCF3 RID: 56563 RVA: 0x0006BAA5 File Offset: 0x00069CA5
			public unsafe CharacterCreatorColor __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCreatorColor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorColor.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400940C RID: 37900
			private static readonly IntPtr NativeFieldInfoPtr_col;

			// Token: 0x0400940D RID: 37901
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400940E RID: 37902
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400940F RID: 37903
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Void_0;
		}
	}
}
