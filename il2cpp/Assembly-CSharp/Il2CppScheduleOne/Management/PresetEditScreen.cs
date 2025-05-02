using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Management.Presets;
using Il2CppScheduleOne.Management.Presets.Options.SetterScreens;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003A2 RID: 930
	public class PresetEditScreen : MonoBehaviour
	{
		// Token: 0x060048CD RID: 18637 RVA: 0x00163CF0 File Offset: 0x00161EF0
		// Note: this type is marked as 'beforefieldinit'.
		static PresetEditScreen()
		{
			Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "PresetEditScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr);
			PresetEditScreen.NativeFieldInfoPtr_EditedPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, "EditedPreset");
			PresetEditScreen.NativeFieldInfoPtr_IconBackgroundRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, "IconBackgroundRect");
			PresetEditScreen.NativeFieldInfoPtr_IconBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, "IconBackground");
			PresetEditScreen.NativeFieldInfoPtr_InputFieldRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, "InputFieldRect");
			PresetEditScreen.NativeFieldInfoPtr_InputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, "InputField");
			PresetEditScreen.NativeFieldInfoPtr_EditButtonRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, "EditButtonRect");
			PresetEditScreen.NativeFieldInfoPtr_ReturnButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, "ReturnButton");
			PresetEditScreen.NativeFieldInfoPtr_DeleteButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, "DeleteButton");
			PresetEditScreen.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672317);
			PresetEditScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672318);
			PresetEditScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672319);
			PresetEditScreen.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672320);
			PresetEditScreen.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672321);
			PresetEditScreen.NativeMethodInfoPtr_RefreshIcon_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672322);
			PresetEditScreen.NativeMethodInfoPtr_RefreshTransforms_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672323);
			PresetEditScreen.NativeMethodInfoPtr_NameFieldChange_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672324);
			PresetEditScreen.NativeMethodInfoPtr_NameFieldDone_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672325);
			PresetEditScreen.NativeMethodInfoPtr_IsNameAppropriate_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672326);
			PresetEditScreen.NativeMethodInfoPtr_DeleteButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672327);
			PresetEditScreen.NativeMethodInfoPtr_ReturnButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672328);
			PresetEditScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672329);
			PresetEditScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672330);
		}

		// Token: 0x170015E1 RID: 5601
		// (get) Token: 0x060048CE RID: 18638 RVA: 0x00163ED8 File Offset: 0x001620D8
		public unsafe bool isOpen
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 162765, RefRangeEnd = 162773, XrefRangeStart = 162765, XrefRangeEnd = 162765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060048CF RID: 18639 RVA: 0x00163F14 File Offset: 0x00162114
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 162813, RefRangeEnd = 162814, XrefRangeStart = 162773, XrefRangeEnd = 162813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PresetEditScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048D0 RID: 18640 RVA: 0x00163F50 File Offset: 0x00162150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162814, XrefRangeEnd = 162818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048D1 RID: 18641 RVA: 0x00163F94 File Offset: 0x00162194
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 162831, RefRangeEnd = 162832, XrefRangeStart = 162818, XrefRangeEnd = 162831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open(Preset preset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(preset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PresetEditScreen.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_Preset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048D2 RID: 18642 RVA: 0x00163FE4 File Offset: 0x001621E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162832, XrefRangeEnd = 162836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048D3 RID: 18643 RVA: 0x00164018 File Offset: 0x00162218
		[CallerCount(0)]
		public unsafe void RefreshIcon()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr_RefreshIcon_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048D4 RID: 18644 RVA: 0x0016404C File Offset: 0x0016224C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 162854, RefRangeEnd = 162857, XrefRangeStart = 162836, XrefRangeEnd = 162854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshTransforms()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr_RefreshTransforms_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048D5 RID: 18645 RVA: 0x00164080 File Offset: 0x00162280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162857, XrefRangeEnd = 162858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NameFieldChange(string newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr_NameFieldChange_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048D6 RID: 18646 RVA: 0x001640C4 File Offset: 0x001622C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162858, XrefRangeEnd = 162869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NameFieldDone(string piss)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(piss);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr_NameFieldDone_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048D7 RID: 18647 RVA: 0x00164108 File Offset: 0x00162308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162869, XrefRangeEnd = 162876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNameAppropriate(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr_IsNameAppropriate_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060048D8 RID: 18648 RVA: 0x00164158 File Offset: 0x00162358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162876, XrefRangeEnd = 162882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr_DeleteButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048D9 RID: 18649 RVA: 0x0016418C File Offset: 0x0016238C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReturnButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr_ReturnButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048DA RID: 18650 RVA: 0x001641C0 File Offset: 0x001623C0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16374, RefRangeEnd = 16592, XrefRangeStart = 16374, XrefRangeEnd = 16592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PresetEditScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048DB RID: 18651 RVA: 0x001641FC File Offset: 0x001623FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162882, XrefRangeEnd = 162887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060048DC RID: 18652 RVA: 0x0002318B File Offset: 0x0002138B
		public PresetEditScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015D9 RID: 5593
		// (get) Token: 0x060048DD RID: 18653 RVA: 0x0016423C File Offset: 0x0016243C
		// (set) Token: 0x060048DE RID: 18654 RVA: 0x00023194 File Offset: 0x00021394
		public unsafe Preset EditedPreset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_EditedPreset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Preset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_EditedPreset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015DA RID: 5594
		// (get) Token: 0x060048DF RID: 18655 RVA: 0x0016426C File Offset: 0x0016246C
		// (set) Token: 0x060048E0 RID: 18656 RVA: 0x000231B3 File Offset: 0x000213B3
		public unsafe RectTransform IconBackgroundRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_IconBackgroundRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_IconBackgroundRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015DB RID: 5595
		// (get) Token: 0x060048E1 RID: 18657 RVA: 0x0016429C File Offset: 0x0016249C
		// (set) Token: 0x060048E2 RID: 18658 RVA: 0x000231D2 File Offset: 0x000213D2
		public unsafe Image IconBackground
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_IconBackground);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_IconBackground), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015DC RID: 5596
		// (get) Token: 0x060048E3 RID: 18659 RVA: 0x001642CC File Offset: 0x001624CC
		// (set) Token: 0x060048E4 RID: 18660 RVA: 0x000231F1 File Offset: 0x000213F1
		public unsafe RectTransform InputFieldRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_InputFieldRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_InputFieldRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015DD RID: 5597
		// (get) Token: 0x060048E5 RID: 18661 RVA: 0x001642FC File Offset: 0x001624FC
		// (set) Token: 0x060048E6 RID: 18662 RVA: 0x00023210 File Offset: 0x00021410
		public unsafe TMP_InputField InputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_InputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_InputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015DE RID: 5598
		// (get) Token: 0x060048E7 RID: 18663 RVA: 0x0016432C File Offset: 0x0016252C
		// (set) Token: 0x060048E8 RID: 18664 RVA: 0x0002322F File Offset: 0x0002142F
		public unsafe RectTransform EditButtonRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_EditButtonRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_EditButtonRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015DF RID: 5599
		// (get) Token: 0x060048E9 RID: 18665 RVA: 0x0016435C File Offset: 0x0016255C
		// (set) Token: 0x060048EA RID: 18666 RVA: 0x0002324E File Offset: 0x0002144E
		public unsafe Button ReturnButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_ReturnButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_ReturnButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015E0 RID: 5600
		// (get) Token: 0x060048EB RID: 18667 RVA: 0x0016438C File Offset: 0x0016258C
		// (set) Token: 0x060048EC RID: 18668 RVA: 0x0002326D File Offset: 0x0002146D
		public unsafe Button DeleteButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_DeleteButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_DeleteButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400311D RID: 12573
		private static readonly IntPtr NativeFieldInfoPtr_EditedPreset;

		// Token: 0x0400311E RID: 12574
		private static readonly IntPtr NativeFieldInfoPtr_IconBackgroundRect;

		// Token: 0x0400311F RID: 12575
		private static readonly IntPtr NativeFieldInfoPtr_IconBackground;

		// Token: 0x04003120 RID: 12576
		private static readonly IntPtr NativeFieldInfoPtr_InputFieldRect;

		// Token: 0x04003121 RID: 12577
		private static readonly IntPtr NativeFieldInfoPtr_InputField;

		// Token: 0x04003122 RID: 12578
		private static readonly IntPtr NativeFieldInfoPtr_EditButtonRect;

		// Token: 0x04003123 RID: 12579
		private static readonly IntPtr NativeFieldInfoPtr_ReturnButton;

		// Token: 0x04003124 RID: 12580
		private static readonly IntPtr NativeFieldInfoPtr_DeleteButton;

		// Token: 0x04003125 RID: 12581
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04003126 RID: 12582
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04003127 RID: 12583
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04003128 RID: 12584
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_Preset_0;

		// Token: 0x04003129 RID: 12585
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x0400312A RID: 12586
		private static readonly IntPtr NativeMethodInfoPtr_RefreshIcon_Private_Void_0;

		// Token: 0x0400312B RID: 12587
		private static readonly IntPtr NativeMethodInfoPtr_RefreshTransforms_Private_Void_0;

		// Token: 0x0400312C RID: 12588
		private static readonly IntPtr NativeMethodInfoPtr_NameFieldChange_Private_Void_String_0;

		// Token: 0x0400312D RID: 12589
		private static readonly IntPtr NativeMethodInfoPtr_NameFieldDone_Private_Void_String_0;

		// Token: 0x0400312E RID: 12590
		private static readonly IntPtr NativeMethodInfoPtr_IsNameAppropriate_Private_Boolean_String_0;

		// Token: 0x0400312F RID: 12591
		private static readonly IntPtr NativeMethodInfoPtr_DeleteButtonClicked_Public_Void_0;

		// Token: 0x04003130 RID: 12592
		private static readonly IntPtr NativeMethodInfoPtr_ReturnButtonClicked_Public_Void_0;

		// Token: 0x04003131 RID: 12593
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003132 RID: 12594
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x0200097A RID: 2426
		[Serializable]
		public class OptionData : Il2CppSystem.Object
		{
			// Token: 0x0600C9D9 RID: 51673 RVA: 0x0030D91C File Offset: 0x0030BB1C
			// Note: this type is marked as 'beforefieldinit'.
			static OptionData()
			{
				Il2CppClassPointerStore<PresetEditScreen.OptionData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, "OptionData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PresetEditScreen.OptionData>.NativeClassPtr);
				PresetEditScreen.OptionData.NativeFieldInfoPtr_OptionEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen.OptionData>.NativeClassPtr, "OptionEntryPrefab");
				PresetEditScreen.OptionData.NativeFieldInfoPtr_OptionSetterScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen.OptionData>.NativeClassPtr, "OptionSetterScreen");
				PresetEditScreen.OptionData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen.OptionData>.NativeClassPtr, 100672331);
			}

			// Token: 0x0600C9DA RID: 51674 RVA: 0x0030D984 File Offset: 0x0030BB84
			[CallerCount(2261)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2275, XrefRangeStart = 14, XrefRangeEnd = 2275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OptionData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PresetEditScreen.OptionData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.OptionData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C9DB RID: 51675 RVA: 0x00062269 File Offset: 0x00060469
			public OptionData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EEC RID: 16108
			// (get) Token: 0x0600C9DC RID: 51676 RVA: 0x0030D9C0 File Offset: 0x0030BBC0
			// (set) Token: 0x0600C9DD RID: 51677 RVA: 0x00062272 File Offset: 0x00060472
			public unsafe GameObject OptionEntryPrefab
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.OptionData.NativeFieldInfoPtr_OptionEntryPrefab);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.OptionData.NativeFieldInfoPtr_OptionEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EED RID: 16109
			// (get) Token: 0x0600C9DE RID: 51678 RVA: 0x0030D9F0 File Offset: 0x0030BBF0
			// (set) Token: 0x0600C9DF RID: 51679 RVA: 0x00062291 File Offset: 0x00060491
			public unsafe OptionSetterScreen OptionSetterScreen
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.OptionData.NativeFieldInfoPtr_OptionSetterScreen);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptionSetterScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.OptionData.NativeFieldInfoPtr_OptionSetterScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008897 RID: 34967
			private static readonly IntPtr NativeFieldInfoPtr_OptionEntryPrefab;

			// Token: 0x04008898 RID: 34968
			private static readonly IntPtr NativeFieldInfoPtr_OptionSetterScreen;

			// Token: 0x04008899 RID: 34969
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200097B RID: 2427
		[ObfuscatedName("ScheduleOne.Management.PresetEditScreen+<<Open>g__Delay|13_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C9E0 RID: 51680 RVA: 0x0030DA20 File Offset: 0x0030BC20
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique()
			{
				Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, "<<Open>g__Delay|13_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr);
				PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>1__state");
				PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>2__current");
				PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>4__this");
				PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100672332);
				PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100672333);
				PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100672334);
				PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100672335);
				PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100672336);
				PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100672337);
			}

			// Token: 0x0600C9E1 RID: 51681 RVA: 0x0030DB00 File Offset: 0x0030BD00
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2331, RefRangeEnd = 2392, XrefRangeStart = 2331, XrefRangeEnd = 2392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C9E2 RID: 51682 RVA: 0x0030DB48 File Offset: 0x0030BD48
			[CallerCount(13599)]
			[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C9E3 RID: 51683 RVA: 0x0030DB7C File Offset: 0x0030BD7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162755, XrefRangeEnd = 162760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003EF1 RID: 16113
			// (get) Token: 0x0600C9E4 RID: 51684 RVA: 0x0030DBB8 File Offset: 0x0030BDB8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C9E5 RID: 51685 RVA: 0x0030DBF8 File Offset: 0x0030BDF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162760, XrefRangeEnd = 162765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003EF2 RID: 16114
			// (get) Token: 0x0600C9E6 RID: 51686 RVA: 0x0030DC2C File Offset: 0x0030BE2C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2432, RefRangeEnd = 2446, XrefRangeStart = 2432, XrefRangeEnd = 2446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C9E7 RID: 51687 RVA: 0x000622B0 File Offset: 0x000604B0
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EEE RID: 16110
			// (get) Token: 0x0600C9E8 RID: 51688 RVA: 0x0030DC6C File Offset: 0x0030BE6C
			// (set) Token: 0x0600C9E9 RID: 51689 RVA: 0x000622B9 File Offset: 0x000604B9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003EEF RID: 16111
			// (get) Token: 0x0600C9EA RID: 51690 RVA: 0x0030DC94 File Offset: 0x0030BE94
			// (set) Token: 0x0600C9EB RID: 51691 RVA: 0x000622D4 File Offset: 0x000604D4
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EF0 RID: 16112
			// (get) Token: 0x0600C9EC RID: 51692 RVA: 0x0030DCC4 File Offset: 0x0030BEC4
			// (set) Token: 0x0600C9ED RID: 51693 RVA: 0x000622F3 File Offset: 0x000604F3
			public unsafe PresetEditScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PresetEditScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400889A RID: 34970
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400889B RID: 34971
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400889C RID: 34972
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400889D RID: 34973
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400889E RID: 34974
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400889F RID: 34975
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040088A0 RID: 34976
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040088A1 RID: 34977
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040088A2 RID: 34978
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
