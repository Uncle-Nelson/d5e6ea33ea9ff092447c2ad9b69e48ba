using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006CF RID: 1743
	public class ItemSelector : ClipboardScreen
	{
		// Token: 0x06009C8C RID: 40076 RVA: 0x0027A7AC File Offset: 0x002789AC
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSelector()
		{
			Il2CppClassPointerStore<ItemSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ItemSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr);
			ItemSelector.NativeFieldInfoPtr_OptionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "OptionContainer");
			ItemSelector.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "TitleLabel");
			ItemSelector.NativeFieldInfoPtr_HoveredItemLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "HoveredItemLabel");
			ItemSelector.NativeFieldInfoPtr_OptionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "OptionPrefab");
			ItemSelector.NativeFieldInfoPtr_EmptyOptionSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "EmptyOptionSprite");
			ItemSelector.NativeFieldInfoPtr_lerpRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "lerpRoutine");
			ItemSelector.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "options");
			ItemSelector.NativeFieldInfoPtr_selectedOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "selectedOption");
			ItemSelector.NativeFieldInfoPtr_optionButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "optionButtons");
			ItemSelector.NativeFieldInfoPtr_optionCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "optionCallback");
			ItemSelector.NativeMethodInfoPtr_Initialize_Public_Void_String_List_1_Option_Option_Action_1_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, 100682516);
			ItemSelector.NativeMethodInfoPtr_Open_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, 100682517);
			ItemSelector.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, 100682518);
			ItemSelector.NativeMethodInfoPtr_ButtonClicked_Private_Void_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, 100682519);
			ItemSelector.NativeMethodInfoPtr_ButtonHovered_Private_Void_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, 100682520);
			ItemSelector.NativeMethodInfoPtr_ButtonHoverEnd_Private_Void_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, 100682521);
			ItemSelector.NativeMethodInfoPtr_CreateOptions_Private_Void_List_1_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, 100682522);
			ItemSelector.NativeMethodInfoPtr_DeleteOptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, 100682523);
			ItemSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, 100682524);
		}

		// Token: 0x06009C8D RID: 40077 RVA: 0x0027A958 File Offset: 0x00278B58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 277990, RefRangeEnd = 277991, XrefRangeStart = 277963, XrefRangeEnd = 277990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(string selectionTitle, List<ItemSelector.Option> _options, ItemSelector.Option _selectedOption = null, Action<ItemSelector.Option> _optionCallback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(selectionTitle);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_options);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_selectedOption);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_optionCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.NativeMethodInfoPtr_Initialize_Public_Void_String_List_1_Option_Option_Action_1_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C8E RID: 40078 RVA: 0x0027A9D4 File Offset: 0x00278BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277991, XrefRangeEnd = 277997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSelector.NativeMethodInfoPtr_Open_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C8F RID: 40079 RVA: 0x0027AA10 File Offset: 0x00278C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277997, XrefRangeEnd = 278004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSelector.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C90 RID: 40080 RVA: 0x0027AA4C File Offset: 0x00278C4C
		[CallerCount(0)]
		public unsafe void ButtonClicked(ItemSelector.Option option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.NativeMethodInfoPtr_ButtonClicked_Private_Void_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C91 RID: 40081 RVA: 0x0027AA90 File Offset: 0x00278C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278004, XrefRangeEnd = 278016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ButtonHovered(ItemSelector.Option option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.NativeMethodInfoPtr_ButtonHovered_Private_Void_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C92 RID: 40082 RVA: 0x0027AAD4 File Offset: 0x00278CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278016, XrefRangeEnd = 278018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ButtonHoverEnd(ItemSelector.Option option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.NativeMethodInfoPtr_ButtonHoverEnd_Private_Void_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C93 RID: 40083 RVA: 0x0027AB18 File Offset: 0x00278D18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278130, RefRangeEnd = 278131, XrefRangeStart = 278018, XrefRangeEnd = 278130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateOptions(List<ItemSelector.Option> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.NativeMethodInfoPtr_CreateOptions_Private_Void_List_1_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C94 RID: 40084 RVA: 0x0027AB5C File Offset: 0x00278D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278131, XrefRangeEnd = 278143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.NativeMethodInfoPtr_DeleteOptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C95 RID: 40085 RVA: 0x0027AB90 File Offset: 0x00278D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278143, XrefRangeEnd = 278158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C96 RID: 40086 RVA: 0x0004CBD7 File Offset: 0x0004ADD7
		public ItemSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003032 RID: 12338
		// (get) Token: 0x06009C97 RID: 40087 RVA: 0x0027ABCC File Offset: 0x00278DCC
		// (set) Token: 0x06009C98 RID: 40088 RVA: 0x0004CBE0 File Offset: 0x0004ADE0
		public unsafe RectTransform OptionContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_OptionContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_OptionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003033 RID: 12339
		// (get) Token: 0x06009C99 RID: 40089 RVA: 0x0027ABFC File Offset: 0x00278DFC
		// (set) Token: 0x06009C9A RID: 40090 RVA: 0x0004CBFF File Offset: 0x0004ADFF
		public unsafe TextMeshProUGUI TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003034 RID: 12340
		// (get) Token: 0x06009C9B RID: 40091 RVA: 0x0027AC2C File Offset: 0x00278E2C
		// (set) Token: 0x06009C9C RID: 40092 RVA: 0x0004CC1E File Offset: 0x0004AE1E
		public unsafe TextMeshProUGUI HoveredItemLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_HoveredItemLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_HoveredItemLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003035 RID: 12341
		// (get) Token: 0x06009C9D RID: 40093 RVA: 0x0027AC5C File Offset: 0x00278E5C
		// (set) Token: 0x06009C9E RID: 40094 RVA: 0x0004CC3D File Offset: 0x0004AE3D
		public unsafe GameObject OptionPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_OptionPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_OptionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003036 RID: 12342
		// (get) Token: 0x06009C9F RID: 40095 RVA: 0x0027AC8C File Offset: 0x00278E8C
		// (set) Token: 0x06009CA0 RID: 40096 RVA: 0x0004CC5C File Offset: 0x0004AE5C
		public unsafe Sprite EmptyOptionSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_EmptyOptionSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_EmptyOptionSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003037 RID: 12343
		// (get) Token: 0x06009CA1 RID: 40097 RVA: 0x0027ACBC File Offset: 0x00278EBC
		// (set) Token: 0x06009CA2 RID: 40098 RVA: 0x0004CC7B File Offset: 0x0004AE7B
		public new unsafe Coroutine lerpRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_lerpRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_lerpRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003038 RID: 12344
		// (get) Token: 0x06009CA3 RID: 40099 RVA: 0x0027ACEC File Offset: 0x00278EEC
		// (set) Token: 0x06009CA4 RID: 40100 RVA: 0x0004CC9A File Offset: 0x0004AE9A
		public unsafe List<ItemSelector.Option> options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSelector.Option>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003039 RID: 12345
		// (get) Token: 0x06009CA5 RID: 40101 RVA: 0x0027AD1C File Offset: 0x00278F1C
		// (set) Token: 0x06009CA6 RID: 40102 RVA: 0x0004CCB9 File Offset: 0x0004AEB9
		public unsafe ItemSelector.Option selectedOption
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_selectedOption);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSelector.Option>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_selectedOption), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700303A RID: 12346
		// (get) Token: 0x06009CA7 RID: 40103 RVA: 0x0027AD4C File Offset: 0x00278F4C
		// (set) Token: 0x06009CA8 RID: 40104 RVA: 0x0004CCD8 File Offset: 0x0004AED8
		public unsafe List<RectTransform> optionButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_optionButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_optionButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700303B RID: 12347
		// (get) Token: 0x06009CA9 RID: 40105 RVA: 0x0027AD7C File Offset: 0x00278F7C
		// (set) Token: 0x06009CAA RID: 40106 RVA: 0x0004CCF7 File Offset: 0x0004AEF7
		public unsafe Action<ItemSelector.Option> optionCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_optionCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ItemSelector.Option>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.NativeFieldInfoPtr_optionCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006928 RID: 26920
		private static readonly IntPtr NativeFieldInfoPtr_OptionContainer;

		// Token: 0x04006929 RID: 26921
		private static readonly IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x0400692A RID: 26922
		private static readonly IntPtr NativeFieldInfoPtr_HoveredItemLabel;

		// Token: 0x0400692B RID: 26923
		private static readonly IntPtr NativeFieldInfoPtr_OptionPrefab;

		// Token: 0x0400692C RID: 26924
		private static readonly IntPtr NativeFieldInfoPtr_EmptyOptionSprite;

		// Token: 0x0400692D RID: 26925
		private static readonly IntPtr NativeFieldInfoPtr_lerpRoutine;

		// Token: 0x0400692E RID: 26926
		private static readonly IntPtr NativeFieldInfoPtr_options;

		// Token: 0x0400692F RID: 26927
		private static readonly IntPtr NativeFieldInfoPtr_selectedOption;

		// Token: 0x04006930 RID: 26928
		private static readonly IntPtr NativeFieldInfoPtr_optionButtons;

		// Token: 0x04006931 RID: 26929
		private static readonly IntPtr NativeFieldInfoPtr_optionCallback;

		// Token: 0x04006932 RID: 26930
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_String_List_1_Option_Option_Action_1_Option_0;

		// Token: 0x04006933 RID: 26931
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_Void_0;

		// Token: 0x04006934 RID: 26932
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04006935 RID: 26933
		private static readonly IntPtr NativeMethodInfoPtr_ButtonClicked_Private_Void_Option_0;

		// Token: 0x04006936 RID: 26934
		private static readonly IntPtr NativeMethodInfoPtr_ButtonHovered_Private_Void_Option_0;

		// Token: 0x04006937 RID: 26935
		private static readonly IntPtr NativeMethodInfoPtr_ButtonHoverEnd_Private_Void_Option_0;

		// Token: 0x04006938 RID: 26936
		private static readonly IntPtr NativeMethodInfoPtr_CreateOptions_Private_Void_List_1_Option_0;

		// Token: 0x04006939 RID: 26937
		private static readonly IntPtr NativeMethodInfoPtr_DeleteOptions_Private_Void_0;

		// Token: 0x0400693A RID: 26938
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B91 RID: 2961
		[Serializable]
		public class Option : Il2CppSystem.Object
		{
			// Token: 0x0600DC0E RID: 56334 RVA: 0x00340DD4 File Offset: 0x0033EFD4
			// Note: this type is marked as 'beforefieldinit'.
			static Option()
			{
				Il2CppClassPointerStore<ItemSelector.Option>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "Option");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSelector.Option>.NativeClassPtr);
				ItemSelector.Option.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector.Option>.NativeClassPtr, "Title");
				ItemSelector.Option.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector.Option>.NativeClassPtr, "Item");
				ItemSelector.Option.NativeMethodInfoPtr__ctor_Public_Void_String_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector.Option>.NativeClassPtr, 100682525);
			}

			// Token: 0x0600DC0F RID: 56335 RVA: 0x00340E3C File Offset: 0x0033F03C
			[CallerCount(49)]
			[CachedScanResults(RefRangeStart = 110734, RefRangeEnd = 110783, XrefRangeStart = 110734, XrefRangeEnd = 110783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Option(string title, ItemDefinition item) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSelector.Option>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.Option.NativeMethodInfoPtr__ctor_Public_Void_String_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC10 RID: 56336 RVA: 0x0006B34C File Offset: 0x0006954C
			public Option(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004439 RID: 17465
			// (get) Token: 0x0600DC11 RID: 56337 RVA: 0x00340E9C File Offset: 0x0033F09C
			// (set) Token: 0x0600DC12 RID: 56338 RVA: 0x0006B355 File Offset: 0x00069555
			public unsafe string Title
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.Option.NativeFieldInfoPtr_Title);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.Option.NativeFieldInfoPtr_Title), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700443A RID: 17466
			// (get) Token: 0x0600DC13 RID: 56339 RVA: 0x00340EC4 File Offset: 0x0033F0C4
			// (set) Token: 0x0600DC14 RID: 56340 RVA: 0x0006B374 File Offset: 0x00069574
			public unsafe ItemDefinition Item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.Option.NativeFieldInfoPtr_Item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.Option.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009385 RID: 37765
			private static readonly IntPtr NativeFieldInfoPtr_Title;

			// Token: 0x04009386 RID: 37766
			private static readonly IntPtr NativeFieldInfoPtr_Item;

			// Token: 0x04009387 RID: 37767
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_ItemDefinition_0;
		}

		// Token: 0x02000B92 RID: 2962
		[ObfuscatedName("ScheduleOne.UI.Management.ItemSelector+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DC15 RID: 56341 RVA: 0x00340EF4 File Offset: 0x0033F0F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<ItemSelector.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSelector.__c__DisplayClass17_0>.NativeClassPtr);
				ItemSelector.__c__DisplayClass17_0.NativeFieldInfoPtr_opt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector.__c__DisplayClass17_0>.NativeClassPtr, "opt");
				ItemSelector.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSelector.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				ItemSelector.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector.__c__DisplayClass17_0>.NativeClassPtr, 100682526);
				ItemSelector.__c__DisplayClass17_0.NativeMethodInfoPtr__CreateOptions_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector.__c__DisplayClass17_0>.NativeClassPtr, 100682527);
				ItemSelector.__c__DisplayClass17_0.NativeMethodInfoPtr__CreateOptions_b__1_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector.__c__DisplayClass17_0>.NativeClassPtr, 100682528);
				ItemSelector.__c__DisplayClass17_0.NativeMethodInfoPtr__CreateOptions_b__2_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector.__c__DisplayClass17_0>.NativeClassPtr, 100682529);
			}

			// Token: 0x0600DC16 RID: 56342 RVA: 0x00340F98 File Offset: 0x0033F198
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSelector.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC17 RID: 56343 RVA: 0x00340FD4 File Offset: 0x0033F1D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277948, XrefRangeEnd = 277949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateOptions_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.__c__DisplayClass17_0.NativeMethodInfoPtr__CreateOptions_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC18 RID: 56344 RVA: 0x00341008 File Offset: 0x0033F208
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277949, XrefRangeEnd = 277961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateOptions_b__1(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.__c__DisplayClass17_0.NativeMethodInfoPtr__CreateOptions_b__1_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC19 RID: 56345 RVA: 0x0034104C File Offset: 0x0033F24C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277961, XrefRangeEnd = 277963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateOptions_b__2(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.__c__DisplayClass17_0.NativeMethodInfoPtr__CreateOptions_b__2_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC1A RID: 56346 RVA: 0x0006B393 File Offset: 0x00069593
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700443B RID: 17467
			// (get) Token: 0x0600DC1B RID: 56347 RVA: 0x00341090 File Offset: 0x0033F290
			// (set) Token: 0x0600DC1C RID: 56348 RVA: 0x0006B39C File Offset: 0x0006959C
			public unsafe ItemSelector.Option opt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.__c__DisplayClass17_0.NativeFieldInfoPtr_opt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSelector.Option>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.__c__DisplayClass17_0.NativeFieldInfoPtr_opt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700443C RID: 17468
			// (get) Token: 0x0600DC1D RID: 56349 RVA: 0x003410C0 File Offset: 0x0033F2C0
			// (set) Token: 0x0600DC1E RID: 56350 RVA: 0x0006B3BB File Offset: 0x000695BB
			public unsafe ItemSelector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSelector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSelector.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009388 RID: 37768
			private static readonly IntPtr NativeFieldInfoPtr_opt;

			// Token: 0x04009389 RID: 37769
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400938A RID: 37770
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400938B RID: 37771
			private static readonly IntPtr NativeMethodInfoPtr__CreateOptions_b__0_Internal_Void_0;

			// Token: 0x0400938C RID: 37772
			private static readonly IntPtr NativeMethodInfoPtr__CreateOptions_b__1_Internal_Void_BaseEventData_0;

			// Token: 0x0400938D RID: 37773
			private static readonly IntPtr NativeMethodInfoPtr__CreateOptions_b__2_Internal_Void_BaseEventData_0;
		}
	}
}
