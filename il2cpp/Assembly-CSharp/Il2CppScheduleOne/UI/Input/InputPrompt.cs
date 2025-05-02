using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Il2CppScheduleOne.UI.Input
{
	// Token: 0x020006EF RID: 1775
	public class InputPrompt : MonoBehaviour
	{
		// Token: 0x06009ECB RID: 40651 RVA: 0x002819F8 File Offset: 0x0027FBF8
		// Note: this type is marked as 'beforefieldinit'.
		static InputPrompt()
		{
			Il2CppClassPointerStore<InputPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Input", "InputPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr);
			InputPrompt.NativeFieldInfoPtr_Spacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "Spacing");
			InputPrompt.NativeFieldInfoPtr_Actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "Actions");
			InputPrompt.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "Label");
			InputPrompt.NativeFieldInfoPtr_Alignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "Alignment");
			InputPrompt.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "Container");
			InputPrompt.NativeFieldInfoPtr_ImagesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "ImagesContainer");
			InputPrompt.NativeFieldInfoPtr_LabelComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "LabelComponent");
			InputPrompt.NativeFieldInfoPtr_Shade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "Shade");
			InputPrompt.NativeFieldInfoPtr_OverridePromptImageColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "OverridePromptImageColor");
			InputPrompt.NativeFieldInfoPtr_PromptImageColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "PromptImageColor");
			InputPrompt.NativeFieldInfoPtr_promptImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "promptImages");
			InputPrompt.NativeFieldInfoPtr_displayedActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "displayedActions");
			InputPrompt.NativeFieldInfoPtr_AppliedAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "AppliedAlignment");
			InputPrompt.NativeMethodInfoPtr_get_manager_Private_get_InputPromptsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, 100682779);
			InputPrompt.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, 100682780);
			InputPrompt.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, 100682781);
			InputPrompt.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, 100682782);
			InputPrompt.NativeMethodInfoPtr_RefreshPromptImages_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, 100682783);
			InputPrompt.NativeMethodInfoPtr_SetLabel_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, 100682784);
			InputPrompt.NativeMethodInfoPtr_UpdateShade_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, 100682785);
			InputPrompt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, 100682786);
		}

		// Token: 0x170030E9 RID: 12521
		// (get) Token: 0x06009ECC RID: 40652 RVA: 0x00281BCC File Offset: 0x0027FDCC
		public unsafe InputPromptsManager manager
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280891, XrefRangeEnd = 280900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPrompt.NativeMethodInfoPtr_get_manager_Private_get_InputPromptsManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputPromptsManager>(intPtr3) : null;
			}
		}

		// Token: 0x06009ECD RID: 40653 RVA: 0x00281C0C File Offset: 0x0027FE0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280900, XrefRangeEnd = 280904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPrompt.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009ECE RID: 40654 RVA: 0x00281C40 File Offset: 0x0027FE40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280904, XrefRangeEnd = 280907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPrompt.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009ECF RID: 40655 RVA: 0x00281C74 File Offset: 0x0027FE74
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPrompt.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009ED0 RID: 40656 RVA: 0x00281CA8 File Offset: 0x0027FEA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281005, RefRangeEnd = 281006, XrefRangeStart = 280907, XrefRangeEnd = 281005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshPromptImages()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPrompt.NativeMethodInfoPtr_RefreshPromptImages_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009ED1 RID: 40657 RVA: 0x00281CDC File Offset: 0x0027FEDC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 281009, RefRangeEnd = 281016, XrefRangeStart = 281006, XrefRangeEnd = 281009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLabel(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPrompt.NativeMethodInfoPtr_SetLabel_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009ED2 RID: 40658 RVA: 0x00281D20 File Offset: 0x0027FF20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 281019, RefRangeEnd = 281022, XrefRangeStart = 281016, XrefRangeEnd = 281019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateShade()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPrompt.NativeMethodInfoPtr_UpdateShade_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009ED3 RID: 40659 RVA: 0x00281D54 File Offset: 0x0027FF54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281022, XrefRangeEnd = 281042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputPrompt() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPrompt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009ED4 RID: 40660 RVA: 0x0004DE0B File Offset: 0x0004C00B
		public InputPrompt(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030DC RID: 12508
		// (get) Token: 0x06009ED5 RID: 40661 RVA: 0x00281D90 File Offset: 0x0027FF90
		// (set) Token: 0x06009ED6 RID: 40662 RVA: 0x0004DE14 File Offset: 0x0004C014
		public unsafe static float Spacing
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(InputPrompt.NativeFieldInfoPtr_Spacing, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputPrompt.NativeFieldInfoPtr_Spacing, (void*)(&value));
			}
		}

		// Token: 0x170030DD RID: 12509
		// (get) Token: 0x06009ED7 RID: 40663 RVA: 0x00281DAC File Offset: 0x0027FFAC
		// (set) Token: 0x06009ED8 RID: 40664 RVA: 0x0004DE22 File Offset: 0x0004C022
		public unsafe List<InputActionReference> Actions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Actions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputActionReference>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Actions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030DE RID: 12510
		// (get) Token: 0x06009ED9 RID: 40665 RVA: 0x00281DDC File Offset: 0x0027FFDC
		// (set) Token: 0x06009EDA RID: 40666 RVA: 0x0004DE41 File Offset: 0x0004C041
		public unsafe string Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170030DF RID: 12511
		// (get) Token: 0x06009EDB RID: 40667 RVA: 0x00281E04 File Offset: 0x00280004
		// (set) Token: 0x06009EDC RID: 40668 RVA: 0x0004DE60 File Offset: 0x0004C060
		public unsafe InputPrompt.EInputPromptAlignment Alignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Alignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Alignment)) = value;
			}
		}

		// Token: 0x170030E0 RID: 12512
		// (get) Token: 0x06009EDD RID: 40669 RVA: 0x00281E2C File Offset: 0x0028002C
		// (set) Token: 0x06009EDE RID: 40670 RVA: 0x0004DE7B File Offset: 0x0004C07B
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030E1 RID: 12513
		// (get) Token: 0x06009EDF RID: 40671 RVA: 0x00281E5C File Offset: 0x0028005C
		// (set) Token: 0x06009EE0 RID: 40672 RVA: 0x0004DE9A File Offset: 0x0004C09A
		public unsafe RectTransform ImagesContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_ImagesContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_ImagesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030E2 RID: 12514
		// (get) Token: 0x06009EE1 RID: 40673 RVA: 0x00281E8C File Offset: 0x0028008C
		// (set) Token: 0x06009EE2 RID: 40674 RVA: 0x0004DEB9 File Offset: 0x0004C0B9
		public unsafe TextMeshProUGUI LabelComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_LabelComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_LabelComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030E3 RID: 12515
		// (get) Token: 0x06009EE3 RID: 40675 RVA: 0x00281EBC File Offset: 0x002800BC
		// (set) Token: 0x06009EE4 RID: 40676 RVA: 0x0004DED8 File Offset: 0x0004C0D8
		public unsafe RectTransform Shade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Shade);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Shade), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030E4 RID: 12516
		// (get) Token: 0x06009EE5 RID: 40677 RVA: 0x00281EEC File Offset: 0x002800EC
		// (set) Token: 0x06009EE6 RID: 40678 RVA: 0x0004DEF7 File Offset: 0x0004C0F7
		public unsafe bool OverridePromptImageColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_OverridePromptImageColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_OverridePromptImageColor)) = value;
			}
		}

		// Token: 0x170030E5 RID: 12517
		// (get) Token: 0x06009EE7 RID: 40679 RVA: 0x00281F14 File Offset: 0x00280114
		// (set) Token: 0x06009EE8 RID: 40680 RVA: 0x0004DF12 File Offset: 0x0004C112
		public unsafe Color PromptImageColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_PromptImageColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_PromptImageColor)) = value;
			}
		}

		// Token: 0x170030E6 RID: 12518
		// (get) Token: 0x06009EE9 RID: 40681 RVA: 0x00281F3C File Offset: 0x0028013C
		// (set) Token: 0x06009EEA RID: 40682 RVA: 0x0004DF2D File Offset: 0x0004C12D
		public unsafe List<PromptImage> promptImages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_promptImages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PromptImage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_promptImages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030E7 RID: 12519
		// (get) Token: 0x06009EEB RID: 40683 RVA: 0x00281F6C File Offset: 0x0028016C
		// (set) Token: 0x06009EEC RID: 40684 RVA: 0x0004DF4C File Offset: 0x0004C14C
		public unsafe List<InputActionReference> displayedActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_displayedActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputActionReference>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_displayedActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030E8 RID: 12520
		// (get) Token: 0x06009EED RID: 40685 RVA: 0x00281F9C File Offset: 0x0028019C
		// (set) Token: 0x06009EEE RID: 40686 RVA: 0x0004DF6B File Offset: 0x0004C16B
		public unsafe InputPrompt.EInputPromptAlignment AppliedAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_AppliedAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_AppliedAlignment)) = value;
			}
		}

		// Token: 0x04006A91 RID: 27281
		private static readonly IntPtr NativeFieldInfoPtr_Spacing;

		// Token: 0x04006A92 RID: 27282
		private static readonly IntPtr NativeFieldInfoPtr_Actions;

		// Token: 0x04006A93 RID: 27283
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04006A94 RID: 27284
		private static readonly IntPtr NativeFieldInfoPtr_Alignment;

		// Token: 0x04006A95 RID: 27285
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006A96 RID: 27286
		private static readonly IntPtr NativeFieldInfoPtr_ImagesContainer;

		// Token: 0x04006A97 RID: 27287
		private static readonly IntPtr NativeFieldInfoPtr_LabelComponent;

		// Token: 0x04006A98 RID: 27288
		private static readonly IntPtr NativeFieldInfoPtr_Shade;

		// Token: 0x04006A99 RID: 27289
		private static readonly IntPtr NativeFieldInfoPtr_OverridePromptImageColor;

		// Token: 0x04006A9A RID: 27290
		private static readonly IntPtr NativeFieldInfoPtr_PromptImageColor;

		// Token: 0x04006A9B RID: 27291
		private static readonly IntPtr NativeFieldInfoPtr_promptImages;

		// Token: 0x04006A9C RID: 27292
		private static readonly IntPtr NativeFieldInfoPtr_displayedActions;

		// Token: 0x04006A9D RID: 27293
		private static readonly IntPtr NativeFieldInfoPtr_AppliedAlignment;

		// Token: 0x04006A9E RID: 27294
		private static readonly IntPtr NativeMethodInfoPtr_get_manager_Private_get_InputPromptsManager_0;

		// Token: 0x04006A9F RID: 27295
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04006AA0 RID: 27296
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04006AA1 RID: 27297
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006AA2 RID: 27298
		private static readonly IntPtr NativeMethodInfoPtr_RefreshPromptImages_Private_Void_0;

		// Token: 0x04006AA3 RID: 27299
		private static readonly IntPtr NativeMethodInfoPtr_SetLabel_Public_Void_String_0;

		// Token: 0x04006AA4 RID: 27300
		private static readonly IntPtr NativeMethodInfoPtr_UpdateShade_Private_Void_0;

		// Token: 0x04006AA5 RID: 27301
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BA0 RID: 2976
		[OriginalName("Assembly-CSharp.dll", "", "EInputPromptAlignment")]
		public enum EInputPromptAlignment
		{
			// Token: 0x040093CC RID: 37836
			Left,
			// Token: 0x040093CD RID: 37837
			Middle,
			// Token: 0x040093CE RID: 37838
			Right
		}
	}
}
