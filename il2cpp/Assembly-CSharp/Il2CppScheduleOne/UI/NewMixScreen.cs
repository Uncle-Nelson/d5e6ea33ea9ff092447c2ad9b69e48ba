using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Properties;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200064C RID: 1612
	public class NewMixScreen : Singleton<NewMixScreen>
	{
		// Token: 0x06008F00 RID: 36608 RVA: 0x0025226C File Offset: 0x0025046C
		// Note: this type is marked as 'beforefieldinit'.
		static NewMixScreen()
		{
			Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "NewMixScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr);
			NewMixScreen.NativeFieldInfoPtr_MAX_PROPERTIES_DISPLAYED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "MAX_PROPERTIES_DISPLAYED");
			NewMixScreen.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "canvas");
			NewMixScreen.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "Container");
			NewMixScreen.NativeFieldInfoPtr_nameInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "nameInputField");
			NewMixScreen.NativeFieldInfoPtr_mixAlreadyExistsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "mixAlreadyExistsText");
			NewMixScreen.NativeFieldInfoPtr_editIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "editIcon");
			NewMixScreen.NativeFieldInfoPtr_randomizeNameButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "randomizeNameButton");
			NewMixScreen.NativeFieldInfoPtr_confirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "confirmButton");
			NewMixScreen.NativeFieldInfoPtr_PropertiesLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "PropertiesLabel");
			NewMixScreen.NativeFieldInfoPtr_MarketValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "MarketValueLabel");
			NewMixScreen.NativeFieldInfoPtr_Sound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "Sound");
			NewMixScreen.NativeFieldInfoPtr_attributeEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "attributeEntryPrefab");
			NewMixScreen.NativeFieldInfoPtr_name1Library = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "name1Library");
			NewMixScreen.NativeFieldInfoPtr_name2Library = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "name2Library");
			NewMixScreen.NativeFieldInfoPtr_onMixNamed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "onMixNamed");
			NewMixScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681042);
			NewMixScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681043);
			NewMixScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681044);
			NewMixScreen.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681045);
			NewMixScreen.NativeMethodInfoPtr_Open_Public_Void_List_1_Property_EDrugType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681046);
			NewMixScreen.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681047);
			NewMixScreen.NativeMethodInfoPtr_RandomizeButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681048);
			NewMixScreen.NativeMethodInfoPtr_ConfirmButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681049);
			NewMixScreen.NativeMethodInfoPtr_GenerateUniqueName_Public_String_Il2CppReferenceArray_1_Property_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681050);
			NewMixScreen.NativeMethodInfoPtr_RefreshNameButtons_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681051);
			NewMixScreen.NativeMethodInfoPtr_OnNameValueChanged_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681052);
			NewMixScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681053);
		}

		// Token: 0x17002BC7 RID: 11207
		// (get) Token: 0x06008F01 RID: 36609 RVA: 0x002524B8 File Offset: 0x002506B8
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 259909, RefRangeEnd = 259910, XrefRangeStart = 259907, XrefRangeEnd = 259909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06008F02 RID: 36610 RVA: 0x002524F4 File Offset: 0x002506F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259910, XrefRangeEnd = 259936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NewMixScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F03 RID: 36611 RVA: 0x00252530 File Offset: 0x00250730
		[CallerCount(13599)]
		[CachedScanResults(RefRangeStart = 2451, RefRangeEnd = 16050, XrefRangeStart = 2451, XrefRangeEnd = 16050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F04 RID: 36612 RVA: 0x00252574 File Offset: 0x00250774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259936, XrefRangeEnd = 259952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NewMixScreen.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F05 RID: 36613 RVA: 0x002525B0 File Offset: 0x002507B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 260009, RefRangeEnd = 260011, XrefRangeStart = 259952, XrefRangeEnd = 260009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(List<Property> properties, EDrugType drugType, float productMarketValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drugType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref productMarketValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_Open_Public_Void_List_1_Property_EDrugType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F06 RID: 36614 RVA: 0x00252610 File Offset: 0x00250810
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 260021, RefRangeEnd = 260022, XrefRangeStart = 260011, XrefRangeEnd = 260021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F07 RID: 36615 RVA: 0x00252644 File Offset: 0x00250844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260022, XrefRangeEnd = 260025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_RandomizeButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F08 RID: 36616 RVA: 0x00252678 File Offset: 0x00250878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260025, XrefRangeEnd = 260037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfirmButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_ConfirmButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F09 RID: 36617 RVA: 0x002526AC File Offset: 0x002508AC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 260072, RefRangeEnd = 260078, XrefRangeStart = 260037, XrefRangeEnd = 260072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GenerateUniqueName(Il2CppReferenceArray<Property> properties = null, EDrugType drugType = EDrugType.Marijuana)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drugType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_GenerateUniqueName_Public_String_Il2CppReferenceArray_1_Property_EDrugType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06008F0A RID: 36618 RVA: 0x00252704 File Offset: 0x00250904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260078, XrefRangeEnd = 260088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshNameButtons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_RefreshNameButtons_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F0B RID: 36619 RVA: 0x00252738 File Offset: 0x00250938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260088, XrefRangeEnd = 260118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnNameValueChanged(string newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_OnNameValueChanged_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F0C RID: 36620 RVA: 0x0025277C File Offset: 0x0025097C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260118, XrefRangeEnd = 260133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewMixScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F0D RID: 36621 RVA: 0x00044DFB File Offset: 0x00042FFB
		public NewMixScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002BB8 RID: 11192
		// (get) Token: 0x06008F0E RID: 36622 RVA: 0x002527B8 File Offset: 0x002509B8
		// (set) Token: 0x06008F0F RID: 36623 RVA: 0x00044E04 File Offset: 0x00043004
		public unsafe static int MAX_PROPERTIES_DISPLAYED
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(NewMixScreen.NativeFieldInfoPtr_MAX_PROPERTIES_DISPLAYED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NewMixScreen.NativeFieldInfoPtr_MAX_PROPERTIES_DISPLAYED, (void*)(&value));
			}
		}

		// Token: 0x17002BB9 RID: 11193
		// (get) Token: 0x06008F10 RID: 36624 RVA: 0x002527D4 File Offset: 0x002509D4
		// (set) Token: 0x06008F11 RID: 36625 RVA: 0x00044E12 File Offset: 0x00043012
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BBA RID: 11194
		// (get) Token: 0x06008F12 RID: 36626 RVA: 0x00252804 File Offset: 0x00250A04
		// (set) Token: 0x06008F13 RID: 36627 RVA: 0x00044E31 File Offset: 0x00043031
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BBB RID: 11195
		// (get) Token: 0x06008F14 RID: 36628 RVA: 0x00252834 File Offset: 0x00250A34
		// (set) Token: 0x06008F15 RID: 36629 RVA: 0x00044E50 File Offset: 0x00043050
		public unsafe TMP_InputField nameInputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_nameInputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_nameInputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BBC RID: 11196
		// (get) Token: 0x06008F16 RID: 36630 RVA: 0x00252864 File Offset: 0x00250A64
		// (set) Token: 0x06008F17 RID: 36631 RVA: 0x00044E6F File Offset: 0x0004306F
		public unsafe GameObject mixAlreadyExistsText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_mixAlreadyExistsText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_mixAlreadyExistsText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BBD RID: 11197
		// (get) Token: 0x06008F18 RID: 36632 RVA: 0x00252894 File Offset: 0x00250A94
		// (set) Token: 0x06008F19 RID: 36633 RVA: 0x00044E8E File Offset: 0x0004308E
		public unsafe RectTransform editIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_editIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_editIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BBE RID: 11198
		// (get) Token: 0x06008F1A RID: 36634 RVA: 0x002528C4 File Offset: 0x00250AC4
		// (set) Token: 0x06008F1B RID: 36635 RVA: 0x00044EAD File Offset: 0x000430AD
		public unsafe Button randomizeNameButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_randomizeNameButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_randomizeNameButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BBF RID: 11199
		// (get) Token: 0x06008F1C RID: 36636 RVA: 0x002528F4 File Offset: 0x00250AF4
		// (set) Token: 0x06008F1D RID: 36637 RVA: 0x00044ECC File Offset: 0x000430CC
		public unsafe Button confirmButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_confirmButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_confirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BC0 RID: 11200
		// (get) Token: 0x06008F1E RID: 36638 RVA: 0x00252924 File Offset: 0x00250B24
		// (set) Token: 0x06008F1F RID: 36639 RVA: 0x00044EEB File Offset: 0x000430EB
		public unsafe TextMeshProUGUI PropertiesLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_PropertiesLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_PropertiesLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BC1 RID: 11201
		// (get) Token: 0x06008F20 RID: 36640 RVA: 0x00252954 File Offset: 0x00250B54
		// (set) Token: 0x06008F21 RID: 36641 RVA: 0x00044F0A File Offset: 0x0004310A
		public unsafe TextMeshProUGUI MarketValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_MarketValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_MarketValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BC2 RID: 11202
		// (get) Token: 0x06008F22 RID: 36642 RVA: 0x00252984 File Offset: 0x00250B84
		// (set) Token: 0x06008F23 RID: 36643 RVA: 0x00044F29 File Offset: 0x00043129
		public unsafe AudioSourceController Sound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_Sound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_Sound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BC3 RID: 11203
		// (get) Token: 0x06008F24 RID: 36644 RVA: 0x002529B4 File Offset: 0x00250BB4
		// (set) Token: 0x06008F25 RID: 36645 RVA: 0x00044F48 File Offset: 0x00043148
		public unsafe GameObject attributeEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_attributeEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_attributeEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BC4 RID: 11204
		// (get) Token: 0x06008F26 RID: 36646 RVA: 0x002529E4 File Offset: 0x00250BE4
		// (set) Token: 0x06008F27 RID: 36647 RVA: 0x00044F67 File Offset: 0x00043167
		public unsafe List<string> name1Library
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_name1Library);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_name1Library), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BC5 RID: 11205
		// (get) Token: 0x06008F28 RID: 36648 RVA: 0x00252A14 File Offset: 0x00250C14
		// (set) Token: 0x06008F29 RID: 36649 RVA: 0x00044F86 File Offset: 0x00043186
		public unsafe List<string> name2Library
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_name2Library);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_name2Library), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BC6 RID: 11206
		// (get) Token: 0x06008F2A RID: 36650 RVA: 0x00252A44 File Offset: 0x00250C44
		// (set) Token: 0x06008F2B RID: 36651 RVA: 0x00044FA5 File Offset: 0x000431A5
		public unsafe Action<string> onMixNamed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_onMixNamed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_onMixNamed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040060C5 RID: 24773
		private static readonly IntPtr NativeFieldInfoPtr_MAX_PROPERTIES_DISPLAYED;

		// Token: 0x040060C6 RID: 24774
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x040060C7 RID: 24775
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040060C8 RID: 24776
		private static readonly IntPtr NativeFieldInfoPtr_nameInputField;

		// Token: 0x040060C9 RID: 24777
		private static readonly IntPtr NativeFieldInfoPtr_mixAlreadyExistsText;

		// Token: 0x040060CA RID: 24778
		private static readonly IntPtr NativeFieldInfoPtr_editIcon;

		// Token: 0x040060CB RID: 24779
		private static readonly IntPtr NativeFieldInfoPtr_randomizeNameButton;

		// Token: 0x040060CC RID: 24780
		private static readonly IntPtr NativeFieldInfoPtr_confirmButton;

		// Token: 0x040060CD RID: 24781
		private static readonly IntPtr NativeFieldInfoPtr_PropertiesLabel;

		// Token: 0x040060CE RID: 24782
		private static readonly IntPtr NativeFieldInfoPtr_MarketValueLabel;

		// Token: 0x040060CF RID: 24783
		private static readonly IntPtr NativeFieldInfoPtr_Sound;

		// Token: 0x040060D0 RID: 24784
		private static readonly IntPtr NativeFieldInfoPtr_attributeEntryPrefab;

		// Token: 0x040060D1 RID: 24785
		private static readonly IntPtr NativeFieldInfoPtr_name1Library;

		// Token: 0x040060D2 RID: 24786
		private static readonly IntPtr NativeFieldInfoPtr_name2Library;

		// Token: 0x040060D3 RID: 24787
		private static readonly IntPtr NativeFieldInfoPtr_onMixNamed;

		// Token: 0x040060D4 RID: 24788
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040060D5 RID: 24789
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040060D6 RID: 24790
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x040060D7 RID: 24791
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040060D8 RID: 24792
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_List_1_Property_EDrugType_Single_0;

		// Token: 0x040060D9 RID: 24793
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x040060DA RID: 24794
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeButtonClicked_Public_Void_0;

		// Token: 0x040060DB RID: 24795
		private static readonly IntPtr NativeMethodInfoPtr_ConfirmButtonClicked_Public_Void_0;

		// Token: 0x040060DC RID: 24796
		private static readonly IntPtr NativeMethodInfoPtr_GenerateUniqueName_Public_String_Il2CppReferenceArray_1_Property_EDrugType_0;

		// Token: 0x040060DD RID: 24797
		private static readonly IntPtr NativeMethodInfoPtr_RefreshNameButtons_Protected_Void_0;

		// Token: 0x040060DE RID: 24798
		private static readonly IntPtr NativeMethodInfoPtr_OnNameValueChanged_Public_Void_String_0;

		// Token: 0x040060DF RID: 24799
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
