using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200063E RID: 1598
	public class GenericSelectionModule : Singleton<GenericSelectionModule>
	{
		// Token: 0x06008D3A RID: 36154 RVA: 0x0024D114 File Offset: 0x0024B314
		// Note: this type is marked as 'beforefieldinit'.
		static GenericSelectionModule()
		{
			Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "GenericSelectionModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr);
			GenericSelectionModule.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "<isOpen>k__BackingField");
			GenericSelectionModule.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "canvas");
			GenericSelectionModule.NativeFieldInfoPtr_TitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "TitleText");
			GenericSelectionModule.NativeFieldInfoPtr_OptionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "OptionContainer");
			GenericSelectionModule.NativeFieldInfoPtr_CloseButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "CloseButton");
			GenericSelectionModule.NativeFieldInfoPtr_ListOptionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "ListOptionPrefab");
			GenericSelectionModule.NativeFieldInfoPtr_OptionChosen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "OptionChosen");
			GenericSelectionModule.NativeFieldInfoPtr__ChosenOptionIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "<ChosenOptionIndex>k__BackingField");
			GenericSelectionModule.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100680849);
			GenericSelectionModule.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100680850);
			GenericSelectionModule.NativeMethodInfoPtr_get_ChosenOptionIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100680851);
			GenericSelectionModule.NativeMethodInfoPtr_set_ChosenOptionIndex_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100680852);
			GenericSelectionModule.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100680853);
			GenericSelectionModule.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100680854);
			GenericSelectionModule.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100680855);
			GenericSelectionModule.NativeMethodInfoPtr_Open_Public_Void_String_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100680856);
			GenericSelectionModule.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100680857);
			GenericSelectionModule.NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100680858);
			GenericSelectionModule.NativeMethodInfoPtr_ClearOptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100680859);
			GenericSelectionModule.NativeMethodInfoPtr_ListOptionClicked_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100680860);
			GenericSelectionModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, 100680861);
		}

		// Token: 0x17002B1E RID: 11038
		// (get) Token: 0x06008D3B RID: 36155 RVA: 0x0024D2E8 File Offset: 0x0024B4E8
		// (set) Token: 0x06008D3C RID: 36156 RVA: 0x0024D324 File Offset: 0x0024B524
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37992, RefRangeEnd = 38015, XrefRangeStart = 37992, XrefRangeEnd = 38015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002B1F RID: 11039
		// (get) Token: 0x06008D3D RID: 36157 RVA: 0x0024D364 File Offset: 0x0024B564
		// (set) Token: 0x06008D3E RID: 36158 RVA: 0x0024D3A0 File Offset: 0x0024B5A0
		public unsafe int ChosenOptionIndex
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 69401, RefRangeEnd = 69402, XrefRangeStart = 69401, XrefRangeEnd = 69402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_get_ChosenOptionIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 258006, RefRangeEnd = 258015, XrefRangeStart = 258006, XrefRangeEnd = 258006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_set_ChosenOptionIndex_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008D3F RID: 36159 RVA: 0x0024D3E0 File Offset: 0x0024B5E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258015, XrefRangeEnd = 258021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericSelectionModule.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D40 RID: 36160 RVA: 0x0024D41C File Offset: 0x0024B61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258021, XrefRangeEnd = 258034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericSelectionModule.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D41 RID: 36161 RVA: 0x0024D458 File Offset: 0x0024B658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258034, XrefRangeEnd = 258037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D42 RID: 36162 RVA: 0x0024D49C File Offset: 0x0024B69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258037, XrefRangeEnd = 258077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(string title, List<string> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_Open_Public_Void_String_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D43 RID: 36163 RVA: 0x0024D4F0 File Offset: 0x0024B6F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258077, XrefRangeEnd = 258080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D44 RID: 36164 RVA: 0x0024D524 File Offset: 0x0024B724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258080, XrefRangeEnd = 258083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D45 RID: 36165 RVA: 0x0024D558 File Offset: 0x0024B758
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 258090, RefRangeEnd = 258097, XrefRangeStart = 258083, XrefRangeEnd = 258090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_ClearOptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D46 RID: 36166 RVA: 0x0024D58C File Offset: 0x0024B78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258097, XrefRangeEnd = 258100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ListOptionClicked(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr_ListOptionClicked_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D47 RID: 36167 RVA: 0x0024D5CC File Offset: 0x0024B7CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258100, XrefRangeEnd = 258103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericSelectionModule() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D48 RID: 36168 RVA: 0x00043C16 File Offset: 0x00041E16
		public GenericSelectionModule(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B16 RID: 11030
		// (get) Token: 0x06008D49 RID: 36169 RVA: 0x0024D608 File Offset: 0x0024B808
		// (set) Token: 0x06008D4A RID: 36170 RVA: 0x00043C1F File Offset: 0x00041E1F
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002B17 RID: 11031
		// (get) Token: 0x06008D4B RID: 36171 RVA: 0x0024D630 File Offset: 0x0024B830
		// (set) Token: 0x06008D4C RID: 36172 RVA: 0x00043C3A File Offset: 0x00041E3A
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B18 RID: 11032
		// (get) Token: 0x06008D4D RID: 36173 RVA: 0x0024D660 File Offset: 0x0024B860
		// (set) Token: 0x06008D4E RID: 36174 RVA: 0x00043C59 File Offset: 0x00041E59
		public unsafe TextMeshProUGUI TitleText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_TitleText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_TitleText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B19 RID: 11033
		// (get) Token: 0x06008D4F RID: 36175 RVA: 0x0024D690 File Offset: 0x0024B890
		// (set) Token: 0x06008D50 RID: 36176 RVA: 0x00043C78 File Offset: 0x00041E78
		public unsafe RectTransform OptionContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_OptionContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_OptionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B1A RID: 11034
		// (get) Token: 0x06008D51 RID: 36177 RVA: 0x0024D6C0 File Offset: 0x0024B8C0
		// (set) Token: 0x06008D52 RID: 36178 RVA: 0x00043C97 File Offset: 0x00041E97
		public unsafe Button CloseButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_CloseButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_CloseButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B1B RID: 11035
		// (get) Token: 0x06008D53 RID: 36179 RVA: 0x0024D6F0 File Offset: 0x0024B8F0
		// (set) Token: 0x06008D54 RID: 36180 RVA: 0x00043CB6 File Offset: 0x00041EB6
		public unsafe GameObject ListOptionPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_ListOptionPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_ListOptionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B1C RID: 11036
		// (get) Token: 0x06008D55 RID: 36181 RVA: 0x0024D720 File Offset: 0x0024B920
		// (set) Token: 0x06008D56 RID: 36182 RVA: 0x00043CD5 File Offset: 0x00041ED5
		public unsafe bool OptionChosen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_OptionChosen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr_OptionChosen)) = value;
			}
		}

		// Token: 0x17002B1D RID: 11037
		// (get) Token: 0x06008D57 RID: 36183 RVA: 0x0024D748 File Offset: 0x0024B948
		// (set) Token: 0x06008D58 RID: 36184 RVA: 0x00043CF0 File Offset: 0x00041EF0
		public unsafe int _ChosenOptionIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr__ChosenOptionIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.NativeFieldInfoPtr__ChosenOptionIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x04005FAF RID: 24495
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x04005FB0 RID: 24496
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04005FB1 RID: 24497
		private static readonly IntPtr NativeFieldInfoPtr_TitleText;

		// Token: 0x04005FB2 RID: 24498
		private static readonly IntPtr NativeFieldInfoPtr_OptionContainer;

		// Token: 0x04005FB3 RID: 24499
		private static readonly IntPtr NativeFieldInfoPtr_CloseButton;

		// Token: 0x04005FB4 RID: 24500
		private static readonly IntPtr NativeFieldInfoPtr_ListOptionPrefab;

		// Token: 0x04005FB5 RID: 24501
		private static readonly IntPtr NativeFieldInfoPtr_OptionChosen;

		// Token: 0x04005FB6 RID: 24502
		private static readonly IntPtr NativeFieldInfoPtr__ChosenOptionIndex_k__BackingField;

		// Token: 0x04005FB7 RID: 24503
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04005FB8 RID: 24504
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04005FB9 RID: 24505
		private static readonly IntPtr NativeMethodInfoPtr_get_ChosenOptionIndex_Public_get_Int32_0;

		// Token: 0x04005FBA RID: 24506
		private static readonly IntPtr NativeMethodInfoPtr_set_ChosenOptionIndex_Protected_set_Void_Int32_0;

		// Token: 0x04005FBB RID: 24507
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04005FBC RID: 24508
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04005FBD RID: 24509
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04005FBE RID: 24510
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_String_List_1_String_0;

		// Token: 0x04005FBF RID: 24511
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04005FC0 RID: 24512
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;

		// Token: 0x04005FC1 RID: 24513
		private static readonly IntPtr NativeMethodInfoPtr_ClearOptions_Private_Void_0;

		// Token: 0x04005FC2 RID: 24514
		private static readonly IntPtr NativeMethodInfoPtr_ListOptionClicked_Private_Void_Int32_0;

		// Token: 0x04005FC3 RID: 24515
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B24 RID: 2852
		[ObfuscatedName("ScheduleOne.UI.GenericSelectionModule+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D792 RID: 55186 RVA: 0x00334120 File Offset: 0x00332320
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<GenericSelectionModule.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSelectionModule>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSelectionModule.__c__DisplayClass17_0>.NativeClassPtr);
				GenericSelectionModule.__c__DisplayClass17_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule.__c__DisplayClass17_0>.NativeClassPtr, "index");
				GenericSelectionModule.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSelectionModule.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				GenericSelectionModule.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule.__c__DisplayClass17_0>.NativeClassPtr, 100680862);
				GenericSelectionModule.__c__DisplayClass17_0.NativeMethodInfoPtr__Open_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSelectionModule.__c__DisplayClass17_0>.NativeClassPtr, 100680863);
			}

			// Token: 0x0600D793 RID: 55187 RVA: 0x0033419C File Offset: 0x0033239C
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSelectionModule.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D794 RID: 55188 RVA: 0x003341D8 File Offset: 0x003323D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258003, XrefRangeEnd = 258006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Open_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSelectionModule.__c__DisplayClass17_0.NativeMethodInfoPtr__Open_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D795 RID: 55189 RVA: 0x00068F54 File Offset: 0x00067154
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042D0 RID: 17104
			// (get) Token: 0x0600D796 RID: 55190 RVA: 0x0033420C File Offset: 0x0033240C
			// (set) Token: 0x0600D797 RID: 55191 RVA: 0x00068F5D File Offset: 0x0006715D
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.__c__DisplayClass17_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.__c__DisplayClass17_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x170042D1 RID: 17105
			// (get) Token: 0x0600D798 RID: 55192 RVA: 0x00334234 File Offset: 0x00332434
			// (set) Token: 0x0600D799 RID: 55193 RVA: 0x00068F78 File Offset: 0x00067178
			public unsafe GenericSelectionModule __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericSelectionModule>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSelectionModule.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040090EA RID: 37098
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x040090EB RID: 37099
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040090EC RID: 37100
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040090ED RID: 37101
			private static readonly IntPtr NativeMethodInfoPtr__Open_b__0_Internal_Void_0;
		}
	}
}
