using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Construction.Features;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Construction.Features
{
	// Token: 0x02000724 RID: 1828
	public class FI_OptionList : FI_Base
	{
		// Token: 0x0600A49A RID: 42138 RVA: 0x00293C88 File Offset: 0x00291E88
		// Note: this type is marked as 'beforefieldinit'.
		static FI_OptionList()
		{
			Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Construction.Features", "FI_OptionList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr);
			FI_OptionList.NativeFieldInfoPtr_buttonContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "buttonContainer");
			FI_OptionList.NativeFieldInfoPtr_buyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "buyButton");
			FI_OptionList.NativeFieldInfoPtr_buyButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "buyButtonText");
			FI_OptionList.NativeFieldInfoPtr_bar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "bar");
			FI_OptionList.NativeFieldInfoPtr_buttonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "buttonPrefab");
			FI_OptionList.NativeFieldInfoPtr_onSelectionChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "onSelectionChanged");
			FI_OptionList.NativeFieldInfoPtr_onSelectionPurchased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "onSelectionPurchased");
			FI_OptionList.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "options");
			FI_OptionList.NativeFieldInfoPtr_specificFeature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "specificFeature");
			FI_OptionList.NativeFieldInfoPtr_selectionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "selectionIndex");
			FI_OptionList.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_OptionListFeature_List_1_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, 100683406);
			FI_OptionList.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, 100683407);
			FI_OptionList.NativeMethodInfoPtr_BuyButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, 100683408);
			FI_OptionList.NativeMethodInfoPtr_Select_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, 100683409);
			FI_OptionList.NativeMethodInfoPtr_UpdateSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, 100683410);
			FI_OptionList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, 100683411);
		}

		// Token: 0x0600A49B RID: 42139 RVA: 0x00293DF8 File Offset: 0x00291FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288002, XrefRangeEnd = 288059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(OptionListFeature _feature, List<FI_OptionList.Option> _options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_feature);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FI_OptionList.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_OptionListFeature_List_1_Option_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A49C RID: 42140 RVA: 0x00293E58 File Offset: 0x00292058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288059, XrefRangeEnd = 288067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FI_OptionList.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A49D RID: 42141 RVA: 0x00293E94 File Offset: 0x00292094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288067, XrefRangeEnd = 288093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuyButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_OptionList.NativeMethodInfoPtr_BuyButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A49E RID: 42142 RVA: 0x00293EC8 File Offset: 0x002920C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 288100, RefRangeEnd = 288102, XrefRangeStart = 288093, XrefRangeEnd = 288100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Select(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_OptionList.NativeMethodInfoPtr_Select_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A49F RID: 42143 RVA: 0x00293F08 File Offset: 0x00292108
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 288161, RefRangeEnd = 288164, XrefRangeStart = 288102, XrefRangeEnd = 288161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_OptionList.NativeMethodInfoPtr_UpdateSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4A0 RID: 42144 RVA: 0x00293F3C File Offset: 0x0029213C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288164, XrefRangeEnd = 288172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FI_OptionList() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_OptionList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A4A1 RID: 42145 RVA: 0x0005125E File Offset: 0x0004F45E
		public FI_OptionList(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170032C8 RID: 13000
		// (get) Token: 0x0600A4A2 RID: 42146 RVA: 0x00293F78 File Offset: 0x00292178
		// (set) Token: 0x0600A4A3 RID: 42147 RVA: 0x00051267 File Offset: 0x0004F467
		public unsafe RectTransform buttonContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_buttonContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_buttonContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032C9 RID: 13001
		// (get) Token: 0x0600A4A4 RID: 42148 RVA: 0x00293FA8 File Offset: 0x002921A8
		// (set) Token: 0x0600A4A5 RID: 42149 RVA: 0x00051286 File Offset: 0x0004F486
		public unsafe Button buyButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_buyButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_buyButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032CA RID: 13002
		// (get) Token: 0x0600A4A6 RID: 42150 RVA: 0x00293FD8 File Offset: 0x002921D8
		// (set) Token: 0x0600A4A7 RID: 42151 RVA: 0x000512A5 File Offset: 0x0004F4A5
		public unsafe TextMeshProUGUI buyButtonText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_buyButtonText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_buyButtonText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032CB RID: 13003
		// (get) Token: 0x0600A4A8 RID: 42152 RVA: 0x00294008 File Offset: 0x00292208
		// (set) Token: 0x0600A4A9 RID: 42153 RVA: 0x000512C4 File Offset: 0x0004F4C4
		public unsafe RectTransform bar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_bar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_bar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032CC RID: 13004
		// (get) Token: 0x0600A4AA RID: 42154 RVA: 0x00294038 File Offset: 0x00292238
		// (set) Token: 0x0600A4AB RID: 42155 RVA: 0x000512E3 File Offset: 0x0004F4E3
		public unsafe GameObject buttonPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_buttonPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_buttonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032CD RID: 13005
		// (get) Token: 0x0600A4AC RID: 42156 RVA: 0x00294068 File Offset: 0x00292268
		// (set) Token: 0x0600A4AD RID: 42157 RVA: 0x00051302 File Offset: 0x0004F502
		public unsafe UnityEvent<int> onSelectionChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_onSelectionChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_onSelectionChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032CE RID: 13006
		// (get) Token: 0x0600A4AE RID: 42158 RVA: 0x00294098 File Offset: 0x00292298
		// (set) Token: 0x0600A4AF RID: 42159 RVA: 0x00051321 File Offset: 0x0004F521
		public unsafe UnityEvent<int> onSelectionPurchased
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_onSelectionPurchased);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_onSelectionPurchased), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032CF RID: 13007
		// (get) Token: 0x0600A4B0 RID: 42160 RVA: 0x002940C8 File Offset: 0x002922C8
		// (set) Token: 0x0600A4B1 RID: 42161 RVA: 0x00051340 File Offset: 0x0004F540
		public unsafe List<FI_OptionList.Option> options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FI_OptionList.Option>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032D0 RID: 13008
		// (get) Token: 0x0600A4B2 RID: 42162 RVA: 0x002940F8 File Offset: 0x002922F8
		// (set) Token: 0x0600A4B3 RID: 42163 RVA: 0x0005135F File Offset: 0x0004F55F
		public unsafe OptionListFeature specificFeature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_specificFeature);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptionListFeature>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_specificFeature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032D1 RID: 13009
		// (get) Token: 0x0600A4B4 RID: 42164 RVA: 0x00294128 File Offset: 0x00292328
		// (set) Token: 0x0600A4B5 RID: 42165 RVA: 0x0005137E File Offset: 0x0004F57E
		public unsafe int selectionIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_selectionIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_selectionIndex)) = value;
			}
		}

		// Token: 0x04006E57 RID: 28247
		private static readonly IntPtr NativeFieldInfoPtr_buttonContainer;

		// Token: 0x04006E58 RID: 28248
		private static readonly IntPtr NativeFieldInfoPtr_buyButton;

		// Token: 0x04006E59 RID: 28249
		private static readonly IntPtr NativeFieldInfoPtr_buyButtonText;

		// Token: 0x04006E5A RID: 28250
		private static readonly IntPtr NativeFieldInfoPtr_bar;

		// Token: 0x04006E5B RID: 28251
		private static readonly IntPtr NativeFieldInfoPtr_buttonPrefab;

		// Token: 0x04006E5C RID: 28252
		private static readonly IntPtr NativeFieldInfoPtr_onSelectionChanged;

		// Token: 0x04006E5D RID: 28253
		private static readonly IntPtr NativeFieldInfoPtr_onSelectionPurchased;

		// Token: 0x04006E5E RID: 28254
		private static readonly IntPtr NativeFieldInfoPtr_options;

		// Token: 0x04006E5F RID: 28255
		private static readonly IntPtr NativeFieldInfoPtr_specificFeature;

		// Token: 0x04006E60 RID: 28256
		private static readonly IntPtr NativeFieldInfoPtr_selectionIndex;

		// Token: 0x04006E61 RID: 28257
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_OptionListFeature_List_1_Option_0;

		// Token: 0x04006E62 RID: 28258
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04006E63 RID: 28259
		private static readonly IntPtr NativeMethodInfoPtr_BuyButtonClicked_Public_Void_0;

		// Token: 0x04006E64 RID: 28260
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Void_Int32_0;

		// Token: 0x04006E65 RID: 28261
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSelection_Private_Void_0;

		// Token: 0x04006E66 RID: 28262
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BC8 RID: 3016
		public class Option : Il2CppSystem.Object
		{
			// Token: 0x0600DDE6 RID: 56806 RVA: 0x00346160 File Offset: 0x00344360
			// Note: this type is marked as 'beforefieldinit'.
			static Option()
			{
				Il2CppClassPointerStore<FI_OptionList.Option>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "Option");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FI_OptionList.Option>.NativeClassPtr);
				FI_OptionList.Option.NativeFieldInfoPtr_optionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList.Option>.NativeClassPtr, "optionLabel");
				FI_OptionList.Option.NativeFieldInfoPtr_optionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList.Option>.NativeClassPtr, "optionColor");
				FI_OptionList.Option.NativeFieldInfoPtr_optionPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList.Option>.NativeClassPtr, "optionPrice");
				FI_OptionList.Option.NativeMethodInfoPtr__ctor_Public_Void_String_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_OptionList.Option>.NativeClassPtr, 100683412);
			}

			// Token: 0x0600DDE7 RID: 56807 RVA: 0x003461DC File Offset: 0x003443DC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287998, RefRangeEnd = 288000, XrefRangeStart = 287996, XrefRangeEnd = 287998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Option(string _optionLabel, Color _optionColor, float _optionPrice) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FI_OptionList.Option>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(_optionLabel);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _optionColor;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _optionPrice;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_OptionList.Option.NativeMethodInfoPtr__ctor_Public_Void_String_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDE8 RID: 56808 RVA: 0x0006C27A File Offset: 0x0006A47A
			public Option(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044BE RID: 17598
			// (get) Token: 0x0600DDE9 RID: 56809 RVA: 0x00346244 File Offset: 0x00344444
			// (set) Token: 0x0600DDEA RID: 56810 RVA: 0x0006C283 File Offset: 0x0006A483
			public unsafe string optionLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.Option.NativeFieldInfoPtr_optionLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.Option.NativeFieldInfoPtr_optionLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170044BF RID: 17599
			// (get) Token: 0x0600DDEB RID: 56811 RVA: 0x0034626C File Offset: 0x0034446C
			// (set) Token: 0x0600DDEC RID: 56812 RVA: 0x0006C2A2 File Offset: 0x0006A4A2
			public unsafe Color optionColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.Option.NativeFieldInfoPtr_optionColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.Option.NativeFieldInfoPtr_optionColor)) = value;
				}
			}

			// Token: 0x170044C0 RID: 17600
			// (get) Token: 0x0600DDED RID: 56813 RVA: 0x00346294 File Offset: 0x00344494
			// (set) Token: 0x0600DDEE RID: 56814 RVA: 0x0006C2BD File Offset: 0x0006A4BD
			public unsafe float optionPrice
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.Option.NativeFieldInfoPtr_optionPrice);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.Option.NativeFieldInfoPtr_optionPrice)) = value;
				}
			}

			// Token: 0x0400949B RID: 38043
			private static readonly IntPtr NativeFieldInfoPtr_optionLabel;

			// Token: 0x0400949C RID: 38044
			private static readonly IntPtr NativeFieldInfoPtr_optionColor;

			// Token: 0x0400949D RID: 38045
			private static readonly IntPtr NativeFieldInfoPtr_optionPrice;

			// Token: 0x0400949E RID: 38046
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Color_Single_0;
		}

		// Token: 0x02000BC9 RID: 3017
		[ObfuscatedName("ScheduleOne.UI.Construction.Features.FI_OptionList+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DDEF RID: 56815 RVA: 0x003462BC File Offset: 0x003444BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<FI_OptionList.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FI_OptionList.__c__DisplayClass11_0>.NativeClassPtr);
				FI_OptionList.__c__DisplayClass11_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList.__c__DisplayClass11_0>.NativeClassPtr, "index");
				FI_OptionList.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
				FI_OptionList.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_OptionList.__c__DisplayClass11_0>.NativeClassPtr, 100683413);
				FI_OptionList.__c__DisplayClass11_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_OptionList.__c__DisplayClass11_0>.NativeClassPtr, 100683414);
			}

			// Token: 0x0600DDF0 RID: 56816 RVA: 0x00346338 File Offset: 0x00344538
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FI_OptionList.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_OptionList.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDF1 RID: 56817 RVA: 0x00346374 File Offset: 0x00344574
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288000, XrefRangeEnd = 288002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_OptionList.__c__DisplayClass11_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDF2 RID: 56818 RVA: 0x0006C2D8 File Offset: 0x0006A4D8
			public __c__DisplayClass11_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044C1 RID: 17601
			// (get) Token: 0x0600DDF3 RID: 56819 RVA: 0x003463A8 File Offset: 0x003445A8
			// (set) Token: 0x0600DDF4 RID: 56820 RVA: 0x0006C2E1 File Offset: 0x0006A4E1
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.__c__DisplayClass11_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.__c__DisplayClass11_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x170044C2 RID: 17602
			// (get) Token: 0x0600DDF5 RID: 56821 RVA: 0x003463D0 File Offset: 0x003445D0
			// (set) Token: 0x0600DDF6 RID: 56822 RVA: 0x0006C2FC File Offset: 0x0006A4FC
			public unsafe FI_OptionList __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FI_OptionList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400949F RID: 38047
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x040094A0 RID: 38048
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040094A1 RID: 38049
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040094A2 RID: 38050
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0;
		}
	}
}
