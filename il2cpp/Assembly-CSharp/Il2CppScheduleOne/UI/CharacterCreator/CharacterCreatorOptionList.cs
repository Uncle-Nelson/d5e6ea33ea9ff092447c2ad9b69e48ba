using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Clothing;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.CharacterCreator
{
	// Token: 0x02000700 RID: 1792
	public class CharacterCreatorOptionList : CharacterCreatorField<string>
	{
		// Token: 0x0600A0C0 RID: 41152 RVA: 0x0028773C File Offset: 0x0028593C
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCreatorOptionList()
		{
			Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCreator", "CharacterCreatorOptionList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr);
			CharacterCreatorOptionList.NativeFieldInfoPtr_OptionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "OptionContainer");
			CharacterCreatorOptionList.NativeFieldInfoPtr_CanSelectNone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "CanSelectNone");
			CharacterCreatorOptionList.NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "Options");
			CharacterCreatorOptionList.NativeFieldInfoPtr_OptionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "OptionPrefab");
			CharacterCreatorOptionList.NativeFieldInfoPtr_optionButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "optionButtons");
			CharacterCreatorOptionList.NativeFieldInfoPtr_selectedButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "selectedButton");
			CharacterCreatorOptionList.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, 100682957);
			CharacterCreatorOptionList.NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, 100682958);
			CharacterCreatorOptionList.NativeMethodInfoPtr_OptionClicked_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, 100682959);
			CharacterCreatorOptionList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, 100682960);
		}

		// Token: 0x0600A0C1 RID: 41153 RVA: 0x00287834 File Offset: 0x00285A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282887, XrefRangeEnd = 282945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorOptionList.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0C2 RID: 41154 RVA: 0x00287870 File Offset: 0x00285A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282945, XrefRangeEnd = 282972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorOptionList.NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0C3 RID: 41155 RVA: 0x002878AC File Offset: 0x00285AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282972, XrefRangeEnd = 282991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptionClicked(string option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorOptionList.NativeMethodInfoPtr_OptionClicked_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0C4 RID: 41156 RVA: 0x002878F0 File Offset: 0x00285AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282991, XrefRangeEnd = 283001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCreatorOptionList() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorOptionList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0C5 RID: 41157 RVA: 0x0004F11D File Offset: 0x0004D31D
		public CharacterCreatorOptionList(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700318A RID: 12682
		// (get) Token: 0x0600A0C6 RID: 41158 RVA: 0x0028792C File Offset: 0x00285B2C
		// (set) Token: 0x0600A0C7 RID: 41159 RVA: 0x0004F126 File Offset: 0x0004D326
		public unsafe RectTransform OptionContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_OptionContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_OptionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700318B RID: 12683
		// (get) Token: 0x0600A0C8 RID: 41160 RVA: 0x0028795C File Offset: 0x00285B5C
		// (set) Token: 0x0600A0C9 RID: 41161 RVA: 0x0004F145 File Offset: 0x0004D345
		public unsafe bool CanSelectNone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_CanSelectNone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_CanSelectNone)) = value;
			}
		}

		// Token: 0x1700318C RID: 12684
		// (get) Token: 0x0600A0CA RID: 41162 RVA: 0x00287984 File Offset: 0x00285B84
		// (set) Token: 0x0600A0CB RID: 41163 RVA: 0x0004F160 File Offset: 0x0004D360
		public unsafe List<CharacterCreatorOptionList.Option> Options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_Options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CharacterCreatorOptionList.Option>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700318D RID: 12685
		// (get) Token: 0x0600A0CC RID: 41164 RVA: 0x002879B4 File Offset: 0x00285BB4
		// (set) Token: 0x0600A0CD RID: 41165 RVA: 0x0004F17F File Offset: 0x0004D37F
		public unsafe GameObject OptionPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_OptionPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_OptionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700318E RID: 12686
		// (get) Token: 0x0600A0CE RID: 41166 RVA: 0x002879E4 File Offset: 0x00285BE4
		// (set) Token: 0x0600A0CF RID: 41167 RVA: 0x0004F19E File Offset: 0x0004D39E
		public unsafe List<Button> optionButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_optionButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_optionButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700318F RID: 12687
		// (get) Token: 0x0600A0D0 RID: 41168 RVA: 0x00287A14 File Offset: 0x00285C14
		// (set) Token: 0x0600A0D1 RID: 41169 RVA: 0x0004F1BD File Offset: 0x0004D3BD
		public unsafe Button selectedButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_selectedButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.NativeFieldInfoPtr_selectedButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006BC3 RID: 27587
		private static readonly IntPtr NativeFieldInfoPtr_OptionContainer;

		// Token: 0x04006BC4 RID: 27588
		private static readonly IntPtr NativeFieldInfoPtr_CanSelectNone;

		// Token: 0x04006BC5 RID: 27589
		private static readonly IntPtr NativeFieldInfoPtr_Options;

		// Token: 0x04006BC6 RID: 27590
		private static readonly IntPtr NativeFieldInfoPtr_OptionPrefab;

		// Token: 0x04006BC7 RID: 27591
		private static readonly IntPtr NativeFieldInfoPtr_optionButtons;

		// Token: 0x04006BC8 RID: 27592
		private static readonly IntPtr NativeFieldInfoPtr_selectedButton;

		// Token: 0x04006BC9 RID: 27593
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006BCA RID: 27594
		private static readonly IntPtr NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0;

		// Token: 0x04006BCB RID: 27595
		private static readonly IntPtr NativeMethodInfoPtr_OptionClicked_Public_Void_String_0;

		// Token: 0x04006BCC RID: 27596
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BAD RID: 2989
		[Serializable]
		public class Option : Il2CppSystem.Object
		{
			// Token: 0x0600DCFD RID: 56573 RVA: 0x003438CC File Offset: 0x00341ACC
			// Note: this type is marked as 'beforefieldinit'.
			static Option()
			{
				Il2CppClassPointerStore<CharacterCreatorOptionList.Option>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "Option");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorOptionList.Option>.NativeClassPtr);
				CharacterCreatorOptionList.Option.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList.Option>.NativeClassPtr, "Label");
				CharacterCreatorOptionList.Option.NativeFieldInfoPtr_AssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList.Option>.NativeClassPtr, "AssetPath");
				CharacterCreatorOptionList.Option.NativeFieldInfoPtr_ClothingItemEquivalent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList.Option>.NativeClassPtr, "ClothingItemEquivalent");
				CharacterCreatorOptionList.Option.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList.Option>.NativeClassPtr, 100682961);
			}

			// Token: 0x0600DCFE RID: 56574 RVA: 0x00343948 File Offset: 0x00341B48
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Option() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorOptionList.Option>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorOptionList.Option.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCFF RID: 56575 RVA: 0x0006BB0B File Offset: 0x00069D0B
			public Option(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700447E RID: 17534
			// (get) Token: 0x0600DD00 RID: 56576 RVA: 0x00343984 File Offset: 0x00341B84
			// (set) Token: 0x0600DD01 RID: 56577 RVA: 0x0006BB14 File Offset: 0x00069D14
			public unsafe string Label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.Option.NativeFieldInfoPtr_Label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.Option.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700447F RID: 17535
			// (get) Token: 0x0600DD02 RID: 56578 RVA: 0x003439AC File Offset: 0x00341BAC
			// (set) Token: 0x0600DD03 RID: 56579 RVA: 0x0006BB33 File Offset: 0x00069D33
			public unsafe string AssetPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.Option.NativeFieldInfoPtr_AssetPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.Option.NativeFieldInfoPtr_AssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004480 RID: 17536
			// (get) Token: 0x0600DD04 RID: 56580 RVA: 0x003439D4 File Offset: 0x00341BD4
			// (set) Token: 0x0600DD05 RID: 56581 RVA: 0x0006BB52 File Offset: 0x00069D52
			public unsafe ClothingDefinition ClothingItemEquivalent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.Option.NativeFieldInfoPtr_ClothingItemEquivalent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClothingDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.Option.NativeFieldInfoPtr_ClothingItemEquivalent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009415 RID: 37909
			private static readonly IntPtr NativeFieldInfoPtr_Label;

			// Token: 0x04009416 RID: 37910
			private static readonly IntPtr NativeFieldInfoPtr_AssetPath;

			// Token: 0x04009417 RID: 37911
			private static readonly IntPtr NativeFieldInfoPtr_ClothingItemEquivalent;

			// Token: 0x04009418 RID: 37912
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000BAE RID: 2990
		[ObfuscatedName("ScheduleOne.UI.CharacterCreator.CharacterCreatorOptionList+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DD06 RID: 56582 RVA: 0x00343A04 File Offset: 0x00341C04
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass7_0>.NativeClassPtr);
				CharacterCreatorOptionList.__c__DisplayClass7_0.NativeFieldInfoPtr_option = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass7_0>.NativeClassPtr, "option");
				CharacterCreatorOptionList.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				CharacterCreatorOptionList.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass7_0>.NativeClassPtr, 100682962);
				CharacterCreatorOptionList.__c__DisplayClass7_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass7_0>.NativeClassPtr, 100682963);
			}

			// Token: 0x0600DD07 RID: 56583 RVA: 0x00343A80 File Offset: 0x00341C80
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorOptionList.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD08 RID: 56584 RVA: 0x00343ABC File Offset: 0x00341CBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282868, XrefRangeEnd = 282887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorOptionList.__c__DisplayClass7_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD09 RID: 56585 RVA: 0x0006BB71 File Offset: 0x00069D71
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004481 RID: 17537
			// (get) Token: 0x0600DD0A RID: 56586 RVA: 0x00343AF0 File Offset: 0x00341CF0
			// (set) Token: 0x0600DD0B RID: 56587 RVA: 0x0006BB7A File Offset: 0x00069D7A
			public unsafe string option
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.__c__DisplayClass7_0.NativeFieldInfoPtr_option);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.__c__DisplayClass7_0.NativeFieldInfoPtr_option), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004482 RID: 17538
			// (get) Token: 0x0600DD0C RID: 56588 RVA: 0x00343B18 File Offset: 0x00341D18
			// (set) Token: 0x0600DD0D RID: 56589 RVA: 0x0006BB99 File Offset: 0x00069D99
			public unsafe CharacterCreatorOptionList __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCreatorOptionList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009419 RID: 37913
			private static readonly IntPtr NativeFieldInfoPtr_option;

			// Token: 0x0400941A RID: 37914
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400941B RID: 37915
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400941C RID: 37916
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Void_0;
		}

		// Token: 0x02000BAF RID: 2991
		[ObfuscatedName("ScheduleOne.UI.CharacterCreator.CharacterCreatorOptionList+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DD0E RID: 56590 RVA: 0x00343B48 File Offset: 0x00341D48
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCreatorOptionList>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass9_0>.NativeClassPtr);
				CharacterCreatorOptionList.__c__DisplayClass9_0.NativeFieldInfoPtr_option = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass9_0>.NativeClassPtr, "option");
				CharacterCreatorOptionList.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass9_0>.NativeClassPtr, 100682964);
				CharacterCreatorOptionList.__c__DisplayClass9_0.NativeMethodInfoPtr__OptionClicked_b__0_Internal_Boolean_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass9_0>.NativeClassPtr, 100682965);
			}

			// Token: 0x0600DD0F RID: 56591 RVA: 0x00343BB0 File Offset: 0x00341DB0
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorOptionList.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorOptionList.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD10 RID: 56592 RVA: 0x00343BEC File Offset: 0x00341DEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OptionClicked_b__0(CharacterCreatorOptionList.Option o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorOptionList.__c__DisplayClass9_0.NativeMethodInfoPtr__OptionClicked_b__0_Internal_Boolean_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DD11 RID: 56593 RVA: 0x0006BBB8 File Offset: 0x00069DB8
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004483 RID: 17539
			// (get) Token: 0x0600DD12 RID: 56594 RVA: 0x00343C3C File Offset: 0x00341E3C
			// (set) Token: 0x0600DD13 RID: 56595 RVA: 0x0006BBC1 File Offset: 0x00069DC1
			public unsafe string option
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.__c__DisplayClass9_0.NativeFieldInfoPtr_option);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorOptionList.__c__DisplayClass9_0.NativeFieldInfoPtr_option), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400941D RID: 37917
			private static readonly IntPtr NativeFieldInfoPtr_option;

			// Token: 0x0400941E RID: 37918
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400941F RID: 37919
			private static readonly IntPtr NativeMethodInfoPtr__OptionClicked_b__0_Internal_Boolean_Option_0;
		}
	}
}
